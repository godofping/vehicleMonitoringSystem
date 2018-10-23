Public Class mainForm




    'sub functions
    Private Sub changePanelDisplay(ByVal nameOfForm As Object)
        parentPanel.Controls.Clear()
        nameOfForm.TopLevel = False
        parentPanel.Controls.Add(nameOfForm)
        nameOfForm.Show()
    End Sub

    Private Sub BunifuTileButton4_Click(sender As Object, e As EventArgs) Handles homeButton.Click
        changePanelDisplay(homeForm)
        titleLabel.Text = "Home"
    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changePanelDisplay(homeForm)
        titleLabel.Text = "Home"
    End Sub

    Private Sub ownersButton_Click(sender As Object, e As EventArgs) Handles ownersButton.Click
        changePanelDisplay(ownerForm)
        titleLabel.Text = "Owners"
    End Sub
End Class