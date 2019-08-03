Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const a% = 1, b% = 100
        Dim counter As Integer
        Dim unlogicalcounter As Integer
        Dim small As Integer = a - 1
        Dim big As Integer = b + 1



        Dim usr_answer%, random_nr%
        Randomize()
        random_nr = Int(Rnd() * (b - a + 1) + a)
        Do
            usr_answer = Val(InputBox("Guess the number [" & a & " ... " & b & "]?"))
            counter += 1
            If usr_answer = 0 Then MsgBox("Try next time again!") : Exit Sub
            If usr_answer = random_nr Then Exit Do
            If usr_answer < random_nr Then
                If usr_answer > small Then
                    MsgBox("Too small!")
                    small = usr_answer
                Else
                    MsgBox("Not Logical")
                    unlogicalcounter += 1
                    If unlogicalcounter = 3 Then MsgBox(" Do not joke!!") : Exit Sub

                End If


            Else

                If usr_answer < big Then
                    MsgBox("Too big!")
                    big = usr_answer
                Else
                    MsgBox("Not Logical")
                    unlogicalcounter += 1
                    If unlogicalcounter = 3 Then MsgBox(" Do not joke!!") : Exit Sub

                End If
            End If
        Loop
        MsgBox(random_nr & " is right answer! You did " & counter & IIf(counter = 1,
        " trial", " trails") & "!")
    End Sub
End Class
