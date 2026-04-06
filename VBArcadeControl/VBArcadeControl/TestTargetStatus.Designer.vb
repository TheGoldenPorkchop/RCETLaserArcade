<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestTargetStatus
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
        Me.RecievedTargetData = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReadButton = New System.Windows.Forms.Button()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.WriteTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WriteButton = New System.Windows.Forms.Button()
        Me.DecimalRadioButton = New System.Windows.Forms.RadioButton()
        Me.HexRadioButton = New System.Windows.Forms.RadioButton()
        Me.AsciiRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EnableButton = New System.Windows.Forms.Button()
        Me.DisableButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ResultLabel = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RecievedTargetData
        '
        Me.RecievedTargetData.Location = New System.Drawing.Point(440, 24)
        Me.RecievedTargetData.Margin = New System.Windows.Forms.Padding(2)
        Me.RecievedTargetData.Name = "RecievedTargetData"
        Me.RecievedTargetData.ReadOnly = True
        Me.RecievedTargetData.Size = New System.Drawing.Size(152, 20)
        Me.RecievedTargetData.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Raw Data"
        '
        'ReadButton
        '
        Me.ReadButton.Location = New System.Drawing.Point(11, 86)
        Me.ReadButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ReadButton.Name = "ReadButton"
        Me.ReadButton.Size = New System.Drawing.Size(58, 32)
        Me.ReadButton.TabIndex = 2
        Me.ReadButton.Text = "Read"
        Me.ReadButton.UseVisualStyleBackColor = True
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(9, 24)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AddressTextBox.TabIndex = 3
        Me.AddressTextBox.Text = "1"
        '
        'WriteTextBox
        '
        Me.WriteTextBox.Location = New System.Drawing.Point(9, 63)
        Me.WriteTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.WriteTextBox.Name = "WriteTextBox"
        Me.WriteTextBox.Size = New System.Drawing.Size(121, 20)
        Me.WriteTextBox.TabIndex = 4
        Me.WriteTextBox.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Write"
        '
        'WriteButton
        '
        Me.WriteButton.Location = New System.Drawing.Point(71, 86)
        Me.WriteButton.Margin = New System.Windows.Forms.Padding(2)
        Me.WriteButton.Name = "WriteButton"
        Me.WriteButton.Size = New System.Drawing.Size(58, 32)
        Me.WriteButton.TabIndex = 7
        Me.WriteButton.Text = "Write"
        Me.WriteButton.UseVisualStyleBackColor = True
        '
        'DecimalRadioButton
        '
        Me.DecimalRadioButton.AutoSize = True
        Me.DecimalRadioButton.Checked = True
        Me.DecimalRadioButton.Location = New System.Drawing.Point(4, 17)
        Me.DecimalRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DecimalRadioButton.Name = "DecimalRadioButton"
        Me.DecimalRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.DecimalRadioButton.TabIndex = 9
        Me.DecimalRadioButton.TabStop = True
        Me.DecimalRadioButton.Text = "JellyBeans"
        Me.DecimalRadioButton.UseVisualStyleBackColor = True
        '
        'HexRadioButton
        '
        Me.HexRadioButton.AutoSize = True
        Me.HexRadioButton.Location = New System.Drawing.Point(4, 38)
        Me.HexRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HexRadioButton.Name = "HexRadioButton"
        Me.HexRadioButton.Size = New System.Drawing.Size(44, 17)
        Me.HexRadioButton.TabIndex = 10
        Me.HexRadioButton.Text = "Hex"
        Me.HexRadioButton.UseVisualStyleBackColor = True
        '
        'AsciiRadioButton
        '
        Me.AsciiRadioButton.AutoSize = True
        Me.AsciiRadioButton.Location = New System.Drawing.Point(4, 59)
        Me.AsciiRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AsciiRadioButton.Name = "AsciiRadioButton"
        Me.AsciiRadioButton.Size = New System.Drawing.Size(47, 17)
        Me.AsciiRadioButton.TabIndex = 11
        Me.AsciiRadioButton.Text = "Ascii"
        Me.AsciiRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DecimalRadioButton)
        Me.GroupBox1.Controls.Add(Me.AsciiRadioButton)
        Me.GroupBox1.Controls.Add(Me.HexRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 258)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(118, 98)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'EnableButton
        '
        Me.EnableButton.Location = New System.Drawing.Point(13, 123)
        Me.EnableButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EnableButton.Name = "EnableButton"
        Me.EnableButton.Size = New System.Drawing.Size(56, 68)
        Me.EnableButton.TabIndex = 13
        Me.EnableButton.Text = "Enable Target"
        Me.EnableButton.UseVisualStyleBackColor = True
        '
        'DisableButton
        '
        Me.DisableButton.Location = New System.Drawing.Point(70, 123)
        Me.DisableButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DisableButton.Name = "DisableButton"
        Me.DisableButton.Size = New System.Drawing.Size(56, 68)
        Me.DisableButton.TabIndex = 14
        Me.DisableButton.Text = "Disable Target"
        Me.DisableButton.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(437, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Result Label"
        '
        'ResultLabel
        '
        Me.ResultLabel.Location = New System.Drawing.Point(441, 102)
        Me.ResultLabel.Multiline = True
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(147, 70)
        Me.ResultLabel.TabIndex = 16
        '
        'TestTargetStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DisableButton)
        Me.Controls.Add(Me.EnableButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WriteButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WriteTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.ReadButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RecievedTargetData)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TestTargetStatus"
        Me.Text = "TestTargetStatus"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RecievedTargetData As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ReadButton As Button
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents WriteTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents WriteButton As Button
    Friend WithEvents DecimalRadioButton As RadioButton
    Friend WithEvents HexRadioButton As RadioButton
    Friend WithEvents AsciiRadioButton As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents EnableButton As Button
    Friend WithEvents DisableButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ResultLabel As TextBox
End Class
