Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu
Imports System.Data.OleDb

Public Class Doctors_Record
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable

    Sub GetData()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("Select* from doctor ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "DoctorID")
            myDA.Fill(myDataSet, "DoctorName")
            myDA.Fill(myDataSet, "FatherName")
            myDA.Fill(myDataSet, "Address")
            myDA.Fill(myDataSet, "ContactNo")
            myDA.Fill(myDataSet, "Email")

            myDA.Fill(myDataSet, "Age")
            myDA.Fill(myDataSet, "Specialization")
            myDA.Fill(myDataSet, "Gender")
            myDA.Fill(myDataSet, "BG")
            myDA.Fill(myDataSet, "DataOfJoining")


            DataGridView1.DataSource = myDataSet.Tables("DoctorID").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("DoctorName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("FatherName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Address").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ContactNo").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Email").DefaultView

            DataGridView1.DataSource = myDataSet.Tables("Age").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Specialization").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Gender").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("BG").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("DataOfJoining").DefaultView

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdTransform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Doctor.txtDoctorID.Text = DataGridView1.Rows(vbEmpty).Cells(0).Value.ToString()
            Doctor.txtDoctorName.Text = DataGridView1.Rows(vbEmpty).Cells(1).Value.ToString()
            Doctor.txtFatherName.Text = DataGridView1.Rows(vbEmpty).Cells(2).Value.ToString()
            Doctor.txtAddress.Text = DataGridView1.Rows(vbEmpty).Cells(3).Value.ToString()
            Doctor.txtContactNo.Text = DataGridView1.Rows(vbEmpty).Cells(4).Value.ToString()
            Doctor.txtEmail.Text = DataGridView1.Rows(vbEmpty).Cells(5).Value.ToString()
            Doctor.txtAge.Text = DataGridView1.Rows(vbEmpty).Cells(6).Value.ToString()
            Doctor.txtSpecialization.Text = DataGridView1.Rows(vbEmpty).Cells(7).Value.ToString()
            Doctor.cmbGender.Text = DataGridView1.Rows(vbEmpty).Cells(8).Value.ToString()

            Doctor.cmbBG.Text = DataGridView1.Rows(vbEmpty).Cells(9).Value.ToString()
            Doctor.txtDate.Text = DataGridView1.Rows(vbEmpty).Cells(10).Value.ToString()

            Doctor.btnSave.Enabled = False

            Doctor.Show()
            Doctor.btnDelete.Enabled = True
            Doctor.btnUpdate.Enabled = True
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Doctors_Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub txtDoctorID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDoctorID.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("Select* from doctor where DoctorID Like '%" & txtDoctorID.Text & "%' ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "DoctorID")
            myDA.Fill(myDataSet, "DoctorName")
            myDA.Fill(myDataSet, "FatherName")
            myDA.Fill(myDataSet, "Address")
            myDA.Fill(myDataSet, "ContactNo")
            myDA.Fill(myDataSet, "Email")

            myDA.Fill(myDataSet, "Age")
            myDA.Fill(myDataSet, "Specialization")
            myDA.Fill(myDataSet, "Gender")
            myDA.Fill(myDataSet, "BG")
            myDA.Fill(myDataSet, "DataOfJoining")


            DataGridView1.DataSource = myDataSet.Tables("DoctorID").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("DoctorName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("FatherName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Address").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ContactNo").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Email").DefaultView

            DataGridView1.DataSource = myDataSet.Tables("Age").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Specialization").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Gender").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("BG").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("DataOfJoining").DefaultView


            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Doctors_Record_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Doctor.Show()
        Me.Hide()
    End Sub
End Class