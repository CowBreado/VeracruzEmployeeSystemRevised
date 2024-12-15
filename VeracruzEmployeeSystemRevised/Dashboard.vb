Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Public Class Dashboard

    'Creating a bunch of necessary variables to manipulate and use MySql related procedures.
    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim dbDataSet As New DataTable

    Dim Current_DB As String = "employeedb"
    Dim Gender As String

    Dim FirstName As String
    Dim LastName As String
    Dim MiddleName As String
    Dim BirthDate As DateTime
    Dim EmployeeID As String
    Dim EmailAddress As String

    Public Property email As String
    Public Property password As String


    Public Sub MakeConnection()
        MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
        MySqlConn.Open()
        Dim Query As String = $"select FirstName, LastName, MiddleName, BirthDate, Email, EmployeeID, Gender from {Current_DB}.employees where email = @email"
        Command = New MySqlCommand(Query, MySqlConn)
        Command.Parameters.AddWithValue("@email", email)
        Reader = Command.ExecuteReader
        If Reader.HasRows Then
            Reader.Read()
            FirstName = Reader("FirstName").ToString()
            LastName = Reader("LastName").ToString()
            MiddleName = Reader("MiddleName").ToString()
            BirthDate = Reader.GetDateTime("BirthDate")
            Gender = Reader("Gender").ToString()
            EmailAddress = Reader("Email").ToString()
            EmployeeID = Reader("EmployeeID").ToString()

            Display_Employee_Name_Label.Text = $"{LastName}, {FirstName}, {MiddleName}"

            FirstName_LabelDisplay.Text = FirstName
            LastName_LabelDisplay.Text = LastName
            MiddleName_LabelDisplay.Text = MiddleName
            BirthDate_DisplayLabel.Text = BirthDate
            Email_LabelDisplay.Text = EmailAddress
            EmployeeID_LabelDisplay.Text = EmployeeID
            Sex_TextBox.Text = Gender
        End If
        Reader.Close()
        MySqlConn.Close()
    End Sub



    Public Function CheckEmployeeID(id As String) As Boolean
        Try
            MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
            MySqlConn.Open()

            Dim CheckEmployeeIDQuery As String
            CheckEmployeeIDQuery = $"SELECT * FROM {Current_DB}.employees WHERE EmployeeID = @id"
            Command = New MySqlCommand(CheckEmployeeIDQuery, MySqlConn)
            Command.Parameters.AddWithValue("@id", id)
            Reader = Command.ExecuteReader
            If Reader.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MySqlConn.Close()
        Reader.Close()
    End Function

    Public Function CheckExistingEmployee(email As String) As Boolean
        Try
            MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
            MySqlConn.Open()

            Dim CheckEmployeeQuery As String
            CheckEmployeeQuery = $"SELECT * FROM {Current_DB}.employees WHERE Email = @email"
            Command = New MySqlCommand(CheckEmployeeQuery, MySqlConn)
            Command.Parameters.AddWithValue("@email", email)
            Reader = Command.ExecuteReader
            If Reader.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MySqlConn.Close()
        Reader.Close()
    End Function


    'This is the button responsible for connecting the database to the visual studio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles DBConnect_Button.Click
        MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
        Try
            MySqlConn.Open()
            MessageBox.Show($"Connection To MySql Database ({Current_DB}) Successfully Established!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MySqlConn.Close()
    End Sub

    Private Sub My_Profile_Button_Click(sender As Object, e As EventArgs) Handles My_Profile_Button.Click



        Try
            MakeConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Nian_Panel.Visible = True
        Update_Panel1.Visible = False
        Home_Panel.Visible = False
        Delete_Panel1.Visible = False


    End Sub

    Private Sub Logout_Button_Click(sender As Object, e As EventArgs) Handles Logout_Button.Click
        Dim Form1 As New Login
        Form1.Show()
        Me.Hide()
    End Sub

    'Display Employee Name, WORK IN PROGRESS # # # #
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Display_Employee_Name_Label.Click

    End Sub





    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MakeConnection()
        LoadDataGridView()
        MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = $"SELECT * FROM {Current_DB}.employees"
            Command = New MySqlCommand(Query, MySqlConn)
            Reader = Command.ExecuteReader

            While Reader.Read
                Dim FirstName = Reader.GetString("FirstName")
                FirstName0_ComboBox.Items.Add(FirstName)
                FirstName0_ListBox.Items.Add(FirstName)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        MySqlConn.Close()
        Reader.Close()
    End Sub
















    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Update_Panel1.Visible = True
        Nian_Panel.Visible = False
        Home_Panel.Visible = False
        Delete_Panel1.Visible = False


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Home_Panel.Visible = True
        Update_Panel1.Visible = False
        Nian_Panel.Visible = False
        Delete_Panel1.Visible = False
    End Sub

    Private Sub SignUp_Button_Click_3(sender As Object, e As EventArgs) Handles SignUp_Button.Click
        'Initialize variable that will be set to replace the existing information
        Dim FirstName2, LastName2, MiddleName2, Password2 As String
        Dim BirthDate2 As Date

        'Verify the inputted BirthDate
        If BirthDate2_DateTimePicker.Value = BirthDate2_DateTimePicker.MinDate Then
            BirthDate2 = New DateTime(1900, 1, 1)
        Else
            BirthDate2 = BirthDate2_DateTimePicker.Value
        End If
        FirstName2 = FirstName2_TextBox.Text
        LastName2 = LastName2_TextBox.Text
        MiddleName2 = MiddleName2_TextBox.Text
        Password2 = Password2_TextBox.Text
        'Now Lets Make A Query That Will Update The Information In The Database Based On Our Inputs and Email Address
        Try
            MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
            MySqlConn.Open()
            Dim UpdateQuery As String
            UpdateQuery = $"UPDATE {Current_DB}.employees SET FirstName = @FirstName, LastName = @LastName, MiddleName = @MiddleName, BirthDate = @BirthDate, Password = @Password WHERE email = @email"
            Command = New MySqlCommand(UpdateQuery, MySqlConn)
            Command.Parameters.AddWithValue("@FirstName", FirstName2)
            Command.Parameters.AddWithValue("@LastName", LastName2)
            Command.Parameters.AddWithValue("@Password", Password2)
            Command.Parameters.AddWithValue("@MiddleName", MiddleName2)
            Command.Parameters.AddWithValue("@BirthDate", BirthDate2)
            Command.Parameters.AddWithValue("@email", email)
            Command.ExecuteNonQuery()
            MessageBox.Show("Profile updated successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MySqlConn.Close()

        Display_Employee_Name_Label.Text = $"{LastName2}, {FirstName2}, {MiddleName2}"
    End Sub

    Private Sub Home_Panel_Paint(sender As Object, e As PaintEventArgs)
        Delete_Panel1.Visible = True
        Nian_Panel.Visible = False
        Update_Panel1.Visible = False
        Home_Panel.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Delete_Panel1.Visible = True
        Home_Panel.Visible = False
        Update_Panel1.Visible = False
        Nian_Panel.Visible = False
    End Sub

    Private Sub ShowPassword_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword_CheckBox.CheckedChanged
        If ShowPassword_CheckBox.Checked Then
            Password2_TextBox.PasswordChar = "*"
        Else
            Password2_TextBox.PasswordChar = ""
        End If
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim IsExisting As Boolean = CheckEmployeeID(EmployeeID3_TextBox.Text)

            MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
            MySqlConn.Open()

            If IsExisting Then
                Reader.Read()
                FirstName3_Label.Text = Reader("FirstName").ToString
                LastName3_Label.Text = Reader("LastName").ToString
                MiddleName3_Label.Text = Reader("MiddleName").ToString
                BirthDate3_Label.Text = Reader.GetDateTime("BirthDate")
                EmailAddress3_Label.Text = Reader("Email").ToString
                EmployeeID3_Label.Text = Reader("EmployeeID").ToString

            Else
                FirstName3_Label.Text = Nothing
                LastName3_Label.Text = Nothing
                MiddleName3_Label.Text = Nothing
                BirthDate3_Label.Text = Nothing
                EmailAddress3_Label.Text = Nothing
                EmployeeID3_Label.Text = Nothing
                MessageBox.Show("Invalid Operation! Employee ID Does Not Exist!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        MySqlConn.Close()
        Reader.Close()

    End Sub

    Private Sub Button3_Click_3(sender As Object, e As EventArgs) Handles Button3.Click
        Dim IsExisting = CheckEmployeeID(EmployeeID3_TextBox.Text)
        Try
            If IsExisting Then
                MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
                MySqlConn.Open()

                Dim DeleteQuery As String
                DeleteQuery = $"DELETE FROM {Current_DB}.employees WHERE EmployeeID = @id"
                Command = New MySqlCommand(DeleteQuery, MySqlConn)
                Command.Parameters.AddWithValue("@id", EmployeeID3_TextBox.Text)
                Reader = Command.ExecuteReader
                MessageBox.Show("Account Deleted Successfully!")

                MySqlConn.Close()
                Reader.Close()

                Hide()
                Dim Register As New Register
                Register.Show()
            Else
                MessageBox.Show("Invalid Operation! Employee ID Does Not Exist!")
                Reader.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub Save0_Button_Click(sender As Object, e As EventArgs) Handles Save0_Button.Click
        LoadDataGridView()
        email = Email0_TextBox.Text
        If BirthDate0_DateTimePicker.Value = BirthDate0_DateTimePicker.MinDate Then
            BirthDate = New DateTime(1900, 1, 1)
        Else
            BirthDate = BirthDate0_DateTimePicker.Value
        End If

        Try
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = $"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;"
            MySqlConn.Open()
            Dim IsExisting As Boolean = CheckExistingEmployee(Email0_TextBox.Text)
            Reader.Close()

            Dim IsExisting1 As Boolean = CheckEmployeeID(Email0_TextBox.Text)
            Reader.Close()

            If Not IsExisting AndAlso Not IsExisting1 Then
                Dim Query As String = $"INSERT INTO {Current_DB}.employees (FirstName, LastName, MiddleName, BirthDate, Email, Password, Gender) VALUES (@FirstName, @LastName, @MiddleName, @BirthDate, @Email, @Password, @Gender)"
                Command = New MySqlCommand(Query, MySqlConn)
                Command.Parameters.AddWithValue("@FirstName", FirstName0_TextBox.Text)
                Command.Parameters.AddWithValue("@LastName", LastName0_TextBox.Text)
                Command.Parameters.AddWithValue("@MiddleName", MiddleName0_TextBox.Text)
                Command.Parameters.AddWithValue("@BirthDate", BirthDate)
                Command.Parameters.AddWithValue("@Gender", Gender)
                Command.Parameters.AddWithValue("@Email", email)
                Command.Parameters.AddWithValue("@Password", Password0_TextBox.Text)
                Reader = Command.ExecuteReader
                MessageBox.Show("Account Information Successfully Saved!")
            Else
                MessageBox.Show("Invalid Operation, Existing Account Found!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MySqlConn.Close()
        Reader.Close()

    End Sub

    Private Sub Update0_Button_Click(sender As Object, e As EventArgs) Handles Update0_Button.Click
        LoadDataGridView()
        email = Email0_TextBox.Text
        If BirthDate0_DateTimePicker.Value = BirthDate0_DateTimePicker.MinDate Then
            BirthDate = New DateTime(1900, 1, 1)
        Else
            BirthDate = BirthDate0_DateTimePicker.Value
        End If


        Try
            Dim IsExisting = CheckEmployeeID(EmployeeID0_TextBox.Text)
            Reader.Close()

            If IsExisting Then
                MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
                MySqlConn.Open()
                Dim UpdateQuery As String
                UpdateQuery = $"UPDATE {Current_DB}.employees SET FirstName = @FirstName, LastName = @LastName, MiddleName = @MiddleName, BirthDate = @BirthDate, Password = @Password, Email = @Email, Gender = @Gender WHERE EmployeeID = @id"
                Command = New MySqlCommand(UpdateQuery, MySqlConn)
                Command.Parameters.AddWithValue("@FirstName", FirstName0_TextBox.Text)
                Command.Parameters.AddWithValue("@LastName", LastName0_TextBox.Text)
                Command.Parameters.AddWithValue("@MiddleName", MiddleName0_TextBox.Text)
                Command.Parameters.AddWithValue("@BirthDate", BirthDate)
                Command.Parameters.AddWithValue("@Gender", Gender)
                Command.Parameters.AddWithValue("@Email", email)
                Command.Parameters.AddWithValue("@Password", Password0_TextBox.Text)
                Command.Parameters.AddWithValue("@id", EmployeeID0_TextBox.Text)
                Command.ExecuteNonQuery()
                MessageBox.Show("Profile updated successfully!")

            Else
                MessageBox.Show("Invalid Operation! Employee ID Does Not Exist!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MySqlConn.Close()
        Display_Employee_Name_Label.Text = $"{LastName0_TextBox.Text}, {FirstName0_TextBox.Text}, {MiddleName0_TextBox.Text}"
    End Sub

    Private Sub Delete0_Button_Click(sender As Object, e As EventArgs) Handles Delete0_Button.Click
        LoadDataGridView()
        email = Email0_TextBox.Text
        Dim IsExisting As Boolean = CheckEmployeeID(EmployeeID0_TextBox.Text)
        Reader.Close()
        Try
            If IsExisting Then
                MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
                MySqlConn.Open()

                Dim DeleteQuery As String
                DeleteQuery = $"DELETE FROM {Current_DB}.employees WHERE EmployeeID = @id"
                Command = New MySqlCommand(DeleteQuery, MySqlConn)
                Command.Parameters.AddWithValue("@id", EmployeeID0_TextBox.Text)
                Reader = Command.ExecuteReader
                MessageBox.Show("Account Deleted Successfully!")
                MySqlConn.Close()
                Reader.Close()

                Dim Register As New Register
                Register.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid Operation! Employee ID Does Not Exist!")
                Reader.Close()
                MySqlConn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FirstName0_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FirstName0_ComboBox.SelectedIndexChanged
        Try
            MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
            MySqlConn.Open()

            Dim Query As String
            Query = $"SELECT * FROM {Current_DB}.employees WHERE FirstName = @FirstName"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.Parameters.AddWithValue("@FirstName", FirstName0_ComboBox.Text)
            Reader = Command.ExecuteReader

            While Reader.Read
                EmployeeID0_TextBox.Text = Reader.GetInt32("EmployeeID")
                FirstName0_TextBox.Text = Reader.GetString("FirstName")
                LastName0_TextBox.Text = Reader.GetString("LastName")
                MiddleName0_TextBox.Text = Reader.GetString("MiddleName")
                Email0_TextBox.Text = Reader.GetString("Email")
                Password0_TextBox.Text = Reader.GetString("Password")
                'BirthDate0_DateTimePicker.Value = Reader.GetDateTime(BirthDate)
                BirthDate0_DateTimePicker.Value = Reader.GetDateTime("BirthDate")
            End While
            'MessageBox.Show($"The Selected Item in ComboBox: {FirstName0_ComboBox.Text}")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MySqlConn.Close()
        Reader.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FirstName0_ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FirstName0_ListBox.SelectedIndexChanged
        Try
            MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
            MySqlConn.Open()

            Dim Query As String
            Query = $"SELECT * FROM {Current_DB}.employees WHERE FirstName = @FirstName"
            Command = New MySqlCommand(Query, MySqlConn)
            Command.Parameters.AddWithValue("@FirstName", FirstName0_ListBox.Text)
            Reader = Command.ExecuteReader

            While Reader.Read
                EmployeeID0_TextBox.Text = Reader.GetInt32("EmployeeID")
                FirstName0_TextBox.Text = Reader.GetString("FirstName")
                LastName0_TextBox.Text = Reader.GetString("LastName")
                MiddleName0_TextBox.Text = Reader.GetString("MiddleName")
                Email0_TextBox.Text = Reader.GetString("Email")
                Password0_TextBox.Text = Reader.GetString("Password")
                BirthDate0_DateTimePicker.Value = Reader.GetDateTime("BirthDate")
            End While
            'MessageBox.Show($"The Selected Item in ComboBox: {FirstName0_ComboBox.Text}")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MySqlConn.Close()
        Reader.Close()

    End Sub

    Private Sub LoadDataGridView()
        MySqlConn = New MySqlConnection
        MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource


        Try
            MySqlConn.Open()
            dbDataSet.Clear()
            Dim Query As String
            Query = $"SELECT * FROM {Current_DB}.employees"
            Command = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            Employees0_DataGridView.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub




    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        LoadDataGridView()
        'Dim Yearr = Year(BirthDate)
        'MessageBox.Show($"Year: {Yearr}")
    End Sub

    Private Sub Employees0_DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Employees0_DataGridView.CellContentClick


        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.Employees0_DataGridView.Rows(e.RowIndex)
                'Debug1
                EmployeeID0_TextBox.Text = row.Cells("EmployeeID").Value.ToString()
                FirstName0_TextBox.Text = row.Cells("FirstName").Value.ToString()
                LastName0_TextBox.Text = row.Cells("LastName").Value.ToString()
                MiddleName0_TextBox.Text = row.Cells("MiddleName").Value.ToString()
                Email0_TextBox.Text = row.Cells("Email").Value.ToString()
                Password0_TextBox.Text = row.Cells("Password").Value.ToString()
                Gender = row.Cells("Gender").Value.ToString()
                BirthDate0_DateTimePicker.Value = row.Cells("BirthDate").Value.ToString()
            End If
        Catch ex As Exception
        End Try


    End Sub

    Private Sub Search_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Search_TextBox.TextChanged
        Try
            Dim DV As New DataView(dbDataSet)
            DV.RowFilter = String.Format($"FirstName LIKE '%{Search_TextBox.Text}%'")
            Employees0_DataGridView.DataSource = DV
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Dim Dialog As DialogResult
        Dialog = MessageBox.Show("Confirm Exit?", "Exit", MessageBoxButtons.YesNo)
        If Dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Gender = "Female"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Gender = "Female"
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub BirthDate0_DateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles BirthDate0_DateTimePicker.ValueChanged

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub LoadChart_Button_Click(sender As Object, e As EventArgs) Handles LoadChart_Button.Click
        MySqlConn = New MySqlConnection($"server=127.0.0.1;database={Current_DB};Uid=root;Pwd=;")
        Try
            MySqlConn.Open()
            Dim Query As String = $"select * from {Current_DB}.employees"
            Command = New MySqlCommand(Query, MySqlConn)
            Reader = Command.ExecuteReader()

            While Reader.Read
                Chart1.Series("EmployeeID-BirthDate").Points.AddXY(Reader.GetInt32("EmployeeID"), Reader.GetDateTime("BirthDate"))
            End While


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MySqlConn.Close()
    End Sub
End Class
