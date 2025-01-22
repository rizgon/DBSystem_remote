<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PW"
        '
        'txtID
        '
        Me.txtID.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtID.Location = New System.Drawing.Point(92, 42)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 19)
        Me.txtID.TabIndex = 2
        '
        'txtPW
        '
        Me.txtPW.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtPW.Location = New System.Drawing.Point(92, 99)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(100, 19)
        Me.txtPW.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(226, 33)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(68, 44)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "ログイン"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(226, 98)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(68, 21)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "終了"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'fmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 164)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPW)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fmLogin"
        Me.Text = "ログイン"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnQuit As Button
End Class
