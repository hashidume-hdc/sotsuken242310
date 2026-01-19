Imports System.Drawing
Imports System.Windows.Forms

Public Class tbatter_hbtk_Control
    Inherits UserControl

    Public Property HbtkId As Integer
    Public Property UserId As Integer

    Public Sub New()
        InitializeComponent()
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub

    Public Sub SetData(
        hbtkId As Integer,
        userId As Integer,
        userName As String,
        content As String,
        iconPath As String,
        imageUrls As List(Of String)
    )

        Me.HbtkId = hbtkId
        Me.UserId = userId

        lbl_hbtk_User.Text = userName
        lbl_hbtk.Text = content

        ' ===== ユーザーアイコン（重要修正） =====
        If Usericon.Image IsNot Nothing Then
            Usericon.Image.Dispose()
            Usericon.Image = Nothing
        End If

        If String.IsNullOrEmpty(iconPath) Then
            Usericon.Visible = False
        Else
            Try
                Using img = Image.FromFile(iconPath)
                    Usericon.Image = New Bitmap(img)
                End Using
                Usericon.SizeMode = PictureBoxSizeMode.Zoom
                Usericon.Size = New Size(48, 48)
                Usericon.Visible = True
            Catch
                Usericon.Visible = False
            End Try
        End If

        ' ===== 投稿画像（最大4枚） =====
        Dim pics = New PictureBox() {PictureBox1, PictureBox2, PictureBox3, PictureBox4}

        For i As Integer = 0 To pics.Length - 1
            If pics(i).Image IsNot Nothing Then
                pics(i).Image.Dispose()
                pics(i).Image = Nothing
            End If

            If imageUrls IsNot Nothing AndAlso i < imageUrls.Count Then
                Try
                    Using img = Image.FromFile(imageUrls(i))
                        pics(i).Image = New Bitmap(img)
                    End Using
                    pics(i).SizeMode = PictureBoxSizeMode.Zoom
                    pics(i).Visible = True
                Catch
                    pics(i).Visible = False
                End Try
            Else
                pics(i).Visible = False
            End If
        Next

        With lbl_hbtk_User
            .AutoSize = True
            .TextAlign = ContentAlignment.MiddleLeft
            .Padding = New Padding(0)
            .Margin = New Padding(0)
            .BringToFront()
        End With

        Me.BackColor = Color.WhiteSmoke

    End Sub

    Private Sub lbl_hbtk_User_Click(sender As Object, e As EventArgs) Handles lbl_hbtk_User.Click
        Form3.Show()
    End Sub
End Class
