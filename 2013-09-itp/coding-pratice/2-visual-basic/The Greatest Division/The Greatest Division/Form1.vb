Public Class Form1
    Dim a, b As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        Do
            If a > b Then
                a = a - b
            Else
                b = b - a
            End If
        Loop Until a = b
        Label1.Text = a
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
