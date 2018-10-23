<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homeForm
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
        Me.timeLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dateLabel = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.SuspendLayout()
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.BackColor = System.Drawing.Color.Transparent
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.ForeColor = System.Drawing.Color.White
        Me.timeLabel.Location = New System.Drawing.Point(22, 24)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(305, 113)
        Me.timeLabel.TabIndex = 4
        Me.timeLabel.Text = "12:00"
        Me.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.BackColor = System.Drawing.Color.Transparent
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.ForeColor = System.Drawing.Color.White
        Me.dateLabel.Location = New System.Drawing.Point(34, 125)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(107, 39)
        Me.dateLabel.TabIndex = 5
        Me.dateLabel.Text = "12:00"
        Me.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(655, 489)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(247, 39)
        Me.BunifuCustomLabel1.TabIndex = 6
        Me.BunifuCustomLabel1.Text = "LOGS TODAY"
        Me.BunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 70.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(689, 364)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(187, 132)
        Me.BunifuCustomLabel2.TabIndex = 7
        Me.BunifuCustomLabel2.Text = "21"
        Me.BunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 10
        Me.BunifuSeparator1.Location = New System.Drawing.Point(54, 242)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(890, 43)
        Me.BunifuSeparator1.TabIndex = 8
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'homeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(993, 578)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.timeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "homeForm"
        Me.Text = "homeForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timeLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dateLabel As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
End Class
