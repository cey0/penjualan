Imports MySql.Data.MySqlClient

Public Enum Role
    admin
    kasir
End Enum

Public Class login
    Dim CS As String = "Server=localhost;Database=penjualan;Uid=root;Pwd=;"

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim um As String = username.Text
        Dim ps As String = password.Text

        If AuthenticationUser(um, ps, Role.admin) Then
            MessageBox.Show("Admin login successful")
            OpenAdminForm()
        ElseIf AuthenticationUser(um, ps, Role.kasir) Then
            MessageBox.Show("User login successful")
            OpenUserForm()
        Else
            MessageBox.Show("Invalid username, password, or role. Please try again.")
        End If
    End Sub

    Private Sub OpenAdminForm()
        Dim adminF As New admin()
        Me.Hide()
        adminF.Show()
    End Sub

    Private Sub OpenUserForm()
        Dim userF As New kasir()
        Me.Hide()
        userF.Show()
    End Sub

    Private Function AuthenticationUser(um As String, ps As String, role As Role) As Boolean
        Using c As New MySqlConnection(CS)
            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM user WHERE username=@um AND password=@ps AND role=@role", c)
                cmd.Parameters.AddWithValue("@um", um)
                cmd.Parameters.AddWithValue("@ps", ps)
                cmd.Parameters.AddWithValue("@role", role.ToString())

                Try
                    c.Open()

                    ' Debugging statements
                    Console.WriteLine("Generated SQL Query: " & cmd.CommandText)
                    Console.WriteLine("Username Parameter: " & cmd.Parameters("@um").Value)
                    Console.WriteLine("Password Parameter: " & cmd.Parameters("@ps").Value)
                    Console.WriteLine("Role Parameter: " & cmd.Parameters("@role").Value)

                    Dim rs As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return rs > 0
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                    Return False
                End Try
            End Using
        End Using
    End Function
End Class
