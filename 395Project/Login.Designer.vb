<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.components = New System.ComponentModel.Container()
        Me.ID = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
<<<<<<< HEAD
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.EMPLOGIN = New System.Windows.Forms.Button()
        Me.CMPT395DataSet = New WindowsApp1.CMPT395DataSet()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New WindowsApp1.CMPT395DataSetTableAdapters.LoginTableAdapter()
        CType(Me.CMPT395DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
=======
        Me.idbox = New System.Windows.Forms.TextBox()
        Me.passwordbox = New System.Windows.Forms.TextBox()
        Me.EMPLOGIN = New System.Windows.Forms.Button()
>>>>>>> parent of 4adcb0b... update layout and button name
        Me.SuspendLayout()
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(94, 68)
        Me.ID.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(21, 17)
        Me.ID.TabIndex = 0
        Me.ID.Text = "ID"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.Location = New System.Drawing.Point(66, 130)
        Me.Password.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(69, 17)
        Me.Password.TabIndex = 1
        Me.Password.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "user_name", True))
        Me.TextBox1.Location = New System.Drawing.Point(156, 66)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(99, 22)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "password", True))
        Me.TextBox2.Location = New System.Drawing.Point(156, 128)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(99, 22)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'EMPLOGIN
        '
<<<<<<< HEAD
        Me.EMPLOGIN.Location = New System.Drawing.Point(165, 186)
        Me.EMPLOGIN.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.EMPLOGIN.Name = "EMPLOGIN"
        Me.EMPLOGIN.Size = New System.Drawing.Size(79, 29)
        Me.EMPLOGIN.TabIndex = 5
        Me.EMPLOGIN.Text = "Login"
        Me.EMPLOGIN.UseVisualStyleBackColor = True
        '
        'CMPT395DataSet
        '
        Me.CMPT395DataSet.DataSetName = "CMPT395DataSet"
        Me.CMPT395DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.CMPT395DataSet
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
=======
        Me.EMPLOGIN.Location = New System.Drawing.Point(227, 244)
        Me.EMPLOGIN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.EMPLOGIN.Name = "EMPLOGIN"
        Me.EMPLOGIN.Size = New System.Drawing.Size(108, 38)
        Me.EMPLOGIN.TabIndex = 5
        Me.EMPLOGIN.Text = "Login"
        Me.EMPLOGIN.UseVisualStyleBackColor = True
>>>>>>> parent of 4adcb0b... update layout and button name
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(582, 335)
        Me.Controls.Add(Me.EMPLOGIN)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
=======
        Me.ClientSize = New System.Drawing.Size(520, 351)
        Me.Controls.Add(Me.EMPLOGIN)
        Me.Controls.Add(Me.passwordbox)
        Me.Controls.Add(Me.idbox)
>>>>>>> parent of 4adcb0b... update layout and button name
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.ID)
        Me.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Name = "login"
        Me.Text = "Login"
        CType(Me.CMPT395DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ID As Label
    Friend WithEvents Password As Label
<<<<<<< HEAD
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents EMPLOGIN As Button
    Friend WithEvents CMPT395DataSet As CMPT395DataSet
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents LoginTableAdapter As CMPT395DataSetTableAdapters.LoginTableAdapter
=======
    Friend WithEvents idbox As TextBox
    Friend WithEvents passwordbox As TextBox
    Friend WithEvents EMPLOGIN As Button
>>>>>>> parent of 4adcb0b... update layout and button name
End Class
