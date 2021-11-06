'Class Name: Default
'Programmer: Sam Bartrug
'Date: 11/25/20
'Description: Default web page
'Project: Lab 10
Partial Class _Default
    Inherits System.Web.UI.Page

    Private DiscountTotalDecimal As Decimal

    Protected Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        ' Calculate the sale
        Dim TheBookSale As BookSale

        Try
            ' Convert the input values to numeric values
            TheBookSale = New BookSale(TitleTextBox.Text,
                                       Convert.ToInt32(QuantityTextBox.Text),
                                       Convert.ToDecimal(PriceTextBox.Text))

            ' Add to the discount total
            DiscountTotalDecimal += TheBookSale.Discount

            ' Save that new total back to the hidden field
            DiscountHiddenField.Value = DiscountTotalDecimal.ToString

            ' Output the discount total
            DiscountTotalLabel.Text = "The total discounts is: " & DiscountTotalDecimal.ToString("c")

            ' Output the result
            With TheBookSale
                ExtendedPriceTextBox.Text = .ExtendedPrice.ToString("c")
                DiscountTextBox.Text = .Discount.ToString("c")
                DiscountedPriceTextBox.Text = .DiscountedPrice.ToString("c")
            End With

        Catch ex As FormatException
            ' In case the convert failed
            ErrorMessageLabel.Text = "You must enter numeric data for price & quantity"
        End Try
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Turn off unobtrusive validation
        Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None

        ' Turn hidden field value (which is a string) into a number
        DiscountTotalDecimal = Decimal.Parse(DiscountHiddenField.Value)
    End Sub

    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Reset the form
        QuantityTextBox.Text = ""
        TitleTextBox.Text = ""
        PriceTextBox.Text = ""
        ExtendedPriceTextBox.Text = ""
        DiscountTextBox.Text = ""
        DiscountedPriceTextBox.Text = ""

    End Sub
End Class
