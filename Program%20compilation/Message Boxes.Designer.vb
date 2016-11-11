<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessage_Boxes
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRetryCancel = New System.Windows.Forms.Button()
        Me.btnYesNo = New System.Windows.Forms.Button()
        Me.btnMixedMessage = New System.Windows.Forms.Button()
        Me.btnGraphic = New System.Windows.Forms.Button()
        Me.btnOKOnly = New System.Windows.Forms.Button()
        Me.grpRandomNumbers = New System.Windows.Forms.GroupBox()
        Me.btnRandomLetter = New System.Windows.Forms.Button()
        Me.btnSpinner = New System.Windows.Forms.Button()
        Me.btn2Dice = New System.Windows.Forms.Button()
        Me.btnDice = New System.Windows.Forms.Button()
        Me.btnHeadTail = New System.Windows.Forms.Button()
        Me.pnlSpinner = New System.Windows.Forms.Panel()
        Me.lblRandomNumber = New System.Windows.Forms.Label()
        Me.btnRandom = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttpMessages = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.grpRandomNumbers.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRetryCancel)
        Me.GroupBox1.Controls.Add(Me.btnYesNo)
        Me.GroupBox1.Controls.Add(Me.btnMixedMessage)
        Me.GroupBox1.Controls.Add(Me.btnGraphic)
        Me.GroupBox1.Controls.Add(Me.btnOKOnly)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 304)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Message Boxes"
        '
        'btnRetryCancel
        '
        Me.btnRetryCancel.Location = New System.Drawing.Point(16, 120)
        Me.btnRetryCancel.Name = "btnRetryCancel"
        Me.btnRetryCancel.Size = New System.Drawing.Size(88, 40)
        Me.btnRetryCancel.TabIndex = 4
        Me.btnRetryCancel.Text = "Retry/Cancel message"
        '
        'btnYesNo
        '
        Me.btnYesNo.Location = New System.Drawing.Point(112, 72)
        Me.btnYesNo.Name = "btnYesNo"
        Me.btnYesNo.Size = New System.Drawing.Size(88, 40)
        Me.btnYesNo.TabIndex = 3
        Me.btnYesNo.Text = "Yes/No message"
        '
        'btnMixedMessage
        '
        Me.btnMixedMessage.Location = New System.Drawing.Point(16, 72)
        Me.btnMixedMessage.Name = "btnMixedMessage"
        Me.btnMixedMessage.Size = New System.Drawing.Size(88, 40)
        Me.btnMixedMessage.TabIndex = 2
        Me.btnMixedMessage.Text = "OK mixed message"
        '
        'btnGraphic
        '
        Me.btnGraphic.Location = New System.Drawing.Point(112, 24)
        Me.btnGraphic.Name = "btnGraphic"
        Me.btnGraphic.Size = New System.Drawing.Size(88, 40)
        Me.btnGraphic.TabIndex = 1
        Me.btnGraphic.Text = "OK message with graphic"
        '
        'btnOKOnly
        '
        Me.btnOKOnly.Location = New System.Drawing.Point(16, 24)
        Me.btnOKOnly.Name = "btnOKOnly"
        Me.btnOKOnly.Size = New System.Drawing.Size(88, 40)
        Me.btnOKOnly.TabIndex = 0
        Me.btnOKOnly.Text = "Simple OK message"
        '
        'grpRandomNumbers
        '
        Me.grpRandomNumbers.Controls.Add(Me.btnRandomLetter)
        Me.grpRandomNumbers.Controls.Add(Me.btnSpinner)
        Me.grpRandomNumbers.Controls.Add(Me.btn2Dice)
        Me.grpRandomNumbers.Controls.Add(Me.btnDice)
        Me.grpRandomNumbers.Controls.Add(Me.btnHeadTail)
        Me.grpRandomNumbers.Controls.Add(Me.pnlSpinner)
        Me.grpRandomNumbers.Controls.Add(Me.lblRandomNumber)
        Me.grpRandomNumbers.Controls.Add(Me.btnRandom)
        Me.grpRandomNumbers.Location = New System.Drawing.Point(236, 12)
        Me.grpRandomNumbers.Name = "grpRandomNumbers"
        Me.grpRandomNumbers.Size = New System.Drawing.Size(216, 304)
        Me.grpRandomNumbers.TabIndex = 8
        Me.grpRandomNumbers.TabStop = False
        Me.grpRandomNumbers.Text = "Random Numbers"
        '
        'btnRandomLetter
        '
        Me.btnRandomLetter.Location = New System.Drawing.Point(112, 120)
        Me.btnRandomLetter.Name = "btnRandomLetter"
        Me.btnRandomLetter.Size = New System.Drawing.Size(88, 40)
        Me.btnRandomLetter.TabIndex = 8
        Me.btnRandomLetter.Text = "Random Letter"
        '
        'btnSpinner
        '
        Me.btnSpinner.Location = New System.Drawing.Point(16, 120)
        Me.btnSpinner.Name = "btnSpinner"
        Me.btnSpinner.Size = New System.Drawing.Size(88, 40)
        Me.btnSpinner.TabIndex = 7
        Me.btnSpinner.Text = "3 Colour Spinner"
        '
        'btn2Dice
        '
        Me.btn2Dice.Location = New System.Drawing.Point(112, 72)
        Me.btn2Dice.Name = "btn2Dice"
        Me.btn2Dice.Size = New System.Drawing.Size(88, 40)
        Me.btn2Dice.TabIndex = 6
        Me.btn2Dice.Text = "2 Dice"
        '
        'btnDice
        '
        Me.btnDice.Location = New System.Drawing.Point(112, 24)
        Me.btnDice.Name = "btnDice"
        Me.btnDice.Size = New System.Drawing.Size(88, 40)
        Me.btnDice.TabIndex = 5
        Me.btnDice.Text = "Single Die"
        '
        'btnHeadTail
        '
        Me.btnHeadTail.Location = New System.Drawing.Point(16, 72)
        Me.btnHeadTail.Name = "btnHeadTail"
        Me.btnHeadTail.Size = New System.Drawing.Size(88, 40)
        Me.btnHeadTail.TabIndex = 4
        Me.btnHeadTail.Text = "Heads or Tails"
        '
        'pnlSpinner
        '
        Me.pnlSpinner.Location = New System.Drawing.Point(128, 192)
        Me.pnlSpinner.Name = "pnlSpinner"
        Me.pnlSpinner.Size = New System.Drawing.Size(72, 56)
        Me.pnlSpinner.TabIndex = 3
        '
        'lblRandomNumber
        '
        Me.lblRandomNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRandomNumber.Location = New System.Drawing.Point(16, 264)
        Me.lblRandomNumber.Name = "lblRandomNumber"
        Me.lblRandomNumber.Size = New System.Drawing.Size(184, 24)
        Me.lblRandomNumber.TabIndex = 2
        Me.lblRandomNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRandom
        '
        Me.btnRandom.Location = New System.Drawing.Point(16, 24)
        Me.btnRandom.Name = "btnRandom"
        Me.btnRandom.Size = New System.Drawing.Size(88, 40)
        Me.btnRandom.TabIndex = 1
        Me.btnRandom.Text = "Random Number"
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Red
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.Lime
        Me.btnQuit.Location = New System.Drawing.Point(197, 323)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(72, 40)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'frmMessage_Boxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 371)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpRandomNumbers)
        Me.Controls.Add(Me.btnQuit)
        Me.Name = "frmMessage_Boxes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MessageBoxes"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpRandomNumbers.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRetryCancel As Button
    Friend WithEvents btnYesNo As Button
    Friend WithEvents btnMixedMessage As Button
    Friend WithEvents btnGraphic As Button
    Friend WithEvents btnOKOnly As Button
    Friend WithEvents grpRandomNumbers As GroupBox
    Friend WithEvents btnRandomLetter As Button
    Friend WithEvents btnSpinner As Button
    Friend WithEvents btn2Dice As Button
    Friend WithEvents btnDice As Button
    Friend WithEvents btnHeadTail As Button
    Friend WithEvents pnlSpinner As Panel
    Friend WithEvents lblRandomNumber As Label
    Friend WithEvents btnRandom As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ttpMessages As ToolTip
End Class
