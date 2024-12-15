<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New DataVisualization.Charting.Series()
        DBConnect_Button = New Button()
        Top_Panel = New Panel()
        Display_Employee_Name_Label = New Label()
        PictureBox2 = New PictureBox()
        Logout_Button = New Button()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Left_Panel = New Panel()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        My_Profile_Button = New Button()
        Label4 = New Label()
        Nian_Panel = New Panel()
        Sex_TextBox = New Label()
        Label34 = New Label()
        BirthDate_DisplayLabel = New Label()
        Email_LabelDisplay = New Label()
        EmployeeID_LabelDisplay = New Label()
        MiddleName_LabelDisplay = New Label()
        LastName_LabelDisplay = New Label()
        FirstName_LabelDisplay = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Delete_Panel1 = New Panel()
        Delete_Panel2 = New Panel()
        Button5 = New Button()
        Label10 = New Label()
        BirthDate3_Label = New Label()
        EmailAddress3_Label = New Label()
        EmployeeID3_Label = New Label()
        MiddleName3_Label = New Label()
        LastName3_Label = New Label()
        FirstName3_Label = New Label()
        Label28 = New Label()
        Label29 = New Label()
        Label30 = New Label()
        Label31 = New Label()
        Label32 = New Label()
        Label33 = New Label()
        EmployeeID3_TextBox = New TextBox()
        Label17 = New Label()
        Label22 = New Label()
        Button3 = New Button()
        Label25 = New Label()
        Home_Panel = New Panel()
        Panel1 = New Panel()
        LoadChart_Button = New Button()
        Chart1 = New DataVisualization.Charting.Chart()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label26 = New Label()
        Label24 = New Label()
        Search_TextBox = New TextBox()
        Employees0_DataGridView = New DataGridView()
        Button6 = New Button()
        FirstName0_ListBox = New ListBox()
        FirstName0_ComboBox = New ComboBox()
        BirthDate0_DateTimePicker = New DateTimePicker()
        Label37 = New Label()
        Password0_TextBox = New TextBox()
        Label23 = New Label()
        Email0_TextBox = New TextBox()
        EmployeeID0_TextBox = New TextBox()
        MiddleName0_TextBox = New TextBox()
        LastName0_TextBox = New TextBox()
        FirstName0_TextBox = New TextBox()
        Label21 = New Label()
        Label38 = New Label()
        Label39 = New Label()
        Label40 = New Label()
        Label41 = New Label()
        Label42 = New Label()
        Update0_Button = New Button()
        Save0_Button = New Button()
        Delete0_Button = New Button()
        Update_Panel1 = New Panel()
        Update_Panel2 = New Panel()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        Label27 = New Label()
        ShowPassword_CheckBox = New CheckBox()
        BirthDate2_DateTimePicker = New DateTimePicker()
        Label3 = New Label()
        MiddleName2_TextBox = New TextBox()
        Password2_TextBox = New TextBox()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        SignUp_Button = New Button()
        LastName2_TextBox = New TextBox()
        Label18 = New Label()
        FirstName2_TextBox = New TextBox()
        Label19 = New Label()
        Label20 = New Label()
        Top_Panel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Left_Panel.SuspendLayout()
        Nian_Panel.SuspendLayout()
        Delete_Panel1.SuspendLayout()
        Delete_Panel2.SuspendLayout()
        Home_Panel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Employees0_DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        Update_Panel1.SuspendLayout()
        Update_Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' DBConnect_Button
        ' 
        DBConnect_Button.BackColor = Color.DimGray
        DBConnect_Button.FlatAppearance.BorderSize = 0
        DBConnect_Button.FlatStyle = FlatStyle.Flat
        DBConnect_Button.ForeColor = Color.White
        DBConnect_Button.Location = New Point(0, 489)
        DBConnect_Button.Name = "DBConnect_Button"
        DBConnect_Button.Size = New Size(104, 75)
        DBConnect_Button.TabIndex = 0
        DBConnect_Button.Text = "CHECK DATABASE CONNECTION"
        DBConnect_Button.UseVisualStyleBackColor = False
        ' 
        ' Top_Panel
        ' 
        Top_Panel.BackColor = Color.DimGray
        Top_Panel.Controls.Add(Display_Employee_Name_Label)
        Top_Panel.Controls.Add(PictureBox2)
        Top_Panel.Controls.Add(Logout_Button)
        Top_Panel.Controls.Add(PictureBox1)
        Top_Panel.Controls.Add(Label2)
        Top_Panel.Controls.Add(Label1)
        Top_Panel.Dock = DockStyle.Top
        Top_Panel.Location = New Point(0, 0)
        Top_Panel.Name = "Top_Panel"
        Top_Panel.Size = New Size(1102, 99)
        Top_Panel.TabIndex = 13
        ' 
        ' Display_Employee_Name_Label
        ' 
        Display_Employee_Name_Label.BackColor = Color.DimGray
        Display_Employee_Name_Label.Font = New Font("Sylfaen", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Display_Employee_Name_Label.ForeColor = Color.Transparent
        Display_Employee_Name_Label.Location = New Point(653, 18)
        Display_Employee_Name_Label.Name = "Display_Employee_Name_Label"
        Display_Employee_Name_Label.Size = New Size(369, 25)
        Display_Employee_Name_Label.TabIndex = 19
        Display_Employee_Name_Label.Text = "LastName, FirstName, MiddleName"
        Display_Employee_Name_Label.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1024, 11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(65, 52)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 20
        PictureBox2.TabStop = False
        ' 
        ' Logout_Button
        ' 
        Logout_Button.BackColor = Color.DimGray
        Logout_Button.FlatAppearance.BorderSize = 0
        Logout_Button.FlatStyle = FlatStyle.Flat
        Logout_Button.Font = New Font("Microsoft Sans Serif", 8.25F)
        Logout_Button.ForeColor = Color.White
        Logout_Button.Location = New Point(1005, 62)
        Logout_Button.Name = "Logout_Button"
        Logout_Button.Size = New Size(100, 37)
        Logout_Button.TabIndex = 19
        Logout_Button.Text = "Sign out"
        Logout_Button.UseMnemonic = False
        Logout_Button.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(77, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Sylfaen", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(109, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(361, 27)
        Label2.TabIndex = 1
        Label2.Text = "EMPLOYEE MANAGEMENT SYSTEM"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Sylfaen", 33.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(101, 5)
        Label1.Name = "Label1"
        Label1.Size = New Size(375, 58)
        Label1.TabIndex = 0
        Label1.Text = "RHODES ISLAND"
        ' 
        ' Left_Panel
        ' 
        Left_Panel.BackColor = Color.DimGray
        Left_Panel.Controls.Add(Button4)
        Left_Panel.Controls.Add(Button2)
        Left_Panel.Controls.Add(Button1)
        Left_Panel.Controls.Add(DBConnect_Button)
        Left_Panel.Controls.Add(My_Profile_Button)
        Left_Panel.Controls.Add(Label4)
        Left_Panel.Dock = DockStyle.Left
        Left_Panel.Location = New Point(0, 99)
        Left_Panel.Name = "Left_Panel"
        Left_Panel.Size = New Size(100, 564)
        Left_Panel.TabIndex = 14
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DimGray
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Sylfaen", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Location = New Point(5, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(92, 30)
        Button4.TabIndex = 19
        Button4.Text = "HOME"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DimGray
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 8.25F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(0, 110)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 41)
        Button2.TabIndex = 17
        Button2.Text = "Delete Profile"
        Button2.UseMnemonic = False
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DimGray
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 8.25F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(0, 72)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 41)
        Button1.TabIndex = 18
        Button1.Text = "Update Profile"
        Button1.UseMnemonic = False
        Button1.UseVisualStyleBackColor = False
        ' 
        ' My_Profile_Button
        ' 
        My_Profile_Button.BackColor = Color.DimGray
        My_Profile_Button.FlatAppearance.BorderSize = 0
        My_Profile_Button.FlatStyle = FlatStyle.Flat
        My_Profile_Button.Font = New Font("Microsoft Sans Serif", 8.25F)
        My_Profile_Button.ForeColor = Color.White
        My_Profile_Button.Location = New Point(0, 36)
        My_Profile_Button.Name = "My_Profile_Button"
        My_Profile_Button.Size = New Size(100, 41)
        My_Profile_Button.TabIndex = 16
        My_Profile_Button.Text = "View Profile"
        My_Profile_Button.UseMnemonic = False
        My_Profile_Button.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(4, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 26)
        Label4.TabIndex = 15
        Label4.Text = "_____________________"
        ' 
        ' Nian_Panel
        ' 
        Nian_Panel.BackgroundImageLayout = ImageLayout.Zoom
        Nian_Panel.Controls.Add(Sex_TextBox)
        Nian_Panel.Controls.Add(Label34)
        Nian_Panel.Controls.Add(BirthDate_DisplayLabel)
        Nian_Panel.Controls.Add(Email_LabelDisplay)
        Nian_Panel.Controls.Add(EmployeeID_LabelDisplay)
        Nian_Panel.Controls.Add(MiddleName_LabelDisplay)
        Nian_Panel.Controls.Add(LastName_LabelDisplay)
        Nian_Panel.Controls.Add(FirstName_LabelDisplay)
        Nian_Panel.Controls.Add(Label13)
        Nian_Panel.Controls.Add(Label12)
        Nian_Panel.Controls.Add(Label11)
        Nian_Panel.Controls.Add(Label8)
        Nian_Panel.Controls.Add(Label9)
        Nian_Panel.Controls.Add(Label7)
        Nian_Panel.Controls.Add(Label6)
        Nian_Panel.Controls.Add(Label5)
        Nian_Panel.Dock = DockStyle.Fill
        Nian_Panel.Location = New Point(100, 99)
        Nian_Panel.Name = "Nian_Panel"
        Nian_Panel.Size = New Size(1002, 564)
        Nian_Panel.TabIndex = 15
        Nian_Panel.Visible = False
        ' 
        ' Sex_TextBox
        ' 
        Sex_TextBox.AutoSize = True
        Sex_TextBox.Font = New Font("Sylfaen", 15F)
        Sex_TextBox.Location = New Point(653, 203)
        Sex_TextBox.Name = "Sex_TextBox"
        Sex_TextBox.Size = New Size(74, 26)
        Sex_TextBox.TabIndex = 43
        Sex_TextBox.Text = "Email: "
        Sex_TextBox.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label34
        ' 
        Label34.AutoSize = True
        Label34.Font = New Font("Sylfaen", 15F)
        Label34.Location = New Point(554, 204)
        Label34.Name = "Label34"
        Label34.Size = New Size(46, 26)
        Label34.TabIndex = 42
        Label34.Text = "Sex:"
        Label34.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' BirthDate_DisplayLabel
        ' 
        BirthDate_DisplayLabel.AutoSize = True
        BirthDate_DisplayLabel.Font = New Font("Sylfaen", 15F)
        BirthDate_DisplayLabel.Location = New Point(653, 158)
        BirthDate_DisplayLabel.Name = "BirthDate_DisplayLabel"
        BirthDate_DisplayLabel.Size = New Size(74, 26)
        BirthDate_DisplayLabel.TabIndex = 41
        BirthDate_DisplayLabel.Text = "Email: "
        BirthDate_DisplayLabel.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Email_LabelDisplay
        ' 
        Email_LabelDisplay.AutoSize = True
        Email_LabelDisplay.Font = New Font("Sylfaen", 15F)
        Email_LabelDisplay.Location = New Point(653, 109)
        Email_LabelDisplay.Name = "Email_LabelDisplay"
        Email_LabelDisplay.Size = New Size(74, 26)
        Email_LabelDisplay.TabIndex = 40
        Email_LabelDisplay.Text = "Email: "
        Email_LabelDisplay.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' EmployeeID_LabelDisplay
        ' 
        EmployeeID_LabelDisplay.AutoSize = True
        EmployeeID_LabelDisplay.Font = New Font("Sylfaen", 15F)
        EmployeeID_LabelDisplay.Location = New Point(211, 256)
        EmployeeID_LabelDisplay.Name = "EmployeeID_LabelDisplay"
        EmployeeID_LabelDisplay.Size = New Size(74, 26)
        EmployeeID_LabelDisplay.TabIndex = 39
        EmployeeID_LabelDisplay.Text = "Email: "
        EmployeeID_LabelDisplay.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' MiddleName_LabelDisplay
        ' 
        MiddleName_LabelDisplay.AutoSize = True
        MiddleName_LabelDisplay.Font = New Font("Sylfaen", 15F)
        MiddleName_LabelDisplay.Location = New Point(211, 204)
        MiddleName_LabelDisplay.Name = "MiddleName_LabelDisplay"
        MiddleName_LabelDisplay.Size = New Size(74, 26)
        MiddleName_LabelDisplay.TabIndex = 38
        MiddleName_LabelDisplay.Text = "Email: "
        MiddleName_LabelDisplay.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LastName_LabelDisplay
        ' 
        LastName_LabelDisplay.AutoSize = True
        LastName_LabelDisplay.Font = New Font("Sylfaen", 15F)
        LastName_LabelDisplay.Location = New Point(211, 158)
        LastName_LabelDisplay.Name = "LastName_LabelDisplay"
        LastName_LabelDisplay.Size = New Size(74, 26)
        LastName_LabelDisplay.TabIndex = 37
        LastName_LabelDisplay.Text = "Email: "
        LastName_LabelDisplay.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' FirstName_LabelDisplay
        ' 
        FirstName_LabelDisplay.AutoSize = True
        FirstName_LabelDisplay.Font = New Font("Sylfaen", 15F)
        FirstName_LabelDisplay.Location = New Point(211, 114)
        FirstName_LabelDisplay.Name = "FirstName_LabelDisplay"
        FirstName_LabelDisplay.Size = New Size(74, 26)
        FirstName_LabelDisplay.TabIndex = 36
        FirstName_LabelDisplay.Text = "Email: "
        FirstName_LabelDisplay.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.Transparent
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(0, 43)
        Label13.Name = "Label13"
        Label13.Size = New Size(418, 26)
        Label13.TabIndex = 19
        Label13.Text = "_________________________________________________________________________________________________________"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Sylfaen", 15F)
        Label12.Location = New Point(502, 158)
        Label12.Name = "Label12"
        Label12.Size = New Size(107, 26)
        Label12.TabIndex = 32
        Label12.Text = "BirthDate: "
        Label12.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Sylfaen", 15F)
        Label11.Location = New Point(535, 109)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 26)
        Label11.TabIndex = 28
        Label11.Text = "Email: "
        Label11.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Sylfaen", 15F)
        Label8.Location = New Point(33, 256)
        Label8.Name = "Label8"
        Label8.Size = New Size(134, 26)
        Label8.TabIndex = 26
        Label8.Text = "Employee ID: "
        Label8.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Sylfaen", 15F)
        Label9.Location = New Point(29, 204)
        Label9.Name = "Label9"
        Label9.Size = New Size(140, 26)
        Label9.TabIndex = 24
        Label9.Text = "Middle Name: "
        Label9.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Sylfaen", 15F)
        Label7.Location = New Point(56, 158)
        Label7.Name = "Label7"
        Label7.Size = New Size(109, 26)
        Label7.TabIndex = 22
        Label7.Text = "Last Name:"
        Label7.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Sylfaen", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(0, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(418, 43)
        Label6.TabIndex = 21
        Label6.Text = "ACCOUNT INFORMATION"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sylfaen", 15F)
        Label5.Location = New Point(51, 114)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 26)
        Label5.TabIndex = 0
        Label5.Text = "First Name: "
        ' 
        ' Delete_Panel1
        ' 
        Delete_Panel1.Controls.Add(Delete_Panel2)
        Delete_Panel1.Dock = DockStyle.Fill
        Delete_Panel1.Location = New Point(100, 99)
        Delete_Panel1.Name = "Delete_Panel1"
        Delete_Panel1.Size = New Size(1002, 564)
        Delete_Panel1.TabIndex = 45
        Delete_Panel1.Visible = False
        ' 
        ' Delete_Panel2
        ' 
        Delete_Panel2.BackColor = SystemColors.ControlDark
        Delete_Panel2.Controls.Add(Button5)
        Delete_Panel2.Controls.Add(Label10)
        Delete_Panel2.Controls.Add(BirthDate3_Label)
        Delete_Panel2.Controls.Add(EmailAddress3_Label)
        Delete_Panel2.Controls.Add(EmployeeID3_Label)
        Delete_Panel2.Controls.Add(MiddleName3_Label)
        Delete_Panel2.Controls.Add(LastName3_Label)
        Delete_Panel2.Controls.Add(FirstName3_Label)
        Delete_Panel2.Controls.Add(Label28)
        Delete_Panel2.Controls.Add(Label29)
        Delete_Panel2.Controls.Add(Label30)
        Delete_Panel2.Controls.Add(Label31)
        Delete_Panel2.Controls.Add(Label32)
        Delete_Panel2.Controls.Add(Label33)
        Delete_Panel2.Controls.Add(EmployeeID3_TextBox)
        Delete_Panel2.Controls.Add(Label17)
        Delete_Panel2.Controls.Add(Label22)
        Delete_Panel2.Controls.Add(Button3)
        Delete_Panel2.Controls.Add(Label25)
        Delete_Panel2.Location = New Point(75, 53)
        Delete_Panel2.Name = "Delete_Panel2"
        Delete_Panel2.Size = New Size(853, 458)
        Delete_Panel2.TabIndex = 44
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(22, 208)
        Button5.Name = "Button5"
        Button5.Size = New Size(138, 32)
        Button5.TabIndex = 55
        Button5.Text = "CHECK ACCOUNT"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Sylfaen", 15F)
        Label10.Location = New Point(176, 129)
        Label10.Name = "Label10"
        Label10.Size = New Size(152, 36)
        Label10.TabIndex = 54
        Label10.Text = "Account Details"
        ' 
        ' BirthDate3_Label
        ' 
        BirthDate3_Label.BackColor = Color.White
        BirthDate3_Label.Font = New Font("Sylfaen", 12.75F)
        BirthDate3_Label.Location = New Point(358, 347)
        BirthDate3_Label.Name = "BirthDate3_Label"
        BirthDate3_Label.Size = New Size(274, 26)
        BirthDate3_Label.TabIndex = 53
        BirthDate3_Label.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' EmailAddress3_Label
        ' 
        EmailAddress3_Label.BackColor = Color.White
        EmailAddress3_Label.Font = New Font("Sylfaen", 12.75F)
        EmailAddress3_Label.Location = New Point(358, 312)
        EmailAddress3_Label.Name = "EmailAddress3_Label"
        EmailAddress3_Label.Size = New Size(274, 26)
        EmailAddress3_Label.TabIndex = 52
        EmailAddress3_Label.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' EmployeeID3_Label
        ' 
        EmployeeID3_Label.BackColor = Color.White
        EmployeeID3_Label.Font = New Font("Sylfaen", 12.75F)
        EmployeeID3_Label.Location = New Point(358, 278)
        EmployeeID3_Label.Name = "EmployeeID3_Label"
        EmployeeID3_Label.Size = New Size(274, 26)
        EmployeeID3_Label.TabIndex = 51
        EmployeeID3_Label.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' MiddleName3_Label
        ' 
        MiddleName3_Label.BackColor = Color.White
        MiddleName3_Label.Font = New Font("Sylfaen", 12.75F)
        MiddleName3_Label.Location = New Point(358, 243)
        MiddleName3_Label.Name = "MiddleName3_Label"
        MiddleName3_Label.Size = New Size(274, 26)
        MiddleName3_Label.TabIndex = 50
        MiddleName3_Label.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' LastName3_Label
        ' 
        LastName3_Label.BackColor = Color.White
        LastName3_Label.Font = New Font("Sylfaen", 12.75F)
        LastName3_Label.Location = New Point(358, 208)
        LastName3_Label.Name = "LastName3_Label"
        LastName3_Label.Size = New Size(274, 26)
        LastName3_Label.TabIndex = 49
        LastName3_Label.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' FirstName3_Label
        ' 
        FirstName3_Label.BackColor = Color.White
        FirstName3_Label.Font = New Font("Sylfaen", 12.75F)
        FirstName3_Label.Location = New Point(358, 174)
        FirstName3_Label.Name = "FirstName3_Label"
        FirstName3_Label.Size = New Size(274, 26)
        FirstName3_Label.TabIndex = 48
        FirstName3_Label.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Sylfaen", 12.75F)
        Label28.Location = New Point(242, 347)
        Label28.Name = "Label28"
        Label28.Size = New Size(90, 22)
        Label28.TabIndex = 47
        Label28.Text = "BirthDate: "
        Label28.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Sylfaen", 12.75F)
        Label29.Location = New Point(268, 316)
        Label29.Name = "Label29"
        Label29.Size = New Size(61, 22)
        Label29.TabIndex = 46
        Label29.Text = "Email: "
        Label29.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Sylfaen", 12.75F)
        Label30.Location = New Point(216, 278)
        Label30.Name = "Label30"
        Label30.Size = New Size(112, 22)
        Label30.TabIndex = 45
        Label30.Text = "Employee ID: "
        Label30.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Sylfaen", 12.75F)
        Label31.Location = New Point(212, 245)
        Label31.Name = "Label31"
        Label31.Size = New Size(116, 22)
        Label31.TabIndex = 44
        Label31.Text = "Middle Name: "
        Label31.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Sylfaen", 12.75F)
        Label32.Location = New Point(239, 208)
        Label32.Name = "Label32"
        Label32.Size = New Size(90, 22)
        Label32.TabIndex = 43
        Label32.Text = "Last Name:"
        Label32.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Sylfaen", 12.75F)
        Label33.Location = New Point(234, 174)
        Label33.Name = "Label33"
        Label33.Size = New Size(98, 22)
        Label33.TabIndex = 42
        Label33.Text = "First Name: "
        ' 
        ' EmployeeID3_TextBox
        ' 
        EmployeeID3_TextBox.Font = New Font("Sylfaen", 15F)
        EmployeeID3_TextBox.Location = New Point(22, 164)
        EmployeeID3_TextBox.Multiline = True
        EmployeeID3_TextBox.Name = "EmployeeID3_TextBox"
        EmployeeID3_TextBox.Size = New Size(138, 32)
        EmployeeID3_TextBox.TabIndex = 24
        ' 
        ' Label17
        ' 
        Label17.Font = New Font("Sylfaen", 15F)
        Label17.Location = New Point(22, 129)
        Label17.Name = "Label17"
        Label17.Size = New Size(138, 36)
        Label17.TabIndex = 20
        Label17.Text = "Employee ID"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = Color.Black
        Label22.Location = New Point(307, 31)
        Label22.Name = "Label22"
        Label22.Size = New Size(227, 35)
        Label22.TabIndex = 10
        Label22.Text = "RHODES ISLAND"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(22, 254)
        Button3.Name = "Button3"
        Button3.Size = New Size(138, 32)
        Button3.TabIndex = 7
        Button3.Text = "DELETE ACCOUNT"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label25
        ' 
        Label25.Font = New Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(298, 79)
        Label25.Name = "Label25"
        Label25.Size = New Size(298, 53)
        Label25.TabIndex = 0
        Label25.Text = "DELETE ACCOUNT"
        ' 
        ' Home_Panel
        ' 
        Home_Panel.BackgroundImageLayout = ImageLayout.Stretch
        Home_Panel.Controls.Add(Panel1)
        Home_Panel.Dock = DockStyle.Fill
        Home_Panel.Location = New Point(100, 99)
        Home_Panel.Name = "Home_Panel"
        Home_Panel.Size = New Size(1002, 564)
        Home_Panel.TabIndex = 45
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(LoadChart_Button)
        Panel1.Controls.Add(Chart1)
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Controls.Add(Label26)
        Panel1.Controls.Add(Label24)
        Panel1.Controls.Add(Search_TextBox)
        Panel1.Controls.Add(Employees0_DataGridView)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(FirstName0_ListBox)
        Panel1.Controls.Add(FirstName0_ComboBox)
        Panel1.Controls.Add(BirthDate0_DateTimePicker)
        Panel1.Controls.Add(Label37)
        Panel1.Controls.Add(Password0_TextBox)
        Panel1.Controls.Add(Label23)
        Panel1.Controls.Add(Email0_TextBox)
        Panel1.Controls.Add(EmployeeID0_TextBox)
        Panel1.Controls.Add(MiddleName0_TextBox)
        Panel1.Controls.Add(LastName0_TextBox)
        Panel1.Controls.Add(FirstName0_TextBox)
        Panel1.Controls.Add(Label21)
        Panel1.Controls.Add(Label38)
        Panel1.Controls.Add(Label39)
        Panel1.Controls.Add(Label40)
        Panel1.Controls.Add(Label41)
        Panel1.Controls.Add(Label42)
        Panel1.Controls.Add(Update0_Button)
        Panel1.Controls.Add(Save0_Button)
        Panel1.Controls.Add(Delete0_Button)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1002, 564)
        Panel1.TabIndex = 44
        ' 
        ' LoadChart_Button
        ' 
        LoadChart_Button.Location = New Point(137, 425)
        LoadChart_Button.Name = "LoadChart_Button"
        LoadChart_Button.Size = New Size(116, 40)
        LoadChart_Button.TabIndex = 88
        LoadChart_Button.Text = "LOAD CHART"
        LoadChart_Button.UseVisualStyleBackColor = True
        ' 
        ' Chart1
        ' 
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Birth Date"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New Point(311, 321)
        Chart1.Name = "Chart1"
        Chart1.Palette = DataVisualization.Charting.ChartColorPalette.Chocolate
        Chart1.RightToLeft = RightToLeft.Yes
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = DataVisualization.Charting.SeriesChartType.Bar
        Series1.Font = New Font("Microsoft Sans Serif", 5.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Series1.Legend = "Birth Date"
        Series1.MarkerSize = 1
        Series1.Name = "EmployeeID-BirthDate"
        Series1.YValueType = DataVisualization.Charting.ChartValueType.Date
        Chart1.Series.Add(Series1)
        Chart1.Size = New Size(677, 230)
        Chart1.TabIndex = 5
        Chart1.Text = "Chart1"
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(213, 295)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(63, 19)
        RadioButton2.TabIndex = 86
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(140, 296)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(51, 19)
        RadioButton1.TabIndex = 85
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Sylfaen", 12.75F)
        Label26.Location = New Point(83, 295)
        Label26.Name = "Label26"
        Label26.Size = New Size(42, 22)
        Label26.TabIndex = 84
        Label26.Text = "Sex: "
        Label26.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Sylfaen", 12.75F)
        Label24.Location = New Point(669, 14)
        Label24.Name = "Label24"
        Label24.Size = New Size(159, 22)
        Label24.TabIndex = 83
        Label24.Text = "Search (First Name):"
        Label24.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Search_TextBox
        ' 
        Search_TextBox.Font = New Font("Sylfaen", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Search_TextBox.Location = New Point(669, 39)
        Search_TextBox.Name = "Search_TextBox"
        Search_TextBox.Size = New Size(319, 39)
        Search_TextBox.TabIndex = 82
        ' 
        ' Employees0_DataGridView
        ' 
        Employees0_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Employees0_DataGridView.Location = New Point(554, 84)
        Employees0_DataGridView.Name = "Employees0_DataGridView"
        Employees0_DataGridView.Size = New Size(434, 231)
        Employees0_DataGridView.TabIndex = 81
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(554, 38)
        Button6.Name = "Button6"
        Button6.Size = New Size(109, 40)
        Button6.TabIndex = 80
        Button6.Text = "LOAD TABLE"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' FirstName0_ListBox
        ' 
        FirstName0_ListBox.FormattingEnabled = True
        FirstName0_ListBox.ItemHeight = 15
        FirstName0_ListBox.Location = New Point(417, 116)
        FirstName0_ListBox.Name = "FirstName0_ListBox"
        FirstName0_ListBox.Size = New Size(131, 199)
        FirstName0_ListBox.TabIndex = 79
        ' 
        ' FirstName0_ComboBox
        ' 
        FirstName0_ComboBox.FormattingEnabled = True
        FirstName0_ComboBox.Location = New Point(417, 85)
        FirstName0_ComboBox.Name = "FirstName0_ComboBox"
        FirstName0_ComboBox.Size = New Size(131, 23)
        FirstName0_ComboBox.TabIndex = 78
        ' 
        ' BirthDate0_DateTimePicker
        ' 
        BirthDate0_DateTimePicker.Location = New Point(137, 262)
        BirthDate0_DateTimePicker.Name = "BirthDate0_DateTimePicker"
        BirthDate0_DateTimePicker.Size = New Size(268, 23)
        BirthDate0_DateTimePicker.TabIndex = 77
        ' 
        ' Label37
        ' 
        Label37.AutoSize = True
        Label37.Font = New Font("Sylfaen", 12.75F)
        Label37.Location = New Point(43, 258)
        Label37.Name = "Label37"
        Label37.Size = New Size(90, 22)
        Label37.TabIndex = 76
        Label37.Text = "BirthDate: "
        Label37.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Password0_TextBox
        ' 
        Password0_TextBox.Location = New Point(137, 232)
        Password0_TextBox.Name = "Password0_TextBox"
        Password0_TextBox.Size = New Size(268, 23)
        Password0_TextBox.TabIndex = 75
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Sylfaen", 12.75F)
        Label23.Location = New Point(43, 229)
        Label23.Name = "Label23"
        Label23.Size = New Size(82, 22)
        Label23.TabIndex = 74
        Label23.Text = "Password:"
        Label23.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Email0_TextBox
        ' 
        Email0_TextBox.Location = New Point(137, 203)
        Email0_TextBox.Name = "Email0_TextBox"
        Email0_TextBox.Size = New Size(268, 23)
        Email0_TextBox.TabIndex = 72
        ' 
        ' EmployeeID0_TextBox
        ' 
        EmployeeID0_TextBox.Location = New Point(137, 84)
        EmployeeID0_TextBox.Name = "EmployeeID0_TextBox"
        EmployeeID0_TextBox.Size = New Size(268, 23)
        EmployeeID0_TextBox.TabIndex = 71
        ' 
        ' MiddleName0_TextBox
        ' 
        MiddleName0_TextBox.Location = New Point(137, 173)
        MiddleName0_TextBox.Name = "MiddleName0_TextBox"
        MiddleName0_TextBox.Size = New Size(268, 23)
        MiddleName0_TextBox.TabIndex = 70
        ' 
        ' LastName0_TextBox
        ' 
        LastName0_TextBox.Location = New Point(137, 144)
        LastName0_TextBox.Name = "LastName0_TextBox"
        LastName0_TextBox.Size = New Size(268, 23)
        LastName0_TextBox.TabIndex = 69
        ' 
        ' FirstName0_TextBox
        ' 
        FirstName0_TextBox.Location = New Point(137, 114)
        FirstName0_TextBox.Name = "FirstName0_TextBox"
        FirstName0_TextBox.Size = New Size(268, 23)
        FirstName0_TextBox.TabIndex = 68
        ' 
        ' Label21
        ' 
        Label21.Font = New Font("Sylfaen", 24.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(15, 33)
        Label21.Name = "Label21"
        Label21.Size = New Size(533, 36)
        Label21.TabIndex = 67
        Label21.Text = "EMPLOYEE MANAGER"
        ' 
        ' Label38
        ' 
        Label38.AutoSize = True
        Label38.Font = New Font("Sylfaen", 12.75F)
        Label38.Location = New Point(70, 204)
        Label38.Name = "Label38"
        Label38.Size = New Size(61, 22)
        Label38.TabIndex = 59
        Label38.Text = "Email: "
        Label38.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label39
        ' 
        Label39.AutoSize = True
        Label39.Font = New Font("Sylfaen", 12.75F)
        Label39.Location = New Point(19, 85)
        Label39.Name = "Label39"
        Label39.Size = New Size(112, 22)
        Label39.TabIndex = 58
        Label39.Text = "Employee ID: "
        Label39.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label40
        ' 
        Label40.AutoSize = True
        Label40.Font = New Font("Sylfaen", 12.75F)
        Label40.Location = New Point(15, 173)
        Label40.Name = "Label40"
        Label40.Size = New Size(116, 22)
        Label40.TabIndex = 57
        Label40.Text = "Middle Name: "
        Label40.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Sylfaen", 12.75F)
        Label41.Location = New Point(42, 144)
        Label41.Name = "Label41"
        Label41.Size = New Size(90, 22)
        Label41.TabIndex = 56
        Label41.Text = "Last Name:"
        Label41.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label42
        ' 
        Label42.AutoSize = True
        Label42.Font = New Font("Sylfaen", 12.75F)
        Label42.Location = New Point(37, 110)
        Label42.Name = "Label42"
        Label42.Size = New Size(98, 22)
        Label42.TabIndex = 55
        Label42.Text = "First Name: "
        ' 
        ' Update0_Button
        ' 
        Update0_Button.Location = New Point(137, 360)
        Update0_Button.Name = "Update0_Button"
        Update0_Button.Size = New Size(116, 40)
        Update0_Button.TabIndex = 13
        Update0_Button.Text = "UPDATE ACCOUNT"
        Update0_Button.UseVisualStyleBackColor = True
        ' 
        ' Save0_Button
        ' 
        Save0_Button.Location = New Point(19, 360)
        Save0_Button.Name = "Save0_Button"
        Save0_Button.Size = New Size(116, 40)
        Save0_Button.TabIndex = 12
        Save0_Button.Text = "SAVE ACCOUNT"
        Save0_Button.UseVisualStyleBackColor = True
        ' 
        ' Delete0_Button
        ' 
        Delete0_Button.Location = New Point(19, 422)
        Delete0_Button.Name = "Delete0_Button"
        Delete0_Button.Size = New Size(116, 40)
        Delete0_Button.TabIndex = 7
        Delete0_Button.Text = "DELETE ACCOUNT"
        Delete0_Button.UseVisualStyleBackColor = True
        ' 
        ' Update_Panel1
        ' 
        Update_Panel1.Controls.Add(Update_Panel2)
        Update_Panel1.Dock = DockStyle.Fill
        Update_Panel1.Location = New Point(100, 99)
        Update_Panel1.Name = "Update_Panel1"
        Update_Panel1.Size = New Size(1002, 564)
        Update_Panel1.TabIndex = 42
        ' 
        ' Update_Panel2
        ' 
        Update_Panel2.BackColor = SystemColors.ControlDark
        Update_Panel2.Controls.Add(RadioButton3)
        Update_Panel2.Controls.Add(RadioButton4)
        Update_Panel2.Controls.Add(Label27)
        Update_Panel2.Controls.Add(ShowPassword_CheckBox)
        Update_Panel2.Controls.Add(BirthDate2_DateTimePicker)
        Update_Panel2.Controls.Add(Label3)
        Update_Panel2.Controls.Add(MiddleName2_TextBox)
        Update_Panel2.Controls.Add(Password2_TextBox)
        Update_Panel2.Controls.Add(Label14)
        Update_Panel2.Controls.Add(Label15)
        Update_Panel2.Controls.Add(Label16)
        Update_Panel2.Controls.Add(SignUp_Button)
        Update_Panel2.Controls.Add(LastName2_TextBox)
        Update_Panel2.Controls.Add(Label18)
        Update_Panel2.Controls.Add(FirstName2_TextBox)
        Update_Panel2.Controls.Add(Label19)
        Update_Panel2.Controls.Add(Label20)
        Update_Panel2.Location = New Point(75, 53)
        Update_Panel2.Name = "Update_Panel2"
        Update_Panel2.Size = New Size(853, 458)
        Update_Panel2.TabIndex = 43
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(574, 293)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(63, 19)
        RadioButton3.TabIndex = 92
        RadioButton3.TabStop = True
        RadioButton3.Text = "Female"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(501, 294)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(51, 19)
        RadioButton4.TabIndex = 91
        RadioButton4.TabStop = True
        RadioButton4.Text = "Male"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Sylfaen", 12.75F)
        Label27.Location = New Point(444, 293)
        Label27.Name = "Label27"
        Label27.Size = New Size(42, 22)
        Label27.TabIndex = 90
        Label27.Text = "Sex: "
        Label27.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ShowPassword_CheckBox
        ' 
        ShowPassword_CheckBox.AutoSize = True
        ShowPassword_CheckBox.Checked = True
        ShowPassword_CheckBox.CheckState = CheckState.Checked
        ShowPassword_CheckBox.Font = New Font("Sylfaen", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ShowPassword_CheckBox.Location = New Point(447, 265)
        ShowPassword_CheckBox.Name = "ShowPassword_CheckBox"
        ShowPassword_CheckBox.Size = New Size(116, 22)
        ShowPassword_CheckBox.TabIndex = 30
        ShowPassword_CheckBox.Text = "Show Password?"
        ShowPassword_CheckBox.UseVisualStyleBackColor = True
        ' 
        ' BirthDate2_DateTimePicker
        ' 
        BirthDate2_DateTimePicker.Font = New Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BirthDate2_DateTimePicker.Location = New Point(447, 167)
        BirthDate2_DateTimePicker.Name = "BirthDate2_DateTimePicker"
        BirthDate2_DateTimePicker.Size = New Size(327, 33)
        BirthDate2_DateTimePicker.TabIndex = 29
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Sylfaen", 12F)
        Label3.Location = New Point(447, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 36)
        Label3.TabIndex = 28
        Label3.Text = "Birth Date"
        ' 
        ' MiddleName2_TextBox
        ' 
        MiddleName2_TextBox.Font = New Font("Sylfaen", 15F)
        MiddleName2_TextBox.Location = New Point(79, 285)
        MiddleName2_TextBox.Multiline = True
        MiddleName2_TextBox.Name = "MiddleName2_TextBox"
        MiddleName2_TextBox.Size = New Size(327, 32)
        MiddleName2_TextBox.TabIndex = 25
        ' 
        ' Password2_TextBox
        ' 
        Password2_TextBox.Font = New Font("Sylfaen", 15F)
        Password2_TextBox.Location = New Point(447, 227)
        Password2_TextBox.Multiline = True
        Password2_TextBox.Name = "Password2_TextBox"
        Password2_TextBox.PasswordChar = "*"c
        Password2_TextBox.Size = New Size(327, 32)
        Password2_TextBox.TabIndex = 24
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Sylfaen", 12F)
        Label14.Location = New Point(447, 203)
        Label14.Name = "Label14"
        Label14.Size = New Size(161, 36)
        Label14.TabIndex = 20
        Label14.Text = "Password"
        ' 
        ' Label15
        ' 
        Label15.Font = New Font("Sylfaen", 12F)
        Label15.Location = New Point(79, 263)
        Label15.Name = "Label15"
        Label15.Size = New Size(161, 36)
        Label15.TabIndex = 12
        Label15.Text = "Middle Name"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(298, 38)
        Label16.Name = "Label16"
        Label16.Size = New Size(227, 35)
        Label16.TabIndex = 10
        Label16.Text = "RHODES ISLAND"
        ' 
        ' SignUp_Button
        ' 
        SignUp_Button.Location = New Point(250, 369)
        SignUp_Button.Name = "SignUp_Button"
        SignUp_Button.Size = New Size(352, 49)
        SignUp_Button.TabIndex = 7
        SignUp_Button.Text = "UPDATE ACCOUNT"
        SignUp_Button.UseVisualStyleBackColor = True
        ' 
        ' LastName2_TextBox
        ' 
        LastName2_TextBox.Font = New Font("Sylfaen", 15F)
        LastName2_TextBox.Location = New Point(79, 227)
        LastName2_TextBox.Multiline = True
        LastName2_TextBox.Name = "LastName2_TextBox"
        LastName2_TextBox.Size = New Size(327, 32)
        LastName2_TextBox.TabIndex = 5
        ' 
        ' Label18
        ' 
        Label18.Font = New Font("Sylfaen", 12F)
        Label18.Location = New Point(79, 202)
        Label18.Name = "Label18"
        Label18.Size = New Size(161, 36)
        Label18.TabIndex = 4
        Label18.Text = "Last Name"
        ' 
        ' FirstName2_TextBox
        ' 
        FirstName2_TextBox.Font = New Font("Sylfaen", 15F)
        FirstName2_TextBox.Location = New Point(79, 167)
        FirstName2_TextBox.Multiline = True
        FirstName2_TextBox.Name = "FirstName2_TextBox"
        FirstName2_TextBox.Size = New Size(327, 32)
        FirstName2_TextBox.TabIndex = 2
        ' 
        ' Label19
        ' 
        Label19.Font = New Font("Sylfaen", 12F)
        Label19.Location = New Point(79, 139)
        Label19.Name = "Label19"
        Label19.Size = New Size(161, 36)
        Label19.TabIndex = 1
        Label19.Text = "First Name"
        ' 
        ' Label20
        ' 
        Label20.Font = New Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(277, 86)
        Label20.Name = "Label20"
        Label20.Size = New Size(298, 53)
        Label20.TabIndex = 0
        Label20.Text = "UPDATE ACCOUNT"
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = SystemColors.HighlightText
        ClientSize = New Size(1102, 663)
        Controls.Add(Home_Panel)
        Controls.Add(Update_Panel1)
        Controls.Add(Nian_Panel)
        Controls.Add(Delete_Panel1)
        Controls.Add(Left_Panel)
        Controls.Add(Top_Panel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rhodes Island Dashboard"
        Top_Panel.ResumeLayout(False)
        Top_Panel.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Left_Panel.ResumeLayout(False)
        Nian_Panel.ResumeLayout(False)
        Nian_Panel.PerformLayout()
        Delete_Panel1.ResumeLayout(False)
        Delete_Panel2.ResumeLayout(False)
        Delete_Panel2.PerformLayout()
        Home_Panel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(Chart1, ComponentModel.ISupportInitialize).EndInit()
        CType(Employees0_DataGridView, ComponentModel.ISupportInitialize).EndInit()
        Update_Panel1.ResumeLayout(False)
        Update_Panel2.ResumeLayout(False)
        Update_Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DBConnect_Button As Button
    Friend WithEvents Top_Panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Left_Panel As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Logout_Button As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents My_Profile_Button As Button
    Friend WithEvents Display_Employee_Name_Label As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Nian_Panel As Panel
    Friend WithEvents BirthDate_DisplayLabel As Label
    Friend WithEvents Email_LabelDisplay As Label
    Friend WithEvents EmployeeID_LabelDisplay As Label
    Friend WithEvents MiddleName_LabelDisplay As Label
    Friend WithEvents LastName_LabelDisplay As Label
    Friend WithEvents FirstName_LabelDisplay As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Update_Panel1 As Panel
    Friend WithEvents Update_Panel2 As Panel
    Friend WithEvents ShowPassword_CheckBox As CheckBox
    Friend WithEvents BirthDate2_DateTimePicker As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents MiddleName2_TextBox As TextBox
    Friend WithEvents Password2_TextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents SignUp_Button As Button
    Friend WithEvents LastName2_TextBox As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents FirstName2_TextBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Delete_Panel1 As Panel
    Friend WithEvents Home_Panel As Panel
    Friend WithEvents Delete_Panel2 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents BirthDate3_Label As Label
    Friend WithEvents EmailAddress3_Label As Label
    Friend WithEvents EmployeeID3_Label As Label
    Friend WithEvents MiddleName3_Label As Label
    Friend WithEvents LastName3_Label As Label
    Friend WithEvents FirstName3_Label As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents EmployeeID3_TextBox As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Delete0_Button As Button
    Friend WithEvents Update0_Button As Button
    Friend WithEvents Save0_Button As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Email0_TextBox As TextBox
    Friend WithEvents MiddleName0_TextBox As TextBox
    Friend WithEvents LastName0_TextBox As TextBox
    Friend WithEvents FirstName0_TextBox As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Password0_TextBox As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents BirthDate0_DateTimePicker As DateTimePicker
    Friend WithEvents EmployeeID0_TextBox As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents FirstName0_ComboBox As ComboBox
    Friend WithEvents FirstName0_ListBox As ListBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Employees0_DataGridView As DataGridView
    Friend WithEvents Search_TextBox As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label26 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label27 As Label
    Friend WithEvents Sex_TextBox As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents LoadChart_Button As Button
    ' Friend WithEvents Chart1 As DataVisualization.Charting.Chart

End Class
