Public Class TicketSalesForm
    'Project: ConcertTicketSales
    'Author: Sam Bartrug 
    'Date: Fall 2020
    'Description: 
    'Allow for the purchase of concert tickets and create a summary of the purchases

    ' Create the class level variables
    Dim TicketPriceArray() As Integer = {65, 60, 20, 10}
    Dim SummaryArray(3) As Integer

    ' Ticket summary sub to calculate the summary
    Sub TicketSummary()
        ' Creates the header of the text box
        TicketSummaryTextBox.Text = String.Format("Section{0}{0}# of Tickets{0}{0}Total",
                                                  ControlChars.Tab,
                                                  ControlChars.NewLine)
        ' Adds summary information to the text box using a for loop to go through each section, listing how many tickets have sold and the sale total
        For counter As Integer = 0 To SummaryArray.Length - 1
            TicketSummaryTextBox.Text &= String.Format("{1}{2} {0}{0} {3} {0}{0}{4:c}",
                                                       ControlChars.Tab,
                                                       ControlChars.NewLine,
                                                       SectionListBox.Items(counter).ToString,
                                                       SummaryArray(counter).ToString,
                                                       SummaryArray(counter) * TicketPriceArray(counter).ToString)
        Next
    End Sub

    Private Sub PurchaseTicketsButton_Click(sender As Object, e As EventArgs) Handles PurchaseTicketsButton.Click
        Dim QuantityInteger As Integer
        ' Try to see if a section has been selected
        Try
            If (SectionListBox.SelectedIndex = -1) Then
                Throw New FormatException
            End If
            ' Try and convert the quantity of tickets requested into an integer
            Try
                QuantityInteger = Convert.ToInt32(NumberOfTicketsTextBox.Text)

                ' Use string.format to output the summary of how much a single section ticket purchase would cost with the amount per ticket
                SingleTicketPurchaseSummaryLabel.Text = String.Format("Purchased {0} ticket(s) {1} at {2} per ticket",
                                                                      QuantityInteger,
                                                                      ControlChars.NewLine,
                                                                      TicketPriceArray(SectionListBox.SelectedIndex).ToString("c"))
                ' Calculate the total amount due
                AmountDueTextBox.Text = (QuantityInteger * TicketPriceArray(SectionListBox.SelectedIndex)).ToString("c")
                ' The summary array is updated for the additional quantity of tickets sold for a particular section
                SummaryArray(SectionListBox.SelectedIndex) += QuantityInteger
                ' Tickets summary sub is run to update the summary section
                TicketSummary()

            Catch ex As FormatException
                ' If the quantity entered is not a number then an exception is thrown
                MessageBox.Show("You must enter a numeric quantity for tickets.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                With NumberOfTicketsTextBox
                    .Focus()
                    .SelectAll()
                End With

            End Try

        Catch ex As FormatException
            ' If there was no section selected then an exception is thrown
            MessageBox.Show("You must choose a selection", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TicketSalesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the form on start up and add the listbox items
        SectionListBox.Items.Add("Orchestra")
        SectionListBox.Items.Add("Mezzanine")
        SectionListBox.Items.Add("General")
        SectionListBox.Items.Add("Balcony")
    End Sub
End Class
