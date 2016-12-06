' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   Jon Groth on 12/05/2016

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs)
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
         Handles radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged

        Dim dblMeasurement As Double = 0.0
        Dim dblResult As Double = 0.0

        Double.TryParse(txtMeasurement.Text, dblMeasurement)

        If radSubCentimeters.Checked Then
            CalcCentimetersSub(dblMeasurement, dblResult)
        ElseIf radSubInches.Checked Then
            CalcInchesSub(dblMeasurement, dblResult)
        ElseIf radFuncCentimeters.Checked Then
            dblResult = CalcCentimetersFunc(dblMeasurement)
        ElseIf radFuncInches.Checked Then
            dblResult = CalcInchesFunc(dblMeasurement)
        End If

        lblResult.Text = dblResult.ToString("n2")
    End Sub

    Private Sub CalcCentimetersSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas * 2.54
    End Sub

    Private Sub CalcInchesSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas / 2.54
    End Sub

    Private Function CalcCentimetersFunc(ByVal dblMeas As Double) As Double

        Dim dblRes As Double
        dblRes = dblMeas * 2.54
        Return dblRes
    End Function

    Private Function CalcInchesFunc(ByVal dblMeas As Double) As Double

        Dim dblRes As Double
        dblRes = dblMeas / 2.54
        Return dblRes
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboPlanets.Items.Add("Mercury")
        cboPlanets.Items.Add("Venus")
        cboPlanets.Items.Add("Earth")
        cboPlanets.Items.Add("Mars")
        cboPlanets.Items.Add("Jupiter")
        cboPlanets.Items.Add("Saturn")
        cboPlanets.Items.Add("Uranus")
        cboPlanets.Items.Add("Neptune")
        cboPlanets.Items.Add("Pluto")
        cboPlanets.SelectedItem = "Earth"
    End Sub

    Private Sub txtEarthWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEarthWeight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
         e.KeyChar <> ControlChars.Back AndAlso
         e.KeyChar <> "." Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub txtEarthWeight_Enter(sender As Object, e As EventArgs) Handles txtEarthWeight.Enter
        txtEarthWeight.SelectAll()
    End Sub

    Private Function CalcWeightFunc(ByVal intWeight As Integer) As Double

        Dim dblGravity As Double

        Select Case cboPlanets.Text
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1.0
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select

        Dim dblWeightonPlanet As Double
        dblWeightonPlanet = intWeight * dblGravity
        Return dblWeightonPlanet
    End Function

    Private Sub CalcWeightSub(ByVal intWeight As Integer, ByRef dblWeightonPlanet As Double)
        Dim dblGravity As Double

        Select Case cboPlanets.Text
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Earth"
                dblGravity = 1.0
            Case "Jupiter"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select

        dblWeightonPlanet = intWeight * dblGravity
    End Sub
    Private Sub WeightInputChanged(sender As Object, e As EventArgs) _
        Handles txtEarthWeight.TextChanged, cboPlanets.TextChanged, rdoPlanetSub.CheckedChanged,
        rdoPlanetFunc.CheckedChanged

        Dim intWeight As Integer = 0
        Dim dblWeightonPlanet As Double = 0.0

        Integer.TryParse(txtEarthWeight.Text, intWeight)

        If rdoPlanetSub.Checked Then
            CalcWeightSub(intWeight, dblWeightonPlanet)
        ElseIf rdoPlanetFunc.Checked Then
            dblWeightonPlanet = CalcWeightFunc(intWeight)
        End If

        lblResult.Text = intWeight.ToString("n2")
    End Sub
End Class
