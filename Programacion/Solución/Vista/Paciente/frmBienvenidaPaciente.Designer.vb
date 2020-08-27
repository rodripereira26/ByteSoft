<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBienvenidaPaciente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlIngresarSintomas = New System.Windows.Forms.Panel()
        Me.pnlDecIngresarSintomas = New System.Windows.Forms.Panel()
        Me.lblDescIngresarSintomas = New System.Windows.Forms.Label()
        Me.lblIngresarSintomas = New System.Windows.Forms.Label()
        Me.pnlHistorial = New System.Windows.Forms.Panel()
        Me.pnlDecHistorial = New System.Windows.Forms.Panel()
        Me.lblDescHistorial = New System.Windows.Forms.Label()
        Me.lblHistorial = New System.Windows.Forms.Label()
        Me.pnlPerfil = New System.Windows.Forms.Panel()
        Me.pnlDescPerfil = New System.Windows.Forms.Panel()
        Me.lblDescPerfil = New System.Windows.Forms.Label()
        Me.lblPerfil = New System.Windows.Forms.Label()
        Me.pnlAyuda = New System.Windows.Forms.Panel()
        Me.pnlDescAyuda = New System.Windows.Forms.Panel()
        Me.lblDescAyuda = New System.Windows.Forms.Label()
        Me.lblAyuda = New System.Windows.Forms.Label()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblBienvenido = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlReanudar = New System.Windows.Forms.Panel()
        Me.pnlDecReanudar = New System.Windows.Forms.Panel()
        Me.lblDescReanudar = New System.Windows.Forms.Label()
        Me.lblReanuda = New System.Windows.Forms.Label()
        Me.pnlIngresarSintomas.SuspendLayout()
        Me.pnlHistorial.SuspendLayout()
        Me.pnlPerfil.SuspendLayout()
        Me.pnlAyuda.SuspendLayout()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlReanudar.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlIngresarSintomas
        '
        Me.pnlIngresarSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlIngresarSintomas.Controls.Add(Me.pnlDecIngresarSintomas)
        Me.pnlIngresarSintomas.Controls.Add(Me.lblDescIngresarSintomas)
        Me.pnlIngresarSintomas.Controls.Add(Me.lblIngresarSintomas)
        Me.pnlIngresarSintomas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlIngresarSintomas.Location = New System.Drawing.Point(64, 148)
        Me.pnlIngresarSintomas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlIngresarSintomas.Name = "pnlIngresarSintomas"
        Me.pnlIngresarSintomas.Size = New System.Drawing.Size(705, 180)
        Me.pnlIngresarSintomas.TabIndex = 0
        '
        'pnlDecIngresarSintomas
        '
        Me.pnlDecIngresarSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.pnlDecIngresarSintomas.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecIngresarSintomas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlDecIngresarSintomas.Name = "pnlDecIngresarSintomas"
        Me.pnlDecIngresarSintomas.Size = New System.Drawing.Size(705, 12)
        Me.pnlDecIngresarSintomas.TabIndex = 2
        '
        'lblDescIngresarSintomas
        '
        Me.lblDescIngresarSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescIngresarSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescIngresarSintomas.ForeColor = System.Drawing.Color.White
        Me.lblDescIngresarSintomas.Location = New System.Drawing.Point(33, 105)
        Me.lblDescIngresarSintomas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescIngresarSintomas.Name = "lblDescIngresarSintomas"
        Me.lblDescIngresarSintomas.Size = New System.Drawing.Size(640, 30)
        Me.lblDescIngresarSintomas.TabIndex = 1
        Me.lblDescIngresarSintomas.Text = "Seleccione síntomas y obtenga un diagnóstico primario"
        '
        'lblIngresarSintomas
        '
        Me.lblIngresarSintomas.AutoSize = True
        Me.lblIngresarSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresarSintomas.ForeColor = System.Drawing.Color.White
        Me.lblIngresarSintomas.Location = New System.Drawing.Point(29, 33)
        Me.lblIngresarSintomas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIngresarSintomas.Name = "lblIngresarSintomas"
        Me.lblIngresarSintomas.Size = New System.Drawing.Size(342, 46)
        Me.lblIngresarSintomas.TabIndex = 0
        Me.lblIngresarSintomas.Text = "Ingresar Síntomas"
        '
        'pnlHistorial
        '
        Me.pnlHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlHistorial.Controls.Add(Me.pnlDecHistorial)
        Me.pnlHistorial.Controls.Add(Me.lblDescHistorial)
        Me.pnlHistorial.Controls.Add(Me.lblHistorial)
        Me.pnlHistorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlHistorial.Location = New System.Drawing.Point(64, 356)
        Me.pnlHistorial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlHistorial.Name = "pnlHistorial"
        Me.pnlHistorial.Size = New System.Drawing.Size(340, 238)
        Me.pnlHistorial.TabIndex = 2
        '
        'pnlDecHistorial
        '
        Me.pnlDecHistorial.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.pnlDecHistorial.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecHistorial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlDecHistorial.Name = "pnlDecHistorial"
        Me.pnlDecHistorial.Size = New System.Drawing.Size(340, 12)
        Me.pnlDecHistorial.TabIndex = 4
        '
        'lblDescHistorial
        '
        Me.lblDescHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescHistorial.ForeColor = System.Drawing.Color.White
        Me.lblDescHistorial.Location = New System.Drawing.Point(33, 112)
        Me.lblDescHistorial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescHistorial.Name = "lblDescHistorial"
        Me.lblDescHistorial.Size = New System.Drawing.Size(237, 113)
        Me.lblDescHistorial.TabIndex = 1
        Me.lblDescHistorial.Text = "Vea su historial completo dentro de la aplicación"
        '
        'lblHistorial
        '
        Me.lblHistorial.AutoSize = True
        Me.lblHistorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistorial.ForeColor = System.Drawing.Color.White
        Me.lblHistorial.Location = New System.Drawing.Point(29, 41)
        Me.lblHistorial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHistorial.Name = "lblHistorial"
        Me.lblHistorial.Size = New System.Drawing.Size(218, 46)
        Me.lblHistorial.TabIndex = 0
        Me.lblHistorial.Text = "Mi Historial"
        '
        'pnlPerfil
        '
        Me.pnlPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlPerfil.Controls.Add(Me.pnlDescPerfil)
        Me.pnlPerfil.Controls.Add(Me.lblDescPerfil)
        Me.pnlPerfil.Controls.Add(Me.lblPerfil)
        Me.pnlPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlPerfil.Location = New System.Drawing.Point(791, 356)
        Me.pnlPerfil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlPerfil.Name = "pnlPerfil"
        Me.pnlPerfil.Size = New System.Drawing.Size(216, 238)
        Me.pnlPerfil.TabIndex = 4
        '
        'pnlDescPerfil
        '
        Me.pnlDescPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.pnlDescPerfil.Location = New System.Drawing.Point(0, 0)
        Me.pnlDescPerfil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlDescPerfil.Name = "pnlDescPerfil"
        Me.pnlDescPerfil.Size = New System.Drawing.Size(216, 12)
        Me.pnlDescPerfil.TabIndex = 6
        '
        'lblDescPerfil
        '
        Me.lblDescPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPerfil.ForeColor = System.Drawing.Color.White
        Me.lblDescPerfil.Location = New System.Drawing.Point(13, 112)
        Me.lblDescPerfil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescPerfil.Name = "lblDescPerfil"
        Me.lblDescPerfil.Size = New System.Drawing.Size(188, 113)
        Me.lblDescPerfil.TabIndex = 1
        Me.lblDescPerfil.Text = "Ver y configurar Perfil"
        '
        'lblPerfil
        '
        Me.lblPerfil.AutoSize = True
        Me.lblPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPerfil.ForeColor = System.Drawing.Color.White
        Me.lblPerfil.Location = New System.Drawing.Point(4, 41)
        Me.lblPerfil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPerfil.Name = "lblPerfil"
        Me.lblPerfil.Size = New System.Drawing.Size(164, 46)
        Me.lblPerfil.TabIndex = 0
        Me.lblPerfil.Text = "Mi Perfil"
        '
        'pnlAyuda
        '
        Me.pnlAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlAyuda.Controls.Add(Me.pnlDescAyuda)
        Me.pnlAyuda.Controls.Add(Me.lblDescAyuda)
        Me.pnlAyuda.Controls.Add(Me.lblAyuda)
        Me.pnlAyuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAyuda.Location = New System.Drawing.Point(791, 148)
        Me.pnlAyuda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlAyuda.Name = "pnlAyuda"
        Me.pnlAyuda.Size = New System.Drawing.Size(216, 180)
        Me.pnlAyuda.TabIndex = 5
        '
        'pnlDescAyuda
        '
        Me.pnlDescAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.pnlDescAyuda.Location = New System.Drawing.Point(0, 0)
        Me.pnlDescAyuda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlDescAyuda.Name = "pnlDescAyuda"
        Me.pnlDescAyuda.Size = New System.Drawing.Size(216, 12)
        Me.pnlDescAyuda.TabIndex = 3
        '
        'lblDescAyuda
        '
        Me.lblDescAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescAyuda.ForeColor = System.Drawing.Color.White
        Me.lblDescAyuda.Location = New System.Drawing.Point(19, 98)
        Me.lblDescAyuda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescAyuda.Name = "lblDescAyuda"
        Me.lblDescAyuda.Size = New System.Drawing.Size(183, 65)
        Me.lblDescAyuda.TabIndex = 1
        Me.lblDescAyuda.Text = "Cómo usar la aplicación"
        '
        'lblAyuda
        '
        Me.lblAyuda.AutoSize = True
        Me.lblAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyuda.ForeColor = System.Drawing.Color.White
        Me.lblAyuda.Location = New System.Drawing.Point(15, 33)
        Me.lblAyuda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAyuda.Name = "lblAyuda"
        Me.lblAyuda.Size = New System.Drawing.Size(133, 46)
        Me.lblAyuda.TabIndex = 0
        Me.lblAyuda.Text = "Ayuda"
        '
        'pnlTitulo
        '
        Me.pnlTitulo.Controls.Add(Me.lblBienvenido)
        Me.pnlTitulo.Controls.Add(Me.btn1)
        Me.pnlTitulo.Controls.Add(Me.btn2)
        Me.pnlTitulo.Location = New System.Drawing.Point(16, 4)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(905, 98)
        Me.pnlTitulo.TabIndex = 6
        '
        'lblBienvenido
        '
        Me.lblBienvenido.AutoSize = True
        Me.lblBienvenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenido.ForeColor = System.Drawing.Color.White
        Me.lblBienvenido.Location = New System.Drawing.Point(103, 43)
        Me.lblBienvenido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBienvenido.Name = "lblBienvenido"
        Me.lblBienvenido.Size = New System.Drawing.Size(180, 36)
        Me.lblBienvenido.TabIndex = 26
        Me.lblBienvenido.Text = "Bienvenido, "
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(749, 11)
        Me.btn1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(93, 68)
        Me.btn1.TabIndex = 23
        Me.btn1.Text = "Button1"
        Me.btn1.UseVisualStyleBackColor = True
        Me.btn1.Visible = False
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(631, 15)
        Me.btn2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(93, 68)
        Me.btn2.TabIndex = 24
        Me.btn2.Text = "Button2"
        Me.btn2.UseVisualStyleBackColor = True
        Me.btn2.Visible = False
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.White
        Me.lblMinimizar.Location = New System.Drawing.Point(960, 1)
        Me.lblMinimizar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinimizar.Name = "lblMinimizar"
        Me.lblMinimizar.Size = New System.Drawing.Size(32, 43)
        Me.lblMinimizar.TabIndex = 22
        Me.lblMinimizar.Text = "_"
        Me.lblMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCerrar
        '
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(993, 11)
        Me.lblCerrar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(57, 43)
        Me.lblCerrar.TabIndex = 21
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 4000
        '
        'pnlReanudar
        '
        Me.pnlReanudar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlReanudar.Controls.Add(Me.pnlDecReanudar)
        Me.pnlReanudar.Controls.Add(Me.lblDescReanudar)
        Me.pnlReanudar.Controls.Add(Me.lblReanuda)
        Me.pnlReanudar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlReanudar.Location = New System.Drawing.Point(429, 356)
        Me.pnlReanudar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlReanudar.Name = "pnlReanudar"
        Me.pnlReanudar.Size = New System.Drawing.Size(340, 238)
        Me.pnlReanudar.TabIndex = 5
        '
        'pnlDecReanudar
        '
        Me.pnlDecReanudar.BackColor = System.Drawing.Color.Silver
        Me.pnlDecReanudar.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecReanudar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlDecReanudar.Name = "pnlDecReanudar"
        Me.pnlDecReanudar.Size = New System.Drawing.Size(340, 12)
        Me.pnlDecReanudar.TabIndex = 4
        '
        'lblDescReanudar
        '
        Me.lblDescReanudar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescReanudar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescReanudar.ForeColor = System.Drawing.Color.White
        Me.lblDescReanudar.Location = New System.Drawing.Point(31, 112)
        Me.lblDescReanudar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescReanudar.Name = "lblDescReanudar"
        Me.lblDescReanudar.Size = New System.Drawing.Size(277, 68)
        Me.lblDescReanudar.TabIndex = 1
        Me.lblDescReanudar.Text = "Continuar chat con médico"
        '
        'lblReanuda
        '
        Me.lblReanuda.AutoSize = True
        Me.lblReanuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReanuda.ForeColor = System.Drawing.Color.White
        Me.lblReanuda.Location = New System.Drawing.Point(29, 41)
        Me.lblReanuda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReanuda.Name = "lblReanuda"
        Me.lblReanuda.Size = New System.Drawing.Size(281, 46)
        Me.lblReanuda.TabIndex = 0
        Me.lblReanuda.Text = "Reanudar chat"
        '
        'frmBienvenidaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1067, 624)
        Me.Controls.Add(Me.pnlReanudar)
        Me.Controls.Add(Me.lblMinimizar)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.pnlAyuda)
        Me.Controls.Add(Me.pnlPerfil)
        Me.Controls.Add(Me.pnlHistorial)
        Me.Controls.Add(Me.pnlIngresarSintomas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmBienvenidaPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnlIngresarSintomas.ResumeLayout(False)
        Me.pnlIngresarSintomas.PerformLayout()
        Me.pnlHistorial.ResumeLayout(False)
        Me.pnlHistorial.PerformLayout()
        Me.pnlPerfil.ResumeLayout(False)
        Me.pnlPerfil.PerformLayout()
        Me.pnlAyuda.ResumeLayout(False)
        Me.pnlAyuda.PerformLayout()
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTitulo.PerformLayout()
        Me.pnlReanudar.ResumeLayout(False)
        Me.pnlReanudar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlIngresarSintomas As Panel
    Friend WithEvents lblDescIngresarSintomas As Label
    Friend WithEvents lblIngresarSintomas As Label
    Friend WithEvents pnlHistorial As Panel
    Friend WithEvents lblDescHistorial As Label
    Friend WithEvents lblHistorial As Label
    Friend WithEvents pnlPerfil As Panel
    Friend WithEvents lblPerfil As Label
    Friend WithEvents pnlAyuda As Panel
    Friend WithEvents lblDescAyuda As Label
    Friend WithEvents lblAyuda As Label
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblMinimizar As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents pnlDecIngresarSintomas As Panel
    Friend WithEvents pnlDescAyuda As Panel
    Friend WithEvents pnlDecHistorial As Panel
    Friend WithEvents pnlDescPerfil As Panel
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents lblDescPerfil As Label
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlReanudar As Panel
    Friend WithEvents pnlDecReanudar As Panel
    Friend WithEvents lblDescReanudar As Label
    Friend WithEvents lblReanuda As Label
End Class
