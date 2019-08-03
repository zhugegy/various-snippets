Public Class Form1
    Const de_time As Date = #6:00:00 PM#
    Const ar_time As Date = #10:00:00 AM#
    Dim re_time As Date = #5:00:00 PM#
    Const en_time As Date = #12:00:00 PM#
    Dim ta_boolean As Boolean
    Dim st_boolean As Boolean
    Dim distance As Integer   ' use this variable to reduce the version error on form's right hand side
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        distance = Me.Width - PictureBox2.Right
        PictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        Label2.Text = "Departure: " & Format(de_time, "HH:mm")
        Label1.Text = "Departure: " & Format(de_time.AddMinutes(-60 + 45), "HH:mm")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        re_time = re_time.AddMinutes(1)
        Label5.Text = Format(re_time, "HH:mm")
        Label4.Text = Format(re_time.AddMinutes(-60), "HH:mm")
        If re_time = de_time Then
            Label2.Text = "Arrival: " & Format(ar_time.AddMinutes(-60 + 60), "HH:mm")
            ta_boolean = True
        End If
        If re_time = de_time.AddMinutes(-60 + 45 + 60) Then
            Label1.Text = "Arrival: " & Format(ar_time, "HH:mm")
            st_boolean = True
        End If
        If re_time = ar_time.AddMinutes(24 * 60 - 60 + 60 + 60) Then
            ta_boolean = False
            Label1.Text = "Departure: " & Format(de_time.AddMinutes(-60 + 45), "HH:mm")
            Label11.Text = "Arrived"
            MsgBox("The ferries have arrived safely")
            PictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        End If
        If re_time = ar_time.AddMinutes(24 * 60) Then
            st_boolean = False
            Label2.Text = "Departure: " & Format(de_time, "HH:mm")
            Label10.Text = "Arrived"
            MsgBox("The ferries have arrived safely")
            PictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY)
        End If
        If re_time = en_time.AddMinutes(24 * 60) Then
            Timer1.Stop()
        End If
        If ta_boolean = True Then
            PictureBox2.Left = (1 - (re_time - de_time).TotalMinutes / (ar_time.AddMinutes(-60 + 60 + 60 + 24 * 60) - de_time).TotalMinutes) * (Me.Width - PictureBox2.Width - distance)
        End If
        If st_boolean = True Then
            PictureBox1.Left = (((re_time - de_time.AddMinutes(-60 + 45 + 60)).TotalMinutes) / ((ar_time.AddMinutes(24 * 60) - de_time.AddMinutes(-60 + 45 + 60)).TotalMinutes)) * (Me.Width - PictureBox1.Width - distance)
        End If
        If PictureBox1.Right <= PictureBox3.Left Then
            Label9.Text = Format(re_time.AddMinutes(-60), "HH:mm")
        Else
            Label9.Text = Format(re_time, "HH:mm")
        End If
        If PictureBox2.Left >= PictureBox3.Left Then
            Label12.Text = Format(re_time, "HH:mm")
        Else
            Label12.Text = Format(re_time.AddMinutes(-60), "HH:mm")
        End If
        If (ar_time.AddMinutes(-60 + 60 + 60 + 24 * 60) - re_time).TotalMinutes >= 0 Then
            Label11.Text = (ar_time.AddMinutes(-60 + 60 + 60 + 24 * 60) - re_time).ToString
            Label11.Text = Label11.Text.Remove(5)
        End If
        If (ar_time.AddMinutes(24 * 60) - re_time).TotalMinutes >= 0 Then
            Label10.Text = (ar_time.AddMinutes(24 * 60) - re_time).ToString
            Label10.Text = Label10.Text.Remove(5)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Interval = 20
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Interval = 1000
    End Sub
End Class
