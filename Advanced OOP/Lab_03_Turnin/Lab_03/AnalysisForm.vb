'Project: Lab #3
'Author: Sam Bartrug 
'Date: Fall 2020
'Description: Analysis of grades
'
Public Class AnalysisForm
    ' Class Level
    Const MAX_GRADES_INTEGER As Integer = 10 ' Max of 10 grades
    Private Sub SubmitResultButton_Click(sender As Object, e As EventArgs) Handles SubmitResultButton.Click
        ' Look at the input and save it to the result listbox
        Dim GradeString As String ' Input from the user

        ' Getting the input
        GradeString = ResultTextBox.Text
        ' Let's turn GradeString into uppercase and remove spaces from the beginning or end
        GradeString = GradeString.ToUpper.Trim

        ' Test if it's a P or F
        If GradeString = "P" Then
            ' This is a good grade/result, add it to the list
            ResultsListBox.Items.Add(GradeString)
            ' Reset Input
            With ResultTextBox
                .Focus()
                .Clear()
            End With
        ElseIf GradeString = "F" Then
            ' This is a good grade/result, add it to the list
            ResultsListBox.Items.Add(GradeString)
            With ResultTextBox
                .Focus()
                .Clear()
            End With
        Else
            ' Not a P or an F
            MessageBox.Show("Only P's and F's are valid.",
                            "Data Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            With ResultTextBox
                .Focus()
                .SelectAll()
            End With
        End If

        ' Above code checked for propper grades and added to list or showed warnings
        ' Do we have 10 grades entered
        If ResultsListBox.Items.Count = MAX_GRADES_INTEGER Then
            ' Single selection
            ' I have 10 grades, disable new ones
            ResultTextBox.Enabled = False ' Can't type in results text box
            SubmitResultButton.Enabled = False ' Can't press submit results button
            AnalyzeResultsButton.Enabled = True ' Can press analyze results button
        End If
    End Sub

    Private Sub AnalyzeResultsButton_Click(sender As Object, e As EventArgs) Handles AnalyzeResultsButton.Click
        Dim PassesInteger, FailuresInteger, CounterInteger As Integer ' Number of passes, Number of failures, loop counter
        Dim ResultString As String ' One exam result/grade

        ' Loop through the results and count them up
        Do
            ' Get one result from the list box
            ResultString = ResultsListBox.Items(CounterInteger)
            ' Test that result
            If ResultString = "P" Then
                ' Increment passes
                PassesInteger += 1
            Else
                FailuresInteger += 1
            End If

            'Increment our counter
            CounterInteger += 1

        Loop While CounterInteger < 10

        ' Display the results
        AnalysisResultsLabel.Text = String.Format("RESULTS{2}Passed: {0}{2}Failed: {1}",
                                                   PassesInteger,
                                                   FailuresInteger,
                                                   Environment.NewLine)
    End Sub

    Private Sub ClearResultsButton_Click(sender As Object, e As EventArgs) Handles ClearResultsButton.Click
        ' Reset our form for more grades
        ResultTextBox.Enabled = True ' Can type in results text box
        SubmitResultButton.Enabled = True ' Can press submit results button
        AnalyzeResultsButton.Enabled = False ' Can't press analyze results button

        'Clear the input fields
        ResultTextBox.Clear()
        AnalysisResultsLabel.Text = ""
        ResultsListBox.Items.Clear()
        ResultTextBox.Focus()

    End Sub
End Class ' Analysis

