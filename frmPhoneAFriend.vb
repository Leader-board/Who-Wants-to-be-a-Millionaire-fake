Option Strict Off
Option Explicit On
Friend Class frmPhoneAFriend
	Inherits System.Windows.Forms.Form
	Public shapenum As Short
	Private Sub playSoundASYNC(ByRef soundFile As Object)
		Dim soundname As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object soundFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "\" + soundFile + ".wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_ASYNC)
	End Sub
	Private Sub playSoundSYNC(ByRef soundFile As Object)
		Dim soundname As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object soundFile. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "\" + soundFile + ".wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_SYNC)
	End Sub
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim soundname As Object
		Timer1.Enabled = False
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "/millionairpiano.wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_ASYNC)
		Millionaire.timTimer.Enabled = True
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
		Me.Close()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Dim soundname As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "/thinkmusic.wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_ASYNC)
		Timer1.Enabled = True
	End Sub
	
	Private Sub frmPhoneAFriend_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		shapenum = 30
		Millionaire.timTimer.Enabled = False
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		If Trim(Label1.Text) <> "0" Then
            shapenum = shapenum - 1
            Label1.Text = Label1.Text - 1
            phoneProg.Value = shapenum
        End If
		If CDbl(Label1.Text) = 0 Then
			Millionaire.timTimer.Enabled = True
			If numQleft > 12 Then
				Call playSoundASYNC("waitq1-3")
			ElseIf numQleft > 10 Then 
				Call playSoundASYNC("waitq4-5")
			ElseIf numQleft > 7 Then 
				Call playSoundASYNC("waitq6-8")
			ElseIf numQleft > 5 Or numQleft <= 5 Then 
				'for time being
				Call playSoundASYNC("waitq9-10")
			Else
				Call playSoundASYNC("waitq11-15")
			End If
			Me.Close()
		End If
	End Sub
End Class