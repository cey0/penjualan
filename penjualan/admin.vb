Public Class admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim akunF As New akun()
        Me.Close()
        akunF.Show()
    End Sub
End Class