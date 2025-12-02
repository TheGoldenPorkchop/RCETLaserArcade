'TO DO LIST
'CHANGE BAUD RATE TO 2400
'MOVE TO UART CLASS
'SETUP CONNECT/VERIFICATION PROCESS
'WRITE I2C ENABLE
'WRITE I2C DISABLE
'READ I2C DATA
'READ SETTINGS
'UPDATE PLAYER COLOR
'CALLIBRATE POSITIONS

'→
'===============================
'UARTController Class
'
'This class is responsible ONLY for:
'  - Creating and configuring the SerialPort object
'  - Opening/closing the port
'  - Sending UART commands to the Laser Arcade system
'  - Receiving data and raising events
'
'This class does NOT contain game logic or score tracking.
'This class acts as a communication "driver" for the hardware
'===============================
Public Class UARTController

    '==============FIELDS/STATE===============

    'Sets up Class-Level Serial Port Object
    Private serialPortJimmy As System.IO.Ports.SerialPort

    'Will be used to know what device is connected
    Public Enum ConnectedDeviceType
        None
        Master
        Slave
        Blaster
    End Enum

    'Creates a field to store the device type (None, Master, Slave, Blaster)
    Private _deviceType As ConnectedDeviceType = ConnectedDeviceType.None
    Public ReadOnly Property DeviceType As ConnectedDeviceType
        Get
            Return _deviceType
        End Get
    End Property

    'Flag to remember if the device has been verified
    Private _deviceVerified As Boolean = False
    Public ReadOnly Property DeviceVerified As Boolean
        Get
            Return _deviceVerified
        End Get
    End Property

    'Custom events
    Public Event DeviceVerificationFailed(reason As String)
    Public Event ConnectOpen()
    Public Event ConnectClose()

    '==============CONSTRUCTOR===============
    'This will run when someone creates a new UARTController
    'Instantiate the SerialPort object and set all default settings
    Public Sub New()
        serialPortJimmy = New IO.Ports.SerialPort()
        SetupSerialPort()
    End Sub

    'Config the serial port settings
    Sub SetupSerialPort()
        Me.serialPortJimmy.BaudRate = 2400
        Me.serialPortJimmy.DataBits = 8
        Me.serialPortJimmy.Parity = IO.Ports.Parity.None
        Me.serialPortJimmy.StopBits = IO.Ports.StopBits.One
    End Sub

    '==============CONNECT METHODS===============
    'Process:
    'Sets up the COMPORT name (ex. "COM3")
    'Opens the serial port
    'After open, sends the 'Device Verification command' "$V" PG.46
    'After send, wait for the response "$LA" (4 BYTES)
    'If the response Is valid → mark device As verified
    'If anything goes wrong → close port and raise DeviceVerificationFailed event


    Public Function Connect(portName As String) As Boolean
        'Reset states each time a connection is attempted
        _deviceVerified = False
        _deviceType = ConnectedDeviceType.None

        'Assure Serial Port exists and is configured
        If serialPortJimmy Is Nothing Then
            serialPortJimmy = New IO.Ports.SerialPort()
            SetupSerialPort()
        End If

        Try
            'If the serial port was open before, close it cleanly
            If serialPortJimmy.IsOpen Then
                serialPortJimmy.Close()
                RaiseEvent ConnectClose()
            End If

            'Set COM port name (e.g., "COM3")
            serialPortJimmy.PortName = portName

            'Set timeouts so we don't block forever during verification
            serialPortJimmy.ReadTimeout = 500   'ms – adjust as needed
            serialPortJimmy.WriteTimeout = 500  'ms – adjust as needed

            'Open the serial port
            serialPortJimmy.Open()
            RaiseEvent ConnectOpen()

            '-----------------------------
            ' Send Device Verification: "$V"
            '-----------------------------
            'This will transmit 2 bytes: "$" & "V"
            serialPortJimmy.Write("$V")

            '-----------------------------
            ' Read 4-byte verification response
            ' Expected patterns:
            '   $ L A B  -> Blaster
            '   $ L A M  -> Master
            '   $ L A S  -> Slave
            '-----------------------------
            Dim response(3) As Byte
            Dim bytesRead As Integer = 0

            While bytesRead < 4
                Dim b As Integer

                Try
                    b = serialPortJimmy.ReadByte() 'blocks until byte or timeout
                Catch ex As TimeoutException
                    Exit While 'stop trying if we timed out
                End Try

                If b = -1 Then
                    Exit While 'no more data
                End If

                response(bytesRead) = CByte(b)
                bytesRead += 1
            End While

            'If we did not get exactly 4 bytes, verification failed
            If bytesRead <> 4 Then
                Throw New ApplicationException("Incomplete verification response.")
            End If

            'Check the header "$ L A"
            If response(0) <> Asc("$"c) OrElse
               response(1) <> Asc("L"c) OrElse
               response(2) <> Asc("A"c) Then

                Throw New ApplicationException("Invalid verification header.")
            End If

            'Determine device type based on 4th byte (B/M/S)
            Dim typeChar As Char = Chr(response(3))

            Select Case typeChar
                Case "B"c
                    _deviceType = ConnectedDeviceType.Blaster
                Case "M"c
                    _deviceType = ConnectedDeviceType.Master
                Case "S"c
                    _deviceType = ConnectedDeviceType.Slave
                Case Else
                    Throw New ApplicationException("Unknown device type character: " & typeChar)
            End Select

            'If we reach here, verification was successful
            _deviceVerified = True
            Return True

        Catch ex As Exception
            'Anything goes wrong → clean up and raise failure event
            _deviceVerified = False
            _deviceType = ConnectedDeviceType.None

            If serialPortJimmy IsNot Nothing AndAlso serialPortJimmy.IsOpen Then
                serialPortJimmy.Close()
                RaiseEvent ConnectClose()
            End If

            RaiseEvent DeviceVerificationFailed(ex.Message)
            Return False
        End Try
    End Function

End Class
