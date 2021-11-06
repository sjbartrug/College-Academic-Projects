<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketSalesForm
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
        Me.TicketPurchaseGroupBox = New System.Windows.Forms.GroupBox()
        Me.SectionLabel = New System.Windows.Forms.Label()
        Me.SectionListBox = New System.Windows.Forms.ListBox()
        Me.NumberOfTicketsTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfTicketsLabel = New System.Windows.Forms.Label()
        Me.PurchaseTicketsButton = New System.Windows.Forms.Button()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AmountDueLabel = New System.Windows.Forms.Label()
        Me.AmountDueTextBox = New System.Windows.Forms.TextBox()
        Me.SingleTicketPurchaseSummaryLabel = New System.Windows.Forms.Label()
        Me.TicketSummaryTextBox = New System.Windows.Forms.TextBox()
        Me.TicketPurchaseGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TicketPurchaseGroupBox
        '
        Me.TicketPurchaseGroupBox.Controls.Add(Me.SectionLabel)
        Me.TicketPurchaseGroupBox.Controls.Add(Me.SectionListBox)
        Me.TicketPurchaseGroupBox.Controls.Add(Me.NumberOfTicketsTextBox)
        Me.TicketPurchaseGroupBox.Controls.Add(Me.NumberOfTicketsLabel)
        Me.TicketPurchaseGroupBox.Controls.Add(Me.PurchaseTicketsButton)
        Me.TicketPurchaseGroupBox.Location = New System.Drawing.Point(12, 87)
        Me.TicketPurchaseGroupBox.Name = "TicketPurchaseGroupBox"
        Me.TicketPurchaseGroupBox.Size = New System.Drawing.Size(240, 120)
        Me.TicketPurchaseGroupBox.TabIndex = 0
        Me.TicketPurchaseGroupBox.TabStop = False
        Me.TicketPurchaseGroupBox.Text = "Select Section and Number of Tickets"
        '
        'SectionLabel
        '
        Me.SectionLabel.AutoSize = True
        Me.SectionLabel.Location = New System.Drawing.Point(7, 20)
        Me.SectionLabel.Name = "SectionLabel"
        Me.SectionLabel.Size = New System.Drawing.Size(46, 13)
        Me.SectionLabel.TabIndex = 4
        Me.SectionLabel.Text = "Section:"
        '
        'SectionListBox
        '
        Me.SectionListBox.FormattingEnabled = True
        Me.SectionListBox.Location = New System.Drawing.Point(6, 37)
        Me.SectionListBox.Name = "SectionListBox"
        Me.SectionListBox.Size = New System.Drawing.Size(73, 69)
        Me.SectionListBox.TabIndex = 3
        '
        'NumberOfTicketsTextBox
        '
        Me.NumberOfTicketsTextBox.Location = New System.Drawing.Point(134, 60)
        Me.NumberOfTicketsTextBox.Name = "NumberOfTicketsTextBox"
        Me.NumberOfTicketsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumberOfTicketsTextBox.TabIndex = 2
        '
        'NumberOfTicketsLabel
        '
        Me.NumberOfTicketsLabel.AutoSize = True
        Me.NumberOfTicketsLabel.Location = New System.Drawing.Point(133, 37)
        Me.NumberOfTicketsLabel.Name = "NumberOfTicketsLabel"
        Me.NumberOfTicketsLabel.Size = New System.Drawing.Size(47, 13)
        Me.NumberOfTicketsLabel.TabIndex = 1
        Me.NumberOfTicketsLabel.Text = "Number:"
        '
        'PurchaseTicketsButton
        '
        Me.PurchaseTicketsButton.Location = New System.Drawing.Point(136, 90)
        Me.PurchaseTicketsButton.Name = "PurchaseTicketsButton"
        Me.PurchaseTicketsButton.Size = New System.Drawing.Size(98, 23)
        Me.PurchaseTicketsButton.TabIndex = 0
        Me.PurchaseTicketsButton.Text = "Purchase Tickets"
        Me.PurchaseTicketsButton.UseVisualStyleBackColor = True
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(57, 32)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(242, 31)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "Concert Ticket Sales"
        '
        'AmountDueLabel
        '
        Me.AmountDueLabel.AutoSize = True
        Me.AmountDueLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountDueLabel.Location = New System.Drawing.Point(255, 159)
        Me.AmountDueLabel.Name = "AmountDueLabel"
        Me.AmountDueLabel.Size = New System.Drawing.Size(95, 16)
        Me.AmountDueLabel.TabIndex = 3
        Me.AmountDueLabel.Text = "Amount Due:"
        '
        'AmountDueTextBox
        '
        Me.AmountDueTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountDueTextBox.Location = New System.Drawing.Point(258, 178)
        Me.AmountDueTextBox.Name = "AmountDueTextBox"
        Me.AmountDueTextBox.ReadOnly = True
        Me.AmountDueTextBox.Size = New System.Drawing.Size(100, 29)
        Me.AmountDueTextBox.TabIndex = 4
        Me.AmountDueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SingleTicketPurchaseSummaryLabel
        '
        Me.SingleTicketPurchaseSummaryLabel.AutoSize = True
        Me.SingleTicketPurchaseSummaryLabel.Location = New System.Drawing.Point(260, 87)
        Me.SingleTicketPurchaseSummaryLabel.Name = "SingleTicketPurchaseSummaryLabel"
        Me.SingleTicketPurchaseSummaryLabel.Size = New System.Drawing.Size(0, 13)
        Me.SingleTicketPurchaseSummaryLabel.TabIndex = 5
        '
        'TicketSummaryTextBox
        '
        Me.TicketSummaryTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketSummaryTextBox.Location = New System.Drawing.Point(18, 214)
        Me.TicketSummaryTextBox.Multiline = True
        Me.TicketSummaryTextBox.Name = "TicketSummaryTextBox"
        Me.TicketSummaryTextBox.ReadOnly = True
        Me.TicketSummaryTextBox.Size = New System.Drawing.Size(340, 85)
        Me.TicketSummaryTextBox.TabIndex = 6
        '
        'TicketSalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 311)
        Me.Controls.Add(Me.TicketSummaryTextBox)
        Me.Controls.Add(Me.SingleTicketPurchaseSummaryLabel)
        Me.Controls.Add(Me.AmountDueTextBox)
        Me.Controls.Add(Me.AmountDueLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.TicketPurchaseGroupBox)
        Me.Name = "TicketSalesForm"
        Me.Text = "Ticket Sales"
        Me.TicketPurchaseGroupBox.ResumeLayout(False)
        Me.TicketPurchaseGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TicketPurchaseGroupBox As GroupBox
    Friend WithEvents SectionLabel As Label
    Friend WithEvents SectionListBox As ListBox
    Friend WithEvents NumberOfTicketsTextBox As TextBox
    Friend WithEvents NumberOfTicketsLabel As Label
    Friend WithEvents PurchaseTicketsButton As Button
    Friend WithEvents TitleLabel As Label
    Friend WithEvents AmountDueLabel As Label
    Friend WithEvents AmountDueTextBox As TextBox
    Friend WithEvents SingleTicketPurchaseSummaryLabel As Label
    Friend WithEvents TicketSummaryTextBox As TextBox
End Class
