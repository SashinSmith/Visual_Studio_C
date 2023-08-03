<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.rbFree = New System.Windows.Forms.RadioButton()
        Me.rbLow = New System.Windows.Forms.RadioButton()
        Me.rbReg = New System.Windows.Forms.RadioButton()
        Me.rbVeg = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'rbFree
        '
        Me.rbFree.AutoSize = True
        Me.rbFree.Location = New System.Drawing.Point(12, 12)
        Me.rbFree.Name = "rbFree"
        Me.rbFree.Size = New System.Drawing.Size(89, 19)
        Me.rbFree.TabIndex = 0
        Me.rbFree.Text = "Unoccupied"
        Me.rbFree.UseVisualStyleBackColor = True
        '
        'rbLow
        '
        Me.rbLow.AutoSize = True
        Me.rbLow.Location = New System.Drawing.Point(12, 51)
        Me.rbLow.Name = "rbLow"
        Me.rbLow.Size = New System.Drawing.Size(87, 19)
        Me.rbLow.TabIndex = 1
        Me.rbLow.Text = "Low Calorie"
        Me.rbLow.UseVisualStyleBackColor = True
        '
        'rbReg
        '
        Me.rbReg.AutoSize = True
        Me.rbReg.Location = New System.Drawing.Point(171, 12)
        Me.rbReg.Name = "rbReg"
        Me.rbReg.Size = New System.Drawing.Size(65, 19)
        Me.rbReg.TabIndex = 2
        Me.rbReg.Text = "Regular"
        Me.rbReg.UseVisualStyleBackColor = True
        '
        'rbVeg
        '
        Me.rbVeg.AutoSize = True
        Me.rbVeg.Location = New System.Drawing.Point(171, 51)
        Me.rbVeg.Name = "rbVeg"
        Me.rbVeg.Size = New System.Drawing.Size(80, 19)
        Me.rbVeg.TabIndex = 3
        Me.rbVeg.Text = "Vegetarian"
        Me.rbVeg.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 88)
        Me.Controls.Add(Me.rbVeg)
        Me.Controls.Add(Me.rbReg)
        Me.Controls.Add(Me.rbLow)
        Me.Controls.Add(Me.rbFree)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbFree As RadioButton
    Friend WithEvents rbLow As RadioButton
    Friend WithEvents rbReg As RadioButton
    Friend WithEvents rbVeg As RadioButton
End Class
