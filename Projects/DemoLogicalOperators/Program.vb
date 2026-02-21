Imports System

Module Program
    Sub Main(args As String())
        ' Demonstrating Logical Operators in VB.NET '
        Dim num1, num2 As Integer

        Console.WriteLine("Please enter first integer: ")
        num1 = Console.ReadLine()
        Console.WriteLine("Please enter second integer: ")
        num2 = Console.ReadLine()

        Console.WriteLine("AND Operator ")
        Console.WriteLine(True And False)
        Console.WriteLine(num1 < num2 And num1 < num2)
        Console.WriteLine("OR Operator ")
        Console.WriteLine(True Or False)
        Console.WriteLine(num1 = -(num2) Or num1 <> num2)
        Console.WriteLine("AND-ALSO Operator ")
        Console.WriteLine(True AndAlso True)
        Console.WriteLine(num1 <= num2 AndAlso num1 <> num2)
        Console.WriteLine("NOT Operator ")
        Console.WriteLine(Not False)
        Console.WriteLine(Not True)
        Console.WriteLine("OR-ELSE")
        Console.WriteLine(False OrElse True)
        Console.WriteLine(num1 > num2 OrElse num1 < num2)
        Console.WriteLine("XOR Operator")
        Console.WriteLine(True Xor True)
    End Sub
End Module
