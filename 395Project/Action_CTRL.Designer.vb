<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Action_CTRL
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Employers = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Constructors = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Employers
        '
        Me.Employers.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Employers.Location = New System.Drawing.Point(138, 147)
=======
        Me.Employers.Location = New System.Drawing.Point(155, 147)
>>>>>>> parent of 4adcb0b... update layout and button name
        Me.Employers.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Employers.Name = "Employers"
        Me.Employers.Size = New System.Drawing.Size(196, 38)
        Me.Employers.TabIndex = 3
        Me.Employers.Text = "Employers Info"
        Me.Employers.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(39, 32)
        Me.Button4.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 38)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Sign Out"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(678, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "manager name"
        '
        'Constructors
        '
        Me.Constructors.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
<<<<<<< HEAD
        Me.Constructors.Location = New System.Drawing.Point(138, 214)
=======
        Me.Constructors.Location = New System.Drawing.Point(155, 214)
>>>>>>> parent of 4adcb0b... update layout and button name
        Me.Constructors.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Constructors.Name = "Constructors"
        Me.Constructors.Size = New System.Drawing.Size(196, 38)
        Me.Constructors.TabIndex = 8
        Me.Constructors.Text = "Constructors Info"
        Me.Constructors.UseVisualStyleBackColor = True
        '
        'Action_CTRL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(884, 456)
=======
        Me.ClientSize = New System.Drawing.Size(497, 456)
>>>>>>> parent of 4adcb0b... update layout and button name
        Me.Controls.Add(Me.Constructors)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Employers)
        Me.Margin = New System.Windows.Forms.Padding(6, 4, 6, 4)
        Me.Name = "Action_CTRL"
        Me.Text = "EmployeeAction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Employers As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Constructors As Button
End Class
