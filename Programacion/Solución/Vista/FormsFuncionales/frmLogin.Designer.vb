<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.pnlIniciarSesion = New System.Windows.Forms.Panel()
        Me.lblIniciarSesion = New System.Windows.Forms.Label()
        Me.mcbRecordarUsuario = New MaterialSkin.Controls.MaterialCheckBox()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.picIngresar = New System.Windows.Forms.PictureBox()
        Me.picUsuario = New System.Windows.Forms.PictureBox()
        Me.picContraseña = New System.Windows.Forms.PictureBox()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.lblCrearCuentaPac = New System.Windows.Forms.Label()
        Me.lblEsAfiliado = New System.Windows.Forms.Label()
        Me.picBytesoft = New System.Windows.Forms.PictureBox()
        Me.picDiseño = New System.Windows.Forms.PictureBox()
        Me.pnlIniciarSesion.SuspendLayout()
        CType(Me.picIngresar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBytesoft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiseño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(217, 225)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(243, 22)
        Me.txtUsuario.TabIndex = 1
        '
        'pnlIniciarSesion
        '
        Me.pnlIniciarSesion.BackColor = System.Drawing.Color.White
        Me.pnlIniciarSesion.Controls.Add(Me.lblIniciarSesion)
        Me.pnlIniciarSesion.Controls.Add(Me.mcbRecordarUsuario)
        Me.pnlIniciarSesion.Controls.Add(Me.lblContraseña)
        Me.pnlIniciarSesion.Controls.Add(Me.lblUsuario)
        Me.pnlIniciarSesion.Controls.Add(Me.txtUsuario)
        Me.pnlIniciarSesion.Controls.Add(Me.txtPassword)
        Me.pnlIniciarSesion.Controls.Add(Me.picIngresar)
        Me.pnlIniciarSesion.Controls.Add(Me.picUsuario)
        Me.pnlIniciarSesion.Controls.Add(Me.picContraseña)
        Me.pnlIniciarSesion.Location = New System.Drawing.Point(0, 0)
        Me.pnlIniciarSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlIniciarSesion.Name = "pnlIniciarSesion"
        Me.pnlIniciarSesion.Size = New System.Drawing.Size(640, 622)
        Me.pnlIniciarSesion.TabIndex = 23
        '
        'lblIniciarSesion
        '
        Me.lblIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIniciarSesion.ForeColor = System.Drawing.Color.Black
        Me.lblIniciarSesion.Location = New System.Drawing.Point(115, 73)
        Me.lblIniciarSesion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIniciarSesion.Name = "lblIniciarSesion"
        Me.lblIniciarSesion.Size = New System.Drawing.Size(496, 62)
        Me.lblIniciarSesion.TabIndex = 0
        Me.lblIniciarSesion.Text = "Inicio de Sesión"
        Me.lblIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mcbRecordarUsuario
        '
        Me.mcbRecordarUsuario.AutoSize = True
        Me.mcbRecordarUsuario.Depth = 0
        Me.mcbRecordarUsuario.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mcbRecordarUsuario.Location = New System.Drawing.Point(248, 442)
        Me.mcbRecordarUsuario.Margin = New System.Windows.Forms.Padding(0)
        Me.mcbRecordarUsuario.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mcbRecordarUsuario.MouseState = MaterialSkin.MouseState.HOVER
        Me.mcbRecordarUsuario.Name = "mcbRecordarUsuario"
        Me.mcbRecordarUsuario.Ripple = True
        Me.mcbRecordarUsuario.Size = New System.Drawing.Size(162, 30)
        Me.mcbRecordarUsuario.TabIndex = 21
        Me.mcbRecordarUsuario.Text = "Recordar usuario"
        Me.mcbRecordarUsuario.UseVisualStyleBackColor = True
        '
        'lblContraseña
        '
        Me.lblContraseña.BackColor = System.Drawing.Color.White
        Me.lblContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblContraseña.Location = New System.Drawing.Point(212, 356)
        Me.lblContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(148, 26)
        Me.lblContraseña.TabIndex = 13
        Me.lblContraseña.Text = "Constraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.BackColor = System.Drawing.Color.White
        Me.lblUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblUsuario.Location = New System.Drawing.Point(212, 224)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(95, 28)
        Me.lblUsuario.TabIndex = 12
        Me.lblUsuario.Text = "Usuario"
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(217, 356)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(243, 22)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'picIngresar
        '
        Me.picIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picIngresar.Image = CType(resources.GetObject("picIngresar.Image"), System.Drawing.Image)
        Me.picIngresar.Location = New System.Drawing.Point(255, 512)
        Me.picIngresar.Margin = New System.Windows.Forms.Padding(4)
        Me.picIngresar.Name = "picIngresar"
        Me.picIngresar.Size = New System.Drawing.Size(173, 71)
        Me.picIngresar.TabIndex = 14
        Me.picIngresar.TabStop = False
        '
        'picUsuario
        '
        Me.picUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picUsuario.Image = Global.Vista.My.Resources.Resources.medd
        Me.picUsuario.Location = New System.Drawing.Point(185, 193)
        Me.picUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.picUsuario.Name = "picUsuario"
        Me.picUsuario.Size = New System.Drawing.Size(312, 90)
        Me.picUsuario.TabIndex = 1
        Me.picUsuario.TabStop = False
        '
        'picContraseña
        '
        Me.picContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picContraseña.Image = Global.Vista.My.Resources.Resources.medd
        Me.picContraseña.Location = New System.Drawing.Point(185, 325)
        Me.picContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.picContraseña.Name = "picContraseña"
        Me.picContraseña.Size = New System.Drawing.Size(312, 90)
        Me.picContraseña.TabIndex = 3
        Me.picContraseña.TabStop = False
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.White
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(636, 69)
        Me.pnlTopBar.TabIndex = 22
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.White
        Me.lblMinimizar.Location = New System.Drawing.Point(1064, 0)
        Me.lblMinimizar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinimizar.Name = "lblMinimizar"
        Me.lblMinimizar.Size = New System.Drawing.Size(32, 43)
        Me.lblMinimizar.TabIndex = 25
        Me.lblMinimizar.Text = "_"
        Me.lblMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCerrar
        '
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(1104, 11)
        Me.lblCerrar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(57, 43)
        Me.lblCerrar.TabIndex = 24
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCrearCuentaPac
        '
        Me.lblCrearCuentaPac.AutoSize = True
        Me.lblCrearCuentaPac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCrearCuentaPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearCuentaPac.ForeColor = System.Drawing.Color.White
        Me.lblCrearCuentaPac.Location = New System.Drawing.Point(851, 538)
        Me.lblCrearCuentaPac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCrearCuentaPac.Name = "lblCrearCuentaPac"
        Me.lblCrearCuentaPac.Size = New System.Drawing.Size(216, 31)
        Me.lblCrearCuentaPac.TabIndex = 28
        Me.lblCrearCuentaPac.Text = "Solicitar cuenta"
        '
        'lblEsAfiliado
        '
        Me.lblEsAfiliado.AutoSize = True
        Me.lblEsAfiliado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsAfiliado.ForeColor = System.Drawing.Color.White
        Me.lblEsAfiliado.Location = New System.Drawing.Point(891, 495)
        Me.lblEsAfiliado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEsAfiliado.Name = "lblEsAfiliado"
        Me.lblEsAfiliado.Size = New System.Drawing.Size(137, 25)
        Me.lblEsAfiliado.TabIndex = 29
        Me.lblEsAfiliado.Text = "¿Es afiliado?"
        '
        'picBytesoft
        '
        Me.picBytesoft.Image = Global.Vista.My.Resources.Resources.logo_byw_v3
        Me.picBytesoft.Location = New System.Drawing.Point(783, 148)
        Me.picBytesoft.Margin = New System.Windows.Forms.Padding(4)
        Me.picBytesoft.Name = "picBytesoft"
        Me.picBytesoft.Size = New System.Drawing.Size(347, 320)
        Me.picBytesoft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBytesoft.TabIndex = 27
        Me.picBytesoft.TabStop = False
        '
        'picDiseño
        '
        Me.picDiseño.Image = CType(resources.GetObject("picDiseño.Image"), System.Drawing.Image)
        Me.picDiseño.Location = New System.Drawing.Point(543, -2)
        Me.picDiseño.Margin = New System.Windows.Forms.Padding(0)
        Me.picDiseño.Name = "picDiseño"
        Me.picDiseño.Size = New System.Drawing.Size(211, 618)
        Me.picDiseño.TabIndex = 22
        Me.picDiseño.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1167, 615)
        Me.Controls.Add(Me.lblEsAfiliado)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.lblCrearCuentaPac)
        Me.Controls.Add(Me.picBytesoft)
        Me.Controls.Add(Me.pnlIniciarSesion)
        Me.Controls.Add(Me.lblMinimizar)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.picDiseño)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "|"
        Me.pnlIniciarSesion.ResumeLayout(False)
        Me.pnlIniciarSesion.PerformLayout()
        CType(Me.picIngresar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBytesoft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiseño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents pnlIniciarSesion As Panel
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents picIngresar As PictureBox
    Friend WithEvents picUsuario As PictureBox
    Friend WithEvents lblIniciarSesion As Label
    Friend WithEvents picContraseña As PictureBox
    Friend WithEvents lblMinimizar As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents picDiseño As PictureBox
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents picBytesoft As PictureBox
    Friend WithEvents lblCrearCuentaPac As Label
    Friend WithEvents lblEsAfiliado As Label
    Friend WithEvents mcbRecordarUsuario As MaterialSkin.Controls.MaterialCheckBox
End Class
