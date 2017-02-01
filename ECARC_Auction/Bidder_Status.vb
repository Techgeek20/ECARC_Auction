Option Strict On
Option Explicit On

Imports MySql.Data.MySqlClient

Public Class Bidder_Status

    ' Initialize variables needed for this window
    Dim Bidder_Num As String
    Dim Seller As Boolean

    ' Initialize the MySQL variables
    Dim MySQLConn As MySqlConnection
    Dim MySQLCmd As MySqlCommand


    Private Sub btn_Main_Click(sender As System.Object, e As System.EventArgs) Handles btn_Main.Click
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txt_Bidder.Clear()
        ckbx_Seller.Checked = False
        txt_Bidder.Focus()
        txt_Buyer_Items.Clear()
        txt_Buyer_Amt.Clear()
        txt_Seller_Items.Clear()
        txt_Seller_Amt.Clear()

        dtgd_Buyer.DataSource = Nothing
        dtgd_Buyer.DataMember = Nothing
        dtgd_Buyer.Update()

        dtgd_Seller.DataSource = Nothing
        dtgd_Seller.DataMember = Nothing
        dtgd_Seller.Update()

        txt_Checkout_Status.Clear()
        txt_Checkout_Status.ForeColor = Color.Black
        txt_Checkout_Status.BackColor = Color.White

    End Sub

    Private Sub btn_Status_Check_Click(sender As System.Object, e As System.EventArgs) Handles btn_Status_Check.Click

        dtgd_Buyer.DataSource = Nothing
        dtgd_Buyer.DataMember = Nothing
        dtgd_Buyer.Update()

        dtgd_Seller.DataSource = Nothing
        dtgd_Seller.DataMember = Nothing
        dtgd_Seller.Update()

        txt_Buyer_Items.Clear()
        txt_Buyer_Amt.Clear()
        txt_Seller_Items.Clear()
        txt_Seller_Amt.Clear()

        Bidder_Num = txt_Bidder.Text
        Seller = CBool(ckbx_Seller.CheckState)

        If Bidder_Num = "" Or Bidder_Num = "0" Then
            MessageBox.Show("ALERT! A bidder valid bidder number has not been entered! Please try again.")
            txt_Bidder.Focus()
        Else
            MySQLConn = New MySqlConnection
            MySQLCmd = New MySqlCommand


            MySQLConn.ConnectionString = "Server = " & ECARC_Program_Variables.Server_IP & "; User = " & ECARC_Program_Variables.User & "; Password = " & ECARC_Program_Variables.Password & "; Database = " & ECARC_Program_Variables.DB & ";"

            Try
                MySQLConn.Open()

                MySQLCmd.Connection = MySQLConn

                If Seller = False Then
                    Try
                        Dim Buyer_Status_Query As String = "SELECT * FROM Auction_" & ECARC_Program_Variables.Year & " WHERE Bidder_ID = " & Bidder_Num & ";"

                        Dim Buyer_Status_DataAdapter As New MySqlDataAdapter(Buyer_Status_Query, MySQLConn)

                        Dim Buyer_Status_DataSet As New DataSet()

                        Buyer_Status_DataAdapter.Fill(Buyer_Status_DataSet, "Buyer_Data")

                        If Buyer_Status_DataSet.Tables(0).Rows.Count < 1 Then
                            MessageBox.Show("Bidder did not purchase anything.")
                        Else
                            dtgd_Buyer.DataSource = Buyer_Status_DataSet
                            dtgd_Buyer.DataMember = "Buyer_Data"

                            Dim Buyer_Status_Num_Items As String = CStr(Buyer_Status_DataSet.Tables(0).Rows.Count)

                            txt_Buyer_Items.Text = Buyer_Status_Num_Items

                            Dim Buyer_Status_Amount As String = "SELECT SUM(Price) FROM Auction_" & ECARC_Program_Variables.Year & " WHERE Bidder_ID = '" & Bidder_Num & "';"

                            Dim Buyer_Status_Cmd = New MySqlCommand(Buyer_Status_Amount, MySQLConn)

                            Dim Buyer_Status_Total_Reader As MySqlDataReader = Buyer_Status_Cmd.ExecuteReader()

                            While Buyer_Status_Total_Reader.Read
                                Dim Buyer_Status_Current_Total As String = "$ " & CDec(Buyer_Status_Total_Reader.GetString(0))
                                txt_Buyer_Amt.Text = Buyer_Status_Current_Total
                            End While

                            Buyer_Status_Total_Reader.Close()
                        End If

                    Catch Buyer_Query_Error As Exception
                        MessageBox.Show(Buyer_Query_Error.Message)
                    End Try

                Else
                    Try
                        Dim Buyer_Status_Query As String = "SELECT * FROM Auction_" & ECARC_Program_Variables.Year & " WHERE Bidder_ID = " & Bidder_Num & ";"

                        Dim Buyer_Status_DataAdapter As New MySqlDataAdapter(Buyer_Status_Query, MySQLConn)

                        Dim Buyer_Status_DataSet As New DataSet()

                        Buyer_Status_DataAdapter.Fill(Buyer_Status_DataSet, "Buyer_Data")

                        If Buyer_Status_DataSet.Tables(0).Rows.Count < 1 Then
                            MessageBox.Show("Bidder did not purchase anything.")
                        Else
                            dtgd_Buyer.DataSource = Buyer_Status_DataSet
                            dtgd_Buyer.DataMember = "Buyer_Data"

                            Dim Buyer_Status_Num_Items As String = CStr(Buyer_Status_DataSet.Tables(0).Rows.Count)

                            txt_Buyer_Items.Text = Buyer_Status_Num_Items

                            Dim Buyer_Status_Amount As String = "SELECT SUM(Price) FROM Auction_" & ECARC_Program_Variables.Year & " WHERE Bidder_ID = '" & Bidder_Num & "';"

                            Dim Buyer_Status_Cmd = New MySqlCommand(Buyer_Status_Amount, MySQLConn)

                            Dim Buyer_Status_Total_Reader As MySqlDataReader = Buyer_Status_Cmd.ExecuteReader()

                            While Buyer_Status_Total_Reader.Read
                                Dim Buyer_Status_Current_Total As String = "$ " & CDec(Buyer_Status_Total_Reader.GetString(0))
                                txt_Buyer_Amt.Text = Buyer_Status_Current_Total
                            End While

                            Buyer_Status_Total_Reader.Close()
                        End If

                    Catch Buyer_Query_Error As Exception
                        MessageBox.Show(Buyer_Query_Error.Message)
                    End Try

                    Try
                        Dim Seller_Status_Query As String = "SELECT Trans_ID, Trans_Time, Description, Bidder_ID, Price FROM Auction_" & ECARC_Program_Variables.Year & " WHERE Lot_ID = " & Bidder_Num & ";"

                        Dim Seller_Status_DataAdapter As New MySqlDataAdapter(Seller_Status_Query, MySQLConn)

                        Dim Seller_Status_DataSet As New DataSet()

                        Seller_Status_DataAdapter.Fill(Seller_Status_DataSet, "Seller_Data")

                        If Seller_Status_DataSet.Tables(0).Rows.Count < 1 Then
                            MessageBox.Show("Bidder did not sell anything.")
                        Else

                            dtgd_Seller.DataSource = Seller_Status_DataSet
                            dtgd_Seller.DataMember = "Seller_Data"

                            Dim Seller_Status_Num_Items As String = CStr(Seller_Status_DataSet.Tables(0).Rows.Count)

                            txt_Seller_Items.Text = Seller_Status_Num_Items

                            Dim Seller_Status_Amount As String = "SELECT SUM(Price) FROM Auction_" & ECARC_Program_Variables.Year & " WHERE Lot_ID = '" & Bidder_Num & "';"

                            Dim Seller_Status_Cmd = New MySqlCommand(Seller_Status_Amount, MySQLConn)

                            Dim Seller_Status_Total_Reader As MySqlDataReader = Seller_Status_Cmd.ExecuteReader()

                            While Seller_Status_Total_Reader.Read
                                Dim Seller_Status_Current_Total As String = "$ " & CDec(Seller_Status_Total_Reader.GetString(0))
                                txt_Seller_Amt.Text = Seller_Status_Current_Total
                            End While

                            Seller_Status_Total_Reader.Close()

                        End If



                    Catch Seller_Query_Error As Exception
                        MessageBox.Show(Seller_Query_Error.Message)
                    End Try

                End If

            Catch MySQLConn_Error As Exception
                MessageBox.Show(MySQLConn_Error.Message)

            Finally
                MySQLConn.Close()
                MySQLConn.Dispose()
            End Try

        End If

        MySQLConn = New MySqlConnection
        MySQLCmd = New MySqlCommand


        MySQLConn.ConnectionString = "Server = " & ECARC_Program_Variables.Server_IP & "; User = " & ECARC_Program_Variables.User & "; Password = " & ECARC_Program_Variables.Password & "; Database = " & ECARC_Program_Variables.DB & ";"

        Try
            MySQLConn.Open()

            MySQLCmd.Connection = MySQLConn

            Dim Checkout_Status As String = "SELECT Checked_Out FROM Bidders_" & ECARC_Program_Variables.Year & " WHERE Bidder_ID = " & Bidder_Num & ";"
            Dim Checkout_Time As String = "SELECT Check_Out_Time FROM Bidders_" & ECARC_Program_Variables.Year & " WHERE Bidder_ID = " & Bidder_Num & ";"

            Dim Checkout_Status_Cmd = New MySqlCommand(Checkout_Status, MySQLConn)
            Dim Checkout_Status_Reader As MySqlDataReader = Checkout_Status_Cmd.ExecuteReader()

            While Checkout_Status_Reader.Read
                Checkout_Status = Checkout_Status_Reader.GetString(0)
                If Checkout_Status Is Nothing Then
                    Checkout_Status = "0"
                End If
            End While

            Checkout_Status_Reader.Close()

            Dim Check_Time_Cmd = New MySqlCommand(Checkout_Time, MySQLConn)
            Dim Check_Time_Reader As MySqlDataReader = Check_Time_Cmd.ExecuteReader()

            While Check_Time_Reader.Read
                Checkout_Time = Check_Time_Reader.GetString(0)
            End While

            If Checkout_Status = "1" Then
                Checkout_Status = "Bidder Checked Out at : "
                txt_Checkout_Status.BackColor = Color.Red
                txt_Checkout_Status.ForeColor = Color.White
            Else
                Checkout_Status = "Bidder is still active."
                txt_Checkout_Status.BackColor = Color.Green
                txt_Checkout_Status.ForeColor = Color.White
            End If

            txt_Checkout_Status.Text = Checkout_Status.ToString & Checkout_Time.ToString

        Catch MySQLConn_Error As Exception
            MessageBox.Show(MySQLConn_Error.Message)
        Finally
            MySQLConn.Close()
            MySQLConn.Dispose()
        End Try

        txt_Bidder.Focus()

    End Sub

    Private Sub Bidder_Status_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_Bidder.Focus()
    End Sub
End Class