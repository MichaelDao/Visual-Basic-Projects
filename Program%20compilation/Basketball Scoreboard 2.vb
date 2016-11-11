REM Basketball Control Panel
REM by Michael Dao
REM Calculate score by adding:
'Free throws (1 pt)
'2 Pointers (2 pts)
'3 Pointers (3 pts)
REM Calculates time remaining
REM Sends scores and time to frmScoreboard
REM Started: 28 Feb 2014

REM Known errors: 'nil

Public Class frmBasketball_Scoreboard_2
    Private Sub frmControlPanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Set control panel position
        Me.Left = 200
        Me.Top = 440
        REM Set up timer
        tmrSetData.Interval = 10
        tmrSetData.Enabled = True
    End Sub

    Private Sub btnStartTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStartGame.Click
        REM Start the timer
        timeron = True
    End Sub

    Private Sub btnPauseTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPauseGame.Click
        REM Pause the Timer
        timeron = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'back to the menu
        timerstop = True
        frmBasketball_Scoreboard.Close()
        Me.Close()
        frmMenu.Show()
    End Sub
End Class