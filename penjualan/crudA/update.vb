Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class update
    Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"
    Dim C As New MySqlConnection(CS)
    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Private Sub loaddata()
        Dim query As New MySqlDataAdapter("SELECT * FROM user", C)
        Dim table As New DataTable
        query.Fill(table)

        DataGridView1.DataSource = table
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
                    MsgBox("Error: " & ex.Message)
                Finally
                    C.Close()
                End Try
            End Using
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        UN.Text = ""
        PW.Text = ""
        NM.Text = ""
        RL.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim slctd As Integer = CInt(DataGridView1.SelectedRows(0).Cells(0).Value)
                Dim query As String = "UPDATE user SET username=@UN, password=@PW, nama=@NM, role=@RL WHERE id_user=@ID"
                Dim cmd As New MySqlCommand(query, C)

                cmd.Parameters.AddWithValue("@UN", UN.Text)
                cmd.Parameters.AddWithValue("@PW", PW.Text)
                cmd.Parameters.AddWithValue("@NM", NM.Text)
                cmd.Parameters.AddWithValue("@RL", RL.Text)


                cmd.Parameters.AddWithValue("@ID", slctd)

                C.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Update berhasil")
                loaddata()
            Else
                MsgBox("Please select a row to update.")
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            C.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim keluar As New akun
        Me.Close()
        keluar.Show()
    End Sub

    Private Sub RL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RL.SelectedIndexChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub NM_TextChanged(sender As Object, e As EventArgs) Handles NM.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PW_TextChanged(sender As Object, e As EventArgs) Handles PW.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub UN_TextChanged(sender As Object, e As EventArgs) Handles UN.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class