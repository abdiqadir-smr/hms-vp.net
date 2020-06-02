Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Menu

Public Class Login
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As OleDbCommand = Nothing
    Dim dt As New DataTable




    Private Property mistake As Object

    Private Property cmd As Object

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        If Len(Trim(txtUsername.Text)) = 0 Then
            MessageBox.Show("Please enter Username ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Exit Sub
        End If

        If Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("Please enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
            Exit Sub
        End If





        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cu As String = "select Username from registration where Username='" & txtUsername.Text & "'"
            cmd = New OleDbCommand(cu)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If Not rdr.Read Then
                MessageBox.Show("Username do not exist. Please enter a valid User Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtUsername.Text = ""
                txtUsername.Focus()
                Exit Sub

            End If
            Dim cp As String = "select Username,User_Password from registration where Username='" & txtUsername.Text & "' And User_Password='" & txtPassword.Text & "'"
            cmd = New OleDbCommand(cp)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If Not rdr.Read Then
                MessageBox.Show("Incorrect Password. Please enter a valid Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Text = ""
                txtPassword.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select Username,User_Password from registration where UserName='" & txtUsername.Text & "' and User_Password='" & txtPassword.Text & "'"
            cmd = New OleDbCommand(ct)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If rdr.Read Then


                Welcome.Show()
                Me.Hide()
            Else

                Welcome.Show()
                Me.Hide()






                'MainForm.Show()
            End If

            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmdUserType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCancel.Click
        Me.Close()
    End Sub

    
End Class
