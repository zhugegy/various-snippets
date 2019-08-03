Module Module1

    Sub Main()
        Dim i As Integer, myarray(19) As Integer
        For i = 0 To myarray.GetUpperBound(0)
            myarray(i) = i
        Next
        Console.WriteLine(myarray(8))
        Console.ReadLine()
    End Sub

End Module
