<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRacing_Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRacing_Game))
        Me.lblHint = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHint
        '
        Me.lblHint.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblHint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHint.ForeColor = System.Drawing.Color.Blue
        Me.lblHint.Location = New System.Drawing.Point(29, 378)
        Me.lblHint.Name = "lblHint"
        Me.lblHint.Size = New System.Drawing.Size(575, 27)
        Me.lblHint.TabIndex = 13
        Me.lblHint.Text = "It is a difficult game"
        Me.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Red
        Me.btnQuit.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.Black
        Me.btnQuit.Location = New System.Drawing.Point(347, 408)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(139, 55)
        Me.btnQuit.TabIndex = 12
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Lime
        Me.btnStart.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(162, 408)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(139, 55)
        Me.btnStart.TabIndex = 11
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Red
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(621, 113)
        Me.lblTitle.TabIndex = 10
        Me.lblTitle.Text = "DRAGSTER 1"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblInfo.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Blue
        Me.lblInfo.Location = New System.Drawing.Point(12, 122)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(621, 283)
        Me.lblInfo.TabIndex = 9
        Me.lblInfo.Text = resources.GetString("lblInfo.Text")
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRacing_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblHint)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "frmRacing_Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Racing Game"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblHint As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInfo As Label
End Class
