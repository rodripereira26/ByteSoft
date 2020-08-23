<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChat
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle49 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle50 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle51 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle52 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle53 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle54 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle55 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle56 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Chat = New System.Windows.Forms.FlowLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblEscriba = New System.Windows.Forms.Label()
        Me.dgvMisChats = New System.Windows.Forms.DataGridView()
        Me.dgvFinalizados = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnFinalizar = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtMensaje = New MetroSet_UI.Controls.MetroSetTextBox()
        Me.MetroSetDivider1 = New MetroSet_UI.Controls.MetroSetDivider()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.pbEnviar = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbCancelar = New System.Windows.Forms.PictureBox()
        CType(Me.dgvMisChats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFinalizados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbEnviar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chat
        '
        Me.Chat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chat.AutoScroll = True
        Me.Chat.Location = New System.Drawing.Point(317, 137)
        Me.Chat.Name = "Chat"
        Me.Chat.Size = New System.Drawing.Size(646, 445)
        Me.Chat.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 4000
        '
        'lblUsuario
        '
        Me.lblUsuario.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(455, 19)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(373, 33)
        Me.lblUsuario.TabIndex = 11
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(356, 81)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(223, 36)
        Me.MaterialFlatButton1.TabIndex = 12
        Me.MaterialFlatButton1.Text = "Ver síntomas y diagnóstico"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'lblEscriba
        '
        Me.lblEscriba.AutoSize = True
        Me.lblEscriba.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblEscriba.Font = New System.Drawing.Font("Roboto Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscriba.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEscriba.Location = New System.Drawing.Point(327, 609)
        Me.lblEscriba.Name = "lblEscriba"
        Me.lblEscriba.Size = New System.Drawing.Size(137, 18)
        Me.lblEscriba.TabIndex = 16
        Me.lblEscriba.Text = "Escriba un mensaje"
        '
        'dgvMisChats
        '
        Me.dgvMisChats.AllowUserToAddRows = False
        Me.dgvMisChats.AllowUserToDeleteRows = False
        DataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle49.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle49.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle49.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle49.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle49.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvMisChats.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle49
        Me.dgvMisChats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMisChats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMisChats.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvMisChats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMisChats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvMisChats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle50.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle50.Font = New System.Drawing.Font("Roboto Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle50.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle50.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMisChats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle50
        Me.dgvMisChats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMisChats.ColumnHeadersVisible = False
        Me.dgvMisChats.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle51.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle51.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle51.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle51.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMisChats.DefaultCellStyle = DataGridViewCellStyle51
        Me.dgvMisChats.EnableHeadersVisualStyles = False
        Me.dgvMisChats.Location = New System.Drawing.Point(1, 100)
        Me.dgvMisChats.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvMisChats.MultiSelect = False
        Me.dgvMisChats.Name = "dgvMisChats"
        Me.dgvMisChats.ReadOnly = True
        DataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle52.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle52.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle52.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMisChats.RowHeadersDefaultCellStyle = DataGridViewCellStyle52
        Me.dgvMisChats.RowHeadersVisible = False
        Me.dgvMisChats.RowHeadersWidth = 51
        Me.dgvMisChats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvMisChats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMisChats.Size = New System.Drawing.Size(246, 287)
        Me.dgvMisChats.TabIndex = 149
        '
        'dgvFinalizados
        '
        Me.dgvFinalizados.AllowUserToAddRows = False
        Me.dgvFinalizados.AllowUserToDeleteRows = False
        DataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle53.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle53.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle53.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle53.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle53.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle53.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFinalizados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle53
        Me.dgvFinalizados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFinalizados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvFinalizados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvFinalizados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvFinalizados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvFinalizados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle54.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle54.Font = New System.Drawing.Font("Roboto Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle54.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle54.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFinalizados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle54
        Me.dgvFinalizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFinalizados.ColumnHeadersVisible = False
        Me.dgvFinalizados.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle55.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle55.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle55.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle55.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFinalizados.DefaultCellStyle = DataGridViewCellStyle55
        Me.dgvFinalizados.EnableHeadersVisualStyles = False
        Me.dgvFinalizados.Location = New System.Drawing.Point(1, 387)
        Me.dgvFinalizados.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvFinalizados.MultiSelect = False
        Me.dgvFinalizados.Name = "dgvFinalizados"
        Me.dgvFinalizados.ReadOnly = True
        DataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle56.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFinalizados.RowHeadersDefaultCellStyle = DataGridViewCellStyle56
        Me.dgvFinalizados.RowHeadersVisible = False
        Me.dgvFinalizados.RowHeadersWidth = 51
        Me.dgvFinalizados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvFinalizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFinalizados.Size = New System.Drawing.Size(246, 269)
        Me.dgvFinalizados.TabIndex = 150
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 100)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label12
        '
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(991, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 35)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "_"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1021, 137)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 35)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "X"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnFinalizar
        '
        Me.btnFinalizar.AutoSize = True
        Me.btnFinalizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizar.Depth = 0
        Me.btnFinalizar.Icon = Nothing
        Me.btnFinalizar.Location = New System.Drawing.Point(835, 87)
        Me.btnFinalizar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnFinalizar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Primary = False
        Me.btnFinalizar.Size = New System.Drawing.Size(128, 36)
        Me.btnFinalizar.TabIndex = 14
        Me.btnFinalizar.Text = "finalizar chat"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'txtMensaje
        '
        Me.txtMensaje.AutoCompleteCustomSource = Nothing
        Me.txtMensaje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.txtMensaje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.txtMensaje.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.txtMensaje.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtMensaje.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.txtMensaje.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.txtMensaje.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.HoverColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.txtMensaje.Image = Nothing
        Me.txtMensaje.Lines = Nothing
        Me.txtMensaje.Location = New System.Drawing.Point(319, 603)
        Me.txtMensaje.MaxLength = 32767
        Me.txtMensaje.Multiline = False
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Padding = New System.Windows.Forms.Padding(10)
        Me.txtMensaje.ReadOnly = False
        Me.txtMensaje.Size = New System.Drawing.Size(585, 31)
        Me.txtMensaje.Style = MetroSet_UI.Design.Style.Light
        Me.txtMensaje.StyleManager = Nothing
        Me.txtMensaje.TabIndex = 152
        Me.txtMensaje.Text = "hola"
        Me.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtMensaje.ThemeAuthor = "Narwin"
        Me.txtMensaje.ThemeName = "MetroLite"
        Me.txtMensaje.UseSystemPasswordChar = False
        Me.txtMensaje.WatermarkText = ""
        '
        'MetroSetDivider1
        '
        Me.MetroSetDivider1.Location = New System.Drawing.Point(282, 61)
        Me.MetroSetDivider1.Name = "MetroSetDivider1"
        Me.MetroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal
        Me.MetroSetDivider1.Size = New System.Drawing.Size(721, 4)
        Me.MetroSetDivider1.Style = MetroSet_UI.Design.Style.Light
        Me.MetroSetDivider1.StyleManager = Nothing
        Me.MetroSetDivider1.TabIndex = 153
        Me.MetroSetDivider1.Text = "MetroSetDivider1"
        Me.MetroSetDivider1.ThemeAuthor = "Narwin"
        Me.MetroSetDivider1.ThemeName = "MetroLite"
        Me.MetroSetDivider1.Thickness = 1
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icoFlechaAtras
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(282, 17)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(34, 33)
        Me.btnAtras.TabIndex = 7
        Me.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'pbEnviar
        '
        Me.pbEnviar.BackColor = System.Drawing.Color.White
        Me.pbEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEnviar.Image = Global.Vista.My.Resources.Resources.icons8_email_send_48
        Me.pbEnviar.Location = New System.Drawing.Point(922, 592)
        Me.pbEnviar.Name = "pbEnviar"
        Me.pbEnviar.Size = New System.Drawing.Size(41, 42)
        Me.pbEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEnviar.TabIndex = 9
        Me.pbEnviar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Vista.My.Resources.Resources.icons8_test_results_30
        Me.PictureBox2.Location = New System.Drawing.Point(319, 87)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(356, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 42)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'pbCancelar
        '
        Me.pbCancelar.Image = Global.Vista.My.Resources.Resources.icons8_delete_48px_11
        Me.pbCancelar.Location = New System.Drawing.Point(794, 91)
        Me.pbCancelar.Name = "pbCancelar"
        Me.pbCancelar.Size = New System.Drawing.Size(34, 28)
        Me.pbCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCancelar.TabIndex = 10
        Me.pbCancelar.TabStop = False
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1076, 656)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.MetroSetDivider1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblEscriba)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.pbEnviar)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvFinalizados)
        Me.Controls.Add(Me.dgvMisChats)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.pbCancelar)
        Me.Controls.Add(Me.Chat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChat"
        CType(Me.dgvMisChats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFinalizados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbEnviar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chat As FlowLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnAtras As Button
    Friend WithEvents pbEnviar As PictureBox
    Friend WithEvents pbCancelar As PictureBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnFinalizar As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblEscriba As Label
    Friend WithEvents dgvMisChats As DataGridView
    Friend WithEvents dgvFinalizados As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMensaje As MetroSet_UI.Controls.MetroSetTextBox
    Friend WithEvents MetroSetDivider1 As MetroSet_UI.Controls.MetroSetDivider
End Class
