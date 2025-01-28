<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmCustomerMaster
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.panelEntry = New System.Windows.Forms.Panel()
        Me.txtTEL = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExe = New System.Windows.Forms.Button()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPost = New System.Windows.Forms.TextBox()
        Me.txtFurigana = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelCustomerList = New System.Windows.Forms.Panel()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.btnWA = New System.Windows.Forms.Button()
        Me.btnRA = New System.Windows.Forms.Button()
        Me.btnYA = New System.Windows.Forms.Button()
        Me.btnMA = New System.Windows.Forms.Button()
        Me.btnHA = New System.Windows.Forms.Button()
        Me.btnNA = New System.Windows.Forms.Button()
        Me.btnTA = New System.Windows.Forms.Button()
        Me.btnSA = New System.Windows.Forms.Button()
        Me.btnKA = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnEntry = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.panelEntry.SuspendLayout()
        Me.panelCustomerList.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnEntry)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.Label1)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "顧客マスタ"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("MS UI Gothic", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblDate.Location = New System.Drawing.Point(863, 8)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(58, 30)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "---"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnClose.Location = New System.Drawing.Point(842, 44)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(114, 31)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "閉じる"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'panelEntry
        '
        Me.panelEntry.BackColor = System.Drawing.SystemColors.ControlLight
        Me.panelEntry.Controls.Add(Me.txtTEL)
        Me.panelEntry.Controls.Add(Me.btnCancel)
        Me.panelEntry.Controls.Add(Me.btnExe)
        Me.panelEntry.Controls.Add(Me.txtFax)
        Me.panelEntry.Controls.Add(Me.txtAddress)
        Me.panelEntry.Controls.Add(Me.txtPost)
        Me.panelEntry.Controls.Add(Me.txtFurigana)
        Me.panelEntry.Controls.Add(Me.Label7)
        Me.panelEntry.Controls.Add(Me.txtCustomerName)
        Me.panelEntry.Controls.Add(Me.Label6)
        Me.panelEntry.Controls.Add(Me.Label5)
        Me.panelEntry.Controls.Add(Me.Label4)
        Me.panelEntry.Controls.Add(Me.Label3)
        Me.panelEntry.Controls.Add(Me.Label2)
        Me.panelEntry.Location = New System.Drawing.Point(1, 85)
        Me.panelEntry.Name = "panelEntry"
        Me.panelEntry.Size = New System.Drawing.Size(972, 167)
        Me.panelEntry.TabIndex = 1
        '
        'txtTEL
        '
        Me.txtTEL.Location = New System.Drawing.Point(389, 116)
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Size = New System.Drawing.Size(170, 19)
        Me.txtTEL.TabIndex = 5
        Me.txtTEL.Tag = "y"
        Me.txtTEL.Text = "1234567890"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(857, 110)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 25)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "キャンセル"
        Me.btnCancel.UseVisualStyleBackColor = True
        Me.btnCancel.UseWaitCursor = True
        '
        'btnExe
        '
        Me.btnExe.Location = New System.Drawing.Point(857, 22)
        Me.btnExe.Name = "btnExe"
        Me.btnExe.Size = New System.Drawing.Size(99, 68)
        Me.btnExe.TabIndex = 7
        Me.btnExe.Text = "新規登録"
        Me.btnExe.UseVisualStyleBackColor = True
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(635, 116)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(170, 19)
        Me.txtFax.TabIndex = 6
        Me.txtFax.Tag = "y"
        Me.txtFax.Text = "2345678901"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(389, 75)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(446, 19)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Tag = "y"
        Me.txtAddress.Text = "東京都大田区1-2-3"
        '
        'txtPost
        '
        Me.txtPost.Location = New System.Drawing.Point(389, 30)
        Me.txtPost.Name = "txtPost"
        Me.txtPost.Size = New System.Drawing.Size(111, 19)
        Me.txtPost.TabIndex = 3
        Me.txtPost.Tag = "y"
        Me.txtPost.Text = "1112222"
        '
        'txtFurigana
        '
        Me.txtFurigana.Location = New System.Drawing.Point(87, 75)
        Me.txtFurigana.Name = "txtFurigana"
        Me.txtFurigana.Size = New System.Drawing.Size(232, 19)
        Me.txtFurigana.TabIndex = 2
        Me.txtFurigana.Tag = "y"
        Me.txtFurigana.Text = "カキクケコペットショップ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.Location = New System.Drawing.Point(594, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "FAX"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(87, 30)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(232, 19)
        Me.txtCustomerName.TabIndex = 1
        Me.txtCustomerName.Tag = "y"
        Me.txtCustomerName.Text = "かきくけこペットショップ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label6.Location = New System.Drawing.Point(348, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "TEL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.Location = New System.Drawing.Point(346, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "住所"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(346, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(22, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "〒"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "フリガナ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "顧客名"
        '
        'panelCustomerList
        '
        Me.panelCustomerList.Controls.Add(Me.dgvList)
        Me.panelCustomerList.Controls.Add(Me.btnWA)
        Me.panelCustomerList.Controls.Add(Me.btnRA)
        Me.panelCustomerList.Controls.Add(Me.btnYA)
        Me.panelCustomerList.Controls.Add(Me.btnMA)
        Me.panelCustomerList.Controls.Add(Me.btnHA)
        Me.panelCustomerList.Controls.Add(Me.btnNA)
        Me.panelCustomerList.Controls.Add(Me.btnTA)
        Me.panelCustomerList.Controls.Add(Me.btnSA)
        Me.panelCustomerList.Controls.Add(Me.btnKA)
        Me.panelCustomerList.Controls.Add(Me.btnA)
        Me.panelCustomerList.Controls.Add(Me.btnDelete)
        Me.panelCustomerList.Controls.Add(Me.btnUpdate)
        Me.panelCustomerList.Location = New System.Drawing.Point(1, 258)
        Me.panelCustomerList.Name = "panelCustomerList"
        Me.panelCustomerList.Size = New System.Drawing.Size(971, 300)
        Me.panelCustomerList.TabIndex = 2
        '
        'dgvList
        '
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Location = New System.Drawing.Point(8, 58)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.RowTemplate.Height = 21
        Me.dgvList.Size = New System.Drawing.Size(951, 231)
        Me.dgvList.TabIndex = 2
        '
        'btnWA
        '
        Me.btnWA.Location = New System.Drawing.Point(488, 18)
        Me.btnWA.Name = "btnWA"
        Me.btnWA.Size = New System.Drawing.Size(47, 27)
        Me.btnWA.TabIndex = 1
        Me.btnWA.Tag = "わ-ん"
        Me.btnWA.Text = "わ"
        Me.btnWA.UseVisualStyleBackColor = True
        '
        'btnRA
        '
        Me.btnRA.Location = New System.Drawing.Point(435, 18)
        Me.btnRA.Name = "btnRA"
        Me.btnRA.Size = New System.Drawing.Size(47, 27)
        Me.btnRA.TabIndex = 1
        Me.btnRA.Tag = "ら-ろ"
        Me.btnRA.Text = "ら"
        Me.btnRA.UseVisualStyleBackColor = True
        '
        'btnYA
        '
        Me.btnYA.Location = New System.Drawing.Point(382, 19)
        Me.btnYA.Name = "btnYA"
        Me.btnYA.Size = New System.Drawing.Size(47, 27)
        Me.btnYA.TabIndex = 1
        Me.btnYA.Tag = "や－よ"
        Me.btnYA.Text = "や"
        Me.btnYA.UseVisualStyleBackColor = True
        '
        'btnMA
        '
        Me.btnMA.Location = New System.Drawing.Point(329, 20)
        Me.btnMA.Name = "btnMA"
        Me.btnMA.Size = New System.Drawing.Size(47, 27)
        Me.btnMA.TabIndex = 1
        Me.btnMA.Tag = "ま-も"
        Me.btnMA.Text = "ま"
        Me.btnMA.UseVisualStyleBackColor = True
        '
        'btnHA
        '
        Me.btnHA.Location = New System.Drawing.Point(276, 20)
        Me.btnHA.Name = "btnHA"
        Me.btnHA.Size = New System.Drawing.Size(47, 27)
        Me.btnHA.TabIndex = 1
        Me.btnHA.Tag = "は-ほ"
        Me.btnHA.Text = "は"
        Me.btnHA.UseVisualStyleBackColor = True
        '
        'btnNA
        '
        Me.btnNA.Location = New System.Drawing.Point(223, 20)
        Me.btnNA.Name = "btnNA"
        Me.btnNA.Size = New System.Drawing.Size(47, 27)
        Me.btnNA.TabIndex = 1
        Me.btnNA.Tag = "な-の"
        Me.btnNA.Text = "な"
        Me.btnNA.UseVisualStyleBackColor = True
        '
        'btnTA
        '
        Me.btnTA.Location = New System.Drawing.Point(170, 19)
        Me.btnTA.Name = "btnTA"
        Me.btnTA.Size = New System.Drawing.Size(47, 27)
        Me.btnTA.TabIndex = 1
        Me.btnTA.Tag = "た-と"
        Me.btnTA.Text = "た"
        Me.btnTA.UseVisualStyleBackColor = True
        '
        'btnSA
        '
        Me.btnSA.Location = New System.Drawing.Point(117, 19)
        Me.btnSA.Name = "btnSA"
        Me.btnSA.Size = New System.Drawing.Size(47, 27)
        Me.btnSA.TabIndex = 1
        Me.btnSA.Tag = "さ-そ"
        Me.btnSA.Text = "さ"
        Me.btnSA.UseVisualStyleBackColor = True
        '
        'btnKA
        '
        Me.btnKA.Location = New System.Drawing.Point(64, 19)
        Me.btnKA.Name = "btnKA"
        Me.btnKA.Size = New System.Drawing.Size(47, 27)
        Me.btnKA.TabIndex = 1
        Me.btnKA.Tag = "か-こ"
        Me.btnKA.Text = "か"
        Me.btnKA.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Location = New System.Drawing.Point(11, 18)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(47, 27)
        Me.btnA.TabIndex = 1
        Me.btnA.Tag = "あーお"
        Me.btnA.Text = "あ"
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(868, 20)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 25)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(765, 20)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(92, 25)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "修正"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnEntry
        '
        Me.btnEntry.Location = New System.Drawing.Point(708, 47)
        Me.btnEntry.Name = "btnEntry"
        Me.btnEntry.Size = New System.Drawing.Size(127, 25)
        Me.btnEntry.TabIndex = 4
        Me.btnEntry.Text = "新規登録"
        Me.btnEntry.UseVisualStyleBackColor = True
        '
        'fmCustomerMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.panelCustomerList)
        Me.Controls.Add(Me.panelEntry)
        Me.Name = "fmCustomerMaster"
        Me.Text = "fmCustomerMaster"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.panelEntry, 0)
        Me.Controls.SetChildIndex(Me.panelCustomerList, 0)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panelEntry.ResumeLayout(False)
        Me.panelEntry.PerformLayout()
        Me.panelCustomerList.ResumeLayout(False)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents panelEntry As Panel
    Friend WithEvents txtFurigana As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents panelCustomerList As Panel
    Friend WithEvents txtTEL As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnExe As Button
    Friend WithEvents txtFax As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPost As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnWA As Button
    Friend WithEvents btnRA As Button
    Friend WithEvents btnYA As Button
    Friend WithEvents btnMA As Button
    Friend WithEvents btnHA As Button
    Friend WithEvents btnNA As Button
    Friend WithEvents btnTA As Button
    Friend WithEvents btnSA As Button
    Friend WithEvents btnKA As Button
    Friend WithEvents btnA As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents btnEntry As Button
End Class
