<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newUser
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
        Me.lbl_newUsr = New System.Windows.Forms.Label()
        Me.txt_newloginPswd = New System.Windows.Forms.TextBox()
        Me.txt_newloginID = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.pic_back = New System.Windows.Forms.PictureBox()
        Me.tbtr_icon = New System.Windows.Forms.PictureBox()
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbtr_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_newUsr
        '
        Me.lbl_newUsr.AutoSize = True
        Me.lbl_newUsr.Font = New System.Drawing.Font("Meiryo UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_newUsr.Location = New System.Drawing.Point(63, 86)
        Me.lbl_newUsr.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_newUsr.Name = "lbl_newUsr"
        Me.lbl_newUsr.Size = New System.Drawing.Size(198, 35)
        Me.lbl_newUsr.TabIndex = 9
        Me.lbl_newUsr.Text = "アカウントを作成"
        '
        'txt_newloginPswd
        '
        Me.txt_newloginPswd.Font = New System.Drawing.Font("Meiryo UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt_newloginPswd.ForeColor = System.Drawing.Color.Silver
        Me.txt_newloginPswd.Location = New System.Drawing.Point(69, 205)
        Me.txt_newloginPswd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_newloginPswd.Name = "txt_newloginPswd"
        Me.txt_newloginPswd.Size = New System.Drawing.Size(376, 31)
        Me.txt_newloginPswd.TabIndex = 15
        Me.txt_newloginPswd.Text = "パスワードを入力"
        '
        'txt_newloginID
        '
        Me.txt_newloginID.Font = New System.Drawing.Font("Meiryo UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt_newloginID.ForeColor = System.Drawing.Color.Silver
        Me.txt_newloginID.Location = New System.Drawing.Point(69, 149)
        Me.txt_newloginID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_newloginID.Name = "txt_newloginID"
        Me.txt_newloginID.Size = New System.Drawing.Size(376, 31)
        Me.txt_newloginID.TabIndex = 14
        Me.txt_newloginID.Text = "ユーザーネームを入力"
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Black
        Me.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(105, 264)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(307, 34)
        Me.btn_login.TabIndex = 16
        Me.btn_login.Text = "Create"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'pic_back
        '
        Me.pic_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_back.Image = Global.tbatter_01.My.Resources.Resources.back
        Me.pic_back.Location = New System.Drawing.Point(9, 10)
        Me.pic_back.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pic_back.Name = "pic_back"
        Me.pic_back.Size = New System.Drawing.Size(45, 48)
        Me.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_back.TabIndex = 17
        Me.pic_back.TabStop = False
        '
        'tbtr_icon
        '
        Me.tbtr_icon.Image = Global.tbatter_01.My.Resources.Resources.tbatter_icon_white
        Me.tbtr_icon.Location = New System.Drawing.Point(226, 2)
        Me.tbtr_icon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbtr_icon.Name = "tbtr_icon"
        Me.tbtr_icon.Size = New System.Drawing.Size(60, 64)
        Me.tbtr_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tbtr_icon.TabIndex = 8
        Me.tbtr_icon.TabStop = False
        '
        'newUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(517, 324)
        Me.Controls.Add(Me.pic_back)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_newloginPswd)
        Me.Controls.Add(Me.txt_newloginID)
        Me.Controls.Add(Me.lbl_newUsr)
        Me.Controls.Add(Me.tbtr_icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "newUser"
        Me.Text = "tbatter_newUser"
        CType(Me.pic_back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbtr_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbtr_icon As PictureBox
    Friend WithEvents lbl_newUsr As Label
    Friend WithEvents txt_newloginPswd As TextBox
    Friend WithEvents txt_newloginID As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents pic_back As PictureBox
End Class
