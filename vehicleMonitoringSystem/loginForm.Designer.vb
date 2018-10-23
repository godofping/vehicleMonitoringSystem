<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.usernameTextBox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.passwordTextBox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.loginButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.closeButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(67, 144)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(169, 29)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "LOGIN FORM"
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
        Me.usernameTextBox.Location = New System.Drawing.Point(72, 190)
        Me.usernameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(370, 44)
        Me.usernameTextBox.TabIndex = 4
        Me.usernameTextBox.Text = "admin"
        Me.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'passwordTextBox
        '
        Me.passwordTextBox.BackColor = System.Drawing.Color.White
        Me.passwordTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.passwordTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.passwordTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.passwordTextBox.BorderThickness = 3
        Me.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passwordTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.passwordTextBox.ForeColor = System.Drawing.Color.Black
        Me.passwordTextBox.isPassword = True
        Me.passwordTextBox.Location = New System.Drawing.Point(72, 256)
        Me.passwordTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.passwordTextBox.Name = "passwordTextBox"
        Me.passwordTextBox.Size = New System.Drawing.Size(370, 44)
        Me.passwordTextBox.TabIndex = 5
        Me.passwordTextBox.Text = "admin"
        Me.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(65, 30)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(360, 78)
        Me.BunifuCustomLabel2.TabIndex = 8
        Me.BunifuCustomLabel2.Text = "VEHICLE PARKING MONITORING" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SYSTEM FOR NOTRE DAME OF" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TACURONG COLLEGE"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 5
        Me.BunifuSeparator1.Location = New System.Drawing.Point(72, 118)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(571, 23)
        Me.BunifuSeparator1.TabIndex = 9
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.loginButton.color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.loginButton.colorActive = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.loginButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginButton.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.loginButton.ForeColor = System.Drawing.Color.White
        Me.loginButton.Image = Global.vehicleMonitoringSystem.My.Resources.Resources.icons8_login_filled_50__1_
        Me.loginButton.ImagePosition = 25
        Me.loginButton.ImageZoom = 50
        Me.loginButton.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.loginButton.LabelPosition = 0
        Me.loginButton.LabelText = ""
        Me.loginButton.Location = New System.Drawing.Point(491, 190)
        Me.loginButton.Margin = New System.Windows.Forms.Padding(6)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(106, 110)
        Me.loginButton.TabIndex = 6
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
        Me.closeButton.Location = New System.Drawing.Point(585, -1)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(6)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(58, 57)
        Me.closeButton.TabIndex = 10
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.BackgroundImage = Global.vehicleMonitoringSystem.My.Resources.Resources._998
        Me.ClientSize = New System.Drawing.Size(722, 351)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.passwordTextBox)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents passwordTextBox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents usernameTextBox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents loginButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents closeButton As Bunifu.Framework.UI.BunifuTileButton
End Class
