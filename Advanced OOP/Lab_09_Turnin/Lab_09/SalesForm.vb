'Program:		Lab #9
'Programmer:	Sam Bartrug
'Date:			11/11/20
'Description:	Calculate sales price using the BookSale class.
'				Instantiate TheBookSale as a new object of the BookSale class.

Public Class SalesForm
    ' Declare the new object.
    Private TheBookSale As BookSale
    Private TheStudentBookSale As StudentBookSale ' Did NOT instantiate an object YET


    Private Sub CalculateSaleToolStripMenuItem_Click(ByVal sender As System.Object,
     ByVal e As System.EventArgs) Handles CalculateSaleToolStripMenuItem.Click
        ' Calculate the extended price for the sale.

        Try
            ' Look at if this is a student
            If StudentCheckBox.Checked = True Then
                ' This is a student, apply a discount
                TheStudentBookSale = New StudentBookSale(TitleTextBox.Text,
                                           Integer.Parse(QuantityTextBox.Text),
                                           Decimal.Parse(PriceTextBox.Text))
                ExtendedPriceTextBox.Text = TheStudentBookSale.ExtendedPrice.ToString("c")
            Else
                ' This is a regular Sale
                ' Instantiate the BookSale object and set the properties.
                TheBookSale = New BookSale(TitleTextBox.Text,
                                           Integer.Parse(QuantityTextBox.Text),
                                           Decimal.Parse(PriceTextBox.Text))
                ' Calculate and format the result.
                ExtendedPriceTextBox.Text = TheBookSale.ExtendedPrice.ToString("c")
            End If

        Catch ex As Exception
            If (MessageBox.Show(“Are you sure you want to delete the record?”, "Delete Records", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                TitleTextBox.Text = "success"
            End If

            MessageBox.Show("Enter numeric data.", "R 'n R Book Sales",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        ' Two ways to open a form
        ' Modally
        'SummaryForm.ShowDialog()
        ' Modelessly
        SummaryForm.Show()

    End Sub

    Private Sub SalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
