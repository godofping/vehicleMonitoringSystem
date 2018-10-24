Imports MySql.Data.MySqlClient


Public Class addOwnerForm
    Dim connection As New MySqlConnection("datasource='" & My.Settings.datasource & "';port='" & My.Settings.port & "';username='" & My.Settings.username & "';password='" & My.Settings.password & "';database='" & My.Settings.database & "'")
    Dim ds As New DataSet
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Close()
    End Sub



    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Dim allSet As Boolean = True

        If firstNameTextBox.Text.Equals("") Then
            ErrorProvider1.SetError(firstNameTextBox, "Please enter first name.")
            allSet = False
        Else
            ErrorProvider1.SetError(firstNameTextBox, "")
        End If

        If middleNameTextBox.Text.Equals("") Then
            ErrorProvider1.SetError(middleNameTextBox, "Please enter middle name.")
            allSet = False
        Else
            ErrorProvider1.SetError(middleNameTextBox, "")
        End If

        If lastNameTextBox.Text.Equals("") Then
            ErrorProvider1.SetError(lastNameTextBox, "Please enter last name.")
            allSet = False
        Else
            ErrorProvider1.SetError(lastNameTextBox, "")
        End If

        If genderComboBox.Text.Equals("") Then
            ErrorProvider1.SetError(genderComboBox, "Please select gender.")
            allSet = False
        Else
            ErrorProvider1.SetError(genderComboBox, "")
        End If

        If phoneNumberTextBox.Text.Equals("") Then
            ErrorProvider1.SetError(phoneNumberTextBox, "Please enter phone number.")
            allSet = False
        ElseIf Not IsNumeric(phoneNumberTextBox.Text) Or phoneNumberTextBox.Text.Length <> 10 Then
            ErrorProvider1.SetError(phoneNumberTextBox, "Please enter correct phone number format.")
            allSet = False
        Else
            ErrorProvider1.SetError(phoneNumberTextBox, "")
        End If

        If roleComboBox.Text.Equals("") Then
            ErrorProvider1.SetError(roleComboBox, "Please select role.")
            allSet = False
        Else
            ErrorProvider1.SetError(roleComboBox, "")
        End If


        If allSet Then
            runQuery("insert into profile_table (firstName, middleName, lastName, gender, contactNumber, role, dateRegistered, imageLocation, isDeleted, birthDay) values ('" & firstNameTextBox.Text & "', '" & middleNameTextBox.Text & "', '" & lastNameTextBox.Text & "', '" & genderComboBox.Text & "', '" & phoneNumberTextBox.Text & "', '" & roleComboBox.Text & "', '" & DateTime.Now.ToString("yyyy-MM-dd") & "', 'asdsa', '0', '" & birthDateBunifuDatepicker.Value.ToString("yyyy-MM-dd") & "')")

        End If

    End Sub

    Private Sub runQuery(ByVal query As String)
        connection.Open()
        cmd = New MySqlCommand(query, connection)
        cmd.ExecuteReader()
        connection.Close()
        MsgBox("Added!")
    End Sub

    Private Sub roleComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles roleComboBox.SelectedIndexChanged
        If roleComboBox.Text.Equals("Personel") Then
            displayForm(peronelPanel)
        End If

        If roleComboBox.Text.Equals("Student") Then
            displayForm(studentPanel)
        End If


        If roleComboBox.Text.Equals("Student") Then
            displayForm(studentPanel)
        End If

        If roleComboBox.Text.Equals("Visitor") Then
            displayForm(visitorPanel)
        End If

    End Sub

    Private Sub displayForm(ByVal panelName As Object)
        peronelPanel.Visible = False
        studentPanel.Visible = False
        gradeSchoolPanel.Visible = False
        highSchoolPanel.Visible = False
        collegePanel.Visible = False
        strandPanel.Visible = False
        visitorPanel.Visible = False
        panelName.Visible = True

        If panelName Is gradeSchoolPanel Then
            studentPanel.Visible = True
            gradeSchoolPanel.Visible = True
        End If

        If panelName Is highSchoolPanel Then
            studentPanel.Visible = True
            highSchoolPanel.Visible = True
        End If

        If panelName Is collegePanel Then
            studentPanel.Visible = True
            collegePanel.Visible = True
        End If

        If panelName Is strandPanel Then
            studentPanel.Visible = True
            highSchoolPanel.Visible = True
            strandPanel.Visible = True
        End If




    End Sub

    Private Sub departmentCombBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles departmentCombBox.SelectedIndexChanged

        If departmentCombBox.Text.Equals("Grade School") Then
            displayForm(gradeSchoolPanel)
        End If

        If departmentCombBox.Text.Equals("High School") Then
            displayForm(highSchoolPanel)
        End If

        If departmentCombBox.Text.Equals("College") Then
            displayForm(collegePanel)
        End If

    End Sub

    Private Sub personelComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles personelComboBox.SelectedIndexChanged

        If personelComboBox.Text.Equals("Academic Personel") Then
            positionComboBox.Items.Clear()
            positionComboBox.Items.Add("Teacher")
            positionComboBox.Items.Add("Secretary")
            positionComboBox.Items.Add("Dean")
            positionComboBox.Items.Add("Program Head")
            positionComboBox.Items.Add("Principal")


        End If

        If personelComboBox.Text.Equals("Non Academic Personel") Then
            positionComboBox.Items.Clear()
            positionComboBox.Items.Add("Secretary")
            positionComboBox.Items.Add("Janitor")
            positionComboBox.Items.Add("Electrician")
            positionComboBox.Items.Add("Officer")
            positionComboBox.Items.Add("IT")
            positionComboBox.Items.Add("Driver")
            positionComboBox.Items.Add("Others")
        End If

        If personelComboBox.Text.Equals("Contructual") Then
            positionComboBox.Items.Clear()
            positionComboBox.Items.Add("Guard")
            positionComboBox.Items.Add("Paintor")
            positionComboBox.Items.Add("Mason")
            positionComboBox.Items.Add("Carpenter")
            positionComboBox.Items.Add("Others")
        End If

        If personelComboBox.Text.Equals("Part Time") Then
            positionComboBox.Items.Clear()
            positionComboBox.Items.Add("Part Time Teacher")
        End If

    End Sub

    Private Sub highSchoolGradeLevel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles highSchoolGradeLevel.SelectedIndexChanged
        If highSchoolGradeLevel.Text.Equals("Grade 11") Or highSchoolGradeLevel.Text.Equals("Grade 12") Then
            displayForm(strandPanel)
        Else
            displayForm(highSchoolPanel)
        End If
    End Sub
End Class