Imports MySql.Data.MySqlClient
Imports System.Data

Public Class setting

    Private Sub setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupGrid()
        LoadMyHbtk()
    End Sub
    Private Sub SetupGrid()

        dgv_hbtk.Columns.Clear()
        dgv_hbtk.Rows.Clear()
        dgv_hbtk.AutoGenerateColumns = False
        dgv_hbtk.AllowUserToAddRows = False
        dgv_hbtk.AllowUserToDeleteRows = False
        dgv_hbtk.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv_hbtk.MultiSelect = False

        Dim chkCol As New DataGridViewCheckBoxColumn()
        chkCol.HeaderText = ""
        chkCol.Width = 40
        chkCol.ReadOnly = False
        dgv_hbtk.Columns.Add(chkCol)

        Dim timeCol As New DataGridViewTextBoxColumn()
        timeCol.HeaderText = "日時"
        timeCol.Width = 150
        timeCol.ReadOnly = True
        dgv_hbtk.Columns.Add(timeCol)

        Dim contentCol As New DataGridViewTextBoxColumn()
        contentCol.HeaderText = "内容"
        contentCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        contentCol.ReadOnly = True
        dgv_hbtk.Columns.Add(contentCol)

        Dim idCol As New DataGridViewTextBoxColumn()
        idCol.HeaderText = "hbtk_id"
        idCol.Visible = False
        dgv_hbtk.Columns.Add(idCol)

    End Sub

    Private Sub LoadMyHbtk()

        dgv_hbtk.Rows.Clear()

        Dim sql As String =
            "SELECT hbtk_id, hbtk_time, content " &
            "FROM hbtks " &
            "WHERE user_id = @uid AND delete_frag = 0 " &
            "ORDER BY hbtk_time DESC"

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@uid", Session.CurrentUserId)
                conn.Open()

                Using rdr = cmd.ExecuteReader()
                    While rdr.Read()
                        dgv_hbtk.Rows.Add(
                            False,
                            CDate(rdr("hbtk_time")).ToString("yyyy/MM/dd HH:mm"),
                            rdr("content").ToString(),
                            CInt(rdr("hbtk_id"))
                        )
                    End While
                End Using
            End Using
        End Using

    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) _
    Handles btn_del.Click

        Dim targets As New List(Of Integer)

        For Each row As DataGridViewRow In dgv_hbtk.Rows
            If CBool(row.Cells(0).Value) Then
                targets.Add(CInt(row.Cells(3).Value)) ' hbtk_id
            End If
        Next

        If targets.Count = 0 Then
            MessageBox.Show("削除する投稿を選択してください")
            Exit Sub
        End If

        If MessageBox.Show(
            "選択した投稿とそのコメントを削除します。よろしいですか？",
            "確認",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Exit Sub
        End If

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            conn.Open()
            Using tran = conn.BeginTransaction()

                Try
                    For Each id In targets

                        Using cmd As New MySqlCommand(
                            "UPDATE hbtks SET delete_frag = 1 WHERE hbtk_id = @id",
                            conn, tran)

                            cmd.Parameters.AddWithValue("@id", id)
                            cmd.ExecuteNonQuery()
                        End Using

                        Using cmd As New MySqlCommand(
                            "UPDATE hbtks SET delete_frag = 1 WHERE pare_hbtk_id = @id",
                            conn, tran)

                            cmd.Parameters.AddWithValue("@id", id)
                            cmd.ExecuteNonQuery()
                        End Using

                    Next

                    tran.Commit()

                Catch ex As Exception
                    tran.Rollback()
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try
            End Using
        End Using

        LoadMyHbtk()

    End Sub

    Private Sub btn_del_user_Click(sender As Object, e As EventArgs) _
    Handles btn_del_user.Click

        If MessageBox.Show(
            "アカウントを削除すると投稿・コメントもすべて消えます。" & vbCrLf &
            "本当によろしいですか？",
            "確認",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning) <> DialogResult.Yes Then
            Exit Sub
        End If

        If MessageBox.Show(
            "この操作は取り消せません。" & vbCrLf &
            "最終確認です。アカウントを削除しますか？",
            "最終確認",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Stop) <> DialogResult.Yes Then
            Exit Sub
        End If

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            conn.Open()
            Using tran = conn.BeginTransaction()

                Try
                    ' ① ユーザー論理削除
                    Using cmd As New MySqlCommand(
                        "UPDATE users SET delete_frag = 1 WHERE user_id = @uid",
                        conn, tran)

                        cmd.Parameters.AddWithValue("@uid", Session.CurrentUserId)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' ② 自分の投稿を論理削除
                    Using cmd As New MySqlCommand(
                        "UPDATE hbtks SET delete_frag = 1 WHERE user_id = @uid",
                        conn, tran)

                        cmd.Parameters.AddWithValue("@uid", Session.CurrentUserId)
                        cmd.ExecuteNonQuery()
                    End Using

                    ' ③ 自分の投稿へのコメントも論理削除
                    Using cmd As New MySqlCommand(
                        "UPDATE hbtks SET delete_frag = 1 " &
                        "WHERE pare_hbtk_id IN (" &
                        "SELECT hbtk_id FROM hbtks WHERE user_id = @uid)",
                        conn, tran)

                        cmd.Parameters.AddWithValue("@uid", Session.CurrentUserId)
                        cmd.ExecuteNonQuery()
                    End Using

                    tran.Commit()

                Catch ex As Exception
                    tran.Rollback()
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try
            End Using
        End Using

        ' セッション破棄
        Session.CurrentUserId = 0

        MessageBox.Show("アカウントを削除しました")

        ' 全フォームを閉じてログイン画面へ
        For Each f As Form In Application.OpenForms.Cast(Of Form).ToList()
            f.Hide()
        Next

        login.Show()

    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        home.Show()
        Me.Hide()
    End Sub

    Private Sub btn_sarch_Click(sender As Object, e As EventArgs) Handles btn_sarch.Click
        sarch.Show()
        Me.Show()
    End Sub

    Private Sub btn_trend_Click(sender As Object, e As EventArgs) Handles btn_trend.Click
        trend.Show()
        Me.Show()
    End Sub

    Private Sub btn_account_Click(sender As Object, e As EventArgs) Handles btn_account.Click
        User_mine.Show()
        Me.Hide()
    End Sub

    Private Sub pic_hbtk_Click(sender As Object, e As EventArgs) Handles pic_hbtk.Click
        hbtk_frm.Show()
    End Sub

    Private Sub btn_messege_Click(sender As Object, e As EventArgs) Handles btn_messege.Click
        s.Show()
        Me.Hide()
    End Sub
End Class
