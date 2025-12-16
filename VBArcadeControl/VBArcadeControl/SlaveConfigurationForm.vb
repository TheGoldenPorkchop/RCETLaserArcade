Public Class SlaveConfigurationForm
    Private WithEvents SlaveCOM As UARTController
    Private CurrentPlayerColors As New PlayerColors

    Public Sub New(slave As UARTController)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        SlaveCOM = slave
    End Sub

    Private Sub UpdatePlayerColor()
        PlayerOneColorPictureBox.BackColor = System.Drawing.Color.FromArgb(CurrentPlayerColors.PlayerOneRed, CurrentPlayerColors.PlayerOneGreen, CurrentPlayerColors.PlayerOneBlue)
        PlayerTwoColorPictureBox.BackColor = System.Drawing.Color.FromArgb(CurrentPlayerColors.PlayerTwoRed, CurrentPlayerColors.PlayerTwoGreen, CurrentPlayerColors.PlayerTwoBlue)
        PlayerThreeColorPictureBox.BackColor = System.Drawing.Color.FromArgb(CurrentPlayerColors.PlayerThreeRed, CurrentPlayerColors.PlayerThreeGreen, CurrentPlayerColors.PlayerThreeBlue)
        PlayerFourColorPictureBox.BackColor = System.Drawing.Color.FromArgb(CurrentPlayerColors.PlayerFourRed, CurrentPlayerColors.PlayerFourGreen, CurrentPlayerColors.PlayerFourBlue)

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim i2CAddress As Integer
        Dim ledNumber As Integer

        Try
            i2CAddress = CInt(I2CAddressTextBox.Text)
            If i2CAddress > 127 Or i2CAddress < 1 Then
                MsgBox("I2C address should be a whole number between 1 and 127")
                Exit Sub
            Else
                SlaveCOM.SendI2CSlaveAddress(i2CAddress * 2)
                System.Threading.Thread.Sleep(300)
            End If
        Catch ex As Exception
            MsgBox("I2C address should be a whole number between 1 and 127")
            Exit Sub
        End Try

        Try
            ledNumber = CInt(LEDNumberTextBox.Text)
            If ledNumber > 255 Or ledNumber < 1 Then
                MsgBox("LED Number should be a whole number between 1 and 255")
                Exit Sub
            Else
                SlaveCOM.SendUpdateLEDs(ledNumber)
                System.Threading.Thread.Sleep(300)
            End If
        Catch ex As Exception
            MsgBox("LED Number should be a whole number between 1 and 255")
            Exit Sub
        End Try

        SlaveCOM.SendUpdatePlayerColor(1, CurrentPlayerColors.PlayerOneRed, CurrentPlayerColors.PlayerOneGreen, CurrentPlayerColors.PlayerOneBlue)
        System.Threading.Thread.Sleep(300)
        SlaveCOM.SendUpdatePlayerColor(2, CurrentPlayerColors.PlayerTwoRed, CurrentPlayerColors.PlayerTwoGreen, CurrentPlayerColors.PlayerTwoBlue)
        System.Threading.Thread.Sleep(300)
        SlaveCOM.SendUpdatePlayerColor(3, CurrentPlayerColors.PlayerThreeRed, CurrentPlayerColors.PlayerThreeGreen, CurrentPlayerColors.PlayerThreeBlue)
        System.Threading.Thread.Sleep(300)
        SlaveCOM.SendUpdatePlayerColor(4, CurrentPlayerColors.PlayerFourRed, CurrentPlayerColors.PlayerFourGreen, CurrentPlayerColors.PlayerFourBlue)
        System.Threading.Thread.Sleep(300)

        SlaveCOM.SendCalibratePositions(129, (Servo1ENTrackBar.Value + 1000) \ 255, (Servo1ENTrackBar.Value + 1000) Mod 255)
        System.Threading.Thread.Sleep(300)
        SlaveCOM.SendCalibratePositions(128, (Servo1DISTrackBar.Value + 1000) \ 255, (Servo1DISTrackBar.Value + 1000) Mod 255)
        System.Threading.Thread.Sleep(300)

        SlaveCOM.SendCalibratePositions(65, (Servo2ENTrackBar.Value + 1000) \ 255, (Servo2ENTrackBar.Value + 1000) Mod 255)
        System.Threading.Thread.Sleep(300)
        SlaveCOM.SendCalibratePositions(64, (Servo2DISTrackBar.Value + 1000) \ 255, (Servo2DISTrackBar.Value + 1000) Mod 255)
        System.Threading.Thread.Sleep(300)

        SlaveCOM.SendCalibratePositions(33, (Servo3ENTrackBar.Value + 1000) \ 255, (Servo3ENTrackBar.Value + 1000) Mod 255)
        System.Threading.Thread.Sleep(300)
        SlaveCOM.SendCalibratePositions(32, (Servo3DISTrackBar.Value + 1000) \ 255, (Servo3DISTrackBar.Value + 1000) Mod 255)
        System.Threading.Thread.Sleep(300)

        MsgBox("Slave Configuration Saved")
        Me.Close()

    End Sub
    Private Sub PlayerColorButton_Click(sender As Object, e As EventArgs) Handles PlayerColorButton.Click
        If MsgBox($"Are you sure you want to change colors?{vbNewLine}This action requires reconfiguration of all components in the Laser Arcade.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox("Open change color screen")
        End If
    End Sub

    Private Sub SlaveConfigurationForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdatePlayerColor()
    End Sub

    Private Sub SlaveConfigurationForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        StartupForm.Show()
    End Sub
End Class