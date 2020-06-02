Public Class MainForm

    Private Sub DetailEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DetailEntryToolStripMenuItem.Click
        Doctor.Show()
        Doctor.btnDelete.Enabled = False
        Doctor.btnUpdate.Enabled = False
        Me.Hide()
    End Sub

    Private Sub RegisterationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterationToolStripMenuItem.Click
        Registration.Show()
        Registration.btnDelete.Enabled = False
        Registration.btnUpdate.Enabled = False
        Me.Hide()
    End Sub

    Private Sub RegisterationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterationToolStripMenuItem1.Click
        Patient.Show()
        Patient.btnDelete.Enabled = False
        Patient.btnUpdate.Enabled = False
        Me.Hide()
    End Sub

    Private Sub WardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WardToolStripMenuItem.Click
        Ward.Show()
        Ward.btnDelete.Enabled = False
        Ward.btnUpdate.Enabled = False
        Me.Hide()
    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        Room.Show()
        Room.btnDelete.Enabled = False
        Room.btnUpdate.Enabled = False
        Me.Hide()
    End Sub

    Private Sub NarseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NarseToolStripMenuItem.Click
        NurseWardboy_Details.Show()
        Patient.btnDelete.Enabled = False
        Patient.btnUpdate.Enabled = False
        Me.Hide()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Change_Password.Show()
        Me.Hide()
    End Sub

    Private Sub ServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicesToolStripMenuItem.Click
        Services.Show()
        Services.btnDelete.Enabled = False
        Services.btnUpdate.Enabled = False
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
        Me.Hide()
    End Sub

    Private Sub ContactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactToolStripMenuItem.Click
        Contact.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub MainForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Login.Show()
    End Sub
End Class