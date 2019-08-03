Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim language As String
        language = TextBox1.Text
        If language.ToUpper = "VISUAL BASIC" Then
            MsgBox("U THE WINNER")
        Else
            MsgBox(language & " is bad language")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
End Class
