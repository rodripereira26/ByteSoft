<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistroPaciente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPatCron = New Guna.UI.WinForms.GunaButton()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.sepFecNac = New Guna.UI.WinForms.GunaSeparator()
        Me.btnSoliCuentaPac = New Guna.UI.WinForms.GunaButton()
        Me.lblFecNacPac = New System.Windows.Forms.Label()
        Me.cbF = New Guna.UI.WinForms.GunaRadioButton()
        Me.lblSexoRegPac = New System.Windows.Forms.Label()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.btnAceptarRegPac = New Guna.UI.WinForms.GunaButton()
        Me.cbM = New Guna.UI.WinForms.GunaRadioButton()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.txtRepPass = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtSApe = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtCI = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtPApe = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblPassPac = New System.Windows.Forms.Label()
        Me.lblSNom = New System.Windows.Forms.Label()
        Me.lblCIRegPac = New System.Windows.Forms.Label()
        Me.lblMailRegistroPaciente = New System.Windows.Forms.Label()
        Me.lblPNomRegisPaciente = New System.Windows.Forms.Label()
        Me.lblPApeRegPaciente = New System.Windows.Forms.Label()
        Me.lblSApeRegPaciente = New System.Windows.Forms.Label()
        Me.lblMiFotoPac = New System.Windows.Forms.Label()
        Me.txtPass = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblFormatoFecNac = New System.Windows.Forms.Label()
        Me.lblRepPassPac = New System.Windows.Forms.Label()
        Me.btnImg = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.txtFecNac = New System.Windows.Forms.MaskedTextBox()
        Me.txtSNom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtPNom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnEliminarRegPac = New Guna.UI.WinForms.GunaButton()
        Me.txtMail = New Guna.UI.WinForms.GunaLineTextBox()
        Me.dgvTelefonos = New System.Windows.Forms.DataGridView()
        Me.Telefonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.pnlContenedor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.Panel1)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 164
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPatCron)
        Me.Panel1.Controls.Add(Me.btnAtras)
        Me.Panel1.Controls.Add(Me.sepFecNac)
        Me.Panel1.Controls.Add(Me.btnSoliCuentaPac)
        Me.Panel1.Controls.Add(Me.lblFecNacPac)
        Me.Panel1.Controls.Add(Me.cbF)
        Me.Panel1.Controls.Add(Me.lblSexoRegPac)
        Me.Panel1.Controls.Add(Me.scroll)
        Me.Panel1.Controls.Add(Me.btnAceptarRegPac)
        Me.Panel1.Controls.Add(Me.cbM)
        Me.Panel1.Controls.Add(Me.lblTelefonos)
        Me.Panel1.Controls.Add(Me.txtRepPass)
        Me.Panel1.Controls.Add(Me.txtSApe)
        Me.Panel1.Controls.Add(Me.txtCI)
        Me.Panel1.Controls.Add(Me.txtPApe)
        Me.Panel1.Controls.Add(Me.lblPassPac)
        Me.Panel1.Controls.Add(Me.lblSNom)
        Me.Panel1.Controls.Add(Me.lblCIRegPac)
        Me.Panel1.Controls.Add(Me.lblMailRegistroPaciente)
        Me.Panel1.Controls.Add(Me.lblPNomRegisPaciente)
        Me.Panel1.Controls.Add(Me.lblPApeRegPaciente)
        Me.Panel1.Controls.Add(Me.lblSApeRegPaciente)
        Me.Panel1.Controls.Add(Me.lblMiFotoPac)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.lblFormatoFecNac)
        Me.Panel1.Controls.Add(Me.lblRepPassPac)
        Me.Panel1.Controls.Add(Me.btnImg)
        Me.Panel1.Controls.Add(Me.GunaPictureBox1)
        Me.Panel1.Controls.Add(Me.txtFecNac)
        Me.Panel1.Controls.Add(Me.txtSNom)
        Me.Panel1.Controls.Add(Me.lbl1)
        Me.Panel1.Controls.Add(Me.txtPNom)
        Me.Panel1.Controls.Add(Me.btnEliminarRegPac)
        Me.Panel1.Controls.Add(Me.txtMail)
        Me.Panel1.Controls.Add(Me.dgvTelefonos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1070, 650)
        Me.Panel1.TabIndex = 233
        '
        'btnPatCron
        '
        Me.btnPatCron.Animated = True
        Me.btnPatCron.AnimationHoverSpeed = 0.07!
        Me.btnPatCron.AnimationSpeed = 0.03!
        Me.btnPatCron.BackColor = System.Drawing.Color.Transparent
        Me.btnPatCron.BaseColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnPatCron.BorderColor = System.Drawing.Color.Black
        Me.btnPatCron.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatCron.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPatCron.FocusedColor = System.Drawing.Color.Empty
        Me.btnPatCron.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatCron.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPatCron.Image = Nothing
        Me.btnPatCron.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnPatCron.Location = New System.Drawing.Point(432, 504)
        Me.btnPatCron.Name = "btnPatCron"
        Me.btnPatCron.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnPatCron.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPatCron.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPatCron.OnHoverImage = Nothing
        Me.btnPatCron.OnPressedColor = System.Drawing.Color.Black
        Me.btnPatCron.Radius = 10
        Me.btnPatCron.Size = New System.Drawing.Size(196, 42)
        Me.btnPatCron.TabIndex = 232
        Me.btnPatCron.Text = "Añadir patologías crónicas"
        Me.btnPatCron.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAtras.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Silver
        Me.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnAtras.IconColor = System.Drawing.Color.Silver
        Me.btnAtras.IconSize = 20
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(18, 22)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Rotation = 0R
        Me.btnAtras.Size = New System.Drawing.Size(117, 37)
        Me.btnAtras.TabIndex = 231
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'sepFecNac
        '
        Me.sepFecNac.LineColor = System.Drawing.Color.Silver
        Me.sepFecNac.Location = New System.Drawing.Point(709, 460)
        Me.sepFecNac.Name = "sepFecNac"
        Me.sepFecNac.Size = New System.Drawing.Size(146, 10)
        Me.sepFecNac.TabIndex = 227
        '
        'btnSoliCuentaPac
        '
        Me.btnSoliCuentaPac.Animated = True
        Me.btnSoliCuentaPac.AnimationHoverSpeed = 0.07!
        Me.btnSoliCuentaPac.AnimationSpeed = 0.03!
        Me.btnSoliCuentaPac.BackColor = System.Drawing.Color.Transparent
        Me.btnSoliCuentaPac.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSoliCuentaPac.BorderColor = System.Drawing.Color.Black
        Me.btnSoliCuentaPac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSoliCuentaPac.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSoliCuentaPac.FocusedColor = System.Drawing.Color.Empty
        Me.btnSoliCuentaPac.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSoliCuentaPac.ForeColor = System.Drawing.Color.White
        Me.btnSoliCuentaPac.Image = Nothing
        Me.btnSoliCuentaPac.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSoliCuentaPac.Location = New System.Drawing.Point(429, 577)
        Me.btnSoliCuentaPac.Name = "btnSoliCuentaPac"
        Me.btnSoliCuentaPac.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSoliCuentaPac.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSoliCuentaPac.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSoliCuentaPac.OnHoverImage = Nothing
        Me.btnSoliCuentaPac.OnPressedColor = System.Drawing.Color.Black
        Me.btnSoliCuentaPac.Radius = 14
        Me.btnSoliCuentaPac.Size = New System.Drawing.Size(199, 42)
        Me.btnSoliCuentaPac.TabIndex = 230
        Me.btnSoliCuentaPac.Text = "Solicitar cuenta"
        Me.btnSoliCuentaPac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFecNacPac
        '
        Me.lblFecNacPac.AutoSize = True
        Me.lblFecNacPac.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecNacPac.ForeColor = System.Drawing.Color.Silver
        Me.lblFecNacPac.Location = New System.Drawing.Point(705, 393)
        Me.lblFecNacPac.Name = "lblFecNacPac"
        Me.lblFecNacPac.Size = New System.Drawing.Size(149, 20)
        Me.lblFecNacPac.TabIndex = 226
        Me.lblFecNacPac.Text = "Fecha de Nacimiento"
        '
        'cbF
        '
        Me.cbF.BaseColor = System.Drawing.Color.Gray
        Me.cbF.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbF.CheckedOnColor = System.Drawing.Color.DarkSlateBlue
        Me.cbF.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.cbF.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbF.ForeColor = System.Drawing.Color.Silver
        Me.cbF.Location = New System.Drawing.Point(930, 454)
        Me.cbF.Name = "cbF"
        Me.cbF.Size = New System.Drawing.Size(98, 24)
        Me.cbF.TabIndex = 11
        Me.cbF.Text = "Femenino"
        '
        'lblSexoRegPac
        '
        Me.lblSexoRegPac.AutoSize = True
        Me.lblSexoRegPac.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexoRegPac.ForeColor = System.Drawing.Color.Silver
        Me.lblSexoRegPac.Location = New System.Drawing.Point(922, 393)
        Me.lblSexoRegPac.Name = "lblSexoRegPac"
        Me.lblSexoRegPac.Size = New System.Drawing.Size(41, 20)
        Me.lblSexoRegPac.TabIndex = 225
        Me.lblSexoRegPac.Text = "Sexo"
        '
        'scroll
        '
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(910, 235)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll.Size = New System.Drawing.Size(10, 107)
        Me.scroll.TabIndex = 221
        Me.scroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'btnAceptarRegPac
        '
        Me.btnAceptarRegPac.Animated = True
        Me.btnAceptarRegPac.AnimationHoverSpeed = 0.07!
        Me.btnAceptarRegPac.AnimationSpeed = 0.03!
        Me.btnAceptarRegPac.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptarRegPac.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAceptarRegPac.BorderColor = System.Drawing.Color.Black
        Me.btnAceptarRegPac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptarRegPac.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAceptarRegPac.FocusedColor = System.Drawing.Color.Empty
        Me.btnAceptarRegPac.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptarRegPac.ForeColor = System.Drawing.Color.White
        Me.btnAceptarRegPac.Image = Nothing
        Me.btnAceptarRegPac.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAceptarRegPac.Location = New System.Drawing.Point(926, 304)
        Me.btnAceptarRegPac.Name = "btnAceptarRegPac"
        Me.btnAceptarRegPac.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAceptarRegPac.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAceptarRegPac.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAceptarRegPac.OnHoverImage = Nothing
        Me.btnAceptarRegPac.OnPressedColor = System.Drawing.Color.Black
        Me.btnAceptarRegPac.Radius = 14
        Me.btnAceptarRegPac.Size = New System.Drawing.Size(96, 42)
        Me.btnAceptarRegPac.TabIndex = 219
        Me.btnAceptarRegPac.Text = "Añadir"
        Me.btnAceptarRegPac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbM
        '
        Me.cbM.BaseColor = System.Drawing.Color.Gray
        Me.cbM.CheckedOffColor = System.Drawing.Color.Gray
        Me.cbM.CheckedOnColor = System.Drawing.Color.DarkSlateBlue
        Me.cbM.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.cbM.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbM.ForeColor = System.Drawing.Color.Silver
        Me.cbM.Location = New System.Drawing.Point(930, 421)
        Me.cbM.Name = "cbM"
        Me.cbM.Size = New System.Drawing.Size(100, 24)
        Me.cbM.TabIndex = 10
        Me.cbM.Text = "Masculino"
        '
        'lblTelefonos
        '
        Me.lblTelefonos.AutoSize = True
        Me.lblTelefonos.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonos.ForeColor = System.Drawing.Color.Silver
        Me.lblTelefonos.Location = New System.Drawing.Point(773, 190)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(73, 20)
        Me.lblTelefonos.TabIndex = 218
        Me.lblTelefonos.Text = "Teléfonos"
        '
        'txtRepPass
        '
        Me.txtRepPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRepPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRepPass.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRepPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepPass.ForeColor = System.Drawing.Color.White
        Me.txtRepPass.LineColor = System.Drawing.Color.Gainsboro
        Me.txtRepPass.LineSize = 1
        Me.txtRepPass.Location = New System.Drawing.Point(53, 358)
        Me.txtRepPass.Name = "txtRepPass"
        Me.txtRepPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRepPass.Size = New System.Drawing.Size(246, 32)
        Me.txtRepPass.TabIndex = 3
        Me.txtRepPass.UseSystemPasswordChar = True
        '
        'txtSApe
        '
        Me.txtSApe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSApe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSApe.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSApe.ForeColor = System.Drawing.Color.White
        Me.txtSApe.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSApe.LineSize = 1
        Me.txtSApe.Location = New System.Drawing.Point(382, 432)
        Me.txtSApe.Name = "txtSApe"
        Me.txtSApe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSApe.Size = New System.Drawing.Size(246, 32)
        Me.txtSApe.TabIndex = 7
        '
        'txtCI
        '
        Me.txtCI.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCI.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCI.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCI.ForeColor = System.Drawing.Color.White
        Me.txtCI.LineColor = System.Drawing.Color.Gainsboro
        Me.txtCI.LineSize = 1
        Me.txtCI.Location = New System.Drawing.Point(53, 108)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCI.Size = New System.Drawing.Size(246, 32)
        Me.txtCI.TabIndex = 1
        '
        'txtPApe
        '
        Me.txtPApe.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPApe.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPApe.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPApe.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPApe.ForeColor = System.Drawing.Color.White
        Me.txtPApe.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPApe.LineSize = 1
        Me.txtPApe.Location = New System.Drawing.Point(382, 334)
        Me.txtPApe.Name = "txtPApe"
        Me.txtPApe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPApe.Size = New System.Drawing.Size(246, 32)
        Me.txtPApe.TabIndex = 6
        '
        'lblPassPac
        '
        Me.lblPassPac.AutoSize = True
        Me.lblPassPac.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassPac.ForeColor = System.Drawing.Color.Silver
        Me.lblPassPac.Location = New System.Drawing.Point(49, 190)
        Me.lblPassPac.Name = "lblPassPac"
        Me.lblPassPac.Size = New System.Drawing.Size(83, 20)
        Me.lblPassPac.TabIndex = 206
        Me.lblPassPac.Text = "Contraseña"
        '
        'lblSNom
        '
        Me.lblSNom.AutoSize = True
        Me.lblSNom.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSNom.ForeColor = System.Drawing.Color.Silver
        Me.lblSNom.Location = New System.Drawing.Point(378, 174)
        Me.lblSNom.Name = "lblSNom"
        Me.lblSNom.Size = New System.Drawing.Size(124, 20)
        Me.lblSNom.TabIndex = 212
        Me.lblSNom.Text = "Segundo nombre"
        '
        'lblCIRegPac
        '
        Me.lblCIRegPac.AutoSize = True
        Me.lblCIRegPac.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIRegPac.ForeColor = System.Drawing.Color.Silver
        Me.lblCIRegPac.Location = New System.Drawing.Point(49, 80)
        Me.lblCIRegPac.Name = "lblCIRegPac"
        Me.lblCIRegPac.Size = New System.Drawing.Size(144, 20)
        Me.lblCIRegPac.TabIndex = 201
        Me.lblCIRegPac.Text = "Cédula de Identidad"
        '
        'lblMailRegistroPaciente
        '
        Me.lblMailRegistroPaciente.AutoSize = True
        Me.lblMailRegistroPaciente.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailRegistroPaciente.ForeColor = System.Drawing.Color.Silver
        Me.lblMailRegistroPaciente.Location = New System.Drawing.Point(722, 80)
        Me.lblMailRegistroPaciente.Name = "lblMailRegistroPaciente"
        Me.lblMailRegistroPaciente.Size = New System.Drawing.Size(132, 20)
        Me.lblMailRegistroPaciente.TabIndex = 202
        Me.lblMailRegistroPaciente.Text = "Correo electrónico"
        '
        'lblPNomRegisPaciente
        '
        Me.lblPNomRegisPaciente.AutoSize = True
        Me.lblPNomRegisPaciente.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNomRegisPaciente.ForeColor = System.Drawing.Color.Silver
        Me.lblPNomRegisPaciente.Location = New System.Drawing.Point(378, 80)
        Me.lblPNomRegisPaciente.Name = "lblPNomRegisPaciente"
        Me.lblPNomRegisPaciente.Size = New System.Drawing.Size(108, 20)
        Me.lblPNomRegisPaciente.TabIndex = 209
        Me.lblPNomRegisPaciente.Text = "Primer nombre"
        '
        'lblPApeRegPaciente
        '
        Me.lblPApeRegPaciente.AutoSize = True
        Me.lblPApeRegPaciente.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPApeRegPaciente.ForeColor = System.Drawing.Color.Silver
        Me.lblPApeRegPaciente.Location = New System.Drawing.Point(378, 294)
        Me.lblPApeRegPaciente.Name = "lblPApeRegPaciente"
        Me.lblPApeRegPaciente.Size = New System.Drawing.Size(111, 20)
        Me.lblPApeRegPaciente.TabIndex = 214
        Me.lblPApeRegPaciente.Text = "Primer apellido"
        '
        'lblSApeRegPaciente
        '
        Me.lblSApeRegPaciente.AutoSize = True
        Me.lblSApeRegPaciente.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSApeRegPaciente.ForeColor = System.Drawing.Color.Silver
        Me.lblSApeRegPaciente.Location = New System.Drawing.Point(378, 393)
        Me.lblSApeRegPaciente.Name = "lblSApeRegPaciente"
        Me.lblSApeRegPaciente.Size = New System.Drawing.Size(127, 20)
        Me.lblSApeRegPaciente.TabIndex = 216
        Me.lblSApeRegPaciente.Text = "Segundo apellido"
        '
        'lblMiFotoPac
        '
        Me.lblMiFotoPac.AutoSize = True
        Me.lblMiFotoPac.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiFotoPac.ForeColor = System.Drawing.Color.Silver
        Me.lblMiFotoPac.Location = New System.Drawing.Point(124, 432)
        Me.lblMiFotoPac.Name = "lblMiFotoPac"
        Me.lblMiFotoPac.Size = New System.Drawing.Size(58, 20)
        Me.lblMiFotoPac.TabIndex = 200
        Me.lblMiFotoPac.Text = "Mi foto"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.White
        Me.txtPass.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPass.LineSize = 1
        Me.txtPass.Location = New System.Drawing.Point(53, 219)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Size = New System.Drawing.Size(246, 32)
        Me.txtPass.TabIndex = 2
        Me.txtPass.UseSystemPasswordChar = True
        '
        'lblFormatoFecNac
        '
        Me.lblFormatoFecNac.AutoSize = True
        Me.lblFormatoFecNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormatoFecNac.ForeColor = System.Drawing.Color.Silver
        Me.lblFormatoFecNac.Location = New System.Drawing.Point(736, 484)
        Me.lblFormatoFecNac.Name = "lblFormatoFecNac"
        Me.lblFormatoFecNac.Size = New System.Drawing.Size(88, 18)
        Me.lblFormatoFecNac.TabIndex = 163
        Me.lblFormatoFecNac.Text = "yyyy-mm-dd"
        '
        'lblRepPassPac
        '
        Me.lblRepPassPac.AutoSize = True
        Me.lblRepPassPac.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepPassPac.ForeColor = System.Drawing.Color.Silver
        Me.lblRepPassPac.Location = New System.Drawing.Point(49, 324)
        Me.lblRepPassPac.Name = "lblRepPassPac"
        Me.lblRepPassPac.Size = New System.Drawing.Size(133, 20)
        Me.lblRepPassPac.TabIndex = 208
        Me.lblRepPassPac.Text = "Repetir contraseña"
        '
        'btnImg
        '
        Me.btnImg.Animated = True
        Me.btnImg.AnimationHoverSpeed = 0.07!
        Me.btnImg.AnimationSpeed = 0.03!
        Me.btnImg.BackColor = System.Drawing.Color.Transparent
        Me.btnImg.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnImg.BorderColor = System.Drawing.Color.Black
        Me.btnImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImg.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnImg.FocusedColor = System.Drawing.Color.Empty
        Me.btnImg.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImg.ForeColor = System.Drawing.Color.White
        Me.btnImg.Image = Nothing
        Me.btnImg.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnImg.Location = New System.Drawing.Point(128, 588)
        Me.btnImg.Name = "btnImg"
        Me.btnImg.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnImg.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnImg.OnHoverForeColor = System.Drawing.Color.White
        Me.btnImg.OnHoverImage = Nothing
        Me.btnImg.OnPressedColor = System.Drawing.Color.Black
        Me.btnImg.Radius = 10
        Me.btnImg.Size = New System.Drawing.Size(58, 32)
        Me.btnImg.TabIndex = 199
        Me.btnImg.Text = "+"
        Me.btnImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GunaPictureBox1.Location = New System.Drawing.Point(96, 462)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Radius = 30
        Me.GunaPictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 198
        Me.GunaPictureBox1.TabStop = False
        '
        'txtFecNac
        '
        Me.txtFecNac.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtFecNac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFecNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecNac.ForeColor = System.Drawing.Color.Silver
        Me.txtFecNac.Location = New System.Drawing.Point(724, 430)
        Me.txtFecNac.Mask = "0000-00-00"
        Me.txtFecNac.Name = "txtFecNac"
        Me.txtFecNac.Size = New System.Drawing.Size(114, 24)
        Me.txtFecNac.TabIndex = 9
        Me.txtFecNac.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtSNom
        '
        Me.txtSNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSNom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNom.ForeColor = System.Drawing.Color.White
        Me.txtSNom.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSNom.LineSize = 1
        Me.txtSNom.Location = New System.Drawing.Point(382, 209)
        Me.txtSNom.Name = "txtSNom"
        Me.txtSNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSNom.Size = New System.Drawing.Size(246, 32)
        Me.txtSNom.TabIndex = 5
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(132, 432)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 24)
        Me.lbl1.TabIndex = 153
        '
        'txtPNom
        '
        Me.txtPNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPNom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPNom.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNom.ForeColor = System.Drawing.Color.White
        Me.txtPNom.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPNom.LineSize = 1
        Me.txtPNom.Location = New System.Drawing.Point(382, 108)
        Me.txtPNom.Name = "txtPNom"
        Me.txtPNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPNom.Size = New System.Drawing.Size(246, 32)
        Me.txtPNom.TabIndex = 4
        '
        'btnEliminarRegPac
        '
        Me.btnEliminarRegPac.Animated = True
        Me.btnEliminarRegPac.AnimationHoverSpeed = 0.07!
        Me.btnEliminarRegPac.AnimationSpeed = 0.03!
        Me.btnEliminarRegPac.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarRegPac.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEliminarRegPac.BorderColor = System.Drawing.Color.Black
        Me.btnEliminarRegPac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarRegPac.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEliminarRegPac.Enabled = False
        Me.btnEliminarRegPac.FocusedColor = System.Drawing.Color.Empty
        Me.btnEliminarRegPac.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarRegPac.ForeColor = System.Drawing.Color.White
        Me.btnEliminarRegPac.Image = Nothing
        Me.btnEliminarRegPac.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEliminarRegPac.Location = New System.Drawing.Point(926, 235)
        Me.btnEliminarRegPac.Name = "btnEliminarRegPac"
        Me.btnEliminarRegPac.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnEliminarRegPac.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEliminarRegPac.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEliminarRegPac.OnHoverImage = Nothing
        Me.btnEliminarRegPac.OnPressedColor = System.Drawing.Color.Black
        Me.btnEliminarRegPac.Radius = 14
        Me.btnEliminarRegPac.Size = New System.Drawing.Size(96, 42)
        Me.btnEliminarRegPac.TabIndex = 220
        Me.btnEliminarRegPac.Text = "Borrar"
        Me.btnEliminarRegPac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMail
        '
        Me.txtMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMail.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMail.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.ForeColor = System.Drawing.Color.White
        Me.txtMail.LineColor = System.Drawing.Color.Gainsboro
        Me.txtMail.LineSize = 1
        Me.txtMail.Location = New System.Drawing.Point(726, 108)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMail.Size = New System.Drawing.Size(246, 32)
        Me.txtMail.TabIndex = 8
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTelefonos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTelefonos.Location = New System.Drawing.Point(714, 235)
        Me.dgvTelefonos.MultiSelect = False
        Me.dgvTelefonos.Name = "dgvTelefonos"
        Me.dgvTelefonos.RowHeadersVisible = False
        Me.dgvTelefonos.RowHeadersWidth = 51
        Me.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTelefonos.Size = New System.Drawing.Size(194, 111)
        Me.dgvTelefonos.TabIndex = 203
        '
        'Telefonos
        '
        Me.Telefonos.HeaderText = "Telefonos"
        Me.Telefonos.MinimumWidth = 6
        Me.Telefonos.Name = "Telefonos"
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(1070, 650)
        Me.pnlInstancia.TabIndex = 234
        '
        'frmRegistroPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistroPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistroPaciente"
        Me.pnlContenedor.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPatCron As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents sepFecNac As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents btnSoliCuentaPac As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblFecNacPac As Label
    Friend WithEvents cbF As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents lblSexoRegPac As Label
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents btnAceptarRegPac As Guna.UI.WinForms.GunaButton
    Friend WithEvents cbM As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents lblTelefonos As Label
    Friend WithEvents txtRepPass As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtSApe As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtCI As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtPApe As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblPassPac As Label
    Friend WithEvents lblSNom As Label
    Friend WithEvents lblCIRegPac As Label
    Friend WithEvents lblMailRegistroPaciente As Label
    Friend WithEvents lblPNomRegisPaciente As Label
    Friend WithEvents lblPApeRegPaciente As Label
    Friend WithEvents lblSApeRegPaciente As Label
    Friend WithEvents lblMiFotoPac As Label
    Friend WithEvents txtPass As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblFormatoFecNac As Label
    Friend WithEvents lblRepPassPac As Label
    Friend WithEvents btnImg As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents txtFecNac As MaskedTextBox
    Friend WithEvents txtSNom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents txtPNom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents btnEliminarRegPac As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtMail As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents dgvTelefonos As DataGridView
    Friend WithEvents Telefonos As DataGridViewTextBoxColumn
    Friend WithEvents pnlInstancia As Panel
End Class
