<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrsetting_frm
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
        Me.lbl_me_setting = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.pic_Usricon = New System.Windows.Forms.PictureBox()
        Me.btn_appload = New System.Windows.Forms.Button()
        CType(Me.pic_Usricon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_me_setting
        '
        Me.lbl_me_setting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_me_setting.Font = New System.Drawing.Font("Meiryo UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_me_setting.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_me_setting.Location = New System.Drawing.Point(12, 149)
        Me.lbl_me_setting.Name = "lbl_me_setting"
        Me.lbl_me_setting.Size = New System.Drawing.Size(540, 165)
        Me.lbl_me_setting.TabIndex = 49
        Me.lbl_me_setting.Text = "自己紹介文"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "自己紹介文の編集"
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.White
        Me.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.Black
        Me.btn_ok.Location = New System.Drawing.Point(451, 317)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(101, 42)
        Me.btn_ok.TabIndex = 51
        Me.btn_ok.Text = "変更"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'pic_Usricon
        '
        Me.pic_Usricon.Image = Global.tbatter_01.My.Resources.Resources.unnamed
        Me.pic_Usricon.Location = New System.Drawing.Point(16, 22)
        Me.pic_Usricon.Name = "pic_Usricon"
        Me.pic_Usricon.Size = New System.Drawing.Size(80, 80)
        Me.pic_Usricon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Usricon.TabIndex = 52
        Me.pic_Usricon.TabStop = False
        '
        'btn_appload
        '
        Me.btn_appload.BackColor = System.Drawing.Color.White
        Me.btn_appload.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_appload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_appload.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_appload.ForeColor = System.Drawing.Color.Black
        Me.btn_appload.Location = New System.Drawing.Point(118, 42)
        Me.btn_appload.Name = "btn_appload"
        Me.btn_appload.Size = New System.Drawing.Size(123, 42)
        Me.btn_appload.TabIndex = 53
        Me.btn_appload.Text = "アップロード"
        Me.btn_appload.UseVisualStyleBackColor = False
        '
        'usrsetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(564, 367)
        Me.Controls.Add(Me.btn_appload)
        Me.Controls.Add(Me.pic_Usricon)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_me_setting)
        Me.Name = "usrsetting"
        Me.Text = "tbatter_user_setting"
        CType(Me.pic_Usricon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_me_setting As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ok As Button
    Friend WithEvents pic_Usricon As PictureBox
    Friend WithEvents btn_appload As Button
End Class
