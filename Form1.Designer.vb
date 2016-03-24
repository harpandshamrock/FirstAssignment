<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnHighScores = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAllShotsFired = New System.Windows.Forms.Label()
        Me.lblNameReminder = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblEnterName = New System.Windows.Forms.Label()
        Me.lblChancesLeft = New System.Windows.Forms.Label()
        Me.lblShotsFiredThisRound = New System.Windows.Forms.Label()
        Me.btnFireAway = New System.Windows.Forms.Button()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.btnSpinChambers = New System.Windows.Forms.Button()
        Me.btnLoadBullet = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.lblScoreMessage = New System.Windows.Forms.Label()
        Me.btnQuitGame = New System.Windows.Forms.Button()
        Me.pbNeeded = New System.Windows.Forms.PictureBox()
        Me.btnCheatMode = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHighScores
        '
        Me.btnHighScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScores.Location = New System.Drawing.Point(43, 231)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(652, 60)
        Me.btnHighScores.TabIndex = 25
        Me.btnHighScores.Text = "HighScores"
        Me.btnHighScores.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(274, 362)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 60)
        Me.btnExit.TabIndex = 24
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'lblAllShotsFired
        '
        Me.lblAllShotsFired.AutoSize = True
        Me.lblAllShotsFired.Location = New System.Drawing.Point(506, 362)
        Me.lblAllShotsFired.Name = "lblAllShotsFired"
        Me.lblAllShotsFired.Size = New System.Drawing.Size(87, 13)
        Me.lblAllShotsFired.TabIndex = 23
        Me.lblAllShotsFired.Text = "Total Shots Fired"
        '
        'lblNameReminder
        '
        Me.lblNameReminder.AutoSize = True
        Me.lblNameReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameReminder.ForeColor = System.Drawing.Color.Red
        Me.lblNameReminder.Location = New System.Drawing.Point(270, 76)
        Me.lblNameReminder.Name = "lblNameReminder"
        Me.lblNameReminder.Size = New System.Drawing.Size(0, 20)
        Me.lblNameReminder.TabIndex = 22
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(274, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 26)
        Me.txtName.TabIndex = 21
        Me.txtName.Text = "Put your name in here"
        '
        'lblEnterName
        '
        Me.lblEnterName.AutoSize = True
        Me.lblEnterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterName.Location = New System.Drawing.Point(270, 12)
        Me.lblEnterName.Name = "lblEnterName"
        Me.lblEnterName.Size = New System.Drawing.Size(176, 20)
        Me.lblEnterName.TabIndex = 20
        Me.lblEnterName.Text = "Please enter your name"
        '
        'lblChancesLeft
        '
        Me.lblChancesLeft.AutoSize = True
        Me.lblChancesLeft.Location = New System.Drawing.Point(506, 418)
        Me.lblChancesLeft.Name = "lblChancesLeft"
        Me.lblChancesLeft.Size = New System.Drawing.Size(102, 13)
        Me.lblChancesLeft.TabIndex = 19
        Me.lblChancesLeft.Text = "Chances Remaining"
        '
        'lblShotsFiredThisRound
        '
        Me.lblShotsFiredThisRound.AutoSize = True
        Me.lblShotsFiredThisRound.Location = New System.Drawing.Point(506, 393)
        Me.lblShotsFiredThisRound.Name = "lblShotsFiredThisRound"
        Me.lblShotsFiredThisRound.Size = New System.Drawing.Size(60, 13)
        Me.lblShotsFiredThisRound.TabIndex = 18
        Me.lblShotsFiredThisRound.Text = "Shots Fired"
        '
        'btnFireAway
        '
        Me.btnFireAway.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFireAway.Location = New System.Drawing.Point(274, 361)
        Me.btnFireAway.Name = "btnFireAway"
        Me.btnFireAway.Size = New System.Drawing.Size(200, 60)
        Me.btnFireAway.TabIndex = 17
        Me.btnFireAway.Text = "Fire Away"
        Me.btnFireAway.UseVisualStyleBackColor = True
        Me.btnFireAway.Visible = False
        '
        'btnFire
        '
        Me.btnFire.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFire.Location = New System.Drawing.Point(274, 297)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(200, 60)
        Me.btnFire.TabIndex = 16
        Me.btnFire.Text = "Fire"
        Me.btnFire.UseVisualStyleBackColor = True
        Me.btnFire.Visible = False
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAgain.Location = New System.Drawing.Point(274, 298)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(200, 60)
        Me.btnPlayAgain.TabIndex = 15
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        Me.btnPlayAgain.Visible = False
        '
        'btnSpinChambers
        '
        Me.btnSpinChambers.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpinChambers.Location = New System.Drawing.Point(274, 165)
        Me.btnSpinChambers.Name = "btnSpinChambers"
        Me.btnSpinChambers.Size = New System.Drawing.Size(200, 60)
        Me.btnSpinChambers.TabIndex = 14
        Me.btnSpinChambers.Text = "Spin Chambers"
        Me.btnSpinChambers.UseVisualStyleBackColor = True
        Me.btnSpinChambers.Visible = False
        '
        'btnLoadBullet
        '
        Me.btnLoadBullet.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadBullet.Location = New System.Drawing.Point(274, 102)
        Me.btnLoadBullet.Name = "btnLoadBullet"
        Me.btnLoadBullet.Size = New System.Drawing.Size(200, 60)
        Me.btnLoadBullet.TabIndex = 13
        Me.btnLoadBullet.Text = "Load Bullet"
        Me.btnLoadBullet.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(43, 12)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(200, 213)
        Me.AxWindowsMediaPlayer1.TabIndex = 27
        '
        'lblScoreMessage
        '
        Me.lblScoreMessage.AutoSize = True
        Me.lblScoreMessage.Location = New System.Drawing.Point(50, 365)
        Me.lblScoreMessage.Name = "lblScoreMessage"
        Me.lblScoreMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblScoreMessage.TabIndex = 28
        '
        'btnQuitGame
        '
        Me.btnQuitGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitGame.Location = New System.Drawing.Point(43, 446)
        Me.btnQuitGame.Name = "btnQuitGame"
        Me.btnQuitGame.Size = New System.Drawing.Size(652, 65)
        Me.btnQuitGame.TabIndex = 30
        Me.btnQuitGame.Text = "Quit"
        Me.btnQuitGame.UseVisualStyleBackColor = True
        '
        'pbNeeded
        '
        Me.pbNeeded.Location = New System.Drawing.Point(495, 12)
        Me.pbNeeded.Name = "pbNeeded"
        Me.pbNeeded.Size = New System.Drawing.Size(200, 213)
        Me.pbNeeded.TabIndex = 32
        Me.pbNeeded.TabStop = False
        '
        'btnCheatMode
        '
        Me.btnCheatMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheatMode.Location = New System.Drawing.Point(495, 297)
        Me.btnCheatMode.Name = "btnCheatMode"
        Me.btnCheatMode.Size = New System.Drawing.Size(200, 60)
        Me.btnCheatMode.TabIndex = 33
        Me.btnCheatMode.Text = "Cheat!!!"
        Me.btnCheatMode.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 518)
        Me.Controls.Add(Me.btnCheatMode)
        Me.Controls.Add(Me.pbNeeded)
        Me.Controls.Add(Me.btnQuitGame)
        Me.Controls.Add(Me.lblScoreMessage)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.btnHighScores)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAllShotsFired)
        Me.Controls.Add(Me.lblNameReminder)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEnterName)
        Me.Controls.Add(Me.lblChancesLeft)
        Me.Controls.Add(Me.lblShotsFiredThisRound)
        Me.Controls.Add(Me.btnFireAway)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.btnSpinChambers)
        Me.Controls.Add(Me.btnLoadBullet)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Russian Roulette"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHighScores As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAllShotsFired As Label
    Friend WithEvents lblNameReminder As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblEnterName As Label
    Friend WithEvents lblChancesLeft As Label
    Friend WithEvents lblShotsFiredThisRound As Label
    Friend WithEvents btnFireAway As Button
    Friend WithEvents btnFire As Button
    Friend WithEvents btnPlayAgain As Button
    Friend WithEvents btnSpinChambers As Button
    Friend WithEvents btnLoadBullet As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents lblScoreMessage As Label
    Friend WithEvents btnQuitGame As Button
    Friend WithEvents pbNeeded As PictureBox
    Friend WithEvents btnCheatMode As Button
End Class
