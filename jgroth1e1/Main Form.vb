' Name:           Richardson County Property Tax Project
' Purpose:        Calculates property tax
' Programmer:     Jon Groth on 9/9/2016
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decPlace As Decimal
        decPlace = Val(txtAssessed.Text) / 100
        lblTax.Text = Val(decPlace) * 1.5
        lblTax.Text = Format(lblTax.Text, "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblTax.Text = String.Empty
        txtAssessed.Text = String.Empty
        txtAssessed.Focus()
    End Sub
End Class
