Public Class Form1
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        ProgressBar1.Maximum = 100
        i = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        i = 1
        Timer1.Enabled = False
        Label1.Text = ""
        ProgressBar1.Value = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 1
        Label1.Text = "Progress " & i & " % Completed"
        i = i + 1
        If i > 100 Then Timer1.Enabled = False
    End Sub
End Class
