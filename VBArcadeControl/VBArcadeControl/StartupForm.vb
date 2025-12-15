Public Class StartupForm
    Private WithEvents selectedDevice As New UARTController

    ''' <summary>
    ''' update the available COM ports in the selection dropdown
    ''' </summary>
    Sub UpdateAvailableCOM()
        If Not COMPortComboBox.DroppedDown Then
            COMPortComboBox.Items.Clear()   'clear the Combobox items
            For Each sp As String In My.Computer.Ports.SerialPortNames 'add all available serial ports to the combo box
                COMPortComboBox.Items.Add(sp)
            Next
        End If
    End Sub

    Private Sub StartupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateAvailableCOM()
        COMRefreshTimer.Start()
    End Sub

    Private Sub COMPortComboBox_Click(sender As Object, e As EventArgs) Handles COMPortComboBox.Click
        COMPortComboBox.DroppedDown = True
    End Sub

    Private Sub COMPortComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles COMPortComboBox.SelectedIndexChanged
        If (selectedDevice.Connect(COMPortComboBox.Text)) And selectedDevice.DeviceVerified Then
            'selected device Is a valid Laser Arcade device
            Select Case selectedDevice.DeviceType
                Case UARTController.ConnectedDeviceType.Master
                    If MsgBox($"Successfully connected to the Laser Arcade Master at {COMPortComboBox.Text}.{vbNewLine}Would you like to pick a game?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        MsgBox("GOTO Game Picker")
                    End If
                Case UARTController.ConnectedDeviceType.Slave
                    If MsgBox($"Successfully connected to the Laser Arcade Slave at {COMPortComboBox.Text}.{vbNewLine}Would you like to configure the slave?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        MsgBox("GOTO Slave Configuration Form")
                    End If
                Case UARTController.ConnectedDeviceType.Blaster
                    If MsgBox($"Successfully connected to the Laser Arcade Blaster at {COMPortComboBox.Text}.{vbNewLine}Would you like to configure the blaster?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        MsgBox("GOTO Blaster Configuration Form")
                    End If
            End Select
        End If
    End Sub

    Private Sub selectedDevice_DeviceVerificationFailed(reason As String) Handles selectedDevice.DeviceVerificationFailed
        MsgBox($"The selected device at {COMPortComboBox.Text} is not a Laser Arcade device.")
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        AboutForm.Show()
    End Sub

    Private Sub COMRefreshTimer_Tick(sender As Object, e As EventArgs) Handles COMRefreshTimer.Tick
        UpdateAvailableCOM()
    End Sub
End Class