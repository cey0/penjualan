Imports MySql.Data.MySqlClient

Public Class Dbarang
    Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(CS)

    Private Sub dataload()
        Dim query As String = "SELECT * FROM barang"
        Dim data As New MySqlDataAdapter(query, c)
        Dim table As New DataTable()
        data.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Dbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataload()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim slctd As Integer = CInt(DataGridView1.SelectedRows(0).Cells(0).Value)
            Dim rs As DialogResult = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If System.Windows.Forms.DialogResult.Yes Then
                Try
                    Dim query As String = "DELETE FROM barang WHERE id_barang=@ID"
                    Dim cmd As New MySqlCommand(query, c)
                    cmd.Parameters.AddWithValue("@ID", slctd)

                    c.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Berhasil menghapus data")
                    dataload()
                Catch ex As MySqlException
                    MsgBox("Error deleting data: " & ex.Message, MsgBoxStyle.Critical)
                Finally
                    c.Close()
                End Try
            End If
        Else
            MsgBox("Silakan pilih baris yang ingin dihapus.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        barang.Show()
    End Sub
End Class