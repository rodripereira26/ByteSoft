﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.dgvMisSintomas = New System.Windows.Forms.DataGridView()
        Me.SINTOMAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTodos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNomPat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescPat = New System.Windows.Forms.TextBox()
        Me.txtRecPat = New System.Windows.Forms.TextBox()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cb1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.cb3 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.cb2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnlTituloPatologia.SuspendLayout()
        CType(Me.dgvMisSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTodos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlDescripcionPatologia.Location = New System.Drawing.Point(49, 391)
        Me.pnlDescripcionPatologia.Name = "pnlDescripcionPatologia"
        Me.pnlDescripcionPatologia.Size = New System.Drawing.Size(374, 2)
        Me.pnlDescripcionPatologia.TabIndex = 109
        '
        'lblNombreDeLaPatologia
        '
        Me.lblNombreDeLaPatologia.AutoSize = True
        Me.lblNombreDeLaPatologia.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDeLaPatologia.Location = New System.Drawing.Point(49, 120)
        Me.lblNombreDeLaPatologia.Name = "lblNombreDeLaPatologia"
        Me.lblNombreDeLaPatologia.Size = New System.Drawing.Size(262, 29)
        Me.lblNombreDeLaPatologia.TabIndex = 105
        Me.lblNombreDeLaPatologia.Text = "Nombre de la patologia"
        '
        'pnlNombreDeLaPatologia
        '
        Me.pnlNombreDeLaPatologia.BackColor = System.Drawing.Color.Black
        Me.pnlNombreDeLaPatologia.Location = New System.Drawing.Point(49, 191)
        Me.pnlNombreDeLaPatologia.Name = "pnlNombreDeLaPatologia"
        Me.pnlNombreDeLaPatologia.Size = New System.Drawing.Size(279, 2)
        Me.pnlNombreDeLaPatologia.TabIndex = 106
        '
        'lblDescripcionPatologia
        '
        Me.lblDescripcionPatologia.AutoSize = True
        Me.lblDescripcionPatologia.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionPatologia.Location = New System.Drawing.Point(49, 258)
        Me.lblDescripcionPatologia.Name = "lblDescripcionPatologia"
        Me.lblDescripcionPatologia.Size = New System.Drawing.Size(138, 29)
        Me.lblDescripcionPatologia.TabIndex = 107
        Me.lblDescripcionPatologia.Text = "Descripción"
        '
        'pnlTxtRecomendaciones
        '
        Me.pnlTxtRecomendaciones.BackColor = System.Drawing.Color.Black
        Me.pnlTxtRecomendaciones.Location = New System.Drawing.Point(47, 555)
        Me.pnlTxtRecomendaciones.Name = "pnlTxtRecomendaciones"
        Me.pnlTxtRecomendaciones.Size = New System.Drawing.Size(374, 2)
        Me.pnlTxtRecomendaciones.TabIndex = 112
        '
        'lblRecomendaciones
        '
        Me.lblRecomendaciones.AutoSize = True
        Me.lblRecomendaciones.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecomendaciones.Location = New System.Drawing.Point(47, 422)
        Me.lblRecomendaciones.Name = "lblRecomendaciones"
        Me.lblRecomendaciones.Size = New System.Drawing.Size(209, 29)
        Me.lblRecomendaciones.TabIndex = 110
        Me.lblRecomendaciones.Text = "Recomendaciones"
        '
        'dgvMisSintomas
        '
        Me.dgvMisSintomas.AllowDrop = True
        Me.dgvMisSintomas.AllowUserToAddRows = False
        Me.dgvMisSintomas.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dgvMisSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvMisSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMisSintomas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvMisSintomas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvMisSintomas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvMisSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMisSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvMisSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMisSintomas.ColumnHeadersVisible = False
        Me.dgvMisSintomas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SINTOMAS})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMisSintomas.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvMisSintomas.Location = New System.Drawing.Point(474, 170)
        Me.dgvMisSintomas.MultiSelect = False
        Me.dgvMisSintomas.Name = "dgvMisSintomas"
        Me.dgvMisSintomas.ReadOnly = True
        Me.dgvMisSintomas.RowHeadersVisible = False
        Me.dgvMisSintomas.RowHeadersWidth = 51
        Me.dgvMisSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMisSintomas.Size = New System.Drawing.Size(214, 430)
        Me.dgvMisSintomas.TabIndex = 114
        '
        'SINTOMAS
        '
        Me.SINTOMAS.HeaderText = "Column1"
        Me.SINTOMAS.Name = "SINTOMAS"
        Me.SINTOMAS.ReadOnly = True
        '
        'dgvTodos
        '
        Me.dgvTodos.AllowUserToAddRows = False
        Me.dgvTodos.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.dgvTodos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvTodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTodos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTodos.BackgroundColor = System.Drawing.Color.White
        Me.dgvTodos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTodos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTodos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodos.ColumnHeadersVisible = False
        Me.dgvTodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTodos.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvTodos.Location = New System.Drawing.Point(847, 170)
        Me.dgvTodos.MultiSelect = False
        Me.dgvTodos.Name = "dgvTodos"
        Me.dgvTodos.ReadOnly = True
        Me.dgvTodos.RowHeadersVisible = False
        Me.dgvTodos.RowHeadersWidth = 51
        Me.dgvTodos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTodos.Size = New System.Drawing.Size(214, 430)
        Me.dgvTodos.TabIndex = 115
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
        Me.Label5.Location = New System.Drawing.Point(816, 103)
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
        Me.Label1.Location = New System.Drawing.Point(425, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 43)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Síntomas Seleccionados"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNomPat
        '
        Me.txtNomPat.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtNomPat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomPat.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomPat.Location = New System.Drawing.Point(49, 161)
        Me.txtNomPat.Name = "txtNomPat"
        Me.txtNomPat.Size = New System.Drawing.Size(279, 24)
        Me.txtNomPat.TabIndex = 119
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(694, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 141)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Arrastre Síntomas hacia la izquierda"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescPat
        '
        Me.txtDescPat.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtDescPat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescPat.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescPat.Location = New System.Drawing.Point(49, 310)
        Me.txtDescPat.Multiline = True
        Me.txtDescPat.Name = "txtDescPat"
        Me.txtDescPat.Size = New System.Drawing.Size(372, 66)
        Me.txtDescPat.TabIndex = 121
        '
        'txtRecPat
        '
        Me.txtRecPat.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtRecPat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecPat.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecPat.Location = New System.Drawing.Point(47, 467)
        Me.txtRecPat.Multiline = True
        Me.txtRecPat.Name = "txtRecPat"
        Me.txtRecPat.Size = New System.Drawing.Size(372, 70)
        Me.txtRecPat.TabIndex = 122
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.AutoSize = True
        Me.MaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialRaisedButton1.Depth = 0
       
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(481, 679)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(172, 36)
        Me.MaterialRaisedButton1.TabIndex = 127
        Me.MaterialRaisedButton1.Text = "Registrar patología"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 582)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 29)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Prioridad"
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Depth = 0
        Me.cb1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cb1.Location = New System.Drawing.Point(47, 629)
        Me.cb1.Margin = New System.Windows.Forms.Padding(0)
        Me.cb1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cb1.MouseState = MaterialSkin.MouseState.HOVER
        Me.cb1.Name = "cb1"
        Me.cb1.Ripple = True
        Me.cb1.Size = New System.Drawing.Size(37, 30)
        Me.cb1.TabIndex = 129
        Me.cb1.TabStop = True
        Me.cb1.Text = "1"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'cb3
        '
        Me.cb3.AutoSize = True
        Me.cb3.Depth = 0
        Me.cb3.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cb3.Location = New System.Drawing.Point(47, 689)
        Me.cb3.Margin = New System.Windows.Forms.Padding(0)
        Me.cb3.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cb3.MouseState = MaterialSkin.MouseState.HOVER
        Me.cb3.Name = "cb3"
        Me.cb3.Ripple = True
        Me.cb3.Size = New System.Drawing.Size(37, 30)
        Me.cb3.TabIndex = 130
        Me.cb3.TabStop = True
        Me.cb3.Text = "3"
        Me.cb3.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Depth = 0
        Me.cb2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cb2.Location = New System.Drawing.Point(47, 659)
        Me.cb2.Margin = New System.Windows.Forms.Padding(0)
        Me.cb2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cb2.MouseState = MaterialSkin.MouseState.HOVER
        Me.cb2.Name = "cb2"
        Me.cb2.Ripple = True
        Me.cb2.Size = New System.Drawing.Size(37, 30)
        Me.cb2.TabIndex = 131
        Me.cb2.TabStop = True
        Me.cb2.Text = "2"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(290, 226)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(133, 150)
        Me.DataGridView1.TabIndex = 132
        '
        'frmRegistrarPatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 747)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb3)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.txtRecPat)
        Me.Controls.Add(Me.txtDescPat)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNomPat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvTodos)
        Me.Controls.Add(Me.dgvMisSintomas)
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
        CType(Me.dgvMisSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTodos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgvMisSintomas As DataGridView
    Friend WithEvents SINTOMAS As DataGridViewTextBoxColumn
    Friend WithEvents dgvTodos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNomPat As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescPat As TextBox
    Friend WithEvents txtRecPat As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Label3 As Label
    Friend WithEvents cb1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents cb3 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents cb2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents DataGridView1 As DataGridView
End Class