Public Class fmMain
    Private ConnectionString As String = "Data Source=MPC107\SQLEXPRESS01;Initial Catalog=SMS01;Integrated Security=True;"
    Private _ds As DataSet
    Private db As New DBBox(ConnectionString)

    Public Sub New(ByVal ds As DataSet)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _ds = ds

    End Sub

    Private Sub fmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoginMessage.Text = _ds.Tables("T_Login").Rows(0)(1).ToString & "さん　今日も楽しい一日を"
    End Sub
End Class