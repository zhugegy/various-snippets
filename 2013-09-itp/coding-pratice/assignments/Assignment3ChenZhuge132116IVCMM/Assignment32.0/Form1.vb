Public Class Form1
    'program1 varibles:
    Dim number_array() As Integer
    Dim enter_judgement As Boolean = False

    'program2 varibles:
    Dim question_number As Integer = 1
    Dim answer_status As Boolean = False
    Dim counter As Integer
    Const time_limit_seconds As Integer = 30
    Dim time_limit_boolean As Boolean = False

    'program1:
    Function serial(i As Integer) As String
        Select Case i Mod 10
            Case 1
                If i = 11 Then
                    Return "11th"
                Else
                    Return i & "st"
                End If
            Case 2
                If i = 12 Then
                    Return "12th"
                Else
                    Return i & "nd"
                End If
            Case 3
                If i = 13 Then
                    Return "13th"
                Else
                    Return i & "rd"
                End If
            Case Else
                Return Convert.ToString(i) & "th"
        End Select
    End Function

    Sub getnumber_toarray(ByRef array() As Integer)
        Dim number As Integer
        Dim i As Integer = 1
        Dim msg_receiver As Integer
        ReDim array(i)
        Do
            Do
                Try
                    number = InputBox("Please enter " & serial(i) & " number. To finish, just click OK-button or press ENTER key.") : Exit Do
                Catch ex As Exception
                    msg_receiver = MsgBox("Do you finish entering?", MsgBoxStyle.YesNo)
                    If msg_receiver = 6 Then Exit Sub
                End Try
            Loop
            array(i) = number
            i += 1
            enter_judgement = True
            ReDim Preserve array(i)
        Loop
    End Sub

    'Sub getnumber()
    '    Dim number As Integer
    '    Dim i As Integer = 1
    '    Dim msg_receiver As Integer
    '    ReDim number_array(i)
    '    Do
    '        Do
    '            Try
    '                number = InputBox("Please enter " & serial(i) & " number. To finish, just click OK-button or press ENTER key.") : Exit Do
    '            Catch ex As Exception
    '                msg_receiver = MsgBox("Do you finish entering?", MsgBoxStyle.YesNo)
    '                If msg_receiver = 6 Then Exit Sub
    '            End Try
    '        Loop
    '        number_array(i) = number
    '        i += 1
    '        enter_judgement = True
    '        ReDim Preserve number_array(i)
    '    Loop
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        enter_judgement = False
        Dim max As Integer
        Dim i_store As Integer = 1
        getnumber_toarray(number_array)
        If enter_judgement = False Then MsgBox("You didn't enter anything.") : Exit Sub
        max = number_array(1)
        For i = 1 To number_array.GetUpperBound(0) - 1
            If number_array(i) > max Then
                max = number_array(i)
                i_store = i
            End If
        Next
        MsgBox("The biggest number is " & max & ", which is the " & serial(i_store) & " of your entering.")
    End Sub

    ' program2:
    Sub anwser(ByVal right_year As Integer)
        Dim input, msg_receiver, error_counter As Integer
        Do
            Do
                Try
                    input = InputBox(question(question_number)) : Exit Do
                Catch ex As Exception
                    If time_limit_boolean = True Then MsgBox("Time has gone.") : Exit Sub
                    error_counter += 1
                    MsgBox("Not a numeric anser.")
                    If error_counter = 2 Then
                        msg_receiver = MsgBox("Do you want to quit?", MsgBoxStyle.YesNo)
                        If msg_receiver = 6 Then
                            Timer1.Stop()
                            Label2.Text = "0"
                            Exit Sub
                        Else
                            error_counter = 1
                        End If
                    End If
                End Try
            Loop
            If time_limit_boolean = True Then MsgBox("Time has gone.") : Exit Sub
            If right_year = input Then Exit Do
            If right_year < input Then
                MsgBox("Too big")
            Else
                MsgBox("Too small")
            End If
        Loop
        question_number += 1
        answer_status = True
    End Sub

    Function question(ByVal number As Integer) As String
        Select Case number
            Case 1
                Return "1st question, in which year was 26th Atlanta Olympic?"
            Case 2
                Return "Right anwser!2nd question, in which year was 27th Sydney Olympic? "
            Case 3
                Return "Right anwser!3rd question, in which year was 28th Athens Olympic?"
            Case 4
                Return "Right anwser!4th question, in which year was 29th Beijing Olympic?"
            Case 5
                Return "Right anwser!5th question, in which year was 30th London Olympic?" 'correct for 4th to 5th
            Case Else
                Return "error"
        End Select
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        counter = 0
        answer_status = True
        time_limit_boolean = False
        question_number = 1
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        If (time_limit_seconds - counter / 10) > 0 Then
            Label2.Text = Format((time_limit_seconds - counter / 10), "0.0")
        Else
            Timer1.Stop()
            Label2.Text = "Timeover"
            time_limit_boolean = True
        End If
        Do While answer_status = True
            answer_status = False
            Select Case question_number
                Case 1
                    anwser(1996)
                Case 2
                    anwser(2000)
                Case 3
                    anwser(2004)
                Case 4
                    anwser(2008)
                Case 5
                    anwser(2012)
                Case 6
                    Timer1.Stop()
                    MsgBox("Congratulations!")
            End Select
        Loop
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.GetCurrentProcess().CloseMainWindow()
    End Sub

End Class
