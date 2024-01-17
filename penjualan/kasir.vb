Imports System.Diagnostics.Eventing
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class kasir
    Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"
    Dim c As New MySqlConnection(CS)
    Dim loggedInUserId As Integer ' Assuming you have a way to track the logged-in user ID

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim loginF As New login()
        Me.Hide()
        loginF.Show()
    End Sub

    Private Function GetIdBarangFromNama(namaBarang As String) As Integer
        Dim idBarang As Integer = -1 ' Default value or error handling

        Try
            Dim query As String = "SELECT id_barang FROM barang WHERE nama_barang=@nama"
            Dim cmd As New MySqlCommand(query, c)
            cmd.Parameters.AddWithValue("@nama", namaBarang)

            c.Open()
            idBarang = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MessageBox.Show("Error getting id_barang: " & ex.Message)
        Finally
            c.Close()
        End Try

        Return idBarang
    End Function

    Private Sub tampildata()
        Try
            Dim query As New MySqlDataAdapter("SELECT t.id_transaksi, b.nama_barang, u.nama, t.jumlah_barang, t.subtotal, t.diskon, t.tunai, t.kembalian FROM transaksi t LEFT JOIN barang b ON t.id_barang = b.id_barang LEFT JOIN user u ON t.id_user = u.id_user", c)
            Dim data As New DataTable
            query.Fill(data)
            DataGridView2.DataSource = data
        Catch ex As Exception
            MsgBox("error:" & ex.Message)
        End Try
    End Sub
    Private Sub ProsesTransaksi(idBarang As Integer, idUser As Integer, jumlahBarang As Integer, tunai As Decimal)
        Try
            Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"
            Dim c As New MySqlConnection(CS)
            c.Open()

            Dim cmd As New MySqlCommand("ProsesTransaksi", c)
            cmd.CommandType = CommandType.StoredProcedure

            ' Parameters for the stored procedure
            cmd.Parameters.AddWithValue("@p_id_barang", idBarang)
            cmd.Parameters.AddWithValue("@p_id_user", idUser)
            cmd.Parameters.AddWithValue("@p_jumlah_barang", jumlahBarang)
            cmd.Parameters.AddWithValue("@p_tunai", tunai)

            ' Output parameters
            cmd.Parameters.Add("@p_id_transaksi", MySqlDbType.Int32).Direction = ParameterDirection.Output
            cmd.Parameters.Add("@p_kembalian", MySqlDbType.Decimal).Direction = ParameterDirection.Output

            ' Execute the stored procedure
            cmd.ExecuteNonQuery()

            ' Retrieve output parameters
            Dim idTransaksi As Integer = Convert.ToInt32(cmd.Parameters("@p_id_transaksi").Value)
            Dim kembalian As Decimal = Convert.ToDecimal(cmd.Parameters("@p_kembalian").Value)

            ' Handle the results as needed

            c.Close()
        Catch ex As Exception
            MsgBox("Error during transaction processing: " & ex.Message)
        End Try
    End Sub
    Private Sub tampil()
        Dim slctd As String = ComboBox1.SelectedItem?.ToString()

        If Not String.IsNullOrWhiteSpace(slctd) Then
            Try
                Dim idBarang As Integer = GetIdBarangFromNama(slctd)
                Dim qty As Integer = CInt(jumlah.Value)

                Dim query As String = "SELECT * FROM barang WHERE id_barang=@id"
                Dim cmd As New MySqlCommand(query, c)
                cmd.Parameters.AddWithValue("@id", idBarang)

                c.Open()
                Dim rd As MySqlDataReader = cmd.ExecuteReader()

                While rd.Read()
                    Dim price As Decimal = rd.GetDecimal("harga")
                    Dim name As String = rd.GetString("nama_barang")
                    Dim TH As Decimal = price * qty

                    nama.Text = name
                    harga.Text = price.ToString()
                    total.Text = TH.ToString()
                End While
            Catch ex As Exception
                MessageBox.Show("Error getting barang details: " & ex.Message)
            Finally
                c.Close()
            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        tampil()
    End Sub

    Private Sub kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim query As String = "SELECT nama_barang FROM barang"
            Dim cmd As New MySqlCommand(query, c)
            Dim rd As MySqlDataReader

            c.Open()
            rd = cmd.ExecuteReader()

            While rd.Read()
                Dim nama As String = rd.GetString("nama_barang")
                ComboBox1.Items.Add(nama)
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading barang data: " & ex.Message)
        Finally
            c.Close()
        End Try

        tampildata()
    End Sub

    Private Sub jumlah_ValueChanged(sender As Object, e As EventArgs) Handles jumlah.ValueChanged
        tampil()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim name As String = nama.Text.Trim()
        Dim price As Decimal
        Dim qty As Integer
        Dim ttl As Decimal
        Dim namaK As String = Kname.Text.Trim()

        If String.IsNullOrWhiteSpace(name) Then
            MessageBox.Show("Name is null or empty.")
            Return
        End If

        If Not Decimal.TryParse(harga.Text.Trim(), price) OrElse
           Not Integer.TryParse(jumlah.Value.ToString(), qty) OrElse
           Not Decimal.TryParse(total.Text.Trim(), ttl) Then
            MessageBox.Show("Invalid input. Please enter valid values.")
            Return
        End If

        DataGridView1.Rows.Add(name, qty, price, ttl, namaK)

        UpdateTotalSum()
    End Sub

    Private Sub UpdateTotalSum()
        CalculateTotalAndShowLabel()
    End Sub

    Private Sub CalculateTotalAndShowLabel()
        Dim totalSum As Decimal = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim ttlValue As Decimal
                If Decimal.TryParse(row.Cells("totalH").Value.ToString(), ttlValue) Then
                    totalSum += ttlValue
                End If
            End If
        Next

        Label14.Text = $"{totalSum}"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tunai As Integer
        Dim mulaValue As Decimal
        Dim label14Value As Decimal

        If Not Decimal.TryParse(mula.Text, mulaValue) Then
            MessageBox.Show("Invalid input for 'mula'. Please enter a valid numeric value.")
            Return
        End If

        If Not Decimal.TryParse(Label14.Text, label14Value) Then
            MessageBox.Show("Invalid input for 'Label14'. Please enter a valid numeric value.")
            Return
        End If

        Dim kembali As Decimal = mulaValue - label14Value

        Label19.Text = kembali.ToString()
        mula.Text = money.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim namaBarang As String = ComboBox1.SelectedItem.ToString()
            Dim idBarang As Integer = GetIdBarangFromNama(namaBarang)
            Dim jumlahBarang As Integer = CInt(jumlah.Value)
            Dim tunai As Decimal = money.Text

            ProsesTransaksi(idBarang, loggedInUserId, jumlahBarang, tunai)
            ' Optionally, you can update your DataGridView or other UI elements here
        Catch ex As Exception
            MessageBox.Show("Error processing transaction: " & ex.Message)
        End Try
    End Sub
End Class
