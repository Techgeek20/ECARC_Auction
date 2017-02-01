<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpbx_Auction_Mgmt = New System.Windows.Forms.GroupBox()
        Me.btn_Checkout = New System.Windows.Forms.Button()
        Me.btn_Status = New System.Windows.Forms.Button()
        Me.btn_Auction_Ctl = New System.Windows.Forms.Button()
        Me.btn_Add_Bidder = New System.Windows.Forms.Button()
        Me.grpbx_DB_Mgmt = New System.Windows.Forms.GroupBox()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.grpbx_Auction_Mgmt.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(686, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome to the Eau Claire Amateur Radio Club auction program"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "What would you like to do?"
        '
        'grpbx_Auction_Mgmt
        '
        Me.grpbx_Auction_Mgmt.Controls.Add(Me.btn_Checkout)
        Me.grpbx_Auction_Mgmt.Controls.Add(Me.btn_Status)
        Me.grpbx_Auction_Mgmt.Controls.Add(Me.btn_Auction_Ctl)
        Me.grpbx_Auction_Mgmt.Controls.Add(Me.btn_Add_Bidder)
        Me.grpbx_Auction_Mgmt.Location = New System.Drawing.Point(96, 88)
        Me.grpbx_Auction_Mgmt.Name = "grpbx_Auction_Mgmt"
        Me.grpbx_Auction_Mgmt.Size = New System.Drawing.Size(518, 93)
        Me.grpbx_Auction_Mgmt.TabIndex = 2
        Me.grpbx_Auction_Mgmt.TabStop = False
        Me.grpbx_Auction_Mgmt.Text = "Auction Management"
        '
        'btn_Checkout
        '
        Me.btn_Checkout.Location = New System.Drawing.Point(393, 41)
        Me.btn_Checkout.Name = "btn_Checkout"
        Me.btn_Checkout.Size = New System.Drawing.Size(107, 23)
        Me.btn_Checkout.TabIndex = 7
        Me.btn_Checkout.Text = "Bidder Checkout"
        Me.btn_Checkout.UseVisualStyleBackColor = True
        '
        'btn_Status
        '
        Me.btn_Status.Location = New System.Drawing.Point(265, 41)
        Me.btn_Status.Name = "btn_Status"
        Me.btn_Status.Size = New System.Drawing.Size(107, 23)
        Me.btn_Status.TabIndex = 6
        Me.btn_Status.Text = "Bidder Status"
        Me.btn_Status.UseVisualStyleBackColor = True
        '
        'btn_Auction_Ctl
        '
        Me.btn_Auction_Ctl.Location = New System.Drawing.Point(140, 41)
        Me.btn_Auction_Ctl.Name = "btn_Auction_Ctl"
        Me.btn_Auction_Ctl.Size = New System.Drawing.Size(107, 23)
        Me.btn_Auction_Ctl.TabIndex = 5
        Me.btn_Auction_Ctl.Text = "Auction Control"
        Me.btn_Auction_Ctl.UseVisualStyleBackColor = True
        '
        'btn_Add_Bidder
        '
        Me.btn_Add_Bidder.Location = New System.Drawing.Point(6, 41)
        Me.btn_Add_Bidder.Name = "btn_Add_Bidder"
        Me.btn_Add_Bidder.Size = New System.Drawing.Size(107, 23)
        Me.btn_Add_Bidder.TabIndex = 4
        Me.btn_Add_Bidder.Text = "Add a Bidder"
        Me.btn_Add_Bidder.UseVisualStyleBackColor = True
        '
        'grpbx_DB_Mgmt
        '
        Me.grpbx_DB_Mgmt.Location = New System.Drawing.Point(96, 206)
        Me.grpbx_DB_Mgmt.Name = "grpbx_DB_Mgmt"
        Me.grpbx_DB_Mgmt.Size = New System.Drawing.Size(518, 93)
        Me.grpbx_DB_Mgmt.TabIndex = 3
        Me.grpbx_DB_Mgmt.TabStop = False
        Me.grpbx_DB_Mgmt.Text = "Database Management"
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(13, 319)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Exit.TabIndex = 4
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 354)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.grpbx_DB_Mgmt)
        Me.Controls.Add(Me.grpbx_Auction_Mgmt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Welcome"
        Me.Text = "ECARC Auction Welcome"
        Me.grpbx_Auction_Mgmt.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpbx_Auction_Mgmt As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Checkout As System.Windows.Forms.Button
    Friend WithEvents btn_Status As System.Windows.Forms.Button
    Friend WithEvents btn_Auction_Ctl As System.Windows.Forms.Button
    Friend WithEvents btn_Add_Bidder As System.Windows.Forms.Button
    Friend WithEvents grpbx_DB_Mgmt As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Exit As System.Windows.Forms.Button
End Class
