<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmMain
    Inherits BaseForm

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
        Me.lblLoginMessage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOption = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.btnOption)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblLoginMessage)
        '
        'lblLoginMessage
        '
        Me.lblLoginMessage.AutoSize = True
        Me.lblLoginMessage.Location = New System.Drawing.Point(56, 56)
        Me.lblLoginMessage.Name = "lblLoginMessage"
        Me.lblLoginMessage.Size = New System.Drawing.Size(38, 12)
        Me.lblLoginMessage.TabIndex = 0
        Me.lblLoginMessage.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "売上管理システム"
        '
        'btnOption
        '
        Me.btnOption.Location = New System.Drawing.Point(787, 52)
        Me.btnOption.Name = "btnOption"
        Me.btnOption.Size = New System.Drawing.Size(82, 21)
        Me.btnOption.TabIndex = 2
        Me.btnOption.Text = "オプション"
        Me.btnOption.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(889, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 21)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "終了"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'fmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1476, 841)
        Me.Name = "fmMain"
        Me.Text = "fmMain"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents lblLoginMessage As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnOption As Button
End Class
