<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.chbAcc = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmbTransAcc = New System.Windows.Forms.ComboBox()
        Me.btnTrans = New System.Windows.Forms.Button()
        Me.txtTrans = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAcc = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlCheck = New System.Windows.Forms.Panel()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.txtOrder = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPayAmount = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtDraw = New System.Windows.Forms.TextBox()
        Me.btnDraw = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgvTrans = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlCheck.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvTrans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Controls.Add(Me.txtBalance)
        Me.Panel1.Controls.Add(Me.chbAcc)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 100)
        Me.Panel1.TabIndex = 0
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(798, 37)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(118, 20)
        Me.txtDate.TabIndex = 5
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(395, 37)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(138, 20)
        Me.txtBalance.TabIndex = 4
        '
        'chbAcc
        '
        Me.chbAcc.FormattingEnabled = True
        Me.chbAcc.Items.AddRange(New Object() {"Savings", "Checking"})
        Me.chbAcc.Location = New System.Drawing.Point(80, 34)
        Me.chbAcc.Name = "chbAcc"
        Me.chbAcc.Size = New System.Drawing.Size(121, 21)
        Me.chbAcc.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(721, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Today's Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(345, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Balance:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.btnDeposit)
        Me.Panel2.Controls.Add(Me.txtDeposit)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(12, 131)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(278, 70)
        Me.Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Deposit"
        '
        'btnDeposit
        '
        Me.btnDeposit.Location = New System.Drawing.Point(184, 22)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(75, 23)
        Me.btnDeposit.TabIndex = 2
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = True
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(27, 24)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(135, 20)
        Me.txtDeposit.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "R"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmbTransAcc)
        Me.Panel3.Controls.Add(Me.btnTrans)
        Me.Panel3.Controls.Add(Me.txtTrans)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.lblAcc)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(345, 131)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(284, 205)
        Me.Panel3.TabIndex = 2
        '
        'cmbTransAcc
        '
        Me.cmbTransAcc.FormattingEnabled = True
        Me.cmbTransAcc.Items.AddRange(New Object() {"Savings", "Checking"})
        Me.cmbTransAcc.Location = New System.Drawing.Point(109, 23)
        Me.cmbTransAcc.Name = "cmbTransAcc"
        Me.cmbTransAcc.Size = New System.Drawing.Size(121, 21)
        Me.cmbTransAcc.TabIndex = 6
        '
        'btnTrans
        '
        Me.btnTrans.Location = New System.Drawing.Point(145, 155)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(88, 37)
        Me.btnTrans.TabIndex = 5
        Me.btnTrans.Text = "Transfer"
        Me.btnTrans.UseVisualStyleBackColor = True
        '
        'txtTrans
        '
        Me.txtTrans.Location = New System.Drawing.Point(109, 109)
        Me.txtTrans.Name = "txtTrans"
        Me.txtTrans.Size = New System.Drawing.Size(124, 20)
        Me.txtTrans.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(88, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "R"
        '
        'lblAcc
        '
        Me.lblAcc.AutoSize = True
        Me.lblAcc.Location = New System.Drawing.Point(15, 109)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(64, 13)
        Me.lblAcc.TabIndex = 2
        Me.lblAcc.Text = "to Checking"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Transfer From"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Transfer"
        '
        'pnlCheck
        '
        Me.pnlCheck.Controls.Add(Me.btnCheck)
        Me.pnlCheck.Controls.Add(Me.txtOrder)
        Me.pnlCheck.Controls.Add(Me.Label12)
        Me.pnlCheck.Controls.Add(Me.txtPayAmount)
        Me.pnlCheck.Controls.Add(Me.Label11)
        Me.pnlCheck.Controls.Add(Me.Label10)
        Me.pnlCheck.Controls.Add(Me.Label8)
        Me.pnlCheck.Location = New System.Drawing.Point(702, 131)
        Me.pnlCheck.Name = "pnlCheck"
        Me.pnlCheck.Size = New System.Drawing.Size(274, 205)
        Me.pnlCheck.TabIndex = 3
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(148, 150)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(111, 47)
        Me.btnCheck.TabIndex = 9
        Me.btnCheck.Text = "Sign Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'txtOrder
        '
        Me.txtOrder.Location = New System.Drawing.Point(86, 102)
        Me.txtOrder.Name = "txtOrder"
        Me.txtOrder.Size = New System.Drawing.Size(173, 20)
        Me.txtOrder.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "to the order of"
        '
        'txtPayAmount
        '
        Me.txtPayAmount.Location = New System.Drawing.Point(135, 32)
        Me.txtPayAmount.Name = "txtPayAmount"
        Me.txtPayAmount.Size = New System.Drawing.Size(124, 20)
        Me.txtPayAmount.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(105, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "R"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Pay this amount: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Check"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "R"
        '
        'txtDraw
        '
        Me.txtDraw.Location = New System.Drawing.Point(27, 35)
        Me.txtDraw.Name = "txtDraw"
        Me.txtDraw.Size = New System.Drawing.Size(135, 20)
        Me.txtDraw.TabIndex = 5
        '
        'btnDraw
        '
        Me.btnDraw.Location = New System.Drawing.Point(184, 33)
        Me.btnDraw.Name = "btnDraw"
        Me.btnDraw.Size = New System.Drawing.Size(75, 23)
        Me.btnDraw.TabIndex = 8
        Me.btnDraw.Text = "Withdrawal"
        Me.btnDraw.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btnDraw)
        Me.Panel5.Controls.Add(Me.txtDraw)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Location = New System.Drawing.Point(12, 260)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(278, 76)
        Me.Panel5.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Withdrawal"
        '
        'dgvTrans
        '
        Me.dgvTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrans.Location = New System.Drawing.Point(277, 381)
        Me.dgvTrans.Name = "dgvTrans"
        Me.dgvTrans.Size = New System.Drawing.Size(438, 240)
        Me.dgvTrans.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 633)
        Me.Controls.Add(Me.dgvTrans)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.pnlCheck)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlCheck.ResumeLayout(False)
        Me.pnlCheck.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgvTrans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents chbAcc As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDeposit As Button
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnTrans As Button
    Friend WithEvents txtTrans As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lblAcc As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents pnlCheck As Panel
    Friend WithEvents btnCheck As Button
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPayAmount As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDraw As TextBox
    Friend WithEvents btnDraw As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvTrans As DataGridView
    Friend WithEvents transDate As DataGridViewTextBoxColumn
    Friend WithEvents typeTrans As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents balance As DataGridViewTextBoxColumn
    Friend WithEvents cmbTransAcc As ComboBox
End Class
