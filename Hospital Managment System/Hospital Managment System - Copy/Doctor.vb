Imports System.Data.OleDb

Public Class Doctor
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cmd As OleDbCommand

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If Len(Trim(txtDoctorID.Text)) = 0 Then
            MessageBox.Show("please enter doctor id", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDoctorID.Focus()
            Exit Sub
        End If


        If Len(Trim(txtDoctorName.Text)) = 0 Then
            MessageBox.Show("please enter doctor name", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDoctorName.Focus()
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

        If Len(Trim(txtSpecialization.Text)) = 0 Then
            MessageBox.Show("please enter specialization", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSpecialization.Focus()
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

        If Len(Trim(txtDate.Text)) = 0 Then
            MessageBox.Show("please enter date of joining", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDate.Focus()
            Exit Sub
        End If



        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = " select DoctorID from doctor where DoctorID= ' " & txtDoctorID.Text & " '"
            Dim cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then


                MessageBox.Show("Record  already exists", " input error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDoctorID.Text = ""
                txtDoctorID.Focus()

                If Not rdr Is Nothing Then
                    rdr.Close()

                End If

                Exit Sub
            End If





            con = New OleDbConnection(cs)
            con.Open()


            Dim cb As String = " insert into doctor (DoctorID, DoctorName, FatherName , Address , ContactNo, Email , Age, Specialization, Gender, BG, DataOfJoining ) values ( '" & txtDoctorID.Text & "', '" & txtDoctorName.Text & "' , '" & txtFatherName.Text & "' , '" & txtAddress.Text & "' , '" & txtContactNo.Text & "' , '" & txtEmail.Text & "' , '" & txtAge.Text & "' , '" & txtSpecialization.Text & "' , '" & cmbGender.Text & "'   ,  '" & cmbBG.Text & "' , '" & txtDate.Text & "'  )"


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

    Private Sub Doctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        txtDoctorID.Text = ""
        txtDoctorName.Text = ""
        txtFatherName.Text = ""
        txtAddress.Text = ""
        txtContactNo.Text = ""
        txtEmail.Text = ""
        txtAge.Text = ""
        txtSpecialization.Text = ""
        cmbGender.Text = ""
        cmbBG.Text = ""
        txtDate.Text = ""

        Me.btnSave.Enabled = True

        Me.Show()
        Me.btnDelete.Enabled = False
        Me.btnUpdate.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            If Len(Trim(txtDoctorID.Text)) = 0 Then
                MessageBox.Show("please enter doctor id", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDoctorID.Focus()
                Exit Sub
            End If


            If Len(Trim(txtDoctorName.Text)) = 0 Then
                MessageBox.Show("please enter doctor name", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDoctorName.Focus()
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

            If Len(Trim(txtSpecialization.Text)) = 0 Then
                MessageBox.Show("please enter specialization", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtSpecialization.Focus()
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

            If Len(Trim(txtDate.Text)) = 0 Then
                MessageBox.Show("please enter date of joining", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDate.Focus()
                Exit Sub
            End If


            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select DoctorID from doctor where DoctorID='" & txtDoctorID.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If Not rdr.Read Then
                txtDoctorID.SelectAll()
                MessageBox.Show("Record do not exist", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update doctor set DoctorName='" & txtDoctorName.Text & "', FatherName='" & txtFatherName.Text & "', Address='" & txtAddress.Text & "',ContactNo='" & txtContactNo.Text & "',Email='" & txtEmail.Text & "', Age='" & txtAge.Text & "', Specialization='" & txtSpecialization.Text & "', Gender='" & cmbGender.Text & "', BG='" & cmbBG.Text & "' ,DataOfJoining='" & txtDate.Text & "'      where DoctorID= '" & txtDoctorID.Text & "'"
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
            If MessageBox.Show("Do you really want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                DeleteRecord()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub DeleteRecord()
        Try
            Dim RowsAffected As Integer = 0
            con = New OleDbConnection(cs)
            con.Open()
            Dim cq As String = "Delete from doctor where DoctorID='" & txtDoctorID.Text & "'"
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
        Doctors_Record.Show()
    End Sub
End Class