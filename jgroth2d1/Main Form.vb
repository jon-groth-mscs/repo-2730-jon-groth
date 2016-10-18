'Name:        Ch4 Lesson B, If statements, message boxes
'Purpose:     Currency, Tea, Electric, Quotient
'Programmer:  Jon Groth on 1017/2016


Public Class frmMain
    Private Sub btnConvertEQ_Click(sender As Object, e As EventArgs) Handles btnConvertEQ.Click
        'convert American Dollars to the Euro, the
        'British Pound, and the South African Rand

        Const dblEURO_RATE As Double = 0.91
        Const dblPOUND_RATE As Double = 0.82
        Const dblRAND_RATE As Double = 14.1
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        If txtAmDollar.Text = String.Empty Then
            MessageBox.Show("Please enter the number of American Dollars.",
                            "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Double.TryParse(txtAmDollar.Text, dblAmDollar)

            dblEuro = dblAmDollar * dblEURO_RATE
            dblPound = dblAmDollar * dblPOUND_RATE
            dblRand = dblAmDollar * dblRAND_RATE

            lblEuro.Text = dblEuro.ToString("c2")
            lblPound.Text = dblPound.ToString("c2")
            lblRand.Text = dblRand.ToString("c2")
        End If
    End Sub

    Private Sub btnConvertNE_Click(sender As Object, e As EventArgs) Handles btnConvertNE.Click
        'convert American Dollars to the Euro, the
        'British Pound, and the South African Rand

        Const dblEURO_RATE As Double = 0.91
        Const dblPOUND_RATE As Double = 0.82
        Const dblRAND_RATE As Double = 14.1
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        If txtAmDollar.Text <> String.Empty Then
            Double.TryParse(txtAmDollar.Text, dblAmDollar)

            dblEuro = dblAmDollar * dblEURO_RATE
            dblPound = dblAmDollar * dblPOUND_RATE
            dblRand = dblAmDollar * dblRAND_RATE

            lblEuro.Text = dblEuro.ToString("c2")
            lblPound.Text = dblPound.ToString("c2")
            lblRand.Text = dblRand.ToString("c2")
        Else
            MessageBox.Show("Please enter the number of American Dollars.",
                           "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblPound As Double
        Dim dblPricePound As Double
        Dim dblTotalDue As Double

        Double.TryParse(txtPound.Text, dblPound)
        Double.TryParse(txtPricePound.Text, dblPricePound)
        Double.TryParse(lblTotalDue.Text, dblTotalDue)

        If MessageBox.Show("Charge for Shipping?", "Tea Time Company",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            dblTotalDue = dblPound * dblPricePound + 15
            lblTotalDue.Text = dblTotalDue.ToString("c2")
        Else
            dblTotalDue = dblPound * dblPricePound
            lblTotalDue.Text = dblTotalDue.ToString("c2")
        End If
    End Sub
    Private Sub btnCalc2_Click(sender As Object, e As EventArgs) Handles btnCalc2.Click
        Const dblCHG_PER_UNIT As Double = 0.13
        Dim dblPrevious As Double
        Dim dblCurrent As Double
        Dim dblMonthlyBill As Double

        Double.TryParse(txtPrevious.Text, dblPrevious)
        Double.TryParse(txtCurrent.Text, dblCurrent)
        Double.TryParse(lblMonthlyBill.Text, dblMonthlyBill)

        If dblCurrent < dblPrevious OrElse
                txtPrevious.Text = String.Empty OrElse
                txtCurrent.Text = String.Empty Then

            MessageBox.Show("The current reading must be greater than or equal to previous reading",
                            "TriCounty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            dblMonthlyBill = (dblCurrent - dblPrevious) * dblCHG_PER_UNIT
            lblMonthlyBill.Text = dblMonthlyBill.ToString("c2")
        End If
    End Sub

    Private Sub btnCalc3_Click(sender As Object, e As EventArgs) Handles btnCalc3.Click
        Dim intFirstNum As Integer
        Dim intSecondNum As Integer
        Dim intQuotient As Integer

        Integer.TryParse(txtFirstNum.Text, intFirstNum)
        Integer.TryParse(txtSecondNum.Text, intSecondNum)
        Integer.TryParse(lblQuotient.Text, intQuotient)

        If intFirstNum = 0 OrElse
                intSecondNum = 0 Then
            MessageBox.Show("You cannot divide by 0.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If intFirstNum > intSecondNum Then
            Dim intTemp As Integer
            intTemp = intFirstNum
            intFirstNum = intSecondNum
            intSecondNum = intTemp
        End If

        intQuotient = intSecondNum / intFirstNum
        lblQuotient.Text = intQuotient.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
