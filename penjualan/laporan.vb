Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient

Public Class laporan
    Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(CS)
    Dim SortOrder As String = "id_transaksi ASC" ' Default sorting order

    Private Sub laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' By default, load the data in ascending order
        tampildata(SortOrder)
    End Sub

    Private Sub tampildata(sortOrder As String)
        Dim queryText As String = "SELECT * FROM transaksi LEFT JOIN barang ON transaksi.id_barang = barang.id_barang ORDER BY " & sortOrder
        Dim query As New MySqlDataAdapter(queryText, c)
        Dim tabel As New DataTable
        query.Fill(tabel)
        DataGridView1.DataSource = tabel
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ' Sort the DataGridView by the specified column in ascending order
            SortOrder = "id_transaksi ASC"
            tampildata(SortOrder)
        Else
            ' Revert to the original data order
            SortOrder = "id_transaksi ASC"
            tampildata(SortOrder)
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            ' Sort the DataGridView by the specified column in descending order
            SortOrder = "id_transaksi DESC"
            tampildata(SortOrder)
        Else
            ' Revert to the original data order
            SortOrder = "id_transaksi ASC"
            tampildata(SortOrder)
        End If
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Call the Print method to start the printing process
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim leftmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left

        ' Print the header
        Dim tall As Integer = 10
        For Each column As DataGridViewColumn In DataGridView1.Columns
            e.Graphics.DrawString(column.HeaderText, f10b, Brushes.Black, leftmargin, tall)
            leftmargin += 120 ' Adjust the horizontal spacing based on your needs
        Next

        ' Select all cells in the DataGridView
        DataGridView1.SelectAll()

        ' Content
        tall += 20
        For Each erow As DataGridViewRow In DataGridView1.SelectedRows
            leftmargin = PrintDocument1.DefaultPageSettings.Margins.Left
            tall += 20
            For Each cell As DataGridViewCell In erow.Cells
                e.Graphics.DrawString($"{cell.Value}", f8, Brushes.Black, leftmargin, tall)
                leftmargin += 120 ' Adjust the horizontal spacing based on your needs
            Next
        Next
    End Sub


End Class
