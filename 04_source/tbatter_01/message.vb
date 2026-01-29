Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing

Public Class s

    Private currentRoomId As Integer = 0
    Private currentTargetUserId As Integer = 0

    ' ===== Load =====
    Private Sub s_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupUserGrid()
        LoadUsers()
    End Sub

    ' ===== DGV初期化 =====
    Private Sub SetupUserGrid()
        dgv_usr.AutoGenerateColumns = False
        dgv_usr.Columns.Clear()

        Dim colRadio As New DataGridViewCheckBoxColumn()
        colRadio.Name = "col_radio"
        colRadio.Width = 30
        dgv_usr.Columns.Add(colRadio)

        Dim colName As New DataGridViewTextBoxColumn()
        colName.Name = "col_name"
        colName.HeaderText = "ユーザー名"
        colName.Width = 160
        dgv_usr.Columns.Add(colName)

        Dim colId As New DataGridViewTextBoxColumn()
        colId.Name = "col_id"
        colId.Visible = False
        dgv_usr.Columns.Add(colId)
    End Sub

    ' ===== ユーザー表示 =====
    Private Sub LoadUsers(Optional keyword As String = "")
        dgv_usr.Rows.Clear()

        Dim sql As String =
            "SELECT user_id, user_name " &
            "FROM users WHERE delete_frag=0 AND user_id<>@me "

        If keyword <> "" Then
            sql &= "AND user_name LIKE @key "
        End If

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@me", Session.CurrentUserId)
                If keyword <> "" Then
                    cmd.Parameters.AddWithValue("@key", "%" & keyword & "%")
                End If

                conn.Open()
                Using rdr = cmd.ExecuteReader()
                    While rdr.Read()
                        dgv_usr.Rows.Add(False,
                                         rdr("user_name").ToString(),
                                         CInt(rdr("user_id")))
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' ===== 検索 =====
    Private Sub btn_usr_Click(sender As Object, e As EventArgs) Handles btn_usr.Click
        LoadUsers(txt_usr.Text.Trim())
    End Sub

    ' ===== ユーザー選択 =====
    Private Sub dgv_usr_CellContentClick(
        sender As Object,
        e As DataGridViewCellEventArgs) Handles dgv_usr.CellContentClick

        If e.RowIndex < 0 OrElse e.ColumnIndex <> 0 Then Exit Sub

        For Each row As DataGridViewRow In dgv_usr.Rows
            row.Cells("col_radio").Value = False
        Next

        dgv_usr.Rows(e.RowIndex).Cells("col_radio").Value = True

        currentTargetUserId =
            CInt(dgv_usr.Rows(e.RowIndex).Cells("col_id").Value)

        currentRoomId = GetOrCreateRoom(currentTargetUserId)
        LoadMessages()
    End Sub

    ' ===== DMルーム取得 or 作成 =====
    Private Function GetOrCreateRoom(targetUserId As Integer) As Integer

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")
            conn.Open()

            Using cmd As New MySqlCommand(
                "SELECT room_id FROM dm_rooms " &
                "WHERE (user1_id=@me AND user2_id=@you) " &
                "OR (user1_id=@you AND user2_id=@me)", conn)

                cmd.Parameters.AddWithValue("@me", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@you", targetUserId)

                Dim r = cmd.ExecuteScalar()
                If r IsNot Nothing Then Return CInt(r)
            End Using

            Using cmd As New MySqlCommand(
                "INSERT INTO dm_rooms(user1_id,user2_id) VALUES(@me,@you);
                 SELECT LAST_INSERT_ID();", conn)

                cmd.Parameters.AddWithValue("@me", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@you", targetUserId)

                Return CInt(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    ' ===== メッセージ表示 =====
    Private Sub LoadMessages()
        msg_FlowLayout.Controls.Clear()

        Dim sql As String =
            "SELECT m.content, u.user_name, u.icon_url " &
            "FROM dm_messages m " &
            "JOIN users u ON m.sender_id=u.user_id " &
            "WHERE m.room_id=@rid ORDER BY m.send_time ASC"

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@rid", currentRoomId)
                conn.Open()

                Using rdr = cmd.ExecuteReader()
                    While rdr.Read()
                        AddMessageControl(
                            rdr("user_name").ToString(),
                            rdr("icon_url").ToString(),
                            rdr("content").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' ===== メッセージControl =====
    Private Sub AddMessageControl(userName As String,
                                  iconPath As String,
                                  content As String)

        Dim ctl As New tbatter_msg_Control()
        ctl.lbl_hbtk_User.Text = "@" & userName
        ctl.lbl_hbtk.Text = content

        If File.Exists(iconPath) Then
            Using img = Image.FromFile(iconPath)
                ctl.Usericon.Image = New Bitmap(img)
            End Using
            ctl.Usericon.SizeMode = PictureBoxSizeMode.Zoom
        End If

        ctl.Width = msg_FlowLayout.ClientSize.Width - 10
        msg_FlowLayout.Controls.Add(ctl)
    End Sub

    ' ===== 送信 =====
    Private Sub btn_msg_Click(sender As Object, e As EventArgs) Handles btn_msg.Click
        If txt_msg.Text.Trim() = "" OrElse currentRoomId = 0 Then Exit Sub

        Using conn As New MySqlConnection(
            "Database=sotuken242310;Data Source=localhost;User Id=root")
            Using cmd As New MySqlCommand(
                "INSERT INTO dm_messages(room_id,sender_id,content,send_time)
                 VALUES(@rid,@sid,@msg,NOW())", conn)

                cmd.Parameters.AddWithValue("@rid", currentRoomId)
                cmd.Parameters.AddWithValue("@sid", Session.CurrentUserId)
                cmd.Parameters.AddWithValue("@msg", txt_msg.Text.Trim())

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        txt_msg.Clear()
        LoadMessages()
    End Sub

End Class
