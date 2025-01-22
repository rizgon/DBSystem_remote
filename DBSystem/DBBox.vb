Imports System.Data.SqlClient
Public Class DBBox
    Private _ConnectionString As String = "SMS01ConnectionString"

    Sub New(ByVal ConnectionString As String)
        'コンストラクタで接続文字列を取得する。
        'このクラスが呼ばれたときに接続文字列は取得済み
        _ConnectionString = ConnectionString
    End Sub

    Public Function GetDataFormDB(ByVal DataTable As DataTable, ByVal strSQL As String) As Boolean

        'クエリと接続文字列を引数にする
        'SqlDataAdapterをインスタンス化
        '=クエリと接続文字列をSqlDataAdapterにセットする。
        '接続をトライしている
        Dim da As New SqlDataAdapter(strSQL, _ConnectionString)

        Try
            ' データベースに接続
            'クエリの実行
            '取得したデータをDataTable に格納する
            da.Fill(DataTable)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Overloads Function GetDataFromDB(ByVal ds As DataSet, ByVal strDataTable As String, ByVal strSQL As String)
        'DBからデータを取得してデータセットに格納する
        Dim da As New SqlDataAdapter(strSQL, _ConnectionString)
        Try
            da.Fill(ds, strDataTable)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class




'このクラスは、データベースにアクセスしてDataTableに格納するクラス。
'■コンストラクタ
'　　　このクラスがNewされたときに接続文字列を取得する
'■GetDataFormDB
'       クエリと接続文字列を使ってDataTableに結果を格納、戻り値とする
'       DB→データセット格納もできる。




