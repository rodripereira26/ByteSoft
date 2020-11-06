<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCHabilitarGestor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnRechazar = New Guna.UI.WinForms.GunaButton()
        Me.btnAceptar = New Guna.UI.WinForms.GunaButton()
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
        Me.lblNombre.TabIndex = 18
        Me.lblNombre.Text = "Juan Perez Rodriguez"
        '
        'btnRechazar
        '
        Me.btnRechazar.AnimationHoverSpeed = 0.07!
        Me.btnRechazar.AnimationSpeed = 0.03!
        Me.btnRechazar.BackColor = System.Drawing.Color.Transparent
        Me.btnRechazar.BaseColor = System.Drawing.Color.Brown
        Me.btnRechazar.BorderColor = System.Drawing.Color.Black
        Me.btnRechazar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRechazar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRechazar.FocusedColor = System.Drawing.Color.Empty
        Me.btnRechazar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRechazar.ForeColor = System.Drawing.Color.White
        Me.btnRechazar.Image = Nothing
        Me.btnRechazar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRechazar.Location = New System.Drawing.Point(170, 76)
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnRechazar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRechazar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRechazar.OnHoverImage = Nothing
        Me.btnRechazar.OnPressedColor = System.Drawing.Color.Black
        Me.btnRechazar.Size = New System.Drawing.Size(88, 22)
        Me.btnRechazar.TabIndex = 17
        Me.btnRechazar.Text = "Rechazar"
        Me.btnRechazar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAceptar
        '
        Me.btnAceptar.AnimationHoverSpeed = 0.07!
        Me.btnAceptar.AnimationSpeed = 0.03!
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.BaseColor = System.Drawing.Color.ForestGreen
        Me.btnAceptar.BorderColor = System.Drawing.Color.Black
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptar.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Image = Nothing
        Me.btnAceptar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptar.Location = New System.Drawing.Point(75, 76)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAceptar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAceptar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptar.OnHoverImage = Nothing
        Me.btnAceptar.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptar.Size = New System.Drawing.Size(88, 22)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.ForeColor = System.Drawing.Color.White
        Me.lblCedula.Location = New System.Drawing.Point(124, 21)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(85, 20)
        Me.lblCedula.TabIndex = 15
        Me.lblCedula.Text = "5.298.615-5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(322, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Label1"
        '
        'UCHabilitarGestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnRechazar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lblCedula)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UCHabilitarGestor"
        Me.Size = New System.Drawing.Size(315, 118)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnRechazar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAceptar As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblCedula As Label
    Friend WithEvents Label1 As Label
End Class
