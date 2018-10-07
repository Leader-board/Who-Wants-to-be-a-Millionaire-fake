Option Strict Off
Option Explicit On
Friend Class frmCorrect
	Inherits System.Windows.Forms.Form
	Private Declare Function CreateEllipticRgn Lib "gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
	Private Declare Function SetWindowRgn Lib "user32" (ByVal hWnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Integer) As Integer
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Me.Close()
	End Sub
	
	Private Sub frmCorrect_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
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
		
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Dim soundname As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_SYNC)
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "/applauslong.wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_ASYNC)
		Timer1.Enabled = False
	End Sub
End Class