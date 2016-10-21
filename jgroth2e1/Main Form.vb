'Name:          Savannah's CC, Commission
'Purpose:       Free shipping for orders over $100 with Savannhas CC,
'               15% commission for sales > 2500 with codes A1, B2, C3
'Programmer:    Jon Gorth on 10/18/2016

Option Strict On

Public Class frmMain
    Private Sub btnCalcAnd_Click(sender As Object, e As EventArgs) Handles btnCalcAnd.Click
        Dim intOrderAmount As Integer
        Dim strSavannah As String
        Dim intShippingCharge As Integer

        Integer.TryParse(txtOrderAmount.Text, intOrderAmount)
        Integer.TryParse(lblShippingCharge.Text, intShippingCharge)
        strSavannah = txtSavannah.Text
        strSavannah = strSavannah.ToUpper

        If intOrderAmount >= 100 AndAlso
                strSavannah = "Y" Then
            lblShippingCharge.Text = "$0"
        Else
            lblShippingCharge.Text = "$9"
        End If
    End Sub

    Private Sub btnCalcOr_Click(sender As Object, e As EventArgs) Handles btnCalcOr.Click
        Dim intOrderAmount As Integer
        Dim strSavannah As String
        Dim intShippingCharge As Integer

        Integer.TryParse(txtOrderAmount.Text, intOrderAmount)
        Integer.TryParse(lblShippingCharge.Text, intShippingCharge)
        strSavannah = txtSavannah.Text
        strSavannah = strSavannah.ToUpper

        If intOrderAmount < 100 OrElse
                strSavannah <> "Y" Then
            lblShippingCharge.Text = "$9"
        Else
            lblShippingCharge.Text = "$0"

        End If
    End Sub

    Private Sub btnCalcEQ_Click(sender As Object, e As EventArgs) Handles btnCalcEQ.Click
        Dim strID As String
        Dim dblSales As Double
        Dim dblCommission As Double

        strID = txtID.Text
        strID = strID.ToUpper
        Double.TryParse(txtSales.Text, dblSales)
        Double.TryParse(lblCommission.Text, dblCommission)

        If strID = "A1" Or strID = "B2" Or strID = "C3" AndAlso
                dblSales >= 25000 Or
                (dblSales < 25000) Then
            dblCommission = dblSales * 0.15
            lblCommission.Text = dblCommission.ToString("c2")
        Else
            dblCommission = dblSales * 0.12
            lblCommission.Text = dblCommission.ToString("C2")
        End If
    End Sub

    Private Sub btnCalcNE_Click(sender As Object, e As EventArgs) Handles btnCalcNE.Click
        Dim strID As String
        Dim dblSales As Double
        Dim dblCommission As Double

        strID = txtID.Text
        strID = strID.ToUpper
        Double.TryParse(txtSales.Text, dblSales)
        Double.TryParse(lblCommission.Text, dblCommission)

        If strID <> "A1" And strID <> "B2" And strID <> "C3" OrElse
            dblSales < 25000 And
            (dblSales > 25000) Then
            dblCommission = dblSales * 0.12
            lblCommission.Text = dblCommission.ToString("c2")
        Else
            dblCommission = dblSales * 0.15
            lblCommission.Text= dblCommission.ToString("C2")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
