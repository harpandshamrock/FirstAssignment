<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.lblScoreMessage = New System.Windows.Forms.Label()
        Me.btnQuitGame = New System.Windows.Forms.Button()
        Me.pbNeeded = New System.Windows.Forms.PictureBox()
        Me.btnCheatMode = New System.Windows.Forms.Button()
        Me.pbSelectImage = New System.Windows.Forms.PictureBox()
        CType(Me.pbNeeded, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSelectImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHighScores
        '
        Me.btnHighScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScores.Location = New System.Drawing.Point(1, 238)
        Me.btnHighScores.Name = "btnHighScores"
        Me.btnHighScores.Size = New System.Drawing.Size(667, 60)
        Me.btnHighScores.TabIndex = 25
        Me.btnHighScores.Text = "HighScores"
        Me.btnHighScores.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(232, 368)
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
        Me.lblAllShotsFired.Location = New System.Drawing.Point(464, 368)
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
        Me.lblNameReminder.Location = New System.Drawing.Point(228, 82)
        Me.lblNameReminder.Name = "lblNameReminder"
        Me.lblNameReminder.Size = New System.Drawing.Size(0, 20)
        Me.lblNameReminder.TabIndex = 22
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(232, 47)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 26)
        Me.txtName.TabIndex = 21
        Me.txtName.Text = "Put your name in here"
        '
        'lblEnterName
        '
        Me.lblEnterName.AutoSize = True
        Me.lblEnterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterName.Location = New System.Drawing.Point(228, 18)
        Me.lblEnterName.Name = "lblEnterName"
        Me.lblEnterName.Size = New System.Drawing.Size(176, 20)
        Me.lblEnterName.TabIndex = 20
        Me.lblEnterName.Text = "Please enter your name"
        '
        'lblChancesLeft
        '
        Me.lblChancesLeft.AutoSize = True
        Me.lblChancesLeft.Location = New System.Drawing.Point(464, 424)
        Me.lblChancesLeft.Name = "lblChancesLeft"
        Me.lblChancesLeft.Size = New System.Drawing.Size(102, 13)
        Me.lblChancesLeft.TabIndex = 19
        Me.lblChancesLeft.Text = "Chances Remaining"
        '
        'lblShotsFiredThisRound
        '
        Me.lblShotsFiredThisRound.AutoSize = True
        Me.lblShotsFiredThisRound.Location = New System.Drawing.Point(464, 399)
        Me.lblShotsFiredThisRound.Name = "lblShotsFiredThisRound"
        Me.lblShotsFiredThisRound.Size = New System.Drawing.Size(60, 13)
        Me.lblShotsFiredThisRound.TabIndex = 18
        Me.lblShotsFiredThisRound.Text = "Shots Fired"
        '
        'btnFireAway
        '
        Me.btnFireAway.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFireAway.Location = New System.Drawing.Point(232, 367)
        Me.btnFireAway.Name = "btnFireAway"
        Me.btnFireAway.Size = New System.Drawing.Size(200, 60)
        Me.btnFireAway.TabIndex = 17
        Me.btnFireAway.Text = "Fire Away"
        Me.btnFireAway.UseVisualStyleBackColor = True
        Me.btnFireAway.Visible = False
        '
        'btnFire
        '
        Me.btnFire.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFire.Location = New System.Drawing.Point(232, 303)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(200, 60)
        Me.btnFire.TabIndex = 16
        Me.btnFire.Text = "Fire"
        Me.btnFire.UseVisualStyleBackColor = True
        Me.btnFire.Visible = False
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAgain.Location = New System.Drawing.Point(232, 304)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(200, 60)
        Me.btnPlayAgain.TabIndex = 15
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = True
        Me.btnPlayAgain.Visible = False
        '
        'btnSpinChambers
        '
        Me.btnSpinChambers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpinChambers.Location = New System.Drawing.Point(232, 171)
        Me.btnSpinChambers.Name = "btnSpinChambers"
        Me.btnSpinChambers.Size = New System.Drawing.Size(200, 60)
        Me.btnSpinChambers.TabIndex = 14
        Me.btnSpinChambers.Text = "Spin Chambers"
        Me.btnSpinChambers.UseVisualStyleBackColor = True
        Me.btnSpinChambers.Visible = False
        '
        'btnLoadBullet
        '
        Me.btnLoadBullet.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadBullet.Location = New System.Drawing.Point(232, 108)
        Me.btnLoadBullet.Name = "btnLoadBullet"
        Me.btnLoadBullet.Size = New System.Drawing.Size(200, 60)
        Me.btnLoadBullet.TabIndex = 13
        Me.btnLoadBullet.Text = "Load Bullet"
        Me.btnLoadBullet.UseVisualStyleBackColor = True
        '
        'lblScoreMessage
        '
        Me.lblScoreMessage.AutoSize = True
        Me.lblScoreMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreMessage.Location = New System.Drawing.Point(12, 334)
        Me.lblScoreMessage.MaximumSize = New System.Drawing.Size(200, 400)
        Me.lblScoreMessage.Name = "lblScoreMessage"
        Me.lblScoreMessage.Size = New System.Drawing.Size(0, 29)
        Me.lblScoreMessage.TabIndex = 28
        '
        'btnQuitGame
        '
        Me.btnQuitGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitGame.Location = New System.Drawing.Point(1, 452)
        Me.btnQuitGame.Name = "btnQuitGame"
        Me.btnQuitGame.Size = New System.Drawing.Size(667, 65)
        Me.btnQuitGame.TabIndex = 30
        Me.btnQuitGame.Text = "Quit"
        Me.btnQuitGame.UseVisualStyleBackColor = True
        '
        'pbNeeded
        '
        Me.pbNeeded.Location = New System.Drawing.Point(438, 18)
        Me.pbNeeded.Name = "pbNeeded"
        Me.pbNeeded.Size = New System.Drawing.Size(230, 213)
        Me.pbNeeded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbNeeded.TabIndex = 32
        Me.pbNeeded.TabStop = False
        '
        'btnCheatMode
        '
        Me.btnCheatMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheatMode.Location = New System.Drawing.Point(438, 303)
        Me.btnCheatMode.Name = "btnCheatMode"
        Me.btnCheatMode.Size = New System.Drawing.Size(230, 60)
        Me.btnCheatMode.TabIndex = 33
        Me.btnCheatMode.Text = "Cheat!!!"
        Me.btnCheatMode.UseVisualStyleBackColor = True
        Me.btnCheatMode.Visible = False
        '
        'pbSelectImage
        '
        Me.pbSelectImage.Location = New System.Drawing.Point(1, 18)
        Me.pbSelectImage.Name = "pbSelectImage"
        Me.pbSelectImage.Size = New System.Drawing.Size(219, 214)
        Me.pbSelectImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSelectImage.TabIndex = 34
        Me.pbSelectImage.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 518)
        Me.Controls.Add(Me.pbSelectImage)
        Me.Controls.Add(Me.btnCheatMode)
        Me.Controls.Add(Me.pbNeeded)
        Me.Controls.Add(Me.btnQuitGame)
        Me.Controls.Add(Me.lblScoreMessage)
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
        CType(Me.pbNeeded, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSelectImage, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblScoreMessage As Label
    Friend WithEvents btnQuitGame As Button
    Friend WithEvents pbNeeded As PictureBox
    Friend WithEvents btnCheatMode As Button
    Friend WithEvents pbSelectImage As PictureBox
End Class
