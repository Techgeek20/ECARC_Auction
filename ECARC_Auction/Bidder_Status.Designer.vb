<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bidder_Status
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.gpbx_Buyer_Items = New System.Windows.Forms.GroupBox()
        Me.txt_Buyer_Amt = New System.Windows.Forms.TextBox()
        Me.txt_Buyer_Items = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtgd_Buyer = New System.Windows.Forms.DataGridView()
        Me.gpbx_Seller_Items = New System.Windows.Forms.GroupBox()
        Me.txt_Seller_Amt = New System.Windows.Forms.TextBox()
        Me.txt_Seller_Items = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtgd_Seller = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Bidder = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckbx_Seller = New System.Windows.Forms.CheckBox()
        Me.btn_Main = New System.Windows.Forms.Button()
        Me.btn_Status_Check = New System.Windows.Forms.Button()
        Me.lbl_Checkedout = New System.Windows.Forms.Label()
        Me.txt_Checkout_Status = New System.Windows.Forms.TextBox()
        Me.gpbx_Buyer_Items.SuspendLayout()
        CType(Me.dtgd_Buyer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbx_Seller_Items.SuspendLayout()
        CType(Me.dtgd_Seller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(448, 50)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'gpbx_Buyer_Items
        '
        Me.gpbx_Buyer_Items.Controls.Add(Me.txt_Buyer_Amt)
        Me.gpbx_Buyer_Items.Controls.Add(Me.txt_Buyer_Items)
        Me.gpbx_Buyer_Items.Controls.Add(Me.Label6)
        Me.gpbx_Buyer_Items.Controls.Add(Me.Label4)
        Me.gpbx_Buyer_Items.Controls.Add(Me.dtgd_Buyer)
        Me.gpbx_Buyer_Items.Location = New System.Drawing.Point(22, 107)
        Me.gpbx_Buyer_Items.Name = "gpbx_Buyer_Items"
        Me.gpbx_Buyer_Items.Size = New System.Drawing.Size(564, 304)
        Me.gpbx_Buyer_Items.TabIndex = 1
        Me.gpbx_Buyer_Items.TabStop = False
        Me.gpbx_Buyer_Items.Text = "Buyer Items"
        '
        'txt_Buyer_Amt
        '
        Me.txt_Buyer_Amt.Location = New System.Drawing.Point(116, 280)
        Me.txt_Buyer_Amt.Name = "txt_Buyer_Amt"
        Me.txt_Buyer_Amt.ReadOnly = True
        Me.txt_Buyer_Amt.Size = New System.Drawing.Size(100, 20)
        Me.txt_Buyer_Amt.TabIndex = 4
        '
        'txt_Buyer_Items
        '
        Me.txt_Buyer_Items.Location = New System.Drawing.Point(116, 249)
        Me.txt_Buyer_Items.Name = "txt_Buyer_Items"
        Me.txt_Buyer_Items.ReadOnly = True
        Me.txt_Buyer_Items.Size = New System.Drawing.Size(100, 20)
        Me.txt_Buyer_Items.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Buyer Total Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Buyer Item Total:"
        '
        'dtgd_Buyer
        '
        Me.dtgd_Buyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgd_Buyer.Location = New System.Drawing.Point(7, 20)
        Me.dtgd_Buyer.Name = "dtgd_Buyer"
        Me.dtgd_Buyer.Size = New System.Drawing.Size(540, 225)
        Me.dtgd_Buyer.TabIndex = 0
        '
        'gpbx_Seller_Items
        '
        Me.gpbx_Seller_Items.Controls.Add(Me.txt_Seller_Amt)
        Me.gpbx_Seller_Items.Controls.Add(Me.txt_Seller_Items)
        Me.gpbx_Seller_Items.Controls.Add(Me.Label7)
        Me.gpbx_Seller_Items.Controls.Add(Me.Label5)
        Me.gpbx_Seller_Items.Controls.Add(Me.dtgd_Seller)
        Me.gpbx_Seller_Items.Location = New System.Drawing.Point(615, 107)
        Me.gpbx_Seller_Items.Name = "gpbx_Seller_Items"
        Me.gpbx_Seller_Items.Size = New System.Drawing.Size(557, 304)
        Me.gpbx_Seller_Items.TabIndex = 2
        Me.gpbx_Seller_Items.TabStop = False
        Me.gpbx_Seller_Items.Text = "Seller Items"
        '
        'txt_Seller_Amt
        '
        Me.txt_Seller_Amt.Location = New System.Drawing.Point(118, 279)
        Me.txt_Seller_Amt.Name = "txt_Seller_Amt"
        Me.txt_Seller_Amt.ReadOnly = True
        Me.txt_Seller_Amt.Size = New System.Drawing.Size(100, 20)
        Me.txt_Seller_Amt.TabIndex = 6
        '
        'txt_Seller_Items
        '
        Me.txt_Seller_Items.Location = New System.Drawing.Point(118, 249)
        Me.txt_Seller_Items.Name = "txt_Seller_Items"
        Me.txt_Seller_Items.ReadOnly = True
        Me.txt_Seller_Items.Size = New System.Drawing.Size(100, 20)
        Me.txt_Seller_Items.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 282)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Seller Total Amount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Seller Item Total:"
        '
        'dtgd_Seller
        '
        Me.dtgd_Seller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgd_Seller.Location = New System.Drawing.Point(7, 19)
        Me.dtgd_Seller.Name = "dtgd_Seller"
        Me.dtgd_Seller.Size = New System.Drawing.Size(544, 225)
        Me.dtgd_Seller.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(535, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bidder Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Bidder Number : "
        '
        'txt_Bidder
        '
        Me.txt_Bidder.Location = New System.Drawing.Point(111, 52)
        Me.txt_Bidder.Name = "txt_Bidder"
        Me.txt_Bidder.Size = New System.Drawing.Size(73, 20)
        Me.txt_Bidder.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Seller?"
        '
        'ckbx_Seller
        '
        Me.ckbx_Seller.AutoSize = True
        Me.ckbx_Seller.Location = New System.Drawing.Point(297, 55)
        Me.ckbx_Seller.Name = "ckbx_Seller"
        Me.ckbx_Seller.Size = New System.Drawing.Size(15, 14)
        Me.ckbx_Seller.TabIndex = 2
        Me.ckbx_Seller.UseVisualStyleBackColor = True
        '
        'btn_Main
        '
        Me.btn_Main.Location = New System.Drawing.Point(540, 49)
        Me.btn_Main.Name = "btn_Main"
        Me.btn_Main.Size = New System.Drawing.Size(75, 23)
        Me.btn_Main.TabIndex = 5
        Me.btn_Main.Text = "Main Menu"
        Me.btn_Main.UseVisualStyleBackColor = True
        '
        'btn_Status_Check
        '
        Me.btn_Status_Check.Location = New System.Drawing.Point(347, 49)
        Me.btn_Status_Check.Name = "btn_Status_Check"
        Me.btn_Status_Check.Size = New System.Drawing.Size(86, 23)
        Me.btn_Status_Check.TabIndex = 3
        Me.btn_Status_Check.Text = "Status Check"
        Me.btn_Status_Check.UseVisualStyleBackColor = True
        '
        'lbl_Checkedout
        '
        Me.lbl_Checkedout.AutoSize = True
        Me.lbl_Checkedout.Location = New System.Drawing.Point(22, 436)
        Me.lbl_Checkedout.Name = "lbl_Checkedout"
        Me.lbl_Checkedout.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Checkedout.TabIndex = 10
        Me.lbl_Checkedout.Text = "Checked Out?"
        '
        'txt_Checkout_Status
        '
        Me.txt_Checkout_Status.Location = New System.Drawing.Point(105, 436)
        Me.txt_Checkout_Status.Name = "txt_Checkout_Status"
        Me.txt_Checkout_Status.ReadOnly = True
        Me.txt_Checkout_Status.Size = New System.Drawing.Size(319, 20)
        Me.txt_Checkout_Status.TabIndex = 11
        '
        'Bidder_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 477)
        Me.Controls.Add(Me.txt_Checkout_Status)
        Me.Controls.Add(Me.lbl_Checkedout)
        Me.Controls.Add(Me.btn_Status_Check)
        Me.Controls.Add(Me.btn_Main)
        Me.Controls.Add(Me.ckbx_Seller)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Bidder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gpbx_Seller_Items)
        Me.Controls.Add(Me.gpbx_Buyer_Items)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "Bidder_Status"
        Me.Text = "Bidder_Status"
        Me.gpbx_Buyer_Items.ResumeLayout(False)
        Me.gpbx_Buyer_Items.PerformLayout()
        CType(Me.dtgd_Buyer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbx_Seller_Items.ResumeLayout(False)
        Me.gpbx_Seller_Items.PerformLayout()
        CType(Me.dtgd_Seller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents gpbx_Buyer_Items As System.Windows.Forms.GroupBox
    Friend WithEvents dtgd_Buyer As System.Windows.Forms.DataGridView
    Friend WithEvents gpbx_Seller_Items As System.Windows.Forms.GroupBox
    Friend WithEvents dtgd_Seller As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_Bidder As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ckbx_Seller As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Main As System.Windows.Forms.Button
    Friend WithEvents btn_Status_Check As System.Windows.Forms.Button
    Friend WithEvents txt_Buyer_Amt As System.Windows.Forms.TextBox
    Friend WithEvents txt_Buyer_Items As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Seller_Amt As System.Windows.Forms.TextBox
    Friend WithEvents txt_Seller_Items As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_Checkedout As System.Windows.Forms.Label
    Friend WithEvents txt_Checkout_Status As System.Windows.Forms.TextBox
End Class
