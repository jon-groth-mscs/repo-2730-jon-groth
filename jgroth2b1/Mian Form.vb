'  Project:    Cranston Berries
'  Purpose:    To calculate projected sales
'              for next year
'  Programmer: Jon Groth
'  Date:       10/05/2016

Option Strict On
Option Explicit On
Option Infer Off
Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decStraw As Decimal
        Dim decBlue As Decimal
        Dim decRasp As Decimal
        Dim decProjIncrease As Decimal
        Dim decProjStraw As Decimal
        Dim decProjBlue As Decimal
        Dim decProjRasp As Decimal

        'calculate projected sales
        Decimal.TryParse(txtStraw.Text, decStraw)
        Decimal.TryParse(txtBlue.Text, decBlue)
        Decimal.TryParse(txtRasp.Text, decRasp)
        Decimal.TryParse(txtProjIncrease.Text, decProjIncrease)

        decProjStraw = decProjIncrease * decStraw + decStraw
        decProjBlue = decProjIncrease * decBlue + decBlue
        decProjRasp = decProjIncrease * decRasp + decRasp

        lblStraw.Text = decProjStraw.ToString("C2")
        lblBlue.Text = decProjBlue.ToString("C2")
        lblRasp.Text = decProjRasp.ToString("C2")


        'lblStraw.Text = Format(Val(txtStraw.Text) * Val(txtPorjIncrease.Text) + Val(txtStraw.Text), "currency")
        'lblBlue.Text = Format(Val(txtBlue.Text) * Val(txtPorjIncrease.Text) + Val(txtBlue.Text), "currency")
        'lblRasp.Text = Format(Val(txtRasp.Text) * Val(txtPorjIncrease.Text) + Val(txtRasp.Text), "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStraw.Text = String.Empty
        lblStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        lblBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        lblRasp.Text = String.Empty
        txtProjIncrease.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRetirementForm_Click(sender As Object, e As EventArgs) Handles btnRetirementForm.Click
        frmRetirement.Show()
    End Sub
End Class
