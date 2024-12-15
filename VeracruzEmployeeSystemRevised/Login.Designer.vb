<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel2 = New Panel()
        Label5 = New Label()
        SignUp_Button = New Button()
        Label3 = New Label()
        SignIn_Button = New Button()
        ShowPassword_CheckBox = New CheckBox()
        Password_Box = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel1 = New Panel()
        Email_Box = New TextBox()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDark
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(SignUp_Button)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(SignIn_Button)
        Panel2.Controls.Add(ShowPassword_CheckBox)
        Panel2.Controls.Add(Password_Box)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Email_Box)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(18, 22)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(403, 430)
        Panel2.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(88, 42)
        Label5.Name = "Label5"
        Label5.Size = New Size(227, 35)
        Label5.TabIndex = 20
        Label5.Text = "RHODES ISLAND"
        ' 
        ' SignUp_Button
        ' 
        SignUp_Button.BackColor = SystemColors.ControlDark
        SignUp_Button.FlatAppearance.BorderSize = 0
        SignUp_Button.FlatStyle = FlatStyle.Flat
        SignUp_Button.Font = New Font("Sylfaen", 12.0F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        SignUp_Button.Location = New Point(233, 346)
        SignUp_Button.Name = "SignUp_Button"
        SignUp_Button.Size = New Size(144, 36)
        SignUp_Button.TabIndex = 19
        SignUp_Button.Text = "Sign Up Account"
        SignUp_Button.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Sylfaen", 12.0F)
        Label3.Location = New Point(25, 353)
        Label3.Name = "Label3"
        Label3.Size = New Size(175, 36)
        Label3.TabIndex = 18
        Label3.Text = "Don't Have An Account?"
        ' 
        ' SignIn_Button
        ' 
        SignIn_Button.Location = New Point(25, 298)
        SignIn_Button.Name = "SignIn_Button"
        SignIn_Button.Size = New Size(352, 49)
        SignIn_Button.TabIndex = 17
        SignIn_Button.Text = "SIGN IN"
        SignIn_Button.UseVisualStyleBackColor = True
        ' 
        ' ShowPassword_CheckBox
        ' 
        ShowPassword_CheckBox.AutoSize = True
        ShowPassword_CheckBox.Font = New Font("Sylfaen", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ShowPassword_CheckBox.Location = New Point(25, 270)
        ShowPassword_CheckBox.Name = "ShowPassword_CheckBox"
        ShowPassword_CheckBox.Size = New Size(116, 22)
        ShowPassword_CheckBox.TabIndex = 16
        ShowPassword_CheckBox.Text = "Show Password?"
        ShowPassword_CheckBox.UseVisualStyleBackColor = True
        ' 
        ' Password_Box
        ' 
        Password_Box.Font = New Font("Segoe UI", 15.0F)
        Password_Box.Location = New Point(25, 232)
        Password_Box.Multiline = True
        Password_Box.Name = "Password_Box"
        Password_Box.PasswordChar = "*"c
        Password_Box.Size = New Size(352, 32)
        Password_Box.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Sylfaen", 12.0F)
        Label4.Location = New Point(25, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(161, 36)
        Label4.TabIndex = 14
        Label4.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Sylfaen", 12.0F)
        Label2.Location = New Point(25, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(161, 36)
        Label2.TabIndex = 12
        Label2.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Sylfaen", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(129, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 53)
        Label1.TabIndex = 11
        Label1.Text = "SIGN IN"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(167, 61)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(437, 472)
        Panel1.TabIndex = 0
        ' 
        ' Email_Box
        ' 
        Email_Box.Font = New Font("Segoe UI", 15.0F)
        Email_Box.Location = New Point(25, 162)
        Email_Box.Multiline = True
        Email_Box.Name = "Email_Box"
        Email_Box.Size = New Size(352, 32)
        Email_Box.TabIndex = 13
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(771, 594)
        Controls.Add(Panel1)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rhodes Island Sign In"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents SignUp_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents SignIn_Button As Button
    Friend WithEvents ShowPassword_CheckBox As CheckBox
    Friend WithEvents Password_Box As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Email_Box As TextBox
End Class
