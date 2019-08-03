Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, b, c As Integer
        Dim a As Integer = 0
        Do Until a > 100
            i = InputBox("please, and now is " & a & " odd number is " & b & ", even number is " & c & ".")
            If i Mod 2 = 1 Then
                c += 1
            Else
                b += 1
            End If
            a = a + i

        Loop
        MsgBox("Done, sum is " & a & ", odd number is " & b & ", even number is " & c & ".")
    End Sub
End Class
