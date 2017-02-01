Option Strict On
Option Explicit On

' Import MySQL Information
Imports MySql
Imports MySql.Data.MySqlClient

Public Class Auction_Control

    ' Initialize Variables
    Dim Lot_Num As String
    Dim Description As String
    Dim Bidder_Num As String
    Dim Price As String
    Dim MySQLConn As MySqlConnection
    Dim MySQLCmd As MySqlCommand


    Private Sub btn_Add_to_DB_Click(sender As System.Object, e As System.EventArgs) Handles btn_Add_to_DB.Click
        ' This button adds the form data to the database

        ' Acquire the form data
        Lot_Num = txt_Lot_Num.Text
        Description = txt_Description.Text
        Bidder_Num = txt_Win_Bidder.Text
        Price = txt_Final_Price.Text

        ' Checking if any of the form fields are empty
        If Lot_Num = "" Or Bidder_Num = "" Or Price = "" Then
            MessageBox.Show("Required auction information is missing.", "Information missing!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            ' Message box is for debugging purposes only
            MessageBox.Show("Lot Number : " & Lot_Num & vbNewLine &
                            "Description : " & Description & vbNewLine &
                            "Bidder Number : " & Bidder_Num & vbNewLine &
                            "Price : $" & Price)

            ' Create and open a MySQL DB connection
            MySQLConn = New MySqlConnection
            MySQLCmd = New MySqlCommand

            MySQLConn.ConnectionString = "Server = " & ECARC_Program_Variables.Server_IP & "; User = " & ECARC_Program_Variables.User & "; Password = " & ECARC_Program_Variables.Password & "; Database = " & ECARC_Program_Variables.DB & ";"

            Try
                MySQLConn.Open()

                MySQLCmd.Connection = MySQLConn

                Try

                    Dim Checkout_Status_Query As String = "SELECT Checked_Out FROM Bidders_" & ECARC_Program_Variables.Year & " WHERE Bidder_ID = " & Bidder_Num & ";"

                    Dim Checkout_Status_Cmd = New MySqlCommand(Checkout_Status_Query, MySQLConn)

                    Dim Checkout_Status_DataAdapter As New MySqlDataAdapter(Checkout_Status_Query, MySQLConn)

                    Dim Checkout_Status_DataSet As New DataSet()

                    Checkout_Status_DataAdapter.Fill(Checkout_Status_DataSet, "Checkout_Data")

                    If Checkout_Status_DataSet.Tables(0).Rows.Count > 1 Then
                        MessageBox.Show("Error: Bidder has already checked out.", "ALERT!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    Else

                        ' Setup Insert Query for the Auction Item
                        Dim Insert_Query As String = "INSERT INTO Auction_" & ECARC_Program_Variables.Year & " (Trans_Time, Lot_ID, Description, Bidder_ID, Price) VALUES ('" & DateAndTime.TimeOfDay & "', '" & Lot_Num & "','" & Description & "','" & Bidder_Num & "','" & Price & "');"

                        MySQLCmd.CommandText = Insert_Query

                        MySQLCmd.ExecuteNonQuery()

                        ' Message box is for debugging
                        ' MessageBox.Show("Auctioned item successfully added.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Refresh the data grid view on the Auction_Tape window
                        Auction_Tape.btn_Refresh.PerformClick()

                        txt_Lot_Num.Clear()
                        txt_Description.Clear()
                        txt_Win_Bidder.Clear()
                        txt_Final_Price.Clear()

                        txt_Lot_Num.Focus()


                    End If

                Catch InsertError As Exception
                    MessageBox.Show(InsertError.Message)
                End Try

            Catch ConnectionError As Exception
                MessageBox.Show(ConnectionError.Message)

            Finally
                MySQLConn.Close()
                MySQLConn.Dispose()
            End Try

        End If

    End Sub

    Private Sub btn_Clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_Clear.Click
        ' This button clears the form
        txt_Lot_Num.Clear()
        txt_Description.Clear()
        txt_Win_Bidder.Clear()
        txt_Final_Price.Clear()
    End Sub

    Private Sub btn_Main_Click(sender As System.Object, e As System.EventArgs) Handles btn_Main.Click
        Welcome.Show()
        Me.Close()
        Auction_Tape.Close()
    End Sub
End Class