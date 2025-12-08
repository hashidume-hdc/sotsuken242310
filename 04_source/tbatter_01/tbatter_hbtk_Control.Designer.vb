<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tbatter_hbtk_Control
    Inherits System.Windows.Forms.UserControl

    'UserControl はコンポーネント一覧をクリーンアップするために dispose をオーバーライドします。
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
        Me.lbl_hbtk = New System.Windows.Forms.Label()
        Me.btn_hbtk_like = New System.Windows.Forms.Button()
        Me.lbl_hbtk_User = New System.Windows.Forms.Label()
        Me.Usericon = New System.Windows.Forms.PictureBox()
        CType(Me.Usericon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_hbtk
        '
        Me.lbl_hbtk.AutoSize = True
        Me.lbl_hbtk.Location = New System.Drawing.Point(65, 40)
        Me.lbl_hbtk.Name = "lbl_hbtk"
        Me.lbl_hbtk.Size = New System.Drawing.Size(69, 15)
        Me.lbl_hbtk.TabIndex = 8
        Me.lbl_hbtk.Text = "ここに本文"
        '
        'btn_hbtk_like
        '
        Me.btn_hbtk_like.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_hbtk_like.ForeColor = System.Drawing.Color.Red
        Me.btn_hbtk_like.Location = New System.Drawing.Point(240, 123)
        Me.btn_hbtk_like.Name = "btn_hbtk_like"
        Me.btn_hbtk_like.Size = New System.Drawing.Size(99, 27)
        Me.btn_hbtk_like.TabIndex = 7
        Me.btn_hbtk_like.Text = "♥　いいね"
        Me.btn_hbtk_like.UseVisualStyleBackColor = True
        '
        'lbl_hbtk_User
        '
        Me.lbl_hbtk_User.AutoSize = True
        Me.lbl_hbtk_User.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hbtk_User.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_hbtk_User.Location = New System.Drawing.Point(64, 10)
        Me.lbl_hbtk_User.Name = "lbl_hbtk_User"
        Me.lbl_hbtk_User.Size = New System.Drawing.Size(75, 19)
        Me.lbl_hbtk_User.TabIndex = 6
        Me.lbl_hbtk_User.Text = "ユーザー名"
        '
        'Usericon
        '
        Me.Usericon.Image = Global.tbatter_01.My.Resources.Resources.first_icon
        Me.Usericon.Location = New System.Drawing.Point(9, 10)
        Me.Usericon.Name = "Usericon"
        Me.Usericon.Size = New System.Drawing.Size(50, 50)
        Me.Usericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Usericon.TabIndex = 5
        Me.Usericon.TabStop = False
        '
        'tbatter_hbtk_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_hbtk)
        Me.Controls.Add(Me.btn_hbtk_like)
        Me.Controls.Add(Me.lbl_hbtk_User)
        Me.Controls.Add(Me.Usericon)
        Me.Name = "tbatter_hbtk_Control"
        Me.Size = New System.Drawing.Size(345, 157)
        CType(Me.Usericon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_hbtk As Label
    Friend WithEvents btn_hbtk_like As Button
    Friend WithEvents lbl_hbtk_User As Label
    Friend WithEvents Usericon As PictureBox
End Class
