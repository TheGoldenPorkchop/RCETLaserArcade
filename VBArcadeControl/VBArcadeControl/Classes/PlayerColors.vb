Imports System.IO

Public Class PlayerColors

    Private _PlayerOneRed As Integer
    Private _PlayerOneGreen As Integer
    Private _PlayerOneBlue As Integer
    Private _PlayerTwoRed As Integer
    Private _PlayerTwoGreen As Integer
    Private _PlayerTwoBlue As Integer
    Private _PlayerThreeRed As Integer
    Private _PlayerThreeGreen As Integer
    Private _PlayerThreeBlue As Integer
    Private _PlayerFourRed As Integer
    Private _PlayerFourGreen As Integer
    Private _PlayerFourBlue As Integer

    Public Property PlayerOneRed() As Integer
        Get
            Return _PlayerOneRed
        End Get
        Set(ByVal value As Integer)
            _PlayerOneRed = value
            SaveNewColors()
        End Set
    End Property

    Public Property PlayerOneGreen() As Integer
        Get
            Return _PlayerOneGreen
        End Get
        Set(ByVal value As Integer)
            _PlayerOneGreen = value
            SaveNewColors()
        End Set
    End Property

    Public Property PlayerOneBlue() As Integer
        Get
            Return _PlayerOneBlue
        End Get
        Set(ByVal value As Integer)
            _PlayerOneBlue = value
            SaveNewColors()
        End Set
    End Property

    Public Property PlayerTwoRed() As Integer
        Get
            Return _PlayerTwoRed
        End Get
        Set(ByVal value As Integer)
            _PlayerTwoRed = value
            SaveNewColors()
        End Set
    End Property

    Public Property PlayerTwoGreen() As Integer
        Get
            Return _PlayerTwoGreen
        End Get
        Set(ByVal value As Integer)
            _PlayerTwoGreen = value
            SaveNewColors()
        End Set
    End Property

    Public Property PlayerTwoBlue() As Integer
        Get
            Return _PlayerTwoBlue
        End Get
        Set(ByVal value As Integer)
            _PlayerTwoBlue = value
            SaveNewColors()
        End Set
    End Property

    Public Property PlayerThreeRed() As Integer
        Get
            Return _PlayerThreeRed
        End Get
        Set(ByVal value As Integer)
            _PlayerThreeRed = value
            SaveNewColors()
        End Set
    End Property

    Public Property PlayerThreeGreen() As Integer
        Get
            Return _PlayerThreeGreen
        End Get
        Set(ByVal value As Integer)
            _PlayerThreeGreen = value
            SaveNewColors()
        End Set
    End Property

    Public Property PlayerThreeBlue() As Integer
        Get
            Return _PlayerThreeBlue
        End Get
        Set(ByVal value As Integer)
            _PlayerThreeBlue = value
            SaveNewColors()
        End Set
    End Property

    Public Property PlayerFourRed() As Integer
        Get
            Return _PlayerFourRed
        End Get
        Set(ByVal value As Integer)
            _PlayerFourRed = value
            SaveNewColors()
        End Set
    End Property

    Public Property PlayerFourGreen() As Integer
        Get
            Return _PlayerFourGreen
        End Get
        Set(ByVal value As Integer)
            _PlayerFourGreen = value
            SaveNewColors()
        End Set
    End Property

    Public Property PlayerFourBlue() As Integer
        Get
            Return _PlayerFourBlue
        End Get
        Set(ByVal value As Integer)
            _PlayerFourBlue = value
            SaveNewColors()
        End Set
    End Property

    Sub New()
        If File.Exists("LA_PlayerColors.txt") Then
            'file already exists, read existing file
            FileOpen(1, "LA_PlayerColors.txt", OpenMode.Input)
            Input(1, _PlayerOneRed)
            Input(1, _PlayerOneGreen)
            Input(1, _PlayerOneBlue)
            Input(1, _PlayerTwoRed)
            Input(1, _PlayerTwoGreen)
            Input(1, _PlayerTwoBlue)
            Input(1, _PlayerThreeRed)
            Input(1, _PlayerThreeGreen)
            Input(1, _PlayerThreeBlue)
            Input(1, _PlayerFourRed)
            Input(1, _PlayerFourGreen)
            Input(1, _PlayerFourBlue)
            FileClose(1)
        Else
            'file does not exist, create defaults
        End If
    End Sub

    Private Sub SaveNewColors()
        FileOpen(1, "LA_PlayerColors.txt", OpenMode.Output)
        Write(1, _PlayerOneRed)
        Write(1, _PlayerOneGreen)
        Write(1, _PlayerOneBlue)
        Write(1, _PlayerTwoRed)
        Write(1, _PlayerTwoGreen)
        Write(1, _PlayerTwoBlue)
        Write(1, _PlayerThreeRed)
        Write(1, _PlayerThreeGreen)
        Write(1, _PlayerThreeBlue)
        Write(1, _PlayerFourRed)
        Write(1, _PlayerFourGreen)
        Write(1, _PlayerFourBlue)
        FileClose(1)
    End Sub
End Class
