Imports MySql.Data.MySqlClient
Imports System.IO

Public Class usrsetting_frm

    Private selectedIconPath As String = Nothing

    Private Sub usrsetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Session.CurrentUserId = 0 Then
            MessageBox.Show("ログイン情報がありません",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End If

        LoadCurrentUserInfo()

    End Sub

    ' 現在のユーザー情報を読み込む
    Private Sub LoadCurrentUserInfo()

        Dim sql As String =
            "SELECT icon_url, bio " &
            "FROM users " &
            "WHERE user_id = @userId"

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId)
                conn.Open()

                Using rdr = cmd.ExecuteReader()
                    If rdr.Read() Then

                        lbl_me_setting.Text = rdr("bio").ToString()

                        Dim iconPath As String = rdr("icon_url").ToString()
                        selectedIconPath = iconPath

                        If pic_Usricon.Image IsNot Nothing Then
                            pic_Usricon.Image.Dispose()
                            pic_Usricon.Image = Nothing
                        End If

                        If Not String.IsNullOrEmpty(iconPath) AndAlso File.Exists(iconPath) Then
                            Using img = Image.FromFile(iconPath)
                                pic_Usricon.Image = New Bitmap(img)
                            End Using
                            pic_Usricon.SizeMode = PictureBoxSizeMode.Zoom
                        End If
                    End If
                End Using
            End Using
        End Using

    End Sub

    ' アイコンアップロード
    Private Sub btn_appload_Click(sender As Object, e As EventArgs) Handles btn_appload.Click

        Using ofd As New OpenFileDialog()
            ofd.Filter = "画像ファイル|*.jpg;*.jpeg;*.png;*.gif"

            If ofd.ShowDialog() = DialogResult.OK Then
                selectedIconPath = ofd.FileName

                If pic_Usricon.Image IsNot Nothing Then
                    pic_Usricon.Image.Dispose()
                End If

                Using img = Image.FromFile(selectedIconPath)
                    pic_Usricon.Image = New Bitmap(img)
                End Using

                pic_Usricon.SizeMode = PictureBoxSizeMode.Zoom
            End If
        End Using

    End Sub
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Dim sql As String =
            "UPDATE users " &
            "SET icon_url = @icon, bio = @bio " &
            "WHERE user_id = @userId"

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@icon", selectedIconPath)
                cmd.Parameters.AddWithValue("@bio", lbl_me_setting.Text)
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("プロフィールを更新しました",
                        "完了",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        Me.Close()

    End Sub

End Class
