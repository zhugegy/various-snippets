Public Class Form1
    Dim a As Integer = 1
    Dim b As Integer = 0
    Dim c As Integer = 1
    Dim d As Integer
    Dim a1 As Integer = 1
    Dim b1 As Integer = 0
    Dim c1 As Integer = 1
    Dim d1 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For a = 1 To 9
            c = 1
            b = b + 1
            Do
                d = a * c
                If d < 10 Then
                    If c = 1 Then
                        Label1.Text = Label1.Text & a & "*" & c & "=" & d & " "
                    Else
                        Label1.Text = Label1.Text & a & "*" & c & "=" & d & "  "
                    End If
                Else
                    Label1.Text = Label1.Text & a & "*" & c & "=" & d & " "
                End If
                    c = c + 1
            Loop Until c > b
            Label1.Text = Label1.Text & vbCrLf
        Next a
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For a1 = 1 To 9
            c1 = 1
            b1 = b1 + 1
            Label2.Text = Label2.Text & a1 & " "
            Do
                d1 = a1 * c1
                If d1 < 10 Then
                    If c1 = 1 Then
                        Label2.Text = Label2.Text & d1 & " "
                    Else
                        Label2.Text = Label2.Text & d1 & "  "
                    End If
                Else
                    Label2.Text = Label2.Text & d1 & " "
                End If
                c1 = c1 + 1
            Loop Until c1 > b1
            Label2.Text = Label2.Text & vbCrLf
        Next a1
        Label2.Text = Label2.Text & "  1  2  3  4  5  6  7  8  9"
    End Sub


End Class
