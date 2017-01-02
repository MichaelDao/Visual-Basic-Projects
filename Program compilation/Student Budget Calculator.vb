Public Class frmStudent_Budget_Calculator
    'By Michael Dao
    'Started 20/08/2015
    'Finished 20/08/2015
    'A budget calculator for students that calculates income and expense

    Private Sub vsbIncome1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbIncome1.Scroll
        'scrolling down adds 10 cents to the relevant label
        lblIncome1.Text = Format(vsbIncome1.Value / 100, "currency")
    End Sub

    Private Sub vsbIncome2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbIncome2.Scroll
        'scrolling down adds 10 cents to the relevant label
        lblIncome2.Text = Format(vsbIncome2.Value / 100, "currency")
    End Sub

    Private Sub vsbIncome3_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbIncome3.Scroll
        'scrolling down adds 10 cents to the relevant label
        lblIncome3.Text = Format(vsbIncome3.Value / 100, "currency")
    End Sub

    Private Sub vsbExpense1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbExpense1.Scroll
        'scrolling down adds 10 cents to the relevant label
        lblExpense1.Text = Format(vsbExpense1.Value / 100, "currency")
    End Sub

    Private Sub vsbExpense2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbExpense2.Scroll
        'scrolling down adds 10 cents to the relevant label
        lblExpense2.Text = Format(vsbExpense2.Value / 100, "currency")
    End Sub

    Private Sub vsbExpense3_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbExpense3.Scroll
        'scrolling down adds 10 cents to the relevant label
        lblExpense3.Text = Format(vsbExpense3.Value / 100, "currency")
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        'this will declare the variable "Total" as a decimal
        Dim Total As Decimal = 0.0

        'Selected checkboxes will have its values multiplied by the appropriate time periods, Income checkboxes will be added to the value
        If chbIncome1.Checked = True Then
            If cmbIncome1.Text = "Daily" Then Total = Total + (vsbIncome1.Value / 100 * 365)
            If cmbIncome1.Text = "Weekly" Then Total = Total + (vsbIncome1.Value / 100 * 52)
            If cmbIncome1.Text = "Monthly" Then Total = Total + (vsbIncome1.Value / 100 * 12)
            If cmbIncome1.Text = "Annually" Then Total = Total + (vsbIncome1.Value / 100)

        ElseIf chbIncome2.Checked = True Then
            If cmbIncome2.Text = "Daily" Then Total = Total + (vsbIncome2.Value / 100 * 365)
            If cmbIncome2.Text = "Weekly" Then Total = Total + (vsbIncome2.Value / 100 * 52)
            If cmbIncome2.Text = "Monthly" Then Total = Total + (vsbIncome2.Value / 100 * 12)
            If cmbIncome2.Text = "Annually" Then Total = Total + (vsbIncome2.Value / 100)

        ElseIf chbIncome3.Checked = True Then
            If cmbIncome3.Text = "Daily" Then Total = Total + (vsbIncome3.Value / 100 * 365)
            If cmbIncome3.Text = "Weekly" Then Total = Total + (vsbIncome3.Value / 100 * 52)
            If cmbIncome3.Text = "Monthly" Then Total = Total + (vsbIncome3.Value / 100 * 12)
            If cmbIncome3.Text = "Annually" Then Total = Total + (vsbIncome3.Value / 100)
        End If

        'Expense checkboxes will be subtracted from the value 
        If chbExpense1.Checked = True Then
            If cmbExpense1.Text = "Daily" Then Total = Total - (vsbExpense1.Value / 100 * 365)
            If cmbExpense1.Text = "Weekly" Then Total = Total - (vsbExpense1.Value / 100 * 52)
            If cmbExpense1.Text = "Monthly" Then Total = Total - (vsbExpense1.Value / 100 * 12)
            If cmbExpense1.Text = "Annually" Then Total = Total - (vsbExpense1.Value / 100)

        ElseIf chbExpense2.Checked = True Then
            If cmbExpense2.Text = "Daily" Then Total = Total - (vsbExpense2.Value / 100 * 365)
            If cmbExpense2.Text = "Weekly" Then Total = Total - (vsbExpense2.Value / 100 * 52)
            If cmbExpense2.Text = "Monthly" Then Total = Total - (vsbExpense2.Value / 100 * 12)
            If cmbExpense2.Text = "Annually" Then Total = Total - (vsbExpense2.Value / 100)

        ElseIf chbExpense3.Checked = True Then
            If cmbExpense3.Text = "Daily" Then Total = Total - (vsbExpense3.Value / 100 * 365)
            If cmbExpense3.Text = "Weekly" Then Total = Total - (vsbExpense3.Value / 100 * 52)
            If cmbExpense3.Text = "Monthly" Then Total = Total - (vsbExpense3.Value / 100 * 12)
            If cmbExpense3.Text = "Annually" Then Total = Total - (vsbExpense3.Value / 100)
        End If

        'Places the value of the variable 'Total" into the label which is being used to display the total
        lblAnnual.Text = Format(Total, "Currency")
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        'quits the program
        Me.Close()
        frmMenu.Show()
    End Sub
End Class
