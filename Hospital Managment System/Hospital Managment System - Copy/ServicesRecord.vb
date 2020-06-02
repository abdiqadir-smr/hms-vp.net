Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu
Imports System.Data.OleDb

Public Class ServicesRecord
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
            cmd = New OleDbCommand("Select* from services ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "ServiceID")
            myDA.Fill(myDataSet, "ServiceName")
            myDA.Fill(myDataSet, "ServiceDate")
            myDA.Fill(myDataSet, "PatientID")
            myDA.Fill(myDataSet, "PatientName")
            myDA.Fill(myDataSet, "ServiceCharges")

            
            DataGridView1.DataSource = myDataSet.Tables("ServiceID").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ServiceName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ServiceDate").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("PatientID").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("PatientName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ServiceCharges").DefaultView

            
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            'Services.txt.Text = DataGridView1.Rows(vbEmpty).Cells(0).Value.ToString()
            Services.txtServiceName.Text = DataGridView1.Rows(vbEmpty).Cells(1).Value.ToString()
            Services.txtServiceDate.Text = DataGridView1.Rows(vbEmpty).Cells(2).Value.ToString()
            Services.txtPatientID.Text = DataGridView1.Rows(vbEmpty).Cells(3).Value.ToString()
            Services.txtPatientName.Text = DataGridView1.Rows(vbEmpty).Cells(4).Value.ToString()
            Services.txtServiceCharge.Text = DataGridView1.Rows(vbEmpty).Cells(5).Value.ToString()
            
            Services.btnSave.Enabled = False

            Services.Show()
            Services.btnDelete.Enabled = True
            Services.btnUpdate.Enabled = True
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ServicesRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub txtPatientID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServiceID.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("Select* from services where ServiceID Like '%" & txtServiceID.Text & "%' ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "ServiceID")
            myDA.Fill(myDataSet, "ServiceName")
            myDA.Fill(myDataSet, "ServiceDate")
            myDA.Fill(myDataSet, "PatientID")
            myDA.Fill(myDataSet, "PatientName")
            myDA.Fill(myDataSet, "ServiceCharges")


            DataGridView1.DataSource = myDataSet.Tables("ServiceID").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ServiceName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ServiceDate").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("PatientID").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("PatientName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ServiceCharges").DefaultView


            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class