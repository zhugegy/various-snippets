Module Module1

    Sub Main()
        Dim ch As Char
        Dim password As String
        Dim i As Integer
        Dim valid As Boolean = False
        While valid = False
            Console.WriteLine("inputyour password, at least one symbol")
            password = Console.ReadLine()
            For i = 0 To password.Length - 1
                ch = password.Chars(i)
                If Not Char.IsLetterOrDigit(ch) Then
                    valid = True
                    Exit For
                Else
                    valid = False
                End If
            Next i
            If valid = True Then
                Console.WriteLine("password is valid")
            Else
                Console.WriteLine("password has to contain at least one symbol, press enter to retry")
            End If
        End While
        Console.Write("press enter to exit")
        Console.ReadLine()
    End Sub

End Module
