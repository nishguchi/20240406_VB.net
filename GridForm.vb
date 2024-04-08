
Public Class GridForm

    Private Sub Grid_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim colSchedule As New DataGridViewTextBoxColumn()
        Dim colMemo As New DataGridViewTextBoxColumn()
        Dim colStart As New DataGridViewTextBoxColumn()
        Dim colEnd As New DataGridViewTextBoxColumn()

        With colSchedule
            .Name = "schedule"
            .HeaderText = "予定"
            .Width = 100S
        End With

        With colMemo
            .Name = "memo"
            .HeaderText = "メモ内容"
            .Width = 250S
        End With


        With colStart
            .Name = "start"
            .HeaderText = "開始日時"
            .Width = 100S
        End With

        With colEnd
            .Name = "end"
            .HeaderText = "終了日時"
            .Width = 100S
        End With


        grid.Columns.Add(colSchedule)
        grid.Columns.Add(colMemo)
        grid.Columns.Add(colStart)
        grid.Columns.Add(colEnd)


    End Sub


    Private Sub selectClear_Click(sender As Object, e As EventArgs) Handles selectClear.Click

        '選択行削除
        For Each c As DataGridViewCell In grid.SelectedCells
            Dim num As String = c.RowIndex + 1
            grid.Rows.RemoveAt(c.RowIndex)

            Label1.Text = num + "行目のアイテムを削除しました"

        Next c

        'testコード
        'MsgBox("{0}, {1}", c.ColumnIndex, c.RowIndex)
        'grid.SelectedRows.Clear()
        'grid.SelectedCells.Clear()
        'grid.SelectedColumns.Clear()
        'https://dobon.net/vb/dotnet/datagridview/selectedcells.html
    End Sub

    Private Sub allClear_Click(sender As Object, e As EventArgs) Handles allClear.Click

        '全行削除（クリア）
        grid.Rows.Clear()
        Label1.Text = "全てのアイテムを削除しました"

        'grid.Columns.Clear()  カラム全削除
    End Sub
End Class
