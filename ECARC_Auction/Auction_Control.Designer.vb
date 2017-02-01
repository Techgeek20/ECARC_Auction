<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auction_Control
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Lot_Num = New System.Windows.Forms.TextBox()
        Me.txt_Description = New System.Windows.Forms.TextBox()
        Me.txt_Win_Bidder = New System.Windows.Forms.TextBox()
        Me.txt_Final_Price = New System.Windows.Forms.TextBox()
        Me.btn_Add_to_DB = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Main = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Auction Control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lot Number : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Winning Bidder : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Final Price : "
        '
        'txt_Lot_Num
        '
        Me.txt_Lot_Num.Location = New System.Drawing.Point(107, 75)
        Me.txt_Lot_Num.Name = "txt_Lot_Num"
        Me.txt_Lot_Num.Size = New System.Drawing.Size(215, 20)
        Me.txt_Lot_Num.TabIndex = 5
        '
        'txt_Description
        '
        Me.txt_Description.Location = New System.Drawing.Point(107, 118)
        Me.txt_Description.MaxLength = 100
        Me.txt_Description.Name = "txt_Description"
        Me.txt_Description.Size = New System.Drawing.Size(215, 20)
        Me.txt_Description.TabIndex = 6
        '
        'txt_Win_Bidder
        '
        Me.txt_Win_Bidder.Location = New System.Drawing.Point(107, 162)
        Me.txt_Win_Bidder.Name = "txt_Win_Bidder"
        Me.txt_Win_Bidder.Size = New System.Drawing.Size(215, 20)
        Me.txt_Win_Bidder.TabIndex = 7
        '
        'txt_Final_Price
        '
        Me.txt_Final_Price.Location = New System.Drawing.Point(107, 205)
        Me.txt_Final_Price.Name = "txt_Final_Price"
        Me.txt_Final_Price.Size = New System.Drawing.Size(215, 20)
        Me.txt_Final_Price.TabIndex = 8
        '
        'btn_Add_to_DB
        '
        Me.btn_Add_to_DB.Location = New System.Drawing.Point(17, 256)
        Me.btn_Add_to_DB.Name = "btn_Add_to_DB"
        Me.btn_Add_to_DB.Size = New System.Drawing.Size(99, 23)
        Me.btn_Add_to_DB.TabIndex = 9
        Me.btn_Add_to_DB.Text = "Add to DB"
        Me.btn_Add_to_DB.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(145, 256)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_Clear.TabIndex = 10
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Main
        '
        Me.btn_Main.Location = New System.Drawing.Point(249, 256)
        Me.btn_Main.Name = "btn_Main"
        Me.btn_Main.Size = New System.Drawing.Size(75, 23)
        Me.btn_Main.TabIndex = 11
        Me.btn_Main.Text = "Main Menu"
        Me.btn_Main.UseVisualStyleBackColor = True
        '
        'Auction_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 318)
        Me.Controls.Add(Me.btn_Main)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Add_to_DB)
        Me.Controls.Add(Me.txt_Final_Price)
        Me.Controls.Add(Me.txt_Win_Bidder)
        Me.Controls.Add(Me.txt_Description)
        Me.Controls.Add(Me.txt_Lot_Num)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Auction_Control"
        Me.Text = "Auction_Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Lot_Num As System.Windows.Forms.TextBox
    Friend WithEvents txt_Description As System.Windows.Forms.TextBox
    Friend WithEvents txt_Win_Bidder As System.Windows.Forms.TextBox
    Friend WithEvents txt_Final_Price As System.Windows.Forms.TextBox
    Friend WithEvents btn_Add_to_DB As System.Windows.Forms.Button
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents btn_Main As System.Windows.Forms.Button
End Class
