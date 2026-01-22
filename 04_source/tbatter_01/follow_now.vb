Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing
Imports System.IO

Public Class follow_now

    Private Sub follow_now_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Session.CurrentUserId = 0 Then
            MessageBox.Show("ログインしてください")
            Me.Close()
            Exit Sub
        End If

        follow_FlowLayout.FlowDirection = FlowDirection.TopDown
        follow_FlowLayout.WrapContents = False
        follow_FlowLayout.AutoScroll = True

        LoadFollowUsers()

    End Sub

    ' ===== フォロー中ユーザー一覧 =====
    Private Sub LoadFollowUsers()

        follow_FlowLayout.Controls.Clear()

        Dim sql As String =
            "SELECT u.user_id, u.user_name, u.icon_url " &
            "FROM follows f " &
            "INNER JOIN users u ON f.follower_id = u.user_id " &
            "WHERE f.user_id = @myId " &
            "ORDER BY u.user_name"

        Dim dt As New DataTable

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@myId", Session.CurrentUserId)

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        For Each row As DataRow In dt.Rows

            Dim ctl As New tbatter_user_Control()

            ctl.SetData(
                CInt(row("user_id")),
                "@" & row("user_name").ToString(),
                row("icon_url").ToString()
            )

            ctl.Width = follow_FlowLayout.ClientSize.Width - 20
            follow_FlowLayout.Controls.Add(ctl)

        Next

    End Sub

End Class
