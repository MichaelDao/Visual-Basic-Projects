<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSandwich_Shop
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnFinish = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTableCharge = New System.Windows.Forms.Label()
        Me.lblToppingCount = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblThisSandwich = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkTableCharge = New System.Windows.Forms.CheckBox()
        Me.chkCrab = New System.Windows.Forms.CheckBox()
        Me.chkHam = New System.Windows.Forms.CheckBox()
        Me.chkTuna = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.lstBread = New System.Windows.Forms.ListBox()
        Me.lstQuantity = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(254, 336)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(135, 29)
        Me.btnReset.TabIndex = 42
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnFinish
        '
        Me.btnFinish.Location = New System.Drawing.Point(254, 301)
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.Size = New System.Drawing.Size(135, 29)
        Me.btnFinish.TabIndex = 41
        Me.btnFinish.Text = "Finish Order"
        Me.btnFinish.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Table Charge"
        '
        'lblTableCharge
        '
        Me.lblTableCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTableCharge.Location = New System.Drawing.Point(131, 304)
        Me.lblTableCharge.Name = "lblTableCharge"
        Me.lblTableCharge.Size = New System.Drawing.Size(101, 22)
        Me.lblTableCharge.TabIndex = 39
        Me.lblTableCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblToppingCount
        '
        Me.lblToppingCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblToppingCount.Location = New System.Drawing.Point(198, 137)
        Me.lblToppingCount.Name = "lblToppingCount"
        Me.lblToppingCount.Size = New System.Drawing.Size(51, 22)
        Me.lblToppingCount.TabIndex = 38
        Me.lblToppingCount.Text = "0"
        Me.lblToppingCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(254, 202)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(135, 29)
        Me.btnCalculate.TabIndex = 37
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(131, 339)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(101, 22)
        Me.lblTotal.TabIndex = 36
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblThisSandwich
        '
        Me.lblThisSandwich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThisSandwich.Location = New System.Drawing.Point(131, 205)
        Me.lblThisSandwich.Name = "lblThisSandwich"
        Me.lblThisSandwich.Size = New System.Drawing.Size(101, 22)
        Me.lblThisSandwich.TabIndex = 35
        Me.lblThisSandwich.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "This Sandwich"
        '
        'chkTableCharge
        '
        Me.chkTableCharge.AutoSize = True
        Me.chkTableCharge.Location = New System.Drawing.Point(285, 49)
        Me.chkTableCharge.Name = "chkTableCharge"
        Me.chkTableCharge.Size = New System.Drawing.Size(74, 17)
        Me.chkTableCharge.TabIndex = 32
        Me.chkTableCharge.Text = "Eat Here?"
        Me.chkTableCharge.UseVisualStyleBackColor = True
        '
        'chkCrab
        '
        Me.chkCrab.AutoSize = True
        Me.chkCrab.Location = New System.Drawing.Point(198, 117)
        Me.chkCrab.Name = "chkCrab"
        Me.chkCrab.Size = New System.Drawing.Size(48, 17)
        Me.chkCrab.TabIndex = 31
        Me.chkCrab.Text = "Crab"
        Me.chkCrab.UseVisualStyleBackColor = True
        '
        'chkHam
        '
        Me.chkHam.AutoSize = True
        Me.chkHam.Location = New System.Drawing.Point(198, 94)
        Me.chkHam.Name = "chkHam"
        Me.chkHam.Size = New System.Drawing.Size(48, 17)
        Me.chkHam.TabIndex = 30
        Me.chkHam.Text = "Ham"
        Me.chkHam.UseVisualStyleBackColor = True
        '
        'chkTuna
        '
        Me.chkTuna.AutoSize = True
        Me.chkTuna.Location = New System.Drawing.Point(198, 71)
        Me.chkTuna.Name = "chkTuna"
        Me.chkTuna.Size = New System.Drawing.Size(51, 17)
        Me.chkTuna.TabIndex = 29
        Me.chkTuna.Text = "Tuna"
        Me.chkTuna.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(198, 48)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(62, 17)
        Me.chkCheese.TabIndex = 28
        Me.chkCheese.Text = "Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'lstBread
        '
        Me.lstBread.FormattingEnabled = True
        Me.lstBread.Location = New System.Drawing.Point(73, 51)
        Me.lstBread.Name = "lstBread"
        Me.lstBread.Size = New System.Drawing.Size(96, 69)
        Me.lstBread.TabIndex = 27
        '
        'lstQuantity
        '
        Me.lstQuantity.FormattingEnabled = True
        Me.lstQuantity.Location = New System.Drawing.Point(17, 49)
        Me.lstQuantity.Name = "lstQuantity"
        Me.lstQuantity.Size = New System.Drawing.Size(40, 134)
        Me.lstQuantity.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Table Charge ($1.50)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Toppings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Bread"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Quantity"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 371)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 29)
        Me.Button1.TabIndex = 43
        Me.Button1.Text = "Back to menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmSandwich_Shop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTableCharge)
        Me.Controls.Add(Me.lblToppingCount)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblThisSandwich)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkTableCharge)
        Me.Controls.Add(Me.chkCrab)
        Me.Controls.Add(Me.chkHam)
        Me.Controls.Add(Me.chkTuna)
        Me.Controls.Add(Me.chkCheese)
        Me.Controls.Add(Me.lstBread)
        Me.Controls.Add(Me.lstQuantity)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSandwich_Shop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sandwich Shop"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents btnFinish As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTableCharge As Label
    Friend WithEvents lblToppingCount As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblThisSandwich As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chkTableCharge As CheckBox
    Friend WithEvents chkCrab As CheckBox
    Friend WithEvents chkHam As CheckBox
    Friend WithEvents chkTuna As CheckBox
    Friend WithEvents chkCheese As CheckBox
    Friend WithEvents lstBread As ListBox
    Friend WithEvents lstQuantity As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
