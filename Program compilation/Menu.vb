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
End Class