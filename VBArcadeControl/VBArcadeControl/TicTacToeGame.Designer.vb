<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicTacToeGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PlayerTurnTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TurnPictureBox = New System.Windows.Forms.PictureBox()
        Me.TurnsPassedTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WinnerPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerTestRadioButton = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinnerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(12, 357)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 75)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start Game"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(93, 357)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 75)
        Me.ResetButton.TabIndex = 1
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'ReturnButton
        '
        Me.ReturnButton.Location = New System.Drawing.Point(713, 363)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(75, 75)
        Me.ReturnButton.TabIndex = 2
        Me.ReturnButton.Text = "Return to Game Menu"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'PictureBox9
        '
        Me.PictureBox9.Enabled = False
        Me.PictureBox9.Image = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox9.InitialImage = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox9.Location = New System.Drawing.Point(433, 263)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 11
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Enabled = False
        Me.PictureBox8.Image = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox8.InitialImage = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox8.Location = New System.Drawing.Point(327, 263)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Enabled = False
        Me.PictureBox7.Image = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox7.InitialImage = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox7.Location = New System.Drawing.Point(221, 263)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Enabled = False
        Me.PictureBox6.Image = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox6.InitialImage = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox6.Location = New System.Drawing.Point(433, 157)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Enabled = False
        Me.PictureBox5.Image = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox5.InitialImage = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox5.Location = New System.Drawing.Point(327, 157)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Enabled = False
        Me.PictureBox4.Image = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox4.InitialImage = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox4.Location = New System.Drawing.Point(221, 157)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox3.InitialImage = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox3.Location = New System.Drawing.Point(433, 51)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox2.InitialImage = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox2.Location = New System.Drawing.Point(327, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox1.InitialImage = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.PictureBox1.Location = New System.Drawing.Point(221, 51)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PlayerTurnTextBox
        '
        Me.PlayerTurnTextBox.Location = New System.Drawing.Point(591, 51)
        Me.PlayerTurnTextBox.Name = "PlayerTurnTextBox"
        Me.PlayerTurnTextBox.ReadOnly = True
        Me.PlayerTurnTextBox.Size = New System.Drawing.Size(33, 22)
        Me.PlayerTurnTextBox.TabIndex = 12
        Me.PlayerTurnTextBox.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(539, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Player"
        '
        'TurnPictureBox
        '
        Me.TurnPictureBox.Image = Global.VBArcadeControl.My.Resources.Resources.BIcon
        Me.TurnPictureBox.InitialImage = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.TurnPictureBox.Location = New System.Drawing.Point(553, 79)
        Me.TurnPictureBox.Name = "TurnPictureBox"
        Me.TurnPictureBox.Size = New System.Drawing.Size(58, 58)
        Me.TurnPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TurnPictureBox.TabIndex = 14
        Me.TurnPictureBox.TabStop = False
        '
        'TurnsPassedTextBox
        '
        Me.TurnsPassedTextBox.Location = New System.Drawing.Point(551, 176)
        Me.TurnsPassedTextBox.Name = "TurnsPassedTextBox"
        Me.TurnsPassedTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TurnsPassedTextBox.TabIndex = 15
        Me.TurnsPassedTextBox.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(550, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Turns Passed:"
        '
        'WinnerPictureBox
        '
        Me.WinnerPictureBox.Image = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.WinnerPictureBox.InitialImage = Global.VBArcadeControl.My.Resources.Resources.NoIcon
        Me.WinnerPictureBox.Location = New System.Drawing.Point(551, 305)
        Me.WinnerPictureBox.Name = "WinnerPictureBox"
        Me.WinnerPictureBox.Size = New System.Drawing.Size(58, 58)
        Me.WinnerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WinnerPictureBox.TabIndex = 17
        Me.WinnerPictureBox.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(550, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Winner:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'TimerTestRadioButton
        '
        Me.TimerTestRadioButton.AutoSize = True
        Me.TimerTestRadioButton.Location = New System.Drawing.Point(174, 412)
        Me.TimerTestRadioButton.Name = "TimerTestRadioButton"
        Me.TimerTestRadioButton.Size = New System.Drawing.Size(93, 20)
        Me.TimerTestRadioButton.TabIndex = 19
        Me.TimerTestRadioButton.TabStop = True
        Me.TimerTestRadioButton.Text = "Timer Test"
        Me.TimerTestRadioButton.UseVisualStyleBackColor = True
        '
        'TicTacToeGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TimerTestRadioButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.WinnerPictureBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TurnsPassedTextBox)
        Me.Controls.Add(Me.TurnPictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PlayerTurnTextBox)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.StartButton)
        Me.Name = "TicTacToeGame"
        Me.Text = "TicTacToeGame"
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinnerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents ReturnButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PlayerTurnTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TurnPictureBox As PictureBox
    Friend WithEvents TurnsPassedTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents WinnerPictureBox As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimerTestRadioButton As RadioButton
End Class
