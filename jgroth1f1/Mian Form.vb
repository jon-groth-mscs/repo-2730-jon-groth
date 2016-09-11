Option Strict On
Public Class frmMain
    '  Project:    Cranston Berries
    '  Purpose:    To calculate projected sales
    '              for next year
    '  Programmer: Jon Groth
    '  Date:       09/11/2016
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblStraw.Text = Format(Val(txtStraw.Text) * Val(txtPorjIncrease.Text) + Val(txtStraw.Text), "currency")
        lblBlue.Text = Format(Val(txtBlue.Text) * Val(txtPorjIncrease.Text) + Val(txtBlue.Text), "currency")
        lblRasp.Text = Format(Val(txtRasp.Text) * Val(txtPorjIncrease.Text) + Val(txtRasp.Text), "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStraw.Text = String.Empty
        lblStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        lblBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        lblRasp.Text = String.Empty
        txtPorjIncrease.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
