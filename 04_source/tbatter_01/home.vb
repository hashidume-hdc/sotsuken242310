Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class home

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hbtk_FlowLayout.FlowDirection = FlowDirection.TopDown
        hbtk_FlowLayout.WrapContents = False
        hbtk_FlowLayout.AutoScroll = True

        LoadTimeline()

    End Sub

    Private Sub LoadTimeline()

        hbtk_FlowLayout.Controls.Clear()

        Dim sql As String =
    "SELECT h.hbtk_id, h.user_id, h.content, u.user_name, u.icon_url " &
    "FROM hbtks h " &
    "LEFT JOIN users u ON h.user_id = u.user_id " &
    "WHERE h.pare_hbtk_id = 0 AND h.delete_frag = 0 " &
    "ORDER BY h.hbtk_time DESC"

        Dim dt As New DataTable

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
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

    Private Function GetPostImages(hbtkId As Integer) As List(Of String)

        Dim list As New List(Of String)

        Dim sql As String =
            "SELECT image_url FROM post_images " &
            "WHERE hbtk_id = @hbtkId " &
            "ORDER BY sort_order"

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@hbtkId", hbtkId)
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

    Private Sub pic_hbtk_Click(sender As Object, e As EventArgs) Handles pic_hbtk.Click
        hbtk_frm.Show()
    End Sub

    Private Sub tbtr_icon_Click(sender As Object, e As EventArgs) Handles tbtr_icon.Click
        LoadTimeline()
    End Sub

    Private Sub btn_account_Click(sender As Object, e As EventArgs) Handles btn_account.Click
        Me.Hide()
        User_mine.Show()
    End Sub

    Private Sub btn_sarch_Click(sender As Object, e As EventArgs) Handles btn_sarch.Click
        Me.Hide()
        sarch.Show()
    End Sub

    Private Sub btn_messege_Click(sender As Object, e As EventArgs) Handles btn_messege.Click
        Me.Hide()
    End Sub
End Class
