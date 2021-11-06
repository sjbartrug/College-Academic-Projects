' Project: Homework 1
' Author:  Sam Bartrug
' Description: This project inputs member and rental information for movies.  It calculates the rental amount and discount for a sale and maintains summary information for all sales.  
'              Uses variables, constants, calculations, error handling and a message box
'
Public Class VideoRentalCalculator
    ' Class Level
    ' Constants, Class Level Variables
    Const RENTAL_AMOUNT As Decimal = 3.99
    Const DISCOUNT_RATE_DECIMAL As Decimal = 0.2
    Dim TotalCustomers As Integer
    Dim TotalRentals As Decimal
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Create variables for all values
        Dim MemberNumberString As String
        Dim QuantityInteger As Integer
        Dim PriceDecimal, DiscountDecimal, DiscountedPriceDecimal As Decimal
        Try
            ' Try to run a statement, if it succeeds we move on, but if it fails it branches to the catch
            ' Convert text entered into textbox into a numeric value
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)

            ' Perform calculations for rental amount, discount amount, and the discounted amount due
            PriceDecimal = RENTAL_AMOUNT * QuantityInteger
            DiscountDecimal = PriceDecimal * DISCOUNT_RATE_DECIMAL
            DiscountedPriceDecimal = PriceDecimal - DiscountDecimal

            ' Increment the total amount of customers and the total of the rentals
            TotalCustomers += 1
            TotalRentals += DiscountedPriceDecimal

            ' Output results
            RentalAmountTextBox.Text = PriceDecimal.ToString("c") ' Displays value as a decimal formated as currency
            DiscountTextBox.Text = DiscountDecimal.ToString("c") ' Displays value as a decimal formated as currency
            AmountDueTextBox.Text = DiscountedPriceDecimal.ToString("c") ' Displays value as a decimal formated as currency
            TotalCustomersTextBox.Text = TotalCustomers.ToString ' Displays value as a decimal
            TotalRentalsTextBox.Text = TotalRentals.ToString("c") ' Displays value as a decimal formated as currency

        Catch QuantityFormatException As FormatException ' If the try fails for price to convert it to a numeric value an error box displaying format error with display
            MessageBox.Show("Quantity Must Be Numeric.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With QuantityTextBox
                .Focus() ' Puts cursor in price textbox
                .SelectAll() ' Highlights all text in price textbox
            End With
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Clear previous amounts from the all text boxs besides those in the summary group box
        MemberNumberTextBox.Clear()
        QuantityTextBox.Clear()
        RentalAmountTextBox.Clear()
        DiscountTextBox.Clear()
        AmountDueTextBox.Clear()
        ' Focuses on Quantity text box to begin inputing data again since Member Number is just for show
        QuantityTextBox.Focus()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' exit program
        Me.Close()
        ' Application exit
    End Sub

End Class
