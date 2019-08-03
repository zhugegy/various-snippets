Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim d12 As Integer
    Dim c As Integer = 2
    Dim flag As Integer
    Private Function qiuzd(i As Integer, t As Integer)
        Do Until i = t
            If i > t Then
                i = i - t
            Else
                t = t - i
            End If
        Loop
        qiuzd = i
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        Do Until c > a
            For d12 = 1 To c
                If qiuzd(d12, c) > 1 Then
                    flag = 0
                    Exit For
                Else
                    flag = 1
                End If
            Next d12
            If flag = 1 Then
                Label1.Text = Label1.Text & c & " "
            End If
            c = c + 1
        Loop

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = TextBox1.Text
        Label2.Text = qiuzd(3, a)
    End Sub
End Class
