Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu
Imports System.Data.OleDb

Public Class NurseWardboyRecord
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
            cmd = New OleDbCommand("Select* from nurse_wardboy ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "ID")
            myDA.Fill(myDataSet, "W_N_Name")
            myDA.Fill(myDataSet, "Category")
            myDA.Fill(myDataSet, "Address")
            myDA.Fill(myDataSet, "ContactNo")
            myDA.Fill(myDataSet, "Email")

            myDA.Fill(myDataSet, "Age")

            myDA.Fill(myDataSet, "Gender")
            myDA.Fill(myDataSet, "BG")
            myDA.Fill(myDataSet, "DateOfJoining")


            DataGridView1.DataSource = myDataSet.Tables("ID").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("W_N_Name").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Category").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Address").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ContactNo").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Email").DefaultView

            DataGridView1.DataSource = myDataSet.Tables("Age").DefaultView

            DataGridView1.DataSource = myDataSet.Tables("Gender").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("BG").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("DateOfJoining").DefaultView

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            NurseWardboy_Details.txtWNID.Text = DataGridView1.Rows(vbEmpty).Cells(0).Value.ToString()
            NurseWardboy_Details.txtWNName.Text = DataGridView1.Rows(vbEmpty).Cells(1).Value.ToString()
            NurseWardboy_Details.cmbCategory.Text = DataGridView1.Rows(vbEmpty).Cells(2).Value.ToString()
            NurseWardboy_Details.txtAddress.Text = DataGridView1.Rows(vbEmpty).Cells(3).Value.ToString()
            NurseWardboy_Details.txtContactNo.Text = DataGridView1.Rows(vbEmpty).Cells(4).Value.ToString()
            NurseWardboy_Details.txtEmail.Text = DataGridView1.Rows(vbEmpty).Cells(5).Value.ToString()
            NurseWardboy_Details.txtAge.Text = DataGridView1.Rows(vbEmpty).Cells(6).Value.ToString()

            NurseWardboy_Details.cmbGender.Text = DataGridView1.Rows(vbEmpty).Cells(7).Value.ToString()

            NurseWardboy_Details.cmbBG.Text = DataGridView1.Rows(vbEmpty).Cells(8).Value.ToString()
            NurseWardboy_Details.txtDate.Text = DataGridView1.Rows(vbEmpty).Cells(9).Value.ToString()

            NurseWardboy_Details.btnSave.Enabled = False

            NurseWardboy_Details.Show()
            NurseWardboy_Details.btnDelete.Enabled = True
            NurseWardboy_Details.btnUpdate.Enabled = True
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub NurseWardboyRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub txtPatientID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWNID.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("Select* from nurse_wardboy where ID Like '%" & txtWNID.Text & "%' ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "ID")
            myDA.Fill(myDataSet, "W_N_Name")
            myDA.Fill(myDataSet, "Category")
            myDA.Fill(myDataSet, "Address")
            myDA.Fill(myDataSet, "ContactNo")
            myDA.Fill(myDataSet, "Email")

            myDA.Fill(myDataSet, "Age")

            myDA.Fill(myDataSet, "Gender")
            myDA.Fill(myDataSet, "BG")
            myDA.Fill(myDataSet, "DateOfJoining")


            DataGridView1.DataSource = myDataSet.Tables("ID").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("W_N_Name").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Category").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Address").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ContactNo").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Email").DefaultView

            DataGridView1.DataSource = myDataSet.Tables("Age").DefaultView

            DataGridView1.DataSource = myDataSet.Tables("Gender").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("BG").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("DateOfJoining").DefaultView


            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class