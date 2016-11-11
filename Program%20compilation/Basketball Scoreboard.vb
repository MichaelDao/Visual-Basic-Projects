REM Basketball Scoreboard
REM by Michael Dao
REM Receives score and time realsing and displays time
REM Started: 28 Feb 2014
REM Known errors: 'nil

Public Class frmBasketball_Scoreboard
    Private Sub frmScoreboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Start position
        Me.Left = 200
        Me.Top = 200

        REM Set up timers
        tmrGameTime.Enabled = False
        tmrGameTime.Interval = 10
        tmrRecieveData.Interval = 10
        tmrRecieveData.Enabled = True
        tmrAnimation.Enabled = False
        tmrAnimation.Interval = 50
    End Sub

    Private Sub tmrGameTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGameTime.Tick
        REM Display the time
        lblTime.Text = Format(Val(lblTime.Text) - 0.01, "fixed")
        REM Check if game is over
        If lblTime.Text = "0.00" Then
            tmrGameTime.Enabled = False
            timeron = False
            REM Display the banner
            Call banner()
        End If
    End Sub

    Private Sub banner()
        REM Insert 'winning' message into lblBanner
        If homeScore > awayScore Then
            REM Home Team Wins
            lblBanner.Text = "Home Team Wins!"
        Else
            REM Away Team Wins
            lblBanner.Text = "Away Team Wins!"
        End If
        REM Draw 
        If homeScore = awayScore Then
            lblBanner.Text = "It's A Draw!"
        End If
        REM Move the Banner
        tmrAnimation.Enabled = True
    End Sub

    Private Sub tmrRecieveData_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRecieveData.Tick
        REM ft,2pt,3pt from modVairbles
        lblHomeFreeThrowsScore.Text = homeFoulShots
        lblHome2PointsScore.Text = home2Pointers
        lblHome3PointsScore.Text = home3Pointers
        lblAwayFreeThrowsScore.Text = awayFoulShots
        lblAway2PointsScore.Text = away2Pointers
        lblAway3PointsScore.Text = away3Pointers
        lblHomeFoulScores.Text = awayFoulShots
        lblAwayFoulScores.Text = homeFoulShots

        REM Recieve Score
        lblHomeScore.Text = homeScore
        lblAwayScore.Text = awayScore

        REM Start/Pause the timer
        tmrGameTime.Enabled = timeron
        If timerstop = True Then
            Me.Close()
        End If
    End Sub

    Private Sub tmrAnimation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAnimation.Tick
        REM Move the banner
        lblBanner.Left = lblBanner.Left - 1
    End Sub


End Class