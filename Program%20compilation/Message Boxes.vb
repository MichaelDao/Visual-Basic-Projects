REM Message box, tool tip and random number demonstrator
REM Uses message boxes for input and output
REM by Michael Dao
REM Started: 19/03/2014

Public Class frmMessage_Boxes
    REM Form level variables
    Dim score As Integer = 0
    Dim answer As MsgBoxResult

    Private Sub frmMessageBoxes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Tool tip help messages 
        ttpMessages.SetToolTip(btnYesNo, "Yes/No button used as input")
        ttpMessages.SetToolTip(btnOKOnly, "Time that runs out")
        ttpMessages.SetToolTip(btnGraphic, "Cool yellow triangle shows up")
        ttpMessages.SetToolTip(btnMixedMessage, "Add a score of 25")
        ttpMessages.SetToolTip(btnRetryCancel, "Choose to retry or cancel the printer")
        ttpMessages.SetToolTip(btnQuit, "Quit the program")

        REM initialise the random number sequence 
        Randomize()
    End Sub

    Private Sub btnOKOnly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOKOnly.Click
        REM ok only button 
        MsgBox("Your time has run out.", , "Warning")
    End Sub

    Private Sub btnGraphic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGraphic.Click
        REM Ok button with graphic
        MsgBox("The USB drive is not available.", MsgBoxStyle.Exclamation, "Error")
    End Sub

    Private Sub btnMixedMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMixedMessage.Click
        REM Declare a local variable 
        Dim message As String

        REM Calculate the score
        score = score + 25

        REM Create the messages string
        message = "Your score is: " & score & "."

        REM Create message box
        MsgBox(message, MsgBoxStyle.Information, "Note")
    End Sub

    Private Sub btnYesNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYesNo.Click
        REM Ask a yes or no queestion
        answer = MsgBox("Would you like to play again?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Game Over")

        REM Code to play again
        If answer = MsgBoxResult.Yes Then
            MsgBox("You have chosen to play again", , "Get Ready")
        Else
            MsgBox("Thanks for playing", , "Goodbye")
            End
        End If
    End Sub

    Private Sub btnRetryCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetryCancel.Click
        REM Ask a retry or cancel question
        answer = MsgBox("The printer is not responding", MsgBoxStyle.RetryCancel + MsgBoxStyle.Critical, "Error")
        If answer = MsgBoxResult.Retry Then
            MsgBox("Your job has been printed", , "Note")
        Else
            MsgBox("The request has been canceled", , "Note")
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        REM Quit the program
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandom.Click
        REM Generate a random decimal greater than or equal to 0 and less than one
        lblRandomNumber.Text = Rnd()
    End Sub

    Private Sub btnHeadTail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeadTail.Click
        REM Heads or tails game 
        If Rnd() < 0.5 Then
            lblRandomNumber.Text = ("Heads")
        Else
            lblRandomNumber.Text = ("Tails")
        End If
    End Sub

    Private Sub btnDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDice.Click
        REM Random integer from 1 to 6
        Dim die As Single
        'die = 6 * Rnd()
        die = Int(6 * Rnd()) + 1
        lblRandomNumber.Text = die
    End Sub

    Private Sub btn2Dice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2Dice.Click
        REM Two dice
        Dim die1, die2, total As Integer
        die1 = (6 * Rnd()) + 1
        die2 = (6 * Rnd()) + 1
        total = die1 + die2
        lblRandomNumber.Text = die1 & " + " & die2 & " = " & total
    End Sub

    Private Sub btnRandomLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRandomLetter.Click
        REM generate a random letter
        Dim letter As Single
        letter = Int(26 * Rnd()) + 65
        lblRandomNumber.Text = Chr(letter)
    End Sub

    Private Sub btnSpinner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpinner.Click
        REM Random number from 0 to 2
        Dim random As Single
        random = Int(3 * Rnd())
        Select Case random
            Case 0
                pnlSpinner.BackColor = Color.Red
            Case 1
                pnlSpinner.BackColor = Color.Blue
            Case 2
                pnlSpinner.BackColor = Color.Green
        End Select
    End Sub
End Class