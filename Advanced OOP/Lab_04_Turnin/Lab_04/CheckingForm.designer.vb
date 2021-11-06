Partial Public Class CheckingForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.ChargeRadioButton = New System.Windows.Forms.RadioButton()
        Me.CheckRadioButton = New System.Windows.Forms.RadioButton()
        Me.DepositRadioButton = New System.Windows.Forms.RadioButton()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.BalanceLabel = New System.Windows.Forms.Label()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.TransactionTypeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.Location = New System.Drawing.Point(156, 27)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.ReadOnly = True
        Me.BalanceTextBox.Size = New System.Drawing.Size(58, 20)
        Me.BalanceTextBox.TabIndex = 3
        Me.BalanceTextBox.TabStop = False
        Me.BalanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TransactionTypeGroupBox
        '
        Me.TransactionTypeGroupBox.Controls.Add(Me.ChargeRadioButton)
        Me.TransactionTypeGroupBox.Controls.Add(Me.CheckRadioButton)
        Me.TransactionTypeGroupBox.Controls.Add(Me.DepositRadioButton)
        Me.TransactionTypeGroupBox.Location = New System.Drawing.Point(12, 72)
        Me.TransactionTypeGroupBox.Name = "TransactionTypeGroupBox"
        Me.TransactionTypeGroupBox.Size = New System.Drawing.Size(120, 120)
        Me.TransactionTypeGroupBox.TabIndex = 4
        Me.TransactionTypeGroupBox.TabStop = False
        Me.TransactionTypeGroupBox.Text = "Transaction Type"
        '
        'ChargeRadioButton
        '
        Me.ChargeRadioButton.Location = New System.Drawing.Point(8, 88)
        Me.ChargeRadioButton.Name = "ChargeRadioButton"
        Me.ChargeRadioButton.Size = New System.Drawing.Size(104, 16)
        Me.ChargeRadioButton.TabIndex = 2
        Me.ChargeRadioButton.Text = "&Service Charge"
        '
        'CheckRadioButton
        '
        Me.CheckRadioButton.Location = New System.Drawing.Point(8, 56)
        Me.CheckRadioButton.Name = "CheckRadioButton"
        Me.CheckRadioButton.Size = New System.Drawing.Size(80, 16)
        Me.CheckRadioButton.TabIndex = 1
        Me.CheckRadioButton.Text = "C&heck"
        '
        'DepositRadioButton
        '
        Me.DepositRadioButton.Location = New System.Drawing.Point(8, 25)
        Me.DepositRadioButton.Name = "DepositRadioButton"
        Me.DepositRadioButton.Size = New System.Drawing.Size(88, 16)
        Me.DepositRadioButton.TabIndex = 0
        Me.DepositRadioButton.Text = "&Deposit"
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(156, 170)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "E&xit"
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(156, 111)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 6
        Me.ClearButton.Text = "C&lear"
        '
        'CalculateButton
        '
        Me.CalculateButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CalculateButton.Location = New System.Drawing.Point(156, 82)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 5
        Me.CalculateButton.Text = "&Calculate"
        '
        'BalanceLabel
        '
        Me.BalanceLabel.AutoSize = True
        Me.BalanceLabel.Location = New System.Drawing.Point(153, 12)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(92, 13)
        Me.BalanceLabel.TabIndex = 2
        Me.BalanceLabel.Text = "Account Balance:"
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(12, 12)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(74, 13)
        Me.AmountLabel.TabIndex = 0
        Me.AmountLabel.Text = "Enter &Amount:"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(12, 27)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox.TabIndex = 1
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(156, 140)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(75, 23)
        Me.SummaryButton.TabIndex = 7
        Me.SummaryButton.Text = "Su&mmary"
        '
        'CheckingForm
        '
        Me.AcceptButton = Me.CalculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(251, 208)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.BalanceTextBox)
        Me.Controls.Add(Me.TransactionTypeGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.BalanceLabel)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Name = "CheckingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Checking Account"
        Me.TransactionTypeGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BalanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TransactionTypeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ChargeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CheckRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DepositRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents BalanceLabel As System.Windows.Forms.Label
    Friend WithEvents AmountLabel As System.Windows.Forms.Label
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SummaryButton As System.Windows.Forms.Button
    'Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
