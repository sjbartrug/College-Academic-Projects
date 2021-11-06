<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
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
        Me.TotalSalesLabel = New System.Windows.Forms.Label()
        Me.TotalCommissionsLabel = New System.Windows.Forms.Label()
        Me.TotalPayLabel = New System.Windows.Forms.Label()
        Me.TotalSalesTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCommissionsTextBox = New System.Windows.Forms.TextBox()
        Me.TotalPayTextBox = New System.Windows.Forms.TextBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TotalSalesLabel
        '
        Me.TotalSalesLabel.AutoSize = True
        Me.TotalSalesLabel.Location = New System.Drawing.Point(41, 42)
        Me.TotalSalesLabel.Name = "TotalSalesLabel"
        Me.TotalSalesLabel.Size = New System.Drawing.Size(63, 13)
        Me.TotalSalesLabel.TabIndex = 0
        Me.TotalSalesLabel.Text = "Total Sales:"
        '
        'TotalCommissionsLabel
        '
        Me.TotalCommissionsLabel.AutoSize = True
        Me.TotalCommissionsLabel.Location = New System.Drawing.Point(41, 72)
        Me.TotalCommissionsLabel.Name = "TotalCommissionsLabel"
        Me.TotalCommissionsLabel.Size = New System.Drawing.Size(97, 13)
        Me.TotalCommissionsLabel.TabIndex = 1
        Me.TotalCommissionsLabel.Text = "Total Commissions:"
        '
        'TotalPayLabel
        '
        Me.TotalPayLabel.AutoSize = True
        Me.TotalPayLabel.Location = New System.Drawing.Point(41, 102)
        Me.TotalPayLabel.Name = "TotalPayLabel"
        Me.TotalPayLabel.Size = New System.Drawing.Size(55, 13)
        Me.TotalPayLabel.TabIndex = 2
        Me.TotalPayLabel.Text = "Total Pay:"
        '
        'TotalSalesTextBox
        '
        Me.TotalSalesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalSalesTextBox.Location = New System.Drawing.Point(154, 43)
        Me.TotalSalesTextBox.Name = "TotalSalesTextBox"
        Me.TotalSalesTextBox.ReadOnly = True
        Me.TotalSalesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalSalesTextBox.TabIndex = 3
        '
        'TotalCommissionsTextBox
        '
        Me.TotalCommissionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalCommissionsTextBox.Location = New System.Drawing.Point(154, 73)
        Me.TotalCommissionsTextBox.Name = "TotalCommissionsTextBox"
        Me.TotalCommissionsTextBox.ReadOnly = True
        Me.TotalCommissionsTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalCommissionsTextBox.TabIndex = 4
        '
        'TotalPayTextBox
        '
        Me.TotalPayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalPayTextBox.Location = New System.Drawing.Point(154, 103)
        Me.TotalPayTextBox.Name = "TotalPayTextBox"
        Me.TotalPayTextBox.ReadOnly = True
        Me.TotalPayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalPayTextBox.TabIndex = 5
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(179, 139)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 6
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 188)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.TotalPayTextBox)
        Me.Controls.Add(Me.TotalCommissionsTextBox)
        Me.Controls.Add(Me.TotalSalesTextBox)
        Me.Controls.Add(Me.TotalPayLabel)
        Me.Controls.Add(Me.TotalCommissionsLabel)
        Me.Controls.Add(Me.TotalSalesLabel)
        Me.Name = "SummaryForm"
        Me.Text = "Summary Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TotalSalesLabel As Label
    Friend WithEvents TotalCommissionsLabel As Label
    Friend WithEvents TotalPayLabel As Label
    Friend WithEvents TotalSalesTextBox As TextBox
    Friend WithEvents TotalCommissionsTextBox As TextBox
    Friend WithEvents TotalPayTextBox As TextBox
    Friend WithEvents CloseButton As Button
End Class
