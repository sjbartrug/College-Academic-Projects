'Class Name: Default
'Programmer: Sam Bartrug
'Date: 12/2/20
'Description: Default web page
'Project: Homework 5
Partial Class _Default
    Inherits System.Web.UI.Page

    Private TotalItemsInteger As Integer
    Private TotalCaloriesInteger As Integer

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Turn off unobtrusive validation
        Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None

        ' Turn hidden field values (which is a string) into a number
        TotalItemsInteger = Convert.ToInt32(TotalNumberOfItemsHiddenField.Value)
        TotalCaloriesInteger = Convert.ToInt32(TotalNumberOfCaloriesHiddenField.Value)
    End Sub

    Protected Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ' Reset the form
        FatTextBox.Text = ""
        CarbsTextBox.Text = ""
        ProteinTextBox.Text = ""
        CurrentItemCaloriesLabel.Text = ""
    End Sub

    Protected Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        ' Calculate the calories
        Dim TheCalorieCalculator As CalorieCalculator

        Try
            ' Calculate the calories
            TheCalorieCalculator = New CalorieCalculator(Convert.ToInt32(FatTextBox.Text),
                                                         Convert.ToInt32(CarbsTextBox.Text),
                                                         Convert.ToInt32(ProteinTextBox.Text))
            ' Increment the values
            TotalItemsInteger += 1
            TotalCaloriesInteger += TheCalorieCalculator.CalculateCalories

            ' Save the new totals back to the  hidden fields
            TotalNumberOfItemsHiddenField.Value = TotalItemsInteger.ToString
            TotalNumberOfCaloriesHiddenField.Value = TotalCaloriesInteger.ToString


            ' Output the results
            CurrentItemCaloriesLabel.Text = TheCalorieCalculator.CalculateCalories
            TotalNumberOfItemsLabel.Text = TotalNumberOfItemsHiddenField.Value
            TotalNumberOfCaloriesLabel.Text = TotalNumberOfCaloriesHiddenField.Value
        Catch ex As Exception

        End Try
    End Sub
End Class
