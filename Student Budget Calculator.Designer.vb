<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent_Budget_Calculator
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
        Me.vsbExpense3 = New System.Windows.Forms.VScrollBar()
        Me.vsbExpense2 = New System.Windows.Forms.VScrollBar()
        Me.vsbExpense1 = New System.Windows.Forms.VScrollBar()
        Me.vsbIncome3 = New System.Windows.Forms.VScrollBar()
        Me.vsbIncome2 = New System.Windows.Forms.VScrollBar()
        Me.cmbExpense2 = New System.Windows.Forms.ComboBox()
        Me.cmbExpense3 = New System.Windows.Forms.ComboBox()
        Me.cmbExpense1 = New System.Windows.Forms.ComboBox()
        Me.cmbIncome2 = New System.Windows.Forms.ComboBox()
        Me.cmbIncome3 = New System.Windows.Forms.ComboBox()
        Me.cmbIncome1 = New System.Windows.Forms.ComboBox()
        Me.vsbIncome1 = New System.Windows.Forms.VScrollBar()
        Me.chbExpense2 = New System.Windows.Forms.CheckBox()
        Me.chbExpense3 = New System.Windows.Forms.CheckBox()
        Me.chbExpense1 = New System.Windows.Forms.CheckBox()
        Me.chbIncome2 = New System.Windows.Forms.CheckBox()
        Me.chbIncome3 = New System.Windows.Forms.CheckBox()
        Me.chbIncome1 = New System.Windows.Forms.CheckBox()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblHeading4 = New System.Windows.Forms.Label()
        Me.lblAnnual = New System.Windows.Forms.Label()
        Me.lblExpense2 = New System.Windows.Forms.Label()
        Me.lblExpense3 = New System.Windows.Forms.Label()
        Me.lblExpense1 = New System.Windows.Forms.Label()
        Me.lblIncome2 = New System.Windows.Forms.Label()
        Me.lblIncome3 = New System.Windows.Forms.Label()
        Me.lblIncome1 = New System.Windows.Forms.Label()
        Me.lblHeading3 = New System.Windows.Forms.Label()
        Me.lblHeading2 = New System.Windows.Forms.Label()
        Me.lblHeading1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'vsbExpense3
        '
        Me.vsbExpense3.Location = New System.Drawing.Point(230, 260)
        Me.vsbExpense3.Maximum = 5000
        Me.vsbExpense3.Name = "vsbExpense3"
        Me.vsbExpense3.Size = New System.Drawing.Size(39, 26)
        Me.vsbExpense3.SmallChange = 10
        Me.vsbExpense3.TabIndex = 67
        '
        'vsbExpense2
        '
        Me.vsbExpense2.Location = New System.Drawing.Point(230, 224)
        Me.vsbExpense2.Maximum = 5000
        Me.vsbExpense2.Name = "vsbExpense2"
        Me.vsbExpense2.Size = New System.Drawing.Size(39, 26)
        Me.vsbExpense2.SmallChange = 10
        Me.vsbExpense2.TabIndex = 66
        '
        'vsbExpense1
        '
        Me.vsbExpense1.Location = New System.Drawing.Point(230, 188)
        Me.vsbExpense1.Maximum = 5000
        Me.vsbExpense1.Name = "vsbExpense1"
        Me.vsbExpense1.Size = New System.Drawing.Size(39, 26)
        Me.vsbExpense1.SmallChange = 10
        Me.vsbExpense1.TabIndex = 65
        '
        'vsbIncome3
        '
        Me.vsbIncome3.Location = New System.Drawing.Point(230, 116)
        Me.vsbIncome3.Maximum = 5000
        Me.vsbIncome3.Name = "vsbIncome3"
        Me.vsbIncome3.Size = New System.Drawing.Size(39, 26)
        Me.vsbIncome3.SmallChange = 10
        Me.vsbIncome3.TabIndex = 64
        '
        'vsbIncome2
        '
        Me.vsbIncome2.Location = New System.Drawing.Point(230, 80)
        Me.vsbIncome2.Maximum = 5000
        Me.vsbIncome2.Name = "vsbIncome2"
        Me.vsbIncome2.Size = New System.Drawing.Size(39, 26)
        Me.vsbIncome2.SmallChange = 10
        Me.vsbIncome2.TabIndex = 63
        '
        'cmbExpense2
        '
        Me.cmbExpense2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExpense2.FormattingEnabled = True
        Me.cmbExpense2.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Annually"})
        Me.cmbExpense2.Location = New System.Drawing.Point(272, 224)
        Me.cmbExpense2.Name = "cmbExpense2"
        Me.cmbExpense2.Size = New System.Drawing.Size(86, 26)
        Me.cmbExpense2.TabIndex = 62
        Me.cmbExpense2.Text = "Weekly"
        '
        'cmbExpense3
        '
        Me.cmbExpense3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExpense3.FormattingEnabled = True
        Me.cmbExpense3.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Annually"})
        Me.cmbExpense3.Location = New System.Drawing.Point(272, 260)
        Me.cmbExpense3.Name = "cmbExpense3"
        Me.cmbExpense3.Size = New System.Drawing.Size(86, 26)
        Me.cmbExpense3.TabIndex = 61
        Me.cmbExpense3.Text = "Weekly"
        '
        'cmbExpense1
        '
        Me.cmbExpense1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExpense1.FormattingEnabled = True
        Me.cmbExpense1.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Annually"})
        Me.cmbExpense1.Location = New System.Drawing.Point(272, 188)
        Me.cmbExpense1.Name = "cmbExpense1"
        Me.cmbExpense1.Size = New System.Drawing.Size(86, 26)
        Me.cmbExpense1.TabIndex = 60
        Me.cmbExpense1.Text = "Weekly"
        '
        'cmbIncome2
        '
        Me.cmbIncome2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIncome2.FormattingEnabled = True
        Me.cmbIncome2.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Annually"})
        Me.cmbIncome2.Location = New System.Drawing.Point(272, 80)
        Me.cmbIncome2.Name = "cmbIncome2"
        Me.cmbIncome2.Size = New System.Drawing.Size(86, 26)
        Me.cmbIncome2.TabIndex = 59
        Me.cmbIncome2.Text = "Weekly"
        '
        'cmbIncome3
        '
        Me.cmbIncome3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIncome3.FormattingEnabled = True
        Me.cmbIncome3.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Annually"})
        Me.cmbIncome3.Location = New System.Drawing.Point(272, 116)
        Me.cmbIncome3.Name = "cmbIncome3"
        Me.cmbIncome3.Size = New System.Drawing.Size(86, 26)
        Me.cmbIncome3.TabIndex = 58
        Me.cmbIncome3.Text = "Weekly"
        '
        'cmbIncome1
        '
        Me.cmbIncome1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIncome1.FormattingEnabled = True
        Me.cmbIncome1.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly", "Annually"})
        Me.cmbIncome1.Location = New System.Drawing.Point(272, 44)
        Me.cmbIncome1.Name = "cmbIncome1"
        Me.cmbIncome1.Size = New System.Drawing.Size(86, 26)
        Me.cmbIncome1.TabIndex = 57
        Me.cmbIncome1.Text = "Weekly"
        '
        'vsbIncome1
        '
        Me.vsbIncome1.Location = New System.Drawing.Point(230, 44)
        Me.vsbIncome1.Maximum = 5000
        Me.vsbIncome1.Name = "vsbIncome1"
        Me.vsbIncome1.Size = New System.Drawing.Size(39, 26)
        Me.vsbIncome1.SmallChange = 10
        Me.vsbIncome1.TabIndex = 56
        '
        'chbExpense2
        '
        Me.chbExpense2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chbExpense2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbExpense2.Location = New System.Drawing.Point(12, 224)
        Me.chbExpense2.Name = "chbExpense2"
        Me.chbExpense2.Size = New System.Drawing.Size(126, 26)
        Me.chbExpense2.TabIndex = 55
        Me.chbExpense2.Text = "Travel"
        Me.chbExpense2.UseVisualStyleBackColor = False
        '
        'chbExpense3
        '
        Me.chbExpense3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chbExpense3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbExpense3.Location = New System.Drawing.Point(12, 261)
        Me.chbExpense3.Name = "chbExpense3"
        Me.chbExpense3.Size = New System.Drawing.Size(126, 26)
        Me.chbExpense3.TabIndex = 54
        Me.chbExpense3.Text = "Other"
        Me.chbExpense3.UseVisualStyleBackColor = False
        '
        'chbExpense1
        '
        Me.chbExpense1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.chbExpense1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbExpense1.Location = New System.Drawing.Point(12, 188)
        Me.chbExpense1.Name = "chbExpense1"
        Me.chbExpense1.Size = New System.Drawing.Size(126, 26)
        Me.chbExpense1.TabIndex = 53
        Me.chbExpense1.Text = "School"
        Me.chbExpense1.UseVisualStyleBackColor = False
        '
        'chbIncome2
        '
        Me.chbIncome2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chbIncome2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbIncome2.Location = New System.Drawing.Point(12, 80)
        Me.chbIncome2.Name = "chbIncome2"
        Me.chbIncome2.Size = New System.Drawing.Size(126, 26)
        Me.chbIncome2.TabIndex = 52
        Me.chbIncome2.Text = "Job"
        Me.chbIncome2.UseVisualStyleBackColor = False
        '
        'chbIncome3
        '
        Me.chbIncome3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chbIncome3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbIncome3.Location = New System.Drawing.Point(12, 117)
        Me.chbIncome3.Name = "chbIncome3"
        Me.chbIncome3.Size = New System.Drawing.Size(126, 26)
        Me.chbIncome3.TabIndex = 51
        Me.chbIncome3.Text = "Other"
        Me.chbIncome3.UseVisualStyleBackColor = False
        '
        'chbIncome1
        '
        Me.chbIncome1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chbIncome1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbIncome1.Location = New System.Drawing.Point(12, 44)
        Me.chbIncome1.Name = "chbIncome1"
        Me.chbIncome1.Size = New System.Drawing.Size(126, 26)
        Me.chbIncome1.TabIndex = 50
        Me.chbIncome1.Text = "Allowance"
        Me.chbIncome1.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(217, 371)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(141, 33)
        Me.btnQuit.TabIndex = 49
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(12, 371)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(141, 33)
        Me.btnCalculate.TabIndex = 48
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblHeading4
        '
        Me.lblHeading4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblHeading4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading4.Location = New System.Drawing.Point(12, 336)
        Me.lblHeading4.Name = "lblHeading4"
        Me.lblHeading4.Size = New System.Drawing.Size(171, 26)
        Me.lblHeading4.TabIndex = 47
        Me.lblHeading4.Text = "Annual Saving:"
        Me.lblHeading4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnnual
        '
        Me.lblAnnual.BackColor = System.Drawing.Color.White
        Me.lblAnnual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnual.Location = New System.Drawing.Point(182, 336)
        Me.lblAnnual.Name = "lblAnnual"
        Me.lblAnnual.Size = New System.Drawing.Size(176, 26)
        Me.lblAnnual.TabIndex = 46
        Me.lblAnnual.Text = "$0.00"
        Me.lblAnnual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExpense2
        '
        Me.lblExpense2.BackColor = System.Drawing.Color.White
        Me.lblExpense2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpense2.Location = New System.Drawing.Point(144, 224)
        Me.lblExpense2.Name = "lblExpense2"
        Me.lblExpense2.Size = New System.Drawing.Size(83, 26)
        Me.lblExpense2.TabIndex = 45
        Me.lblExpense2.Text = "$0.00"
        Me.lblExpense2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExpense3
        '
        Me.lblExpense3.BackColor = System.Drawing.Color.White
        Me.lblExpense3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpense3.Location = New System.Drawing.Point(144, 260)
        Me.lblExpense3.Name = "lblExpense3"
        Me.lblExpense3.Size = New System.Drawing.Size(83, 26)
        Me.lblExpense3.TabIndex = 44
        Me.lblExpense3.Text = "$0.00"
        Me.lblExpense3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblExpense1
        '
        Me.lblExpense1.BackColor = System.Drawing.Color.White
        Me.lblExpense1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpense1.Location = New System.Drawing.Point(144, 188)
        Me.lblExpense1.Name = "lblExpense1"
        Me.lblExpense1.Size = New System.Drawing.Size(83, 26)
        Me.lblExpense1.TabIndex = 43
        Me.lblExpense1.Text = "$0.00"
        Me.lblExpense1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIncome2
        '
        Me.lblIncome2.BackColor = System.Drawing.Color.White
        Me.lblIncome2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncome2.Location = New System.Drawing.Point(144, 80)
        Me.lblIncome2.Name = "lblIncome2"
        Me.lblIncome2.Size = New System.Drawing.Size(83, 26)
        Me.lblIncome2.TabIndex = 42
        Me.lblIncome2.Text = "$0.00"
        Me.lblIncome2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIncome3
        '
        Me.lblIncome3.BackColor = System.Drawing.Color.White
        Me.lblIncome3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncome3.Location = New System.Drawing.Point(144, 116)
        Me.lblIncome3.Name = "lblIncome3"
        Me.lblIncome3.Size = New System.Drawing.Size(83, 26)
        Me.lblIncome3.TabIndex = 41
        Me.lblIncome3.Text = "$0.00"
        Me.lblIncome3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIncome1
        '
        Me.lblIncome1.BackColor = System.Drawing.Color.White
        Me.lblIncome1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncome1.Location = New System.Drawing.Point(144, 44)
        Me.lblIncome1.Name = "lblIncome1"
        Me.lblIncome1.Size = New System.Drawing.Size(83, 26)
        Me.lblIncome1.TabIndex = 40
        Me.lblIncome1.Text = "$0.00"
        Me.lblIncome1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHeading3
        '
        Me.lblHeading3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblHeading3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading3.Location = New System.Drawing.Point(12, 301)
        Me.lblHeading3.Name = "lblHeading3"
        Me.lblHeading3.Size = New System.Drawing.Size(346, 26)
        Me.lblHeading3.TabIndex = 39
        Me.lblHeading3.Text = "Summary"
        Me.lblHeading3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeading2
        '
        Me.lblHeading2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblHeading2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading2.Location = New System.Drawing.Point(12, 153)
        Me.lblHeading2.Name = "lblHeading2"
        Me.lblHeading2.Size = New System.Drawing.Size(346, 26)
        Me.lblHeading2.TabIndex = 38
        Me.lblHeading2.Text = "Expenses"
        Me.lblHeading2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeading1
        '
        Me.lblHeading1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHeading1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading1.Location = New System.Drawing.Point(12, 9)
        Me.lblHeading1.Name = "lblHeading1"
        Me.lblHeading1.Size = New System.Drawing.Size(346, 26)
        Me.lblHeading1.TabIndex = 37
        Me.lblHeading1.Text = "Income"
        Me.lblHeading1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmStudent_Budget_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(372, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.vsbExpense3)
        Me.Controls.Add(Me.vsbExpense2)
        Me.Controls.Add(Me.vsbExpense1)
        Me.Controls.Add(Me.vsbIncome3)
        Me.Controls.Add(Me.vsbIncome2)
        Me.Controls.Add(Me.cmbExpense2)
        Me.Controls.Add(Me.cmbExpense3)
        Me.Controls.Add(Me.cmbExpense1)
        Me.Controls.Add(Me.cmbIncome2)
        Me.Controls.Add(Me.cmbIncome3)
        Me.Controls.Add(Me.cmbIncome1)
        Me.Controls.Add(Me.vsbIncome1)
        Me.Controls.Add(Me.chbExpense2)
        Me.Controls.Add(Me.chbExpense3)
        Me.Controls.Add(Me.chbExpense1)
        Me.Controls.Add(Me.chbIncome2)
        Me.Controls.Add(Me.chbIncome3)
        Me.Controls.Add(Me.chbIncome1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblHeading4)
        Me.Controls.Add(Me.lblAnnual)
        Me.Controls.Add(Me.lblExpense2)
        Me.Controls.Add(Me.lblExpense3)
        Me.Controls.Add(Me.lblExpense1)
        Me.Controls.Add(Me.lblIncome2)
        Me.Controls.Add(Me.lblIncome3)
        Me.Controls.Add(Me.lblIncome1)
        Me.Controls.Add(Me.lblHeading3)
        Me.Controls.Add(Me.lblHeading2)
        Me.Controls.Add(Me.lblHeading1)
        Me.Name = "frmStudent_Budget_Calculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Budget Calculator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents vsbExpense3 As VScrollBar
    Friend WithEvents vsbExpense2 As VScrollBar
    Friend WithEvents vsbExpense1 As VScrollBar
    Friend WithEvents vsbIncome3 As VScrollBar
    Friend WithEvents vsbIncome2 As VScrollBar
    Friend WithEvents cmbExpense2 As ComboBox
    Friend WithEvents cmbExpense3 As ComboBox
    Friend WithEvents cmbExpense1 As ComboBox
    Friend WithEvents cmbIncome2 As ComboBox
    Friend WithEvents cmbIncome3 As ComboBox
    Friend WithEvents cmbIncome1 As ComboBox
    Friend WithEvents vsbIncome1 As VScrollBar
    Friend WithEvents chbExpense2 As CheckBox
    Friend WithEvents chbExpense3 As CheckBox
    Friend WithEvents chbExpense1 As CheckBox
    Friend WithEvents chbIncome2 As CheckBox
    Friend WithEvents chbIncome3 As CheckBox
    Friend WithEvents chbIncome1 As CheckBox
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblHeading4 As Label
    Friend WithEvents lblAnnual As Label
    Friend WithEvents lblExpense2 As Label
    Friend WithEvents lblExpense3 As Label
    Friend WithEvents lblExpense1 As Label
    Friend WithEvents lblIncome2 As Label
    Friend WithEvents lblIncome3 As Label
    Friend WithEvents lblIncome1 As Label
    Friend WithEvents lblHeading3 As Label
    Friend WithEvents lblHeading2 As Label
    Friend WithEvents lblHeading1 As Label
End Class
