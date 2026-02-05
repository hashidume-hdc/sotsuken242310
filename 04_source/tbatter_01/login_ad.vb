Imports MySql.Data.MySqlClient

Public Class login_ad
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        '変数の宣言
        Dim Connection As New MySqlConnection
        Dim Command As MySqlCommand
        If String.IsNullOrWhiteSpace(txt_loginID.Text) OrElse String.IsNullOrWhiteSpace(txt_loginPswd.Text) Then
            MessageBox.Show("ユーザーネームまたはパスワードが入力されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub ' 処理を中断
        End If

        Dim AdminName As String = txt_loginID.Text
        Dim pswd As String = txt_loginPswd.Text

        '接続文字列の設定
        Connection.ConnectionString = "Database=sotuken242310;Data Source=localhost;User Id=root"

        'オープン
        Connection.Open()

        '検索
        Command = Connection.CreateCommand
        Command.CommandText = "SELECT COUNT(*) FROM admins " &
                             $"WHERE admin_name = '{AdminName}' AND password = '{pswd}'"

        Dim count As Integer = Convert.ToInt32(Command.ExecuteScalar())

        If count = 1 Then
            MessageBox.Show("ようこそ", "通知", MessageBoxButtons.OK, MessageBoxIcon.Information)

            home_ad.Show()
            Me.Hide()
        Else
            MessageBox.Show("ユーザーネームまたはパスワードが間違っています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'クローズ
        Connection.Close()
    End Sub

    Private Sub pic_back_Click(sender As Object, e As EventArgs) Handles pic_back.Click
        Me.Close()
        login.Show()
    End Sub

    Private Sub login_ad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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