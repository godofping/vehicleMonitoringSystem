<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.parentPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.homeButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.reportButtons = New Bunifu.Framework.UI.BunifuTileButton()
        Me.ownersButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.logsButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.closeButton = New Bunifu.Framework.UI.BunifuTileButton()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.titleLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
        '
        'parentPanel
        '
        Me.parentPanel.BackColor = System.Drawing.Color.Transparent
        Me.parentPanel.Location = New System.Drawing.Point(242, 93)
        Me.parentPanel.Name = "parentPanel"
        Me.parentPanel.Size = New System.Drawing.Size(993, 578)
        Me.parentPanel.TabIndex = 0
        '
        'homeButton
        '
        Me.homeButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.homeButton.color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.homeButton.colorActive = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.homeButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homeButton.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.homeButton.ForeColor = System.Drawing.Color.White
        Me.homeButton.Image = Global.vehicleMonitoringSystem.My.Resources.Resources.icons8_house_filled_50
        Me.homeButton.ImagePosition = 20
        Me.homeButton.ImageZoom = 50
        Me.homeButton.LabelPosition = 41
        Me.homeButton.LabelText = "HOME"
        Me.homeButton.Location = New System.Drawing.Point(40, 93)
        Me.homeButton.Margin = New System.Windows.Forms.Padding(6)
        Me.homeButton.Name = "homeButton"
        Me.homeButton.Size = New System.Drawing.Size(128, 129)
        Me.homeButton.TabIndex = 3
        '
        'reportButtons
        '
        Me.reportButtons.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.reportButtons.color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.reportButtons.colorActive = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.reportButtons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reportButtons.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.reportButtons.ForeColor = System.Drawing.Color.White
        Me.reportButtons.Image = Global.vehicleMonitoringSystem.My.Resources.Resources.icons8_combo_chart_filled_50
        Me.reportButtons.ImagePosition = 20
        Me.reportButtons.ImageZoom = 50
        Me.reportButtons.LabelPosition = 41
        Me.reportButtons.LabelText = "REPORTS"
        Me.reportButtons.Location = New System.Drawing.Point(40, 552)
        Me.reportButtons.Margin = New System.Windows.Forms.Padding(6)
        Me.reportButtons.Name = "reportButtons"
        Me.reportButtons.Size = New System.Drawing.Size(128, 129)
        Me.reportButtons.TabIndex = 2
        '
        'ownersButton
        '
        Me.ownersButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ownersButton.color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ownersButton.colorActive = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ownersButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ownersButton.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.ownersButton.ForeColor = System.Drawing.Color.White
        Me.ownersButton.Image = CType(resources.GetObject("ownersButton.Image"), System.Drawing.Image)
        Me.ownersButton.ImagePosition = 20
        Me.ownersButton.ImageZoom = 50
        Me.ownersButton.LabelPosition = 41
        Me.ownersButton.LabelText = "OWNERS"
        Me.ownersButton.Location = New System.Drawing.Point(40, 245)
        Me.ownersButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ownersButton.Name = "ownersButton"
        Me.ownersButton.Size = New System.Drawing.Size(128, 129)
        Me.ownersButton.TabIndex = 1
        '
        'logsButton
        '
        Me.logsButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.logsButton.color = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.logsButton.colorActive = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.logsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logsButton.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.logsButton.ForeColor = System.Drawing.Color.White
        Me.logsButton.Image = Global.vehicleMonitoringSystem.My.Resources.Resources.icons8_bulleted_list_filled_50
        Me.logsButton.ImagePosition = 20
        Me.logsButton.ImageZoom = 50
        Me.logsButton.LabelPosition = 41
        Me.logsButton.LabelText = "LOGS"
        Me.logsButton.Location = New System.Drawing.Point(40, 396)
        Me.logsButton.Margin = New System.Windows.Forms.Padding(6)
        Me.logsButton.Name = "logsButton"
        Me.logsButton.Size = New System.Drawing.Size(128, 129)
        Me.logsButton.TabIndex = 0
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
        Me.closeButton.Location = New System.Drawing.Point(1141, 0)
        Me.closeButton.Margin = New System.Windows.Forms.Padding(6)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(58, 57)
        Me.closeButton.TabIndex = 11
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.homeButton)
        Me.BunifuGradientPanel1.Controls.Add(Me.reportButtons)
        Me.BunifuGradientPanel1.Controls.Add(Me.ownersButton)
        Me.BunifuGradientPanel1.Controls.Add(Me.logsButton)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.SandyBrown
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.AntiqueWhite
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(200, 720)
        Me.BunifuGradientPanel1.TabIndex = 12
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.BackColor = System.Drawing.Color.Transparent
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.titleLabel.Location = New System.Drawing.Point(278, 55)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(267, 29)
        Me.titleLabel.TabIndex = 13
        Me.titleLabel.Text = "BunifuCustomLabel1"
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 50
        Me.BunifuElipse2.TargetControl = Me.parentPanel
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(421, 683)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(573, 15)
        Me.BunifuCustomLabel1.TabIndex = 14
        Me.BunifuCustomLabel1.Text = "VEHICLE PARKING MONITORING SYSTEM FOR NOTRE DAME OF TACURONG COLLEGE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.vehicleMonitoringSystem.My.Resources.Resources._998
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.BunifuGradientPanel1)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.parentPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainForm"
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents parentPanel As FlowLayoutPanel
    Friend WithEvents closeButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents reportButtons As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents ownersButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents logsButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents homeButton As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents titleLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
