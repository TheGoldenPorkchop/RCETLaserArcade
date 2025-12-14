<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LightningGameForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LightningGameForm))
        Me.P1ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.P2ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.P3ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.P4ScoreTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RoundStatusTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Player4PictureBox = New System.Windows.Forms.PictureBox()
        Me.Player3PictureBox = New System.Windows.Forms.PictureBox()
        Me.Player2PictureBox = New System.Windows.Forms.PictureBox()
        Me.Player1PictureBox = New System.Windows.Forms.PictureBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.Player4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P1ScoreTextBox
        '
        Me.P1ScoreTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P1ScoreTextBox.Location = New System.Drawing.Point(57, 241)
        Me.P1ScoreTextBox.Name = "P1ScoreTextBox"
        Me.P1ScoreTextBox.ReadOnly = True
        Me.P1ScoreTextBox.Size = New System.Drawing.Size(100, 22)
        Me.P1ScoreTextBox.TabIndex = 4
        '
        'P2ScoreTextBox
        '
        Me.P2ScoreTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P2ScoreTextBox.Location = New System.Drawing.Point(252, 241)
        Me.P2ScoreTextBox.Name = "P2ScoreTextBox"
        Me.P2ScoreTextBox.ReadOnly = True
        Me.P2ScoreTextBox.Size = New System.Drawing.Size(100, 22)
        Me.P2ScoreTextBox.TabIndex = 8
        '
        'P3ScoreTextBox
        '
        Me.P3ScoreTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P3ScoreTextBox.Location = New System.Drawing.Point(447, 241)
        Me.P3ScoreTextBox.Name = "P3ScoreTextBox"
        Me.P3ScoreTextBox.ReadOnly = True
        Me.P3ScoreTextBox.Size = New System.Drawing.Size(100, 22)
        Me.P3ScoreTextBox.TabIndex = 9
        '
        'P4ScoreTextBox
        '
        Me.P4ScoreTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.P4ScoreTextBox.Location = New System.Drawing.Point(642, 241)
        Me.P4ScoreTextBox.Name = "P4ScoreTextBox"
        Me.P4ScoreTextBox.ReadOnly = True
        Me.P4ScoreTextBox.Size = New System.Drawing.Size(100, 22)
        Me.P4ScoreTextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 49)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "START"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RoundStatusTextBox
        '
        Me.RoundStatusTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoundStatusTextBox.Location = New System.Drawing.Point(131, 416)
        Me.RoundStatusTextBox.Name = "RoundStatusTextBox"
        Me.RoundStatusTextBox.ReadOnly = True
        Me.RoundStatusTextBox.Size = New System.Drawing.Size(100, 22)
        Me.RoundStatusTextBox.TabIndex = 12
        Me.RoundStatusTextBox.Text = "Ready"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(131, 397)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Round Status"
        '
        'Player4PictureBox
        '
        Me.Player4PictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Player4PictureBox.Image = CType(resources.GetObject("Player4PictureBox.Image"), System.Drawing.Image)
        Me.Player4PictureBox.Location = New System.Drawing.Point(597, 12)
        Me.Player4PictureBox.Name = "Player4PictureBox"
        Me.Player4PictureBox.Size = New System.Drawing.Size(189, 371)
        Me.Player4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player4PictureBox.TabIndex = 7
        Me.Player4PictureBox.TabStop = False
        '
        'Player3PictureBox
        '
        Me.Player3PictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Player3PictureBox.Image = CType(resources.GetObject("Player3PictureBox.Image"), System.Drawing.Image)
        Me.Player3PictureBox.Location = New System.Drawing.Point(402, 12)
        Me.Player3PictureBox.Name = "Player3PictureBox"
        Me.Player3PictureBox.Size = New System.Drawing.Size(189, 371)
        Me.Player3PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player3PictureBox.TabIndex = 6
        Me.Player3PictureBox.TabStop = False
        '
        'Player2PictureBox
        '
        Me.Player2PictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Player2PictureBox.Image = CType(resources.GetObject("Player2PictureBox.Image"), System.Drawing.Image)
        Me.Player2PictureBox.Location = New System.Drawing.Point(207, 12)
        Me.Player2PictureBox.Name = "Player2PictureBox"
        Me.Player2PictureBox.Size = New System.Drawing.Size(189, 371)
        Me.Player2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player2PictureBox.TabIndex = 5
        Me.Player2PictureBox.TabStop = False
        '
        'Player1PictureBox
        '
        Me.Player1PictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Player1PictureBox.Image = CType(resources.GetObject("Player1PictureBox.Image"), System.Drawing.Image)
        Me.Player1PictureBox.Location = New System.Drawing.Point(12, 12)
        Me.Player1PictureBox.Name = "Player1PictureBox"
        Me.Player1PictureBox.Size = New System.Drawing.Size(189, 371)
        Me.Player1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Player1PictureBox.TabIndex = 0
        Me.Player1PictureBox.TabStop = False
        '
        'LightningGameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RoundStatusTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.P4ScoreTextBox)
        Me.Controls.Add(Me.P3ScoreTextBox)
        Me.Controls.Add(Me.P2ScoreTextBox)
        Me.Controls.Add(Me.Player4PictureBox)
        Me.Controls.Add(Me.Player3PictureBox)
        Me.Controls.Add(Me.Player2PictureBox)
        Me.Controls.Add(Me.P1ScoreTextBox)
        Me.Controls.Add(Me.Player1PictureBox)
        Me.Name = "LightningGameForm"
        Me.Text = "LightningGameForm"
        CType(Me.Player4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Player1PictureBox As PictureBox
    Friend WithEvents P1ScoreTextBox As TextBox
    Friend WithEvents Player2PictureBox As PictureBox
    Friend WithEvents Player3PictureBox As PictureBox
    Friend WithEvents Player4PictureBox As PictureBox
    Friend WithEvents P2ScoreTextBox As TextBox
    Friend WithEvents P3ScoreTextBox As TextBox
    Friend WithEvents P4ScoreTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RoundStatusTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
