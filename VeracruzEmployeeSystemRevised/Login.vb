Imports MySql.Data.MySqlClient

Public Class Login

    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader

    Dim ShowPassword As Boolean = False

    Dim email As String
    Dim password As String
    Dim Current_DB As String = "employeedb"

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SignUp_Button.Click
        Me.Hide()
        Dim Register As New Register
        Register.Show()
    End Sub


    'SIGN-IN BUTTON
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SignIn_Button.Click

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = $"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;"

        Try
            MySqlConn.Open()
            Dim Query As String = $"select * from {Current_DB}.employees where BINARY email = @email and BINARY password = @password;"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.Parameters.AddWithValue("@email", email)
            Command.Parameters.AddWithValue("@password", password)
            Reader = Command.ExecuteReader

            If Reader.HasRows = True Then
                MessageBox.Show($"Email {email} Found! {vbNewLine}Password Found {password}!")
                Dim Dashboard As New Dashboard
                Dashboard.email = email
                Dashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show($"Email {email} Not Found!{vbNewLine}Password {password} Not Found!")
                Return
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try




    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Password_Box.TextChanged
        password = Password_Box.Text
    End Sub

    'ShowPassword CheckBox
    Private Sub ShowPassword_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword_CheckBox.CheckedChanged
        If ShowPassword_CheckBox.Checked = False Then
            Password_Box.PasswordChar = "*"
        Else
            Password_Box.PasswordChar = ""
        End If
    End Sub

    'Email-Box 
    Private Sub Email_Box_TextChanged(sender As Object, e As EventArgs) Handles Email_Box.TextChanged
        email = Email_Box.Text
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class