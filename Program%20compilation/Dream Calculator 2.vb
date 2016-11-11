Public Class frmDream_Calculator_2
    REM Dream Calculator
    ' Inputs two numbers in text boxes
    ' Calculate +, -, x, /, ^2Root
    ' Displays the results
    ' (Input - Processing - Output)
    ' Multiple forms
    ' Transfers data inbetween froms
    REM Started: 14/2/2014

    REM Declare Form Level Variables
    Dim XValue, YValue, AddResult, SubResult, MultResult, DivResult, SquareX, SquareRootX, CubedX As Single

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        REM Input 
        XValue = txtXvalue.Text
        YValue = txtYValue.Text

        REM Processing 
        AddResult = XValue + YValue
        SubResult = XValue + YValue
        MultResult = XValue * YValue
        DivResult = XValue / YValue
        SquareX = XValue ^ 2
        SquareRootX = Math.Sqrt(XValue)
        CubedX = XValue ^ 3

        REM Output
        lblAddResult.Text = AddResult
        lblSubResult.Text = SubResult
        lblMultiResult.Text = MultResult
        lblDivResult.Text = DivResult
        lblSquareResult.Text = SquareX
        lblSquareRootResult.Text = SquareRootX
        lblCubedResult.Text = CubedX
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        'back to the menu
        Me.Close()
        frmMenu.Show()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        REM Clear text from boxes and labels
        txtYValue.Text = 0
        txtXvalue.Text = 0
        lblAddResult.Text = 0
        lblSubResult.Text = 0
        lblMultiResult.Text = 0
        lblDivResult.Text = 0
        lblSquareResult.Text = 0
        lblSquareRootResult.Text = 0
    End Sub

    Private Sub frmCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        REM Copy UserName to label
        lblUserName.Text = UserName
        REM Setup unusual characters
        lblSquareLabel.Text = "x" & Chr(178)
        lblSquareRootLabel.Text = Chr(214) & Chr(67)
    End Sub
End Class

