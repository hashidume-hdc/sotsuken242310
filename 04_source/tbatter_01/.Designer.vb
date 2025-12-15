<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.btn_osusume = New System.Windows.Forms.Button()
        Me.btn_follow = New System.Windows.Forms.Button()
        Me.lbl_me = New System.Windows.Forms.Label()
        Me.lbl_follow_people = New System.Windows.Forms.Label()
        Me.lbl_follow = New System.Windows.Forms.Label()
        Me.lbl_Usrname = New System.Windows.Forms.Label()
        Me.pic_Usricon = New System.Windows.Forms.PictureBox()
        Me.hbtk_FlowLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pic_Usricon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_osusume
        '
        Me.btn_osusume.BackColor = System.Drawing.Color.White
        Me.btn_osusume.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_osusume.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_osusume.Font = New System.Drawing.Font("Meiryo UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_osusume.ForeColor = System.Drawing.Color.Black
        Me.btn_osusume.Location = New System.Drawing.Point(136, 241)
        Me.btn_osusume.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_osusume.Name = "btn_osusume"
        Me.btn_osusume.Size = New System.Drawing.Size(200, 34)
        Me.btn_osusume.TabIndex = 59
        Me.btn_osusume.Text = "はばたき"
        Me.btn_osusume.UseVisualStyleBackColor = False
        '
        'btn_follow
        '
        Me.btn_follow.BackColor = System.Drawing.Color.White
        Me.btn_follow.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_follow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_follow.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn_follow.ForeColor = System.Drawing.Color.Black
        Me.btn_follow.Location = New System.Drawing.Point(363, 21)
        Me.btn_follow.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_follow.Name = "btn_follow"
        Me.btn_follow.Size = New System.Drawing.Size(94, 34)
        Me.btn_follow.TabIndex = 58
        Me.btn_follow.Text = "フォロー"
        Me.btn_follow.UseVisualStyleBackColor = False
        '
        'lbl_me
        '
        Me.lbl_me.Font = New System.Drawing.Font("Meiryo UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_me.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_me.Location = New System.Drawing.Point(11, 77)
        Me.lbl_me.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_me.Name = "lbl_me"
        Me.lbl_me.Size = New System.Drawing.Size(451, 132)
        Me.lbl_me.TabIndex = 57
        Me.lbl_me.Text = "自己紹介文"
        '
        'lbl_follow_people
        '
        Me.lbl_follow_people.AutoSize = True
        Me.lbl_follow_people.Font = New System.Drawing.Font("Meiryo UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_follow_people.ForeColor = System.Drawing.Color.Black
        Me.lbl_follow_people.Location = New System.Drawing.Point(11, 209)
        Me.lbl_follow_people.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_follow_people.Name = "lbl_follow_people"
        Me.lbl_follow_people.Size = New System.Drawing.Size(17, 18)
        Me.lbl_follow_people.TabIndex = 56
        Me.lbl_follow_people.Text = "0"
        '
        'lbl_follow
        '
        Me.lbl_follow.AutoSize = True
        Me.lbl_follow.Font = New System.Drawing.Font("Meiryo UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_follow.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_follow.Location = New System.Drawing.Point(42, 209)
        Me.lbl_follow.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_follow.Name = "lbl_follow"
        Me.lbl_follow.Size = New System.Drawing.Size(65, 18)
        Me.lbl_follow.TabIndex = 55
        Me.lbl_follow.Text = "フォロー中"
        '
        'lbl_Usrname
        '
        Me.lbl_Usrname.AutoSize = True
        Me.lbl_Usrname.Font = New System.Drawing.Font("Meiryo UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_Usrname.Location = New System.Drawing.Point(79, 30)
        Me.lbl_Usrname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Usrname.Name = "lbl_Usrname"
        Me.lbl_Usrname.Size = New System.Drawing.Size(195, 41)
        Me.lbl_Usrname.TabIndex = 54
        Me.lbl_Usrname.Text = "UserName"
        '
        'pic_Usricon
        '
        Me.pic_Usricon.Image = Global.tbatter_01.My.Resources.Resources.unnamed
        Me.pic_Usricon.Location = New System.Drawing.Point(14, 6)
        Me.pic_Usricon.Margin = New System.Windows.Forms.Padding(2)
        Me.pic_Usricon.Name = "pic_Usricon"
        Me.pic_Usricon.Size = New System.Drawing.Size(60, 64)
        Me.pic_Usricon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_Usricon.TabIndex = 53
        Me.pic_Usricon.TabStop = False
        '
        'hbtk_FlowLayout
        '
        Me.hbtk_FlowLayout.BackColor = System.Drawing.Color.White
        Me.hbtk_FlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hbtk_FlowLayout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.hbtk_FlowLayout.Location = New System.Drawing.Point(14, 279)
        Me.hbtk_FlowLayout.Margin = New System.Windows.Forms.Padding(2)
        Me.hbtk_FlowLayout.Name = "hbtk_FlowLayout"
        Me.hbtk_FlowLayout.Size = New System.Drawing.Size(448, 267)
        Me.hbtk_FlowLayout.TabIndex = 52
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Meiryo UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(363, 59)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 34)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "メッセージ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(468, 555)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_osusume)
        Me.Controls.Add(Me.btn_follow)
        Me.Controls.Add(Me.lbl_me)
        Me.Controls.Add(Me.lbl_follow_people)
        Me.Controls.Add(Me.lbl_follow)
        Me.Controls.Add(Me.lbl_Usrname)
        Me.Controls.Add(Me.pic_Usricon)
        Me.Controls.Add(Me.hbtk_FlowLayout)
        Me.Name = "Form3"
        Me.Text = "tbtter_user"
        CType(Me.pic_Usricon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_osusume As Button
    Friend WithEvents btn_follow As Button
    Friend WithEvents lbl_me As Label
    Friend WithEvents lbl_follow_people As Label
    Friend WithEvents lbl_follow As Label
    Friend WithEvents lbl_Usrname As Label
    Friend WithEvents pic_Usricon As PictureBox
    Friend WithEvents hbtk_FlowLayout As FlowLayoutPanel
    Friend WithEvents Button1 As Button
End Class
