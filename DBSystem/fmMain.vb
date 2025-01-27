Public Class fmMain
    Private _ds As DataSet
    Private db As New DBBox(My.Settings.ConnectionString)

    Public Sub New(ByVal ds As DataSet)

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        _ds = ds

    End Sub

    Private Sub fmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoginMessage.Text = _ds.Tables("T_Login").Rows(0)(1).ToString & "さん　今日も楽しい一日を"
    End Sub

    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        'オプションボタンが押されたら、fmMainは非表示、fmOptionをひょうじする。
        'どのフォームが開けばいいのかわからないので、変数fmにfmOptionの情報を入れておいて、fmOptionが表示されるようにする。
        Dim fm As New fmOption(_ds, Me)
        fm.Show()
        Me.Hide()
    End Sub
End Class