Public Class Form1

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

    End Sub

    Private Sub Exitmenu_Click(sender As Object, e As EventArgs) Handles Exitmenu.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click


        Dim strFileName As String
        OPENFD.InitialDirectory = "C:\"
        OPENFD.Title = "Open a Text File"
        OPENFD.Filter = "Text Files|*.txt"
        OPENFD.ShowDialog()
        strFileName = OPENFD.FileName
        MsgBox(strFileName)
    End Sub

    Private Sub ViewTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTextToolStripMenuItem.Click
        ViewTextToolStripMenuItem.Checked = Not ViewTextToolStripMenuItem.Checked
        If ViewTextToolStripMenuItem.Checked = False Then
            TextBox1.Visible = False
        Else
            TextBox1.Visible = True

        End If
    End Sub
End Class
