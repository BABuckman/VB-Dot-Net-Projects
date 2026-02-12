Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FirstName As String
        Dim LastName As String
        Dim Email As String

        FirstName = txtFirstName.Text
        LastName = txtLastName.Text
        Email = txtEmail.Text

        MessageBox.Show("Username: " & FirstName & " " & LastName & Environment.NewLine &
                        "Email: " & Email)
    End Sub
End Class
