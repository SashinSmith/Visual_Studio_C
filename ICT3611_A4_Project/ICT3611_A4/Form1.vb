Public Class frmContactForm
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'set each variable as the input
        Dim name, surname, email, mess, display As String

        name = txtName.Text
        surname = txtSurname.Text
        email = txtEmail.Text
        mess = rtxtMess.Text
        display = "Thank you for submitting!"

        'check if every variable is valid
        If name = "" Then
            display = "Please fill all fields"
        End If

        If surname = "" Then
            display = "Please fill all fields"
        End If

        If mess = "" Then
            display = "Please fill all fields"
        End If

        Try
            Dim emailValid As New System.Net.Mail.MailAddress(email)
        Catch ex As Exception
            display = "Please fill all fields"
        End Try

        'shows message based off program
        MessageBox.Show(display, "Message")

    End Sub
End Class
