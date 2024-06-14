Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up the progress bar
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Step = 1
        ProgressBar1.BackColor = Color.Blue

        ' Start the timer for slow animation
        Timer1.Interval = 1 ' Adjust the interval as needed (e.g., 100 milliseconds)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment the progress bar value
        ProgressBar1.PerformStep()

        ' Simulate some work (you can replace this with your actual process)
        Thread.Sleep(50) ' Adjust the delay for slower animation
    End Sub
End Class
