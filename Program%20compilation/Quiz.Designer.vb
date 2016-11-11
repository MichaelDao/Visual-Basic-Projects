<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuiz))
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.grpQ5 = New System.Windows.Forms.GroupBox()
        Me.lblResult5 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnQ5 = New System.Windows.Forms.Button()
        Me.grpQ3 = New System.Windows.Forms.GroupBox()
        Me.picReward = New System.Windows.Forms.PictureBox()
        Me.lblResult3 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnQ3 = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.grpQ2 = New System.Windows.Forms.GroupBox()
        Me.lblResult2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnQ2 = New System.Windows.Forms.Button()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblOutOf = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpQ1 = New System.Windows.Forms.GroupBox()
        Me.lblResult1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQ1 = New System.Windows.Forms.Button()
        Me.grpQ4 = New System.Windows.Forms.GroupBox()
        Me.lblResult4 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnQ4 = New System.Windows.Forms.Button()
        Me.grpQ5.SuspendLayout()
        Me.grpQ3.SuspendLayout()
        CType(Me.picReward, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQ2.SuspendLayout()
        Me.grpQ1.SuspendLayout()
        Me.grpQ4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(25, 353)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(48, 32)
        Me.lblScore.TabIndex = 66
        Me.lblScore.Text = "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(129, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(240, 48)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Quick Quiz Questions by Paul Shannon"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimer
        '
        Me.lblTimer.Location = New System.Drawing.Point(385, 17)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(112, 32)
        Me.lblTimer.TabIndex = 72
        '
        'grpQ5
        '
        Me.grpQ5.Controls.Add(Me.lblResult5)
        Me.grpQ5.Controls.Add(Me.Label5)
        Me.grpQ5.Controls.Add(Me.btnQ5)
        Me.grpQ5.Location = New System.Drawing.Point(9, 289)
        Me.grpQ5.Name = "grpQ5"
        Me.grpQ5.Size = New System.Drawing.Size(480, 48)
        Me.grpQ5.TabIndex = 64
        Me.grpQ5.TabStop = False
        Me.grpQ5.Text = "Question 5"
        '
        'lblResult5
        '
        Me.lblResult5.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblResult5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult5.Location = New System.Drawing.Point(384, 16)
        Me.lblResult5.Name = "lblResult5"
        Me.lblResult5.Size = New System.Drawing.Size(88, 24)
        Me.lblResult5.TabIndex = 2
        Me.lblResult5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(72, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(304, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Which planet has the most number of human deaths?"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQ5
        '
        Me.btnQ5.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnQ5.Location = New System.Drawing.Point(8, 16)
        Me.btnQ5.Name = "btnQ5"
        Me.btnQ5.Size = New System.Drawing.Size(56, 24)
        Me.btnQ5.TabIndex = 0
        Me.btnQ5.Text = "Answer"
        Me.btnQ5.UseVisualStyleBackColor = False
        '
        'grpQ3
        '
        Me.grpQ3.Controls.Add(Me.picReward)
        Me.grpQ3.Controls.Add(Me.lblResult3)
        Me.grpQ3.Controls.Add(Me.Label3)
        Me.grpQ3.Controls.Add(Me.btnQ3)
        Me.grpQ3.Location = New System.Drawing.Point(9, 177)
        Me.grpQ3.Name = "grpQ3"
        Me.grpQ3.Size = New System.Drawing.Size(480, 48)
        Me.grpQ3.TabIndex = 62
        Me.grpQ3.TabStop = False
        Me.grpQ3.Text = "Question 3"
        '
        'picReward
        '
        Me.picReward.Image = CType(resources.GetObject("picReward.Image"), System.Drawing.Image)
        Me.picReward.Location = New System.Drawing.Point(281, -14)
        Me.picReward.Name = "picReward"
        Me.picReward.Size = New System.Drawing.Size(64, 64)
        Me.picReward.TabIndex = 57
        Me.picReward.TabStop = False
        '
        'lblResult3
        '
        Me.lblResult3.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblResult3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult3.Location = New System.Drawing.Point(384, 16)
        Me.lblResult3.Name = "lblResult3"
        Me.lblResult3.Size = New System.Drawing.Size(88, 24)
        Me.lblResult3.TabIndex = 2
        Me.lblResult3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(72, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Tag = "1"
        Me.Label3.Text = "What does RAM stand for?"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQ3
        '
        Me.btnQ3.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnQ3.Location = New System.Drawing.Point(8, 16)
        Me.btnQ3.Name = "btnQ3"
        Me.btnQ3.Size = New System.Drawing.Size(56, 24)
        Me.btnQ3.TabIndex = 0
        Me.btnQ3.Text = "Answer"
        Me.btnQ3.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Red
        Me.btnQuit.Location = New System.Drawing.Point(417, 401)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(72, 32)
        Me.btnQuit.TabIndex = 73
        Me.btnQuit.Text = "&Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'grpQ2
        '
        Me.grpQ2.Controls.Add(Me.lblResult2)
        Me.grpQ2.Controls.Add(Me.Label2)
        Me.grpQ2.Controls.Add(Me.btnQ2)
        Me.grpQ2.Location = New System.Drawing.Point(9, 121)
        Me.grpQ2.Name = "grpQ2"
        Me.grpQ2.Size = New System.Drawing.Size(480, 48)
        Me.grpQ2.TabIndex = 61
        Me.grpQ2.TabStop = False
        Me.grpQ2.Text = "Question 2"
        '
        'lblResult2
        '
        Me.lblResult2.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblResult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult2.Location = New System.Drawing.Point(384, 16)
        Me.lblResult2.Name = "lblResult2"
        Me.lblResult2.Size = New System.Drawing.Size(88, 24)
        Me.lblResult2.TabIndex = 2
        Me.lblResult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(72, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Can the Kiwi bird Fly? Yes or no."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQ2
        '
        Me.btnQ2.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnQ2.Location = New System.Drawing.Point(8, 16)
        Me.btnQ2.Name = "btnQ2"
        Me.btnQ2.Size = New System.Drawing.Size(56, 24)
        Me.btnQ2.TabIndex = 0
        Me.btnQ2.Text = "Answer"
        Me.btnQ2.UseVisualStyleBackColor = False
        '
        'lblPercent
        '
        Me.lblPercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(201, 353)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(96, 32)
        Me.lblPercent.TabIndex = 70
        Me.lblPercent.Text = "0.00%"
        Me.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRating
        '
        Me.lblRating.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRating.Location = New System.Drawing.Point(305, 353)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(184, 32)
        Me.lblRating.TabIndex = 71
        Me.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(177, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 32)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "="
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutOf
        '
        Me.lblOutOf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutOf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutOf.Location = New System.Drawing.Point(121, 353)
        Me.lblOutOf.Name = "lblOutOf"
        Me.lblOutOf.Size = New System.Drawing.Size(40, 32)
        Me.lblOutOf.TabIndex = 68
        Me.lblOutOf.Text = "0"
        Me.lblOutOf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(89, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(8, 32)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "/"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpQ1
        '
        Me.grpQ1.Controls.Add(Me.lblResult1)
        Me.grpQ1.Controls.Add(Me.Label1)
        Me.grpQ1.Controls.Add(Me.btnQ1)
        Me.grpQ1.Location = New System.Drawing.Point(9, 65)
        Me.grpQ1.Name = "grpQ1"
        Me.grpQ1.Size = New System.Drawing.Size(480, 48)
        Me.grpQ1.TabIndex = 60
        Me.grpQ1.TabStop = False
        Me.grpQ1.Text = "Question 1"
        '
        'lblResult1
        '
        Me.lblResult1.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblResult1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult1.Location = New System.Drawing.Point(384, 16)
        Me.lblResult1.Name = "lblResult1"
        Me.lblResult1.Size = New System.Drawing.Size(88, 24)
        Me.lblResult1.TabIndex = 2
        Me.lblResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(72, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Are Gorillas carnivores, omnivores, or herbivores ? "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQ1
        '
        Me.btnQ1.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnQ1.Location = New System.Drawing.Point(8, 16)
        Me.btnQ1.Name = "btnQ1"
        Me.btnQ1.Size = New System.Drawing.Size(56, 24)
        Me.btnQ1.TabIndex = 0
        Me.btnQ1.Text = "Answer"
        Me.btnQ1.UseVisualStyleBackColor = False
        '
        'grpQ4
        '
        Me.grpQ4.Controls.Add(Me.lblResult4)
        Me.grpQ4.Controls.Add(Me.Label4)
        Me.grpQ4.Controls.Add(Me.btnQ4)
        Me.grpQ4.Location = New System.Drawing.Point(9, 233)
        Me.grpQ4.Name = "grpQ4"
        Me.grpQ4.Size = New System.Drawing.Size(480, 48)
        Me.grpQ4.TabIndex = 63
        Me.grpQ4.TabStop = False
        Me.grpQ4.Text = "Question 4"
        '
        'lblResult4
        '
        Me.lblResult4.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblResult4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult4.Location = New System.Drawing.Point(384, 16)
        Me.lblResult4.Name = "lblResult4"
        Me.lblResult4.Size = New System.Drawing.Size(88, 24)
        Me.lblResult4.TabIndex = 2
        Me.lblResult4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(72, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(304, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Who was the first man in space?"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQ4
        '
        Me.btnQ4.BackColor = System.Drawing.Color.LemonChiffon
        Me.btnQ4.Location = New System.Drawing.Point(8, 16)
        Me.btnQ4.Name = "btnQ4"
        Me.btnQ4.Size = New System.Drawing.Size(56, 24)
        Me.btnQ4.TabIndex = 0
        Me.btnQ4.Text = "Answer"
        Me.btnQ4.UseVisualStyleBackColor = False
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 440)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.grpQ5)
        Me.Controls.Add(Me.grpQ3)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.grpQ2)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblOutOf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grpQ1)
        Me.Controls.Add(Me.grpQ4)
        Me.Name = "frmQuiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz"
        Me.grpQ5.ResumeLayout(False)
        Me.grpQ3.ResumeLayout(False)
        CType(Me.picReward, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQ2.ResumeLayout(False)
        Me.grpQ1.ResumeLayout(False)
        Me.grpQ4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblScore As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTimer As Label
    Friend WithEvents grpQ5 As GroupBox
    Friend WithEvents lblResult5 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnQ5 As Button
    Friend WithEvents grpQ3 As GroupBox
    Friend WithEvents picReward As PictureBox
    Friend WithEvents lblResult3 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnQ3 As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents grpQ2 As GroupBox
    Friend WithEvents lblResult2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnQ2 As Button
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblRating As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblOutOf As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents grpQ1 As GroupBox
    Friend WithEvents lblResult1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnQ1 As Button
    Friend WithEvents grpQ4 As GroupBox
    Friend WithEvents lblResult4 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnQ4 As Button
End Class
