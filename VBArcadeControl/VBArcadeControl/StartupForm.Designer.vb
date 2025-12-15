<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartupForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartupForm))
        Me.BennyPictureBox = New System.Windows.Forms.PictureBox()
        Me.COMGroupBox = New System.Windows.Forms.GroupBox()
        Me.COMPortComboBox = New System.Windows.Forms.ComboBox()
        Me.FormLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TitleLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.COMRefreshTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BennyPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.COMGroupBox.SuspendLayout()
        Me.FormLayoutPanel.SuspendLayout()
        Me.TitleLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BennyPictureBox
        '
        Me.BennyPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BennyPictureBox.BackgroundImage = Global.VBArcadeControl.My.Resources.Resources.Bengal
        Me.BennyPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BennyPictureBox.InitialImage = Nothing
        Me.BennyPictureBox.Location = New System.Drawing.Point(3, 3)
        Me.BennyPictureBox.Name = "BennyPictureBox"
        Me.FormLayoutPanel.SetRowSpan(Me.BennyPictureBox, 3)
        Me.BennyPictureBox.Size = New System.Drawing.Size(382, 420)
        Me.BennyPictureBox.TabIndex = 0
        Me.BennyPictureBox.TabStop = False
        '
        'COMGroupBox
        '
        Me.COMGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.COMGroupBox.Controls.Add(Me.COMPortComboBox)
        Me.COMGroupBox.Location = New System.Drawing.Point(391, 173)
        Me.COMGroupBox.Name = "COMGroupBox"
        Me.COMGroupBox.Size = New System.Drawing.Size(382, 53)
        Me.COMGroupBox.TabIndex = 1
        Me.COMGroupBox.TabStop = False
        Me.COMGroupBox.Text = "COM Port"
        '
        'COMPortComboBox
        '
        Me.COMPortComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.COMPortComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMPortComboBox.FormattingEnabled = True
        Me.COMPortComboBox.Location = New System.Drawing.Point(6, 19)
        Me.COMPortComboBox.Name = "COMPortComboBox"
        Me.COMPortComboBox.Size = New System.Drawing.Size(370, 24)
        Me.COMPortComboBox.TabIndex = 0
        '
        'FormLayoutPanel
        '
        Me.FormLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormLayoutPanel.ColumnCount = 2
        Me.FormLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.FormLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.FormLayoutPanel.Controls.Add(Me.TitleLayoutPanel, 1, 0)
        Me.FormLayoutPanel.Controls.Add(Me.COMGroupBox, 1, 1)
        Me.FormLayoutPanel.Controls.Add(Me.BennyPictureBox, 0, 0)
        Me.FormLayoutPanel.Controls.Add(Me.AboutButton, 1, 2)
        Me.FormLayoutPanel.Location = New System.Drawing.Point(12, 12)
        Me.FormLayoutPanel.Name = "FormLayoutPanel"
        Me.FormLayoutPanel.RowCount = 3
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.FormLayoutPanel.Size = New System.Drawing.Size(776, 426)
        Me.FormLayoutPanel.TabIndex = 2
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
        Me.TitleLayoutPanel.Location = New System.Drawing.Point(391, 3)
        Me.TitleLayoutPanel.Name = "TitleLayoutPanel"
        Me.TitleLayoutPanel.RowCount = 2
        Me.TitleLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TitleLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TitleLayoutPanel.Size = New System.Drawing.Size(382, 164)
        Me.TitleLayoutPanel.TabIndex = 4
        '
        'TitleLabel
        '
        Me.TitleLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(3, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(376, 98)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "RCET Laser Arcade"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(3, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 66)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please select a COM Port using the dropdown below:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AboutButton
        '
        Me.AboutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutButton.Location = New System.Drawing.Point(623, 373)
        Me.AboutButton.MaximumSize = New System.Drawing.Size(150, 50)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(150, 50)
        Me.AboutButton.TabIndex = 5
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'COMRefreshTimer
        '
        Me.COMRefreshTimer.Interval = 500
        '
        'StartupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FormLayoutPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "StartupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laser Arcade Startup"
        CType(Me.BennyPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.COMGroupBox.ResumeLayout(False)
        Me.FormLayoutPanel.ResumeLayout(False)
        Me.TitleLayoutPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BennyPictureBox As PictureBox
    Friend WithEvents COMGroupBox As GroupBox
    Friend WithEvents FormLayoutPanel As TableLayoutPanel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents TitleLayoutPanel As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents COMPortComboBox As ComboBox
    Friend WithEvents AboutButton As Button
    Friend WithEvents COMRefreshTimer As Timer
End Class
