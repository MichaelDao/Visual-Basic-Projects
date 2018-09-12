<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRacing_Game_2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRacing_Game_2))
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.lblAmberLight2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblRedLight = New System.Windows.Forms.Label()
        Me.pnlGoFaster = New System.Windows.Forms.Panel()
        Me.btnGoFaster = New System.Windows.Forms.Button()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblGreenLight = New System.Windows.Forms.Label()
        Me.tmrRaceLights2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblRivalScore = New System.Windows.Forms.Label()
        Me.btnLaunch = New System.Windows.Forms.Button()
        Me.lblAmberLight1 = New System.Windows.Forms.Label()
        Me.tmrRaceLights4 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.lblAmberLight3 = New System.Windows.Forms.Label()
        Me.lblPreviousTime = New System.Windows.Forms.Label()
        Me.lblPlayerScoreText = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.pnlRoad = New System.Windows.Forms.Panel()
        Me.picRival = New System.Windows.Forms.PictureBox()
        Me.recFinishLine = New System.Windows.Forms.Label()
        Me.lblDisqualify = New System.Windows.Forms.Label()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.tmrRaceLights = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRivalCar = New System.Windows.Forms.Timer(Me.components)
        Me.lblRivalScoreText = New System.Windows.Forms.Label()
        Me.lblPreviousTimeText = New System.Windows.Forms.Label()
        Me.tmrRaceLights3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGoFaster.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlRoad.SuspendLayout()
        CType(Me.picRival, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.SystemColors.GrayText
        Me.picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), System.Drawing.Image)
        Me.picPlayer.Location = New System.Drawing.Point(3, 192)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(100, 50)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlayer.TabIndex = 3
        Me.picPlayer.TabStop = False
        '
        'lblAmberLight2
        '
        Me.lblAmberLight2.BackColor = System.Drawing.Color.Gold
        Me.lblAmberLight2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmberLight2.Location = New System.Drawing.Point(6, 114)
        Me.lblAmberLight2.Name = "lblAmberLight2"
        Me.lblAmberLight2.Size = New System.Drawing.Size(244, 46)
        Me.lblAmberLight2.TabIndex = 8
        Me.lblAmberLight2.Visible = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStart.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.Location = New System.Drawing.Point(1032, 348)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(147, 72)
        Me.btnStart.TabIndex = 33
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblRedLight
        '
        Me.lblRedLight.BackColor = System.Drawing.Color.Red
        Me.lblRedLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRedLight.Location = New System.Drawing.Point(6, 4)
        Me.lblRedLight.Name = "lblRedLight"
        Me.lblRedLight.Size = New System.Drawing.Size(244, 46)
        Me.lblRedLight.TabIndex = 9
        Me.lblRedLight.Visible = False
        '
        'pnlGoFaster
        '
        Me.pnlGoFaster.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlGoFaster.Controls.Add(Me.btnGoFaster)
        Me.pnlGoFaster.Location = New System.Drawing.Point(288, 335)
        Me.pnlGoFaster.Name = "pnlGoFaster"
        Me.pnlGoFaster.Size = New System.Drawing.Size(446, 270)
        Me.pnlGoFaster.TabIndex = 34
        '
        'btnGoFaster
        '
        Me.btnGoFaster.AutoSize = True
        Me.btnGoFaster.BackColor = System.Drawing.Color.Aqua
        Me.btnGoFaster.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGoFaster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGoFaster.Location = New System.Drawing.Point(177, 111)
        Me.btnGoFaster.Name = "btnGoFaster"
        Me.btnGoFaster.Size = New System.Drawing.Size(68, 48)
        Me.btnGoFaster.TabIndex = 0
        Me.btnGoFaster.Text = "GO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FASTER"
        Me.btnGoFaster.UseVisualStyleBackColor = False
        '
        'tmrGame
        '
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReset.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(1032, 434)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(147, 72)
        Me.btnReset.TabIndex = 32
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblGreenLight
        '
        Me.lblGreenLight.BackColor = System.Drawing.Color.Lime
        Me.lblGreenLight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGreenLight.Location = New System.Drawing.Point(6, 223)
        Me.lblGreenLight.Name = "lblGreenLight"
        Me.lblGreenLight.Size = New System.Drawing.Size(244, 46)
        Me.lblGreenLight.TabIndex = 11
        Me.lblGreenLight.Visible = False
        '
        'tmrRaceLights2
        '
        '
        'lblRivalScore
        '
        Me.lblRivalScore.BackColor = System.Drawing.Color.White
        Me.lblRivalScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRivalScore.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRivalScore.Location = New System.Drawing.Point(717, 6)
        Me.lblRivalScore.Name = "lblRivalScore"
        Me.lblRivalScore.Size = New System.Drawing.Size(47, 40)
        Me.lblRivalScore.TabIndex = 41
        Me.lblRivalScore.Text = "0"
        Me.lblRivalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLaunch
        '
        Me.btnLaunch.BackColor = System.Drawing.Color.Lime
        Me.btnLaunch.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaunch.ForeColor = System.Drawing.Color.Red
        Me.btnLaunch.Location = New System.Drawing.Point(754, 348)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Size = New System.Drawing.Size(254, 245)
        Me.btnLaunch.TabIndex = 31
        Me.btnLaunch.Text = "LAUNCH"
        Me.btnLaunch.UseVisualStyleBackColor = False
        '
        'lblAmberLight1
        '
        Me.lblAmberLight1.BackColor = System.Drawing.Color.Gold
        Me.lblAmberLight1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmberLight1.Location = New System.Drawing.Point(6, 58)
        Me.lblAmberLight1.Name = "lblAmberLight1"
        Me.lblAmberLight1.Size = New System.Drawing.Size(244, 46)
        Me.lblAmberLight1.TabIndex = 10
        Me.lblAmberLight1.Visible = False
        '
        'tmrRaceLights4
        '
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimer.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Black
        Me.lblTimer.Location = New System.Drawing.Point(16, 7)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(88, 40)
        Me.lblTimer.TabIndex = 28
        Me.lblTimer.Text = "TIME:"
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.BackColor = System.Drawing.Color.White
        Me.lblPlayerScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayerScore.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerScore.Location = New System.Drawing.Point(539, 7)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(47, 40)
        Me.lblPlayerScore.TabIndex = 39
        Me.lblPlayerScore.Text = "0"
        Me.lblPlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAmberLight3
        '
        Me.lblAmberLight3.BackColor = System.Drawing.Color.Gold
        Me.lblAmberLight3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmberLight3.Location = New System.Drawing.Point(6, 169)
        Me.lblAmberLight3.Name = "lblAmberLight3"
        Me.lblAmberLight3.Size = New System.Drawing.Size(244, 46)
        Me.lblAmberLight3.TabIndex = 7
        Me.lblAmberLight3.Visible = False
        '
        'lblPreviousTime
        '
        Me.lblPreviousTime.BackColor = System.Drawing.Color.White
        Me.lblPreviousTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPreviousTime.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreviousTime.Location = New System.Drawing.Point(1092, 6)
        Me.lblPreviousTime.Name = "lblPreviousTime"
        Me.lblPreviousTime.Size = New System.Drawing.Size(87, 40)
        Me.lblPreviousTime.TabIndex = 40
        Me.lblPreviousTime.Text = "0.00"
        Me.lblPreviousTime.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPlayerScoreText
        '
        Me.lblPlayerScoreText.BackColor = System.Drawing.Color.Cyan
        Me.lblPlayerScoreText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlayerScoreText.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerScoreText.ForeColor = System.Drawing.Color.Black
        Me.lblPlayerScoreText.Location = New System.Drawing.Point(428, 7)
        Me.lblPlayerScoreText.Name = "lblPlayerScoreText"
        Me.lblPlayerScoreText.Size = New System.Drawing.Size(105, 40)
        Me.lblPlayerScoreText.TabIndex = 36
        Me.lblPlayerScoreText.Text = "PLAYER"
        Me.lblPlayerScoreText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.lblGreenLight)
        Me.Panel1.Controls.Add(Me.lblRedLight)
        Me.Panel1.Controls.Add(Me.lblAmberLight1)
        Me.Panel1.Controls.Add(Me.lblAmberLight3)
        Me.Panel1.Controls.Add(Me.lblAmberLight2)
        Me.Panel1.Location = New System.Drawing.Point(16, 334)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 273)
        Me.Panel1.TabIndex = 29
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Red
        Me.btnQuit.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.White
        Me.btnQuit.Location = New System.Drawing.Point(1032, 521)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(147, 72)
        Me.btnQuit.TabIndex = 30
        Me.btnQuit.Text = "GIVE UP"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'pnlRoad
        '
        Me.pnlRoad.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.pnlRoad.Controls.Add(Me.picRival)
        Me.pnlRoad.Controls.Add(Me.recFinishLine)
        Me.pnlRoad.Controls.Add(Me.lblDisqualify)
        Me.pnlRoad.Controls.Add(Me.picPlayer)
        Me.pnlRoad.Location = New System.Drawing.Point(1, 53)
        Me.pnlRoad.Name = "pnlRoad"
        Me.pnlRoad.Size = New System.Drawing.Size(1218, 278)
        Me.pnlRoad.TabIndex = 27
        '
        'picRival
        '
        Me.picRival.Image = CType(resources.GetObject("picRival.Image"), System.Drawing.Image)
        Me.picRival.Location = New System.Drawing.Point(3, 52)
        Me.picRival.Name = "picRival"
        Me.picRival.Size = New System.Drawing.Size(100, 50)
        Me.picRival.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRival.TabIndex = 7
        Me.picRival.TabStop = False
        '
        'recFinishLine
        '
        Me.recFinishLine.BackColor = System.Drawing.SystemColors.ControlLight
        Me.recFinishLine.Location = New System.Drawing.Point(1205, 0)
        Me.recFinishLine.Name = "recFinishLine"
        Me.recFinishLine.Size = New System.Drawing.Size(10, 278)
        Me.recFinishLine.TabIndex = 5
        '
        'lblDisqualify
        '
        Me.lblDisqualify.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblDisqualify.Location = New System.Drawing.Point(103, 203)
        Me.lblDisqualify.Name = "lblDisqualify"
        Me.lblDisqualify.Size = New System.Drawing.Size(30, 30)
        Me.lblDisqualify.TabIndex = 4
        '
        'lblStopwatch
        '
        Me.lblStopwatch.BackColor = System.Drawing.Color.White
        Me.lblStopwatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStopwatch.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopwatch.Location = New System.Drawing.Point(107, 7)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(87, 40)
        Me.lblStopwatch.TabIndex = 38
        Me.lblStopwatch.Text = "0.00"
        Me.lblStopwatch.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tmrRaceLights
        '
        '
        'tmrStopwatch
        '
        '
        'tmrRivalCar
        '
        '
        'lblRivalScoreText
        '
        Me.lblRivalScoreText.BackColor = System.Drawing.Color.Red
        Me.lblRivalScoreText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRivalScoreText.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRivalScoreText.ForeColor = System.Drawing.Color.Black
        Me.lblRivalScoreText.Location = New System.Drawing.Point(606, 7)
        Me.lblRivalScoreText.Name = "lblRivalScoreText"
        Me.lblRivalScoreText.Size = New System.Drawing.Size(105, 40)
        Me.lblRivalScoreText.TabIndex = 35
        Me.lblRivalScoreText.Text = "RIVAL"
        Me.lblRivalScoreText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPreviousTimeText
        '
        Me.lblPreviousTimeText.BackColor = System.Drawing.Color.Lime
        Me.lblPreviousTimeText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPreviousTimeText.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreviousTimeText.ForeColor = System.Drawing.Color.Black
        Me.lblPreviousTimeText.Location = New System.Drawing.Point(869, 6)
        Me.lblPreviousTimeText.Name = "lblPreviousTimeText"
        Me.lblPreviousTimeText.Size = New System.Drawing.Size(217, 40)
        Me.lblPreviousTimeText.TabIndex = 37
        Me.lblPreviousTimeText.Text = "PREVIOUS TIME:"
        '
        'tmrRaceLights3
        '
        '
        'frmRacing_Game_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(1215, 606)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.pnlGoFaster)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblRivalScore)
        Me.Controls.Add(Me.btnLaunch)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.lblPreviousTime)
        Me.Controls.Add(Me.lblPlayerScoreText)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.pnlRoad)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.lblRivalScoreText)
        Me.Controls.Add(Me.lblPreviousTimeText)
        Me.Name = "frmRacing_Game_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Racing Game 2"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGoFaster.ResumeLayout(False)
        Me.pnlGoFaster.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnlRoad.ResumeLayout(False)
        CType(Me.picRival, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents lblAmberLight2 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents lblRedLight As Label
    Friend WithEvents pnlGoFaster As Panel
    Friend WithEvents btnGoFaster As Button
    Friend WithEvents tmrGame As Timer
    Friend WithEvents btnReset As Button
    Friend WithEvents lblGreenLight As Label
    Friend WithEvents tmrRaceLights2 As Timer
    Friend WithEvents lblRivalScore As Label
    Friend WithEvents btnLaunch As Button
    Friend WithEvents lblAmberLight1 As Label
    Friend WithEvents tmrRaceLights4 As Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblPlayerScore As Label
    Friend WithEvents lblAmberLight3 As Label
    Friend WithEvents lblPreviousTime As Label
    Friend WithEvents lblPlayerScoreText As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnQuit As Button
    Friend WithEvents pnlRoad As Panel
    Friend WithEvents lblDisqualify As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents tmrRaceLights As Timer
    Friend WithEvents tmrStopwatch As Timer
    Friend WithEvents tmrRivalCar As Timer
    Friend WithEvents lblRivalScoreText As Label
    Friend WithEvents lblPreviousTimeText As Label
    Friend WithEvents tmrRaceLights3 As Timer
    Friend WithEvents recFinishLine As Label
    Friend WithEvents picRival As PictureBox
End Class
