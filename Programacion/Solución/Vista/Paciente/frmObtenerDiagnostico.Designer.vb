<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmObtenerDiagnostico
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTituloPatologia = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblPosibles = New System.Windows.Forms.Label()
        Me.dgvPosiblesDiagnosticos = New System.Windows.Forms.DataGridView()
        Me.btnSolicitarChat = New MaterialSkin.Controls.MaterialFlatButton()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.ucRespuesta = New Vista.UserControl1()
        Me.pnlTituloPatologia.SuspendLayout()
        CType(Me.dgvPosiblesDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTituloPatologia
        '
        Me.pnlTituloPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTituloPatologia.Controls.Add(Me.btnAtras)
        Me.pnlTituloPatologia.Controls.Add(Me.lblPosibles)
        Me.pnlTituloPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituloPatologia.Name = "pnlTituloPatologia"
        Me.pnlTituloPatologia.Size = New System.Drawing.Size(1004, 77)
        Me.pnlTituloPatologia.TabIndex = 147
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icons8_left_32px
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(9, 19)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Padding = New System.Windows.Forms.Padding(3)
        Me.btnAtras.Size = New System.Drawing.Size(49, 32)
        Me.btnAtras.TabIndex = 153
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblPosibles
        '
        Me.lblPosibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPosibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosibles.ForeColor = System.Drawing.Color.White
        Me.lblPosibles.Location = New System.Drawing.Point(305, 16)
        Me.lblPosibles.Name = "lblPosibles"
        Me.lblPosibles.Size = New System.Drawing.Size(396, 45)
        Me.lblPosibles.TabIndex = 26
        Me.lblPosibles.Text = "POSIBLES DIAGNÓSTICOS"
        Me.lblPosibles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPosiblesDiagnosticos
        '
        Me.dgvPosiblesDiagnosticos.AllowUserToAddRows = False
        Me.dgvPosiblesDiagnosticos.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(30)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPosiblesDiagnosticos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPosiblesDiagnosticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPosiblesDiagnosticos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPosiblesDiagnosticos.BackgroundColor = System.Drawing.Color.White
        Me.dgvPosiblesDiagnosticos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPosiblesDiagnosticos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPosiblesDiagnosticos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPosiblesDiagnosticos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPosiblesDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPosiblesDiagnosticos.ColumnHeadersVisible = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(30)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPosiblesDiagnosticos.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvPosiblesDiagnosticos.EnableHeadersVisualStyles = False
        Me.dgvPosiblesDiagnosticos.Location = New System.Drawing.Point(3, 77)
        Me.dgvPosiblesDiagnosticos.MultiSelect = False
        Me.dgvPosiblesDiagnosticos.Name = "dgvPosiblesDiagnosticos"
        Me.dgvPosiblesDiagnosticos.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPosiblesDiagnosticos.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvPosiblesDiagnosticos.RowHeadersVisible = False
        Me.dgvPosiblesDiagnosticos.RowHeadersWidth = 51
        Me.dgvPosiblesDiagnosticos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPosiblesDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPosiblesDiagnosticos.Size = New System.Drawing.Size(998, 541)
        Me.dgvPosiblesDiagnosticos.TabIndex = 146
        '
        'btnSolicitarChat
        '
        Me.btnSolicitarChat.AutoSize = True
        Me.btnSolicitarChat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSolicitarChat.Depth = 0
        Me.btnSolicitarChat.Icon = Nothing
        Me.btnSolicitarChat.Location = New System.Drawing.Point(393, 636)
        Me.btnSolicitarChat.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSolicitarChat.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSolicitarChat.Name = "btnSolicitarChat"
        Me.btnSolicitarChat.Primary = False
        Me.btnSolicitarChat.Size = New System.Drawing.Size(215, 36)
        Me.btnSolicitarChat.TabIndex = 149
        Me.btnSolicitarChat.Text = "solicitar chat con médico"
        Me.btnSolicitarChat.UseVisualStyleBackColor = True
        '
        'pnlContenedor
        '
        Me.pnlContenedor.Controls.Add(Me.pnlTituloPatologia)
        Me.pnlContenedor.Controls.Add(Me.dgvPosiblesDiagnosticos)
        Me.pnlContenedor.Controls.Add(Me.btnSolicitarChat)
        Me.pnlContenedor.Controls.Add(Me.ucRespuesta)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1004, 677)
        Me.pnlContenedor.TabIndex = 150
        '
        'ucRespuesta
        '
        Me.ucRespuesta.BackColor = System.Drawing.Color.White
        Me.ucRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucRespuesta.Location = New System.Drawing.Point(200, 77)
        Me.ucRespuesta.Margin = New System.Windows.Forms.Padding(4)
        Me.ucRespuesta.Name = "ucRespuesta"
        Me.ucRespuesta.Size = New System.Drawing.Size(607, 541)
        Me.ucRespuesta.TabIndex = 148
        Me.ucRespuesta.Visible = False
        '
        'frmObtenerDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1004, 677)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmObtenerDiagnostico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ObtenerDiagnóstico"
        Me.pnlTituloPatologia.ResumeLayout(False)
        CType(Me.dgvPosiblesDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTituloPatologia As Panel
    Friend WithEvents lblPosibles As Label
    Friend WithEvents dgvPosiblesDiagnosticos As DataGridView
    Friend WithEvents ucRespuesta As UserControl1
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSolicitarChat As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents pnlContenedor As Panel
End Class
