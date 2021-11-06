'Project:     Lab 4
'Programmer:  Sam Bartrug
'Date:        Fall 2020
'Description: This project maintains a checking account balance.
'             The requested transaction is calculated and 
'             the new balance is displayed.
'             A summary includes all transactions.

Public Class CheckingForm
    ' Class level variables
    Dim BalanceDecimal As Decimal = 100 ' Starting balance
    Const SERVICE_CHARGE_DECIMAL As Decimal = 10 ' Be our default service charge
    Dim TotalDepositCountInteger, TotalChecksCountInteger, TotalServiceChargeInteger As Integer ' Keep track of # of deposits, checks, and service charges
    Dim TotalDepositAmountDecimal, TotalChecksAmountDecimal, TotalServiceChargeAmountDecimal As Decimal ' Keep track of deposit amounts

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'End the program

        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'Calculate the transaction and display the new balance.
        Dim AmountDecimal As Decimal

        If (DepositRadioButton.Checked = True) OrElse (CheckRadioButton.Checked = True) OrElse (ChargeRadioButton.Checked = True) Then
            Try
                AmountDecimal = Decimal.Parse(AmountTextBox.Text)

                'Calculate each transaction and keep track of summary information.
                If (DepositRadioButton.Checked) Then
                    ' They selected a deposit and we need to add it to our balance
                    BalanceDecimal += AmountDecimal
                    ' Increment number of deposits and total amount
                    TotalDepositCountInteger += 1
                    TotalDepositAmountDecimal += AmountDecimal
                ElseIf (CheckRadioButton.Checked) Then
                    ' They selected a check, we need sufficient funds
                    If AmountDecimal > BalanceDecimal Then
                        ' Don't have enough money
                        MessageBox.Show("Insufficient Funds: $10 Service Charge", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        BalanceDecimal -= SERVICE_CHARGE_DECIMAL ' Subtract the service charge
                        ' Increment number of service charges and total amount
                        TotalServiceChargeInteger += 1
                        TotalServiceChargeAmountDecimal += SERVICE_CHARGE_DECIMAL
                    Else
                        ' We have enough money, remove from our account
                        BalanceDecimal -= AmountDecimal
                        ' Increment number of checks and total amount
                        TotalChecksCountInteger += 1
                        TotalChecksAmountDecimal += AmountDecimal
                    End If
                Else
                    ' It's not a deposit or a check, must be a service charge
                    ' Subtract from our balance
                    BalanceDecimal -= AmountDecimal
                    ' Increment number of checks and total amount
                    TotalServiceChargeInteger += 1
                    TotalServiceChargeAmountDecimal += AmountDecimal
                End If

                BalanceTextBox.Text = BalanceDecimal.ToString("c")

                ' Reset the form
                ' Try NOT to duplicate code
                ' Call the event handler
                ClearButton_Click(sender, e)

            Catch AmountException As FormatException
                MessageBox.Show("Please make sure that only numeric data has been entered.",
                    "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With AmountTextBox
                    .Focus()
                    .SelectAll()
                End With
            Catch AnyException As Exception
                MessageBox.Show("Error: " & AnyException.Message)
            End Try
        Else
            MessageBox.Show("Please select deposit, check, or service charge", "Input needed")
        End If
    End Sub

    Private Sub CheckingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Only ONE time when the program starts

        ' Output my initial balance
        BalanceTextBox.Text = BalanceDecimal.ToString("c")
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Reset our form for next transaction

        DepositRadioButton.Checked = True ' Unselect any radio button in this group that was selected
        DepositRadioButton.Checked = False ' Unselects deposit radio button

        With AmountTextBox
            .Clear() ' Clear it
            .Focus() ' Put cursor in it
        End With

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        ' Display summary
        Dim MessageString As String

        MessageString = String.Format("Total # of Deposits: {1}{0}" &
                                      "Total Amount of Deposits: {2:c}{0}{0}" &
                                      "Total # of Checks: {3}{0}" &
                                      "Total Amount of Checks: {4:c}{0}{0}" &
                                      "Total # of Service Charges: {5}{0}" &
                                      "Total Amount of Service Charges: {6:c}{0}",
                                      ControlChars.NewLine,
                                      TotalDepositCountInteger, TotalDepositAmountDecimal,
                                      TotalChecksCountInteger, TotalChecksAmountDecimal,
                                      TotalServiceChargeInteger, TotalServiceChargeAmountDecimal)

        MessageBox.Show(MessageString, "Account Summary")

    End Sub
End Class

