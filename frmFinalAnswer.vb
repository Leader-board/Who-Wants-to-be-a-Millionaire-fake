Option Strict Off
Option Explicit On
Friend Class frmFinalAnswer
	Inherits System.Windows.Forms.Form
	Private Declare Function CreateEllipticRgn Lib "gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
	Private Declare Function SetWindowRgn Lib "user32" (ByVal hWnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Integer) As Integer
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		FinalAnswerNum = 1
		Me.Close()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		FinalAnswerNum = 0
		Me.Close()
	End Sub
	
	Private Sub frmFinalAnswer_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim soundname As Object
		Dim lngReturn As Object
		Dim lngRegion As Object
		Dim lngFormHeight As Object
		Dim lngFormWidth As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object lngFormWidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lngFormWidth = VB6.PixelsToTwipsX(Me.Width) / VB6.TwipsPerPixelX
		'UPGRADE_WARNING: Couldn't resolve default property of object lngFormHeight. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lngFormHeight = VB6.PixelsToTwipsY(Me.Height) / VB6.TwipsPerPixelY
		'UPGRADE_WARNING: Couldn't resolve default property of object lngFormHeight. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object lngFormWidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object lngRegion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lngRegion = CreateEllipticRgn(0, 0, lngFormWidth, lngFormHeight)
		'UPGRADE_WARNING: Couldn't resolve default property of object lngRegion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object lngReturn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lngReturn = SetWindowRgn(Me.Handle.ToInt32, lngRegion, True)
		If correctans <> labelclicked And qnum < 7 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			soundname = My.Application.Info.DirectoryPath & "/rightdecision.wav"
			'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			gbResults = PlaySound(soundname, 0, SND_ASYNC)
		ElseIf correctans <> labelclicked And qnum = 11 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			soundname = My.Application.Info.DirectoryPath & "/rightdecision.wav"
			'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			gbResults = PlaySound(soundname, 0, SND_ASYNC)
		ElseIf qnum = 6 Or qnum = 10 Or qnum = 14 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			soundname = My.Application.Info.DirectoryPath & "/isthatyourfinalanswer.wav"
			'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			gbResults = PlaySound(soundname, 0, SND_ASYNC)
		ElseIf qnum = 8 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			soundname = My.Application.Info.DirectoryPath & "/quite_sure.wav"
			'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			gbResults = PlaySound(soundname, 0, SND_ASYNC)
		ElseIf qnum = 12 Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			soundname = My.Application.Info.DirectoryPath & "/doyoufeellucky.wav"
			'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			gbResults = PlaySound(soundname, 0, SND_ASYNC)
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			soundname = My.Application.Info.DirectoryPath & "/finalanswer.wav"
			'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			gbResults = PlaySound(soundname, 0, SND_ASYNC)
		End If
	End Sub
End Class