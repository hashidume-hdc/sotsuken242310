Imports MySql.Data.MySqlClient
Imports System.Data

Public Class home

    Private Enum TimelineMode
        Normal
        FollowOnly
    End Enum

    Private currentMode As TimelineMode = TimelineMode.Normal
    Private currentCommentParentId As Integer = 0

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hbtk_FlowLayout.FlowDirection = FlowDirection.TopDown
        hbtk_FlowLayout.WrapContents = False
        hbtk_FlowLayout.AutoScroll = True
        LoadTimeline()
    End Sub

    Private Sub LoadTimeline()

        hbtk_FlowLayout.Controls.Clear()

        If currentCommentParentId <> 0 Then
            LoadCommentTimeline(currentCommentParentId)
            Exit Sub
        End If

        If currentMode = TimelineMode.Normal Then
            LoadNormalTimeline()
        Else
            LoadFollowTimeline()
        End If
    End Sub

    ' ===== 通常タイムライン =====
    Private Sub LoadNormalTimeline()

        Dim sql As String =
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM hbtks h " &
            "LEFT JOIN users u ON h.user_id = u.user_id " &
            "WHERE h.pare_hbtk_id = 0 AND h.delete_frag = 0 " &
            "ORDER BY h.hbtk_time DESC"

        LoadPosts(sql, Nothing, False)
    End Sub

    ' ===== フォロー中のみ =====
    Private Sub LoadFollowTimeline()

        Dim sql As String =
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM follows f " &
            "INNER JOIN hbtks h ON f.follower_id = h.user_id " &
            "LEFT JOIN users u ON h.user_id = u.user_id " &
            "WHERE f.user_id = @me " &
            "AND h.pare_hbtk_id = 0 " &
            "AND h.delete_frag = 0 " &
            "ORDER BY h.hbtk_time DESC"

        LoadPosts(sql, Nothing, False)
    End Sub

    ' ===== 親＋コメント =====
    Private Sub LoadCommentTimeline(parentId As Integer)

        LoadPosts(
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM hbtks h LEFT JOIN users u ON h.user_id=u.user_id " &
            "WHERE h.hbtk_id=@id AND h.delete_frag=0",
            parentId,
            False)

        LoadPosts(
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM hbtks h LEFT JOIN users u ON h.user_id=u.user_id " &
            "WHERE h.pare_hbtk_id=@id AND h.delete_frag=0 " &
            "ORDER BY h.hbtk_time ASC",
            parentId,
            True)
    End Sub

    ' ===== 共通描画 =====
    Private Sub LoadPosts(sql As String, id As Integer?, indent As Boolean)

        Dim dt As New DataTable

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)

                If sql.Contains("@me") Then
                    cmd.Parameters.AddWithValue("@me", Session.CurrentUserId)
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

    ' ===== 戻る =====
    Private Sub tbtr_icon_Click(sender As Object, e As EventArgs) Handles tbtr_icon.Click
        currentCommentParentId = 0
        LoadTimeline()
    End Sub

    ' ===== TL切替ボタン =====
    Private Sub btn_follow_Click(sender As Object, e As EventArgs) Handles btn_follow.Click
        currentCommentParentId = 0
        currentMode = TimelineMode.FollowOnly
        LoadTimeline()
    End Sub

    Private Sub btn_osusume_Click(sender As Object, e As EventArgs) Handles btn_osusume.Click
        currentCommentParentId = 0
        currentMode = TimelineMode.Normal
        LoadTimeline()
    End Sub

    Private Sub home_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadTimeline()
    End Sub

    Private Sub pic_hbtk_Click(sender As Object, e As EventArgs) Handles pic_hbtk.Click
        hbtk_frm.Show()
    End Sub

    Private Sub btn_account_Click(sender As Object, e As EventArgs) Handles btn_account.Click
        Me.Hide()
        User_mine.Show()
    End Sub

    Private Sub btn_sarch_Click(sender As Object, e As EventArgs) Handles btn_sarch.Click
        Me.Hide()
        sarch.Show()
    End Sub

    Private Sub btn_messege_Click(sender As Object, e As EventArgs) Handles btn_messege.Click
        Me.Hide()
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
