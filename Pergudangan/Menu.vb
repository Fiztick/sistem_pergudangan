Public Class Menu
    Private Sub Menu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Show()
        Login.TxtUsername.Text = ""
        Login.TxtPassword.Text = ""
    End Sub
End Class