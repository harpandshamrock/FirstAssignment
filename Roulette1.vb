Imports System.IO

Public Class Roulette1

    'LoadedorEmpty chamber False = empty True = loaded
    Public Loaded As Boolean
    Public ShotsFiredThisRound As Integer = 0
    Public FinalScore As Integer = 0
    Public ChancesLeft As Integer = 2
    Public CurrentContestant As String = ""
    Public BulletChamber(7) As Boolean
    Public path As String
    Public fileread As StreamReader
    Public LocationtoLookup As String
    Public SaveGamePath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\RouletteSavedGames.txt"
    Public WinOrLose As String = ""
    Public LastActionTaken As String = ""
    Dim CheatModeMessage As String = ""
    Public TotalWins As Integer = 0
    Public TotalLosses As Integer = 0


    'Sound for spinning the barrell.
    Private Sub PlaySpinBarrel()
        My.Computer.Audio.Play(My.Resources.ratchet, AudioPlayMode.Background)
    End Sub

    'Sound for firing an empty chamber.
    Private Sub PlayEmptyChamber()
        My.Computer.Audio.Play(My.Resources.Dry_Fire_Gun_SoundBible_com_2053652037, AudioPlayMode.Background)
    End Sub
    'Sound for firing a bullet.
    Private Sub PlayGunShot()
        My.Computer.Audio.Play(My.Resources.deserteagle, AudioPlayMode.Background)
    End Sub
    'Sound for loading a bullet.
    Public Sub PlayLoadtheBullet()
        My.Computer.Audio.Play(My.Resources.Police_357_Magnum_Loading_SoundBible_com_439069938, AudioPlayMode.Background)
    End Sub

    'Function used to rearrange Datagridview rows. Moves Row with a larger value for score to the position it occupies.
    Public Sub MoveDataGridRowsIfScoreFromrow2IsGreaterThanrow1(Row1 As DataGridViewRow, Row2 As DataGridViewRow)
        Dim CurrentIndex As Integer
        Dim TempRow2 As DataGridViewRow
        CurrentIndex = Row1.Index
        TempRow2 = Row2

        If CInt(Row2.Cells(2).Value) > CInt(Row1.Cells(2).Value) Then

            HighScores1.dgvHighScores.Rows.Remove(Row2)
            HighScores1.dgvHighScores.Rows.Insert(CurrentIndex, TempRow2)
        Else

        End If
    End Sub



    'Add the current score to the DataGridView highscore table sort it and Save to the RouletteSavedGames file. 
    Public Sub AddThisScoreToDataGridAndSortInDescendingOrder(FinalScore As Integer, WinOrLoss As String, TotalWins As Integer, TotalLosses As Integer)

        HighScores1.dgvHighScores.Rows.Add(Form1.txtName.Text, DateAndTime.Now, FinalScore, WinOrLoss, TotalWins, TotalLosses)
        Dim i As Integer
        Dim j As Integer

        For i = 0 To HighScores1.dgvHighScores.Rows.Count - 3
            For j = i + 1 To HighScores1.dgvHighScores.Rows.Count - 2
                MoveDataGridRowsIfScoreFromrow2IsGreaterThanrow1(HighScores1.dgvHighScores.Rows(i), HighScores1.dgvHighScores.Rows(j))
            Next
        Next

        Dim TxtWriter As StreamWriter

        Try

            TxtWriter = New StreamWriter(SaveGamePath)
            For i = 0 To HighScores1.dgvHighScores.Rows.Count - 2
                For j = 0 To 4
                    TxtWriter.Write(HighScores1.dgvHighScores.Rows(i).Cells(j).Value & ",")
                Next
                TxtWriter.Write(HighScores1.dgvHighScores.Rows(i).Cells(5).Value)

                    TxtWriter.WriteLine()

            Next
            TxtWriter.Close()
        Catch ex As Exception
            MsgBox("file writing error: " & ex.Message)
        End Try

    End Sub

    'Reset controls to Play again or exit state.
    Public Sub ResetToPlayAgainOrExit()
        Form1.btnCheatMode.Visible = False
        Form1.btnCheatMode.Text = "Cheat!!!"
        Form1.btnFire.Visible = False
        Form1.btnFireAway.Visible = False
        Form1.btnPlayAgain.Visible = True
        Form1.btnExit.Visible = True
    End Sub

    'Sub related to the btnloadthebullet on form1.
    Public Sub LoadTheBullet()

        If Form1.txtName.Text = "" Or Form1.txtName.Text = "Put your name in here" Then
            Form1.lblNameReminder.Text = "Please Enter your name above"
            Form1.txtName.BackColor = Color.Red
            Return
        Else
            PlayLoadtheBullet()
            CurrentContestant = Form1.txtName.Text
            Form1.lblEnterName.Text = ""
            Form1.lblNameReminder.Text = ""
            Form1.txtName.BackColor = Color.White
            Form1.btnLoadBullet.Visible = False
            Form1.txtName.Enabled = False
            Form1.btnSpinChambers.Visible = True
            Form1.btnSpinChambers.Enabled = True
        End If
    End Sub

    'Sub related to btnspinchambers on form1.
    Public Sub SpinChambers()
        Form1.btnCheatMode.Visible = True
        Form1.btnHighScores.Visible = False
        PlaySpinBarrel()
        Dim Random1 As New Random
        Dim WhichChamber As Integer = Random1.Next(1, 7)

        For i = 1 To 6

            If WhichChamber = i Then
                BulletChamber(i) = True
                CheatModeMessage = "Chamber " & i & " Loaded"
            Else
                BulletChamber(i) = False
            End If
        Next
        Form1.btnSpinChambers.Visible = False
        Form1.btnLoadBullet.Visible = False
        Form1.btnFire.Visible = True
        Form1.btnFireAway.Visible = True
        Form1.lblChancesLeft.Text = "Chances Left: " & ChancesLeft
    End Sub

    'Sub handling what happens on fire.
    Public Sub Fire()
        LastActionTaken = "Fire"
        ShotsFiredThisRound += 1
        FinalScore += 1
        Loaded = BulletChamber(ShotsFiredThisRound)
        If ChancesLeft = 0 Then
            WinOrLose = "Lose"
            TotalLosses += 1
            PlayGunShot()
            MsgBox("Tough luck. Maybe your head will grow back in a week or two")
            Form1.lblShotsFiredThisRound.Text = "Shots Fired this round: " & ShotsFiredThisRound
            Form1.lblAllShotsFired.Text = "Total Shots Fired Consecutively: " & FinalScore
            Form1.lblScoreMessage.Text = "You Lose: Total Shots Fired: " & FinalScore
            ResetToPlayAgainOrExit()
        Else

            If Loaded = False Then

                Form1.lblShotsFiredThisRound.Text = "Shots Fired this round: " & ShotsFiredThisRound
                Form1.lblAllShotsFired.Text = "Total Shots Fired Consecutively: " & FinalScore
                PlayEmptyChamber()
            ElseIf Loaded = True Then
                WinOrLose = "Lose"
                TotalWins += 1
                Form1.lblShotsFiredThisRound.Text = "Shots Fired this round: " & ShotsFiredThisRound
                Form1.lblAllShotsFired.Text = "Total Shots Fired Consecutively: " & FinalScore
                Form1.lblScoreMessage.Text = "You Lose: Total Shots Fired: " & FinalScore
                PlayGunShot()
                MsgBox("Better Luck next time, You just blew your head off!!!")
                ResetToPlayAgainOrExit()
            Else MsgBox("Error with LoadedOrEmpty")
            End If
        End If
    End Sub

    'Sub handling what happens on firing away.

    Public Sub FireAway()
        LastActionTaken = "FireAway"
        ShotsFiredThisRound += 1
        FinalScore += 1
        ChancesLeft -= 1
        Form1.lblChancesLeft.Text = "Chances Left: " & ChancesLeft
        Loaded = BulletChamber(ShotsFiredThisRound)

        If ChancesLeft = 0 Then
            Form1.btnFireAway.Visible = False
        Else

        End If

        If Loaded = False Then
            Form1.lblShotsFiredThisRound.Text = "Shots Fired this round: " & ShotsFiredThisRound
            Form1.lblAllShotsFired.Text = "Total Shots Fired Consecutively: " & FinalScore
            PlayEmptyChamber()
            MsgBox("That's a waste!")
        ElseIf Loaded = True Then

            WinOrLose = "Win"
            TotalWins += 1
            Form1.lblShotsFiredThisRound.Text = "Shots Fired this round: " & ShotsFiredThisRound
            Form1.lblAllShotsFired.Text = "Total Shots Fired Consecutively: " & FinalScore
            PlayGunShot()
            MsgBox("Well Done. You've dodged the bullet and lived!")
            Form1.lblScoreMessage.Text = "You Win: Total Shots Fired: " & FinalScore
            ResetToPlayAgainOrExit()

        Else MsgBox("error with LoadedOrEmpty")
        End If
    End Sub

    'Reset the scores from the last round and continue.
    Public Sub PlayAgain()
        CheatModeMessage = ""
        Form1.btnCheatMode.Visible = False
        If LastActionTaken = "Fire" Then
            Form1.btnHighScores.Visible = True
            BulletChamber = {False, False, False, False, False, False, False}
            Form1.btnLoadBullet.Visible = True
            Form1.lblEnterName.Text = ""
            Form1.lblNameReminder.Text = ""
            Form1.txtName.BackColor = Color.White
            Form1.txtName.Enabled = False
            Form1.btnFire.Visible = False
            Form1.btnFireAway.Visible = False
            Form1.btnPlayAgain.Visible = False
            Form1.btnExit.Visible = False
            ChancesLeft = 2
            AddThisScoreToDataGridAndSortInDescendingOrder(FinalScore, WinOrLose, TotalWins, TotalLosses)
            ShotsFiredThisRound = 0
            FinalScore = 0
            ResetLabelsToStart()

        ElseIf LastActionTaken = "FireAway" Then

            BulletChamber = {False, False, False, False, False, False, False}
            Form1.btnLoadBullet.Visible = True
            Form1.lblEnterName.Text = ""
            Form1.lblNameReminder.Text = ""
            Form1.txtName.BackColor = Color.White
            Form1.txtName.Enabled = False
            Form1.btnFire.Visible = False
            Form1.btnFireAway.Visible = False
            Form1.btnPlayAgain.Visible = False
            Form1.btnExit.Visible = False
            ChancesLeft = 2
            ShotsFiredThisRound = 0
            Form1.lblShotsFiredThisRound.Text = "Shots Fired This Round = 0"
            Form1.lblChancesLeft.Text = "Chances Left = 2"
        Else MsgBox("Error: Problem with selection of 'LastActionTaken'")
        End If

    End Sub

    ' Return the game to the original state
    Public Sub ExitGame()

        
        Form1.btnCheatMode.Visible = False
        CheatModeMessage = ""
        Form1.btnHighScores.Visible = True
        If LastActionTaken = "Fire" Then
            Form1.btnLoadBullet.Visible = True
            Form1.lblEnterName.Text = "Please enter your name"
            Form1.txtName.BackColor = Color.White
            Form1.txtName.Enabled = True
            Form1.btnFire.Visible = False
            Form1.btnFireAway.Visible = False
            Form1.btnPlayAgain.Visible = False
            Form1.btnExit.Visible = False
            AddThisScoreToDataGridAndSortInDescendingOrder(FinalScore, WinOrLose, TotalWins, TotalLosses)
            Form1.txtName.Text = ""
            Form1.lblNameReminder.Text = ""
            FinalScore = 0
            ChancesLeft = 2
            ShotsFiredThisRound = 0
            TotalLosses = 0
            TotalWins = 0
            ResetLabelsToStart()

        ElseIf LastActionTaken = "FireAway" Then

            Form1.btnLoadBullet.Visible = True
            Form1.lblEnterName.Text = "Please enter your name"
            Form1.txtName.BackColor = Color.White
            Form1.txtName.Enabled = True
            Form1.btnFire.Visible = False
            Form1.btnFireAway.Visible = False
            Form1.btnPlayAgain.Visible = False
            Form1.btnExit.Visible = False
            AddThisScoreToDataGridAndSortInDescendingOrder(FinalScore, WinOrLose, TotalWins, TotalLosses)
            Form1.txtName.Text = ""
            Form1.lblNameReminder.Text = ""
            FinalScore = 0
            ChancesLeft = 2
            ShotsFiredThisRound = 0
            ResetLabelsToStart()

        Else MsgBox("Error: Problem with selection of 'LastActionTaken'")

        End If
        Form1.txtName.Select()
    End Sub

    'Handles the user entering their name using the enter key.
    Public Sub EnterOnLoadBullet()

        If Form1.txtName.Text = "" Or Form1.txtName.Text = "Put your name In here" Then
            Form1.lblNameReminder.Text = "Please Enter your name above"
            Form1.txtName.BackColor = Color.Red
            Return
        Else
            PlayLoadtheBullet()
            CurrentContestant = Form1.txtName.Text
            Form1.lblEnterName.Text = ""
            Form1.lblNameReminder.Text = ""
            Form1.txtName.BackColor = Color.White
            Form1.btnLoadBullet.Visible = False
            Form1.txtName.Enabled = False
            Form1.btnSpinChambers.Visible = True
        End If
    End Sub

    'On starting the game add the scores saved in the RouletteSavedGames file to the datagridview highscore table
    Public Sub ReadFromTxtToDataGrid()
        Dim DataArray() As String
        Dim Line As String

        ' Create or overwrite the SaveGamePath file.
        Dim fs As FileStream = File.Open(SaveGamePath, FileMode.Append)

        fs.Close()


        'Write scores from file to array if it contains any.
        Try
            Dim fileread1 = New StreamReader(SaveGamePath)
            Do Until fileread1.EndOfStream
                Line = fileread1.ReadLine
                DataArray = Line.Split(",")

                If DataArray.Length = 6 Then
                    HighScores1.dgvHighScores.Rows.Add(DataArray(0), DataArray(1), DataArray(2), DataArray(3), DataArray(4), DataArray(5))
                Else

                End If
            Loop
            fileread1.Close()
        Catch ex As Exception
            MessageBox.Show("File reading error:  " & ex.Message)
        End Try
        Form1.txtName.Select()
    End Sub

    'Reset labels providing score information.
    Public Sub ResetLabelsToStart()
        Form1.lblAllShotsFired.Text = "Total Shots Fired = 0"
        Form1.lblShotsFiredThisRound.Text = "Shots Fired This Round = 0"
        Form1.lblChancesLeft.Text = "Chances Left = 2"
    End Sub

    'Cheat!
    Public Sub CheatMode()

        Form1.btnCheatMode.Text = CheatModeMessage

    End Sub

End Class
