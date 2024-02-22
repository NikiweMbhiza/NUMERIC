Imports System

Module Program
    Sub Main(args As String())
        '15..........................................
        On Error GoTo err

        Dim userInput As Integer
        Console.WriteLine("Enter numeric data only:")
        userInput = Integer.Parse(Console.ReadLine())
        Console.WriteLine("The correct answer is: " & userInput)

        Exit Sub
err:
        Console.WriteLine("Error: Please enter numeric data only.")

        Console.ReadLine()
    End Sub
End Module

''13............
Module Module1
    Sub Main()
        Dim userInput As String
        Console.WriteLine("Enter numeric data only:")
        userInput = Console.ReadLine()

        If IsNumeric(userInput) Then
            Console.WriteLine("Input accepted. You entered: " & userInput)
        Else
            Console.WriteLine("Error: Please enter numeric data only.")
        End If

        Console.ReadLine() ' Keeps the console window open
    End Sub
End Module


'14....
Module Module2
    Sub Main()
        Try
            Dim userInput As Integer
            Console.WriteLine("Enter numeric data only:")
            userInput = Integer.Parse(Console.ReadLine())
            Console.WriteLine("The correct answer is: " & userInput)
        Catch ex As FormatException
            Console.WriteLine("Error: Please enter numeric data only.")
        End Try

        Console.ReadLine() ' Keeps the console window open
    End Sub
End Module



