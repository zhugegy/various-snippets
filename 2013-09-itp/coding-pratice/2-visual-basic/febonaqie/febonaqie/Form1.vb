Public Class Form1
    Dim a As Integer = 1
    Dim b As Integer = 1
    Dim c As Integer
    Dim i As Integer
    Dim n As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = TextBox1.Text
        If c < 3 Then
            Label1.Text = "1"
        Else
            For i = 3 To c
                n = b
                b = a + b
                a = n
            Next i
            Label1.Text = b
        End If
        a = 1
        b = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c = TextBox1.Text
        Label2.Text = ""
        For c = 1 To c
            If c < 3 Then
                Label2.Text = Label2.Text & "1" & vbCrLf
            Else
                For i = 3 To c
                    n = b
                    b = a + b
                    a = n
                Next i
                Label2.Text = Label2.Text & b & vbCrLf
            End If
            a = 1
            b = 1
        Next c
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
