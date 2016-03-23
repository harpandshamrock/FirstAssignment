Public Class Form1




    Dim Roulette2 As New Roulette1







    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        Me.Hide()
        HighScores1.Show()

    End Sub

    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            'MsgBox("Hi")
            Roulette2.EnterOnLoadBullet()
        Else
        End If


    End Sub

    Private Sub btnLoadBullet_Click(sender As Object, e As EventArgs) Handles btnLoadBullet.Click
        Roulette2.LoadTheBullet()
    End Sub

    Private Sub btnSpinChambers_Click(sender As Object, e As EventArgs) Handles btnSpinChambers.Click
        Roulette2.SpinChambers()
    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        Roulette2.PlayAgain()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Roulette2.ExitGame()
    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        Roulette2.Fire()
    End Sub

    Private Sub btnFireAway_Click(sender As Object, e As EventArgs) Handles btnFireAway.Click
        Roulette2.FireAway()
    End Sub

    Private Sub btnHighScores2_Click(sender As Object, e As EventArgs) Handles btnHighScores2.Click
        Roulette2.HighScoreLookup(Roulette2.SaveGameDirectory)
        Me.Hide()
        HighScoreDisplay.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbNeeded.Image = My.Resources.happy_gun

        Roulette2.ReadFromTxtToDataGrid()
    End Sub

    Private Sub btnQuitGame_Click(sender As Object, e As EventArgs) Handles btnQuitGame.Click
        Me.Close()

    End Sub
End Class
