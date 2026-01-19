Imports MySql.Data.MySqlClient
Imports System.Data

Public Class User_mine

    Private Sub User_mine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Session.CurrentUserId = 0 Then
            MessageBox.Show("ログイン情報がありません")
            Me.Close()
            Exit Sub
        End If

        hbtk_FlowLayout.FlowDirection = FlowDirection.TopDown
        hbtk_FlowLayout.WrapContents = False
        hbtk_FlowLayout.AutoScroll = True

        LoadUserProfile()
        LoadUserTimeline()
    End Sub

    Private Sub LoadUserTimeline()

        hbtk_FlowLayout.Controls.Clear()

        Dim sql As String =
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM hbtks h " &
            "LEFT JOIN users u ON h.user_id = u.user_id " &
            "WHERE h.pare_hbtk_id = 0 " &
            "AND h.delete_frag = 0 " &
            "AND h.user_id = @userId " &
            "ORDER BY h.hbtk_time DESC"

        Dim dt As New DataTable

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId)

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        For Each row As DataRow In dt.Rows
            Dim ctl As New tbatter_hbtk_Control()

            ctl.SetData(
                CInt(row("hbtk_id")),
                CInt(row("user_id")),
                "@" & row("user_name").ToString(),
                row("content").ToString(),
                row("icon_url").ToString(),
                GetPostImages(CInt(row("hbtk_id")))
            )

            ctl.Width = hbtk_FlowLayout.ClientSize.Width - 20
            hbtk_FlowLayout.Controls.Add(ctl)
        Next
    End Sub
    Private Sub LoadUserProfile()

        Dim sql As String =
        "SELECT user_name, icon_url, bio " &
        "FROM users " &
        "WHERE user_id = @userId"

        Using conn As New MySqlConnection(
        "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@userId", Session.CurrentUserId)
                conn.Open()

                Using rdr = cmd.ExecuteReader()
                    If rdr.Read() Then

                        ' ユーザー名
                        lbl_Usrname.Text = rdr("user_name").ToString()

                        ' 自己紹介
                        lbl_me.Text = rdr("bio").ToString()

                        ' アイコン
                        If pic_Usricon.Image IsNot Nothing Then
                            pic_Usricon.Image.Dispose()
                            pic_Usricon.Image = Nothing
                        End If

                        Dim iconPath As String = rdr("icon_url").ToString()

                        If String.IsNullOrEmpty(iconPath) Then
                            pic_Usricon.Visible = False
                        Else
                            Try
                                Using img = Image.FromFile(iconPath)
                                    pic_Usricon.Image = New Bitmap(img)
                                End Using
                                pic_Usricon.SizeMode = PictureBoxSizeMode.Zoom
                                pic_Usricon.Visible = True
                            Catch
                                pic_Usricon.Visible = False
                            End Try
                        End If

                    End If
                End Using
            End Using
        End Using

    End Sub


    Private Function GetPostImages(hbtkId As Integer) As List(Of String)
        Dim list As New List(Of String)

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(
                "SELECT image_url FROM post_images WHERE hbtk_id=@id ORDER BY sort_order", conn)

                cmd.Parameters.AddWithValue("@id", hbtkId)
                conn.Open()

                Using rdr = cmd.ExecuteReader()
                    While rdr.Read()
                        list.Add(rdr("image_url").ToString())
                    End While
                End Using
            End Using
        End Using

        Return list
    End Function

    Private Sub btn_acount_setting_Click(sender As Object, e As EventArgs) Handles btn_acount_setting.Click
        usrsetting_frm.Show()
    End Sub

    Private Sub pic_hbtk_Click(sender As Object, e As EventArgs) Handles pic_hbtk.Click
        hbtk_frm.Show()
    End Sub

    Private Sub btn_account_Click(sender As Object, e As EventArgs) Handles btn_account.Click
        LoadUserProfile()
        LoadUserTimeline()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub btn_sarch_Click(sender As Object, e As EventArgs) Handles btn_sarch.Click
        Me.Hide()
        sarch.Show()
    End Sub

    Private Sub btn_trend_Click(sender As Object, e As EventArgs) Handles btn_trend.Click
        Me.Hide()
        trend.Show()
    End Sub

    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        Me.Hide()
        setting.Show()
    End Sub
End Class
