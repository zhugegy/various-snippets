Public Class Form1
    Dim counter As Integer
    Dim delay As Integer = 5
    Dim crosstime As Integer = 10

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox4.Visible = False
        PictureBox2.Visible = False
        Label1.Visible = False
        Label3.Text = "No Crossing"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        If counter > (delay + crosstime) * 10 Then counter = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        Select Case counter
            Case Is < (delay - 3) * 10
                Label3.Text = "Waiting for " & Format((delay * 10 - counter) / 10, "0.0") & "seconds"
            Case (delay - 3) * 10 To delay * 10
                If counter Mod 10 < 5 Then
                    PictureBox5.Visible = False
                Else
                    PictureBox5.Visible = True
                End If
                Label3.Text = "Waiting for " & Format((delay * 10 - counter) / 10, "0.0") & "seconds"
            Case delay * 10 + 1 To (delay + crosstime - 4) * 10
                PictureBox5.Visible = False
                PictureBox4.Visible = True
                PictureBox1.Visible = False
                PictureBox2.Visible = True
                Label1.Visible = True
                Label1.Text = Format(Int(((delay + crosstime) * 10 - counter) / 10), "00")
                Label3.Text = "Crossing " & Format(((delay + crosstime) * 10 - counter) / 10, "0.0") & "seconds"
            Case (delay + crosstime - 4) * 10 To (delay + crosstime) * 10
                If counter Mod 6 < 3 Then
                    PictureBox2.Visible = False
                Else
                    PictureBox2.Visible = True
                End If
                Label1.Text = Format(Int(((delay + crosstime) * 10 - counter) / 10), "00")
                Label3.Text = "Crossing " & Format(((delay + crosstime) * 10 - counter) / 10, "0.0") & "seconds"
            Case Is > (delay + crosstime) * 10
                PictureBox4.Visible = False
                PictureBox2.Visible = False
                PictureBox1.Visible = True
                PictureBox5.Visible = True
                Label1.Visible = False
                Label3.Text = "No Crossing"
        End Select
    End Sub
End Class
