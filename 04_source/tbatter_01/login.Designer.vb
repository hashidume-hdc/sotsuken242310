<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.txt_loginPswd = New System.Windows.Forms.TextBox()
        Me.txt_loginID = New System.Windows.Forms.TextBox()
        Me.lbl_border = New System.Windows.Forms.Label()
        Me.btn_newuser = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.tbtr_icon = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.tbtr_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_loginPswd
        '
        Me.txt_loginPswd.Font = New System.Drawing.Font("Meiryo UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt_loginPswd.ForeColor = System.Drawing.Color.Silver
        Me.txt_loginPswd.Location = New System.Drawing.Point(200, 254)
        Me.txt_loginPswd.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_loginPswd.Name = "txt_loginPswd"
        Me.txt_loginPswd.Size = New System.Drawing.Size(267, 31)
        Me.txt_loginPswd.TabIndex = 13
        Me.txt_loginPswd.Text = "パスワードを入力"
        Me.txt_loginPswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_loginID
        '
        Me.txt_loginID.Font = New System.Drawing.Font("Meiryo UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt_loginID.ForeColor = System.Drawing.Color.Silver
        Me.txt_loginID.Location = New System.Drawing.Point(200, 198)
        Me.txt_loginID.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_loginID.Name = "txt_loginID"
        Me.txt_loginID.Size = New System.Drawing.Size(267, 31)
        Me.txt_loginID.TabIndex = 12
        Me.txt_loginID.Text = "ユーザーネームを入力"
        Me.txt_loginID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_border
        '
        Me.lbl_border.AutoSize = True
        Me.lbl_border.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_border.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl_border.Location = New System.Drawing.Point(148, 307)
        Me.lbl_border.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_border.Name = "lbl_border"
        Me.lbl_border.Size = New System.Drawing.Size(392, 18)
        Me.lbl_border.TabIndex = 11
        Me.lbl_border.Text = "ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー"
        '
        'btn_newuser
        '
        Me.btn_newuser.BackColor = System.Drawing.Color.White
        Me.btn_newuser.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_newuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_newuser.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_newuser.ForeColor = System.Drawing.Color.Black
        Me.btn_newuser.Location = New System.Drawing.Point(177, 389)
        Me.btn_newuser.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_newuser.Name = "btn_newuser"
        Me.btn_newuser.Size = New System.Drawing.Size(307, 34)
        Me.btn_newuser.TabIndex = 10
        Me.btn_newuser.Text = "NEW user"
        Me.btn_newuser.UseVisualStyleBackColor = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Black
        Me.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(177, 350)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(307, 34)
        Me.btn_login.TabIndex = 9
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Meiryo UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_login.Location = New System.Drawing.Point(203, 127)
        Me.lbl_login.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(273, 41)
        Me.lbl_login.TabIndex = 8
        Me.lbl_login.Text = "Tbatterにログイン"
        '
        'tbtr_icon
        '
        Me.tbtr_icon.Image = Global.tbatter_01.My.Resources.Resources.tbatter_icon_white
        Me.tbtr_icon.Location = New System.Drawing.Point(284, 14)
        Me.tbtr_icon.Margin = New System.Windows.Forms.Padding(2)
        Me.tbtr_icon.Name = "tbtr_icon"
        Me.tbtr_icon.Size = New System.Drawing.Size(98, 104)
        Me.tbtr_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tbtr_icon.TabIndex = 7
        Me.tbtr_icon.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(578, 416)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "管理者はこちらから"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 241)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "デバッグ用"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(702, 451)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_loginPswd)
        Me.Controls.Add(Me.txt_loginID)
        Me.Controls.Add(Me.lbl_border)
        Me.Controls.Add(Me.btn_newuser)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.tbtr_icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "login"
        Me.Text = "tbatter_login"
        CType(Me.tbtr_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_loginPswd As TextBox
    Friend WithEvents txt_loginID As TextBox
    Friend WithEvents lbl_border As Label
    Friend WithEvents btn_newuser As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_login As Label
    Friend WithEvents tbtr_icon As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
