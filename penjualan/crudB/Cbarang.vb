Imports MySql.Data.MySqlClient

Public Class Cbarang
    Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(CS)
    Private Sub Cbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            c.Open()
            Dim query As String = "INSERT INTO barang (nama_barang,harga,stock) VALUES(@NM,@PR,@ST)"
            Dim cmd As New MySqlCommand(query, c)

            cmd.Parameters.AddWithValue("@NM", NM.Text)
            cmd.Parameters.AddWithValue("@PR", PR.Text)
            cmd.Parameters.AddWithValue("@ST", ST.Text)
            cmd.ExecuteNonQuery()
            MsgBox("berhasil insert")
            dataload()

        Catch ex As Exception
            MsgBox("tidak berhasil:" & ex.Message)

        Finally
            c.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        barang.Show()
    End Sub
End Class