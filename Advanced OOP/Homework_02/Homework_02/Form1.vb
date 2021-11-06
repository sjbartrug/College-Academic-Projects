Public Class CoffeeCalculatorForm
    Const SALES_TAX_DECIMAL As Decimal = 0.075
    Const CAPPUCCINO_PRICE_DECIMAL As Decimal = 3.25
    Const ESPRESSO_PRICE_DECIMAL As Decimal = 2.75
    Const LATTE_PRICE_DECIMAL As Decimal = 2.15
    Const ICED_LATTE_OR_ICED_CAPPUCINO_PRICE_DECIMAL As Decimal = 2.35
    Dim TotalSalesDecimal As Decimal

    Sub Sale(CoffeeCostDecimal, QuantityInteger) ' Sale calculates the cost of the sale and adds it to total sales section of the program
        Dim TakeoutBoolean As Boolean = TakeoutCheckBox.CheckState ' Checks to see if the takeout checkbox was selected
        Dim SaleAmountDecimal As Decimal = CoffeeCostDecimal * QuantityInteger ' Declares the sale amount by the cost of this specific coffee along with the quantity of them
        If TakeoutBoolean = False Then ' If the takeout checkbox is unselected, the sales tax must be added
            SaleAmountDecimal += SALES_TAX_DECIMAL * (CoffeeCostDecimal * QuantityInteger)
        End If
        ItemAmountTextBox.Text = SaleAmountDecimal.ToString("c")
        TotalSalesListBox.Items.Add(SaleAmountDecimal.ToString("c")) ' Adds the sale to the total sales list box
        TotalSalesDecimal += SaleAmountDecimal
        Reset() ' Resets the form

    End Sub

    Sub Reset()
        ' Clears the quantity textbox and focuses on it for future inputs
        With QuantityTextBox
            .Focus()
            .Clear()
        End With
        ' Resets radio buttons to original selection state
        CappuccinoRadioButton.Checked = True
        ' Resets takeout checkbox to original selection state
        TakeoutCheckBox.Checked = False
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Declares all the needed variables
        Dim CoffeeCostDecimal As Decimal
        Dim QuantityInteger As Integer

        Try ' Try and see if the quantity entered was a valid integer
            QuantityInteger = Integer.Parse(QuantityTextBox.Text)

            If QuantityInteger > 0 Then
                ' Depending on the coffee selected by the radio button, the price of the sale changes
                If CappuccinoRadioButton.Checked = True Then
                    CoffeeCostDecimal = CAPPUCCINO_PRICE_DECIMAL
                ElseIf EspressoRadioButton.Checked = True Then
                    CoffeeCostDecimal = ESPRESSO_PRICE_DECIMAL
                ElseIf LatteRadioButton.Checked = True Then
                    CoffeeCostDecimal = LATTE_PRICE_DECIMAL
                ElseIf IcedLatteRadioButton.Checked = True OrElse IcedCappuccinoRadioButton.Checked = True Then
                    CoffeeCostDecimal = ICED_LATTE_OR_ICED_CAPPUCINO_PRICE_DECIMAL
                End If
                ' Call for sale
                Sale(CoffeeCostDecimal, QuantityInteger)
                ' Updates the total sales text box with the most current information
                TotalSalesTextBox.Text = TotalSalesDecimal.ToString("c")
            Else
                MessageBox.Show("Please enter a value greater than 0.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch AmountException As FormatException ' If the parse fails, an error message box displays
            MessageBox.Show("Please enter a numeric value.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Reset() ' Resets the form

        End Try
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        ' Exits program
        Me.Close()
    End Sub
End Class
