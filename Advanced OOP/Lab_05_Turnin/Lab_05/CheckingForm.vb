'Project:     Lab 5
'Programmer:  Sam Bartrug
'Date:        Fall 2019
'Description: This project maintains a checking account balance.
'             The requested transaction is calculated and 
'             the new balance is displayed.
'             A summary includes all transactions.

Public Class CheckingForm
    Const SERVICE_CHARGE_DECIMAL As Decimal = 10

    Dim BalanceDecimal As Decimal = 100
    Dim TotalDepositCountInteger, TotalCheckCountInteger, TotalServiceChargeCountInteger As Integer
    Dim TotalDepositAmountDecimal, TotalCheckAmountDecimal, TotalServiceChargeAmountDecimal As Decimal

    Private Sub CheckingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' When the form comes into memory
        ' Only happens once
        ' Initialization tasks
        BalanceTextBox.Text = BalanceDecimal.ToString("c")
    End Sub

    Sub ResetForm()
        ' clear form and reset input

        'reset the radio buttons
        DepositRadioButton.Checked = True
        DepositRadioButton.Checked = False

        With AmountTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Sub MakeDeposit(AmountDecimal As Decimal)
        ' Will take an amount and add it to our balance

        ' Deposit amount into balance
        BalanceDecimal += AmountDecimal

        ' Increment our totals
        TotalDepositCountInteger += 1
        TotalDepositAmountDecimal += AmountDecimal
    End Sub
    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'End the program

        Me.Close()
    End Sub

    Sub ServiceCharge(ByRef inBalanceDecimal As Decimal,
                      Optional inAmountDecimal As Decimal = SERVICE_CHARGE_DECIMAL)
        ' Apply a service charge, subtract amount from our balance
        inBalanceDecimal = inBalanceDecimal - inAmountDecimal

        ' Add onto totals
        TotalServiceChargeCountInteger += 1
        TotalServiceChargeAmountDecimal += inAmountDecimal
    End Sub

    Function WithdrawCheck(inAmountDecimal As Decimal,
                           ByVal inBalanceDecimal As Decimal) As Decimal
        ' Withdraw the check from account IF we have funds

        ' Check for funds
        If inAmountDecimal <= inBalanceDecimal Then
            ' We have enough money
            inBalanceDecimal -= inAmountDecimal
            TotalCheckCountInteger += 1
            TotalCheckAmountDecimal += inAmountDecimal
        Else
            ' We don't have enough money
            MessageBox.Show("Insufficient funds, service charge applied.", "Not Enough Money", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ServiceCharge(inBalanceDecimal, SERVICE_CHARGE_DECIMAL)

        End If
        ' Return a result
        ' Return the new balance we computed
        Return inBalanceDecimal ' Return statement can be anywhere in the function but once it runs we immediatly leave the function
    End Function

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        'Calculate the transaction and display the new balance.
        Dim AmountDecimal As Decimal

        If DepositRadioButton.Checked Or CheckRadioButton.Checked Or ChargeRadioButton.Checked Then
            Try
                AmountDecimal = Decimal.Parse(AmountTextBox.Text)

                'Calculate each transaction and keep track of summary information.
                If DepositRadioButton.Checked Then
                    ' deposit funds
                    MakeDeposit(AmountDecimal)

                ElseIf CheckRadioButton.Checked Then
                    ' withdraw funds 
                    BalanceDecimal = WithdrawCheck(AmountDecimal, BalanceDecimal)
                Else
                    ' perform service charge
                    ServiceCharge(BalanceDecimal, AmountDecimal)
                End If

                ' output results
                BalanceTextBox.Text = BalanceDecimal.ToString("c")

                ' clear form
                ResetForm()


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


    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' clear form
        ResetForm()

    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click
        ' display summary
        Dim MessageString As String

        MessageString = "Total # of Deposits: " & TotalDepositCountInteger.ToString & ControlChars.NewLine
        MessageString &= "Total Amount of Deposits: " & TotalDepositAmountDecimal.ToString("c") &
            ControlChars.NewLine & ControlChars.NewLine
        MessageString &= "Total # of Checks: " & TotalCheckCountInteger.ToString & ControlChars.NewLine
        MessageString &= "Total Amount of Checks: " & TotalCheckAmountDecimal.ToString("c") &
            ControlChars.NewLine & ControlChars.NewLine
        MessageString &= "Total # of Service Charges: " & TotalServiceChargeCountInteger.ToString & ControlChars.NewLine
        MessageString &= "Total Amount of Service Charges: " & TotalServiceChargeAmountDecimal.ToString("c") &
            ControlChars.NewLine & ControlChars.NewLine

        MessageBox.Show(MessageString, "Account Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class

