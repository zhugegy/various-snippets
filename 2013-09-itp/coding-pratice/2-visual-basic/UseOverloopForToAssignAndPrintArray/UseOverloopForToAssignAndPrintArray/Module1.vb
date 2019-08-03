Module Module1

    Sub Main()
        Dim test(2, 6) As Integer
        For i = 0 To test.GetUpperBound(0)
            For u = 0 To test.GetUpperBound(1)
                test(i, u) = i * 100 + u
                Console.Write(test(i, u) & "  ")

            Next
            Console.WriteLine("========")
        Next
        Console.ReadLine()
    End Sub

End Module
