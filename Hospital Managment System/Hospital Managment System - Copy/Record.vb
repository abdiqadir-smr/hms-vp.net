Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu
Imports System.Data.OleDb

Public Class Record
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
            cmd = New OleDbCommand("Select* from registration ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Name")
            myDA.Fill(myDataSet, "Username")
            myDA.Fill(myDataSet, "User_Password")
            myDA.Fill(myDataSet, "RePass")
            myDA.Fill(myDataSet, "Email")
            myDA.Fill(myDataSet, "ContactNo")


            DataGridView1.DataSource = myDataSet.Tables("Name").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Username").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("User_Password").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("RePass").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Email").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ContactNo").DefaultView


            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Registration.txtName.Text = DataGridView1.Rows(vbEmpty).Cells(0).Value.ToString()
            Registration.txtusername.Text = DataGridView1.Rows(vbEmpty).Cells(1).Value.ToString()
            Registration.txtPassword.Text = DataGridView1.Rows(vbEmpty).Cells(2).Value.ToString()
            Registration.txtrepass.Text = DataGridView1.Rows(vbEmpty).Cells(3).Value.ToString()
            Registration.txtEmail.Text = DataGridView1.Rows(vbEmpty).Cells(4).Value.ToString()
            Registration.txtContactNo.Text = DataGridView1.Rows(vbEmpty).Cells(5).Value.ToString()

            Registration.btnSave.Enabled = False

            Registration.Show()
            Registration.btnDelete.Enabled = True
            Registration.btnUpdate.Enabled = True
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Record_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
    End Sub

    Private Sub txtServiceID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServiceID.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("Select* from registration where Name Like '%" & txtServiceID.Text & "%' ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "Name")
            myDA.Fill(myDataSet, "Username")
            myDA.Fill(myDataSet, "User_Password")
            myDA.Fill(myDataSet, "RePass")
            myDA.Fill(myDataSet, "Email")
            myDA.Fill(myDataSet, "ContactNo")


            DataGridView1.DataSource = myDataSet.Tables("Name").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Username").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("User_Password").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("RePass").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Email").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("ContactNo").DefaultView


            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class