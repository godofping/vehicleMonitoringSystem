<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ownerForm
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.vehicleOwnersListBunifuCustomDataGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        CType(Me.vehicleOwnersListBunifuCustomDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(67, 4)
        '
        'vehicleOwnersListBunifuCustomDataGrid
        '
        Me.vehicleOwnersListBunifuCustomDataGrid.AllowUserToAddRows = False
        Me.vehicleOwnersListBunifuCustomDataGrid.AllowUserToDeleteRows = False
        Me.vehicleOwnersListBunifuCustomDataGrid.AllowUserToOrderColumns = True
        Me.vehicleOwnersListBunifuCustomDataGrid.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.vehicleOwnersListBunifuCustomDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.vehicleOwnersListBunifuCustomDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.vehicleOwnersListBunifuCustomDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.vehicleOwnersListBunifuCustomDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.vehicleOwnersListBunifuCustomDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 7.8!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Beige
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.vehicleOwnersListBunifuCustomDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.vehicleOwnersListBunifuCustomDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vehicleOwnersListBunifuCustomDataGrid.DoubleBuffered = True
        Me.vehicleOwnersListBunifuCustomDataGrid.EnableHeadersVisualStyles = False
        Me.vehicleOwnersListBunifuCustomDataGrid.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.vehicleOwnersListBunifuCustomDataGrid.HeaderForeColor = System.Drawing.Color.Beige
        Me.vehicleOwnersListBunifuCustomDataGrid.Location = New System.Drawing.Point(36, 128)
        Me.vehicleOwnersListBunifuCustomDataGrid.MultiSelect = False
        Me.vehicleOwnersListBunifuCustomDataGrid.Name = "vehicleOwnersListBunifuCustomDataGrid"
        Me.vehicleOwnersListBunifuCustomDataGrid.ReadOnly = True
        Me.vehicleOwnersListBunifuCustomDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.vehicleOwnersListBunifuCustomDataGrid.RowHeadersVisible = False
        Me.vehicleOwnersListBunifuCustomDataGrid.RowTemplate.Height = 24
        Me.vehicleOwnersListBunifuCustomDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.vehicleOwnersListBunifuCustomDataGrid.Size = New System.Drawing.Size(915, 404)
        Me.vehicleOwnersListBunifuCustomDataGrid.TabIndex = 11
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
        Me.BunifuTileButton1.LabelText = "ADD"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(36, 35)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(129, 84)
        Me.BunifuTileButton1.TabIndex = 0
        '
        'ownerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(993, 578)
        Me.Controls.Add(Me.vehicleOwnersListBunifuCustomDataGrid)
        Me.Controls.Add(Me.BunifuTileButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ownerForm"
        Me.Text = "ownerForm"
        CType(Me.vehicleOwnersListBunifuCustomDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents vehicleOwnersListBunifuCustomDataGrid As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
