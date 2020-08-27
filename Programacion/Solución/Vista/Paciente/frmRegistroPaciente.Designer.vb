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
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.cbF = New MaterialSkin.Controls.MaterialRadioButton()
        Me.cbM = New MaterialSkin.Controls.MaterialRadioButton()
        Me.pnlRepPass = New System.Windows.Forms.Panel()
        Me.txtRepPass = New System.Windows.Forms.TextBox()
        Me.pnlPass = New System.Windows.Forms.Panel()
        Me.lblRepPass = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.pnlDecAgregarTelefonos = New System.Windows.Forms.Panel()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.pnlMail = New System.Windows.Forms.Panel()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.pnlCI = New System.Windows.Forms.Panel()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblSolicitarCuenta = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.lblCI = New System.Windows.Forms.Label()
        Me.pnlPNom = New System.Windows.Forms.Panel()
        Me.txtPNom = New System.Windows.Forms.TextBox()
        Me.pnlSApe = New System.Windows.Forms.Panel()
        Me.pnlPApe = New System.Windows.Forms.Panel()
        Me.pnlSNom = New System.Windows.Forms.Panel()
        Me.txtSApe = New System.Windows.Forms.TextBox()
        Me.lblSApe = New System.Windows.Forms.Label()
        Me.txtPApe = New System.Windows.Forms.TextBox()
        Me.lblPApe = New System.Windows.Forms.Label()
        Me.txtSNom = New System.Windows.Forms.TextBox()
        Me.lblSegundoNombre = New System.Windows.Forms.Label()
        Me.lblPNom = New System.Windows.Forms.Label()
        Me.mrbtnSolicitarCuenta = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlDecFecNac = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblFecNac = New System.Windows.Forms.Label()
        Me.dgvTelefonos = New System.Windows.Forms.DataGridView()
        Me.Telefonos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlAgregarTelefonos1 = New System.Windows.Forms.Panel()
        Me.btnAgregar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnEliminar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblAgregarTelefonos = New System.Windows.Forms.Label()
        Me.txtFecNac = New System.Windows.Forms.MaskedTextBox()
        Me.lblFormatoFecNac = New System.Windows.Forms.Label()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAgregarTelefonos1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSexo.Location = New System.Drawing.Point(681, 468)
        Me.lblSexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(68, 29)
        Me.lblSexo.TabIndex = 155
        Me.lblSexo.Text = "Sexo"
        '
        'cbF
        '
        Me.cbF.AutoSize = True
        Me.cbF.Depth = 0
        Me.cbF.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cbF.Location = New System.Drawing.Point(648, 576)
        Me.cbF.Margin = New System.Windows.Forms.Padding(0)
        Me.cbF.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cbF.MouseState = MaterialSkin.MouseState.HOVER
        Me.cbF.Name = "cbF"
        Me.cbF.Ripple = True
        Me.cbF.Size = New System.Drawing.Size(106, 30)
        Me.cbF.TabIndex = 31
        Me.cbF.TabStop = True
        Me.cbF.Text = "Femenino"
        Me.cbF.UseVisualStyleBackColor = True
        '
        'cbM
        '
        Me.cbM.AutoSize = True
        Me.cbM.Depth = 0
        Me.cbM.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cbM.Location = New System.Drawing.Point(648, 524)
        Me.cbM.Margin = New System.Windows.Forms.Padding(0)
        Me.cbM.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cbM.MouseState = MaterialSkin.MouseState.HOVER
        Me.cbM.Name = "cbM"
        Me.cbM.Ripple = True
        Me.cbM.Size = New System.Drawing.Size(110, 30)
        Me.cbM.TabIndex = 30
        Me.cbM.TabStop = True
        Me.cbM.Text = "Masculino"
        Me.cbM.UseVisualStyleBackColor = True
        '
        'pnlRepPass
        '
        Me.pnlRepPass.BackColor = System.Drawing.Color.Black
        Me.pnlRepPass.Location = New System.Drawing.Point(720, 212)
        Me.pnlRepPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlRepPass.Name = "pnlRepPass"
        Me.pnlRepPass.Size = New System.Drawing.Size(235, 2)
        Me.pnlRepPass.TabIndex = 147
        '
        'txtRepPass
        '
        Me.txtRepPass.BackColor = System.Drawing.Color.White
        Me.txtRepPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRepPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRepPass.Location = New System.Drawing.Point(720, 175)
        Me.txtRepPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRepPass.Name = "txtRepPass"
        Me.txtRepPass.Size = New System.Drawing.Size(235, 27)
        Me.txtRepPass.TabIndex = 141
        Me.txtRepPass.UseSystemPasswordChar = True
        '
        'pnlPass
        '
        Me.pnlPass.BackColor = System.Drawing.Color.Black
        Me.pnlPass.Location = New System.Drawing.Point(409, 212)
        Me.pnlPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlPass.Name = "pnlPass"
        Me.pnlPass.Size = New System.Drawing.Size(235, 2)
        Me.pnlPass.TabIndex = 144
        '
        'lblRepPass
        '
        Me.lblRepPass.AutoSize = True
        Me.lblRepPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepPass.Location = New System.Drawing.Point(715, 133)
        Me.lblRepPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRepPass.Name = "lblRepPass"
        Me.lblRepPass.Size = New System.Drawing.Size(221, 29)
        Me.lblRepPass.TabIndex = 145
        Me.lblRepPass.Text = "Repetir Contraseña"
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(409, 175)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(235, 27)
        Me.txtPass.TabIndex = 140
        Me.txtPass.UseSystemPasswordChar = True
        '
        'pnlDecAgregarTelefonos
        '
        Me.pnlDecAgregarTelefonos.BackColor = System.Drawing.Color.Black
        Me.pnlDecAgregarTelefonos.Location = New System.Drawing.Point(204, 562)
        Me.pnlDecAgregarTelefonos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlDecAgregarTelefonos.Name = "pnlDecAgregarTelefonos"
        Me.pnlDecAgregarTelefonos.Size = New System.Drawing.Size(291, 2)
        Me.pnlDecAgregarTelefonos.TabIndex = 153
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(448, 133)
        Me.lblPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(136, 29)
        Me.lblPass.TabIndex = 142
        Me.lblPass.Text = "Contraseña"
        '
        'pnlMail
        '
        Me.pnlMail.BackColor = System.Drawing.Color.Black
        Me.pnlMail.Location = New System.Drawing.Point(1005, 212)
        Me.pnlMail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlMail.Name = "pnlMail"
        Me.pnlMail.Size = New System.Drawing.Size(291, 2)
        Me.pnlMail.TabIndex = 151
        '
        'txtMail
        '
        Me.txtMail.BackColor = System.Drawing.Color.White
        Me.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.Location = New System.Drawing.Point(1013, 175)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(291, 27)
        Me.txtMail.TabIndex = 142
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(1101, 133)
        Me.lblMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(80, 29)
        Me.lblMail.TabIndex = 150
        Me.lblMail.Text = "e-mail"
        '
        'lblTelefonos
        '
        Me.lblTelefonos.AutoSize = True
        Me.lblTelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonos.Location = New System.Drawing.Point(287, 473)
        Me.lblTelefonos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(122, 29)
        Me.lblTelefonos.TabIndex = 148
        Me.lblTelefonos.Text = "Teléfonos"
        '
        'pnlCI
        '
        Me.pnlCI.BackColor = System.Drawing.Color.Black
        Me.pnlCI.Location = New System.Drawing.Point(69, 212)
        Me.pnlCI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlCI.Name = "pnlCI"
        Me.pnlCI.Size = New System.Drawing.Size(235, 2)
        Me.pnlCI.TabIndex = 140
        '
        'txtCI
        '
        Me.txtCI.BackColor = System.Drawing.Color.White
        Me.txtCI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCI.Location = New System.Drawing.Point(69, 175)
        Me.txtCI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(235, 27)
        Me.txtCI.TabIndex = 139
        Me.txtCI.TabStop = False
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.lblSolicitarCuenta)
        Me.pnlTitulo.Controls.Add(Me.btnAtras)
        Me.pnlTitulo.Controls.Add(Me.lblMinimizar)
        Me.pnlTitulo.Controls.Add(Me.lblCerrar)
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1352, 95)
        Me.pnlTitulo.TabIndex = 141
        '
        'lblSolicitarCuenta
        '
        Me.lblSolicitarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSolicitarCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolicitarCuenta.ForeColor = System.Drawing.Color.White
        Me.lblSolicitarCuenta.Location = New System.Drawing.Point(392, 12)
        Me.lblSolicitarCuenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSolicitarCuenta.Name = "lblSolicitarCuenta"
        Me.lblSolicitarCuenta.Size = New System.Drawing.Size(569, 70)
        Me.lblSolicitarCuenta.TabIndex = 155
        Me.lblSolicitarCuenta.Text = "SOLICITAR CUENTA PACIENTE"
        Me.lblSolicitarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icons8_left_32px
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(41, 34)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAtras.Size = New System.Drawing.Size(65, 39)
        Me.btnAtras.TabIndex = 154
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.White
        Me.lblMinimizar.Location = New System.Drawing.Point(1251, -7)
        Me.lblMinimizar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinimizar.Name = "lblMinimizar"
        Me.lblMinimizar.Size = New System.Drawing.Size(32, 43)
        Me.lblMinimizar.TabIndex = 24
        Me.lblMinimizar.Text = "_"
        Me.lblMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCerrar
        '
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(1291, 0)
        Me.lblCerrar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(57, 43)
        Me.lblCerrar.TabIndex = 23
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCI
        '
        Me.lblCI.AutoSize = True
        Me.lblCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCI.Location = New System.Drawing.Point(51, 133)
        Me.lblCI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCI.Name = "lblCI"
        Me.lblCI.Size = New System.Drawing.Size(230, 29)
        Me.lblCI.TabIndex = 138
        Me.lblCI.Text = "Cédula de Identidad"
        '
        'pnlPNom
        '
        Me.pnlPNom.BackColor = System.Drawing.Color.Black
        Me.pnlPNom.Location = New System.Drawing.Point(15, 407)
        Me.pnlPNom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlPNom.Name = "pnlPNom"
        Me.pnlPNom.Size = New System.Drawing.Size(291, 2)
        Me.pnlPNom.TabIndex = 137
        '
        'txtPNom
        '
        Me.txtPNom.BackColor = System.Drawing.Color.White
        Me.txtPNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPNom.Location = New System.Drawing.Point(13, 372)
        Me.txtPNom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPNom.Name = "txtPNom"
        Me.txtPNom.Size = New System.Drawing.Size(291, 27)
        Me.txtPNom.TabIndex = 143
        '
        'pnlSApe
        '
        Me.pnlSApe.BackColor = System.Drawing.Color.Black
        Me.pnlSApe.Location = New System.Drawing.Point(1000, 405)
        Me.pnlSApe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlSApe.Name = "pnlSApe"
        Me.pnlSApe.Size = New System.Drawing.Size(291, 2)
        Me.pnlSApe.TabIndex = 135
        '
        'pnlPApe
        '
        Me.pnlPApe.BackColor = System.Drawing.Color.Black
        Me.pnlPApe.Location = New System.Drawing.Point(672, 407)
        Me.pnlPApe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlPApe.Name = "pnlPApe"
        Me.pnlPApe.Size = New System.Drawing.Size(291, 2)
        Me.pnlPApe.TabIndex = 134
        '
        'pnlSNom
        '
        Me.pnlSNom.BackColor = System.Drawing.Color.Black
        Me.pnlSNom.Location = New System.Drawing.Point(340, 407)
        Me.pnlSNom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlSNom.Name = "pnlSNom"
        Me.pnlSNom.Size = New System.Drawing.Size(291, 2)
        Me.pnlSNom.TabIndex = 133
        '
        'txtSApe
        '
        Me.txtSApe.BackColor = System.Drawing.Color.White
        Me.txtSApe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSApe.Location = New System.Drawing.Point(1000, 368)
        Me.txtSApe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSApe.Name = "txtSApe"
        Me.txtSApe.Size = New System.Drawing.Size(291, 27)
        Me.txtSApe.TabIndex = 146
        '
        'lblSApe
        '
        Me.lblSApe.AutoSize = True
        Me.lblSApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSApe.Location = New System.Drawing.Point(1043, 321)
        Me.lblSApe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSApe.Name = "lblSApe"
        Me.lblSApe.Size = New System.Drawing.Size(206, 29)
        Me.lblSApe.TabIndex = 132
        Me.lblSApe.Text = "Segundo Apellido"
        '
        'txtPApe
        '
        Me.txtPApe.BackColor = System.Drawing.Color.White
        Me.txtPApe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPApe.Location = New System.Drawing.Point(689, 370)
        Me.txtPApe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPApe.Name = "txtPApe"
        Me.txtPApe.Size = New System.Drawing.Size(291, 27)
        Me.txtPApe.TabIndex = 145
        '
        'lblPApe
        '
        Me.lblPApe.AutoSize = True
        Me.lblPApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPApe.Location = New System.Drawing.Point(729, 321)
        Me.lblPApe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPApe.Name = "lblPApe"
        Me.lblPApe.Size = New System.Drawing.Size(180, 29)
        Me.lblPApe.TabIndex = 131
        Me.lblPApe.Text = "Primer Apellido"
        '
        'txtSNom
        '
        Me.txtSNom.BackColor = System.Drawing.Color.White
        Me.txtSNom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSNom.Location = New System.Drawing.Point(352, 370)
        Me.txtSNom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSNom.Name = "txtSNom"
        Me.txtSNom.Size = New System.Drawing.Size(291, 27)
        Me.txtSNom.TabIndex = 144
        '
        'lblSegundoNombre
        '
        Me.lblSegundoNombre.AutoSize = True
        Me.lblSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoNombre.Location = New System.Drawing.Point(397, 321)
        Me.lblSegundoNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSegundoNombre.Name = "lblSegundoNombre"
        Me.lblSegundoNombre.Size = New System.Drawing.Size(205, 29)
        Me.lblSegundoNombre.TabIndex = 129
        Me.lblSegundoNombre.Text = "Segundo Nombre"
        '
        'lblPNom
        '
        Me.lblPNom.AutoSize = True
        Me.lblPNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNom.Location = New System.Drawing.Point(64, 321)
        Me.lblPNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPNom.Name = "lblPNom"
        Me.lblPNom.Size = New System.Drawing.Size(179, 29)
        Me.lblPNom.TabIndex = 126
        Me.lblPNom.Text = "Primer Nombre"
        '
        'mrbtnSolicitarCuenta
        '
        Me.mrbtnSolicitarCuenta.AutoSize = True
        Me.mrbtnSolicitarCuenta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mrbtnSolicitarCuenta.Depth = 0
        Me.mrbtnSolicitarCuenta.Icon = Nothing
        Me.mrbtnSolicitarCuenta.Location = New System.Drawing.Point(595, 686)
        Me.mrbtnSolicitarCuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mrbtnSolicitarCuenta.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnSolicitarCuenta.Name = "mrbtnSolicitarCuenta"
        Me.mrbtnSolicitarCuenta.Primary = True
        Me.mrbtnSolicitarCuenta.Size = New System.Drawing.Size(177, 36)
        Me.mrbtnSolicitarCuenta.TabIndex = 156
        Me.mrbtnSolicitarCuenta.Text = "solicitar cuenta"
        Me.mrbtnSolicitarCuenta.UseVisualStyleBackColor = True
        '
        'pnlDecFecNac
        '
        Me.pnlDecFecNac.BackColor = System.Drawing.Color.Black
        Me.pnlDecFecNac.Location = New System.Drawing.Point(936, 553)
        Me.pnlDecFecNac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlDecFecNac.Name = "pnlDecFecNac"
        Me.pnlDecFecNac.Size = New System.Drawing.Size(291, 2)
        Me.pnlDecFecNac.TabIndex = 154
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(1043, 586)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 29)
        Me.lbl1.TabIndex = 153
        '
        'lblFecNac
        '
        Me.lblFecNac.AutoSize = True
        Me.lblFecNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecNac.Location = New System.Drawing.Point(960, 454)
        Me.lblFecNac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecNac.Name = "lblFecNac"
        Me.lblFecNac.Size = New System.Drawing.Size(237, 29)
        Me.lblFecNac.TabIndex = 157
        Me.lblFecNac.Text = "Fecha de nacimiento"
        '
        'dgvTelefonos
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dgvTelefonos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTelefonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTelefonos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTelefonos.BackgroundColor = System.Drawing.Color.White
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
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTelefonos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTelefonos.Location = New System.Drawing.Point(16, 4)
        Me.dgvTelefonos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvTelefonos.MultiSelect = False
        Me.dgvTelefonos.Name = "dgvTelefonos"
        Me.dgvTelefonos.RowHeadersVisible = False
        Me.dgvTelefonos.RowHeadersWidth = 51
        Me.dgvTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTelefonos.Size = New System.Drawing.Size(259, 137)
        Me.dgvTelefonos.TabIndex = 159
        '
        'Telefonos
        '
        Me.Telefonos.HeaderText = "Telefonos"
        Me.Telefonos.MinimumWidth = 6
        Me.Telefonos.Name = "Telefonos"
        '
        'pnlAgregarTelefonos1
        '
        Me.pnlAgregarTelefonos1.BackColor = System.Drawing.SystemColors.Window
        Me.pnlAgregarTelefonos1.Controls.Add(Me.btnAgregar)
        Me.pnlAgregarTelefonos1.Controls.Add(Me.btnEliminar)
        Me.pnlAgregarTelefonos1.Controls.Add(Me.dgvTelefonos)
        Me.pnlAgregarTelefonos1.Location = New System.Drawing.Point(147, 572)
        Me.pnlAgregarTelefonos1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlAgregarTelefonos1.Name = "pnlAgregarTelefonos1"
        Me.pnlAgregarTelefonos1.Size = New System.Drawing.Size(400, 158)
        Me.pnlAgregarTelefonos1.TabIndex = 160
        Me.pnlAgregarTelefonos1.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.AutoSize = True
        Me.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAgregar.Depth = 0
        Me.btnAgregar.Icon = Nothing
        Me.btnAgregar.Location = New System.Drawing.Point(283, 76)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Primary = True
        Me.btnAgregar.Size = New System.Drawing.Size(98, 36)
        Me.btnAgregar.TabIndex = 162
        Me.btnAgregar.Text = "aceptar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEliminar.Depth = 0
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Icon = Nothing
        Me.btnEliminar.Location = New System.Drawing.Point(283, 25)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Primary = True
        Me.btnEliminar.Size = New System.Drawing.Size(100, 36)
        Me.btnEliminar.TabIndex = 161
        Me.btnEliminar.Text = "eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lblAgregarTelefonos
        '
        Me.lblAgregarTelefonos.AutoSize = True
        Me.lblAgregarTelefonos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAgregarTelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgregarTelefonos.Location = New System.Drawing.Point(240, 523)
        Me.lblAgregarTelefonos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAgregarTelefonos.Name = "lblAgregarTelefonos"
        Me.lblAgregarTelefonos.Size = New System.Drawing.Size(228, 31)
        Me.lblAgregarTelefonos.TabIndex = 161
        Me.lblAgregarTelefonos.Text = "Agregar teléfonos"
        '
        'txtFecNac
        '
        Me.txtFecNac.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFecNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecNac.Location = New System.Drawing.Point(1011, 513)
        Me.txtFecNac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFecNac.Mask = "0000-00-00"
        Me.txtFecNac.Name = "txtFecNac"
        Me.txtFecNac.Size = New System.Drawing.Size(173, 30)
        Me.txtFecNac.TabIndex = 147
        '
        'lblFormatoFecNac
        '
        Me.lblFormatoFecNac.AutoSize = True
        Me.lblFormatoFecNac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormatoFecNac.Location = New System.Drawing.Point(1000, 484)
        Me.lblFormatoFecNac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormatoFecNac.Name = "lblFormatoFecNac"
        Me.lblFormatoFecNac.Size = New System.Drawing.Size(112, 24)
        Me.lblFormatoFecNac.TabIndex = 163
        Me.lblFormatoFecNac.Text = "yyyy-mm-dd"
        '
        'frmRegistroPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1348, 778)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.lblCI)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.pnlCI)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.pnlPass)
        Me.Controls.Add(Me.lblRepPass)
        Me.Controls.Add(Me.txtRepPass)
        Me.Controls.Add(Me.pnlRepPass)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.pnlMail)
        Me.Controls.Add(Me.lblPNom)
        Me.Controls.Add(Me.txtPNom)
        Me.Controls.Add(Me.pnlPNom)
        Me.Controls.Add(Me.txtSNom)
        Me.Controls.Add(Me.pnlSNom)
        Me.Controls.Add(Me.lblPApe)
        Me.Controls.Add(Me.txtPApe)
        Me.Controls.Add(Me.pnlPApe)
        Me.Controls.Add(Me.lblSApe)
        Me.Controls.Add(Me.txtSApe)
        Me.Controls.Add(Me.pnlSApe)
        Me.Controls.Add(Me.lblTelefonos)
        Me.Controls.Add(Me.lblAgregarTelefonos)
        Me.Controls.Add(Me.pnlDecAgregarTelefonos)
        Me.Controls.Add(Me.pnlAgregarTelefonos1)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.cbM)
        Me.Controls.Add(Me.cbF)
        Me.Controls.Add(Me.lblFecNac)
        Me.Controls.Add(Me.lblFormatoFecNac)
        Me.Controls.Add(Me.txtFecNac)
        Me.Controls.Add(Me.pnlDecFecNac)
        Me.Controls.Add(Me.mrbtnSolicitarCuenta)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lblSegundoNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmRegistroPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRegistroPaciente"
        Me.pnlTitulo.ResumeLayout(False)
        CType(Me.dgvTelefonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAgregarTelefonos1.ResumeLayout(False)
        Me.pnlAgregarTelefonos1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSexo As Label
    Friend WithEvents cbF As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents cbM As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents pnlRepPass As Panel
    Friend WithEvents txtRepPass As TextBox
    Friend WithEvents pnlPass As Panel
    Friend WithEvents lblRepPass As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents pnlMail As Panel
    Friend WithEvents txtMail As TextBox
    Friend WithEvents lblMail As Label
    Friend WithEvents lblTelefonos As Label
    Friend WithEvents pnlCI As Panel
    Friend WithEvents txtCI As TextBox
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblMinimizar As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents lblCI As Label
    Friend WithEvents pnlPNom As Panel
    Friend WithEvents txtPNom As TextBox
    Friend WithEvents pnlSApe As Panel
    Friend WithEvents pnlPApe As Panel
    Friend WithEvents txtSApe As TextBox
    Friend WithEvents lblSApe As Label
    Friend WithEvents txtPApe As TextBox
    Friend WithEvents lblPApe As Label
    Friend WithEvents txtSNom As TextBox
    Friend WithEvents lblSegundoNombre As Label
    Friend WithEvents lblPNom As Label
    Friend WithEvents mrbtnSolicitarCuenta As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents pnlDecFecNac As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblFecNac As Label
    Friend WithEvents pnlDecAgregarTelefonos As Panel
    Friend WithEvents pnlSNom As Panel
    Friend WithEvents dgvTelefonos As DataGridView
    Friend WithEvents pnlAgregarTelefonos1 As Panel
    Friend WithEvents lblAgregarTelefonos As Label
    Friend WithEvents btnEliminar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Telefonos As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtFecNac As MaskedTextBox
    Friend WithEvents lblFormatoFecNac As Label
    Friend WithEvents btnAtras As Button
    Friend WithEvents lblSolicitarCuenta As Label
End Class
