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
    Private Function GetIduserFromNama(nama As String) As Integer
        Dim iduser As Integer = -1

        Try
            Dim quey As String = "SELECT id_user FROM user WHERE nama=@nama"
            Dim cmd As New MySqlCommand(quey, c)
            cmd.Parameters.AddWithValue("@nama", nama)
            c.Open()
            iduser = Convert.ToInt32(cmd.ExecuteScalar())
        Catch ex As Exception
            MsgBox("error geting id_user: " & ex.Message)
        Finally
            c.Close()
        End Try
        Return iduser
    End Function

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

    Private Sub tampiluser()
        Dim slctd As String = ComboBox2.SelectedItem?.ToString()

        If Not String.IsNullOrWhiteSpace(slctd) Then
            Try
                Dim iduser As Integer = GetIduserFromNama(slctd)

                ' Use the correct table name (assuming "user" is the correct table)
                Dim query As String = "SELECT * FROM user WHERE id_user=@id"
                Dim cmd As New MySqlCommand(query, c)
                cmd.Parameters.AddWithValue("@id", iduser)

                c.Open()
                Dim rd As MySqlDataReader = cmd.ExecuteReader()

                While rd.Read()
                    Dim id As String = rd.GetString("id_user")

                    namaUser.Text = id
                End While
            Catch ex As Exception
                MessageBox.Show("Error getting user details: " & ex.Message)
            Finally
                c.Close()
            End Try
        End If
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
                    Dim id As Integer = rd.GetInt64("id_barang")
                    Dim stok As Integer = rd.GetInt64("stock")
                    Dim TH As Decimal = price * qty

                    nama.Text = name
                    harga.Text = price.ToString()
                    total.Text = TH.ToString()
                    barangI.Text = id.ToString()
                    stock.Text = stok.ToString()

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
    Private Sub databarang()
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
    End Sub
    Private Sub datauser()
        Try
            Dim query As String = "SELECT nama FROM user"
            Dim cmd As New MySqlCommand(query, c)
            Dim rd As MySqlDataReader

            c.Open()
            rd = cmd.ExecuteReader()

            While rd.Read()
                Dim nama As String = rd.GetString("nama")
                ComboBox2.Items.Add(nama)
            End While
        Catch ex As Exception
            MessageBox.Show("Error loading user data: " & ex.Message)
        Finally
            c.Close()
        End Try
    End Sub
    Private Sub kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        datauser()
        databarang()
        tampildata()
        tampiluser()
    End Sub

    Private Sub jumlah_ValueChanged(sender As Object, e As EventArgs) Handles jumlah.ValueChanged
        tampil()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim name As String = nama.Text.Trim()
        Dim price As Decimal
        Dim qty As Integer
        Dim ttl As Decimal
        Dim namaK As String = ComboBox2.Text

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
            c.Open()
            Dim query As String = "INSERT INTO `transaksi`( `id_user`, `id_barang`, `jumlah_barang`, `subtotal`, `diskon`, `tunai`, `kembalian`) VALUES ( @UID, @BID, @JB, @ST, @DK, @TN, @KB) "
            Dim cmd As New MySqlCommand(query, c)
            cmd.Parameters.AddWithValue("@UID", namaUser.Text)
            cmd.Parameters.AddWithValue("@BID", barangI.Text)
            cmd.Parameters.AddWithValue("@JB", jumlah.Value)
            cmd.Parameters.AddWithValue("@ST", total.Text)
            cmd.Parameters.AddWithValue("@UID", namaUser.Text)
            cmd.Parameters.AddWithValue("@UID", namaUser.Text)
            cmd.Parameters.AddWithValue("@UID", namaUser.Text)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub name_TextChanged(sender As Object, e As EventArgs) Handles namaUser.TextChanged

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        tampiluser()
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles subtotal.Click

    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class
