Public Class Form1
    Dim mA As Single
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdAbweisend_Click(sender As Object, e As EventArgs) Handles cmdAbweisend.Click
        mA = 0
        Do While mA < 4
            mA = mA + 1
            MsgBox(mA)
        Loop

    End Sub

    Private Sub cmdNichtAbweisend_Click(sender As Object, e As EventArgs) Handles cmdNichtAbweisend.Click
        mA = 0
        Do
            mA = mA + 1
            MsgBox(mA)
        Loop Until mA > 3
        MsgBox(mA)
    End Sub
End Class
