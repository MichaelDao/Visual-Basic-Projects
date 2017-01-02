<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChallenge_The_Computer
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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.lblHoursName = New System.Windows.Forms.Label()
        Me.lblMinutesName = New System.Windows.Forms.Label()
        Me.lblSecondsName = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Red
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(247, 238)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(77, 57)
        Me.btnQuit.TabIndex = 25
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblSeconds
        '
        Me.lblSeconds.BackColor = System.Drawing.Color.White
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(243, 158)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(81, 32)
        Me.lblSeconds.TabIndex = 22
        Me.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinutes
        '
        Me.lblMinutes.BackColor = System.Drawing.Color.White
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.Location = New System.Drawing.Point(139, 158)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(81, 32)
        Me.lblMinutes.TabIndex = 21
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHours
        '
        Me.lblHours.BackColor = System.Drawing.Color.White
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(32, 158)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(81, 32)
        Me.lblHours.TabIndex = 20
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComment
        '
        Me.lblComment.BackColor = System.Drawing.Color.White
        Me.lblComment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComment.Location = New System.Drawing.Point(16, 53)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(327, 87)
        Me.lblComment.TabIndex = 19
        Me.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHoursName
        '
        Me.lblHoursName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursName.Location = New System.Drawing.Point(36, 203)
        Me.lblHoursName.Name = "lblHoursName"
        Me.lblHoursName.Size = New System.Drawing.Size(77, 32)
        Me.lblHoursName.TabIndex = 18
        Me.lblHoursName.Text = "Hours"
        Me.lblHoursName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinutesName
        '
        Me.lblMinutesName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutesName.Location = New System.Drawing.Point(139, 203)
        Me.lblMinutesName.Name = "lblMinutesName"
        Me.lblMinutesName.Size = New System.Drawing.Size(81, 32)
        Me.lblMinutesName.TabIndex = 17
        Me.lblMinutesName.Text = "Minutes"
        Me.lblMinutesName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSecondsName
        '
        Me.lblSecondsName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondsName.Location = New System.Drawing.Point(243, 203)
        Me.lblSecondsName.Name = "lblSecondsName"
        Me.lblSecondsName.Size = New System.Drawing.Size(81, 32)
        Me.lblSecondsName.TabIndex = 16
        Me.lblSecondsName.Text = "Seconds"
        Me.lblSecondsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(225, 10)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(118, 31)
        Me.txtNumber.TabIndex = 15
        '
        'lblInstruction
        '
        Me.lblInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.Location = New System.Drawing.Point(12, 9)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(191, 32)
        Me.lblInstruction.TabIndex = 14
        Me.lblInstruction.Text = "Enter your guess here"
        Me.lblInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Yellow
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(143, 238)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(77, 57)
        Me.btnStop.TabIndex = 24
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Lime
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(36, 238)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(77, 57)
        Me.btnStart.TabIndex = 23
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'frmChallenge_The_Computer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(358, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblComment)
        Me.Controls.Add(Me.lblHoursName)
        Me.Controls.Add(Me.lblMinutesName)
        Me.Controls.Add(Me.lblSecondsName)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "frmChallenge_The_Computer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Challenge The Computer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents lblHoursName As Label
    Friend WithEvents lblMinutesName As Label
    Friend WithEvents lblSecondsName As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblInstruction As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnStop As Button
    Friend WithEvents btnStart As Button
End Class
