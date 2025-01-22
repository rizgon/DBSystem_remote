Public Class fmLogin

    Private ds As New DataSet
    Private db As New DBBox(My.Settings.ConnectionString)




    Private Sub fmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not db.GetDataFromDB(ds, "T分類マスタ", "SELECT * FROM T分類マスタ") Then
            Dim msg As String = "データベースに接続できません。終了してください"
            MessageBox.Show(msg, "接続エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        db.GetDataFromDB(ds, "Tメーカーマスタ", "SELECT * FROM メーカーマスタ")

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        '指定されたログインIDでパスワード、ユーザーネームを呼び出すクエリ
        Dim sql As String = "SELECT Password, UserName FROM T_Login WHERE LoginID='" & txtID.Text & "'"
        'T_Loginテーブルに上のクエリを投げるとデータセットが返ってくる
        If db.GetDataFromDB(ds, "T_Login", sql) Then
            'クエリの結果が0行なら、LoginIDが間違っているのでexit
            If ds.Tables("T_Login").Rows.Count = 0 Then
                Exit Sub
            End If
            'クエリの結果が0行ではない→結果の0,0番目の内容が入力されたパスワードと一致するなら
            If ds.Tables("T_Login").Rows(0)(0).ToString = txtPW.Text Then
                Dim fm As New fmMain(ds)
                fm.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub
End Class
