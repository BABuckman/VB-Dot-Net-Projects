Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim results As Double

        firstNumber = 10
        secondNumber = 5

        '' Addition + 
        'results = firstNumber + secondNumber
        'MessageBox.Show(results, "Results")

        '' Subtraction - 
        'results = firstNumber - secondNumber
        'MessageBox.Show(results, "Results")

        '' Multiplication * 
        'results = firstNumber * secondNumber
        'MessageBox.Show(results, "Results")

        ' Divide / 
        'results = firstNumber / secondNumber
        'MessageBox.Show(results, "Results")
        ' Returns decimal results

        ' Quotient \ 
        'results = firstNumber \ secondNumber
        'MessageBox.Show(results, "Results")
        ' Returns numeric results 

        '' Power ^
        'results = firstNumber ^ 2
        'MessageBox.Show(results, "Results")

        '' Modulus Mod 
        results = firstNumber Mod secondNumber
        MessageBox.Show(results, "Results")

        '' Bit shift operations
        'Dim myNumber As Integer
        'Dim result As Integer
        'myNumber = 10

        'result = Convert.ToString(myNumber, 2)
        'MessageBox.Show(result, "Result")

        '' Bit shift left by 1
        'myNumber = myNumber << 1
        'result = Convert.ToString(myNumber, 2)
        'MessageBox.Show(result, "Result")

        '' Bit shift right by 1
        'myNumber = 10
        'myNumber = myNumber >> 1
        'result = Convert.ToString(myNumber, 2)
        'MessageBox.Show(result, "Results")



    End Sub
End Class
