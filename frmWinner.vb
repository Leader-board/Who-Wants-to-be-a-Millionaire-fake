Option Strict Off
Option Explicit On
Friend Class frmWinner
    Inherits System.Windows.Forms.Form
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        If (2 ^ (14 - numQleft) > My.Settings.highestscore) Then
            My.Settings.highestscore = 2 ^ (14 - numQleft)
        End If
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        Dim soundname As Object
        soundname = My.Application.Info.DirectoryPath & "/charge.wav"

        gbResults = PlaySound(soundname, 0, SND_SYNC)

        soundname = My.Application.Info.DirectoryPath & "/shrek_champion.wav"

        gbResults = PlaySound(soundname, 0, SND_SYNC)

        soundname = My.Application.Info.DirectoryPath & "/enjoyable_game.wav"

        gbResults = PlaySound(soundname, 0, SND_SYNC)

        soundname = My.Application.Info.DirectoryPath & "/CHEERS0V.wav"

        gbResults = PlaySound(soundname, 0, SND_ASYNC)
        Timer1.Enabled = False
    End Sub
End Class