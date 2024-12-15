Imports MySql.Data.MySqlClient

Public Class Register

    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim Current_DB As String = "employeedb"

    Dim FirstName As String
    Dim LastName As String
    Dim MiddleName As String
    Dim Gender As String

    Dim EmailAddress As String
    Dim Password As String
    Dim BirthDate As DateTime
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SignIn_Button.Click
        Dim Login As New Login
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SignUp_Button.Click

        'MessageBox.Show(BirthDate)
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = $"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;"
        Try


            If BirthDate_DateTimePicker.Value = BirthDate_DateTimePicker.MinDate Then
                BirthDate = New DateTime(1900, 1, 1)
            Else
                BirthDate = BirthDate_DateTimePicker.Value
            End If

            MySqlConn.Open()
            'This first check if the email you want to sign up with is already existing or not.
            Dim Check_If_Exist_Query As String = $"select * from {Current_DB}.employees where email = @Email"
            Command = New MySqlCommand(Check_If_Exist_Query, MySqlConn)
            Command.Parameters.AddWithValue("@Email", EmailAddress)
            Reader = Command.ExecuteReader

            If Not Reader.HasRows Then
                Reader.Close()
                Dim Query As String = $"insert into {Current_DB}.employees(FirstName, LastName, MiddleName, BirthDate, Email, Password, Gender) Values (@FirstName, @LastName, @MiddleName, @BirthDate, @EmailAddress, @Password, @Gender)"
                Command = New MySqlCommand(Query, MySqlConn)
                Command.Parameters.AddWithValue("@FirstName", FirstName)
                Command.Parameters.AddWithValue("@LastName", LastName)
                Command.Parameters.AddWithValue("@MiddleName", MiddleName)
                Command.Parameters.AddWithValue("@BirthDate", BirthDate)
                Command.Parameters.AddWithValue("@Gender", Gender)
                Command.Parameters.AddWithValue("@EmailAddress", EmailAddress)
                Command.Parameters.AddWithValue("@Password", Password)
                Reader = Command.ExecuteReader
                MessageBox.Show("Account Information Successfully Saved!")
                Me.Hide()
                Dim LoginPage As New Login
                LoginPage.Show()


            Else
                MessageBox.Show("Invalid Operation, Existing Account Found!")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Private Sub FirstName_TextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstName_TextBox.TextChanged
        FirstName = FirstName_TextBox.Text
    End Sub

    Private Sub BirthDate_DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles BirthDate_DateTimePicker.ValueChanged

        If BirthDate_DateTimePicker.Value = BirthDate_DateTimePicker.MinDate Then

            BirthDate = DateTime.Now
        Else

            BirthDate = BirthDate_DateTimePicker.Value
        End If
    End Sub


    Private Sub LastName_TextBox_TextChanged(sender As Object, e As EventArgs) Handles LastName_TextBox.TextChanged
        LastName = LastName_TextBox.Text
    End Sub

    Private Sub EmailAddress_TextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailAddress_TextBox.TextChanged
        EmailAddress = EmailAddress_TextBox.Text
    End Sub

    Private Sub Password_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Password_TextBox.TextChanged
        Password = Password_TextBox.Text
    End Sub

    Private Sub ShowPassword_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword_CheckBox.CheckedChanged
        If ShowPassword_CheckBox.Checked = False Then
            Password_TextBox.PasswordChar = "*"
        Else
            Password_TextBox.PasswordChar = ""
        End If
    End Sub

    Private Sub MiddleName_TextBox_TextChanged(sender As Object, e As EventArgs) Handles MiddleName_TextBox.TextChanged
        MiddleName = MiddleName_TextBox.Text
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Gender = "Female"
    End Sub
End Class