Imports System.IO
Public Class frmTimetable_Manager
    'By Michael Dao
    'Started 23/08/2015
    'Finished 
    'a program that allows the user to manipulate data and save it for a timetable

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        'Prompts the user to save if has not been done, allows them choose whether to quit
        If btnSave.Enabled = False Then
            Me.Dispose()
            frmMenu.Show()
        Else
            'reminds the user that they have not saved 
            If MsgBox("Changes to your timetable since the last visit will be lost! Are you sure you want to quit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                'quits if they press OK
                Me.Dispose()
                frmMenu.Show()
            End If
        End If
    End Sub

    Private Sub text_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonday.TextChanged, txtTuesday.TextChanged, txtWednesday.TextChanged, txtThursday.TextChanged, txtFriday.TextChanged
        'all the text boxes have been included within the new subroutine to prevent repitition of code
        'sets the save button to true whenever data has been altered
        btnSave.Enabled = True
    End Sub

    Private Sub frmTimeTable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Declare the variables we will be using to access our files
        Dim MyReader As StreamReader

        MyReader = File.OpenText("monday.txt")
        txtMonday.Text = MyReader.ReadToEnd
        MyReader.Close()

        MyReader = File.OpenText("tuesday.txt")
        txtTuesday.Text = MyReader.ReadToEnd
        MyReader.Close()

        MyReader = File.OpenText("wednesday.txt")
        txtWednesday.Text = MyReader.ReadToEnd
        MyReader.Close()

        MyReader = File.OpenText("thursday.txt")
        txtThursday.Text = MyReader.ReadToEnd
        MyReader.Close()

        MyReader = File.OpenText("friday.txt")
        txtFriday.Text = MyReader.ReadToEnd
        MyReader.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'this code will save the altered data by writing the contents of the textboxes back into the text files
        Dim MyWriter As StreamWriter

        MyWriter = File.CreateText("monday.txt")
        MyWriter.Write(txtMonday.Text)
        MyWriter.Close()

        MyWriter = File.CreateText("tuesday.txt")
        MyWriter.Write(txtTuesday.Text)
        MyWriter.Close()

        MyWriter = File.CreateText("wednesday.txt")
        MyWriter.Write(txtWednesday.Text)
        MyWriter.Close()

        MyWriter = File.CreateText("thursday.txt")
        MyWriter.Write(txtThursday.Text)
        MyWriter.Close()

        MyWriter = File.CreateText("friday.txt")
        MyWriter.Write(txtFriday.Text)
        MyWriter.Close()

        btnSave.Enabled = False
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        'Opens the form frmAbout
        Dim AboutForm As New frmTimetable_Manager_2
        AboutForm.ShowDialog()
    End Sub
End Class