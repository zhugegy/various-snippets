Public Class Form1
    Dim counter As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const a% = 1, b% = 100
        Dim usr_answer%, random_nr%
        Dim min As Integer = a - 1, max As Integer = b + 1
        Dim logicounter As Integer = 0 ' count the times of unlogical input
        Dim errorcounter As Integer = 0 ' count the times of unnumeric input, if too many unnumeric input, give user a chance to quit the sub
        Dim i As Integer
        counter = 0
        Randomize()
        random_nr = Int(Rnd() * (b - a + 1) + a)
        Do
            Do
                Try
                    usr_answer = InputBox("Guess the number [" & a & " ... " & b & "]?") : Exit Do
                Catch ex As Exception
                    MsgBox("Please input a number.")
                    errorcounter += 1
                End Try
                If errorcounter = 2 Then
                    i = MsgBox("Do you want to quit?", MsgBoxStyle.YesNo)
                    If i = 6 Then
                        Exit Sub
                    Else
                        errorcounter = 1
                    End If
                End If
            Loop
            counter += 1
            If usr_answer = random_nr Then Exit Do
            If usr_answer < random_nr Then
                If min < usr_answer Then
                    MsgBox("Too small!")
                    min = usr_answer
                Else
                    MsgBox("It was not logical!")
                    logicounter += 1
                    If logicounter = 3 Then MsgBox("Do not joke!") : Exit Sub
                End If
            Else
                If max > usr_answer Then
                    MsgBox("Too big!")
                    max = usr_answer
                Else
                    MsgBox("It was not logical!")
                    logicounter += 1
                    If logicounter = 3 Then MsgBox("Do not joke!") : Exit Sub
                End If
            End If
        Loop
        MsgBox(random_nr & " is right answer! You did " & counter & IIf(counter = 1, " trial", " trails") & "!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Const a% = 1, b% = 100
        Dim time As Integer
        Dim i, number, min, max As Integer
        Try
            time = TextBox1.Text
        Catch
            MsgBox("Please input a number.")
            TextBox1.Text = "" : Exit Sub
        End Try
        ListBox1.Items.Clear()
        For i = 1 To time
            min = a
            max = b
            Randomize()
            number = Int(Rnd() * (b - a + 1) + a)
            counter = 1
            Do Until number = Int((min + max) / 2)
                counter += 1
                If number < Int((min + max) / 2) Then
                    max = Int((min + max) / 2)
                Else
                    min = Int((min + max) / 2)
                End If
            Loop
            If Int((min + max) / 2) < 10 Then
                'if number is 1-9, give an extra space after the number to keep the sort tidy.
                ListBox1.Items.Add("    " & Int((min + max) / 2) & " - " & counter)
            Else
                ListBox1.Items.Add("    " & Int((min + max) / 2) & "- " & counter)
            End If
        Next i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.GetCurrentProcess().CloseMainWindow()
    End Sub
End Class
