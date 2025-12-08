Public Class newUser
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub pic_back_Click(sender As Object, e As EventArgs) Handles pic_back.Click
        Me.Close()
        login.Show()
    End Sub
End Class