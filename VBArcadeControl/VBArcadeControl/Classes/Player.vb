Public Class Player
    Private _playerNumber As Integer
    Private _green As Byte
    Private _red As Byte
    Private _blue As Byte

    Public Property playerNumber() As Integer
        Get
            Return _playerNumber
        End Get
        Set(ByVal value As Integer)
            _playerNumber = value
        End Set
    End Property

    Public Property green() As Byte
        Get
            Return _green
        End Get
        Set(ByVal value As Byte)
            _green = value
        End Set
    End Property

    Public Property red() As Byte
        Get
            Return _red
        End Get
        Set(ByVal value As Byte)
            _red = value
        End Set
    End Property

    Public Property blue() As Byte
        Get
            Return _blue
        End Get
        Set(ByVal value As Byte)
            _blue = value
        End Set
    End Property
End Class
