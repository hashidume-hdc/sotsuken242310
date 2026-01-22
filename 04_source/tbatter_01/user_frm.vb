Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.IO
Imports System.Drawing

Public Class Form3

    Private ReadOnly _userId As Integer   ' 表示対象ユーザー
    Private _isFollowing As Boolean       ' フォロー状態

    ' ===== コンストラクタ =====
    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub

    ' ===== フォームロード =====
    Private Sub user_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Session.CurrentUserId = 0 OrElse _userId <= 0 Then
            MessageBox.Show("ユーザー情報が不正です",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Me.Close()
            Exit Sub
        End If

        hbtk_FlowLayout.FlowDirection = FlowDirection.TopDown
        hbtk_FlowLayout.WrapContents = False
        hbtk_FlowLayout.AutoScroll = True

        LoadUserProfile()
        LoadUserTimeline()
        LoadFollowCount()

        _isFollowing = IsFollowing()
        UpdateFollowButton()

    End Sub

    ' ===== プロフィール読み込み =====
    Private Sub LoadUserProfile()

        Dim sql As String =
            "SELECT user_name, icon_url, bio " &
            "FROM users WHERE user_id = @userId"

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@userId", _userId)
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

                        If Not String.IsNullOrEmpty(iconPath) AndAlso File.Exists(iconPath) Then
                            Using img = Image.FromFile(iconPath)
                                pic_Usricon.Image = New Bitmap(img)
                            End Using
                            pic_Usricon.SizeMode = PictureBoxSizeMode.Zoom
                            pic_Usricon.Visible = True
                        Else
                            pic_Usricon.Visible = False
                        End If

                    End If
                End Using
            End Using
        End Using

    End Sub

    ' ===== 投稿一覧 =====
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
                cmd.Parameters.AddWithValue("@userId", _userId)

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

    ' ===== 投稿画像取得 =====
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

    ' ===== フォロー判定 =====
    Private Function IsFollowing() As Boolean

        Dim sql As String =
            "SELECT 1 FROM follows " &
            "WHERE user_id = @me AND follower_id = @target LIMIT 1"

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@me", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@target", _userId)
                conn.Open()
                Return cmd.ExecuteScalar() IsNot Nothing
            End Using
        End Using

    End Function

    ' ===== フォローボタン表示 =====
    Private Sub UpdateFollowButton()

        If _isFollowing Then
            btn_follow.Text = "フォロー中"
            btn_follow.BackColor = Color.LightGray
        Else
            btn_follow.Text = "フォロー"
            btn_follow.BackColor = SystemColors.Control
        End If

    End Sub

    ' ===== フォロートグル =====
    Private Sub btn_follow_Click(sender As Object, e As EventArgs) _
        Handles btn_follow.Click

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            conn.Open()

            If _isFollowing Then
                ' フォロー解除
                Using cmd As New MySqlCommand(
                    "DELETE FROM follows WHERE user_id=@me AND follower_id=@target", conn)

                    cmd.Parameters.AddWithValue("@me", Session.CurrentUserId)
                    cmd.Parameters.AddWithValue("@target", _userId)
                    cmd.ExecuteNonQuery()
                End Using

                _isFollowing = False

            Else
                ' フォロー
                Using cmd As New MySqlCommand(
                    "INSERT INTO follows (user_id, follower_id) VALUES (@me, @target)", conn)

                    cmd.Parameters.AddWithValue("@me", Session.CurrentUserId)
                    cmd.Parameters.AddWithValue("@target", _userId)
                    cmd.ExecuteNonQuery()
                End Using

                _isFollowing = True
            End If
        End Using

        UpdateFollowButton()

    End Sub
    Private Sub LoadFollowCount()

        Dim sql As String =
            "SELECT COUNT(*) FROM follows WHERE user_id = @userId"

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@userId", _userId)
                conn.Open()

                Dim count As Integer = CInt(cmd.ExecuteScalar())
                lbl_follow_people.Text = count.ToString()

            End Using
        End Using

    End Sub

End Class
