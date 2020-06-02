Imports System.Data.OleDb
Public Class Ward
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As OleDbCommand = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable


    Sub GetData()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("Select * from ward ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "WardName")
            myDA.Fill(myDataSet, "WardType")
            myDA.Fill(myDataSet, "NoOfBeds")
            myDA.Fill(myDataSet, "Charge")




            DataGridView1.DataSource = myDataSet.Tables("WardName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("WardType").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("NoOfBeds").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Charge").DefaultView


            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Ward_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbWardType.Items.Add("General")
        cmbWardType.Items.Add("Special")
        GetData()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtWardName.Text)) = 0 Then
            MessageBox.Show("please enter name ward name", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtWardName.Focus()
            Exit Sub
        End If


        If Len(Trim(cmbWardType.Text)) = 0 Then
            MessageBox.Show("please enter ward type", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbWardType.Focus()
            Exit Sub
        End If


        If Len(Trim(txtNoBed.Text)) = 0 Then
            MessageBox.Show("please enter no of beds", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNoBed.Focus()
            Exit Sub
        End If


        If Len(Trim(txtChanges.Text)) = 0 Then
            MessageBox.Show("please confirm charges", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtChanges.Focus()
            Exit Sub
        End If

        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = " select WardName from ward where WardName= ' " & txtWardName.Text & " '"
            Dim cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then


                MessageBox.Show("Record  already exists", " input error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtWardName.Text = ""
                txtWardName.Focus()

                If Not rdr Is Nothing Then
                    rdr.Close()

                End If

                Exit Sub
            End If





            con = New OleDbConnection(cs)
            con.Open()


            Dim cb As String = " insert into ward (WardName, WardType, NoOfBeds , Charge) values ( '" & txtWardName.Text & "', '" & cmbWardType.Text & "' ,     '" & txtNoBed.Text & "' , '" & txtChanges.Text & "' )"


            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("record saved saccesfully ", " input record ", MessageBoxButtons.OK, MessageBoxIcon.Information)


            Reset()
            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.txtWardName.Text = DataGridView1.Rows(vbEmpty).Cells(0).Value.ToString()
            Me.cmbWardType.Text = DataGridView1.Rows(vbEmpty).Cells(1).Value.ToString()
            Me.txtNoBed.Text = DataGridView1.Rows(vbEmpty).Cells(2).Value.ToString()
            Me.txtChanges.Text = DataGridView1.Rows(vbEmpty).Cells(3).Value.ToString()




        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub txtWardNameS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWardNameS.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("Select* from ward where WardName Like '%" & txtWardNameS.Text & "%' ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "WardName")
            myDA.Fill(myDataSet, "WardType")
            myDA.Fill(myDataSet, "NoOfBeds")
            myDA.Fill(myDataSet, "Charge")




            DataGridView1.DataSource = myDataSet.Tables("WardName").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("WardType").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("NoOfBeds").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("Charge").DefaultView


            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select WardName from ward where WardName='" & txtWardName.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If Not rdr.Read Then
                txtWardName.SelectAll()
                MessageBox.Show("Record do not exist", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update ward set WardType='" & cmbWardType.Text & "', NoOfBeds='" & txtNoBed.Text & "', Charge='" & txtChanges.Text & "'      where WardName= '" & txtWardName.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "Delete from ward where WardName='" & txtWardName.Text & "'"
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'fillProductName()
                GetData()
                'fillCategory()
                'fillPartyname()
                'Reset()
            Else
                MessageBox.Show("No record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Reset()
                If con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.txtWardName.Text = DataGridView1.Rows(vbEmpty).Cells(0).Value.ToString()
            Me.cmbWardType.Text = DataGridView1.Rows(vbEmpty).Cells(1).Value.ToString()
            Me.txtNoBed.Text = DataGridView1.Rows(vbEmpty).Cells(2).Value.ToString()
            Me.txtChanges.Text = DataGridView1.Rows(vbEmpty).Cells(3).Value.ToString()

            Me.btnSave.Enabled = False

            Me.Show()
            Me.btnDelete.Enabled = True
            Me.btnUpdate.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtWardName.Text = ""
        cmbWardType.Text = ""
        txtChanges.Text = ""
        txtNoBed.Text = ""

        Me.btnSave.Enabled = True

        Me.Show()
        Me.btnDelete.Enabled = False
        Me.btnUpdate.Enabled = False
    End Sub
End Class