<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDodge_The_Tomatoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDodge_The_Tomatoes))
        Me.pnlGame = New System.Windows.Forms.Panel()
        Me.picTomato5 = New System.Windows.Forms.PictureBox()
        Me.picDino = New System.Windows.Forms.PictureBox()
        Me.picTomato2 = New System.Windows.Forms.PictureBox()
        Me.picTomato4 = New System.Windows.Forms.PictureBox()
        Me.picTomato3 = New System.Windows.Forms.PictureBox()
        Me.picTomato1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlGame.SuspendLayout()
        CType(Me.picTomato5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTomato2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTomato4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTomato3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTomato1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlGame
        '
        Me.pnlGame.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlGame.Controls.Add(Me.picTomato5)
        Me.pnlGame.Controls.Add(Me.picDino)
        Me.pnlGame.Controls.Add(Me.picTomato2)
        Me.pnlGame.Controls.Add(Me.picTomato4)
        Me.pnlGame.Controls.Add(Me.picTomato3)
        Me.pnlGame.Controls.Add(Me.picTomato1)
        Me.pnlGame.Location = New System.Drawing.Point(12, 27)
        Me.pnlGame.Name = "pnlGame"
        Me.pnlGame.Size = New System.Drawing.Size(331, 246)
        Me.pnlGame.TabIndex = 6
        '
        'picTomato5
        '
        Me.picTomato5.Image = CType(resources.GetObject("picTomato5.Image"), System.Drawing.Image)
        Me.picTomato5.Location = New System.Drawing.Point(273, -33)
        Me.picTomato5.Name = "picTomato5"
        Me.picTomato5.Size = New System.Drawing.Size(37, 34)
        Me.picTomato5.TabIndex = 5
        Me.picTomato5.TabStop = False
        '
        'picDino
        '
        Me.picDino.Image = CType(resources.GetObject("picDino.Image"), System.Drawing.Image)
        Me.picDino.Location = New System.Drawing.Point(198, 200)
        Me.picDino.Name = "picDino"
        Me.picDino.Size = New System.Drawing.Size(37, 34)
        Me.picDino.TabIndex = 1
        Me.picDino.TabStop = False
        '
        'picTomato2
        '
        Me.picTomato2.Image = CType(resources.GetObject("picTomato2.Image"), System.Drawing.Image)
        Me.picTomato2.Location = New System.Drawing.Point(70, -33)
        Me.picTomato2.Name = "picTomato2"
        Me.picTomato2.Size = New System.Drawing.Size(37, 34)
        Me.picTomato2.TabIndex = 4
        Me.picTomato2.TabStop = False
        '
        'picTomato4
        '
        Me.picTomato4.Image = CType(resources.GetObject("picTomato4.Image"), System.Drawing.Image)
        Me.picTomato4.Location = New System.Drawing.Point(217, -33)
        Me.picTomato4.Name = "picTomato4"
        Me.picTomato4.Size = New System.Drawing.Size(37, 34)
        Me.picTomato4.TabIndex = 2
        Me.picTomato4.TabStop = False
        '
        'picTomato3
        '
        Me.picTomato3.Image = CType(resources.GetObject("picTomato3.Image"), System.Drawing.Image)
        Me.picTomato3.Location = New System.Drawing.Point(152, -33)
        Me.picTomato3.Name = "picTomato3"
        Me.picTomato3.Size = New System.Drawing.Size(37, 34)
        Me.picTomato3.TabIndex = 3
        Me.picTomato3.TabStop = False
        '
        'picTomato1
        '
        Me.picTomato1.Image = CType(resources.GetObject("picTomato1.Image"), System.Drawing.Image)
        Me.picTomato1.Location = New System.Drawing.Point(18, -33)
        Me.picTomato1.Name = "picTomato1"
        Me.picTomato1.Size = New System.Drawing.Size(37, 34)
        Me.picTomato1.TabIndex = 0
        Me.picTomato1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStart, Me.mnuQuit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(357, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuStart
        '
        Me.mnuStart.Name = "mnuStart"
        Me.mnuStart.Size = New System.Drawing.Size(43, 20)
        Me.mnuStart.Text = "&Start"
        '
        'mnuQuit
        '
        Me.mnuQuit.Name = "mnuQuit"
        Me.mnuQuit.Size = New System.Drawing.Size(42, 20)
        Me.mnuQuit.Text = "&Quit"
        '
        'lblScore
        '
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblScore.Location = New System.Drawing.Point(93, 276)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(53, 19)
        Me.lblScore.TabIndex = 11
        Me.lblScore.Text = "Score"
        '
        'lblLives
        '
        Me.lblLives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLives.Location = New System.Drawing.Point(274, 276)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(50, 19)
        Me.lblLives.TabIndex = 10
        Me.lblLives.Text = "Lives"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Lives"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Score"
        '
        'frmDodge_The_Tomatoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlGame)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDodge_The_Tomatoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dodge The Tomatoes"
        Me.pnlGame.ResumeLayout(False)
        CType(Me.picTomato5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTomato2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTomato4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTomato3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTomato1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlGame As Panel
    Friend WithEvents picTomato5 As PictureBox
    Friend WithEvents picDino As PictureBox
    Friend WithEvents picTomato2 As PictureBox
    Friend WithEvents picTomato4 As PictureBox
    Friend WithEvents picTomato3 As PictureBox
    Friend WithEvents picTomato1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuStart As ToolStripMenuItem
    Friend WithEvents mnuQuit As ToolStripMenuItem
    Friend WithEvents tmrGame As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents lblLives As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
