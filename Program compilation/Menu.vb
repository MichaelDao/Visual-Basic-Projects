'Program compilation
'created by Michael Dao
'This is a compilation of all my programs made during highschool, they all helped me practice programming
'Started: 11/11/2016

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

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'Balloon chase 
        Me.Hide()
        frmBalloon_Chase.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Investment Calculator
        Me.Hide()
        frmInvestment_Calculator.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'Dodge the tomatoes
        Me.Hide()
        frmDodge_The_Tomatoes.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'Sandwich Shop
        Me.Hide()
        frmSandwich_Shop.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'Project 1: Racing Game
        Me.Hide()
        frmRacing_Game.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'Project 1: Jumper
        Me.Hide()
        frmJumper.Show()
    End Sub
End Class