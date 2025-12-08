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
        CType(Me.dgv_hbtk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_del_user
        '
        Me.btn_del_user.BackColor = System.Drawing.Color.Red
        Me.btn_del_user.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_del_user.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_del_user.Location = New System.Drawing.Point(17, 373)
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
        Me.lbl_del.Location = New System.Drawing.Point(11, 9)
        Me.lbl_del.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_del.Name = "lbl_del"
        Me.lbl_del.Size = New System.Drawing.Size(162, 35)
        Me.lbl_del.TabIndex = 10
        Me.lbl_del.Text = "ユーザー設定"
        '
        'dgv_hbtk
        '
        Me.dgv_hbtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_hbtk.Location = New System.Drawing.Point(12, 47)
        Me.dgv_hbtk.Name = "dgv_hbtk"
        Me.dgv_hbtk.RowTemplate.Height = 21
        Me.dgv_hbtk.Size = New System.Drawing.Size(678, 320)
        Me.dgv_hbtk.TabIndex = 11
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.Red
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_del.Font = New System.Drawing.Font("Meiryo UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_del.Location = New System.Drawing.Point(436, 373)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(254, 36)
        Me.btn_del.TabIndex = 12
        Me.btn_del.Text = "選択したはばたきを削除する"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'setting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(702, 421)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.dgv_hbtk)
        Me.Controls.Add(Me.lbl_del)
        Me.Controls.Add(Me.btn_del_user)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "setting"
        Me.Text = "tbatter_setting"
        CType(Me.dgv_hbtk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_del_user As Button
    Friend WithEvents lbl_del As Label
    Friend WithEvents dgv_hbtk As DataGridView
    Friend WithEvents btn_del As Button
End Class
