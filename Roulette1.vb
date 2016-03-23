Imports System.IO

Public Class Roulette1

    'LoadedorEmpty chamber False = empty True = loaded
    Public LoadedOrEmpty As Boolean
    Public ShotsFiredThisRound As Integer = 0
    Public FinalScore As Integer = 0
    Public ChancesLeft As Integer = 2
    Public CurrentContestant As String = ""
    Public BulletChamber(7) As Boolean
    Public path As String
    Public fileread As StreamReader
    Public LocationtoLookup As String
    Public SaveGameDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\RouletteSavedGames.txt"


    Public Sub HighScoreLookup(LocationtoLookup)
        HighScoreDisplay.rtbHighScores.Text = ""
        path = LocationtoLookup
        Dim line1 As String
        Try
            fileread = New StreamReader(path)

            Do Until fileread.EndOfStream
                line1 = fileread.ReadLine
                If line1 <> "" And
                    line1 <> ",,," Then
                    HighScoreDisplay.rtbHighScores.Text = HighScoreDisplay.rtbHighScores.Text & vbCrLf & line1
                End If


            Loop
            fileread.Close()
        Catch ex As Exception
            MessageBox.Show("File reading error: " & ex.Message)
        End Try


    End Sub
    Private Sub PlaySpinBarrel()
        My.Computer.Audio.Play(My.Resources.ratchet, AudioPlayMode.Background)
    End Sub



    Private Sub PlayEmptyChamber()
        My.Computer.Audio.Play(My.Resources.Dry_Fire_Gun_SoundBible_com_2053652037, AudioPlayMode.Background)
    End Sub

    Private Sub PlayGunShot()
        My.Computer.Audio.Play(My.Resources.deserteagle, AudioPlayMode.Background)
    End Sub
    Public Sub PlayLoadtheBullet()
        My.Computer.Audio.Play(My.Resources.Police_357_Magnum_Loading_SoundBible_com_439069938, AudioPlayMode.Background)
    End Sub
    Public Function UpdateHighScores(FinalScore As Integer)

        MsgBox(SaveGameDirectory)
        HighScores1.dgvHighScores.Rows.Add(Form1.txtName.Text, DateAndTime.Now, FinalScore)

        '''HighScores1.dgvHighScores.Columns("Score").HeaderCell.SortGlyphDirection = SortOrder.Ascending
        ''For i = 2 To HighScores1.dgvHighScores.Rows.Count - 1
        ''    If HighScores1.dgvHighScores.Rows(i).Cells(2).Value > HighScores1.dgvHighScores.Rows(1).Cells(2).Value Then
        ''        'move to top


        ''    End If
        ''Next


        Using TxtWriter As StreamWriter = File.AppendText(SaveGameDirectory)
            For Each currentrow As DataGridViewRow In HighScores1.dgvHighScores.Rows
                For Each currentcolumn As DataGridViewCell In currentrow.Cells
                    TxtWriter.Write(currentcolumn.Value & ",")
                Next

                TxtWriter.WriteLine()

            Next
            TxtWriter.Close()

        End Using

        'HighScoreLookup("G:\Files Required for VS2015\Files\Deer Hunter Scores.txt")
    End Function
    Public Sub ResetToPlayAgainOrExit()
        Form1.btnFire.Visible = False
        Form1.btnFireAway.Visible = False
        Form1.btnPlayAgain.Visible = True
        Form1.btnExit.Visible = True
    End Sub


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

        ' MsgBox(CurrentContestant)

    End Sub


    Public Sub SpinChambers()

        PlaySpinBarrel()
        Dim Random1 As New Random


        Dim WhichChamber As Integer = Random1.Next(1, 6)
        Dim message1 As String = ""



        For i = 0 To 6


            If WhichChamber = i Then
                BulletChamber(i) = True
            Else
                BulletChamber(i) = False
            End If
            message1 += i & "  " & BulletChamber(i) & "  :  "

        Next


        Form1.btnSpinChambers.Visible = False
        Form1.btnLoadBullet.Visible = False
        Form1.btnFire.Visible = True
        Form1.btnFireAway.Visible = True

        If Form1.cbToggleCheatMode.Checked = True Then
            MsgBox(message1 & "  " & CurrentContestant)
        Else

        End If


        Form1.lblChancesLeft.Text = "Chances Left: " & ChancesLeft
    End Sub

    Public Sub Fire()
        ShotsFiredThisRound += 1
        FinalScore += 1
        LoadedOrEmpty = BulletChamber(ShotsFiredThisRound)
        If ChancesLeft = 0 Then
            PlayGunShot()
            MsgBox("Tough luck. Maybe your head will grow back in a week or two")
            Form1.lblTotalShotsFired.Text = "Shots Fired this round: " & ShotsFiredThisRound
            Form1.lblAllShotsFired.Text = "Total Shots Fired Consecutively: " & FinalScore
            Form1.lblScoreMessage.Text = "You Lose: Total Shots Fired: " & FinalScore
            ResetToPlayAgainOrExit()
            UpdateHighScores(FinalScore)


        Else







            If LoadedOrEmpty = False Then

                Form1.lblTotalShotsFired.Text = "Shots Fired this round: " & ShotsFiredThisRound
                Form1.lblAllShotsFired.Text = "Total Shots Fired Consecutively: " & FinalScore
                PlayEmptyChamber()
            ElseIf LoadedOrEmpty = True Then

                Form1.lblTotalShotsFired.Text = "Shots Fired this round: " & ShotsFiredThisRound
                Form1.lblAllShotsFired.Text = "Total Shots Fired Consecutively: " & FinalScore
                PlayGunShot()
                MsgBox("Better Luck next time, You just blew your head off!!!")
                Form1.lblScoreMessage.Text = "You Lose: Total Shots Fired: " & FinalScore
                UpdateHighScores(FinalScore)
                ShotsFiredThisRound = 0
                FinalScore = 0
                ResetToPlayAgainOrExit()




            Else MsgBox("Error with LoadedOrEmpty")
            End If

        End If


    End Sub



    Public Sub FireAway()
        ShotsFiredThisRound += 1
        FinalScore += 1
        ChancesLeft -= 1
        Form1.lblChancesLeft.Text = "Chances Left: " & ChancesLeft
        LoadedOrEmpty = BulletChamber(ShotsFiredThisRound)


        If ChancesLeft = 0 Then
            Form1.btnFireAway.Visible = False
        Else

        End If


        If LoadedOrEmpty = False Then
            Form1.lblTotalShotsFired.Text = "Shots Fired this round: " & ShotsFiredThisRound
            Form1.lblAllShotsFired.Text = "Total Shots Fired Consecutively: " & FinalScore
            PlayEmptyChamber()
            MsgBox("That's a waste!")
        ElseIf LoadedOrEmpty = True Then


            Form1.lblTotalShotsFired.Text = "Shots Fired this round: " & ShotsFiredThisRound
            Form1.lblAllShotsFired.Text = "Total Shots Fired Consecutively: " & FinalScore
            PlayGunShot()
            MsgBox("Well Done. You've dodged the bullet and lived!")
            Form1.lblScoreMessage.Text = "You Win: Total Shots Fired: " & FinalScore

            ResetToPlayAgainOrExit()



        Else MsgBox("error with LoadedOrEmpty")



        End If
    End Sub


    Public Sub PlayAgain()


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

    End Sub

    Public Sub ExitGame()

        Form1.btnLoadBullet.Visible = True
        Form1.lblEnterName.Text = "Please enter your name"
        Form1.txtName.BackColor = Color.White
        Form1.txtName.Enabled = True
        Form1.btnFire.Visible = False
        Form1.btnFireAway.Visible = False
        Form1.btnPlayAgain.Visible = False
        Form1.btnExit.Visible = False
        UpdateHighScores(FinalScore)
        Form1.txtName.Text = ""

        Form1.lblNameReminder.Text = ""
        FinalScore = 0
        ChancesLeft = 2
        ShotsFiredThisRound = 0





    End Sub


    Public Sub EnterOnLoadBullet()




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

            End If


        MsgBox(CurrentContestant)
    End Sub

    Public Sub ReadFromTxtToDataGrid()
        ''''''Dim TextfieldParser1 As New Microsoft.VisualBasic.FileIO.TextFieldParser(SaveGameDirectory)
        ''''''TextfieldParser1.Delimiters = New String() {"  "}
        ''''''While Not TextfieldParser1.EndOfData
        ''''''    Dim Row1 As String() = TextfieldParser1.ReadFields()
        ''''''    If HighScores1.dgvHighScores.Columns.Count = 0 AndAlso Row1.Count > 0 Then
        ''''''        For i = 0 To Row1.Count - 1
        ''''''            HighScores1.dgvHighScores.Columns.Add("Column" & i + 1, "Column" & i + 1)
        ''''''        Next
        ''''''    End If
        ''''''    HighScores1.dgvHighScores.Rows.Add()
        ''''''End While

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim DataArray() As String
        Dim Line As String
        Dim path1 As String = SaveGameDirectory
        Try
            Dim fileread1 = New StreamReader(path1)
            Do Until fileread1.EndOfStream
                Line = fileread1.ReadLine






                DataArray = Line.Split(",")
                ' MsgBox(DataArray(0).Length)
                ' MsgBox(DataArray(1).Length)
                ' MsgBox(DataArray(2).Length)
                If DataArray(0).Length = 3 Then


                    HighScores1.dgvHighScores.Rows.Add(DataArray(0), DataArray(1), DataArray(2))

                Else
                End If


            Loop
            fileread1.Close()
        Catch ex As Exception
            MessageBox.Show("File reading error: " & ex.Message)
        End Try
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''For Each line As String In System.IO.File.ReadAllLines(SaveGameDirectory)
        ''''    HighScores1.dgvHighScores.Rows.Add(line.Split("   "))
        ''''Next


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


        '''''''Dim reader = New StreamReader(SaveGameDirectory)
        '''''''Dim line As String
        '''''''Do

        '''''''    Dim parts As String() = line.Split("   ")
        '''''''    HighScores1.dgvHighScores.Rows.Add(parts)


        '''''''    While (line = reader.ReadLine()) <> Nothing

    End Sub













End Class
