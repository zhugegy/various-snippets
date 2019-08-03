Public Class changeproperty
    Dim width As Integer
    Public Property widethc() As Integer
        Get
            widethc = width
        End Get
        Set(value As Integer)
            width = value
        End Set
    End Property

End Class
