Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu
Imports System.Data.OleDb

Public Class PatientRecord
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
            cmd = New OleDbCommand("Select* from patient ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "PatientID")
            myDA.Fill(myDataSet, "PatientName")
            myDA.Fill(myDataSet, "FatherName")
            myDA.Fill(myDataSet, "Address")
            myDA.Fill(myDataSet, "ContactNo")
            myDA.Fill(myDataSet, "Email")

            myDA.Fill(myDataSet, "Age")

            myDA.Fill(myDataSet, "Gender")
            myDA.Fill(myDataSet, "BG")
            myDA.Fill(myDataSet, "Remarks")


            DataGridView1.DataSource = myDataSet.Tables("PatientID").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("PatientName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("FatherName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Address").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ContactNo").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Email").DefaultView

            DataGridView1.DataSource = myDataSet.Tables("Age").DefaultView

            DataGridView1.DataSource = myDataSet.Tables("Gender").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("BG").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Remarks").DefaultView

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Patient.txtPatientID.Text = DataGridView1.Rows(vbEmpty).Cells(0).Value.ToString()
            Patient.txtPatientName.Text = DataGridView1.Rows(vbEmpty).Cells(1).Value.ToString()
            Patient.txtFatherName.Text = DataGridView1.Rows(vbEmpty).Cells(2).Value.ToString()
            Patient.txtAddress.Text = DataGridView1.Rows(vbEmpty).Cells(3).Value.ToString()
            Patient.txtContactNo.Text = DataGridView1.Rows(vbEmpty).Cells(4).Value.ToString()
            Patient.txtEmail.Text = DataGridView1.Rows(vbEmpty).Cells(5).Value.ToString()
            Patient.txtAge.Text = DataGridView1.Rows(vbEmpty).Cells(6).Value.ToString()

            Patient.cmbGender.Text = DataGridView1.Rows(vbEmpty).Cells(7).Value.ToString()

            Patient.cmbBG.Text = DataGridView1.Rows(vbEmpty).Cells(8).Value.ToString()
            Patient.txtRemarks.Text = DataGridView1.Rows(vbEmpty).Cells(9).Value.ToString()

            Patient.btnSave.Enabled = False

            Patient.Show()
            Patient.btnDelete.Enabled = True
            Patient.btnUpdate.Enabled = True
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PatientRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub txtPatientID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPatientID.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("Select* from patient where PatientID Like '%" & txtPatientID.Text & "%' ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "PatientID")
            myDA.Fill(myDataSet, "PatientName")
            myDA.Fill(myDataSet, "FatherName")
            myDA.Fill(myDataSet, "Address")
            myDA.Fill(myDataSet, "ContactNo")
            myDA.Fill(myDataSet, "Email")

            myDA.Fill(myDataSet, "Age")

            myDA.Fill(myDataSet, "Gender")
            myDA.Fill(myDataSet, "BG")
            myDA.Fill(myDataSet, "Remarks")


            DataGridView1.DataSource = myDataSet.Tables("PatientID").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("PatientName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("FatherName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Address").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ContactNo").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Email").DefaultView

            DataGridView1.DataSource = myDataSet.Tables("Age").DefaultView

            DataGridView1.DataSource = myDataSet.Tables("Gender").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("BG").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Remarks").DefaultView


            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PatientRecord_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Patient.Show()
        Me.Hide()
    End Sub
End Class