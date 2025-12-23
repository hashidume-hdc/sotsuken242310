Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class newUser
    '変数の宣言
    Dim DSet As New System.Data.DataSet
    Dim ConnectionString As String = "DRIVER={MySQL ODBC 8.4 ANSI Driver};SERVER=localhost;DATABASE=sotuken242310;UID=root;OPTION=3"
    Dim Connection As New System.Data.Odbc.OdbcConnection(ConnectionString.ToString)
    Dim DV1Rows As Integer = 0
    Dim SQLStrings As String
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim Connection As New MySqlConnection
        Dim Command As MySqlCommand
        Dim UserName As String = txt_newloginID.Text   'ユーザ名
        Dim pswd As String = txt_newloginPswd.Text    'パス

        Connection.ConnectionString =
        "Database=sotuken242310;Data Source=localhost;User Id=root"

        Connection.Open()

        '① 同じユーザー名が存在するかチェック
        Command = Connection.CreateCommand()
        Command.CommandText =
        "SELECT COUNT(*) FROM users WHERE user_name = @username"
        Command.Parameters.AddWithValue("@username", UserName)

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
        "INSERT INTO users (user_name, password) VALUES (@username, @password)"
        Command.Parameters.AddWithValue("@username", UserName)
        Command.Parameters.AddWithValue("@password", pswd)

        Command.ExecuteNonQuery()

        MessageBox.Show("ユーザー作成が完了しました",
                    "成功",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

        Connection.Close()

        Me.Close()
        login.Show()

    End Sub


    Private Sub pic_back_Click(sender As Object, e As EventArgs) Handles pic_back.Click
        Me.Close()
        login.Show()
    End Sub
End Class