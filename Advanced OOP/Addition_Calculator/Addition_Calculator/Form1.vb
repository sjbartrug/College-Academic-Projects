Public Class Addition_Form

    Private Sub AdditionButton_Click(sender As Object, e As EventArgs) Handles AdditionButton.Click
        'Create 3 Integers
        Dim FirstInteger, SecondInteger, SumInteger As Integer
        Try
            FirstInteger = Integer.Parse(FirstIntegerTextBox.Text) 'Attempts to set value input in FirstIntegerTextBox as an integer
            Try
                SecondInteger = Integer.Parse(SecondIntegerTextBox.Text) 'Attempts to set value input in SecondIntegerTextBox as an integer
                SumInteger = FirstInteger + SecondInteger
                ResultLabel.Text = "The sum is " & SumInteger.ToString
            Catch SecondIntegerFormatException As FormatException
                With SecondIntegerTextBox 'Focuses curson in SecondIntegerTextBox and highlights everything
                    .Focus()
                    .SelectAll()
                End With
                ResultLabel.Text = "You must enter a numeric second integer"
            End Try
        Catch FirstIntegerFormatException As FormatException
            With FirstIntegerTextBox 'Focuses curson in SecondIntegerTextBox and highlights everything
                .Focus()
                .SelectAll()
            End With
            'ResultLabel.Text = "You must enter a numeric first integer"
            MessageBox.Show("You must enter a numeric first integer",
                            "Data Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation)
        End Try


    End Sub

End Class
