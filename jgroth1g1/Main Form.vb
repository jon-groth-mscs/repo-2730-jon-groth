'Name:             Average Project
'Purpose:          Displays the average of 3 test scores
'Programmer:       Jon Groth on 9/13/2016

Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblAverageScore.Text = Format((Val(txtTest1.Text) + Val(txtTest2.Text) + Val(txtTest3.Text)) / 3, "standard")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTest1.Text = String.Empty
        txtTest2.Text = String.Empty
        txtTest3.Text = String.Empty
        lblAverageScore.Text = String.Empty
        txtTest1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
