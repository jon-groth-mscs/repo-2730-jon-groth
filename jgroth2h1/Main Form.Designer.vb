<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMzin
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
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.chkMoreThanTen = New System.Windows.Forms.CheckBox()
        Me.chkTavel = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCommissionOnly = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAdditional = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalCommission = New System.Windows.Forms.Label()
        Me.btnIfThen = New System.Windows.Forms.Button()
        Me.btnNestedIf = New System.Windows.Forms.Button()
        Me.btnIfElseIf = New System.Windows.Forms.Button()
        Me.btnSelectCase = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(25, 36)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 1
        Me.txtSales.Text = "#10000000"
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkMoreThanTen
        '
        Me.chkMoreThanTen.AutoSize = True
        Me.chkMoreThanTen.Location = New System.Drawing.Point(25, 63)
        Me.chkMoreThanTen.Name = "chkMoreThanTen"
        Me.chkMoreThanTen.Size = New System.Drawing.Size(77, 17)
        Me.chkMoreThanTen.TabIndex = 2
        Me.chkMoreThanTen.Text = "> 10 Years"
        Me.chkMoreThanTen.UseVisualStyleBackColor = True
        '
        'chkTavel
        '
        Me.chkTavel.AutoSize = True
        Me.chkTavel.Location = New System.Drawing.Point(25, 87)
        Me.chkTavel.Name = "chkTavel"
        Me.chkTavel.Size = New System.Drawing.Size(70, 17)
        Me.chkTavel.TabIndex = 3
        Me.chkTavel.Text = "Traveling"
        Me.chkTavel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Commission Only:"
        '
        'lblCommissionOnly
        '
        Me.lblCommissionOnly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommissionOnly.Location = New System.Drawing.Point(25, 128)
        Me.lblCommissionOnly.Name = "lblCommissionOnly"
        Me.lblCommissionOnly.Size = New System.Drawing.Size(100, 23)
        Me.lblCommissionOnly.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Additional Amount:"
        '
        'lblAdditional
        '
        Me.lblAdditional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAdditional.Location = New System.Drawing.Point(25, 174)
        Me.lblAdditional.Name = "lblAdditional"
        Me.lblAdditional.Size = New System.Drawing.Size(100, 23)
        Me.lblAdditional.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Commission:"
        '
        'lblTotalCommission
        '
        Me.lblTotalCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCommission.Location = New System.Drawing.Point(25, 218)
        Me.lblTotalCommission.Name = "lblTotalCommission"
        Me.lblTotalCommission.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalCommission.TabIndex = 9
        '
        'btnIfThen
        '
        Me.btnIfThen.Location = New System.Drawing.Point(143, 36)
        Me.btnIfThen.Name = "btnIfThen"
        Me.btnIfThen.Size = New System.Drawing.Size(75, 23)
        Me.btnIfThen.TabIndex = 10
        Me.btnIfThen.Text = "If Then"
        Me.btnIfThen.UseVisualStyleBackColor = True
        '
        'btnNestedIf
        '
        Me.btnNestedIf.Location = New System.Drawing.Point(143, 66)
        Me.btnNestedIf.Name = "btnNestedIf"
        Me.btnNestedIf.Size = New System.Drawing.Size(75, 23)
        Me.btnNestedIf.TabIndex = 11
        Me.btnNestedIf.Text = "Nested If"
        Me.btnNestedIf.UseVisualStyleBackColor = True
        '
        'btnIfElseIf
        '
        Me.btnIfElseIf.Location = New System.Drawing.Point(143, 96)
        Me.btnIfElseIf.Name = "btnIfElseIf"
        Me.btnIfElseIf.Size = New System.Drawing.Size(75, 23)
        Me.btnIfElseIf.TabIndex = 12
        Me.btnIfElseIf.Text = "If ElseIf"
        Me.btnIfElseIf.UseVisualStyleBackColor = True
        '
        'btnSelectCase
        '
        Me.btnSelectCase.Location = New System.Drawing.Point(143, 126)
        Me.btnSelectCase.Name = "btnSelectCase"
        Me.btnSelectCase.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectCase.TabIndex = 13
        Me.btnSelectCase.Text = "Select Case"
        Me.btnSelectCase.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(143, 155)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 178)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Commission  Calculations:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(114, 155)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "$700"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(114, 138)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "$500"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 155)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 13)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "Travelling"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "> 10 Years"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 13)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Additionsl Amounts:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(131, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(158, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "$3,120 + 14% of Sales > 30,000"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(131, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "$120 + 13% of Sales > 6,000"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(131, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "10% of Sales"
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(131, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Commission"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "> 30,000"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "6,000 - 29,999.99"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "1 - 5,999.99"
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(7, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Sales (S)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMzin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 261)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSelectCase)
        Me.Controls.Add(Me.btnIfElseIf)
        Me.Controls.Add(Me.btnNestedIf)
        Me.Controls.Add(Me.btnIfThen)
        Me.Controls.Add(Me.lblTotalCommission)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblAdditional)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCommissionOnly)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkTavel)
        Me.Controls.Add(Me.chkMoreThanTen)
        Me.Controls.Add(Me.txtSales)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMzin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jgroth2h1 Marshall Sales Commission"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents chkMoreThanTen As CheckBox
    Friend WithEvents chkTavel As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCommissionOnly As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAdditional As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalCommission As Label
    Friend WithEvents btnIfThen As Button
    Friend WithEvents btnNestedIf As Button
    Friend WithEvents btnIfElseIf As Button
    Friend WithEvents btnSelectCase As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
End Class
