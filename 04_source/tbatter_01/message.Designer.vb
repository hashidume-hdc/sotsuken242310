<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class s
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
        Me.btn_setting = New System.Windows.Forms.Button()
        Me.btn_account = New System.Windows.Forms.Button()
        Me.btn_trend = New System.Windows.Forms.Button()
        Me.btn_messege = New System.Windows.Forms.Button()
        Me.btn_sarch = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.msg_FlowLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_msg = New System.Windows.Forms.TextBox()
        Me.btn_msg = New System.Windows.Forms.Button()
        Me.pic_hbtk = New System.Windows.Forms.PictureBox()
        Me.pic_setting = New System.Windows.Forms.PictureBox()
        Me.pic_account = New System.Windows.Forms.PictureBox()
        Me.pic_trend = New System.Windows.Forms.PictureBox()
        Me.pic_message = New System.Windows.Forms.PictureBox()
        Me.pic_sarch = New System.Windows.Forms.PictureBox()
        Me.pic_home = New System.Windows.Forms.PictureBox()
        Me.tbtr_icon = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.pic_hbtk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_setting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_account, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_trend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_message, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_sarch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbtr_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_setting
        '
        Me.btn_setting.BackColor = System.Drawing.Color.White
        Me.btn_setting.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setting.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_setting.ForeColor = System.Drawing.Color.Black
        Me.btn_setting.Location = New System.Drawing.Point(38, 267)
        Me.btn_setting.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_setting.Name = "btn_setting"
        Me.btn_setting.Size = New System.Drawing.Size(167, 34)
        Me.btn_setting.TabIndex = 50
        Me.btn_setting.Text = "設定"
        Me.btn_setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_setting.UseVisualStyleBackColor = False
        '
        'btn_account
        '
        Me.btn_account.BackColor = System.Drawing.Color.White
        Me.btn_account.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_account.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_account.ForeColor = System.Drawing.Color.Black
        Me.btn_account.Location = New System.Drawing.Point(38, 226)
        Me.btn_account.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_account.Name = "btn_account"
        Me.btn_account.Size = New System.Drawing.Size(167, 34)
        Me.btn_account.TabIndex = 49
        Me.btn_account.Text = "プロフィール"
        Me.btn_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_account.UseVisualStyleBackColor = False
        '
        'btn_trend
        '
        Me.btn_trend.BackColor = System.Drawing.Color.White
        Me.btn_trend.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_trend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_trend.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_trend.ForeColor = System.Drawing.Color.Black
        Me.btn_trend.Location = New System.Drawing.Point(35, 185)
        Me.btn_trend.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_trend.Name = "btn_trend"
        Me.btn_trend.Size = New System.Drawing.Size(167, 34)
        Me.btn_trend.TabIndex = 48
        Me.btn_trend.Text = "トレンド"
        Me.btn_trend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_trend.UseVisualStyleBackColor = False
        '
        'btn_messege
        '
        Me.btn_messege.BackColor = System.Drawing.Color.White
        Me.btn_messege.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_messege.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_messege.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_messege.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_messege.Location = New System.Drawing.Point(35, 144)
        Me.btn_messege.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_messege.Name = "btn_messege"
        Me.btn_messege.Size = New System.Drawing.Size(167, 34)
        Me.btn_messege.TabIndex = 47
        Me.btn_messege.Text = "メッセージ"
        Me.btn_messege.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_messege.UseVisualStyleBackColor = False
        '
        'btn_sarch
        '
        Me.btn_sarch.BackColor = System.Drawing.Color.White
        Me.btn_sarch.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_sarch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sarch.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_sarch.ForeColor = System.Drawing.Color.Black
        Me.btn_sarch.Location = New System.Drawing.Point(35, 103)
        Me.btn_sarch.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_sarch.Name = "btn_sarch"
        Me.btn_sarch.Size = New System.Drawing.Size(167, 34)
        Me.btn_sarch.TabIndex = 46
        Me.btn_sarch.Text = "検索"
        Me.btn_sarch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_sarch.UseVisualStyleBackColor = False
        '
        'btn_home
        '
        Me.btn_home.BackColor = System.Drawing.Color.White
        Me.btn_home.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_home.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_home.ForeColor = System.Drawing.Color.Black
        Me.btn_home.Location = New System.Drawing.Point(35, 63)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(167, 34)
        Me.btn_home.TabIndex = 45
        Me.btn_home.Text = "ホーム"
        Me.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'msg_FlowLayout
        '
        Me.msg_FlowLayout.BackColor = System.Drawing.Color.White
        Me.msg_FlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.msg_FlowLayout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.msg_FlowLayout.Location = New System.Drawing.Point(232, 45)
        Me.msg_FlowLayout.Margin = New System.Windows.Forms.Padding(2)
        Me.msg_FlowLayout.Name = "msg_FlowLayout"
        Me.msg_FlowLayout.Size = New System.Drawing.Size(376, 459)
        Me.msg_FlowLayout.TabIndex = 58
        '
        'txt_msg
        '
        Me.txt_msg.Font = New System.Drawing.Font("Meiryo UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt_msg.ForeColor = System.Drawing.Color.Silver
        Me.txt_msg.Location = New System.Drawing.Point(232, 512)
        Me.txt_msg.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_msg.Name = "txt_msg"
        Me.txt_msg.Size = New System.Drawing.Size(322, 31)
        Me.txt_msg.TabIndex = 59
        Me.txt_msg.Text = "メッセージ"
        '
        'btn_msg
        '
        Me.btn_msg.BackColor = System.Drawing.Color.Black
        Me.btn_msg.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_msg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_msg.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_msg.ForeColor = System.Drawing.Color.White
        Me.btn_msg.Location = New System.Drawing.Point(558, 512)
        Me.btn_msg.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_msg.Name = "btn_msg"
        Me.btn_msg.Size = New System.Drawing.Size(50, 34)
        Me.btn_msg.TabIndex = 60
        Me.btn_msg.Text = "送信"
        Me.btn_msg.UseVisualStyleBackColor = False
        '
        'pic_hbtk
        '
        Me.pic_hbtk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_hbtk.Image = Global.tbatter_01.My.Resources.Resources.hbtk
        Me.pic_hbtk.Location = New System.Drawing.Point(8, 455)
        Me.pic_hbtk.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_hbtk.Name = "pic_hbtk"
        Me.pic_hbtk.Size = New System.Drawing.Size(82, 88)
        Me.pic_hbtk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_hbtk.TabIndex = 57
        Me.pic_hbtk.TabStop = False
        '
        'pic_setting
        '
        Me.pic_setting.Image = Global.tbatter_01.My.Resources.Resources.setting_02
        Me.pic_setting.Location = New System.Drawing.Point(8, 267)
        Me.pic_setting.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_setting.Name = "pic_setting"
        Me.pic_setting.Size = New System.Drawing.Size(32, 34)
        Me.pic_setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_setting.TabIndex = 56
        Me.pic_setting.TabStop = False
        '
        'pic_account
        '
        Me.pic_account.Image = Global.tbatter_01.My.Resources.Resources.unnamed
        Me.pic_account.Location = New System.Drawing.Point(8, 226)
        Me.pic_account.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_account.Name = "pic_account"
        Me.pic_account.Size = New System.Drawing.Size(32, 34)
        Me.pic_account.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_account.TabIndex = 55
        Me.pic_account.TabStop = False
        '
        'pic_trend
        '
        Me.pic_trend.Image = Global.tbatter_01.My.Resources.Resources.trend_03
        Me.pic_trend.Location = New System.Drawing.Point(8, 185)
        Me.pic_trend.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_trend.Name = "pic_trend"
        Me.pic_trend.Size = New System.Drawing.Size(32, 34)
        Me.pic_trend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_trend.TabIndex = 54
        Me.pic_trend.TabStop = False
        '
        'pic_message
        '
        Me.pic_message.Image = Global.tbatter_01.My.Resources.Resources.message_031
        Me.pic_message.Location = New System.Drawing.Point(8, 144)
        Me.pic_message.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_message.Name = "pic_message"
        Me.pic_message.Size = New System.Drawing.Size(32, 34)
        Me.pic_message.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_message.TabIndex = 53
        Me.pic_message.TabStop = False
        '
        'pic_sarch
        '
        Me.pic_sarch.Image = Global.tbatter_01.My.Resources.Resources.sarch
        Me.pic_sarch.Location = New System.Drawing.Point(8, 103)
        Me.pic_sarch.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_sarch.Name = "pic_sarch"
        Me.pic_sarch.Size = New System.Drawing.Size(32, 34)
        Me.pic_sarch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_sarch.TabIndex = 52
        Me.pic_sarch.TabStop = False
        '
        'pic_home
        '
        Me.pic_home.Image = Global.tbatter_01.My.Resources.Resources.home
        Me.pic_home.Location = New System.Drawing.Point(8, 63)
        Me.pic_home.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_home.Name = "pic_home"
        Me.pic_home.Size = New System.Drawing.Size(32, 34)
        Me.pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_home.TabIndex = 51
        Me.pic_home.TabStop = False
        '
        'tbtr_icon
        '
        Me.tbtr_icon.Image = Global.tbatter_01.My.Resources.Resources.tbatter_icon_white
        Me.tbtr_icon.Location = New System.Drawing.Point(8, 7)
        Me.tbtr_icon.Margin = New System.Windows.Forms.Padding(2)
        Me.tbtr_icon.Name = "tbtr_icon"
        Me.tbtr_icon.Size = New System.Drawing.Size(45, 48)
        Me.tbtr_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tbtr_icon.TabIndex = 44
        Me.tbtr_icon.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(558, 7)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 34)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "検索"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Meiryo UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.Silver
        Me.TextBox1.Location = New System.Drawing.Point(232, 7)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(322, 31)
        Me.TextBox1.TabIndex = 61
        Me.TextBox1.Text = "ユーザ名"
        '
        's
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(619, 554)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_msg)
        Me.Controls.Add(Me.txt_msg)
        Me.Controls.Add(Me.msg_FlowLayout)
        Me.Controls.Add(Me.pic_hbtk)
        Me.Controls.Add(Me.pic_setting)
        Me.Controls.Add(Me.pic_account)
        Me.Controls.Add(Me.pic_trend)
        Me.Controls.Add(Me.pic_message)
        Me.Controls.Add(Me.pic_sarch)
        Me.Controls.Add(Me.pic_home)
        Me.Controls.Add(Me.btn_setting)
        Me.Controls.Add(Me.btn_account)
        Me.Controls.Add(Me.btn_trend)
        Me.Controls.Add(Me.btn_messege)
        Me.Controls.Add(Me.btn_sarch)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.tbtr_icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "s"
        Me.Text = "tbatter_message"
        CType(Me.pic_hbtk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_setting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_account, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_trend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_message, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_sarch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbtr_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pic_hbtk As PictureBox
    Friend WithEvents pic_setting As PictureBox
    Friend WithEvents pic_account As PictureBox
    Friend WithEvents pic_trend As PictureBox
    Friend WithEvents pic_message As PictureBox
    Friend WithEvents pic_sarch As PictureBox
    Friend WithEvents pic_home As PictureBox
    Friend WithEvents btn_setting As Button
    Friend WithEvents btn_account As Button
    Friend WithEvents btn_trend As Button
    Friend WithEvents btn_messege As Button
    Friend WithEvents btn_sarch As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents tbtr_icon As PictureBox
    Friend WithEvents msg_FlowLayout As FlowLayoutPanel
    Friend WithEvents txt_msg As TextBox
    Friend WithEvents btn_msg As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
