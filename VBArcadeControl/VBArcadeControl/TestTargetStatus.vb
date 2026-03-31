Imports System.IO.Ports
Imports System.Security.Cryptography

'Laser Arcade Project
'Angel Nava
'Spring 2026
Public Class TestTargetStatus
    Private WithEvents testCOM As UARTController
    Public Sub New(testTarget As UARTController)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        testCOM = testTarget
    End Sub

    Function ConvertToDecimal(value As String) As Decimal
        Dim result As Decimal

        If value = "" Then
            Return -2
        End If

        If DecimalRadioButton.Checked = True Then
            If IsNumeric(value) = True Then
                result = CDec(value)
            Else
                result = -1
            End If
        ElseIf HexRadioButton.Checked = True Then
            Dim hexVal As Integer
            Try
                hexVal = Convert.ToInt32(value, 16)
                result = hexVal
            Catch ex As Exception
                result = -3
            End Try
        ElseIf AsciiRadioButton.Checked = True Then
            Try
                result = Asc(value)
            Catch ex As Exception
                result = -4
            End Try
        Else
            result = CDec(value)
        End If

        Return result
    End Function

    Function DisplayNumber(number As String) As String
        Dim result As String
        Dim hexVal As String
        hexVal = Hex(number)

        If DecimalRadioButton.Checked = True Then
            result = number
        ElseIf HexRadioButton.Checked = True Then
            result = hexVal
        ElseIf AsciiRadioButton.Checked = True Then
            result = Chr(CDec(number))
        Else
            result = number
        End If

        Return result
    End Function


    '----------------------------------------------------------------------------------------------------
    Private Sub ReadButton_Click(sender As Object, e As EventArgs) Handles ReadButton.Click
        Dim writableAddress As Integer
        writableAddress = CInt(AddressTextBox.Text) * 2
        testCOM.SendI2CRead(CByte(writableAddress))
    End Sub

    Private Sub WriteButton_Click(sender As Object, e As EventArgs) Handles WriteButton.Click
        Dim writableAddress As Integer
        writableAddress = CInt(AddressTextBox.Text) * 2
        testCOM.SendI2CWrite(CByte(writableAddress), CByte(WriteTextBox.Text))
    End Sub

    Private Sub EnableButton_Click(sender As Object, e As EventArgs) Handles EnableButton.Click
        Dim writableAddress As Integer
        writableAddress = CInt(AddressTextBox.Text) * 2
        testCOM.SendI2CEnable(CByte(writableAddress))
    End Sub

    Private Sub DisableButton_Click(sender As Object, e As EventArgs) Handles DisableButton.Click
        Dim writableAddress As Integer
        writableAddress = CInt(AddressTextBox.Text) * 2
        testCOM.SendI2CDisable(CByte(writableAddress))
    End Sub
End Class