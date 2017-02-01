Public Class Welcome

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
End Class