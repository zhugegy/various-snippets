Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer2.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Top > PictureBox4.Top Then
            PictureBox1.Top -= 10
        End If
        If PictureBox2.Top > PictureBox5.Top Then
            PictureBox2.Top -= 10
        End If
        If PictureBox3.Top > PictureBox6.Top Then
            PictureBox3.Top -= 10
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Bottom < PictureBox4.Bottom Then
            PictureBox1.Top += 10
        End If
        If PictureBox2.Bottom < PictureBox5.Bottom Then
            PictureBox2.Top += 10
        End If
        If PictureBox3.Bottom < PictureBox6.Bottom Then
            PictureBox3.Top += 10
        End If
    End Sub
End Class
