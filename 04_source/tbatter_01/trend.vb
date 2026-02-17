Imports MySql.Data.MySqlClient
Imports System.Data

Public Class trend

    Private Sub trend_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load

        LoadTrend()

    End Sub

    Private Sub LoadTrend()

        Dim dt As New DataTable

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Dim sql As String =
                "SELECT h.hbtk_id, h.content, u.user_name, " &
                "COUNT(DISTINCT l.hbtk_id) AS like_count, " &
                "COUNT(DISTINCT c.hbtk_id) AS comment_count, " &
                "(COUNT(DISTINCT l.hbtk_id) + COUNT(DISTINCT c.hbtk_id) * 2) AS score " &
                "FROM hbtks h " &
                "LEFT JOIN users u ON h.user_id = u.user_id " &
                "LEFT JOIN likes l ON h.hbtk_id = l.hbtk_id " &
                "LEFT JOIN hbtks c ON c.pare_hbtk_id = h.hbtk_id AND c.delete_frag = 0 " &
                "WHERE h.pare_hbtk_id = 0 " &
                "AND h.delete_frag = 0 " &
                "GROUP BY h.hbtk_id " &
                "ORDER BY score DESC " &
                "LIMIT 20"

            Using cmd As New MySqlCommand(sql, conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

        End Using

        dgv_trend.DataSource = dt

        ' 表示列名を日本語に変更
        dgv_trend.Columns("hbtk_id").HeaderText = "投稿ID"
        dgv_trend.Columns("user_name").HeaderText = "ユーザー"
        dgv_trend.Columns("content").HeaderText = "内容"
        dgv_trend.Columns("like_count").HeaderText = "いいね"
        dgv_trend.Columns("comment_count").HeaderText = "返信数"
        dgv_trend.Columns("score").HeaderText = "トレンドスコア"

        dgv_trend.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub btn_sarch_Click(sender As Object, e As EventArgs) Handles btn_sarch.Click
        sarch.Show()
        Me.Hide()
    End Sub

    Private Sub btn_messege_Click(sender As Object, e As EventArgs) Handles btn_messege.Click
        s.Show()
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

    Private Sub pic_hbtk_Click(sender As Object, e As EventArgs) Handles pic_hbtk.Click
        hbtk_frm.Show()
    End Sub
End Class
