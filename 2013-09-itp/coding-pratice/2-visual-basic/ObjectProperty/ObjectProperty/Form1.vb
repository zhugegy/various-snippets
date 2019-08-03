Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objChange As changeproperty
        Dim withe As Integer
        objChange = New changeproperty
        withe = Val(TextBox1.Text)
        objChange.widethc = withe
        PictureBox1.Width = objChange.widethc
        objChange = Nothing
    End Sub
End Class
