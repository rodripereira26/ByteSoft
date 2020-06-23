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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlDescripcionPatologia = New System.Windows.Forms.Panel()
        Me.lblNombreDeLaPatologia = New System.Windows.Forms.Label()
        Me.pnlNombreDeLaPatologia = New System.Windows.Forms.Panel()
        Me.lblDescripcionPatologia = New System.Windows.Forms.Label()
        Me.pnlTxtRecomendaciones = New System.Windows.Forms.Panel()
        Me.lblRecomendaciones = New System.Windows.Forms.Label()
        Me.dgvSintomas = New System.Windows.Forms.DataGridView()
        Me.SINTOMAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlTituloPatologia.SuspendLayout()
        CType(Me.dgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTituloPatologia
        '
        Me.pnlTituloPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.pnlTituloPatologia.Controls.Add(Me.Label12)
        Me.pnlTituloPatologia.Controls.Add(Me.Label13)
        Me.pnlTituloPatologia.Controls.Add(Me.Label4)
        Me.pnlTituloPatologia.Location = New System.Drawing.Point(-1, 0)
        Me.pnlTituloPatologia.Name = "pnlTituloPatologia"
        Me.pnlTituloPatologia.Size = New System.Drawing.Size(1103, 77)
        Me.pnlTituloPatologia.TabIndex = 92
        '
        'Label12
        '
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(1027, -6)
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
        Me.Label13.Location = New System.Drawing.Point(1057, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 35)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "X"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(414, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(311, 57)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Registrar patología"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlDescripcionPatologia
        '
        Me.pnlDescripcionPatologia.BackColor = System.Drawing.Color.Black
        Me.pnlDescripcionPatologia.Location = New System.Drawing.Point(56, 414)
        Me.pnlDescripcionPatologia.Name = "pnlDescripcionPatologia"
        Me.pnlDescripcionPatologia.Size = New System.Drawing.Size(374, 2)
        Me.pnlDescripcionPatologia.TabIndex = 109
        '
        'lblNombreDeLaPatologia
        '
        Me.lblNombreDeLaPatologia.AutoSize = True
        Me.lblNombreDeLaPatologia.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDeLaPatologia.Location = New System.Drawing.Point(56, 143)
        Me.lblNombreDeLaPatologia.Name = "lblNombreDeLaPatologia"
        Me.lblNombreDeLaPatologia.Size = New System.Drawing.Size(262, 29)
        Me.lblNombreDeLaPatologia.TabIndex = 105
        Me.lblNombreDeLaPatologia.Text = "Nombre de la patologia"
        '
        'pnlNombreDeLaPatologia
        '
        Me.pnlNombreDeLaPatologia.BackColor = System.Drawing.Color.Black
        Me.pnlNombreDeLaPatologia.Location = New System.Drawing.Point(56, 214)
        Me.pnlNombreDeLaPatologia.Name = "pnlNombreDeLaPatologia"
        Me.pnlNombreDeLaPatologia.Size = New System.Drawing.Size(279, 2)
        Me.pnlNombreDeLaPatologia.TabIndex = 106
        '
        'lblDescripcionPatologia
        '
        Me.lblDescripcionPatologia.AutoSize = True
        Me.lblDescripcionPatologia.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionPatologia.Location = New System.Drawing.Point(56, 281)
        Me.lblDescripcionPatologia.Name = "lblDescripcionPatologia"
        Me.lblDescripcionPatologia.Size = New System.Drawing.Size(138, 29)
        Me.lblDescripcionPatologia.TabIndex = 107
        Me.lblDescripcionPatologia.Text = "Descripción"
        '
        'pnlTxtRecomendaciones
        '
        Me.pnlTxtRecomendaciones.BackColor = System.Drawing.Color.Black
        Me.pnlTxtRecomendaciones.Location = New System.Drawing.Point(56, 621)
        Me.pnlTxtRecomendaciones.Name = "pnlTxtRecomendaciones"
        Me.pnlTxtRecomendaciones.Size = New System.Drawing.Size(374, 2)
        Me.pnlTxtRecomendaciones.TabIndex = 112
        '
        'lblRecomendaciones
        '
        Me.lblRecomendaciones.AutoSize = True
        Me.lblRecomendaciones.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecomendaciones.Location = New System.Drawing.Point(56, 488)
        Me.lblRecomendaciones.Name = "lblRecomendaciones"
        Me.lblRecomendaciones.Size = New System.Drawing.Size(209, 29)
        Me.lblRecomendaciones.TabIndex = 110
        Me.lblRecomendaciones.Text = "Recomendaciones"
        '
        'dgvSintomas
        '
        Me.dgvSintomas.AllowUserToAddRows = False
        Me.dgvSintomas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dgvSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSintomas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSintomas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomas.ColumnHeadersVisible = False
        Me.dgvSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SINTOMAS})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSintomas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSintomas.Location = New System.Drawing.Point(481, 193)
        Me.dgvSintomas.MultiSelect = False
        Me.dgvSintomas.Name = "dgvSintomas"
        Me.dgvSintomas.ReadOnly = True
        Me.dgvSintomas.RowHeadersVisible = False
        Me.dgvSintomas.RowHeadersWidth = 51
        Me.dgvSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSintomas.Size = New System.Drawing.Size(214, 430)
        Me.dgvSintomas.TabIndex = 114
        '
        'SINTOMAS
        '
        Me.SINTOMAS.HeaderText = "Column1"
        Me.SINTOMAS.Name = "SINTOMAS"
        Me.SINTOMAS.ReadOnly = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView1.Location = New System.Drawing.Point(854, 193)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(214, 430)
        Me.DataGridView1.TabIndex = 115
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(823, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(277, 43)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Todos los síntomas"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(432, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 43)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Síntomas Seleccionados"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.Location = New System.Drawing.Point(56, 184)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(279, 24)
        Me.txtPrimerNombre.TabIndex = 119
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(701, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 141)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Arrastre Síntomas hacia la izquierda"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(56, 333)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(372, 66)
        Me.TextBox1.TabIndex = 121
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(56, 533)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(372, 70)
        Me.TextBox2.TabIndex = 122
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Icon = Nothing
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(481, 679)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(172, 36)
        Me.MaterialRaisedButton1.TabIndex = 127
        Me.MaterialRaisedButton1.Text = "Registrar patología"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'frmRegistrarPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 747)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrimerNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dgvSintomas)
        Me.Controls.Add(Me.pnlTxtRecomendaciones)
        Me.Controls.Add(Me.pnlDescripcionPatologia)
        Me.Controls.Add(Me.lblRecomendaciones)
        Me.Controls.Add(Me.lblNombreDeLaPatologia)
        Me.Controls.Add(Me.pnlNombreDeLaPatologia)
        Me.Controls.Add(Me.lblDescripcionPatologia)
        Me.Controls.Add(Me.pnlTituloPatologia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarPatologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlTituloPatologia.ResumeLayout(False)
        CType(Me.dgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTituloPatologia As Panel
    Friend WithEvents pnlDescripcionPatologia As Panel
    Friend WithEvents lblNombreDeLaPatologia As Label
    Friend WithEvents pnlNombreDeLaPatologia As Panel
    Friend WithEvents lblDescripcionPatologia As Label
    Friend WithEvents pnlTxtRecomendaciones As Panel
    Friend WithEvents lblRecomendaciones As Label
    Friend WithEvents dgvSintomas As DataGridView
    Friend WithEvents SINTOMAS As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrimerNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
End Class
