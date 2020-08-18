<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mensaje
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.horaEnviado = New System.Windows.Forms.Label()
        Me.horaRecibido = New System.Windows.Forms.Label()
        Me.lbl_Enviado = New System.Windows.Forms.Label()
        Me.lbl_Recibido = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'horaEnviado
        '
        Me.horaEnviado.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.horaEnviado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaEnviado.Location = New System.Drawing.Point(0, 170)
        Me.horaEnviado.Name = "horaEnviado"
        Me.horaEnviado.Size = New System.Drawing.Size(764, 13)
        Me.horaEnviado.TabIndex = 3
        Me.horaEnviado.Text = "00:00"
        Me.horaEnviado.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.horaEnviado.Visible = False
        '
        'horaRecibido
        '
        Me.horaRecibido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.horaRecibido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaRecibido.Location = New System.Drawing.Point(0, 170)
        Me.horaRecibido.Name = "horaRecibido"
        Me.horaRecibido.Size = New System.Drawing.Size(39, 13)
        Me.horaRecibido.TabIndex = 4
        Me.horaRecibido.Text = "00:00"
        Me.horaRecibido.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.horaRecibido.Visible = False
        '
        'lbl_Enviado
        '
        Me.lbl_Enviado.AutoSize = True
        Me.lbl_Enviado.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.lbl_Enviado.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Enviado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Enviado.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Enviado.ForeColor = System.Drawing.Color.White
        Me.lbl_Enviado.Location = New System.Drawing.Point(631, 0)
        Me.lbl_Enviado.MaximumSize = New System.Drawing.Size(400, 0)
        Me.lbl_Enviado.Name = "lbl_Enviado"
        Me.lbl_Enviado.Padding = New System.Windows.Forms.Padding(10)
        Me.lbl_Enviado.Size = New System.Drawing.Size(133, 40)
        Me.lbl_Enviado.TabIndex = 7
        Me.lbl_Enviado.Text = "SAMPLE TEXT"
        '
        'lbl_Recibido
        '
        Me.lbl_Recibido.AutoSize = True
        Me.lbl_Recibido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_Recibido.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_Recibido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Recibido.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Recibido.ForeColor = System.Drawing.Color.White
        Me.lbl_Recibido.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Recibido.MaximumSize = New System.Drawing.Size(400, 0)
        Me.lbl_Recibido.Name = "lbl_Recibido"
        Me.lbl_Recibido.Padding = New System.Windows.Forms.Padding(10)
        Me.lbl_Recibido.Size = New System.Drawing.Size(133, 40)
        Me.lbl_Recibido.TabIndex = 8
        Me.lbl_Recibido.Text = "SAMPLE TEXT"
        '
        'Mensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(764, 183)
        Me.Controls.Add(Me.lbl_Recibido)
        Me.Controls.Add(Me.lbl_Enviado)
        Me.Controls.Add(Me.horaRecibido)
        Me.Controls.Add(Me.horaEnviado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mensaje"
        Me.Text = "SAMPLE TEXT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents horaEnviado As Label
    Friend WithEvents horaRecibido As Label
    Friend WithEvents lbl_Enviado As Label
    Friend WithEvents lbl_Recibido As Label
End Class
