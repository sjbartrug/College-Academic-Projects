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
        Me.SalesTotalTitleLabel = New System.Windows.Forms.Label()
        Me.SalesCountTitleLabel = New System.Windows.Forms.Label()
        Me.TotalStudentDiscountsTitleLabel = New System.Windows.Forms.Label()
        Me.SalesTotalLabel = New System.Windows.Forms.Label()
        Me.SalesCountLabel = New System.Windows.Forms.Label()
        Me.TotalStudentDiscountsLabel = New System.Windows.Forms.Label()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SalesTotalTitleLabel
        '
        Me.SalesTotalTitleLabel.AutoSize = True
        Me.SalesTotalTitleLabel.Location = New System.Drawing.Point(12, 19)
        Me.SalesTotalTitleLabel.Name = "SalesTotalTitleLabel"
        Me.SalesTotalTitleLabel.Size = New System.Drawing.Size(63, 13)
        Me.SalesTotalTitleLabel.TabIndex = 0
        Me.SalesTotalTitleLabel.Text = "Sales Total:"
        '
        'SalesCountTitleLabel
        '
        Me.SalesCountTitleLabel.AutoSize = True
        Me.SalesCountTitleLabel.Location = New System.Drawing.Point(12, 66)
        Me.SalesCountTitleLabel.Name = "SalesCountTitleLabel"
        Me.SalesCountTitleLabel.Size = New System.Drawing.Size(67, 13)
        Me.SalesCountTitleLabel.TabIndex = 1
        Me.SalesCountTitleLabel.Text = "Sales Count:"
        '
        'TotalStudentDiscountsTitleLabel
        '
        Me.TotalStudentDiscountsTitleLabel.AutoSize = True
        Me.TotalStudentDiscountsTitleLabel.Location = New System.Drawing.Point(12, 113)
        Me.TotalStudentDiscountsTitleLabel.Name = "TotalStudentDiscountsTitleLabel"
        Me.TotalStudentDiscountsTitleLabel.Size = New System.Drawing.Size(118, 13)
        Me.TotalStudentDiscountsTitleLabel.TabIndex = 2
        Me.TotalStudentDiscountsTitleLabel.Text = "TotalStudentDiscounts:"
        '
        'SalesTotalLabel
        '
        Me.SalesTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesTotalLabel.Location = New System.Drawing.Point(136, 19)
        Me.SalesTotalLabel.Name = "SalesTotalLabel"
        Me.SalesTotalLabel.Size = New System.Drawing.Size(135, 25)
        Me.SalesTotalLabel.TabIndex = 3
        '
        'SalesCountLabel
        '
        Me.SalesCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SalesCountLabel.Location = New System.Drawing.Point(136, 65)
        Me.SalesCountLabel.Name = "SalesCountLabel"
        Me.SalesCountLabel.Size = New System.Drawing.Size(135, 25)
        Me.SalesCountLabel.TabIndex = 4
        '
        'TotalStudentDiscountsLabel
        '
        Me.TotalStudentDiscountsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalStudentDiscountsLabel.Location = New System.Drawing.Point(136, 111)
        Me.TotalStudentDiscountsLabel.Name = "TotalStudentDiscountsLabel"
        Me.TotalStudentDiscountsLabel.Size = New System.Drawing.Size(135, 25)
        Me.TotalStudentDiscountsLabel.TabIndex = 5
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(196, 153)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 6
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(283, 188)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.TotalStudentDiscountsLabel)
        Me.Controls.Add(Me.SalesCountLabel)
        Me.Controls.Add(Me.SalesTotalLabel)
        Me.Controls.Add(Me.TotalStudentDiscountsTitleLabel)
        Me.Controls.Add(Me.SalesCountTitleLabel)
        Me.Controls.Add(Me.SalesTotalTitleLabel)
        Me.Name = "SummaryForm"
        Me.Text = "SummaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SalesTotalTitleLabel As Label
    Friend WithEvents SalesCountTitleLabel As Label
    Friend WithEvents TotalStudentDiscountsTitleLabel As Label
    Friend WithEvents SalesTotalLabel As Label
    Friend WithEvents SalesCountLabel As Label
    Friend WithEvents TotalStudentDiscountsLabel As Label
    Friend WithEvents OkButton As Button
End Class
