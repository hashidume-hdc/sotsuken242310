<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class follow_now
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
        Me.follow_FlowLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'follow_FlowLayout
        '
        Me.follow_FlowLayout.BackColor = System.Drawing.Color.White
        Me.follow_FlowLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.follow_FlowLayout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.follow_FlowLayout.Location = New System.Drawing.Point(11, 11)
        Me.follow_FlowLayout.Margin = New System.Windows.Forms.Padding(2)
        Me.follow_FlowLayout.Name = "follow_FlowLayout"
        Me.follow_FlowLayout.Size = New System.Drawing.Size(308, 428)
        Me.follow_FlowLayout.TabIndex = 1
        '
        'follow_now
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(330, 450)
        Me.Controls.Add(Me.follow_FlowLayout)
        Me.Name = "follow_now"
        Me.Text = "follow_now"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents follow_FlowLayout As FlowLayoutPanel
End Class
