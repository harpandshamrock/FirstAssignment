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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgvHighScores = New System.Windows.Forms.DataGridView()
        Me.Name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Date1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Score = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WinOrLose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalWins1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalLosses1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvHighScores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(1029, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 569)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgvHighScores
        '
        Me.dgvHighScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHighScores.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHighScores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHighScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHighScores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Name1, Me.Date1, Me.Score, Me.WinOrLose, Me.TotalWins1, Me.TotalLosses1})
        Me.dgvHighScores.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvHighScores.GridColor = System.Drawing.Color.White
        Me.dgvHighScores.Location = New System.Drawing.Point(0, 0)
        Me.dgvHighScores.Name = "dgvHighScores"
        Me.dgvHighScores.ReadOnly = True
        Me.dgvHighScores.RowHeadersVisible = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvHighScores.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHighScores.Size = New System.Drawing.Size(1033, 569)
        Me.dgvHighScores.TabIndex = 2
        '
        'Name1
        '
        Me.Name1.HeaderText = "Name"
        Me.Name1.Name = "Name1"
        Me.Name1.ReadOnly = True
        Me.Name1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Date1
        '
        Me.Date1.HeaderText = "Date"
        Me.Date1.Name = "Date1"
        Me.Date1.ReadOnly = True
        Me.Date1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Score
        '
        Me.Score.HeaderText = "Score"
        Me.Score.Name = "Score"
        Me.Score.ReadOnly = True
        Me.Score.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'WinOrLose
        '
        Me.WinOrLose.HeaderText = "WinOrLose"
        Me.WinOrLose.Name = "WinOrLose"
        Me.WinOrLose.ReadOnly = True
        '
        'TotalWins1
        '
        Me.TotalWins1.HeaderText = "Total Wins"
        Me.TotalWins1.Name = "TotalWins1"
        Me.TotalWins1.ReadOnly = True
        '
        'TotalLosses1
        '
        Me.TotalLosses1.HeaderText = "Total Losses"
        Me.TotalLosses1.Name = "TotalLosses1"
        Me.TotalLosses1.ReadOnly = True
        '
        'HighScores1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 569)
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
    Friend WithEvents WinOrLose As DataGridViewTextBoxColumn
    Friend WithEvents TotalWins1 As DataGridViewTextBoxColumn
    Friend WithEvents TotalLosses1 As DataGridViewTextBoxColumn
End Class
