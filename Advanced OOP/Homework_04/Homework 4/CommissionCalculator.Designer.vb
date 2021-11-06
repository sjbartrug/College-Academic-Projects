<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommissionCalculatorForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesGroupBox = New System.Windows.Forms.GroupBox()
        Me.WeeklySalesTextBox = New System.Windows.Forms.TextBox()
        Me.SalespersonsNameTextBox = New System.Windows.Forms.TextBox()
        Me.WeeklySalesLabel = New System.Windows.Forms.Label()
        Me.SalespersonsNameLabel = New System.Windows.Forms.Label()
        Me.AmountPaidLabel = New System.Windows.Forms.Label()
        Me.CommissionLabel = New System.Windows.Forms.Label()
        Me.AmountPaidTextBox = New System.Windows.Forms.TextBox()
        Me.CommissionTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SalesGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(354, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PayToolStripMenuItem, Me.SummaryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'PayToolStripMenuItem
        '
        Me.PayToolStripMenuItem.Name = "PayToolStripMenuItem"
        Me.PayToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PayToolStripMenuItem.Text = "Pay"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SummaryToolStripMenuItem.Text = "Summary"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SalesGroupBox
        '
        Me.SalesGroupBox.Controls.Add(Me.WeeklySalesTextBox)
        Me.SalesGroupBox.Controls.Add(Me.SalespersonsNameTextBox)
        Me.SalesGroupBox.Controls.Add(Me.WeeklySalesLabel)
        Me.SalesGroupBox.Controls.Add(Me.SalespersonsNameLabel)
        Me.SalesGroupBox.Location = New System.Drawing.Point(13, 45)
        Me.SalesGroupBox.Name = "SalesGroupBox"
        Me.SalesGroupBox.Size = New System.Drawing.Size(327, 100)
        Me.SalesGroupBox.TabIndex = 1
        Me.SalesGroupBox.TabStop = False
        '
        'WeeklySalesTextBox
        '
        Me.WeeklySalesTextBox.Location = New System.Drawing.Point(121, 61)
        Me.WeeklySalesTextBox.Name = "WeeklySalesTextBox"
        Me.WeeklySalesTextBox.Size = New System.Drawing.Size(109, 20)
        Me.WeeklySalesTextBox.TabIndex = 3
        '
        'SalespersonsNameTextBox
        '
        Me.SalespersonsNameTextBox.Location = New System.Drawing.Point(121, 20)
        Me.SalespersonsNameTextBox.Name = "SalespersonsNameTextBox"
        Me.SalespersonsNameTextBox.Size = New System.Drawing.Size(180, 20)
        Me.SalespersonsNameTextBox.TabIndex = 2
        '
        'WeeklySalesLabel
        '
        Me.WeeklySalesLabel.AutoSize = True
        Me.WeeklySalesLabel.Location = New System.Drawing.Point(43, 64)
        Me.WeeklySalesLabel.Name = "WeeklySalesLabel"
        Me.WeeklySalesLabel.Size = New System.Drawing.Size(72, 13)
        Me.WeeklySalesLabel.TabIndex = 1
        Me.WeeklySalesLabel.Text = "Weekly Sales"
        '
        'SalespersonsNameLabel
        '
        Me.SalespersonsNameLabel.AutoSize = True
        Me.SalespersonsNameLabel.Location = New System.Drawing.Point(12, 23)
        Me.SalespersonsNameLabel.Name = "SalespersonsNameLabel"
        Me.SalespersonsNameLabel.Size = New System.Drawing.Size(103, 13)
        Me.SalespersonsNameLabel.TabIndex = 0
        Me.SalespersonsNameLabel.Text = "Salesperson's Name"
        '
        'AmountPaidLabel
        '
        Me.AmountPaidLabel.AutoSize = True
        Me.AmountPaidLabel.Location = New System.Drawing.Point(58, 183)
        Me.AmountPaidLabel.Name = "AmountPaidLabel"
        Me.AmountPaidLabel.Size = New System.Drawing.Size(70, 13)
        Me.AmountPaidLabel.TabIndex = 2
        Me.AmountPaidLabel.Text = "Amount Paid:"
        '
        'CommissionLabel
        '
        Me.CommissionLabel.AutoSize = True
        Me.CommissionLabel.Location = New System.Drawing.Point(63, 222)
        Me.CommissionLabel.Name = "CommissionLabel"
        Me.CommissionLabel.Size = New System.Drawing.Size(65, 13)
        Me.CommissionLabel.TabIndex = 3
        Me.CommissionLabel.Text = "Commission:"
        '
        'AmountPaidTextBox
        '
        Me.AmountPaidTextBox.Location = New System.Drawing.Point(134, 180)
        Me.AmountPaidTextBox.Name = "AmountPaidTextBox"
        Me.AmountPaidTextBox.ReadOnly = True
        Me.AmountPaidTextBox.Size = New System.Drawing.Size(109, 20)
        Me.AmountPaidTextBox.TabIndex = 4
        Me.AmountPaidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CommissionTextBox
        '
        Me.CommissionTextBox.Location = New System.Drawing.Point(134, 219)
        Me.CommissionTextBox.Name = "CommissionTextBox"
        Me.CommissionTextBox.ReadOnly = True
        Me.CommissionTextBox.Size = New System.Drawing.Size(109, 20)
        Me.CommissionTextBox.TabIndex = 5
        Me.CommissionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CommissionCalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 265)
        Me.Controls.Add(Me.CommissionTextBox)
        Me.Controls.Add(Me.AmountPaidTextBox)
        Me.Controls.Add(Me.CommissionLabel)
        Me.Controls.Add(Me.AmountPaidLabel)
        Me.Controls.Add(Me.SalesGroupBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "CommissionCalculatorForm"
        Me.Text = "Commission Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SalesGroupBox.ResumeLayout(False)
        Me.SalesGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesGroupBox As GroupBox
    Friend WithEvents WeeklySalesTextBox As TextBox
    Friend WithEvents SalespersonsNameTextBox As TextBox
    Friend WithEvents WeeklySalesLabel As Label
    Friend WithEvents SalespersonsNameLabel As Label
    Friend WithEvents AmountPaidLabel As Label
    Friend WithEvents CommissionLabel As Label
    Friend WithEvents AmountPaidTextBox As TextBox
    Friend WithEvents CommissionTextBox As TextBox
End Class
