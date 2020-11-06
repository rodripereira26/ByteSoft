<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCMensaje
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
        Me.lbl_Recibido = New System.Windows.Forms.Label()
        Me.lbl_Enviado = New System.Windows.Forms.Label()
        Me.horaEnviado = New System.Windows.Forms.Label()
        Me.horaRecibido = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Recibido
        '
        Me.lbl_Recibido.AutoSize = True
        Me.lbl_Recibido.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.lbl_Recibido.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_Recibido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Recibido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Recibido.ForeColor = System.Drawing.Color.White
        Me.lbl_Recibido.Location = New System.Drawing.Point(20, 4)
        Me.lbl_Recibido.MaximumSize = New System.Drawing.Size(400, 0)
        Me.lbl_Recibido.Name = "lbl_Recibido"
        Me.lbl_Recibido.Padding = New System.Windows.Forms.Padding(10)
        Me.lbl_Recibido.Size = New System.Drawing.Size(125, 41)
        Me.lbl_Recibido.TabIndex = 12
        Me.lbl_Recibido.Text = "SAMPLE TEXT"
        '
        'lbl_Enviado
        '
        Me.lbl_Enviado.AutoSize = True
        Me.lbl_Enviado.BackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_Enviado.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_Enviado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Enviado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Enviado.ForeColor = System.Drawing.Color.White
        Me.lbl_Enviado.Location = New System.Drawing.Point(619, 4)
        Me.lbl_Enviado.MaximumSize = New System.Drawing.Size(400, 0)
        Me.lbl_Enviado.Name = "lbl_Enviado"
        Me.lbl_Enviado.Padding = New System.Windows.Forms.Padding(10)
        Me.lbl_Enviado.Size = New System.Drawing.Size(125, 41)
        Me.lbl_Enviado.TabIndex = 11
        Me.lbl_Enviado.Text = "SAMPLE TEXT"
        '
        'horaEnviado
        '
        Me.horaEnviado.AutoSize = True
        Me.horaEnviado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaEnviado.ForeColor = System.Drawing.Color.White
        Me.horaEnviado.Location = New System.Drawing.Point(556, 13)
        Me.horaEnviado.Name = "horaEnviado"
        Me.horaEnviado.Size = New System.Drawing.Size(44, 20)
        Me.horaEnviado.TabIndex = 9
        Me.horaEnviado.Text = "00:00"
        Me.horaEnviado.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.horaEnviado.Visible = False
        '
        'horaRecibido
        '
        Me.horaRecibido.AutoSize = True
        Me.horaRecibido.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horaRecibido.ForeColor = System.Drawing.Color.White
        Me.horaRecibido.Location = New System.Drawing.Point(163, 13)
        Me.horaRecibido.Name = "horaRecibido"
        Me.horaRecibido.Size = New System.Drawing.Size(44, 20)
        Me.horaRecibido.TabIndex = 10
        Me.horaRecibido.Text = "00:00"
        Me.horaRecibido.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.horaRecibido.Visible = False
        '
        'UCMensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.lbl_Recibido)
        Me.Controls.Add(Me.lbl_Enviado)
        Me.Controls.Add(Me.horaRecibido)
        Me.Controls.Add(Me.horaEnviado)
        Me.Name = "UCMensaje"
        Me.Padding = New System.Windows.Forms.Padding(20, 4, 20, 4)
        Me.Size = New System.Drawing.Size(764, 46)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Recibido As Label
    Friend WithEvents lbl_Enviado As Label
    Friend WithEvents horaEnviado As Label
    Friend WithEvents horaRecibido As Label
End Class
