Public Class frmInternetLifeline
    Private Sub frmInternetLifeline_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(urlString:="www.google.co.in")
        Millionaire.timTimer.Enabled = False
    End Sub
    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        If e.MaximumProgress <> 0 And e.MaximumProgress >= e.CurrentProgress Then
            ProgressBar1.Value = Convert.ToInt32(100 * e.CurrentProgress / e.MaximumProgress)
            Label3.Text = ProgressBar1.Value
        Else
            With ProgressBar1
                .Value = 100
                .Visible = True
            End With
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = Label5.Text - 1
        ProgressBar2.Value = Label5.Text
        TextBox1.Text = WebBrowser1.Document.Url.AbsoluteUri
        Me.Text = WebBrowser1.DocumentTitle
        If (Label5.Text = 0) Then
            Me.Close()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.GoBack()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.GoForward()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(urlString:=TextBox1.Text)
    End Sub

    Private Sub frmInternetLifeline_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Millionaire.timTimer.Enabled = True
    End Sub
End Class