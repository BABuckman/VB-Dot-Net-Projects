Imports System

Module Program
    Sub Main(args As String())
        ' Program to demonstrate comparisons operators '
        Dim number1, number2 As Integer ' declare variables

        Console.Write("Enter first number: ")
        number1 = Console.ReadLine()
        Console.Write("Enter second number: ")
        number2 = Console.ReadLine()

        Console.WriteLine("Equal-to: {0}", (number1 = number2)) ' equal to 
        Console.WriteLine("Less-than: {0}", (number1 < number2)) ' less than 
        Console.WriteLine("Less than or equal to: {0}", (number1 <= number2)) ' less than and equal to 
        Console.WriteLine("Greater than: {0}", (number1 > number2)) ' greater than 
        Console.WriteLine("Greater than or equal to: {0}", (number1 >= number2)) ' greater than or equal to
        Console.WriteLine("Not equal to: {0}", (number1 <> number2)) ' not equal to

    End Sub
End Module
