Imports MySql.Data.MySqlClient

Public Class loginForm
    Dim connection As New MySqlConnection("datasource='" & My.Settings.datasource & "';port='" & My.Settings.port & "';username='" & My.Settings.username & "';password='" & My.Settings.password & "';database='" & My.Settings.database & "'")
    Dim ds As New DataSet
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()

    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        'check if account is existing
        connection.Open()
        cmd = New MySqlCommand("SELECT COUNT(*) As result FROM admin_table where userName = '" & usernameTextBox.Text & "' and passWord = '" & passwordTextBox.Text & "'", connection)
        reader = cmd.ExecuteReader
        reader.Read()
        Dim result As Integer = reader.GetInt32("result")

        If result = 1 Then

            connection.Close()
            MsgBox("Login Successful!", 0, "")
            Me.Hide()
            mainForm.Show()

        Else
            connection.Close()
            MsgBox("Login Failed!", 0, "")
        End If

    End Sub
End Class
