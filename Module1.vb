Option Strict Off
Option Explicit On
Module Module1
	Public TEAMNAME As String
	Public NumberIncorrect As Short
	Public answer As Short
	Public totNumGames As Short
	Public gamenumber As Short
	Public qunum As Short
	Public qnum As Short
	Public numQleft As Short
	Public gamename As String
	Public intcnt As Short
	Public correctans As String
	Public labelclicked As String
	Public opta As String 'set up for use with timer
	Public optb As String
	Public optc As String
	Public optd As String
	Public livePlay As Boolean
	Public FinalAnswerNum As Short
	Public Const MB_ICONASTERISK As Integer = &H40
	Public Const MB_ICONEXCLAMATION As Integer = &H30
	Public Const MB_ICONQUESTION As Integer = &H20
	Public Const MB_ICONHAND As Integer = &H10
	Declare Function MessageBeep Lib "user32" (ByVal wType As Integer) As Integer
	Public cnn As ADODB.Connection
	Public isBiblical As Boolean
	
	
	
	Public Function dbConnection() As Object
		
		cnn = New ADODB.Connection
		With cnn
			.Provider = "Microsoft.Jet.OLEDB.4.0"
			.ConnectionString = "User ID=Admin;password= ;" & " Data Source=" & My.Application.Info.DirectoryPath & "\millionaire.mdb;"
			.CursorLocation = ADODB.CursorLocationEnum.adUseClient
			.Open()
		End With
		
	End Function
End Module