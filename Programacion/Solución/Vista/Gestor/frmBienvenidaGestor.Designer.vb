<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBienvenidaGestor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBienvenidaGestor))
        Me.tempListaPacientes = New System.Windows.Forms.Timer(Me.components)
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlOps = New System.Windows.Forms.Panel()
        Me.btnCerrarSesionGestor = New Guna.UI.WinForms.GunaButton()
        Me.btnCambiarPassGestor = New Guna.UI.WinForms.GunaButton()
        Me.btnVerPerfil = New Guna.UI.WinForms.GunaButton()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.lblNA = New System.Windows.Forms.Label()
        Me.pnlFlow = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblSubPat = New System.Windows.Forms.Label()
        Me.btnPatologiaGestion = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblPatologiaMain = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSintomasGestion = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblSubSin = New System.Windows.Forms.Label()
        Me.lblSintomaMain = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnUsuariosGestion = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblUsuarioMain = New System.Windows.Forms.Label()
        Me.lblSubUsu = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnRegistroGestor = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblRegistroMain = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblSubRegis = New System.Windows.Forms.Label()
        Me.pnlCerrar = New System.Windows.Forms.Panel()
        Me.GunaElipsePanel2 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnGestores = New FontAwesome.Sharp.IconPictureBox()
        Me.pnlNotificacion = New Guna.UI.WinForms.GunaElipsePanel()
        Me.lblNotificacion = New System.Windows.Forms.Label()
        Me.btnPacientes = New FontAwesome.Sharp.IconPictureBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.pnlContenedor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlOps.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.pnlCerrar.SuspendLayout()
        Me.GunaElipsePanel2.SuspendLayout()
        CType(Me.btnGestores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNotificacion.SuspendLayout()
        CType(Me.btnPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tempListaPacientes
        '
        Me.tempListaPacientes.Enabled = True
        Me.tempListaPacientes.Interval = 6000
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.PictureBox1)
        Me.pnlContenedor.Controls.Add(Me.pnlOps)
        Me.pnlContenedor.Controls.Add(Me.Panel9)
        Me.pnlContenedor.Controls.Add(Me.pnlCerrar)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.PictureBox1.Image = Global.Vista.My.Resources.Resources.LOGO_MEDICARE_SIN_SUB_WHITE_V2_PNG
        Me.PictureBox1.Location = New System.Drawing.Point(39, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(264, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'pnlOps
        '
        Me.pnlOps.Controls.Add(Me.btnCerrarSesionGestor)
        Me.pnlOps.Controls.Add(Me.btnCambiarPassGestor)
        Me.pnlOps.Controls.Add(Me.btnVerPerfil)
        Me.pnlOps.Location = New System.Drawing.Point(828, 80)
        Me.pnlOps.Name = "pnlOps"
        Me.pnlOps.Size = New System.Drawing.Size(179, 128)
        Me.pnlOps.TabIndex = 30
        Me.pnlOps.Visible = False
        '
        'btnCerrarSesionGestor
        '
        Me.btnCerrarSesionGestor.Animated = True
        Me.btnCerrarSesionGestor.AnimationHoverSpeed = 0.07!
        Me.btnCerrarSesionGestor.AnimationSpeed = 0.03!
        Me.btnCerrarSesionGestor.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnCerrarSesionGestor.BorderColor = System.Drawing.Color.Black
        Me.btnCerrarSesionGestor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarSesionGestor.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCerrarSesionGestor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCerrarSesionGestor.FocusedColor = System.Drawing.Color.Empty
        Me.btnCerrarSesionGestor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarSesionGestor.ForeColor = System.Drawing.Color.White
        Me.btnCerrarSesionGestor.Image = Nothing
        Me.btnCerrarSesionGestor.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCerrarSesionGestor.Location = New System.Drawing.Point(0, 84)
        Me.btnCerrarSesionGestor.Name = "btnCerrarSesionGestor"
        Me.btnCerrarSesionGestor.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCerrarSesionGestor.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCerrarSesionGestor.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCerrarSesionGestor.OnHoverImage = Nothing
        Me.btnCerrarSesionGestor.OnPressedColor = System.Drawing.Color.Black
        Me.btnCerrarSesionGestor.Size = New System.Drawing.Size(179, 42)
        Me.btnCerrarSesionGestor.TabIndex = 201
        Me.btnCerrarSesionGestor.Text = "Cerrar sesión"
        Me.btnCerrarSesionGestor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCambiarPassGestor
        '
        Me.btnCambiarPassGestor.Animated = True
        Me.btnCambiarPassGestor.AnimationHoverSpeed = 0.07!
        Me.btnCambiarPassGestor.AnimationSpeed = 0.03!
        Me.btnCambiarPassGestor.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnCambiarPassGestor.BorderColor = System.Drawing.Color.Black
        Me.btnCambiarPassGestor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiarPassGestor.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCambiarPassGestor.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCambiarPassGestor.FocusedColor = System.Drawing.Color.Empty
        Me.btnCambiarPassGestor.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarPassGestor.ForeColor = System.Drawing.Color.White
        Me.btnCambiarPassGestor.Image = Nothing
        Me.btnCambiarPassGestor.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCambiarPassGestor.Location = New System.Drawing.Point(0, 42)
        Me.btnCambiarPassGestor.Name = "btnCambiarPassGestor"
        Me.btnCambiarPassGestor.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCambiarPassGestor.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCambiarPassGestor.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCambiarPassGestor.OnHoverImage = Nothing
        Me.btnCambiarPassGestor.OnPressedColor = System.Drawing.Color.Black
        Me.btnCambiarPassGestor.Size = New System.Drawing.Size(179, 42)
        Me.btnCambiarPassGestor.TabIndex = 200
        Me.btnCambiarPassGestor.Text = "Cambiar contraseña"
        Me.btnCambiarPassGestor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel9.Controls.Add(Me.scroll)
        Me.Panel9.Controls.Add(Me.lblNA)
        Me.Panel9.Controls.Add(Me.pnlFlow)
        Me.Panel9.Controls.Add(Me.Panel10)
        Me.Panel9.Location = New System.Drawing.Point(0, 80)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1070, 570)
        Me.Panel9.TabIndex = 26
        '
        'scroll
        '
        Me.scroll.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.scroll.Enabled = False
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(928, 19)
        Me.scroll.Margin = New System.Windows.Forms.Padding(0)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.Silver
        Me.scroll.Size = New System.Drawing.Size(10, 106)
        Me.scroll.TabIndex = 0
        Me.scroll.ThumbColor = System.Drawing.Color.DimGray
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'lblNA
        '
        Me.lblNA.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.lblNA.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNA.ForeColor = System.Drawing.Color.White
        Me.lblNA.Location = New System.Drawing.Point(214, 21)
        Me.lblNA.Name = "lblNA"
        Me.lblNA.Size = New System.Drawing.Size(300, 420)
        Me.lblNA.TabIndex = 0
        Me.lblNA.Text = "No hay solicitudes"
        Me.lblNA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNA.Visible = False
        '
        'pnlFlow
        '
        Me.pnlFlow.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.pnlFlow.Location = New System.Drawing.Point(211, 19)
        Me.pnlFlow.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlFlow.Name = "pnlFlow"
        Me.pnlFlow.Size = New System.Drawing.Size(335, 466)
        Me.pnlFlow.TabIndex = 26
        Me.pnlFlow.Visible = False
        Me.pnlFlow.WrapContents = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel1)
        Me.Panel10.Controls.Add(Me.Panel3)
        Me.Panel10.Controls.Add(Me.Panel8)
        Me.Panel10.Controls.Add(Me.Panel7)
        Me.Panel10.Controls.Add(Me.Panel5)
        Me.Panel10.Location = New System.Drawing.Point(39, 135)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1003, 306)
        Me.Panel10.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblSubPat)
        Me.Panel1.Controls.Add(Me.btnPatologiaGestion)
        Me.Panel1.Controls.Add(Me.lblPatologiaMain)
        Me.Panel1.Location = New System.Drawing.Point(82, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 248)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel2.Location = New System.Drawing.Point(0, 241)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(183, 7)
        Me.Panel2.TabIndex = 3
        '
        'lblSubPat
        '
        Me.lblSubPat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubPat.ForeColor = System.Drawing.Color.White
        Me.lblSubPat.Location = New System.Drawing.Point(20, 79)
        Me.lblSubPat.Name = "lblSubPat"
        Me.lblSubPat.Size = New System.Drawing.Size(143, 59)
        Me.lblSubPat.TabIndex = 2
        Me.lblSubPat.Text = "Registrar, modificar, eliminar y buscar patologías"
        Me.lblSubPat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPatologiaGestion
        '
        Me.btnPatologiaGestion.Animated = True
        Me.btnPatologiaGestion.AnimationHoverSpeed = 0.07!
        Me.btnPatologiaGestion.AnimationSpeed = 0.03!
        Me.btnPatologiaGestion.BackColor = System.Drawing.Color.Transparent
        Me.btnPatologiaGestion.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnPatologiaGestion.BorderColor = System.Drawing.Color.Black
        Me.btnPatologiaGestion.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnPatologiaGestion.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnPatologiaGestion.CheckedForeColor = System.Drawing.Color.White
        Me.btnPatologiaGestion.CheckedImage = CType(resources.GetObject("btnPatologiaGestion.CheckedImage"), System.Drawing.Image)
        Me.btnPatologiaGestion.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnPatologiaGestion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatologiaGestion.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPatologiaGestion.FocusedColor = System.Drawing.Color.Empty
        Me.btnPatologiaGestion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatologiaGestion.ForeColor = System.Drawing.Color.White
        Me.btnPatologiaGestion.Image = Nothing
        Me.btnPatologiaGestion.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPatologiaGestion.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPatologiaGestion.Location = New System.Drawing.Point(29, 179)
        Me.btnPatologiaGestion.Name = "btnPatologiaGestion"
        Me.btnPatologiaGestion.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnPatologiaGestion.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPatologiaGestion.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPatologiaGestion.OnHoverImage = Nothing
        Me.btnPatologiaGestion.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnPatologiaGestion.OnPressedColor = System.Drawing.Color.Black
        Me.btnPatologiaGestion.Radius = 15
        Me.btnPatologiaGestion.Size = New System.Drawing.Size(125, 32)
        Me.btnPatologiaGestion.TabIndex = 9
        Me.btnPatologiaGestion.Text = "Ingresar"
        Me.btnPatologiaGestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPatologiaMain
        '
        Me.lblPatologiaMain.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatologiaMain.ForeColor = System.Drawing.Color.White
        Me.lblPatologiaMain.Location = New System.Drawing.Point(3, 16)
        Me.lblPatologiaMain.Name = "lblPatologiaMain"
        Me.lblPatologiaMain.Size = New System.Drawing.Size(183, 40)
        Me.lblPatologiaMain.TabIndex = 1
        Me.lblPatologiaMain.Text = "Patologías"
        Me.lblPatologiaMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnSintomasGestion)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.lblSubSin)
        Me.Panel3.Controls.Add(Me.lblSintomaMain)
        Me.Panel3.Location = New System.Drawing.Point(306, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 248)
        Me.Panel3.TabIndex = 5
        '
        'btnSintomasGestion
        '
        Me.btnSintomasGestion.Animated = True
        Me.btnSintomasGestion.AnimationHoverSpeed = 0.07!
        Me.btnSintomasGestion.AnimationSpeed = 0.03!
        Me.btnSintomasGestion.BackColor = System.Drawing.Color.Transparent
        Me.btnSintomasGestion.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSintomasGestion.BorderColor = System.Drawing.Color.Black
        Me.btnSintomasGestion.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSintomasGestion.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnSintomasGestion.CheckedForeColor = System.Drawing.Color.White
        Me.btnSintomasGestion.CheckedImage = Nothing
        Me.btnSintomasGestion.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnSintomasGestion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSintomasGestion.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSintomasGestion.FocusedColor = System.Drawing.Color.Empty
        Me.btnSintomasGestion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSintomasGestion.ForeColor = System.Drawing.Color.White
        Me.btnSintomasGestion.Image = Nothing
        Me.btnSintomasGestion.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSintomasGestion.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSintomasGestion.Location = New System.Drawing.Point(30, 183)
        Me.btnSintomasGestion.Name = "btnSintomasGestion"
        Me.btnSintomasGestion.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSintomasGestion.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSintomasGestion.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSintomasGestion.OnHoverImage = Nothing
        Me.btnSintomasGestion.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnSintomasGestion.OnPressedColor = System.Drawing.Color.Black
        Me.btnSintomasGestion.Radius = 12
        Me.btnSintomasGestion.Size = New System.Drawing.Size(125, 32)
        Me.btnSintomasGestion.TabIndex = 10
        Me.btnSintomasGestion.Text = "Ingresar"
        Me.btnSintomasGestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel4.Location = New System.Drawing.Point(0, 240)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(183, 7)
        Me.Panel4.TabIndex = 3
        '
        'lblSubSin
        '
        Me.lblSubSin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubSin.ForeColor = System.Drawing.Color.White
        Me.lblSubSin.Location = New System.Drawing.Point(21, 78)
        Me.lblSubSin.Name = "lblSubSin"
        Me.lblSubSin.Size = New System.Drawing.Size(143, 59)
        Me.lblSubSin.TabIndex = 2
        Me.lblSubSin.Text = "Registrar, modificar, eliminar y buscar síntomas"
        Me.lblSubSin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSintomaMain
        '
        Me.lblSintomaMain.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintomaMain.ForeColor = System.Drawing.Color.White
        Me.lblSintomaMain.Location = New System.Drawing.Point(0, 25)
        Me.lblSintomaMain.Name = "lblSintomaMain"
        Me.lblSintomaMain.Size = New System.Drawing.Size(183, 40)
        Me.lblSintomaMain.TabIndex = 1
        Me.lblSintomaMain.Text = "Síntomas"
        Me.lblSintomaMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel8.Location = New System.Drawing.Point(749, 265)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(183, 7)
        Me.Panel8.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel7.Controls.Add(Me.btnUsuariosGestion)
        Me.Panel7.Controls.Add(Me.lblUsuarioMain)
        Me.Panel7.Controls.Add(Me.lblSubUsu)
        Me.Panel7.Location = New System.Drawing.Point(749, 24)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(183, 248)
        Me.Panel7.TabIndex = 7
        '
        'btnUsuariosGestion
        '
        Me.btnUsuariosGestion.Animated = True
        Me.btnUsuariosGestion.AnimationHoverSpeed = 0.07!
        Me.btnUsuariosGestion.AnimationSpeed = 0.03!
        Me.btnUsuariosGestion.BackColor = System.Drawing.Color.Transparent
        Me.btnUsuariosGestion.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUsuariosGestion.BorderColor = System.Drawing.Color.Black
        Me.btnUsuariosGestion.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUsuariosGestion.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnUsuariosGestion.CheckedForeColor = System.Drawing.Color.White
        Me.btnUsuariosGestion.CheckedImage = CType(resources.GetObject("btnUsuariosGestion.CheckedImage"), System.Drawing.Image)
        Me.btnUsuariosGestion.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnUsuariosGestion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuariosGestion.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUsuariosGestion.FocusedColor = System.Drawing.Color.Empty
        Me.btnUsuariosGestion.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuariosGestion.ForeColor = System.Drawing.Color.White
        Me.btnUsuariosGestion.Image = Nothing
        Me.btnUsuariosGestion.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUsuariosGestion.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUsuariosGestion.Location = New System.Drawing.Point(29, 181)
        Me.btnUsuariosGestion.Name = "btnUsuariosGestion"
        Me.btnUsuariosGestion.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnUsuariosGestion.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUsuariosGestion.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUsuariosGestion.OnHoverImage = Nothing
        Me.btnUsuariosGestion.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUsuariosGestion.OnPressedColor = System.Drawing.Color.Black
        Me.btnUsuariosGestion.Radius = 12
        Me.btnUsuariosGestion.Size = New System.Drawing.Size(125, 32)
        Me.btnUsuariosGestion.TabIndex = 12
        Me.btnUsuariosGestion.Text = "Ingresar"
        Me.btnUsuariosGestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblUsuarioMain
        '
        Me.lblUsuarioMain.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioMain.ForeColor = System.Drawing.Color.White
        Me.lblUsuarioMain.Location = New System.Drawing.Point(3, 16)
        Me.lblUsuarioMain.Name = "lblUsuarioMain"
        Me.lblUsuarioMain.Size = New System.Drawing.Size(183, 40)
        Me.lblUsuarioMain.TabIndex = 5
        Me.lblUsuarioMain.Text = "Usuarios"
        Me.lblUsuarioMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubUsu
        '
        Me.lblSubUsu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubUsu.ForeColor = System.Drawing.Color.White
        Me.lblSubUsu.Location = New System.Drawing.Point(20, 79)
        Me.lblSubUsu.Name = "lblSubUsu"
        Me.lblSubUsu.Size = New System.Drawing.Size(143, 59)
        Me.lblSubUsu.TabIndex = 2
        Me.lblSubUsu.Text = "Buscar, modificar o eliminar usuarios"
        Me.lblSubUsu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btnRegistroGestor)
        Me.Panel5.Controls.Add(Me.lblRegistroMain)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.lblSubRegis)
        Me.Panel5.Location = New System.Drawing.Point(532, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(183, 248)
        Me.Panel5.TabIndex = 6
        '
        'btnRegistroGestor
        '
        Me.btnRegistroGestor.Animated = True
        Me.btnRegistroGestor.AnimationHoverSpeed = 0.07!
        Me.btnRegistroGestor.AnimationSpeed = 0.03!
        Me.btnRegistroGestor.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistroGestor.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnRegistroGestor.BorderColor = System.Drawing.Color.Black
        Me.btnRegistroGestor.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnRegistroGestor.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnRegistroGestor.CheckedForeColor = System.Drawing.Color.White
        Me.btnRegistroGestor.CheckedImage = CType(resources.GetObject("btnRegistroGestor.CheckedImage"), System.Drawing.Image)
        Me.btnRegistroGestor.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnRegistroGestor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistroGestor.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistroGestor.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistroGestor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistroGestor.ForeColor = System.Drawing.Color.White
        Me.btnRegistroGestor.Image = Nothing
        Me.btnRegistroGestor.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegistroGestor.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnRegistroGestor.Location = New System.Drawing.Point(32, 184)
        Me.btnRegistroGestor.Name = "btnRegistroGestor"
        Me.btnRegistroGestor.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnRegistroGestor.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistroGestor.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistroGestor.OnHoverImage = Nothing
        Me.btnRegistroGestor.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnRegistroGestor.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistroGestor.Radius = 12
        Me.btnRegistroGestor.Size = New System.Drawing.Size(125, 32)
        Me.btnRegistroGestor.TabIndex = 11
        Me.btnRegistroGestor.Text = "Ingresar"
        Me.btnRegistroGestor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRegistroMain
        '
        Me.lblRegistroMain.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroMain.ForeColor = System.Drawing.Color.White
        Me.lblRegistroMain.Location = New System.Drawing.Point(0, 25)
        Me.lblRegistroMain.Name = "lblRegistroMain"
        Me.lblRegistroMain.Size = New System.Drawing.Size(183, 40)
        Me.lblRegistroMain.TabIndex = 5
        Me.lblRegistroMain.Text = "Registro"
        Me.lblRegistroMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel6.Location = New System.Drawing.Point(0, 240)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(183, 7)
        Me.Panel6.TabIndex = 3
        '
        'lblSubRegis
        '
        Me.lblSubRegis.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubRegis.ForeColor = System.Drawing.Color.White
        Me.lblSubRegis.Location = New System.Drawing.Point(23, 78)
        Me.lblSubRegis.Name = "lblSubRegis"
        Me.lblSubRegis.Size = New System.Drawing.Size(143, 59)
        Me.lblSubRegis.TabIndex = 2
        Me.lblSubRegis.Text = "Registrar médicos y gestores en la aplicación"
        Me.lblSubRegis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCerrar
        '
        Me.pnlCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlCerrar.Controls.Add(Me.GunaElipsePanel2)
        Me.pnlCerrar.Controls.Add(Me.btnGestores)
        Me.pnlCerrar.Controls.Add(Me.pnlNotificacion)
        Me.pnlCerrar.Controls.Add(Me.btnPacientes)
        Me.pnlCerrar.Controls.Add(Me.IconButton1)
        Me.pnlCerrar.Location = New System.Drawing.Point(0, 0)
        Me.pnlCerrar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlCerrar.Name = "pnlCerrar"
        Me.pnlCerrar.Size = New System.Drawing.Size(1070, 80)
        Me.pnlCerrar.TabIndex = 25
        '
        'GunaElipsePanel2
        '
        Me.GunaElipsePanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel2.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.GunaElipsePanel2.Controls.Add(Me.Label11)
        Me.GunaElipsePanel2.Location = New System.Drawing.Point(783, 27)
        Me.GunaElipsePanel2.Name = "GunaElipsePanel2"
        Me.GunaElipsePanel2.Size = New System.Drawing.Size(16, 16)
        Me.GunaElipsePanel2.TabIndex = 11
        Me.GunaElipsePanel2.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(-1, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "0"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label11.Visible = False
        '
        'btnGestores
        '
        Me.btnGestores.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnGestores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGestores.IconChar = FontAwesome.Sharp.IconChar.UserShield
        Me.btnGestores.IconColor = System.Drawing.Color.White
        Me.btnGestores.Location = New System.Drawing.Point(756, 27)
        Me.btnGestores.Name = "btnGestores"
        Me.btnGestores.Size = New System.Drawing.Size(37, 32)
        Me.btnGestores.TabIndex = 26
        Me.btnGestores.TabStop = False
        '
        'pnlNotificacion
        '
        Me.pnlNotificacion.BackColor = System.Drawing.Color.Transparent
        Me.pnlNotificacion.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.pnlNotificacion.Controls.Add(Me.lblNotificacion)
        Me.pnlNotificacion.Location = New System.Drawing.Point(835, 27)
        Me.pnlNotificacion.Name = "pnlNotificacion"
        Me.pnlNotificacion.Size = New System.Drawing.Size(16, 16)
        Me.pnlNotificacion.TabIndex = 10
        Me.pnlNotificacion.Visible = False
        '
        'lblNotificacion
        '
        Me.lblNotificacion.AutoSize = True
        Me.lblNotificacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNotificacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotificacion.ForeColor = System.Drawing.Color.White
        Me.lblNotificacion.Location = New System.Drawing.Point(0, 1)
        Me.lblNotificacion.Name = "lblNotificacion"
        Me.lblNotificacion.Size = New System.Drawing.Size(13, 13)
        Me.lblNotificacion.TabIndex = 0
        Me.lblNotificacion.Text = "0"
        Me.lblNotificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNotificacion.Visible = False
        '
        'btnPacientes
        '
        Me.btnPacientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPacientes.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.btnPacientes.IconColor = System.Drawing.Color.White
        Me.btnPacientes.Location = New System.Drawing.Point(808, 27)
        Me.btnPacientes.Name = "btnPacientes"
        Me.btnPacientes.Size = New System.Drawing.Size(37, 32)
        Me.btnPacientes.TabIndex = 11
        Me.btnPacientes.TabStop = False
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
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1070, 650)
        Me.pnlInstancia.TabIndex = 6
        '
        'frmBienvenidaGestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBienvenidaGestor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnlContenedor.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlOps.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.pnlCerrar.ResumeLayout(False)
        Me.GunaElipsePanel2.ResumeLayout(False)
        Me.GunaElipsePanel2.PerformLayout()
        CType(Me.btnGestores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNotificacion.ResumeLayout(False)
        Me.pnlNotificacion.PerformLayout()
        CType(Me.btnPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tempListaPacientes As Timer
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlInstancia As Panel
    Friend WithEvents pnlCerrar As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSubPat As Label
    Friend WithEvents btnPatologiaGestion As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblPatologiaMain As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSintomasGestion As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblSubSin As Label
    Friend WithEvents lblSintomaMain As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btnUsuariosGestion As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblUsuarioMain As Label
    Friend WithEvents lblSubUsu As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnRegistroGestor As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblRegistroMain As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblSubRegis As Label
    Friend WithEvents btnPacientes As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents pnlFlow As FlowLayoutPanel
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents pnlNotificacion As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents lblNotificacion As Label
    Friend WithEvents lblNA As Label
    Friend WithEvents btnGestores As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents GunaElipsePanel2 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label11 As Label
    Friend WithEvents pnlOps As Panel
    Friend WithEvents btnCerrarSesionGestor As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCambiarPassGestor As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnVerPerfil As Guna.UI.WinForms.GunaButton
    Friend WithEvents PictureBox1 As PictureBox
End Class

