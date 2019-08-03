Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.FileSystem.WriteAllText("D:\1\Intro.Pro\J.txt", Now() & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText("D:\1\Intro.Pro\J.txt", TextBox1.Text & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText("D:\1\Intro.Pro\J.txt", "---------------------------------------------------------" & vbCrLf, True)
        My.Computer.FileSystem.WriteAllText("D:\1\Intro.Pro\J.txt", " " & vbCrLf, True)
        TextBox1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText("D:\1\Intro.Pro\J.txt")
        TextBox1.Text = fileContents
    End Sub
End Class
