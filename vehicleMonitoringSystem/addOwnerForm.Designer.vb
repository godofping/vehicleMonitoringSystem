<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addOwnerForm
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.usernameTextBox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.titleLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.genderComboBox = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.birthDateBunifuDatepicker = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuMetroTextbox3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuTileButton2 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.closeButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.studentPanel = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.studentPanel.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'usernameTextBox
        '
        Me.usernameTextBox.BackColor = System.Drawing.Color.White
        Me.usernameTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.usernameTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.usernameTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.usernameTextBox.BorderThickness = 3
        Me.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.usernameTextBox.ForeColor = System.Drawing.Color.Black
        Me.usernameTextBox.isPassword = False
        Me.usernameTextBox.Location = New System.Drawing.Point(33, 146)
        Me.usernameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(278, 44)
        Me.usernameTextBox.TabIndex = 13
        Me.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.BackColor = System.Drawing.Color.Transparent
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.titleLabel.Location = New System.Drawing.Point(28, 35)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(147, 29)
        Me.titleLabel.TabIndex = 16
        Me.titleLabel.Text = "Add Owner"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(28, 117)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(116, 25)
        Me.BunifuCustomLabel1.TabIndex = 17
        Me.BunifuCustomLabel1.Text = "First Name"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(28, 203)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(138, 25)
        Me.BunifuCustomLabel2.TabIndex = 19
        Me.BunifuCustomLabel2.Text = "Middle Name"
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BackColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderThickness = 3
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(33, 232)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(278, 44)
        Me.BunifuMetroTextbox1.TabIndex = 18
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(28, 287)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(115, 25)
        Me.BunifuCustomLabel3.TabIndex = 21
        Me.BunifuCustomLabel3.Text = "Last Name"
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BackColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderThickness = 3
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(33, 316)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(278, 44)
        Me.BunifuMetroTextbox2.TabIndex = 20
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'genderComboBox
        '
        Me.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.genderComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.genderComboBox.FormattingEnabled = True
        Me.genderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.genderComboBox.Location = New System.Drawing.Point(33, 405)
        Me.genderComboBox.Name = "genderComboBox"
        Me.genderComboBox.Size = New System.Drawing.Size(278, 29)
        Me.genderComboBox.TabIndex = 48
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(29, 371)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(83, 25)
        Me.BunifuCustomLabel4.TabIndex = 49
        Me.BunifuCustomLabel4.Text = "Gender"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 10
        Me.BunifuSeparator1.Location = New System.Drawing.Point(33, 68)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(890, 43)
        Me.BunifuSeparator1.TabIndex = 50
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'birthDateBunifuDatepicker
        '
        Me.birthDateBunifuDatepicker.BackColor = System.Drawing.Color.SeaGreen
        Me.birthDateBunifuDatepicker.BorderRadius = 0
        Me.birthDateBunifuDatepicker.ForeColor = System.Drawing.Color.White
        Me.birthDateBunifuDatepicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.birthDateBunifuDatepicker.FormatCustom = Nothing
        Me.birthDateBunifuDatepicker.Location = New System.Drawing.Point(34, 479)
        Me.birthDateBunifuDatepicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.birthDateBunifuDatepicker.Name = "birthDateBunifuDatepicker"
        Me.birthDateBunifuDatepicker.Size = New System.Drawing.Size(278, 44)
        Me.birthDateBunifuDatepicker.TabIndex = 51
        Me.birthDateBunifuDatepicker.Value = New Date(1995, 12, 25, 0, 0, 0, 0)
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(29, 450)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(91, 25)
        Me.BunifuCustomLabel5.TabIndex = 52
        Me.BunifuCustomLabel5.Text = "Birthday"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(29, 539)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(155, 25)
        Me.BunifuCustomLabel6.TabIndex = 54
        Me.BunifuCustomLabel6.Text = "Phone Number"
        '
        'BunifuMetroTextbox3
        '
        Me.BunifuMetroTextbox3.BackColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuMetroTextbox3.BorderThickness = 3
        Me.BunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMetroTextbox3.ForeColor = System.Drawing.Color.Black
        Me.BunifuMetroTextbox3.isPassword = False
        Me.BunifuMetroTextbox3.Location = New System.Drawing.Point(34, 568)
        Me.BunifuMetroTextbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox3.Name = "BunifuMetroTextbox3"
        Me.BunifuMetroTextbox3.Size = New System.Drawing.Size(278, 44)
        Me.BunifuMetroTextbox3.TabIndex = 53
        Me.BunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuTileButton2
        '
        Me.BunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuTileButton2.color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton2.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton2.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton2.Image = Global.vehicleMonitoringSystem.My.Resources.Resources.icons8_clear_symbol_filled_100
        Me.BunifuTileButton2.ImagePosition = 0
        Me.BunifuTileButton2.ImageZoom = 40
        Me.BunifuTileButton2.LabelPosition = 30
        Me.BunifuTileButton2.LabelText = "CLEAR"
        Me.BunifuTileButton2.Location = New System.Drawing.Point(653, 528)
        Me.BunifuTileButton2.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton2.Name = "BunifuTileButton2"
        Me.BunifuTileButton2.Size = New System.Drawing.Size(129, 84)
        Me.BunifuTileButton2.TabIndex = 56
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuTileButton1.color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = Global.vehicleMonitoringSystem.My.Resources.Resources.icons8_plus_52
        Me.BunifuTileButton1.ImagePosition = 0
        Me.BunifuTileButton1.ImageZoom = 40
        Me.BunifuTileButton1.LabelPosition = 30
        Me.BunifuTileButton1.LabelText = "SAVE"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(794, 528)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(129, 84)
        Me.BunifuTileButton1.TabIndex = 55
        '
        'closeButton
        '
        Me.closeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.closeButton.color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.closeButton.colorActive = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.closeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeButton.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.closeButton.ForeColor = System.Drawing.Color.White
        Me.closeButton.Image = Global.vehicleMonitoringSystem.My.Resources.Resources.icons8_delete_48
        Me.closeButton.ImagePosition = 10
        Me.closeButton.ImageZoom = 60
        Me.closeButton.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.closeButton.LabelPosition = 0
        Me.closeButton.LabelText = ""
        Me.closeButton.Location = New System.Drawing.Point(824, -1)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(6)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(58, 57)
        Me.closeButton.TabIndex = 12
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(349, 117)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(55, 25)
        Me.BunifuCustomLabel7.TabIndex = 58
        Me.BunifuCustomLabel7.Text = "Role"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Student", "Personel", "Visitor"})
        Me.ComboBox1.Location = New System.Drawing.Point(355, 146)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(278, 29)
        Me.ComboBox1.TabIndex = 57
        '
        'studentPanel
        '
        Me.studentPanel.Controls.Add(Me.BunifuCustomLabel8)
        Me.studentPanel.Controls.Add(Me.ComboBox2)
        Me.studentPanel.Location = New System.Drawing.Point(324, 186)
        Me.studentPanel.Name = "studentPanel"
        Me.studentPanel.Size = New System.Drawing.Size(330, 321)
        Me.studentPanel.TabIndex = 60
        Me.studentPanel.Visible = False
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(26, 17)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(123, 25)
        Me.BunifuCustomLabel8.TabIndex = 51
        Me.BunifuCustomLabel8.Text = "Department"
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Grade School", "High School", "College"})
        Me.ComboBox2.Location = New System.Drawing.Point(30, 46)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(278, 29)
        Me.ComboBox2.TabIndex = 50
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'addOwnerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 659)
        Me.Controls.Add(Me.studentPanel)
        Me.Controls.Add(Me.BunifuCustomLabel7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BunifuTileButton2)
        Me.Controls.Add(Me.BunifuTileButton1)
        Me.Controls.Add(Me.BunifuCustomLabel6)
        Me.Controls.Add(Me.BunifuMetroTextbox3)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.birthDateBunifuDatepicker)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.genderComboBox)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuMetroTextbox2)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.closeButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addOwnerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addOwnerForm"
        Me.studentPanel.ResumeLayout(False)
        Me.studentPanel.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents closeButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents usernameTextBox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents titleLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents genderComboBox As ComboBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents birthDateBunifuDatepicker As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuMetroTextbox3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuTileButton2 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents studentPanel As Panel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
