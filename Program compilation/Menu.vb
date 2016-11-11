'Program compilation
'created by Michael Dao
'This is a compilation of all my programs made during highschool, they all helped me practice programming
Started: 11/11/2916

Public Class frmMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'LCD Demo
        Me.Hide()
        frmLCD_Demo.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dream calculator
        Me.Hide()
        frmDream_Calculator.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Basketball Scoreboard
        Me.Hide()
        frmBasketball_Scoreboard.Show()
        frmBasketball_Scoreboard_2.Show()
        timerstop = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'quiz
        Me.Hide()
        frmQuiz.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'message boxes
        Me.Hide()
        frmMessage_Boxes.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'stopwatch
        Me.Hide()
        frmStopwatch.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Animation
        Me.Hide()
        frmAnimation.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'Button Game
        Me.Hide()
        frmButton_Game.Show()
    End Sub
End Class