Public Class fmOption
    ' Private ConnectionString As String = "Data Source=MPC107\SQLEXPRESS01;Initial Catalog=SMS01;Integrated Security=True;"
    Private _ds As DataSet
    Private db As New DBBox(My.Settings.ConnectionString)
    Private _fm As Form

    Public Sub New(ByVal ds As DataSet, ByVal fm As Form)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _ds = ds
        _fm = fm
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        _fm.Show()
    End Sub

    Private Sub fmOption_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        _fm.Show()
    End Sub

    Private Sub btnCustomerMaster_Click(sender As Object, e As EventArgs) Handles btnCustomerMaster.Click
        Dim fm As New fmCustomerMaster(_ds, Me)
        fm.Show()
        Me.Hide()
    End Sub
End Class