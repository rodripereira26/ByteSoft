<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModular
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
        Me.pnlOpcion1 = New System.Windows.Forms.Panel()
        Me.lblSubtitulo1 = New System.Windows.Forms.Label()
        Me.pnlDecorativo1 = New System.Windows.Forms.Panel()
        Me.lblTitulo1 = New System.Windows.Forms.Label()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlOpcion2 = New System.Windows.Forms.Panel()
        Me.lblSubtitulo2 = New System.Windows.Forms.Label()
        Me.pnlDecorativo2 = New System.Windows.Forms.Panel()
        Me.lblTitulo2 = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.pnlOpcion1.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlOpcion2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlOpcion1
        '
        Me.pnlOpcion1.BackColor = System.Drawing.Color.White
        Me.pnlOpcion1.Controls.Add(Me.lblSubtitulo1)
        Me.pnlOpcion1.Controls.Add(Me.pnlDecorativo1)
        Me.pnlOpcion1.Controls.Add(Me.lblTitulo1)
        Me.pnlOpcion1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlOpcion1.Location = New System.Drawing.Point(100, 100)
        Me.pnlOpcion1.Name = "pnlOpcion1"
        Me.pnlOpcion1.Size = New System.Drawing.Size(565, 151)
        Me.pnlOpcion1.TabIndex = 7
        '
        'lblSubtitulo1
        '
        Me.lblSubtitulo1.AutoSize = True
        Me.lblSubtitulo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubtitulo1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitulo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblSubtitulo1.Location = New System.Drawing.Point(25, 80)
        Me.lblSubtitulo1.Name = "lblSubtitulo1"
        Me.lblSubtitulo1.Size = New System.Drawing.Size(0, 24)
        Me.lblSubtitulo1.TabIndex = 5
        '
        'pnlDecorativo1
        '
        Me.pnlDecorativo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlDecorativo1.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecorativo1.Name = "pnlDecorativo1"
        Me.pnlDecorativo1.Size = New System.Drawing.Size(564, 14)
        Me.pnlDecorativo1.TabIndex = 2
        '
        'lblTitulo1
        '
        Me.lblTitulo1.AutoSize = True
        Me.lblTitulo1.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblTitulo1.Location = New System.Drawing.Point(22, 28)
        Me.lblTitulo1.Name = "lblTitulo1"
        Me.lblTitulo1.Size = New System.Drawing.Size(146, 39)
        Me.lblTitulo1.TabIndex = 0
        Me.lblTitulo1.Text = "Registrar"
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.White
        Me.lblMinimizar.Location = New System.Drawing.Point(692, 0)
        Me.lblMinimizar.Name = "lblMinimizar"
        Me.lblMinimizar.Size = New System.Drawing.Size(24, 35)
        Me.lblMinimizar.TabIndex = 24
        Me.lblMinimizar.Text = "_"
        Me.lblMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCerrar
        '
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(722, 6)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(43, 35)
        Me.lblCerrar.TabIndex = 23
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.btnAtras)
        Me.pnlTopBar.Controls.Add(Me.lblTitulo)
        Me.pnlTopBar.Controls.Add(Me.lblMinimizar)
        Me.pnlTopBar.Controls.Add(Me.lblCerrar)
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(765, 77)
        Me.pnlTopBar.TabIndex = 10
        '
        'lblTitulo
        '
        Me.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitulo.Font = New System.Drawing.Font("Roboto Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(148, 16)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(490, 45)
        Me.lblTitulo.TabIndex = 25
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlOpcion2
        '
        Me.pnlOpcion2.BackColor = System.Drawing.Color.White
        Me.pnlOpcion2.Controls.Add(Me.lblSubtitulo2)
        Me.pnlOpcion2.Controls.Add(Me.pnlDecorativo2)
        Me.pnlOpcion2.Controls.Add(Me.lblTitulo2)
        Me.pnlOpcion2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlOpcion2.Location = New System.Drawing.Point(100, 270)
        Me.pnlOpcion2.Name = "pnlOpcion2"
        Me.pnlOpcion2.Size = New System.Drawing.Size(565, 156)
        Me.pnlOpcion2.TabIndex = 11
        '
        'lblSubtitulo2
        '
        Me.lblSubtitulo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubtitulo2.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtitulo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblSubtitulo2.Location = New System.Drawing.Point(26, 75)
        Me.lblSubtitulo2.Name = "lblSubtitulo2"
        Me.lblSubtitulo2.Size = New System.Drawing.Size(512, 60)
        Me.lblSubtitulo2.TabIndex = 7
        '
        'pnlDecorativo2
        '
        Me.pnlDecorativo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlDecorativo2.Location = New System.Drawing.Point(0, 0)
        Me.pnlDecorativo2.Name = "pnlDecorativo2"
        Me.pnlDecorativo2.Size = New System.Drawing.Size(564, 12)
        Me.pnlDecorativo2.TabIndex = 2
        '
        'lblTitulo2
        '
        Me.lblTitulo2.AutoSize = True
        Me.lblTitulo2.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblTitulo2.Location = New System.Drawing.Point(23, 25)
        Me.lblTitulo2.Name = "lblTitulo2"
        Me.lblTitulo2.Size = New System.Drawing.Size(0, 39)
        Me.lblTitulo2.TabIndex = 0
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icoFlechaAtras
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Image = Global.Vista.My.Resources.Resources.icoFlechaAtrasWhite
        Me.btnAtras.Location = New System.Drawing.Point(38, 22)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(34, 33)
        Me.btnAtras.TabIndex = 27
        Me.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'frmModular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(765, 451)
        Me.Controls.Add(Me.pnlOpcion2)
        Me.Controls.Add(Me.pnlOpcion1)
        Me.Controls.Add(Me.pnlTopBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmModular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlOpcion1.ResumeLayout(False)
        Me.pnlOpcion1.PerformLayout()
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlOpcion2.ResumeLayout(False)
        Me.pnlOpcion2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlOpcion1 As Panel
    Friend WithEvents lblSubtitulo1 As Label
    Friend WithEvents pnlDecorativo1 As Panel
    Friend WithEvents lblTitulo1 As Label
    Friend WithEvents lblMinimizar As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents pnlOpcion2 As Panel
    Friend WithEvents lblSubtitulo2 As Label
    Friend WithEvents pnlDecorativo2 As Panel
    Friend WithEvents lblTitulo2 As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnAtras As Button
End Class
