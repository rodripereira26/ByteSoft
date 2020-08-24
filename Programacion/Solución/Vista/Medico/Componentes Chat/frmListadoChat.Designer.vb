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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvListadoChat = New System.Windows.Forms.DataGridView()
        Me.pnlTituloPatologia = New System.Windows.Forms.Panel()
        Me.brnActualizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        CType(Me.dgvListadoChat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTituloPatologia.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListadoChat
        '
        Me.dgvListadoChat.AllowUserToAddRows = False
        Me.dgvListadoChat.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.Padding = New System.Windows.Forms.Padding(30)
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListadoChat.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvListadoChat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListadoChat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListadoChat.BackgroundColor = System.Drawing.Color.White
        Me.dgvListadoChat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListadoChat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvListadoChat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Roboto Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoChat.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvListadoChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoChat.ColumnHeadersVisible = False
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Roboto", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.Padding = New System.Windows.Forms.Padding(20)
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoChat.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvListadoChat.EnableHeadersVisualStyles = False
        Me.dgvListadoChat.Location = New System.Drawing.Point(49, 141)
        Me.dgvListadoChat.MultiSelect = False
        Me.dgvListadoChat.Name = "dgvListadoChat"
        Me.dgvListadoChat.ReadOnly = True
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoChat.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvListadoChat.RowHeadersVisible = False
        Me.dgvListadoChat.RowHeadersWidth = 51
        Me.dgvListadoChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvListadoChat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoChat.Size = New System.Drawing.Size(333, 481)
        Me.dgvListadoChat.TabIndex = 152
        '
        'pnlTituloPatologia
        '
        Me.pnlTituloPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTituloPatologia.Controls.Add(Me.btnCerrar)
        Me.pnlTituloPatologia.Controls.Add(Me.btnMinimizar)
        Me.pnlTituloPatologia.Controls.Add(Me.brnActualizar)
        Me.pnlTituloPatologia.Controls.Add(Me.Button1)
        Me.pnlTituloPatologia.Controls.Add(Me.Label10)
        Me.pnlTituloPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituloPatologia.Name = "pnlTituloPatologia"
        Me.pnlTituloPatologia.Size = New System.Drawing.Size(1006, 80)
        Me.pnlTituloPatologia.TabIndex = 153
        '
        'brnActualizar
        '
        Me.brnActualizar.FlatAppearance.BorderSize = 0
        Me.brnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brnActualizar.Image = Global.Vista.My.Resources.Resources.icons8_refresh_20px
        Me.brnActualizar.Location = New System.Drawing.Point(885, 0)
        Me.brnActualizar.Name = "brnActualizar"
        Me.brnActualizar.Size = New System.Drawing.Size(40, 35)
        Me.brnActualizar.TabIndex = 150
        Me.brnActualizar.UseVisualStyleBackColor = True
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
        Me.Label10.Text = "SOLICITUDES DE CHAT"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Vista.My.Resources.Resources.icons8_right_arrow_64
        Me.Button2.Location = New System.Drawing.Point(645, 319)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(236, 58)
        Me.Button2.TabIndex = 154
        Me.Button2.Text = "Ver mis chats"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(972, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(34, 33)
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
        Me.btnMinimizar.Location = New System.Drawing.Point(935, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(34, 33)
        Me.btnMinimizar.TabIndex = 157
        Me.btnMinimizar.Text = "_"
        Me.btnMinimizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'frmListadoChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1006, 645)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgvListadoChat)
        Me.Controls.Add(Me.pnlTituloPatologia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmListadoChat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListadoChat"
        CType(Me.dgvListadoChat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTituloPatologia.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents dgvListadoChat As DataGridView
    Friend WithEvents pnlTituloPatologia As Panel
    Friend WithEvents brnActualizar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
End Class
