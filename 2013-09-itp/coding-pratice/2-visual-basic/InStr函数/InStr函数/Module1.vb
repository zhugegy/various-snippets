Module Module1

    Sub Main()
        Dim word1 As String = "hello"
        Dim word2 As String = "p"
        Dim position As Integer
        position = InStr(word1, word2)
        Console.WriteLine(position)
        Console.ReadLine()
    End Sub

End Module
