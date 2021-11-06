<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VideoRentalCalculator
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
        Me.MemberNumberLabel = New System.Windows.Forms.Label()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.CalculationsGroupBox = New System.Windows.Forms.GroupBox()
        Me.AmountDueTextBox = New System.Windows.Forms.TextBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.RentalAmountTextBox = New System.Windows.Forms.TextBox()
        Me.AmountDueLabel = New System.Windows.Forms.Label()
        Me.DiscountLabel = New System.Windows.Forms.Label()
        Me.RentalAmountLabel = New System.Windows.Forms.Label()
        Me.SummaryGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalRentalsTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCustomersTextBox = New System.Windows.Forms.TextBox()
        Me.TotalRentalsLabel = New System.Windows.Forms.Label()
        Me.TotalCustomersLabel = New System.Windows.Forms.Label()
        Me.MemberNumberTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CalculationsGroupBox.SuspendLayout()
        Me.SummaryGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MemberNumberLabel
        '
        Me.MemberNumberLabel.AutoSize = True
        Me.MemberNumberLabel.Location = New System.Drawing.Point(12, 20)
        Me.MemberNumberLabel.Name = "MemberNumberLabel"
        Me.MemberNumberLabel.Size = New System.Drawing.Size(88, 13)
        Me.MemberNumberLabel.TabIndex = 0
        Me.MemberNumberLabel.Text = "Member Number:"
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(12, 51)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(49, 13)
        Me.QuantityLabel.TabIndex = 1
        Me.QuantityLabel.Text = "Quantity:"
        '
        'CalculationsGroupBox
        '
        Me.CalculationsGroupBox.Controls.Add(Me.AmountDueTextBox)
        Me.CalculationsGroupBox.Controls.Add(Me.DiscountTextBox)
        Me.CalculationsGroupBox.Controls.Add(Me.RentalAmountTextBox)
        Me.CalculationsGroupBox.Controls.Add(Me.AmountDueLabel)
        Me.CalculationsGroupBox.Controls.Add(Me.DiscountLabel)
        Me.CalculationsGroupBox.Controls.Add(Me.RentalAmountLabel)
        Me.CalculationsGroupBox.Location = New System.Drawing.Point(15, 88)
        Me.CalculationsGroupBox.Name = "CalculationsGroupBox"
        Me.CalculationsGroupBox.Size = New System.Drawing.Size(200, 100)
        Me.CalculationsGroupBox.TabIndex = 2
        Me.CalculationsGroupBox.TabStop = False
        '
        'AmountDueTextBox
        '
        Me.AmountDueTextBox.Location = New System.Drawing.Point(90, 73)
        Me.AmountDueTextBox.Name = "AmountDueTextBox"
        Me.AmountDueTextBox.ReadOnly = True
        Me.AmountDueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountDueTextBox.TabIndex = 0
        Me.AmountDueTextBox.TabStop = False
        Me.AmountDueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.Location = New System.Drawing.Point(90, 43)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.ReadOnly = True
        Me.DiscountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DiscountTextBox.TabIndex = 0
        Me.DiscountTextBox.TabStop = False
        Me.DiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RentalAmountTextBox
        '
        Me.RentalAmountTextBox.Location = New System.Drawing.Point(90, 13)
        Me.RentalAmountTextBox.Name = "RentalAmountTextBox"
        Me.RentalAmountTextBox.ReadOnly = True
        Me.RentalAmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RentalAmountTextBox.TabIndex = 0
        Me.RentalAmountTextBox.TabStop = False
        Me.RentalAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AmountDueLabel
        '
        Me.AmountDueLabel.AutoSize = True
        Me.AmountDueLabel.Location = New System.Drawing.Point(7, 72)
        Me.AmountDueLabel.Name = "AmountDueLabel"
        Me.AmountDueLabel.Size = New System.Drawing.Size(66, 13)
        Me.AmountDueLabel.TabIndex = 2
        Me.AmountDueLabel.Text = "Amount Due"
        '
        'DiscountLabel
        '
        Me.DiscountLabel.AutoSize = True
        Me.DiscountLabel.Location = New System.Drawing.Point(7, 44)
        Me.DiscountLabel.Name = "DiscountLabel"
        Me.DiscountLabel.Size = New System.Drawing.Size(72, 13)
        Me.DiscountLabel.TabIndex = 1
        Me.DiscountLabel.Text = "20% Discount"
        '
        'RentalAmountLabel
        '
        Me.RentalAmountLabel.AutoSize = True
        Me.RentalAmountLabel.Location = New System.Drawing.Point(7, 16)
        Me.RentalAmountLabel.Name = "RentalAmountLabel"
        Me.RentalAmountLabel.Size = New System.Drawing.Size(77, 13)
        Me.RentalAmountLabel.TabIndex = 0
        Me.RentalAmountLabel.Text = "Rental Amount"
        '
        'SummaryGroupBox
        '
        Me.SummaryGroupBox.Controls.Add(Me.TotalRentalsTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.TotalCustomersTextBox)
        Me.SummaryGroupBox.Controls.Add(Me.TotalRentalsLabel)
        Me.SummaryGroupBox.Controls.Add(Me.TotalCustomersLabel)
        Me.SummaryGroupBox.Location = New System.Drawing.Point(15, 210)
        Me.SummaryGroupBox.Name = "SummaryGroupBox"
        Me.SummaryGroupBox.Size = New System.Drawing.Size(200, 82)
        Me.SummaryGroupBox.TabIndex = 3
        Me.SummaryGroupBox.TabStop = False
        Me.SummaryGroupBox.Text = "Summary"
        '
        'TotalRentalsTextBox
        '
        Me.TotalRentalsTextBox.Location = New System.Drawing.Point(90, 47)
        Me.TotalRentalsTextBox.Name = "TotalRentalsTextBox"
        Me.TotalRentalsTextBox.ReadOnly = True
        Me.TotalRentalsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalRentalsTextBox.TabIndex = 3
        Me.TotalRentalsTextBox.TabStop = False
        Me.TotalRentalsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalCustomersTextBox
        '
        Me.TotalCustomersTextBox.Location = New System.Drawing.Point(90, 19)
        Me.TotalCustomersTextBox.Name = "TotalCustomersTextBox"
        Me.TotalCustomersTextBox.ReadOnly = True
        Me.TotalCustomersTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalCustomersTextBox.TabIndex = 2
        Me.TotalCustomersTextBox.TabStop = False
        Me.TotalCustomersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalRentalsLabel
        '
        Me.TotalRentalsLabel.AutoSize = True
        Me.TotalRentalsLabel.Location = New System.Drawing.Point(7, 54)
        Me.TotalRentalsLabel.Name = "TotalRentalsLabel"
        Me.TotalRentalsLabel.Size = New System.Drawing.Size(70, 13)
        Me.TotalRentalsLabel.TabIndex = 1
        Me.TotalRentalsLabel.Text = "Total Rentals"
        '
        'TotalCustomersLabel
        '
        Me.TotalCustomersLabel.AutoSize = True
        Me.TotalCustomersLabel.Location = New System.Drawing.Point(7, 25)
        Me.TotalCustomersLabel.Name = "TotalCustomersLabel"
        Me.TotalCustomersLabel.Size = New System.Drawing.Size(83, 13)
        Me.TotalCustomersLabel.TabIndex = 0
        Me.TotalCustomersLabel.Text = "Total Customers"
        '
        'MemberNumberTextBox
        '
        Me.MemberNumberTextBox.Location = New System.Drawing.Point(106, 17)
        Me.MemberNumberTextBox.Name = "MemberNumberTextBox"
        Me.MemberNumberTextBox.Size = New System.Drawing.Size(107, 20)
        Me.MemberNumberTextBox.TabIndex = 1
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(106, 48)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(107, 20)
        Me.QuantityTextBox.TabIndex = 2
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(243, 210)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 3
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(243, 239)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(243, 268)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'VideoRentalCalculator
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 303)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.MemberNumberTextBox)
        Me.Controls.Add(Me.SummaryGroupBox)
        Me.Controls.Add(Me.CalculationsGroupBox)
        Me.Controls.Add(Me.QuantityLabel)
        Me.Controls.Add(Me.MemberNumberLabel)
        Me.Name = "VideoRentalCalculator"
        Me.Text = "Video Bonanza"
        Me.CalculationsGroupBox.ResumeLayout(False)
        Me.CalculationsGroupBox.PerformLayout()
        Me.SummaryGroupBox.ResumeLayout(False)
        Me.SummaryGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MemberNumberLabel As Label
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents CalculationsGroupBox As GroupBox
    Friend WithEvents AmountDueTextBox As TextBox
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents RentalAmountTextBox As TextBox
    Friend WithEvents AmountDueLabel As Label
    Friend WithEvents DiscountLabel As Label
    Friend WithEvents RentalAmountLabel As Label
    Friend WithEvents SummaryGroupBox As GroupBox
    Friend WithEvents MemberNumberTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents CalculateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents TotalRentalsTextBox As TextBox
    Friend WithEvents TotalCustomersTextBox As TextBox
    Friend WithEvents TotalRentalsLabel As Label
    Friend WithEvents TotalCustomersLabel As Label
End Class
