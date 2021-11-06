Public Class SummaryForm
    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        Me.Close()

    End Sub

    Private Sub SummaryForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SalesTotalLabel.Text = BookSale.SalesTotal.ToString("c")
        SalesCountLabel.Text = BookSale.SalesCount.ToString
        TotalStudentDiscountsLabel.Text = StudentBookSale.DiscountTotal.ToString("c")
    End Sub
End Class