Imports System
Module Module1
    Sub Main()
        Console.WriteLine("Guess My Number")
        While True
            Console.WriteLine()
            Console.WriteLine("Guess my number between 1 and 10")
            Randomize()
            Dim ornd As New Random()
            Dim inum As Integer = ornd.Next(1, 11)
            Dim sask As String
            Dim iask As Integer
            While True
                Console.Write(">")
                sask = Console.ReadLine()
                Try
                    iask = CInt(sask)
                    If iask < inum Then
                        Console.WriteLine("Too Low")
                    ElseIf iask > inum Then
                        Console.WriteLine("Too High")
                    Else
                        Console.WriteLine("You got it!")
                        Exit While
                    End If
                Catch
                    If sask = "quit" Then End
                    Console.WriteLine("Error - input not valid, try again.")
                End Try
                Console.WriteLine()
            End While
        End While
    End Sub
End Module
