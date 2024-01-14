Imports System.Diagnostics.Eventing
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class kasir

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim loginF As New login()
        Me.Hide()
        loginF.Show()
    End Sub
    Private Sub tampil()
        ' Get the selected item as a string
        Dim slctd As String = ComboBox1.SelectedItem.ToString()

        If Not String.IsNullOrWhiteSpace(slctd) Then
            Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"
            Dim c As New MySqlConnection(CS)

            Try
                Dim query As String = "SELECT * FROM barang WHERE nama_barang=@nama"
                Dim cmd As New MySqlCommand(query, c)
                cmd.Parameters.AddWithValue("@nama", slctd)

                c.Open()
                Dim rd As MySqlDataReader = cmd.ExecuteReader()

                While rd.Read()
                    Dim qty As Integer = CInt(jumlah.Value)


                    Dim id As Integer = rd.GetInt32("id_barang")
                    Dim price As Decimal = rd.GetDecimal("harga")
                    Dim name As String = rd.GetString("nama_barang")

                    Dim TH As Decimal = price * qty

                    nama.Text = name
                    harga.Text = price
                    total.Text = TH.ToString()


                End While

            Catch ex As Exception
                MessageBox.Show("bang error:" & ex.Message)
            Finally
                c.Close()
            End Try
        End If
    End Sub
    Private Sub CalculateTotalAndShowLabel()
        Dim totalSum As Decimal = 0

        For Each row As DataGridViewRow In DataGridView1.Rows
            If Not row.IsNewRow Then ' Skip the new row if it's present
                Dim ttlValue As Decimal
                If Decimal.TryParse(row.Cells("totalH").Value.ToString(), ttlValue) Then
                    totalSum += ttlValue
                End If
            End If
        Next

        ' Display the total sum in a label
        Label14.Text = $"{totalSum}"
    End Sub

    ' Call this method whenever you need to update the total sum (e.g., after adding a new row)
    Private Sub UpdateTotalSum()
        CalculateTotalAndShowLabel()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        tampil()
    End Sub


    Private Sub kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"
        Dim c As New MySqlConnection(CS)
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
            MessageBox.Show("error bang:" & ex.Message)
        Finally
            c.Close()
        End Try


    End Sub

    Private Sub jumlah_ValueChanged(sender As Object, e As EventArgs) Handles jumlah.ValueChanged
        tampil()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tunai As Integer
        Dim kembali As Decimal = mula.Text - Label14.Text

        If Not Integer.TryParse(money.Text.ToString(), tunai) Then
            MessageBox.Show("Invalid input. Please enter valid values.")
            Return
        End If


        mula.Text = tunai
        Label19.Text = kembali
    End Sub
End Class
