Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login_ad.Show()
        Me.Hide()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        ' 未入力チェック
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

                ' ① ログイン判定用SQL
                cmd.CommandText =
                "SELECT COUNT(*) FROM users " &
                "WHERE user_name = @UserName AND password = @Password"

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@UserName", userName)
                cmd.Parameters.AddWithValue("@Password", pswd)

                Dim count As Integer = CInt(cmd.ExecuteScalar())

                If count = 1 Then
                    MessageBox.Show("ようこそ",
                                "通知",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

                    ' ② user_id 取得用SQL
                    cmd.CommandText =
                    "SELECT user_id FROM users WHERE user_name = @UserName"

                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@UserName", userName)

                    Dim userId As Integer = CInt(cmd.ExecuteScalar())

                    ' ③ hbtk_frm に user_id を渡す（表示はしない）
                    Dim hbtk As New hbtk_frm()
                    hbtk.UserId = userId

                    ' ここで home を表示する
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
        home.Show()
        Me.Hide()
    End Sub
End Class
