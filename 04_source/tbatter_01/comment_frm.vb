Imports MySql.Data.MySqlClient
Imports System.Drawing

Public Class comment_frm

    Private ReadOnly _parentHbtkId As Integer
    Private imagePaths(3) As String

    Public Sub New(parentHbtkId As Integer)
        InitializeComponent()
        _parentHbtkId = parentHbtkId
    End Sub

    ' ===== 画像選択 =====
    Private Sub SetImage(index As Integer, pb As PictureBox)
        Using ofd As New OpenFileDialog()
            ofd.Filter = "画像ファイル|*.jpg;*.jpeg;*.png;*.gif"
            If ofd.ShowDialog() = DialogResult.OK Then
                pb.Image = Image.FromFile(ofd.FileName)
                pb.SizeMode = PictureBoxSizeMode.Zoom
                imagePaths(index) = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub btn_img1_Click(sender As Object, e As EventArgs) Handles btn_img1.Click
        SetImage(0, PictureBox1)
    End Sub
    Private Sub btn_img2_Click(sender As Object, e As EventArgs) Handles btn_img2.Click
        SetImage(1, PictureBox2)
    End Sub
    Private Sub btn_img3_Click(sender As Object, e As EventArgs) Handles btn_img3.Click
        SetImage(2, PictureBox3)
    End Sub
    Private Sub btn_img4_Click(sender As Object, e As EventArgs) Handles btn_img4.Click
        SetImage(3, PictureBox4)
    End Sub

    ' ===== コメント送信 =====
    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click

        If Session.CurrentUserId = 0 Then
            MessageBox.Show("ログインしてください")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txt_comment.Text) Then
            MessageBox.Show("コメントを入力してください")
            Exit Sub
        End If

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            conn.Open()
            Dim tran = conn.BeginTransaction()

            Try
                ' ① コメント本体を保存
                Dim cmd As New MySqlCommand(
                    "INSERT INTO hbtks " &
                    "(user_id, pare_hbtk_id, content, hbtk_time, delete_frag) " &
                    "VALUES (@uid, @parent, @content, NOW(), 0)",
                    conn, tran)

                cmd.Parameters.AddWithValue("@uid", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@parent", _parentHbtkId)
                cmd.Parameters.AddWithValue("@content", txt_comment.Text)
                cmd.ExecuteNonQuery()

                Dim commentHbtkId As Integer = CInt(cmd.LastInsertedId)

                ' ② 画像保存（あれば）
                For i As Integer = 0 To 3
                    If Not String.IsNullOrEmpty(imagePaths(i)) Then
                        Dim imgCmd As New MySqlCommand(
                            "INSERT INTO post_images " &
                            "(hbtk_id, sort_order, image_url) " &
                            "VALUES (@hid, @order, @url)",
                            conn, tran)

                        imgCmd.Parameters.AddWithValue("@hid", commentHbtkId)
                        imgCmd.Parameters.AddWithValue("@order", i + 1)
                        imgCmd.Parameters.AddWithValue("@url", imagePaths(i))
                        imgCmd.ExecuteNonQuery()
                    End If
                Next

                tran.Commit()

            Catch ex As Exception
                tran.Rollback()
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        End Using

        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub
    Private Sub btn_no_Click(sender As Object, e As EventArgs) Handles btn_no.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


End Class
