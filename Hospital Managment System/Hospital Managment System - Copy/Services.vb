Imports System.Data.OleDb

Public Class Services
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As OleDbCommand = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtServiceName.Text)) = 0 Then
            MessageBox.Show("please enter service name", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtServiceName.Focus()
            Exit Sub
        End If


        If Len(Trim(txtServiceDate.Text)) = 0 Then
            MessageBox.Show("please enter service date", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtServiceDate.Focus()
            Exit Sub
        End If


        If Len(Trim(txtPatientID.Text)) = 0 Then
            MessageBox.Show("please enter patient id", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPatientID.Focus()
            Exit Sub
        End If


        If Len(Trim(txtPatientName.Text)) = 0 Then
            MessageBox.Show("please enter patient name", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPatientName.Focus()
            Exit Sub
        End If

        If Len(Trim(txtServiceCharge.Text)) = 0 Then
            MessageBox.Show("please enter service charges", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtServiceCharge.Focus()
            Exit Sub
        End If

        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = " select ServiceName from services where ServiceName= ' " & txtServiceName.Text & " '"
            Dim cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then


                MessageBox.Show("Record  already exists", " input error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtServiceName.Text = ""
                txtServiceName.Focus()

                If Not rdr Is Nothing Then
                    rdr.Close()

                End If

                Exit Sub
            End If





            con = New OleDbConnection(cs)
            con.Open()


            Dim cb As String = " insert into services (ServiceName, ServiceDate, PatientID ,PatientName ,ServiceCharges) values ( '" & txtServiceName.Text & "', '" & txtServiceDate.Text & "' ,     '" & txtPatientID.Text & "' ,   '" & txtPatientName.Text & "' ,     '" & txtServiceCharge.Text & "')"


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

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtServiceName.Text = ""
        txtServiceDate.Text = ""
        txtPatientID.Text = ""
        txtPatientName.Text = ""
        txtServiceCharge.Text = ""


        Me.btnSave.Enabled = True

        Me.Show()
        Me.btnDelete.Enabled = False
        Me.btnUpdate.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select ServiceName from services where ServiceName='" & txtServiceName.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If Not rdr.Read Then
                txtPatientID.SelectAll()
                MessageBox.Show("Record do not exist", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update services set ServiceDate='" & txtServiceDate.Text & "', PatientID='" & txtPatientID.Text & "', PatientName='" & txtPatientName.Text & "',ServiceCharges='" & txtServiceCharge.Text & "'    where ServiceName= '" & txtServiceName.Text & "'"
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
            Dim cq As String = "Delete from services where ServiceName='" & txtServiceName.Text & "'"
            cmd = New OleDbCommand(cq)
            cmd.Connection = con
            RowsAffected = cmd.ExecuteNonQuery()
            If RowsAffected > 0 Then
                MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'fillProductName()
                'GetData()
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

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        ServicesRecord.Show()
    End Sub
End Class