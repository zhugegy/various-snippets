Module Module1

    Sub Main()
        Dim pro() As Process = Process.GetProcesses
        For Each p As Process In pro
            Console.WriteLine(p.ProcessName & "     " & p.PrivateMemorySize64.ToString)
        Next
        Console.ReadLine()
    End Sub

End Module
