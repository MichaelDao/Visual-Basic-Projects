REM Investment Calculator
REM by Michael Dao
REM Use loops to fill list boxes
REM Use loops to calculate simple and compound interest
REM Started: 12/05/14 
REM Known errors: 'nil

Public Class frmInvestment_Calculator
    REM declare form level Variables
    Dim Years As Integer

    Private Sub frmCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Declare Local Variables
        Dim Counter As Integer
        'Dim Investment As Integer

        REM Populate the age list box
        ' Use a post-test loop
        Counter = 18 ' starting point
        Do
            lstAge.Items.Add(Counter)
            Counter += 1
        Loop Until Counter >= 65

        REM Populate the Rate Combo Box
        'Use pre-test loop
        Dim Rate As Single = 3.0
        Do While Rate < 12
            cboSimpleRate.Items.Add(Format(Rate, "fixed"))
            Rate += 0.25
        Loop

        REM Set the default Rate
        cboSimpleRate.SelectedItem = "6.00"
    End Sub

    Private Sub btnSimpleInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpleInterest.Click
        REM Declare Local Variables
        Dim rate, balance, interest As Single
        Dim counter As Integer

        REM Get starting Investment
        balance = txtinvestment.Text

        REM Calculate the length of the investment
        Years = 65 - lstAge.SelectedItem
        lblYears.Text = Years

        REM get Rate
        rate = cboSimpleRate.SelectedItem

        REM Pre-test loop to calculate interest
        counter = 0
        interest = 0
        Do While counter < Years
            REM Calculate Interest
            interest = interest + (rate * balance / 100)
            counter += 1
        Loop

        REM Display results
        lblInterest.Text = FormatCurrency(interest)
        lblBalance.Text = FormatCurrency(interest + balance)
    End Sub

    Private Sub btnCompoundInterest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompoundInterest.Click
        REM Declare Local Variables
        Dim balance, rate As Single
        Dim interest As Single = 0
        Dim counter As Integer = 0

        REM Calculate the time of the investment
        Years = 65 - lstAge.SelectedItem
        lblYears.Text = Years

        REM get the balance
        balance = txtinvestment.Text

        REM get Rate
        rate = cboSimpleRate.SelectedItem

        REM For-Next loop to calculate the interestsnf balance
        For counter = 0 To Years
            interest = rate * balance / 100
            balance += interest
        Next counter

        REM Display results
        lblInterest.Text = FormatCurrency(interest)
        lblBalance.Text = FormatCurrency(interest + balance)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'go back to menu
        frmMenu.Show()
        Me.Close()
    End Sub
End Class
