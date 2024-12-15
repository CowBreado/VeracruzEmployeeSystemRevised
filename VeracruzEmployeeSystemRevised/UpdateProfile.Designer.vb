<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel2 = New Panel()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Label26 = New Label()
        Button1 = New Button()
        ShowPassword_CheckBox = New CheckBox()
        BirthDate_DateTimePicker = New DateTimePicker()
        Label8 = New Label()
        MiddleName_TextBox = New TextBox()
        Password_TextBox = New TextBox()
        EmailAddress_TextBox = New TextBox()
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        SignUp_Button = New Button()
        LastName_TextBox = New TextBox()
        Label4 = New Label()
        FirstName_TextBox = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDark
        Panel2.Controls.Add(RadioButton2)
        Panel2.Controls.Add(RadioButton1)
        Panel2.Controls.Add(Label26)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(ShowPassword_CheckBox)
        Panel2.Controls.Add(BirthDate_DateTimePicker)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(MiddleName_TextBox)
        Panel2.Controls.Add(Password_TextBox)
        Panel2.Controls.Add(EmailAddress_TextBox)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(SignUp_Button)
        Panel2.Controls.Add(LastName_TextBox)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(FirstName_TextBox)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(22, 26)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(757, 488)
        Panel2.TabIndex = 0
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(176, 305)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(63, 19)
        RadioButton2.TabIndex = 89
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(103, 306)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(51, 19)
        RadioButton1.TabIndex = 88
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Sylfaen", 12.75F)
        Label26.Location = New Point(46, 305)
        Label26.Name = "Label26"
        Label26.Size = New Size(42, 22)
        Label26.TabIndex = 87
        Label26.Text = "Sex: "
        Label26.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(217, 422)
        Button1.Name = "Button1"
        Button1.Size = New Size(352, 44)
        Button1.TabIndex = 31
        Button1.Text = "RETURN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ShowPassword_CheckBox
        ' 
        ShowPassword_CheckBox.AutoSize = True
        ShowPassword_CheckBox.Font = New Font("Sylfaen", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ShowPassword_CheckBox.Location = New Point(414, 305)
        ShowPassword_CheckBox.Name = "ShowPassword_CheckBox"
        ShowPassword_CheckBox.Size = New Size(116, 22)
        ShowPassword_CheckBox.TabIndex = 30
        ShowPassword_CheckBox.Text = "Show Password?"
        ShowPassword_CheckBox.UseVisualStyleBackColor = True
        ' 
        ' BirthDate_DateTimePicker
        ' 
        BirthDate_DateTimePicker.Font = New Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BirthDate_DateTimePicker.Location = New Point(414, 147)
        BirthDate_DateTimePicker.Name = "BirthDate_DateTimePicker"
        BirthDate_DateTimePicker.Size = New Size(327, 33)
        BirthDate_DateTimePicker.TabIndex = 29
        ' 
        ' Label8
        ' 
        Label8.Font = New Font("Sylfaen", 12.0F)
        Label8.Location = New Point(414, 119)
        Label8.Name = "Label8"
        Label8.Size = New Size(161, 36)
        Label8.TabIndex = 28
        Label8.Text = "Birth Date"
        ' 
        ' MiddleName_TextBox
        ' 
        MiddleName_TextBox.Font = New Font("Sylfaen", 15.0F)
        MiddleName_TextBox.Location = New Point(46, 265)
        MiddleName_TextBox.Multiline = True
        MiddleName_TextBox.Name = "MiddleName_TextBox"
        MiddleName_TextBox.Size = New Size(327, 32)
        MiddleName_TextBox.TabIndex = 25
        ' 
        ' Password_TextBox
        ' 
        Password_TextBox.Font = New Font("Sylfaen", 15.0F)
        Password_TextBox.Location = New Point(414, 267)
        Password_TextBox.Multiline = True
        Password_TextBox.Name = "Password_TextBox"
        Password_TextBox.PasswordChar = "*"c
        Password_TextBox.Size = New Size(327, 32)
        Password_TextBox.TabIndex = 24
        ' 
        ' EmailAddress_TextBox
        ' 
        EmailAddress_TextBox.Font = New Font("Sylfaen", 15.0F)
        EmailAddress_TextBox.Location = New Point(414, 207)
        EmailAddress_TextBox.Multiline = True
        EmailAddress_TextBox.Name = "EmailAddress_TextBox"
        EmailAddress_TextBox.Size = New Size(327, 32)
        EmailAddress_TextBox.TabIndex = 23
        ' 
        ' Label9
        ' 
        Label9.Font = New Font("Sylfaen", 12.0F)
        Label9.Location = New Point(414, 184)
        Label9.Name = "Label9"
        Label9.Size = New Size(161, 36)
        Label9.TabIndex = 22
        Label9.Text = "Email Address"
        ' 
        ' Label7
        ' 
        Label7.Font = New Font("Sylfaen", 12.0F)
        Label7.Location = New Point(414, 243)
        Label7.Name = "Label7"
        Label7.Size = New Size(161, 36)
        Label7.TabIndex = 20
        Label7.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Sylfaen", 12.0F)
        Label6.Location = New Point(46, 243)
        Label6.Name = "Label6"
        Label6.Size = New Size(161, 36)
        Label6.TabIndex = 12
        Label6.Text = "Middle Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(280, 38)
        Label5.Name = "Label5"
        Label5.Size = New Size(227, 35)
        Label5.TabIndex = 10
        Label5.Text = "RHODES ISLAND"
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Sylfaen", 12.0F)
        Label3.Location = New Point(217, 422)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 36)
        Label3.TabIndex = 8
        ' 
        ' SignUp_Button
        ' 
        SignUp_Button.Location = New Point(217, 367)
        SignUp_Button.Name = "SignUp_Button"
        SignUp_Button.Size = New Size(352, 49)
        SignUp_Button.TabIndex = 7
        SignUp_Button.Text = "UPDATE ACCOUNT"
        SignUp_Button.UseVisualStyleBackColor = True
        ' 
        ' LastName_TextBox
        ' 
        LastName_TextBox.Font = New Font("Sylfaen", 15.0F)
        LastName_TextBox.Location = New Point(46, 207)
        LastName_TextBox.Multiline = True
        LastName_TextBox.Name = "LastName_TextBox"
        LastName_TextBox.Size = New Size(327, 32)
        LastName_TextBox.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Sylfaen", 12.0F)
        Label4.Location = New Point(46, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(161, 36)
        Label4.TabIndex = 4
        Label4.Text = "Last Name"
        ' 
        ' FirstName_TextBox
        ' 
        FirstName_TextBox.Font = New Font("Sylfaen", 15.0F)
        FirstName_TextBox.Location = New Point(46, 147)
        FirstName_TextBox.Multiline = True
        FirstName_TextBox.Name = "FirstName_TextBox"
        FirstName_TextBox.Size = New Size(327, 32)
        FirstName_TextBox.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Sylfaen", 12.0F)
        Label2.Location = New Point(46, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 36)
        Label2.TabIndex = 1
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(321, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 53)
        Label1.TabIndex = 0
        Label1.Text = "UPDATE ACCOUNT"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 541)
        Panel1.TabIndex = 2
        ' 
        ' UpdateProfile
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(824, 565)
        Controls.Add(Panel1)
        Name = "UpdateProfile"
        Text = "UpdateProfile"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents ShowPassword_CheckBox As CheckBox
    Friend WithEvents BirthDate_DateTimePicker As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents MiddleName_TextBox As TextBox
    Friend WithEvents Password_TextBox As TextBox
    Friend WithEvents EmailAddress_TextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SignUp_Button As Button
    Friend WithEvents LastName_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents FirstName_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label26 As Label
End Class
