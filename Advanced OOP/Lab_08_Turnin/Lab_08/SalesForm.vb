'Program:		Lab #7
'Programmer:	Sam Bartrug
'Date:			11/4/20
'Description:	Calculate sales price using the BookSale class.
'				Instantiate TheBookSale as a new object of the BookSale class.

Public Class SalesForm
    ' Declare the new object.
    Private TheBookSale As BookSale

    Private Sub CalculateSaleToolStripMenuItem_Click(ByVal sender As System.Object,
     ByVal e As System.EventArgs) Handles CalculateSaleToolStripMenuItem.Click
        ' Calculate the extended price for the sale.
        Try
            TheBookSale = New BookSale(TitleTextBox.Text,
                                       Integer.Parse(QuantityTextBox.Text),
                                       Convert.ToDecimal(PriceTextBox.Text))
            ' Output the result
            ExtendedPriceTextBox.Text = TheBookSale.ExtendedPrice.ToString("c")

            ' Exception for if user does not input numeric data
        Catch ex As FormatException
            MessageBox.Show("You must enter numeric data.")
            'Exception if quantity or price is not a positive integer
        Catch ex1 As ArgumentOutOfRangeException
            MessageBox.Show(ex1.Message)
        End Try
    End Sub

    Private Sub ClearToolStripMenuItem_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clear the screen controls.

        QuantityTextBox.Clear()
        PriceTextBox.Clear()
        ExtendedPriceTextBox.Clear()
        With TitleTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        ' Exit the program.

        Me.Close()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(ByVal sender As System.Object,
      ByVal e As System.EventArgs) Handles SummaryToolStripMenuItem.Click
        ' Display the sales summary information.
        MessageBox.Show(String.Format("Sales Total: {0:c}{2}Sales Count: {1}",
                                      BookSale.SalesTotal,
                                      BookSale.SalesCount,
                                      ControlChars.NewLine),
                                      "Book Sale Summary")
    End Sub

End Class
