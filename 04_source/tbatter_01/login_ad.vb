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
End Class