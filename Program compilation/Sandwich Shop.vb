REM Sandwich Shop
REM by Michael Dao 
REM Calculates the cost of sandwiches
REM Started:15/05/2014
REM known errors 'nil

Public Class frmSandwich_Shop
    Dim count As Integer
    Dim toppingCount As Integer
    Dim thisSandwich As Single
    Dim total As Single = 0
    Dim quantity As Integer
    Dim tableCharge As Single
    Dim answer As MsgBoxResult

    Private Sub frmOrders_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Populate quantity list box
        count = 0
        Do
            count += 1
            lstQuantity.Items.Add(count)
        Loop Until count = 10

        REM Default
        lstQuantity.SelectedItem = 1

        REM Bread list box
        lstBread.Items.Add("White")
        lstBread.Items.Add("Whole Meal")
        lstBread.Items.Add("Oat")
        lstBread.Items.Add("Heptagrain")

        REM Default
        lstBread.SelectedItem = "white"
        btnFinish.Enabled = False
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        REM Cost of 1 sandwich
        btnCalculate.Enabled = False
        toppingCount = 0
        thisSandwich = 0
        quantity = Val(lstQuantity.SelectedItem)

        'long set of IF statements
        If lstBread.SelectedItem = "white" Or lstBread.SelectedItem = "Whole Meal then" Then
            thisSandwich += 1
        End If
        If lstBread.SelectedItem = "Oat" Then
            thisSandwich += 1.1
        End If
        If lstBread.SelectedItem = "Hepagrain" Then
            thisSandwich += 1.2
        End If
        If chkCheese.Checked Then
            toppingCount += 1
        End If
        If chkTuna.Checked Then
            toppingCount += 1
        End If
        If chkHam.Checked Then
            toppingCount += 1
        End If
        If chkCrab.Checked Then
            toppingCount += 1
        End If

        'setup variables
        lblToppingCount.Text = toppingCount
        thisSandwich = thisSandwich + toppingCount * 0.8
        thisSandwich = quantity * thisSandwich
        lblThisSandwich.Text = FormatCurrency(thisSandwich)
        total += thisSandwich
        lblTotal.Text = FormatCurrency(total)
        answer = MsgBox("Another Sandwich?", MsgBoxStyle.YesNo, "")

        'check if user clicked no
        If answer = MsgBoxResult.No Then
            btnCalculate.Enabled = False
            btnFinish.Enabled = True
        Else
            btnCalculate.Enabled = True
            Call nextSandwich()
        End If
    End Sub

    Private Sub nextSandwich()
        REM Set defaults
        lstQuantity.SelectedItem = 1
        lstBread.SelectedItem = "White"
        chkCheese.Checked = False
        chkTuna.Checked = False
        chkHam.Checked = False
        chkCrab.Checked = False
        lblToppingCount.Text = 0
        lblThisSandwich.Text = ""

        REM Calculate total
        lblTotal.Text = FormatCurrency(total)
    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        btnFinish.Enabled = False
        REM Finalise order
        If chkTableCharge.Checked Then
            tableCharge = 1.5
        Else
            tableCharge = 0
        End If

        REM Calculate total
        lblTableCharge.Text = FormatCurrency(tableCharge)
        total += tableCharge
        lblTotal.Text = FormatCurrency(total)
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        REM Set defaults
        total = 0
        thisSandwich = 0
        lblTableCharge.Text = FormatCurrency(0)
        lblTotal.Text = FormatCurrency(0)
        tableCharge = 0
        lstQuantity.SelectedItem = 1
        lstBread.SelectedItem = "White"
        chkCheese.Checked = False
        chkTuna.Checked = False
        chkHam.Checked = False
        chkCrab.Checked = False
        lblToppingCount.Text = 0
        lblThisSandwich.Text = ""
        btnFinish.Enabled = False
        btnCalculate.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'go back to menu
        frmMenu.Show()
        Me.Close()
    End Sub
End Class
