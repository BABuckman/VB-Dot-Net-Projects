Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim dollar As Double
        Dim cedi As Double
        Dim nira As Double
        Dim ghRate As Double = 11.0
        Dim nigRate As Double = 1500.0

        dollar = CDbl(txtDollar.Text)
        cedi = dollar * ghRate
        nira = dollar * nigRate

        lblCedi.Text = cedi
        lblNira.Text = nira
    End Sub
End Class
