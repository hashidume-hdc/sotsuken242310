Imports MySql.Data.MySqlClient

Public Class newUser_ad
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim Connection As New MySqlConnection
        Dim Command As MySqlCommand
        Dim AdminName As String = txt_newloginID.Text   'ユーザ名
        Dim pswd As String = txt_newloginPswd.Text    'パス

        Connection.ConnectionString =
        "Database=sotuken242310;Data Source=localhost;User Id=root"

        Connection.Open()

        '① 同じユーザー名が存在するかチェック
        Command = Connection.CreateCommand()
        Command.CommandText =
        "SELECT COUNT(*) FROM admins WHERE admin_name = @adminname"
        Command.Parameters.AddWithValue("@adminname", AdminName)

        Dim count As Integer = Convert.ToInt32(Command.ExecuteScalar())

        If count > 0 Then
            '② すでに存在する場合
            MessageBox.Show("そのユーザーネームは既に使われています",
                        "エラー",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

            Connection.Close()
            Exit Sub
        End If

        '③ 存在しなければ INSERT
        Command.Parameters.Clear()
        Command.CommandText =
        "INSERT INTO admins (admin_name, password) VALUES (@adminname, @password)"
        Command.Parameters.AddWithValue("@adminname", AdminName)
        Command.Parameters.AddWithValue("@password", pswd)

        Command.ExecuteNonQuery()

        MessageBox.Show("ユーザー作成が完了しました",
                    "成功",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

        Connection.Close()

        Me.Close()
    End Sub
End Class