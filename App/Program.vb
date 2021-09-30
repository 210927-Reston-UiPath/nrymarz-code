Imports System

Module Program
    Sub Main(args As String())
        Do While True
            Console.WriteLine("What would you like to do?")
            Console.WriteLine("[0] Say Hello")
            Console.WriteLine("[x] Exit")
            Dim input as string = Console.ReadLine()
            Select Case input
                Case "0"
                    Console.WriteLine("Hello")
                Case "x"
                    Console.WriteLine("Goodbye")
                    Exit Do
            End Select
        Loop
    End Sub
End Module
