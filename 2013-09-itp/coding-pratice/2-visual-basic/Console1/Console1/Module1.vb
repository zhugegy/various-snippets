Module Module1

    Sub Main()
        Console.WriteLine("Please enter your language in programming")
        Dim langu As String
        langu = Console.ReadLine()
        If langu.ToUpper = "VISUAL BASIC" Or
            langu.ToUpper = "BASIC.NET" Or
             langu.ToUpper = "VB.NET" Then
            MsgBox("U the winner!")
        Else
            Console.WriteLine(langu & "is not a bad language!")
        End If
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Press any key to exit!")
        Console.ReadLine()
    End Sub

End Module
