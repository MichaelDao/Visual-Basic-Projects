<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAnimation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnimation))
        Me.fraControlPanel = New System.Windows.Forms.GroupBox()
        Me.btnFly = New System.Windows.Forms.Button()
        Me.btnFlyManual = New System.Windows.Forms.Button()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.btnLarger = New System.Windows.Forms.Button()
        Me.btnSmaller = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.lblUp = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.pnlGame = New System.Windows.Forms.Panel()
        Me.picSpaceShip = New System.Windows.Forms.PictureBox()
        Me.tmrAuto = New System.Windows.Forms.Timer(Me.components)
        Me.fraControlPanel.SuspendLayout()
        Me.pnlGame.SuspendLayout()
        CType(Me.picSpaceShip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fraControlPanel
        '
        Me.fraControlPanel.Controls.Add(Me.btnFly)
        Me.fraControlPanel.Controls.Add(Me.btnFlyManual)
        Me.fraControlPanel.Controls.Add(Me.lblSize)
        Me.fraControlPanel.Controls.Add(Me.btnLarger)
        Me.fraControlPanel.Controls.Add(Me.btnSmaller)
        Me.fraControlPanel.Controls.Add(Me.btnReset)
        Me.fraControlPanel.Controls.Add(Me.btnDown)
        Me.fraControlPanel.Controls.Add(Me.btnUp)
        Me.fraControlPanel.Controls.Add(Me.lblUp)
        Me.fraControlPanel.Controls.Add(Me.lblLeft)
        Me.fraControlPanel.Controls.Add(Me.btnRight)
        Me.fraControlPanel.Controls.Add(Me.btnLeft)
        Me.fraControlPanel.Location = New System.Drawing.Point(452, 12)
        Me.fraControlPanel.Name = "fraControlPanel"
        Me.fraControlPanel.Size = New System.Drawing.Size(144, 320)
        Me.fraControlPanel.TabIndex = 8
        Me.fraControlPanel.TabStop = False
        Me.fraControlPanel.Text = "Control Panel"
        '
        'btnFly
        '
        Me.btnFly.Location = New System.Drawing.Point(32, 240)
        Me.btnFly.Name = "btnFly"
        Me.btnFly.Size = New System.Drawing.Size(88, 40)
        Me.btnFly.TabIndex = 11
        Me.btnFly.Text = "Fly &Automatically"
        '
        'btnFlyManual
        '
        Me.btnFlyManual.Location = New System.Drawing.Point(32, 216)
        Me.btnFlyManual.Name = "btnFlyManual"
        Me.btnFlyManual.Size = New System.Drawing.Size(88, 24)
        Me.btnFlyManual.TabIndex = 10
        Me.btnFlyManual.Text = "Fly &Manual"
        '
        'lblSize
        '
        Me.lblSize.Location = New System.Drawing.Point(32, 168)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(80, 24)
        Me.lblSize.TabIndex = 9
        Me.lblSize.Text = "Label1"
        Me.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLarger
        '
        Me.btnLarger.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLarger.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnLarger.Location = New System.Drawing.Point(112, 168)
        Me.btnLarger.Name = "btnLarger"
        Me.btnLarger.Size = New System.Drawing.Size(24, 42)
        Me.btnLarger.TabIndex = 8
        Me.btnLarger.Text = ">"
        '
        'btnSmaller
        '
        Me.btnSmaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSmaller.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnSmaller.Location = New System.Drawing.Point(8, 168)
        Me.btnSmaller.Name = "btnSmaller"
        Me.btnSmaller.Size = New System.Drawing.Size(24, 24)
        Me.btnSmaller.TabIndex = 7
        Me.btnSmaller.Text = "<"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(32, 286)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(88, 24)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Exit"
        '
        'btnDown
        '
        Me.btnDown.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnDown.Location = New System.Drawing.Point(56, 120)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(24, 24)
        Me.btnDown.TabIndex = 5
        Me.btnDown.Text = "v"
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnUp.Location = New System.Drawing.Point(56, 64)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(24, 24)
        Me.btnUp.TabIndex = 4
        Me.btnUp.Text = "^"
        '
        'lblUp
        '
        Me.lblUp.Location = New System.Drawing.Point(32, 96)
        Me.lblUp.Name = "lblUp"
        Me.lblUp.Size = New System.Drawing.Size(80, 24)
        Me.lblUp.TabIndex = 3
        Me.lblUp.Text = "Label1"
        Me.lblUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLeft
        '
        Me.lblLeft.Location = New System.Drawing.Point(32, 24)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(80, 24)
        Me.lblLeft.TabIndex = 2
        Me.lblLeft.Text = "Label1"
        Me.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnRight
        '
        Me.btnRight.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnRight.Location = New System.Drawing.Point(112, 24)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(24, 24)
        Me.btnRight.TabIndex = 1
        Me.btnRight.Text = ">"
        '
        'btnLeft
        '
        Me.btnLeft.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnLeft.Location = New System.Drawing.Point(8, 24)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(24, 24)
        Me.btnLeft.TabIndex = 0
        Me.btnLeft.Text = "<"
        '
        'pnlGame
        '
        Me.pnlGame.Controls.Add(Me.picSpaceShip)
        Me.pnlGame.Location = New System.Drawing.Point(12, 12)
        Me.pnlGame.Name = "pnlGame"
        Me.pnlGame.Size = New System.Drawing.Size(416, 472)
        Me.pnlGame.TabIndex = 9
        '
        'picSpaceShip
        '
        Me.picSpaceShip.Image = CType(resources.GetObject("picSpaceShip.Image"), System.Drawing.Image)
        Me.picSpaceShip.Location = New System.Drawing.Point(3, 3)
        Me.picSpaceShip.Name = "picSpaceShip"
        Me.picSpaceShip.Size = New System.Drawing.Size(32, 32)
        Me.picSpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSpaceShip.TabIndex = 0
        Me.picSpaceShip.TabStop = False
        '
        'tmrAuto
        '
        '
        'frmAnimation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 492)
        Me.ControlBox = False
        Me.Controls.Add(Me.fraControlPanel)
        Me.Controls.Add(Me.pnlGame)
        Me.Name = "frmAnimation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Animation"
        Me.fraControlPanel.ResumeLayout(False)
        Me.pnlGame.ResumeLayout(False)
        CType(Me.picSpaceShip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fraControlPanel As GroupBox
    Friend WithEvents btnFly As Button
    Friend WithEvents btnFlyManual As Button
    Friend WithEvents lblSize As Label
    Friend WithEvents btnLarger As Button
    Friend WithEvents btnSmaller As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents lblUp As Label
    Friend WithEvents lblLeft As Label
    Friend WithEvents btnRight As Button
    Friend WithEvents btnLeft As Button
    Friend WithEvents pnlGame As Panel
    Friend WithEvents picSpaceShip As PictureBox
    Friend WithEvents tmrAuto As Timer
End Class
