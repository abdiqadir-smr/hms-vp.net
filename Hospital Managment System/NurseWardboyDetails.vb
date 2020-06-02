Imports System.Data.OleDb

Public Class NurseWardboy_Details
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cmd As OleDbCommand

    Private Sub NurseWardboy_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbCategory.Items.Add("Nurse")
        cmbCategory.Items.Add("WardBoy")
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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtWNID.Text)) = 0 Then
            MessageBox.Show("please enter nusre or wardboy  id", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtWNID.Focus()
            Exit Sub
        End If


        If Len(Trim(txtWNName.Text)) = 0 Then
            MessageBox.Show("please enter nusre or ward name", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtWNName.Focus()
            Exit Sub
        End If

        If Len(Trim(cmbCategory.Text)) = 0 Then
            MessageBox.Show("please enter category", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbCategory.Focus()
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

        If Len(Trim(txtEmail.Text)) = 0 Then
            MessageBox.Show("please enter Email", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
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
            MessageBox.Show("please enter date", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDate.Focus()
            Exit Sub
        End If



        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = " select ID from nurse_wardboy where ID= ' " & txtWNID.Text & " '"
            Dim cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then


                MessageBox.Show("Record  already exists", " input error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtWNID.Text = ""
                txtWNID.Focus()

                If Not rdr Is Nothing Then
                    rdr.Close()

                End If

                Exit Sub
            End If





            con = New OleDbConnection(cs)
            con.Open()


            Dim cb As String = " insert into nurse_wardboy (ID, W_N_Name, Category , Address , ContactNo , Email , Age, Gender, BG, DateOfJoining ) values ( '" & txtWNID.Text & "', '" & txtWNName.Text & "' , '" & cmbCategory.Text & "' , '" & txtAddress.Text & "' , '" & txtContactNo.Text & "' , '" & txtEmail.Text & "' , '" & txtAge.Text & "' , '" & cmbGender.Text & "'   ,  '" & cmbBG.Text & "' , '" & txtDate.Text & "'  )"


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
        If Len(Trim(txtWNID.Text)) = 0 Then
            MessageBox.Show("please enter nusre or wardboy  id", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtWNID.Focus()
            Exit Sub
        End If


        If Len(Trim(txtWNName.Text)) = 0 Then
            MessageBox.Show("please enter nusre or ward name", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtWNName.Focus()
            Exit Sub
        End If

        If Len(Trim(cmbCategory.Text)) = 0 Then
            MessageBox.Show("please enter category", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbCategory.Focus()
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

        If Len(Trim(txtEmail.Text)) = 0 Then
            MessageBox.Show("please enter Email", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
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
            MessageBox.Show("please enter date", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDate.Focus()
            Exit Sub
        End If

        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select ID from nurse_wardboy where ID='" & txtWNID.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If Not rdr.Read Then
                txtWNID.SelectAll()
                MessageBox.Show("Record do not exist", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update nurse_wardboy set W_N_Name='" & txtWNName.Text & "', Category='" & cmbCategory.Text & "', Address='" & txtAddress.Text & "',ContactNo='" & txtContactNo.Text & "',Email='" & txtEmail.Text & "', Age='" & txtAge.Text & "', Gender='" & cmbGender.Text & "', BG='" & cmbBG.Text & "' ,DateOfJoining='" & txtDate.Text & "'      where ID= '" & txtWNID.Text & "'"
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
            Dim cq As String = "Delete from nurse_wardboy where ID='" & txtWNID.Text & "'"
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

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtWNID.Text = ""
        txtWNName.Text = ""
        cmbCategory.Text = ""
        txtAddress.Text = ""
        txtContactNo.Text = ""
        txtEmail.Text = ""
        txtAge.Text = ""
        cmbGender.Text = ""
        cmbBG.Text = ""
        txtDate.Text = ""

        Me.btnSave.Enabled = True

        Me.Show()
        Me.btnDelete.Enabled = False
        Me.btnUpdate.Enabled = False
    End Sub

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NurseWardboyRecord.Show()
        Me.Hide()
    End Sub

    Private Sub NurseWardboy_Details_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        NurseWardboyRecord.Show()
        Me.Hide()
    End Sub
End Class