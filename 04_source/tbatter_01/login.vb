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
                    "WHERE user_name = @UserName " &
                    "AND password = @Password " &
                    "AND delete_frag = 0"

                cmd.Parameters.AddWithValue("@UserName", userName)
                cmd.Parameters.AddWithValue("@Password", pswd)

                Dim result = cmd.ExecuteScalar()

                If result IsNot Nothing Then
                    Dim userId As Integer = CInt(result)

                    Session.CurrentUserId = userId

                    MessageBox.Show("ようこそ",
                                    "通知",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)

                    home.Show()
                    Me.Hide()
                Else
                    MessageBox.Show(
                        "ユーザーネームまたはパスワードが間違っているか、" & vbCrLf &
                        "このアカウントは削除されています。",
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

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        txt_loginID.Text = "t"
        txt_loginPswd.Text = "asdf"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        login_ad.Show()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ログインID
        txt_loginID.Text = "ユーザーネームを入力"
        txt_loginID.ForeColor = Color.Gray

        ' パスワード
        txt_loginPswd.Text = "パスワードを入力"
        txt_loginPswd.ForeColor = Color.Gray
        txt_loginPswd.UseSystemPasswordChar = False
    End Sub
    Private Sub txt_loginID_Enter(sender As Object, e As EventArgs) Handles txt_loginID.Enter
        If txt_loginID.ForeColor = Color.Gray Then
            txt_loginID.Text = ""
            txt_loginID.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txt_loginID_Leave(sender As Object, e As EventArgs) Handles txt_loginID.Leave
        If txt_loginID.Text = "" Then
            txt_loginID.Text = "ユーザーネームを入力"
            txt_loginID.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txt_loginPswd_Enter(sender As Object, e As EventArgs) Handles txt_loginPswd.Enter
        If txt_loginPswd.ForeColor = Color.Gray Then
            txt_loginPswd.Text = ""
            txt_loginPswd.ForeColor = Color.Black
            txt_loginPswd.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txt_loginPswd_Leave(sender As Object, e As EventArgs) Handles txt_loginPswd.Leave
        If txt_loginPswd.Text = "" Then
            txt_loginPswd.Text = "パスワードを入力"
            txt_loginPswd.ForeColor = Color.Gray
            txt_loginPswd.UseSystemPasswordChar = False
        End If
    End Sub
End Class
