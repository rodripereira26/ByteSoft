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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBienvenidaPaciente))
        Me.notificacion = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlOps = New System.Windows.Forms.Panel()
        Me.btnCerrarSesion = New Guna.UI.WinForms.GunaButton()
        Me.btnCambiarPass = New Guna.UI.WinForms.GunaButton()
        Me.btnVerPerfil = New Guna.UI.WinForms.GunaButton()
        Me.pnlNotis = New System.Windows.Forms.Panel()
        Me.lblNA = New System.Windows.Forms.Label()
        Me.btnNo = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnSi = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblIniciarConversacion = New System.Windows.Forms.Label()
        Me.lblIniciarCOnv = New System.Windows.Forms.Label()
        Me.pnlCerrar = New System.Windows.Forms.Panel()
        Me.pnlNoti = New Guna.UI.WinForms.GunaElipsePanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNoti = New FontAwesome.Sharp.IconPictureBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.pnlListado = New System.Windows.Forms.Panel()
        Me.btnListadoPac = New Guna.UI.WinForms.GunaButton()
        Me.lblListadoPatPac = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblSubListadoPat = New System.Windows.Forms.Label()
        Me.pnlConsultaActual = New System.Windows.Forms.Panel()
        Me.btnConsultaActual = New Guna.UI.WinForms.GunaButton()
        Me.lblCOnsultaa = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblVerConsultaaa = New System.Windows.Forms.Label()
        Me.pnlIngresar = New System.Windows.Forms.Panel()
        Me.btnIngresarSinPac = New Guna.UI.WinForms.GunaButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSubIngSin = New System.Windows.Forms.Label()
        Me.lblIngSinPac = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnHistorialPac = New Guna.UI.WinForms.GunaButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblSubMiHistoiralPac = New System.Windows.Forms.Label()
        Me.lblMiHistorialPac = New System.Windows.Forms.Label()
        Me.pnlReanudar = New System.Windows.Forms.Panel()
        Me.btnReanudar = New Guna.UI.WinForms.GunaButton()
        Me.lblReanudarChatt = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblContinuarChat = New System.Windows.Forms.Label()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.timVerificarSiSolicitud = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContenedor.SuspendLayout()
        Me.pnlOps.SuspendLayout()
        Me.pnlNotis.SuspendLayout()
        Me.pnlCerrar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNoti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.pnlListado.SuspendLayout()
        Me.pnlConsultaActual.SuspendLayout()
        Me.pnlIngresar.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlReanudar.SuspendLayout()
        Me.SuspendLayout()
        '
        'notificacion
        '
        Me.notificacion.AutoSize = True
        Me.notificacion.ForeColor = System.Drawing.SystemColors.Control
        Me.notificacion.Location = New System.Drawing.Point(105, 103)
        Me.notificacion.Name = "notificacion"
        Me.notificacion.Size = New System.Drawing.Size(61, 13)
        Me.notificacion.TabIndex = 10
        Me.notificacion.Text = "notificacion"
        Me.notificacion.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.pnlOps)
        Me.pnlContenedor.Controls.Add(Me.pnlNotis)
        Me.pnlContenedor.Controls.Add(Me.pnlCerrar)
        Me.pnlContenedor.Controls.Add(Me.notificacion)
        Me.pnlContenedor.Controls.Add(Me.Panel10)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 7
        '
        'pnlOps
        '
        Me.pnlOps.Controls.Add(Me.btnCerrarSesion)
        Me.pnlOps.Controls.Add(Me.btnCambiarPass)
        Me.pnlOps.Controls.Add(Me.btnVerPerfil)
        Me.pnlOps.Location = New System.Drawing.Point(828, 80)
        Me.pnlOps.Name = "pnlOps"
        Me.pnlOps.Size = New System.Drawing.Size(179, 128)
        Me.pnlOps.TabIndex = 29
        Me.pnlOps.Visible = False
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Animated = True
        Me.btnCerrarSesion.AnimationHoverSpeed = 0.07!
        Me.btnCerrarSesion.AnimationSpeed = 0.03!
        Me.btnCerrarSesion.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnCerrarSesion.BorderColor = System.Drawing.Color.Black
        Me.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCerrarSesion.FocusedColor = System.Drawing.Color.Empty
        Me.btnCerrarSesion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.Image = Nothing
        Me.btnCerrarSesion.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCerrarSesion.Location = New System.Drawing.Point(0, 84)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCerrarSesion.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCerrarSesion.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCerrarSesion.OnHoverImage = Nothing
        Me.btnCerrarSesion.OnPressedColor = System.Drawing.Color.Black
        Me.btnCerrarSesion.Size = New System.Drawing.Size(179, 42)
        Me.btnCerrarSesion.TabIndex = 201
        Me.btnCerrarSesion.Text = "Cerrar sesión"
        Me.btnCerrarSesion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCambiarPass
        '
        Me.btnCambiarPass.Animated = True
        Me.btnCambiarPass.AnimationHoverSpeed = 0.07!
        Me.btnCambiarPass.AnimationSpeed = 0.03!
        Me.btnCambiarPass.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnCambiarPass.BorderColor = System.Drawing.Color.Black
        Me.btnCambiarPass.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiarPass.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCambiarPass.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCambiarPass.FocusedColor = System.Drawing.Color.Empty
        Me.btnCambiarPass.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarPass.ForeColor = System.Drawing.Color.White
        Me.btnCambiarPass.Image = Nothing
        Me.btnCambiarPass.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCambiarPass.Location = New System.Drawing.Point(0, 42)
        Me.btnCambiarPass.Name = "btnCambiarPass"
        Me.btnCambiarPass.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCambiarPass.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCambiarPass.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCambiarPass.OnHoverImage = Nothing
        Me.btnCambiarPass.OnPressedColor = System.Drawing.Color.Black
        Me.btnCambiarPass.Size = New System.Drawing.Size(179, 42)
        Me.btnCambiarPass.TabIndex = 200
        Me.btnCambiarPass.Text = "Cambiar contraseña"
        Me.btnCambiarPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVerPerfil
        '
        Me.btnVerPerfil.Animated = True
        Me.btnVerPerfil.AnimationHoverSpeed = 0.07!
        Me.btnVerPerfil.AnimationSpeed = 0.03!
        Me.btnVerPerfil.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnVerPerfil.BorderColor = System.Drawing.Color.Black
        Me.btnVerPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerPerfil.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnVerPerfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVerPerfil.FocusedColor = System.Drawing.Color.Empty
        Me.btnVerPerfil.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPerfil.ForeColor = System.Drawing.Color.White
        Me.btnVerPerfil.Image = Nothing
        Me.btnVerPerfil.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnVerPerfil.Location = New System.Drawing.Point(0, 0)
        Me.btnVerPerfil.Name = "btnVerPerfil"
        Me.btnVerPerfil.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnVerPerfil.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnVerPerfil.OnHoverForeColor = System.Drawing.Color.White
        Me.btnVerPerfil.OnHoverImage = Nothing
        Me.btnVerPerfil.OnPressedColor = System.Drawing.Color.Black
        Me.btnVerPerfil.Size = New System.Drawing.Size(179, 42)
        Me.btnVerPerfil.TabIndex = 199
        Me.btnVerPerfil.Text = "Ver perfil"
        Me.btnVerPerfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlNotis
        '
        Me.pnlNotis.Controls.Add(Me.lblNA)
        Me.pnlNotis.Controls.Add(Me.btnNo)
        Me.pnlNotis.Controls.Add(Me.btnSi)
        Me.pnlNotis.Controls.Add(Me.lblIniciarConversacion)
        Me.pnlNotis.Controls.Add(Me.lblIniciarCOnv)
        Me.pnlNotis.Location = New System.Drawing.Point(615, 82)
        Me.pnlNotis.Name = "pnlNotis"
        Me.pnlNotis.Size = New System.Drawing.Size(345, 232)
        Me.pnlNotis.TabIndex = 28
        Me.pnlNotis.Visible = False
        '
        'lblNA
        '
        Me.lblNA.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNA.ForeColor = System.Drawing.Color.Silver
        Me.lblNA.Location = New System.Drawing.Point(18, 21)
        Me.lblNA.Name = "lblNA"
        Me.lblNA.Size = New System.Drawing.Size(309, 197)
        Me.lblNA.TabIndex = 12
        Me.lblNA.Text = "No hay respuestas"
        Me.lblNA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNA.Visible = False
        '
        'btnNo
        '
        Me.btnNo.Animated = True
        Me.btnNo.AnimationHoverSpeed = 0.07!
        Me.btnNo.AnimationSpeed = 0.03!
        Me.btnNo.BackColor = System.Drawing.Color.Transparent
        Me.btnNo.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnNo.BorderColor = System.Drawing.Color.Black
        Me.btnNo.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnNo.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnNo.CheckedForeColor = System.Drawing.Color.White
        Me.btnNo.CheckedImage = CType(resources.GetObject("btnNo.CheckedImage"), System.Drawing.Image)
        Me.btnNo.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnNo.FocusedColor = System.Drawing.Color.Empty
        Me.btnNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.ForeColor = System.Drawing.Color.White
        Me.btnNo.Image = Nothing
        Me.btnNo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnNo.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnNo.Location = New System.Drawing.Point(184, 166)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnNo.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnNo.OnHoverForeColor = System.Drawing.Color.White
        Me.btnNo.OnHoverImage = Nothing
        Me.btnNo.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnNo.OnPressedColor = System.Drawing.Color.Black
        Me.btnNo.Radius = 15
        Me.btnNo.Size = New System.Drawing.Size(125, 32)
        Me.btnNo.TabIndex = 11
        Me.btnNo.Text = "No"
        Me.btnNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSi
        '
        Me.btnSi.Animated = True
        Me.btnSi.AnimationHoverSpeed = 0.07!
        Me.btnSi.AnimationSpeed = 0.03!
        Me.btnSi.BackColor = System.Drawing.Color.Transparent
        Me.btnSi.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSi.BorderColor = System.Drawing.Color.Black
        Me.btnSi.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSi.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSi.CheckedForeColor = System.Drawing.Color.White
        Me.btnSi.CheckedImage = CType(resources.GetObject("btnSi.CheckedImage"), System.Drawing.Image)
        Me.btnSi.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSi.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSi.FocusedColor = System.Drawing.Color.Empty
        Me.btnSi.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSi.ForeColor = System.Drawing.Color.White
        Me.btnSi.Image = Nothing
        Me.btnSi.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSi.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSi.Location = New System.Drawing.Point(39, 165)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSi.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSi.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSi.OnHoverImage = Nothing
        Me.btnSi.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSi.OnPressedColor = System.Drawing.Color.Black
        Me.btnSi.Radius = 15
        Me.btnSi.Size = New System.Drawing.Size(125, 32)
        Me.btnSi.TabIndex = 10
        Me.btnSi.Text = "Sí"
        Me.btnSi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblIniciarConversacion
        '
        Me.lblIniciarConversacion.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIniciarConversacion.ForeColor = System.Drawing.Color.Silver
        Me.lblIniciarConversacion.Location = New System.Drawing.Point(24, 89)
        Me.lblIniciarConversacion.Name = "lblIniciarConversacion"
        Me.lblIniciarConversacion.Size = New System.Drawing.Size(304, 46)
        Me.lblIniciarConversacion.TabIndex = 1
        Me.lblIniciarConversacion.Text = "¿Desea Iniciar la conversación?"
        Me.lblIniciarConversacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIniciarCOnv
        '
        Me.lblIniciarCOnv.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIniciarCOnv.ForeColor = System.Drawing.Color.Silver
        Me.lblIniciarCOnv.Location = New System.Drawing.Point(19, 4)
        Me.lblIniciarCOnv.Name = "lblIniciarCOnv"
        Me.lblIniciarCOnv.Size = New System.Drawing.Size(309, 89)
        Me.lblIniciarCOnv.TabIndex = 0
        Me.lblIniciarCOnv.Text = "Ha recibido una respuesta del médico"
        Me.lblIniciarCOnv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCerrar
        '
        Me.pnlCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlCerrar.Controls.Add(Me.pnlNoti)
        Me.pnlCerrar.Controls.Add(Me.PictureBox1)
        Me.pnlCerrar.Controls.Add(Me.btnNoti)
        Me.pnlCerrar.Controls.Add(Me.IconButton1)
        Me.pnlCerrar.Location = New System.Drawing.Point(0, 0)
        Me.pnlCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlCerrar.Name = "pnlCerrar"
        Me.pnlCerrar.Size = New System.Drawing.Size(1070, 80)
        Me.pnlCerrar.TabIndex = 26
        '
        'pnlNoti
        '
        Me.pnlNoti.BackColor = System.Drawing.Color.Transparent
        Me.pnlNoti.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlNoti.Location = New System.Drawing.Point(858, 29)
        Me.pnlNoti.Name = "pnlNoti"
        Me.pnlNoti.Radius = 5
        Me.pnlNoti.Size = New System.Drawing.Size(10, 10)
        Me.pnlNoti.TabIndex = 9
        Me.pnlNoti.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Vista.My.Resources.Resources.LOGO_MEDICARE_SIN_SUB_WHITE_V2_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnNoti
        '
        Me.btnNoti.BackColor = System.Drawing.Color.Transparent
        Me.btnNoti.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNoti.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNoti.IconChar = FontAwesome.Sharp.IconChar.Bell
        Me.btnNoti.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btnNoti.Location = New System.Drawing.Point(836, 32)
        Me.btnNoti.Name = "btnNoti"
        Me.btnNoti.Size = New System.Drawing.Size(32, 32)
        Me.btnNoti.TabIndex = 4
        Me.btnNoti.TabStop = False
        '
        'IconButton1
        '
        Me.IconButton1.BackgroundImage = CType(resources.GetObject("IconButton1.BackgroundImage"), System.Drawing.Image)
        Me.IconButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.CaretDown
        Me.IconButton1.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton1.IconSize = 16
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(874, 29)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(86, 32)
        Me.IconButton1.TabIndex = 3
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel10.Controls.Add(Me.pnlListado)
        Me.Panel10.Controls.Add(Me.pnlConsultaActual)
        Me.Panel10.Controls.Add(Me.pnlIngresar)
        Me.Panel10.Controls.Add(Me.Panel3)
        Me.Panel10.Controls.Add(Me.pnlReanudar)
        Me.Panel10.Location = New System.Drawing.Point(55, 209)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(965, 336)
        Me.Panel10.TabIndex = 9
        '
        'pnlListado
        '
        Me.pnlListado.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlListado.Controls.Add(Me.btnListadoPac)
        Me.pnlListado.Controls.Add(Me.lblListadoPatPac)
        Me.pnlListado.Controls.Add(Me.Panel7)
        Me.pnlListado.Controls.Add(Me.lblSubListadoPat)
        Me.pnlListado.Location = New System.Drawing.Point(735, 41)
        Me.pnlListado.Name = "pnlListado"
        Me.pnlListado.Size = New System.Drawing.Size(183, 248)
        Me.pnlListado.TabIndex = 202
        '
        'btnListadoPac
        '
        Me.btnListadoPac.Animated = True
        Me.btnListadoPac.AnimationHoverSpeed = 0.07!
        Me.btnListadoPac.AnimationSpeed = 0.03!
        Me.btnListadoPac.BackColor = System.Drawing.Color.Transparent
        Me.btnListadoPac.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnListadoPac.BorderColor = System.Drawing.Color.Black
        Me.btnListadoPac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListadoPac.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnListadoPac.FocusedColor = System.Drawing.Color.Empty
        Me.btnListadoPac.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoPac.ForeColor = System.Drawing.Color.White
        Me.btnListadoPac.Image = Nothing
        Me.btnListadoPac.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnListadoPac.Location = New System.Drawing.Point(33, 181)
        Me.btnListadoPac.Name = "btnListadoPac"
        Me.btnListadoPac.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnListadoPac.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnListadoPac.OnHoverForeColor = System.Drawing.Color.White
        Me.btnListadoPac.OnHoverImage = Nothing
        Me.btnListadoPac.OnPressedColor = System.Drawing.Color.Black
        Me.btnListadoPac.Radius = 12
        Me.btnListadoPac.Size = New System.Drawing.Size(117, 32)
        Me.btnListadoPac.TabIndex = 200
        Me.btnListadoPac.Text = "Ingresar"
        Me.btnListadoPac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblListadoPatPac
        '
        Me.lblListadoPatPac.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoPatPac.ForeColor = System.Drawing.Color.White
        Me.lblListadoPatPac.Location = New System.Drawing.Point(1, 28)
        Me.lblListadoPatPac.Name = "lblListadoPatPac"
        Me.lblListadoPatPac.Size = New System.Drawing.Size(180, 53)
        Me.lblListadoPatPac.TabIndex = 5
        Me.lblListadoPatPac.Text = "Listado de patologías"
        Me.lblListadoPatPac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 241)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(183, 7)
        Me.Panel7.TabIndex = 3
        '
        'lblSubListadoPat
        '
        Me.lblSubListadoPat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubListadoPat.ForeColor = System.Drawing.Color.White
        Me.lblSubListadoPat.Location = New System.Drawing.Point(10, 94)
        Me.lblSubListadoPat.Name = "lblSubListadoPat"
        Me.lblSubListadoPat.Size = New System.Drawing.Size(162, 59)
        Me.lblSubListadoPat.TabIndex = 2
        Me.lblSubListadoPat.Text = "Vea todas las patologías registradas en la aplicación"
        Me.lblSubListadoPat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlConsultaActual
        '
        Me.pnlConsultaActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlConsultaActual.Controls.Add(Me.btnConsultaActual)
        Me.pnlConsultaActual.Controls.Add(Me.lblCOnsultaa)
        Me.pnlConsultaActual.Controls.Add(Me.Panel5)
        Me.pnlConsultaActual.Controls.Add(Me.lblVerConsultaaa)
        Me.pnlConsultaActual.Location = New System.Drawing.Point(735, 41)
        Me.pnlConsultaActual.Name = "pnlConsultaActual"
        Me.pnlConsultaActual.Size = New System.Drawing.Size(183, 248)
        Me.pnlConsultaActual.TabIndex = 201
        '
        'btnConsultaActual
        '
        Me.btnConsultaActual.Animated = True
        Me.btnConsultaActual.AnimationHoverSpeed = 0.07!
        Me.btnConsultaActual.AnimationSpeed = 0.03!
        Me.btnConsultaActual.BackColor = System.Drawing.Color.Transparent
        Me.btnConsultaActual.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnConsultaActual.BorderColor = System.Drawing.Color.Black
        Me.btnConsultaActual.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnConsultaActual.FocusedColor = System.Drawing.Color.Empty
        Me.btnConsultaActual.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultaActual.ForeColor = System.Drawing.Color.White
        Me.btnConsultaActual.Image = Nothing
        Me.btnConsultaActual.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnConsultaActual.Location = New System.Drawing.Point(33, 181)
        Me.btnConsultaActual.Name = "btnConsultaActual"
        Me.btnConsultaActual.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnConsultaActual.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnConsultaActual.OnHoverForeColor = System.Drawing.Color.White
        Me.btnConsultaActual.OnHoverImage = Nothing
        Me.btnConsultaActual.OnPressedColor = System.Drawing.Color.Black
        Me.btnConsultaActual.Radius = 12
        Me.btnConsultaActual.Size = New System.Drawing.Size(117, 32)
        Me.btnConsultaActual.TabIndex = 200
        Me.btnConsultaActual.Text = "Ingresar"
        Me.btnConsultaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCOnsultaa
        '
        Me.lblCOnsultaa.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCOnsultaa.ForeColor = System.Drawing.Color.White
        Me.lblCOnsultaa.Location = New System.Drawing.Point(3, 28)
        Me.lblCOnsultaa.Name = "lblCOnsultaa"
        Me.lblCOnsultaa.Size = New System.Drawing.Size(180, 25)
        Me.lblCOnsultaa.TabIndex = 5
        Me.lblCOnsultaa.Text = "Consulta actual"
        Me.lblCOnsultaa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 241)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(183, 7)
        Me.Panel5.TabIndex = 3
        '
        'lblVerConsultaaa
        '
        Me.lblVerConsultaaa.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerConsultaaa.ForeColor = System.Drawing.Color.White
        Me.lblVerConsultaaa.Location = New System.Drawing.Point(3, 81)
        Me.lblVerConsultaaa.Name = "lblVerConsultaaa"
        Me.lblVerConsultaaa.Size = New System.Drawing.Size(177, 59)
        Me.lblVerConsultaaa.TabIndex = 2
        Me.lblVerConsultaaa.Text = "Vea su consulta mientras espera"
        Me.lblVerConsultaaa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlIngresar
        '
        Me.pnlIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlIngresar.Controls.Add(Me.btnIngresarSinPac)
        Me.pnlIngresar.Controls.Add(Me.Panel2)
        Me.pnlIngresar.Controls.Add(Me.lblSubIngSin)
        Me.pnlIngresar.Controls.Add(Me.lblIngSinPac)
        Me.pnlIngresar.Location = New System.Drawing.Point(286, 41)
        Me.pnlIngresar.Name = "pnlIngresar"
        Me.pnlIngresar.Size = New System.Drawing.Size(393, 276)
        Me.pnlIngresar.TabIndex = 0
        '
        'btnIngresarSinPac
        '
        Me.btnIngresarSinPac.Animated = True
        Me.btnIngresarSinPac.AnimationHoverSpeed = 0.07!
        Me.btnIngresarSinPac.AnimationSpeed = 0.03!
        Me.btnIngresarSinPac.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresarSinPac.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnIngresarSinPac.BorderColor = System.Drawing.Color.Black
        Me.btnIngresarSinPac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresarSinPac.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnIngresarSinPac.FocusedColor = System.Drawing.Color.Empty
        Me.btnIngresarSinPac.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarSinPac.ForeColor = System.Drawing.Color.White
        Me.btnIngresarSinPac.Image = Nothing
        Me.btnIngresarSinPac.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnIngresarSinPac.Location = New System.Drawing.Point(85, 208)
        Me.btnIngresarSinPac.Name = "btnIngresarSinPac"
        Me.btnIngresarSinPac.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnIngresarSinPac.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnIngresarSinPac.OnHoverForeColor = System.Drawing.Color.White
        Me.btnIngresarSinPac.OnHoverImage = Nothing
        Me.btnIngresarSinPac.OnPressedColor = System.Drawing.Color.Black
        Me.btnIngresarSinPac.Radius = 12
        Me.btnIngresarSinPac.Size = New System.Drawing.Size(213, 32)
        Me.btnIngresarSinPac.TabIndex = 199
        Me.btnIngresarSinPac.Text = "Ingresar"
        Me.btnIngresarSinPac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 266)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 10)
        Me.Panel2.TabIndex = 3
        '
        'lblSubIngSin
        '
        Me.lblSubIngSin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubIngSin.ForeColor = System.Drawing.Color.White
        Me.lblSubIngSin.Location = New System.Drawing.Point(70, 101)
        Me.lblSubIngSin.Name = "lblSubIngSin"
        Me.lblSubIngSin.Size = New System.Drawing.Size(252, 73)
        Me.lblSubIngSin.TabIndex = 2
        Me.lblSubIngSin.Text = "Dígamos cuáles son sus síntomas y le daremos un diagnóstico primario"
        Me.lblSubIngSin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIngSinPac
        '
        Me.lblIngSinPac.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngSinPac.ForeColor = System.Drawing.Color.White
        Me.lblIngSinPac.Location = New System.Drawing.Point(3, 29)
        Me.lblIngSinPac.Name = "lblIngSinPac"
        Me.lblIngSinPac.Size = New System.Drawing.Size(387, 37)
        Me.lblIngSinPac.TabIndex = 1
        Me.lblIngSinPac.Text = "Ingresar síntomas"
        Me.lblIngSinPac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnHistorialPac)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.lblSubMiHistoiralPac)
        Me.Panel3.Controls.Add(Me.lblMiHistorialPac)
        Me.Panel3.Location = New System.Drawing.Point(52, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 248)
        Me.Panel3.TabIndex = 5
        '
        'btnHistorialPac
        '
        Me.btnHistorialPac.Animated = True
        Me.btnHistorialPac.AnimationHoverSpeed = 0.07!
        Me.btnHistorialPac.AnimationSpeed = 0.03!
        Me.btnHistorialPac.BackColor = System.Drawing.Color.Transparent
        Me.btnHistorialPac.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnHistorialPac.BorderColor = System.Drawing.Color.Black
        Me.btnHistorialPac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistorialPac.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHistorialPac.FocusedColor = System.Drawing.Color.Empty
        Me.btnHistorialPac.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialPac.ForeColor = System.Drawing.Color.White
        Me.btnHistorialPac.Image = Nothing
        Me.btnHistorialPac.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnHistorialPac.Location = New System.Drawing.Point(31, 181)
        Me.btnHistorialPac.Name = "btnHistorialPac"
        Me.btnHistorialPac.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnHistorialPac.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHistorialPac.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHistorialPac.OnHoverImage = Nothing
        Me.btnHistorialPac.OnPressedColor = System.Drawing.Color.Black
        Me.btnHistorialPac.Radius = 12
        Me.btnHistorialPac.Size = New System.Drawing.Size(128, 32)
        Me.btnHistorialPac.TabIndex = 198
        Me.btnHistorialPac.Text = "Ingresar"
        Me.btnHistorialPac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel4.Location = New System.Drawing.Point(0, 240)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(183, 7)
        Me.Panel4.TabIndex = 3
        '
        'lblSubMiHistoiralPac
        '
        Me.lblSubMiHistoiralPac.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubMiHistoiralPac.ForeColor = System.Drawing.Color.White
        Me.lblSubMiHistoiralPac.Location = New System.Drawing.Point(20, 78)
        Me.lblSubMiHistoiralPac.Name = "lblSubMiHistoiralPac"
        Me.lblSubMiHistoiralPac.Size = New System.Drawing.Size(143, 59)
        Me.lblSubMiHistoiralPac.TabIndex = 2
        Me.lblSubMiHistoiralPac.Text = "Vea su historial completo dentro de la aplicación"
        Me.lblSubMiHistoiralPac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMiHistorialPac
        '
        Me.lblMiHistorialPac.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiHistorialPac.ForeColor = System.Drawing.Color.White
        Me.lblMiHistorialPac.Location = New System.Drawing.Point(3, 29)
        Me.lblMiHistorialPac.Name = "lblMiHistorialPac"
        Me.lblMiHistorialPac.Size = New System.Drawing.Size(177, 25)
        Me.lblMiHistorialPac.TabIndex = 1
        Me.lblMiHistorialPac.Text = "Mi historial"
        Me.lblMiHistorialPac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlReanudar
        '
        Me.pnlReanudar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlReanudar.Controls.Add(Me.btnReanudar)
        Me.pnlReanudar.Controls.Add(Me.lblReanudarChatt)
        Me.pnlReanudar.Controls.Add(Me.Panel6)
        Me.pnlReanudar.Controls.Add(Me.lblContinuarChat)
        Me.pnlReanudar.Location = New System.Drawing.Point(735, 41)
        Me.pnlReanudar.Name = "pnlReanudar"
        Me.pnlReanudar.Size = New System.Drawing.Size(183, 248)
        Me.pnlReanudar.TabIndex = 6
        '
        'btnReanudar
        '
        Me.btnReanudar.Animated = True
        Me.btnReanudar.AnimationHoverSpeed = 0.07!
        Me.btnReanudar.AnimationSpeed = 0.03!
        Me.btnReanudar.BackColor = System.Drawing.Color.Transparent
        Me.btnReanudar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnReanudar.BorderColor = System.Drawing.Color.Black
        Me.btnReanudar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnReanudar.FocusedColor = System.Drawing.Color.Empty
        Me.btnReanudar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReanudar.ForeColor = System.Drawing.Color.White
        Me.btnReanudar.Image = Nothing
        Me.btnReanudar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnReanudar.Location = New System.Drawing.Point(33, 181)
        Me.btnReanudar.Name = "btnReanudar"
        Me.btnReanudar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnReanudar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnReanudar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnReanudar.OnHoverImage = Nothing
        Me.btnReanudar.OnPressedColor = System.Drawing.Color.Black
        Me.btnReanudar.Radius = 12
        Me.btnReanudar.Size = New System.Drawing.Size(117, 32)
        Me.btnReanudar.TabIndex = 200
        Me.btnReanudar.Text = "Ingresar"
        Me.btnReanudar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblReanudarChatt
        '
        Me.lblReanudarChatt.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReanudarChatt.ForeColor = System.Drawing.Color.White
        Me.lblReanudarChatt.Location = New System.Drawing.Point(3, 28)
        Me.lblReanudarChatt.Name = "lblReanudarChatt"
        Me.lblReanudarChatt.Size = New System.Drawing.Size(180, 25)
        Me.lblReanudarChatt.TabIndex = 5
        Me.lblReanudarChatt.Text = "Reanudar chat"
        Me.lblReanudarChatt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel6.Location = New System.Drawing.Point(0, 240)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(183, 7)
        Me.Panel6.TabIndex = 3
        '
        'lblContinuarChat
        '
        Me.lblContinuarChat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContinuarChat.ForeColor = System.Drawing.Color.White
        Me.lblContinuarChat.Location = New System.Drawing.Point(15, 81)
        Me.lblContinuarChat.Name = "lblContinuarChat"
        Me.lblContinuarChat.Size = New System.Drawing.Size(143, 59)
        Me.lblContinuarChat.TabIndex = 2
        Me.lblContinuarChat.Text = "Continuar chat con médico"
        Me.lblContinuarChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1070, 650)
        Me.pnlInstancia.TabIndex = 7
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 5000
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 3000
        '
        'timVerificarSiSolicitud
        '
        Me.timVerificarSiSolicitud.Enabled = True
        Me.timVerificarSiSolicitud.Interval = 3000
        '
        'frmBienvenidaPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBienvenidaPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.pnlOps.ResumeLayout(False)
        Me.pnlNotis.ResumeLayout(False)
        Me.pnlCerrar.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNoti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.pnlListado.ResumeLayout(False)
        Me.pnlConsultaActual.ResumeLayout(False)
        Me.pnlIngresar.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.pnlReanudar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents notificacion As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents pnlIngresar As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSubIngSin As Label
    Friend WithEvents lblIngSinPac As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblSubMiHistoiralPac As Label
    Friend WithEvents lblMiHistorialPac As Label
    Friend WithEvents pnlReanudar As Panel
    Friend WithEvents lblReanudarChatt As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblContinuarChat As Label
    Friend WithEvents pnlCerrar As Panel
    Friend WithEvents pnlNoti As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNoti As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Public WithEvents pnlInstancia As Panel
    Friend WithEvents pnlNotis As Panel
    Friend WithEvents lblIniciarCOnv As Label
    Friend WithEvents lblIniciarConversacion As Label
    Friend WithEvents btnNo As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnSi As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblNA As Label
    Friend WithEvents btnHistorialPac As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnIngresarSinPac As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnReanudar As Guna.UI.WinForms.GunaButton
    Friend WithEvents Timer3 As Timer
    Friend WithEvents pnlOps As Panel
    Friend WithEvents btnCerrarSesion As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCambiarPass As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnVerPerfil As Guna.UI.WinForms.GunaButton
    Friend WithEvents timVerificarSiSolicitud As Timer
    Friend WithEvents pnlConsultaActual As Panel
    Friend WithEvents btnConsultaActual As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblCOnsultaa As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblVerConsultaaa As Label
    Friend WithEvents pnlListado As Panel
    Friend WithEvents btnListadoPac As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblListadoPatPac As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblSubListadoPat As Label
End Class
