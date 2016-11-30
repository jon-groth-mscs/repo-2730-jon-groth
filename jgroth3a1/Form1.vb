Option Strict On
Option Explicit On
Option Infer Off
Public Class Form1
    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        lblEven.Text = "PreTest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop
    End Sub

    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click
        lblEven.Text = "PreTest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i = 22
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop
    End Sub

    Private Sub btnLoopWhile_Click(sender As Object, e As EventArgs) Handles btnLoopWhile.Click
        lblEven.Text = "PostTest Loop While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop While i <= 20
    End Sub

    Private Sub btnLoopUntil_Click(sender As Object, e As EventArgs) Handles btnLoopUntil.Click
        lblEven.Text = "PostTest Loop Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop Until i = 22
    End Sub

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        lblEven.Text = "PreTest For" & ControlChars.NewLine
        For i As Integer = 2 To 20 Step 2
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
        Next i
    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter a Number, " &
            ControlChars.NewLine &
            "Click Cancel or Leave Blank to End."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")


        ' *** Begin loop here: repeat as long as input is not empty
        Do While strNum <> String.Empty
            ' convert the input to a number
            Int32.TryParse(strNum, intNum)
            ' diplay the input in the text box
            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            ' update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' *** Update control variable
            strNum = InputBox(strPROMPT, strTITLE, "0")
            ' *** End loop here
        Loop


        lblCount.Text = intCount.ToString
        ' verify that the count is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles btnSumLoopUntil.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter a Number, " &
            ControlChars.NewLine &
            "Click Cancel or Leave Blank to End."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")


        ' *** Begin loop here: repeat as long as input is not empty
        Do
            ' convert the input to a number
            Int32.TryParse(strNum, intNum)
            ' diplay the input in the text box
            txtList.Text = txtList.Text &
                intNum.ToString & ControlChars.NewLine

            ' update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' *** Update control variable
            strNum = InputBox(strPROMPT, strTITLE, "0")
            ' *** End loop here
        Loop Until strNum = String.Empty


        lblCount.Text = intCount.ToString
        ' verify that the count is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' clear screen
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        ' calculates average
        Const strPROMPT As String =
            "Enter quantity of numbers"
        Const strTITLE As String = "Quantity"
        Dim strInputCount As String = InputBox("Enter quantity of numbers", "Quantity", "0")
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        ' get first sales amount
        strNum = strInputCount
        ' convert the input to a number
        Int32.TryParse(strNum, intNum)
        ' *** Begin loop here: repeat as long as input is not empty
        For i As Integer = 1 To intNum

            ' diplay the input in the text box
            txtList.Text = txtList.Text &
                intSum.ToString & ControlChars.NewLine

            ' update the counter and accumulator
            intCount = intCount + 1
            intSum = intSum + intNum

            ' *** Update control variable
            strNum = InputBox(strPROMPT & intCount.ToString, strTITLE)
            ' *** End loop here
        Next i


        lblCount.Text = intCount.ToString
        ' verify that the count is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub
End Class
