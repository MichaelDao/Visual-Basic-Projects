REM Animation Demonstration
REM By Michael Dao
REM Demonstrates how to move a picture around the screen using buttons, how to shrink or enlarge a picture and how to automatically move a picture.
REM Started: 31/03/2014 

Public Class frmAnimation
    Private Sub frmSpace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Default values
        lblLeft.Text = picSpaceShip.Left
        lblUp.Text = picSpaceShip.Top
        lblSize.Text = picSpaceShip.Width
        tmrAuto.Enabled = False
    End Sub

    Private Sub btnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLeft.Click
        REM Move the spaceship left
        picSpaceShip.Left = picSpaceShip.Left - 5
        lblLeft.Text = picSpaceShip.Left
    End Sub

    Private Sub btnRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRight.Click
        REM Move the spaceship Right
        picSpaceShip.Left += 5
        lblLeft.Text = picSpaceShip.Left
    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        REM Move the spaceship up
        picSpaceShip.Top -= 5
        lblUp.Text = picSpaceShip.Top
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        REM Move the spaceship down
        picSpaceShip.Top += 5
        lblUp.Text = picSpaceShip.Top
    End Sub

    Private Sub btnLarger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLarger.Click
        REM Make sure the spaceship bigger
        picSpaceShip.Width += 3
        picSpaceShip.Height += 3
        lblSize.Text = picSpaceShip.Width
    End Sub

    Private Sub btnSmaller_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSmaller.Click
        REM Make sure the spaceship smaller
        picSpaceShip.Width -= 3
        picSpaceShip.Height -= 3
        lblSize.Text = picSpaceShip.Width
    End Sub

    Private Sub btnFlyManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFlyManual.Click
        REM Make the spaceship move down, right and get larger
        picSpaceShip.Top += 5
        picSpaceShip.Left += 3
        picSpaceShip.Width += 2
        picSpaceShip.Height += 2

        REM Put the numbers into labels
        lblLeft.Text = picSpaceShip.Left
        lblUp.Text = picSpaceShip.Top
        lblSize.Text = picSpaceShip.Width
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'back to the menu
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnFly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFly.Click
        REM Reset the spaceship
        Call Reset()
        REM Start the time
        tmrAuto.Enabled = True
    End Sub

    Private Sub tmrAuto_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrAuto.Tick
        REM Make the ship move down, right and get bigger
        picSpaceShip.Top += 5
        picSpaceShip.Left += 3
        picSpaceShip.Width += 2
        picSpaceShip.Height += 2

        REM Put the numbers into labels
        lblLeft.Text = picSpaceShip.Left
        lblUp.Text = picSpaceShip.Top
        lblSize.Text = picSpaceShip.Width
    End Sub
End Class