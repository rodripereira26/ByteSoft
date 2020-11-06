<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCObservacion
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnEnviarObservacion = New Guna.UI.WinForms.GunaButton()
        Me.GunaTextBox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.lblDescPatObs = New System.Windows.Forms.Label()
        Me.lblObservacion = New System.Windows.Forms.Label()
        Me.txtObservacion = New Guna.UI.WinForms.GunaTextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCantRec = New System.Windows.Forms.Label()
        Me.lblCantDesc = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnviarObservacion
        '
        Me.btnEnviarObservacion.Animated = True
        Me.btnEnviarObservacion.AnimationHoverSpeed = 0.07!
        Me.btnEnviarObservacion.AnimationSpeed = 0.03!
        Me.btnEnviarObservacion.BackColor = System.Drawing.Color.Transparent
        Me.btnEnviarObservacion.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnEnviarObservacion.BorderColor = System.Drawing.Color.Black
        Me.btnEnviarObservacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviarObservacion.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEnviarObservacion.FocusedColor = System.Drawing.Color.Empty
        Me.btnEnviarObservacion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEnviarObservacion.Image = Nothing
        Me.btnEnviarObservacion.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEnviarObservacion.Location = New System.Drawing.Point(333, 361)
        Me.btnEnviarObservacion.Name = "btnEnviarObservacion"
        Me.btnEnviarObservacion.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnEnviarObservacion.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEnviarObservacion.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEnviarObservacion.OnHoverImage = Nothing
        Me.btnEnviarObservacion.OnPressedColor = System.Drawing.Color.Black
        Me.btnEnviarObservacion.Radius = 10
        Me.btnEnviarObservacion.Size = New System.Drawing.Size(199, 42)
        Me.btnEnviarObservacion.TabIndex = 182
        Me.btnEnviarObservacion.Text = "Enviar observación"
        Me.btnEnviarObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaTextBox1
        '
        Me.GunaTextBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GunaTextBox1.BorderColor = System.Drawing.Color.Snow
        Me.GunaTextBox1.BorderSize = 0
        Me.GunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextBox1.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaTextBox1.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GunaTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaTextBox1.ForeColor = System.Drawing.Color.Silver
        Me.GunaTextBox1.Location = New System.Drawing.Point(146, 294)
        Me.GunaTextBox1.MaxLength = 30
        Me.GunaTextBox1.Name = "GunaTextBox1"
        Me.GunaTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextBox1.Size = New System.Drawing.Size(572, 43)
        Me.GunaTextBox1.TabIndex = 183
        '
        'lblDescPatObs
        '
        Me.lblDescPatObs.AutoSize = True
        Me.lblDescPatObs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPatObs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescPatObs.Location = New System.Drawing.Point(143, 255)
        Me.lblDescPatObs.Name = "lblDescPatObs"
        Me.lblDescPatObs.Size = New System.Drawing.Size(84, 21)
        Me.lblDescPatObs.TabIndex = 184
        Me.lblDescPatObs.Text = "Derivación"
        '
        'lblObservacion
        '
        Me.lblObservacion.AutoSize = True
        Me.lblObservacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblObservacion.Location = New System.Drawing.Point(143, 45)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(97, 21)
        Me.lblObservacion.TabIndex = 185
        Me.lblObservacion.Text = "Observación"
        '
        'txtObservacion
        '
        Me.txtObservacion.BaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtObservacion.BorderColor = System.Drawing.Color.Snow
        Me.txtObservacion.BorderSize = 0
        Me.txtObservacion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtObservacion.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.txtObservacion.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtObservacion.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtObservacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ForeColor = System.Drawing.Color.Silver
        Me.txtObservacion.Location = New System.Drawing.Point(147, 80)
        Me.txtObservacion.MaxLength = 60
        Me.txtObservacion.MultiLine = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservacion.Size = New System.Drawing.Size(572, 159)
        Me.txtObservacion.TabIndex = 186
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(753, 396)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 21)
        Me.lblFecha.TabIndex = 187
        '
        'lblCantRec
        '
        Me.lblCantRec.AutoSize = True
        Me.lblCantRec.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantRec.ForeColor = System.Drawing.Color.Silver
        Me.lblCantRec.Location = New System.Drawing.Point(685, 274)
        Me.lblCantRec.Name = "lblCantRec"
        Me.lblCantRec.Size = New System.Drawing.Size(34, 17)
        Me.lblCantRec.TabIndex = 198
        Me.lblCantRec.Text = "0/30"
        '
        'lblCantDesc
        '
        Me.lblCantDesc.AutoSize = True
        Me.lblCantDesc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantDesc.ForeColor = System.Drawing.Color.Silver
        Me.lblCantDesc.Location = New System.Drawing.Point(678, 49)
        Me.lblCantDesc.Name = "lblCantDesc"
        Me.lblCantDesc.Size = New System.Drawing.Size(34, 17)
        Me.lblCantDesc.TabIndex = 197
        Me.lblCantDesc.Text = "0/60"
        '
        'UCObservacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblCantRec)
        Me.Controls.Add(Me.lblCantDesc)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.lblObservacion)
        Me.Controls.Add(Me.lblDescPatObs)
        Me.Controls.Add(Me.GunaTextBox1)
        Me.Controls.Add(Me.btnEnviarObservacion)
        Me.Name = "UCObservacion"
        Me.Size = New System.Drawing.Size(864, 435)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnviarObservacion As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaTextBox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblDescPatObs As Label
    Friend WithEvents lblObservacion As Label
    Friend WithEvents txtObservacion As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblCantRec As Label
    Friend WithEvents lblCantDesc As Label
End Class
