Option Strict On
Option Explicit On

Imports MySql
Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click

        Dim LoginFail As Boolean = False

        ECARC_Program_Variables.Server_IP = txtServerIP.Text
        ECARC_Program_Variables.User = txtUser.Text
        ECARC_Program_Variables.Password = txtPassword.Text
        ECARC_Program_Variables.DB = txtDatabase.Text

        If txtServerIP.Text = "" And txtUser.Text = "" And txtPassword.Text = "" And txtDatabase.Text = "" Then
            MessageBox.Show("Login information is required for the program to run.", "Please provide MySQL login information!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblServerIP.ForeColor = Color.Red
            lblUser.ForeColor = Color.Red
            lblPassword.ForeColor = Color.Red
            lblDB.ForeColor = Color.Red
            txtServerIP.Focus()
            LoginFail = True
        ElseIf txtUser.Text = "" And txtPassword.Text = "" And txtDatabase.Text = "" Then
            MessageBox.Show("Login information is required for the program to run.", "Please provide MySQL login information!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblUser.ForeColor = Color.Red
            lblPassword.ForeColor = Color.Red
            lblDB.ForeColor = Color.Red
            txtUser.Focus()
            LoginFail = True
        ElseIf txtPassword.Text = "" And txtDatabase.Text = "" Then
            MessageBox.Show("Login information is required for the program to run.", "Please provide MySQL login information!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblPassword.ForeColor = Color.Red
            lblDB.ForeColor = Color.Red
            txtPassword.Focus()
            LoginFail = True
        ElseIf txtDatabase.Text = "" Then
            MessageBox.Show("Login information is required for the program to run.", "Please provide MySQL login information!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblDB.ForeColor = Color.Red
            txtDatabase.Focus()
            LoginFail = True
        Else

            Dim MySQLConn As MySqlConnection
            Dim MySQLCmd As MySqlCommand

            MySQLConn = New MySqlConnection
            MySQLCmd = New MySqlCommand

            MySQLConn.ConnectionString = "Server = " & ECARC_Program_Variables.Server_IP & "; User = " & ECARC_Program_Variables.User & "; Password = " & ECARC_Program_Variables.Password & "; Database = " & ECARC_Program_Variables.DB & ";"

            Try
                MySQLConn.Open()
                MySQLCmd.Connection = MySQLConn
            Catch LoginError As Exception
                MessageBox.Show(LoginError.Message)
                LoginFail = True
            Finally
                MySQLConn.Close()
                MySQLConn.Dispose()
            End Try
        End If

        If LoginFail.Equals(False) Then

            Welcome.Show()
            Me.Hide()

        End If

        ' The line of code below is for DEBUGGING only
        ' MessageBox.Show("IP: " & ECARC_Program_Variables.Server_IP & " User: " & ECARC_Program_Variables.User & " Pass: " & ECARC_Program_Variables.Password)
        ' The line of code above is for DEBUGGING only

    End Sub


    Private Sub txtServerIP_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtServerIP.TextChanged
        lblServerIP.ForeColor = Color.Black
    End Sub

    Private Sub txtUser_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUser.TextChanged
        lblUser.ForeColor = Color.Black
    End Sub

    Private Sub txtPassword_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPassword.TextChanged
        lblPassword.ForeColor = Color.Black
    End Sub

    Private Sub txtDatabase_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDatabase.TextChanged
        lblDB.ForeColor = Color.Black
    End Sub
End Class