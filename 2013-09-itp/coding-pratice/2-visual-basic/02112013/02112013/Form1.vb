Public Class Form1
    Dim TextLine As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FILE_NAME As String = "D:\1\test.txt"
        Dim objReader As New System.IO.StreamReader(FILE_NAME)

        Do While objReader.Peek() <> -1
            TextLine = TextLine & objReader.ReadLine() & vbNewLine
        Loop
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = textline
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
