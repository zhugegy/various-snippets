Public Class Form1
    Private binding_source As New BindingSource()
    Private data_adapter As New SqlClient.SqlDataAdapter()
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DataGridView1.DataSource = Me.binding_source
        Get_DGV_Data("SELECT*FROM TypeAName")

    End Sub

    Private Sub Get_DGV_Data(ByVal select_command As String)
        Dim filepath As String
        Dim connect_string As String
        'filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Employees.mdf;"
        filepath = "C:\Employees.mdf;"
        connect_string = "Data Source=.\SQLEXPRESS;"
        connect_string += "AttachDbFilename=" & filepath
        connect_string += "Integrated Security=True;"
        connect_string += "Connect Timeout=30;"
        connect_string += "User Instance=True;"
        connect_string += "Trusted_Connection=Yes;"
        Try
            data_adapter = New SqlClient.SqlDataAdapter(select_command, connect_string)

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Dim cb As New SqlClient.SqlCommandBuilder(data_adapter)
        Dim data_table As New DataTable()
        Try
            data_adapter.Fill(data_table)
            binding_source.DataSource = data_table
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        data_adapter.Update(CType(binding_source.DataSource, DataTable))
        Get_DGV_Data(data_adapter.SelectCommand.CommandText)
    End Sub

    Private Sub btnSelected_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelected.Click
        Dim rowCount As Integer
        Dim i As Integer
        Dim message As String = ""
        rowCount = DataGridView1.CurrentRow.Cells.Count
        For i = 1 To rowCount - 1
            message = message & " " & (DataGridView1.CurrentRow.Cells(i).Value)
        Next
        MsgBox(message)
    End Sub
End Class
