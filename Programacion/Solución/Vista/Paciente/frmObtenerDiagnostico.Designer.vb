<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObtenerDiagnostico
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTituloPatologia = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblPosibles = New System.Windows.Forms.Label()
        Me.dgvPosiblesDiagnosticos = New System.Windows.Forms.DataGridView()
        Me.btnSolicitarChat = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ucRespuesta = New Vista.UserControl1()
        Me.pnlTituloPatologia.SuspendLayout()
        CType(Me.dgvPosiblesDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTituloPatologia
        '
        Me.pnlTituloPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTituloPatologia.Controls.Add(Me.btnAtras)
        Me.pnlTituloPatologia.Controls.Add(Me.lblPosibles)
        Me.pnlTituloPatologia.Controls.Add(Me.btnMinimizar)
        Me.pnlTituloPatologia.Controls.Add(Me.btnCerrar)
        Me.pnlTituloPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituloPatologia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTituloPatologia.Name = "pnlTituloPatologia"
        Me.pnlTituloPatologia.Size = New System.Drawing.Size(1336, 95)
        Me.pnlTituloPatologia.TabIndex = 147
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(1292, 0)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 41)
        Me.btnCerrar.TabIndex = 158
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
        Me.btnMinimizar.Location = New System.Drawing.Point(1243, 0)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(45, 41)
        Me.btnMinimizar.TabIndex = 159
        Me.btnMinimizar.Text = "_"
        Me.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnMinimizar.UseVisualStyleBackColor = True
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
        'lblPosibles
        '
        Me.lblPosibles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPosibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosibles.ForeColor = System.Drawing.Color.White
        Me.lblPosibles.Location = New System.Drawing.Point(407, 20)
        Me.lblPosibles.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPosibles.Name = "lblPosibles"
        Me.lblPosibles.Size = New System.Drawing.Size(528, 55)
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
        Me.dgvPosiblesDiagnosticos.Location = New System.Drawing.Point(4, 95)
        Me.dgvPosiblesDiagnosticos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.dgvPosiblesDiagnosticos.Size = New System.Drawing.Size(1331, 666)
        Me.dgvPosiblesDiagnosticos.TabIndex = 146
        '
        'btnSolicitarChat
        '
        Me.btnSolicitarChat.AutoSize = True
        Me.btnSolicitarChat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSolicitarChat.Depth = 0
        Me.btnSolicitarChat.Icon = Nothing
        Me.btnSolicitarChat.Location = New System.Drawing.Point(524, 783)
        Me.btnSolicitarChat.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnSolicitarChat.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSolicitarChat.Name = "btnSolicitarChat"
        Me.btnSolicitarChat.Primary = False
        Me.btnSolicitarChat.Size = New System.Drawing.Size(264, 36)
        Me.btnSolicitarChat.TabIndex = 149
        Me.btnSolicitarChat.Text = "solicitar chat con médico"
        Me.btnSolicitarChat.UseVisualStyleBackColor = True
        '
        'ucRespuesta
        '
        Me.ucRespuesta.BackColor = System.Drawing.Color.White
        Me.ucRespuesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ucRespuesta.Location = New System.Drawing.Point(267, 95)
        Me.ucRespuesta.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucRespuesta.Name = "ucRespuesta"
        Me.ucRespuesta.Size = New System.Drawing.Size(809, 665)
        Me.ucRespuesta.TabIndex = 148
        Me.ucRespuesta.Visible = False
        '
        'frmObtenerDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1339, 833)
        Me.Controls.Add(Me.pnlTituloPatologia)
        Me.Controls.Add(Me.ucRespuesta)
        Me.Controls.Add(Me.btnSolicitarChat)
        Me.Controls.Add(Me.dgvPosiblesDiagnosticos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmObtenerDiagnostico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ObtenerDiagnóstico"
        Me.pnlTituloPatologia.ResumeLayout(False)
        CType(Me.dgvPosiblesDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTituloPatologia As Panel
    Friend WithEvents lblPosibles As Label
    Friend WithEvents dgvPosiblesDiagnosticos As DataGridView
    Friend WithEvents ucRespuesta As UserControl1
    Friend WithEvents btnAtras As Button
    Friend WithEvents btnSolicitarChat As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
End Class
