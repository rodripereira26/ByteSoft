<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuariosRegistrados
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuariosRegistrados))
        Me.dgvEmp = New System.Windows.Forms.DataGridView()
        Me.ci = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrimerNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SegundoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pape = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Segundoapellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.lblListadoDeUsuariosRegistrados = New System.Windows.Forms.Label()
        Me.txtCed = New System.Windows.Forms.TextBox()
        Me.pnlBuscar = New System.Windows.Forms.Panel()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblCriterioBusqueda = New System.Windows.Forms.Label()
        Me.cbbCriterioBusqueda = New System.Windows.Forms.ComboBox()
        Me.picBuscar = New System.Windows.Forms.PictureBox()
        Me.picIngresarTexto = New System.Windows.Forms.PictureBox()
        Me.btnSeleccionMultiple = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnEliminarPorElemento = New MaterialSkin.Controls.MaterialRaisedButton()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlBuscar.SuspendLayout()
        CType(Me.picBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIngresarTexto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvEmp
        '
        Me.dgvEmp.AllowUserToAddRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(4, 10, 4, 10)
        Me.dgvEmp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvEmp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvEmp.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(4, 12, 4, 12)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ci, Me.PrimerNombre, Me.SegundoNombre, Me.Pape, Me.Segundoapellido, Me.tipo, Me.edad})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(4, 10, 4, 10)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmp.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvEmp.EnableHeadersVisualStyles = False
        Me.dgvEmp.Location = New System.Drawing.Point(0, 106)
        Me.dgvEmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvEmp.MultiSelect = False
        Me.dgvEmp.Name = "dgvEmp"
        Me.dgvEmp.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmp.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvEmp.RowHeadersVisible = False
        Me.dgvEmp.RowHeadersWidth = 51
        Me.dgvEmp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvEmp.Size = New System.Drawing.Size(1345, 681)
        Me.dgvEmp.TabIndex = 57
        '
        'ci
        '
        Me.ci.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.ci.DefaultCellStyle = DataGridViewCellStyle8
        Me.ci.HeaderText = "Cédula"
        Me.ci.MinimumWidth = 6
        Me.ci.Name = "ci"
        Me.ci.ReadOnly = True
        '
        'PrimerNombre
        '
        Me.PrimerNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PrimerNombre.HeaderText = "Primer Nombre"
        Me.PrimerNombre.MinimumWidth = 6
        Me.PrimerNombre.Name = "PrimerNombre"
        Me.PrimerNombre.ReadOnly = True
        '
        'SegundoNombre
        '
        Me.SegundoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SegundoNombre.HeaderText = "Segundo Nombre"
        Me.SegundoNombre.MinimumWidth = 6
        Me.SegundoNombre.Name = "SegundoNombre"
        Me.SegundoNombre.ReadOnly = True
        '
        'Pape
        '
        Me.Pape.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Pape.HeaderText = "Primer Apellido"
        Me.Pape.MinimumWidth = 6
        Me.Pape.Name = "Pape"
        Me.Pape.ReadOnly = True
        '
        'Segundoapellido
        '
        Me.Segundoapellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Segundoapellido.HeaderText = "Segundo Apellido"
        Me.Segundoapellido.MinimumWidth = 6
        Me.Segundoapellido.Name = "Segundoapellido"
        Me.Segundoapellido.ReadOnly = True
        '
        'tipo
        '
        Me.tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.MinimumWidth = 6
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        '
        'edad
        '
        Me.edad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.edad.HeaderText = "Edad"
        Me.edad.MinimumWidth = 6
        Me.edad.Name = "edad"
        Me.edad.ReadOnly = True
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.lblMinimizar)
        Me.pnlTitulo.Controls.Add(Me.lblCerrar)
        Me.pnlTitulo.Controls.Add(Me.lblListadoDeUsuariosRegistrados)
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(1741, 110)
        Me.pnlTitulo.TabIndex = 59
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.White
        Me.lblMinimizar.Location = New System.Drawing.Point(1640, -7)
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
        Me.lblCerrar.Location = New System.Drawing.Point(1680, 0)
        Me.lblCerrar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(57, 43)
        Me.lblCerrar.TabIndex = 23
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblListadoDeUsuariosRegistrados
        '
        Me.lblListadoDeUsuariosRegistrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblListadoDeUsuariosRegistrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoDeUsuariosRegistrados.ForeColor = System.Drawing.Color.White
        Me.lblListadoDeUsuariosRegistrados.Location = New System.Drawing.Point(556, 11)
        Me.lblListadoDeUsuariosRegistrados.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblListadoDeUsuariosRegistrados.Name = "lblListadoDeUsuariosRegistrados"
        Me.lblListadoDeUsuariosRegistrados.Size = New System.Drawing.Size(631, 70)
        Me.lblListadoDeUsuariosRegistrados.TabIndex = 4
        Me.lblListadoDeUsuariosRegistrados.Text = "Listado de usuarios registrados"
        Me.lblListadoDeUsuariosRegistrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCed
        '
        Me.txtCed.BackColor = System.Drawing.Color.White
        Me.txtCed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCed.Location = New System.Drawing.Point(1439, 407)
        Me.txtCed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCed.Name = "txtCed"
        Me.txtCed.Size = New System.Drawing.Size(235, 27)
        Me.txtCed.TabIndex = 89
        Me.txtCed.Visible = False
        '
        'pnlBuscar
        '
        Me.pnlBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.pnlBuscar.Controls.Add(Me.lblBuscar)
        Me.pnlBuscar.Controls.Add(Me.lbl1)
        Me.pnlBuscar.Location = New System.Drawing.Point(1345, 110)
        Me.pnlBuscar.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlBuscar.Name = "pnlBuscar"
        Me.pnlBuscar.Size = New System.Drawing.Size(396, 82)
        Me.pnlBuscar.TabIndex = 60
        '
        'lblBuscar
        '
        Me.lblBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.ForeColor = System.Drawing.Color.White
        Me.lblBuscar.Location = New System.Drawing.Point(115, 18)
        Me.lblBuscar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(176, 42)
        Me.lblBuscar.TabIndex = 25
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl1
        '
        Me.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(556, 11)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(631, 70)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Listado de usuarios registrados"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCriterioBusqueda
        '
        Me.lblCriterioBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCriterioBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCriterioBusqueda.ForeColor = System.Drawing.Color.Black
        Me.lblCriterioBusqueda.Location = New System.Drawing.Point(1415, 238)
        Me.lblCriterioBusqueda.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCriterioBusqueda.Name = "lblCriterioBusqueda"
        Me.lblCriterioBusqueda.Size = New System.Drawing.Size(284, 42)
        Me.lblCriterioBusqueda.TabIndex = 92
        Me.lblCriterioBusqueda.Text = "Criterio de búsqueda"
        Me.lblCriterioBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbbCriterioBusqueda
        '
        Me.cbbCriterioBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbbCriterioBusqueda.FormattingEnabled = True
        Me.cbbCriterioBusqueda.Items.AddRange(New Object() {"Cédula"})
        Me.cbbCriterioBusqueda.Location = New System.Drawing.Point(1440, 297)
        Me.cbbCriterioBusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbbCriterioBusqueda.Name = "cbbCriterioBusqueda"
        Me.cbbCriterioBusqueda.Size = New System.Drawing.Size(231, 37)
        Me.cbbCriterioBusqueda.TabIndex = 93
        '
        'picBuscar
        '
        Me.picBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picBuscar.Image = CType(resources.GetObject("picBuscar.Image"), System.Drawing.Image)
        Me.picBuscar.Location = New System.Drawing.Point(1520, 496)
        Me.picBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picBuscar.Name = "picBuscar"
        Me.picBuscar.Size = New System.Drawing.Size(72, 66)
        Me.picBuscar.TabIndex = 88
        Me.picBuscar.TabStop = False
        '
        'picIngresarTexto
        '
        Me.picIngresarTexto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picIngresarTexto.Image = CType(resources.GetObject("picIngresarTexto.Image"), System.Drawing.Image)
        Me.picIngresarTexto.Location = New System.Drawing.Point(1419, 391)
        Me.picIngresarTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picIngresarTexto.Name = "picIngresarTexto"
        Me.picIngresarTexto.Size = New System.Drawing.Size(276, 65)
        Me.picIngresarTexto.TabIndex = 90
        Me.picIngresarTexto.TabStop = False
        '
        'btnSeleccionMultiple
        '
        Me.btnSeleccionMultiple.AutoSize = True
        Me.btnSeleccionMultiple.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSeleccionMultiple.Depth = 0
        Me.btnSeleccionMultiple.Icon = Nothing
        Me.btnSeleccionMultiple.Location = New System.Drawing.Point(1449, 602)
        Me.btnSeleccionMultiple.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSeleccionMultiple.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSeleccionMultiple.Name = "btnSeleccionMultiple"
        Me.btnSeleccionMultiple.Primary = True
        Me.btnSeleccionMultiple.Size = New System.Drawing.Size(197, 36)
        Me.btnSeleccionMultiple.TabIndex = 125
        Me.btnSeleccionMultiple.Text = "Selección múltiple"
        Me.btnSeleccionMultiple.UseVisualStyleBackColor = True
        '
        'btnEliminarPorElemento
        '
        Me.btnEliminarPorElemento.AutoSize = True
        Me.btnEliminarPorElemento.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEliminarPorElemento.Depth = 0
        Me.btnEliminarPorElemento.Icon = Nothing
        Me.btnEliminarPorElemento.Location = New System.Drawing.Point(1437, 677)
        Me.btnEliminarPorElemento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminarPorElemento.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEliminarPorElemento.Name = "btnEliminarPorElemento"
        Me.btnEliminarPorElemento.Primary = True
        Me.btnEliminarPorElemento.Size = New System.Drawing.Size(218, 36)
        Me.btnEliminarPorElemento.TabIndex = 127
        Me.btnEliminarPorElemento.Text = "Eliminar X elementos"
        Me.btnEliminarPorElemento.UseVisualStyleBackColor = True
        Me.btnEliminarPorElemento.Visible = False
        '
        'frmUsuariosRegistrados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1741, 794)
        Me.Controls.Add(Me.btnEliminarPorElemento)
        Me.Controls.Add(Me.btnSeleccionMultiple)
        Me.Controls.Add(Me.cbbCriterioBusqueda)
        Me.Controls.Add(Me.lblCriterioBusqueda)
        Me.Controls.Add(Me.pnlBuscar)
        Me.Controls.Add(Me.picBuscar)
        Me.Controls.Add(Me.txtCed)
        Me.Controls.Add(Me.picIngresarTexto)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.dgvEmp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmUsuariosRegistrados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ListadoGestor"
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlBuscar.ResumeLayout(False)
        CType(Me.picBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIngresarTexto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvEmp As DataGridView
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblMinimizar As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents lblListadoDeUsuariosRegistrados As Label
    Friend WithEvents picBuscar As PictureBox
    Friend WithEvents txtCed As TextBox
    Friend WithEvents picIngresarTexto As PictureBox
    Friend WithEvents pnlBuscar As Panel
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblCriterioBusqueda As Label
    Friend WithEvents cbbCriterioBusqueda As ComboBox
    Friend WithEvents btnSeleccionMultiple As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnEliminarPorElemento As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ci As DataGridViewTextBoxColumn
    Friend WithEvents PrimerNombre As DataGridViewTextBoxColumn
    Friend WithEvents SegundoNombre As DataGridViewTextBoxColumn
    Friend WithEvents Pape As DataGridViewTextBoxColumn
    Friend WithEvents Segundoapellido As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents edad As DataGridViewTextBoxColumn
End Class
