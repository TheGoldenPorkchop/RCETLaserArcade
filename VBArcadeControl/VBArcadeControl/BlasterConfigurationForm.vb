Public Class BlasterConfigurationForm
    Private WithEvents BlasterCOM As UARTController
    Private CurrentPlayerColors As New PlayerColors

    Private Sub UpdatePlayerColor()
        Select Case PlayerNumberComboBox.Text
            Case "1"
                PlayerColorPictureBox.BackColor = System.Drawing.Color.FromArgb(CurrentPlayerColors.PlayerOneRed, CurrentPlayerColors.PlayerOneGreen, CurrentPlayerColors.PlayerOneBlue)
            Case "2"
                PlayerColorPictureBox.BackColor = System.Drawing.Color.FromArgb(CurrentPlayerColors.PlayerTwoRed, CurrentPlayerColors.PlayerTwoGreen, CurrentPlayerColors.PlayerTwoBlue)
            Case "3"
                PlayerColorPictureBox.BackColor = System.Drawing.Color.FromArgb(CurrentPlayerColors.PlayerThreeRed, CurrentPlayerColors.PlayerThreeGreen, CurrentPlayerColors.PlayerThreeBlue)
            Case "4"
                PlayerColorPictureBox.BackColor = System.Drawing.Color.FromArgb(CurrentPlayerColors.PlayerFourRed, CurrentPlayerColors.PlayerFourGreen, CurrentPlayerColors.PlayerFourBlue)
        End Select

    End Sub

    Public Sub New(blaster As UARTController)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        BlasterCOM = blaster
    End Sub

    Private Sub BlasterConfigurationForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        StartupForm.Show()
    End Sub

    Private Sub PlayerColorButton_Click(sender As Object, e As EventArgs) Handles PlayerColorButton.Click
        If MsgBox($"Are you sure you want to change colors?{vbNewLine}This action requires reconfiguration of all components in the Laser Arcade.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox("Open change color screen")
        End If
    End Sub

    Private Sub PlayerNumberComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlayerNumberComboBox.SelectedIndexChanged
        UpdatePlayerColor()
    End Sub

    Private Sub PlayerNumberComboBox_Click(sender As Object, e As EventArgs) Handles PlayerNumberComboBox.Click
        PlayerNumberComboBox.DroppedDown = True
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Select Case PlayerNumberComboBox.Text
            Case "1"
                BlasterCOM.SendUpdatePlayerColor(1, CurrentPlayerColors.PlayerOneRed, CurrentPlayerColors.PlayerOneGreen, CurrentPlayerColors.PlayerOneBlue)
            Case "2"
                BlasterCOM.SendUpdatePlayerColor(2, CurrentPlayerColors.PlayerTwoRed, CurrentPlayerColors.PlayerTwoGreen, CurrentPlayerColors.PlayerTwoBlue)
            Case "3"
                BlasterCOM.SendUpdatePlayerColor(3, CurrentPlayerColors.PlayerThreeRed, CurrentPlayerColors.PlayerThreeGreen, CurrentPlayerColors.PlayerThreeBlue)
            Case "4"
                BlasterCOM.SendUpdatePlayerColor(4, CurrentPlayerColors.PlayerFourRed, CurrentPlayerColors.PlayerFourGreen, CurrentPlayerColors.PlayerFourBlue)
        End Select
        MsgBox("Blaster Configuration Saved")
        Me.Close()
    End Sub
End Class