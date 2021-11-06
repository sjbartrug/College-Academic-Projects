'Project: Lab 6 
'Author: Sam Bartrug
'Date: Fall 2020
'Description: A calculator to calculate the commissions made by sales people in a company using an array

Public Class SalarySurvey
    ' class level
    Dim TotalArray(8) As Integer ' 9 elements, 8 is our upperbound
    Const SALARY_BASE_DECIMAL As Decimal = 250 ' decimal, currency
    Const COMMISSION_RATE_DECIMAL As Decimal = 0.15 ' 15%

    ' handles Calculate Button's Click event
    Private Sub calculateButton_Click(sender As Object,
       e As EventArgs) Handles calculateButton.Click
        Dim SalesAmountDecimal As Decimal ' the sales keyed in by the user
        Dim SalaryDecimal As Decimal ' the salary paid out, BASE + COMM
        Dim IndexInteger As Integer ' the slot in the array to store our results

        Try
            ' is the sales amount valid
            SalesAmountDecimal = Convert.ToDecimal(amountTextBox.Text)
            If SalesAmountDecimal < 0 Then
                MessageBox.Show("Sales amount must be a positive number.")
                Exit Sub
            End If

            ' calc salary
            SalaryDecimal = SALARY_BASE_DECIMAL + (SalesAmountDecimal * COMMISSION_RATE_DECIMAL)

            ' calc the index
            IndexInteger = Convert.ToInt32(Math.Truncate(SalaryDecimal / 100)) - 2
            ' make sure value is within bounds of the array
            IndexInteger = Math.Min(IndexInteger, 8)

            ' increment the array
            TotalArray(IndexInteger) += 1

            ' update display
            UpdateValues()

            ' clear input
            With amountTextBox
                .Clear()
                .Focus()
            End With
        Catch ex As FormatException
            MessageBox.Show("You must enter a valid amount", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With amountTextBox
                .Focus()
                .SelectAll()
            End With
        End Try

    End Sub ' calculateButton_Click

    Private Sub SalarySurvey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load event, runs ONCE when the program starts

        ' initialize our table
        rangesLabel.Text = String.Format("$200-299{0}$300-399{0}$400-499{0}" &
                                         "$500-599{0}$600-699{0}$700-799{0}$800-899{0}$900-999{0}$1000 and over",
                                         ControlChars.NewLine)
        ' update values from the array to the screen
        UpdateValues()

    End Sub

    Sub UpdateValues()
        ' loop through our array and update the screen
        Dim ValueString As String = String.Empty

        ' loop through array
        For Each ValueInteger As Integer In TotalArray

            ValueString &= ValueInteger.ToString & ControlChars.NewLine

        Next

        ' update the label onscreen
        valuesLabel.Text = ValueString

    End Sub
End Class ' SalarySurvey
