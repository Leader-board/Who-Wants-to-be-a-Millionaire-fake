Option Strict Off
Option Explicit On
Friend Class frmSorry
    Inherits System.Windows.Forms.Form
    Private Declare Function CreateEllipticRgn Lib "gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer) As Integer
    Private Declare Function SetWindowRgn Lib "user32" (ByVal hWnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Integer) As Integer

    Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
        Dim soundname As Object
        'In this version, player is returned to the game instead of being kicked out
        'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        soundname = My.Application.Info.DirectoryPath & "/hasta.wav"
        'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        gbResults = PlaySound(soundname, 0, SND_ASYNC)
        numQleft = 15
        qnum = 0
        Millionaire.progTimer.Visible = False
        Millionaire.lblTimer.Visible = False
        Me.Close()
        MsgBox("The program will now close. Restart the program to continue!")
        Millionaire.Close()
    End Sub

    Private Sub frmSorry_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim lngReturn As Object
        Dim lngRegion As Object
        Dim lngFormHeight As Object
        Dim lngFormWidth As Object
        Label1.Text = "Sorry " + My.Settings.username
        'UPGRADE_WARNING: Couldn't resolve default property of object lngFormWidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lngFormWidth = (Me.Width)
        'UPGRADE_WARNING: Couldn't resolve default property of object lngFormHeight. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lngFormHeight = Me.Height
        'UPGRADE_WARNING: Couldn't resolve default property of object lngFormHeight. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object lngFormWidth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object lngRegion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lngRegion = CreateEllipticRgn(0, 0, lngFormWidth, lngFormHeight)
        'UPGRADE_WARNING: Couldn't resolve default property of object lngRegion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object lngReturn. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lngReturn = SetWindowRgn(Me.Handle.ToInt32, lngRegion, True)
        Timer1.Enabled = True
        Label2.Text = "You have answered the question incorrectly. The correct answer is "
        Label3.Text = correctans
        If numQleft > 10 Then
            Label4.Text = "You have collected a total of 0 points!"
        ElseIf numQleft > 5 Then
            Label4.Text = "You have collected a total of 16 points!"
            If (16 > My.Settings.highestscore) Then
                My.Settings.highestscore = 16
            End If
        Else
            Label4.Text = "You have collected a total of 512 points!"
            If (512 > My.Settings.highestscore) Then
                My.Settings.highestscore = 512
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        Dim soundname As Object 'timer is used to let form load before running this sync wave (which stops all other processes while it run.)
        soundname = ""
        'timer inverval is set to 1000ms (1 second) in the properties,
        ' and is enabled upon form load.  form loads, the 1 sec later, this runs
        ' soundname = App.Path + "/wronganswer.wav" not used anymore , it is a bug

        'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        gbResults = PlaySound(soundname, 0, SND_SYNC)

        'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        gbResults = PlaySound(soundname, 0, SND_ASYNC)

        Timer1.Enabled = False 'shut off time after this runs just once
    End Sub
End Class