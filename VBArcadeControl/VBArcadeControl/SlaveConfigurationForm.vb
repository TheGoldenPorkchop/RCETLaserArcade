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