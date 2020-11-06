<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistrarPatologia

    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components__1 IsNot Nothing Then
                components__1.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components__1 As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistrarPatologia))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.transicion = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlPatologia = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.lblNomPat = New System.Windows.Forms.Label()
        Me.btnRegPatologia = New Guna.UI.WinForms.GunaButton()
        Me.txtNomPat = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblCantRec = New System.Windows.Forms.Label()
        Me.lblDescPatologia = New System.Windows.Forms.Label()
        Me.btnSintomasPatologia = New Guna.UI.WinForms.GunaButton()
        Me.txtDescPat = New Guna.UI.WinForms.GunaTextBox()
        Me.lblPrioPatologia = New System.Windows.Forms.Label()
        Me.sepDesc = New Guna.UI.WinForms.GunaSeparator()
        Me.mrbPMedia = New Guna.UI.WinForms.GunaRadioButton()
        Me.lblCantDesc = New System.Windows.Forms.Label()
        Me.mrbPBaja = New Guna.UI.WinForms.GunaRadioButton()
        Me.lblRecomendacionesPatologia = New System.Windows.Forms.Label()
        Me.mrbPAlta = New Guna.UI.WinForms.GunaRadioButton()
        Me.txtRecPat = New Guna.UI.WinForms.GunaTextBox()
        Me.sepRec = New Guna.UI.WinForms.GunaSeparator()
        Me.pnlSintomas = New System.Windows.Forms.Panel()
        Me.btnVolver = New FontAwesome.Sharp.IconButton()
        Me.scroll2 = New Guna.UI.WinForms.GunaVScrollBar()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        Me.dgvTodosLosSintomas = New System.Windows.Forms.DataGridView()
        Me.dgvColSintomas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSintomasSeleccionados = New System.Windows.Forms.DataGridView()
        Me.dgvColSintomasSel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTodosLosSintomas = New System.Windows.Forms.Label()
        Me.lblSintomasSeleccionados = New System.Windows.Forms.Label()
        Me.pnlContenedor.SuspendLayout()
        Me.pnlPatologia.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlSintomas.SuspendLayout()
        CType(Me.dgvTodosLosSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.transicion.Interval = 7
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.pnlPatologia)
        Me.pnlContenedor.Controls.Add(Me.pnlSintomas)
        Me.transicion.SetDecoration(Me.pnlContenedor, Guna.UI.Animation.DecorationType.None)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 133
        '
        'pnlPatologia
        '
        Me.pnlPatologia.Controls.Add(Me.Panel1)
        Me.transicion.SetDecoration(Me.pnlPatologia, Guna.UI.Animation.DecorationType.None)
        Me.pnlPatologia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlPatologia.Name = "pnlPatologia"
        Me.pnlPatologia.Size = New System.Drawing.Size(1070, 650)
        Me.pnlPatologia.TabIndex = 176
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.IconButton1)
        Me.Panel1.Controls.Add(Me.lblNomPat)
        Me.Panel1.Controls.Add(Me.btnRegPatologia)
        Me.Panel1.Controls.Add(Me.txtNomPat)
        Me.Panel1.Controls.Add(Me.lblCantRec)
        Me.Panel1.Controls.Add(Me.lblDescPatologia)
        Me.Panel1.Controls.Add(Me.btnSintomasPatologia)
        Me.Panel1.Controls.Add(Me.txtDescPat)
        Me.Panel1.Controls.Add(Me.lblPrioPatologia)
        Me.Panel1.Controls.Add(Me.sepDesc)
        Me.Panel1.Controls.Add(Me.mrbPMedia)
        Me.Panel1.Controls.Add(Me.lblCantDesc)
        Me.Panel1.Controls.Add(Me.mrbPBaja)
        Me.Panel1.Controls.Add(Me.lblRecomendacionesPatologia)
        Me.Panel1.Controls.Add(Me.mrbPAlta)
        Me.Panel1.Controls.Add(Me.txtRecPat)
        Me.Panel1.Controls.Add(Me.sepRec)
        Me.transicion.SetDecoration(Me.Panel1, Guna.UI.Animation.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1070, 650)
        Me.Panel1.TabIndex = 198
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.transicion.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 197
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
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
        Me.IconButton1.Size = New System.Drawing.Size(117, 37)
        Me.IconButton1.TabIndex = 9
        Me.IconButton1.Text = "Atrás"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'lblNomPat
        '
        Me.lblNomPat.AutoSize = True
        Me.transicion.SetDecoration(Me.lblNomPat, Guna.UI.Animation.DecorationType.None)
        Me.lblNomPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNomPat.Location = New System.Drawing.Point(204, 37)
        Me.lblNomPat.Name = "lblNomPat"
        Me.lblNomPat.Size = New System.Drawing.Size(212, 25)
        Me.lblNomPat.TabIndex = 181
        Me.lblNomPat.Text = "Nombre de la patología"
        '
        'btnRegPatologia
        '
        Me.btnRegPatologia.Animated = True
        Me.btnRegPatologia.AnimationHoverSpeed = 0.07!
        Me.btnRegPatologia.AnimationSpeed = 0.03!
        Me.btnRegPatologia.BackColor = System.Drawing.Color.Transparent
        Me.btnRegPatologia.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnRegPatologia.BorderColor = System.Drawing.Color.Black
        Me.transicion.SetDecoration(Me.btnRegPatologia, Guna.UI.Animation.DecorationType.None)
        Me.btnRegPatologia.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegPatologia.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegPatologia.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegPatologia.ForeColor = System.Drawing.Color.White
        Me.btnRegPatologia.Image = Nothing
        Me.btnRegPatologia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnRegPatologia.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegPatologia.Location = New System.Drawing.Point(253, 586)
        Me.btnRegPatologia.Name = "btnRegPatologia"
        Me.btnRegPatologia.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnRegPatologia.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegPatologia.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegPatologia.OnHoverImage = Nothing
        Me.btnRegPatologia.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegPatologia.Radius = 10
        Me.btnRegPatologia.Size = New System.Drawing.Size(243, 42)
        Me.btnRegPatologia.TabIndex = 8
        Me.btnRegPatologia.Text = "Registrar"
        Me.btnRegPatologia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNomPat
        '
        Me.txtNomPat.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNomPat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtNomPat, Guna.UI.Animation.DecorationType.None)
        Me.txtNomPat.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNomPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNomPat.LineColor = System.Drawing.Color.Gainsboro
        Me.txtNomPat.LineSize = 1
        Me.txtNomPat.Location = New System.Drawing.Point(204, 83)
        Me.txtNomPat.MaxLength = 25
        Me.txtNomPat.Name = "txtNomPat"
        Me.txtNomPat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNomPat.Size = New System.Drawing.Size(317, 42)
        Me.txtNomPat.TabIndex = 1
        '
        'lblCantRec
        '
        Me.lblCantRec.AutoSize = True
        Me.transicion.SetDecoration(Me.lblCantRec, Guna.UI.Animation.DecorationType.None)
        Me.lblCantRec.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantRec.ForeColor = System.Drawing.Color.Silver
        Me.lblCantRec.Location = New System.Drawing.Point(799, 377)
        Me.lblCantRec.Name = "lblCantRec"
        Me.lblCantRec.Size = New System.Drawing.Size(41, 17)
        Me.lblCantRec.TabIndex = 196
        Me.lblCantRec.Text = "0/300"
        '
        'lblDescPatologia
        '
        Me.lblDescPatologia.AutoSize = True
        Me.transicion.SetDecoration(Me.lblDescPatologia, Guna.UI.Animation.DecorationType.None)
        Me.lblDescPatologia.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPatologia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescPatologia.Location = New System.Drawing.Point(199, 165)
        Me.lblDescPatologia.Name = "lblDescPatologia"
        Me.lblDescPatologia.Size = New System.Drawing.Size(111, 25)
        Me.lblDescPatologia.TabIndex = 182
        Me.lblDescPatologia.Text = "Descripción"
        '
        'btnSintomasPatologia
        '
        Me.btnSintomasPatologia.Animated = True
        Me.btnSintomasPatologia.AnimationHoverSpeed = 0.07!
        Me.btnSintomasPatologia.AnimationSpeed = 0.03!
        Me.btnSintomasPatologia.BackColor = System.Drawing.Color.Transparent
        Me.btnSintomasPatologia.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnSintomasPatologia.BorderColor = System.Drawing.Color.Black
        Me.transicion.SetDecoration(Me.btnSintomasPatologia, Guna.UI.Animation.DecorationType.None)
        Me.btnSintomasPatologia.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSintomasPatologia.FocusedColor = System.Drawing.Color.Empty
        Me.btnSintomasPatologia.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSintomasPatologia.ForeColor = System.Drawing.Color.White
        Me.btnSintomasPatologia.Image = Nothing
        Me.btnSintomasPatologia.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSintomasPatologia.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSintomasPatologia.Location = New System.Drawing.Point(550, 586)
        Me.btnSintomasPatologia.Name = "btnSintomasPatologia"
        Me.btnSintomasPatologia.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnSintomasPatologia.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSintomasPatologia.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSintomasPatologia.OnHoverImage = Nothing
        Me.btnSintomasPatologia.OnPressedColor = System.Drawing.Color.Black
        Me.btnSintomasPatologia.Radius = 10
        Me.btnSintomasPatologia.Size = New System.Drawing.Size(243, 42)
        Me.btnSintomasPatologia.TabIndex = 7
        Me.btnSintomasPatologia.Text = "Añadir síntomas"
        Me.btnSintomasPatologia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDescPat
        '
        Me.txtDescPat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDescPat.BorderColor = System.Drawing.Color.Silver
        Me.txtDescPat.BorderSize = 0
        Me.txtDescPat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtDescPat, Guna.UI.Animation.DecorationType.None)
        Me.txtDescPat.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDescPat.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescPat.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescPat.Location = New System.Drawing.Point(205, 211)
        Me.txtDescPat.MaxLength = 300
        Me.txtDescPat.MultiLine = True
        Me.txtDescPat.Name = "txtDescPat"
        Me.txtDescPat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescPat.Size = New System.Drawing.Size(654, 122)
        Me.txtDescPat.TabIndex = 5
        '
        'lblPrioPatologia
        '
        Me.lblPrioPatologia.AutoSize = True
        Me.transicion.SetDecoration(Me.lblPrioPatologia, Guna.UI.Animation.DecorationType.None)
        Me.lblPrioPatologia.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioPatologia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPrioPatologia.Location = New System.Drawing.Point(670, 37)
        Me.lblPrioPatologia.Name = "lblPrioPatologia"
        Me.lblPrioPatologia.Size = New System.Drawing.Size(90, 25)
        Me.lblPrioPatologia.TabIndex = 192
        Me.lblPrioPatologia.Text = "Prioridad"
        '
        'sepDesc
        '
        Me.transicion.SetDecoration(Me.sepDesc, Guna.UI.Animation.DecorationType.None)
        Me.sepDesc.LineColor = System.Drawing.Color.Gainsboro
        Me.sepDesc.Location = New System.Drawing.Point(205, 339)
        Me.sepDesc.Name = "sepDesc"
        Me.sepDesc.Size = New System.Drawing.Size(654, 10)
        Me.sepDesc.TabIndex = 184
        '
        'mrbPMedia
        '
        Me.mrbPMedia.BaseColor = System.Drawing.Color.Silver
        Me.mrbPMedia.CheckedOffColor = System.Drawing.Color.Gray
        Me.mrbPMedia.CheckedOnColor = System.Drawing.Color.MediumSlateBlue
        Me.transicion.SetDecoration(Me.mrbPMedia, Guna.UI.Animation.DecorationType.None)
        Me.mrbPMedia.FillColor = System.Drawing.Color.White
        Me.mrbPMedia.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mrbPMedia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mrbPMedia.Location = New System.Drawing.Point(667, 96)
        Me.mrbPMedia.Name = "mrbPMedia"
        Me.mrbPMedia.Size = New System.Drawing.Size(74, 24)
        Me.mrbPMedia.TabIndex = 3
        Me.mrbPMedia.Text = "Media"
        '
        'lblCantDesc
        '
        Me.lblCantDesc.AutoSize = True
        Me.transicion.SetDecoration(Me.lblCantDesc, Guna.UI.Animation.DecorationType.None)
        Me.lblCantDesc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantDesc.ForeColor = System.Drawing.Color.Silver
        Me.lblCantDesc.Location = New System.Drawing.Point(799, 165)
        Me.lblCantDesc.Name = "lblCantDesc"
        Me.lblCantDesc.Size = New System.Drawing.Size(41, 17)
        Me.lblCantDesc.TabIndex = 185
        Me.lblCantDesc.Text = "0/300"
        '
        'mrbPBaja
        '
        Me.mrbPBaja.BaseColor = System.Drawing.Color.Silver
        Me.mrbPBaja.CheckedOffColor = System.Drawing.Color.Gray
        Me.mrbPBaja.CheckedOnColor = System.Drawing.Color.MediumSlateBlue
        Me.transicion.SetDecoration(Me.mrbPBaja, Guna.UI.Animation.DecorationType.None)
        Me.mrbPBaja.FillColor = System.Drawing.Color.White
        Me.mrbPBaja.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mrbPBaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mrbPBaja.Location = New System.Drawing.Point(581, 95)
        Me.mrbPBaja.Name = "mrbPBaja"
        Me.mrbPBaja.Size = New System.Drawing.Size(59, 24)
        Me.mrbPBaja.TabIndex = 2
        Me.mrbPBaja.Text = "Baja"
        '
        'lblRecomendacionesPatologia
        '
        Me.lblRecomendacionesPatologia.AutoSize = True
        Me.transicion.SetDecoration(Me.lblRecomendacionesPatologia, Guna.UI.Animation.DecorationType.None)
        Me.lblRecomendacionesPatologia.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecomendacionesPatologia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblRecomendacionesPatologia.Location = New System.Drawing.Point(204, 388)
        Me.lblRecomendacionesPatologia.Name = "lblRecomendacionesPatologia"
        Me.lblRecomendacionesPatologia.Size = New System.Drawing.Size(164, 25)
        Me.lblRecomendacionesPatologia.TabIndex = 186
        Me.lblRecomendacionesPatologia.Text = "Recomendaciones"
        '
        'mrbPAlta
        '
        Me.mrbPAlta.BaseColor = System.Drawing.Color.Silver
        Me.mrbPAlta.CheckedOffColor = System.Drawing.Color.Gray
        Me.mrbPAlta.CheckedOnColor = System.Drawing.Color.MediumSlateBlue
        Me.transicion.SetDecoration(Me.mrbPAlta, Guna.UI.Animation.DecorationType.None)
        Me.mrbPAlta.FillColor = System.Drawing.Color.White
        Me.mrbPAlta.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mrbPAlta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.mrbPAlta.Location = New System.Drawing.Point(768, 96)
        Me.mrbPAlta.Name = "mrbPAlta"
        Me.mrbPAlta.Size = New System.Drawing.Size(58, 24)
        Me.mrbPAlta.TabIndex = 4
        Me.mrbPAlta.Text = "Alta"
        '
        'txtRecPat
        '
        Me.txtRecPat.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRecPat.BorderColor = System.Drawing.Color.Silver
        Me.txtRecPat.BorderSize = 0
        Me.txtRecPat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transicion.SetDecoration(Me.txtRecPat, Guna.UI.Animation.DecorationType.None)
        Me.txtRecPat.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRecPat.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRecPat.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRecPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtRecPat.Location = New System.Drawing.Point(204, 435)
        Me.txtRecPat.MaxLength = 300
        Me.txtRecPat.MultiLine = True
        Me.txtRecPat.Name = "txtRecPat"
        Me.txtRecPat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRecPat.Size = New System.Drawing.Size(667, 96)
        Me.txtRecPat.TabIndex = 6
        '
        'sepRec
        '
        Me.transicion.SetDecoration(Me.sepRec, Guna.UI.Animation.DecorationType.None)
        Me.sepRec.LineColor = System.Drawing.Color.Gainsboro
        Me.sepRec.Location = New System.Drawing.Point(204, 537)
        Me.sepRec.Name = "sepRec"
        Me.sepRec.Size = New System.Drawing.Size(655, 11)
        Me.sepRec.TabIndex = 188
        '
        'pnlSintomas
        '
        Me.pnlSintomas.Controls.Add(Me.btnVolver)
        Me.pnlSintomas.Controls.Add(Me.scroll2)
        Me.pnlSintomas.Controls.Add(Me.scroll)
        Me.pnlSintomas.Controls.Add(Me.dgvTodosLosSintomas)
        Me.pnlSintomas.Controls.Add(Me.dgvSintomasSeleccionados)
        Me.pnlSintomas.Controls.Add(Me.lblTodosLosSintomas)
        Me.pnlSintomas.Controls.Add(Me.lblSintomasSeleccionados)
        Me.transicion.SetDecoration(Me.pnlSintomas, Guna.UI.Animation.DecorationType.None)
        Me.pnlSintomas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlSintomas.Location = New System.Drawing.Point(0, 0)
        Me.pnlSintomas.Name = "pnlSintomas"
        Me.pnlSintomas.Size = New System.Drawing.Size(1070, 650)
        Me.pnlSintomas.TabIndex = 177
        '
        'btnVolver
        '
        Me.transicion.SetDecoration(Me.btnVolver, Guna.UI.Animation.DecorationType.None)
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.Silver
        Me.btnVolver.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnVolver.IconColor = System.Drawing.Color.Silver
        Me.btnVolver.IconSize = 20
        Me.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVolver.Location = New System.Drawing.Point(22, 22)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Rotation = 0R
        Me.btnVolver.Size = New System.Drawing.Size(117, 37)
        Me.btnVolver.TabIndex = 190
        Me.btnVolver.Text = "Atrás"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'scroll2
        '
        Me.transicion.SetDecoration(Me.scroll2, Guna.UI.Animation.DecorationType.None)
        Me.scroll2.LargeChange = 10
        Me.scroll2.Location = New System.Drawing.Point(611, 229)
        Me.scroll2.Maximum = 100
        Me.scroll2.Name = "scroll2"
        Me.scroll2.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll2.Size = New System.Drawing.Size(5, 200)
        Me.scroll2.TabIndex = 189
        Me.scroll2.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll2.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll2.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'scroll
        '
        Me.transicion.SetDecoration(Me.scroll, Guna.UI.Animation.DecorationType.None)
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(536, 229)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll.Size = New System.Drawing.Size(5, 200)
        Me.scroll.TabIndex = 188
        Me.scroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'dgvTodosLosSintomas
        '
        Me.dgvTodosLosSintomas.AllowDrop = True
        Me.dgvTodosLosSintomas.AllowUserToAddRows = False
        Me.dgvTodosLosSintomas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgvTodosLosSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTodosLosSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTodosLosSintomas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTodosLosSintomas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgvTodosLosSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTodosLosSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodosLosSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTodosLosSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodosLosSintomas.ColumnHeadersVisible = False
        Me.dgvTodosLosSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColSintomas})
        Me.transicion.SetDecoration(Me.dgvTodosLosSintomas, Guna.UI.Animation.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTodosLosSintomas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTodosLosSintomas.Location = New System.Drawing.Point(164, 150)
        Me.dgvTodosLosSintomas.MultiSelect = False
        Me.dgvTodosLosSintomas.Name = "dgvTodosLosSintomas"
        Me.dgvTodosLosSintomas.ReadOnly = True
        Me.dgvTodosLosSintomas.RowHeadersVisible = False
        Me.dgvTodosLosSintomas.RowHeadersWidth = 51
        Me.dgvTodosLosSintomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTodosLosSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTodosLosSintomas.Size = New System.Drawing.Size(250, 430)
        Me.dgvTodosLosSintomas.TabIndex = 115
        '
        'dgvColSintomas
        '
        Me.dgvColSintomas.HeaderText = "Column1"
        Me.dgvColSintomas.MinimumWidth = 6
        Me.dgvColSintomas.Name = "dgvColSintomas"
        Me.dgvColSintomas.ReadOnly = True
        '
        'dgvSintomasSeleccionados
        '
        Me.dgvSintomasSeleccionados.AllowDrop = True
        Me.dgvSintomasSeleccionados.AllowUserToAddRows = False
        Me.dgvSintomasSeleccionados.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.dgvSintomasSeleccionados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSintomasSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomasSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSintomasSeleccionados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.dgvSintomasSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSintomasSeleccionados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomasSeleccionados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSintomasSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomasSeleccionados.ColumnHeadersVisible = False
        Me.dgvSintomasSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColSintomasSel})
        Me.transicion.SetDecoration(Me.dgvSintomasSeleccionados, Guna.UI.Animation.DecorationType.None)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(19, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSintomasSeleccionados.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSintomasSeleccionados.Location = New System.Drawing.Point(679, 150)
        Me.dgvSintomasSeleccionados.MultiSelect = False
        Me.dgvSintomasSeleccionados.Name = "dgvSintomasSeleccionados"
        Me.dgvSintomasSeleccionados.ReadOnly = True
        Me.dgvSintomasSeleccionados.RowHeadersVisible = False
        Me.dgvSintomasSeleccionados.RowHeadersWidth = 51
        Me.dgvSintomasSeleccionados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSintomasSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSintomasSeleccionados.Size = New System.Drawing.Size(250, 430)
        Me.dgvSintomasSeleccionados.TabIndex = 114
        '
        'dgvColSintomasSel
        '
        Me.dgvColSintomasSel.HeaderText = "Column1"
        Me.dgvColSintomasSel.MinimumWidth = 6
        Me.dgvColSintomasSel.Name = "dgvColSintomasSel"
        Me.dgvColSintomasSel.ReadOnly = True
        '
        'lblTodosLosSintomas
        '
        Me.transicion.SetDecoration(Me.lblTodosLosSintomas, Guna.UI.Animation.DecorationType.None)
        Me.lblTodosLosSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTodosLosSintomas.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodosLosSintomas.ForeColor = System.Drawing.Color.Silver
        Me.lblTodosLosSintomas.Location = New System.Drawing.Point(127, 62)
        Me.lblTodosLosSintomas.Name = "lblTodosLosSintomas"
        Me.lblTodosLosSintomas.Size = New System.Drawing.Size(339, 70)
        Me.lblTodosLosSintomas.TabIndex = 116
        Me.lblTodosLosSintomas.Text = "Todos los síntomas"
        Me.lblTodosLosSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSintomasSeleccionados
        '
        Me.transicion.SetDecoration(Me.lblSintomasSeleccionados, Guna.UI.Animation.DecorationType.None)
        Me.lblSintomasSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSintomasSeleccionados.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintomasSeleccionados.ForeColor = System.Drawing.Color.Silver
        Me.lblSintomasSeleccionados.Location = New System.Drawing.Point(656, 71)
        Me.lblSintomasSeleccionados.Name = "lblSintomasSeleccionados"
        Me.lblSintomasSeleccionados.Size = New System.Drawing.Size(312, 55)
        Me.lblSintomasSeleccionados.TabIndex = 117
        Me.lblSintomasSeleccionados.Text = "Síntomas Seleccionados"
        Me.lblSintomasSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmRegistrarPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.transicion.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarPatologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlPatologia.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlSintomas.ResumeLayout(False)
        CType(Me.dgvTodosLosSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents transicion As Guna.UI.WinForms.GunaTransition
    Private components As System.ComponentModel.IContainer
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlPatologia As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents lblNomPat As Label
    Friend WithEvents btnRegPatologia As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtNomPat As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblCantRec As Label
    Friend WithEvents lblDescPatologia As Label
    Friend WithEvents btnSintomasPatologia As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtDescPat As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblPrioPatologia As Label
    Friend WithEvents sepDesc As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents mrbPMedia As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents lblCantDesc As Label
    Friend WithEvents mrbPBaja As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents lblRecomendacionesPatologia As Label
    Friend WithEvents mrbPAlta As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents txtRecPat As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents sepRec As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents pnlSintomas As Panel
    Friend WithEvents btnVolver As FontAwesome.Sharp.IconButton
    Friend WithEvents scroll2 As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
    Friend WithEvents dgvTodosLosSintomas As DataGridView
    Friend WithEvents dgvColSintomas As DataGridViewTextBoxColumn
    Friend WithEvents dgvSintomasSeleccionados As DataGridView
    Friend WithEvents dgvColSintomasSel As DataGridViewTextBoxColumn
    Friend WithEvents lblTodosLosSintomas As Label
    Friend WithEvents lblSintomasSeleccionados As Label
    Friend WithEvents Label1 As Label
End Class
