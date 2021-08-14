Option Strict Off
Option Explicit On
Friend Class Millionaire
    Inherits System.Windows.Forms.Form

    Public myValue As Short
    Public Image4clicked As Short
    Public Image11clicked As Short
    Public Image12clicked As Short
    Public Image13clicked As Short
    Public Image14clicked As Short
    Public gamenum As Short
    Public doubleoption As Short
    Public doubleflag As Short
    Public timebankcheck As Short
    Public timebanker As Short
    Dim SAPI
    Private Sub InternetLifeline()
        '
        Call playSoundASYNC("sound827")
        timTimer.Enabled = True
        frmInternetLifeline.Show()
        Image6.Visible = False 'hide this image

    End Sub
    Private Sub congrats()
        ' when the user has answered all questions
        Timer3.Enabled = True
        If numQleft = 10 Then
            Timer2.Enabled = True
            frmNumLeft.ShowDialog()
        End If
        If numQleft = 5 Then
            Timer2.Enabled = True
            frmNumLeft.ShowDialog()
        End If
        If numQleft = 0 Then
            frmWinner.ShowDialog()
            Picture1.Visible = False
            Picture2.Visible = False
        End If
    End Sub
    Public Sub questionsLeft()
        ' finding number of remaining questions
        Select Case qnum
            Case 1
                numQleft = 14
            Case 2
                numQleft = 13
            Case 3
                numQleft = 12
            Case 4
                numQleft = 11
            Case 5
                numQleft = 10
            Case 6
                numQleft = 9
            Case 7
                numQleft = 8
            Case 8
                numQleft = 7
            Case 9
                numQleft = 6
            Case 10
                numQleft = 5
            Case 11
                numQleft = 4
            Case 12
                numQleft = 3
            Case 13
                numQleft = 2
            Case 14
                numQleft = 1
            Case 15
                numQleft = 0
        End Select
    End Sub
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim cmd As Object
        Dim timebank As Integer
        qline1.Visible = True
        qline1.BringToFront()

        doubleoption = 0

        timebank = timebank + lblTimer.Text
        lblTimer.ForeColor = System.Drawing.ColorTranslator.FromOle(&H80000012)
        timTimer.Enabled = True
        progTimer.Visible = True
        lblTimer.Visible = True
        Image3.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\images\Scenery.jpg")

        isBiblical = False 'ignore this code except set biblical to false

        If doubleflag = 0 Then
            Image7.Visible = True
        Else
            Image7.Visible = False
        End If
        Label20.Visible = False
        Label21.Visible = False
        Dim curres As ADODB.Recordset
        Dim X As Short
        If qnum < 15 Then
            Frame4.Visible = False
            Image4clicked = 0
            Image4.Enabled = True
            Image5.Enabled = True
            Image6.Enabled = True
            Image7.Enabled = True

            'if I left the lifeline not showing when I started the new game, have to make
            ' the lifeline visible again...but also had to reset imageXclicked back to o
            If Image11clicked = 1 Then
                Image4.Visible = True
                Image11clicked = 0
            End If
            If Image12clicked = 1 Then
                Image5.Visible = True
                Image12clicked = 0
            End If
            If Image13clicked = 1 Then
                Image6.Visible = True
                Image13clicked = 0
            End If
            Image15.Visible = False 'redlifelines--hide it
            Image11.Visible = False
            Image12.Visible = False
            Image13.Visible = False
            Image14.Visible = False
            ' to set timebomb

            If numQleft > 10 Then
                lblTimer.Text = "45"
                progTimer.Maximum = CSng(lblTimer.Text)
            ElseIf numQleft > 5 Then
                lblTimer.Text = "60"
                progTimer.Maximum = CSng(lblTimer.Text)
            ElseIf numQleft > 1 Then
                lblTimer.Text = "75"
                progTimer.Maximum = CSng(lblTimer.Text)
            Else
                If timebankcheck = 0 Then
                    'default method
                    lblTimer.Text = "75"
                    progTimer.Maximum = CSng(lblTimer.Text)
                Else
                    ' if experimental timebank option is used
                    lblTimer.Text = "75" + timebank
                    progTimer.Maximum = CSng(lblTimer.Text)
                End If
            End If

            cmd = New ADODB.Command
            Call dbConnection() 'located in Module1

            cmd.ActiveConnection = cnn

            X = CShort(Trim(CStr(Text1.Text)))

            cmd.CommandText = "select * from " & "disciple where gamenum = " & X & " and questnum= " & qnum + 1

            curres = cmd.Execute()
            ' redundant, disabled
            Label5.Text = curres.Fields("question").Value
            SAPI = CreateObject("SAPI.spvoice")
            If Command6.Text = "Self Play" Then
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.Speak(Label5.Text)
            End If
            Label1.Text = curres.Fields("ans_a").Value
            If Command6.Text = "Self Play" Then
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.Speak(Label1.Text)
            End If
            Label2.Text = curres.Fields("ans_b").Value
            If Command6.Text = "Self Play" Then
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.Speak(Label2.Text)
            End If
            Label3.Text = curres.Fields("ans_c").Value
            If Command6.Text = "Self Play" Then
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.Speak(Label3.Text)
            End If
            Label4.Text = curres.Fields("ans_d").Value
            If Command6.Text = "Self Play" Then
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.Speak(Label4.Text)
            End If
            If curres.Fields("pictureID").Value = "-" Then
                ' load nothing
            Else
                Image3.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\qpx\" + curres.Fields("pictureID").Value)
            End If
            correctans = Trim(curres.Fields("correctans").Value)
            Command1.Visible = False
            Command1.Text = "Next Question"
            qnum = qnum + 1
            curres.Close()
            cnn.Close()
        Else
            Command1.Text = "Start"
            Command1.Visible = True
            qnum = 0
            Frame4.Visible = True
        End If
        btnQuit.Visible = True
        btnQuit.Enabled = True 'option to quit the game
        'after a game has started, the option to switch games should not be there.
        Command2.Enabled = False
        Command3.Enabled = False
        Command1.Enabled = False
        If numQleft = 0 Then 'that is, he got all 15 questions
            Call playSoundSYNC("cheers0v")
            Call playSoundASYNC("finalmusic")
            numQleft = 15
        ElseIf numQleft = 5 Or numQleft = 10 Then  '1/3 or 2/3rd way there
            Timer2.Enabled = True
        ElseIf numQleft = 15 Then
            Timer1.Enabled = True
        Else
            Timer2.Enabled = True
        End If
        ' this is for the Panel1 contents
        lblcurQNo.Text = 16 - numQleft
        lblQcorr.Text = 15 - numQleft
        progProgress.Value = (100 / 15) * lblQcorr.Text
        lblqprog.Text = CInt(progProgress.Value)
    End Sub

    Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        Try
            Dim cmd As Object
            Call getNumberOfGames()
            qnum = 0
            numQleft = 15
            '  If gamenum < totNumGames Then
            Text1.Text = CStr(CDbl(Text1.Text) + 1)
            gamenum = gamenum + 1
            Image15.Visible = True 'show redlifelines in bg for demonstrating lifelines
            Image10.Visible = True
            Image11.Visible = True
            Image12.Visible = True
            Image13.Visible = True
            Image14.Visible = True
            Dim curres As ADODB.Recordset
            cmd = New ADODB.Command
            Call dbConnection() 'located in Module1
            cmd.ActiveConnection = cnn
            Dim m As Short
            m = CShort(CStr(gamenum))
            cmd.CommandText = "select gametype from " & "disciple where gamenum = " & m
            cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
            cmd.CommandTimeout = 15
            curres = cmd.Execute()
            Text2.Text = curres.Fields("gametype").Value
            cnn.Close()
            Command1.Text = "Start"
            Command1.Visible = True
            Frame4.Visible = True
            Image4.Visible = True
            Image5.Visible = True
            Image6.Visible = True
            Image7.Visible = True
            Image4.Enabled = False
            Image5.Enabled = False
            Image6.Enabled = False
            Image7.Enabled = True
        Catch e As Exception
            ' the initial method to detect number of games wasn't working properly, so an exception is used as the hook
            MsgBox("Error detected: " + e.Message + " You might have reached the last available set.", MsgBoxStyle.Critical)
            Text1.Text = Text1.Text - 1
        End Try
    End Sub
    Private Sub getNumberOfGames()
        Dim X As Object
        Dim cmd As Object
        Dim curres As ADODB.Recordset
        cmd = New ADODB.Command
        Call dbConnection() 'located in Module1
        cmd.ActiveConnection = cnn
        cmd.CommandText = "select gamenum from disciple"
        cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
        cmd.CommandTimeout = 15
        curres = cmd.Execute()
        curres.MoveLast()
        X = curres.Fields("gamenum").Value
        totNumGames = X
        cnn.Close()
    End Sub
    Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
        Dim cmd As Object
        qnum = 0
        numQleft = 15
        Dim curres As ADODB.Recordset
        Dim m As Short
        If gamenum <> 1 Then
            Text1.Text = CStr(CDbl(Text1.Text) - 1)
            gamenum = gamenum - 1
            cmd = New ADODB.Command
            Call dbConnection() 'located in Module1
            cmd.ActiveConnection = cnn
            m = CShort(CStr(gamenum))
            cmd.CommandText = "select gametype from " & "disciple where gamenum = " & m
            cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
            cmd.CommandTimeout = 15
            curres = cmd.Execute()
            Text2.Text = curres.Fields("gametype").Value
            cnn.Close()
            Command1.Text = "Start"
            Command1.Visible = True
            Frame4.Visible = True
            Image4.Visible = True
            Image5.Visible = True
            Image6.Visible = True
            Image7.Visible = True
            Image4.Enabled = False
            Image5.Enabled = False
            Image6.Enabled = False
            Image7.Enabled = True
            Image15.Visible = True 'show redlifelines in bg for demonstrating lifelines
            Image10.Visible = True 'doubledip small icon
            Image11.Visible = True
            Image12.Visible = True
            Image13.Visible = True
            Image14.Visible = True
        Else
            MsgBox("You are in the first game")
        End If
    End Sub
    Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
        Call playSoundASYNC("start-end")
    End Sub

    Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
        If Command6.Text = "Live Play" Then
            livePlay = False
            Command6.Text = "Self Play"
        Else
            livePlay = True
            Command6.Text = "Live Play"
        End If
    End Sub

    Private Sub Millionaire_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        My.Settings.programlaunchcounter = My.Settings.programlaunchcounter + 1
        timebanker = 0
        timebankcheck = 0
        qnum = 0
        Image4clicked = 0
        numQleft = 15
        gamenum = 1
        gamenumber = 1 'global for ff form
        Frame4.Left = 7
        Frame4.Height = 230
        Frame4.Width = 961
        Frame4.Top = 504
        livePlay = True
        Image11clicked = 0
        Image12clicked = 0
        Image13clicked = 0
        Image14clicked = 0
        doubleflag = 0
        Call playSoundSYNC("war_games_play_a_game")
        Call playSoundASYNC("start-end")
        frmHelp.Show()
    End Sub
    Private Sub playSoundASYNC(ByRef soundFile As Object)
        Dim soundname As Object
        soundname = My.Application.Info.DirectoryPath & "\" + soundFile + ".wav"
        gbResults = PlaySound(soundname, 0, SND_ASYNC)
    End Sub
    Private Sub playSoundSYNC(ByRef soundFile As Object)
        Dim soundname As Object
        soundname = My.Application.Info.DirectoryPath & "\" + soundFile + ".wav"
        gbResults = PlaySound(soundname, 0, SND_SYNC)
    End Sub
    Private Sub Image11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image11.Click
        If Image11clicked = 0 Then
            Call playSoundASYNC("sound827")
            Image4.Visible = False
            Image11clicked = 1
        Else
            Image4.Visible = True
            Image11clicked = 0
        End If
    End Sub

    Private Sub Image12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image12.Click
        If Image12clicked = 0 Then
            Call playSoundASYNC("sound827")
            Image5.Visible = False
            Image12clicked = 1
        Else
            Image5.Visible = True
            Image12clicked = 0
        End If
    End Sub

    Private Sub Image13_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image13.Click
        If Image13clicked = 0 Then
            Call playSoundASYNC("sound827")
            Image6.Visible = False
            Image13clicked = 1
        Else
            Image6.Visible = True
            Image13clicked = 0
        End If
    End Sub

    Private Sub Image14_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image14.Click
        If Image14clicked = 0 Then
            Call playSoundASYNC("sound827")
            Image7.Visible = False
            Image14clicked = 1
        Else
            Image7.Visible = True
            Image14clicked = 0
        End If
    End Sub
    Private Sub Image4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image4.Click
        Dim myValue2 As Integer
        Dim z As Integer
        If Image4clicked = 0 Then
            Image4.Visible = False 'hide this image
            My.Settings.lifelinecounter = My.Settings.lifelinecounter + 1
            Call playSoundSYNC("sound827")
            'stop timer
            Select Case correctans
                Case "A"

                    z = 1
                Case "B"

                    z = 2
                Case "C"

                    z = 3
                Case "D"

                    z = 4
            End Select
            myValue = Int((4 * Rnd()) + 1)

            Do Until myValue <> z
                myValue = Int((4 * Rnd()) + 1)
            Loop

            myValue2 = Int((4 * Rnd()) + 1)


            Do Until myValue2 <> myValue And myValue2 <> z

                myValue2 = Int((4 * Rnd()) + 1)
            Loop
            ' continue the music immediately after the 50:50 music has played.
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
            Select Case myValue
                Case 1
                    Label1.Text = ""
                Case 2
                    Label2.Text = ""
                Case 3
                    Label3.Text = ""
                Case 4
                    Label4.Text = ""
            End Select
            Select Case myValue2
                Case 1
                    Label1.Text = ""
                Case 2
                    Label2.Text = ""
                Case 3
                    Label3.Text = ""
                Case 4
                    Label4.Text = ""
            End Select
        End If
        Image4clicked = 1
    End Sub

    Private Sub Image5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image5.Click
        Call playSoundASYNC("sound827")
        timTimer.Enabled = False
        My.Settings.lifelinecounter = My.Settings.lifelinecounter + 1
        frmPhoneAFriend.ShowDialog()
        Image5.Visible = False 'hide this image
    End Sub

    Private Sub Image6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image6.Click
        Call InternetLifeline()
    End Sub

    Private Sub Image7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image7.Click 'this is AskTheExperts-- now DoubeDip
        Call playSoundASYNC("ddipmus")
        doubleflag = 1
        My.Settings.lifelinecounter = My.Settings.lifelinecounter + 1
        Image7.Visible = False
        doubleoption = 1
        Image7.Visible = False
    End Sub
    Private Sub Label1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label1.Click
        Dim ans As Object
        ans = 0
        If Label1.Text <> "" Then
            labelclicked = "A"

            If ans <> 7 Then
                If correctans = labelclicked Then
                    Label1.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 200, 0))
                    Call playSoundASYNC("cormusic")
                    Call questionsLeft()

                    Call congrats()
                ElseIf doubleoption = 1 Then
                    If correctans = labelclicked Then
                        Label1.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 200, 0))
                        Call playSoundASYNC("cormusic")
                        Call questionsLeft()

                        Call congrats()
                    Else
                        timTimer.Enabled = True
                        Call playSoundASYNC("ddipinc")
                        Label1.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(88, 78, 78))
                        doubleoption = 0
                    End If
                Else
                    Call playSoundASYNC("wronganswer")
                    Label1.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(200, 0, 0))
                    frmSorry.ShowDialog() 'sorry-----end of game
                    Label1.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
                    isBiblical = True
                    qnum = 0
                    Image4clicked = 0
                    numQleft = 15
                    gamenum = 1
                    gamenumber = 1 'global for ff form
                    Frame4.Left = 7
                    Frame4.Height = 230
                    Frame4.Width = 961
                    Frame4.Top = 504
                    'Picture2.Height = 2420
                    'Picture2.Width = 4020
                    'Picture2.Top = 6360
                    'Picture2.Left = 10800
                    'Picture1.Height = 3072
                    'Picture1.Width = 10620
                    'Picture1.Left = 240
                    livePlay = True
                    Frame4.Visible = Enabled
                    Image11clicked = 0
                    Image12clicked = 0
                    Image13clicked = 0
                    Image14clicked = 0
                    Command1.Visible = True
                    Call playSoundASYNC("start-end")
                End If
            End If
        Else
            Label1.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
        End If
    End Sub
    Private Sub Label1_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = eventArgs.X
        Dim Y As Single = eventArgs.Y
        Label1.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 0))
        timTimer.Enabled = False
        If doubleoption = 1 Then
            Call playSoundASYNC("ddipchk")
        Else
            Call playSoundASYNC("finmusic")
        End If
    End Sub
    Private Sub btnQuit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim uQuit As Object
        Call playSoundASYNC("quit")

        uQuit = MsgBox("Do you really want to quit now.......?", MsgBoxStyle.YesNo, "Millionaire!")

        If uQuit = 6 Then
            MsgBox("You have collected a total of", MsgBoxStyle.Information, "You've quit!")
            MsgBox(2 ^ (14 - numQleft))
            MsgBox("points!")
            Me.Close()
        End If
    End Sub
    Private Sub Label2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label2.Click
        Dim ans As Integer
        If Label2.Text <> "" Then
            labelclicked = "B"

            If ans <> 7 Then
                If correctans = labelclicked Then
                    Label2.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 200, 0))
                    Call playSoundASYNC("cormusic")
                    Call questionsLeft()

                    Call congrats()
                ElseIf doubleoption = 1 Then
                    If correctans = labelclicked Then
                        Label1.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 200, 0))
                        Call playSoundASYNC("cormusic")
                        Call questionsLeft()

                        Call congrats()
                    Else
                        Call playSoundASYNC("ddipinc")
                        Label2.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(88, 78, 78))
                        timTimer.Enabled = True
                        doubleoption = 0
                    End If
                Else
                    Label2.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(200, 0, 0))
                    Call playSoundASYNC("wronganswer")
                    frmSorry.ShowDialog() 'sorry-----end of game
                    isBiblical = True
                    qnum = 0
                    Image4clicked = 0
                    numQleft = 15
                    gamenum = 1
                    gamenumber = 1 'global for ff form
                    Frame4.Left = 7
                    Frame4.Height = 230
                    Frame4.Width = 961
                    Frame4.Top = 504
                    'Picture2.Height = 2420
                    'Picture2.Width = 4020
                    'Picture2.Top = 6360
                    'Picture2.Left = 10800
                    'Picture1.Height = 3072
                    'Picture1.Width = 10620
                    'Picture1.Left = 240
                    livePlay = True
                    Image11clicked = 0
                    Image12clicked = 0
                    Image13clicked = 0
                    Image14clicked = 0
                    Call playSoundASYNC("start-end")
                    Frame4.Visible = Enabled
                    Command1.Visible = True
                    Label2.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
                End If
            Else
                Label2.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
            End If
        End If
    End Sub
    Private Sub Label2_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = eventArgs.X
        Dim Y As Single = eventArgs.Y
        timTimer.Enabled = False
        Label2.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 0))
        If doubleoption = 1 Then
            Call playSoundASYNC("ddipchk")
        Else
            Call playSoundASYNC("finmusic")
        End If
    End Sub
    Private Sub Label3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label3.Click
        Dim ans As Object
        ans = 0
        If Label3.Text <> "" Then
            labelclicked = "C"

            If ans <> 7 Then
                If correctans = labelclicked Then
                    Label3.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 200, 0))
                    Call playSoundASYNC("cormusic")
                    Call questionsLeft()

                    Call congrats()
                ElseIf doubleoption = 1 Then
                    If correctans = labelclicked Then
                        Label3.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 200, 0))
                        Call playSoundASYNC("cormusic")
                        Call questionsLeft()

                        Call congrats()
                    Else
                        timTimer.Enabled = True
                        Call playSoundASYNC("ddipinc")
                        Label3.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(88, 78, 78))
                        doubleoption = 0
                    End If
                Else
                    Call playSoundASYNC("wronganswer")
                    Label3.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(200, 0, 0))
                    frmSorry.ShowDialog() 'sorry-----end of game
                    Call playSoundASYNC("hasta")
                    isBiblical = True
                    qnum = 0
                    Image4clicked = 0
                    numQleft = 15
                    gamenum = 1
                    gamenumber = 1 'global for ff form
                    Frame4.Left = 7
                    Frame4.Height = 230
                    Frame4.Width = 961
                    Frame4.Top = 504
                    'Picture2.Height = 2420
                    'Picture2.Width = 4020
                    'Picture2.Top = 6360
                    'Picture2.Left = 10800
                    'Picture1.Height = 3072
                    'Picture1.Width = 10620
                    'Picture1.Left = 240
                    livePlay = True
                    Image11clicked = 0
                    Image12clicked = 0
                    Image13clicked = 0
                    Frame4.Visible = Enabled
                    Image14clicked = 0
                    Command1.Visible = True
                    Call playSoundASYNC("start-end")
                    Label3.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
                End If
            Else
                Label3.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
            End If
        End If
    End Sub

    Private Sub Label3_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = eventArgs.X
        Dim Y As Single = eventArgs.Y
        timTimer.Enabled = False
        Label3.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 0))
        If doubleoption = 1 Then
            Call playSoundASYNC("ddipchk")
        Else
            Call playSoundASYNC("finmusic")
        End If
    End Sub
    Private Sub Label4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label4.Click
        Dim ans As Object
        ans = 0
        If Label4.Text <> "" Then
            labelclicked = "D"

            If ans <> 7 Then
                If correctans = labelclicked Then
                    Label4.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 200, 0))
                    Call playSoundASYNC("cormusic")
                    Call questionsLeft()

                    Call congrats()
                ElseIf doubleoption = 1 Then
                    If correctans = labelclicked Then
                        Label4.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 200, 0))
                        Call playSoundASYNC("cormusic")
                        Call questionsLeft()

                        Call congrats()
                    Else
                        timTimer.Enabled = True
                        Call playSoundASYNC("ddipinc")
                        Label4.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(88, 78, 78))
                        doubleoption = 0
                    End If
                Else
                    Call playSoundASYNC("wronganswer")
                    Label4.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(200, 0, 0))
                    frmSorry.ShowDialog() 'sorry-----end of game
                    Label4.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
                    isBiblical = True
                    qnum = 0
                    Image4clicked = 0
                    numQleft = 15
                    gamenum = 1
                    gamenumber = 1 'global for ff form
                    Frame4.Left = 7
                    Frame4.Height = 230
                    Frame4.Width = 961
                    Frame4.Top = 504
                    'Picture2.Height = 2420
                    'Picture2.Width = 4020
                    'Picture2.Top = 6360
                    'Picture2.Left = 10800
                    'Picture1.Height = 3072
                    'Picture1.Width = 10620
                    'Picture1.Left = 240
                    livePlay = True
                    Image11clicked = 0
                    Image12clicked = 0
                    Image13clicked = 0
                    Image14clicked = 0
                    Frame4.Visible = Enabled
                    Command1.Visible = True
                    Call playSoundASYNC("start-end")
                End If
            Else
                Label4.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
            End If
        End If
    End Sub

    Private Sub Label4_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseDown
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = eventArgs.X
        Dim Y As Single = eventArgs.Y
        timTimer.Enabled = False
        Label4.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 0))
        If doubleoption = 1 Then
            Call playSoundASYNC("ddipchk")
        Else
            Call playSoundASYNC("finmusic")
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        Call playSoundSYNC("lets_play_millionaire")
        Call playSoundASYNC("waitq1-3")
        Timer1.Enabled = False
    End Sub
    Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
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
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer3.Tick
        Label1.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
        Label2.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
        Label3.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
        Label4.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(255, 255, 255))
        Call Command1_Click(Command1, New System.EventArgs())
        Timer3.Enabled = False
    End Sub

    Private Sub timTimer_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles timTimer.Tick
        lblTimer.Text = CStr(CDbl(lblTimer.Text) - 1)
        progTimer.Value = CSng(lblTimer.Text)
        If CDbl(lblTimer.Text) = 0 Then
            MsgBox("Time's up, sorry" + MsgBoxStyle.Exclamation)
            timTimer.Enabled = False
            If (numQleft < 15) Then
                MsgBox("You have correctly answered " + 15 - numQleft + "questions and have received " + 2 ^ (15 - numQleft) + " points")
            Else
                MsgBox("You have correctly answered " + 0 + "questions and have received " + 0 + " points")
            End If
            If (2 ^ (14 - numQleft) > My.Settings.highestscore) Then
                My.Settings.highestscore = 2 ^ (14 - numQleft)
            End If
            ' Repeat form loading proceedures
        ElseIf CDbl(lblTimer.Text) < 5 Then
            lblTimer.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
            progTimer.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
        End If
    End Sub
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmHelp.Show()
    End Sub
    Private Sub btnQuit_Click_1(sender As Object, e As EventArgs) Handles btnQuit.Click
        ' recopied from original btnQuit_Click due to VS having some problem recognising that one.
        If doubleoption = 1 Then
            MsgBox("You cannot quit the game when Double Dip has started. You must finish the question before quitting if you so wish.", MsgBoxStyle.Critical, "Can't quit!")
        Else
            Dim uQuit As Object
            Call playSoundASYNC("quit")

            uQuit = MsgBox("Do you really want to quit now.......?", MsgBoxStyle.YesNo, "Millionaire!")

            If uQuit = 6 Then
                MsgBox("You have collected a total of " + Str(2 ^ (14 - numQleft)) + " points!", MsgBoxStyle.Information, "You've quit!")
                If (2 ^ (14 - numQleft) > My.Settings.highestscore) Then
                    My.Settings.highestscore = 2 ^ (14 - numQleft)
                End If
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Image3_Click(sender As Object, e As EventArgs) Handles Image3.Click
        ' view statistics
        frmOptions.ShowDialog()
    End Sub


End Class