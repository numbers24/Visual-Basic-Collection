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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Read = New System.Windows.Forms.Button()
        Me.Right = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SmdWriter = New System.Windows.Forms.SaveFileDialog()
        Me.txtWrite = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 100)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 149)
        Me.TextBox1.TabIndex = 0
        '
        'Read
        '
        Me.Read.Location = New System.Drawing.Point(12, 52)
        Me.Read.Name = "Read"
        Me.Read.Size = New System.Drawing.Size(75, 23)
        Me.Read.TabIndex = 1
        Me.Read.Text = "Read"
        Me.Read.UseVisualStyleBackColor = True
        '
        'Right
        '
        Me.Right.Location = New System.Drawing.Point(102, 52)
        Me.Right.Name = "Right"
        Me.Right.Size = New System.Drawing.Size(75, 23)
        Me.Right.TabIndex = 2
        Me.Right.Text = "Right"
        Me.Right.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(197, 52)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SmdWriter
        '
        '
        'txtWrite
        '
        Me.txtWrite.Location = New System.Drawing.Point(519, 91)
        Me.txtWrite.Multiline = True
        Me.txtWrite.Name = "txtWrite"
        Me.txtWrite.Size = New System.Drawing.Size(232, 158)
        Me.txtWrite.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 261)
        Me.Controls.Add(Me.txtWrite)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Right)
        Me.Controls.Add(Me.Read)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Read As Button
    Friend WithEvents Right As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents SmdWriter As SaveFileDialog
    Friend WithEvents txtWrite As TextBox
End Class
