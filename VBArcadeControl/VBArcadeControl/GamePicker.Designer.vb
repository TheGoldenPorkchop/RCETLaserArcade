<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GamePicker
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
        Me.LightningButton = New System.Windows.Forms.Button()
        Me.MemoryButton = New System.Windows.Forms.Button()
        Me.TicTacToeButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LightningButton
        '
        Me.LightningButton.Location = New System.Drawing.Point(12, 12)
        Me.LightningButton.Name = "LightningButton"
        Me.LightningButton.Size = New System.Drawing.Size(102, 51)
        Me.LightningButton.TabIndex = 0
        Me.LightningButton.Text = "Lightning"
        Me.LightningButton.UseVisualStyleBackColor = True
        '
        'MemoryButton
        '
        Me.MemoryButton.Location = New System.Drawing.Point(120, 12)
        Me.MemoryButton.Name = "MemoryButton"
        Me.MemoryButton.Size = New System.Drawing.Size(102, 51)
        Me.MemoryButton.TabIndex = 1
        Me.MemoryButton.Text = "Memory"
        Me.MemoryButton.UseVisualStyleBackColor = True
        '
        'TicTacToeButton
        '
        Me.TicTacToeButton.Location = New System.Drawing.Point(228, 12)
        Me.TicTacToeButton.Name = "TicTacToeButton"
        Me.TicTacToeButton.Size = New System.Drawing.Size(102, 51)
        Me.TicTacToeButton.TabIndex = 2
        Me.TicTacToeButton.Text = "TicTacToe"
        Me.TicTacToeButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 387)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 51)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Test"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GamePicker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TicTacToeButton)
        Me.Controls.Add(Me.MemoryButton)
        Me.Controls.Add(Me.LightningButton)
        Me.Name = "GamePicker"
        Me.Text = "GamePicker"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LightningButton As Button
    Friend WithEvents MemoryButton As Button
    Friend WithEvents TicTacToeButton As Button
    Friend WithEvents Button4 As Button
End Class
