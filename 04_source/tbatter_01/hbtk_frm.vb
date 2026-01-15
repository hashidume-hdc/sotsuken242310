' hbtk_frm.vb
Imports MySql.Data.MySqlClient

Public Class hbtk_frm

    Private imagePaths(3) As String

    Private Sub hbtk_frm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ログインチェック（必須）
        If Session.CurrentUserId = 0 Then
            MessageBox.Show("ログインしてください",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Me.Close()
        End If
    End Sub


    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        If String.IsNullOrWhiteSpace(txt_hbtk.Text) Then
            MessageBox.Show("本文を入力してください",
                            "エラー",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            conn.Open()
            Dim tran = conn.BeginTransaction()

            Try
                ' ① 投稿本文を保存
                Dim cmd As New MySqlCommand()
                cmd.Connection = conn
                cmd.Transaction = tran

                cmd.CommandText =
                    "INSERT INTO hbtks (user_id, pare_hbtk_id, content) " &
                    "VALUES (@user_id, @pare_hbtk_id, @content)"

                cmd.Parameters.AddWithValue("@user_id", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@pare_hbtk_id", 0)
                cmd.Parameters.AddWithValue("@content", txt_hbtk.Text)

                cmd.ExecuteNonQuery()

                ' ② 追加された hbtk_id を取得
                Dim hbtkId As Integer = CInt(cmd.LastInsertedId)

                ' ③ 画像があれば保存
                For i As Integer = 0 To 3
                    If Not String.IsNullOrEmpty(imagePaths(i)) Then
                        Dim imgCmd As New MySqlCommand()
                        imgCmd.Connection = conn
                        imgCmd.Transaction = tran

                        imgCmd.CommandText =
                            "INSERT INTO post_images (hbtk_id, sort_order, image_url) " &
                            "VALUES (@hbtk_id, @sort_order, @image_url)"

                        imgCmd.Parameters.AddWithValue("@hbtk_id", hbtkId)
                        imgCmd.Parameters.AddWithValue("@sort_order", i + 1)
                        imgCmd.Parameters.AddWithValue("@image_url", imagePaths(i))

                        imgCmd.ExecuteNonQuery()
                    End If
                Next

                tran.Commit()

                MessageBox.Show("投稿が完了しました",
                                "成功",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information)

                Me.Close()

            Catch ex As Exception
                tran.Rollback()
                MessageBox.Show(ex.Message,
                                "エラー",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


    Private Sub btn_up_Click(sender As Object, e As EventArgs) Handles btn_up.Click
        SetImage(0, PictureBox1)
    End Sub

    Private Sub btn_up2_Click(sender As Object, e As EventArgs) Handles btn_up2.Click
        SetImage(1, PictureBox2)
    End Sub

    Private Sub btn_up3_Click(sender As Object, e As EventArgs) Handles btn_up3.Click
        SetImage(2, PictureBox3)
    End Sub

    Private Sub btn_up4_Click(sender As Object, e As EventArgs) Handles btn_up4.Click
        SetImage(3, PictureBox4)
    End Sub


    Private Sub SetImage(index As Integer, pb As PictureBox)
        Using ofd As New OpenFileDialog()
            ofd.Filter = "画像ファイル|*.jpg;*.png;*.jpeg;*.gif"
            If ofd.ShowDialog() = DialogResult.OK Then
                pb.Image = Image.FromFile(ofd.FileName)
                pb.SizeMode = PictureBoxSizeMode.Zoom
                imagePaths(index) = ofd.FileName
            End If
        End Using
    End Sub

End Class
