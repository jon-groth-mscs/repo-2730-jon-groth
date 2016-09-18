' Name:          Photo Project
' Purpose:       Displays the gross pay, FWT, FICA, State Income Tax, and Net Pay
' Programmer:    Jon Groth on 9/17/2016

Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'lblGross.Text = Val(txtHours.Text) * Val(txtPayRate.Text)
        'lblFWT.Text = Val(lblGross.Text) * 0.2
        'lblFICA.Text = Val(lblGross.Text) * 0.08
        'lblState.Text = Val(lblGross.Text) * 0.03
        'lblNet.Text = Val(lblGross.Text) - Val(lblFWT.Text) - Val(lblFICA.Text) - Val(lblState.Text)
        lblGross.Text = Format(Val(txtHours.Text) * Val(txtPayRate.Text), "fixed")
        lblFWT.Text = Format(Val(lblGross.Text) * 0.2, "fixed")
        lblFICA.Text = Format(Val(lblGross.Text) * 0.08, "fixed")
        lblState.Text = Format(Val(lblGross.Text) * 0.03, "fixed")
        lblNet.Text = Format(Val(lblGross.Text) - Val(lblFWT.Text) - Val(lblFICA.Text) - Val(lblState.Text), "currency")
    End Sub

    Private Sub btnCleary_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = String.Empty
        txtHours.Text = String.Empty
        txtPayRate.Text = String.Empty
        lblGross.Text = String.Empty
        lblFWT.Text = String.Empty
        lblFICA.Text = String.Empty
        lblState.Text = String.Empty
        lblNet.Text = String.Empty
        txtName.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
