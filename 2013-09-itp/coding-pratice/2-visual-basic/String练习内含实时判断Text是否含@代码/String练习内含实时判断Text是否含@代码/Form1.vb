Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim LetterCount As Integer
        Dim strText As String
        Dim letter As Char
        strText = "Debugging"
        For i = 0 To strText.Length - 1
            letter = strText.Substring(i)
            If letter = "g" Then
                LetterCount = LetterCount + 1
            End If
        Next
        TextBox1.Text = "G appears " & LetterCount & " times"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ok As Boolean = False
        Dim oi As Char
        Dim words As String
        words = TextBox1.Text
        For i = 0 To words.Length - 1
            oi = words.Chars(i)
            If oi = "@" Then ok = True
        Next
        If ok = True Then
            Label1.Text = "OK"
        Else
            Label1.Text = "NotOK"
        End If

    End Sub
End Class
