' Project: Lab 2
' Author:  Sam Bartrug
' Description: This project inputs sales information for books.  It calculates the extended price and discount for a sale and maintains summary information for all sales.  
'              Uses variables, constants, calculations, error handling and a message box
'
Public Class BookSaleForm
    ' Class Level
    ' Constants, Class Level Variables
    Const DISCOUNT_RATE_DECIMAL As Decimal = 0.15
    Dim TotalBooksSoldInteger, SaleCountInteger As Integer
    Dim DiscountTotalDecimal, FinalPriceTotalDecimal As Decimal
    Private Sub ExitButton_Click(sender As System.Object, e As System.EventArgs) Handles ExitButton.Click
        ' exit program
        Me.Close()
        ' Application exit
    End Sub

    Private Sub ClearButton_Click(sender As System.Object, e As System.EventArgs) Handles ClearButton.Click
        ' Clear previous amounts from the all text boxs besides those in the summary group box
        QuantityTextBox.Clear()
        TitleTextBox.Clear()
        PriceTextBox.Clear()
        ExtendedPriceTextBox.Clear()
        DiscountTextBox.Clear()
        DiscountedPriceTextBox.Clear()
        ' Focuses on the Quantity text box to begin inputing data again
        QuantityTextBox.Focus()
    End Sub

    Private Sub CalculateButton_Click(sender As System.Object, e As System.EventArgs) Handles CalculateButton.Click
        ' Calculate the value of a sale
        Dim QuantitiyInteger As Integer ' Initialized to 0 as default
        Dim TitleString As String
        Dim PriceDecimal, ExtendedPriceDecimal, DiscountDecimal, FinalPriceDecimal As Decimal ' Initialized to 0 as default
        Dim AverageDiscountDecimal As Decimal

        Try
            ' Try to run a statement, if it succeeds we move on, but if it fails it branches to the catch
            ' Convert text entered into textbox into a numeric value
            QuantitiyInteger = Integer.Parse(QuantityTextBox.Text)

            Try
                ' Try to run a statement, if it succeeds we move on, but if it fails it branches to the catch
                ' Convert text entered into textbox into a numeric value
                PriceDecimal = Decimal.Parse(PriceTextBox.Text)

                'Perform Calculations for extended price, discount, and final discounted price
                ExtendedPriceDecimal = QuantitiyInteger * PriceDecimal
                DiscountDecimal = ExtendedPriceDecimal * DISCOUNT_RATE_DECIMAL
                FinalPriceDecimal = ExtendedPriceDecimal - DiscountDecimal

                TotalBooksSoldInteger += QuantitiyInteger ' Increment number of books sold
                DiscountTotalDecimal += DiscountDecimal ' Increment discount total
                FinalPriceTotalDecimal += FinalPriceDecimal ' Increment final total price
                SaleCountInteger += 1 ' Increment number of sales
                AverageDiscountDecimal = DiscountTotalDecimal / SaleCountInteger

                'Output Results
                ExtendedPriceTextBox.Text = ExtendedPriceDecimal.ToString("c") ' Formats it as currency and displays it as a string
                DiscountTextBox.Text = DiscountDecimal.ToString("c") ' Formats it as currency and displays it as a string
                DiscountedPriceTextBox.Text = FinalPriceDecimal.ToString("c") ' Formats it as currency and displays it as a string

                QuantitySumTextBox.Text = TotalBooksSoldInteger.ToString() ' Displays it as a string
                DiscountSumTextBox.Text = DiscountTotalDecimal.ToString("c") ' Formats it as currency and displays it as a string
                DiscountedAmountSumTextBox.Text = FinalPriceTotalDecimal.ToString("c") ' Formats it as currency and displays it as a string
                AverageDiscountTextBox.Text = AverageDiscountDecimal.ToString("c") ' Formats it as currency and displays it as a string

            Catch PriceFormatException As FormatException ' If the try fails for price to convert it to a numeric value an error box displaying format error with display
                MessageBox.Show("Price must be numeric.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With PriceTextBox
                    .Focus() ' Puts cursor in price textbox
                    .SelectAll() ' Highlights all text in price textbox
                End With

            End Try

        Catch QuantityFormatException As FormatException ' If the try fails for quantity to convert it to a numeric value an error box displaying format error with display
            MessageBox.Show("Quantity must be numeric.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With QuantityTextBox
                .Focus() ' Puts cursor in quantity textbox
                .SelectAll() ' Highlights all text in quantity textbox
            End With

        End Try

        ' Could be outputting results with bad input
    End Sub

End Class
