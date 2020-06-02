Public Class MainForm

    Private Sub RegisterationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterationToolStripMenuItem.Click
        Registration.Show()
        Registration.btnDelete.Enabled = False
        Registration.btnUpdate.Enabled = False
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

    Private Sub MainForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Login.Show()
    End Sub

    Private Sub UserDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserDetailToolStripMenuItem.Click
        Me.Hide()
        LoginDetails.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Welcome.Close()
        Me.Close()
        Login.Show()
    End Sub

    Private Sub RegistrationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationToolStripMenuItem1.Click
        Patient.Show()
        Patient.btnDelete.Enabled = False
        Patient.btnUpdate.Enabled = False
        Me.Hide()
    End Sub

    Private Sub RegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationToolStripMenuItem.Click
        Doctor.Show()
        Doctor.btnDelete.Enabled = False
        Doctor.btnUpdate.Enabled = False
        Me.Hide()
    End Sub

    Private Sub EditeOrDeleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditeOrDeleToolStripMenuItem.Click
        Doctors_Record.Show()
    End Sub

    Private Sub EditeOrDeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditeOrDeleteToolStripMenuItem.Click
        PatientRecord.Show()
        Me.Hide()
    End Sub

    Private Sub EntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryToolStripMenuItem.Click
        Services.Show()
        Me.Hide()
    End Sub

    Private Sub EditeOrDeleteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditeOrDeleteToolStripMenuItem1.Click
        ServicesRecord.Show()
        Me.Hide()
    End Sub

    Private Sub EntryNurseWardboyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryNurseWardboyToolStripMenuItem.Click
        NurseWardboy_Details.Show()
        NurseWardboy_Details.btnDelete.Enabled = False
        NurseWardboy_Details.btnUpdate.Enabled = False
        Me.Hide()
    End Sub

    Private Sub EditeOrDeleteToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditeOrDeleteToolStripMenuItem2.Click
        NurseWardboyRecord.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DischareToolStripMenuItem.Visible = False
        Me.BillingToolStripMenuItem.Visible = False
        Me.AdminToolStripMenuItem1.Visible = False
    End Sub

    Private Sub PatientReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientReportToolStripMenuItem.Click
        patientReport.Show()
    End Sub

    Private Sub DoctorReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DoctorReportToolStripMenuItem.Click
        'DoctorReport.Show()
    End Sub
End Class