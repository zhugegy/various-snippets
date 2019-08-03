Public Class Form1
    Dim counter As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        counter = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        If counter = 5 Then
            Timer1.Stop()
            Debug.WriteLine("stoped")
        End If
        Debug.WriteLine("experiment")
    End Sub
End Class
