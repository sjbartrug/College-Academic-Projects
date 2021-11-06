'Program:		Homework_04
'Programmer:	Sam Bartrug
'Date:			11/11/20
'Description:	Calculate pay and commission using PayAndCommissionCalculator Class
'				Instantiate Calculator as a new object of the PayAndCommissionCalculator class.
Public Class SummaryForm
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        ' Closes the summary box
        Me.Close()
    End Sub

    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Displays the total values for all sales
        TotalSalesTextBox.Text = PayAndCommissionCalculator.TotalSales.ToString("c")
        TotalCommissionsTextBox.Text = PayAndCommissionCalculator.TotalCommission.ToString("c")
        TotalPayTextBox.Text = PayAndCommissionCalculator.TotalPay.ToString("c")
    End Sub

End Class