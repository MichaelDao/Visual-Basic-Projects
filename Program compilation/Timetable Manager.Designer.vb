<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimetable_Manager
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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtFriday = New System.Windows.Forms.TextBox()
        Me.txtThursday = New System.Windows.Forms.TextBox()
        Me.txtTuesday = New System.Windows.Forms.TextBox()
        Me.txtWednesday = New System.Windows.Forms.TextBox()
        Me.txtMonday = New System.Windows.Forms.TextBox()
        Me.lblFriday = New System.Windows.Forms.Label()
        Me.lblWednesday = New System.Windows.Forms.Label()
        Me.lblThursday = New System.Windows.Forms.Label()
        Me.lblMonday = New System.Windows.Forms.Label()
        Me.lblTuesday = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(676, 331)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(153, 30)
        Me.btnQuit.TabIndex = 25
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(178, 331)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(153, 30)
        Me.btnAbout.TabIndex = 24
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(12, 331)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(153, 30)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtFriday
        '
        Me.txtFriday.Location = New System.Drawing.Point(676, 45)
        Me.txtFriday.Multiline = True
        Me.txtFriday.Name = "txtFriday"
        Me.txtFriday.Size = New System.Drawing.Size(153, 278)
        Me.txtFriday.TabIndex = 22
        '
        'txtThursday
        '
        Me.txtThursday.Location = New System.Drawing.Point(510, 45)
        Me.txtThursday.Multiline = True
        Me.txtThursday.Name = "txtThursday"
        Me.txtThursday.Size = New System.Drawing.Size(153, 278)
        Me.txtThursday.TabIndex = 21
        '
        'txtTuesday
        '
        Me.txtTuesday.Location = New System.Drawing.Point(178, 45)
        Me.txtTuesday.Multiline = True
        Me.txtTuesday.Name = "txtTuesday"
        Me.txtTuesday.Size = New System.Drawing.Size(153, 278)
        Me.txtTuesday.TabIndex = 20
        '
        'txtWednesday
        '
        Me.txtWednesday.Location = New System.Drawing.Point(344, 45)
        Me.txtWednesday.Multiline = True
        Me.txtWednesday.Name = "txtWednesday"
        Me.txtWednesday.Size = New System.Drawing.Size(153, 278)
        Me.txtWednesday.TabIndex = 19
        '
        'txtMonday
        '
        Me.txtMonday.Location = New System.Drawing.Point(12, 45)
        Me.txtMonday.Multiline = True
        Me.txtMonday.Name = "txtMonday"
        Me.txtMonday.Size = New System.Drawing.Size(153, 278)
        Me.txtMonday.TabIndex = 18
        '
        'lblFriday
        '
        Me.lblFriday.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblFriday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFriday.Location = New System.Drawing.Point(676, 9)
        Me.lblFriday.Name = "lblFriday"
        Me.lblFriday.Size = New System.Drawing.Size(153, 33)
        Me.lblFriday.TabIndex = 17
        Me.lblFriday.Text = "Friday"
        Me.lblFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWednesday
        '
        Me.lblWednesday.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblWednesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWednesday.Location = New System.Drawing.Point(344, 9)
        Me.lblWednesday.Name = "lblWednesday"
        Me.lblWednesday.Size = New System.Drawing.Size(153, 33)
        Me.lblWednesday.TabIndex = 16
        Me.lblWednesday.Text = "Wednesday"
        Me.lblWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblThursday
        '
        Me.lblThursday.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblThursday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThursday.Location = New System.Drawing.Point(510, 9)
        Me.lblThursday.Name = "lblThursday"
        Me.lblThursday.Size = New System.Drawing.Size(153, 33)
        Me.lblThursday.TabIndex = 15
        Me.lblThursday.Text = "Thursday"
        Me.lblThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMonday
        '
        Me.lblMonday.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMonday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonday.Location = New System.Drawing.Point(12, 9)
        Me.lblMonday.Name = "lblMonday"
        Me.lblMonday.Size = New System.Drawing.Size(153, 33)
        Me.lblMonday.TabIndex = 14
        Me.lblMonday.Text = "Monday"
        Me.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTuesday
        '
        Me.lblTuesday.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTuesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTuesday.Location = New System.Drawing.Point(178, 9)
        Me.lblTuesday.Name = "lblTuesday"
        Me.lblTuesday.Size = New System.Drawing.Size(153, 33)
        Me.lblTuesday.TabIndex = 13
        Me.lblTuesday.Text = "Tuesday"
        Me.lblTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTimetable_Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(839, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtFriday)
        Me.Controls.Add(Me.txtThursday)
        Me.Controls.Add(Me.txtTuesday)
        Me.Controls.Add(Me.txtWednesday)
        Me.Controls.Add(Me.txtMonday)
        Me.Controls.Add(Me.lblFriday)
        Me.Controls.Add(Me.lblWednesday)
        Me.Controls.Add(Me.lblThursday)
        Me.Controls.Add(Me.lblMonday)
        Me.Controls.Add(Me.lblTuesday)
        Me.Name = "frmTimetable_Manager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timetable Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtFriday As TextBox
    Friend WithEvents txtThursday As TextBox
    Friend WithEvents txtTuesday As TextBox
    Friend WithEvents txtWednesday As TextBox
    Friend WithEvents txtMonday As TextBox
    Friend WithEvents lblFriday As Label
    Friend WithEvents lblWednesday As Label
    Friend WithEvents lblThursday As Label
    Friend WithEvents lblMonday As Label
    Friend WithEvents lblTuesday As Label
End Class
