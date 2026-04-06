Public Class TicTacToeGame
    Private WithEvents ticTacToeCOM As UARTController
    Public Sub New(ticTacToeTarget As UARTController)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        ticTacToeCOM = ticTacToeTarget
    End Sub

    Dim TicTacToeTargets(9) As Byte

    Private Sub ticTacToeCOM_TargetHit(address As Byte, player As Byte) Handles ticTacToeCOM.TargetHit
        If Me.InvokeRequired Then
            Me.Invoke(Sub() ReadTicTacToeTarget(address, player))
        Else
            ReadTicTacToeTarget(address, player)
        End If
    End Sub

    Private Sub ticTacToeCOM_ParseFailed(reason As String) Handles ticTacToeCOM.ParseFailed
        If Me.InvokeRequired Then
            Me.Invoke(Sub() UpdateParseFailedUI(reason))
        Else
            UpdateParseFailedUI(reason)
        End If
    End Sub
    Private Sub UpdateParseFailedUI(reason As String)
        'ResultLabel.Text = "Parse Failed: " & reason
    End Sub
    Private Sub ticTacToeCOM_CommandAcknowledged(address As Byte) Handles ticTacToeCOM.CommandAcknowledged
        If Me.InvokeRequired Then
            'Me.Invoke(Sub() ResultLabel.Text = "Command acknowledged by target " & (address \ 2).ToString())
        Else
            'ResultLabel.Text = "Command acknowledged by target " & address.ToString()
        End If
    End Sub

    Sub ReadTicTacToeTarget(address As Byte, player As Byte)
        Dim validPlayerTurn As Integer
        Dim preCount As Integer
        Dim postCount As Integer

        If PlayerTurnTextBox.Text = "1" Then
            validPlayerTurn = 1
        Else
            validPlayerTurn = 2
        End If

        If player = validPlayerTurn Then
            TicTacToeTargets(address \ 2) = CInt(PlayerTurnTextBox.Text)

            Select Case address \ 2
                Case 1
                    PictureBox1.Image = TurnPictureBox.Image
                Case 2
                    PictureBox2.Image = TurnPictureBox.Image
                Case 3
                    PictureBox3.Image = TurnPictureBox.Image
                Case 4
                    PictureBox4.Image = TurnPictureBox.Image
                Case 5
                    PictureBox5.Image = TurnPictureBox.Image
                Case 6
                    PictureBox6.Image = TurnPictureBox.Image
                Case 7
                    PictureBox7.Image = TurnPictureBox.Image
                Case 8
                    PictureBox8.Image = TurnPictureBox.Image
                Case 9
                    PictureBox9.Image = TurnPictureBox.Image
            End Select

            preCount = CInt(TurnsPassedTextBox.Text)
            postCount = Counter(preCount)
            TurnsPassedTextBox.Text = postCount
            WinCheck()
        Else
            ConstantReadTimer.Stop()
            wrongTurnTarget = address
            WrongPlayerTimer.Start()
        End If
        'MsgBox("We hit the blaster")
    End Sub
    Dim wrongTurnTarget As Integer

    Sub Reset()
        PictureBox1.Image = My.Resources.NoIcon
        PictureBox2.Image = My.Resources.NoIcon
        PictureBox3.Image = My.Resources.NoIcon
        PictureBox4.Image = My.Resources.NoIcon
        PictureBox5.Image = My.Resources.NoIcon
        PictureBox6.Image = My.Resources.NoIcon
        PictureBox7.Image = My.Resources.NoIcon
        PictureBox8.Image = My.Resources.NoIcon
        PictureBox9.Image = My.Resources.NoIcon

        PictureBox1.Enabled = False
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        PictureBox5.Enabled = False
        PictureBox6.Enabled = False
        PictureBox7.Enabled = False
        PictureBox8.Enabled = False
        PictureBox9.Enabled = False

        TicTacToeTargets(0) = 0
        TicTacToeTargets(1) = 0
        TicTacToeTargets(2) = 0
        TicTacToeTargets(3) = 0
        TicTacToeTargets(4) = 0
        TicTacToeTargets(5) = 0
        TicTacToeTargets(6) = 0
        TicTacToeTargets(7) = 0
        TicTacToeTargets(8) = 0
        TicTacToeTargets(9) = 0

        ResetButton.Enabled = False
        StartButton.Enabled = True

        PlayerTurnTextBox.Text = "1"
        TurnsPassedTextBox.Text = "0"
        TurnPictureBox.Image = My.Resources.BIcon
        WinnerPictureBox.Image = My.Resources.NoIcon

    End Sub
    Function Counter(currentCount As Integer) As Integer
        If currentCount > 8 Then
            currentCount = 1
        Else
            currentCount = currentCount + 1
        End If

        If PlayerTurnTextBox.Text = "1" Then
            PlayerTurnTextBox.Text = "2"
            TurnPictureBox.Image = My.Resources.PIcon
        Else
            PlayerTurnTextBox.Text = "1"
            TurnPictureBox.Image = My.Resources.BIcon
        End If

        Return currentCount
    End Function


    Sub WinCheck()
        'Player 1
        If TicTacToeTargets(1) = 1 And TicTacToeTargets(2) = 1 And TicTacToeTargets(3) = 1 Then
            WinnerPictureBox.Image = My.Resources.BIcon
            MsgBox("P1 Wins")
            EndGame()
        End If
        If TicTacToeTargets(4) = 1 And TicTacToeTargets(5) = 1 And TicTacToeTargets(6) = 1 Then
            WinnerPictureBox.Image = My.Resources.BIcon
            MsgBox("P1 Wins")
            EndGame()
        End If
        If TicTacToeTargets(7) = 1 And TicTacToeTargets(8) = 1 And TicTacToeTargets(9) = 1 Then
            WinnerPictureBox.Image = My.Resources.BIcon
            MsgBox("P1 Wins")
            EndGame()
        End If
        If TicTacToeTargets(1) = 1 And TicTacToeTargets(4) = 1 And TicTacToeTargets(7) = 1 Then
            WinnerPictureBox.Image = My.Resources.BIcon
            MsgBox("P1 Wins")
            EndGame()
        End If
        If TicTacToeTargets(2) = 1 And TicTacToeTargets(5) = 1 And TicTacToeTargets(8) = 1 Then
            WinnerPictureBox.Image = My.Resources.BIcon '???
            MsgBox("P1 Wins")
            EndGame()
        End If
        If TicTacToeTargets(3) = 1 And TicTacToeTargets(6) = 1 And TicTacToeTargets(9) = 1 Then
            WinnerPictureBox.Image = My.Resources.BIcon
            MsgBox("P1 Wins")
            EndGame()
        End If
        If TicTacToeTargets(1) = 1 And TicTacToeTargets(5) = 1 And TicTacToeTargets(9) = 1 Then
            WinnerPictureBox.Image = My.Resources.BIcon
            MsgBox("P1 Wins")
            EndGame()
        End If
        If TicTacToeTargets(3) = 1 And TicTacToeTargets(5) = 1 And TicTacToeTargets(7) = 1 Then
            WinnerPictureBox.Image = My.Resources.BIcon
            MsgBox("P1 Wins")
            EndGame()
        End If

        'player 2
        If TicTacToeTargets(1) = 2 And TicTacToeTargets(2) = 2 And TicTacToeTargets(3) = 2 Then
            WinnerPictureBox.Image = My.Resources.PIcon
            MsgBox("P2 Wins")
            EndGame()
        End If
        If TicTacToeTargets(4) = 2 And TicTacToeTargets(5) = 2 And TicTacToeTargets(6) = 2 Then
            WinnerPictureBox.Image = My.Resources.PIcon
            MsgBox("P2 Wins")
            EndGame()
        End If
        If TicTacToeTargets(7) = 2 And TicTacToeTargets(8) = 2 And TicTacToeTargets(9) = 2 Then
            WinnerPictureBox.Image = My.Resources.PIcon
            MsgBox("P2 Wins")
            EndGame()
        End If
        If TicTacToeTargets(1) = 2 And TicTacToeTargets(4) = 2 And TicTacToeTargets(7) = 2 Then
            WinnerPictureBox.Image = My.Resources.PIcon
            MsgBox("P2 Wins")
            EndGame()
        End If
        If TicTacToeTargets(2) = 2 And TicTacToeTargets(5) = 2 And TicTacToeTargets(8) = 2 Then
            WinnerPictureBox.Image = My.Resources.PIcon
            MsgBox("P2 Wins")
            EndGame()
        End If
        If TicTacToeTargets(3) = 2 And TicTacToeTargets(6) = 2 And TicTacToeTargets(9) = 2 Then
            WinnerPictureBox.Image = My.Resources.PIcon
            MsgBox("P2 Wins")
            EndGame()
        End If
        If TicTacToeTargets(1) = 2 And TicTacToeTargets(5) = 2 And TicTacToeTargets(9) = 2 Then
            WinnerPictureBox.Image = My.Resources.PIcon
            MsgBox("P2 Wins")
            EndGame()
        End If
        If TicTacToeTargets(3) = 2 And TicTacToeTargets(5) = 2 And TicTacToeTargets(7) = 2 Then
            WinnerPictureBox.Image = My.Resources.PIcon
            MsgBox("P2 Wins")
            EndGame()
        End If

        If CInt(TurnsPassedTextBox.Text) = 9 Then
            If TicTacToeTargets(0) = 0 Then
                MsgBox("Draw")
                EndGame()
            End If

        End If
    End Sub

    Sub EndGame()
        PictureBox1.Enabled = False
        PictureBox2.Enabled = False
        PictureBox3.Enabled = False
        PictureBox4.Enabled = False
        PictureBox5.Enabled = False
        PictureBox6.Enabled = False
        PictureBox7.Enabled = False
        PictureBox8.Enabled = False
        PictureBox9.Enabled = False
        StartButton.Enabled = True
        ResetButton.Enabled = False

        TicTacToeTargets(0) = 1
        ConstantReadTimer.Stop()
    End Sub

    '--------------------------------------------------------------
    'Event Handlers
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        ticTacToeCOM.SendI2CEnable(0)
        ConstantReadTimer.Start()
        Reset()
        PictureBox1.Enabled = True
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
        PictureBox5.Enabled = True
        PictureBox6.Enabled = True
        PictureBox7.Enabled = True
        PictureBox8.Enabled = True
        PictureBox9.Enabled = True

        StartButton.Enabled = False
        ResetButton.Enabled = True

        Do Until CInt(PlayerTurnTextBox.Text) > 9
            ReadTicTacToeTarget()
            WinCheck()
        Loop

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim preCount As Integer
        Dim postCount As Integer

        'TicTacToeTargets(1) = CInt(PlayerTurnTextBox.Text)
        'PictureBox1.Image = TurnPictureBox.Image
        'preCount = CInt(TurnsPassedTextBox.Text)
        'postCount = Counter(preCount)
        'TurnsPassedTextBox.Text = postCount
        'WinCheck()
        ticTacToeCOM.SendI2CRead(2)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim preCount As Integer
        Dim postCount As Integer

        TicTacToeTargets(2) = CInt(PlayerTurnTextBox.Text)
        PictureBox2.Image = TurnPictureBox.Image
        preCount = CInt(TurnsPassedTextBox.Text)
        postCount = Counter(preCount)
        TurnsPassedTextBox.Text = postCount
        WinCheck()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim preCount As Integer
        Dim postCount As Integer

        TicTacToeTargets(3) = CInt(PlayerTurnTextBox.Text)
        PictureBox3.Image = TurnPictureBox.Image
        preCount = CInt(TurnsPassedTextBox.Text)
        postCount = Counter(preCount)
        TurnsPassedTextBox.Text = postCount
        WinCheck()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Dim preCount As Integer
        Dim postCount As Integer

        TicTacToeTargets(4) = CInt(PlayerTurnTextBox.Text)
        PictureBox4.Image = TurnPictureBox.Image
        preCount = CInt(TurnsPassedTextBox.Text)
        postCount = Counter(preCount)
        TurnsPassedTextBox.Text = postCount
        WinCheck()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim preCount As Integer
        Dim postCount As Integer

        TicTacToeTargets(5) = CInt(PlayerTurnTextBox.Text)
        PictureBox5.Image = TurnPictureBox.Image
        preCount = CInt(TurnsPassedTextBox.Text)
        postCount = Counter(preCount)
        TurnsPassedTextBox.Text = postCount
        WinCheck()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim preCount As Integer
        Dim postCount As Integer

        TicTacToeTargets(6) = CInt(PlayerTurnTextBox.Text)
        PictureBox6.Image = TurnPictureBox.Image
        preCount = CInt(TurnsPassedTextBox.Text)
        postCount = Counter(preCount)
        TurnsPassedTextBox.Text = postCount
        WinCheck()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Dim preCount As Integer
        Dim postCount As Integer

        TicTacToeTargets(7) = CInt(PlayerTurnTextBox.Text)
        PictureBox7.Image = TurnPictureBox.Image
        preCount = CInt(TurnsPassedTextBox.Text)
        postCount = Counter(preCount)
        TurnsPassedTextBox.Text = postCount
        WinCheck()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Dim preCount As Integer
        Dim postCount As Integer

        TicTacToeTargets(8) = CInt(PlayerTurnTextBox.Text)
        PictureBox8.Image = TurnPictureBox.Image
        preCount = CInt(TurnsPassedTextBox.Text)
        postCount = Counter(preCount)
        TurnsPassedTextBox.Text = postCount
        WinCheck()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Dim preCount As Integer
        Dim postCount As Integer

        TicTacToeTargets(9) = CInt(PlayerTurnTextBox.Text)
        PictureBox9.Image = TurnPictureBox.Image
        preCount = CInt(TurnsPassedTextBox.Text)
        postCount = Counter(preCount)
        TurnsPassedTextBox.Text = postCount
        WinCheck()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ConstantReadTimer.Stop()
        ticTacToeCOM.SendI2CDisable(0)
        Reset()
    End Sub

    Dim timercounts As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ConstantReadTimer.Tick
        timercounts = timercounts + 1

        'If TimerTestRadioButton.Checked = True Then
        'TimerTestRadioButton.Checked = False
        'Else
        'TimerTestRadioButton.Checked = True
        'End If

        Select Case timercounts
            Case 1
                ticTacToeCOM.SendI2CRead(2)
                TimerTestRadioButton.Checked = False
            Case 2
                ticTacToeCOM.SendI2CRead(4)
                TimerTestRadioButton.Checked = True
            Case 3
                ticTacToeCOM.SendI2CRead(6)
                TimerTestRadioButton.Checked = False
            Case 4
                ticTacToeCOM.SendI2CRead(8)
                TimerTestRadioButton.Checked = True
            Case 5
                ticTacToeCOM.SendI2CRead(10)
                TimerTestRadioButton.Checked = False
            Case 6
                ticTacToeCOM.SendI2CRead(12)
                TimerTestRadioButton.Checked = True
            Case 7
                ticTacToeCOM.SendI2CRead(14)
                TimerTestRadioButton.Checked = False
            Case 8
                ticTacToeCOM.SendI2CRead(16)
                TimerTestRadioButton.Checked = True
            Case 9
                ticTacToeCOM.SendI2CRead(18)
                TimerTestRadioButton.Checked = False
                timercounts = 0
        End Select
    End Sub

    Private Sub WrongPlayerTimer_Tick(sender As Object, e As EventArgs) Handles WrongPlayerTimer.Tick
        ticTacToeCOM.SendI2CEnable(wrongTurnTarget)
        WrongPlayerTimer.Stop()
        ConstantReadTimer.Start()
    End Sub
End Class