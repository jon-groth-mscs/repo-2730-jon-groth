Option Strict On
Option Explicit On
Option Infer Off

Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03: Insert
        Dim strWord As String = txt03RemoveInsert.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03RemoveInsert.Text = strWord

        '#04 Substring:
        Dim strItem As String = txt04Substring.Text
        Dim strColor As String
        strColor = strItem.Substring(2, 4)
        lbl04Substring.Text = strColor

        '#05a Length:
        Dim strMsg As String = txt05aLength.Text
        Dim intNumChars As Integer
        intNumChars = txt05aLength.Text.Length
        lbl05aLength.Text = intNumChars.ToString

        '#05b Trim:
        Dim strState As String = txt05bTrim.Text
        strState = txt05bTrim.Text.Trim
        lbl05bTrim.Text = strState

        '#05c Remove/Insert:
        Dim strWord1 As String = txt05cRemoveInsert.Text
        strWord1 = strWord1.Remove(1, 1)
        strWord1 = strWord1.Insert(1, "rit")
        lbl05cRemoveInsert.Text = strWord1

        '#05d Insert
        Dim strWord2 As String = txt05dInsert.Text
        strWord2 = strWord2.Insert(0, "Mon")
        lbl05dInsert.Text = strWord2

        '#05e Pad:
        Dim decPay As Decimal
        Dim strPay As String
        Decimal.TryParse(txt05ePad.Text, decPay)
        strPay = decPay.ToString("n2")
        strPay = strPay.PadLeft(10, "*"c)
        lbl05ePad.Text = strPay

        '#06 Remove:
        Dim strAmount As String = txt06Remove.Text
        strAmount = strAmount.Remove(1, 1)
        strAmount = strAmount.Remove(4, 1)
        lbl06Remove.Text = strAmount

        '#07 Contains:
        Dim strAddress As String = txt07Contains.Text
        Dim blnIsContained As Boolean
        If blnIsContained = strAddress.ToUpper.Contains("JEFFERSON") Then
            lbl07Contains.Text = "Jeff St. Found"
        Else
            lbl07Contains.Text = "Jeff St. Not Found"
        End If

        '#12 Len/Remove:
        Dim strTax As String = txt12LenRemove.Text
        Dim intNumChars1 As Integer
        Dim dblTaxRate As Double
        intNumChars1 = txt12LenRemove.Text.Length
        intNumChars1 = intNumChars1 - 2
        strTax = strTax.Remove(intNumChars1)
        Double.TryParse(strTax, dblTaxRate)
        dblTaxRate = dblTaxRate * 1000
        lbl12LenRemove.Text = dblTaxRate.ToString

        '#13 Like:
        Dim strZip As String = txt13Like.Text
        If strZip Like "605##" Then
            lbl13Like.Text = "Ship Chg: $25"
        ElseIf strZip Like "606##" Then
            lbl13Like.Text = "Ship Chg: $30"
        Else
            lbl13Like.Text = "Invalid Zip Code"
        End If
    End Sub
End Class