<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home_ad
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_hbtk_del = New System.Windows.Forms.Button()
        Me.btn_usr_del = New System.Windows.Forms.Button()
        Me.dgv_hbtk = New System.Windows.Forms.DataGridView()
        Me.txt_usr_sarch = New System.Windows.Forms.TextBox()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.dgv_usr = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_hbtk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_usr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(805, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "その他の設定"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("MS UI Gothic", 13.0!)
        Me.Button5.Location = New System.Drawing.Point(805, 280)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(256, 44)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "新規管理者ユーザーを作成する"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(805, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "はばたき関連"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(801, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "アカウント関連"
        '
        'btn_hbtk_del
        '
        Me.btn_hbtk_del.Font = New System.Drawing.Font("MS UI Gothic", 13.0!)
        Me.btn_hbtk_del.Location = New System.Drawing.Point(805, 176)
        Me.btn_hbtk_del.Name = "btn_hbtk_del"
        Me.btn_hbtk_del.Size = New System.Drawing.Size(256, 44)
        Me.btn_hbtk_del.TabIndex = 17
        Me.btn_hbtk_del.Text = "選択しているはばたきを削除する" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_hbtk_del.UseVisualStyleBackColor = True
        '
        'btn_usr_del
        '
        Me.btn_usr_del.Font = New System.Drawing.Font("MS UI Gothic", 13.0!)
        Me.btn_usr_del.Location = New System.Drawing.Point(805, 78)
        Me.btn_usr_del.Name = "btn_usr_del"
        Me.btn_usr_del.Size = New System.Drawing.Size(256, 38)
        Me.btn_usr_del.TabIndex = 16
        Me.btn_usr_del.Text = "選択しているアカウントを削除する" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_usr_del.UseVisualStyleBackColor = True
        '
        'dgv_hbtk
        '
        Me.dgv_hbtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_hbtk.Location = New System.Drawing.Point(505, 37)
        Me.dgv_hbtk.Name = "dgv_hbtk"
        Me.dgv_hbtk.RowTemplate.Height = 21
        Me.dgv_hbtk.Size = New System.Drawing.Size(289, 537)
        Me.dgv_hbtk.TabIndex = 14
        '
        'txt_usr_sarch
        '
        Me.txt_usr_sarch.Location = New System.Drawing.Point(9, 12)
        Me.txt_usr_sarch.Name = "txt_usr_sarch"
        Me.txt_usr_sarch.Size = New System.Drawing.Size(541, 19)
        Me.txt_usr_sarch.TabIndex = 13
        Me.txt_usr_sarch.Text = "アカウント名を入力"
        '
        'btn_send
        '
        Me.btn_send.Location = New System.Drawing.Point(556, 12)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(75, 23)
        Me.btn_send.TabIndex = 12
        Me.btn_send.Text = "検索"
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'dgv_usr
        '
        Me.dgv_usr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usr.Location = New System.Drawing.Point(12, 37)
        Me.dgv_usr.Name = "dgv_usr"
        Me.dgv_usr.RowTemplate.Height = 21
        Me.dgv_usr.Size = New System.Drawing.Size(487, 537)
        Me.dgv_usr.TabIndex = 11
        '
        'home_ad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1074, 590)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_hbtk_del)
        Me.Controls.Add(Me.btn_usr_del)
        Me.Controls.Add(Me.dgv_hbtk)
        Me.Controls.Add(Me.txt_usr_sarch)
        Me.Controls.Add(Me.btn_send)
        Me.Controls.Add(Me.dgv_usr)
        Me.Name = "home_ad"
        Me.Text = "Form5"
        CType(Me.dgv_hbtk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_usr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_hbtk_del As Button
    Friend WithEvents dgv_hbtk As DataGridView
    Friend WithEvents txt_usr_sarch As TextBox
    Friend WithEvents btn_send As Button
    Friend WithEvents dgv_usr As DataGridView
    Friend WithEvents btn_usr_del As Button
End Class
