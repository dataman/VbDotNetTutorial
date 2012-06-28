Public Class Form1

    Public sOperation As String = ""
    Public dValue As Double

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles _
        Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, _
        Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button0.Click, _
        ButtonC.Click, ButtonMultiply.Click, ButtonDivide.Click, ButtonPlus.Click, _
        ButtonMinus.Click, ButtonEquals.Click
        Dim sButton As String = CType(sender, Button).Text
        If "X/+-=C".IndexOf(sButton) >= 0 Then : DoOperation(sButton) : Return : End If
        txtOutput.Text = Val(txtOutput.Text & sButton).ToString
    End Sub

    Private Sub DoOperation(NewOp As String)
        Dim i As Double = Val(txtOutput.Text)
        Select Case NewOp
            Case "C"
                dValue = 0
                sOperation = ""
            Case "="
                Select Case sOperation
                    Case "" : Return
                    Case "X" : dValue *= i
                    Case "/" : dValue /= i
                    Case "+" : dValue += i
                    Case "-" : dValue -= i
                End Select
                sOperation = ""
            Case Else
                dValue = i
                sOperation = NewOp
                txtOutput.Text = "0"
                Return
        End Select
        txtOutput.Text = dValue.ToString("0")
    End Sub

End Class
