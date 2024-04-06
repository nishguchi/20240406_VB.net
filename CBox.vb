Imports System.Reflection

Public Class CBox
    Private Sub CBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With Me.ComboBox1
            .Text = "-選択一覧-"
            .Items.Add("内容1")
            .Items.Add("内容2")
            .Items.Add("内容3")
            .Items.Add("内容4")
        End With

        Label4.Text = ComboBox1.Items.Count

    End Sub


    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        'コンボボックス変更時
        '表示変更
        Label2.Text = ComboBox1.SelectedItem
        Label3.Text = ComboBox1.SelectedIndex + 1.ToString
        'Label3.Text = ComboBox1.Items.IndexOf(ComboBox1.SelectedItem) + 1.ToString

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        '追加ボタン押下
        'コンボボックス追加
        If (AddText.Text <> String.Empty) Then
            ComboBox1.Items.Add(AddText.Text)
            AddText.Text = String.Empty
            Label4.Text = ComboBox1.Items.Count
        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        'コンボボックス全値クリア
        '初期値セット
        ComboBox1.Items.Clear()
        ClearIs()
    End Sub

    Private Sub SelectClearButton_Click(sender As Object, e As EventArgs) Handles SelectClearButton.Click
        'コンボボックス選択値クリア
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)
        ClearIs()
    End Sub


    Private Sub ClearIs()
        '初期値セット
        ComboBox1.Text = "-選択一覧-"
        Label2.Text = "*****"
        Label3.Text = "**"
    End Sub


End Class
