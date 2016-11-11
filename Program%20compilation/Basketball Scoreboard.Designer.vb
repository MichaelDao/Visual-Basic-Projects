<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBasketball_Scoreboard
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
        Me.components = New System.ComponentModel.Container()
        Me.tmrAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRecieveData = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblBanner = New System.Windows.Forms.Label()
        Me.lblAwayFoulScores = New System.Windows.Forms.Label()
        Me.lblHomeFoulScores = New System.Windows.Forms.Label()
        Me.lblHomefoulscore = New System.Windows.Forms.Label()
        Me.lblAwayfouls = New System.Windows.Forms.Label()
        Me.lblHomefouls = New System.Windows.Forms.Label()
        Me.lblAwayScore = New System.Windows.Forms.Label()
        Me.lblHomeScore = New System.Windows.Forms.Label()
        Me.lblHome3PointsScore = New System.Windows.Forms.Label()
        Me.lblHome3Points = New System.Windows.Forms.Label()
        Me.lblHome2PointsScore = New System.Windows.Forms.Label()
        Me.lblHome2Points = New System.Windows.Forms.Label()
        Me.lblHomeFreeThrows = New System.Windows.Forms.Label()
        Me.lblAway3PointsScore = New System.Windows.Forms.Label()
        Me.lblAway3Points = New System.Windows.Forms.Label()
        Me.lblAway2PointsScore = New System.Windows.Forms.Label()
        Me.lblAway2Points = New System.Windows.Forms.Label()
        Me.lblAwayFreeThrowsScore = New System.Windows.Forms.Label()
        Me.lblAwayFreeThrows = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.tmrShotClock = New System.Windows.Forms.Timer(Me.components)
        Me.lblHomeFreeThrowsScore = New System.Windows.Forms.Label()
        Me.lblAwayTeam = New System.Windows.Forms.Label()
        Me.lblHomeTeam = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrAnimation
        '
        '
        'tmrRecieveData
        '
        '
        'tmrGameTime
        '
        '
        'lblBanner
        '
        Me.lblBanner.BackColor = System.Drawing.Color.Gold
        Me.lblBanner.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBanner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBanner.Location = New System.Drawing.Point(1313, -4)
        Me.lblBanner.Name = "lblBanner"
        Me.lblBanner.Size = New System.Drawing.Size(899, 53)
        Me.lblBanner.TabIndex = 62
        Me.lblBanner.Text = "Label1"
        Me.lblBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAwayFoulScores
        '
        Me.lblAwayFoulScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAwayFoulScores.Font = New System.Drawing.Font("OCR A Extended", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayFoulScores.ForeColor = System.Drawing.Color.Yellow
        Me.lblAwayFoulScores.Location = New System.Drawing.Point(851, 266)
        Me.lblAwayFoulScores.Name = "lblAwayFoulScores"
        Me.lblAwayFoulScores.Size = New System.Drawing.Size(225, 86)
        Me.lblAwayFoulScores.TabIndex = 61
        Me.lblAwayFoulScores.Text = "0"
        Me.lblAwayFoulScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHomeFoulScores
        '
        Me.lblHomeFoulScores.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHomeFoulScores.Font = New System.Drawing.Font("OCR A Extended", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeFoulScores.ForeColor = System.Drawing.Color.Yellow
        Me.lblHomeFoulScores.Location = New System.Drawing.Point(96, 266)
        Me.lblHomeFoulScores.Name = "lblHomeFoulScores"
        Me.lblHomeFoulScores.Size = New System.Drawing.Size(225, 86)
        Me.lblHomeFoulScores.TabIndex = 60
        Me.lblHomeFoulScores.Text = "0"
        Me.lblHomeFoulScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHomefoulscore
        '
        Me.lblHomefoulscore.AutoSize = True
        Me.lblHomefoulscore.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHomefoulscore.Location = New System.Drawing.Point(161, 269)
        Me.lblHomefoulscore.Name = "lblHomefoulscore"
        Me.lblHomefoulscore.Size = New System.Drawing.Size(39, 13)
        Me.lblHomefoulscore.TabIndex = 59
        Me.lblHomefoulscore.Text = "Label1"
        '
        'lblAwayfouls
        '
        Me.lblAwayfouls.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAwayfouls.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayfouls.ForeColor = System.Drawing.Color.White
        Me.lblAwayfouls.Location = New System.Drawing.Point(861, 224)
        Me.lblAwayfouls.Name = "lblAwayfouls"
        Me.lblAwayfouls.Size = New System.Drawing.Size(187, 42)
        Me.lblAwayfouls.TabIndex = 58
        Me.lblAwayfouls.Text = "Fouls"
        Me.lblAwayfouls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHomefouls
        '
        Me.lblHomefouls.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHomefouls.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomefouls.ForeColor = System.Drawing.Color.White
        Me.lblHomefouls.Location = New System.Drawing.Point(111, 224)
        Me.lblHomefouls.Name = "lblHomefouls"
        Me.lblHomefouls.Size = New System.Drawing.Size(187, 42)
        Me.lblHomefouls.TabIndex = 57
        Me.lblHomefouls.Text = "Fouls"
        Me.lblHomefouls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAwayScore
        '
        Me.lblAwayScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAwayScore.Font = New System.Drawing.Font("OCR A Extended", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAwayScore.Location = New System.Drawing.Point(851, 88)
        Me.lblAwayScore.Name = "lblAwayScore"
        Me.lblAwayScore.Size = New System.Drawing.Size(225, 118)
        Me.lblAwayScore.TabIndex = 56
        Me.lblAwayScore.Text = "0"
        Me.lblAwayScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHomeScore
        '
        Me.lblHomeScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHomeScore.Font = New System.Drawing.Font("OCR A Extended", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHomeScore.Location = New System.Drawing.Point(96, 88)
        Me.lblHomeScore.Name = "lblHomeScore"
        Me.lblHomeScore.Size = New System.Drawing.Size(225, 118)
        Me.lblHomeScore.TabIndex = 55
        Me.lblHomeScore.Text = "0"
        Me.lblHomeScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHome3PointsScore
        '
        Me.lblHome3PointsScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHome3PointsScore.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome3PointsScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHome3PointsScore.Location = New System.Drawing.Point(272, 447)
        Me.lblHome3PointsScore.Name = "lblHome3PointsScore"
        Me.lblHome3PointsScore.Size = New System.Drawing.Size(114, 90)
        Me.lblHome3PointsScore.TabIndex = 54
        Me.lblHome3PointsScore.Text = "0"
        Me.lblHome3PointsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHome3Points
        '
        Me.lblHome3Points.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHome3Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome3Points.ForeColor = System.Drawing.Color.White
        Me.lblHome3Points.Location = New System.Drawing.Point(272, 382)
        Me.lblHome3Points.Name = "lblHome3Points"
        Me.lblHome3Points.Size = New System.Drawing.Size(114, 52)
        Me.lblHome3Points.TabIndex = 53
        Me.lblHome3Points.Text = "3 Points"
        Me.lblHome3Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHome2PointsScore
        '
        Me.lblHome2PointsScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHome2PointsScore.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome2PointsScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHome2PointsScore.Location = New System.Drawing.Point(142, 447)
        Me.lblHome2PointsScore.Name = "lblHome2PointsScore"
        Me.lblHome2PointsScore.Size = New System.Drawing.Size(114, 90)
        Me.lblHome2PointsScore.TabIndex = 52
        Me.lblHome2PointsScore.Text = "0"
        Me.lblHome2PointsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHome2Points
        '
        Me.lblHome2Points.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHome2Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome2Points.ForeColor = System.Drawing.Color.White
        Me.lblHome2Points.Location = New System.Drawing.Point(142, 382)
        Me.lblHome2Points.Name = "lblHome2Points"
        Me.lblHome2Points.Size = New System.Drawing.Size(114, 52)
        Me.lblHome2Points.TabIndex = 51
        Me.lblHome2Points.Text = "2 Points"
        Me.lblHome2Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHomeFreeThrows
        '
        Me.lblHomeFreeThrows.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHomeFreeThrows.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeFreeThrows.ForeColor = System.Drawing.Color.White
        Me.lblHomeFreeThrows.Location = New System.Drawing.Point(11, 382)
        Me.lblHomeFreeThrows.Name = "lblHomeFreeThrows"
        Me.lblHomeFreeThrows.Size = New System.Drawing.Size(114, 52)
        Me.lblHomeFreeThrows.TabIndex = 49
        Me.lblHomeFreeThrows.Text = "Free Throws"
        Me.lblHomeFreeThrows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAway3PointsScore
        '
        Me.lblAway3PointsScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAway3PointsScore.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAway3PointsScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAway3PointsScore.Location = New System.Drawing.Point(1049, 447)
        Me.lblAway3PointsScore.Name = "lblAway3PointsScore"
        Me.lblAway3PointsScore.Size = New System.Drawing.Size(114, 90)
        Me.lblAway3PointsScore.TabIndex = 48
        Me.lblAway3PointsScore.Text = "0"
        Me.lblAway3PointsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAway3Points
        '
        Me.lblAway3Points.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAway3Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAway3Points.ForeColor = System.Drawing.Color.White
        Me.lblAway3Points.Location = New System.Drawing.Point(1049, 382)
        Me.lblAway3Points.Name = "lblAway3Points"
        Me.lblAway3Points.Size = New System.Drawing.Size(114, 52)
        Me.lblAway3Points.TabIndex = 47
        Me.lblAway3Points.Text = "3 Points"
        Me.lblAway3Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAway2PointsScore
        '
        Me.lblAway2PointsScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAway2PointsScore.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAway2PointsScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAway2PointsScore.Location = New System.Drawing.Point(919, 447)
        Me.lblAway2PointsScore.Name = "lblAway2PointsScore"
        Me.lblAway2PointsScore.Size = New System.Drawing.Size(114, 90)
        Me.lblAway2PointsScore.TabIndex = 46
        Me.lblAway2PointsScore.Text = "0"
        Me.lblAway2PointsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAway2Points
        '
        Me.lblAway2Points.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAway2Points.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAway2Points.ForeColor = System.Drawing.Color.White
        Me.lblAway2Points.Location = New System.Drawing.Point(919, 382)
        Me.lblAway2Points.Name = "lblAway2Points"
        Me.lblAway2Points.Size = New System.Drawing.Size(114, 52)
        Me.lblAway2Points.TabIndex = 45
        Me.lblAway2Points.Text = "2 Points"
        Me.lblAway2Points.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAwayFreeThrowsScore
        '
        Me.lblAwayFreeThrowsScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAwayFreeThrowsScore.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayFreeThrowsScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAwayFreeThrowsScore.Location = New System.Drawing.Point(788, 447)
        Me.lblAwayFreeThrowsScore.Name = "lblAwayFreeThrowsScore"
        Me.lblAwayFreeThrowsScore.Size = New System.Drawing.Size(114, 90)
        Me.lblAwayFreeThrowsScore.TabIndex = 44
        Me.lblAwayFreeThrowsScore.Text = "0"
        Me.lblAwayFreeThrowsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAwayFreeThrows
        '
        Me.lblAwayFreeThrows.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAwayFreeThrows.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayFreeThrows.ForeColor = System.Drawing.Color.White
        Me.lblAwayFreeThrows.Location = New System.Drawing.Point(788, 382)
        Me.lblAwayFreeThrows.Name = "lblAwayFreeThrows"
        Me.lblAwayFreeThrows.Size = New System.Drawing.Size(114, 52)
        Me.lblAwayFreeThrows.TabIndex = 43
        Me.lblAwayFreeThrows.Text = "Free Throws"
        Me.lblAwayFreeThrows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTime.Font = New System.Drawing.Font("OCR A Extended", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Red
        Me.lblTime.Location = New System.Drawing.Point(462, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(256, 114)
        Me.lblTime.TabIndex = 42
        Me.lblTime.Text = "12.00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHomeFreeThrowsScore
        '
        Me.lblHomeFreeThrowsScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHomeFreeThrowsScore.Font = New System.Drawing.Font("OCR A Extended", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeFreeThrowsScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHomeFreeThrowsScore.Location = New System.Drawing.Point(11, 447)
        Me.lblHomeFreeThrowsScore.Name = "lblHomeFreeThrowsScore"
        Me.lblHomeFreeThrowsScore.Size = New System.Drawing.Size(114, 90)
        Me.lblHomeFreeThrowsScore.TabIndex = 50
        Me.lblHomeFreeThrowsScore.Text = "0"
        Me.lblHomeFreeThrowsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAwayTeam
        '
        Me.lblAwayTeam.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAwayTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayTeam.ForeColor = System.Drawing.Color.White
        Me.lblAwayTeam.Location = New System.Drawing.Point(724, 9)
        Me.lblAwayTeam.Name = "lblAwayTeam"
        Me.lblAwayTeam.Size = New System.Drawing.Size(436, 114)
        Me.lblAwayTeam.TabIndex = 41
        Me.lblAwayTeam.Text = "Away Team Name"
        Me.lblAwayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHomeTeam
        '
        Me.lblHomeTeam.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHomeTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeTeam.ForeColor = System.Drawing.Color.White
        Me.lblHomeTeam.Location = New System.Drawing.Point(12, 9)
        Me.lblHomeTeam.Name = "lblHomeTeam"
        Me.lblHomeTeam.Size = New System.Drawing.Size(444, 114)
        Me.lblHomeTeam.TabIndex = 40
        Me.lblHomeTeam.Text = "Home Team Name"
        Me.lblHomeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBasketball_Scoreboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1181, 546)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblBanner)
        Me.Controls.Add(Me.lblAwayFoulScores)
        Me.Controls.Add(Me.lblHomeFoulScores)
        Me.Controls.Add(Me.lblHomefoulscore)
        Me.Controls.Add(Me.lblAwayfouls)
        Me.Controls.Add(Me.lblHomefouls)
        Me.Controls.Add(Me.lblAwayScore)
        Me.Controls.Add(Me.lblHomeScore)
        Me.Controls.Add(Me.lblHome3PointsScore)
        Me.Controls.Add(Me.lblHome3Points)
        Me.Controls.Add(Me.lblHome2PointsScore)
        Me.Controls.Add(Me.lblHome2Points)
        Me.Controls.Add(Me.lblHomeFreeThrows)
        Me.Controls.Add(Me.lblAway3PointsScore)
        Me.Controls.Add(Me.lblAway3Points)
        Me.Controls.Add(Me.lblAway2PointsScore)
        Me.Controls.Add(Me.lblAway2Points)
        Me.Controls.Add(Me.lblAwayFreeThrowsScore)
        Me.Controls.Add(Me.lblAwayFreeThrows)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblHomeFreeThrowsScore)
        Me.Controls.Add(Me.lblAwayTeam)
        Me.Controls.Add(Me.lblHomeTeam)
        Me.Name = "frmBasketball_Scoreboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Basketball Scoreboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrAnimation As Timer
    Friend WithEvents tmrRecieveData As Timer
    Friend WithEvents tmrGameTime As Timer
    Friend WithEvents lblBanner As Label
    Friend WithEvents lblAwayFoulScores As Label
    Friend WithEvents lblHomeFoulScores As Label
    Friend WithEvents lblHomefoulscore As Label
    Friend WithEvents lblAwayfouls As Label
    Friend WithEvents lblHomefouls As Label
    Friend WithEvents lblAwayScore As Label
    Friend WithEvents lblHomeScore As Label
    Friend WithEvents lblHome3PointsScore As Label
    Friend WithEvents lblHome3Points As Label
    Friend WithEvents lblHome2PointsScore As Label
    Friend WithEvents lblHome2Points As Label
    Friend WithEvents lblHomeFreeThrows As Label
    Friend WithEvents lblAway3PointsScore As Label
    Friend WithEvents lblAway3Points As Label
    Friend WithEvents lblAway2PointsScore As Label
    Friend WithEvents lblAway2Points As Label
    Friend WithEvents lblAwayFreeThrowsScore As Label
    Friend WithEvents lblAwayFreeThrows As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents tmrShotClock As Timer
    Friend WithEvents lblHomeFreeThrowsScore As Label
    Friend WithEvents lblAwayTeam As Label
    Friend WithEvents lblHomeTeam As Label
End Class
