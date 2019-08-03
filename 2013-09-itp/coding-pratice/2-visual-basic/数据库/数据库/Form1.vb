Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection
        Dim sql As String
        Dim dbprovider As String
        Dim dbsource As String
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        
        dbprovider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        dbsource = "Data Source= D:/AddressBook.mdb"
        con.ConnectionString = dbprovider & dbsource
        con.Open()
        sql = "SELECT*FROM tblContacts"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "addresslist")
        MsgBox("Your database is open")
        TextBox1.Text = ds.Tables("addresslist").Rows(0).Item(1)
        TextBox2.Text = ds.Tables("addresslist").Rows(0).Item(2)
        con.Close()
        MsgBox("your is closed now")
    End Sub
End Class
