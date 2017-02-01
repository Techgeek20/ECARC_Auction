Imports MySql.Data.MySqlClient
Imports DGVPrinterHelper

Public Class Bidder_Checkout

    ' Initialize the variables needed for this screen
    Dim MySQLConn As MySqlConnection
    Dim MySQLCmd As MySqlCommand

    Dim Bidder_Num As String
    Dim Buyer_Data_BitMap As Bitmap
    Dim Did_Buy As Boolean
    Dim Did_Sell As Boolean

    Private Sub btn_Main_Click(sender As System.Object, e As System.EventArgs) Handles btn_Main.Click
        ' This button closes this screen and shows the Welcome screen
        Welcome.Show()
        Me.Close()
    End Sub

    Private Sub btn_Clear_Click(sender As System.Object, e As System.EventArgs) Handles btn_Clear.Click
        ' This button clears the form fields
        txt_Bidder.Clear()

        dtagd_Buyer_Listing.DataSource = Nothing
        dtagd_Buyer_Listing.DataMember = Nothing
        dtagd_Buyer_Listing.Update()

        dtagd_Seller_Listing.DataSource = Nothing
        dtagd_Seller_Listing.DataMember = Nothing
        dtagd_Seller_Listing.Update()

        txt_Buyer_Num_Items.Clear()
        txt_Buyer_Total.Clear()

        txt_Seller_Num_Items.Clear()
        txt_Seller_Payout.Clear()
        txt_Seller_Total.Clear()

        txt_Chkout_Buyer_Total.Clear()
        txt_Chkout_Final_Total.Clear()
        txt_Chkout_Seller_Total.Clear()
        txt_Seller_Payout.Clear()

        txt_Chkout_Seller_Commis_Rate.Clear()

        txt_Bidder.Focus()

    End Sub

    Private Sub btn_Status_List_Click(sender As System.Object, e As System.EventArgs) Handles btn_Status_List.Click

        dtagd_Buyer_Listing.DataSource = Nothing
        dtagd_Buyer_Listing.DataMember = Nothing
        dtagd_Buyer_Listing.Update()

        dtagd_Seller_Listing.DataSource = Nothing
        dtagd_Seller_Listing.DataMember = Nothing
        dtagd_Seller_Listing.Update()

        txt_Buyer_Num_Items.Clear()
        txt_Buyer_Total.Clear()

        txt_Seller_Num_Items.Clear()
        txt_Seller_Payout.Clear()
        txt_Seller_Total.Clear()

        txt_Chkout_Buyer_Total.Clear()
        txt_Chkout_Final_Total.Clear()
        txt_Chkout_Seller_Total.Clear()
        txt_Chkout_Seller_Commis_Rate.Clear()

        Bidder_Num = txt_Bidder.Text

        If Bidder_Num = "" Or Bidder_Num = "0" Then
            MessageBox.Show("ALERT! A bidder number has not been entered, please try again.")
            txt_Bidder.Focus()
        Else
            MySQLConn = New MySqlConnection
            MySQLCmd = New MySqlCommand

            MySQLConn.ConnectionString = "Server = " & ECARC_Program_Variables.Server_IP & "; User = " & ECARC_Program_Variables.User & "; Password = " & ECARC_Program_Variables.Password & "; Database = " & ECARC_Program_Variables.DB & ";"

            Try
                MySQLConn.Open()
                MySQLCmd.Connection = MySQLConn

                Try
                    Dim Buyer_Status_Query As String = "SELECT * FROM Auction_" & ECARC_Program_Variables.Year & " WHERE Bidder_ID = '" & Bidder_Num & "';"
                    Dim Buyer_Status_DataAdapter As New MySqlDataAdapter(Buyer_Status_Query, MySQLConn)

                    Dim Buyer_Status_DataSet As New DataSet()

                    Buyer_Status_DataAdapter.Fill(Buyer_Status_DataSet, "Buyer_Data")

                    If Buyer_Status_DataSet.Tables(0).Rows.Count < 1 Then
                        MessageBox.Show("Bidder did not purchase anything.")
                        Did_Buy = False
                    Else
                        dtagd_Buyer_Listing.DataSource = Buyer_Status_DataSet
                        dtagd_Buyer_Listing.DataMember = "Buyer_Data"

                        Dim Buyer_Status_Num_Items As Double = Buyer_Status_DataSet.Tables(0).Rows.Count
                        txt_Buyer_Num_Items.Text = CStr(Buyer_Status_Num_Items)

                        Dim Buyer_Status_Total As String = "SELECT SUM(Price) FROM Auction_" & ECARC_Program_Variables.Year & " WHERE Bidder_ID = '" & Bidder_Num & "';"

                        Dim Buyer_Status_Cmd = New MySqlCommand(Buyer_Status_Total, MySQLConn)

                        Dim Buyer_Status_Total_Reader As MySqlDataReader = Buyer_Status_Cmd.ExecuteReader()

                        Dim Buyer_Checkout_Total As Decimal
                        Dim Buyer_Status_Current_Total As Decimal

                        While Buyer_Status_Total_Reader.Read
                            Buyer_Status_Current_Total = Buyer_Status_Total_Reader.GetDecimal(0)
                            Buyer_Checkout_Total = Buyer_Status_Current_Total
                            txt_Buyer_Total.Text = CStr(Buyer_Status_Current_Total)
                        End While

                        Buyer_Status_Total_Reader.Close()

                        txt_Chkout_Buyer_Total.Text = Buyer_Checkout_Total.ToString

                        Did_Buy = True

                    End If

                Catch Buyer_Query_Error As Exception
                    MessageBox.Show(Buyer_Query_Error.Message)
                End Try


                Try
                    Dim Seller_Status_Query As String = "SELECT * FROM Auction_" & ECARC_Program_Variables.Year & " WHERE Lot_ID = '" & Bidder_Num & "';"
                    Dim Seller_Status_DataAdapter As New MySqlDataAdapter(Seller_Status_Query, MySQLConn)

                    Dim Seller_Status_DataSet As New DataSet()

                    Seller_Status_DataAdapter.Fill(Seller_Status_DataSet, "Seller_Data")

                    If Seller_Status_DataSet.Tables(0).Rows.Count < 1 Then
                        MessageBox.Show("Bidder did not sell anything.")
                        Did_Sell = False
                    Else
                        dtagd_Seller_Listing.DataSource = Seller_Status_DataSet
                        dtagd_Seller_Listing.DataMember = "Seller_Data"

                        Dim Seller_Status_Num_Items As Double = Seller_Status_DataSet.Tables(0).Rows.Count
                        txt_Seller_Num_Items.Text = CStr(Seller_Status_Num_Items)

                        Dim Seller_Status_Total As String = "SELECT SUM(Price) FROM Auction_" & ECARC_Program_Variables.Year & " WHERE Lot_ID = '" & Bidder_Num & "';"

                        Dim Seller_Status_Cmd = New MySqlCommand(Seller_Status_Total, MySQLConn)

                        Dim Seller_Status_Total_Reader As MySqlDataReader = Seller_Status_Cmd.ExecuteReader()

                        Dim Seller_Checkout_Total As Decimal
                        Dim Seller_Status_Current_Total As Decimal

                        While Seller_Status_Total_Reader.Read
                            Seller_Status_Current_Total = Seller_Status_Total_Reader.GetDecimal(0)
                            Seller_Checkout_Total = Seller_Status_Current_Total
                            txt_Seller_Total.Text = Seller_Status_Current_Total.ToString
                        End While

                        Seller_Status_Total_Reader.Close()

                        txt_Chkout_Seller_Total.Text = Seller_Checkout_Total.ToString

                        Did_Sell = True

                        Dim Seller_Commision_Total As String = "SELECT Comission_Amt FROM Bidders_" & ECARC_Program_Variables.Year & " WHERE Bidder_ID = '" & Bidder_Num & "';"

                        Dim Seller_Comission_Cmd = New MySqlCommand(Seller_Commision_Total, MySQLConn)

                        Dim Seller_Comission_Total_Reader As MySqlDataReader = Seller_Comission_Cmd.ExecuteReader()

                        Dim Seller_Comission As Decimal

                        While Seller_Comission_Total_Reader.Read
                            Seller_Comission = Seller_Comission_Total_Reader.GetDecimal(0)
                        End While

                        txt_Chkout_Seller_Commis_Rate.Text = Seller_Comission.ToString

                        Seller_Comission_Total_Reader.Close()

                        Dim Seller_Payout As Decimal

                        Dim Seller_Less_Comission = CDec(Seller_Checkout_Total) * CDec(Seller_Comission)

                        Seller_Payout = Seller_Checkout_Total - Seller_Less_Comission

                        txt_Seller_Payout.Text = Seller_Payout.ToString

                    End If

                Catch Seller_Query_Error As Exception
                    MessageBox.Show(Seller_Query_Error.Message)
                End Try


                If txt_Chkout_Buyer_Total.Text > txt_Seller_Payout.Text Then
                    Dim Final_Total As String = "Bidder needs to pay : $" & CDec(txt_Chkout_Buyer_Total.Text) - CDec(txt_Seller_Payout.Text)
                    txt_Chkout_Final_Total.Text = Final_Total
                ElseIf txt_Seller_Payout.Text > txt_Chkout_Buyer_Total.Text Then
                    Dim Final_Total As String = "Bidder is being paid : $" & CDec(txt_Seller_Payout.Text) - CDec(txt_Buyer_Total.Text)
                    txt_Chkout_Final_Total.Text = Final_Total
                ElseIf txt_Seller_Payout.Text = txt_Chkout_Buyer_Total.Text Then
                    Dim Final_Total As String = "Bidder does not pay. Bidder also is not paid."
                    txt_Chkout_Final_Total.Text = Final_Total
                End If

            Catch MySqlConnError As Exception
                MessageBox.Show(MySqlConnError.Message)
            Finally
                MySQLConn.Close()
                MySQLConn.Dispose()
            End Try

        End If

        txt_Bidder.Focus()

    End Sub


    Private Sub btn_Checkout_Click(sender As System.Object, e As System.EventArgs) Handles btn_Checkout.Click

        Bidder_Num = txt_Bidder.Text

        MySQLConn = New MySqlConnection
        MySQLCmd = New MySqlCommand

        MySQLConn.ConnectionString = "Server = " & ECARC_Program_Variables.Server_IP & "; User = " & ECARC_Program_Variables.User & "; Password = " & ECARC_Program_Variables.Password & "; Database = " & ECARC_Program_Variables.DB & ";"

        If Bidder_Num = "" Then
            MessageBox.Show("A bider number has been provided. Please try again.", "", MessageBoxButtons.OKCancel)
        Else
            Try

                MySQLConn.Open()

                MySQLCmd.Connection = MySQLConn

                Dim CheckOut_Status As String = "UPDATE Bidders_" & ECARC_Program_Variables.Year & " SET Checked_Out = '1' ,Check_Out_Time='" & DateAndTime.Now.ToString("hh:mm:ss") & "' WHERE Bidder_ID = '" & Bidder_Num & "';"

                MySQLCmd.CommandText = CheckOut_Status

                MySQLCmd.ExecuteNonQuery()

                MessageBox.Show("Bidder #" & Bidder_Num & " Checked out at : " & Now.ToString("hh:mm:ss tt"), "Successful Checkout!", MessageBoxButtons.OK)
            Catch MySQLConnError As Exception
                MessageBox.Show(MySQLConnError.Message)
            Finally
                MySQLConn.Close()
                MySQLConn.Dispose()
            End Try

        End If

        If Did_Buy = True Then
            Dim Printer = New DGVPrinter
            Printer.Title = "Buyer Invoice"
            Printer.SubTitle = ""
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
            Printer.PageNumbers = True
            Printer.PageNumberInHeader = False
            Printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional
            Printer.HeaderCellAlignment = StringAlignment.Near
            Printer.Footer = "ECARC " & ECARC_Program_Variables.Year & " Auction"
            Printer.FooterSpacing = 15
            Printer.PrintDataGridView(Me.dtagd_Buyer_Listing)
            Printer.PageSettings.Landscape = True
        End If
        
        If Did_Sell = True Then
            Dim Printer2 = New DGVPrinter
            Printer2.Title = "Seller Invoice"
            Printer2.SubTitle = ""
            Printer2.SubTitleFormatFlags = StringFormatFlags.LineLimit Or StringFormatFlags.NoClip
            Printer2.PageNumbers = True
            Printer2.PageNumberInHeader = False
            Printer2.ColumnWidth = DGVPrinter.ColumnWidthSetting.Porportional
            Printer2.HeaderCellAlignment = StringAlignment.Near
            Printer2.Footer = "ECARC " & ECARC_Program_Variables.Year & " Auction"
            Printer2.FooterSpacing = 15
            Printer2.PrintDataGridView(Me.dtagd_Seller_Listing)
            Printer2.PageSettings.Landscape = True
        End If
      
    End Sub

End Class