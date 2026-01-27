Imports MySql.Data.MySqlClient
Imports System.Data

Public Class sarch

    Private currentCommentParentId As Integer = 0

    Private Sub sarch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hbtk_FlowLayout.FlowDirection = FlowDirection.TopDown
        hbtk_FlowLayout.WrapContents = False
        hbtk_FlowLayout.AutoScroll = True
    End Sub

    ' ===== 検索ボタン =====
    Private Sub pic_sarch_2_Click(sender As Object, e As EventArgs) _
        Handles pic_sarch_2.Click

        Dim keyword As String = txt_sarchwrd.Text.Trim()

        If String.IsNullOrEmpty(keyword) Then
            MessageBox.Show("検索ワードを入力してください")
            Exit Sub
        End If

        currentCommentParentId = 0

        If keyword.StartsWith("@") Then
            SearchByUser(keyword.Substring(1))
        Else
            SearchByContent(keyword)
        End If
    End Sub

    ' ===== 投稿本文検索 =====
    Private Sub SearchByContent(keyword As String)

        Dim sql As String =
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM hbtks h " &
            "LEFT JOIN users u ON h.user_id = u.user_id " &
            "WHERE h.delete_frag = 0 " &
            "AND h.content LIKE @kw " &
            "ORDER BY h.hbtk_time DESC"

        LoadPosts(sql, "%" & keyword & "%")
    End Sub

    ' ===== ユーザー検索 =====
    Private Sub SearchByUser(userName As String)

        Dim sql As String =
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM hbtks h " &
            "INNER JOIN users u ON h.user_id = u.user_id " &
            "WHERE h.delete_frag = 0 " &
            "AND u.user_name LIKE @kw " &
            "ORDER BY h.hbtk_time DESC"

        LoadPosts(sql, "%" & userName & "%")
    End Sub

    ' ===== 共通表示 =====
    Private Sub LoadPosts(sql As String, keyword As String)

        hbtk_FlowLayout.Controls.Clear()

        Dim dt As New DataTable

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@kw", keyword)

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        If dt.Rows.Count = 0 Then
            MessageBox.Show("該当する投稿はありません")
            Exit Sub
        End If

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
            hbtk_FlowLayout.Controls.Add(ctl)
        Next
    End Sub

    ' ===== コメント遷移 =====
    Private Sub OnCommentRequested(hbtkId As Integer)

        Using frm As New comment_frm(hbtkId)
            If frm.ShowDialog() = DialogResult.OK Then
                currentCommentParentId = hbtkId
                LoadCommentTimeline(hbtkId)
            End If
        End Using

    End Sub

    ' ===== 親＋コメント =====
    Private Sub LoadCommentTimeline(parentId As Integer)

        hbtk_FlowLayout.Controls.Clear()

        ' 親
        LoadCommentPosts(
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM hbtks h LEFT JOIN users u ON h.user_id=u.user_id " &
            "WHERE h.hbtk_id=@id AND h.delete_frag=0",
            parentId,
            False)

        ' コメント
        LoadCommentPosts(
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM hbtks h LEFT JOIN users u ON h.user_id=u.user_id " &
            "WHERE h.pare_hbtk_id=@id AND h.delete_frag=0 " &
            "ORDER BY h.hbtk_time ASC",
            parentId,
            True)

    End Sub

    Private Sub LoadCommentPosts(sql As String, parentId As Integer, indent As Boolean)

        Dim dt As New DataTable

        Using conn As New MySqlConnection(
        "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", parentId)

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

            If indent Then ctl.SetAsComment()

            ctl.Width = hbtk_FlowLayout.ClientSize.Width - 20
            hbtk_FlowLayout.Controls.Add(ctl)
        Next
    End Sub


    ' ===== 投稿画像 =====
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

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub pic_hbtk_Click(sender As Object, e As EventArgs) Handles pic_hbtk.Click
        hbtk_frm.Show()
    End Sub

    Private Sub btn_messege_Click(sender As Object, e As EventArgs) Handles btn_messege.Click
        s.Show()
        Me.Hide()
    End Sub

    Private Sub btn_trend_Click(sender As Object, e As EventArgs) Handles btn_trend.Click
        trend.Show()
        Me.Hide()
    End Sub

    Private Sub btn_account_Click(sender As Object, e As EventArgs) Handles btn_account.Click
        User_mine.Show()
        Me.Hide()
    End Sub

    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click
        setting.Show()
        Me.Hide()
    End Sub
End Class
