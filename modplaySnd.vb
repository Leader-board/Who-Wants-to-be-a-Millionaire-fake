Option Strict Off
Option Explicit On
Module modPlaySound
	
	
	Public Declare Function PlaySound Lib "winmm.dll"  Alias "PlaySoundA"(ByVal lpszName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer
	
	Public Const SND_ASYNC As Integer = &H1
	Public Const SND_LOOP As Integer = &H8
	Public Const SND_MEMORY As Integer = &H4
	Public Const SND_NODEFAULT As Integer = &H2
	Public Const SND_NOSTOP As Integer = &H10
	Public Const SND_SYNC As Integer = &H0
	Public Const SND_ALIAS As Integer = &H10000
	Public Const SND_APPLICATION As Integer = &H80
	Public Const SND_ALIAS_ID As Integer = &H110000
	Public Const SND_FILENAME As Integer = &H20000
	Public Const SND_NOWAIT As Integer = &H2000
	Public Const SND_PURGE As Integer = &H40
	Public Const SND_RESOURCE As Integer = &H40004
	
	Public gbResults As Boolean
End Module