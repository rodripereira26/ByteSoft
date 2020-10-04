<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIngresarSintomas
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblIngreseSIntomas = New System.Windows.Forms.Label()
        Me.lblArrastreSintomas = New System.Windows.Forms.Label()
        Me.lblMisSintomas = New System.Windows.Forms.Label()
        Me.lblSintomasRegistrados = New System.Windows.Forms.Label()
        Me.btnObtenerDiagnostico = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtBuscar = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.dgvSintomasSeleccionados = New System.Windows.Forms.DataGridView()
        Me.MISintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTodos = New System.Windows.Forms.DataGridView()
        Me.SintomaTodos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.pnlInstancia = New System.Windows.Forms.Panel()
        Me.pnlTitulo.SuspendLayout()
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.btnAtras)
        Me.pnlTitulo.Controls.Add(Me.lblIngreseSIntomas)
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(767, 69)
        Me.pnlTitulo.TabIndex = 11
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icons8_left_32px
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(18, 13)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Padding = New System.Windows.Forms.Padding(3)
        Me.btnAtras.Size = New System.Drawing.Size(49, 32)
        Me.btnAtras.TabIndex = 160
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblIngreseSIntomas
        '
        Me.lblIngreseSIntomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIngreseSIntomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseSIntomas.ForeColor = System.Drawing.Color.White
        Me.lblIngreseSIntomas.Location = New System.Drawing.Point(204, 9)
        Me.lblIngreseSIntomas.Name = "lblIngreseSIntomas"
        Me.lblIngreseSIntomas.Size = New System.Drawing.Size(345, 45)
        Me.lblIngreseSIntomas.TabIndex = 25
        Me.lblIngreseSIntomas.Text = "INGRESE SÍNTOMAS"
        Me.lblIngreseSIntomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArrastreSintomas
        '
        Me.lblArrastreSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblArrastreSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArrastreSintomas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblArrastreSintomas.Location = New System.Drawing.Point(274, 331)
        Me.lblArrastreSintomas.Name = "lblArrastreSintomas"
        Me.lblArrastreSintomas.Size = New System.Drawing.Size(217, 217)
        Me.lblArrastreSintomas.TabIndex = 82
        Me.lblArrastreSintomas.Text = "Arrastre Síntomas hacia la derecha "
        Me.lblArrastreSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMisSintomas
        '
        Me.lblMisSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblMisSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMisSintomas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblMisSintomas.Location = New System.Drawing.Point(550, 135)
        Me.lblMisSintomas.Name = "lblMisSintomas"
        Me.lblMisSintomas.Size = New System.Drawing.Size(177, 69)
        Me.lblMisSintomas.TabIndex = 85
        Me.lblMisSintomas.Text = "Mis síntomas"
        Me.lblMisSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSintomasRegistrados
        '
        Me.lblSintomasRegistrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSintomasRegistrados.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSintomasRegistrados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblSintomasRegistrados.Location = New System.Drawing.Point(10, 121)
        Me.lblSintomasRegistrados.Name = "lblSintomasRegistrados"
        Me.lblSintomasRegistrados.Size = New System.Drawing.Size(261, 96)
        Me.lblSintomasRegistrados.TabIndex = 86
        Me.lblSintomasRegistrados.Text = "Síntomas registrados"
        Me.lblSintomasRegistrados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnObtenerDiagnostico
        '
        Me.btnObtenerDiagnostico.AutoSize = True
        Me.btnObtenerDiagnostico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnObtenerDiagnostico.Depth = 0
        Me.btnObtenerDiagnostico.Icon = Nothing
        Me.btnObtenerDiagnostico.Location = New System.Drawing.Point(295, 643)
        Me.btnObtenerDiagnostico.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnObtenerDiagnostico.Name = "btnObtenerDiagnostico"
        Me.btnObtenerDiagnostico.Primary = True
        Me.btnObtenerDiagnostico.Size = New System.Drawing.Size(174, 36)
        Me.btnObtenerDiagnostico.TabIndex = 126
        Me.btnObtenerDiagnostico.Text = "Obtener diagnóstico"
        Me.btnObtenerDiagnostico.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Depth = 0
        Me.txtBuscar.Hint = ""
        Me.txtBuscar.Location = New System.Drawing.Point(39, 234)
        Me.txtBuscar.MaxLength = 32767
        Me.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.SelectionLength = 0
        Me.txtBuscar.SelectionStart = 0
        Me.txtBuscar.Size = New System.Drawing.Size(214, 23)
        Me.txtBuscar.TabIndex = 156
        Me.txtBuscar.TabStop = False
        Me.txtBuscar.Text = "Buscar"
        Me.txtBuscar.UseSystemPasswordChar = False
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
        Me.dgvSintomasSeleccionados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MISintoma})
        Me.dgvSintomasSeleccionados.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSintomasSeleccionados.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSintomasSeleccionados.Location = New System.Drawing.Point(535, 286)
        Me.dgvSintomasSeleccionados.MultiSelect = False
        Me.dgvSintomasSeleccionados.Name = "dgvSintomasSeleccionados"
        Me.dgvSintomasSeleccionados.ReadOnly = True
        Me.dgvSintomasSeleccionados.RowHeadersVisible = False
        Me.dgvSintomasSeleccionados.RowHeadersWidth = 51
        Me.dgvSintomasSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSintomasSeleccionados.Size = New System.Drawing.Size(202, 430)
        Me.dgvSintomasSeleccionados.TabIndex = 159
        '
        'MISintoma
        '
        Me.MISintoma.HeaderText = "Column1"
        Me.MISintoma.MinimumWidth = 6
        Me.MISintoma.Name = "MISintoma"
        Me.MISintoma.ReadOnly = True
        '
        'dgvTodos
        '
        Me.dgvTodos.AllowDrop = True
        Me.dgvTodos.AllowUserToAddRows = False
        Me.dgvTodos.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.dgvTodos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTodos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTodos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTodos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTodos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodos.ColumnHeadersVisible = False
        Me.dgvTodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SintomaTodos})
        Me.dgvTodos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTodos.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTodos.Location = New System.Drawing.Point(30, 286)
        Me.dgvTodos.MultiSelect = False
        Me.dgvTodos.Name = "dgvTodos"
        Me.dgvTodos.ReadOnly = True
        Me.dgvTodos.RowHeadersVisible = False
        Me.dgvTodos.RowHeadersWidth = 51
        Me.dgvTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTodos.Size = New System.Drawing.Size(202, 430)
        Me.dgvTodos.TabIndex = 158
        '
        'SintomaTodos
        '
        Me.SintomaTodos.HeaderText = "Column1"
        Me.SintomaTodos.MinimumWidth = 6
        Me.SintomaTodos.Name = "SintomaTodos"
        Me.SintomaTodos.ReadOnly = True
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.pnlTitulo)
        Me.pnlContenedor.Controls.Add(Me.lblSintomasRegistrados)
        Me.pnlContenedor.Controls.Add(Me.txtBuscar)
        Me.pnlContenedor.Controls.Add(Me.lblMisSintomas)
        Me.pnlContenedor.Controls.Add(Me.dgvTodos)
        Me.pnlContenedor.Controls.Add(Me.lblArrastreSintomas)
        Me.pnlContenedor.Controls.Add(Me.dgvSintomasSeleccionados)
        Me.pnlContenedor.Controls.Add(Me.btnObtenerDiagnostico)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(765, 744)
        Me.pnlContenedor.TabIndex = 160
        '
        'pnlInstancia
        '
        Me.pnlInstancia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInstancia.Location = New System.Drawing.Point(0, 0)
        Me.pnlInstancia.Name = "pnlInstancia"
        Me.pnlInstancia.Size = New System.Drawing.Size(765, 744)
        Me.pnlInstancia.TabIndex = 160
        '
        'frmIngresarSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(765, 744)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.pnlInstancia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIngresarSintomas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlTitulo.ResumeLayout(False)
        CType(Me.dgvSintomasSeleccionados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblArrastreSintomas As Label
    Friend WithEvents lblMisSintomas As Label
    Friend WithEvents lblSintomasRegistrados As Label
    Friend WithEvents btnObtenerDiagnostico As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblIngreseSIntomas As Label
    Friend WithEvents txtBuscar As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents dgvSintomasSeleccionados As DataGridView
    Friend WithEvents MISintoma As DataGridViewTextBoxColumn
    Friend WithEvents dgvTodos As DataGridView
    Friend WithEvents SintomaTodos As DataGridViewTextBoxColumn
    Friend WithEvents btnAtras As Button
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents pnlInstancia As Panel
End Class
