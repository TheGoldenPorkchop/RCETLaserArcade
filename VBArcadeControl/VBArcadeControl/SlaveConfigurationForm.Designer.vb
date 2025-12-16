<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlaveConfigurationForm
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
        Me.PlayerColorsGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PlayerFourColorPictureBox = New System.Windows.Forms.PictureBox()
        Me.PlayerThreeColorPictureBox = New System.Windows.Forms.PictureBox()
        Me.PlayerTwoColorPictureBox = New System.Windows.Forms.PictureBox()
        Me.PlayerColorButton = New System.Windows.Forms.Button()
        Me.PlayerOneColorPictureBox = New System.Windows.Forms.PictureBox()
        Me.TitleLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.I2CAddressGroupBox = New System.Windows.Forms.GroupBox()
        Me.I2CAddressTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.LEDNumberGroupBox = New System.Windows.Forms.GroupBox()
        Me.LEDNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ServoLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Servo1ENGroupBox = New System.Windows.Forms.GroupBox()
        Me.Servo1ENTrackBar = New System.Windows.Forms.TrackBar()
        Me.Servo2ENGroupBox = New System.Windows.Forms.GroupBox()
        Me.Servo2ENTrackBar = New System.Windows.Forms.TrackBar()
        Me.Servo3ENGroupBox = New System.Windows.Forms.GroupBox()
        Me.Servo3ENTrackBar = New System.Windows.Forms.TrackBar()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Servo3DISGroupBox = New System.Windows.Forms.GroupBox()
        Me.Servo3DISTrackBar = New System.Windows.Forms.TrackBar()
        Me.Servo2DISGroupBox = New System.Windows.Forms.GroupBox()
        Me.Servo2DISTrackBar = New System.Windows.Forms.TrackBar()
        Me.Servo1DISGroupBox = New System.Windows.Forms.GroupBox()
        Me.Servo1DISTrackBar = New System.Windows.Forms.TrackBar()
        Me.FormLayoutPanel.SuspendLayout()
        Me.PlayerColorsGroupBox.SuspendLayout()
        CType(Me.PlayerFourColorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerThreeColorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerTwoColorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerOneColorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TitleLayoutPanel.SuspendLayout()
        Me.I2CAddressGroupBox.SuspendLayout()
        Me.LEDNumberGroupBox.SuspendLayout()
        Me.ServoLayoutPanel.SuspendLayout()
        Me.Servo1ENGroupBox.SuspendLayout()
        CType(Me.Servo1ENTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Servo2ENGroupBox.SuspendLayout()
        CType(Me.Servo2ENTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Servo3ENGroupBox.SuspendLayout()
        CType(Me.Servo3ENTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Servo3DISGroupBox.SuspendLayout()
        CType(Me.Servo3DISTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Servo2DISGroupBox.SuspendLayout()
        CType(Me.Servo2DISTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Servo1DISGroupBox.SuspendLayout()
        CType(Me.Servo1DISTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormLayoutPanel
        '
        Me.FormLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FormLayoutPanel.ColumnCount = 1
        Me.FormLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FormLayoutPanel.Controls.Add(Me.TableLayoutPanel1, 0, 5)
        Me.FormLayoutPanel.Controls.Add(Me.LEDNumberGroupBox, 0, 2)
        Me.FormLayoutPanel.Controls.Add(Me.TitleLayoutPanel, 0, 0)
        Me.FormLayoutPanel.Controls.Add(Me.I2CAddressGroupBox, 0, 1)
        Me.FormLayoutPanel.Controls.Add(Me.PlayerColorsGroupBox, 0, 3)
        Me.FormLayoutPanel.Controls.Add(Me.SaveButton, 0, 6)
        Me.FormLayoutPanel.Controls.Add(Me.ServoLayoutPanel, 0, 4)
        Me.FormLayoutPanel.Location = New System.Drawing.Point(12, 12)
        Me.FormLayoutPanel.Name = "FormLayoutPanel"
        Me.FormLayoutPanel.RowCount = 7
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.FormLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.FormLayoutPanel.Size = New System.Drawing.Size(546, 468)
        Me.FormLayoutPanel.TabIndex = 1
        '
        'PlayerColorsGroupBox
        '
        Me.PlayerColorsGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlayerColorsGroupBox.Controls.Add(Me.Label5)
        Me.PlayerColorsGroupBox.Controls.Add(Me.Label4)
        Me.PlayerColorsGroupBox.Controls.Add(Me.Label3)
        Me.PlayerColorsGroupBox.Controls.Add(Me.Label2)
        Me.PlayerColorsGroupBox.Controls.Add(Me.PlayerFourColorPictureBox)
        Me.PlayerColorsGroupBox.Controls.Add(Me.PlayerThreeColorPictureBox)
        Me.PlayerColorsGroupBox.Controls.Add(Me.PlayerTwoColorPictureBox)
        Me.PlayerColorsGroupBox.Controls.Add(Me.PlayerColorButton)
        Me.PlayerColorsGroupBox.Controls.Add(Me.PlayerOneColorPictureBox)
        Me.PlayerColorsGroupBox.Location = New System.Drawing.Point(3, 213)
        Me.PlayerColorsGroupBox.Name = "PlayerColorsGroupBox"
        Me.PlayerColorsGroupBox.Size = New System.Drawing.Size(540, 75)
        Me.PlayerColorsGroupBox.TabIndex = 6
        Me.PlayerColorsGroupBox.TabStop = False
        Me.PlayerColorsGroupBox.Text = "Player Colors"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(324, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Player 4"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(215, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Player 3"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(112, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Player 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Player 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PlayerFourColorPictureBox
        '
        Me.PlayerFourColorPictureBox.Location = New System.Drawing.Point(324, 37)
        Me.PlayerFourColorPictureBox.Name = "PlayerFourColorPictureBox"
        Me.PlayerFourColorPictureBox.Size = New System.Drawing.Size(100, 24)
        Me.PlayerFourColorPictureBox.TabIndex = 4
        Me.PlayerFourColorPictureBox.TabStop = False
        '
        'PlayerThreeColorPictureBox
        '
        Me.PlayerThreeColorPictureBox.Location = New System.Drawing.Point(218, 37)
        Me.PlayerThreeColorPictureBox.Name = "PlayerThreeColorPictureBox"
        Me.PlayerThreeColorPictureBox.Size = New System.Drawing.Size(100, 24)
        Me.PlayerThreeColorPictureBox.TabIndex = 3
        Me.PlayerThreeColorPictureBox.TabStop = False
        '
        'PlayerTwoColorPictureBox
        '
        Me.PlayerTwoColorPictureBox.Location = New System.Drawing.Point(112, 37)
        Me.PlayerTwoColorPictureBox.Name = "PlayerTwoColorPictureBox"
        Me.PlayerTwoColorPictureBox.Size = New System.Drawing.Size(100, 24)
        Me.PlayerTwoColorPictureBox.TabIndex = 2
        Me.PlayerTwoColorPictureBox.TabStop = False
        '
        'PlayerColorButton
        '
        Me.PlayerColorButton.Location = New System.Drawing.Point(430, 37)
        Me.PlayerColorButton.Name = "PlayerColorButton"
        Me.PlayerColorButton.Size = New System.Drawing.Size(101, 24)
        Me.PlayerColorButton.TabIndex = 1
        Me.PlayerColorButton.Text = "Change Colors"
        Me.PlayerColorButton.UseVisualStyleBackColor = True
        '
        'PlayerOneColorPictureBox
        '
        Me.PlayerOneColorPictureBox.Location = New System.Drawing.Point(6, 37)
        Me.PlayerOneColorPictureBox.Name = "PlayerOneColorPictureBox"
        Me.PlayerOneColorPictureBox.Size = New System.Drawing.Size(100, 24)
        Me.PlayerOneColorPictureBox.TabIndex = 0
        Me.PlayerOneColorPictureBox.TabStop = False
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
        Me.TitleLayoutPanel.Size = New System.Drawing.Size(540, 94)
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
        Me.TitleLabel.Size = New System.Drawing.Size(534, 56)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Slave Configuration"
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
        Me.Label1.Size = New System.Drawing.Size(534, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Change the slave configuration. Click Save to write to the Slave."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'I2CAddressGroupBox
        '
        Me.I2CAddressGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.I2CAddressGroupBox.Controls.Add(Me.I2CAddressTextBox)
        Me.I2CAddressGroupBox.Location = New System.Drawing.Point(3, 103)
        Me.I2CAddressGroupBox.Name = "I2CAddressGroupBox"
        Me.I2CAddressGroupBox.Size = New System.Drawing.Size(540, 49)
        Me.I2CAddressGroupBox.TabIndex = 2
        Me.I2CAddressGroupBox.TabStop = False
        Me.I2CAddressGroupBox.Text = "I2C Address"
        '
        'I2CAddressTextBox
        '
        Me.I2CAddressTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.I2CAddressTextBox.Location = New System.Drawing.Point(10, 19)
        Me.I2CAddressTextBox.Name = "I2CAddressTextBox"
        Me.I2CAddressTextBox.Size = New System.Drawing.Size(524, 20)
        Me.I2CAddressTextBox.TabIndex = 0
        Me.I2CAddressTextBox.Text = "1"
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(393, 415)
        Me.SaveButton.MaximumSize = New System.Drawing.Size(150, 50)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(150, 50)
        Me.SaveButton.TabIndex = 7
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'LEDNumberGroupBox
        '
        Me.LEDNumberGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LEDNumberGroupBox.Controls.Add(Me.LEDNumberTextBox)
        Me.LEDNumberGroupBox.Location = New System.Drawing.Point(3, 158)
        Me.LEDNumberGroupBox.Name = "LEDNumberGroupBox"
        Me.LEDNumberGroupBox.Size = New System.Drawing.Size(540, 49)
        Me.LEDNumberGroupBox.TabIndex = 8
        Me.LEDNumberGroupBox.TabStop = False
        Me.LEDNumberGroupBox.Text = "Number of LEDs"
        '
        'LEDNumberTextBox
        '
        Me.LEDNumberTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LEDNumberTextBox.Location = New System.Drawing.Point(10, 19)
        Me.LEDNumberTextBox.Name = "LEDNumberTextBox"
        Me.LEDNumberTextBox.Size = New System.Drawing.Size(524, 20)
        Me.LEDNumberTextBox.TabIndex = 0
        Me.LEDNumberTextBox.Text = "1"
        '
        'ServoLayoutPanel
        '
        Me.ServoLayoutPanel.ColumnCount = 3
        Me.ServoLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ServoLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ServoLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.ServoLayoutPanel.Controls.Add(Me.Servo3ENGroupBox, 2, 0)
        Me.ServoLayoutPanel.Controls.Add(Me.Servo2ENGroupBox, 1, 0)
        Me.ServoLayoutPanel.Controls.Add(Me.Servo1ENGroupBox, 0, 0)
        Me.ServoLayoutPanel.Location = New System.Drawing.Point(3, 294)
        Me.ServoLayoutPanel.Name = "ServoLayoutPanel"
        Me.ServoLayoutPanel.RowCount = 1
        Me.ServoLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ServoLayoutPanel.Size = New System.Drawing.Size(540, 49)
        Me.ServoLayoutPanel.TabIndex = 9
        '
        'Servo1ENGroupBox
        '
        Me.Servo1ENGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Servo1ENGroupBox.Controls.Add(Me.Servo1ENTrackBar)
        Me.Servo1ENGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.Servo1ENGroupBox.Name = "Servo1ENGroupBox"
        Me.Servo1ENGroupBox.Size = New System.Drawing.Size(174, 43)
        Me.Servo1ENGroupBox.TabIndex = 9
        Me.Servo1ENGroupBox.TabStop = False
        Me.Servo1ENGroupBox.Text = "Servo1 - Enabled"
        '
        'Servo1ENTrackBar
        '
        Me.Servo1ENTrackBar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Servo1ENTrackBar.Location = New System.Drawing.Point(7, 18)
        Me.Servo1ENTrackBar.Maximum = 1000
        Me.Servo1ENTrackBar.Name = "Servo1ENTrackBar"
        Me.Servo1ENTrackBar.Size = New System.Drawing.Size(161, 25)
        Me.Servo1ENTrackBar.TabIndex = 0
        '
        'Servo2ENGroupBox
        '
        Me.Servo2ENGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Servo2ENGroupBox.Controls.Add(Me.Servo2ENTrackBar)
        Me.Servo2ENGroupBox.Location = New System.Drawing.Point(183, 3)
        Me.Servo2ENGroupBox.Name = "Servo2ENGroupBox"
        Me.Servo2ENGroupBox.Size = New System.Drawing.Size(174, 43)
        Me.Servo2ENGroupBox.TabIndex = 10
        Me.Servo2ENGroupBox.TabStop = False
        Me.Servo2ENGroupBox.Text = "Servo2 - Enabled"
        '
        'Servo2ENTrackBar
        '
        Me.Servo2ENTrackBar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Servo2ENTrackBar.Location = New System.Drawing.Point(7, 18)
        Me.Servo2ENTrackBar.Maximum = 1000
        Me.Servo2ENTrackBar.Name = "Servo2ENTrackBar"
        Me.Servo2ENTrackBar.Size = New System.Drawing.Size(161, 25)
        Me.Servo2ENTrackBar.TabIndex = 0
        '
        'Servo3ENGroupBox
        '
        Me.Servo3ENGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Servo3ENGroupBox.Controls.Add(Me.Servo3ENTrackBar)
        Me.Servo3ENGroupBox.Location = New System.Drawing.Point(363, 3)
        Me.Servo3ENGroupBox.Name = "Servo3ENGroupBox"
        Me.Servo3ENGroupBox.Size = New System.Drawing.Size(174, 43)
        Me.Servo3ENGroupBox.TabIndex = 11
        Me.Servo3ENGroupBox.TabStop = False
        Me.Servo3ENGroupBox.Text = "Servo3 - Enabled"
        '
        'Servo3ENTrackBar
        '
        Me.Servo3ENTrackBar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Servo3ENTrackBar.Location = New System.Drawing.Point(7, 18)
        Me.Servo3ENTrackBar.Maximum = 1000
        Me.Servo3ENTrackBar.Name = "Servo3ENTrackBar"
        Me.Servo3ENTrackBar.Size = New System.Drawing.Size(161, 25)
        Me.Servo3ENTrackBar.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.Servo3DISGroupBox, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Servo2DISGroupBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Servo1DISGroupBox, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 349)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(540, 49)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Servo3DISGroupBox
        '
        Me.Servo3DISGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Servo3DISGroupBox.Controls.Add(Me.Servo3DISTrackBar)
        Me.Servo3DISGroupBox.Location = New System.Drawing.Point(363, 3)
        Me.Servo3DISGroupBox.Name = "Servo3DISGroupBox"
        Me.Servo3DISGroupBox.Size = New System.Drawing.Size(174, 43)
        Me.Servo3DISGroupBox.TabIndex = 11
        Me.Servo3DISGroupBox.TabStop = False
        Me.Servo3DISGroupBox.Text = "Servo3 - Disabled"
        '
        'Servo3DISTrackBar
        '
        Me.Servo3DISTrackBar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Servo3DISTrackBar.Location = New System.Drawing.Point(7, 18)
        Me.Servo3DISTrackBar.Maximum = 1000
        Me.Servo3DISTrackBar.Name = "Servo3DISTrackBar"
        Me.Servo3DISTrackBar.Size = New System.Drawing.Size(161, 25)
        Me.Servo3DISTrackBar.TabIndex = 0
        '
        'Servo2DISGroupBox
        '
        Me.Servo2DISGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Servo2DISGroupBox.Controls.Add(Me.Servo2DISTrackBar)
        Me.Servo2DISGroupBox.Location = New System.Drawing.Point(183, 3)
        Me.Servo2DISGroupBox.Name = "Servo2DISGroupBox"
        Me.Servo2DISGroupBox.Size = New System.Drawing.Size(174, 43)
        Me.Servo2DISGroupBox.TabIndex = 10
        Me.Servo2DISGroupBox.TabStop = False
        Me.Servo2DISGroupBox.Text = "Servo2 - Disabled"
        '
        'Servo2DISTrackBar
        '
        Me.Servo2DISTrackBar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Servo2DISTrackBar.Location = New System.Drawing.Point(7, 18)
        Me.Servo2DISTrackBar.Maximum = 1000
        Me.Servo2DISTrackBar.Name = "Servo2DISTrackBar"
        Me.Servo2DISTrackBar.Size = New System.Drawing.Size(161, 25)
        Me.Servo2DISTrackBar.TabIndex = 0
        '
        'Servo1DISGroupBox
        '
        Me.Servo1DISGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Servo1DISGroupBox.Controls.Add(Me.Servo1DISTrackBar)
        Me.Servo1DISGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.Servo1DISGroupBox.Name = "Servo1DISGroupBox"
        Me.Servo1DISGroupBox.Size = New System.Drawing.Size(174, 43)
        Me.Servo1DISGroupBox.TabIndex = 9
        Me.Servo1DISGroupBox.TabStop = False
        Me.Servo1DISGroupBox.Text = "Servo1 - Disabled"
        '
        'Servo1DISTrackBar
        '
        Me.Servo1DISTrackBar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Servo1DISTrackBar.Location = New System.Drawing.Point(7, 18)
        Me.Servo1DISTrackBar.Maximum = 1000
        Me.Servo1DISTrackBar.Name = "Servo1DISTrackBar"
        Me.Servo1DISTrackBar.Size = New System.Drawing.Size(161, 25)
        Me.Servo1DISTrackBar.TabIndex = 0
        '
        'SlaveConfigurationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 492)
        Me.Controls.Add(Me.FormLayoutPanel)
        Me.Name = "SlaveConfigurationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SlaveConfigurationForm"
        Me.FormLayoutPanel.ResumeLayout(False)
        Me.PlayerColorsGroupBox.ResumeLayout(False)
        CType(Me.PlayerFourColorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerThreeColorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerTwoColorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerOneColorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TitleLayoutPanel.ResumeLayout(False)
        Me.I2CAddressGroupBox.ResumeLayout(False)
        Me.I2CAddressGroupBox.PerformLayout()
        Me.LEDNumberGroupBox.ResumeLayout(False)
        Me.LEDNumberGroupBox.PerformLayout()
        Me.ServoLayoutPanel.ResumeLayout(False)
        Me.Servo1ENGroupBox.ResumeLayout(False)
        Me.Servo1ENGroupBox.PerformLayout()
        CType(Me.Servo1ENTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Servo2ENGroupBox.ResumeLayout(False)
        Me.Servo2ENGroupBox.PerformLayout()
        CType(Me.Servo2ENTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Servo3ENGroupBox.ResumeLayout(False)
        Me.Servo3ENGroupBox.PerformLayout()
        CType(Me.Servo3ENTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Servo3DISGroupBox.ResumeLayout(False)
        Me.Servo3DISGroupBox.PerformLayout()
        CType(Me.Servo3DISTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Servo2DISGroupBox.ResumeLayout(False)
        Me.Servo2DISGroupBox.PerformLayout()
        CType(Me.Servo2DISTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Servo1DISGroupBox.ResumeLayout(False)
        Me.Servo1DISGroupBox.PerformLayout()
        CType(Me.Servo1DISTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormLayoutPanel As TableLayoutPanel
    Friend WithEvents PlayerColorsGroupBox As GroupBox
    Friend WithEvents PlayerColorButton As Button
    Friend WithEvents PlayerOneColorPictureBox As PictureBox
    Friend WithEvents TitleLayoutPanel As TableLayoutPanel
    Friend WithEvents TitleLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveButton As Button
    Private WithEvents I2CAddressGroupBox As GroupBox
    Friend WithEvents I2CAddressTextBox As TextBox
    Friend WithEvents PlayerFourColorPictureBox As PictureBox
    Friend WithEvents PlayerThreeColorPictureBox As PictureBox
    Friend WithEvents PlayerTwoColorPictureBox As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents LEDNumberGroupBox As GroupBox
    Friend WithEvents LEDNumberTextBox As TextBox
    Friend WithEvents ServoLayoutPanel As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Private WithEvents Servo3DISGroupBox As GroupBox
    Friend WithEvents Servo3DISTrackBar As TrackBar
    Private WithEvents Servo2DISGroupBox As GroupBox
    Friend WithEvents Servo2DISTrackBar As TrackBar
    Private WithEvents Servo1DISGroupBox As GroupBox
    Friend WithEvents Servo1DISTrackBar As TrackBar
    Private WithEvents Servo3ENGroupBox As GroupBox
    Friend WithEvents Servo3ENTrackBar As TrackBar
    Private WithEvents Servo2ENGroupBox As GroupBox
    Friend WithEvents Servo2ENTrackBar As TrackBar
    Private WithEvents Servo1ENGroupBox As GroupBox
    Friend WithEvents Servo1ENTrackBar As TrackBar
End Class
