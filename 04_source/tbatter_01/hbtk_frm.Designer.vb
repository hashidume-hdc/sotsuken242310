<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hbtk_frm
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
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_me_setting = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.White
        Me.btn_ok.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.Black
        Me.btn_ok.Location = New System.Drawing.Point(451, 213)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(101, 42)
        Me.btn_ok.TabIndex = 54
        Me.btn_ok.Text = "はばたく"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "はばたこう"
        '
        'lbl_me_setting
        '
        Me.lbl_me_setting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_me_setting.Font = New System.Drawing.Font("Meiryo UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_me_setting.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_me_setting.Location = New System.Drawing.Point(12, 45)
        Me.lbl_me_setting.Name = "lbl_me_setting"
        Me.lbl_me_setting.Size = New System.Drawing.Size(540, 165)
        Me.lbl_me_setting.TabIndex = 52
        Me.lbl_me_setting.Text = "本文"
        '
        'hbtk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(563, 267)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_me_setting)
        Me.Name = "hbtk"
        Me.Text = "tbatter_hbtk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ok As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_me_setting As Label
End Class
