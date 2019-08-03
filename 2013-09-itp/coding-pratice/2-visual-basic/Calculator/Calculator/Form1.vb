Public Class divide
    Dim press As Boolean = False
    Dim yunsuan As Integer = 1
    Dim prestore As Double = 0
    Dim counter_equal As Boolean = False
    Dim store_equal As Double
    Dim bool As Boolean = False

    Sub numberpress(ByVal number As String)
        If press = True Then
            prestore = Val(Label1.Text)
            Label1.Text = ""
            press = False
            Label1.Text = Val(Label1.Text & number)
        Else
            Label1.Text = Val(Label1.Text & number)
        End If
        bool = False
    End Sub

    Sub jisuan()
        Select Case yunsuan
            Case 1
                Label1.Text = prestore + Val(Label1.Text)

            Case 2
                Label1.Text = prestore - Val(Label1.Text)

            Case 3
                Label1.Text = prestore * Val(Label1.Text)

            Case 4
                Label1.Text = prestore / Val(Label1.Text)

        End Select
        bool = True
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If press = True Then
            prestore = Val(Label1.Text)
            Label1.Text = ""
            press = False
            Label1.Text = Label1.Text & "0."
        Else
            If Label1.Text = "" Then
                Label1.Text = Label1.Text & "0."
            Else
                Label1.Text = Label1.Text & "."
            End If
        End If
        bool = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        numberpress("1")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        numberpress("2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        numberpress("3")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        numberpress("4")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        numberpress("5")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        numberpress("6")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        numberpress("7")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        numberpress("8")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        numberpress("9")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        numberpress("00")
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        numberpress("0")
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        counter_equal = False
        press = True
        If bool = False Then Call jisuan()
        yunsuan = 1
    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        counter_equal = False
        press = True
        If bool = False Then Call jisuan()
        yunsuan = 2
    End Sub

    Private Sub multiply_Click(sender As Object, e As EventArgs) Handles multiply.Click
        counter_equal = False
        press = True
        If bool = False Then Call jisuan()
        yunsuan = 3
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        counter_equal = False
        press = True
        If bool = False Then Call jisuan()
        yunsuan = 4
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        counter_equal = False
        Label1.Text = "0"
        prestore = 0
        yunsuan = 1
        press = False
        bool = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If press = True Then Exit Sub
        If counter_equal = False Then
            store_equal = Val(Label1.Text)
            jisuan()
            counter_equal = True
        Else
            Select Case yunsuan
                Case 1
                    Label1.Text = Label1.Text + store_equal
                Case 2
                    Label1.Text = Label1.Text - store_equal
                Case 3
                    Label1.Text = Label1.Text * store_equal
                Case 4
                    Label1.Text = Label1.Text / store_equal
            End Select
        End If


    End Sub
End Class
