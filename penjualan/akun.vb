﻿Public Class akun
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim bikin As New createB()
        Me.Close()
        bikin.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ubah As New update()
        Me.Close()
        ubah.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim hapus As New delete()
        Me.Close()
        hapus.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        admin.Show()
    End Sub
End Class