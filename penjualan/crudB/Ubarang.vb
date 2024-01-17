Imports MySql.Data.MySqlClient

Public Class Ubarang
    Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(CS)
    Private Sub Ubarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataload()
    End Sub
    Private Sub dataload()
        Dim query As String = "SELECT * FROM barang"
        Dim data As New MySqlDataAdapter(query, c)
        Dim table As New DataTable()
        data.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim slctd As Integer = CInt(DataGridView1.SelectedRows(0).Cells(0).Value)
                Dim query As String = "UPDATE barang SET nama_barang=@NM, harga=@HG, stock=@ST WHERE id_barang=@id"
                Dim cmd As New MySqlCommand(query, c)

                cmd.Parameters.AddWithValue("@NM", NM.Text)
                cmd.Parameters.AddWithValue("@HG", PR.Text)
                cmd.Parameters.AddWithValue("@ST", ST.Text)
                cmd.Parameters.AddWithValue("@ID", slctd)
                c.Open()
                cmd.ExecuteNonQuery()
                MsgBox("berhasil update")
                dataload()
            Else
                MsgBox("please select row to update")
            End If
        Catch ex As Exception
            MsgBox("gabisa bang:" & ex.Message)
        Finally
            c.Close()
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim slctd As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            Dim query As String = "SELECT * FROM barang WHERE id_barang = @id"

            Using cmd As New MySqlCommand(query, c)
                cmd.Parameters.AddWithValue("@id", slctd)

                Try
                    c.Open()
                    Dim rd As MySqlDataReader = cmd.ExecuteReader()

                    If rd.Read() Then
                        NM.Text = rd("nama_barang").ToString()
                        PR.Text = rd("harga").ToString()
                        ST.Text = rd("stock").ToString()
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                Finally
                    c.Close()
                End Try
            End Using
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NM.Text = ""
        PR.Text = ""
        ST.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        barang.Show()
    End Sub
End Class