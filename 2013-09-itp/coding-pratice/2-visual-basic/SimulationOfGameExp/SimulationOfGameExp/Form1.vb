Public Class Form1
    Dim exp(20) As Integer
    Dim current_exp As Integer = 10
    Dim exp_sum As Integer
    Dim lvl As Integer = 1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        exp(0) = 10
        For i = 1 To 20
            exp(i) = exp(i - 1) * 2
        Next
        Debug.WriteLine(exp(20))
        refreshstatus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Sub refreshstatus()
        Label3.Text = lvl
        Label4.Text = current_exp - exp(lvl - 1)
        Label5.Text = "/" & exp(lvl) - exp(lvl - 1)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Randomize()
        current_exp = current_exp + Int(Rnd() * 10)
        Debug.WriteLine(current_exp)
        If current_exp >= exp(lvl) And lvl < 20 Then
            Do While current_exp >= exp(lvl)
                lvl += 1
            Loop
            refreshstatus()
        End If
        Label4.Text = current_exp - exp(lvl - 1)
        If ((current_exp - exp(lvl - 1)) / (exp(lvl) - exp(lvl - 1))) <= 1 Then PictureBox1.Width = PictureBox2.Width * ((current_exp - exp(lvl - 1)) / (exp(lvl) - exp(lvl - 1)))
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
