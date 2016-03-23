Public Class HighScoreDisplay
    Private Sub HighScoreDisplay_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub HighScoreDisplay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub RichTextBox1_Click(sender As Object, e As EventArgs) Handles rtbHighScores.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub HighScoreDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class