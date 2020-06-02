Imports System.Data.OleDb

Public Class Patient
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cmd As OleDbCommand

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
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

        If Len(Trim(txtFatherName.Text)) = 0 Then
            MessageBox.Show("please enter father name", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFatherName.Focus()
            Exit Sub
        End If

        If Len(Trim(txtAddress.Text)) = 0 Then
            MessageBox.Show("please enter address", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAddress.Focus()
            Exit Sub
        End If

        If Len(Trim(txtContactNo.Text)) = 0 Then
            MessageBox.Show("please enter cell phone ", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContactNo.Focus()
            Exit Sub
        End If

        If Len(Trim(txtAge.Text)) = 0 Then
            MessageBox.Show("please enter age", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAge.Focus()
            Exit Sub
        End If

        If Len(Trim(cmbGender.Text)) = 0 Then
            MessageBox.Show("please enter gender", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbGender.Focus()

            Exit Sub
        End If

        If Len(Trim(cmbBG.Text)) = 0 Then
            MessageBox.Show("please enter blood group ", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbBG.Focus()

            Exit Sub
        End If

        If Len(Trim(txtRemarks.Text)) = 0 Then
            MessageBox.Show("please enter remarks name", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRemarks.Focus()
            Exit Sub
        End If



        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = " select PatientID from patient where PatientID= ' " & txtPatientID.Text & " '"
            Dim cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then


                MessageBox.Show("Record  already exists", " input error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPatientID.Text = ""
                txtPatientID.Focus()

                If Not rdr Is Nothing Then
                    rdr.Close()

                End If

                Exit Sub
            End If





            con = New OleDbConnection(cs)
            con.Open()


            Dim cb As String = " insert into patient (PatientID, PatientName, FatherName , Address , ContactNo, Email , Age, Gender, BG, Remarks) values ( '" & txtPatientID.Text & "', '" & txtPatientName.Text & "' , '" & txtFatherName.Text & "' , '" & txtAddress.Text & "' , '" & txtContactNo.Text & "' , '" & txtEmail.Text & "' , '" & txtAge.Text & "' , '" & cmbGender.Text & "'   ,  '" & cmbBG.Text & "' , '" & txtRemarks.Text & "'  )"


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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
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

        If Len(Trim(txtFatherName.Text)) = 0 Then
            MessageBox.Show("please enter father name", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFatherName.Focus()
            Exit Sub
        End If

        If Len(Trim(txtAddress.Text)) = 0 Then
            MessageBox.Show("please enter address", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAddress.Focus()
            Exit Sub
        End If

        If Len(Trim(txtContactNo.Text)) = 0 Then
            MessageBox.Show("please enter cell phone ", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContactNo.Focus()
            Exit Sub
        End If

        If Len(Trim(txtAge.Text)) = 0 Then
            MessageBox.Show("please enter age", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAge.Focus()
            Exit Sub
        End If

        If Len(Trim(cmbGender.Text)) = 0 Then
            MessageBox.Show("please enter gender", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbGender.Focus()

            Exit Sub
        End If

        If Len(Trim(cmbBG.Text)) = 0 Then
            MessageBox.Show("please enter blood group ", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbBG.Focus()

            Exit Sub
        End If

        If Len(Trim(txtRemarks.Text)) = 0 Then
            MessageBox.Show("please enter remarks name", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRemarks.Focus()
            Exit Sub
        End If

        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select PatientID from patient where PatientID='" & txtPatientID.Text & "'"
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
            Dim cb As String = "update patient set PatientName='" & txtPatientName.Text & "', FatherName='" & txtFatherName.Text & "', Address='" & txtAddress.Text & "',ContactNo='" & txtContactNo.Text & "',Email='" & txtEmail.Text & "', Age='" & txtAge.Text & "', Gender='" & cmbGender.Text & "', BG='" & cmbBG.Text & "' ,Remarks='" & txtRemarks.Text & "'      where PatientID= '" & txtPatientID.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Patient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")
        cmbBG.Items.Add("O+")
        cmbBG.Items.Add("O-")
        cmbBG.Items.Add("A+")
        cmbBG.Items.Add("A-")
        cmbBG.Items.Add("B+")
        cmbBG.Items.Add("B-")
        cmbBG.Items.Add("AB+")
        cmbBG.Items.Add("AB-")
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtPatientID.Text = ""
        txtPatientName.Text = ""
        txtFatherName.Text = ""
        txtAddress.Text = ""
        txtContactNo.Text = ""
        txtEmail.Text = ""
        txtAge.Text = ""
        cmbGender.Text = ""
        cmbBG.Text = ""
        txtRemarks.Text = ""

        Me.btnSave.Enabled = True

        Me.Show()
        Me.btnDelete.Enabled = False
        Me.btnUpdate.Enabled = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "Delete from patient where PatientID='" & txtPatientID.Text & "'"
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
        PatientRecord.Show()
    End Sub
End Class