Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class tbatter_hbtk_Control
    Inherits UserControl

    Public Property HbtkId As Integer
    Public Property UserId As Integer

    Public Sub New()
        InitializeComponent()
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
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

        ' ===== 投稿画像（最大4枚） =====
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

        With lbl_hbtk_User
            .AutoSize = True
            .TextAlign = ContentAlignment.MiddleLeft
            .Padding = New Padding(0)
            .Margin = New Padding(0)
            .BringToFront()
        End With

        ' ===== 自分の投稿はクリック不可 =====
        If Me.UserId = Session.CurrentUserId Then
            lbl_hbtk_User.Enabled = False
            lbl_hbtk_User.Cursor = Cursors.Default
            lbl_hbtk_User.ForeColor = Color.Gray
        Else
            lbl_hbtk_User.Enabled = True
            lbl_hbtk_User.Cursor = Cursors.Hand
        End If

        ' ===== いいね状態を反映 =====
        ApplyLikeState()

        Me.BackColor = Color.WhiteSmoke

    End Sub

    ' ===== ユーザー名クリック（他人のみ） =====
    Private Sub lbl_hbtk_User_Click(sender As Object, e As EventArgs) _
        Handles lbl_hbtk_User.Click

        Dim frm As New Form3(Me.UserId)
        frm.Show()

    End Sub

    ' ===== いいねボタン（トグル） =====
    Private Sub btn_hbtk_like_Click(sender As Object, e As EventArgs) _
        Handles btn_hbtk_like.Click

        If Session.CurrentUserId = 0 Then
            MessageBox.Show("ログインしてください",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If

        If IsLikedByCurrentUser() Then
            RemoveLike()
        Else
            AddLike()
        End If

        ApplyLikeState()

    End Sub

    ' ===== いいね状態UI反映 =====
    Private Sub ApplyLikeState()

        If IsLikedByCurrentUser() Then
            btn_hbtk_like.Text = "♥"
            btn_hbtk_like.BackColor = Color.Pink
        Else
            btn_hbtk_like.Text = "♡"
            btn_hbtk_like.BackColor = SystemColors.Control
        End If

    End Sub

    ' ===== いいね追加 =====
    Private Sub AddLike()

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(
                "INSERT INTO likes (user_id, hbtk_id) VALUES (@uid, @hid)", conn)

                cmd.Parameters.AddWithValue("@uid", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@hid", Me.HbtkId)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    ' ===== いいね解除 =====
    Private Sub RemoveLike()

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(
                "DELETE FROM likes WHERE user_id=@uid AND hbtk_id=@hid", conn)

                cmd.Parameters.AddWithValue("@uid", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@hid", Me.HbtkId)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

    End Sub

    ' ===== いいね済み判定 =====
    Private Function IsLikedByCurrentUser() As Boolean

        If Session.CurrentUserId = 0 Then Return False

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(
                "SELECT 1 FROM likes WHERE user_id=@uid AND hbtk_id=@hid LIMIT 1", conn)

                cmd.Parameters.AddWithValue("@uid", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@hid", Me.HbtkId)

                conn.Open()
                Return cmd.ExecuteScalar() IsNot Nothing
            End Using
        End Using

    End Function

End Class
