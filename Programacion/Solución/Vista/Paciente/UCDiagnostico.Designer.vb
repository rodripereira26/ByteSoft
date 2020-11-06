<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDiagnostico
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblDescipcion = New System.Windows.Forms.Label()
        Me.lblRecomendaciones = New System.Windows.Forms.Label()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 16
        Me.GunaElipse1.TargetControl = Me
        '
        'lblNom
        '
        Me.lblNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.Silver
        Me.lblNom.Location = New System.Drawing.Point(42, 24)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(200, 75)
        Me.lblNom.TabIndex = 0
        Me.lblNom.Text = "Label1"
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDescipcion
        '
        Me.lblDescipcion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescipcion.ForeColor = System.Drawing.Color.Silver
        Me.lblDescipcion.Location = New System.Drawing.Point(18, 115)
        Me.lblDescipcion.Name = "lblDescipcion"
        Me.lblDescipcion.Size = New System.Drawing.Size(224, 73)
        Me.lblDescipcion.TabIndex = 1
        Me.lblDescipcion.Text = "Label2"
        '
        'lblRecomendaciones
        '
        Me.lblRecomendaciones.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecomendaciones.ForeColor = System.Drawing.Color.Silver
        Me.lblRecomendaciones.Location = New System.Drawing.Point(18, 221)
        Me.lblRecomendaciones.Name = "lblRecomendaciones"
        Me.lblRecomendaciones.Size = New System.Drawing.Size(224, 73)
        Me.lblRecomendaciones.TabIndex = 2
        Me.lblRecomendaciones.Text = "Label3"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(58, 352)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton1.TabIndex = 11
        Me.GunaButton1.Text = "VER SÍNTOMAS"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UCDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.lblRecomendaciones)
        Me.Controls.Add(Me.lblDescipcion)
        Me.Controls.Add(Me.lblNom)
        Me.Name = "UCDiagnostico"
        Me.Size = New System.Drawing.Size(264, 442)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblNom As Label
    Friend WithEvents lblRecomendaciones As Label
    Friend WithEvents lblDescipcion As Label
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
End Class
