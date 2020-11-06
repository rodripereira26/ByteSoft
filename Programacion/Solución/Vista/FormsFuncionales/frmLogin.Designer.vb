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
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.UcAjustes1 = New Vista.UCAjustes()
        Me.lblContraseña = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnAjustes = New FontAwesome.Sharp.IconPictureBox()
        Me.mcbRecordarUsuario = New Guna.UI.WinForms.GunaCheckBox()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtUsr = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.txtPass = New Guna.UI.WinForms.GunaTextBox()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnIngresar = New Guna.UI.WinForms.GunaButton()
        Me.lblCrearCuenta = New System.Windows.Forms.Label()
        Me.im = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.btnAjustes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.im, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(880, 500)
        Me.pnlInstancia.TabIndex = 37
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.UcAjustes1)
        Me.pnlContenedor.Controls.Add(Me.lblContraseña)
        Me.pnlContenedor.Controls.Add(Me.lblUsuario)
        Me.pnlContenedor.Controls.Add(Me.btnAjustes)
        Me.pnlContenedor.Controls.Add(Me.mcbRecordarUsuario)
        Me.pnlContenedor.Controls.Add(Me.lblLogin)
        Me.pnlContenedor.Controls.Add(Me.txtUsr)
        Me.pnlContenedor.Controls.Add(Me.GunaSeparator1)
        Me.pnlContenedor.Controls.Add(Me.txtPass)
        Me.pnlContenedor.Controls.Add(Me.lblApp)
        Me.pnlContenedor.Controls.Add(Me.Panel1)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(880, 500)
        Me.pnlContenedor.TabIndex = 0
        '
        'UcAjustes1
        '
        Me.UcAjustes1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.UcAjustes1.Location = New System.Drawing.Point(195, 59)
        Me.UcAjustes1.Name = "UcAjustes1"
        Me.UcAjustes1.Size = New System.Drawing.Size(505, 438)
        Me.UcAjustes1.TabIndex = 52
        Me.UcAjustes1.Visible = False
        '
        'lblContraseña
        '
        Me.lblContraseña.AutoSize = True
        Me.lblContraseña.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblContraseña.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContraseña.ForeColor = System.Drawing.Color.LightGray
        Me.lblContraseña.Location = New System.Drawing.Point(359, 236)
        Me.lblContraseña.Name = "lblContraseña"
        Me.lblContraseña.Size = New System.Drawing.Size(89, 21)
        Me.lblContraseña.TabIndex = 53
        Me.lblContraseña.Text = "Contraseña"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.LightGray
        Me.lblUsuario.Location = New System.Drawing.Point(359, 154)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(64, 21)
        Me.lblUsuario.TabIndex = 52
        Me.lblUsuario.Text = "Usuario"
        '
        'btnAjustes
        '
        Me.btnAjustes.BackColor = System.Drawing.Color.Transparent
        Me.btnAjustes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAjustes.ForeColor = System.Drawing.Color.LightGray
        Me.btnAjustes.IconChar = FontAwesome.Sharp.IconChar.Cog
        Me.btnAjustes.IconColor = System.Drawing.Color.LightGray
        Me.btnAjustes.Location = New System.Drawing.Point(22, 448)
        Me.btnAjustes.Name = "btnAjustes"
        Me.btnAjustes.Size = New System.Drawing.Size(32, 32)
        Me.btnAjustes.TabIndex = 48
        Me.btnAjustes.TabStop = False
        '
        'mcbRecordarUsuario
        '
        Me.mcbRecordarUsuario.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.mcbRecordarUsuario.CheckedOffColor = System.Drawing.Color.Gray
        Me.mcbRecordarUsuario.CheckedOnColor = System.Drawing.Color.MediumSlateBlue
        Me.mcbRecordarUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mcbRecordarUsuario.FillColor = System.Drawing.Color.White
        Me.mcbRecordarUsuario.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcbRecordarUsuario.ForeColor = System.Drawing.Color.LightGray
        Me.mcbRecordarUsuario.Location = New System.Drawing.Point(363, 336)
        Me.mcbRecordarUsuario.Name = "mcbRecordarUsuario"
        Me.mcbRecordarUsuario.Radius = 1
        Me.mcbRecordarUsuario.Size = New System.Drawing.Size(155, 24)
        Me.mcbRecordarUsuario.TabIndex = 47
        Me.mcbRecordarUsuario.Text = "Recordar usuario"
        '
        'lblLogin
        '
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(327, 59)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(230, 45)
        Me.lblLogin.TabIndex = 41
        Me.lblLogin.Text = "Login"
        Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsr
        '
        Me.txtUsr.BackColor = System.Drawing.Color.Transparent
        Me.txtUsr.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUsr.BorderColor = System.Drawing.Color.Silver
        Me.txtUsr.BorderSize = 1
        Me.txtUsr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsr.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUsr.FocusedBorderColor = System.Drawing.Color.White
        Me.txtUsr.FocusedForeColor = System.Drawing.Color.White
        Me.txtUsr.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsr.ForeColor = System.Drawing.Color.LightGray
        Me.txtUsr.Location = New System.Drawing.Point(350, 144)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsr.Radius = 17
        Me.txtUsr.Size = New System.Drawing.Size(181, 42)
        Me.txtUsr.TabIndex = 42
        Me.txtUsr.TextOffsetX = 7
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(385, 109)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(77, 10)
        Me.GunaSeparator1.TabIndex = 44
        Me.GunaSeparator1.Thickness = 5
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.Transparent
        Me.txtPass.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPass.BorderColor = System.Drawing.Color.Silver
        Me.txtPass.BorderSize = 1
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPass.FocusedBorderColor = System.Drawing.Color.White
        Me.txtPass.FocusedForeColor = System.Drawing.Color.White
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.Location = New System.Drawing.Point(350, 226)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Radius = 17
        Me.txtPass.Size = New System.Drawing.Size(181, 42)
        Me.txtPass.TabIndex = 43
        Me.txtPass.TextOffsetX = 5
        '
        'lblApp
        '
        Me.lblApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp.ForeColor = System.Drawing.Color.Black
        Me.lblApp.Location = New System.Drawing.Point(83, 531)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(352, 57)
        Me.lblApp.TabIndex = 40
        Me.lblApp.Text = "APLICACION"
        Me.lblApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnIngresar)
        Me.Panel1.Controls.Add(Me.lblCrearCuenta)
        Me.Panel1.Controls.Add(Me.im)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 500)
        Me.Panel1.TabIndex = 55
        '
        'btnIngresar
        '
        Me.btnIngresar.AnimationHoverSpeed = 0.07!
        Me.btnIngresar.AnimationSpeed = 0.03!
        Me.btnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnIngresar.BorderColor = System.Drawing.Color.Black
        Me.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnIngresar.FocusedColor = System.Drawing.Color.Empty
        Me.btnIngresar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.White
        Me.btnIngresar.Image = Nothing
        Me.btnIngresar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnIngresar.Location = New System.Drawing.Point(350, 376)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnIngresar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnIngresar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnIngresar.OnHoverImage = Nothing
        Me.btnIngresar.OnPressedColor = System.Drawing.Color.Black
        Me.btnIngresar.Radius = 17
        Me.btnIngresar.Size = New System.Drawing.Size(180, 42)
        Me.btnIngresar.TabIndex = 51
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCrearCuenta
        '
        Me.lblCrearCuenta.AutoSize = True
        Me.lblCrearCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCrearCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCrearCuenta.ForeColor = System.Drawing.Color.White
        Me.lblCrearCuenta.Location = New System.Drawing.Point(373, 433)
        Me.lblCrearCuenta.Name = "lblCrearCuenta"
        Me.lblCrearCuenta.Size = New System.Drawing.Size(134, 20)
        Me.lblCrearCuenta.TabIndex = 49
        Me.lblCrearCuenta.Text = "Solicitar cuenta"
        Me.lblCrearCuenta.Visible = False
        '
        'im
        '
        Me.im.BackColor = System.Drawing.Color.Transparent
        Me.im.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.im.IconChar = FontAwesome.Sharp.IconChar.GripLinesVertical
        Me.im.IconColor = System.Drawing.Color.DarkSlateBlue
        Me.im.IconSize = 521
        Me.im.Location = New System.Drawing.Point(555, -387)
        Me.im.Name = "im"
        Me.im.Rotation = 135.0R
        Me.im.Size = New System.Drawing.Size(521, 707)
        Me.im.TabIndex = 46
        Me.im.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(880, 500)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "|"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        CType(Me.btnAjustes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.im, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlInstancia As Panel
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents btnIngresar As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAjustes As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents im As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtUsr As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents txtPass As Guna.UI.WinForms.GunaTextBox
    Public WithEvents lblApp As Label
    Friend WithEvents UcAjustes1 As UCAjustes
    Public WithEvents mcbRecordarUsuario As Guna.UI.WinForms.GunaCheckBox
    Public WithEvents lblCrearCuenta As Label
    Friend WithEvents lblContraseña As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Panel1 As Panel
End Class