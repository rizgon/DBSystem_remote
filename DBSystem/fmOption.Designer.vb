<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fmOption
    Inherits BaseForm

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCustomerMaster = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(144, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 143)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "商品マスタ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.Location = New System.Drawing.Point(407, 150)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 143)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "月次処理"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnCustomerMaster
        '
        Me.btnCustomerMaster.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnCustomerMaster.Location = New System.Drawing.Point(144, 330)
        Me.btnCustomerMaster.Name = "btnCustomerMaster"
        Me.btnCustomerMaster.Size = New System.Drawing.Size(188, 143)
        Me.btnCustomerMaster.TabIndex = 1
        Me.btnCustomerMaster.Text = "顧客マスタ"
        Me.btnCustomerMaster.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button4.Location = New System.Drawing.Point(407, 330)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(188, 143)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "請求書の印刷"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "オプション"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(851, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "---"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button5.Location = New System.Drawing.Point(832, 46)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 31)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "閉じる"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'fmOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnCustomerMaster)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "fmOption"
        Me.Text = "fmOption"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Button1, 0)
        Me.Controls.SetChildIndex(Me.Button2, 0)
        Me.Controls.SetChildIndex(Me.btnCustomerMaster, 0)
        Me.Controls.SetChildIndex(Me.Button4, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCustomerMaster As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label2 As Label
End Class
