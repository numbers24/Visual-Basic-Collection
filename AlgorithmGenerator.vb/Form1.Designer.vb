<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXP
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
        Me.txtEnemyValue = New System.Windows.Forms.TextBox()
        Me.txtWeaponValue = New System.Windows.Forms.TextBox()
        Me.prgXP = New System.Windows.Forms.ProgressBar()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.txtLevel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWeaponValue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblXP = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblXPG = New System.Windows.Forms.Label()
        Me.txtYourLevel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtEnemyValue
        '
        Me.txtEnemyValue.Location = New System.Drawing.Point(12, 52)
        Me.txtEnemyValue.Name = "txtEnemyValue"
        Me.txtEnemyValue.Size = New System.Drawing.Size(100, 20)
        Me.txtEnemyValue.TabIndex = 0
        '
        'txtWeaponValue
        '
        Me.txtWeaponValue.Location = New System.Drawing.Point(12, 102)
        Me.txtWeaponValue.Name = "txtWeaponValue"
        Me.txtWeaponValue.Size = New System.Drawing.Size(100, 20)
        Me.txtWeaponValue.TabIndex = 1
        '
        'prgXP
        '
        Me.prgXP.Location = New System.Drawing.Point(485, 276)
        Me.prgXP.Maximum = 100000
        Me.prgXP.Name = "prgXP"
        Me.prgXP.Size = New System.Drawing.Size(389, 23)
        Me.prgXP.TabIndex = 2
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(37, 227)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 62)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'txtLevel
        '
        Me.txtLevel.Location = New System.Drawing.Point(12, 148)
        Me.txtLevel.Name = "txtLevel"
        Me.txtLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtLevel.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(147, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enemy Level"
        '
        'lblWeaponValue
        '
        Me.lblWeaponValue.AutoSize = True
        Me.lblWeaponValue.Location = New System.Drawing.Point(147, 109)
        Me.lblWeaponValue.Name = "lblWeaponValue"
        Me.lblWeaponValue.Size = New System.Drawing.Size(113, 13)
        Me.lblWeaponValue.TabIndex = 6
        Me.lblWeaponValue.Text = "Enemy Weapon Value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Enemy Value"
        '
        'lblXP
        '
        Me.lblXP.AutoSize = True
        Me.lblXP.Location = New System.Drawing.Point(482, 252)
        Me.lblXP.Name = "lblXP"
        Me.lblXP.Size = New System.Drawing.Size(39, 13)
        Me.lblXP.TabIndex = 8
        Me.lblXP.Text = "Label2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(686, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 108)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblXPG
        '
        Me.lblXPG.AutoSize = True
        Me.lblXPG.Location = New System.Drawing.Point(482, 227)
        Me.lblXPG.Name = "lblXPG"
        Me.lblXPG.Size = New System.Drawing.Size(39, 13)
        Me.lblXPG.TabIndex = 10
        Me.lblXPG.Text = "Label2"
        '
        'txtYourLevel
        '
        Me.txtYourLevel.Location = New System.Drawing.Point(12, 187)
        Me.txtYourLevel.Name = "txtYourLevel"
        Me.txtYourLevel.Size = New System.Drawing.Size(100, 20)
        Me.txtYourLevel.TabIndex = 11
        '
        'frmXP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 328)
        Me.Controls.Add(Me.txtYourLevel)
        Me.Controls.Add(Me.lblXPG)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblXP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblWeaponValue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLevel)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.prgXP)
        Me.Controls.Add(Me.txtWeaponValue)
        Me.Controls.Add(Me.txtEnemyValue)
        Me.Name = "frmXP"
        Me.Text = "XP Generator Prototype"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEnemyValue As TextBox
    Friend WithEvents txtWeaponValue As TextBox
    Friend WithEvents prgXP As ProgressBar
    Friend WithEvents btnCalc As Button
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblWeaponValue As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblXP As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblXPG As Label
    Friend WithEvents txtYourLevel As TextBox
End Class
