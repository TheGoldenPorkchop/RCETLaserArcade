<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlasterConfigurationForm
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
        Me.FormLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PlayerColorGroupBox = New System.Windows.Forms.GroupBox()
        Me.PlayerColorButton = New System.Windows.Forms.Button()
        Me.PlayerColorPictureBox = New System.Windows.Forms.PictureBox()
        Me.TitleLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlayerNumberGroupBox = New System.Windows.Forms.GroupBox()
        Me.PlayerNumberComboBox = New System.Windows.Forms.ComboBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.FormLayoutPanel.SuspendLayout()
        Me.PlayerColorGroupBox.SuspendLayout()
        CType(Me.PlayerColorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitleLayoutPanel.SuspendLayout()
        Me.PlayerNumberGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormLayoutPanel
        '
        Me.FormLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormLayoutPanel.ColumnCount = 1
        Me.FormLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FormLayoutPanel.Controls.Add(Me.PlayerColorGroupBox, 0, 2)
        Me.FormLayoutPanel.Controls.Add(Me.TitleLayoutPanel, 0, 0)
        Me.FormLayoutPanel.Controls.Add(Me.PlayerNumberGroupBox, 0, 1)
        Me.FormLayoutPanel.Controls.Add(Me.SaveButton, 0, 3)
        Me.FormLayoutPanel.Location = New System.Drawing.Point(12, 12)
        Me.FormLayoutPanel.Name = "FormLayoutPanel"
        Me.FormLayoutPanel.RowCount = 4
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FormLayoutPanel.Size = New System.Drawing.Size(363, 274)
        Me.FormLayoutPanel.TabIndex = 0
        '
        'PlayerColorGroupBox
        '
        Me.PlayerColorGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayerColorGroupBox.Controls.Add(Me.PlayerColorButton)
        Me.PlayerColorGroupBox.Controls.Add(Me.PlayerColorPictureBox)
        Me.PlayerColorGroupBox.Location = New System.Drawing.Point(3, 158)
        Me.PlayerColorGroupBox.Name = "PlayerColorGroupBox"
        Me.PlayerColorGroupBox.Size = New System.Drawing.Size(357, 49)
        Me.PlayerColorGroupBox.TabIndex = 6
        Me.PlayerColorGroupBox.TabStop = False
        Me.PlayerColorGroupBox.Text = "Player Number"
        '
        'PlayerColorButton
        '
        Me.PlayerColorButton.Location = New System.Drawing.Point(112, 19)
        Me.PlayerColorButton.Name = "PlayerColorButton"
        Me.PlayerColorButton.Size = New System.Drawing.Size(101, 24)
        Me.PlayerColorButton.TabIndex = 1
        Me.PlayerColorButton.Text = "Change Color"
        Me.PlayerColorButton.UseVisualStyleBackColor = True
        '
        'PlayerColorPictureBox
        '
        Me.PlayerColorPictureBox.Location = New System.Drawing.Point(6, 19)
        Me.PlayerColorPictureBox.Name = "PlayerColorPictureBox"
        Me.PlayerColorPictureBox.Size = New System.Drawing.Size(100, 24)
        Me.PlayerColorPictureBox.TabIndex = 0
        Me.PlayerColorPictureBox.TabStop = False
        '
        'TitleLayoutPanel
        '
        Me.TitleLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleLayoutPanel.ColumnCount = 1
        Me.TitleLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TitleLayoutPanel.Controls.Add(Me.TitleLabel, 0, 0)
        Me.TitleLayoutPanel.Controls.Add(Me.Label1, 0, 1)
        Me.TitleLayoutPanel.Location = New System.Drawing.Point(3, 3)
        Me.TitleLayoutPanel.Name = "TitleLayoutPanel"
        Me.TitleLayoutPanel.RowCount = 2
        Me.TitleLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TitleLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TitleLayoutPanel.Size = New System.Drawing.Size(357, 94)
        Me.TitleLayoutPanel.TabIndex = 5
        '
        'TitleLabel
        '
        Me.TitleLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(3, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(351, 56)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Blaster Configuration"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(3, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Change the player number and/or color using the controls below. Click Save to wri" &
    "te to the Blaster."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PlayerNumberGroupBox
        '
        Me.PlayerNumberGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayerNumberGroupBox.Controls.Add(Me.PlayerNumberComboBox)
        Me.PlayerNumberGroupBox.Location = New System.Drawing.Point(3, 103)
        Me.PlayerNumberGroupBox.Name = "PlayerNumberGroupBox"
        Me.PlayerNumberGroupBox.Size = New System.Drawing.Size(357, 49)
        Me.PlayerNumberGroupBox.TabIndex = 2
        Me.PlayerNumberGroupBox.TabStop = False
        Me.PlayerNumberGroupBox.Text = "Player Number"
        '
        'PlayerNumberComboBox
        '
        Me.PlayerNumberComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayerNumberComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerNumberComboBox.FormattingEnabled = True
        Me.PlayerNumberComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.PlayerNumberComboBox.Location = New System.Drawing.Point(6, 19)
        Me.PlayerNumberComboBox.Name = "PlayerNumberComboBox"
        Me.PlayerNumberComboBox.Size = New System.Drawing.Size(345, 24)
        Me.PlayerNumberComboBox.TabIndex = 0
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(210, 221)
        Me.SaveButton.MaximumSize = New System.Drawing.Size(150, 50)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(150, 50)
        Me.SaveButton.TabIndex = 7
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BlasterConfigurationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 298)
        Me.Controls.Add(Me.FormLayoutPanel)
        Me.Name = "BlasterConfigurationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blaster Configuration"
        Me.FormLayoutPanel.ResumeLayout(False)
        Me.PlayerColorGroupBox.ResumeLayout(False)
        CType(Me.PlayerColorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitleLayoutPanel.ResumeLayout(False)
        Me.PlayerNumberGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormLayoutPanel As TableLayoutPanel
    Friend WithEvents PlayerNumberGroupBox As GroupBox
    Friend WithEvents PlayerNumberComboBox As ComboBox
    Friend WithEvents TitleLayoutPanel As TableLayoutPanel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PlayerColorGroupBox As GroupBox
    Friend WithEvents PlayerColorButton As Button
    Friend WithEvents PlayerColorPictureBox As PictureBox
    Friend WithEvents SaveButton As Button
End Class
