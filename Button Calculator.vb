Public Class frmButton_Calculator
    REM By Michael Dao
    'Started 19/08/2015
    'Finished 19/08/2015
    'This form will have a button calculator
    Dim total1 As Double
    Dim total2 As Double

    Private Sub btnZero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZero.Click
        REM Adds a 0 to the lblDisplay label
        lblDisplay.Text = lblDisplay.Text & btnZero.Text
    End Sub

    Private Sub btnOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOne.Click
        REM Adds a 1 to the lblDisplay label
        lblDisplay.Text = lblDisplay.Text & btnOne.Text
    End Sub

    Private Sub btnTwo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwo.Click
        REM Adds a 2 to the lblDisplay label
        lblDisplay.Text = lblDisplay.Text & btnTwo.Text
    End Sub

    Private Sub btnThree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThree.Click
        REM Adds a 3 to the lblDisplay label
        lblDisplay.Text = lblDisplay.Text & btnThree.Text
    End Sub

    Private Sub btnFour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFour.Click
        REM Adds a 4 to the lblDisplay label
        lblDisplay.Text = lblDisplay.Text & btnFour.Text
    End Sub

    Private Sub btnFive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFive.Click
        REM Adds a 5 to the lblDisplay label
        lblDisplay.Text = lblDisplay.Text & btnFive.Text
    End Sub

    Private Sub btnSix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSix.Click
        REM Adds a 6 to the lblDisplay label
        lblDisplay.Text = lblDisplay.Text & btnSix.Text
    End Sub

    Private Sub btnSeven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeven.Click
        REM Adds a 7 to the lblDisplay label
        lblDisplay.Text = lblDisplay.Text & btnSeven.Text
    End Sub

    Private Sub btnEight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEight.Click
        REM Adds a 8 to the lblDisplay label
        lblDisplay.Text = lblDisplay.Text & btnEight.Text
    End Sub

    Private Sub btnNine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNine.Click
        REM Adds a 9 to the lblDisplay label
        lblDisplay.Text = lblDisplay.Text & btnNine.Text
    End Sub

    Private Sub btnDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecimal.Click
        REM Adds a decimal to the lblDisplay label
        lblDisplay.Text = lblDisplay.Text & btnDecimal.Text
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        REM this makes the lblDisplay label assign the existing value to the variable total1
        total1 = total1 + Val(lblDisplay.Text)
        lblDisplay.Text = ""
    End Sub

    Private Sub btnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEquals.Click
        REM This adds the value ldlDisplay to whatever the value is in the variable total1 and assigns the new value to total2, it then displays total 2 value in lblDisplay
        total2 = total1 + Val(lblDisplay.Text)
        lblDisplay.Text = total2
        total1 = 0
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        REM Resets the value for total1 back to zero
        lblDisplay.Text = ""
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        REM Creates a message box asking the user if they want to close the form
        Dim response As Integer
        response = MsgBox("Are you sure you wish to exit?", MsgBoxStyle.YesNo, "Push Button Calculator")
        If response = vbYes Then
            Me.Close()
            frmMenu.Show()
        End If
    End Sub
End Class

