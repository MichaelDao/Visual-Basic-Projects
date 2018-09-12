REM Simple Stopwatch
REM By Michael Dao
REM Simulates a Stopwatch with Start, Stop and Reset
REM Started: 12/2/2013
REM Known errors: 'nil

Public Class frmStopwatch
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Set up initial timer properties
        tmrStopwatch.Interval = 1 'approximately 100 seconds
        tmrStopwatch.Enabled = False 'turn the timer off
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        REM Start the watch
        REM Press Spacebar to activate
        tmrStopwatch.Enabled = True
    End Sub

    Private Sub tmrStopwatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrStopwatch.Tick
        REM Count in hundreths of seconds
        lblDisplay.Text = Format(Val(lblDisplay.Text) + 0.01, "fixed")
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        REM Stop the watch
        tmrStopwatch.Enabled = False
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        REM Reset the watch
        lblDisplay.Text = "0.00"
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        'back to the menu
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        REM Record lap time
        lblDisplay2.Text = Format(Val(lblDisplay.Text) + 0.0, "fixed")
    End Sub
End Class