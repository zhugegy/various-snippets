Public Class Form1
    Sub picture_move_left()
        PictureBox1.Left -= 10
    End Sub
    Sub picture_move_right()
        PictureBox1.Left += 10
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Do
            If keyascii=Asc("A") or keyascii=Asc("a") then Call Sub picture_move_left
        Loop
    End Sub
    

End Class
