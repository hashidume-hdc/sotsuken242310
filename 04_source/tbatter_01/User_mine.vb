Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing

Public Class User_mine

    ' ==============================
    ' タイムライン表示モード
    ' ==============================
    Private Enum TimelineMode
        MyPosts
        LikedPosts
    End Enum

    Private currentMode As TimelineMode = TimelineMode.MyPosts
    Private currentCommentParentId As Integer = 0

    ' ==============================
    ' フォームロード
    ' ==============================
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
        LoadFollowCount()
        LoadTimeline()

    End Sub

    Private Sub User_mine_Activated(sender As Object, e As EventArgs) _
        Handles Me.Activated

        LoadUserProfile()
        LoadFollowCount()
        LoadTimeline()

    End Sub

    ' ==============================
    ' タイムライン制御
    ' ==============================
    Private Sub LoadTimeline()

        hbtk_FlowLayout.Controls.Clear()

        If currentCommentParentId <> 0 Then
            LoadCommentTimeline(currentCommentParentId)
        Else
            LoadNormalTimeline()
        End If

    End Sub

    ' ==============================
    ' 通常タイムライン
    ' ==============================
    Private Sub LoadNormalTimeline()

        Dim sql As String = ""

        If currentMode = TimelineMode.MyPosts Then

            sql =
                "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
                "FROM hbtks h " &
                "LEFT JOIN users u ON h.user_id = u.user_id " &
                "WHERE h.pare_hbtk_id = 0 " &
                "AND h.delete_frag = 0 " &
                "AND h.user_id = @uid " &
                "ORDER BY h.hbtk_time DESC"

        Else

            sql =
                "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
                "FROM likes l " &
                "INNER JOIN hbtks h ON l.hbtk_id = h.hbtk_id " &
                "LEFT JOIN users u ON h.user_id = u.user_id " &
                "WHERE l.user_id = @uid " &
                "AND h.delete_frag = 0 " &
                "ORDER BY h.hbtk_time DESC"

        End If

        LoadPosts(sql, Nothing, False)

    End Sub

    ' ==============================
    ' 親＋返信表示
    ' ==============================
    Private Sub LoadCommentTimeline(parentId As Integer)

        ' 親投稿
        LoadPosts(
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM hbtks h LEFT JOIN users u ON h.user_id=u.user_id " &
            "WHERE h.hbtk_id=@id AND h.delete_frag=0",
            parentId,
            False)

        ' 返信
        LoadPosts(
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM hbtks h LEFT JOIN users u ON h.user_id=u.user_id " &
            "WHERE h.pare_hbtk_id=@id AND h.delete_frag=0 " &
            "ORDER BY h.hbtk_time ASC",
            parentId,
            True)

    End Sub

    ' ==============================
    ' 共通描画
    ' ==============================
    Private Sub LoadPosts(sql As String, id As Integer?, indent As Boolean)

        Dim dt As New DataTable

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)

                If sql.Contains("@uid") Then
                    cmd.Parameters.AddWithValue("@uid", Session.CurrentUserId)
                End If

                If id.HasValue Then
                    cmd.Parameters.AddWithValue("@id", id.Value)
                End If

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

            End Using
        End Using

        For Each row As DataRow In dt.Rows

            Dim ctl As New tbatter_hbtk_Control()

            AddHandler ctl.CommentRequested, AddressOf OnCommentRequested
            AddHandler ctl.ViewRepliesRequested, AddressOf OnViewRepliesRequested

            ctl.SetData(
                CInt(row("hbtk_id")),
                CInt(row("user_id")),
                "@" & row("user_name").ToString(),
                row("content").ToString(),
                row("icon_url").ToString(),
                GetPostImages(CInt(row("hbtk_id")))
            )

            ctl.Width = hbtk_FlowLayout.ClientSize.Width - 20

            If indent Then
                ctl.SetAsComment()
            End If

            hbtk_FlowLayout.Controls.Add(ctl)

        Next

    End Sub
    Private Sub OnCommentRequested(hbtkId As Integer)

        Using frm As New comment_frm(hbtkId)
            If frm.ShowDialog() = DialogResult.OK Then
                currentCommentParentId = hbtkId
                LoadTimeline()
            End If
        End Using

    End Sub
    Private Sub OnViewRepliesRequested(hbtkId As Integer)

        If currentCommentParentId = hbtkId Then
            currentCommentParentId = 0
        Else
            currentCommentParentId = hbtkId
        End If

        LoadTimeline()

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
    Private Sub LoadUserProfile()

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(
                "SELECT user_name, icon_url, bio FROM users WHERE user_id=@u", conn)

                cmd.Parameters.AddWithValue("@u", Session.CurrentUserId)
                conn.Open()

                Using rdr = cmd.ExecuteReader()
                    If rdr.Read() Then

                        lbl_Usrname.Text = rdr("user_name").ToString()
                        lbl_me.Text = rdr("bio").ToString()

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
    Private Sub LoadFollowCount()

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(
                "SELECT COUNT(*) FROM follows WHERE user_id=@u", conn)

                cmd.Parameters.AddWithValue("@u", Session.CurrentUserId)
                conn.Open()

                lbl_follow_people.Text = cmd.ExecuteScalar().ToString()

            End Using
        End Using

    End Sub

    ' ==============================
    ' モード切替
    ' ==============================
    Private Sub btn_hbtk_like_Click(sender As Object, e As EventArgs) _
        Handles btn_hbtk_like.Click

        currentCommentParentId = 0
        currentMode = TimelineMode.LikedPosts
        LoadTimeline()

    End Sub

    Private Sub btn_hbtk_me_Click(sender As Object, e As EventArgs) _
        Handles btn_hbtk_me.Click

        currentCommentParentId = 0
        currentMode = TimelineMode.MyPosts
        LoadTimeline()

    End Sub
    Private Sub btn_acount_setting_Click(sender As Object, e As EventArgs) _
        Handles btn_acount_setting.Click
        usrsetting_frm.Show()
    End Sub

    Private Sub pic_hbtk_Click(sender As Object, e As EventArgs) _
        Handles pic_hbtk.Click
        hbtk_frm.Show()
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) _
        Handles btn_home.Click
        Me.Hide()
        home.Show()
    End Sub

    Private Sub btn_sarch_Click(sender As Object, e As EventArgs) _
        Handles btn_sarch.Click
        Me.Hide()
        sarch.Show()
    End Sub

    Private Sub btn_trend_Click(sender As Object, e As EventArgs) _
        Handles btn_trend.Click
        Me.Hide()
        trend.Show()
    End Sub

    Private Sub btn_setting_Click(sender As Object, e As EventArgs) _
        Handles btn_setting.Click
        Me.Hide()
        setting.Show()
    End Sub

    Private Sub lbl_follow_Click(sender As Object, e As EventArgs) _
        Handles lbl_follow.Click
        follow_now.Show()
    End Sub

    Private Sub btn_messege_Click(sender As Object, e As EventArgs) _
        Handles btn_messege.Click
        s.Show()
        Me.Hide()
    End Sub

End Class
