REM Jumper
REM Player controls the orange oval and jumps over incoming rectangles to survive

REM by Michael Dao
REM Started: 26/05/2014
REM Finished: 29/05/2014

REM Known errors:
'Nil

Public Class frmJumper
    REM Declare form level variables
    Dim score As Integer = 0
    Dim dodge As Integer = 0
    Dim lives As Integer = 10

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem.Click
        REM Start the game
        tmrStopwatch.Enabled = True
        tmrGame.Enabled = True
        btnJump.Enabled = True
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        REM Stop the game
        tmrGame.Enabled = False
        btnJump.Enabled = False

        REM Reset everything
        tmrStopwatch.Enabled = False
        lblStopwatch.Text = "0.00"
        score = 0
        lives = 10
        dodge = 0

        REM Reset all object positions
        rectObstacle1.Top = 280
        rectObstacle1.Left = 53
        rectObstacle2.Top = 280
        RectObstacle2.Left = 776
        RectObstacle3.Top = 52
        rectObstacle3.Left = 400
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        REM Declare form level variables
        Dim answer As MsgBoxResult

        REM Ask the user if they want to quit
        answer = MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")

        REM Code to play again
        If answer = MsgBoxResult.No Then
        Else
            End
        End If
    End Sub

    Private Sub Jumper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Set up initial timer properties for stopwatch
        tmrStopwatch.Interval = 1
        tmrStopwatch.Enabled = False
        tmrGame.Enabled = False
        btnJump.Enabled = False

        REM Set up the form load routine
        lblDodges.Text = dodge
        lblLivesCount.Text = lives

        REM Stop the game when lives is -1
        If lives = -1 Then
            tmrGame.Stop()
            tmrStopwatch.Enabled = False
            btnJump.Enabled = False
        End If
    End Sub

    Private Sub tmrStopwatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStopwatch.Tick
        REM Count in hundreths of seconds
        lblStopwatch.Text = Format(Val(lblStopwatch.Text) + 0.01, "fixed")
    End Sub

    Private Sub tmrGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGame.Tick
        REM Set up tennis balls
        REM Set up rectObstacle1
        If rectObstacle1.Bounds.IntersectsWith(rectLand.Bounds) Then
            lblDodges.Text = dodge
            dodge += 1
            rectObstacle1.Left = +900
        Else
            rectObstacle1.Left -= 45
        End If

        REM Decrease the lives
        If ovlPlayer.Bounds.IntersectsWith(rectObstacle1.Bounds) Then
            lives -= 1
            rectObstacle1.Left = +1000
            lblLivesCount.Text = lives

        End If

        REM Set up rectObstacle2
        If RectObstacle2.Bounds.IntersectsWith(rectLand.Bounds) Then
            dodge += 1
            lblDodges.Text = dodge
            RectObstacle2.Left = +900
        Else
            RectObstacle2.Left -= 50
        End If

        REM Decrease the lives
        If ovlPlayer.Bounds.IntersectsWith(RectObstacle2.Bounds) Then
            lives -= 1
            RectObstacle2.Left = +1000
            lblLivesCount.Text = lives
        End If

        REM Set up rectObstacle3
        If RectObstacle3.Bounds.IntersectsWith(rectLand.Bounds) Then
            dodge += 1
            lblDodges.Text = dodge
            RectObstacle3.Left = +900
        Else
            RectObstacle3.Left -= 45
        End If

        REM Decrease the lives
        If ovlPlayer.Bounds.IntersectsWith(rectObstacle3.Bounds) Then
            lives -= 1
            rectObstacle3.Left = +1000
            lblLivesCount.Text = lives
        End If

        REM Stop the game when lives is -1
        If lives = -1 Then
            tmrGame.Stop()
            tmrStopwatch.Enabled = False
            MsgBox("Sorry, You have lost.", MsgBoxStyle.Exclamation, "Please try again")
        End If
    End Sub

    Private Sub tmrJump_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrJump.Tick
        REM Make the oval jump
        ovlPlayer.Top -= 40
        If ovlPlayer.Bounds.IntersectsWith(recJumpTop.Bounds) Then
            btnJump.Enabled = False
            tmrJump.Stop()
            tmrJumpDown.Start()
        End If
    End Sub

    Private Sub tmrJumpDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrJumpDown.Tick
        REM Make the oval come back down
        ovlPlayer.Top += 40
        If ovlPlayer.Bounds.IntersectsWith(rectLand.Bounds) Then
            btnJump.Enabled = True
            tmrJumpDown.Stop()
        End If
    End Sub

    Private Sub btnJump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJump.Click
        REM Make the oval jump
        tmrJump.Start()
    End Sub
End Class
