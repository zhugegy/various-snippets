Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim st As New StringFunctions.Authentication
        Dim stringcheck As String = ""
        Dim result As Boolean
        result = st.isBlankString(stringcheck)
        If result = True Then
            MsgBox("good")
        Else
            MsgBox("bad")
        End If
    End Sub
End Class
