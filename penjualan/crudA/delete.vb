﻿Imports MySql.Data.MySqlClient

Public Class delete
    Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"
    Dim C As New MySqlConnection(CS)

    Private Sub delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
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

            If System.Windows.Forms.DialogResult.Yes Then
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()
        akun.Show()
    End Sub
End Class
