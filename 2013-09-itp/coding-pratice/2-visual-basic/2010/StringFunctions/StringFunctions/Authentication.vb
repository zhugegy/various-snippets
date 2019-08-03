Public Class Authentication
    '''<Summary> Check </Summary>
    ''' <returns> ture </returns>
    ''' <remarks> None </remarks>  
    Public Function isBlankString(ByVal check_string As String) As Boolean
        If check_string = "" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
