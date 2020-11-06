<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCHabilitarPaciente
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnRechazarPaciente = New Guna.UI.WinForms.GunaButton()
        Me.btnAceptarPaciente = New Guna.UI.WinForms.GunaButton()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(107, 48)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(118, 15)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Juan Perez Rodriguez"
        '
        'btnRechazarPaciente
        '
        Me.btnRechazarPaciente.AnimationHoverSpeed = 0.07!
        Me.btnRechazarPaciente.AnimationSpeed = 0.03!
        Me.btnRechazarPaciente.BackColor = System.Drawing.Color.Transparent
        Me.btnRechazarPaciente.BaseColor = System.Drawing.Color.Brown
        Me.btnRechazarPaciente.BorderColor = System.Drawing.Color.Black
        Me.btnRechazarPaciente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRechazarPaciente.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRechazarPaciente.FocusedColor = System.Drawing.Color.Empty
        Me.btnRechazarPaciente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRechazarPaciente.ForeColor = System.Drawing.Color.White
        Me.btnRechazarPaciente.Image = Nothing
        Me.btnRechazarPaciente.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRechazarPaciente.Location = New System.Drawing.Point(170, 76)
        Me.btnRechazarPaciente.Name = "btnRechazarPaciente"
        Me.btnRechazarPaciente.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRechazarPaciente.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRechazarPaciente.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRechazarPaciente.OnHoverImage = Nothing
        Me.btnRechazarPaciente.OnPressedColor = System.Drawing.Color.Black
        Me.btnRechazarPaciente.Size = New System.Drawing.Size(88, 22)
        Me.btnRechazarPaciente.TabIndex = 10
        Me.btnRechazarPaciente.Text = "Rechazar"
        Me.btnRechazarPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAceptarPaciente
        '
        Me.btnAceptarPaciente.AnimationHoverSpeed = 0.07!
        Me.btnAceptarPaciente.AnimationSpeed = 0.03!
        Me.btnAceptarPaciente.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptarPaciente.BaseColor = System.Drawing.Color.ForestGreen
        Me.btnAceptarPaciente.BorderColor = System.Drawing.Color.Black
        Me.btnAceptarPaciente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptarPaciente.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptarPaciente.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptarPaciente.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAceptarPaciente.ForeColor = System.Drawing.Color.White
        Me.btnAceptarPaciente.Image = Nothing
        Me.btnAceptarPaciente.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptarPaciente.Location = New System.Drawing.Point(75, 76)
        Me.btnAceptarPaciente.Name = "btnAceptarPaciente"
        Me.btnAceptarPaciente.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAceptarPaciente.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAceptarPaciente.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptarPaciente.OnHoverImage = Nothing
        Me.btnAceptarPaciente.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptarPaciente.Size = New System.Drawing.Size(88, 22)
        Me.btnAceptarPaciente.TabIndex = 9
        Me.btnAceptarPaciente.Text = "Aceptar"
        Me.btnAceptarPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.Color.White
        Me.lblCedula.Location = New System.Drawing.Point(124, 21)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(85, 20)
        Me.lblCedula.TabIndex = 8
        Me.lblCedula.Text = "5.298.615-5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(318, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        '
        'UCHabilitarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnRechazarPaciente)
        Me.Controls.Add(Me.btnAceptarPaciente)
        Me.Controls.Add(Me.lblCedula)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UCHabilitarPaciente"
        Me.Size = New System.Drawing.Size(315, 118)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents btnRechazarPaciente As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAceptarPaciente As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblCedula As Label
    Friend WithEvents Label1 As Label
End Class
