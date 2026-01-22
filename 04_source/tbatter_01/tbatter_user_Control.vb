Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms

Public Class tbatter_user_Control
    Inherits UserControl

    Public Property UserId As Integer

    Public Sub New()
        InitializeComponent()
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub

    Public Sub SetData(
        userId As Integer,
        userName As String,
        iconPath As String
    )

        Me.UserId = userId
        lbl_hbtk_User.Text = userName

        ' ===== ユーザーアイコン =====
        If Usericon.Image IsNot Nothing Then
            Usericon.Image.Dispose()
            Usericon.Image = Nothing
        End If

        If Not String.IsNullOrEmpty(iconPath) AndAlso File.Exists(iconPath) Then
            Using img = Image.FromFile(iconPath)
                Usericon.Image = New Bitmap(img)
            End Using
            Usericon.SizeMode = PictureBoxSizeMode.Zoom
            Usericon.Visible = True
        Else
            Usericon.Visible = False
        End If

        ' ===== クリック見た目 =====
        If Me.UserId = Session.CurrentUserId Then
            lbl_hbtk_User.Enabled = False
            lbl_hbtk_User.Cursor = Cursors.Default
        Else
            lbl_hbtk_User.Enabled = True
            lbl_hbtk_User.Cursor = Cursors.Hand
        End If

    End Sub

    ' ===== ユーザーネームクリック =====
    Private Sub lbl_hbtk_User_Click(sender As Object, e As EventArgs) _
        Handles lbl_hbtk_User.Click

        If Me.UserId = Session.CurrentUserId Then Exit Sub

        Dim frm As New Form3(Me.UserId)
        frm.Show()

    End Sub

End Class
