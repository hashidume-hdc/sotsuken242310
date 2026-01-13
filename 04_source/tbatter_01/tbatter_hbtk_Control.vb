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

        ' ユーザーアイコン
        If String.IsNullOrEmpty(iconPath) Then
            Usericon.Visible = False
        Else
            Try
                Usericon.Image = Image.FromFile(iconPath)
                Usericon.SizeMode = PictureBoxSizeMode.Zoom
                Usericon.Visible = True
            Catch
                Usericon.Visible = False
            End Try
        End If

        ' 投稿画像（最大4枚）
        Dim pics = New PictureBox() {PictureBox1, PictureBox2, PictureBox3, PictureBox4}

        For i As Integer = 0 To pics.Length - 1
            If imageUrls IsNot Nothing AndAlso i < imageUrls.Count Then
                Try
                    pics(i).Image = Image.FromFile(imageUrls(i))
                    pics(i).SizeMode = PictureBoxSizeMode.Zoom
                    pics(i).Visible = True
                Catch
                    pics(i).Visible = False
                End Try
            Else
                pics(i).Visible = False
            End If
        Next

    End Sub

End Class
