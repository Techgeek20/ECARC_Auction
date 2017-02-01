<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bidder_Checkout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_Seller_Total = New System.Windows.Forms.TextBox()
        Me.txt_Seller_Num_Items = New System.Windows.Forms.TextBox()
        Me.txt_Buyer_Total = New System.Windows.Forms.TextBox()
        Me.txt_Buyer_Num_Items = New System.Windows.Forms.TextBox()
        Me.lbl_Seller_Total = New System.Windows.Forms.Label()
        Me.lbl_Seller_Num_Items = New System.Windows.Forms.Label()
        Me.lbl_Buyer_Total = New System.Windows.Forms.Label()
        Me.lbl_Buyer_Num_Items = New System.Windows.Forms.Label()
        Me.gpbx_Seller = New System.Windows.Forms.GroupBox()
        Me.dtagd_Seller_Listing = New System.Windows.Forms.DataGridView()
        Me.gpbx_Buyer = New System.Windows.Forms.GroupBox()
        Me.dtagd_Buyer_Listing = New System.Windows.Forms.DataGridView()
        Me.btn_Main = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Status_List = New System.Windows.Forms.Button()
        Me.txt_Bidder = New System.Windows.Forms.TextBox()
        Me.lbl_Bidder = New System.Windows.Forms.Label()
        Me.lbl_Checkout = New System.Windows.Forms.Label()
        Me.gpbx_Checkout_Info = New System.Windows.Forms.GroupBox()
        Me.btn_Checkout = New System.Windows.Forms.Button()
        Me.txt_Seller_Payout = New System.Windows.Forms.TextBox()
        Me.lbl_Seller_Payout = New System.Windows.Forms.Label()
        Me.txt_Chkout_Seller_Commis_Rate = New System.Windows.Forms.TextBox()
        Me.lbl_Comission_Rate = New System.Windows.Forms.Label()
        Me.txt_Chkout_Seller_Total = New System.Windows.Forms.TextBox()
        Me.lbl_Checkout_Seller_Total = New System.Windows.Forms.Label()
        Me.txt_Chkout_Buyer_Total = New System.Windows.Forms.TextBox()
        Me.txt_Chkout_Final_Total = New System.Windows.Forms.TextBox()
        Me.lbl_Final_Total = New System.Windows.Forms.Label()
        Me.lbl_Buyer_Checkout_Total = New System.Windows.Forms.Label()
        Me.gpbx_Seller.SuspendLayout()
        CType(Me.dtagd_Seller_Listing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbx_Buyer.SuspendLayout()
        CType(Me.dtagd_Buyer_Listing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbx_Checkout_Info.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Seller_Total
        '
        Me.txt_Seller_Total.Location = New System.Drawing.Point(1006, 515)
        Me.txt_Seller_Total.Name = "txt_Seller_Total"
        Me.txt_Seller_Total.ReadOnly = True
        Me.txt_Seller_Total.Size = New System.Drawing.Size(100, 20)
        Me.txt_Seller_Total.TabIndex = 39
        '
        'txt_Seller_Num_Items
        '
        Me.txt_Seller_Num_Items.Location = New System.Drawing.Point(768, 517)
        Me.txt_Seller_Num_Items.Name = "txt_Seller_Num_Items"
        Me.txt_Seller_Num_Items.ReadOnly = True
        Me.txt_Seller_Num_Items.Size = New System.Drawing.Size(100, 20)
        Me.txt_Seller_Num_Items.TabIndex = 38
        '
        'txt_Buyer_Total
        '
        Me.txt_Buyer_Total.Location = New System.Drawing.Point(347, 519)
        Me.txt_Buyer_Total.Name = "txt_Buyer_Total"
        Me.txt_Buyer_Total.ReadOnly = True
        Me.txt_Buyer_Total.Size = New System.Drawing.Size(100, 20)
        Me.txt_Buyer_Total.TabIndex = 37
        '
        'txt_Buyer_Num_Items
        '
        Me.txt_Buyer_Num_Items.Location = New System.Drawing.Point(125, 521)
        Me.txt_Buyer_Num_Items.Name = "txt_Buyer_Num_Items"
        Me.txt_Buyer_Num_Items.ReadOnly = True
        Me.txt_Buyer_Num_Items.Size = New System.Drawing.Size(100, 20)
        Me.txt_Buyer_Num_Items.TabIndex = 36
        '
        'lbl_Seller_Total
        '
        Me.lbl_Seller_Total.AutoSize = True
        Me.lbl_Seller_Total.Location = New System.Drawing.Point(921, 518)
        Me.lbl_Seller_Total.Name = "lbl_Seller_Total"
        Me.lbl_Seller_Total.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Seller_Total.TabIndex = 35
        Me.lbl_Seller_Total.Text = "Seller Total : "
        '
        'lbl_Seller_Num_Items
        '
        Me.lbl_Seller_Num_Items.AutoSize = True
        Me.lbl_Seller_Num_Items.Location = New System.Drawing.Point(669, 518)
        Me.lbl_Seller_Num_Items.Name = "lbl_Seller_Num_Items"
        Me.lbl_Seller_Num_Items.Size = New System.Drawing.Size(93, 13)
        Me.lbl_Seller_Num_Items.TabIndex = 34
        Me.lbl_Seller_Num_Items.Text = "Number of Items : "
        '
        'lbl_Buyer_Total
        '
        Me.lbl_Buyer_Total.AutoSize = True
        Me.lbl_Buyer_Total.Location = New System.Drawing.Point(262, 521)
        Me.lbl_Buyer_Total.Name = "lbl_Buyer_Total"
        Me.lbl_Buyer_Total.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Buyer_Total.TabIndex = 33
        Me.lbl_Buyer_Total.Text = "Buyer Total :"
        '
        'lbl_Buyer_Num_Items
        '
        Me.lbl_Buyer_Num_Items.AutoSize = True
        Me.lbl_Buyer_Num_Items.Location = New System.Drawing.Point(25, 522)
        Me.lbl_Buyer_Num_Items.Name = "lbl_Buyer_Num_Items"
        Me.lbl_Buyer_Num_Items.Size = New System.Drawing.Size(93, 13)
        Me.lbl_Buyer_Num_Items.TabIndex = 32
        Me.lbl_Buyer_Num_Items.Text = "Number of Items : "
        '
        'gpbx_Seller
        '
        Me.gpbx_Seller.Controls.Add(Me.dtagd_Seller_Listing)
        Me.gpbx_Seller.Location = New System.Drawing.Point(638, 104)
        Me.gpbx_Seller.Name = "gpbx_Seller"
        Me.gpbx_Seller.Size = New System.Drawing.Size(694, 397)
        Me.gpbx_Seller.TabIndex = 31
        Me.gpbx_Seller.TabStop = False
        Me.gpbx_Seller.Text = "As Seller : "
        '
        'dtagd_Seller_Listing
        '
        Me.dtagd_Seller_Listing.AllowUserToAddRows = False
        Me.dtagd_Seller_Listing.AllowUserToDeleteRows = False
        Me.dtagd_Seller_Listing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtagd_Seller_Listing.Location = New System.Drawing.Point(6, 19)
        Me.dtagd_Seller_Listing.Name = "dtagd_Seller_Listing"
        Me.dtagd_Seller_Listing.ReadOnly = True
        Me.dtagd_Seller_Listing.Size = New System.Drawing.Size(682, 371)
        Me.dtagd_Seller_Listing.TabIndex = 0
        '
        'gpbx_Buyer
        '
        Me.gpbx_Buyer.Controls.Add(Me.dtagd_Buyer_Listing)
        Me.gpbx_Buyer.Location = New System.Drawing.Point(12, 104)
        Me.gpbx_Buyer.Name = "gpbx_Buyer"
        Me.gpbx_Buyer.Size = New System.Drawing.Size(595, 397)
        Me.gpbx_Buyer.TabIndex = 30
        Me.gpbx_Buyer.TabStop = False
        Me.gpbx_Buyer.Text = "As Buyer :"
        '
        'dtagd_Buyer_Listing
        '
        Me.dtagd_Buyer_Listing.AllowUserToAddRows = False
        Me.dtagd_Buyer_Listing.AllowUserToDeleteRows = False
        Me.dtagd_Buyer_Listing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtagd_Buyer_Listing.Location = New System.Drawing.Point(6, 20)
        Me.dtagd_Buyer_Listing.Name = "dtagd_Buyer_Listing"
        Me.dtagd_Buyer_Listing.ReadOnly = True
        Me.dtagd_Buyer_Listing.Size = New System.Drawing.Size(583, 371)
        Me.dtagd_Buyer_Listing.TabIndex = 0
        '
        'btn_Main
        '
        Me.btn_Main.Location = New System.Drawing.Point(1174, 9)
        Me.btn_Main.Name = "btn_Main"
        Me.btn_Main.Size = New System.Drawing.Size(152, 23)
        Me.btn_Main.TabIndex = 29
        Me.btn_Main.Text = "&Main Menu"
        Me.btn_Main.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(1196, 66)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(106, 23)
        Me.btn_Clear.TabIndex = 28
        Me.btn_Clear.Text = "C&lear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Status_List
        '
        Me.btn_Status_List.Location = New System.Drawing.Point(1021, 66)
        Me.btn_Status_List.Name = "btn_Status_List"
        Me.btn_Status_List.Size = New System.Drawing.Size(139, 23)
        Me.btn_Status_List.TabIndex = 27
        Me.btn_Status_List.Text = "&Get Listing(s)"
        Me.btn_Status_List.UseVisualStyleBackColor = True
        '
        'txt_Bidder
        '
        Me.txt_Bidder.Location = New System.Drawing.Point(437, 68)
        Me.txt_Bidder.Name = "txt_Bidder"
        Me.txt_Bidder.Size = New System.Drawing.Size(116, 20)
        Me.txt_Bidder.TabIndex = 22
        '
        'lbl_Bidder
        '
        Me.lbl_Bidder.AutoSize = True
        Me.lbl_Bidder.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bidder.Location = New System.Drawing.Point(276, 65)
        Me.lbl_Bidder.Name = "lbl_Bidder"
        Me.lbl_Bidder.Size = New System.Drawing.Size(154, 24)
        Me.lbl_Bidder.TabIndex = 21
        Me.lbl_Bidder.Text = "Bidder Number : "
        '
        'lbl_Checkout
        '
        Me.lbl_Checkout.AutoSize = True
        Me.lbl_Checkout.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Checkout.Location = New System.Drawing.Point(544, 9)
        Me.lbl_Checkout.Name = "lbl_Checkout"
        Me.lbl_Checkout.Size = New System.Drawing.Size(160, 37)
        Me.lbl_Checkout.TabIndex = 20
        Me.lbl_Checkout.Text = "Checkout"
        '
        'gpbx_Checkout_Info
        '
        Me.gpbx_Checkout_Info.Controls.Add(Me.btn_Checkout)
        Me.gpbx_Checkout_Info.Controls.Add(Me.txt_Seller_Payout)
        Me.gpbx_Checkout_Info.Controls.Add(Me.lbl_Seller_Payout)
        Me.gpbx_Checkout_Info.Controls.Add(Me.txt_Chkout_Seller_Commis_Rate)
        Me.gpbx_Checkout_Info.Controls.Add(Me.lbl_Comission_Rate)
        Me.gpbx_Checkout_Info.Controls.Add(Me.txt_Chkout_Seller_Total)
        Me.gpbx_Checkout_Info.Controls.Add(Me.lbl_Checkout_Seller_Total)
        Me.gpbx_Checkout_Info.Controls.Add(Me.txt_Chkout_Buyer_Total)
        Me.gpbx_Checkout_Info.Controls.Add(Me.txt_Chkout_Final_Total)
        Me.gpbx_Checkout_Info.Controls.Add(Me.lbl_Final_Total)
        Me.gpbx_Checkout_Info.Controls.Add(Me.lbl_Buyer_Checkout_Total)
        Me.gpbx_Checkout_Info.Location = New System.Drawing.Point(189, 560)
        Me.gpbx_Checkout_Info.Name = "gpbx_Checkout_Info"
        Me.gpbx_Checkout_Info.Size = New System.Drawing.Size(917, 128)
        Me.gpbx_Checkout_Info.TabIndex = 40
        Me.gpbx_Checkout_Info.TabStop = False
        Me.gpbx_Checkout_Info.Text = "Checkout Info : "
        '
        'btn_Checkout
        '
        Me.btn_Checkout.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Checkout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Checkout.Location = New System.Drawing.Point(33, 69)
        Me.btn_Checkout.Name = "btn_Checkout"
        Me.btn_Checkout.Size = New System.Drawing.Size(191, 43)
        Me.btn_Checkout.TabIndex = 10
        Me.btn_Checkout.Text = "&Check Out"
        Me.btn_Checkout.UseVisualStyleBackColor = False
        '
        'txt_Seller_Payout
        '
        Me.txt_Seller_Payout.BackColor = System.Drawing.Color.White
        Me.txt_Seller_Payout.ForeColor = System.Drawing.Color.Black
        Me.txt_Seller_Payout.Location = New System.Drawing.Point(765, 89)
        Me.txt_Seller_Payout.Name = "txt_Seller_Payout"
        Me.txt_Seller_Payout.ReadOnly = True
        Me.txt_Seller_Payout.Size = New System.Drawing.Size(135, 20)
        Me.txt_Seller_Payout.TabIndex = 9
        '
        'lbl_Seller_Payout
        '
        Me.lbl_Seller_Payout.AutoSize = True
        Me.lbl_Seller_Payout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Seller_Payout.Location = New System.Drawing.Point(636, 89)
        Me.lbl_Seller_Payout.Name = "lbl_Seller_Payout"
        Me.lbl_Seller_Payout.Size = New System.Drawing.Size(114, 20)
        Me.lbl_Seller_Payout.TabIndex = 8
        Me.lbl_Seller_Payout.Text = "Seller Payout : "
        '
        'txt_Chkout_Seller_Commis_Rate
        '
        Me.txt_Chkout_Seller_Commis_Rate.BackColor = System.Drawing.Color.White
        Me.txt_Chkout_Seller_Commis_Rate.ForeColor = System.Drawing.Color.Black
        Me.txt_Chkout_Seller_Commis_Rate.Location = New System.Drawing.Point(765, 55)
        Me.txt_Chkout_Seller_Commis_Rate.Name = "txt_Chkout_Seller_Commis_Rate"
        Me.txt_Chkout_Seller_Commis_Rate.ReadOnly = True
        Me.txt_Chkout_Seller_Commis_Rate.Size = New System.Drawing.Size(135, 20)
        Me.txt_Chkout_Seller_Commis_Rate.TabIndex = 7
        '
        'lbl_Comission_Rate
        '
        Me.lbl_Comission_Rate.AutoSize = True
        Me.lbl_Comission_Rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Comission_Rate.Location = New System.Drawing.Point(626, 55)
        Me.lbl_Comission_Rate.Name = "lbl_Comission_Rate"
        Me.lbl_Comission_Rate.Size = New System.Drawing.Size(133, 20)
        Me.lbl_Comission_Rate.TabIndex = 6
        Me.lbl_Comission_Rate.Text = "Comission Rate : "
        '
        'txt_Chkout_Seller_Total
        '
        Me.txt_Chkout_Seller_Total.BackColor = System.Drawing.Color.White
        Me.txt_Chkout_Seller_Total.Location = New System.Drawing.Point(765, 23)
        Me.txt_Chkout_Seller_Total.Name = "txt_Chkout_Seller_Total"
        Me.txt_Chkout_Seller_Total.ReadOnly = True
        Me.txt_Chkout_Seller_Total.Size = New System.Drawing.Size(135, 20)
        Me.txt_Chkout_Seller_Total.TabIndex = 5
        '
        'lbl_Checkout_Seller_Total
        '
        Me.lbl_Checkout_Seller_Total.AutoSize = True
        Me.lbl_Checkout_Seller_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Checkout_Seller_Total.Location = New System.Drawing.Point(659, 23)
        Me.lbl_Checkout_Seller_Total.Name = "lbl_Checkout_Seller_Total"
        Me.lbl_Checkout_Seller_Total.Size = New System.Drawing.Size(100, 20)
        Me.lbl_Checkout_Seller_Total.TabIndex = 4
        Me.lbl_Checkout_Seller_Total.Text = "Seller Total : "
        '
        'txt_Chkout_Buyer_Total
        '
        Me.txt_Chkout_Buyer_Total.BackColor = System.Drawing.Color.White
        Me.txt_Chkout_Buyer_Total.ForeColor = System.Drawing.Color.Black
        Me.txt_Chkout_Buyer_Total.Location = New System.Drawing.Point(171, 27)
        Me.txt_Chkout_Buyer_Total.Name = "txt_Chkout_Buyer_Total"
        Me.txt_Chkout_Buyer_Total.ReadOnly = True
        Me.txt_Chkout_Buyer_Total.Size = New System.Drawing.Size(116, 20)
        Me.txt_Chkout_Buyer_Total.TabIndex = 3
        '
        'txt_Chkout_Final_Total
        '
        Me.txt_Chkout_Final_Total.BackColor = System.Drawing.Color.White
        Me.txt_Chkout_Final_Total.Location = New System.Drawing.Point(345, 79)
        Me.txt_Chkout_Final_Total.Name = "txt_Chkout_Final_Total"
        Me.txt_Chkout_Final_Total.ReadOnly = True
        Me.txt_Chkout_Final_Total.Size = New System.Drawing.Size(258, 20)
        Me.txt_Chkout_Final_Total.TabIndex = 2
        '
        'lbl_Final_Total
        '
        Me.lbl_Final_Total.AutoSize = True
        Me.lbl_Final_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Final_Total.Location = New System.Drawing.Point(244, 79)
        Me.lbl_Final_Total.Name = "lbl_Final_Total"
        Me.lbl_Final_Total.Size = New System.Drawing.Size(94, 20)
        Me.lbl_Final_Total.TabIndex = 1
        Me.lbl_Final_Total.Text = "Final Total : "
        '
        'lbl_Buyer_Checkout_Total
        '
        Me.lbl_Buyer_Checkout_Total.AutoSize = True
        Me.lbl_Buyer_Checkout_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Buyer_Checkout_Total.Location = New System.Drawing.Point(64, 25)
        Me.lbl_Buyer_Checkout_Total.Name = "lbl_Buyer_Checkout_Total"
        Me.lbl_Buyer_Checkout_Total.Size = New System.Drawing.Size(101, 20)
        Me.lbl_Buyer_Checkout_Total.TabIndex = 0
        Me.lbl_Buyer_Checkout_Total.Text = "Buyer Total : "
        '
        'Bidder_Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 700)
        Me.Controls.Add(Me.gpbx_Checkout_Info)
        Me.Controls.Add(Me.txt_Seller_Total)
        Me.Controls.Add(Me.txt_Seller_Num_Items)
        Me.Controls.Add(Me.txt_Buyer_Total)
        Me.Controls.Add(Me.txt_Buyer_Num_Items)
        Me.Controls.Add(Me.lbl_Seller_Total)
        Me.Controls.Add(Me.lbl_Seller_Num_Items)
        Me.Controls.Add(Me.lbl_Buyer_Total)
        Me.Controls.Add(Me.lbl_Buyer_Num_Items)
        Me.Controls.Add(Me.gpbx_Seller)
        Me.Controls.Add(Me.gpbx_Buyer)
        Me.Controls.Add(Me.btn_Main)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Status_List)
        Me.Controls.Add(Me.txt_Bidder)
        Me.Controls.Add(Me.lbl_Bidder)
        Me.Controls.Add(Me.lbl_Checkout)
        Me.Name = "Bidder_Checkout"
        Me.Text = "Checkout"
        Me.gpbx_Seller.ResumeLayout(False)
        CType(Me.dtagd_Seller_Listing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbx_Buyer.ResumeLayout(False)
        CType(Me.dtagd_Buyer_Listing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbx_Checkout_Info.ResumeLayout(False)
        Me.gpbx_Checkout_Info.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Seller_Total As System.Windows.Forms.TextBox
    Friend WithEvents txt_Seller_Num_Items As System.Windows.Forms.TextBox
    Friend WithEvents txt_Buyer_Total As System.Windows.Forms.TextBox
    Friend WithEvents txt_Buyer_Num_Items As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Seller_Total As System.Windows.Forms.Label
    Friend WithEvents lbl_Seller_Num_Items As System.Windows.Forms.Label
    Friend WithEvents lbl_Buyer_Total As System.Windows.Forms.Label
    Friend WithEvents lbl_Buyer_Num_Items As System.Windows.Forms.Label
    Friend WithEvents gpbx_Seller As System.Windows.Forms.GroupBox
    Friend WithEvents gpbx_Buyer As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Main As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Status_List As System.Windows.Forms.Button
    Friend WithEvents txt_Bidder As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Bidder As System.Windows.Forms.Label
    Friend WithEvents lbl_Checkout As System.Windows.Forms.Label
    Friend WithEvents gpbx_Checkout_Info As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Seller_Payout As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Seller_Payout As System.Windows.Forms.Label
    Friend WithEvents txt_Chkout_Seller_Commis_Rate As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Comission_Rate As System.Windows.Forms.Label
    Friend WithEvents txt_Chkout_Seller_Total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Checkout_Seller_Total As System.Windows.Forms.Label
    Friend WithEvents txt_Chkout_Buyer_Total As System.Windows.Forms.TextBox
    Friend WithEvents txt_Chkout_Final_Total As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Final_Total As System.Windows.Forms.Label
    Friend WithEvents lbl_Buyer_Checkout_Total As System.Windows.Forms.Label
    Friend WithEvents btn_Checkout As System.Windows.Forms.Button
    Friend WithEvents dtagd_Buyer_Listing As System.Windows.Forms.DataGridView
    Friend WithEvents dtagd_Seller_Listing As System.Windows.Forms.DataGridView
End Class
