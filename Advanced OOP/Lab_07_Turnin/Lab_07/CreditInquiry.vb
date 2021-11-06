'Project: StreamReader
'Author: Sam Bartrug 
'Date: Fall 2020
'Description: 
' Read a file sequentially and display contents based on
' account type specified by user (credit, debit or zero balances).
Imports System.IO ' using classes from this namespace

Public Class CreditInquiry
    ' class level
    Dim FileNameString As String ' name of the file containing the account data

    ' enumerable value to represent the account types
    Enum AccountType ' new data type, constants representing account types
        POSITIVE
        NEGATIVE
        ZERO
        ALL
    End Enum

    Sub DisplayAccounts(inAccountType As AccountType)
        ' display accounts of specified type
        Dim AccountStreamReader As StreamReader
        ' read and display the file info
        Try
            ' reset our output
            accountsTextBox.Text = "The accounts are:" & ControlChars.NewLine

            ' open the file for reading
            AccountStreamReader = New StreamReader(FileNameString)
            ' if I reach this line, the file is open for reading

            'read file and display lines that match the balance type
            Do Until AccountStreamReader.EndOfStream ' until the end of the file is reached
                Dim LineString As String = AccountStreamReader.ReadLine 'reads one record/line
                Dim FieldString() As String = LineString.Split(","c) ' split linestring based on delimeter

                ' get data from array
                Dim AccountNumberInteger As Integer = Convert.ToInt32(FieldString(0))
                Dim FirstNameString As String = FieldString(1)
                Dim LastNameString As String = FieldString(2)
                Dim BalanceDecimal As Decimal = Convert.ToDecimal(FieldString(3))

                'should we display this record
                If ShouldDisplay(BalanceDecimal, inAccountType) Then
                    'return true, show that record
                    accountsTextBox.AppendText(String.Format("{0}{5}{1}{5}{2}{5}{3:c}{5}{4}",
                                               AccountNumberInteger,
                                               FirstNameString,
                                               LastNameString,
                                               BalanceDecimal,
                                               ControlChars.NewLine,
                                               ControlChars.Tab))
                End If
            Loop

            ' close the file

        Catch AccountIOException As IOException
            ' problem opening/reading the file
            MessageBox.Show("Cannot read file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Catch ConvertFormatException As FormatException
            ' catch the parse errors

        Finally
            ' runs whether the try succeeds or fails
            ' close file
            ' check if file is open
            If AccountStreamReader IsNot Nothing Then
                ' if we're here, the file was instantiated
                Try
                    AccountStreamReader.Close()
                Catch ex As IOException
                    MessageBox.Show("Error closing file.")
                End Try

            End If

        End Try
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' close the program

        Application.Exit() ' terminates the program

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ' get the file to where the accounts are stored
        Dim FileDialogResult As DialogResult ' stores results of the Open Dialog

        'create the dialog box enabling the user to open ther file
        Using AccountOpenFileDialog As New OpenFileDialog ' creating a block level object
            ' dialog is not open yet
            FileDialogResult = AccountOpenFileDialog.ShowDialog() ' opens the window/dialog
            ' what file they chose to open
            FileNameString = AccountOpenFileDialog.FileName
        End Using ' automatic call to AccountOpenFileDialog.Dispose()

        ' what button did they click
        If FileDialogResult <> DialogResult.Cancel Then
            ' they didn't click cancel, they clicked ok/open
            NegativeBalancesButton.Enabled = True
            PositiveBalancesButton.Enabled = True
            ZeroBalancesButton.Enabled = True
        Else
            ' they clicked cancel
        End If

        ' I have a file name and the form buttons are enabled if we picked a file

    End Sub

    Function ShouldDisplay(inBalanceDecimal As Decimal,
                           inAccountType As AccountType) As Boolean
        'determine if I should show the record
        If inAccountType = AccountType.ALL Then
            Return True ' show the record
        ElseIf inBalanceDecimal < 0 AndAlso inAccountType = AccountType.NEGATIVE Then
            Return True ' show the record
        ElseIf inBalanceDecimal = 0 AndAlso inAccountType = AccountType.ZERO Then
            Return True ' show the record
        ElseIf inBalanceDecimal > 0 AndAlso inAccountType = AccountType.POSITIVE Then
            Return True ' show the record
        End If

        Return False ' should not return the record
    End Function
    Private Sub PositiveBalancesButton_Click(sender As Object, e As EventArgs) Handles PositiveBalancesButton.Click
        ' show the positive account balances
        DisplayAccounts(AccountType.POSITIVE)
    End Sub

    Private Sub NegativeBalancesButton_Click(sender As Object, e As EventArgs) Handles NegativeBalancesButton.Click
        ' show the negative account balances
        DisplayAccounts(AccountType.NEGATIVE)
    End Sub

    Private Sub ZeroBalancesButton_Click(sender As Object, e As EventArgs) Handles ZeroBalancesButton.Click
        ' show the zero account balances
        DisplayAccounts(AccountType.ZERO)
    End Sub
End Class ' Credit Inquiry

