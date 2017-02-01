Option Strict On
Option Explicit On

' Import the MySQL information
Imports MySql
Imports MySQL.Data.MySQLClient

Public Class Add_Bidders

    Dim MySQLConn As MySqlConnection
    Dim MySQLCmd As MySqlCommand
    Dim MySQLDataAdapter As MySqlDataAdapter
    Dim MySQLDataSet As DataSet

    Dim Bidder_Exists As Boolean

    ' Initialize variables needed for this screen
    Dim Bidder_Num As String = ""
    Dim Bidder_Name As String = ""
    Dim Bidder_Call As String = ""

    Private Sub btn_Clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_Clear.Click

        ' This button clears the form
        txtBidNum.Clear()
        txtBidName.Clear()
        txtBidCall.Clear()

    End Sub

    Private Sub btn_Main_Click(sender As System.Object, e As System.EventArgs) Handles btn_Main.Click

        ' This button closes this screen and switched the program to the Welcome screen
        Welcome.Show()
        Me.Close()

    End Sub

    Private Sub btn_Add_Bidder_Click(sender As System.Object, e As System.EventArgs) Handles btn_Add_Bidder.Click

        ' This button Adds a bidder to the Database

        Bidder_Num = txtBidNum.Text
        Bidder_Name = txtBidName.Text
        Bidder_Call = txtBidCall.Text

        If Bidder_Num = "" Then
            MessageBox.Show("A bidder number has not been entered! Please try again.", "No bidder number given...", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblBidderNum.ForeColor = Color.Red
            txtBidNum.Focus()
        ElseIf Bidder_Name = "" And Bidder_Call = "" Then
            MessageBox.Show("Bidder number given, however Callsign and name are empty...", "Missing Information...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            lblBidderName.ForeColor = Color.Firebrick
            lblBidderCall.ForeColor = Color.Firebrick
        Else
            MessageBox.Show("Bidder # : " & Bidder_Num & " Callsign : " & Bidder_Call & " Bidder Name : " & Bidder_Name, "Confirm Bidder", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            MySQLConn = New MySqlConnection
            MySQLCmd = New MySqlCommand

            MySQLConn.ConnectionString = "Server = " & ECARC_Program_Variables.Server_IP & "; User = " & ECARC_Program_Variables.User & "; Password = " & ECARC_Program_Variables.Password & "; Database = " & ECARC_Program_Variables.DB & ";"

            Try
                MySQLConn.Open()

                'MessageBox.Show("Connection to the MySQL Server as IP : " & ECARC_Program_Variables.Server_IP & " and Database : " & ECARC_Program_Variables.DB & " is successful.")

                MySQLCmd.Connection = MySQLConn

                Try
                    Dim Insert_Query As String = "INSERT INTO Bidders_" & ECARC_Program_Variables.Year & " (Bidder_ID,Call_Sign,Name) VALUES ('" & Bidder_Num & "', '" & Bidder_Call & "','" & Bidder_Name & "');"

                    MySQLCmd.CommandText = Insert_Query

                    MySQLCmd.ExecuteNonQuery()

                    'MySQLConn.Close()

                    MessageBox.Show("Bidder successfully added!", "Information...", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch SQLError As Exception

                    MessageBox.Show(SQLError.Message)

                    MessageBox.Show("Error: Unable to insert new bidder!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally

                End Try

            Catch myerror As Exception
                MessageBox.Show(myerror.Message)
            Finally
                MySQLConn.Close()
                MySQLConn.Dispose()
            End Try

            txtBidNum.Clear()
            txtBidName.Clear()
            txtBidCall.Clear()

            txtBidNum.Focus()

        End If

    End Sub

    Private Sub txtBidNum_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBidNum.TextChanged
        lblBidderNum.ForeColor = Color.Black
    End Sub

    Private Sub txtBidName_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBidName.TextChanged
        lblBidderName.ForeColor = Color.Black
        lblBidderCall.ForeColor = Color.Black
    End Sub

    Private Sub txtBidCall_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBidCall.TextChanged
        lblBidderCall.ForeColor = Color.Black
        lblBidderName.ForeColor = Color.Black
    End Sub
End Class