Option Strict On
Option Explicit On

' Import MySQL Information
Imports MySql
Imports MySql.Data.MySqlClient

Public Class Welcome

    Dim MySQLConn As MySqlConnection
    Dim MySQLCmd As MySqlCommand

    Private Sub btn_Exit_Click(sender As System.Object, e As System.EventArgs) Handles btn_Exit.Click
        ' This button exit the program
        Me.Close()
    End Sub

    Private Sub btn_Add_Bidder_Click(sender As System.Object, e As System.EventArgs) Handles btn_Add_Bidder.Click
        ' This button switches the program to the Add a Bidder screen
        Add_Bidders.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Auction_Ctl_Click(sender As System.Object, e As System.EventArgs) Handles btn_Auction_Ctl.Click
        ' This button switches the program to the Auction Control and Auction Tape screens
        Auction_Tape.Show()
        Auction_Control.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Status_Click(sender As System.Object, e As System.EventArgs) Handles btn_Status.Click
        ' This button switches the program to the Bidder Status screen
        Bidder_Status.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Checkout_Click(sender As System.Object, e As System.EventArgs) Handles btn_Checkout.Click
        ' This button switches the program to the Bidder Checkout screen
        Bidder_Checkout.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Create_Tables_Click(sender As Object, e As EventArgs) Handles btn_Create_Tables.Click
        ' This button creates the tables required for the current year's auction


        MessageBox.Show("This button should only be clicked on one time.", "Reminder...", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Create and open a MySQL DB connection
        MySQLConn = New MySqlConnection
        MySQLCmd = New MySqlCommand

        MySQLConn.ConnectionString = "Server = " & ECARC_Program_Variables.Server_IP & "; User = " & ECARC_Program_Variables.User & "; Password = " & ECARC_Program_Variables.Password & "; Database = " & ECARC_Program_Variables.DB & ";"

        Try
            MySQLConn.Open()

            MySQLCmd.Connection = MySQLConn

            Try

                ' Setup Insert Query to create the Auction table for the current year
                Dim Insert_Query As String = "CREATE TABLE IF NOT EXISTS Auction_" & ECARC_Program_Variables.Year & " (Trans_ID int(11) NOT NULL AUTO_INCREMENT,Trans_Time time DEFAULT NULL,Lot_ID int(11) DEFAULT NULL,Description varchar(100) DEFAULT NULL,Bidder_ID int(11) DEFAULT NULL,
                Price decimal(8,2) DEFAULT NULL, PRIMARY KEY (Trans_ID),KEY Bidder_ID (Bidder_ID),FOREIGN KEY (Bidder_ID) REFERENCES Bidders_Temp (Bidder_ID) ON DELETE SET NULL ON UPDATE CASCADE) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;"

                MySQLCmd.CommandText = Insert_Query

                MySQLCmd.ExecuteNonQuery()

            Catch InsertError As Exception
                MessageBox.Show(InsertError.Message)
            End Try

        Catch ConnectionError As Exception
            MessageBox.Show(ConnectionError.Message)

        Finally

            MessageBox.Show("Successfully created Auction table for this year's auction.")

            MySQLConn.Close()
            MySQLConn.Dispose()
        End Try

        Try
            MySQLConn.Open()

            MySQLCmd.Connection = MySQLConn

            Try

                ' Setup Insert Query to create the Bidders table for the current year
                Dim Insert_Query2 As String = "CREATE TABLE IF NOT EXISTS Bidders_" & ECARC_Program_Variables.Year & " (Bidder_ID int(11) NOT NULL,Call_Sign varchar(10) DEFAULT NULL,Name varchar(50) DEFAULT NULL,Checked_Out char(1) DEFAULT NULL,
                Check_Out_Time time DEFAULT NULL,Mail_Invoice char(1) DEFAULT NULL,Comission_Amt decimal(4,2) DEFAULT NULL,PRIMARY KEY (Bidder_ID)) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;"

                MySQLCmd.CommandText = Insert_Query2

                MySQLCmd.ExecuteNonQuery()

            Catch InsertError As Exception
                MessageBox.Show(InsertError.Message)
            End Try

        Catch ConnectionError As Exception
            MessageBox.Show(ConnectionError.Message)

        Finally

            MessageBox.Show("Successfully created Bidders table for this year's auction.")

            MySQLConn.Close()
            MySQLConn.Dispose()
        End Try

    End Sub
End Class