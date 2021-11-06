<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Addition_Form
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
        Me.AdditionButton = New System.Windows.Forms.Button()
        Me.FirstIntegerTextBox = New System.Windows.Forms.TextBox()
        Me.SecondIntegerTextBox = New System.Windows.Forms.TextBox()
        Me.FirstIntegerLabel = New System.Windows.Forms.Label()
        Me.SecondIntegerLabel = New System.Windows.Forms.Label()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AdditionButton
        '
        Me.AdditionButton.Location = New System.Drawing.Point(82, 93)
        Me.AdditionButton.Name = "AdditionButton"
        Me.AdditionButton.Size = New System.Drawing.Size(120, 23)
        Me.AdditionButton.TabIndex = 0
        Me.AdditionButton.Text = "Add Integers"
        Me.AdditionButton.UseVisualStyleBackColor = True
        '
        'FirstIntegerTextBox
        '
        Me.FirstIntegerTextBox.Location = New System.Drawing.Point(19, 52)
        Me.FirstIntegerTextBox.Name = "FirstIntegerTextBox"
        Me.FirstIntegerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstIntegerTextBox.TabIndex = 1
        '
        'SecondIntegerTextBox
        '
        Me.SecondIntegerTextBox.Location = New System.Drawing.Point(165, 52)
        Me.SecondIntegerTextBox.Name = "SecondIntegerTextBox"
        Me.SecondIntegerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SecondIntegerTextBox.TabIndex = 2
        '
        'FirstIntegerLabel
        '
        Me.FirstIntegerLabel.AutoSize = True
        Me.FirstIntegerLabel.Location = New System.Drawing.Point(16, 36)
        Me.FirstIntegerLabel.Name = "FirstIntegerLabel"
        Me.FirstIntegerLabel.Size = New System.Drawing.Size(93, 13)
        Me.FirstIntegerLabel.TabIndex = 4
        Me.FirstIntegerLabel.Text = "Enter First Integer:"
        '
        'SecondIntegerLabel
        '
        Me.SecondIntegerLabel.AutoSize = True
        Me.SecondIntegerLabel.Location = New System.Drawing.Point(162, 36)
        Me.SecondIntegerLabel.Name = "SecondIntegerLabel"
        Me.SecondIntegerLabel.Size = New System.Drawing.Size(111, 13)
        Me.SecondIntegerLabel.TabIndex = 5
        Me.SecondIntegerLabel.Text = "Enter Second Integer:"
        '
        'ResultLabel
        '
        Me.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultLabel.Location = New System.Drawing.Point(16, 132)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(249, 40)
        Me.ResultLabel.TabIndex = 6
        Me.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Addition_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 196)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.SecondIntegerLabel)
        Me.Controls.Add(Me.FirstIntegerLabel)
        Me.Controls.Add(Me.SecondIntegerTextBox)
        Me.Controls.Add(Me.FirstIntegerTextBox)
        Me.Controls.Add(Me.AdditionButton)
        Me.Name = "Addition_Form"
        Me.Text = "Addition Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AdditionButton As Button
    Friend WithEvents FirstIntegerTextBox As TextBox
    Friend WithEvents SecondIntegerTextBox As TextBox
    Friend WithEvents FirstIntegerLabel As Label
    Friend WithEvents SecondIntegerLabel As Label
    Friend WithEvents ResultLabel As Label
End Class
