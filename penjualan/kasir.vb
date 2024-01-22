Imports System.Diagnostics.Eventing
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational
Imports System.Drawing.Printing

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

        tampiluser()
    End Sub

    Private Sub jumlah_ValueChanged(sender As Object, e As EventArgs) Handles jumlah.ValueChanged
        tampil()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim st As Int32 = Label14.Text
        Dim dskn As Int32 = ComboBox3.Text
        Dim tunai As Int32 = mula.Text
        Dim total As Int32 = Label13.Text
        Dim kembali As Int32 = Label19.Text

        For Each row As DataGridViewRow In DataGridView2.Rows
            If Not row.IsNewRow Then
                Dim idU As Int64 = Convert.ToInt64(row.Cells("idU").Value)
                Dim idB As Int64 = Convert.ToInt64(row.Cells("idb").Value)
                Dim jmlh As Int32 = Convert.ToInt32(row.Cells("jumlahBar").Value)
                Dim NB As String = row.Cells("nama_B").Value
                Dim HB As String = row.Cells("hrg").Value
                Dim TH As String = row.Cells("total_ha").Value


                DataGridView1.Rows.Add(idU, idB, NB, HB, jmlh, TH, st, dskn, tunai, total, kembali)
            End If
        Next

        If DataGridView2.Rows.Count = 0 Then
            MsgBox("Pilih dulu bang")
        End If
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




        mula.Text = money.Text
        Label13.Text = Label14.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Using c As New MySqlConnection("Server=localhost;Database=penjualan;Uid=root;Pwd=;")
                c.Open()

                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Not row.IsNewRow Then
                        Dim query As String = "INSERT INTO transaksi (id_user,id_barang,jumlah_barang,subtotal,diskon,tunai,total,kembalian) VALUES (@iduser, @idbarang, @jumlahB, @subttl, @DS, @uang, @ttl, @change);"

                        Dim cmd As New MySqlCommand(query, c)
                        cmd.Parameters.AddWithValue("@iduser", row.Cells("iduser").Value)
                        cmd.Parameters.AddWithValue("@idbarang", row.Cells("idbarang").Value)
                        cmd.Parameters.AddWithValue("@jumlahB", row.Cells("jumlahB").Value)
                        cmd.Parameters.AddWithValue("@subttl", row.Cells("subttl").Value)
                        cmd.Parameters.AddWithValue("@DS", row.Cells("DS").Value)
                        cmd.Parameters.AddWithValue("@uang", row.Cells("uang").Value)
                        cmd.Parameters.AddWithValue("@ttl", row.Cells("ttl").Value)
                        cmd.Parameters.AddWithValue("@change", row.Cells("change").Value)

                        cmd.ExecuteNonQuery()
                    End If
                Next

                MsgBox("Berhasil insert")
            End Using
        Catch ex As Exception
            MsgBox("Error bang: " & ex.Message)
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

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Dim slctd As String = ComboBox3.SelectedItem.ToString().TrimEnd("%"c)

        ' Assuming 90000 is the amount you want to calculate the discount for
        Dim amount As Decimal = Label14.Text ' Replace this with your actual amount


        Dim percentageValue As Decimal
        If Decimal.TryParse(slctd, percentageValue) Then
            Dim cal As Decimal = (slctd / 100) * amount
            Dim hasil As Decimal = amount - cal

            ' Update Label13 with the calculated discount
            Label13.Text = hasil.ToString()
        Else
            MessageBox.Show("Invalid percentage selected.")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim perhitungan As Decimal = mula.Text - Label13.Text
        Label19.Text = perhitungan.ToString()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim idU As Int64 = Convert.ToInt64(namaUser.Text)
        Dim idB As Int64 = Convert.ToInt64(barangI.Text)
        Dim NB As String = ComboBox1.Text
        Dim jmlh As Int32 = Convert.ToInt32(jumlah.Value)
        Dim price As Int64 = Convert.ToInt64(harga.Text)
        Dim ttl As Int64 = Convert.ToInt64(total.Text)


        DataGridView2.Rows.Add(idU, idB, NB, jmlh, price, ttl)


        totalsum()
    End Sub
    Private Function totalbarang() As Integer
        Dim TB As Integer = 0
        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim rowtotal As Integer

                If Integer.TryParse(row.Cells("jumlahB").Value.ToString(), rowtotal) Then
                    TB += rowtotal
                Else
                    MsgBox("Invalid total value in row " & row.Index + 1)
                End If
            End If
        Next
        Return TB
    End Function


    Private Sub totalsum()
        Dim totalSum As Int64 = 0

        For Each row As DataGridViewRow In DataGridView2.Rows

            If Not row.IsNewRow Then

                Dim rowTotal As Int64

                If Int64.TryParse(row.Cells(5).Value.ToString(), rowTotal) Then

                    totalSum += rowTotal
                Else
                    MessageBox.Show("Invalid total value in row " & row.Index + 1)
                End If
            End If
        Next


        Label14.Text = totalSum.ToString()
    End Sub
    Dim WithEvents PD As New PrintDocument
    Dim ppd As New PrintPreviewDialog
    Dim longpaper As Integer
    Private Sub pd_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("custom", 600, 500)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub pd_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage

        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width - PD.DefaultPageSettings.Margins.Right

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "*******************************************************************************************************************************"
        Dim tall As Integer = 10

        ' Header
        e.Graphics.DrawString("CESHOP", f14, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("JLN H MUSA 2 LIMO", f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("oleh: " & ComboBox2.Text, f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString(line, f10, Brushes.Black, centermargin, tall, center)

        ' DetailHeader
        tall += 20
        e.Graphics.DrawString("Barang", f8, Brushes.Black, leftmargin, tall)
        e.Graphics.DrawString("Harga", f8, Brushes.Black, leftmargin + 80, tall)
        e.Graphics.DrawString("Jumlah", f8, Brushes.Black, leftmargin + 200, tall)
        e.Graphics.DrawString("Total", f8, Brushes.Black, rightmargin - 80, tall, right)
        tall += 20
        e.Graphics.DrawString(line, f10, Brushes.Black, centermargin, tall, center)


        ' Content
        For Each erow As DataGridViewRow In DataGridView1.Rows
            tall += 20
            ' Adjust the following line based on your DataGridView columns
            e.Graphics.DrawString($"{erow.Cells("Nbarang").Value}", f8, Brushes.Black, leftmargin, tall)
            e.Graphics.DrawString($"{erow.Cells("harga_barang").Value}", f8, Brushes.Black, leftmargin + 80, tall)
            e.Graphics.DrawString($"{erow.Cells("jumlahB").Value}", f8, Brushes.Black, leftmargin + 200, tall)
            e.Graphics.DrawString($"{erow.Cells("ttl").Value}", f8, Brushes.Black, rightmargin - 80, tall, right)
        Next

        tall += 20
        e.Graphics.DrawString("------------------------------------", f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("Total Pembelian: " & totalbarang().ToString(), f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("subtotal: " & DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells("subttl").Value.ToString(), f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("diskon: " & DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells("DS").Value.ToString() & "%", f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("------------------------------------", f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("total: " & Label13.Text, f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("tunai: " & mula.Text, f10, Brushes.Black, centermargin, tall, center)
        tall += 20
        e.Graphics.DrawString("kembali: " & Label19.Text, f10, Brushes.Black, centermargin, tall, center)


    End Sub


    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        changelongpaper()
        ppd.Document = PD
        ppd.ShowDialog()
        'PD.Print()  'Direct Print
    End Sub
End Class
