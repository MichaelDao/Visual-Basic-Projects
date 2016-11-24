<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJumper
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
        Me.lblLivesCount = New System.Windows.Forms.Label()
        Me.tmrJumpDown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrJump = New System.Windows.Forms.Timer(Me.components)
        Me.tmrStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.btnJump = New System.Windows.Forms.Button()
        Me.lblDodges = New System.Windows.Forms.Label()
        Me.lblDodgeCount = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlGame = New System.Windows.Forms.Panel()
        Me.rectObstacle1 = New System.Windows.Forms.Label()
        Me.RectObstacle2 = New System.Windows.Forms.Label()
        Me.RectObstacle3 = New System.Windows.Forms.Label()
        Me.rectLand = New System.Windows.Forms.Label()
        Me.recTennisReset = New System.Windows.Forms.Label()
        Me.ovlPlayer = New System.Windows.Forms.Label()
        Me.recJumpTop = New System.Windows.Forms.Label()
        Me.mnuMenu.SuspendLayout()
        Me.pnlGame.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLivesCount
        '
        Me.lblLivesCount.BackColor = System.Drawing.Color.White
        Me.lblLivesCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLivesCount.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLivesCount.Location = New System.Drawing.Point(529, 40)
        Me.lblLivesCount.Name = "lblLivesCount"
        Me.lblLivesCount.Size = New System.Drawing.Size(47, 40)
        Me.lblLivesCount.TabIndex = 42
        Me.lblLivesCount.Text = "0"
        Me.lblLivesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrJumpDown
        '
        '
        'tmrJump
        '
        '
        'tmrStopwatch
        '
        '
        'btnJump
        '
        Me.btnJump.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnJump.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJump.ForeColor = System.Drawing.Color.White
        Me.btnJump.Location = New System.Drawing.Point(267, 34)
        Me.btnJump.Name = "btnJump"
        Me.btnJump.Size = New System.Drawing.Size(147, 51)
        Me.btnJump.TabIndex = 43
        Me.btnJump.Text = "JUMP"
        Me.btnJump.UseVisualStyleBackColor = False
        '
        'lblDodges
        '
        Me.lblDodges.BackColor = System.Drawing.Color.White
        Me.lblDodges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDodges.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDodges.Location = New System.Drawing.Point(834, 40)
        Me.lblDodges.Name = "lblDodges"
        Me.lblDodges.Size = New System.Drawing.Size(65, 40)
        Me.lblDodges.TabIndex = 41
        Me.lblDodges.Text = "0"
        Me.lblDodges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDodgeCount
        '
        Me.lblDodgeCount.BackColor = System.Drawing.Color.Red
        Me.lblDodgeCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDodgeCount.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDodgeCount.ForeColor = System.Drawing.Color.Black
        Me.lblDodgeCount.Location = New System.Drawing.Point(621, 41)
        Me.lblDodgeCount.Name = "lblDodgeCount"
        Me.lblDodgeCount.Size = New System.Drawing.Size(207, 40)
        Me.lblDodgeCount.TabIndex = 40
        Me.lblDodgeCount.Text = "DODGE COUNT:"
        '
        'lblLives
        '
        Me.lblLives.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLives.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.Color.Black
        Me.lblLives.Location = New System.Drawing.Point(429, 41)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(94, 40)
        Me.lblLives.TabIndex = 39
        Me.lblLives.Text = "LIVES:"
        '
        'lblStopwatch
        '
        Me.lblStopwatch.BackColor = System.Drawing.Color.White
        Me.lblStopwatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStopwatch.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopwatch.Location = New System.Drawing.Point(106, 41)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(112, 40)
        Me.lblStopwatch.TabIndex = 38
        Me.lblStopwatch.Text = "0.00"
        Me.lblStopwatch.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.Yellow
        Me.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTimer.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ForeColor = System.Drawing.Color.Black
        Me.lblTimer.Location = New System.Drawing.Point(12, 41)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(88, 40)
        Me.lblTimer.TabIndex = 37
        Me.lblTimer.Text = "TIME:"
        '
        'tmrGame
        '
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.StartToolStripMenuItem.Text = "& Start"
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ResetToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(1047, 24)
        Me.mnuMenu.TabIndex = 36
        Me.mnuMenu.Text = "MenuStrip1"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'pnlGame
        '
        Me.pnlGame.BackColor = System.Drawing.Color.White
        Me.pnlGame.Controls.Add(Me.rectObstacle1)
        Me.pnlGame.Controls.Add(Me.recTennisReset)
        Me.pnlGame.Controls.Add(Me.RectObstacle2)
        Me.pnlGame.Controls.Add(Me.recJumpTop)
        Me.pnlGame.Controls.Add(Me.RectObstacle3)
        Me.pnlGame.Controls.Add(Me.ovlPlayer)
        Me.pnlGame.Controls.Add(Me.rectLand)
        Me.pnlGame.Location = New System.Drawing.Point(12, 90)
        Me.pnlGame.Name = "pnlGame"
        Me.pnlGame.Size = New System.Drawing.Size(886, 404)
        Me.pnlGame.TabIndex = 35
        '
        'rectObstacle1
        '
        Me.rectObstacle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rectObstacle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rectObstacle1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rectObstacle1.ForeColor = System.Drawing.Color.Black
        Me.rectObstacle1.Location = New System.Drawing.Point(16, 287)
        Me.rectObstacle1.Name = "rectObstacle1"
        Me.rectObstacle1.Size = New System.Drawing.Size(44, 89)
        Me.rectObstacle1.TabIndex = 44
        '
        'RectObstacle2
        '
        Me.RectObstacle2.BackColor = System.Drawing.Color.Red
        Me.RectObstacle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RectObstacle2.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RectObstacle2.ForeColor = System.Drawing.Color.Black
        Me.RectObstacle2.Location = New System.Drawing.Point(843, 33)
        Me.RectObstacle2.Name = "RectObstacle2"
        Me.RectObstacle2.Size = New System.Drawing.Size(44, 89)
        Me.RectObstacle2.TabIndex = 45
        '
        'RectObstacle3
        '
        Me.RectObstacle3.BackColor = System.Drawing.Color.Lime
        Me.RectObstacle3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RectObstacle3.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RectObstacle3.ForeColor = System.Drawing.Color.Black
        Me.RectObstacle3.Location = New System.Drawing.Point(839, 287)
        Me.RectObstacle3.Name = "RectObstacle3"
        Me.RectObstacle3.Size = New System.Drawing.Size(44, 89)
        Me.RectObstacle3.TabIndex = 46
        '
        'rectLand
        '
        Me.rectLand.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rectLand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rectLand.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rectLand.ForeColor = System.Drawing.Color.Black
        Me.rectLand.Location = New System.Drawing.Point(0, 376)
        Me.rectLand.Name = "rectLand"
        Me.rectLand.Size = New System.Drawing.Size(887, 28)
        Me.rectLand.TabIndex = 47
        '
        'recTennisReset
        '
        Me.recTennisReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.recTennisReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.recTennisReset.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recTennisReset.ForeColor = System.Drawing.Color.Black
        Me.recTennisReset.Location = New System.Drawing.Point(-8, 0)
        Me.recTennisReset.Name = "recTennisReset"
        Me.recTennisReset.Size = New System.Drawing.Size(18, 404)
        Me.recTennisReset.TabIndex = 48
        '
        'ovlPlayer
        '
        Me.ovlPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ovlPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ovlPlayer.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ovlPlayer.ForeColor = System.Drawing.Color.Black
        Me.ovlPlayer.Location = New System.Drawing.Point(69, 158)
        Me.ovlPlayer.Name = "ovlPlayer"
        Me.ovlPlayer.Size = New System.Drawing.Size(44, 41)
        Me.ovlPlayer.TabIndex = 49
        '
        'recJumpTop
        '
        Me.recJumpTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.recJumpTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.recJumpTop.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recJumpTop.ForeColor = System.Drawing.Color.Black
        Me.recJumpTop.Location = New System.Drawing.Point(-1, 0)
        Me.recJumpTop.Name = "recJumpTop"
        Me.recJumpTop.Size = New System.Drawing.Size(887, 33)
        Me.recJumpTop.TabIndex = 50
        '
        'frmJumper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1047, 508)
        Me.Controls.Add(Me.lblLivesCount)
        Me.Controls.Add(Me.btnJump)
        Me.Controls.Add(Me.lblDodges)
        Me.Controls.Add(Me.lblDodgeCount)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.mnuMenu)
        Me.Controls.Add(Me.pnlGame)
        Me.Name = "frmJumper"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jumper"
        Me.mnuMenu.ResumeLayout(False)
        Me.mnuMenu.PerformLayout()
        Me.pnlGame.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLivesCount As Label
    Friend WithEvents tmrJumpDown As Timer
    Friend WithEvents tmrJump As Timer
    Friend WithEvents tmrStopwatch As Timer
    Friend WithEvents btnJump As Button
    Friend WithEvents lblDodges As Label
    Friend WithEvents lblDodgeCount As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents tmrGame As Timer
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuMenu As MenuStrip
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlGame As Panel
    Friend WithEvents rectObstacle1 As Label
    Friend WithEvents RectObstacle3 As Label
    Friend WithEvents RectObstacle2 As Label
    Friend WithEvents rectLand As Label
    Friend WithEvents recTennisReset As Label
    Friend WithEvents ovlPlayer As Label
    Friend WithEvents recJumpTop As Label
End Class
