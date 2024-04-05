Public Class checkBox
    Private Sub checkBox_Load(sender As Object, e As EventArgs) Handles Me.Load


        CheckBox1.Text = "平日"
        CheckBox2.Text = "休日"
        CheckBox3.Text = "祝日"

        Button1.Text = "確認"

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim str As String = ""

        If CheckBox1.Checked = True Then
            str += CheckBox1.Text + vbCrLf
        End If

        If CheckBox2.Checked = True Then
            str += CheckBox2.Text + vbCrLf
        End If

        If CheckBox3.Checked = True Then
            str += CheckBox3.Text + vbCrLf
        End If

        If str = "" Then
            str = "チェックはありません"
        End If

        MsgBox(str)

    End Sub
End Class
