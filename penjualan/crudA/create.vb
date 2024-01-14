Imports MySql.Data.MySqlClient
Public Class create
    Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"
    Dim C As New MySqlConnection(CS)
    Private Sub create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            C.Open()
            Dim query As String = "INSERT INTO user (username,password,nama,role) VALUES(@uname,@pass,@nama,@level)"
            Dim cmd As New MySqlCommand(query, C)

            cmd.Parameters.AddWithValue("@uname", UN.Text)
            cmd.Parameters.AddWithValue("@pass", PW.Text)
            cmd.Parameters.AddWithValue("@nama", NM.Text)
            cmd.Parameters.AddWithValue("@level", RL.Text)

            cmd.ExecuteNonQuery()
            MsgBox("berhasil insert")
            loaddata()
        Catch ex As Exception
            MsgBox("error bang:" & ex.Message)

        Finally
            C.Close()
        End Try
    End Sub

    Private Sub loaddata()


        Dim query As String = "SELECT * FROM user"
        Dim data As New MySqlDataAdapter(query, C)
        Dim table As New DataTable()
        data.Fill(table)

        DataGridView1.DataSource = table

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim keluar As New akun
        Me.Close()
        keluar.Show()
    End Sub
End Class