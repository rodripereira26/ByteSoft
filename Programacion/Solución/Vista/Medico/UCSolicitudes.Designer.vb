<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSolicitudes
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnAceptarChat = New Guna.UI.WinForms.GunaButton()
        Me.lblEdad = New System.Windows.Forms.Label()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnDiagnostico = New Guna.UI.WinForms.GunaButton()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(54, 20)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(159, 20)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Juan Perez Rodriguez"
        '
        'btnAceptarChat
        '
        Me.btnAceptarChat.Animated = True
        Me.btnAceptarChat.AnimationHoverSpeed = 0.07!
        Me.btnAceptarChat.AnimationSpeed = 0.03!
        Me.btnAceptarChat.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptarChat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAceptarChat.BorderColor = System.Drawing.Color.Black
        Me.btnAceptarChat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptarChat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptarChat.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptarChat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarChat.ForeColor = System.Drawing.Color.White
        Me.btnAceptarChat.Image = Nothing
        Me.btnAceptarChat.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptarChat.Location = New System.Drawing.Point(249, 11)
        Me.btnAceptarChat.Name = "btnAceptarChat"
        Me.btnAceptarChat.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAceptarChat.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAceptarChat.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptarChat.OnHoverImage = Nothing
        Me.btnAceptarChat.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptarChat.Radius = 10
        Me.btnAceptarChat.Size = New System.Drawing.Size(150, 39)
        Me.btnAceptarChat.TabIndex = 13
        Me.btnAceptarChat.Text = "Comenzar chat"
        Me.btnAceptarChat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblEdad
        '
        Me.lblEdad.AutoSize = True
        Me.lblEdad.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdad.ForeColor = System.Drawing.Color.White
        Me.lblEdad.Location = New System.Drawing.Point(54, 68)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(64, 20)
        Me.lblEdad.TabIndex = 16
        Me.lblEdad.Text = "65 años"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 12
        Me.GunaElipse1.TargetControl = Me
        '
        'btnDiagnostico
        '
        Me.btnDiagnostico.Animated = True
        Me.btnDiagnostico.AnimationHoverSpeed = 0.07!
        Me.btnDiagnostico.AnimationSpeed = 0.03!
        Me.btnDiagnostico.BackColor = System.Drawing.Color.Transparent
        Me.btnDiagnostico.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDiagnostico.BorderColor = System.Drawing.Color.Black
        Me.btnDiagnostico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDiagnostico.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDiagnostico.FocusedColor = System.Drawing.Color.Empty
        Me.btnDiagnostico.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiagnostico.ForeColor = System.Drawing.Color.White
        Me.btnDiagnostico.Image = Nothing
        Me.btnDiagnostico.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDiagnostico.Location = New System.Drawing.Point(249, 59)
        Me.btnDiagnostico.Name = "btnDiagnostico"
        Me.btnDiagnostico.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDiagnostico.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDiagnostico.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDiagnostico.OnHoverImage = Nothing
        Me.btnDiagnostico.OnPressedColor = System.Drawing.Color.Black
        Me.btnDiagnostico.Radius = 10
        Me.btnDiagnostico.Size = New System.Drawing.Size(150, 39)
        Me.btnDiagnostico.TabIndex = 17
        Me.btnDiagnostico.Text = "Ver Diagnóstico"
        Me.btnDiagnostico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UCSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Controls.Add(Me.btnDiagnostico)
        Me.Controls.Add(Me.lblEdad)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnAceptarChat)
        Me.Name = "UCSolicitudes"
        Me.Size = New System.Drawing.Size(419, 110)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents btnAceptarChat As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblEdad As Label
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnDiagnostico As Guna.UI.WinForms.GunaButton
End Class
