<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCPatologia
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.dgvSintomas = New System.Windows.Forms.DataGridView()
        Me.MISintoma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.lblNomSin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.TextBox()
        Me.scroll = New Guna.UI.WinForms.GunaVScrollBar()
        CType(Me.dgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(302, 26)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(115, 25)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Síntomas de"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvSintomas
        '
        Me.dgvSintomas.AllowDrop = True
        Me.dgvSintomas.AllowUserToAddRows = False
        Me.dgvSintomas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.dgvSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSintomas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.dgvSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomas.ColumnHeadersVisible = False
        Me.dgvSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MISintoma})
        Me.dgvSintomas.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(45, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSintomas.Location = New System.Drawing.Point(335, 121)
        Me.dgvSintomas.MultiSelect = False
        Me.dgvSintomas.Name = "dgvSintomas"
        Me.dgvSintomas.ReadOnly = True
        Me.dgvSintomas.RowHeadersVisible = False
        Me.dgvSintomas.RowHeadersWidth = 51
        Me.dgvSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSintomas.Size = New System.Drawing.Size(195, 328)
        Me.dgvSintomas.TabIndex = 160
        '
        'MISintoma
        '
        Me.MISintoma.HeaderText = "Column1"
        Me.MISintoma.MinimumWidth = 6
        Me.MISintoma.Name = "MISintoma"
        Me.MISintoma.ReadOnly = True
        '
        'btnAtras
        '
        Me.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnAtras.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Silver
        Me.btnAtras.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.btnAtras.IconColor = System.Drawing.Color.Silver
        Me.btnAtras.IconSize = 20
        Me.btnAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtras.Location = New System.Drawing.Point(22, 22)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Rotation = 0R
        Me.btnAtras.Size = New System.Drawing.Size(117, 37)
        Me.btnAtras.TabIndex = 232
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblNomSin
        '
        Me.lblNomSin.AutoSize = True
        Me.lblNomSin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomSin.Location = New System.Drawing.Point(23, 121)
        Me.lblNomSin.Name = "lblNomSin"
        Me.lblNomSin.Size = New System.Drawing.Size(79, 25)
        Me.lblNomSin.TabIndex = 234
        Me.lblNomSin.Text = "¿Qué es"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(22, 182)
        Me.Label1.Multiline = True
        Me.Label1.Name = "Label1"
        Me.Label1.ReadOnly = True
        Me.Label1.Size = New System.Drawing.Size(250, 255)
        Me.Label1.TabIndex = 235
        '
        'scroll
        '
        Me.scroll.LargeChange = 10
        Me.scroll.Location = New System.Drawing.Point(547, 150)
        Me.scroll.Maximum = 100
        Me.scroll.Name = "scroll"
        Me.scroll.ScrollIdleColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.scroll.Size = New System.Drawing.Size(5, 200)
        Me.scroll.TabIndex = 237
        Me.scroll.ThumbColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.scroll.ThumbHoverColor = System.Drawing.Color.Gray
        Me.scroll.ThumbPressedColor = System.Drawing.Color.DarkGray
        '
        'UCPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.scroll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNomSin)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.dgvSintomas)
        Me.Controls.Add(Me.lblTitulo)
        Me.ForeColor = System.Drawing.Color.Silver
        Me.Name = "UCPatologia"
        Me.Size = New System.Drawing.Size(580, 484)
        CType(Me.dgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As Label
    Friend WithEvents dgvSintomas As DataGridView
    Friend WithEvents MISintoma As DataGridViewTextBoxColumn
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents lblNomSin As Label
    Friend WithEvents Label1 As TextBox
    Friend WithEvents scroll As Guna.UI.WinForms.GunaVScrollBar
End Class
