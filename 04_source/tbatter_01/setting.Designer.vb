<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setting
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
        Me.btn_del_user = New System.Windows.Forms.Button()
        Me.lbl_del = New System.Windows.Forms.Label()
        Me.dgv_hbtk = New System.Windows.Forms.DataGridView()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.pic_hbtk = New System.Windows.Forms.PictureBox()
        Me.pic_setting = New System.Windows.Forms.PictureBox()
        Me.pic_account = New System.Windows.Forms.PictureBox()
        Me.pic_trend = New System.Windows.Forms.PictureBox()
        Me.pic_message = New System.Windows.Forms.PictureBox()
        Me.pic_sarch = New System.Windows.Forms.PictureBox()
        Me.pic_home = New System.Windows.Forms.PictureBox()
        Me.btn_setting = New System.Windows.Forms.Button()
        Me.btn_account = New System.Windows.Forms.Button()
        Me.btn_trend = New System.Windows.Forms.Button()
        Me.btn_messege = New System.Windows.Forms.Button()
        Me.btn_sarch = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.tbtr_icon = New System.Windows.Forms.PictureBox()
        CType(Me.dgv_hbtk, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btn_del_user
        '
        Me.btn_del_user.BackColor = System.Drawing.Color.Red
        Me.btn_del_user.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_del_user.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_del_user.Location = New System.Drawing.Point(273, 507)
        Me.btn_del_user.Name = "btn_del_user"
        Me.btn_del_user.Size = New System.Drawing.Size(171, 36)
        Me.btn_del_user.TabIndex = 0
        Me.btn_del_user.Text = "アカウント削除"
        Me.btn_del_user.UseVisualStyleBackColor = False
        '
        'lbl_del
        '
        Me.lbl_del.AutoSize = True
        Me.lbl_del.Font = New System.Drawing.Font("Meiryo UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_del.Location = New System.Drawing.Point(267, 9)
        Me.lbl_del.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_del.Name = "lbl_del"
        Me.lbl_del.Size = New System.Drawing.Size(162, 35)
        Me.lbl_del.TabIndex = 10
        Me.lbl_del.Text = "ユーザー設定"
        '
        'dgv_hbtk
        '
        Me.dgv_hbtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_hbtk.Location = New System.Drawing.Point(273, 47)
        Me.dgv_hbtk.Name = "dgv_hbtk"
        Me.dgv_hbtk.RowTemplate.Height = 21
        Me.dgv_hbtk.Size = New System.Drawing.Size(417, 454)
        Me.dgv_hbtk.TabIndex = 11
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.Red
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_del.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_del.Location = New System.Drawing.Point(445, 507)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(254, 36)
        Me.btn_del.TabIndex = 12
        Me.btn_del.Text = "選択したはばたきを削除する"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'pic_hbtk
        '
        Me.pic_hbtk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_hbtk.Image = Global.tbatter_01.My.Resources.Resources.hbtk
        Me.pic_hbtk.Location = New System.Drawing.Point(7, 455)
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
        Me.pic_setting.Location = New System.Drawing.Point(7, 267)
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
        Me.pic_account.Location = New System.Drawing.Point(7, 226)
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
        Me.pic_trend.Location = New System.Drawing.Point(7, 185)
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
        Me.pic_message.Location = New System.Drawing.Point(7, 144)
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
        Me.pic_sarch.Location = New System.Drawing.Point(7, 103)
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
        Me.pic_home.Location = New System.Drawing.Point(7, 63)
        Me.pic_home.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_home.Name = "pic_home"
        Me.pic_home.Size = New System.Drawing.Size(32, 34)
        Me.pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_home.TabIndex = 51
        Me.pic_home.TabStop = False
        '
        'btn_setting
        '
        Me.btn_setting.BackColor = System.Drawing.Color.White
        Me.btn_setting.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_setting.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_setting.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_setting.Location = New System.Drawing.Point(37, 267)
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
        Me.btn_account.Location = New System.Drawing.Point(37, 226)
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
        Me.btn_trend.Location = New System.Drawing.Point(34, 185)
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
        Me.btn_messege.ForeColor = System.Drawing.Color.Black
        Me.btn_messege.Location = New System.Drawing.Point(34, 144)
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
        Me.btn_sarch.Location = New System.Drawing.Point(34, 103)
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
        Me.btn_home.Location = New System.Drawing.Point(34, 63)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(167, 34)
        Me.btn_home.TabIndex = 45
        Me.btn_home.Text = "ホーム"
        Me.btn_home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_home.UseVisualStyleBackColor = False
        '
        'tbtr_icon
        '
        Me.tbtr_icon.Image = Global.tbatter_01.My.Resources.Resources.tbatter_icon_white
        Me.tbtr_icon.Location = New System.Drawing.Point(7, 7)
        Me.tbtr_icon.Margin = New System.Windows.Forms.Padding(2)
        Me.tbtr_icon.Name = "tbtr_icon"
        Me.tbtr_icon.Size = New System.Drawing.Size(45, 48)
        Me.tbtr_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tbtr_icon.TabIndex = 44
        Me.tbtr_icon.TabStop = False
        '
        'setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(702, 549)
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
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.dgv_hbtk)
        Me.Controls.Add(Me.lbl_del)
        Me.Controls.Add(Me.btn_del_user)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "setting"
        Me.Text = "tbatter_setting"
        CType(Me.dgv_hbtk, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents btn_del_user As Button
    Friend WithEvents lbl_del As Label
    Friend WithEvents dgv_hbtk As DataGridView
    Friend WithEvents btn_del As Button
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
End Class
