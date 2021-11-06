Public Class GreetingForm
    Private Sub MessageLabel_Click(sender As Object, e As EventArgs) Handles MessageLabel.Click

    End Sub

    Private Sub Saying1Button_Click(sender As Object, e As EventArgs) Handles Saying1Button.Click
        MessageLabel.Text = "Let's Go Pens!"
    End Sub

    Private Sub Saying2Button_Click(sender As Object, e As EventArgs) Handles Saying2Button.Click
        MessageLabel.Text = "Stop Losing To The Canadians!"
    End Sub

    Private Sub Saying3Button_Click(sender As Object, e As EventArgs) Handles Saying3Button.Click
        MessageLabel.Text = "Fight! Fight! Fight!"
    End Sub

    Private Sub Saying4Button_Click(sender As Object, e As EventArgs) Handles Saying4Button.Click
        MessageLabel.Text = "Skate Circles Around Them!"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'exit the program
        Me.Close()
    End Sub
End Class
