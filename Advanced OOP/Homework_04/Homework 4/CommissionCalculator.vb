'Program:		Homework_04
'Programmer:	Sam Bartrug
'Date:			11/11/20
'Description:	Calculate pay and commission using PayAndCommissionCalculator Class
'				Instantiate Calculator as a new object of the PayAndCommissionCalculator class.
Public Class CommissionCalculatorForm
    Private Calculator As PayAndCommissionCalculator
    Private Sub PayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayToolStripMenuItem.Click
        ' Calculate amount paid and commission
        Try
            ' Create new instance of the class
            Calculator = New PayAndCommissionCalculator(SalespersonsNameTextBox.Text, Convert.ToInt32(WeeklySalesTextBox.Text))
            ' Display the amount paid and the commission from this instance of the class
            AmountPaidTextBox.Text = Calculator.Pay.ToString("c")
            CommissionTextBox.Text = Calculator.Commission.ToString("c")
        Catch ex As FormatException
            ' If a numeric sales amount was not entered then a format exception is thrown
            MessageBox.Show("Please enter a numeric sales amount.",
                            "Input Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        Catch ex1 As ArgumentOutOfRangeException
            ' If a name is not entered then an argument out of range exception is thrown
            MessageBox.Show(ex1.Message)

        End Try
        ' Resets the input textboxes
        SalespersonsNameTextBox.Clear()
        WeeklySalesTextBox.Clear()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Display the summary form modelessly
        SummaryForm.Show()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Closes program
        Me.Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clears all text and focuses on first text box
        With SalespersonsNameTextBox
            .Clear()
            .Focus()
        End With
        WeeklySalesTextBox.Clear()
        AmountPaidTextBox.Clear()
        CommissionTextBox.Clear()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ' Display the about box modally
        Homework_4AboutBox.ShowDialog()
    End Sub
End Class
