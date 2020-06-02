Imports System.Data.OleDb

Public Class Login
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As OleDbCommand = Nothing
    Dim dt As New DataTable




    Private Property mistake As Object

    Private Property cmd As Object



    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub btnSingIn_Click(sender As Object, e As EventArgs) Handles btnSingIn.Click

        If Len(Trim(txtUsername.Text)) = 0 Then
            MessageBox.Show("Please enter Username ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsername.Focus()
            Exit Sub
        End If

        If Len(Trim(txtPasword.Text)) = 0 Then
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
            Dim cp As String = "select Username,User_Password from registration where Username='" & txtUsername.Text & "' And User_Password='" & txtPasword.Text & "'"
            cmd = New OleDbCommand(cp)
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            If Not rdr.Read Then
                MessageBox.Show("Incorrect Password. Please enter a valid Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPasword.Text = ""
                txtPasword.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            Dim ct As String = "select Username,User_Password from registration where UserName='" & txtUsername.Text & "' and User_Password='" & txtPasword.Text & "'"
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

    Private Sub txtPasword_Click(sender As Object, e As EventArgs) Handles txtPasword.Click
        txtPasword.Text = ""
        Panel1.BackColor = Color.FromArgb(78, 184, 206)
        txtPasword.ForeColor = Color.FromArgb(78, 184, 206)

        Panel2.BackColor = Color.WhiteSmoke
        txtUsername.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        txtUsername.Text = ""
        Panel1.BackColor = Color.FromArgb(78, 184, 206)
        txtUsername.ForeColor = Color.FromArgb(78, 184, 206)

        Panel2.BackColor = Color.WhiteSmoke
        txtPasword.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub lblClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblClose.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Registration.Show()
        Me.Hide()
    End Sub
End Class
