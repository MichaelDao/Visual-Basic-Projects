<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvestment_Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCompoundInterest = New System.Windows.Forms.Button()
        Me.btnSimpleInterest = New System.Windows.Forms.Button()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblInterest = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.txtinvestment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboSimpleRate = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstAge = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpOutput.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCompoundInterest
        '
        Me.btnCompoundInterest.Location = New System.Drawing.Point(137, 258)
        Me.btnCompoundInterest.Name = "btnCompoundInterest"
        Me.btnCompoundInterest.Size = New System.Drawing.Size(107, 34)
        Me.btnCompoundInterest.TabIndex = 11
        Me.btnCompoundInterest.Text = "Compound Interest Investment"
        '
        'btnSimpleInterest
        '
        Me.btnSimpleInterest.Location = New System.Drawing.Point(12, 258)
        Me.btnSimpleInterest.Name = "btnSimpleInterest"
        Me.btnSimpleInterest.Size = New System.Drawing.Size(107, 34)
        Me.btnSimpleInterest.TabIndex = 10
        Me.btnSimpleInterest.Text = "Simple Interest Investment"
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.lblBalance)
        Me.grpOutput.Controls.Add(Me.Label8)
        Me.grpOutput.Controls.Add(Me.lblInterest)
        Me.grpOutput.Controls.Add(Me.Label6)
        Me.grpOutput.Controls.Add(Me.lblYears)
        Me.grpOutput.Controls.Add(Me.Label4)
        Me.grpOutput.Location = New System.Drawing.Point(12, 300)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(232, 120)
        Me.grpOutput.TabIndex = 9
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Outputs"
        '
        'lblBalance
        '
        Me.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBalance.Location = New System.Drawing.Point(136, 80)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(88, 24)
        Me.lblBalance.TabIndex = 5
        Me.lblBalance.Text = "0"
        Me.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 24)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Balance Retirement:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblInterest
        '
        Me.lblInterest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInterest.Location = New System.Drawing.Point(136, 48)
        Me.lblInterest.Name = "lblInterest"
        Me.lblInterest.Size = New System.Drawing.Size(88, 24)
        Me.lblInterest.TabIndex = 3
        Me.lblInterest.Text = "0"
        Me.lblInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Interest at Retirement:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYears
        '
        Me.lblYears.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYears.Location = New System.Drawing.Point(136, 16)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(88, 24)
        Me.lblYears.TabIndex = 1
        Me.lblYears.Text = "0"
        Me.lblYears.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Years to Retirement:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.txtinvestment)
        Me.grpInput.Controls.Add(Me.Label3)
        Me.grpInput.Controls.Add(Me.cboSimpleRate)
        Me.grpInput.Controls.Add(Me.Label2)
        Me.grpInput.Controls.Add(Me.Label1)
        Me.grpInput.Controls.Add(Me.lstAge)
        Me.grpInput.Location = New System.Drawing.Point(12, 12)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(232, 240)
        Me.grpInput.TabIndex = 8
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Inputs"
        '
        'txtinvestment
        '
        Me.txtinvestment.Location = New System.Drawing.Point(124, 40)
        Me.txtinvestment.Name = "txtinvestment"
        Me.txtinvestment.Size = New System.Drawing.Size(100, 20)
        Me.txtinvestment.TabIndex = 6
        Me.txtinvestment.Text = "1000"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Simple Interest Rate"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboSimpleRate
        '
        Me.cboSimpleRate.Location = New System.Drawing.Point(24, 208)
        Me.cboSimpleRate.Name = "cboSimpleRate"
        Me.cboSimpleRate.Size = New System.Drawing.Size(80, 21)
        Me.cboSimpleRate.TabIndex = 4
        Me.cboSimpleRate.Text = "ComboBox1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(136, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Investment"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Age"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstAge
        '
        Me.lstAge.Location = New System.Drawing.Point(16, 40)
        Me.lstAge.Name = "lstAge"
        Me.lstAge.Size = New System.Drawing.Size(88, 134)
        Me.lstAge.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(85, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 34)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Return to menu"
        '
        'frmInvestment_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCompoundInterest)
        Me.Controls.Add(Me.btnSimpleInterest)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpInput)
        Me.Name = "frmInvestment_Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Investment Calculator"
        Me.grpOutput.ResumeLayout(False)
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCompoundInterest As Button
    Friend WithEvents btnSimpleInterest As Button
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblInterest As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblYears As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboSimpleRate As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lstAge As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtinvestment As TextBox
End Class
