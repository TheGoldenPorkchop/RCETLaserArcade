Public Class GamePicker

    Private WithEvents gameCOM As UARTController
    Public Sub New(game As UARTController)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        gameCOM = game
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim testTargetForm As New TestTargetStatus(gameCOM)
        testTargetForm.Show()
        Me.Hide()

    End Sub

    Private Sub TicTacToeButton_Click(sender As Object, e As EventArgs) Handles TicTacToeButton.Click
        Dim ticTacToeTargetForm As New TicTacToeGame(gameCOM)
        ticTacToeTargetForm.Show()
        'TicTacToeGame.Show()
        Me.Hide()
    End Sub
End Class