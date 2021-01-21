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
        Me.Button1 = New System.Windows.Forms.Button
        Me.TR1 = New System.Windows.Forms.TextBox
        Me.D1 = New System.Windows.Forms.DateTimePicker
        Me.D2 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.EPO = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DIE = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TR2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TR3 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(423, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 74)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ΕΚΤΥΠΩΣΗ ΑΠΟΔΕΙΞΗΣ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TR1
        '
        Me.TR1.Location = New System.Drawing.Point(256, 270)
        Me.TR1.Name = "TR1"
        Me.TR1.Size = New System.Drawing.Size(100, 20)
        Me.TR1.TabIndex = 5
        '
        'D1
        '
        Me.D1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.D1.Location = New System.Drawing.Point(121, 188)
        Me.D1.Name = "D1"
        Me.D1.Size = New System.Drawing.Size(106, 20)
        Me.D1.TabIndex = 3
        '
        'D2
        '
        Me.D2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.D2.Location = New System.Drawing.Point(423, 188)
        Me.D2.Name = "D2"
        Me.D2.Size = New System.Drawing.Size(106, 20)
        Me.D2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "ΑΠΟ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(420, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ΕΩΣ"
        '
        'EPO
        '
        Me.EPO.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.EPO.Location = New System.Drawing.Point(127, 35)
        Me.EPO.MaxLength = 24
        Me.EPO.Name = "EPO"
        Me.EPO.Size = New System.Drawing.Size(243, 26)
        Me.EPO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ΜΕΤΡΗΤΑ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "ΕΠΩΝΥΜΟ ΟΝΟΜΑ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ΔΙΕΥΘΥΝΣΗ"
        '
        'DIE
        '
        Me.DIE.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DIE.Location = New System.Drawing.Point(127, 104)
        Me.DIE.MaxLength = 24
        Me.DIE.Name = "DIE"
        Me.DIE.Size = New System.Drawing.Size(243, 26)
        Me.DIE.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ΚΑΡΤΑ"
        '
        'TR2
        '
        Me.TR2.Location = New System.Drawing.Point(256, 312)
        Me.TR2.Name = "TR2"
        Me.TR2.Size = New System.Drawing.Size(100, 20)
        Me.TR2.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(124, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ΑΛΛΟ"
        '
        'TR3
        '
        Me.TR3.Location = New System.Drawing.Point(256, 359)
        Me.TR3.Name = "TR3"
        Me.TR3.Size = New System.Drawing.Size(100, 20)
        Me.TR3.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 553)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TR3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TR2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DIE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EPO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.D2)
        Me.Controls.Add(Me.D1)
        Me.Controls.Add(Me.TR1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TR1 As System.Windows.Forms.TextBox
    Friend WithEvents D1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents D2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents EPO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DIE As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TR2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TR3 As System.Windows.Forms.TextBox

End Class
