Public Class frmRetirement
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decGrossPay As Decimal
        Dim decEmployeeRate As Decimal
        Dim decEmployerRate As Decimal
        Dim decEmployeeAnnual As Decimal
        Dim decEmployerAnnual As Decimal
        Dim decTotalAnnual As Decimal

        Decimal.TryParse(txtGrossPay.Text, decGrossPay)
        Decimal.TryParse(txtEmployeeRate.Text, decEmployeeRate)
        Decimal.TryParse(txtEmployerRate.Text, decEmployerRate)

        decEmployeeAnnual = decGrossPay * decEmployeeRate
        decEmployerAnnual = decGrossPay * decEmployerRate
        decTotalAnnual = decEmployeeAnnual + decEmployerAnnual

        lblEmployeeAnnual.Text = decEmployeeAnnual.ToString("C2")
        lblEmployerAnnual.Text = decEmployerAnnual.ToString("C2")
        lblTotalAnnual.Text = decTotalAnnual.ToString("C2")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
