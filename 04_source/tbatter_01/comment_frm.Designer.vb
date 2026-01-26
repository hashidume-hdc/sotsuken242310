<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comment_frm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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
        Me.txt_comment = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_img4 = New System.Windows.Forms.Button()
        Me.btn_img3 = New System.Windows.Forms.Button()
        Me.btn_img2 = New System.Windows.Forms.Button()
        Me.btn_img1 = New System.Windows.Forms.Button()
        Me.btn_no = New System.Windows.Forms.Button()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_comment
        '
        Me.txt_comment.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txt_comment.Location = New System.Drawing.Point(12, 37)
        Me.txt_comment.Multiline = True
        Me.txt_comment.Name = "txt_comment"
        Me.txt_comment.Size = New System.Drawing.Size(412, 141)
        Me.txt_comment.TabIndex = 70
        Me.txt_comment.Text = "本文"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(300, 189)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 69
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(211, 189)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 68
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(123, 189)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(34, 189)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(90, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'btn_send
        '
        Me.btn_send.BackColor = System.Drawing.Color.White
        Me.btn_send.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_send.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_send.ForeColor = System.Drawing.Color.Black
        Me.btn_send.Location = New System.Drawing.Point(343, 327)
        Me.btn_send.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(76, 34)
        Me.btn_send.TabIndex = 65
        Me.btn_send.Text = "コメント"
        Me.btn_send.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "コメントしよう"
        '
        'btn_img4
        '
        Me.btn_img4.Location = New System.Drawing.Point(311, 285)
        Me.btn_img4.Name = "btn_img4"
        Me.btn_img4.Size = New System.Drawing.Size(75, 23)
        Me.btn_img4.TabIndex = 74
        Me.btn_img4.Text = "アップロード"
        Me.btn_img4.UseVisualStyleBackColor = True
        '
        'btn_img3
        '
        Me.btn_img3.Location = New System.Drawing.Point(221, 285)
        Me.btn_img3.Name = "btn_img3"
        Me.btn_img3.Size = New System.Drawing.Size(75, 23)
        Me.btn_img3.TabIndex = 73
        Me.btn_img3.Text = "アップロード"
        Me.btn_img3.UseVisualStyleBackColor = True
        '
        'btn_img2
        '
        Me.btn_img2.Location = New System.Drawing.Point(129, 285)
        Me.btn_img2.Name = "btn_img2"
        Me.btn_img2.Size = New System.Drawing.Size(75, 23)
        Me.btn_img2.TabIndex = 72
        Me.btn_img2.Text = "アップロード"
        Me.btn_img2.UseVisualStyleBackColor = True
        '
        'btn_img1
        '
        Me.btn_img1.Location = New System.Drawing.Point(39, 285)
        Me.btn_img1.Name = "btn_img1"
        Me.btn_img1.Size = New System.Drawing.Size(75, 23)
        Me.btn_img1.TabIndex = 71
        Me.btn_img1.Text = "アップロード"
        Me.btn_img1.UseVisualStyleBackColor = True
        '
        'btn_no
        '
        Me.btn_no.BackColor = System.Drawing.Color.White
        Me.btn_no.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_no.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_no.ForeColor = System.Drawing.Color.Black
        Me.btn_no.Location = New System.Drawing.Point(221, 327)
        Me.btn_no.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_no.Name = "btn_no"
        Me.btn_no.Size = New System.Drawing.Size(118, 34)
        Me.btn_no.TabIndex = 75
        Me.btn_no.Text = "キャンセル"
        Me.btn_no.UseVisualStyleBackColor = False
        '
        'comment_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(441, 377)
        Me.Controls.Add(Me.btn_no)
        Me.Controls.Add(Me.btn_img4)
        Me.Controls.Add(Me.btn_img3)
        Me.Controls.Add(Me.btn_img2)
        Me.Controls.Add(Me.btn_img1)
        Me.Controls.Add(Me.txt_comment)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.Label1)
        Me.Name = "comment_frm"
        Me.Text = "tbatter_comment_frm"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_comment As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_send As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_img4 As Button
    Friend WithEvents btn_img3 As Button
    Friend WithEvents btn_img2 As Button
    Friend WithEvents btn_img1 As Button
    Friend WithEvents btn_no As Button
End Class
