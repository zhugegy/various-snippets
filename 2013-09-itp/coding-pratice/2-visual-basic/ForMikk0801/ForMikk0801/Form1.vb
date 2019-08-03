Public Class Form1
    Dim speed As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Left = 0
        speed = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PictureBox1.Right < (Me.Width - 50) Then speed += 5
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If speed >= 5 Then speed -= 5
        If (speed <= 5) And (PictureBox1.Right > (Me.Width - 200)) Then speed = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Left += speed
        If PictureBox1.Right > (Me.Width - 50) Then speed = 0
        If (PictureBox1.Right > (Me.Width - 200) Xor PictureBox1.Right > (Me.Width - 50)) And (speed <> 0) Then speed = ((Me.Width - PictureBox1.Right) / 200) * speed + 2
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = speed
    End Sub


End Class
