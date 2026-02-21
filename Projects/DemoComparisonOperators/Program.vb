Imports System

Module Program
    Sub Main(args As String())
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim results As Integer

        firstNumber = 10
        secondNumber = 20

        Console.WriteLine(firstNumber & " greater-than " & secondNumber & " => " & (firstNumber > secondNumber))      ' Greater-than operator
        Console.WriteLine(firstNumber & " greater-than or equal-to: " & secondNumber & " => " & (firstNumber >= secondNumber)) ' Greater-than or equal-to  operator
        Console.WriteLine(firstNumber & " less-than: " & secondNumber & " => " & (firstNumber < secondNumber))         ' Less-than operator
        Console.WriteLine(firstNumber & " less-than or equal-to: " & secondNumber & " => " & (firstNumber <= secondNumber))        ' Less-than or equal-to operator
        Console.WriteLine(firstNumber & " equal-to: " & secondNumber & " => " & (firstNumber = secondNumber))          ' Equal-to operator
        Console.WriteLine(firstNumber & " not equal-to: " & secondNumber & " => " & (firstNumber <> secondNumber))         ' Not equal-to operator
    End Sub
End Module
