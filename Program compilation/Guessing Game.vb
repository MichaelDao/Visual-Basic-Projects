Public Class frmGuessing_Game
    'By Michael Dao
    'Started on 19/08/2015
    'Finished on 19/08/2015
    'Generates a random number between 1 and 25 in which the user has to guess whether it is odd or even

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'This form will generate a new random number between 1 and 25 
        'It will display it in the textbox
        Randomize()
        txtDisplay.Text = Int(Rnd() * 25 + 1)
    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click
        'If the text box is displayed it hides it
        'otherwise it shows it
        If txtDisplay.Visible = True Then
            btnHide.Text = "&Show"
            txtDisplay.Visible = False
        Else
            btnHide.Text = "&Hide"
            txtDisplay.Visible = True
        End If
    End Sub

    Private Sub btnCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompare.Click
        'This button will determine whether or not the number is even
        Dim Even As Boolean
        'It will be first determined if the number is even or not
        If Val(txtDisplay.Text) Mod 2 = 0 Then
            Even = True
        Else
            Even = False
        End If

        'The user's guess will be compared with the value of the variable Even
        If Even = True And rdbEven.Checked = True Then
            'if even was picked and it was even
            lblWin.Visible = True
        ElseIf Even = False And rdbOdd.Checked = True Then
            'if odd was picked and it was odd
            lblWin.Visible = True
        Else
            'if the wrong answer was picked
            lblLose.Visible = True
        End If

        'disables the compare button so it cannot be clicked until restart
        btnCompare.Enabled = False
        btnHide.Enabled = True
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'resets all the buttons and boxes
        txtDisplay.Visible = False
        btnHide.Text = "&Show"
        lblWin.Visible = False
        lblLose.Visible = False
        btnCompare.Enabled = True
        btnHide.Enabled = False

        'generate a new random number between 1 and 25
        Randomize()
        txtDisplay.Text = Int(Rnd() * 25 + 1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'go back to menu
        Me.Close()
        frmMenu.Show()
    End Sub
End Class