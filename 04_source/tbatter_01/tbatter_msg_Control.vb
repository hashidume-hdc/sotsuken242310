Imports System.Drawing

Public Class tbatter_msg_Control
    Inherits UserControl

    Public Sub SetData(
        userName As String,
        content As String,
        iconPath As String,
        isMe As Boolean)

        ' ===== テキスト =====
        lbl_hbtk_User.Text = userName
        lbl_hbtk.Text = content

        ' ===== アイコン =====
        If IO.File.Exists(iconPath) Then
            If Usericon.Image IsNot Nothing Then
                Usericon.Image.Dispose()
            End If
            Using img = Image.FromFile(iconPath)
                Usericon.Image = New Bitmap(img)
            End Using
            Usericon.SizeMode = PictureBoxSizeMode.Zoom
            Usericon.Visible = True
        Else
            Usericon.Visible = False
        End If

        ' ===== 自分 / 相手 判定 =====
        If isMe Then
            ' ===== 自分（右寄せ） =====
            Me.BackColor = Color.FromArgb(230, 255, 230)

            ' 位置
            Usericon.Left = Me.Width - Usericon.Width - 10
            lbl_hbtk_User.Left = Usericon.Left - lbl_hbtk_User.Width - 5
            lbl_hbtk.Left = lbl_hbtk_User.Left

            ' 揃え
            lbl_hbtk_User.TextAlign = ContentAlignment.MiddleRight
            lbl_hbtk.TextAlign = ContentAlignment.MiddleRight

        Else
            ' ===== 相手（左寄せ） =====
            Me.BackColor = Color.WhiteSmoke

            Usericon.Left = 10
            lbl_hbtk_User.Left = Usericon.Right + 5
            lbl_hbtk.Left = lbl_hbtk_User.Left

            lbl_hbtk_User.TextAlign = ContentAlignment.MiddleLeft
            lbl_hbtk.TextAlign = ContentAlignment.MiddleLeft
        End If

        ' ===== 高さ自動調整 =====
        lbl_hbtk.MaximumSize = New Size(250, 0)
        lbl_hbtk.AutoSize = True

        Me.Height = lbl_hbtk.Bottom + 10
    End Sub
End Class
