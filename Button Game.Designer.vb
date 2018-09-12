<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmButton_Game
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
        Me.pnlGame = New System.Windows.Forms.Panel()
        Me.btnWin = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblScoreLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlGame.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGame
        '
        Me.pnlGame.BackColor = System.Drawing.Color.White
        Me.pnlGame.Controls.Add(Me.btnWin)
        Me.pnlGame.Location = New System.Drawing.Point(12, 12)
        Me.pnlGame.Name = "pnlGame"
        Me.pnlGame.Size = New System.Drawing.Size(955, 553)
        Me.pnlGame.TabIndex = 3
        '
        'btnWin
        '
        Me.btnWin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnWin.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnWin.Location = New System.Drawing.Point(402, 261)
        Me.btnWin.Name = "btnWin"
        Me.btnWin.Size = New System.Drawing.Size(71, 46)
        Me.btnWin.TabIndex = 3
        Me.btnWin.Text = "Win"
        Me.btnWin.UseVisualStyleBackColor = False
        '
        'lblScore
        '
        Me.lblScore.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblScore.Location = New System.Drawing.Point(122, 576)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(92, 42)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblScoreLabel
        '
        Me.lblScoreLabel.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreLabel.Location = New System.Drawing.Point(12, 575)
        Me.lblScoreLabel.Name = "lblScoreLabel"
        Me.lblScoreLabel.Size = New System.Drawing.Size(104, 43)
        Me.lblScoreLabel.TabIndex = 4
        Me.lblScoreLabel.Text = "Clicks:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(896, 571)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 46)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmButton_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(981, 620)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnlGame)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblScoreLabel)
        Me.Name = "frmButton_Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Button Game"
        Me.pnlGame.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlGame As Panel
    Friend WithEvents btnWin As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents lblScoreLabel As Label
    Friend WithEvents Button1 As Button
End Class
