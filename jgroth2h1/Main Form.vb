Option Strict On
Option Explicit On
Option Infer Off
Public Class frmMzin
    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btnIfThen_Click(sender As Object, e As EventArgs) Handles btnIfThen.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Format", "Number Format Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommissionOnly = 120 + (dblSales - 6000.0) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End If

        If chkMoreThanTen.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTavel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If


        txtSales.Focus()
    End Sub

    Private Sub btnNestedIf_Click(sender As Object, e As EventArgs) Handles btnNestedIf.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Format", "Number Format Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        Else
            If dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
                dblCommissionOnly = dblSales * 0.1
            Else
                If dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
                    dblCommissionOnly = 120 + (dblSales - 6000.0) * 0.013
                Else
                    If dblSales >= 30000.0 Then
                        dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
                    End If
                End If
            End If
        End If

        If chkMoreThanTen.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTavel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If


        txtSales.Focus()
    End Sub
    Private Sub btnIfElseIf_Click(sender As Object, e As EventArgs) Handles btnIfElseIf.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Format", "Number Format Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        ElseIf dblSales >= 6000.0 AndAlso dblSales < 30000 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        ElseIf dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        ElseIf dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        End If

        If chkMoreThanTen.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTavel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If


        txtSales.Focus()
    End Sub
    Private Sub btnSelectCase_Click(sender As Object, e As EventArgs) Handles btnSelectCase.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Format", "Number Format Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Select Case dblSales
            Case Is < 1
                dblCommissionOnly = 0.0
            Case 1 To 6000.0
                dblCommissionOnly = 0.1
            Case 6000.0 To 30000.0
                dblCommissionOnly = 120 + (dblSales - 6000) * 0.13
            Case Is >= 30000.0
                dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End Select

        If chkMoreThanTen.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTavel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If


        txtSales.Focus()
    End Sub

    Private Sub ClearCommission(sender As Object, e As EventArgs) Handles txtSales.TextChanged,
            chkMoreThanTen.TextChanged, chkTavel.TextChanged
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
