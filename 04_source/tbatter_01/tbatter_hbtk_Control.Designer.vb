<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tbatter_hbtk_Control
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_hbtk = New System.Windows.Forms.Label()
        Me.btn_hbtk_like = New System.Windows.Forms.Button()
        Me.lbl_hbtk_User = New System.Windows.Forms.Label()
        Me.Usericon = New System.Windows.Forms.PictureBox()
        Me.btn_comment = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Usericon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_hbtk
        '
        Me.lbl_hbtk.Location = New System.Drawing.Point(52, 33)
        Me.lbl_hbtk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_hbtk.Name = "lbl_hbtk"
        Me.lbl_hbtk.Size = New System.Drawing.Size(321, 53)
        Me.lbl_hbtk.TabIndex = 12
        Me.lbl_hbtk.Text = "ここに本文"
        '
        'btn_hbtk_like
        '
        Me.btn_hbtk_like.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_hbtk_like.ForeColor = System.Drawing.Color.Red
        Me.btn_hbtk_like.Location = New System.Drawing.Point(309, 184)
        Me.btn_hbtk_like.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hbtk_like.Name = "btn_hbtk_like"
        Me.btn_hbtk_like.Size = New System.Drawing.Size(74, 22)
        Me.btn_hbtk_like.TabIndex = 11
        Me.btn_hbtk_like.Text = "♥　いいね"
        Me.btn_hbtk_like.UseVisualStyleBackColor = True
        '
        'lbl_hbtk_User
        '
        Me.lbl_hbtk_User.AutoSize = True
        Me.lbl_hbtk_User.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hbtk_User.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_hbtk_User.Location = New System.Drawing.Point(51, 9)
        Me.lbl_hbtk_User.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_hbtk_User.Name = "lbl_hbtk_User"
        Me.lbl_hbtk_User.Size = New System.Drawing.Size(61, 15)
        Me.lbl_hbtk_User.TabIndex = 10
        Me.lbl_hbtk_User.Text = "ユーザー名"
        '
        'Usericon
        '
        Me.Usericon.Image = Global.tbatter_01.My.Resources.Resources.first_icon
        Me.Usericon.Location = New System.Drawing.Point(10, 9)
        Me.Usericon.Margin = New System.Windows.Forms.Padding(2)
        Me.Usericon.Name = "Usericon"
        Me.Usericon.Size = New System.Drawing.Size(38, 40)
        Me.Usericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Usericon.TabIndex = 9
        Me.Usericon.TabStop = False
        '
        'btn_comment
        '
        Me.btn_comment.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_comment.ForeColor = System.Drawing.Color.Gray
        Me.btn_comment.Location = New System.Drawing.Point(231, 184)
        Me.btn_comment.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_comment.Name = "btn_comment"
        Me.btn_comment.Size = New System.Drawing.Size(74, 22)
        Me.btn_comment.TabIndex = 13
        Me.btn_comment.Text = "コメント"
        Me.btn_comment.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(283, 89)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 62
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(192, 89)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 61
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(101, 89)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 60
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(10, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'tbatter_hbtk_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_comment)
        Me.Controls.Add(Me.lbl_hbtk)
        Me.Controls.Add(Me.btn_hbtk_like)
        Me.Controls.Add(Me.lbl_hbtk_User)
        Me.Controls.Add(Me.Usericon)
        Me.Name = "tbatter_hbtk_Control"
        Me.Size = New System.Drawing.Size(394, 213)
        CType(Me.Usericon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_hbtk As Label
    Friend WithEvents btn_hbtk_like As Button
    Friend WithEvents lbl_hbtk_User As Label
    Friend WithEvents Usericon As PictureBox
    Friend WithEvents btn_comment As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
