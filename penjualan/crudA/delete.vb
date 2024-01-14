Imports MySql.Data.MySqlClient

Public Class delete
    Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"
    Dim C As New MySqlConnection(CS)

    Private Sub delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim slctd As Integer = CInt(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
            Dim query As String = "SELECT * FROM user WHERE id_user = @id"

            Using cmd As New MySqlCommand(query, C)
                cmd.Parameters.AddWithValue("@id", slctd)

                Try
                    C.Open()
                    Dim rd As MySqlDataReader = cmd.ExecuteReader()

                    If rd.Read() Then
                        UN.Text = rd("username").ToString()
                        PW.Text = rd("password").ToString()
                        NM.Text = rd("nama").ToString()
                        RL.Text = rd("role").ToString()
                    End If
                Catch ex As Exception
                    MsgBox("Error retrieving data: " & ex.Message)
                Finally
                    C.Close()
                End Try
            End Using
        End If
    End Sub

    Private Sub loaddata()
        Try
            Dim query As New MySqlDataAdapter("SELECT * FROM user", C)
            Dim table As New DataTable
            query.Fill(table)

            DataGridView1.DataSource = table
        Catch ex As Exception
            MsgBox("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim slctd As Integer = CInt(DataGridView1.SelectedRows(0).Cells(0).Value)
            Dim rs As DialogResult = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If rs = DialogResult.Yes Then
                Try
                    Dim query As String = "DELETE FROM user WHERE id_user=@ID"
                    Dim cmd As New MySqlCommand(query, C)
                    cmd.Parameters.AddWithValue("@ID", slctd)

                    C.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("Berhasil menghapus data")
                    loaddata()
                Catch ex As MySqlException
                    MsgBox("Error deleting data: " & ex.Message, MsgBoxStyle.Critical)
                Finally
                    C.Close()
                End Try
            End If
        Else
            MsgBox("Silakan pilih baris yang ingin dihapus.")
        End If
    End Sub
End Class
