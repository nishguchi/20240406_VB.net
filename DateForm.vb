Public Class DateForm
    Private Sub DateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dateTime As DateTime = DateTime.Now
        'Label1.Text = dateTime.ToString.Format("yyyy/MM/dd HH:mm:ss") 変換されない
        Label1.Text = Format(dateTime, "yyyy年MM月dd日 HH時 mm分 ss秒")

    End Sub


End Class
