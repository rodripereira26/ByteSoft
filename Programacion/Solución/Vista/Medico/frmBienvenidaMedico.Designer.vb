<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBienvenidaMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBienvenidaMedico))
        Me.timerChat = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlOps = New System.Windows.Forms.Panel()
        Me.btnCerrarSesionMedico = New Guna.UI.WinForms.GunaButton()
        Me.btnCambiarPassMedico = New Guna.UI.WinForms.GunaButton()
        Me.btnVerPerfilMedico = New Guna.UI.WinForms.GunaButton()
        Me.lblNuevosMsg = New System.Windows.Forms.Label()
        Me.lblNAChats = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlCerrar = New System.Windows.Forms.Panel()
        Me.pnlNotificacion = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblNotiMsg = New System.Windows.Forms.Label()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlNoti = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblNotiChats = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNoti = New FontAwesome.Sharp.IconPictureBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnIngresarChatsPaciente = New Guna.UI.WinForms.GunaButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSubChats = New System.Windows.Forms.Label()
        Me.lblTituloChats = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnHistorialMedico = New Guna.UI.WinForms.GunaButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblSubHistorial = New System.Windows.Forms.Label()
        Me.lblTituloHistorial = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnListadoPatMedico = New Guna.UI.WinForms.GunaButton()
        Me.lblTituloListadoPatMedico = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblListadoPatMedico = New System.Windows.Forms.Label()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.timerMsg = New System.Windows.Forms.Timer(Me.components)
        Me.Redondear = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.pnlContenedor.SuspendLayout()
        Me.pnlOps.SuspendLayout()
        Me.pnlCerrar.SuspendLayout()
        Me.pnlNotificacion.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNoti.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNoti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'timerChat
        '
        Me.timerChat.Enabled = True
        Me.timerChat.Interval = 4000
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.pnlOps)
        Me.pnlContenedor.Controls.Add(Me.lblNuevosMsg)
        Me.pnlContenedor.Controls.Add(Me.lblNAChats)
        Me.pnlContenedor.Controls.Add(Me.FlowLayoutPanel1)
        Me.pnlContenedor.Controls.Add(Me.pnlCerrar)
        Me.pnlContenedor.Controls.Add(Me.Panel10)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 23
        '
        'pnlOps
        '
        Me.pnlOps.Controls.Add(Me.btnCerrarSesionMedico)
        Me.pnlOps.Controls.Add(Me.btnCambiarPassMedico)
        Me.pnlOps.Controls.Add(Me.btnVerPerfilMedico)
        Me.pnlOps.Location = New System.Drawing.Point(828, 80)
        Me.pnlOps.Name = "pnlOps"
        Me.pnlOps.Size = New System.Drawing.Size(179, 128)
        Me.pnlOps.TabIndex = 32
        Me.pnlOps.Visible = False
        '
        'btnCerrarSesionMedico
        '
        Me.btnCerrarSesionMedico.Animated = True
        Me.btnCerrarSesionMedico.AnimationHoverSpeed = 0.07!
        Me.btnCerrarSesionMedico.AnimationSpeed = 0.03!
        Me.btnCerrarSesionMedico.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnCerrarSesionMedico.BorderColor = System.Drawing.Color.Black
        Me.btnCerrarSesionMedico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesionMedico.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCerrarSesionMedico.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCerrarSesionMedico.FocusedColor = System.Drawing.Color.Empty
        Me.btnCerrarSesionMedico.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesionMedico.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesionMedico.Image = Nothing
        Me.btnCerrarSesionMedico.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCerrarSesionMedico.Location = New System.Drawing.Point(0, 84)
        Me.btnCerrarSesionMedico.Name = "btnCerrarSesionMedico"
        Me.btnCerrarSesionMedico.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCerrarSesionMedico.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCerrarSesionMedico.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCerrarSesionMedico.OnHoverImage = Nothing
        Me.btnCerrarSesionMedico.OnPressedColor = System.Drawing.Color.Black
        Me.btnCerrarSesionMedico.Size = New System.Drawing.Size(179, 42)
        Me.btnCerrarSesionMedico.TabIndex = 201
        Me.btnCerrarSesionMedico.Text = "Cerrar sesión"
        Me.btnCerrarSesionMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCambiarPassMedico
        '
        Me.btnCambiarPassMedico.Animated = True
        Me.btnCambiarPassMedico.AnimationHoverSpeed = 0.07!
        Me.btnCambiarPassMedico.AnimationSpeed = 0.03!
        Me.btnCambiarPassMedico.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnCambiarPassMedico.BorderColor = System.Drawing.Color.Black
        Me.btnCambiarPassMedico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiarPassMedico.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCambiarPassMedico.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCambiarPassMedico.FocusedColor = System.Drawing.Color.Empty
        Me.btnCambiarPassMedico.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarPassMedico.ForeColor = System.Drawing.Color.White
        Me.btnCambiarPassMedico.Image = Nothing
        Me.btnCambiarPassMedico.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCambiarPassMedico.Location = New System.Drawing.Point(0, 42)
        Me.btnCambiarPassMedico.Name = "btnCambiarPassMedico"
        Me.btnCambiarPassMedico.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCambiarPassMedico.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCambiarPassMedico.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCambiarPassMedico.OnHoverImage = Nothing
        Me.btnCambiarPassMedico.OnPressedColor = System.Drawing.Color.Black
        Me.btnCambiarPassMedico.Size = New System.Drawing.Size(179, 42)
        Me.btnCambiarPassMedico.TabIndex = 200
        Me.btnCambiarPassMedico.Text = "Cambiar contraseña"
        Me.btnCambiarPassMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVerPerfilMedico
        '
        Me.btnVerPerfilMedico.Animated = True
        Me.btnVerPerfilMedico.AnimationHoverSpeed = 0.07!
        Me.btnVerPerfilMedico.AnimationSpeed = 0.03!
        Me.btnVerPerfilMedico.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnVerPerfilMedico.BorderColor = System.Drawing.Color.Black
        Me.btnVerPerfilMedico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerPerfilMedico.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnVerPerfilMedico.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVerPerfilMedico.FocusedColor = System.Drawing.Color.Empty
        Me.btnVerPerfilMedico.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPerfilMedico.ForeColor = System.Drawing.Color.White
        Me.btnVerPerfilMedico.Image = Nothing
        Me.btnVerPerfilMedico.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnVerPerfilMedico.Location = New System.Drawing.Point(0, 0)
        Me.btnVerPerfilMedico.Name = "btnVerPerfilMedico"
        Me.btnVerPerfilMedico.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnVerPerfilMedico.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnVerPerfilMedico.OnHoverForeColor = System.Drawing.Color.White
        Me.btnVerPerfilMedico.OnHoverImage = Nothing
        Me.btnVerPerfilMedico.OnPressedColor = System.Drawing.Color.Black
        Me.btnVerPerfilMedico.Size = New System.Drawing.Size(179, 42)
        Me.btnVerPerfilMedico.TabIndex = 199
        Me.btnVerPerfilMedico.Text = "Ver perfil"
        Me.btnVerPerfilMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNuevosMsg
        '
        Me.lblNuevosMsg.AutoSize = True
        Me.lblNuevosMsg.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevosMsg.ForeColor = System.Drawing.Color.White
        Me.lblNuevosMsg.Location = New System.Drawing.Point(398, 182)
        Me.lblNuevosMsg.Name = "lblNuevosMsg"
        Me.lblNuevosMsg.Size = New System.Drawing.Size(0, 32)
        Me.lblNuevosMsg.TabIndex = 29
        '
        'lblNAChats
        '
        Me.lblNAChats.AutoSize = True
        Me.lblNAChats.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblNAChats.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNAChats.ForeColor = System.Drawing.Color.Silver
        Me.lblNAChats.Location = New System.Drawing.Point(600, 305)
        Me.lblNAChats.Name = "lblNAChats"
        Me.lblNAChats.Size = New System.Drawing.Size(297, 32)
        Me.lblNAChats.TabIndex = 0
        Me.lblNAChats.Text = "No hay solicitudes de chat"
        Me.lblNAChats.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(539, 78)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(420, 497)
        Me.FlowLayoutPanel1.TabIndex = 31
        Me.FlowLayoutPanel1.Visible = False
        '
        'pnlCerrar
        '
        Me.pnlCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlCerrar.Controls.Add(Me.pnlNotificacion)
        Me.pnlCerrar.Controls.Add(Me.IconPictureBox2)
        Me.pnlCerrar.Controls.Add(Me.pnlNoti)
        Me.pnlCerrar.Controls.Add(Me.PictureBox1)
        Me.pnlCerrar.Controls.Add(Me.btnNoti)
        Me.pnlCerrar.Controls.Add(Me.IconButton1)
        Me.pnlCerrar.Location = New System.Drawing.Point(0, 0)
        Me.pnlCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlCerrar.Name = "pnlCerrar"
        Me.pnlCerrar.Size = New System.Drawing.Size(1070, 80)
        Me.pnlCerrar.TabIndex = 27
        '
        'pnlNotificacion
        '
        Me.pnlNotificacion.BackColor = System.Drawing.Color.Transparent
        Me.pnlNotificacion.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlNotificacion.Controls.Add(Me.lblNotiMsg)
        Me.pnlNotificacion.Location = New System.Drawing.Point(786, 27)
        Me.pnlNotificacion.Name = "pnlNotificacion"
        Me.pnlNotificacion.Size = New System.Drawing.Size(16, 16)
        Me.pnlNotificacion.TabIndex = 12
        Me.pnlNotificacion.Visible = False
        '
        'lblNotiMsg
        '
        Me.lblNotiMsg.AutoSize = True
        Me.lblNotiMsg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNotiMsg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotiMsg.ForeColor = System.Drawing.Color.White
        Me.lblNotiMsg.Location = New System.Drawing.Point(-1, 1)
        Me.lblNotiMsg.Name = "lblNotiMsg"
        Me.lblNotiMsg.Size = New System.Drawing.Size(13, 13)
        Me.lblNotiMsg.TabIndex = 0
        Me.lblNotiMsg.Text = "0"
        Me.lblNotiMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNotiMsg.Visible = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CommentAlt
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.Location = New System.Drawing.Point(768, 30)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.IconPictureBox2.TabIndex = 13
        Me.IconPictureBox2.TabStop = False
        '
        'pnlNoti
        '
        Me.pnlNoti.BackColor = System.Drawing.Color.Transparent
        Me.pnlNoti.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlNoti.Controls.Add(Me.lblNotiChats)
        Me.pnlNoti.Location = New System.Drawing.Point(835, 27)
        Me.pnlNoti.Name = "pnlNoti"
        Me.pnlNoti.Size = New System.Drawing.Size(16, 16)
        Me.pnlNoti.TabIndex = 9
        Me.pnlNoti.Visible = False
        '
        'lblNotiChats
        '
        Me.lblNotiChats.AutoSize = True
        Me.lblNotiChats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNotiChats.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotiChats.ForeColor = System.Drawing.Color.White
        Me.lblNotiChats.Location = New System.Drawing.Point(-1, 1)
        Me.lblNotiChats.Name = "lblNotiChats"
        Me.lblNotiChats.Size = New System.Drawing.Size(13, 13)
        Me.lblNotiChats.TabIndex = 1
        Me.lblNotiChats.Text = "0"
        Me.lblNotiChats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNotiChats.Visible = False
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
        Me.btnNoti.Location = New System.Drawing.Point(816, 31)
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
        Me.IconButton1.Location = New System.Drawing.Point(857, 27)
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
        Me.Panel10.Controls.Add(Me.Panel1)
        Me.Panel10.Controls.Add(Me.Panel3)
        Me.Panel10.Controls.Add(Me.Panel5)
        Me.Panel10.Location = New System.Drawing.Point(61, 212)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(965, 336)
        Me.Panel10.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnIngresarChatsPaciente)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblSubChats)
        Me.Panel1.Controls.Add(Me.lblTituloChats)
        Me.Panel1.Location = New System.Drawing.Point(287, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 276)
        Me.Panel1.TabIndex = 0
        '
        'btnIngresarChatsPaciente
        '
        Me.btnIngresarChatsPaciente.Animated = True
        Me.btnIngresarChatsPaciente.AnimationHoverSpeed = 0.07!
        Me.btnIngresarChatsPaciente.AnimationSpeed = 0.03!
        Me.btnIngresarChatsPaciente.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresarChatsPaciente.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnIngresarChatsPaciente.BorderColor = System.Drawing.Color.Black
        Me.btnIngresarChatsPaciente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIngresarChatsPaciente.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnIngresarChatsPaciente.FocusedColor = System.Drawing.Color.Empty
        Me.btnIngresarChatsPaciente.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarChatsPaciente.ForeColor = System.Drawing.Color.White
        Me.btnIngresarChatsPaciente.Image = Nothing
        Me.btnIngresarChatsPaciente.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnIngresarChatsPaciente.Location = New System.Drawing.Point(85, 208)
        Me.btnIngresarChatsPaciente.Name = "btnIngresarChatsPaciente"
        Me.btnIngresarChatsPaciente.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnIngresarChatsPaciente.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnIngresarChatsPaciente.OnHoverForeColor = System.Drawing.Color.White
        Me.btnIngresarChatsPaciente.OnHoverImage = Nothing
        Me.btnIngresarChatsPaciente.OnPressedColor = System.Drawing.Color.Black
        Me.btnIngresarChatsPaciente.Radius = 12
        Me.btnIngresarChatsPaciente.Size = New System.Drawing.Size(213, 32)
        Me.btnIngresarChatsPaciente.TabIndex = 199
        Me.btnIngresarChatsPaciente.Text = "Ingresar"
        Me.btnIngresarChatsPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'lblSubChats
        '
        Me.lblSubChats.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubChats.ForeColor = System.Drawing.Color.White
        Me.lblSubChats.Location = New System.Drawing.Point(70, 101)
        Me.lblSubChats.Name = "lblSubChats"
        Me.lblSubChats.Size = New System.Drawing.Size(252, 73)
        Me.lblSubChats.TabIndex = 2
        Me.lblSubChats.Text = "Ver lista de chats que tiene con su pacientes"
        Me.lblSubChats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTituloChats
        '
        Me.lblTituloChats.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloChats.ForeColor = System.Drawing.Color.White
        Me.lblTituloChats.Location = New System.Drawing.Point(3, 29)
        Me.lblTituloChats.Name = "lblTituloChats"
        Me.lblTituloChats.Size = New System.Drawing.Size(387, 37)
        Me.lblTituloChats.TabIndex = 1
        Me.lblTituloChats.Text = "Chat"
        Me.lblTituloChats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnHistorialMedico)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.lblSubHistorial)
        Me.Panel3.Controls.Add(Me.lblTituloHistorial)
        Me.Panel3.Location = New System.Drawing.Point(52, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 248)
        Me.Panel3.TabIndex = 5
        '
        'btnHistorialMedico
        '
        Me.btnHistorialMedico.Animated = True
        Me.btnHistorialMedico.AnimationHoverSpeed = 0.07!
        Me.btnHistorialMedico.AnimationSpeed = 0.03!
        Me.btnHistorialMedico.BackColor = System.Drawing.Color.Transparent
        Me.btnHistorialMedico.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnHistorialMedico.BorderColor = System.Drawing.Color.Black
        Me.btnHistorialMedico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHistorialMedico.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHistorialMedico.FocusedColor = System.Drawing.Color.Empty
        Me.btnHistorialMedico.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistorialMedico.ForeColor = System.Drawing.Color.White
        Me.btnHistorialMedico.Image = Nothing
        Me.btnHistorialMedico.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnHistorialMedico.Location = New System.Drawing.Point(31, 181)
        Me.btnHistorialMedico.Name = "btnHistorialMedico"
        Me.btnHistorialMedico.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnHistorialMedico.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHistorialMedico.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHistorialMedico.OnHoverImage = Nothing
        Me.btnHistorialMedico.OnPressedColor = System.Drawing.Color.Black
        Me.btnHistorialMedico.Radius = 12
        Me.btnHistorialMedico.Size = New System.Drawing.Size(128, 32)
        Me.btnHistorialMedico.TabIndex = 198
        Me.btnHistorialMedico.Text = "Ingresar"
        Me.btnHistorialMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel4.Location = New System.Drawing.Point(0, 240)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(183, 7)
        Me.Panel4.TabIndex = 3
        '
        'lblSubHistorial
        '
        Me.lblSubHistorial.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubHistorial.ForeColor = System.Drawing.Color.White
        Me.lblSubHistorial.Location = New System.Drawing.Point(20, 78)
        Me.lblSubHistorial.Name = "lblSubHistorial"
        Me.lblSubHistorial.Size = New System.Drawing.Size(143, 59)
        Me.lblSubHistorial.TabIndex = 2
        Me.lblSubHistorial.Text = "Vea su historial completo dentro de la aplicación"
        Me.lblSubHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTituloHistorial
        '
        Me.lblTituloHistorial.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloHistorial.ForeColor = System.Drawing.Color.White
        Me.lblTituloHistorial.Location = New System.Drawing.Point(3, 29)
        Me.lblTituloHistorial.Name = "lblTituloHistorial"
        Me.lblTituloHistorial.Size = New System.Drawing.Size(177, 25)
        Me.lblTituloHistorial.TabIndex = 1
        Me.lblTituloHistorial.Text = "Mi historial"
        Me.lblTituloHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btnListadoPatMedico)
        Me.Panel5.Controls.Add(Me.lblTituloListadoPatMedico)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.lblListadoPatMedico)
        Me.Panel5.Location = New System.Drawing.Point(740, 41)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(183, 248)
        Me.Panel5.TabIndex = 6
        '
        'btnListadoPatMedico
        '
        Me.btnListadoPatMedico.Animated = True
        Me.btnListadoPatMedico.AnimationHoverSpeed = 0.07!
        Me.btnListadoPatMedico.AnimationSpeed = 0.03!
        Me.btnListadoPatMedico.BackColor = System.Drawing.Color.Transparent
        Me.btnListadoPatMedico.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnListadoPatMedico.BorderColor = System.Drawing.Color.Black
        Me.btnListadoPatMedico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListadoPatMedico.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnListadoPatMedico.FocusedColor = System.Drawing.Color.Empty
        Me.btnListadoPatMedico.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadoPatMedico.ForeColor = System.Drawing.Color.White
        Me.btnListadoPatMedico.Image = Nothing
        Me.btnListadoPatMedico.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnListadoPatMedico.Location = New System.Drawing.Point(33, 181)
        Me.btnListadoPatMedico.Name = "btnListadoPatMedico"
        Me.btnListadoPatMedico.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnListadoPatMedico.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnListadoPatMedico.OnHoverForeColor = System.Drawing.Color.White
        Me.btnListadoPatMedico.OnHoverImage = Nothing
        Me.btnListadoPatMedico.OnPressedColor = System.Drawing.Color.Black
        Me.btnListadoPatMedico.Radius = 12
        Me.btnListadoPatMedico.Size = New System.Drawing.Size(117, 32)
        Me.btnListadoPatMedico.TabIndex = 200
        Me.btnListadoPatMedico.Text = "Ingresar"
        Me.btnListadoPatMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTituloListadoPatMedico
        '
        Me.lblTituloListadoPatMedico.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloListadoPatMedico.ForeColor = System.Drawing.Color.White
        Me.lblTituloListadoPatMedico.Location = New System.Drawing.Point(3, 28)
        Me.lblTituloListadoPatMedico.Name = "lblTituloListadoPatMedico"
        Me.lblTituloListadoPatMedico.Size = New System.Drawing.Size(180, 53)
        Me.lblTituloListadoPatMedico.TabIndex = 5
        Me.lblTituloListadoPatMedico.Text = "Listado de patologías"
        Me.lblTituloListadoPatMedico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel6.Location = New System.Drawing.Point(0, 240)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(183, 7)
        Me.Panel6.TabIndex = 3
        '
        'lblListadoPatMedico
        '
        Me.lblListadoPatMedico.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoPatMedico.ForeColor = System.Drawing.Color.White
        Me.lblListadoPatMedico.Location = New System.Drawing.Point(21, 90)
        Me.lblListadoPatMedico.Name = "lblListadoPatMedico"
        Me.lblListadoPatMedico.Size = New System.Drawing.Size(143, 59)
        Me.lblListadoPatMedico.TabIndex = 2
        Me.lblListadoPatMedico.Text = "Vea todas las patologías registradas en la aplicación"
        Me.lblListadoPatMedico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1070, 650)
        Me.pnlInstancia.TabIndex = 7
        '
        'timerMsg
        '
        Me.timerMsg.Enabled = True
        Me.timerMsg.Interval = 5000
        '
        'Redondear
        '
        Me.Redondear.Radius = 7
        Me.Redondear.TargetControl = Me.FlowLayoutPanel1
        '
        'frmBienvenidaMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBienvenidaMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.pnlOps.ResumeLayout(False)
        Me.pnlCerrar.ResumeLayout(False)
        Me.pnlNotificacion.ResumeLayout(False)
        Me.pnlNotificacion.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNoti.ResumeLayout(False)
        Me.pnlNoti.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNoti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timerChat As Timer
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlInstancia As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnIngresarChatsPaciente As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSubChats As Label
    Friend WithEvents lblTituloChats As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnHistorialMedico As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblSubHistorial As Label
    Friend WithEvents lblTituloHistorial As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnListadoPatMedico As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblTituloListadoPatMedico As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblListadoPatMedico As Label
    Friend WithEvents pnlCerrar As Panel
    Friend WithEvents pnlNoti As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNoti As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents timerMsg As Timer
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pnlNotificacion As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblNotiMsg As Label
    Friend WithEvents lblNuevosMsg As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Redondear As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblNotiChats As Label
    Friend WithEvents lblNAChats As Label
    Friend WithEvents pnlOps As Panel
    Friend WithEvents btnCerrarSesionMedico As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCambiarPassMedico As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnVerPerfilMedico As Guna.UI.WinForms.GunaButton
End Class

