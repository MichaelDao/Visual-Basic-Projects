<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuessing_Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuessing_Game))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbEven = New System.Windows.Forms.RadioButton()
        Me.rdbOdd = New System.Windows.Forms.RadioButton()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLose = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbEven)
        Me.GroupBox1.Controls.Add(Me.rdbOdd)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Odd or Even?"
        '
        'rdbEven
        '
        Me.rdbEven.AutoSize = True
        Me.rdbEven.Location = New System.Drawing.Point(28, 62)
        Me.rdbEven.Name = "rdbEven"
        Me.rdbEven.Size = New System.Drawing.Size(50, 17)
        Me.rdbEven.TabIndex = 1
        Me.rdbEven.TabStop = True
        Me.rdbEven.Text = "Even"
        Me.rdbEven.UseVisualStyleBackColor = True
        '
        'rdbOdd
        '
        Me.rdbOdd.AutoSize = True
        Me.rdbOdd.Location = New System.Drawing.Point(28, 29)
        Me.rdbOdd.Name = "rdbOdd"
        Me.rdbOdd.Size = New System.Drawing.Size(45, 17)
        Me.rdbOdd.TabIndex = 0
        Me.rdbOdd.TabStop = True
        Me.rdbOdd.Text = "Odd"
        Me.rdbOdd.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(191, 22)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(76, 20)
        Me.txtDisplay.TabIndex = 11
        '
        'btnHide
        '
        Me.btnHide.Location = New System.Drawing.Point(191, 54)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(76, 36)
        Me.btnHide.TabIndex = 10
        Me.btnHide.Text = "Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(12, 54)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(151, 36)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(12, 12)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(151, 36)
        Me.btnCompare.TabIndex = 8
        Me.btnCompare.Text = "Compare"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(37, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 86)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'lblLose
        '
        Me.lblLose.BackColor = System.Drawing.Color.Red
        Me.lblLose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLose.ForeColor = System.Drawing.Color.White
        Me.lblLose.Location = New System.Drawing.Point(166, 167)
        Me.lblLose.Name = "lblLose"
        Me.lblLose.Size = New System.Drawing.Size(124, 43)
        Me.lblLose.TabIndex = 14
        Me.lblLose.Text = "LOSE!"
        Me.lblLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblLose.Visible = False
        '
        'lblWin
        '
        Me.lblWin.BackColor = System.Drawing.Color.Lime
        Me.lblWin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.Location = New System.Drawing.Point(166, 113)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(124, 43)
        Me.lblWin.TabIndex = 13
        Me.lblWin.Text = "WIN!"
        Me.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWin.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(191, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 36)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmGuessing_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 354)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCompare)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblLose)
        Me.Controls.Add(Me.lblWin)
        Me.Name = "frmGuessing_Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guessing Game "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbEven As RadioButton
    Friend WithEvents rdbOdd As RadioButton
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnHide As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCompare As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLose As Label
    Friend WithEvents lblWin As Label
    Friend WithEvents Button1 As Button
End Class
