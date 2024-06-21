Public Class ViewSubmissionsForm

    Private submissions As List(Of Submission)
    Private submissionIndex As Integer

    Public Sub New(submissions As List(Of Submission))
        InitializeComponent()

        If submissions Is Nothing OrElse submissions.Count = 0 Then
            MessageBox.Show("No submissions found.")
            Me.Close() ' Close the form if there are no submissions to display
            Return
        End If

        Me.submissions = submissions
        Me.submissionIndex = 0
        DisplaySubmission(submissions(submissionIndex))
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If submissions Is Nothing OrElse submissions.Count = 0 Then
            MessageBox.Show("No submissions found.")
            Return
        End If

        submissionIndex += 1
        If submissionIndex < submissions.Count Then
            DisplaySubmission(submissions(submissionIndex))
        Else
            submissionIndex -= 1
            MessageBox.Show("No more submissions")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If submissions Is Nothing OrElse submissions.Count = 0 Then
            MessageBox.Show("No submissions found.")
            Return
        End If

        submissionIndex -= 1
        If submissionIndex >= 0 Then
            DisplaySubmission(submissions(submissionIndex))
        Else
            submissionIndex += 1
            MessageBox.Show("No previous submissions")
        End If
    End Sub

    Private Sub DisplaySubmission(submission As Submission)
        lblName.Text = $"Name: {submission.Name}"
        lblEmail.Text = $"Email: {submission.Email}"
        lblPhone.Text = $"Phone: {submission.Phone}"
        lblGitHubLink.Text = $"GitHub Link: {submission.GitHubLink}"
        lblStopwatchTime.Text = $"Stopwatch Time: {submission.StopwatchTime}"
    End Sub

End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String
End Class
