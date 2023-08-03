<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContactForm
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.rtxtMess = New System.Windows.Forms.RichTextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblName.Location = New System.Drawing.Point(39, 31)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 15)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "First Name"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Location = New System.Drawing.Point(305, 31)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(54, 15)
        Me.lblSurname.TabIndex = 1
        Me.lblSurname.Text = "Surname"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(39, 134)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(36, 15)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email"
        '
        'txtName
        '
        Me.txtName.ForeColor = System.Drawing.SystemColors.MenuText
        Me.txtName.Location = New System.Drawing.Point(41, 61)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(142, 23)
        Me.txtName.TabIndex = 3
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(305, 61)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(155, 23)
        Me.txtSurname.TabIndex = 4
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(41, 175)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(168, 23)
        Me.txtEmail.TabIndex = 5
        '
        'rtxtMess
        '
        Me.rtxtMess.Location = New System.Drawing.Point(41, 248)
        Me.rtxtMess.Name = "rtxtMess"
        Me.rtxtMess.Size = New System.Drawing.Size(329, 96)
        Me.rtxtMess.TabIndex = 6
        Me.rtxtMess.Text = "What are you looking for?"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(41, 397)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 41)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'frmContactForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 470)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.rtxtMess)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.lblName)
        Me.Name = "frmContactForm"
        Me.Text = "Contact Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents rtxtMess As RichTextBox
    Friend WithEvents btnSubmit As Button
End Class
