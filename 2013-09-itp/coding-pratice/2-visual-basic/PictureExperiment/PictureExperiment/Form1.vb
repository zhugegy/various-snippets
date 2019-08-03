Public Class Form1
    Dim i As Integer = 3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = Image.FromFile(" D:\1\Intro.Pro\2\Menu\Menu\bin\Debug\pic" & i & ".jpg")
    End Sub
End Class
