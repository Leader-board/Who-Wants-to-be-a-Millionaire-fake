Public Class frmOptions
    Private Sub frmOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblProgramLaunchedCounter.Text = (My.Settings.programlaunchcounter)
        lblHighestScore.Text = My.Settings.highestscore
        lblNumberofLifelines.Text = My.Settings.lifelinecounter
        TextBox1.Text = My.Settings.username
        If Millionaire.timebankcheck = 1 Then
            Button2.Text = "On. Press to switch off"
        Else
            Button2.Text = "Off. Press to switch on"
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.username = TextBox1.Text
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Millionaire.timebankcheck = 0 Then
            Millionaire.timebankcheck = 1
            MsgBox("Banked time enabled. Q15 will have extended time")
            Button2.Text = "On. Press to switch off"
        Else
            Millionaire.timebankcheck = 0
            MsgBox("Banked time disabled. Q15 will have 75 seconds time")
            Button2.Text = "Off. Press to switch on"
        End If
    End Sub
End Class