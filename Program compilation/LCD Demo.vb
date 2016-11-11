Public Class frmLCD_Demo
    REM Liquid Crystal Display demo
    REM By Michael Dao
    REM Simulates a seven segment liquid crystal display
    REM Started: 4/2/2014
    REM Known errors: 'nil 

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        'back to the menu
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btOne.Click
        REM Display number 1
        lblTop.BackColor = Color.DarkGreen
        lblTopLeft.BackColor = Color.DarkGreen
        lblTopRight.BackColor = Color.Lime
        lblMiddle.BackColor = Color.DarkGreen
        lblBottomLeft.BackColor = Color.DarkGreen
        lblBottomRight.BackColor = Color.Lime
        lblBottom.BackColor = Color.DarkGreen
        lblOneTop.BackColor = Color.DarkGreen
        lblOneBottom.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        REM Display number 2
        lblTop.BackColor = Color.Lime
        lblTopLeft.BackColor = Color.DarkGreen
        lblTopRight.BackColor = Color.Lime
        lblMiddle.BackColor = Color.Lime
        lblBottomLeft.BackColor = Color.Lime
        lblBottomRight.BackColor = Color.DarkGreen
        lblBottom.BackColor = Color.Lime
        lblOneTop.BackColor = Color.DarkGreen
        lblOneBottom.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        REM Display number 3
        lblTop.BackColor = Color.Lime
        lblTopLeft.BackColor = Color.DarkGreen
        lblTopRight.BackColor = Color.Lime
        lblMiddle.BackColor = Color.Lime
        lblBottomLeft.BackColor = Color.DarkGreen
        lblBottomRight.BackColor = Color.Lime
        lblBottom.BackColor = Color.Lime
        lblOneTop.BackColor = Color.DarkGreen
        lblOneBottom.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click
        REM Display number 4
        lblTop.BackColor = Color.DarkGreen
        lblTopLeft.BackColor = Color.Lime
        lblTopRight.BackColor = Color.Lime
        lblMiddle.BackColor = Color.Lime
        lblBottomLeft.BackColor = Color.DarkGreen
        lblBottomRight.BackColor = Color.Lime
        lblBottom.BackColor = Color.DarkGreen
        lblOneTop.BackColor = Color.DarkGreen
        lblOneBottom.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFive.Click
        REM Display number 5
        lblTop.BackColor = Color.Lime
        lblTopLeft.BackColor = Color.Lime
        lblTopRight.BackColor = Color.DarkGreen
        lblMiddle.BackColor = Color.Lime
        lblBottomLeft.BackColor = Color.DarkGreen
        lblBottomRight.BackColor = Color.Lime
        lblBottom.BackColor = Color.Lime
        lblOneTop.BackColor = Color.DarkGreen
        lblOneBottom.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnSix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSix.Click
        REM Display number 6
        lblTop.BackColor = Color.Lime
        lblTopLeft.BackColor = Color.Lime
        lblTopRight.BackColor = Color.DarkGreen
        lblMiddle.BackColor = Color.Lime
        lblBottomLeft.BackColor = Color.Lime
        lblBottomRight.BackColor = Color.Lime
        lblBottom.BackColor = Color.Lime
        lblOneTop.BackColor = Color.DarkGreen
        lblOneBottom.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnSeven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeven.Click
        REM Display number 7
        lblTop.BackColor = Color.Lime
        lblTopLeft.BackColor = Color.DarkGreen
        lblTopRight.BackColor = Color.Lime
        lblMiddle.BackColor = Color.DarkGreen
        lblBottomLeft.BackColor = Color.DarkGreen
        lblBottomRight.BackColor = Color.Lime
        lblBottom.BackColor = Color.DarkGreen
        lblOneTop.BackColor = Color.DarkGreen
        lblOneBottom.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnEight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEight.Click
        REM Display number 8
        lblTop.BackColor = Color.Lime
        lblTopLeft.BackColor = Color.Lime
        lblTopRight.BackColor = Color.Lime
        lblMiddle.BackColor = Color.Lime
        lblBottomLeft.BackColor = Color.Lime
        lblBottomRight.BackColor = Color.Lime
        lblBottom.BackColor = Color.Lime
        lblOneTop.BackColor = Color.DarkGreen
        lblOneBottom.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNine.Click
        REM Display number 9
        lblTop.BackColor = Color.Lime
        lblTopLeft.BackColor = Color.Lime
        lblTopRight.BackColor = Color.Lime
        lblMiddle.BackColor = Color.Lime
        lblBottomLeft.BackColor = Color.DarkGreen
        lblBottomRight.BackColor = Color.Lime
        lblBottom.BackColor = Color.Lime
        lblOneTop.BackColor = Color.DarkGreen
        lblOneBottom.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        REM Display number 0
        lblTop.BackColor = Color.Lime
        lblTopLeft.BackColor = Color.Lime
        lblTopRight.BackColor = Color.Lime
        lblMiddle.BackColor = Color.DarkGreen
        lblBottomLeft.BackColor = Color.Lime
        lblBottomRight.BackColor = Color.Lime
        lblBottom.BackColor = Color.Lime
        lblOneTop.BackColor = Color.DarkGreen
        lblOneBottom.BackColor = Color.DarkGreen
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        lblTop.BackColor = Color.DarkGreen
        lblTopLeft.BackColor = Color.DarkGreen
        lblTopRight.BackColor = Color.DarkGreen
        lblMiddle.BackColor = Color.DarkGreen
        lblBottomLeft.BackColor = Color.DarkGreen
        lblBottomRight.BackColor = Color.DarkGreen
        lblBottom.BackColor = Color.DarkGreen
        lblOneTop.BackColor = Color.DarkGreen
        lblOneBottom.BackColor = Color.DarkGreen
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTen.Click
        REM Display number 10
        lblTop.BackColor = Color.Lime
        lblTopLeft.BackColor = Color.Lime
        lblTopRight.BackColor = Color.Lime
        lblMiddle.BackColor = Color.DarkGreen
        lblBottomLeft.BackColor = Color.Lime
        lblBottomRight.BackColor = Color.Lime
        lblBottom.BackColor = Color.Lime
        lblOneTop.BackColor = Color.Lime
        lblOneBottom.BackColor = Color.Lime
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEleven.Click
        REM Display number 11
        lblTop.BackColor = Color.DarkGreen
        lblTopLeft.BackColor = Color.DarkGreen
        lblTopRight.BackColor = Color.Lime
        lblMiddle.BackColor = Color.DarkGreen
        lblBottomLeft.BackColor = Color.DarkGreen
        lblBottomRight.BackColor = Color.Lime
        lblBottom.BackColor = Color.DarkGreen
        lblOneTop.BackColor = Color.Lime
        lblOneBottom.BackColor = Color.Lime
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwelve.Click
        REM Display number 12
        lblTop.BackColor = Color.Lime
        lblTopLeft.BackColor = Color.DarkGreen
        lblTopRight.BackColor = Color.Lime
        lblMiddle.BackColor = Color.Lime
        lblBottomLeft.BackColor = Color.Lime
        lblBottomRight.BackColor = Color.DarkGreen
        lblBottom.BackColor = Color.Lime
        lblOneTop.BackColor = Color.Lime
        lblOneBottom.BackColor = Color.Lime
    End Sub
End Class