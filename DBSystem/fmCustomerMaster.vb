Public Class fmCustomerMaster
    Const ENTRY_TOP As Integer = 85
    Const ENTRY_HEIGHT As Integer = 145
    Const LIST_HEIGHT As Integer = 330

    Private db As New DBBox(My.Settings.ConnectionString)
    Private _ds As DataSet
    Private _fm As Form

    Private TargetOperation As Integer
    Private Enum Operation
        entry = 1
        update = 2
    End Enum

    Public Sub New(ByVal ds As DataSet, ByVal fm As Form)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _ds = ds
        _fm = fm

    End Sub

    Private Sub ShowCustomerList(ByVal Condition As String)
        Dim sql As String = "SELECT * FROM T顧客マスタ WHERE フリガナ LIKE '[" & Condition & "]%' ORDER BY フリガナ"
        Dim dt As New DataTable
        If Not db.GetDataFormDB(dt, sql) Then
            Exit Sub
        End If
        With dgvList
            .DataSource = dt
            .Columns(0).HeaderText = "ID"
            .Columns(0).Width = 50
            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(3).Width = 100
            .Columns(4).Width = 250
            .Columns(5).Width = 100
            .Columns(6).Width = 100

        End With
    End Sub
    Private Sub fmCustomerMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With dgvList
            .CellBorderStyle = DataGridViewCellBorderStyle.None
            .AllowUserToResizeRows = False
            .AllowUserToAddRows = False
            .ReadOnly = True
        End With
        InvisibleEntryArea()
        btnUpdate.Visible = False
        btnDelete.Visible = False
    End Sub

    Private Sub VisibleEntryArea()
        panelEntry.Height = ENTRY_HEIGHT
        panelCustomerList.Top = ENTRY_TOP + ENTRY_HEIGHT
        panelCustomerList.Height = LIST_HEIGHT
    End Sub
    Private Sub InvisibleEntryArea()
        panelEntry.Height = 0
        panelCustomerList.Top = ENTRY_TOP
        panelCustomerList.Height = LIST_HEIGHT + ENTRY_HEIGHT
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub fmCustomerMaster_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        _fm.Show()
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnKA.Click, btnSA.Click, btnTA.Click, btnNA.Click, btnHA.Click, btnMA.Click, btnYA.Click, btnRA.Click, btnWA.Click
        ShowCustomerList(DirectCast(sender, Button).Tag.ToString)

    End Sub

    Private Sub btnExe_Click(sender As Object, e As EventArgs) Handles btnExe.Click
        'グレーの見え隠れするパネル内の新規登録ボタン
        Select Case TargetOperation
            Case Operation.entry
                EntryData()
            Case Operation.update
                UpdateData()
            Case Else
                Dim msg As String = "新規登録/更新の判断ができません"
                MessageBox.Show(msg, "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Select
    End Sub

    Private Sub btnEntry_Click(sender As Object, e As EventArgs) Handles btnEntry.Click
        '水色のパネル内の新規登録ボタン
        VisibleEntryArea()
        txtCustomerName.Focus()
        TargetOperation = Operation.entry
        btnEntry.Enabled = False
    End Sub


    Private Sub EntryData()
        If txtCustomerName.Text = String.Empty Then
            MessageBox.Show("顧客名を入力してください", "確認")
            txtCustomerName.Focus()
            Exit Sub
        End If
        Dim sql As String = "INSERT INTO T顧客マスタ(顧客名,フリガナ,Post,住所,TEL,FAX) "
        sql &= "VALUES('" & txtCustomerName.Text & "','"
        sql &= txtFurigana.Text & "','"
        sql &= txtPost.Text & "','"
        sql &= txtAddress.Text & "','"
        sql &= txtTEL.Text & "','"
        sql &= txtFax.Text & "')"
        If Not db.UpdateData(sql) Then
            MessageBox.Show("保存されませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        ClearControlData()
        InvisibleEntryArea()
        btnEntry.Enabled = True
    End Sub

    Private Sub ClearControlData()
        For Each ctl As Control In Me.panelEntry.Controls
            Try
                If DirectCast(ctl, TextBox).Tag.ToString = "y" Then
                    ctl.Text = ""
                End If
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearControlData()
        InvisibleEntryArea()
        btnEntry.Enabled = True
        btnUpdate.Visible = False
        btnDelete.Visible = False
        dgvList.Enabled = True
    End Sub

    Private Sub dgvList_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvList.RowHeaderMouseClick
        btnUpdate.Visible = True
        btnDelete.Visible = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        '修正ボタン
        btnExe.Text = "修正"
        VisibleEntryArea()
        SetDataToControl()
        TargetOperation = Operation.update
        dgvList.Enabled = False
    End Sub
    Private Sub SetDataToControl()
        With dgvList
            txtCustomerName.Text = Trim(.CurrentRow.Cells("顧客名").Value.ToString)
            txtFurigana.Text = Trim(.CurrentRow.Cells("フリガナ").Value.ToString)
            txtPost.Text = Trim(.CurrentRow.Cells("Post").Value.ToString)
            txtAddress.Text = Trim(.CurrentRow.Cells("住所").Value.ToString)
            txtTEL.Text = Trim(.CurrentRow.Cells("TEL").Value.ToString)
            txtFax.Text = Trim(.CurrentRow.Cells("FAX").Value.ToString)

        End With
    End Sub

    Private Sub UpdateData()
        Dim sql As String = "UPDATE T顧客マスタ SET 顧客名='"
        sql &= txtCustomerName.Text
        sql &= "', フリガナ='" & txtFurigana.Text
        sql &= "', Post='" & txtPost.Text
        sql &= "', 住所='" & txtAddress.Text
        sql &= "', TEL='" & txtTEL.Text
        sql &= "', FAX='" & txtFax.Text
        sql &= "' WHERE 顧客ID="
        sql &= dgvList.CurrentRow.Cells("顧客ID").Value.ToString

        If Not db.UpdateData(sql) Then
            Dim msg As String = "もう一度修正ボタンをクリックしてください"
            MessageBox.Show(msg, "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        UpdateGridviewRowData()
        ClearControlData()
        InvisibleEntryArea()
        btnUpdate.Visible = False
        btnUpdate.Visible = False
        dgvList.Enabled = True
    End Sub
    Private Sub UpdateGridviewRowData()
        With dgvList.CurrentRow
            .Cells("顧客名").Value = txtCustomerName.Text
            .Cells("フリガナ").Value = txtFurigana.Text
            .Cells("Post").Value = txtPost.Text
            .Cells("住所").Value = txtAddress.Text
            .Cells("TEL").Value = txtTEL.Text
            .Cells("FAX").Value = txtFax.Text
        End With
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim CustomerName As String = dgvList.CurrentRow.Cells("顧客名").Value.ToString
        Dim msg As String = "以下のレコードを削除します。元に戻すことはできません。よろしいですか？"
        msg &= vbNewLine & "顧客名：" & CustomerName
        Dim res As DialogResult = MessageBox.Show(msg, "削除の確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If res = Windows.Forms.DialogResult.Yes Then
            Dim CustomerID As String = dgvList.CurrentRow.Cells("顧客ID").Value.ToString
            Dim sql As String = "DELETE FROM T顧客マスタ WHERE 顧客ID=" & CustomerID
            If db.UpdateData(sql) Then
                dgvList.Rows.RemoveAt(dgvList.CurrentRow.Index)
                btnUpdate.Visible = False
                btnDelete.Visible = False
            End If
        End If
    End Sub
End Class