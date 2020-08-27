<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoChat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvListadoChat = New System.Windows.Forms.DataGridView()
        Me.pnlTituloPatologia = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.brnActualizar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblSolicitudesDeChat = New System.Windows.Forms.Label()
        Me.btnVerMisChat = New System.Windows.Forms.Button()
        CType(Me.dgvListadoChat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTituloPatologia.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListadoChat
        '
        Me.dgvListadoChat.AllowUserToAddRows = False
        Me.dgvListadoChat.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(30)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListadoChat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvListadoChat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListadoChat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoChat.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoChat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListadoChat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvListadoChat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoChat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvListadoChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoChat.ColumnHeadersVisible = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoChat.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvListadoChat.EnableHeadersVisualStyles = False
        Me.dgvListadoChat.Location = New System.Drawing.Point(65, 174)
        Me.dgvListadoChat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvListadoChat.MultiSelect = False
        Me.dgvListadoChat.Name = "dgvListadoChat"
        Me.dgvListadoChat.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoChat.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvListadoChat.RowHeadersVisible = False
        Me.dgvListadoChat.RowHeadersWidth = 51
        Me.dgvListadoChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListadoChat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoChat.Size = New System.Drawing.Size(444, 592)
        Me.dgvListadoChat.TabIndex = 152
        '
        'pnlTituloPatologia
        '
        Me.pnlTituloPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTituloPatologia.Controls.Add(Me.btnAtras)
        Me.pnlTituloPatologia.Controls.Add(Me.lblSolicitudesDeChat)
        Me.pnlTituloPatologia.Controls.Add(Me.brnActualizar)
        Me.pnlTituloPatologia.Controls.Add(Me.btnMinimizar)
        Me.pnlTituloPatologia.Controls.Add(Me.btnCerrar)
        Me.pnlTituloPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituloPatologia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTituloPatologia.Name = "pnlTituloPatologia"
        Me.pnlTituloPatologia.Size = New System.Drawing.Size(1341, 98)
        Me.pnlTituloPatologia.TabIndex = 153
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(1296, 0)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 41)
        Me.btnCerrar.TabIndex = 156
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnMinimizar.ForeColor = System.Drawing.Color.White
        Me.btnMinimizar.Location = New System.Drawing.Point(1247, 0)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(45, 41)
        Me.btnMinimizar.TabIndex = 157
        Me.btnMinimizar.Text = "_"
        Me.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'brnActualizar
        '
        Me.brnActualizar.FlatAppearance.BorderSize = 0
        Me.brnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brnActualizar.Image = Global.Vista.My.Resources.Resources.icons8_refresh_20px
        Me.brnActualizar.Location = New System.Drawing.Point(1180, 0)
        Me.brnActualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.brnActualizar.Name = "brnActualizar"
        Me.brnActualizar.Size = New System.Drawing.Size(53, 43)
        Me.brnActualizar.TabIndex = 150
        Me.brnActualizar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icons8_left_32px
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(12, 23)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAtras.Size = New System.Drawing.Size(65, 39)
        Me.btnAtras.TabIndex = 153
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblSolicitudesDeChat
        '
        Me.lblSolicitudesDeChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSolicitudesDeChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolicitudesDeChat.ForeColor = System.Drawing.Color.White
        Me.lblSolicitudesDeChat.Location = New System.Drawing.Point(407, 20)
        Me.lblSolicitudesDeChat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSolicitudesDeChat.Name = "lblSolicitudesDeChat"
        Me.lblSolicitudesDeChat.Size = New System.Drawing.Size(528, 55)
        Me.lblSolicitudesDeChat.TabIndex = 26
        Me.lblSolicitudesDeChat.Text = "SOLICITUDES DE CHAT"
        Me.lblSolicitudesDeChat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVerMisChat
        '
        Me.btnVerMisChat.FlatAppearance.BorderSize = 0
        Me.btnVerMisChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerMisChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerMisChat.Image = Global.Vista.My.Resources.Resources.icons8_right_arrow_64
        Me.btnVerMisChat.Location = New System.Drawing.Point(860, 393)
        Me.btnVerMisChat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVerMisChat.Name = "btnVerMisChat"
        Me.btnVerMisChat.Size = New System.Drawing.Size(315, 71)
        Me.btnVerMisChat.TabIndex = 154
        Me.btnVerMisChat.Text = "Ver mis chats"
        Me.btnVerMisChat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerMisChat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnVerMisChat.UseVisualStyleBackColor = True
        '
        'frmListadoChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1341, 794)
        Me.Controls.Add(Me.pnlTituloPatologia)
        Me.Controls.Add(Me.dgvListadoChat)
        Me.Controls.Add(Me.btnVerMisChat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmListadoChat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListadoChat"
        CType(Me.dgvListadoChat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTituloPatologia.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVerMisChat As Button
    Friend WithEvents dgvListadoChat As DataGridView
    Friend WithEvents pnlTituloPatologia As Panel
    Friend WithEvents brnActualizar As Button
    Friend WithEvents btnAtras As Button
    Friend WithEvents lblSolicitudesDeChat As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
End Class
