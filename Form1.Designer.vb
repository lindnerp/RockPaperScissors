<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.rdoRock = New System.Windows.Forms.RadioButton()
        Me.rdoPaper = New System.Windows.Forms.RadioButton()
        Me.rdoScissors = New System.Windows.Forms.RadioButton()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHumanScore = New System.Windows.Forms.Label()
        Me.lblCompScore = New System.Windows.Forms.Label()
        Me.btnPlayIf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rdoRock
        '
        Me.rdoRock.AutoSize = True
        Me.rdoRock.Location = New System.Drawing.Point(12, 58)
        Me.rdoRock.Name = "rdoRock"
        Me.rdoRock.Size = New System.Drawing.Size(51, 17)
        Me.rdoRock.TabIndex = 0
        Me.rdoRock.TabStop = True
        Me.rdoRock.Text = "Rock"
        Me.rdoRock.UseVisualStyleBackColor = True
        '
        'rdoPaper
        '
        Me.rdoPaper.AutoSize = True
        Me.rdoPaper.Location = New System.Drawing.Point(12, 81)
        Me.rdoPaper.Name = "rdoPaper"
        Me.rdoPaper.Size = New System.Drawing.Size(53, 17)
        Me.rdoPaper.TabIndex = 1
        Me.rdoPaper.TabStop = True
        Me.rdoPaper.Text = "Paper"
        Me.rdoPaper.UseVisualStyleBackColor = True
        '
        'rdoScissors
        '
        Me.rdoScissors.AutoSize = True
        Me.rdoScissors.Location = New System.Drawing.Point(12, 104)
        Me.rdoScissors.Name = "rdoScissors"
        Me.rdoScissors.Size = New System.Drawing.Size(64, 17)
        Me.rdoScissors.TabIndex = 2
        Me.rdoScissors.TabStop = True
        Me.rdoScissors.Text = "Scissors"
        Me.rdoScissors.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(-1, 29)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(66, 13)
        Me.lblInstructions.TabIndex = 3
        Me.lblInstructions.Text = "Choose One"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(12, 127)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(149, 127)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 197)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Human Score"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Computer Score"
        '
        'lblHumanScore
        '
        Me.lblHumanScore.AutoSize = True
        Me.lblHumanScore.Location = New System.Drawing.Point(160, 226)
        Me.lblHumanScore.Name = "lblHumanScore"
        Me.lblHumanScore.Size = New System.Drawing.Size(13, 13)
        Me.lblHumanScore.TabIndex = 8
        Me.lblHumanScore.Text = "0"
        '
        'lblCompScore
        '
        Me.lblCompScore.AutoSize = True
        Me.lblCompScore.Location = New System.Drawing.Point(284, 226)
        Me.lblCompScore.Name = "lblCompScore"
        Me.lblCompScore.Size = New System.Drawing.Size(13, 13)
        Me.lblCompScore.TabIndex = 9
        Me.lblCompScore.Text = "0"
        '
        'btnPlayIf
        '
        Me.btnPlayIf.Location = New System.Drawing.Point(12, 156)
        Me.btnPlayIf.Name = "btnPlayIf"
        Me.btnPlayIf.Size = New System.Drawing.Size(75, 23)
        Me.btnPlayIf.TabIndex = 10
        Me.btnPlayIf.Text = "PlayIf"
        Me.btnPlayIf.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 358)
        Me.Controls.Add(Me.btnPlayIf)
        Me.Controls.Add(Me.lblCompScore)
        Me.Controls.Add(Me.lblHumanScore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.rdoScissors)
        Me.Controls.Add(Me.rdoPaper)
        Me.Controls.Add(Me.rdoRock)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdoRock As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPaper As System.Windows.Forms.RadioButton
    Friend WithEvents rdoScissors As System.Windows.Forms.RadioButton
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblHumanScore As System.Windows.Forms.Label
    Friend WithEvents lblCompScore As System.Windows.Forms.Label
    Friend WithEvents btnPlayIf As System.Windows.Forms.Button

End Class
