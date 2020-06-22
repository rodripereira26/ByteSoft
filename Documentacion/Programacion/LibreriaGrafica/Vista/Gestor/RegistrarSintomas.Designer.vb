<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrarSintomas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarSintomas))
        Me.panelTitulo = New System.Windows.Forms.Panel()
        Me.lblRegistrarSintomas = New System.Windows.Forms.Label()
        Me.Panel1__ = New System.Windows.Forms.Panel()
        Me.Label1__ = New System.Windows.Forms.Label()
        Me.Panel9__ = New System.Windows.Forms.Panel()
        Me.TextBox1__ = New System.Windows.Forms.TextBox()
        Me.pnlTxtDescripcion = New System.Windows.Forms.Panel()
        Me.lblNomSintoma = New System.Windows.Forms.Label()
        Me.pnlTxtNomSintoma = New System.Windows.Forms.Panel()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtNomSintoma = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.picBoxRegistrarSintoma = New System.Windows.Forms.PictureBox()
        Me.btnVirusRegistrarSintomas = New System.Windows.Forms.Button()
        Me.panelTitulo.SuspendLayout()
        CType(Me.picBoxRegistrarSintoma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitulo
        '
        Me.panelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.panelTitulo.Controls.Add(Me.lblRegistrarSintomas)
        Me.panelTitulo.Location = New System.Drawing.Point(-1, 0)
        Me.panelTitulo.Name = "panelTitulo"
        Me.panelTitulo.Size = New System.Drawing.Size(701, 77)
        Me.panelTitulo.TabIndex = 92
        '
        'lblRegistrarSintomas
        '
        Me.lblRegistrarSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRegistrarSintomas.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrarSintomas.ForeColor = System.Drawing.Color.White
        Me.lblRegistrarSintomas.Location = New System.Drawing.Point(203, 9)
        Me.lblRegistrarSintomas.Name = "lblRegistrarSintomas"
        Me.lblRegistrarSintomas.Size = New System.Drawing.Size(300, 57)
        Me.lblRegistrarSintomas.TabIndex = 4
        Me.lblRegistrarSintomas.Text = "Registrar sintomas"
        Me.lblRegistrarSintomas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1__
        '
        Me.Panel1__.Location = New System.Drawing.Point(0, 0)
        Me.Panel1__.Name = "Panel1__"
        Me.Panel1__.Size = New System.Drawing.Size(200, 100)
        Me.Panel1__.TabIndex = 0
        '
        'Label1__
        '
        Me.Label1__.Location = New System.Drawing.Point(0, 0)
        Me.Label1__.Name = "Label1__"
        Me.Label1__.Size = New System.Drawing.Size(100, 23)
        Me.Label1__.TabIndex = 0
        '
        'Panel9__
        '
        Me.Panel9__.Location = New System.Drawing.Point(0, 0)
        Me.Panel9__.Name = "Panel9__"
        Me.Panel9__.Size = New System.Drawing.Size(200, 100)
        Me.Panel9__.TabIndex = 0
        '
        'TextBox1__
        '
        Me.TextBox1__.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1__.Name = "TextBox1__"
        Me.TextBox1__.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1__.TabIndex = 0
        '
        'pnlTxtDescripcion
        '
        Me.pnlTxtDescripcion.BackColor = System.Drawing.Color.Black
        Me.pnlTxtDescripcion.Location = New System.Drawing.Point(127, 336)
        Me.pnlTxtDescripcion.Name = "pnlTxtDescripcion"
        Me.pnlTxtDescripcion.Size = New System.Drawing.Size(459, 2)
        Me.pnlTxtDescripcion.TabIndex = 114
        '
        'lblNomSintoma
        '
        Me.lblNomSintoma.AutoSize = True
        Me.lblNomSintoma.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomSintoma.Location = New System.Drawing.Point(260, 133)
        Me.lblNomSintoma.Name = "lblNomSintoma"
        Me.lblNomSintoma.Size = New System.Drawing.Size(208, 26)
        Me.lblNomSintoma.TabIndex = 110
        Me.lblNomSintoma.Text = "Nombre del sintoma"
        '
        'pnlTxtNomSintoma
        '
        Me.pnlTxtNomSintoma.BackColor = System.Drawing.Color.Black
        Me.pnlTxtNomSintoma.Location = New System.Drawing.Point(274, 200)
        Me.pnlTxtNomSintoma.Name = "pnlTxtNomSintoma"
        Me.pnlTxtNomSintoma.Size = New System.Drawing.Size(176, 2)
        Me.pnlTxtNomSintoma.TabIndex = 111
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(127, 249)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(459, 67)
        Me.txtDescripcion.TabIndex = 113
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(112, 209)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(126, 26)
        Me.lblDescripcion.TabIndex = 112
        Me.lblDescripcion.Text = "Descripcion"
        '
        'txtNomSintoma
        '
        Me.txtNomSintoma.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.txtNomSintoma.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNomSintoma.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomSintoma.Location = New System.Drawing.Point(274, 171)
        Me.txtNomSintoma.Name = "txtNomSintoma"
        Me.txtNomSintoma.Size = New System.Drawing.Size(176, 24)
        Me.txtNomSintoma.TabIndex = 115
        '
        'picBoxRegistrarSintoma
        '
        Me.picBoxRegistrarSintoma.Image = Global.Vista.My.Resources.Resources.ingmed
        Me.picBoxRegistrarSintoma.Location = New System.Drawing.Point(253, 484)
        Me.picBoxRegistrarSintoma.Name = "picBoxRegistrarSintoma"
        Me.picBoxRegistrarSintoma.Size = New System.Drawing.Size(210, 50)
        Me.picBoxRegistrarSintoma.TabIndex = 95
        Me.picBoxRegistrarSintoma.TabStop = False
        '
        'btnVirusRegistrarSintomas
        '
        Me.btnVirusRegistrarSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.btnVirusRegistrarSintomas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVirusRegistrarSintomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVirusRegistrarSintomas.Image = CType(resources.GetObject("btnVirusRegistrarSintomas.Image"), System.Drawing.Image)
        Me.btnVirusRegistrarSintomas.Location = New System.Drawing.Point(666, 524)
        Me.btnVirusRegistrarSintomas.Name = "btnVirusRegistrarSintomas"
        Me.btnVirusRegistrarSintomas.Size = New System.Drawing.Size(34, 32)
        Me.btnVirusRegistrarSintomas.TabIndex = 93
        Me.btnVirusRegistrarSintomas.UseVisualStyleBackColor = False
        '
        'RegistrarSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 556)
        Me.Controls.Add(Me.txtNomSintoma)
        Me.Controls.Add(Me.pnlTxtDescripcion)
        Me.Controls.Add(Me.lblNomSintoma)
        Me.Controls.Add(Me.pnlTxtNomSintoma)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.picBoxRegistrarSintoma)
        Me.Controls.Add(Me.panelTitulo)
        Me.Controls.Add(Me.btnVirusRegistrarSintomas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegistrarSintomas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelTitulo.ResumeLayout(False)
        CType(Me.picBoxRegistrarSintoma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelTitulo As Panel
    Friend WithEvents lblRegistrarSintomas As Label
    Friend WithEvents btnVirusRegistrarSintomas As Button
    Friend WithEvents picBoxRegistrarSintoma As PictureBox
    Friend WithEvents Panel1__ As Panel
    Friend WithEvents Label1__ As Label
    Friend WithEvents Panel9__ As Panel
    Friend WithEvents TextBox1__ As TextBox
    Friend WithEvents pnlTxtDescripcion As Panel
    Friend WithEvents lblNomSintoma As Label
    Friend WithEvents pnlTxtNomSintoma As Panel
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtNomSintoma As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
