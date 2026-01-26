Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Imports System.Drawing

Public Class Form3

    Private ReadOnly _userId As Integer
    Private _isFollowing As Boolean
    Private currentCommentParentId As Integer = 0

    ' ===== コンストラクタ =====
    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub

    ' ===== フォームロード =====
    Private Sub user_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Session.CurrentUserId = 0 OrElse _userId <= 0 Then
            MessageBox.Show("ユーザー情報が不正です", "エラー")
            Me.Close()
            Exit Sub
        End If

        hbtk_FlowLayout.FlowDirection = FlowDirection.TopDown
        hbtk_FlowLayout.WrapContents = False
        hbtk_FlowLayout.AutoScroll = True

        LoadUserProfile()
        LoadFollowCount()

        _isFollowing = IsFollowing()
        UpdateFollowButton()

        LoadTimeline()
    End Sub

    ' ===== タイムライン切替 =====
    Private Sub LoadTimeline()
        hbtk_FlowLayout.Controls.Clear()

        If currentCommentParentId = 0 Then
            LoadNormalTimeline()
        Else
            LoadCommentTimeline(currentCommentParentId)
        End If
    End Sub

    ' ===== 通常（特定ユーザーの投稿） =====
    Private Sub LoadNormalTimeline()

        Dim sql As String =
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM hbtks h " &
            "LEFT JOIN users u ON h.user_id = u.user_id " &
            "WHERE h.pare_hbtk_id = 0 " &
            "AND h.delete_frag = 0 " &
            "AND h.user_id = @uid " &
            "ORDER BY h.hbtk_time DESC"

        LoadPosts(sql, Nothing, False)
    End Sub

    ' ===== 親＋コメント =====
    Private Sub LoadCommentTimeline(parentId As Integer)

        ' 親投稿
        LoadPosts(
            "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
            "FROM hbtks h LEFT JOIN users u ON h.user_id=u.user_id " &
            "WHERE h.hbtk_id=@id AND h.delete_frag=0",
            parentId,
            False)

        ' コメント
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

                If sql.Contains("@uid") Then
                    cmd.Parameters.AddWithValue("@uid", _userId)
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

    ' ===== コメント要求 =====
    Private Sub OnCommentRequested(hbtkId As Integer)

        Using frm As New comment_frm(hbtkId)
            If frm.ShowDialog() = DialogResult.OK Then
                currentCommentParentId = hbtkId
                LoadTimeline()
            End If
        End Using
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

    ' ===== プロフィール =====
    Private Sub LoadUserProfile()

        Dim sql As String =
            "SELECT user_name, icon_url, bio FROM users WHERE user_id=@uid"

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@uid", _userId)
                conn.Open()

                Using rdr = cmd.ExecuteReader()
                    If rdr.Read() Then
                        lbl_Usrname.Text = rdr("user_name").ToString()
                        lbl_me.Text = rdr("bio").ToString()

                        Dim iconPath = rdr("icon_url").ToString()
                        If File.Exists(iconPath) Then
                            Using img = Image.FromFile(iconPath)
                                pic_Usricon.Image = New Bitmap(img)
                            End Using
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub

    ' ===== フォロー関連（元コードそのまま） =====
    Private Function IsFollowing() As Boolean
        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")
            Using cmd As New MySqlCommand(
                "SELECT 1 FROM follows WHERE user_id=@me AND follower_id=@t LIMIT 1", conn)
                cmd.Parameters.AddWithValue("@me", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@t", _userId)
                conn.Open()
                Return cmd.ExecuteScalar() IsNot Nothing
            End Using
        End Using
    End Function

    Private Sub UpdateFollowButton()
        btn_follow.Text = If(_isFollowing, "フォロー中", "フォロー")
    End Sub

    Private Sub btn_follow_Click(sender As Object, e As EventArgs) Handles btn_follow.Click
        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            conn.Open()

            If _isFollowing Then
                Using cmd As New MySqlCommand(
                    "DELETE FROM follows WHERE user_id=@me AND follower_id=@t", conn)
                    cmd.Parameters.AddWithValue("@me", Session.CurrentUserId)
                    cmd.Parameters.AddWithValue("@t", _userId)
                    cmd.ExecuteNonQuery()
                End Using
            Else
                Using cmd As New MySqlCommand(
                    "INSERT INTO follows (user_id, follower_id) VALUES (@me,@t)", conn)
                    cmd.Parameters.AddWithValue("@me", Session.CurrentUserId)
                    cmd.Parameters.AddWithValue("@t", _userId)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        End Using

        _isFollowing = Not _isFollowing
        UpdateFollowButton()
    End Sub

    Private Sub LoadFollowCount()
        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")
            Using cmd As New MySqlCommand(
                "SELECT COUNT(*) FROM follows WHERE user_id=@u", conn)
                cmd.Parameters.AddWithValue("@u", _userId)
                conn.Open()
                lbl_follow_people.Text = cmd.ExecuteScalar().ToString()
            End Using
        End Using
    End Sub

End Class
