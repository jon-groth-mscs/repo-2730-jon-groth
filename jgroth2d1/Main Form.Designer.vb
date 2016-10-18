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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnConvertNE = New System.Windows.Forms.Button()
        Me.btnConvertEQ = New System.Windows.Forms.Button()
        Me.txtAmDollar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalDue = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPricePound = New System.Windows.Forms.TextBox()
        Me.txtPound = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMonthlyBill = New System.Windows.Forms.Label()
        Me.btnCalc2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.txtPrevious = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblQuotient = New System.Windows.Forms.Label()
        Me.btnCalc3 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtSecondNum = New System.Windows.Forms.TextBox()
        Me.txtFirstNum = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblRand)
        Me.GroupBox1.Controls.Add(Me.lblPound)
        Me.GroupBox1.Controls.Add(Me.lblEuro)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnConvertNE)
        Me.GroupBox1.Controls.Add(Me.btnConvertEQ)
        Me.GroupBox1.Controls.Add(Me.txtAmDollar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "p231 #1 Currency Converter"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(448, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "South African Rand"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(342, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "British Pound:"
        '
        'lblRand
        '
        Me.lblRand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRand.Location = New System.Drawing.Point(448, 48)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(100, 23)
        Me.lblRand.TabIndex = 7
        Me.lblRand.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPound
        '
        Me.lblPound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPound.Location = New System.Drawing.Point(342, 48)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(100, 23)
        Me.lblPound.TabIndex = 6
        Me.lblPound.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEuro
        '
        Me.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEuro.Location = New System.Drawing.Point(236, 48)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(100, 23)
        Me.lblEuro.TabIndex = 5
        Me.lblEuro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Euro:"
        '
        'btnConvertNE
        '
        Me.btnConvertNE.Location = New System.Drawing.Point(139, 58)
        Me.btnConvertNE.Name = "btnConvertNE"
        Me.btnConvertNE.Size = New System.Drawing.Size(75, 21)
        Me.btnConvertNE.TabIndex = 3
        Me.btnConvertNE.Text = "Convert <>"
        Me.btnConvertNE.UseVisualStyleBackColor = True
        '
        'btnConvertEQ
        '
        Me.btnConvertEQ.Location = New System.Drawing.Point(139, 31)
        Me.btnConvertEQ.Name = "btnConvertEQ"
        Me.btnConvertEQ.Size = New System.Drawing.Size(75, 21)
        Me.btnConvertEQ.TabIndex = 2
        Me.btnConvertEQ.Text = "Convert ="
        Me.btnConvertEQ.UseVisualStyleBackColor = True
        '
        'txtAmDollar
        '
        Me.txtAmDollar.Location = New System.Drawing.Point(38, 48)
        Me.txtAmDollar.Name = "txtAmDollar"
        Me.txtAmDollar.Size = New System.Drawing.Size(84, 20)
        Me.txtAmDollar.TabIndex = 1
        Me.txtAmDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "American Dollar:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblTotalDue)
        Me.GroupBox2.Controls.Add(Me.btnCalc)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtPricePound)
        Me.GroupBox2.Controls.Add(Me.txtPound)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(421, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "p231 #3 Tea Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Due:"
        '
        'lblTotalDue
        '
        Me.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalDue.Location = New System.Drawing.Point(303, 46)
        Me.lblTotalDue.Name = "lblTotalDue"
        Me.lblTotalDue.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalDue.TabIndex = 5
        Me.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(221, 47)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 20)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(130, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Price/lb:"
        '
        'txtPricePound
        '
        Me.txtPricePound.Location = New System.Drawing.Point(130, 47)
        Me.txtPricePound.Name = "txtPricePound"
        Me.txtPricePound.Size = New System.Drawing.Size(84, 20)
        Me.txtPricePound.TabIndex = 2
        '
        'txtPound
        '
        Me.txtPound.Location = New System.Drawing.Point(41, 47)
        Me.txtPound.Name = "txtPound"
        Me.txtPound.Size = New System.Drawing.Size(84, 20)
        Me.txtPound.TabIndex = 1
        Me.txtPound.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Pounds:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.lblMonthlyBill)
        Me.GroupBox3.Controls.Add(Me.btnCalc2)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtCurrent)
        Me.GroupBox3.Controls.Add(Me.txtPrevious)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 214)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(421, 100)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "p232 #4 County Electric w/Validation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(303, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Monthly Bill:"
        '
        'lblMonthlyBill
        '
        Me.lblMonthlyBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMonthlyBill.Location = New System.Drawing.Point(303, 46)
        Me.lblMonthlyBill.Name = "lblMonthlyBill"
        Me.lblMonthlyBill.Size = New System.Drawing.Size(100, 23)
        Me.lblMonthlyBill.TabIndex = 5
        Me.lblMonthlyBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalc2
        '
        Me.btnCalc2.Location = New System.Drawing.Point(221, 47)
        Me.btnCalc2.Name = "btnCalc2"
        Me.btnCalc2.Size = New System.Drawing.Size(75, 20)
        Me.btnCalc2.TabIndex = 4
        Me.btnCalc2.Text = "Calculate"
        Me.btnCalc2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Current:"
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(130, 47)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(84, 20)
        Me.txtCurrent.TabIndex = 2
        '
        'txtPrevious
        '
        Me.txtPrevious.Location = New System.Drawing.Point(41, 47)
        Me.txtPrevious.Name = "txtPrevious"
        Me.txtPrevious.Size = New System.Drawing.Size(84, 20)
        Me.txtPrevious.TabIndex = 1
        Me.txtPrevious.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(38, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Previous:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.lblQuotient)
        Me.GroupBox4.Controls.Add(Me.btnCalc3)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtSecondNum)
        Me.GroupBox4.Controls.Add(Me.txtFirstNum)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 320)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(421, 100)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "p232 Divsion Calculator"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(303, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Quotient:"
        '
        'lblQuotient
        '
        Me.lblQuotient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuotient.Location = New System.Drawing.Point(303, 46)
        Me.lblQuotient.Name = "lblQuotient"
        Me.lblQuotient.Size = New System.Drawing.Size(100, 23)
        Me.lblQuotient.TabIndex = 5
        Me.lblQuotient.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCalc3
        '
        Me.btnCalc3.Location = New System.Drawing.Point(221, 47)
        Me.btnCalc3.Name = "btnCalc3"
        Me.btnCalc3.Size = New System.Drawing.Size(75, 20)
        Me.btnCalc3.TabIndex = 4
        Me.btnCalc3.Text = "Calculate"
        Me.btnCalc3.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(130, 30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Second#:"
        '
        'txtSecondNum
        '
        Me.txtSecondNum.Location = New System.Drawing.Point(130, 47)
        Me.txtSecondNum.Name = "txtSecondNum"
        Me.txtSecondNum.Size = New System.Drawing.Size(84, 20)
        Me.txtSecondNum.TabIndex = 2
        '
        'txtFirstNum
        '
        Me.txtFirstNum.Location = New System.Drawing.Point(41, 47)
        Me.txtFirstNum.Name = "txtFirstNum"
        Me.txtFirstNum.Size = New System.Drawing.Size(84, 20)
        Me.txtFirstNum.TabIndex = 1
        Me.txtFirstNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(38, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "First#:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(486, 350)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(143, 54)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 433)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "jgroth2d1 If Statements"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblRand As Label
    Friend WithEvents lblPound As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnConvertNE As Button
    Friend WithEvents btnConvertEQ As Button
    Friend WithEvents txtAmDollar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalDue As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPricePound As TextBox
    Friend WithEvents txtPound As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblMonthlyBill As Label
    Friend WithEvents btnCalc2 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents txtPrevious As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblQuotient As Label
    Friend WithEvents btnCalc3 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtSecondNum As TextBox
    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnExit As Button
End Class
