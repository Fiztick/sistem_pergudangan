Public Class Login

    Public Shared Users As New Users()

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text

        If TxtUsername.TextLength < 1 Then
            MessageBox.Show("Tolong masukkan sebuah username!")
        ElseIf TxtPassword.TextLength < 1 Then
            MessageBox.Show("Tolong masukkan sebuah password!")
        Else
            Dim data_user As List(Of String) = Users.CheckAuthDB(plainUsername, plainPassword)
            If data_user.Count > 0 Then
                Users.usernameProperty = data_user(1)
                Dim main_menu = New Menu()
                main_menu.Show()
                Me.Hide()
            Else
                MessageBox.Show("Username atau password salah")
            End If
        End If
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Register.Show()
    End Sub
End Class
