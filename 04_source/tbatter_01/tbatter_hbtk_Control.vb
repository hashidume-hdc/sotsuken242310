Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class tbatter_hbtk_Control
    Inherits UserControl

    Public Property HbtkId As Integer
    Public Property UserId As Integer

    ' ===== コメント要求イベント =====
    Public Event CommentRequested(hbtkId As Integer)

    Public Sub New()
        InitializeComponent()
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.BackColor = Color.WhiteSmoke
    End Sub

    Public Sub SetData(
        hbtkId As Integer,
        userId As Integer,
        userName As String,
        content As String,
        iconPath As String,
        imageUrls As List(Of String)
    )

        Me.HbtkId = hbtkId
        Me.UserId = userId

        lbl_hbtk_User.Text = userName
        lbl_hbtk.Text = content

        ' ===== ユーザーアイコン =====
        If Usericon.Image IsNot Nothing Then
            Usericon.Image.Dispose()
            Usericon.Image = Nothing
        End If

        If String.IsNullOrEmpty(iconPath) Then
            Usericon.Visible = False
        Else
            Try
                Using img = Image.FromFile(iconPath)
                    Usericon.Image = New Bitmap(img)
                End Using
                Usericon.SizeMode = PictureBoxSizeMode.Zoom
                Usericon.Size = New Size(48, 48)
                Usericon.Visible = True
            Catch
                Usericon.Visible = False
            End Try
        End If

        ' ===== 投稿画像 =====
        Dim pics = New PictureBox() {PictureBox1, PictureBox2, PictureBox3, PictureBox4}

        For i As Integer = 0 To pics.Length - 1
            If pics(i).Image IsNot Nothing Then
                pics(i).Image.Dispose()
                pics(i).Image = Nothing
            End If

            If imageUrls IsNot Nothing AndAlso i < imageUrls.Count Then
                Try
                    Using img = Image.FromFile(imageUrls(i))
                        pics(i).Image = New Bitmap(img)
                    End Using
                    pics(i).SizeMode = PictureBoxSizeMode.Zoom
                    pics(i).Visible = True
                Catch
                    pics(i).Visible = False
                End Try
            Else
                pics(i).Visible = False
            End If
        Next

        ' ===== 自分の投稿はクリック不可 =====
        If Me.UserId = Session.CurrentUserId Then
            lbl_hbtk_User.Enabled = False
            lbl_hbtk_User.ForeColor = Color.Gray
        Else
            lbl_hbtk_User.Enabled = True
            lbl_hbtk_User.Cursor = Cursors.Hand
        End If

        ApplyLikeState()
    End Sub

    ' ===== ユーザー名クリック =====
    Private Sub lbl_hbtk_User_Click(sender As Object, e As EventArgs) _
        Handles lbl_hbtk_User.Click

        Dim frm As New Form3(Me.UserId)
        frm.Show()

    End Sub

    ' ===== コメントボタン =====
    Private Sub btn_comment_Click(sender As Object, e As EventArgs) _
        Handles btn_comment.Click

        RaiseEvent CommentRequested(Me.HbtkId)

    End Sub

    ' ===== いいね =====
    Private Sub btn_hbtk_like_Click(sender As Object, e As EventArgs) _
        Handles btn_hbtk_like.Click

        If Session.CurrentUserId = 0 Then Exit Sub

        If IsLikedByCurrentUser() Then
            RemoveLike()
        Else
            AddLike()
        End If

        ApplyLikeState()
    End Sub

    Private Sub ApplyLikeState()
        If IsLikedByCurrentUser() Then
            btn_hbtk_like.Text = "♥"
            btn_hbtk_like.BackColor = Color.Pink
        Else
            btn_hbtk_like.Text = "♡"
            btn_hbtk_like.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub AddLike()
        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")
            Using cmd As New MySqlCommand(
                "INSERT INTO likes (user_id, hbtk_id) VALUES (@u,@h)", conn)
                cmd.Parameters.AddWithValue("@u", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@h", Me.HbtkId)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub RemoveLike()
        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")
            Using cmd As New MySqlCommand(
                "DELETE FROM likes WHERE user_id=@u AND hbtk_id=@h", conn)
                cmd.Parameters.AddWithValue("@u", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@h", Me.HbtkId)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Function IsLikedByCurrentUser() As Boolean
        If Session.CurrentUserId = 0 Then Return False

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")
            Using cmd As New MySqlCommand(
                "SELECT 1 FROM likes WHERE user_id=@u AND hbtk_id=@h LIMIT 1", conn)
                cmd.Parameters.AddWithValue("@u", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@h", Me.HbtkId)
                conn.Open()
                Return cmd.ExecuteScalar() IsNot Nothing
            End Using
        End Using
    End Function
    Public Sub SetAsComment()

        lbl_hbtk_User.ForeColor = Color.Green
        Me.BackColor = Color.FromArgb(235, 255, 235)

    End Sub

End Class
