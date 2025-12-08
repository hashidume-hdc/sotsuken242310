Public Class login
    Private Sub btn_newuser_Click(sender As Object, e As EventArgs) Handles btn_newuser.Click
        newUser.Show()
        Me.Hide()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        home.Show()
        Me.Hide()
    End Sub
End Class
