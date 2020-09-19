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
        Me.ing = New System.Windows.Forms.RadioButton()
        Me.esp = New System.Windows.Forms.RadioButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
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
        Me.lblCrearCuentaPac = New System.Windows.Forms.Button()
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
        Me.txtUsuario.Location = New System.Drawing.Point(163, 183)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(182, 17)
        Me.txtUsuario.TabIndex = 1
        '
        'pnlIniciarSesion
        '
        Me.pnlIniciarSesion.BackColor = System.Drawing.Color.White
        Me.pnlIniciarSesion.Controls.Add(Me.ing)
        Me.pnlIniciarSesion.Controls.Add(Me.esp)
        Me.pnlIniciarSesion.Controls.Add(Me.MetroButton1)
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
        Me.pnlIniciarSesion.Name = "pnlIniciarSesion"
        Me.pnlIniciarSesion.Size = New System.Drawing.Size(480, 505)
        Me.pnlIniciarSesion.TabIndex = 23
        '
        'ing
        '
        Me.ing.AutoSize = True
        Me.ing.Location = New System.Drawing.Point(66, 236)
        Me.ing.Name = "ing"
        Me.ing.Size = New System.Drawing.Size(52, 17)
        Me.ing.TabIndex = 24
        Me.ing.TabStop = True
        Me.ing.Text = "ingles"
        Me.ing.UseVisualStyleBackColor = True
        '
        'esp
        '
        Me.esp.AutoSize = True
        Me.esp.Location = New System.Drawing.Point(66, 182)
        Me.esp.Name = "esp"
        Me.esp.Size = New System.Drawing.Size(58, 17)
        Me.esp.TabIndex = 23
        Me.esp.TabStop = True
        Me.esp.Text = "espalol"
        Me.esp.UseVisualStyleBackColor = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(42, 286)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 22
        Me.MetroButton1.Text = "MetroButton1"
        Me.MetroButton1.UseSelectable = True
        '
        'lblIniciarSesion
        '
        Me.lblIniciarSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIniciarSesion.ForeColor = System.Drawing.Color.Black
        Me.lblIniciarSesion.Location = New System.Drawing.Point(86, 59)
        Me.lblIniciarSesion.Name = "lblIniciarSesion"
        Me.lblIniciarSesion.Size = New System.Drawing.Size(372, 72)
        Me.lblIniciarSesion.TabIndex = 0
        Me.lblIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mcbRecordarUsuario
        '
        Me.mcbRecordarUsuario.AutoSize = True
        Me.mcbRecordarUsuario.Depth = 0
        Me.mcbRecordarUsuario.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mcbRecordarUsuario.Location = New System.Drawing.Point(186, 359)
        Me.mcbRecordarUsuario.Margin = New System.Windows.Forms.Padding(0)
        Me.mcbRecordarUsuario.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mcbRecordarUsuario.MouseState = MaterialSkin.MouseState.HOVER
        Me.mcbRecordarUsuario.Name = "mcbRecordarUsuario"
        Me.mcbRecordarUsuario.Ripple = True
        Me.mcbRecordarUsuario.Size = New System.Drawing.Size(26, 30)
        Me.mcbRecordarUsuario.TabIndex = 21
        Me.mcbRecordarUsuario.UseVisualStyleBackColor = True
        '
        'lblContraseña
        '
        Me.lblContraseña.BackColor = System.Drawing.Color.White
        Me.lblContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblContraseña.Location = New System.Drawing.Point(159, 289)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(111, 21)
        Me.lblContraseña.TabIndex = 13
        '
        'lblUsuario
        '
        Me.lblUsuario.BackColor = System.Drawing.Color.White
        Me.lblUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblUsuario.Location = New System.Drawing.Point(159, 182)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(71, 23)
        Me.lblUsuario.TabIndex = 12
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(163, 289)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(182, 17)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'picIngresar
        '
        Me.picIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picIngresar.Image = CType(resources.GetObject("picIngresar.Image"), System.Drawing.Image)
        Me.picIngresar.Location = New System.Drawing.Point(191, 416)
        Me.picIngresar.Name = "picIngresar"
        Me.picIngresar.Size = New System.Drawing.Size(130, 58)
        Me.picIngresar.TabIndex = 14
        Me.picIngresar.TabStop = False
        '
        'picUsuario
        '
        Me.picUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picUsuario.Image = Global.Vista.My.Resources.Resources.medd
        Me.picUsuario.Location = New System.Drawing.Point(139, 157)
        Me.picUsuario.Name = "picUsuario"
        Me.picUsuario.Size = New System.Drawing.Size(234, 73)
        Me.picUsuario.TabIndex = 1
        Me.picUsuario.TabStop = False
        '
        'picContraseña
        '
        Me.picContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picContraseña.Image = Global.Vista.My.Resources.Resources.medd
        Me.picContraseña.Location = New System.Drawing.Point(139, 264)
        Me.picContraseña.Name = "picContraseña"
        Me.picContraseña.Size = New System.Drawing.Size(234, 73)
        Me.picContraseña.TabIndex = 3
        Me.picContraseña.TabStop = False
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.White
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(477, 56)
        Me.pnlTopBar.TabIndex = 22
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.White
        Me.lblMinimizar.Location = New System.Drawing.Point(798, 0)
        Me.lblMinimizar.Name = "lblMinimizar"
        Me.lblMinimizar.Size = New System.Drawing.Size(24, 35)
        Me.lblMinimizar.TabIndex = 25
        Me.lblMinimizar.Text = "_"
        Me.lblMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCerrar
        '
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(828, 9)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(43, 35)
        Me.lblCerrar.TabIndex = 24
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCrearCuentaPac
        '
        Me.lblCrearCuentaPac.BackColor = System.Drawing.Color.Transparent
        Me.lblCrearCuentaPac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCrearCuentaPac.FlatAppearance.BorderSize = 0
        Me.lblCrearCuentaPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCrearCuentaPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblCrearCuentaPac.ForeColor = System.Drawing.Color.White
        Me.lblCrearCuentaPac.Location = New System.Drawing.Point(650, 430)
        Me.lblCrearCuentaPac.Name = "lblCrearCuentaPac"
        Me.lblCrearCuentaPac.Size = New System.Drawing.Size(160, 52)
        Me.lblCrearCuentaPac.TabIndex = 31
        Me.lblCrearCuentaPac.UseVisualStyleBackColor = False
        '
        'lblEsAfiliado
        '
        Me.lblEsAfiliado.AutoSize = True
        Me.lblEsAfiliado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsAfiliado.ForeColor = System.Drawing.Color.White
        Me.lblEsAfiliado.Location = New System.Drawing.Point(668, 402)
        Me.lblEsAfiliado.Name = "lblEsAfiliado"
        Me.lblEsAfiliado.Size = New System.Drawing.Size(0, 20)
        Me.lblEsAfiliado.TabIndex = 29
        '
        'picBytesoft
        '
        Me.picBytesoft.Image = Global.Vista.My.Resources.Resources.logo_byw_v3
        Me.picBytesoft.Location = New System.Drawing.Point(587, 120)
        Me.picBytesoft.Name = "picBytesoft"
        Me.picBytesoft.Size = New System.Drawing.Size(260, 260)
        Me.picBytesoft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBytesoft.TabIndex = 27
        Me.picBytesoft.TabStop = False
        '
        'picDiseño
        '
        Me.picDiseño.Image = CType(resources.GetObject("picDiseño.Image"), System.Drawing.Image)
        Me.picDiseño.Location = New System.Drawing.Point(407, -2)
        Me.picDiseño.Margin = New System.Windows.Forms.Padding(0)
        Me.picDiseño.Name = "picDiseño"
        Me.picDiseño.Size = New System.Drawing.Size(158, 502)
        Me.picDiseño.TabIndex = 22
        Me.picDiseño.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(875, 500)
        Me.Controls.Add(Me.lblEsAfiliado)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.lblCrearCuentaPac)
        Me.Controls.Add(Me.picBytesoft)
        Me.Controls.Add(Me.pnlIniciarSesion)
        Me.Controls.Add(Me.lblMinimizar)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.picDiseño)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
    Friend WithEvents lblCrearCuentaPac As Button
    Friend WithEvents lblEsAfiliado As Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents ing As RadioButton
    Friend WithEvents esp As RadioButton
    Public WithEvents mcbRecordarUsuario As MaterialSkin.Controls.MaterialCheckBox
End Class