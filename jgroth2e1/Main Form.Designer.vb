<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCalcOr = New System.Windows.Forms.Button()
        Me.btnCalcAnd = New System.Windows.Forms.Button()
        Me.lblShippingCharge = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSavannah = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrderAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCalcNE = New System.Windows.Forms.Button()
        Me.btnCalcEQ = New System.Windows.Forms.Button()
        Me.lblCommission = New System.Windows.Forms.Label()
        Me.k = New System.Windows.Forms.Label()
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.l = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCalcOr)
        Me.GroupBox1.Controls.Add(Me.btnCalcAnd)
        Me.GroupBox1.Controls.Add(Me.lblShippingCharge)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSavannah)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtOrderAmount)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 93)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Free shipping for orders over $100 with Savanna's CC"
        '
        'btnCalcOr
        '
        Me.btnCalcOr.Location = New System.Drawing.Point(393, 57)
        Me.btnCalcOr.Name = "btnCalcOr"
        Me.btnCalcOr.Size = New System.Drawing.Size(88, 23)
        Me.btnCalcOr.TabIndex = 7
        Me.btnCalcOr.Text = "Calculate (Or)"
        Me.btnCalcOr.UseVisualStyleBackColor = True
        '
        'btnCalcAnd
        '
        Me.btnCalcAnd.Location = New System.Drawing.Point(393, 32)
        Me.btnCalcAnd.Name = "btnCalcAnd"
        Me.btnCalcAnd.Size = New System.Drawing.Size(88, 23)
        Me.btnCalcAnd.TabIndex = 6
        Me.btnCalcAnd.Text = "Calculate (And)"
        Me.btnCalcAnd.UseVisualStyleBackColor = True
        '
        'lblShippingCharge
        '
        Me.lblShippingCharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShippingCharge.Location = New System.Drawing.Point(251, 46)
        Me.lblShippingCharge.Name = "lblShippingCharge"
        Me.lblShippingCharge.Size = New System.Drawing.Size(100, 23)
        Me.lblShippingCharge.TabIndex = 5
        Me.lblShippingCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Shipping Charge:"
        '
        'txtSavannah
        '
        Me.txtSavannah.Location = New System.Drawing.Point(144, 47)
        Me.txtSavannah.Name = "txtSavannah"
        Me.txtSavannah.Size = New System.Drawing.Size(42, 20)
        Me.txtSavannah.TabIndex = 3
        Me.txtSavannah.Text = "Y"
        Me.txtSavannah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Savannah (Y/N):"
        '
        'txtOrderAmount
        '
        Me.txtOrderAmount.Location = New System.Drawing.Point(25, 47)
        Me.txtOrderAmount.Name = "txtOrderAmount"
        Me.txtOrderAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderAmount.TabIndex = 1
        Me.txtOrderAmount.Text = "100"
        Me.txtOrderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Order Amount:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCalcNE)
        Me.GroupBox2.Controls.Add(Me.btnCalcEQ)
        Me.GroupBox2.Controls.Add(Me.lblCommission)
        Me.GroupBox2.Controls.Add(Me.k)
        Me.GroupBox2.Controls.Add(Me.txtSales)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.l)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(505, 93)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "15% commission for sales > 25000 with codes A1, B2, C3"
        '
        'btnCalcNE
        '
        Me.btnCalcNE.Location = New System.Drawing.Point(393, 57)
        Me.btnCalcNE.Name = "btnCalcNE"
        Me.btnCalcNE.Size = New System.Drawing.Size(88, 23)
        Me.btnCalcNE.TabIndex = 7
        Me.btnCalcNE.Text = "Calculate (<>)"
        Me.btnCalcNE.UseVisualStyleBackColor = True
        '
        'btnCalcEQ
        '
        Me.btnCalcEQ.Location = New System.Drawing.Point(393, 32)
        Me.btnCalcEQ.Name = "btnCalcEQ"
        Me.btnCalcEQ.Size = New System.Drawing.Size(88, 23)
        Me.btnCalcEQ.TabIndex = 6
        Me.btnCalcEQ.Text = "Calculate (=)"
        Me.btnCalcEQ.UseVisualStyleBackColor = True
        '
        'lblCommission
        '
        Me.lblCommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommission.Location = New System.Drawing.Point(251, 46)
        Me.lblCommission.Name = "lblCommission"
        Me.lblCommission.Size = New System.Drawing.Size(100, 23)
        Me.lblCommission.TabIndex = 5
        Me.lblCommission.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'k
        '
        Me.k.AutoSize = True
        Me.k.Location = New System.Drawing.Point(251, 30)
        Me.k.Name = "k"
        Me.k.Size = New System.Drawing.Size(65, 13)
        Me.k.TabIndex = 4
        Me.k.Text = "Commission:"
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(78, 47)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(122, 20)
        Me.txtSales.TabIndex = 3
        Me.txtSales.Text = "100000"
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Sales:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(25, 47)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(35, 20)
        Me.txtID.TabIndex = 1
        Me.txtID.Text = "A1"
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Location = New System.Drawing.Point(25, 30)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(21, 13)
        Me.l.TabIndex = 0
        Me.l.Text = "ID:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(218, 243)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 268)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "jgroth2e1 AndAlso, OrElse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCalcOr As Button
    Friend WithEvents btnCalcAnd As Button
    Friend WithEvents lblShippingCharge As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSavannah As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOrderAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalcNE As Button
    Friend WithEvents btnCalcEQ As Button
    Friend WithEvents lblCommission As Label
    Friend WithEvents k As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents l As Label
    Friend WithEvents btnExit As Button
End Class
