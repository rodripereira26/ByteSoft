<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_de_patologías
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvEmp = New System.Windows.Forms.DataGridView()
        Me.DiagnosticoPrimario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recomendaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Derivacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDelMedico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHistorialDeAutoconsulta = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lblHistorialDeAutoconsulta = New System.Windows.Forms.Label()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHistorialDeAutoconsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmp
        '
        Me.dgvEmp.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(4, 10, 4, 10)
        Me.dgvEmp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvEmp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvEmp.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4, 12, 4, 12)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmp.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DiagnosticoPrimario, Me.Recomendaciones, Me.Derivacion, Me.Fecha, Me.NombreDelMedico})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(4, 10, 4, 10)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmp.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmp.EnableHeadersVisualStyles = False
        Me.dgvEmp.Location = New System.Drawing.Point(0, 130)
        Me.dgvEmp.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEmp.MultiSelect = False
        Me.dgvEmp.Name = "dgvEmp"
        Me.dgvEmp.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmp.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEmp.RowHeadersVisible = False
        Me.dgvEmp.RowHeadersWidth = 51
        Me.dgvEmp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvEmp.Size = New System.Drawing.Size(1345, 681)
        Me.dgvEmp.TabIndex = 58
        '
        'DiagnosticoPrimario
        '
        Me.DiagnosticoPrimario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DiagnosticoPrimario.HeaderText = "Diagnóstico primario"
        Me.DiagnosticoPrimario.MinimumWidth = 6
        Me.DiagnosticoPrimario.Name = "DiagnosticoPrimario"
        Me.DiagnosticoPrimario.ReadOnly = True
        '
        'Recomendaciones
        '
        Me.Recomendaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Recomendaciones.HeaderText = "Recomendaciones"
        Me.Recomendaciones.MinimumWidth = 6
        Me.Recomendaciones.Name = "Recomendaciones"
        Me.Recomendaciones.ReadOnly = True
        '
        'Derivacion
        '
        Me.Derivacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Derivacion.HeaderText = "Derivación"
        Me.Derivacion.MinimumWidth = 6
        Me.Derivacion.Name = "Derivacion"
        Me.Derivacion.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'NombreDelMedico
        '
        Me.NombreDelMedico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NombreDelMedico.HeaderText = "Nombre del médico"
        Me.NombreDelMedico.MinimumWidth = 6
        Me.NombreDelMedico.Name = "NombreDelMedico"
        Me.NombreDelMedico.ReadOnly = True
        '
        'pnlHistorialDeAutoconsulta
        '
        Me.pnlHistorialDeAutoconsulta.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.pnlHistorialDeAutoconsulta.Controls.Add(Me.lbl1)
        Me.pnlHistorialDeAutoconsulta.Controls.Add(Me.lbl2)
        Me.pnlHistorialDeAutoconsulta.Controls.Add(Me.lbl3)
        Me.pnlHistorialDeAutoconsulta.Controls.Add(Me.lbl4)
        Me.pnlHistorialDeAutoconsulta.Controls.Add(Me.lblHistorialDeAutoconsulta)
        Me.pnlHistorialDeAutoconsulta.Location = New System.Drawing.Point(0, 0)
        Me.pnlHistorialDeAutoconsulta.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlHistorialDeAutoconsulta.Name = "pnlHistorialDeAutoconsulta"
        Me.pnlHistorialDeAutoconsulta.Size = New System.Drawing.Size(1345, 130)
        Me.pnlHistorialDeAutoconsulta.TabIndex = 117
        '
        'lbl1
        '
        Me.lbl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(1472, -7)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(32, 43)
        Me.lbl1.TabIndex = 26
        Me.lbl1.Text = "_"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(1512, 0)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(57, 43)
        Me.lbl2.TabIndex = 25
        Me.lbl2.Text = "X"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl3
        '
        Me.lbl3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(1663, -7)
        Me.lbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(32, 43)
        Me.lbl3.TabIndex = 24
        Me.lbl3.Text = "_"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl4
        '
        Me.lbl4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.White
        Me.lbl4.Location = New System.Drawing.Point(1703, 0)
        Me.lbl4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(57, 43)
        Me.lbl4.TabIndex = 23
        Me.lbl4.Text = "X"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHistorialDeAutoconsulta
        '
        Me.lblHistorialDeAutoconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHistorialDeAutoconsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistorialDeAutoconsulta.ForeColor = System.Drawing.Color.White
        Me.lblHistorialDeAutoconsulta.Location = New System.Drawing.Point(412, 26)
        Me.lblHistorialDeAutoconsulta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHistorialDeAutoconsulta.Name = "lblHistorialDeAutoconsulta"
        Me.lblHistorialDeAutoconsulta.Size = New System.Drawing.Size(520, 70)
        Me.lblHistorialDeAutoconsulta.TabIndex = 4
        Me.lblHistorialDeAutoconsulta.Text = "Historial de autoconsulta"
        Me.lblHistorialDeAutoconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Historial_de_patologías
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 820)
        Me.Controls.Add(Me.pnlHistorialDeAutoconsulta)
        Me.Controls.Add(Me.dgvEmp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Historial_de_patologías"
        Me.Text = "Historial_de_patologías"
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHistorialDeAutoconsulta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvEmp As DataGridView
    Friend WithEvents DiagnosticoPrimario As DataGridViewTextBoxColumn
    Friend WithEvents Recomendaciones As DataGridViewTextBoxColumn
    Friend WithEvents Derivacion As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents NombreDelMedico As DataGridViewTextBoxColumn
    Friend WithEvents pnlHistorialDeAutoconsulta As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lblHistorialDeAutoconsulta As Label
End Class
