REM Fun Button Game
REM By Michael Dao
REM Started: 2/04/2013
REM Finished: 2/04/2014
REM Known Errors: 'Nil

Public Class frmButton_Game
    REM Declare form level variable
    Dim score As Integer = 0

    Private Sub btnWin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWin.Click
        REM Win the game
        score += 1
        lblScore.Text = score
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Initialise the random number generator 
        Randomize()
    End Sub

    Private Sub btnWin_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWin.MouseHover
        REM Move the button
        btnWin.Left = Rnd() * pnlGame.Width
        btnWin.Top = Rnd() * pnlGame.Height
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmMenu.Show()
    End Sub
End Class