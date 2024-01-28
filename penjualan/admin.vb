Public Class admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'menampilkan form CRUD akun
        Dim akunF As New akun()
        Me.Close()
        akunF.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'menampilkan form crud barang
        Me.Close()
        barang.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'menampilkan form laporan
        Me.Close()
        laporan.Show()
    End Sub
End Class