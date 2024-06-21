Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class CreateSubmissionForm

    Private stopwatch As New Stopwatch()
    Private stopwatchRunning As Boolean = False
    Private WithEvents timer As New Timer()

    Public Sub New()
        InitializeComponent()
        ' Initialize timer properties
        timer.Interval = 1000 ' 1 second intervals
        AddHandler timer.Tick, AddressOf Timer_Tick
    End Sub

    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        ' Toggle stopwatch
        If stopwatchRunning Then
            ' Pause the stopwatch
            stopwatch.Stop()
            timer.Stop()
            btnStartStop.Text = "Start"
        Else
            ' Start or resume the stopwatch
            stopwatch.Start()
            timer.Start()
            btnStartStop.Text = "Pause"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        ' Update stopwatch time label
        lblStopwatchTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validate input
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtPhone.Text
        Dim githubLink As String = txtGitHubLink.Text

        If String.IsNullOrEmpty(name) OrElse
           String.IsNullOrEmpty(email) OrElse
           String.IsNullOrEmpty(phone) OrElse
           String.IsNullOrEmpty(githubLink) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        ' Create submission object
        Dim newSubmission As New Submission() With {
            .Name = name,
            .Email = email,
            .Phone = phone,
            .GitHubLink = githubLink,
            .StopwatchTime = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        }

        ' Submit to backend asynchronously
        Dim isSuccess As Boolean = Await SubmitToBackendAsync(newSubmission)

        If isSuccess Then
            MessageBox.Show("Submission successful.")
            ' Clear form for next submission
            txtName.Text = ""
            txtEmail.Text = ""
            txtPhone.Text = ""
            txtGitHubLink.Text = ""
            btnStartStop.Text = "Start"
            stopwatch.Reset()
            lblStopwatchTime.Text = "00:00:00"
            stopwatchRunning = False
        Else
            MessageBox.Show("Failed to submit data to the backend.")
        End If
    End Sub

    Private Async Function SubmitToBackendAsync(submission As Submission) As Task(Of Boolean)
        Dim apiUrl As String = "http://localhost:3000/submit"

        Try
            Using client As New HttpClient()
                Dim jsonSubmission As String = JsonConvert.SerializeObject(submission)
                Dim content As New StringContent(jsonSubmission, System.Text.Encoding.UTF8, "application/json")
                Dim response = Await client.PostAsync(apiUrl, content)
                Return response.IsSuccessStatusCode
            End Using
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return False
        End Try
    End Function

    ' Submission class definition
    Public Class Submission
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("email")>
        Public Property Email As String
        <JsonProperty("phone")>
        Public Property Phone As String
        <JsonProperty("github_link")>
        Public Property GitHubLink As String
        <JsonProperty("stopwatch_time")>
        Public Property StopwatchTime As String
    End Class

End Class
