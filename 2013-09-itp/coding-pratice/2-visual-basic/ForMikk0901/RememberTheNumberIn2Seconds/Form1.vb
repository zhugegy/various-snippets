Public Class Form1
    Dim counter As Integer
    Dim timelimit As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        timelimit = NumericUpDown1.Value
        counter = 0
        Label1.Text = ""
        Label1.Visible = True
        Timer1.Start()
        For i = 0 To 6
            Randomize()
            Label1.Text = Label1.Text & Int(Rnd() * 10)
        Next
        Label4.Text = Label1.Text
        Label1.Text = Format(Int(Label1.Text), "0,000,000")
        Label1.Text = Label1.Text.Replace(",", " ")
        Randomize()
        Label1.Left = Rnd() * (Me.Width - Label1.Width) * 0.8
        Randomize()
        Label1.Top = Rnd() * (Me.Height - Label1.Height) * 0.8
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        Debug.WriteLine(counter & " " & timelimit * 10)
        Label2.Text = IIf(timelimit * 10 - counter > 0, Format(timelimit - counter / 10, "0.0"), "0.0")
        If counter >= timelimit * 10 Then
            Timer1.Stop()
            Label1.Visible = False
            If Convert.ToString(InputBox("Please enter the number!")) = Label4.Text Then
                MsgBox("Right!")
            Else
                MsgBox("Wrong!")
            End If
            Button1.Enabled = True
            Label2.Text = Format(timelimit, "0.0")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "0.0"
    End Sub


End Class
