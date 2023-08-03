<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.lbDistances = New System.Windows.Forms.Label()
        Me.btnDistance = New System.Windows.Forms.Button()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(24, 314)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(163, 23)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create table"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnMore
        '
        Me.btnMore.Location = New System.Drawing.Point(24, 188)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(75, 23)
        Me.btnMore.TabIndex = 1
        Me.btnMore.Text = "More"
        Me.btnMore.UseVisualStyleBackColor = True
        '
        'lbDistances
        '
        Me.lbDistances.AutoSize = True
        Me.lbDistances.Location = New System.Drawing.Point(202, 195)
        Me.lbDistances.Name = "lbDistances"
        Me.lbDistances.Size = New System.Drawing.Size(0, 15)
        Me.lbDistances.TabIndex = 2
        '
        'btnDistance
        '
        Me.btnDistance.Location = New System.Drawing.Point(12, 37)
        Me.btnDistance.Name = "btnDistance"
        Me.btnDistance.Size = New System.Drawing.Size(75, 23)
        Me.btnDistance.TabIndex = 3
        Me.btnDistance.Text = "Display"
        Me.btnDistance.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(146, 37)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(100, 23)
        Me.txtValue.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.btnDistance)
        Me.Controls.Add(Me.lbDistances)
        Me.Controls.Add(Me.btnMore)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents btnMore As Button
    Friend WithEvents lbDistance As Label
    Friend WithEvents lbDistances As Label
    Friend WithEvents btnDistance As Button
    Friend WithEvents txtValue As TextBox
End Class
