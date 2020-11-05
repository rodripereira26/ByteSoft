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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblBienvenidoGestor = New System.Windows.Forms.Label()
        Me.pnlAjustes = New System.Windows.Forms.Panel()
        Me.pnlDecoracionAjustes = New System.Windows.Forms.Panel()
        Me.lblDescripcionAjustes = New System.Windows.Forms.Label()
        Me.lblAjustes = New System.Windows.Forms.Label()
        Me.pnlMiPerfil = New System.Windows.Forms.Panel()
        Me.pnlDecoracionMiPerfil = New System.Windows.Forms.Panel()
        Me.lblDescripcionMiPerfil = New System.Windows.Forms.Label()
        Me.lblMiPerfil = New System.Windows.Forms.Label()
        Me.pnlAyuda = New System.Windows.Forms.Panel()
        Me.pnlDecoracionAyuda = New System.Windows.Forms.Panel()
        Me.lblDescripcionAyuda = New System.Windows.Forms.Label()
        Me.lblAyuda = New System.Windows.Forms.Label()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.pnlRegistroDeUsuarios = New System.Windows.Forms.Panel()
        Me.pnlDecoracionRegistroDeUsuarios = New System.Windows.Forms.Panel()
        Me.lblDescripcionRegistroDeUsuarios = New System.Windows.Forms.Label()
        Me.lblRegistroDeUsuarios = New System.Windows.Forms.Label()
        Me.pnlPatologias = New System.Windows.Forms.Panel()
        Me.pnlDecoracionPatologias = New System.Windows.Forms.Panel()
        Me.lblDescripcionPatologias = New System.Windows.Forms.Label()
        Me.lblPatologias = New System.Windows.Forms.Label()
        Me.pnlDecoracionSintomas = New System.Windows.Forms.Panel()
        Me.pnlSintomas = New System.Windows.Forms.Panel()
        Me.lblDescripcionSintomas = New System.Windows.Forms.Label()
        Me.lblSintomas = New System.Windows.Forms.Label()
        Me.pnlUsuarios = New System.Windows.Forms.Panel()
        Me.pnlDecoracionUsuarios = New System.Windows.Forms.Panel()
        Me.lblDescripcionUsuarios = New System.Windows.Forms.Label()
        Me.lblUsuarios = New System.Windows.Forms.Label()
        Me.pnlListadoPacientes = New System.Windows.Forms.Panel()
        Me.btnRefrescarListadoPac = New System.Windows.Forms.Button()
        Me.lblTituloLIstadoPacientes = New System.Windows.Forms.Label()
        Me.dgvListadoPacientes = New System.Windows.Forms.DataGridView()
        Me.Rechazar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Aceptar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tempListaPacientes = New System.Windows.Forms.Timer(Me.components)
        Me.btnNotificacion = New System.Windows.Forms.Button()
        Me.pnlAjustes.SuspendLayout()
        Me.pnlMiPerfil.SuspendLayout()
        Me.pnlAyuda.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlRegistroDeUsuarios.SuspendLayout()
        Me.pnlPatologias.SuspendLayout()
        Me.pnlSintomas.SuspendLayout()
        Me.pnlUsuarios.SuspendLayout()
        Me.pnlListadoPacientes.SuspendLayout()
        CType(Me.dgvListadoPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBienvenidoGestor
        '
        Me.lblBienvenidoGestor.AutoSize = True
        Me.lblBienvenidoGestor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBienvenidoGestor.ForeColor = System.Drawing.Color.White
        Me.lblBienvenidoGestor.Location = New System.Drawing.Point(69, 38)
        Me.lblBienvenidoGestor.Name = "lblBienvenidoGestor"
        Me.lblBienvenidoGestor.Size = New System.Drawing.Size(224, 29)
        Me.lblBienvenidoGestor.TabIndex = 4
        Me.lblBienvenidoGestor.Text = "Bienvenido, Gestor "
        '
        'pnlAjustes
        '
        Me.pnlAjustes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlAjustes.Controls.Add(Me.pnlDecoracionAjustes)
        Me.pnlAjustes.Controls.Add(Me.lblDescripcionAjustes)
        Me.pnlAjustes.Controls.Add(Me.lblAjustes)
        Me.pnlAjustes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAjustes.Location = New System.Drawing.Point(31, 320)
        Me.pnlAjustes.Name = "pnlAjustes"
        Me.pnlAjustes.Size = New System.Drawing.Size(225, 193)
        Me.pnlAjustes.TabIndex = 3
        '
        'pnlDecoracionAjustes
        '
        Me.pnlDecoracionAjustes.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.pnlDecoracionAjustes.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecoracionAjustes.Name = "pnlDecoracionAjustes"
        Me.pnlDecoracionAjustes.Size = New System.Drawing.Size(226, 10)
        Me.pnlDecoracionAjustes.TabIndex = 5
        '
        'lblDescripcionAjustes
        '
        Me.lblDescripcionAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescripcionAjustes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionAjustes.ForeColor = System.Drawing.Color.White
        Me.lblDescripcionAjustes.Location = New System.Drawing.Point(25, 91)
        Me.lblDescripcionAjustes.Name = "lblDescripcionAjustes"
        Me.lblDescripcionAjustes.Size = New System.Drawing.Size(178, 76)
        Me.lblDescripcionAjustes.TabIndex = 1
        Me.lblDescripcionAjustes.Text = "Entrar a la configuración de la aplicación"
        '
        'lblAjustes
        '
        Me.lblAjustes.AutoSize = True
        Me.lblAjustes.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjustes.ForeColor = System.Drawing.Color.White
        Me.lblAjustes.Location = New System.Drawing.Point(22, 33)
        Me.lblAjustes.Name = "lblAjustes"
        Me.lblAjustes.Size = New System.Drawing.Size(122, 37)
        Me.lblAjustes.TabIndex = 0
        Me.lblAjustes.Text = "Ajustes"
        '
        'pnlMiPerfil
        '
        Me.pnlMiPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlMiPerfil.Controls.Add(Me.pnlDecoracionMiPerfil)
        Me.pnlMiPerfil.Controls.Add(Me.lblDescripcionMiPerfil)
        Me.pnlMiPerfil.Controls.Add(Me.lblMiPerfil)
        Me.pnlMiPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlMiPerfil.Location = New System.Drawing.Point(595, 320)
        Me.pnlMiPerfil.Name = "pnlMiPerfil"
        Me.pnlMiPerfil.Size = New System.Drawing.Size(175, 193)
        Me.pnlMiPerfil.TabIndex = 4
        '
        'pnlDecoracionMiPerfil
        '
        Me.pnlDecoracionMiPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.pnlDecoracionMiPerfil.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecoracionMiPerfil.Name = "pnlDecoracionMiPerfil"
        Me.pnlDecoracionMiPerfil.Size = New System.Drawing.Size(175, 10)
        Me.pnlDecoracionMiPerfil.TabIndex = 6
        '
        'lblDescripcionMiPerfil
        '
        Me.lblDescripcionMiPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescripcionMiPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionMiPerfil.ForeColor = System.Drawing.Color.White
        Me.lblDescripcionMiPerfil.Location = New System.Drawing.Point(20, 91)
        Me.lblDescripcionMiPerfil.Name = "lblDescripcionMiPerfil"
        Me.lblDescripcionMiPerfil.Size = New System.Drawing.Size(141, 57)
        Me.lblDescripcionMiPerfil.TabIndex = 1
        Me.lblDescripcionMiPerfil.Text = "Ver y configurar Perfil"
        '
        'lblMiPerfil
        '
        Me.lblMiPerfil.AutoSize = True
        Me.lblMiPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiPerfil.ForeColor = System.Drawing.Color.White
        Me.lblMiPerfil.Location = New System.Drawing.Point(17, 33)
        Me.lblMiPerfil.Name = "lblMiPerfil"
        Me.lblMiPerfil.Size = New System.Drawing.Size(131, 37)
        Me.lblMiPerfil.TabIndex = 0
        Me.lblMiPerfil.Text = "Mi Perfil"
        '
        'pnlAyuda
        '
        Me.pnlAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlAyuda.Controls.Add(Me.pnlDecoracionAyuda)
        Me.pnlAyuda.Controls.Add(Me.lblDescripcionAyuda)
        Me.pnlAyuda.Controls.Add(Me.lblAyuda)
        Me.pnlAyuda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlAyuda.Location = New System.Drawing.Point(783, 320)
        Me.pnlAyuda.Name = "pnlAyuda"
        Me.pnlAyuda.Size = New System.Drawing.Size(162, 193)
        Me.pnlAyuda.TabIndex = 5
        '
        'pnlDecoracionAyuda
        '
        Me.pnlDecoracionAyuda.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.pnlDecoracionAyuda.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecoracionAyuda.Name = "pnlDecoracionAyuda"
        Me.pnlDecoracionAyuda.Size = New System.Drawing.Size(162, 10)
        Me.pnlDecoracionAyuda.TabIndex = 3
        '
        'lblDescripcionAyuda
        '
        Me.lblDescripcionAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescripcionAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionAyuda.ForeColor = System.Drawing.Color.White
        Me.lblDescripcionAyuda.Location = New System.Drawing.Point(14, 83)
        Me.lblDescripcionAyuda.Name = "lblDescripcionAyuda"
        Me.lblDescripcionAyuda.Size = New System.Drawing.Size(137, 72)
        Me.lblDescripcionAyuda.TabIndex = 1
        Me.lblDescripcionAyuda.Text = "Cómo usar la aplicación de Gestión"
        '
        'lblAyuda
        '
        Me.lblAyuda.AutoSize = True
        Me.lblAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyuda.ForeColor = System.Drawing.Color.White
        Me.lblAyuda.Location = New System.Drawing.Point(11, 27)
        Me.lblAyuda.Name = "lblAyuda"
        Me.lblAyuda.Size = New System.Drawing.Size(108, 37)
        Me.lblAyuda.TabIndex = 0
        Me.lblAyuda.Text = "Ayuda"
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.lblBienvenidoGestor)
        Me.pnlTopBar.Controls.Add(Me.btn1)
        Me.pnlTopBar.Controls.Add(Me.btn2)
        Me.pnlTopBar.Location = New System.Drawing.Point(12, 3)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(743, 80)
        Me.pnlTopBar.TabIndex = 6
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(583, 12)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(70, 55)
        Me.btn1.TabIndex = 24
        Me.btn1.Text = "Button2"
        Me.btn1.UseVisualStyleBackColor = True
        Me.btn1.Visible = False
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(658, 12)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(70, 55)
        Me.btn2.TabIndex = 23
        Me.btn2.Text = "Button1"
        Me.btn2.UseVisualStyleBackColor = True
        Me.btn2.Visible = False
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.White
        Me.lblMinimizar.Location = New System.Drawing.Point(907, -3)
        Me.lblMinimizar.Name = "lblMinimizar"
        Me.lblMinimizar.Size = New System.Drawing.Size(24, 35)
        Me.lblMinimizar.TabIndex = 22
        Me.lblMinimizar.Text = "_"
        Me.lblMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCerrar
        '
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(937, 3)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(43, 35)
        Me.lblCerrar.TabIndex = 21
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlRegistroDeUsuarios
        '
        Me.pnlRegistroDeUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlRegistroDeUsuarios.Controls.Add(Me.pnlDecoracionRegistroDeUsuarios)
        Me.pnlRegistroDeUsuarios.Controls.Add(Me.lblDescripcionRegistroDeUsuarios)
        Me.pnlRegistroDeUsuarios.Controls.Add(Me.lblRegistroDeUsuarios)
        Me.pnlRegistroDeUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlRegistroDeUsuarios.Location = New System.Drawing.Point(595, 120)
        Me.pnlRegistroDeUsuarios.Name = "pnlRegistroDeUsuarios"
        Me.pnlRegistroDeUsuarios.Size = New System.Drawing.Size(349, 180)
        Me.pnlRegistroDeUsuarios.TabIndex = 6
        '
        'pnlDecoracionRegistroDeUsuarios
        '
        Me.pnlDecoracionRegistroDeUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlDecoracionRegistroDeUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecoracionRegistroDeUsuarios.Name = "pnlDecoracionRegistroDeUsuarios"
        Me.pnlDecoracionRegistroDeUsuarios.Size = New System.Drawing.Size(350, 10)
        Me.pnlDecoracionRegistroDeUsuarios.TabIndex = 4
        '
        'lblDescripcionRegistroDeUsuarios
        '
        Me.lblDescripcionRegistroDeUsuarios.AutoSize = True
        Me.lblDescripcionRegistroDeUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionRegistroDeUsuarios.ForeColor = System.Drawing.Color.White
        Me.lblDescripcionRegistroDeUsuarios.Location = New System.Drawing.Point(13, 27)
        Me.lblDescripcionRegistroDeUsuarios.Name = "lblDescripcionRegistroDeUsuarios"
        Me.lblDescripcionRegistroDeUsuarios.Size = New System.Drawing.Size(315, 37)
        Me.lblDescripcionRegistroDeUsuarios.TabIndex = 8
        Me.lblDescripcionRegistroDeUsuarios.Text = "Registro de Usuarios"
        '
        'lblRegistroDeUsuarios
        '
        Me.lblRegistroDeUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRegistroDeUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroDeUsuarios.ForeColor = System.Drawing.Color.White
        Me.lblRegistroDeUsuarios.Location = New System.Drawing.Point(20, 81)
        Me.lblRegistroDeUsuarios.Name = "lblRegistroDeUsuarios"
        Me.lblRegistroDeUsuarios.Size = New System.Drawing.Size(247, 57)
        Me.lblRegistroDeUsuarios.TabIndex = 1
        Me.lblRegistroDeUsuarios.Text = "Registrar médicos y gestores en la aplicación"
        '
        'pnlPatologias
        '
        Me.pnlPatologias.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlPatologias.Controls.Add(Me.pnlDecoracionPatologias)
        Me.pnlPatologias.Controls.Add(Me.lblDescripcionPatologias)
        Me.pnlPatologias.Controls.Add(Me.lblPatologias)
        Me.pnlPatologias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlPatologias.Location = New System.Drawing.Point(31, 120)
        Me.pnlPatologias.Name = "pnlPatologias"
        Me.pnlPatologias.Size = New System.Drawing.Size(255, 180)
        Me.pnlPatologias.TabIndex = 3
        '
        'pnlDecoracionPatologias
        '
        Me.pnlDecoracionPatologias.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.pnlDecoracionPatologias.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecoracionPatologias.Name = "pnlDecoracionPatologias"
        Me.pnlDecoracionPatologias.Size = New System.Drawing.Size(253, 10)
        Me.pnlDecoracionPatologias.TabIndex = 4
        '
        'lblDescripcionPatologias
        '
        Me.lblDescripcionPatologias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescripcionPatologias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionPatologias.ForeColor = System.Drawing.Color.White
        Me.lblDescripcionPatologias.Location = New System.Drawing.Point(30, 81)
        Me.lblDescripcionPatologias.Name = "lblDescripcionPatologias"
        Me.lblDescripcionPatologias.Size = New System.Drawing.Size(196, 74)
        Me.lblDescripcionPatologias.TabIndex = 8
        Me.lblDescripcionPatologias.Text = "Registrar, modificar, eliminar y  buscar patologías"
        '
        'lblPatologias
        '
        Me.lblPatologias.AutoSize = True
        Me.lblPatologias.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatologias.ForeColor = System.Drawing.Color.White
        Me.lblPatologias.Location = New System.Drawing.Point(23, 27)
        Me.lblPatologias.Name = "lblPatologias"
        Me.lblPatologias.Size = New System.Drawing.Size(167, 37)
        Me.lblPatologias.TabIndex = 0
        Me.lblPatologias.Text = "Patologías"
        '
        'pnlDecoracionSintomas
        '
        Me.pnlDecoracionSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.pnlDecoracionSintomas.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecoracionSintomas.Name = "pnlDecoracionSintomas"
        Me.pnlDecoracionSintomas.Size = New System.Drawing.Size(274, 10)
        Me.pnlDecoracionSintomas.TabIndex = 7
        '
        'pnlSintomas
        '
        Me.pnlSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlSintomas.Controls.Add(Me.pnlDecoracionSintomas)
        Me.pnlSintomas.Controls.Add(Me.lblDescripcionSintomas)
        Me.pnlSintomas.Controls.Add(Me.lblSintomas)
        Me.pnlSintomas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlSintomas.Location = New System.Drawing.Point(304, 120)
        Me.pnlSintomas.Name = "pnlSintomas"
        Me.pnlSintomas.Size = New System.Drawing.Size(273, 180)
        Me.pnlSintomas.TabIndex = 8
        '
        'lblDescripcionSintomas
        '
        Me.lblDescripcionSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescripcionSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionSintomas.ForeColor = System.Drawing.Color.White
        Me.lblDescripcionSintomas.Location = New System.Drawing.Point(26, 81)
        Me.lblDescripcionSintomas.Name = "lblDescripcionSintomas"
        Me.lblDescripcionSintomas.Size = New System.Drawing.Size(196, 74)
        Me.lblDescripcionSintomas.TabIndex = 9
        Me.lblDescripcionSintomas.Text = "Registrar, modificar, eliminar y  buscar síntomas"
        '
        'lblSintomas
        '
        Me.lblSintomas.AutoSize = True
        Me.lblSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintomas.ForeColor = System.Drawing.Color.White
        Me.lblSintomas.Location = New System.Drawing.Point(23, 27)
        Me.lblSintomas.Name = "lblSintomas"
        Me.lblSintomas.Size = New System.Drawing.Size(151, 37)
        Me.lblSintomas.TabIndex = 0
        Me.lblSintomas.Text = "Sintomas"
        '
        'pnlUsuarios
        '
        Me.pnlUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlUsuarios.Controls.Add(Me.pnlDecoracionUsuarios)
        Me.pnlUsuarios.Controls.Add(Me.lblDescripcionUsuarios)
        Me.pnlUsuarios.Controls.Add(Me.lblUsuarios)
        Me.pnlUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlUsuarios.Location = New System.Drawing.Point(275, 320)
        Me.pnlUsuarios.Name = "pnlUsuarios"
        Me.pnlUsuarios.Size = New System.Drawing.Size(302, 193)
        Me.pnlUsuarios.TabIndex = 6
        '
        'pnlDecoracionUsuarios
        '
        Me.pnlDecoracionUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.pnlDecoracionUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecoracionUsuarios.Name = "pnlDecoracionUsuarios"
        Me.pnlDecoracionUsuarios.Size = New System.Drawing.Size(301, 10)
        Me.pnlDecoracionUsuarios.TabIndex = 5
        '
        'lblDescripcionUsuarios
        '
        Me.lblDescripcionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDescripcionUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionUsuarios.ForeColor = System.Drawing.Color.White
        Me.lblDescripcionUsuarios.Location = New System.Drawing.Point(25, 90)
        Me.lblDescripcionUsuarios.Name = "lblDescripcionUsuarios"
        Me.lblDescripcionUsuarios.Size = New System.Drawing.Size(253, 77)
        Me.lblDescripcionUsuarios.TabIndex = 1
        Me.lblDescripcionUsuarios.Text = "Buscar, modificar o eliminar usuarios registrados en la aplicación"
        '
        'lblUsuarios
        '
        Me.lblUsuarios.AutoSize = True
        Me.lblUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarios.ForeColor = System.Drawing.Color.White
        Me.lblUsuarios.Location = New System.Drawing.Point(22, 33)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(144, 37)
        Me.lblUsuarios.TabIndex = 0
        Me.lblUsuarios.Text = "Usuarios"
        '
        'pnlListadoPacientes
        '
        Me.pnlListadoPacientes.Controls.Add(Me.btnRefrescarListadoPac)
        Me.pnlListadoPacientes.Controls.Add(Me.lblTituloLIstadoPacientes)
        Me.pnlListadoPacientes.Controls.Add(Me.dgvListadoPacientes)
        Me.pnlListadoPacientes.Location = New System.Drawing.Point(701, 62)
        Me.pnlListadoPacientes.Name = "pnlListadoPacientes"
        Me.pnlListadoPacientes.Size = New System.Drawing.Size(260, 451)
        Me.pnlListadoPacientes.TabIndex = 24
        Me.pnlListadoPacientes.Visible = False
        '
        'btnRefrescarListadoPac
        '
        Me.btnRefrescarListadoPac.FlatAppearance.BorderSize = 0
        Me.btnRefrescarListadoPac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescarListadoPac.Image = Global.Vista.My.Resources.Resources.icons8_refresh_20px
        Me.btnRefrescarListadoPac.Location = New System.Drawing.Point(224, 3)
        Me.btnRefrescarListadoPac.Name = "btnRefrescarListadoPac"
        Me.btnRefrescarListadoPac.Size = New System.Drawing.Size(28, 30)
        Me.btnRefrescarListadoPac.TabIndex = 25
        Me.btnRefrescarListadoPac.UseVisualStyleBackColor = True
        '
        'lblTituloLIstadoPacientes
        '
        Me.lblTituloLIstadoPacientes.AutoSize = True
        Me.lblTituloLIstadoPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloLIstadoPacientes.ForeColor = System.Drawing.Color.White
        Me.lblTituloLIstadoPacientes.Location = New System.Drawing.Point(63, 8)
        Me.lblTituloLIstadoPacientes.Name = "lblTituloLIstadoPacientes"
        Me.lblTituloLIstadoPacientes.Size = New System.Drawing.Size(128, 18)
        Me.lblTituloLIstadoPacientes.TabIndex = 147
        Me.lblTituloLIstadoPacientes.Text = "Habilitar pacientes"
        '
        'dgvListadoPacientes
        '
        Me.dgvListadoPacientes.AllowUserToAddRows = False
        Me.dgvListadoPacientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListadoPacientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListadoPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoPacientes.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListadoPacientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvListadoPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4, 20, 4, 20)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPacientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoPacientes.ColumnHeadersVisible = False
        Me.dgvListadoPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Rechazar, Me.Aceptar})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(5, 10, 5, 10)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPacientes.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListadoPacientes.EnableHeadersVisualStyles = False
        Me.dgvListadoPacientes.Location = New System.Drawing.Point(0, 39)
        Me.dgvListadoPacientes.MultiSelect = False
        Me.dgvListadoPacientes.Name = "dgvListadoPacientes"
        Me.dgvListadoPacientes.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoPacientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListadoPacientes.RowHeadersVisible = False
        Me.dgvListadoPacientes.RowHeadersWidth = 51
        Me.dgvListadoPacientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListadoPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoPacientes.Size = New System.Drawing.Size(257, 409)
        Me.dgvListadoPacientes.TabIndex = 146
        '
        'Rechazar
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Green
        Me.Rechazar.DefaultCellStyle = DataGridViewCellStyle3
        Me.Rechazar.HeaderText = "Rechazar"
        Me.Rechazar.MinimumWidth = 6
        Me.Rechazar.Name = "Rechazar"
        Me.Rechazar.ReadOnly = True
        Me.Rechazar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Rechazar.Text = "rechazar"
        '
        'Aceptar
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        Me.Aceptar.DefaultCellStyle = DataGridViewCellStyle4
        Me.Aceptar.HeaderText = "Aceptar"
        Me.Aceptar.MinimumWidth = 6
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.ReadOnly = True
        Me.Aceptar.Text = "aceptar"
        '
        'tempListaPacientes
        '
        Me.tempListaPacientes.Enabled = True
        Me.tempListaPacientes.Interval = 6000
        '
        'btnNotificacion
        '
        Me.btnNotificacion.FlatAppearance.BorderSize = 0
        Me.btnNotificacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNotificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotificacion.Image = Global.Vista.My.Resources.Resources.icons8_bell_35px
        Me.btnNotificacion.Location = New System.Drawing.Point(838, 3)
        Me.btnNotificacion.Name = "btnNotificacion"
        Me.btnNotificacion.Size = New System.Drawing.Size(43, 44)
        Me.btnNotificacion.TabIndex = 23
        Me.btnNotificacion.UseVisualStyleBackColor = True
        '
        'frmBienvenidaGestor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(981, 551)
        Me.Controls.Add(Me.pnlListadoPacientes)
        Me.Controls.Add(Me.btnNotificacion)
        Me.Controls.Add(Me.pnlUsuarios)
        Me.Controls.Add(Me.pnlSintomas)
        Me.Controls.Add(Me.pnlPatologias)
        Me.Controls.Add(Me.pnlRegistroDeUsuarios)
        Me.Controls.Add(Me.lblMinimizar)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.pnlAyuda)
        Me.Controls.Add(Me.pnlMiPerfil)
        Me.Controls.Add(Me.pnlAjustes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBienvenidaGestor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.pnlAjustes.ResumeLayout(False)
        Me.pnlAjustes.PerformLayout()
        Me.pnlMiPerfil.ResumeLayout(False)
        Me.pnlMiPerfil.PerformLayout()
        Me.pnlAyuda.ResumeLayout(False)
        Me.pnlAyuda.PerformLayout()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.pnlRegistroDeUsuarios.ResumeLayout(False)
        Me.pnlRegistroDeUsuarios.PerformLayout()
        Me.pnlPatologias.ResumeLayout(False)
        Me.pnlPatologias.PerformLayout()
        Me.pnlSintomas.ResumeLayout(False)
        Me.pnlSintomas.PerformLayout()
        Me.pnlUsuarios.ResumeLayout(False)
        Me.pnlUsuarios.PerformLayout()
        Me.pnlListadoPacientes.ResumeLayout(False)
        Me.pnlListadoPacientes.PerformLayout()
        CType(Me.dgvListadoPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBienvenidoGestor As Label
    Friend WithEvents pnlAjustes As Panel
    Friend WithEvents lblDescripcionAjustes As Label
    Friend WithEvents lblAjustes As Label
    Friend WithEvents pnlMiPerfil As Panel
    Friend WithEvents lblMiPerfil As Label
    Friend WithEvents pnlAyuda As Panel
    Friend WithEvents lblDescripcionAyuda As Label
    Friend WithEvents lblAyuda As Label
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents lblMinimizar As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents pnlDecoracionAyuda As Panel
    Friend WithEvents pnlDecoracionMiPerfil As Panel
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents lblDescripcionMiPerfil As Label
    Friend WithEvents pnlDecoracionAjustes As Panel
    Friend WithEvents pnlRegistroDeUsuarios As Panel
    Friend WithEvents lblRegistroDeUsuarios As Label
    Friend WithEvents pnlDecoracionRegistroDeUsuarios As Panel
    Friend WithEvents pnlPatologias As Panel
    Friend WithEvents pnlDecoracionPatologias As Panel
    Friend WithEvents lblPatologias As Label
    Friend WithEvents pnlDecoracionSintomas As Panel
    Friend WithEvents pnlSintomas As Panel
    Friend WithEvents lblSintomas As Label
    Friend WithEvents pnlUsuarios As Panel
    Friend WithEvents pnlDecoracionUsuarios As Panel
    Friend WithEvents lblDescripcionUsuarios As Label
    Friend WithEvents lblUsuarios As Label
    Friend WithEvents lblDescripcionRegistroDeUsuarios As Label
    Friend WithEvents lblDescripcionPatologias As Label
    Friend WithEvents lblDescripcionSintomas As Label
    Friend WithEvents btnNotificacion As Button
    Friend WithEvents pnlListadoPacientes As Panel
    Friend WithEvents lblTituloLIstadoPacientes As Label
    Friend WithEvents dgvListadoPacientes As DataGridView
    Friend WithEvents btnRefrescarListadoPac As Button
    Friend WithEvents tempListaPacientes As Timer
    Friend WithEvents Rechazar As DataGridViewButtonColumn
    Friend WithEvents Aceptar As DataGridViewButtonColumn
End Class

