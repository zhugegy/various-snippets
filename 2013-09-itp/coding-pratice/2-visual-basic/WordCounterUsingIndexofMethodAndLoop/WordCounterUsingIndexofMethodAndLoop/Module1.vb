Module Module1

    Sub Main()
        Dim abc As String
        abc = Convert.ToString(Console.ReadLine())
        Dim postion As Integer = 0
        Dim word As Integer = 0
        Do Until postion < 0
            postion = abc.IndexOf(" ", postion + 1)
            word += 1

        Loop
        Console.WriteLine(CStr(word))
        Console.ReadLine()



    End Sub

End Module
