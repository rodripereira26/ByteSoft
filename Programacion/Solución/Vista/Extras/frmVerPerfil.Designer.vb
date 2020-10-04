<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerPerfil
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblTelefonos = New System.Windows.Forms.Label()
        Me.lblPatologiasCronicas = New System.Windows.Forms.Label()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.picEditar = New System.Windows.Forms.PictureBox()
        Me.picImagenPerfil = New System.Windows.Forms.PictureBox()
        CType(Me.picEditar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picImagenPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(31, 305)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(383, 29)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre:  xxxxxxxxxxxxxxxxxxxxxxxx"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.Location = New System.Drawing.Point(31, 396)
        Me.lblMail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(301, 29)
        Me.lblMail.TabIndex = 2
        Me.lblMail.Text = "e-mail: xxxxxxxxxxxxxxxxxxx"
        '
        'lblTelefonos
        '
        Me.lblTelefonos.AutoSize = True
        Me.lblTelefonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonos.Location = New System.Drawing.Point(31, 487)
        Me.lblTelefonos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefonos.Name = "lblTelefonos"
        Me.lblTelefonos.Size = New System.Drawing.Size(255, 29)
        Me.lblTelefonos.TabIndex = 3
        Me.lblTelefonos.Text = "Teléfonos: xxxxxxxxxxx"
        '
        'lblPatologiasCronicas
        '
        Me.lblPatologiasCronicas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatologiasCronicas.Location = New System.Drawing.Point(31, 578)
        Me.lblPatologiasCronicas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPatologiasCronicas.Name = "lblPatologiasCronicas"
        Me.lblPatologiasCronicas.Size = New System.Drawing.Size(521, 71)
        Me.lblPatologiasCronicas.TabIndex = 4
        Me.lblPatologiasCronicas.Text = "Patologías crónicas: xxxxxxxxx,xxxxxxxxxxxx,xxxxxxxx"
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.Black
        Me.lblMinimizar.Location = New System.Drawing.Point(0, 0)
        Me.lblMinimizar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinimizar.Name = "lblMinimizar"
        Me.lblMinimizar.Size = New System.Drawing.Size(32, 43)
        Me.lblMinimizar.TabIndex = 24
        Me.lblMinimizar.Text = "_"
        Me.lblMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCerrar
        '
        Me.lblCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCerrar.ForeColor = System.Drawing.Color.Black
        Me.lblCerrar.Location = New System.Drawing.Point(0, 0)
        Me.lblCerrar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(57, 43)
        Me.lblCerrar.TabIndex = 23
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picEditar
        '
        Me.picEditar.Image = Global.Vista.My.Resources.Resources.icons8_edit_32px_1
        Me.picEditar.Location = New System.Drawing.Point(507, 48)
        Me.picEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picEditar.Name = "picEditar"
        Me.picEditar.Size = New System.Drawing.Size(45, 44)
        Me.picEditar.TabIndex = 5
        Me.picEditar.TabStop = False
        '
        'picImagenPerfil
        '
        Me.picImagenPerfil.Image = Global.Vista.My.Resources.Resources.icons8_user_80px_1
        Me.picImagenPerfil.Location = New System.Drawing.Point(217, 105)
        Me.picImagenPerfil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picImagenPerfil.Name = "picImagenPerfil"
        Me.picImagenPerfil.Size = New System.Drawing.Size(135, 117)
        Me.picImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImagenPerfil.TabIndex = 0
        Me.picImagenPerfil.TabStop = False
        '
        'frmVerPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(568, 767)
        Me.Controls.Add(Me.lblCerrar)
        Me.Controls.Add(Me.lblMinimizar)
        Me.Controls.Add(Me.picEditar)
        Me.Controls.Add(Me.picImagenPerfil)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblTelefonos)
        Me.Controls.Add(Me.lblPatologiasCronicas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmVerPerfil"
        Me.Text = "VerPerfil"
        CType(Me.picEditar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picImagenPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picImagenPerfil As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblMail As Label
    Friend WithEvents lblTelefonos As Label
    Friend WithEvents lblPatologiasCronicas As Label
    Friend WithEvents picEditar As PictureBox
    Friend WithEvents lblMinimizar As Label
    Friend WithEvents lblCerrar As Label
End Class
