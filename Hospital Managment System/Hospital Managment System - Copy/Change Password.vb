Imports System.Data.OleDb

Public Class Change_Password
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As OleDbCommand = Nothing
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Len(Trim(txtUserName.Text)) = 0 Then
            MessageBox.Show("please enter user name", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUserName.Focus()
            Exit Sub
        End If



        If Len(Trim(txtoldpass.Text)) = 0 Then
            MessageBox.Show("please enter old password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtoldpass.Focus()
            Exit Sub
        End If

        If Len(Trim(txtnewpass.Text)) = 0 Then
            MessageBox.Show("please enter new password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnewpass.Focus()
            Exit Sub
        End If


        If Len(Trim(txtrenewpass.Text)) = 0 Then
            MessageBox.Show("please enter confirm pass", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtrenewpass.Focus()
            Exit Sub
        End If




        If txtnewpass.Text <> txtrenewpass.Text Then
            MessageBox.Show("Password didn't match", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnewpass.Focus()
            Exit Sub
        End If




        'If Len(Trim(cmbRole.Text)) = 0 Then
        'MessageBox.Show("please enter role", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'cmbRole.Focus()
        'Exit Sub
        'End If


        '=======================================================================================


        Try

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select Username from registration where Username='" & txtUserName.Text & "' and User_Password='" & txtoldpass.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If Not rdr.Read Then
                txtUserName.SelectAll()
                txtoldpass.SelectAll()
                MessageBox.Show(" Username or Old password  Record do not exist", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update registration set User_Password='" & txtnewpass.Text & "', RePass='" & txtrenewpass.Text & "' where Username= '" & txtUserName.Text & "'"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteReader()
            MessageBox.Show("Password change Successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information)

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Change_Password_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.Show()
        Me.Hide()
    End Sub
End Class