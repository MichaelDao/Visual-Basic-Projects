<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDream_Calculator_2
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpProcessing = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.lblCubedLabel = New System.Windows.Forms.Label()
        Me.lblCubedResult = New System.Windows.Forms.Label()
        Me.lblSubLabel = New System.Windows.Forms.Label()
        Me.lblAddLabel = New System.Windows.Forms.Label()
        Me.lblMultiLabel = New System.Windows.Forms.Label()
        Me.lblDivLabel = New System.Windows.Forms.Label()
        Me.lblSquareLabel = New System.Windows.Forms.Label()
        Me.lblSquareRootLabel = New System.Windows.Forms.Label()
        Me.lblSquareRootResult = New System.Windows.Forms.Label()
        Me.lblSquareResult = New System.Windows.Forms.Label()
        Me.lblDivResult = New System.Windows.Forms.Label()
        Me.lblMultiResult = New System.Windows.Forms.Label()
        Me.lblSubResult = New System.Windows.Forms.Label()
        Me.lblAddResult = New System.Windows.Forms.Label()
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.lblY = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.txtXvalue = New System.Windows.Forms.TextBox()
        Me.txtYValue = New System.Windows.Forms.TextBox()
        Me.grpProcessing.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.grpInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(80, 69)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(141, 40)
        Me.lblWelcome.TabIndex = 16
        Me.lblWelcome.Text = "Welcome"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Tomato
        Me.btnQuit.Location = New System.Drawing.Point(386, 551)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(122, 49)
        Me.btnQuit.TabIndex = 15
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblUserName
        '
        Me.lblUserName.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(212, 75)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(303, 40)
        Me.lblUserName.TabIndex = 14
        Me.lblUserName.Text = "User Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(532, 67)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Dream Calculator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpProcessing
        '
        Me.grpProcessing.Controls.Add(Me.btnClear)
        Me.grpProcessing.Controls.Add(Me.btnCalculate)
        Me.grpProcessing.Location = New System.Drawing.Point(8, 187)
        Me.grpProcessing.Name = "grpProcessing"
        Me.grpProcessing.Size = New System.Drawing.Size(179, 170)
        Me.grpProcessing.TabIndex = 10
        Me.grpProcessing.TabStop = False
        Me.grpProcessing.Text = "Processing"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(11, 91)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(156, 66)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.AllowDrop = True
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(11, 19)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(156, 66)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.lblCubedLabel)
        Me.grpOutput.Controls.Add(Me.lblCubedResult)
        Me.grpOutput.Controls.Add(Me.lblSubLabel)
        Me.grpOutput.Controls.Add(Me.lblAddLabel)
        Me.grpOutput.Controls.Add(Me.lblMultiLabel)
        Me.grpOutput.Controls.Add(Me.lblDivLabel)
        Me.grpOutput.Controls.Add(Me.lblSquareLabel)
        Me.grpOutput.Controls.Add(Me.lblSquareRootLabel)
        Me.grpOutput.Controls.Add(Me.lblSquareRootResult)
        Me.grpOutput.Controls.Add(Me.lblSquareResult)
        Me.grpOutput.Controls.Add(Me.lblDivResult)
        Me.grpOutput.Controls.Add(Me.lblMultiResult)
        Me.grpOutput.Controls.Add(Me.lblSubResult)
        Me.grpOutput.Controls.Add(Me.lblAddResult)
        Me.grpOutput.Location = New System.Drawing.Point(203, 187)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(305, 358)
        Me.grpOutput.TabIndex = 12
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output"
        '
        'lblCubedLabel
        '
        Me.lblCubedLabel.AutoSize = True
        Me.lblCubedLabel.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCubedLabel.Location = New System.Drawing.Point(21, 309)
        Me.lblCubedLabel.Name = "lblCubedLabel"
        Me.lblCubedLabel.Size = New System.Drawing.Size(48, 27)
        Me.lblCubedLabel.TabIndex = 16
        Me.lblCubedLabel.Text = "x^3"
        '
        'lblCubedResult
        '
        Me.lblCubedResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblCubedResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCubedResult.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCubedResult.Location = New System.Drawing.Point(82, 304)
        Me.lblCubedResult.Name = "lblCubedResult"
        Me.lblCubedResult.Size = New System.Drawing.Size(212, 37)
        Me.lblCubedResult.TabIndex = 15
        '
        'lblSubLabel
        '
        Me.lblSubLabel.AutoSize = True
        Me.lblSubLabel.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubLabel.Location = New System.Drawing.Point(10, 68)
        Me.lblSubLabel.Name = "lblSubLabel"
        Me.lblSubLabel.Size = New System.Drawing.Size(65, 27)
        Me.lblSubLabel.TabIndex = 9
        Me.lblSubLabel.Text = "X - Y"
        '
        'lblAddLabel
        '
        Me.lblAddLabel.AutoSize = True
        Me.lblAddLabel.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddLabel.Location = New System.Drawing.Point(10, 18)
        Me.lblAddLabel.Name = "lblAddLabel"
        Me.lblAddLabel.Size = New System.Drawing.Size(71, 27)
        Me.lblAddLabel.TabIndex = 10
        Me.lblAddLabel.Text = "X + Y"
        '
        'lblMultiLabel
        '
        Me.lblMultiLabel.AutoSize = True
        Me.lblMultiLabel.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiLabel.Location = New System.Drawing.Point(10, 116)
        Me.lblMultiLabel.Name = "lblMultiLabel"
        Me.lblMultiLabel.Size = New System.Drawing.Size(68, 27)
        Me.lblMultiLabel.TabIndex = 11
        Me.lblMultiLabel.Text = "X x Y"
        '
        'lblDivLabel
        '
        Me.lblDivLabel.AutoSize = True
        Me.lblDivLabel.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivLabel.Location = New System.Drawing.Point(10, 162)
        Me.lblDivLabel.Name = "lblDivLabel"
        Me.lblDivLabel.Size = New System.Drawing.Size(64, 27)
        Me.lblDivLabel.TabIndex = 12
        Me.lblDivLabel.Text = "X / Y"
        '
        'lblSquareLabel
        '
        Me.lblSquareLabel.AutoSize = True
        Me.lblSquareLabel.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquareLabel.Location = New System.Drawing.Point(21, 211)
        Me.lblSquareLabel.Name = "lblSquareLabel"
        Me.lblSquareLabel.Size = New System.Drawing.Size(48, 27)
        Me.lblSquareLabel.TabIndex = 13
        Me.lblSquareLabel.Text = "x^2"
        '
        'lblSquareRootLabel
        '
        Me.lblSquareRootLabel.Font = New System.Drawing.Font("Symbol", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblSquareRootLabel.Location = New System.Drawing.Point(13, 260)
        Me.lblSquareRootLabel.Name = "lblSquareRootLabel"
        Me.lblSquareRootLabel.Size = New System.Drawing.Size(68, 32)
        Me.lblSquareRootLabel.TabIndex = 14
        Me.lblSquareRootLabel.Text = "Sqrt"
        '
        'lblSquareRootResult
        '
        Me.lblSquareRootResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSquareRootResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSquareRootResult.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquareRootResult.Location = New System.Drawing.Point(82, 255)
        Me.lblSquareRootResult.Name = "lblSquareRootResult"
        Me.lblSquareRootResult.Size = New System.Drawing.Size(212, 37)
        Me.lblSquareRootResult.TabIndex = 5
        '
        'lblSquareResult
        '
        Me.lblSquareResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSquareResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSquareResult.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquareResult.Location = New System.Drawing.Point(82, 206)
        Me.lblSquareResult.Name = "lblSquareResult"
        Me.lblSquareResult.Size = New System.Drawing.Size(212, 37)
        Me.lblSquareResult.TabIndex = 4
        '
        'lblDivResult
        '
        Me.lblDivResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDivResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDivResult.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivResult.Location = New System.Drawing.Point(82, 157)
        Me.lblDivResult.Name = "lblDivResult"
        Me.lblDivResult.Size = New System.Drawing.Size(212, 37)
        Me.lblDivResult.TabIndex = 3
        '
        'lblMultiResult
        '
        Me.lblMultiResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMultiResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMultiResult.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiResult.Location = New System.Drawing.Point(82, 111)
        Me.lblMultiResult.Name = "lblMultiResult"
        Me.lblMultiResult.Size = New System.Drawing.Size(212, 37)
        Me.lblMultiResult.TabIndex = 2
        '
        'lblSubResult
        '
        Me.lblSubResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblSubResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubResult.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubResult.Location = New System.Drawing.Point(82, 63)
        Me.lblSubResult.Name = "lblSubResult"
        Me.lblSubResult.Size = New System.Drawing.Size(212, 37)
        Me.lblSubResult.TabIndex = 1
        '
        'lblAddResult
        '
        Me.lblAddResult.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAddResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddResult.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddResult.Location = New System.Drawing.Point(82, 13)
        Me.lblAddResult.Name = "lblAddResult"
        Me.lblAddResult.Size = New System.Drawing.Size(212, 37)
        Me.lblAddResult.TabIndex = 0
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.lblY)
        Me.grpInput.Controls.Add(Me.lblX)
        Me.grpInput.Controls.Add(Me.txtXvalue)
        Me.grpInput.Controls.Add(Me.txtYValue)
        Me.grpInput.Location = New System.Drawing.Point(8, 106)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(500, 70)
        Me.grpInput.TabIndex = 11
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Input"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblY.Location = New System.Drawing.Point(246, 19)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(49, 32)
        Me.lblY.TabIndex = 4
        Me.lblY.Text = "Y="
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblX.Location = New System.Drawing.Point(5, 19)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(48, 32)
        Me.lblX.TabIndex = 3
        Me.lblX.Text = "X="
        '
        'txtXvalue
        '
        Me.txtXvalue.BackColor = System.Drawing.Color.White
        Me.txtXvalue.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtXvalue.Location = New System.Drawing.Point(45, 19)
        Me.txtXvalue.Name = "txtXvalue"
        Me.txtXvalue.Size = New System.Drawing.Size(195, 32)
        Me.txtXvalue.TabIndex = 1
        Me.txtXvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtYValue
        '
        Me.txtYValue.BackColor = System.Drawing.Color.White
        Me.txtYValue.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYValue.Location = New System.Drawing.Point(294, 19)
        Me.txtYValue.Name = "txtYValue"
        Me.txtYValue.Size = New System.Drawing.Size(195, 32)
        Me.txtYValue.TabIndex = 0
        Me.txtYValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmDream_Calculator_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 608)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.grpProcessing)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpInput)
        Me.Name = "frmDream_Calculator_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dream Calculator "
        Me.grpProcessing.ResumeLayout(False)
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents grpProcessing As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents lblCubedLabel As Label
    Friend WithEvents lblCubedResult As Label
    Friend WithEvents lblSubLabel As Label
    Friend WithEvents lblAddLabel As Label
    Friend WithEvents lblMultiLabel As Label
    Friend WithEvents lblDivLabel As Label
    Friend WithEvents lblSquareLabel As Label
    Friend WithEvents lblSquareRootLabel As Label
    Friend WithEvents lblSquareRootResult As Label
    Friend WithEvents lblSquareResult As Label
    Friend WithEvents lblDivResult As Label
    Friend WithEvents lblMultiResult As Label
    Friend WithEvents lblSubResult As Label
    Friend WithEvents lblAddResult As Label
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents lblY As Label
    Friend WithEvents lblX As Label
    Friend WithEvents txtXvalue As TextBox
    Friend WithEvents txtYValue As TextBox
End Class
