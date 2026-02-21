Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim principal As Double
        Dim rate As Double
        Dim term As Integer
        Dim simple As Double

        principal = Convert.ToDouble(txtPrincipal.Text)
        rate = Convert.ToDouble(txtRate.Text)
        term = Convert.ToDouble(txtTerm.Text)

        If rate >= 0 And term >= 0 Then
            simple = (principal * rate * term) / 100
            Label5.Text = simple
        Else
            MessageBox.Show("The rate and term must be positive!")
        End If
    End Sub
End Class
