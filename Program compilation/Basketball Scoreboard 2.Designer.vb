<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBasketball_Scoreboard_2
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
        Me.txtAwayTeamName = New System.Windows.Forms.TextBox()
        Me.txtHomeTeamName = New System.Windows.Forms.TextBox()
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.btnPauseGame = New System.Windows.Forms.Button()
        Me.txtAway3pt = New System.Windows.Forms.TextBox()
        Me.txtAway2pt = New System.Windows.Forms.TextBox()
        Me.txtAwayft = New System.Windows.Forms.TextBox()
        Me.txtHome3pt = New System.Windows.Forms.TextBox()
        Me.txtHome2pt = New System.Windows.Forms.TextBox()
        Me.txtHomeft = New System.Windows.Forms.TextBox()
        Me.lblAway3pt = New System.Windows.Forms.Label()
        Me.lblAway2pt = New System.Windows.Forms.Label()
        Me.lblAwayft = New System.Windows.Forms.Label()
        Me.lblHome3pt = New System.Windows.Forms.Label()
        Me.lblHome2pt = New System.Windows.Forms.Label()
        Me.lbHomelft = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tmrSetData = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtAwayTeamName
        '
        Me.txtAwayTeamName.Location = New System.Drawing.Point(494, 12)
        Me.txtAwayTeamName.Name = "txtAwayTeamName"
        Me.txtAwayTeamName.Size = New System.Drawing.Size(341, 20)
        Me.txtAwayTeamName.TabIndex = 40
        Me.txtAwayTeamName.Text = "Away Team "
        Me.txtAwayTeamName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHomeTeamName
        '
        Me.txtHomeTeamName.Location = New System.Drawing.Point(26, 12)
        Me.txtHomeTeamName.Name = "txtHomeTeamName"
        Me.txtHomeTeamName.Size = New System.Drawing.Size(341, 20)
        Me.txtHomeTeamName.TabIndex = 39
        Me.txtHomeTeamName.Text = "Home Team"
        Me.txtHomeTeamName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStartGame
        '
        Me.btnStartGame.Location = New System.Drawing.Point(389, 39)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(99, 54)
        Me.btnStartGame.TabIndex = 38
        Me.btnStartGame.Text = "Start Game Time"
        Me.btnStartGame.UseVisualStyleBackColor = True
        '
        'btnPauseGame
        '
        Me.btnPauseGame.Location = New System.Drawing.Point(389, 99)
        Me.btnPauseGame.Name = "btnPauseGame"
        Me.btnPauseGame.Size = New System.Drawing.Size(99, 54)
        Me.btnPauseGame.TabIndex = 37
        Me.btnPauseGame.Text = "Pause Game Time"
        Me.btnPauseGame.UseVisualStyleBackColor = True
        '
        'txtAway3pt
        '
        Me.txtAway3pt.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAway3pt.Location = New System.Drawing.Point(742, 141)
        Me.txtAway3pt.Name = "txtAway3pt"
        Me.txtAway3pt.Size = New System.Drawing.Size(100, 38)
        Me.txtAway3pt.TabIndex = 36
        Me.txtAway3pt.Text = "0"
        Me.txtAway3pt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAway2pt
        '
        Me.txtAway2pt.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAway2pt.Location = New System.Drawing.Point(619, 141)
        Me.txtAway2pt.Name = "txtAway2pt"
        Me.txtAway2pt.Size = New System.Drawing.Size(100, 38)
        Me.txtAway2pt.TabIndex = 35
        Me.txtAway2pt.Text = "0"
        Me.txtAway2pt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAwayft
        '
        Me.txtAwayft.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAwayft.Location = New System.Drawing.Point(494, 141)
        Me.txtAwayft.Name = "txtAwayft"
        Me.txtAwayft.Size = New System.Drawing.Size(100, 38)
        Me.txtAwayft.TabIndex = 34
        Me.txtAwayft.Text = "0"
        Me.txtAwayft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHome3pt
        '
        Me.txtHome3pt.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHome3pt.Location = New System.Drawing.Point(283, 141)
        Me.txtHome3pt.Name = "txtHome3pt"
        Me.txtHome3pt.Size = New System.Drawing.Size(100, 38)
        Me.txtHome3pt.TabIndex = 33
        Me.txtHome3pt.Text = "0"
        Me.txtHome3pt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHome2pt
        '
        Me.txtHome2pt.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHome2pt.Location = New System.Drawing.Point(146, 141)
        Me.txtHome2pt.Name = "txtHome2pt"
        Me.txtHome2pt.Size = New System.Drawing.Size(100, 38)
        Me.txtHome2pt.TabIndex = 32
        Me.txtHome2pt.Text = "0"
        Me.txtHome2pt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHomeft
        '
        Me.txtHomeft.Font = New System.Drawing.Font("OCR A Extended", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHomeft.Location = New System.Drawing.Point(9, 141)
        Me.txtHomeft.Name = "txtHomeft"
        Me.txtHomeft.Size = New System.Drawing.Size(100, 38)
        Me.txtHomeft.TabIndex = 31
        Me.txtHomeft.Text = "0"
        Me.txtHomeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblAway3pt
        '
        Me.lblAway3pt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAway3pt.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAway3pt.Location = New System.Drawing.Point(742, 78)
        Me.lblAway3pt.Name = "lblAway3pt"
        Me.lblAway3pt.Size = New System.Drawing.Size(100, 45)
        Me.lblAway3pt.TabIndex = 30
        Me.lblAway3pt.Text = "3pt"
        Me.lblAway3pt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAway2pt
        '
        Me.lblAway2pt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAway2pt.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAway2pt.Location = New System.Drawing.Point(619, 78)
        Me.lblAway2pt.Name = "lblAway2pt"
        Me.lblAway2pt.Size = New System.Drawing.Size(100, 45)
        Me.lblAway2pt.TabIndex = 29
        Me.lblAway2pt.Text = "2pt"
        Me.lblAway2pt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAwayft
        '
        Me.lblAwayft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAwayft.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayft.Location = New System.Drawing.Point(494, 78)
        Me.lblAwayft.Name = "lblAwayft"
        Me.lblAwayft.Size = New System.Drawing.Size(100, 45)
        Me.lblAwayft.TabIndex = 28
        Me.lblAwayft.Text = "Ft"
        Me.lblAwayft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHome3pt
        '
        Me.lblHome3pt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHome3pt.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome3pt.Location = New System.Drawing.Point(283, 78)
        Me.lblHome3pt.Name = "lblHome3pt"
        Me.lblHome3pt.Size = New System.Drawing.Size(100, 45)
        Me.lblHome3pt.TabIndex = 27
        Me.lblHome3pt.Text = "3pt"
        Me.lblHome3pt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHome2pt
        '
        Me.lblHome2pt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHome2pt.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome2pt.Location = New System.Drawing.Point(146, 78)
        Me.lblHome2pt.Name = "lblHome2pt"
        Me.lblHome2pt.Size = New System.Drawing.Size(100, 45)
        Me.lblHome2pt.TabIndex = 26
        Me.lblHome2pt.Text = "2pt"
        Me.lblHome2pt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbHomelft
        '
        Me.lbHomelft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbHomelft.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHomelft.Location = New System.Drawing.Point(9, 78)
        Me.lbHomelft.Name = "lbHomelft"
        Me.lbHomelft.Size = New System.Drawing.Size(100, 45)
        Me.lbHomelft.TabIndex = 25
        Me.lbHomelft.Text = "Ft"
        Me.lbHomelft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.Location = New System.Drawing.Point(389, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 54)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Return to menu"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmBasketball_Scoreboard_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 226)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAwayTeamName)
        Me.Controls.Add(Me.txtHomeTeamName)
        Me.Controls.Add(Me.btnStartGame)
        Me.Controls.Add(Me.btnPauseGame)
        Me.Controls.Add(Me.txtAway3pt)
        Me.Controls.Add(Me.txtAway2pt)
        Me.Controls.Add(Me.txtAwayft)
        Me.Controls.Add(Me.txtHome3pt)
        Me.Controls.Add(Me.txtHome2pt)
        Me.Controls.Add(Me.txtHomeft)
        Me.Controls.Add(Me.lblAway3pt)
        Me.Controls.Add(Me.lblAway2pt)
        Me.Controls.Add(Me.lblAwayft)
        Me.Controls.Add(Me.lblHome3pt)
        Me.Controls.Add(Me.lblHome2pt)
        Me.Controls.Add(Me.lbHomelft)
        Me.Name = "frmBasketball_Scoreboard_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basketball Scoreboard 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAwayTeamName As TextBox
    Friend WithEvents txtHomeTeamName As TextBox
    Friend WithEvents btnStartGame As Button
    Friend WithEvents btnPauseGame As Button
    Friend WithEvents txtAway3pt As TextBox
    Friend WithEvents txtAway2pt As TextBox
    Friend WithEvents txtAwayft As TextBox
    Friend WithEvents txtHome3pt As TextBox
    Friend WithEvents txtHome2pt As TextBox
    Friend WithEvents txtHomeft As TextBox
    Friend WithEvents lblAway3pt As Label
    Friend WithEvents lblAway2pt As Label
    Friend WithEvents lblAwayft As Label
    Friend WithEvents lblHome3pt As Label
    Friend WithEvents lblHome2pt As Label
    Friend WithEvents lbHomelft As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents tmrSetData As Timer
End Class
