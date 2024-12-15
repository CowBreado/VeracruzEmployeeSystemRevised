Public Class UpdateProfile
    Dim Gender As String
    Public Property email As String

    Private Sub FirstName_TextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstName_TextBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Dashboard As Dashboard
        Dashboard.Show
        Hide
    End Sub

    Private Sub EmailAddress_TextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailAddress_TextBox.TextChanged

    End Sub

    Private Sub SignUp_Button_Click(sender As Object, e As EventArgs) Handles SignUp_Button.Click
        MessageBox.Show("Done")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Gender = "Female"
    End Sub
End Class