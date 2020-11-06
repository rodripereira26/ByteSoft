<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCVerPerfil
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCVerPerfil))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnCerrar = New FontAwesome.Sharp.IconButton()
        Me.btnRegistrar = New Guna.UI.WinForms.GunaButton()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblEmailPerfil = New System.Windows.Forms.Label()
        Me.lblNomPerfil = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnModificarPerfil = New FontAwesome.Sharp.IconPictureBox()
        Me.lblMailPerfil = New System.Windows.Forms.Label()
        Me.lblNombrePerfil = New System.Windows.Forms.Label()
        Me.lblTelefonosPerfil = New System.Windows.Forms.Label()
        Me.btnVerPatologias = New System.Windows.Forms.Button()
        Me.pnlPatologias = New System.Windows.Forms.Panel()
        Me.lblPatologiasCronicas = New System.Windows.Forms.Label()
        Me.lblPatCron = New System.Windows.Forms.Label()
        Me.pnlMedico = New System.Windows.Forms.Panel()
        Me.lblEspecializacionPerfil = New System.Windows.Forms.Label()
        Me.lblEspe = New System.Windows.Forms.Label()
        Me.pnlPaciente = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblEdadPerfil = New System.Windows.Forms.Label()
        Me.lblEd = New System.Windows.Forms.Label()
        Me.transicion = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.pnlCredenciales = New System.Windows.Forms.Panel()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.btnChangePass = New Guna.UI.WinForms.GunaButton()
        Me.lblPassActual = New System.Windows.Forms.Label()
        Me.txtPassActual = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblRepetirCon = New System.Windows.Forms.Label()
        Me.txtPassRep = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblCon = New System.Windows.Forms.Label()
        Me.txtPassNueva = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblCredenciales = New System.Windows.Forms.Label()
        Me.pnlYo = New System.Windows.Forms.Panel()
        Me.btnModPatologias = New System.Windows.Forms.Button()
        Me.pnlMedYo = New System.Windows.Forms.Panel()
        Me.lblEspecPerfil = New System.Windows.Forms.Label()
        Me.txtEspe = New Guna.UI.WinForms.GunaLineTextBox()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.lblSApePerfil = New System.Windows.Forms.Label()
        Me.txtSApePerfil = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblPApePerfil = New System.Windows.Forms.Label()
        Me.txtPApe = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblSNomPerfil = New System.Windows.Forms.Label()
        Me.txtSNom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtPNom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblPNomPerfil = New System.Windows.Forms.Label()
        Me.lblMiInformacion = New System.Windows.Forms.Label()
        Me.pnlContacto = New System.Windows.Forms.Panel()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.txtMail = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblCorreoPerfil = New System.Windows.Forms.Label()
        Me.lblTelesPerfil = New System.Windows.Forms.Label()
        Me.btnEliminarPerfil = New Guna.UI.WinForms.GunaButton()
        Me.btnAceptarPerfil = New Guna.UI.WinForms.GunaButton()
        Me.dgvTelefonos = New System.Windows.Forms.DataGridView()
        Me.Telefonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblContactoPerfil = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnModificarPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPatologias.SuspendLayout()
        Me.pnlMedico.SuspendLayout()
        Me.pnlPaciente.SuspendLayout()
        Me.pnlCredenciales.SuspendLayout()
        Me.pnlYo.SuspendLayout()
        Me.pnlMedYo.SuspendLayout()
        Me.pnlContacto.SuspendLayout()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.btnCerrar)
        Me.pnlMain.Controls.Add(Me.btnRegistrar)
        Me.pnlMain.Controls.Add(Me.lblTel)
        Me.pnlMain.Controls.Add(Me.lblEmailPerfil)
        Me.pnlMain.Controls.Add(Me.lblNomPerfil)
        Me.pnlMain.Controls.Add(Me.GunaCirclePictureBox1)
        Me.pnlMain.Controls.Add(Me.btnModificarPerfil)
        Me.pnlMain.Controls.Add(Me.lblMailPerfil)
        Me.pnlMain.Controls.Add(Me.lblNombrePerfil)
        Me.pnlMain.Controls.Add(Me.lblTelefonosPerfil)
        Me.pnlMain.Controls.Add(Me.btnVerPatologias)
        Me.pnlMain.Controls.Add(Me.pnlPatologias)
        Me.pnlMain.Controls.Add(Me.pnlMedico)
        Me.pnlMain.Controls.Add(Me.pnlPaciente)
        Me.transicion.SetDecoration(Me.pnlMain, Guna.UI.Animation.DecorationType.None)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(424, 648)
        Me.pnlMain.TabIndex = 36
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.btnCerrar, Guna.UI.Animation.DecorationType.None)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnCerrar.IconColor = System.Drawing.Color.White
        Me.btnCerrar.IconSize = 20
        Me.btnCerrar.Location = New System.Drawing.Point(22, 22)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Rotation = 0R
        Me.btnCerrar.Size = New System.Drawing.Size(37, 34)
        Me.btnCerrar.TabIndex = 248
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Animated = True
        Me.btnRegistrar.AnimationHoverSpeed = 0.07!
        Me.btnRegistrar.AnimationSpeed = 0.03!
        Me.btnRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnRegistrar.BorderColor = System.Drawing.Color.Black
        Me.transicion.SetDecoration(Me.btnRegistrar, Guna.UI.Animation.DecorationType.None)
        Me.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistrar.Enabled = False
        Me.btnRegistrar.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Image = Nothing
        Me.btnRegistrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegistrar.Location = New System.Drawing.Point(108, 592)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistrar.OnHoverImage = Nothing
        Me.btnRegistrar.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistrar.Radius = 10
        Me.btnRegistrar.Size = New System.Drawing.Size(199, 35)
        Me.btnRegistrar.TabIndex = 245
        Me.btnRegistrar.Text = "Aplicar cambios"
        Me.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTel
        '
        Me.transicion.SetDecoration(Me.lblTel, Guna.UI.Animation.DecorationType.None)
        Me.lblTel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.ForeColor = System.Drawing.Color.Silver
        Me.lblTel.Location = New System.Drawing.Point(63, 395)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(306, 42)
        Me.lblTel.TabIndex = 31
        '
        'lblEmailPerfil
        '
        Me.lblEmailPerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblEmailPerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblEmailPerfil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailPerfil.ForeColor = System.Drawing.Color.Silver
        Me.lblEmailPerfil.Location = New System.Drawing.Point(62, 300)
        Me.lblEmailPerfil.Name = "lblEmailPerfil"
        Me.lblEmailPerfil.Size = New System.Drawing.Size(68, 21)
        Me.lblEmailPerfil.TabIndex = 30
        Me.lblEmailPerfil.Text = "Nombre"
        '
        'lblNomPerfil
        '
        Me.lblNomPerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblNomPerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblNomPerfil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomPerfil.ForeColor = System.Drawing.Color.Silver
        Me.lblNomPerfil.Location = New System.Drawing.Point(62, 206)
        Me.lblNomPerfil.Name = "lblNomPerfil"
        Me.lblNomPerfil.Size = New System.Drawing.Size(68, 21)
        Me.lblNomPerfil.TabIndex = 29
        Me.lblNomPerfil.Text = "Nombre"
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.transicion.SetDecoration(Me.GunaCirclePictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(160, 22)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 28
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'btnModificarPerfil
        '
        Me.btnModificarPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnModificarPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.btnModificarPerfil, Guna.UI.Animation.DecorationType.None)
        Me.btnModificarPerfil.ForeColor = System.Drawing.Color.Silver
        Me.btnModificarPerfil.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btnModificarPerfil.IconColor = System.Drawing.Color.Silver
        Me.btnModificarPerfil.IconSize = 46
        Me.btnModificarPerfil.Location = New System.Drawing.Point(352, 33)
        Me.btnModificarPerfil.Name = "btnModificarPerfil"
        Me.btnModificarPerfil.Size = New System.Drawing.Size(53, 46)
        Me.btnModificarPerfil.TabIndex = 25
        Me.btnModificarPerfil.TabStop = False
        '
        'lblMailPerfil
        '
        Me.lblMailPerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblMailPerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblMailPerfil.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailPerfil.ForeColor = System.Drawing.Color.White
        Me.lblMailPerfil.Location = New System.Drawing.Point(30, 250)
        Me.lblMailPerfil.Name = "lblMailPerfil"
        Me.lblMailPerfil.Size = New System.Drawing.Size(148, 21)
        Me.lblMailPerfil.TabIndex = 2
        Me.lblMailPerfil.Text = "Correo electrónico"
        '
        'lblNombrePerfil
        '
        Me.lblNombrePerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblNombrePerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblNombrePerfil.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombrePerfil.ForeColor = System.Drawing.Color.White
        Me.lblNombrePerfil.Location = New System.Drawing.Point(30, 166)
        Me.lblNombrePerfil.Name = "lblNombrePerfil"
        Me.lblNombrePerfil.Size = New System.Drawing.Size(71, 21)
        Me.lblNombrePerfil.TabIndex = 1
        Me.lblNombrePerfil.Text = "Nombre"
        '
        'lblTelefonosPerfil
        '
        Me.lblTelefonosPerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblTelefonosPerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblTelefonosPerfil.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonosPerfil.ForeColor = System.Drawing.Color.White
        Me.lblTelefonosPerfil.Location = New System.Drawing.Point(27, 350)
        Me.lblTelefonosPerfil.Name = "lblTelefonosPerfil"
        Me.lblTelefonosPerfil.Size = New System.Drawing.Size(81, 21)
        Me.lblTelefonosPerfil.TabIndex = 3
        Me.lblTelefonosPerfil.Text = "Teléfonos"
        '
        'btnVerPatologias
        '
        Me.btnVerPatologias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.btnVerPatologias, Guna.UI.Animation.DecorationType.None)
        Me.btnVerPatologias.FlatAppearance.BorderSize = 0
        Me.btnVerPatologias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerPatologias.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerPatologias.ForeColor = System.Drawing.Color.Silver
        Me.btnVerPatologias.Location = New System.Drawing.Point(31, 544)
        Me.btnVerPatologias.Name = "btnVerPatologias"
        Me.btnVerPatologias.Size = New System.Drawing.Size(369, 30)
        Me.btnVerPatologias.TabIndex = 247
        Me.btnVerPatologias.Text = "Ver patologías crónicas"
        Me.btnVerPatologias.UseVisualStyleBackColor = True
        Me.btnVerPatologias.Visible = False
        '
        'pnlPatologias
        '
        Me.pnlPatologias.Controls.Add(Me.lblPatologiasCronicas)
        Me.pnlPatologias.Controls.Add(Me.lblPatCron)
        Me.transicion.SetDecoration(Me.pnlPatologias, Guna.UI.Animation.DecorationType.None)
        Me.pnlPatologias.Location = New System.Drawing.Point(31, 454)
        Me.pnlPatologias.Name = "pnlPatologias"
        Me.pnlPatologias.Size = New System.Drawing.Size(369, 89)
        Me.pnlPatologias.TabIndex = 37
        Me.pnlPatologias.Visible = False
        '
        'lblPatologiasCronicas
        '
        Me.lblPatologiasCronicas.AutoSize = True
        Me.transicion.SetDecoration(Me.lblPatologiasCronicas, Guna.UI.Animation.DecorationType.None)
        Me.lblPatologiasCronicas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatologiasCronicas.ForeColor = System.Drawing.Color.White
        Me.lblPatologiasCronicas.Location = New System.Drawing.Point(3, 16)
        Me.lblPatologiasCronicas.Name = "lblPatologiasCronicas"
        Me.lblPatologiasCronicas.Size = New System.Drawing.Size(150, 21)
        Me.lblPatologiasCronicas.TabIndex = 4
        Me.lblPatologiasCronicas.Text = "Patologías crónicas"
        '
        'lblPatCron
        '
        Me.lblPatCron.AutoSize = True
        Me.transicion.SetDecoration(Me.lblPatCron, Guna.UI.Animation.DecorationType.None)
        Me.lblPatCron.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatCron.ForeColor = System.Drawing.Color.Silver
        Me.lblPatCron.Location = New System.Drawing.Point(28, 54)
        Me.lblPatCron.Name = "lblPatCron"
        Me.lblPatCron.Size = New System.Drawing.Size(0, 21)
        Me.lblPatCron.TabIndex = 32
        '
        'pnlMedico
        '
        Me.pnlMedico.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMedico.Controls.Add(Me.lblEspecializacionPerfil)
        Me.pnlMedico.Controls.Add(Me.lblEspe)
        Me.transicion.SetDecoration(Me.pnlMedico, Guna.UI.Animation.DecorationType.None)
        Me.pnlMedico.Location = New System.Drawing.Point(31, 337)
        Me.pnlMedico.Name = "pnlMedico"
        Me.pnlMedico.Size = New System.Drawing.Size(369, 108)
        Me.pnlMedico.TabIndex = 34
        '
        'lblEspecializacionPerfil
        '
        Me.lblEspecializacionPerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblEspecializacionPerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblEspecializacionPerfil.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecializacionPerfil.ForeColor = System.Drawing.Color.White
        Me.lblEspecializacionPerfil.Location = New System.Drawing.Point(3, 16)
        Me.lblEspecializacionPerfil.Name = "lblEspecializacionPerfil"
        Me.lblEspecializacionPerfil.Size = New System.Drawing.Size(118, 21)
        Me.lblEspecializacionPerfil.TabIndex = 4
        Me.lblEspecializacionPerfil.Text = "Especialización"
        '
        'lblEspe
        '
        Me.lblEspe.AutoSize = True
        Me.transicion.SetDecoration(Me.lblEspe, Guna.UI.Animation.DecorationType.None)
        Me.lblEspe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspe.ForeColor = System.Drawing.Color.Silver
        Me.lblEspe.Location = New System.Drawing.Point(28, 54)
        Me.lblEspe.Name = "lblEspe"
        Me.lblEspe.Size = New System.Drawing.Size(68, 21)
        Me.lblEspe.TabIndex = 32
        Me.lblEspe.Text = "Nombre"
        '
        'pnlPaciente
        '
        Me.pnlPaciente.Controls.Add(Me.Label3)
        Me.pnlPaciente.Controls.Add(Me.lblSex)
        Me.pnlPaciente.Controls.Add(Me.lblEdadPerfil)
        Me.pnlPaciente.Controls.Add(Me.lblEd)
        Me.transicion.SetDecoration(Me.pnlPaciente, Guna.UI.Animation.DecorationType.None)
        Me.pnlPaciente.Location = New System.Drawing.Point(31, 451)
        Me.pnlPaciente.Name = "pnlPaciente"
        Me.pnlPaciente.Size = New System.Drawing.Size(369, 91)
        Me.pnlPaciente.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.transicion.SetDecoration(Me.Label3, Guna.UI.Animation.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(223, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 21)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Sexo"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.transicion.SetDecoration(Me.lblSex, Guna.UI.Animation.DecorationType.None)
        Me.lblSex.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.Silver
        Me.lblSex.Location = New System.Drawing.Point(248, 54)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(68, 21)
        Me.lblSex.TabIndex = 36
        Me.lblSex.Text = "Nombre"
        '
        'lblEdadPerfil
        '
        Me.lblEdadPerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblEdadPerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblEdadPerfil.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdadPerfil.ForeColor = System.Drawing.Color.White
        Me.lblEdadPerfil.Location = New System.Drawing.Point(-1, 16)
        Me.lblEdadPerfil.Name = "lblEdadPerfil"
        Me.lblEdadPerfil.Size = New System.Drawing.Size(46, 21)
        Me.lblEdadPerfil.TabIndex = 33
        Me.lblEdadPerfil.Text = "Edad"
        '
        'lblEd
        '
        Me.lblEd.AutoSize = True
        Me.transicion.SetDecoration(Me.lblEd, Guna.UI.Animation.DecorationType.None)
        Me.lblEd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEd.ForeColor = System.Drawing.Color.Silver
        Me.lblEd.Location = New System.Drawing.Point(24, 54)
        Me.lblEd.Name = "lblEd"
        Me.lblEd.Size = New System.Drawing.Size(68, 21)
        Me.lblEd.TabIndex = 34
        Me.lblEd.Text = "Nombre"
        '
        'transicion
        '
        Me.transicion.AnimationType = Guna.UI.Animation.AnimationType.Transparent
        Me.transicion.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.transicion.DefaultAnimation = Animation1
        Me.transicion.Interval = 5
        Me.transicion.TimeStep = 0.05!
        '
        'pnlCredenciales
        '
        Me.pnlCredenciales.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlCredenciales.Controls.Add(Me.IconButton3)
        Me.pnlCredenciales.Controls.Add(Me.btnChangePass)
        Me.pnlCredenciales.Controls.Add(Me.lblPassActual)
        Me.pnlCredenciales.Controls.Add(Me.txtPassActual)
        Me.pnlCredenciales.Controls.Add(Me.lblRepetirCon)
        Me.pnlCredenciales.Controls.Add(Me.txtPassRep)
        Me.pnlCredenciales.Controls.Add(Me.lblCon)
        Me.pnlCredenciales.Controls.Add(Me.txtPassNueva)
        Me.pnlCredenciales.Controls.Add(Me.lblCredenciales)
        Me.transicion.SetDecoration(Me.pnlCredenciales, Guna.UI.Animation.DecorationType.None)
        Me.pnlCredenciales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCredenciales.Location = New System.Drawing.Point(0, 0)
        Me.pnlCredenciales.Name = "pnlCredenciales"
        Me.pnlCredenciales.Size = New System.Drawing.Size(424, 648)
        Me.pnlCredenciales.TabIndex = 35
        '
        'IconButton3
        '
        Me.IconButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.IconButton3, Guna.UI.Animation.DecorationType.None)
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconSize = 20
        Me.IconButton3.Location = New System.Drawing.Point(22, 22)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Rotation = 0R
        Me.IconButton3.Size = New System.Drawing.Size(37, 34)
        Me.IconButton3.TabIndex = 250
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'btnChangePass
        '
        Me.btnChangePass.Animated = True
        Me.btnChangePass.AnimationHoverSpeed = 0.07!
        Me.btnChangePass.AnimationSpeed = 0.03!
        Me.btnChangePass.BackColor = System.Drawing.Color.Transparent
        Me.btnChangePass.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnChangePass.BorderColor = System.Drawing.Color.Black
        Me.transicion.SetDecoration(Me.btnChangePass, Guna.UI.Animation.DecorationType.None)
        Me.btnChangePass.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnChangePass.FocusedColor = System.Drawing.Color.Empty
        Me.btnChangePass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePass.ForeColor = System.Drawing.Color.White
        Me.btnChangePass.Image = Nothing
        Me.btnChangePass.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnChangePass.Location = New System.Drawing.Point(108, 592)
        Me.btnChangePass.Name = "btnChangePass"
        Me.btnChangePass.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnChangePass.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnChangePass.OnHoverForeColor = System.Drawing.Color.White
        Me.btnChangePass.OnHoverImage = Nothing
        Me.btnChangePass.OnPressedColor = System.Drawing.Color.Black
        Me.btnChangePass.Radius = 10
        Me.btnChangePass.Size = New System.Drawing.Size(199, 35)
        Me.btnChangePass.TabIndex = 249
        Me.btnChangePass.Text = "Cambiar contraseña"
        Me.btnChangePass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPassActual
        '
        Me.lblPassActual.AutoSize = True
        Me.transicion.SetDecoration(Me.lblPassActual, Guna.UI.Animation.DecorationType.None)
        Me.lblPassActual.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassActual.ForeColor = System.Drawing.Color.Silver
        Me.lblPassActual.Location = New System.Drawing.Point(39, 168)
        Me.lblPassActual.Name = "lblPassActual"
        Me.lblPassActual.Size = New System.Drawing.Size(127, 20)
        Me.lblPassActual.TabIndex = 248
        Me.lblPassActual.Text = "Contraseña actual"
        '
        'txtPassActual
        '
        Me.txtPassActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPassActual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtPassActual, Guna.UI.Animation.DecorationType.None)
        Me.txtPassActual.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassActual.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassActual.ForeColor = System.Drawing.Color.White
        Me.txtPassActual.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPassActual.LineSize = 1
        Me.txtPassActual.Location = New System.Drawing.Point(39, 197)
        Me.txtPassActual.Name = "txtPassActual"
        Me.txtPassActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassActual.Size = New System.Drawing.Size(246, 32)
        Me.txtPassActual.TabIndex = 247
        Me.txtPassActual.UseSystemPasswordChar = True
        '
        'lblRepetirCon
        '
        Me.lblRepetirCon.AutoSize = True
        Me.transicion.SetDecoration(Me.lblRepetirCon, Guna.UI.Animation.DecorationType.None)
        Me.lblRepetirCon.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepetirCon.ForeColor = System.Drawing.Color.Silver
        Me.lblRepetirCon.Location = New System.Drawing.Point(39, 411)
        Me.lblRepetirCon.Name = "lblRepetirCon"
        Me.lblRepetirCon.Size = New System.Drawing.Size(133, 20)
        Me.lblRepetirCon.TabIndex = 214
        Me.lblRepetirCon.Text = "Repetir contraseña"
        '
        'txtPassRep
        '
        Me.txtPassRep.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPassRep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtPassRep, Guna.UI.Animation.DecorationType.None)
        Me.txtPassRep.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassRep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassRep.ForeColor = System.Drawing.Color.White
        Me.txtPassRep.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPassRep.LineSize = 1
        Me.txtPassRep.Location = New System.Drawing.Point(39, 445)
        Me.txtPassRep.Name = "txtPassRep"
        Me.txtPassRep.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassRep.Size = New System.Drawing.Size(246, 32)
        Me.txtPassRep.TabIndex = 211
        Me.txtPassRep.UseSystemPasswordChar = True
        '
        'lblCon
        '
        Me.lblCon.AutoSize = True
        Me.transicion.SetDecoration(Me.lblCon, Guna.UI.Animation.DecorationType.None)
        Me.lblCon.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCon.ForeColor = System.Drawing.Color.Silver
        Me.lblCon.Location = New System.Drawing.Point(39, 277)
        Me.lblCon.Name = "lblCon"
        Me.lblCon.Size = New System.Drawing.Size(127, 20)
        Me.lblCon.TabIndex = 213
        Me.lblCon.Text = "Nueva contraseña"
        '
        'txtPassNueva
        '
        Me.txtPassNueva.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPassNueva.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtPassNueva, Guna.UI.Animation.DecorationType.None)
        Me.txtPassNueva.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassNueva.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassNueva.ForeColor = System.Drawing.Color.White
        Me.txtPassNueva.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPassNueva.LineSize = 1
        Me.txtPassNueva.Location = New System.Drawing.Point(39, 306)
        Me.txtPassNueva.Name = "txtPassNueva"
        Me.txtPassNueva.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassNueva.Size = New System.Drawing.Size(246, 32)
        Me.txtPassNueva.TabIndex = 210
        Me.txtPassNueva.UseSystemPasswordChar = True
        '
        'lblCredenciales
        '
        Me.lblCredenciales.AutoSize = True
        Me.transicion.SetDecoration(Me.lblCredenciales, Guna.UI.Animation.DecorationType.None)
        Me.lblCredenciales.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredenciales.ForeColor = System.Drawing.Color.White
        Me.lblCredenciales.Location = New System.Drawing.Point(28, 90)
        Me.lblCredenciales.Name = "lblCredenciales"
        Me.lblCredenciales.Size = New System.Drawing.Size(150, 32)
        Me.lblCredenciales.TabIndex = 31
        Me.lblCredenciales.Text = "Credenciales"
        '
        'pnlYo
        '
        Me.pnlYo.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlYo.Controls.Add(Me.btnModPatologias)
        Me.pnlYo.Controls.Add(Me.pnlMedYo)
        Me.pnlYo.Controls.Add(Me.IconButton2)
        Me.pnlYo.Controls.Add(Me.IconButton1)
        Me.pnlYo.Controls.Add(Me.lblSApePerfil)
        Me.pnlYo.Controls.Add(Me.txtSApePerfil)
        Me.pnlYo.Controls.Add(Me.lblPApePerfil)
        Me.pnlYo.Controls.Add(Me.txtPApe)
        Me.pnlYo.Controls.Add(Me.lblSNomPerfil)
        Me.pnlYo.Controls.Add(Me.txtSNom)
        Me.pnlYo.Controls.Add(Me.txtPNom)
        Me.pnlYo.Controls.Add(Me.lblPNomPerfil)
        Me.pnlYo.Controls.Add(Me.lblMiInformacion)
        Me.transicion.SetDecoration(Me.pnlYo, Guna.UI.Animation.DecorationType.None)
        Me.pnlYo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlYo.Location = New System.Drawing.Point(0, 0)
        Me.pnlYo.Name = "pnlYo"
        Me.pnlYo.Size = New System.Drawing.Size(424, 648)
        Me.pnlYo.TabIndex = 232
        '
        'btnModPatologias
        '
        Me.btnModPatologias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.btnModPatologias, Guna.UI.Animation.DecorationType.None)
        Me.btnModPatologias.FlatAppearance.BorderSize = 0
        Me.btnModPatologias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModPatologias.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModPatologias.ForeColor = System.Drawing.Color.Silver
        Me.btnModPatologias.Location = New System.Drawing.Point(28, 565)
        Me.btnModPatologias.Name = "btnModPatologias"
        Me.btnModPatologias.Size = New System.Drawing.Size(369, 30)
        Me.btnModPatologias.TabIndex = 249
        Me.btnModPatologias.Text = "Modificar patologías crónicas"
        Me.btnModPatologias.UseVisualStyleBackColor = True
        '
        'pnlMedYo
        '
        Me.pnlMedYo.Controls.Add(Me.lblEspecPerfil)
        Me.pnlMedYo.Controls.Add(Me.txtEspe)
        Me.transicion.SetDecoration(Me.pnlMedYo, Guna.UI.Animation.DecorationType.None)
        Me.pnlMedYo.Location = New System.Drawing.Point(34, 454)
        Me.pnlMedYo.Name = "pnlMedYo"
        Me.pnlMedYo.Size = New System.Drawing.Size(260, 88)
        Me.pnlMedYo.TabIndex = 247
        '
        'lblEspecPerfil
        '
        Me.lblEspecPerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblEspecPerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblEspecPerfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecPerfil.ForeColor = System.Drawing.Color.Silver
        Me.lblEspecPerfil.Location = New System.Drawing.Point(8, 14)
        Me.lblEspecPerfil.Name = "lblEspecPerfil"
        Me.lblEspecPerfil.Size = New System.Drawing.Size(110, 20)
        Me.lblEspecPerfil.TabIndex = 246
        Me.lblEspecPerfil.Text = "Especialización"
        '
        'txtEspe
        '
        Me.txtEspe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtEspe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtEspe, Guna.UI.Animation.DecorationType.None)
        Me.txtEspe.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEspe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspe.ForeColor = System.Drawing.Color.White
        Me.txtEspe.LineColor = System.Drawing.Color.Gainsboro
        Me.txtEspe.LineSize = 1
        Me.txtEspe.Location = New System.Drawing.Point(8, 45)
        Me.txtEspe.Name = "txtEspe"
        Me.txtEspe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEspe.Size = New System.Drawing.Size(246, 32)
        Me.txtEspe.TabIndex = 245
        '
        'IconButton2
        '
        Me.IconButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.IconButton2, Guna.UI.Animation.DecorationType.None)
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton2.ForeColor = System.Drawing.Color.Silver
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.IconButton2.IconColor = System.Drawing.Color.Silver
        Me.IconButton2.IconSize = 20
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton2.Location = New System.Drawing.Point(300, 22)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 180.0R
        Me.IconButton2.Size = New System.Drawing.Size(105, 37)
        Me.IconButton2.TabIndex = 244
        Me.IconButton2.Text = "Siguiente"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.IconButton1, Guna.UI.Animation.DecorationType.None)
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.Silver
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.IconButton1.IconColor = System.Drawing.Color.Silver
        Me.IconButton1.IconSize = 20
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(22, 22)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(37, 37)
        Me.IconButton1.TabIndex = 243
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'lblSApePerfil
        '
        Me.lblSApePerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblSApePerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblSApePerfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSApePerfil.ForeColor = System.Drawing.Color.Silver
        Me.lblSApePerfil.Location = New System.Drawing.Point(40, 460)
        Me.lblSApePerfil.Name = "lblSApePerfil"
        Me.lblSApePerfil.Size = New System.Drawing.Size(127, 20)
        Me.lblSApePerfil.TabIndex = 239
        Me.lblSApePerfil.Text = "Segundo apellido"
        '
        'txtSApePerfil
        '
        Me.txtSApePerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSApePerfil.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtSApePerfil, Guna.UI.Animation.DecorationType.None)
        Me.txtSApePerfil.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSApePerfil.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSApePerfil.ForeColor = System.Drawing.Color.White
        Me.txtSApePerfil.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSApePerfil.LineSize = 1
        Me.txtSApePerfil.Location = New System.Drawing.Point(40, 491)
        Me.txtSApePerfil.Name = "txtSApePerfil"
        Me.txtSApePerfil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSApePerfil.Size = New System.Drawing.Size(246, 32)
        Me.txtSApePerfil.TabIndex = 238
        '
        'lblPApePerfil
        '
        Me.lblPApePerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblPApePerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblPApePerfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPApePerfil.ForeColor = System.Drawing.Color.Silver
        Me.lblPApePerfil.Location = New System.Drawing.Point(40, 362)
        Me.lblPApePerfil.Name = "lblPApePerfil"
        Me.lblPApePerfil.Size = New System.Drawing.Size(111, 20)
        Me.lblPApePerfil.TabIndex = 237
        Me.lblPApePerfil.Text = "Primer apellido"
        '
        'txtPApe
        '
        Me.txtPApe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPApe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtPApe, Guna.UI.Animation.DecorationType.None)
        Me.txtPApe.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPApe.ForeColor = System.Drawing.Color.White
        Me.txtPApe.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPApe.LineSize = 1
        Me.txtPApe.Location = New System.Drawing.Point(40, 394)
        Me.txtPApe.Name = "txtPApe"
        Me.txtPApe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPApe.Size = New System.Drawing.Size(246, 32)
        Me.txtPApe.TabIndex = 236
        '
        'lblSNomPerfil
        '
        Me.lblSNomPerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblSNomPerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblSNomPerfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSNomPerfil.ForeColor = System.Drawing.Color.Silver
        Me.lblSNomPerfil.Location = New System.Drawing.Point(40, 250)
        Me.lblSNomPerfil.Name = "lblSNomPerfil"
        Me.lblSNomPerfil.Size = New System.Drawing.Size(124, 20)
        Me.lblSNomPerfil.TabIndex = 235
        Me.lblSNomPerfil.Text = "Segundo nombre"
        '
        'txtSNom
        '
        Me.txtSNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtSNom, Guna.UI.Animation.DecorationType.None)
        Me.txtSNom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNom.ForeColor = System.Drawing.Color.White
        Me.txtSNom.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSNom.LineSize = 1
        Me.txtSNom.Location = New System.Drawing.Point(40, 277)
        Me.txtSNom.Name = "txtSNom"
        Me.txtSNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSNom.Size = New System.Drawing.Size(246, 32)
        Me.txtSNom.TabIndex = 234
        '
        'txtPNom
        '
        Me.txtPNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtPNom, Guna.UI.Animation.DecorationType.None)
        Me.txtPNom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNom.ForeColor = System.Drawing.Color.White
        Me.txtPNom.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPNom.LineSize = 1
        Me.txtPNom.Location = New System.Drawing.Point(40, 177)
        Me.txtPNom.Name = "txtPNom"
        Me.txtPNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPNom.Size = New System.Drawing.Size(246, 32)
        Me.txtPNom.TabIndex = 233
        '
        'lblPNomPerfil
        '
        Me.lblPNomPerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblPNomPerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblPNomPerfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNomPerfil.ForeColor = System.Drawing.Color.Silver
        Me.lblPNomPerfil.Location = New System.Drawing.Point(40, 148)
        Me.lblPNomPerfil.Name = "lblPNomPerfil"
        Me.lblPNomPerfil.Size = New System.Drawing.Size(108, 20)
        Me.lblPNomPerfil.TabIndex = 232
        Me.lblPNomPerfil.Text = "Primer nombre"
        '
        'lblMiInformacion
        '
        Me.lblMiInformacion.AutoSize = True
        Me.transicion.SetDecoration(Me.lblMiInformacion, Guna.UI.Animation.DecorationType.None)
        Me.lblMiInformacion.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiInformacion.ForeColor = System.Drawing.Color.White
        Me.lblMiInformacion.Location = New System.Drawing.Point(28, 90)
        Me.lblMiInformacion.Name = "lblMiInformacion"
        Me.lblMiInformacion.Size = New System.Drawing.Size(178, 32)
        Me.lblMiInformacion.TabIndex = 31
        Me.lblMiInformacion.Text = "Mi información"
        '
        'pnlContacto
        '
        Me.pnlContacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContacto.Controls.Add(Me.scroll)
        Me.pnlContacto.Controls.Add(Me.btnAtras)
        Me.pnlContacto.Controls.Add(Me.txtMail)
        Me.pnlContacto.Controls.Add(Me.lblCorreoPerfil)
        Me.pnlContacto.Controls.Add(Me.lblTelesPerfil)
        Me.pnlContacto.Controls.Add(Me.btnEliminarPerfil)
        Me.pnlContacto.Controls.Add(Me.btnAceptarPerfil)
        Me.pnlContacto.Controls.Add(Me.dgvTelefonos)
        Me.pnlContacto.Controls.Add(Me.lblContactoPerfil)
        Me.transicion.SetDecoration(Me.pnlContacto, Guna.UI.Animation.DecorationType.None)
        Me.pnlContacto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContacto.Location = New System.Drawing.Point(0, 0)
        Me.pnlContacto.Name = "pnlContacto"
        Me.pnlContacto.Size = New System.Drawing.Size(424, 648)
        Me.pnlContacto.TabIndex = 240
        '
        'scroll
        '
        Me.transicion.SetDecoration(Me.scroll, Guna.UI.Animation.DecorationType.None)
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(289, 264)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll.Size = New System.Drawing.Size(5, 200)
        Me.scroll.TabIndex = 243
        Me.scroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.btnAtras, Guna.UI.Animation.DecorationType.None)
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAtras.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Silver
        Me.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnAtras.IconColor = System.Drawing.Color.Silver
        Me.btnAtras.IconSize = 20
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(22, 22)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Rotation = 0R
        Me.btnAtras.Size = New System.Drawing.Size(37, 37)
        Me.btnAtras.TabIndex = 242
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'txtMail
        '
        Me.txtMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtMail, Guna.UI.Animation.DecorationType.None)
        Me.txtMail.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.ForeColor = System.Drawing.Color.White
        Me.txtMail.LineColor = System.Drawing.Color.Gainsboro
        Me.txtMail.LineSize = 1
        Me.txtMail.Location = New System.Drawing.Point(38, 190)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMail.Size = New System.Drawing.Size(246, 32)
        Me.txtMail.TabIndex = 241
        '
        'lblCorreoPerfil
        '
        Me.lblCorreoPerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblCorreoPerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblCorreoPerfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoPerfil.ForeColor = System.Drawing.Color.Silver
        Me.lblCorreoPerfil.Location = New System.Drawing.Point(34, 162)
        Me.lblCorreoPerfil.Name = "lblCorreoPerfil"
        Me.lblCorreoPerfil.Size = New System.Drawing.Size(132, 20)
        Me.lblCorreoPerfil.TabIndex = 240
        Me.lblCorreoPerfil.Text = "Correo electrónico"
        '
        'lblTelesPerfil
        '
        Me.lblTelesPerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblTelesPerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblTelesPerfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelesPerfil.ForeColor = System.Drawing.Color.Silver
        Me.lblTelesPerfil.Location = New System.Drawing.Point(117, 284)
        Me.lblTelesPerfil.Name = "lblTelesPerfil"
        Me.lblTelesPerfil.Size = New System.Drawing.Size(73, 20)
        Me.lblTelesPerfil.TabIndex = 239
        Me.lblTelesPerfil.Text = "Teléfonos"
        '
        'btnEliminarPerfil
        '
        Me.btnEliminarPerfil.Animated = True
        Me.btnEliminarPerfil.AnimationHoverSpeed = 0.07!
        Me.btnEliminarPerfil.AnimationSpeed = 0.03!
        Me.btnEliminarPerfil.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarPerfil.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEliminarPerfil.BorderColor = System.Drawing.Color.Black
        Me.btnEliminarPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.btnEliminarPerfil, Guna.UI.Animation.DecorationType.None)
        Me.btnEliminarPerfil.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEliminarPerfil.Enabled = False
        Me.btnEliminarPerfil.FocusedColor = System.Drawing.Color.Empty
        Me.btnEliminarPerfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPerfil.ForeColor = System.Drawing.Color.White
        Me.btnEliminarPerfil.Image = Nothing
        Me.btnEliminarPerfil.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEliminarPerfil.Location = New System.Drawing.Point(300, 315)
        Me.btnEliminarPerfil.Name = "btnEliminarPerfil"
        Me.btnEliminarPerfil.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnEliminarPerfil.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEliminarPerfil.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEliminarPerfil.OnHoverImage = Nothing
        Me.btnEliminarPerfil.OnPressedColor = System.Drawing.Color.Black
        Me.btnEliminarPerfil.Radius = 10
        Me.btnEliminarPerfil.Size = New System.Drawing.Size(96, 42)
        Me.btnEliminarPerfil.TabIndex = 238
        Me.btnEliminarPerfil.Text = "Borrar"
        Me.btnEliminarPerfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAceptarPerfil
        '
        Me.btnAceptarPerfil.Animated = True
        Me.btnAceptarPerfil.AnimationHoverSpeed = 0.07!
        Me.btnAceptarPerfil.AnimationSpeed = 0.03!
        Me.btnAceptarPerfil.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptarPerfil.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAceptarPerfil.BorderColor = System.Drawing.Color.Black
        Me.btnAceptarPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.transicion.SetDecoration(Me.btnAceptarPerfil, Guna.UI.Animation.DecorationType.None)
        Me.btnAceptarPerfil.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptarPerfil.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptarPerfil.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarPerfil.ForeColor = System.Drawing.Color.White
        Me.btnAceptarPerfil.Image = Nothing
        Me.btnAceptarPerfil.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptarPerfil.Location = New System.Drawing.Point(300, 384)
        Me.btnAceptarPerfil.Name = "btnAceptarPerfil"
        Me.btnAceptarPerfil.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAceptarPerfil.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAceptarPerfil.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptarPerfil.OnHoverImage = Nothing
        Me.btnAceptarPerfil.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptarPerfil.Radius = 10
        Me.btnAceptarPerfil.Size = New System.Drawing.Size(96, 42)
        Me.btnAceptarPerfil.TabIndex = 237
        Me.btnAceptarPerfil.Text = "Añadir"
        Me.btnAceptarPerfil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgvTelefonos
        '
        Me.dgvTelefonos.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver
        Me.dgvTelefonos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTelefonos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTelefonos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTelefonos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTelefonos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTelefonos.ColumnHeadersVisible = False
        Me.dgvTelefonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Telefonos})
        Me.transicion.SetDecoration(Me.dgvTelefonos, Guna.UI.Animation.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTelefonos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTelefonos.Location = New System.Drawing.Point(43, 315)
        Me.dgvTelefonos.MultiSelect = False
        Me.dgvTelefonos.Name = "dgvTelefonos"
        Me.dgvTelefonos.RowHeadersVisible = False
        Me.dgvTelefonos.RowHeadersWidth = 51
        Me.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTelefonos.Size = New System.Drawing.Size(237, 111)
        Me.dgvTelefonos.TabIndex = 236
        '
        'Telefonos
        '
        Me.Telefonos.HeaderText = "Telefonos"
        Me.Telefonos.MinimumWidth = 6
        Me.Telefonos.Name = "Telefonos"
        '
        'lblContactoPerfil
        '
        Me.lblContactoPerfil.AutoSize = True
        Me.transicion.SetDecoration(Me.lblContactoPerfil, Guna.UI.Animation.DecorationType.None)
        Me.lblContactoPerfil.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactoPerfil.ForeColor = System.Drawing.Color.White
        Me.lblContactoPerfil.Location = New System.Drawing.Point(28, 90)
        Me.lblContactoPerfil.Name = "lblContactoPerfil"
        Me.lblContactoPerfil.Size = New System.Drawing.Size(111, 32)
        Me.lblContactoPerfil.TabIndex = 31
        Me.lblContactoPerfil.Text = "Contacto"
        '
        'UCVerPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.pnlCredenciales)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlYo)
        Me.Controls.Add(Me.pnlContacto)
        Me.transicion.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.Name = "UCVerPerfil"
        Me.Size = New System.Drawing.Size(424, 648)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnModificarPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPatologias.ResumeLayout(False)
        Me.pnlPatologias.PerformLayout()
        Me.pnlMedico.ResumeLayout(False)
        Me.pnlMedico.PerformLayout()
        Me.pnlPaciente.ResumeLayout(False)
        Me.pnlPaciente.PerformLayout()
        Me.pnlCredenciales.ResumeLayout(False)
        Me.pnlCredenciales.PerformLayout()
        Me.pnlYo.ResumeLayout(False)
        Me.pnlYo.PerformLayout()
        Me.pnlMedYo.ResumeLayout(False)
        Me.pnlMedYo.PerformLayout()
        Me.pnlContacto.ResumeLayout(False)
        Me.pnlContacto.PerformLayout()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblTel As Label
    Friend WithEvents lblEmailPerfil As Label
    Friend WithEvents lblNomPerfil As Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnModificarPerfil As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblMailPerfil As Label
    Friend WithEvents lblNombrePerfil As Label
    Friend WithEvents lblTelefonosPerfil As Label
    Friend WithEvents pnlMedico As Panel
    Friend WithEvents lblEspecializacionPerfil As Label
    Friend WithEvents lblEspe As Label
    Friend WithEvents pnlPaciente As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents lblEdadPerfil As Label
    Friend WithEvents lblEd As Label
    Friend WithEvents transicion As Guna.UI.WinForms.GunaTransition
    Friend WithEvents pnlCredenciales As Panel
    Friend WithEvents lblCredenciales As Label
    Friend WithEvents lblRepetirCon As Label
    Friend WithEvents txtPassRep As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblCon As Label
    Friend WithEvents txtPassNueva As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents pnlYo As Panel
    Friend WithEvents lblMiInformacion As Label
    Friend WithEvents lblSApePerfil As Label
    Friend WithEvents txtSApePerfil As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblPApePerfil As Label
    Friend WithEvents txtPApe As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblSNomPerfil As Label
    Friend WithEvents txtSNom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtPNom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblPNomPerfil As Label
    Friend WithEvents pnlContacto As Panel
    Friend WithEvents lblContactoPerfil As Label
    Friend WithEvents btnEliminarPerfil As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAceptarPerfil As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgvTelefonos As DataGridView
    Friend WithEvents Telefonos As DataGridViewTextBoxColumn
    Friend WithEvents lblTelesPerfil As Label
    Friend WithEvents txtMail As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblCorreoPerfil As Label
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents btnRegistrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblEspecPerfil As Label
    Friend WithEvents txtEspe As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents pnlMedYo As Panel
    Friend WithEvents btnVerPatologias As Button
    Friend WithEvents pnlPatologias As Panel
    Friend WithEvents lblPatologiasCronicas As Label
    Friend WithEvents lblPatCron As Label
    Friend WithEvents btnModPatologias As Button
    Friend WithEvents lblPassActual As Label
    Friend WithEvents txtPassActual As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnChangePass As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
End Class
