REM Tomato Dodge
REM By Michael Dao
REM Dinosaur must dodge the falling tomatoes
REM 100 points for a dodge. -1 live for a miss
REM Started: 14/5/2014 
REM Known errors: 'nil

Public Class frmDodge_The_Tomatoes
    REM Declare form level variables
    Dim score As Integer = 0
    Dim lives As Integer = 10
    Dim started As Boolean = False

    Private Sub frmGame_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        REM Move the dinosaur
        If e.KeyCode = Keys.Left Then
            If picDino.Left > 0 Then
                picDino.Left -= 3
            End If
        End If

        If e.KeyCode = Keys.Right Then
            If picDino.Left + picDino.Width < pnlGame.Width Then
                picDino.Left += 3
            End If
        End If
    End Sub

    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Set up defaults
        tmrGame.Interval = 30
        tmrGame.Enabled = False
        lblScore.Text = score
        lblLives.Text = lives
    End Sub

    Private Sub mnuStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStart.Click
        REM Setup the tomatoes
        picTomato1.Top = -200
        picTomato2.Top = -35
        picTomato3.Top = -250
        picTomato4.Top = -100
        picTomato5.Top = -50

        REM Start the random number generator
        Randomize()

        REM Start the game
        started = True
        tmrGame.Enabled = True
    End Sub

    Private Sub tmrGame_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGame.Tick
        REM Move the tomatoes
        REM Drop tomato 1
        If picTomato1.Top > pnlGame.Height Then
            picTomato1.Top = -300 * Rnd()
            score += 100
        Else
            picTomato1.Top += 3
        End If

        REM Drop tomato 2
        If picTomato2.Top > pnlGame.Height Then
            picTomato2.Top = -300 * Rnd()
            score += 100
        Else
            picTomato2.Top += 5
        End If

        REM Drop tomato 3
        If picTomato3.Top > pnlGame.Height Then
            picTomato3.Top = -300 * Rnd()
            score += 100
        Else
            picTomato3.Top += 2
        End If

        REM Drop tomato 4
        If picTomato4.Top > pnlGame.Height Then
            picTomato4.Top = -300 * Rnd()
            score += 100
        Else
            picTomato3.Top += 5
        End If

        REM Drop tomato 5
        If picTomato5.Top > pnlGame.Height Then
            picTomato5.Top = -300 * Rnd()
            score += 100
        Else
            picTomato5.Top += 5
        End If

        REM Show score
        lblScore.Text = score

        REM Detect collision
        REM Check tomato 1
        If picDino.Bounds.IntersectsWith(picTomato1.Bounds) Then
            picTomato1.Top = -300 * Rnd()
            lives -= 1
            lblLives.Text = lives
        End If

        REM Check tomato 2
        If picDino.Bounds.IntersectsWith(picTomato2.Bounds) Then
            picTomato2.Top = -300 * Rnd()
            lives -= 1
            lblLives.Text = lives
        End If

        REM Check tomato 3
        If picDino.Bounds.IntersectsWith(picTomato3.Bounds) Then
            picTomato3.Top = -300 * Rnd()
            lives -= 1
            lblLives.Text = lives
        End If

        REM Check tomato 4
        If picDino.Bounds.IntersectsWith(picTomato4.Bounds) Then
            picTomato4.Top = -300 * Rnd()
            lives -= 1
            lblLives.Text = lives
        End If

        REM Check tomato 5
        If picDino.Bounds.IntersectsWith(picTomato5.Bounds) Then
            picTomato5.Top = -300 * Rnd()
            lives -= 1
            lblLives.Text = lives
        End If

        REM End of game?
        If lives < 1 Then
            tmrGame.Enabled = False
            MsgBox("Game Over", MsgBoxStyle.Exclamation, "Congratulations")
            MsgBox("Your score is " & score, , "Well done")
        End If
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        REM Quit the program
        frmMenu.Show()
        Me.Close()
    End Sub
End Class
