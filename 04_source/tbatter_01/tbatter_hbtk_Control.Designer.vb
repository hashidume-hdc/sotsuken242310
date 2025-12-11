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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btn_hbtk_koment = New System.Windows.Forms.Button()
        CType(Me.Usericon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_hbtk
        '
        Me.lbl_hbtk.AutoSize = True
        Me.lbl_hbtk.Location = New System.Drawing.Point(49, 32)
        Me.lbl_hbtk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_hbtk.Name = "lbl_hbtk"
        Me.lbl_hbtk.Size = New System.Drawing.Size(54, 12)
        Me.lbl_hbtk.TabIndex = 8
        Me.lbl_hbtk.Text = "ここに本文"
        '
        'btn_hbtk_like
        '
        Me.btn_hbtk_like.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_hbtk_like.ForeColor = System.Drawing.Color.Red
        Me.btn_hbtk_like.Location = New System.Drawing.Point(325, 227)
        Me.btn_hbtk_like.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_hbtk_like.Name = "btn_hbtk_like"
        Me.btn_hbtk_like.Size = New System.Drawing.Size(74, 22)
        Me.btn_hbtk_like.TabIndex = 7
        Me.btn_hbtk_like.Text = "♥　いいね"
        Me.btn_hbtk_like.UseVisualStyleBackColor = True
        '
        'lbl_hbtk_User
        '
        Me.lbl_hbtk_User.AutoSize = True
        Me.lbl_hbtk_User.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hbtk_User.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_hbtk_User.Location = New System.Drawing.Point(48, 8)
        Me.lbl_hbtk_User.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_hbtk_User.Name = "lbl_hbtk_User"
        Me.lbl_hbtk_User.Size = New System.Drawing.Size(61, 15)
        Me.lbl_hbtk_User.TabIndex = 6
        Me.lbl_hbtk_User.Text = "ユーザー名"
        '
        'Usericon
        '
        Me.Usericon.Image = Global.tbatter_01.My.Resources.Resources.first_icon
        Me.Usericon.Location = New System.Drawing.Point(7, 8)
        Me.Usericon.Margin = New System.Windows.Forms.Padding(2)
        Me.Usericon.Name = "Usericon"
        Me.Usericon.Size = New System.Drawing.Size(38, 40)
        Me.Usericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Usericon.TabIndex = 5
        Me.Usericon.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(18, 130)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(200, 130)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(109, 130)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(291, 130)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'btn_hbtk_koment
        '
        Me.btn_hbtk_koment.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_hbtk_koment.ForeColor = System.Drawing.Color.Gray
        Me.btn_hbtk_koment.Location = New System.Drawing.Point(243, 227)
        Me.btn_hbtk_koment.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_hbtk_koment.Name = "btn_hbtk_koment"
        Me.btn_hbtk_koment.Size = New System.Drawing.Size(74, 22)
        Me.btn_hbtk_koment.TabIndex = 13
        Me.btn_hbtk_koment.Text = "コメント"
        Me.btn_hbtk_koment.UseVisualStyleBackColor = True
        '
        'tbatter_hbtk_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_hbtk_koment)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_hbtk)
        Me.Controls.Add(Me.btn_hbtk_like)
        Me.Controls.Add(Me.lbl_hbtk_User)
        Me.Controls.Add(Me.Usericon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "tbatter_hbtk_Control"
        Me.Size = New System.Drawing.Size(405, 254)
        CType(Me.Usericon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_hbtk As Label
    Friend WithEvents btn_hbtk_like As Button
    Friend WithEvents lbl_hbtk_User As Label
    Friend WithEvents Usericon As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btn_hbtk_koment As Button
End Class
