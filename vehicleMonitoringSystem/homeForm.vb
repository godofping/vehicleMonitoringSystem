Public Class homeForm
    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub homeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayTime()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        displayTime()
    End Sub

    Private Sub displayTime()
        dateLabel.Text = Format(Now, "dddd, MMMM dd yyyy")
        timeLabel.Text = Format(Now, "hh:mm tt")
    End Sub
End Class