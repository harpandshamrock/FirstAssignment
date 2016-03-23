<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScores1
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgvHighScores = New System.Windows.Forms.DataGridView()
        Me.Name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Score = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvHighScores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(119, 481)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgvHighScores
        '
        Me.dgvHighScores.BackgroundColor = System.Drawing.Color.White
        Me.dgvHighScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHighScores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name1, Me.Date1, Me.Score})
        Me.dgvHighScores.GridColor = System.Drawing.Color.White
        Me.dgvHighScores.Location = New System.Drawing.Point(70, 64)
        Me.dgvHighScores.Name = "dgvHighScores"
        Me.dgvHighScores.Size = New System.Drawing.Size(614, 267)
        Me.dgvHighScores.TabIndex = 2
        '
        'Name1
        '
        Me.Name1.HeaderText = "Name"
        Me.Name1.Name = "Name1"
        Me.Name1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Date1
        '
        Me.Date1.HeaderText = "Date"
        Me.Date1.Name = "Date1"
        Me.Date1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Score
        '
        Me.Score.HeaderText = "Score"
        Me.Score.Name = "Score"
        Me.Score.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'HighScores1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 569)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.dgvHighScores)
        Me.Name = "HighScores1"
        Me.Text = "HighScores1"
        CType(Me.dgvHighScores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents dgvHighScores As DataGridView
    Friend WithEvents Name1 As DataGridViewTextBoxColumn
    Friend WithEvents Date1 As DataGridViewTextBoxColumn
    Friend WithEvents Score As DataGridViewTextBoxColumn
End Class
