' login.vb
Imports MySql.Data.MySqlClient

Public Class login

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        If String.IsNullOrWhiteSpace(txt_loginID.Text) _
        OrElse String.IsNullOrWhiteSpace(txt_loginPswd.Text) Then
            MessageBox.Show("ユーザーネームまたはパスワードが入力されていません。",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim userName As String = txt_loginID.Text
        Dim pswd As String = txt_loginPswd.Text

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            conn.Open()

            Using cmd As MySqlCommand = conn.CreateCommand()

                cmd.CommandText =
                    "SELECT user_id FROM users " &
                    "WHERE user_name = @UserName AND password = @Password"

                cmd.Parameters.AddWithValue("@UserName", userName)
                cmd.Parameters.AddWithValue("@Password", pswd)

                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    Dim userId As Integer = CInt(result)

                    ' ★ Session に保存
                    Session.CurrentUserId = userId

                    MessageBox.Show("ようこそ",
                                    "通知",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)

                    home.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("ユーザーネームまたはパスワードが間違っています。",
                                    "エラー",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                End If

            End Using
        End Using
    End Sub


    Private Sub btn_newuser_Click(sender As Object, e As EventArgs) Handles btn_newuser.Click
        newUser.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_loginID.Text = "t"
        txt_loginPswd.Text = "asdf"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        login_ad.Show()
    End Sub
End Class
