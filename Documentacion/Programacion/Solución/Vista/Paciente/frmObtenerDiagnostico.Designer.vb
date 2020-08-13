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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTituloPatologia = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgvPosiblesDiagnosticos = New System.Windows.Forms.DataGridView()
        Me.UserControl11 = New Vista.UserControl1()
        Me.pnlTituloPatologia.SuspendLayout()
        CType(Me.dgvPosiblesDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTituloPatologia
        '
        Me.pnlTituloPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTituloPatologia.Controls.Add(Me.Button1)
        Me.pnlTituloPatologia.Controls.Add(Me.Label10)
        Me.pnlTituloPatologia.Controls.Add(Me.Label12)
        Me.pnlTituloPatologia.Controls.Add(Me.Label13)
        Me.pnlTituloPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituloPatologia.Name = "pnlTituloPatologia"
        Me.pnlTituloPatologia.Size = New System.Drawing.Size(1006, 77)
        Me.pnlTituloPatologia.TabIndex = 147
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Vista.My.Resources.Resources.icons8_left_32px
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(9, 19)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(3)
        Me.Button1.Size = New System.Drawing.Size(49, 32)
        Me.Button1.TabIndex = 153
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Roboto Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(305, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(396, 45)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "POSIBLES DIAGNÓSTICOS"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(940, -17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 54)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "_"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(963, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 35)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "X"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPosiblesDiagnosticos
        '
        Me.dgvPosiblesDiagnosticos.AllowUserToAddRows = False
        Me.dgvPosiblesDiagnosticos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Roboto", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(30)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPosiblesDiagnosticos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPosiblesDiagnosticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPosiblesDiagnosticos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvPosiblesDiagnosticos.BackgroundColor = System.Drawing.Color.White
        Me.dgvPosiblesDiagnosticos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPosiblesDiagnosticos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPosiblesDiagnosticos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Roboto Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPosiblesDiagnosticos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPosiblesDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPosiblesDiagnosticos.ColumnHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Roboto", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(30)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPosiblesDiagnosticos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPosiblesDiagnosticos.EnableHeadersVisualStyles = False
        Me.dgvPosiblesDiagnosticos.Location = New System.Drawing.Point(0, 77)
        Me.dgvPosiblesDiagnosticos.MultiSelect = False
        Me.dgvPosiblesDiagnosticos.Name = "dgvPosiblesDiagnosticos"
        Me.dgvPosiblesDiagnosticos.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPosiblesDiagnosticos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPosiblesDiagnosticos.RowHeadersVisible = False
        Me.dgvPosiblesDiagnosticos.RowHeadersWidth = 51
        Me.dgvPosiblesDiagnosticos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPosiblesDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPosiblesDiagnosticos.Size = New System.Drawing.Size(1006, 601)
        Me.dgvPosiblesDiagnosticos.TabIndex = 146
        '
        'UserControl11
        '
        Me.UserControl11.BackColor = System.Drawing.Color.White
        Me.UserControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControl11.Location = New System.Drawing.Point(199, 98)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(607, 541)
        Me.UserControl11.TabIndex = 148
        Me.UserControl11.Visible = False
        '
        'frmObtenerDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 677)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.pnlTituloPatologia)
        Me.Controls.Add(Me.dgvPosiblesDiagnosticos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmObtenerDiagnostico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ObtenerDiagnóstico"
        Me.pnlTituloPatologia.ResumeLayout(False)
        CType(Me.dgvPosiblesDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTituloPatologia As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvPosiblesDiagnosticos As DataGridView
    Friend WithEvents UserControl11 As UserControl1
    Friend WithEvents Button1 As Button
End Class
