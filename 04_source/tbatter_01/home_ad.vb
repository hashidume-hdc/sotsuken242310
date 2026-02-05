Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing

Public Class home_ad

    ' ===== フォームロード =====
    Private Sub home_ad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupUserGrid()
        SetupHbtkGrid()
        LoadUsers("")
    End Sub

    ' ===== DGV設定 =====
    Private Sub SetupUserGrid()

        dgv_usr.Columns.Clear()
        dgv_usr.AutoGenerateColumns = False

        Dim colRadio As New DataGridViewCheckBoxColumn()
        colRadio.Width = 30
        dgv_usr.Columns.Add(colRadio)

        dgv_usr.Columns.Add("user_id", "ユーザーID")
        dgv_usr.Columns.Add("user_name", "ユーザーネーム")
        dgv_usr.Columns.Add("password", "パスワード")
        dgv_usr.Columns.Add("bio", "bio")

    End Sub

    Private Sub SetupHbtkGrid()

        dgv_hbtk.Columns.Clear()
        dgv_hbtk.AutoGenerateColumns = False

        Dim colChk As New DataGridViewCheckBoxColumn()
        colChk.Width = 30
        dgv_hbtk.Columns.Add(colChk)

        dgv_hbtk.Columns.Add("content", "投稿内容")
        dgv_hbtk.Columns.Add("hbtk_time", "投稿日時")

    End Sub

    ' ===== ユーザー一覧 =====
    Private Sub LoadUsers(keyword As String)

        dgv_usr.Rows.Clear()
        dgv_hbtk.Rows.Clear()

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(
                "SELECT user_id, user_name, password, bio, delete_frag " &
                "FROM users WHERE user_name LIKE @kw", conn)

                cmd.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                conn.Open()

                Using rdr = cmd.ExecuteReader()
                    While rdr.Read()

                        Dim idx = dgv_usr.Rows.Add(
                            False,
                            rdr("user_id"),
                            rdr("user_name"),
                            rdr("password"),
                            rdr("bio")
                        )

                        If CInt(rdr("delete_frag")) = 1 Then
                            dgv_usr.Rows(idx).DefaultCellStyle.ForeColor = Color.Red
                        End If

                    End While
                End Using
            End Using
        End Using

    End Sub

    ' ===== ユーザー選択 =====
    Private Sub dgv_usr_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgv_usr.CellClick

        If e.RowIndex < 0 OrElse e.ColumnIndex <> 0 Then Exit Sub

        For Each row As DataGridViewRow In dgv_usr.Rows
            row.Cells(0).Value = False
        Next

        dgv_usr.Rows(e.RowIndex).Cells(0).Value = True

        ReloadSelectedUserPosts()

    End Sub

    ' ===== 投稿再ロード（重要）=====
    Private Sub ReloadSelectedUserPosts()

        dgv_hbtk.Rows.Clear()

        Dim userId As Integer = -1

        For Each row As DataGridViewRow In dgv_usr.Rows
            If CBool(row.Cells(0).Value) Then
                userId = CInt(row.Cells("user_id").Value)
                Exit For
            End If
        Next

        If userId = -1 Then Exit Sub

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(
                "SELECT content, hbtk_time FROM hbtks " &
                "WHERE user_id=@uid AND pare_hbtk_id=0 AND delete_frag=0",
                conn)

                cmd.Parameters.AddWithValue("@uid", userId)
                conn.Open()

                Using rdr = cmd.ExecuteReader()
                    While rdr.Read()
                        dgv_hbtk.Rows.Add(
                            False,
                            rdr("content"),
                            CDate(rdr("hbtk_time")).ToString("yyyy/MM/dd HH:mm")
                        )
                    End While
                End Using
            End Using
        End Using

    End Sub

    ' ===== ユーザー検索 =====
    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click
        LoadUsers(txt_usr_sarch.Text.Trim())
    End Sub

    ' ===== ユーザー削除 =====
    Private Sub btn_usr_del_Click(sender As Object, e As EventArgs) Handles btn_usr_del.Click

        Dim userId As Integer = -1

        For Each row As DataGridViewRow In dgv_usr.Rows
            If CBool(row.Cells(0).Value) Then
                userId = CInt(row.Cells("user_id").Value)
                Exit For
            End If
        Next

        If userId = -1 Then Exit Sub

        If MessageBox.Show("本当に削除しますか？", "確認",
                           MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            conn.Open()
            Dim tran = conn.BeginTransaction()

            Try
                Using cmdUser As New MySqlCommand(
                    "UPDATE users SET delete_frag=1 WHERE user_id=@id", conn, tran)

                    cmdUser.Parameters.AddWithValue("@id", userId)
                    cmdUser.ExecuteNonQuery()
                End Using

                Using cmdHbtk As New MySqlCommand(
                    "UPDATE hbtks SET delete_frag=1 WHERE user_id=@id", conn, tran)

                    cmdHbtk.Parameters.AddWithValue("@id", userId)
                    cmdHbtk.ExecuteNonQuery()
                End Using


                tran.Commit()
            Catch
                tran.Rollback()
            End Try
        End Using

        LoadUsers(txt_usr_sarch.Text.Trim())

    End Sub

    ' ===== 投稿削除 =====
    Private Sub btn_hbtk_del_Click(sender As Object, e As EventArgs) Handles btn_hbtk_del.Click

        Dim content As String = Nothing

        For Each row As DataGridViewRow In dgv_hbtk.Rows
            If CBool(row.Cells(0).Value) Then
                content = row.Cells("content").Value.ToString()
                Exit For
            End If
        Next

        If content Is Nothing Then Exit Sub

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            conn.Open()
            Dim tran = conn.BeginTransaction()

            Try
                Dim cmd As New MySqlCommand(
                    "UPDATE hbtks SET delete_frag=1 WHERE content=@c",
                    conn, tran)

                cmd.Parameters.AddWithValue("@c", content)
                cmd.ExecuteNonQuery()

                tran.Commit()
            Catch
                tran.Rollback()
            End Try
        End Using

        ReloadSelectedUserPosts()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        newUser_ad.Show()
    End Sub
End Class
