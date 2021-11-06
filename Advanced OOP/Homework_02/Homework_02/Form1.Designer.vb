<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoffeeCalculatorForm
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
        Me.OrderInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.ItemAmountTextBox = New System.Windows.Forms.TextBox()
        Me.ItemAmountLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.TakeoutCheckBox = New System.Windows.Forms.CheckBox()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.CoffeeSelectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.IcedCappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.IcedLatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.LatteRadioButton = New System.Windows.Forms.RadioButton()
        Me.EspressoRadioButton = New System.Windows.Forms.RadioButton()
        Me.CappuccinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.TotalSalesGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalSalesTextBox = New System.Windows.Forms.TextBox()
        Me.TotalSalesLabel = New System.Windows.Forms.Label()
        Me.TotalSalesListBox = New System.Windows.Forms.ListBox()
        Me.OrderInformationGroupBox.SuspendLayout()
        Me.CoffeeSelectionGroupBox.SuspendLayout()
        Me.TotalSalesGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrderInformationGroupBox
        '
        Me.OrderInformationGroupBox.Controls.Add(Me.ItemAmountTextBox)
        Me.OrderInformationGroupBox.Controls.Add(Me.ItemAmountLabel)
        Me.OrderInformationGroupBox.Controls.Add(Me.ExitButton)
        Me.OrderInformationGroupBox.Controls.Add(Me.CalculateButton)
        Me.OrderInformationGroupBox.Controls.Add(Me.TakeoutCheckBox)
        Me.OrderInformationGroupBox.Controls.Add(Me.QuantityLabel)
        Me.OrderInformationGroupBox.Controls.Add(Me.QuantityTextBox)
        Me.OrderInformationGroupBox.Controls.Add(Me.CoffeeSelectionGroupBox)
        Me.OrderInformationGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.OrderInformationGroupBox.Name = "OrderInformationGroupBox"
        Me.OrderInformationGroupBox.Size = New System.Drawing.Size(392, 197)
        Me.OrderInformationGroupBox.TabIndex = 0
        Me.OrderInformationGroupBox.TabStop = False
        Me.OrderInformationGroupBox.Text = "Order Information"
        '
        'ItemAmountTextBox
        '
        Me.ItemAmountTextBox.Location = New System.Drawing.Point(83, 165)
        Me.ItemAmountTextBox.Name = "ItemAmountTextBox"
        Me.ItemAmountTextBox.ReadOnly = True
        Me.ItemAmountTextBox.Size = New System.Drawing.Size(93, 20)
        Me.ItemAmountTextBox.TabIndex = 8
        '
        'ItemAmountLabel
        '
        Me.ItemAmountLabel.AutoSize = True
        Me.ItemAmountLabel.Location = New System.Drawing.Point(7, 165)
        Me.ItemAmountLabel.Name = "ItemAmountLabel"
        Me.ItemAmountLabel.Size = New System.Drawing.Size(69, 13)
        Me.ItemAmountLabel.TabIndex = 7
        Me.ItemAmountLabel.Text = "Item Amount:"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(101, 101)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 45)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(10, 101)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 45)
        Me.CalculateButton.TabIndex = 5
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'TakeoutCheckBox
        '
        Me.TakeoutCheckBox.AutoSize = True
        Me.TakeoutCheckBox.Location = New System.Drawing.Point(10, 65)
        Me.TakeoutCheckBox.Name = "TakeoutCheckBox"
        Me.TakeoutCheckBox.Size = New System.Drawing.Size(72, 17)
        Me.TakeoutCheckBox.TabIndex = 4
        Me.TakeoutCheckBox.Text = "Takeout?"
        Me.TakeoutCheckBox.UseVisualStyleBackColor = True
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(7, 32)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(49, 13)
        Me.QuantityLabel.TabIndex = 3
        Me.QuantityLabel.Text = "Quantity:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(62, 29)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(72, 20)
        Me.QuantityTextBox.TabIndex = 2
        '
        'CoffeeSelectionGroupBox
        '
        Me.CoffeeSelectionGroupBox.Controls.Add(Me.IcedCappuccinoRadioButton)
        Me.CoffeeSelectionGroupBox.Controls.Add(Me.IcedLatteRadioButton)
        Me.CoffeeSelectionGroupBox.Controls.Add(Me.LatteRadioButton)
        Me.CoffeeSelectionGroupBox.Controls.Add(Me.EspressoRadioButton)
        Me.CoffeeSelectionGroupBox.Controls.Add(Me.CappuccinoRadioButton)
        Me.CoffeeSelectionGroupBox.Location = New System.Drawing.Point(186, 13)
        Me.CoffeeSelectionGroupBox.Name = "CoffeeSelectionGroupBox"
        Me.CoffeeSelectionGroupBox.Size = New System.Drawing.Size(200, 178)
        Me.CoffeeSelectionGroupBox.TabIndex = 1
        Me.CoffeeSelectionGroupBox.TabStop = False
        Me.CoffeeSelectionGroupBox.Text = "Coffee Selection"
        '
        'IcedCappuccinoRadioButton
        '
        Me.IcedCappuccinoRadioButton.AutoSize = True
        Me.IcedCappuccinoRadioButton.Location = New System.Drawing.Point(23, 140)
        Me.IcedCappuccinoRadioButton.Name = "IcedCappuccinoRadioButton"
        Me.IcedCappuccinoRadioButton.Size = New System.Drawing.Size(106, 17)
        Me.IcedCappuccinoRadioButton.TabIndex = 4
        Me.IcedCappuccinoRadioButton.TabStop = True
        Me.IcedCappuccinoRadioButton.Text = "Iced Cappuccino"
        Me.IcedCappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'IcedLatteRadioButton
        '
        Me.IcedLatteRadioButton.AutoSize = True
        Me.IcedLatteRadioButton.Location = New System.Drawing.Point(22, 110)
        Me.IcedLatteRadioButton.Name = "IcedLatteRadioButton"
        Me.IcedLatteRadioButton.Size = New System.Drawing.Size(73, 17)
        Me.IcedLatteRadioButton.TabIndex = 3
        Me.IcedLatteRadioButton.TabStop = True
        Me.IcedLatteRadioButton.Text = "Iced Latte"
        Me.IcedLatteRadioButton.UseVisualStyleBackColor = True
        '
        'LatteRadioButton
        '
        Me.LatteRadioButton.AutoSize = True
        Me.LatteRadioButton.Location = New System.Drawing.Point(22, 81)
        Me.LatteRadioButton.Name = "LatteRadioButton"
        Me.LatteRadioButton.Size = New System.Drawing.Size(49, 17)
        Me.LatteRadioButton.TabIndex = 2
        Me.LatteRadioButton.TabStop = True
        Me.LatteRadioButton.Text = "Latte"
        Me.LatteRadioButton.UseVisualStyleBackColor = True
        '
        'EspressoRadioButton
        '
        Me.EspressoRadioButton.AutoSize = True
        Me.EspressoRadioButton.Location = New System.Drawing.Point(22, 52)
        Me.EspressoRadioButton.Name = "EspressoRadioButton"
        Me.EspressoRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.EspressoRadioButton.TabIndex = 1
        Me.EspressoRadioButton.TabStop = True
        Me.EspressoRadioButton.Text = "Espresso"
        Me.EspressoRadioButton.UseVisualStyleBackColor = True
        '
        'CappuccinoRadioButton
        '
        Me.CappuccinoRadioButton.AutoSize = True
        Me.CappuccinoRadioButton.Location = New System.Drawing.Point(22, 23)
        Me.CappuccinoRadioButton.Name = "CappuccinoRadioButton"
        Me.CappuccinoRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.CappuccinoRadioButton.TabIndex = 0
        Me.CappuccinoRadioButton.TabStop = True
        Me.CappuccinoRadioButton.Text = "Cappuccino"
        Me.CappuccinoRadioButton.UseVisualStyleBackColor = True
        '
        'TotalSalesGroupBox
        '
        Me.TotalSalesGroupBox.Controls.Add(Me.TotalSalesTextBox)
        Me.TotalSalesGroupBox.Controls.Add(Me.TotalSalesLabel)
        Me.TotalSalesGroupBox.Controls.Add(Me.TotalSalesListBox)
        Me.TotalSalesGroupBox.Location = New System.Drawing.Point(410, 12)
        Me.TotalSalesGroupBox.Name = "TotalSalesGroupBox"
        Me.TotalSalesGroupBox.Size = New System.Drawing.Size(138, 197)
        Me.TotalSalesGroupBox.TabIndex = 2
        Me.TotalSalesGroupBox.TabStop = False
        Me.TotalSalesGroupBox.Text = "Total Sales"
        '
        'TotalSalesTextBox
        '
        Me.TotalSalesTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.TotalSalesTextBox.Location = New System.Drawing.Point(11, 169)
        Me.TotalSalesTextBox.Name = "TotalSalesTextBox"
        Me.TotalSalesTextBox.ReadOnly = True
        Me.TotalSalesTextBox.Size = New System.Drawing.Size(115, 20)
        Me.TotalSalesTextBox.TabIndex = 2
        '
        'TotalSalesLabel
        '
        Me.TotalSalesLabel.AutoSize = True
        Me.TotalSalesLabel.Location = New System.Drawing.Point(7, 148)
        Me.TotalSalesLabel.Name = "TotalSalesLabel"
        Me.TotalSalesLabel.Size = New System.Drawing.Size(63, 13)
        Me.TotalSalesLabel.TabIndex = 1
        Me.TotalSalesLabel.Text = "Total Sales:"
        '
        'TotalSalesListBox
        '
        Me.TotalSalesListBox.FormattingEnabled = True
        Me.TotalSalesListBox.Location = New System.Drawing.Point(7, 20)
        Me.TotalSalesListBox.Name = "TotalSalesListBox"
        Me.TotalSalesListBox.Size = New System.Drawing.Size(120, 121)
        Me.TotalSalesListBox.TabIndex = 0
        '
        'CoffeeCalculatorForm
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 221)
        Me.Controls.Add(Me.TotalSalesGroupBox)
        Me.Controls.Add(Me.OrderInformationGroupBox)
        Me.Name = "CoffeeCalculatorForm"
        Me.Text = "Coffee Calculator"
        Me.OrderInformationGroupBox.ResumeLayout(False)
        Me.OrderInformationGroupBox.PerformLayout()
        Me.CoffeeSelectionGroupBox.ResumeLayout(False)
        Me.CoffeeSelectionGroupBox.PerformLayout()
        Me.TotalSalesGroupBox.ResumeLayout(False)
        Me.TotalSalesGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OrderInformationGroupBox As GroupBox
    Friend WithEvents CoffeeSelectionGroupBox As GroupBox
    Friend WithEvents TotalSalesGroupBox As GroupBox
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents CalculateButton As Button
    Friend WithEvents TakeoutCheckBox As CheckBox
    Friend WithEvents ItemAmountLabel As Label
    Friend WithEvents ItemAmountTextBox As TextBox
    Friend WithEvents IcedCappuccinoRadioButton As RadioButton
    Friend WithEvents IcedLatteRadioButton As RadioButton
    Friend WithEvents LatteRadioButton As RadioButton
    Friend WithEvents EspressoRadioButton As RadioButton
    Friend WithEvents CappuccinoRadioButton As RadioButton
    Friend WithEvents TotalSalesLabel As Label
    Friend WithEvents TotalSalesListBox As ListBox
    Friend WithEvents TotalSalesTextBox As TextBox
End Class
