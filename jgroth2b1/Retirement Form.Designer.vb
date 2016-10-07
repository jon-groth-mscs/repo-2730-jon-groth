<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetirement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.txtEmployeeRate = New System.Windows.Forms.TextBox()
        Me.txtEmployerRate = New System.Windows.Forms.TextBox()
        Me.lblEmployeeAnnual = New System.Windows.Forms.Label()
        Me.lblEmployerAnnual = New System.Windows.Forms.Label()
        Me.lblTotalAnnual = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Gross weekly Pay:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Employee contribution rate (decimal form):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Employe&r contribution rate (decimal form):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Employee annual contribution:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Employer annual contribution:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total annaul contribution:"
        '
        'txtGrossPay
        '
        Me.txtGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrossPay.Location = New System.Drawing.Point(235, 36)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(144, 20)
        Me.txtGrossPay.TabIndex = 1
        Me.txtGrossPay.Text = "1000"
        Me.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployeeRate
        '
        Me.txtEmployeeRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeRate.Location = New System.Drawing.Point(316, 62)
        Me.txtEmployeeRate.Name = "txtEmployeeRate"
        Me.txtEmployeeRate.Size = New System.Drawing.Size(63, 20)
        Me.txtEmployeeRate.TabIndex = 3
        Me.txtEmployeeRate.Text = "0.05"
        Me.txtEmployeeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEmployerRate
        '
        Me.txtEmployerRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployerRate.Location = New System.Drawing.Point(316, 88)
        Me.txtEmployerRate.Name = "txtEmployerRate"
        Me.txtEmployerRate.Size = New System.Drawing.Size(63, 20)
        Me.txtEmployerRate.TabIndex = 5
        Me.txtEmployerRate.Text = "0.07"
        Me.txtEmployerRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEmployeeAnnual
        '
        Me.lblEmployeeAnnual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployeeAnnual.Location = New System.Drawing.Point(279, 120)
        Me.lblEmployeeAnnual.Name = "lblEmployeeAnnual"
        Me.lblEmployeeAnnual.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployeeAnnual.TabIndex = 9
        Me.lblEmployeeAnnual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmployerAnnual
        '
        Me.lblEmployerAnnual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmployerAnnual.Location = New System.Drawing.Point(279, 152)
        Me.lblEmployerAnnual.Name = "lblEmployerAnnual"
        Me.lblEmployerAnnual.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployerAnnual.TabIndex = 11
        Me.lblEmployerAnnual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalAnnual
        '
        Me.lblTotalAnnual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalAnnual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalAnnual.Location = New System.Drawing.Point(279, 189)
        Me.lblTotalAnnual.Name = "lblTotalAnnual"
        Me.lblTotalAnnual.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalAnnual.TabIndex = 13
        Me.lblTotalAnnual.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(279, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 42)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(173, 226)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(100, 42)
        Me.btnCalc.TabIndex = 6
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmRetirement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 296)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblTotalAnnual)
        Me.Controls.Add(Me.lblEmployerAnnual)
        Me.Controls.Add(Me.lblEmployeeAnnual)
        Me.Controls.Add(Me.txtEmployerRate)
        Me.Controls.Add(Me.txtEmployeeRate)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRetirement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jgroth2b1 Retirement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents txtEmployeeRate As TextBox
    Friend WithEvents txtEmployerRate As TextBox
    Friend WithEvents lblEmployeeAnnual As Label
    Friend WithEvents lblEmployerAnnual As Label
    Friend WithEvents lblTotalAnnual As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
End Class
