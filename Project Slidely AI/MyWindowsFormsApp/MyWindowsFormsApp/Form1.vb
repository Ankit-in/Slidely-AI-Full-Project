Public Class Form1

    Private submissions As List(Of Submission)

    Public Sub New()
        InitializeComponent()
        ' Initialize submissions data (you need to populate this list with actual data)
        submissions = New List(Of Submission)()
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm(submissions)
        viewSubmissionsForm.ShowDialog()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim createSubmissionForm As New CreateSubmissionForm()
        createSubmissionForm.ShowDialog()
    End Sub

End Class
