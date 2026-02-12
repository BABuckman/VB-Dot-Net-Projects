Public Class Form1
    Dim number1 As Integer
    Dim number2 As Decimal
    Dim number3 As Double
    Dim number4 As Single

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        number1 = CInt(txtValue.Text)
        number2 = CDec(txtValue.Text)
        number3 = CDbl(txtValue.Text)
        number4 = CSng(txtValue.Text)

        lblInteger.Text = number1
        lblDecimal.Text = number2
        lblDouble.Text = number3
        lblSingle.Text = number4
    End Sub
End Class
