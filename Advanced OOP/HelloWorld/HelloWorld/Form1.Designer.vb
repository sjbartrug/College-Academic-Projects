<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DisplayMessageButton = New System.Windows.Forms.Button()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DisplayMessageButton
        '
        Me.DisplayMessageButton.Location = New System.Drawing.Point(314, 258)
        Me.DisplayMessageButton.Name = "DisplayMessageButton"
        Me.DisplayMessageButton.Size = New System.Drawing.Size(187, 93)
        Me.DisplayMessageButton.TabIndex = 0
        Me.DisplayMessageButton.Text = "Display Message"
        Me.DisplayMessageButton.UseVisualStyleBackColor = True
        '
        'MessageLabel
        '
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(12, 150)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(776, 105)
        Me.MessageLabel.TabIndex = 1
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.DisplayMessageButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DisplayMessageButton As Button
    Friend WithEvents MessageLabel As Label

    Private Sub DisplayMessageButton_Click(sender As Object, e As EventArgs) Handles DisplayMessageButton.Click
        MessageLabel.Text = "Hello World"

    End Sub

    Private Sub MessageLabel_Click(sender As Object, e As EventArgs) Handles MessageLabel.Click

    End Sub
End Class
