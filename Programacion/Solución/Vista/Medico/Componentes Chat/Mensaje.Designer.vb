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
        Me.imgRecibido = New System.Windows.Forms.PictureBox()
        Me.lbl_Mensaje = New System.Windows.Forms.Label()
        Me.horaEnviado = New System.Windows.Forms.Label()
        Me.horaRecibido = New System.Windows.Forms.Label()
        Me.colorRecibido = New System.Windows.Forms.Panel()
        Me.colorEnviado = New System.Windows.Forms.Panel()
        CType(Me.imgRecibido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgRecibido
        '
        Me.imgRecibido.Location = New System.Drawing.Point(10, 8)
        Me.imgRecibido.Name = "imgRecibido"
        Me.imgRecibido.Size = New System.Drawing.Size(25, 25)
        Me.imgRecibido.TabIndex = 0
        Me.imgRecibido.TabStop = False
        '
        'lbl_Mensaje
        '
        Me.lbl_Mensaje.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Mensaje.AutoEllipsis = True
        Me.lbl_Mensaje.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Mensaje.Location = New System.Drawing.Point(39, 9)
        Me.lbl_Mensaje.Name = "lbl_Mensaje"
        Me.lbl_Mensaje.Size = New System.Drawing.Size(303, 28)
        Me.lbl_Mensaje.TabIndex = 2
        Me.lbl_Mensaje.Text = "SAMPLE TEXT"
        '
        'horaEnviado
        '
        Me.horaEnviado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.horaEnviado.Location = New System.Drawing.Point(335, 41)
        Me.horaEnviado.Name = "horaEnviado"
        Me.horaEnviado.Size = New System.Drawing.Size(39, 13)
        Me.horaEnviado.TabIndex = 3
        Me.horaEnviado.Text = "00:00"
        Me.horaEnviado.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.horaEnviado.Visible = False
        '
        'horaRecibido
        '
        Me.horaRecibido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.horaRecibido.Location = New System.Drawing.Point(4, 41)
        Me.horaRecibido.Name = "horaRecibido"
        Me.horaRecibido.Size = New System.Drawing.Size(39, 13)
        Me.horaRecibido.TabIndex = 4
        Me.horaRecibido.Text = "00:00"
        Me.horaRecibido.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'colorRecibido
        '
        Me.colorRecibido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.colorRecibido.BackColor = System.Drawing.SystemColors.ControlDark
        Me.colorRecibido.Location = New System.Drawing.Point(7, 6)
        Me.colorRecibido.Name = "colorRecibido"
        Me.colorRecibido.Size = New System.Drawing.Size(338, 32)
        Me.colorRecibido.TabIndex = 5
        '
        'colorEnviado
        '
        Me.colorEnviado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.colorEnviado.BackColor = System.Drawing.Color.LightSeaGreen
        Me.colorEnviado.Location = New System.Drawing.Point(36, 7)
        Me.colorEnviado.Name = "colorEnviado"
        Me.colorEnviado.Size = New System.Drawing.Size(338, 31)
        Me.colorEnviado.TabIndex = 6
        '
        'Mensaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(375, 60)
        Me.Controls.Add(Me.lbl_Mensaje)
        Me.Controls.Add(Me.horaRecibido)
        Me.Controls.Add(Me.horaEnviado)
        Me.Controls.Add(Me.imgRecibido)
        Me.Controls.Add(Me.colorRecibido)
        Me.Controls.Add(Me.colorEnviado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Mensaje"
        Me.Text = "Mensaje"
        CType(Me.imgRecibido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imgRecibido As PictureBox
    Friend WithEvents lbl_Mensaje As Label
    Friend WithEvents horaEnviado As Label
    Friend WithEvents horaRecibido As Label
    Friend WithEvents colorRecibido As Panel
    Friend WithEvents colorEnviado As Panel
End Class
