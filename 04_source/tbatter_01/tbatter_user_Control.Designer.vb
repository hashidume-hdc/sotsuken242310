<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tbatter_user_Control
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
        Me.lbl_hbtk_User = New System.Windows.Forms.Label()
        Me.Usericon = New System.Windows.Forms.PictureBox()
        CType(Me.Usericon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_hbtk_User
        '
        Me.lbl_hbtk_User.AutoSize = True
        Me.lbl_hbtk_User.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hbtk_User.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbl_hbtk_User.Location = New System.Drawing.Point(44, 16)
        Me.lbl_hbtk_User.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_hbtk_User.Name = "lbl_hbtk_User"
        Me.lbl_hbtk_User.Size = New System.Drawing.Size(61, 15)
        Me.lbl_hbtk_User.TabIndex = 13
        Me.lbl_hbtk_User.Text = "ユーザー名"
        '
        'Usericon
        '
        Me.Usericon.Image = Global.tbatter_01.My.Resources.Resources.first_icon
        Me.Usericon.Location = New System.Drawing.Point(2, 2)
        Me.Usericon.Margin = New System.Windows.Forms.Padding(2)
        Me.Usericon.Name = "Usericon"
        Me.Usericon.Size = New System.Drawing.Size(38, 40)
        Me.Usericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Usericon.TabIndex = 12
        Me.Usericon.TabStop = False
        '
        'tbatter_user_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.Controls.Add(Me.lbl_hbtk_User)
        Me.Controls.Add(Me.Usericon)
        Me.Name = "tbatter_user_Control"
        Me.Size = New System.Drawing.Size(244, 45)
        CType(Me.Usericon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_hbtk_User As Label
    Friend WithEvents Usericon As PictureBox
End Class
