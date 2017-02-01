Option Strict On
Option Explicit On

Imports MySql.Data.MySqlClient

Public Class Auction_Tape

    ' Initialize MySQL variables
    Dim MySQLConn As MySqlConnection
    Dim MySQLCmd As MySqlCommand

    Private Sub btn_Refresh_Click(sender As System.Object, e As System.EventArgs) Handles btn_Refresh.Click

        ' This button refreshes the Auction Tape data view
        dtgd_Auction_Tape.DataSource = Nothing
        dtgd_Auction_Tape.DataMember = Nothing
        dtgd_Auction_Tape.Update()

        ' Activate the MySQL Connection and MySQL Command Protocols
        MySQLConn = New MySqlConnection
        MySQLCmd = New MySqlCommand

        MySQLConn.ConnectionString = "Server = " & ECARC_Program_Variables.Server_IP & "; User = " & ECARC_Program_Variables.User & "; Password = " & ECARC_Program_Variables.Password & "; Database = " & ECARC_Program_Variables.DB & ";"

        Try
            MySQLConn.Open()

            MySQLCmd.Connection = MySQLConn

            Dim Auction_Query As String = "SELECT * FROM Auction_" & ECARC_Program_Variables.Year & ";"

            Dim Auction_DataAdapter As New MySqlDataAdapter(Auction_Query, MySQLConn)
            Dim Auction_DataSet As New DataSet()

            Auction_DataAdapter.Fill(Auction_DataSet, "Auction_Data")

            dtgd_Auction_Tape.DataSource = Auction_DataSet
            dtgd_Auction_Tape.DataMember = "Auction_Data"

            Dim Auction_Items As String = CStr(Auction_DataSet.Tables(0).Rows.Count)

            Dim Auction_Total As String = "SELECT * FROM Auction_" & ECARC_Program_Variables.Year & ";"
            Dim Auction_Cmd = New MySqlCommand(Auction_Total, MySQLConn)
            Dim Auction_Reader As MySqlDataReader = Auction_Cmd.ExecuteReader()

            While Auction_Reader.Read
                Dim Buyer_Status_Current_Total As String = Auction_Reader.GetString(0)
            End While

            Auction_Reader.Close()

        Catch Buyer_Query_Error As Exception
            MessageBox.Show(Buyer_Query_Error.Message)
        End Try

    End Sub

    Private Sub Auction_Tape_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Activate the MySQL Connection and MySQL Command protocols
        MySQLConn = New MySqlConnection
        MySQLCmd = New MySqlCommand

        MySQLConn.ConnectionString = "Server = " & ECARC_Program_Variables.Server_IP & "; User = " & ECARC_Program_Variables.User & "; Password = " & ECARC_Program_Variables.Password & "; Database = " & ECARC_Program_Variables.DB & ";"

        Try
            MySQLConn.Open()

            MySQLCmd.Connection = MySQLConn

            Dim Auction_Query As String = "SELECT * FROM Auction_" & ECARC_Program_Variables.Year & ";"

            Dim Auction_DataAdapter As New MySqlDataAdapter(Auction_Query, MySQLConn)
            Dim Auction_DataSet As New DataSet()

            Auction_DataAdapter.Fill(Auction_DataSet, "Auction_Data")

            dtgd_Auction_Tape.DataSource = Auction_DataSet
            dtgd_Auction_Tape.DataMember = "Auction_Data"

            Dim Auction_Items As String = CStr(Auction_DataSet.Tables(0).Rows.Count)

            Dim Auction_Total As String = "SELECT * FROM Auction_" & ECARC_Program_Variables.Year & ";"
            Dim Auction_Cmd = New MySqlCommand(Auction_Total, MySQLConn)
            Dim Auction_Reader As MySqlDataReader = Auction_Cmd.ExecuteReader()

            While Auction_Reader.Read
                Dim Buyer_Status_Current_Total As String = Auction_Reader.GetString(0)
            End While

            Auction_Reader.Close()

        Catch Buyer_Query_Error As Exception
            MessageBox.Show(Buyer_Query_Error.Message)
        End Try

    End Sub

End Class