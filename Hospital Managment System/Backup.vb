Public Class Backup

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 200
        ProgressBar1.Value = 200

        My.Computer.FileSystem.CopyFile(
        "C:\Users\a\Documents\Visual Studio 2008\Hospital Managment System\Hospital Managment System\Hospital Managment System - Copy\hms_db.mdb",
        "C:\Users\a\Documents\Visual Studio 2008\Hospital Managment System\Hospital Managment System\Hospital Managment System - Copy\Backup/hms_db.mdb",
        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        MessageBox.Show("Backup Completed Successfully", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        MainForm.Show()
    End Sub
End Class