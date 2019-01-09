Option Strict Off
Option Explicit On
Friend Class frmNumLeft
	Inherits System.Windows.Forms.Form
	Private Declare Function CreateEllipticRgn Lib "gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
	Private Declare Function SetWindowRgn Lib "user32" (ByVal hWnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Integer) As Integer
	
	
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Me.Close()
	End Sub

    Private Sub frmNumLeft_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Dim lngRegion As Integer
        Dim lngReturn As Integer
        Dim lngFormWidth As Integer
        Dim lngFormHeight As Integer

        lngFormWidth = VB6.PixelsToTwipsX(Me.Width) / VB6.TwipsPerPixelX
        lngFormHeight = VB6.PixelsToTwipsY(Me.Height) / VB6.TwipsPerPixelY
        lngRegion = CreateEllipticRgn(0, 0, lngFormWidth, lngFormHeight)
        lngReturn = SetWindowRgn(Me.Handle.ToInt32, lngRegion, True)

        If numQleft = 10 Then
            Label1.Text = "You are 1/3 way there to winning the game. You will get atleast 16 points!"

        End If
        If numQleft = 5 Then
            Label1.Text = "You are 2/3 way there to winning the game. You will get atleast 512 points!"
        End If

    End Sub
End Class