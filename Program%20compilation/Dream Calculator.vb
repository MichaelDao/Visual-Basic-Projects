Public Class frmDream_Calculator
    REM The Dream Calculator
    REM Splash screen (Title form)
    REM Transfer username from frmTitle to frmCalculator
    REM Show and hide forms
    REM Animated banner

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        REM Copy user name to a global variable
        UserName = txtUserName.Text
        REM Strt frmCalculator and close frmTitle
        Dim myCalculatorform As New frmDream_Calculator_2
        REM Above line of code must appear in a button or a load routine 
        myCalculatorform.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        REM back to the menu
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmTitle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Setup and start animation timer
        tmrAnimation.Interval = 600
        tmrAnimation.Enabled = True
    End Sub
End Class
