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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Chat = New System.Windows.Forms.FlowLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnVerSintomas = New MaterialSkin.Controls.MaterialFlatButton()
        Me.lblEscriba = New System.Windows.Forms.Label()
        Me.dgvMisChats = New System.Windows.Forms.DataGridView()
        Me.dgvFinalizados = New System.Windows.Forms.DataGridView()
        Me.pnlYo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFinalizar = New MaterialSkin.Controls.MaterialFlatButton()
        Me.divider = New MetroSet_UI.Controls.MetroSetDivider()
        Me.pnlWrapChat = New System.Windows.Forms.Panel()
        Me.pnlAcciones = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.txtMensaje = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.lblFinalizados = New System.Windows.Forms.Label()
        Me.pbVerSintomas = New System.Windows.Forms.PictureBox()
        Me.pbFinalizar = New System.Windows.Forms.PictureBox()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.pbEnviar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UcDiagnostico1 = New Vista.UCDiagnostico()
        CType(Me.dgvMisChats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFinalizados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlYo.SuspendLayout()
        Me.pnlWrapChat.SuspendLayout()
        Me.pnlAcciones.SuspendLayout()
        CType(Me.pbVerSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFinalizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEnviar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chat
        '
        Me.Chat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chat.AutoScroll = True
        Me.Chat.Location = New System.Drawing.Point(65, 121)
        Me.Chat.Name = "Chat"
        Me.Chat.Size = New System.Drawing.Size(646, 473)
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
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(173, 16)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(373, 33)
        Me.lblUsuario.TabIndex = 11
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVerSintomas
        '
        Me.btnVerSintomas.AutoSize = True
        Me.btnVerSintomas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVerSintomas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerSintomas.Depth = 0
        Me.btnVerSintomas.Icon = Nothing
        Me.btnVerSintomas.Location = New System.Drawing.Point(40, 6)
        Me.btnVerSintomas.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnVerSintomas.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnVerSintomas.Name = "btnVerSintomas"
        Me.btnVerSintomas.Primary = False
        Me.btnVerSintomas.Size = New System.Drawing.Size(223, 36)
        Me.btnVerSintomas.TabIndex = 12
        Me.btnVerSintomas.Text = "Ver síntomas y diagnóstico"
        Me.btnVerSintomas.UseVisualStyleBackColor = True
        '
        'lblEscriba
        '
        Me.lblEscriba.AutoSize = True
        Me.lblEscriba.BackColor = System.Drawing.Color.White
        Me.lblEscriba.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEscriba.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblEscriba.Location = New System.Drawing.Point(63, 615)
        Me.lblEscriba.Name = "lblEscriba"
        Me.lblEscriba.Size = New System.Drawing.Size(140, 19)
        Me.lblEscriba.TabIndex = 16
        Me.lblEscriba.Text = "Escriba un mensaje"
        '
        'dgvMisChats
        '
        Me.dgvMisChats.AllowUserToAddRows = False
        Me.dgvMisChats.AllowUserToDeleteRows = False
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle17.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvMisChats.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvMisChats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMisChats.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMisChats.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvMisChats.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMisChats.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvMisChats.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMisChats.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvMisChats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMisChats.ColumnHeadersVisible = False
        Me.dgvMisChats.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMisChats.DefaultCellStyle = DataGridViewCellStyle19
        Me.dgvMisChats.EnableHeadersVisualStyles = False
        Me.dgvMisChats.Location = New System.Drawing.Point(1, 100)
        Me.dgvMisChats.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvMisChats.MultiSelect = False
        Me.dgvMisChats.Name = "dgvMisChats"
        Me.dgvMisChats.ReadOnly = True
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMisChats.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvMisChats.RowHeadersVisible = False
        Me.dgvMisChats.RowHeadersWidth = 51
        Me.dgvMisChats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvMisChats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMisChats.Size = New System.Drawing.Size(246, 323)
        Me.dgvMisChats.TabIndex = 149
        '
        'dgvFinalizados
        '
        Me.dgvFinalizados.AllowUserToAddRows = False
        Me.dgvFinalizados.AllowUserToDeleteRows = False
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle21.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvFinalizados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.dgvFinalizados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFinalizados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvFinalizados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvFinalizados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFinalizados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvFinalizados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle22.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFinalizados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvFinalizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFinalizados.ColumnHeadersVisible = False
        Me.dgvFinalizados.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle23.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFinalizados.DefaultCellStyle = DataGridViewCellStyle23
        Me.dgvFinalizados.EnableHeadersVisualStyles = False
        Me.dgvFinalizados.Location = New System.Drawing.Point(1, 452)
        Me.dgvFinalizados.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvFinalizados.MultiSelect = False
        Me.dgvFinalizados.Name = "dgvFinalizados"
        Me.dgvFinalizados.ReadOnly = True
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFinalizados.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.dgvFinalizados.RowHeadersVisible = False
        Me.dgvFinalizados.RowHeadersWidth = 51
        Me.dgvFinalizados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvFinalizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFinalizados.Size = New System.Drawing.Size(246, 204)
        Me.dgvFinalizados.TabIndex = 150
        '
        'pnlYo
        '
        Me.pnlYo.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlYo.Controls.Add(Me.Label1)
        Me.pnlYo.Location = New System.Drawing.Point(0, 0)
        Me.pnlYo.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlYo.Name = "pnlYo"
        Me.pnlYo.Size = New System.Drawing.Size(246, 65)
        Me.pnlYo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.AutoSize = True
        Me.btnFinalizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizar.Depth = 0
        Me.btnFinalizar.Icon = Nothing
        Me.btnFinalizar.Location = New System.Drawing.Point(585, 77)
        Me.btnFinalizar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnFinalizar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Primary = False
        Me.btnFinalizar.Size = New System.Drawing.Size(128, 36)
        Me.btnFinalizar.TabIndex = 14
        Me.btnFinalizar.Text = "finalizar chat"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'divider
        '
        Me.divider.Location = New System.Drawing.Point(56, 61)
        Me.divider.Name = "divider"
        Me.divider.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal
        Me.divider.Size = New System.Drawing.Size(662, 4)
        Me.divider.Style = MetroSet_UI.Design.Style.Light
        Me.divider.StyleManager = Nothing
        Me.divider.TabIndex = 153
        Me.divider.Text = "MetroSetDivider1"
        Me.divider.ThemeAuthor = "Narwin"
        Me.divider.ThemeName = "MetroLite"
        Me.divider.Thickness = 1
        '
        'pnlWrapChat
        '
        Me.pnlWrapChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlWrapChat.Controls.Add(Me.pnlAcciones)
        Me.pnlWrapChat.Controls.Add(Me.btnCerrar)
        Me.pnlWrapChat.Controls.Add(Me.btnFinalizar)
        Me.pnlWrapChat.Controls.Add(Me.pbFinalizar)
        Me.pnlWrapChat.Controls.Add(Me.btnMinimizar)
        Me.pnlWrapChat.Controls.Add(Me.lblEscriba)
        Me.pnlWrapChat.Controls.Add(Me.txtMensaje)
        Me.pnlWrapChat.Controls.Add(Me.divider)
        Me.pnlWrapChat.Controls.Add(Me.btnAtras)
        Me.pnlWrapChat.Controls.Add(Me.pbEnviar)
        Me.pnlWrapChat.Controls.Add(Me.lblUsuario)
        Me.pnlWrapChat.Controls.Add(Me.PictureBox1)
        Me.pnlWrapChat.Controls.Add(Me.Chat)
        Me.pnlWrapChat.Location = New System.Drawing.Point(247, 0)
        Me.pnlWrapChat.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlWrapChat.Name = "pnlWrapChat"
        Me.pnlWrapChat.Size = New System.Drawing.Size(766, 656)
        Me.pnlWrapChat.TabIndex = 154
        '
        'pnlAcciones
        '
        Me.pnlAcciones.AutoSize = True
        Me.pnlAcciones.Controls.Add(Me.btnVerSintomas)
        Me.pnlAcciones.Controls.Add(Me.pbVerSintomas)
        Me.pnlAcciones.Location = New System.Drawing.Point(67, 71)
        Me.pnlAcciones.Name = "pnlAcciones"
        Me.pnlAcciones.Size = New System.Drawing.Size(267, 48)
        Me.pnlAcciones.TabIndex = 156
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnCerrar.Location = New System.Drawing.Point(732, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(34, 33)
        Me.btnCerrar.TabIndex = 154
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnMinimizar.Location = New System.Drawing.Point(695, -3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(34, 33)
        Me.btnMinimizar.TabIndex = 155
        Me.btnMinimizar.Text = "_"
        Me.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'txtMensaje
        '
        Me.txtMensaje.Depth = 0
        Me.txtMensaje.Hint = ""
        Me.txtMensaje.Location = New System.Drawing.Point(67, 615)
        Me.txtMensaje.MaxLength = 32767
        Me.txtMensaje.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMensaje.SelectedText = ""
        Me.txtMensaje.SelectionLength = 0
        Me.txtMensaje.SelectionStart = 0
        Me.txtMensaje.Size = New System.Drawing.Size(585, 23)
        Me.txtMensaje.TabIndex = 154
        Me.txtMensaje.TabStop = False
        Me.txtMensaje.UseSystemPasswordChar = False
        '
        'lblGeneral
        '
        Me.lblGeneral.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblGeneral.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneral.Location = New System.Drawing.Point(0, 65)
        Me.lblGeneral.Margin = New System.Windows.Forms.Padding(0)
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.Size = New System.Drawing.Size(246, 35)
        Me.lblGeneral.TabIndex = 1
        Me.lblGeneral.Text = "GENERAL"
        Me.lblGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalizados
        '
        Me.lblFinalizados.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblFinalizados.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalizados.Location = New System.Drawing.Point(1, 423)
        Me.lblFinalizados.Margin = New System.Windows.Forms.Padding(0)
        Me.lblFinalizados.Name = "lblFinalizados"
        Me.lblFinalizados.Size = New System.Drawing.Size(246, 29)
        Me.lblFinalizados.TabIndex = 155
        Me.lblFinalizados.Text = "FINALIZADOS"
        Me.lblFinalizados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbVerSintomas
        '
        Me.pbVerSintomas.Image = Global.Vista.My.Resources.Resources.icons8_test_results_30
        Me.pbVerSintomas.Location = New System.Drawing.Point(3, 9)
        Me.pbVerSintomas.Name = "pbVerSintomas"
        Me.pbVerSintomas.Size = New System.Drawing.Size(30, 30)
        Me.pbVerSintomas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbVerSintomas.TabIndex = 15
        Me.pbVerSintomas.TabStop = False
        '
        'pbFinalizar
        '
        Me.pbFinalizar.Image = Global.Vista.My.Resources.Resources.icons8_delete_48px_11
        Me.pbFinalizar.Location = New System.Drawing.Point(544, 80)
        Me.pbFinalizar.Name = "pbFinalizar"
        Me.pbFinalizar.Size = New System.Drawing.Size(34, 28)
        Me.pbFinalizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFinalizar.TabIndex = 10
        Me.pbFinalizar.TabStop = False
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icoFlechaAtras
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(13, 18)
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
        Me.pbEnviar.Location = New System.Drawing.Point(658, 602)
        Me.pbEnviar.Name = "pbEnviar"
        Me.pbEnviar.Size = New System.Drawing.Size(41, 42)
        Me.pbEnviar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEnviar.TabIndex = 9
        Me.pbEnviar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(90, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 42)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'UcDiagnostico1
        '
        Me.UcDiagnostico1.Location = New System.Drawing.Point(315, 117)
        Me.UcDiagnostico1.Name = "UcDiagnostico1"
        Me.UcDiagnostico1.Size = New System.Drawing.Size(417, 516)
        Me.UcDiagnostico1.TabIndex = 157
        '
        'frmChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1014, 656)
        Me.Controls.Add(Me.UcDiagnostico1)
        Me.Controls.Add(Me.lblFinalizados)
        Me.Controls.Add(Me.lblGeneral)
        Me.Controls.Add(Me.pnlYo)
        Me.Controls.Add(Me.dgvFinalizados)
        Me.Controls.Add(Me.dgvMisChats)
        Me.Controls.Add(Me.pnlWrapChat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmChat"
        CType(Me.dgvMisChats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFinalizados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlYo.ResumeLayout(False)
        Me.pnlWrapChat.ResumeLayout(False)
        Me.pnlWrapChat.PerformLayout()
        Me.pnlAcciones.ResumeLayout(False)
        Me.pnlAcciones.PerformLayout()
        CType(Me.pbVerSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFinalizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEnviar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chat As FlowLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents btnAtras As Button
    Friend WithEvents pbEnviar As PictureBox
    Friend WithEvents pbFinalizar As PictureBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents btnVerSintomas As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnFinalizar As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents pbVerSintomas As PictureBox
    Friend WithEvents lblEscriba As Label
    Friend WithEvents dgvMisChats As DataGridView
    Friend WithEvents dgvFinalizados As DataGridView
    Friend WithEvents pnlYo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents divider As MetroSet_UI.Controls.MetroSetDivider
    Friend WithEvents pnlWrapChat As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents txtMensaje As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents pnlAcciones As Panel
    Friend WithEvents lblGeneral As Label
    Friend WithEvents lblFinalizados As Label
    Friend WithEvents UcDiagnostico1 As UCDiagnostico
End Class
