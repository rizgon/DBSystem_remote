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
        update=2
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
        Select Case TargetOperation
            Case Operation.entry
                EntryData()
            Case Operation.update
                'UpdateData()
            Case Else
                Dim msg As String = "新規登録/更新の判断ができません"
                MessageBox.Show(msg, "確認", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Select
    End Sub

    Private Sub btnEntry_Click(sender As Object, e As EventArgs) Handles btnEntry.Click
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
        Dim sql As String = "INSERT INTO T顧客マスタ(顧客名,フリガナ,Post,住所,TEL,FAX)"
        sql &= "VALUES('" & txtCustomerName.Text & "'.'"
        sql &= txtFurigana.Text & "'.'" txtPost.Text & "'.'"txtAddress.Text & "'.'"
        sql &= txtTEL.Text & "'.'" txtFax.Text & "')"
            If
    End Sub
End Class