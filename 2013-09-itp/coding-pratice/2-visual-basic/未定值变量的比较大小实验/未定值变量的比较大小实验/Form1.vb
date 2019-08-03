Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim temp, max As Integer
        If temp > max Then
            MsgBox(">")
        ElseIf temp = max Then
            MsgBox("=")
        ElseIf temp < max Then
            MsgBox("<")
        Else
            MsgBox("NONE")

        End If
    End Sub
End Class
