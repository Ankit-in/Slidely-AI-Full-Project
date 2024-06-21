<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGitHubLink = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHubLink = New TextBox()
        btnStartStop = New Button()
        btnSubmit = New Button()
        lblStopwatchLabel = New Label()
        lblStopwatchTime = New Label()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(31, 28)
        lblName.Name = "lblName"
        lblName.Size = New Size(42, 15)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(31, 60)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(39, 15)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(31, 92)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(44, 15)
        lblPhone.TabIndex = 2
        lblPhone.Text = "Phone:"
        ' 
        ' lblGitHubLink
        ' 
        lblGitHubLink.AutoSize = True
        lblGitHubLink.Location = New Point(31, 121)
        lblGitHubLink.Name = "lblGitHubLink"
        lblGitHubLink.Size = New Size(73, 15)
        lblGitHubLink.TabIndex = 3
        lblGitHubLink.Text = "GitHub Link:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(127, 25)
        txtName.Name = "txtName"
        txtName.Size = New Size(200, 23)
        txtName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(127, 57)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(200, 23)
        txtEmail.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(127, 89)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(200, 23)
        txtPhone.TabIndex = 6
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(127, 121)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(200, 23)
        txtGitHubLink.TabIndex = 7
        ' 
        ' btnStartStop
        ' 
        btnStartStop.Location = New Point(60, 183)
        btnStartStop.Name = "btnStartStop"
        btnStartStop.Size = New Size(100, 30)
        btnStartStop.TabIndex = 8
        btnStartStop.Text = "Start"
        btnStartStop.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(209, 183)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(100, 30)
        btnSubmit.TabIndex = 9
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' lblStopwatchLabel
        ' 
        lblStopwatchLabel.AutoSize = True
        lblStopwatchLabel.Location = New Point(31, 151)
        lblStopwatchLabel.Name = "lblStopwatchLabel"
        lblStopwatchLabel.Size = New Size(66, 15)
        lblStopwatchLabel.TabIndex = 10
        lblStopwatchLabel.Text = "Stopwatch:"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(127, 151)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(49, 15)
        lblStopwatchTime.TabIndex = 11
        lblStopwatchTime.Text = "00:00:00"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 250)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblStopwatchLabel)
        Controls.Add(btnSubmit)
        Controls.Add(btnStartStop)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGitHubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Name = "CreateSubmissionForm"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents btnStartStop As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblStopwatchLabel As Label
    Friend WithEvents lblStopwatchTime As Label
End Class
