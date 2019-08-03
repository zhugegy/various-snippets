VERSION 5.00
Begin VB.Form Form1 
   AutoRedraw      =   -1  'True
   Caption         =   "Form1"
   ClientHeight    =   3090
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   4680
   LinkTopic       =   "Form1"
   ScaleHeight     =   3090
   ScaleWidth      =   4680
   StartUpPosition =   3  '´°¿ÚÈ±Ê¡
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
Dim n As Double
Dim m As Double
Dim n1 As Double
m = 1
n = 1
n1 = 1

While m < 10 ^ 100
m = 1
n = n1
While n > 0
m = m * n
n = n - 1
Wend
n1 = n1 + 1
Wend
Print n1
Print n1 - 1
End Sub
