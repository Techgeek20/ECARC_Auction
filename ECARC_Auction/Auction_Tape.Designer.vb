<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Auction_Tape
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
        Me.dtgd_Auction_Tape = New System.Windows.Forms.DataGridView()
        Me.btn_Refresh = New System.Windows.Forms.Button()
        CType(Me.dtgd_Auction_Tape, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgd_Auction_Tape
        '
        Me.dtgd_Auction_Tape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgd_Auction_Tape.Location = New System.Drawing.Point(12, 12)
        Me.dtgd_Auction_Tape.Name = "dtgd_Auction_Tape"
        Me.dtgd_Auction_Tape.Size = New System.Drawing.Size(650, 349)
        Me.dtgd_Auction_Tape.TabIndex = 0
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Location = New System.Drawing.Point(551, 385)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(101, 23)
        Me.btn_Refresh.TabIndex = 1
        Me.btn_Refresh.Text = "Refresh Tape"
        Me.btn_Refresh.UseVisualStyleBackColor = True
        '
        'Auction_Tape
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 420)
        Me.Controls.Add(Me.btn_Refresh)
        Me.Controls.Add(Me.dtgd_Auction_Tape)
        Me.Name = "Auction_Tape"
        Me.Text = "Auction_Tape"
        CType(Me.dtgd_Auction_Tape, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgd_Auction_Tape As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Refresh As System.Windows.Forms.Button
End Class
