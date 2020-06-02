Imports System.Data.OleDb

Public Class Registration
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As OleDbCommand = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable

    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Len(Trim(txtName.Text)) = 0 Then
            MessageBox.Show("please enter name of user", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
            Exit Sub
        End If


        If Len(Trim(txtusername.Text)) = 0 Then
            MessageBox.Show("please enter username", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Focus()
            Exit Sub
        End If


        If Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("please enter password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If


        If Len(Trim(txtrepass.Text)) = 0 Then
            MessageBox.Show("please confirm password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtrepass.Focus()
            Exit Sub
        End If

        If txtrepass.Text <> txtPassword.Text Then
            MessageBox.Show("Password didn't match", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If



        If Len(Trim(txtEmail.Text)) = 0 Then
            MessageBox.Show("please enter contact no", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Exit Sub
        End If


        If Len(Trim(txtContactNo.Text)) = 0 Then
            MessageBox.Show("please enter email", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContactNo.Focus()
            Exit Sub
        End If



        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = " select Name from registration where Name= ' " & txtName.Text & " '"
            Dim cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then


                MessageBox.Show("Record  already exists", " input error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtName.Text = ""
                txtName.Focus()

                If Not rdr Is Nothing Then
                    rdr.Close()

                End If

                Exit Sub
            End If





            con = New OleDbConnection(cs)
            con.Open()
            
            Dim cb As String = " insert into registration (Name, Username, User_Password , RePass, Email, ContactNo ) values ( '" & txtName.Text & "', '" & txtusername.Text & "', '" & txtPassword.Text & "' ,     '" & txtrepass.Text & "' , '" & txtEmail.Text & "'   ,  '" & txtContactNo.Text & "' )"


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
        If Len(Trim(txtName.Text)) = 0 Then
            MessageBox.Show("please enter name of user", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
            Exit Sub
        End If


        If Len(Trim(txtusername.Text)) = 0 Then
            MessageBox.Show("please enter username", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtusername.Focus()
            Exit Sub
        End If


        If Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("please enter password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If


        If Len(Trim(txtrepass.Text)) = 0 Then
            MessageBox.Show("please confirm password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtrepass.Focus()
            Exit Sub
        End If

        If txtrepass.Text <> txtPassword.Text Then
            MessageBox.Show("Password didn't match", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If



        If Len(Trim(txtEmail.Text)) = 0 Then
            MessageBox.Show("please enter contact no", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Exit Sub
        End If


        If Len(Trim(txtContactNo.Text)) = 0 Then
            MessageBox.Show("please enter email", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtContactNo.Focus()
            Exit Sub
        End If

        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select Name from registration where Name='" & txtName.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If Not rdr.Read Then
                txtName.SelectAll()
                MessageBox.Show("Record do not exist", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update registration set Username='" & txtusername.Text & "', User_Password='" & txtPassword.Text & "', RePass='" & txtrepass.Text & "',Email='" & txtEmail.Text & "', ContactNo='" & txtContactNo.Text & "'     where Name= '" & txtName.Text & "'"
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
        txtName.Text = ""
        txtusername.Text = ""
        txtPassword.Text = ""
        txtrepass.Text = ""
        txtEmail.Text = ""
        txtContactNo.Text = ""

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
            Dim cq As String = "Delete from registration where Name='" & txtName.Text & "'"
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
        Record.Show()
        Me.Hide()
    End Sub

    Private Sub Registration_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        MainForm.Show()
        Me.Close()
    End Sub
End Class