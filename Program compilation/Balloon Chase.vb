REM Balloon Chase Game
REM Uses keyboard input to control a chaser balloon, Computer controls the target balloon using random numbers
REM Objective: Catch the chaser balloon with the target balloon.
REM by Michael Dao
REM Started: 2/04/2014 
REM Known errors: 'Nil

Public Class frmBalloon_Chase
    REM Declare form level variables
    Dim score As Integer = 0
    Dim answer As MsgBoxResult
    Dim started As Boolean = False

    Private Sub frmChase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        REM Move the chaser balloon if the game has started and a key has been pressed
        If started = True Then
            REM Move the chaser balloon up
            If e.KeyCode = Keys.Up Then
                If picChaser.Top > 4 Then
                    picChaser.Top -= 5
                End If
            End If

            REM Move the chaser balloon left
            If e.KeyCode = Keys.Left Then
                If picChaser.Left > 4 Then
                    picChaser.Left -= 5
                End If
            End If

            REM Move the chaser balloon right
            If e.KeyCode = Keys.Right Then
                If pnlGame.Width > picChaser.Left + picChaser.Width Then
                    picChaser.Left += 5
                End If
            End If

            REM Move the chaser balloon down
            If e.KeyCode = Keys.Down Then
                If pnlGame.Width > picChaser.Top + picChaser.Width Then
                    picChaser.Top += 5
                End If
            End If
        End If
    End Sub

    Private Sub mnuStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStart.Click
        REM Get rid of the baloons
        picChaser.Visible = True
        picTarget.Visible = True

        REM Put the chaser balloon at a random position at the bottom
        Dim startPlace As Single
        startPlace = Rnd() * pnlGame.Width / 2

        REM Reset the chaser balloon
        picChaser.Top = 287
        picChaser.Left = startPlace

        REM Reset the target balloon
        picTarget.Top = 287
        picTarget.Left = 335

        REM Start the game
        started = True

        REM Start moving the target baloon 
        tmrGame.Enabled = True
        started = True
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        'go back to menu
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmChase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Initialize the random number generator
        Randomize()

        REM Initialize the timer 
        tmrGame.Enabled = False
        tmrGame.Interval = 100
    End Sub

    Private Sub tmrGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGame.Tick
        REM Balloon moves
        picTarget.Top -= 16 * Rnd()
        picTarget.Left -= 10 * Rnd()

        REM You have caught the baloon 
        If picChaser.Bounds.IntersectsWith(picTarget.Bounds) Then

            REM Stop the target baloon
            tmrGame.Enabled = False

            REM Disable the chaser balloon
            started = False

            REM Increase the score
            score += 100
            lblScore.Text = score

            REM Display the win message
            MsgBox("You have caught the baloon!", MsgBoxStyle.Exclamation, "Well Done")

            REM Get rid of the baloons
            picChaser.Visible = False
            picTarget.Visible = False
        End If

        REM The target balloon got away
        If picTarget.Top + picTarget.Height < 0 Then

            REM Stop the target balloon
            tmrGame.Enabled = False

            REM Stop the chaser balloon
            started = False

            REM Tell the user they have lost
            MsgBox("You have lost the baloon!", MsgBoxStyle.Exclamation, "Better luck")

            REM Get rid of the baloons
            picChaser.Visible = False
            picTarget.Visible = False

            REM Call the highscore table
            Call highScoreTable()

            REM Play again?
            answer = MsgBox("Do you want to play again?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Game Over")
            If answer = MsgBoxResult.Yes Then
                score = 0
                lblScore.Text = score
            Else
                mnuStart.Enabled = False
            End If
        End If
    End Sub

    Private Sub highScoreTable()
        REM Produce a highscore table 
        Dim Highscorer As String

        REM Check if current game is highscore  
        If score > Val(lblScore1.Text) Then
            Highscorer = InputBox("New highscore" & vbCrLf & "Enter your name", "Congratulations!")

            REM Shift the second place down to the third place
            lblScore3.Text = lblScore2.Text
            lblName3.Text = lblName2.Text

            REM Shift the first place down to the second place 
            lblScore2.Text = lblScore1.Text
            lblName2.Text = lblName1.Text

            REM Display the first place
            lblScore1.Text = score
            lblName1.Text = Highscorer
        End If

        REM Check if current score is the second highest score
        If score > Val(lblScore2.Text) And score < Val(lblScore1.Text) Then
            Highscorer = InputBox("New second place" & vbCrLf & "Enter your name.", "Congratulations!")

            REM Shift the second place down to the third place
            lblScore3.Text = lblScore2.Text
            lblName3.Text = lblName2.Text

            REM Display the second place
            lblScore2.Text = score
            lblName2.Text = Highscorer
        End If

        REM Check if the current score is the third highest score
        If score > Val(lblScore3.Text) And score < Val(lblScore2.Text) Then
            Highscorer = InputBox("New third place" & vbCrLf & "Enter your name.", "Congratulations!")

            REM Display the third place
            lblScore3.Text = score
            lblName3.Text = Highscorer
        End If
    End Sub
End Class
