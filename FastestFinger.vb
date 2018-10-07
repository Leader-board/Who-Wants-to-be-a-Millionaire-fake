Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FastestFinger
	Inherits System.Windows.Forms.Form
	Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Integer) As Short
	Public maxQuestions As Short
	
	
	Private Sub Command8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command8.Click
		List1.Visible = True
	End Sub
	
	Private Sub FastestFinger_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
		Dim KeyCode As Short = eventArgs.KeyCode
		Dim Shift As Short = eventArgs.KeyData \ &H10000
		'NOTICE....by setting the form's KeyPreview property to TRUE, can use this method
		' to capture all keystrokes
		' MsgBox KeyCode
		Select Case KeyCode
			Case 49 '1 Key
				Text11(1).BackColor = System.Drawing.Color.Lime
				List1.Items.Add(("Player 1"))
			Case 50 '2key
				Text11(2).BackColor = System.Drawing.Color.Lime
				List1.Items.Add(("Player 2"))
			Case 51 '3 key
				Text11(3).BackColor = System.Drawing.Color.Lime
				List1.Items.Add(("Player 3"))
			Case 52 '4 key
				Text11(4).BackColor = System.Drawing.Color.Lime
				List1.Items.Add(("Player 4"))
			Case 53 '5 key
				Text11(5).BackColor = System.Drawing.Color.Lime
				List1.Items.Add(("Player 5"))
			Case 54 '6 key
				Text11(6).BackColor = System.Drawing.Color.Lime
				List1.Items.Add(("Player 6"))
			Case 55 '7 key
				Text11(7).BackColor = System.Drawing.Color.Lime
				List1.Items.Add(("Player 7"))
		End Select
	End Sub
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim soundname As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "/feat.wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_ASYNC)
		List1.Items.Clear()
		Me.Close()
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Frame1.Visible = True
		
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Dim rs1 As Object
		Dim cmd As Object
		qunum = qunum + 1
		If qunum = maxQuestions + 1 Then
			MsgBox("There are only " & Str(qunum - 1) & " questions.")
			Exit Sub
		End If
		Timer1.Enabled = False
		Text10.Text = Str(qunum)
		Frame1.Visible = False
		Text2.Text = ""
		Text3.Text = ""
		Text4.Text = ""
		Text5.Text = ""
		
		
		Dim curres As ADODB.Recordset
		cmd = New ADODB.Command
		Call dbConnection() 'located in Module1
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.ActiveConnection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.ActiveConnection = cnn
		
		Dim X As Short
		qunum = Val(Trim(Text10.Text))
		If isBiblical = True Then
			X = 1 'this is for biblical
		Else
			X = 2 'this is for non-biblical
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.ActiveConnection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.ActiveConnection = cnn
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandText = "select * from " & "fastestfinger where gamenum = " & X & "and qnum= " & qunum
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandTimeout. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandTimeout = 15
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.Execute. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rs1 = cmd.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!question. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Label11.Text = Trim(rs1!question)
		cnn.Close()
		
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Dim soundname As Object
		Dim answerorder As Object
		Dim rs1 As Object
		Dim cmd As Object
		Text10.Text = Str(1)
		
		
		Dim curres As ADODB.Recordset
		cmd = New ADODB.Command
		Call dbConnection() 'located in Module1
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.ActiveConnection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.ActiveConnection = cnn
		
		Dim X As Short
		qunum = 1
		If isBiblical = True Then
			X = 1 'this is for biblical
		Else
			X = 2 'this is for non-biblical
		End If
		
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.ActiveConnection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.ActiveConnection = cnn
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandText = "select * from " & "fastestfinger where gamenum = " & X & "and qnum= " & qunum
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandTimeout. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandTimeout = 15
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.Execute. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rs1 = cmd.Execute()
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!question. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Label11.Text = Trim(rs1!question)
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!aoption1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text2.Text = Trim(rs1!aoption1)
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!aoption2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text3.Text = Trim(rs1!aoption2)
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!aoption3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text4.Text = Trim(rs1!aoption3)
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!aoption4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text5.Text = Trim(rs1!aoption4)
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!correctorder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object answerorder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		answerorder = Trim(rs1!correctorder)
		'UPGRADE_WARNING: Couldn't resolve default property of object answerorder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text1.Text = VB.Left(answerorder, 1) & "-" & Mid(answerorder, 2, 1) & "-" & Mid(answerorder, 3, 1) & "-" & Mid(answerorder, 4, 1)
		cnn.Close()
		Call orderanswers(answerorder)
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "/fastestfinger.wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_ASYNC)
		
	End Sub
	Private Sub orderanswers(ByRef answerorder As Object)
		Dim fourthanswer As Object
		Dim thirdanswer As Object
		Dim secondanswer As Object
		Dim firstanswer As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object answerorder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object firstanswer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		firstanswer = VB.Left(answerorder, 1)
		'UPGRADE_WARNING: Couldn't resolve default property of object answerorder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object secondanswer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		secondanswer = Mid(answerorder, 2, 1)
		'UPGRADE_WARNING: Couldn't resolve default property of object answerorder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object thirdanswer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		thirdanswer = Mid(answerorder, 3, 1)
		'UPGRADE_WARNING: Couldn't resolve default property of object answerorder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object fourthanswer. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fourthanswer = Mid(answerorder, 4, 1)
		
		Select Case firstanswer
			Case "A"
				Label6.Text = "A"
				Text6.Text = opta
			Case "B"
				Label6.Text = "B"
				Text6.Text = optb
			Case "C"
				Label6.Text = "C"
				Text6.Text = optc
			Case "D"
				Label6.Text = "D"
				Text6.Text = optd
		End Select
		Select Case secondanswer
			Case "A"
				Label7.Text = "A"
				Text7.Text = opta
			Case "B"
				Label7.Text = "B"
				Text7.Text = optb
			Case "C"
				Label7.Text = "C"
				Text7.Text = optc
			Case "D"
				Label7.Text = "D"
				Text7.Text = optd
		End Select
		Select Case thirdanswer
			Case "A"
				Label8.Text = "A"
				Text8.Text = opta
			Case "B"
				Label8.Text = "B"
				Text8.Text = optb
			Case "C"
				Label8.Text = "C"
				Text8.Text = optc
			Case "D"
				Label8.Text = "D"
				Text8.Text = optd
		End Select
		Select Case fourthanswer
			Case "A"
				Label9.Text = "A"
				Text9.Text = opta
			Case "B"
				Label9.Text = "B"
				Text9.Text = optb
			Case "C"
				Label9.Text = "C"
				Text9.Text = optc
			Case "D"
				Label9.Text = "D"
				Text9.Text = optd
		End Select
		'UPGRADE_WARNING: Couldn't resolve default property of object answerorder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text1.Text = VB.Left(answerorder, 1) & "-" & Mid(answerorder, 2, 1) & "-" & Mid(answerorder, 3, 1) & "-" & Mid(answerorder, 4, 1)
	End Sub
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		Dim answerorder As Object
		Dim rs1 As Object
		Dim cmd As Object
		qunum = qunum - 1
		If qunum < 1 Then
			MsgBox("You are at question # 1.")
			qunum = 1
			Exit Sub
		End If
		Timer1.Enabled = False
		Text10.Text = Str(qunum)
		Frame1.Visible = False
		Text2.Text = ""
		Text3.Text = ""
		Text4.Text = ""
		Text5.Text = ""
		
		
		Dim curres As ADODB.Recordset
		cmd = New ADODB.Command
		Call dbConnection() 'located in Module1
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.ActiveConnection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.ActiveConnection = cnn
		
		Dim X As Short
		qunum = Val(Trim(Text10.Text))
		If isBiblical = True Then
			X = 1 'this is for biblical
		Else
			X = 2 'this is for non-biblical
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.ActiveConnection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.ActiveConnection = cnn
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandText = "select * from " & "fastestfinger where gamenum = " & X & "and qnum= " & qunum
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandTimeout. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandTimeout = 15
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.Execute. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rs1 = cmd.Execute()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!question. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Label11.Text = Trim(rs1!question)
		'UPGRADE_WARNING: Couldn't resolve default property of object answerorder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Text1.Text = VB.Left(answerorder, 1) & "-" & Mid(answerorder, 2, 1) & "-" & Mid(answerorder, 3, 1) & "-" & Mid(answerorder, 4, 1)
		'
		cnn.Close()
		
	End Sub
	
	Private Sub Command6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command6.Click
		Frame1.Visible = False
		Frame2.Visible = False
		Command7.Visible = True
		
		
	End Sub
	
	Private Sub Command7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command7.Click
		Dim soundname As Object
		Dim answerorder As Object
		Dim rs1 As Object
		Dim cmd As Object 'start adding choices and play music
		
		Dim curres As ADODB.Recordset
		cmd = New ADODB.Command
		Call dbConnection() 'located in Module1
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.ActiveConnection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.ActiveConnection = cnn
		
		Dim X As Short
		qunum = Val(Trim(Text10.Text))
		If isBiblical = True Then
			X = 1 'this is for biblical
		Else
			X = 2 'this is for non-biblical
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.ActiveConnection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.ActiveConnection = cnn
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandText = "select * from " & "fastestfinger where gamenum = " & X & "and qnum= " & qunum
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandTimeout. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandTimeout = 15
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.Execute. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rs1 = cmd.Execute()
		Timer1.Enabled = True
		Timer1.Interval = 1000
		intcnt = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!aoption1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		opta = Trim(rs1!aoption1)
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!aoption2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		optb = Trim(rs1!aoption2)
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!aoption3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		optc = Trim(rs1!aoption3)
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!aoption4. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		optd = Trim(rs1!aoption4)
		Text2.Text = opta
		List1.Items.Clear()
		
		Call Timer1_Tick(Timer1, New System.EventArgs())
		'UPGRADE_WARNING: Couldn't resolve default property of object rs1!correctorder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object answerorder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		answerorder = Trim(rs1!correctorder)
		cnn.Close()
		Call orderanswers(answerorder)
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		soundname = My.Application.Info.DirectoryPath & "/fastestfingerwait.wav"
		'UPGRADE_WARNING: Couldn't resolve default property of object soundname. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		gbResults = PlaySound(soundname, 0, SND_ASYNC)
	End Sub
	
	
	Private Sub FastestFinger_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim cmd As Object
		Dim rs1 As ADODB.Recordset
		cmd = New ADODB.Command
		Call dbConnection() 'located in Module1
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.ActiveConnection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.ActiveConnection = cnn
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandText = "select * from fastestfinger"
		If isBiblical = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cmd.CommandText = cmd.CommandText + " where gamenum=1"
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cmd.CommandText = cmd.CommandText + " where gamenum=2"
		End If
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandType. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.CommandTimeout. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cmd.CommandTimeout = 15
		'UPGRADE_WARNING: Couldn't resolve default property of object cmd.Execute. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rs1 = cmd.Execute()
		maxQuestions = rs1.RecordCount
		
		'gNumber = gamenumber
		qunum = 0
		Frame2.Left = VB6.TwipsToPixelsX(60)
		Frame2.Top = VB6.TwipsToPixelsY(765)
		Frame2.Visible = True
		Me.KeyPreview = True
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		
		If intcnt = 2 Then
			Text3.Text = optb
			intcnt = 3
		ElseIf intcnt = 4 Then 
			Text4.Text = optc
			intcnt = 5
		ElseIf intcnt = 6 Then 
			Text5.Text = optd
			intcnt = 0
		Else
			intcnt = intcnt + 1
		End If
		
		
	End Sub
End Class