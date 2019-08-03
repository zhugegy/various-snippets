Module Module1

    Sub Main()
        Dim a As Double = 8.88888
        Dim b As Double = 8.888
        Dim c, d As Double
        Dim e As Single
        Console.WriteLine(IIf(Format(a, "0.0") = Format(b, "0.0"), "Xiangdeng", "Butong"))
        Console.ReadLine()
        c = Format(a, "0.0")
        d = Format(b, "0.0")
        Console.WriteLine("C is " & c & ", D is " & d)
        Console.ReadLine()
        e = Format(b, "0.0")
        Console.WriteLine(IIf(e = c, "Xiangdeng", "Butong"))
        Console.ReadLine()
    End Sub

End Module
