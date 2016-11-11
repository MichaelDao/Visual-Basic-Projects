REM Five-question quiz program
REM by Michael Dao
REM Poses 5 questions about (your topic) and
REM corrects user answers and
REM displays running scores and comments about the user's progress.
REM Started: 13/03/2014

Public Class frmQuiz
    Private Sub frmQuiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Set up program defaults
        picReward.Visible = False
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        REM Declare local variables
        Dim message As String
        Dim Answer As MsgBoxResult

        If TotalScore < 5 Then
            message = "You have not completed all the questions" & vbCrLf & "are you sure you really want to quit?"
            Answer = MsgBox(message, MsgBoxStyle.YesNo, "Note")
            If Answer = MsgBoxResult.Yes Then
                MsgBox("Goodbye", , "")
                frmMenu.Show()
                Me.Close()
            Else
                MsgBox("Please continue", , "Note")
            End If
        Else
            REM Game finished so quit
            frmMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub calculateScore()
        REM Calculate the score
        ' MsgBox("Calculate score routine started")
        TotalScore = TotalScore + 1
        lblOutOf.Text = TotalScore
        lblScore.Text = score
        percentage = score / TotalScore
        lblPercent.Text = Format(percentage, "percent")

        REM Check if passed 
        If percentage >= 0.5 Then
            lblRating.BackColor = Color.White
            lblRating.ForeColor = Color.Black
            lblRating.Text = "Satisfactory"
        Else
            lblRating.BackColor = Color.White
            lblRating.ForeColor = Color.Red
            lblRating.Text = "Not satisfactory"
        End If

        If percentage >= 1 Then
            lblRating.BackColor = Color.Green
            lblRating.ForeColor = Color.White
            lblRating.Text = "Excellent"
        Else
            lblRating.BackColor = Color.Red
            lblRating.ForeColor = Color.White
            lblRating.Text = "Try harder"
        End If
    End Sub

    Private Sub btnQ1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ1.Click
        REM Get answer using an input box 
        Response = InputBox("Type in the answer", "Question 1")

        REM Check if answer 1 is corret 
        If Response = "herbivores" Then
            lblResult1.Text = "Correct"
            score = score + 1
        Else
            lblResult1.Text = "Incorrect"
            MsgBox("The correct answer is herbivores.", MsgBoxStyle.OkOnly, "Question 1")
        End If

        REM Disable the question button
        btnQ1.Enabled = False
        REM The calculator score routine
        Call calculateScore()
    End Sub

    Private Sub btnQ2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ2.Click
        REM Get answer using an input box 
        Response = InputBox("Type in the answer", "Question 2")

        REM Check if answer 2 is corret 
        If Response = "no" Then
            lblResult2.Text = "Correct"
            score = score + 1
        Else
            lblResult2.Text = "Incorrect"
            MsgBox("The correct answer is no.", MsgBoxStyle.OkOnly, "Question 2")
        End If

        REM Disable the question button
        btnQ2.Enabled = False
        REM The calculator score routine
        Call calculateScore()
    End Sub

    Private Sub btnQ3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ3.Click
        REM Get answer using an input box 
        Response = InputBox("Type in the answer", "Question 3")

        REM Check if answer 3 is corret 
        If Response = "random access memory" Then
            lblResult3.Text = "Correct"
            score = score + 1
        Else
            lblResult3.Text = "Incorrect"
            MsgBox("The correct answer is random access memory.", MsgBoxStyle.OkOnly, "Question 3")
        End If

        REM Disable the question button
        btnQ3.Enabled = False
        REM The calculator score routine
        Call calculateScore()
    End Sub

    Private Sub btnQ4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ4.Click
        REM Get answer using an input box 
        Response = InputBox("Type in the answer", "Question 4")

        REM Check if answer 4 is corret 
        If Response = "Yuri Gagarin" Then
            lblResult4.Text = "Correct"
            score = score + 1
        Else
            lblResult4.Text = "Incorrect"
            MsgBox("The correct answer is Yuri Gagarin.", MsgBoxStyle.OkOnly, "Question 4")
        End If

        REM Disable the question button
        btnQ4.Enabled = False
        REM The calculator score routine
        Call calculateScore()
    End Sub

    Private Sub btnQ5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQ5.Click
        REM Get answer using an input box 
        Response = InputBox("Type in the answer", "Question 5")

        REM Check if answer 5 is corret 
        If Response = "earth" Then
            lblResult5.Text = "Correct"
            score = score + 1
        Else
            lblResult5.Text = "Incorrect"
            MsgBox("The correct answer is earth.", MsgBoxStyle.OkOnly, "Question 5")
        End If
        REM Disable the question button
        btnQ5.Enabled = False
        REM The calculator score routine
        Call calculateScore()
    End Sub
End Class