<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalloon_Chase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalloon_Chase))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblScore3 = New System.Windows.Forms.Label()
        Me.lblName3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblName2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblName1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlGame = New System.Windows.Forms.Panel()
        Me.picTarget = New System.Windows.Forms.PictureBox()
        Me.picChaser = New System.Windows.Forms.PictureBox()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.pnlGame.SuspendLayout()
        CType(Me.picTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picChaser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(535, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "High Scores"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScore3
        '
        Me.lblScore3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblScore3.Location = New System.Drawing.Point(631, 107)
        Me.lblScore3.Name = "lblScore3"
        Me.lblScore3.Size = New System.Drawing.Size(64, 16)
        Me.lblScore3.TabIndex = 52
        Me.lblScore3.Text = "0"
        Me.lblScore3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblName3
        '
        Me.lblName3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName3.Location = New System.Drawing.Point(503, 107)
        Me.lblName3.Name = "lblName3"
        Me.lblName3.Size = New System.Drawing.Size(136, 16)
        Me.lblName3.TabIndex = 51
        Me.lblName3.Text = "No one"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(479, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 24)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "3."
        '
        'lblScore2
        '
        Me.lblScore2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblScore2.Location = New System.Drawing.Point(631, 83)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(64, 16)
        Me.lblScore2.TabIndex = 49
        Me.lblScore2.Text = "0"
        Me.lblScore2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblName2
        '
        Me.lblName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName2.Location = New System.Drawing.Point(503, 83)
        Me.lblName2.Name = "lblName2"
        Me.lblName2.Size = New System.Drawing.Size(136, 16)
        Me.lblName2.TabIndex = 48
        Me.lblName2.Text = "No one"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(479, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 24)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "2."
        '
        'lblScore1
        '
        Me.lblScore1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblScore1.Location = New System.Drawing.Point(631, 59)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(64, 16)
        Me.lblScore1.TabIndex = 46
        Me.lblScore1.Text = "0"
        Me.lblScore1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblName1
        '
        Me.lblName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName1.Location = New System.Drawing.Point(503, 59)
        Me.lblName1.Name = "lblName1"
        Me.lblName1.Size = New System.Drawing.Size(136, 16)
        Me.lblName1.TabIndex = 45
        Me.lblName1.Text = "No one"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(479, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "1."
        '
        'lblScore
        '
        Me.lblScore.Location = New System.Drawing.Point(90, 378)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(72, 24)
        Me.lblScore.TabIndex = 43
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 24)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Score:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlGame
        '
        Me.pnlGame.BackColor = System.Drawing.Color.LightSkyBlue
        Me.pnlGame.Controls.Add(Me.picTarget)
        Me.pnlGame.Controls.Add(Me.picChaser)
        Me.pnlGame.Location = New System.Drawing.Point(12, 27)
        Me.pnlGame.Name = "pnlGame"
        Me.pnlGame.Size = New System.Drawing.Size(456, 336)
        Me.pnlGame.TabIndex = 41
        '
        'picTarget
        '
        Me.picTarget.Image = Global.Program_compilation.My.Resources.Resources.Balloon2
        Me.picTarget.Location = New System.Drawing.Point(335, 287)
        Me.picTarget.Name = "picTarget"
        Me.picTarget.Size = New System.Drawing.Size(32, 32)
        Me.picTarget.TabIndex = 1
        Me.picTarget.TabStop = False
        '
        'picChaser
        '
        Me.picChaser.Image = Global.Program_compilation.My.Resources.Resources.Balloon1
        Me.picChaser.InitialImage = CType(resources.GetObject("picChaser.InitialImage"), System.Drawing.Image)
        Me.picChaser.Location = New System.Drawing.Point(71, 287)
        Me.picChaser.Name = "picChaser"
        Me.picChaser.Size = New System.Drawing.Size(32, 32)
        Me.picChaser.TabIndex = 0
        Me.picChaser.TabStop = False
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStart, Me.mnuQuit})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(716, 24)
        Me.mnuMain.TabIndex = 55
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuStart
        '
        Me.mnuStart.Name = "mnuStart"
        Me.mnuStart.Size = New System.Drawing.Size(43, 20)
        Me.mnuStart.Text = "&Start"
        '
        'mnuQuit
        '
        Me.mnuQuit.Name = "mnuQuit"
        Me.mnuQuit.Size = New System.Drawing.Size(42, 20)
        Me.mnuQuit.Text = "&Quit"
        '
        'tmrGame
        '
        '
        'frmBalloon_Chase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 421)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblScore3)
        Me.Controls.Add(Me.lblName3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblName2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.lblName1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlGame)
        Me.Controls.Add(Me.mnuMain)
        Me.Name = "frmBalloon_Chase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balloon Chase"
        Me.pnlGame.ResumeLayout(False)
        CType(Me.picTarget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picChaser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents lblScore3 As Label
    Friend WithEvents lblName3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblScore2 As Label
    Friend WithEvents lblName2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblScore1 As Label
    Friend WithEvents lblName1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlGame As Panel
    Friend WithEvents picTarget As PictureBox
    Friend WithEvents picChaser As PictureBox
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuStart As ToolStripMenuItem
    Friend WithEvents mnuQuit As ToolStripMenuItem
    Friend WithEvents tmrGame As Timer
End Class
