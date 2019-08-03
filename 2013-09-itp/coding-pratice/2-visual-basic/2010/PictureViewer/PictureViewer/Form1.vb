Public Class Form1

    Private Sub btnLoadImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadImages.Click
        ImageList1.Images.Clear()
        ListView1.Clear()
       
        oFD1.InitialDirectory = "C:\"
        oFD1.Title = "Open an Image File"
        oFD1.Filter = "JPEGS|*.jpg|GIFS|*.gif"
        Dim ofdResults As Integer = oFD1.ShowDialog() 'hui tou zai shi TRY AGAIN
        If ofdResults = Windows.Forms.DialogResult.Cancel Then Exit Sub
       
        Try
            Dim single_file As String
            Dim counter As Integer = 0
            Dim num_of_files As Integer = oFD1.FileNames.Length
            Dim aryFilePaths(num_of_files - 1) As String



            For Each single_file In oFD1.FileNames
                aryFilePaths(counter) = single_file
                ImageList1.Images.Add(Image.FromFile(single_file))
                counter += 1
            Next
            ListView1.LargeImageList = ImageList1
            For i As Integer = 0 To counter - 1
                ListView1.Items.Add(aryFilePaths(i), i)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Dim big_filename As String
        For i = 0 To ListView1.SelectedItems.Count - 1
            big_filename = ListView1.SelectedItems(i).Text
            PictureBox1.Image = Image.FromFile(big_filename)
            Panel1.AutoScrollMinSize = New Size(PictureBox1.Image.Width, PictureBox1.Image.Height)
        Next
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim bmp As New Bitmap(PictureBox1.Image)
            Dim bmp_new As New Bitmap(CInt(PictureBox1.Image.Width / 2), _
            CInt(PictureBox1.Image.Height / 2))
            Dim gr As Graphics = Graphics.FromImage(bmp_new)
            gr.DrawImage(bmp, 0, 0, bmp_new.Width, bmp_new.Height)
            PictureBox1.Image = bmp_new
            Panel1.AutoScrollMinSize = New Size(PictureBox1.Image.Width, _
            PictureBox1.Image.Height)
        End If
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim bmp As New Bitmap(PictureBox1.Image)
            Dim bmp_new As New Bitmap(CInt(PictureBox1.Image.Width * 2), _
            CInt(PictureBox1.Image.Height * 2))
            Dim gr As Graphics = Graphics.FromImage(bmp_new)
            gr.DrawImage(bmp, 0, 0, bmp_new.Width, bmp_new.Height)
            PictureBox1.Image = bmp_new
            Panel1.AutoScrollMinSize = New Size(PictureBox1.Image.Width, _
            PictureBox1.Image.Height)
        End If
    End Sub
End Class
