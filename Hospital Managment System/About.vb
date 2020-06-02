Public Class About

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub About_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
        Me.Hide()
    End Sub
End Class