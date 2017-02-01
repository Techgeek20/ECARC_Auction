<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Bidders
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
        Me.lblBidderNum = New System.Windows.Forms.Label()
        Me.lblBidderName = New System.Windows.Forms.Label()
        Me.lblBidderCall = New System.Windows.Forms.Label()
        Me.txtBidNum = New System.Windows.Forms.TextBox()
        Me.txtBidName = New System.Windows.Forms.TextBox()
        Me.txtBidCall = New System.Windows.Forms.TextBox()
        Me.btn_Add_Bidder = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Main = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add a Bidder"
        '
        'lblBidderNum
        '
        Me.lblBidderNum.AutoSize = True
        Me.lblBidderNum.Location = New System.Drawing.Point(54, 79)
        Me.lblBidderNum.Name = "lblBidderNum"
        Me.lblBidderNum.Size = New System.Drawing.Size(83, 13)
        Me.lblBidderNum.TabIndex = 1
        Me.lblBidderNum.Text = "Bidder Number :"
        '
        'lblBidderName
        '
        Me.lblBidderName.AutoSize = True
        Me.lblBidderName.Location = New System.Drawing.Point(60, 118)
        Me.lblBidderName.Name = "lblBidderName"
        Me.lblBidderName.Size = New System.Drawing.Size(77, 13)
        Me.lblBidderName.TabIndex = 2
        Me.lblBidderName.Text = "Bidder Name : "
        '
        'lblBidderCall
        '
        Me.lblBidderCall.AutoSize = True
        Me.lblBidderCall.Location = New System.Drawing.Point(80, 160)
        Me.lblBidderCall.Name = "lblBidderCall"
        Me.lblBidderCall.Size = New System.Drawing.Size(57, 13)
        Me.lblBidderCall.TabIndex = 3
        Me.lblBidderCall.Text = "Call Sign : "
        '
        'txtBidNum
        '
        Me.txtBidNum.Location = New System.Drawing.Point(143, 76)
        Me.txtBidNum.Name = "txtBidNum"
        Me.txtBidNum.Size = New System.Drawing.Size(100, 20)
        Me.txtBidNum.TabIndex = 4
        '
        'txtBidName
        '
        Me.txtBidName.Location = New System.Drawing.Point(143, 115)
        Me.txtBidName.Name = "txtBidName"
        Me.txtBidName.Size = New System.Drawing.Size(100, 20)
        Me.txtBidName.TabIndex = 5
        '
        'txtBidCall
        '
        Me.txtBidCall.Location = New System.Drawing.Point(143, 157)
        Me.txtBidCall.Name = "txtBidCall"
        Me.txtBidCall.Size = New System.Drawing.Size(100, 20)
        Me.txtBidCall.TabIndex = 6
        '
        'btn_Add_Bidder
        '
        Me.btn_Add_Bidder.Location = New System.Drawing.Point(57, 210)
        Me.btn_Add_Bidder.Name = "btn_Add_Bidder"
        Me.btn_Add_Bidder.Size = New System.Drawing.Size(75, 23)
        Me.btn_Add_Bidder.TabIndex = 7
        Me.btn_Add_Bidder.Text = "Add Bidder"
        Me.btn_Add_Bidder.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(188, 210)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_Clear.TabIndex = 8
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Main
        '
        Me.btn_Main.Location = New System.Drawing.Point(57, 259)
        Me.btn_Main.Name = "btn_Main"
        Me.btn_Main.Size = New System.Drawing.Size(75, 23)
        Me.btn_Main.TabIndex = 9
        Me.btn_Main.Text = "Main Menu"
        Me.btn_Main.UseVisualStyleBackColor = True
        '
        'Add_Bidders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 300)
        Me.Controls.Add(Me.btn_Main)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Add_Bidder)
        Me.Controls.Add(Me.txtBidCall)
        Me.Controls.Add(Me.txtBidName)
        Me.Controls.Add(Me.txtBidNum)
        Me.Controls.Add(Me.lblBidderCall)
        Me.Controls.Add(Me.lblBidderName)
        Me.Controls.Add(Me.lblBidderNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add_Bidders"
        Me.Text = "Add_Bidders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBidderNum As System.Windows.Forms.Label
    Friend WithEvents lblBidderName As System.Windows.Forms.Label
    Friend WithEvents lblBidderCall As System.Windows.Forms.Label
    Friend WithEvents txtBidNum As System.Windows.Forms.TextBox
    Friend WithEvents txtBidName As System.Windows.Forms.TextBox
    Friend WithEvents txtBidCall As System.Windows.Forms.TextBox
    Friend WithEvents btn_Add_Bidder As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Main As System.Windows.Forms.Button
End Class
