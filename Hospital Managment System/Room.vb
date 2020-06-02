Imports System.Data.OleDb

Public Class Room
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
            cmd = New OleDbCommand("Select * from room ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "RoomNo")
            myDA.Fill(myDataSet, "RoomType")
            myDA.Fill(myDataSet, "RoomCharges")
            myDA.Fill(myDataSet, "RoomStatus")




            DataGridView1.DataSource = myDataSet.Tables("RoomNo").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("RoomType").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("RoomCharges").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("RoomStatus").DefaultView


            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtRoomNo.Text)) = 0 Then
            MessageBox.Show("please enter room no", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRoomNo.Focus()
            Exit Sub
        End If


        If Len(Trim(cmbRoomType.Text)) = 0 Then
            MessageBox.Show("please enter room type", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbRoomType.Focus()
            Exit Sub
        End If


        If Len(Trim(txtCharges.Text)) = 0 Then
            MessageBox.Show("please enter Charges", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCharges.Focus()
            Exit Sub
        End If


        If Len(Trim(txtStatus.Text)) = 0 Then
            MessageBox.Show("please Status", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtStatus.Focus()
            Exit Sub
        End If

        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = " select RoomNo from room where RoomNo= ' " & txtRoomNo.Text & " '"
            Dim cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then


                MessageBox.Show("Record  already exists", " input error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtRoomNo.Text = ""
                txtRoomNo.Focus()

                If Not rdr Is Nothing Then
                    rdr.Close()

                End If

                Exit Sub
            End If





            con = New OleDbConnection(cs)
            con.Open()


            Dim cb As String = " insert into room (RoomNo, RoomType, RoomCharges ,RoomStatus) values ( '" & txtRoomNo.Text & "', '" & cmbRoomType.Text & "' , '" & txtCharges.Text & "' , '" & txtStatus.Text & "' )"


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

    Private Sub Room_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbRoomType.Items.Add("General")
        cmbRoomType.Items.Add("Deluxe")
        GetData()
    End Sub

    Private Sub txtRoomNameS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRoomNameS.TextChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("Select * from room where RoomNo Like '%" & txtRoomNameS.Text & "%' ", con)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, "RoomNo")
            myDA.Fill(myDataSet, "RoomType")
            myDA.Fill(myDataSet, "RoomCharges")
            myDA.Fill(myDataSet, "RoomStatus")




            DataGridView1.DataSource = myDataSet.Tables("RoomNo").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("RoomType").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("RoomCharges").DefaultView
            DataGridView1.DataSource = myDataSet.Tables("RoomStatus").DefaultView


            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

  

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select RoomNo from room where RoomNo='" & txtRoomNo.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If Not rdr.Read Then
                txtRoomNo.SelectAll()
                MessageBox.Show("Record do not exist", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update room set RoomType='" & cmbRoomType.Text & "', RoomCharges='" & txtCharges.Text & "', RoomStatus='" & txtStatus.Text & "'      where RoomNo= '" & txtRoomNo.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtRoomNo.Text = ""
        cmbRoomType.Text = ""
        txtCharges.Text = ""
        txtStatus.Text = ""

        Me.btnSave.Enabled = True

        Me.Show()
        Me.btnDelete.Enabled = False
        Me.btnUpdate.Enabled = False
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            Me.txtRoomNo.Text = DataGridView1.Rows(vbEmpty).Cells(0).Value.ToString()
            Me.cmbRoomType.Text = DataGridView1.Rows(vbEmpty).Cells(1).Value.ToString()
            Me.txtCharges.Text = DataGridView1.Rows(vbEmpty).Cells(2).Value.ToString()
            Me.txtStatus.Text = DataGridView1.Rows(vbEmpty).Cells(3).Value.ToString()

            Me.btnSave.Enabled = False

            Me.Show()
            Me.btnDelete.Enabled = True
            Me.btnUpdate.Enabled = True

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Room_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "Delete from room where RoomNo='" & txtRoomNo.Text & "'"
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

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click

        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class