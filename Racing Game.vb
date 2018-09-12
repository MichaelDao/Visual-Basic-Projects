REM Dragster game title
REM Display title screen and instructions
REM Transition to frmDragster and hide frmTitle
REM Known Errors: 'Nil

Public Class frmRacing_Game
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        REM Start frmDragster and close frmTitle
        frmRacing_Game_2.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        'go back to menu
        frmMenu.Show()
        Me.Close()
    End Sub
End Class