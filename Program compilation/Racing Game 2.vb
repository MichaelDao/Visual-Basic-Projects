REM Dragster game
REM Start button launches the car and makes it move slowly, Go faster button jumps and user has to press it to move faster
REM Computer controls the rival at a set speed the player has to race
REM Objective: Beat the rival car in a race
REM by Michael Dao
REM Started: 1/06/2014 
REM Finished: 9/06/2014
REM Known errors: 'Nil

Public Class frmRacing_Game_2
    REM Disable the enter key to prevent cheating 
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Enter) Then
            Return True
        Else
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
    End Function

    REM Declare form level variables
    Dim score As Integer = 0
    Dim score2 As Integer = 0
    Dim answer As MsgBoxResult
    Dim started As Boolean = False
    Dim Besttime As String

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        'go back to menu
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnLaunch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaunch.Click
        REM Start the game
        started = True

        REM Start moving the player car 
        tmrGame.Enabled = True
        started = True
    End Sub

    Private Sub frmDragster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Set up initial timer properties for stopwatch
        tmrStopwatch.Interval = 1
        tmrStopwatch.Enabled = False

        REM Set up initial timer properties for RaceLights
        tmrRaceLights.Interval = 400
        tmrRaceLights2.Interval = 400
        tmrRaceLights3.Interval = 400
        tmrRaceLights4.Interval = 400
    End Sub

    Private Sub tmrGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGame.Tick
        REM Make the player car move
        picPlayer.Left += 4

        REM Player launches early
        If picPlayer.Bounds.IntersectsWith(lblDisqualify.Bounds) Then

            REM Stop the car
            tmrGame.Enabled = False

            REM Stop the watch
            tmrStopwatch.Enabled = False

            REM Get rid of the cars
            picPlayer.Visible = False
            picRival.Visible = False

            REM Display the disqualify message
            MsgBox("You are disqualified for an early start", MsgBoxStyle.Exclamation, "Try again")
        End If

        REM Player car reaches the racing line
        If picPlayer.Bounds.IntersectsWith(recFinishLine.Bounds) Then

            REM Stop the timers
            tmrGame.Enabled = False
            tmrRivalCar.Stop()
            tmrRaceLights4.Stop()
            tmrStopwatch.Enabled = False

            REM Get rid of the cars
            picPlayer.Visible = False
            picRival.Visible = False

            REM Increase the score
            score += 1
            lblPlayerScore.Text = score

            REM Record lap time
            lblPreviousTime.Text = Format(Val(lblStopwatch.Text) + 0.0, "fixed")

            REM Display the win message
            MsgBox("You win the race!", MsgBoxStyle.Exclamation, "Winner!")
        End If

        REM Rival car reaches the racing line
        If picRival.Bounds.IntersectsWith(recFinishLine.Bounds) Then

            REM Stop the timers
            tmrGame.Enabled = False
            tmrRivalCar.Stop()
            tmrRaceLights4.Stop()
            tmrStopwatch.Enabled = False

            REM Get rid of the cars
            picPlayer.Visible = False
            picRival.Visible = False

            REM Increase the score
            score2 += 1
            lblRivalScore.Text = score2

            REM Display the losing message
            MsgBox("You lost the race", MsgBoxStyle.Exclamation, "Bad Luck")
        End If
    End Sub

    Private Sub tmrStopwatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStopwatch.Tick
        REM Count in hundreths of seconds
        lblStopwatch.Text = Format(Val(lblStopwatch.Text) + 0.01, "fixed")
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        REM Start the race
        tmrRaceLights.Enabled = True
        lblRedLight.Visible = True
        started = True
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        REM Reset the watch
        lblStopwatch.Text = "0.00"
        tmrStopwatch.Enabled = False

        REM Reset the cars
        tmrGame.Enabled = False
        picPlayer.Visible = True
        picPlayer.Top = 192
        picPlayer.Left = 6
        picRival.Visible = True
        picRival.Top = 31
        picRival.Left = 6
        tmrRivalCar.Stop()

        REM Reset the RaceLight
        lblAmberLight1.BackColor = Color.Gold
        lblAmberLight2.BackColor = Color.Gold
        lblAmberLight3.BackColor = Color.Gold
        lblRedLight.BackColor = Color.Red

        lblGreenLight.Visible = False
        lblAmberLight1.Visible = False
        lblAmberLight2.Visible = False
        lblAmberLight3.Visible = False
        lblGreenLight.Visible = False
        lblRedLight.Visible = False

        REM Reset the disqualify label
        lblDisqualify.Top = 201
        lblDisqualify.Left = 109

        REM Reset the Go Faster button
        btnGoFaster.Top = 115
        btnGoFaster.Left = 177
    End Sub

    Private Sub tmrRaceLights_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRaceLights.Tick
        REM Light AmberLight1
        If lblRedLight.Visible = True Then
            lblAmberLight1.Visible = True

            REM Move on to the next light
            tmrRaceLights.Stop()
            tmrRaceLights2.Start()
        End If
    End Sub

    Private Sub tmrRaceLights2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRaceLights2.Tick
        REM Light AmberLight2
        If lblAmberLight1.Visible = True Then
            lblAmberLight2.Visible = True

            REM Move on to the next light
            tmrRaceLights2.Stop()
            tmrRaceLights3.Start()
        End If
    End Sub

    Private Sub tmrRaceLights3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRaceLights3.Tick
        REM Light AmberLight3
        If lblAmberLight2.Visible = True Then
            lblAmberLight3.Visible = True

            REM Move on to the next light
            tmrRaceLights3.Stop()
            tmrRaceLights4.Start()
        End If
    End Sub

    Private Sub tmrRaceLights4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRaceLights4.Tick
        REM Make all lights Green
        If lblAmberLight3.Visible = True Then
            lblGreenLight.Visible = True
            lblAmberLight1.BackColor = Color.Lime
            lblAmberLight2.BackColor = Color.Lime
            lblAmberLight3.BackColor = Color.Lime
            lblGreenLight.BackColor = Color.Lime
            lblRedLight.BackColor = Color.Lime

            REM Move the label away from the start and move it, label also serves as anti cheat
            lblDisqualify.Left += 100

            REM Start the watch 
            tmrStopwatch.Enabled = True

            REM Make the rival car move
            tmrRivalCar.Start()
            started = True
        End If
    End Sub

    Private Sub tmrRivalCar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrRivalCar.Tick
        REM Set speed of Rival car
        picRival.Left += 5
    End Sub

    Private Sub btnGoFaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoFaster.Click
        REM Make the player car go faster
        picPlayer.Left += 7
    End Sub

    Private Sub btnGoFaster_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGoFaster.MouseHover
        REM Move the button
        btnGoFaster.Left = Rnd() * pnlGoFaster.Width
        btnGoFaster.Top = Rnd() * pnlGoFaster.Height
    End Sub
End Class
