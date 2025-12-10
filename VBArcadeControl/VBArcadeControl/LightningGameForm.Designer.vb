<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LightningGameForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Player1PictureBox = New System.Windows.Forms.PictureBox()
        Me.Player2PictureBox = New System.Windows.Forms.PictureBox()
        Me.Player3PictureBox = New System.Windows.Forms.PictureBox()
        Me.Player4PictureBox = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.Player1PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player3PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Player1PictureBox
        '
        Me.Player1PictureBox.Location = New System.Drawing.Point(12, 12)
        Me.Player1PictureBox.Name = "Player1PictureBox"
        Me.Player1PictureBox.Size = New System.Drawing.Size(169, 308)
        Me.Player1PictureBox.TabIndex = 0
        Me.Player1PictureBox.TabStop = False
        '
        'Player2PictureBox
        '
        Me.Player2PictureBox.Location = New System.Drawing.Point(209, 12)
        Me.Player2PictureBox.Name = "Player2PictureBox"
        Me.Player2PictureBox.Size = New System.Drawing.Size(169, 308)
        Me.Player2PictureBox.TabIndex = 1
        Me.Player2PictureBox.TabStop = False
        '
        'Player3PictureBox
        '
        Me.Player3PictureBox.Location = New System.Drawing.Point(405, 12)
        Me.Player3PictureBox.Name = "Player3PictureBox"
        Me.Player3PictureBox.Size = New System.Drawing.Size(169, 308)
        Me.Player3PictureBox.TabIndex = 2
        Me.Player3PictureBox.TabStop = False
        '
        'Player4PictureBox
        '
        Me.Player4PictureBox.Location = New System.Drawing.Point(619, 12)
        Me.Player4PictureBox.Name = "Player4PictureBox"
        Me.Player4PictureBox.Size = New System.Drawing.Size(169, 308)
        Me.Player4PictureBox.TabIndex = 3
        Me.Player4PictureBox.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(192, 360)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 4
        '
        'LightningGameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Player4PictureBox)
        Me.Controls.Add(Me.Player3PictureBox)
        Me.Controls.Add(Me.Player2PictureBox)
        Me.Controls.Add(Me.Player1PictureBox)
        Me.Name = "LightningGameForm"
        Me.Text = "LightningGameForm"
        CType(Me.Player1PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player3PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Player1PictureBox As PictureBox
    Friend WithEvents Player2PictureBox As PictureBox
    Friend WithEvents Player3PictureBox As PictureBox
    Friend WithEvents Player4PictureBox As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
