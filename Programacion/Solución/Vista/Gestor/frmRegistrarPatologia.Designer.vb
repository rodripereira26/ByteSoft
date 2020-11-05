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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTituloPatologia = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblRegistrar = New System.Windows.Forms.Label()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.pnlDescPatologia = New System.Windows.Forms.Panel()
        Me.lblNomPat = New System.Windows.Forms.Label()
        Me.pnlNomPat = New System.Windows.Forms.Panel()
        Me.lblDescPat = New System.Windows.Forms.Label()
        Me.pnlTxtRecPat = New System.Windows.Forms.Panel()
        Me.lblRecPat = New System.Windows.Forms.Label()
        Me.dgvSintomasSeleccionados = New System.Windows.Forms.DataGridView()
        Me.dgvColSintomasSel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTodosLosSintomas = New System.Windows.Forms.DataGridView()
        Me.dgvColSintomas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTodosLosSintomas = New System.Windows.Forms.Label()
        Me.lblSintomasSeleccionados = New System.Windows.Forms.Label()
        Me.txtNomPat = New System.Windows.Forms.TextBox()
        Me.lblArrastreSintomas = New System.Windows.Forms.Label()
        Me.txtDescPat = New System.Windows.Forms.TextBox()
        Me.txtRecPat = New System.Windows.Forms.TextBox()
        Me.mrbtnRegistrarPat = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblPrioridad = New System.Windows.Forms.Label()
        Me.mrbPAlta = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbPBaja = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbPMedia = New MaterialSkin.Controls.MaterialRadioButton()
        Me.pnlTituloPatologia.SuspendLayout()
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTodosLosSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTituloPatologia
        '
        Me.pnlTituloPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTituloPatologia.Controls.Add(Me.btnAtras)
        Me.pnlTituloPatologia.Controls.Add(Me.lblRegistrar)
        Me.pnlTituloPatologia.Controls.Add(Me.lblMinimizar)
        Me.pnlTituloPatologia.Controls.Add(Me.lblCerrar)
        Me.pnlTituloPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituloPatologia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTituloPatologia.Name = "pnlTituloPatologia"
        Me.pnlTituloPatologia.Size = New System.Drawing.Size(1471, 95)
        Me.pnlTituloPatologia.TabIndex = 92
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icoFlechaAtras
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Image = Global.Vista.My.Resources.Resources.icoFlechaAtrasWhite
        Me.btnAtras.Location = New System.Drawing.Point(43, 28)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(45, 41)
        Me.btnAtras.TabIndex = 29
        Me.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblRegistrar
        '
        Me.lblRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrar.ForeColor = System.Drawing.Color.White
        Me.lblRegistrar.Location = New System.Drawing.Point(492, 20)
        Me.lblRegistrar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegistrar.Name = "lblRegistrar"
        Me.lblRegistrar.Size = New System.Drawing.Size(487, 55)
        Me.lblRegistrar.TabIndex = 26
        Me.lblRegistrar.Text = "REGISTRAR PATOLOGÍA"
        Me.lblRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.White
        Me.lblMinimizar.Location = New System.Drawing.Point(1369, -7)
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
        Me.lblCerrar.Location = New System.Drawing.Point(1409, 0)
        Me.lblCerrar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(57, 43)
        Me.lblCerrar.TabIndex = 23
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlDescPatologia
        '
        Me.pnlDescPatologia.BackColor = System.Drawing.Color.Black
        Me.pnlDescPatologia.Location = New System.Drawing.Point(65, 481)
        Me.pnlDescPatologia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlDescPatologia.Name = "pnlDescPatologia"
        Me.pnlDescPatologia.Size = New System.Drawing.Size(499, 2)
        Me.pnlDescPatologia.TabIndex = 109
        '
        'lblNomPat
        '
        Me.lblNomPat.AutoSize = True
        Me.lblNomPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomPat.Location = New System.Drawing.Point(65, 148)
        Me.lblNomPat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNomPat.Name = "lblNomPat"
        Me.lblNomPat.Size = New System.Drawing.Size(322, 36)
        Me.lblNomPat.TabIndex = 105
        Me.lblNomPat.Text = "Nombre de la patologia"
        '
        'pnlNomPat
        '
        Me.pnlNomPat.BackColor = System.Drawing.Color.Black
        Me.pnlNomPat.Location = New System.Drawing.Point(65, 235)
        Me.pnlNomPat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlNomPat.Name = "pnlNomPat"
        Me.pnlNomPat.Size = New System.Drawing.Size(372, 2)
        Me.pnlNomPat.TabIndex = 106
        '
        'lblDescPat
        '
        Me.lblDescPat.AutoSize = True
        Me.lblDescPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescPat.Location = New System.Drawing.Point(65, 318)
        Me.lblDescPat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescPat.Name = "lblDescPat"
        Me.lblDescPat.Size = New System.Drawing.Size(172, 36)
        Me.lblDescPat.TabIndex = 107
        Me.lblDescPat.Text = "Descripción"
        '
        'pnlTxtRecPat
        '
        Me.pnlTxtRecPat.BackColor = System.Drawing.Color.Black
        Me.pnlTxtRecPat.Location = New System.Drawing.Point(63, 683)
        Me.pnlTxtRecPat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTxtRecPat.Name = "pnlTxtRecPat"
        Me.pnlTxtRecPat.Size = New System.Drawing.Size(499, 2)
        Me.pnlTxtRecPat.TabIndex = 112
        '
        'lblRecPat
        '
        Me.lblRecPat.AutoSize = True
        Me.lblRecPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecPat.Location = New System.Drawing.Point(63, 519)
        Me.lblRecPat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecPat.Name = "lblRecPat"
        Me.lblRecPat.Size = New System.Drawing.Size(261, 36)
        Me.lblRecPat.TabIndex = 110
        Me.lblRecPat.Text = "Recomendaciones"
        '
        'dgvSintomasSeleccionados
        '
        Me.dgvSintomasSeleccionados.AllowDrop = True
        Me.dgvSintomasSeleccionados.AllowUserToAddRows = False
        Me.dgvSintomasSeleccionados.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dgvSintomasSeleccionados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSintomasSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomasSeleccionados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSintomasSeleccionados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSintomasSeleccionados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSintomasSeleccionados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomasSeleccionados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSintomasSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomasSeleccionados.ColumnHeadersVisible = False
        Me.dgvSintomasSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColSintomasSel})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSintomasSeleccionados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSintomasSeleccionados.Location = New System.Drawing.Point(632, 209)
        Me.dgvSintomasSeleccionados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvSintomasSeleccionados.MultiSelect = False
        Me.dgvSintomasSeleccionados.Name = "dgvSintomasSeleccionados"
        Me.dgvSintomasSeleccionados.ReadOnly = True
        Me.dgvSintomasSeleccionados.RowHeadersVisible = False
        Me.dgvSintomasSeleccionados.RowHeadersWidth = 51
        Me.dgvSintomasSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSintomasSeleccionados.Size = New System.Drawing.Size(285, 529)
        Me.dgvSintomasSeleccionados.TabIndex = 114
        '
        'dgvColSintomasSel
        '
        Me.dgvColSintomasSel.HeaderText = "Column1"
        Me.dgvColSintomasSel.MinimumWidth = 6
        Me.dgvColSintomasSel.Name = "dgvColSintomasSel"
        Me.dgvColSintomasSel.ReadOnly = True
        '
        'dgvTodosLosSintomas
        '
        Me.dgvTodosLosSintomas.AllowDrop = True
        Me.dgvTodosLosSintomas.AllowUserToAddRows = False
        Me.dgvTodosLosSintomas.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dgvTodosLosSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTodosLosSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTodosLosSintomas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTodosLosSintomas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTodosLosSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTodosLosSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodosLosSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTodosLosSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodosLosSintomas.ColumnHeadersVisible = False
        Me.dgvTodosLosSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvColSintomas})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTodosLosSintomas.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTodosLosSintomas.Location = New System.Drawing.Point(1129, 209)
        Me.dgvTodosLosSintomas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvTodosLosSintomas.MultiSelect = False
        Me.dgvTodosLosSintomas.Name = "dgvTodosLosSintomas"
        Me.dgvTodosLosSintomas.ReadOnly = True
        Me.dgvTodosLosSintomas.RowHeadersVisible = False
        Me.dgvTodosLosSintomas.RowHeadersWidth = 51
        Me.dgvTodosLosSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTodosLosSintomas.Size = New System.Drawing.Size(285, 529)
        Me.dgvTodosLosSintomas.TabIndex = 115
        '
        'dgvColSintomas
        '
        Me.dgvColSintomas.HeaderText = "Column1"
        Me.dgvColSintomas.MinimumWidth = 6
        Me.dgvColSintomas.Name = "dgvColSintomas"
        Me.dgvColSintomas.ReadOnly = True
        '
        'lblTodosLosSintomas
        '
        Me.lblTodosLosSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTodosLosSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodosLosSintomas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblTodosLosSintomas.Location = New System.Drawing.Point(1088, 127)
        Me.lblTodosLosSintomas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTodosLosSintomas.Name = "lblTodosLosSintomas"
        Me.lblTodosLosSintomas.Size = New System.Drawing.Size(369, 53)
        Me.lblTodosLosSintomas.TabIndex = 116
        Me.lblTodosLosSintomas.Text = "Todos los síntomas"
        Me.lblTodosLosSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSintomasSeleccionados
        '
        Me.lblSintomasSeleccionados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSintomasSeleccionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintomasSeleccionados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblSintomasSeleccionados.Location = New System.Drawing.Point(567, 127)
        Me.lblSintomasSeleccionados.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSintomasSeleccionados.Name = "lblSintomasSeleccionados"
        Me.lblSintomasSeleccionados.Size = New System.Drawing.Size(416, 53)
        Me.lblSintomasSeleccionados.TabIndex = 117
        Me.lblSintomasSeleccionados.Text = "Síntomas Seleccionados"
        Me.lblSintomasSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNomPat
        '
        Me.txtNomPat.BackColor = System.Drawing.Color.White
        Me.txtNomPat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomPat.Location = New System.Drawing.Point(65, 198)
        Me.txtNomPat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNomPat.Name = "txtNomPat"
        Me.txtNomPat.Size = New System.Drawing.Size(372, 27)
        Me.txtNomPat.TabIndex = 119
        '
        'lblArrastreSintomas
        '
        Me.lblArrastreSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblArrastreSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrastreSintomas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblArrastreSintomas.Location = New System.Drawing.Point(925, 385)
        Me.lblArrastreSintomas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArrastreSintomas.Name = "lblArrastreSintomas"
        Me.lblArrastreSintomas.Size = New System.Drawing.Size(196, 174)
        Me.lblArrastreSintomas.TabIndex = 120
        Me.lblArrastreSintomas.Text = "Arrastre Síntomas hacia la izquierda"
        Me.lblArrastreSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescPat
        '
        Me.txtDescPat.BackColor = System.Drawing.Color.White
        Me.txtDescPat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescPat.Location = New System.Drawing.Point(65, 382)
        Me.txtDescPat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescPat.Multiline = True
        Me.txtDescPat.Name = "txtDescPat"
        Me.txtDescPat.Size = New System.Drawing.Size(496, 81)
        Me.txtDescPat.TabIndex = 121
        '
        'txtRecPat
        '
        Me.txtRecPat.BackColor = System.Drawing.Color.White
        Me.txtRecPat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecPat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecPat.Location = New System.Drawing.Point(63, 575)
        Me.txtRecPat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRecPat.Multiline = True
        Me.txtRecPat.Name = "txtRecPat"
        Me.txtRecPat.Size = New System.Drawing.Size(496, 86)
        Me.txtRecPat.TabIndex = 122
        '
        'mrbtnRegistrarPat
        '
        Me.mrbtnRegistrarPat.AutoSize = True
        Me.mrbtnRegistrarPat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mrbtnRegistrarPat.Depth = 0
        Me.mrbtnRegistrarPat.Icon = Nothing
        Me.mrbtnRegistrarPat.Location = New System.Drawing.Point(641, 836)
        Me.mrbtnRegistrarPat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mrbtnRegistrarPat.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnRegistrarPat.Name = "mrbtnRegistrarPat"
        Me.mrbtnRegistrarPat.Primary = True
        Me.mrbtnRegistrarPat.Size = New System.Drawing.Size(211, 36)
        Me.mrbtnRegistrarPat.TabIndex = 127
        Me.mrbtnRegistrarPat.Text = "Registrar patología"
        Me.mrbtnRegistrarPat.UseVisualStyleBackColor = True
        '
        'lblPrioridad
        '
        Me.lblPrioridad.AutoSize = True
        Me.lblPrioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrioridad.Location = New System.Drawing.Point(59, 716)
        Me.lblPrioridad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrioridad.Name = "lblPrioridad"
        Me.lblPrioridad.Size = New System.Drawing.Size(136, 36)
        Me.lblPrioridad.TabIndex = 128
        Me.lblPrioridad.Text = "Prioridad"
        '
        'mrbPAlta
        '
        Me.mrbPAlta.AutoSize = True
        Me.mrbPAlta.Depth = 0
        Me.mrbPAlta.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbPAlta.Location = New System.Drawing.Point(63, 774)
        Me.mrbPAlta.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbPAlta.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbPAlta.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbPAlta.Name = "mrbPAlta"
        Me.mrbPAlta.Ripple = True
        Me.mrbPAlta.Size = New System.Drawing.Size(61, 30)
        Me.mrbPAlta.TabIndex = 129
        Me.mrbPAlta.TabStop = True
        Me.mrbPAlta.Text = "Alta"
        Me.mrbPAlta.UseVisualStyleBackColor = True
        '
        'mrbPBaja
        '
        Me.mrbPBaja.AutoSize = True
        Me.mrbPBaja.Depth = 0
        Me.mrbPBaja.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbPBaja.Location = New System.Drawing.Point(63, 848)
        Me.mrbPBaja.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbPBaja.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbPBaja.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbPBaja.Name = "mrbPBaja"
        Me.mrbPBaja.Ripple = True
        Me.mrbPBaja.Size = New System.Drawing.Size(64, 30)
        Me.mrbPBaja.TabIndex = 130
        Me.mrbPBaja.TabStop = True
        Me.mrbPBaja.Text = "Baja"
        Me.mrbPBaja.UseVisualStyleBackColor = True
        '
        'mrbPMedia
        '
        Me.mrbPMedia.AutoSize = True
        Me.mrbPMedia.Depth = 0
        Me.mrbPMedia.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbPMedia.Location = New System.Drawing.Point(63, 811)
        Me.mrbPMedia.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbPMedia.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbPMedia.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbPMedia.Name = "mrbPMedia"
        Me.mrbPMedia.Ripple = True
        Me.mrbPMedia.Size = New System.Drawing.Size(78, 30)
        Me.mrbPMedia.TabIndex = 131
        Me.mrbPMedia.TabStop = True
        Me.mrbPMedia.Text = "Media"
        Me.mrbPMedia.UseVisualStyleBackColor = True
        '
        'frmRegistrarPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1467, 919)
        Me.Controls.Add(Me.pnlTituloPatologia)
        Me.Controls.Add(Me.lblNomPat)
        Me.Controls.Add(Me.txtNomPat)
        Me.Controls.Add(Me.pnlNomPat)
        Me.Controls.Add(Me.lblDescPat)
        Me.Controls.Add(Me.txtDescPat)
        Me.Controls.Add(Me.pnlDescPatologia)
        Me.Controls.Add(Me.lblRecPat)
        Me.Controls.Add(Me.txtRecPat)
        Me.Controls.Add(Me.pnlTxtRecPat)
        Me.Controls.Add(Me.lblPrioridad)
        Me.Controls.Add(Me.mrbPAlta)
        Me.Controls.Add(Me.mrbPMedia)
        Me.Controls.Add(Me.mrbPBaja)
        Me.Controls.Add(Me.mrbtnRegistrarPat)
        Me.Controls.Add(Me.lblSintomasSeleccionados)
        Me.Controls.Add(Me.dgvSintomasSeleccionados)
        Me.Controls.Add(Me.lblArrastreSintomas)
        Me.Controls.Add(Me.lblTodosLosSintomas)
        Me.Controls.Add(Me.dgvTodosLosSintomas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmRegistrarPatologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlTituloPatologia.ResumeLayout(False)
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTodosLosSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTituloPatologia As Panel
    Friend WithEvents pnlDescPatologia As Panel
    Friend WithEvents lblNomPat As Label
    Friend WithEvents pnlNomPat As Panel
    Friend WithEvents lblDescPat As Label
    Friend WithEvents pnlTxtRecPat As Panel
    Friend WithEvents lblRecPat As Label
    Friend WithEvents dgvSintomasSeleccionados As DataGridView
    Friend WithEvents dgvColSintomasSel As DataGridViewTextBoxColumn
    Friend WithEvents dgvTodosLosSintomas As DataGridView
    Friend WithEvents dgvColSintomas As DataGridViewTextBoxColumn
    Friend WithEvents lblTodosLosSintomas As Label
    Friend WithEvents lblSintomasSeleccionados As Label
    Friend WithEvents txtNomPat As TextBox
    Friend WithEvents lblArrastreSintomas As Label
    Friend WithEvents txtDescPat As TextBox
    Friend WithEvents txtRecPat As TextBox
    Friend WithEvents lblMinimizar As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents mrbtnRegistrarPat As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblPrioridad As Label
    Friend WithEvents mrbPAlta As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbPBaja As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbPMedia As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents lblRegistrar As Label
    Friend WithEvents btnAtras As Button
End Class
