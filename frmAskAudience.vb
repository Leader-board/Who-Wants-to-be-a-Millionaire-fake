Option Strict Off
Option Explicit On
Friend Class frmAskAudience
	Inherits System.Windows.Forms.Form
	
	Private Sub playSoundASYNC(ByRef soundFile As Object)
		Dim soundname As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object soundFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "\" + soundFile + ".wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_ASYNC)
	End Sub
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim soundname As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_ASYNC)
		Call playSoundASYNC("lightdown")
		If numQleft > 12 Then
			Call playSoundASYNC("waitq1-3")
		ElseIf numQleft > 10 Then 
			Call playSoundASYNC("waitq4-5")
		ElseIf numQleft > 7 Then 
			Call playSoundASYNC("waitq6-8")
		ElseIf numQleft > 5 Then 
			Call playSoundASYNC("waitq9-10")
		Else
			Call playSoundASYNC("waitq11-15")
		End If
		Millionaire.timTimer.Enabled = True
		Me.Close()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Dim soundname As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "/sound827.wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_ASYNC)
		
	End Sub
	
	Private Sub frmAskAudience_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim X As Object
		Millionaire.timTimer.Enabled = False
		For X = 0 To 3
		Next X
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Me.Height = VB6.TwipsToPixelsY(4860)
		Timer1.Enabled = False
	End Sub
End Class