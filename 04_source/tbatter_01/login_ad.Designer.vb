<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_ad
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
        Me.btn_login = New System.Windows.Forms.Button()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_loginPswd
        '
        Me.txt_loginPswd.Font = New System.Drawing.Font("Meiryo UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt_loginPswd.ForeColor = System.Drawing.Color.Silver
        Me.txt_loginPswd.Location = New System.Drawing.Point(95, 143)
        Me.txt_loginPswd.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_loginPswd.Name = "txt_loginPswd"
        Me.txt_loginPswd.Size = New System.Drawing.Size(267, 31)
        Me.txt_loginPswd.TabIndex = 25
        Me.txt_loginPswd.Text = "パスワードを入力"
        Me.txt_loginPswd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_loginID
        '
        Me.txt_loginID.Font = New System.Drawing.Font("Meiryo UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt_loginID.ForeColor = System.Drawing.Color.Silver
        Me.txt_loginID.Location = New System.Drawing.Point(95, 87)
        Me.txt_loginID.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_loginID.Name = "txt_loginID"
        Me.txt_loginID.Size = New System.Drawing.Size(267, 31)
        Me.txt_loginID.TabIndex = 24
        Me.txt_loginID.Text = "ユーザーネームを入力"
        Me.txt_loginID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_border
        '
        Me.lbl_border.AutoSize = True
        Me.lbl_border.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_border.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lbl_border.Location = New System.Drawing.Point(43, 196)
        Me.lbl_border.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_border.Name = "lbl_border"
        Me.lbl_border.Size = New System.Drawing.Size(392, 18)
        Me.lbl_border.TabIndex = 23
        Me.lbl_border.Text = "ーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーー"
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Black
        Me.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(72, 239)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(307, 34)
        Me.btn_login.TabIndex = 22
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Meiryo UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_login.Location = New System.Drawing.Point(118, 19)
        Me.lbl_login.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(218, 41)
        Me.lbl_login.TabIndex = 21
        Me.lbl_login.Text = "管理者ログイン"
        '
        'login_ad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(461, 309)
        Me.Controls.Add(Me.txt_loginPswd)
        Me.Controls.Add(Me.txt_loginID)
        Me.Controls.Add(Me.lbl_border)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.lbl_login)
        Me.Name = "login_ad"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_loginPswd As TextBox
    Friend WithEvents txt_loginID As TextBox
    Friend WithEvents lbl_border As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_login As Label
End Class
