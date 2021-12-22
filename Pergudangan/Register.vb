Public Class Register
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim plainUsername As String = TxtUsername.Text
        Dim plainPassword As String = TxtPassword.Text

        If TxtUsername.TextLength > 0 And TxtPassword.TextLength > 0 Then
            ' Check if username alr used
            Dim authStatus As Boolean = Login.Users.CheckUsernameRegistToDB(plainUsername)
            If authStatus Then
                Login.Users.AddUserToDB(plainUsername, plainPassword)
                Me.Close()
            Else
                MessageBox.Show("Mohon maaf username telah digunakan")
            End If
        Else
            MessageBox.Show("Tolong lengkapi data terlebih dahulu!")
        End If
    End Sub
End Class