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
        Me.lblCrearCuentaPac = New System.Windows.Forms.Button()
        Me.lblEsAfiliado = New System.Windows.Forms.Label()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.picBytesoft = New System.Windows.Forms.PictureBox()
        Me.picDiseño = New System.Windows.Forms.PictureBox()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.pnlIniciarSesion.SuspendLayout()
        CType(Me.picIngresar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.picBytesoft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiseño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(162, 184)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(182, 17)
        Me.txtUsuario.TabIndex = 1
        '
        'pnlIniciarSesion
        '
        Me.pnlIniciarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
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
        Me.pnlIniciarSesion.Size = New System.Drawing.Size(480, 511)
        Me.pnlIniciarSesion.TabIndex = 23
        '
        'ing
        '
        Me.ing.AutoSize = True
        Me.ing.Location = New System.Drawing.Point(65, 255)
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
        Me.esp.Location = New System.Drawing.Point(65, 201)
        Me.esp.Name = "esp"
        Me.esp.Size = New System.Drawing.Size(58, 17)
        Me.esp.TabIndex = 23
        Me.esp.TabStop = True
        Me.esp.Text = "espalol"
        Me.esp.UseVisualStyleBackColor = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(41, 305)
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
        Me.lblIniciarSesion.Location = New System.Drawing.Point(55, 50)
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
        Me.mcbRecordarUsuario.Location = New System.Drawing.Point(185, 360)
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
        Me.lblContraseña.Location = New System.Drawing.Point(158, 290)
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
        Me.lblUsuario.Location = New System.Drawing.Point(158, 183)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(71, 23)
        Me.lblUsuario.TabIndex = 12
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(162, 290)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(182, 17)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'picIngresar
        '
        Me.picIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picIngresar.Image = CType(resources.GetObject("picIngresar.Image"), System.Drawing.Image)
        Me.picIngresar.Location = New System.Drawing.Point(190, 423)
        Me.picIngresar.Name = "picIngresar"
        Me.picIngresar.Size = New System.Drawing.Size(130, 58)
        Me.picIngresar.TabIndex = 14
        Me.picIngresar.TabStop = False
        '
        'picUsuario
        '
        Me.picUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picUsuario.Image = Global.Vista.My.Resources.Resources.medd
        Me.picUsuario.Location = New System.Drawing.Point(138, 158)
        Me.picUsuario.Name = "picUsuario"
        Me.picUsuario.Size = New System.Drawing.Size(234, 73)
        Me.picUsuario.TabIndex = 1
        Me.picUsuario.TabStop = False
        '
        'picContraseña
        '
        Me.picContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.picContraseña.Image = Global.Vista.My.Resources.Resources.medd
        Me.picContraseña.Location = New System.Drawing.Point(138, 265)
        Me.picContraseña.Name = "picContraseña"
        Me.picContraseña.Size = New System.Drawing.Size(234, 73)
        Me.picContraseña.TabIndex = 3
        Me.picContraseña.TabStop = False
        '
        'lblCrearCuentaPac
        '
        Me.lblCrearCuentaPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCrearCuentaPac.BackColor = System.Drawing.Color.DimGray
        Me.lblCrearCuentaPac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCrearCuentaPac.FlatAppearance.BorderSize = 0
        Me.lblCrearCuentaPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCrearCuentaPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblCrearCuentaPac.ForeColor = System.Drawing.Color.White
        Me.lblCrearCuentaPac.Location = New System.Drawing.Point(645, 410)
        Me.lblCrearCuentaPac.Name = "lblCrearCuentaPac"
        Me.lblCrearCuentaPac.Size = New System.Drawing.Size(148, 40)
        Me.lblCrearCuentaPac.TabIndex = 31
        Me.lblCrearCuentaPac.UseVisualStyleBackColor = False
        Me.lblCrearCuentaPac.Visible = False
        '
        'lblEsAfiliado
        '
        Me.lblEsAfiliado.AutoSize = True
        Me.lblEsAfiliado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsAfiliado.ForeColor = System.Drawing.Color.White
        Me.lblEsAfiliado.Location = New System.Drawing.Point(740, 418)
        Me.lblEsAfiliado.Name = "lblEsAfiliado"
        Me.lblEsAfiliado.Size = New System.Drawing.Size(0, 20)
        Me.lblEsAfiliado.TabIndex = 29
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlContenedor.Controls.Add(Me.lblApp)
        Me.pnlContenedor.Controls.Add(Me.lblEsAfiliado)
        Me.pnlContenedor.Controls.Add(Me.picBytesoft)
        Me.pnlContenedor.Controls.Add(Me.picDiseño)
        Me.pnlContenedor.Controls.Add(Me.lblCrearCuentaPac)
        Me.pnlContenedor.Controls.Add(Me.pnlIniciarSesion)
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(910, 511)
        Me.pnlContenedor.TabIndex = 25
        '
        'lblApp
        '
        Me.lblApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp.ForeColor = System.Drawing.Color.Black
        Me.lblApp.Location = New System.Drawing.Point(577, 312)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(269, 57)
        Me.lblApp.TabIndex = 25
        Me.lblApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picBytesoft
        '
        Me.picBytesoft.Image = Global.Vista.My.Resources.Resources.logo_3
        Me.picBytesoft.Location = New System.Drawing.Point(542, 92)
        Me.picBytesoft.Name = "picBytesoft"
        Me.picBytesoft.Size = New System.Drawing.Size(356, 217)
        Me.picBytesoft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBytesoft.TabIndex = 27
        Me.picBytesoft.TabStop = False
        '
        'picDiseño
        '
        Me.picDiseño.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.picDiseño.Image = CType(resources.GetObject("picDiseño.Image"), System.Drawing.Image)
        Me.picDiseño.Location = New System.Drawing.Point(375, 0)
        Me.picDiseño.Margin = New System.Windows.Forms.Padding(0)
        Me.picDiseño.Name = "picDiseño"
        Me.picDiseño.Size = New System.Drawing.Size(156, 493)
        Me.picDiseño.TabIndex = 22
        Me.picDiseño.TabStop = False
        '
        'pnlInstancia
        '
        Me.pnlInstancia.AutoSize = True
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(910, 505)
        Me.pnlInstancia.TabIndex = 25
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(910, 505)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "|"
        Me.pnlIniciarSesion.ResumeLayout(False)
        Me.pnlIniciarSesion.PerformLayout()
        CType(Me.picIngresar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
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
    Friend WithEvents picDiseño As PictureBox
    Friend WithEvents picBytesoft As PictureBox
    Friend WithEvents lblEsAfiliado As Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents ing As RadioButton
    Friend WithEvents esp As RadioButton
    Public WithEvents mcbRecordarUsuario As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlInstancia As Panel
    Public WithEvents lblCrearCuentaPac As Button
    Public WithEvents lblApp As Label
End Class