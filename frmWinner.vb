Option Strict Off
Option Explicit On
Friend Class frmWinner
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Me.Close()
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Dim soundname As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "/charge.wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_SYNC)
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "/shrek_champion.wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_SYNC)
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "/enjoyable_game.wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_SYNC)
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "/CHEERS0V.wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_ASYNC)
		Timer1.Enabled = False
	End Sub
End Class