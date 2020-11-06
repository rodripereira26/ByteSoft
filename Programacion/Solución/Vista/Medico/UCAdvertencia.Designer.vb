<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAdvertencia
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
        Me.lblMensajeAdv = New System.Windows.Forms.Label()
        Me.lblTituloAdv = New System.Windows.Forms.Label()
        Me.btnCambiarPass = New Guna.UI.WinForms.GunaButton()
        Me.pbAdvertencia = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.pbAdvertencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMensajeAdv
        '
        Me.lblMensajeAdv.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensajeAdv.ForeColor = System.Drawing.Color.White
        Me.lblMensajeAdv.Location = New System.Drawing.Point(92, 93)
        Me.lblMensajeAdv.Name = "lblMensajeAdv"
        Me.lblMensajeAdv.Size = New System.Drawing.Size(338, 84)
        Me.lblMensajeAdv.TabIndex = 205
        Me.lblMensajeAdv.Text = "No has cambiado tu constraseña desde que fuiste registreado, por razones de segur" &
    "idad, debes cambiarla"
        '
        'lblTituloAdv
        '
        Me.lblTituloAdv.AutoSize = True
        Me.lblTituloAdv.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloAdv.ForeColor = System.Drawing.Color.White
        Me.lblTituloAdv.Location = New System.Drawing.Point(37, 37)
        Me.lblTituloAdv.Name = "lblTituloAdv"
        Me.lblTituloAdv.Size = New System.Drawing.Size(141, 32)
        Me.lblTituloAdv.TabIndex = 203
        Me.lblTituloAdv.Text = "Advertencia"
        '
        'btnCambiarPass
        '
        Me.btnCambiarPass.Animated = True
        Me.btnCambiarPass.AnimationHoverSpeed = 0.07!
        Me.btnCambiarPass.AnimationSpeed = 0.03!
        Me.btnCambiarPass.BackColor = System.Drawing.Color.Transparent
        Me.btnCambiarPass.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnCambiarPass.BorderColor = System.Drawing.Color.Black
        Me.btnCambiarPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiarPass.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCambiarPass.FocusedColor = System.Drawing.Color.Empty
        Me.btnCambiarPass.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCambiarPass.Image = Nothing
        Me.btnCambiarPass.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCambiarPass.Location = New System.Drawing.Point(185, 187)
        Me.btnCambiarPass.Name = "btnCambiarPass"
        Me.btnCambiarPass.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnCambiarPass.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCambiarPass.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCambiarPass.OnHoverImage = Nothing
        Me.btnCambiarPass.OnPressedColor = System.Drawing.Color.Black
        Me.btnCambiarPass.Radius = 10
        Me.btnCambiarPass.Size = New System.Drawing.Size(199, 42)
        Me.btnCambiarPass.TabIndex = 202
        Me.btnCambiarPass.Text = "ir a cambiar contraseña"
        Me.btnCambiarPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pbAdvertencia
        '
        Me.pbAdvertencia.BackColor = System.Drawing.Color.Transparent
        Me.pbAdvertencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAdvertencia.ForeColor = System.Drawing.Color.IndianRed
        Me.pbAdvertencia.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle
        Me.pbAdvertencia.IconColor = System.Drawing.Color.IndianRed
        Me.pbAdvertencia.IconSize = 73
        Me.pbAdvertencia.Location = New System.Drawing.Point(467, 15)
        Me.pbAdvertencia.Name = "pbAdvertencia"
        Me.pbAdvertencia.Size = New System.Drawing.Size(73, 76)
        Me.pbAdvertencia.TabIndex = 204
        Me.pbAdvertencia.TabStop = False
        '
        'UCAdvertencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblMensajeAdv)
        Me.Controls.Add(Me.pbAdvertencia)
        Me.Controls.Add(Me.lblTituloAdv)
        Me.Controls.Add(Me.btnCambiarPass)
        Me.Name = "UCAdvertencia"
        Me.Size = New System.Drawing.Size(551, 248)
        CType(Me.pbAdvertencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMensajeAdv As Label
    Friend WithEvents pbAdvertencia As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblTituloAdv As Label
    Friend WithEvents btnCambiarPass As Guna.UI.WinForms.GunaButton
End Class
