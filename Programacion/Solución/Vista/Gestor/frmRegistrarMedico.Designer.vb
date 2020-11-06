<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistrarMedico
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
        Me.lblNomPatMed = New System.Windows.Forms.Label()
        Me.txtCed = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtEspec = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblEspecMed = New System.Windows.Forms.Label()
        Me.txtPrimerNombre = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblPNomMed = New System.Windows.Forms.Label()
        Me.txtSegundoNombre = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblSNomMed = New System.Windows.Forms.Label()
        Me.txtPrimerApellido = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtSegundoApellido = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblPApeMed = New System.Windows.Forms.Label()
        Me.lblSApeMed = New System.Windows.Forms.Label()
        Me.btnRegistrarMedico = New Guna.UI.WinForms.GunaButton()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.lblCorreoMed = New System.Windows.Forms.Label()
        Me.txtMail = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblMiFoto = New System.Windows.Forms.Label()
        Me.btnImg = New Guna.UI.WinForms.GunaButton()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNomPatMed
        '
        Me.lblNomPatMed.AutoSize = True
        Me.lblNomPatMed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomPatMed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNomPatMed.Location = New System.Drawing.Point(35, 123)
        Me.lblNomPatMed.Name = "lblNomPatMed"
        Me.lblNomPatMed.Size = New System.Drawing.Size(182, 25)
        Me.lblNomPatMed.TabIndex = 183
        Me.lblNomPatMed.Text = "Cédula de identidad"
        '
        'txtCed
        '
        Me.txtCed.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtCed.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCed.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCed.LineColor = System.Drawing.Color.Gainsboro
        Me.txtCed.LineSize = 1
        Me.txtCed.Location = New System.Drawing.Point(40, 170)
        Me.txtCed.Name = "txtCed"
        Me.txtCed.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCed.Size = New System.Drawing.Size(262, 36)
        Me.txtCed.TabIndex = 1
        '
        'txtEspec
        '
        Me.txtEspec.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtEspec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEspec.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEspec.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspec.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtEspec.LineColor = System.Drawing.Color.Gainsboro
        Me.txtEspec.LineSize = 1
        Me.txtEspec.Location = New System.Drawing.Point(40, 285)
        Me.txtEspec.Name = "txtEspec"
        Me.txtEspec.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEspec.Size = New System.Drawing.Size(262, 36)
        Me.txtEspec.TabIndex = 2
        '
        'lblEspecMed
        '
        Me.lblEspecMed.AutoSize = True
        Me.lblEspecMed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspecMed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblEspecMed.Location = New System.Drawing.Point(35, 238)
        Me.lblEspecMed.Name = "lblEspecMed"
        Me.lblEspecMed.Size = New System.Drawing.Size(140, 25)
        Me.lblEspecMed.TabIndex = 185
        Me.lblEspecMed.Text = "Especialización"
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPrimerNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrimerNombre.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPrimerNombre.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPrimerNombre.LineSize = 1
        Me.txtPrimerNombre.Location = New System.Drawing.Point(404, 179)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimerNombre.Size = New System.Drawing.Size(262, 36)
        Me.txtPrimerNombre.TabIndex = 3
        '
        'lblPNomMed
        '
        Me.lblPNomMed.AutoSize = True
        Me.lblPNomMed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPNomMed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPNomMed.Location = New System.Drawing.Point(399, 123)
        Me.lblPNomMed.Name = "lblPNomMed"
        Me.lblPNomMed.Size = New System.Drawing.Size(139, 25)
        Me.lblPNomMed.TabIndex = 187
        Me.lblPNomMed.Text = "Primer nombre"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSegundoNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSegundoNombre.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSegundoNombre.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSegundoNombre.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSegundoNombre.LineSize = 1
        Me.txtSegundoNombre.Location = New System.Drawing.Point(403, 402)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSegundoNombre.Size = New System.Drawing.Size(262, 36)
        Me.txtSegundoNombre.TabIndex = 4
        '
        'lblSNomMed
        '
        Me.lblSNomMed.AutoSize = True
        Me.lblSNomMed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSNomMed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSNomMed.Location = New System.Drawing.Point(399, 351)
        Me.lblSNomMed.Name = "lblSNomMed"
        Me.lblSNomMed.Size = New System.Drawing.Size(158, 25)
        Me.lblSNomMed.TabIndex = 189
        Me.lblSNomMed.Text = "Segundo nombre"
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPrimerApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrimerApellido.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPrimerApellido.LineColor = System.Drawing.Color.Gainsboro
        Me.txtPrimerApellido.LineSize = 1
        Me.txtPrimerApellido.Location = New System.Drawing.Point(746, 179)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrimerApellido.Size = New System.Drawing.Size(262, 36)
        Me.txtPrimerApellido.TabIndex = 5
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtSegundoApellido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSegundoApellido.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApellido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtSegundoApellido.LineColor = System.Drawing.Color.Gainsboro
        Me.txtSegundoApellido.LineSize = 1
        Me.txtSegundoApellido.Location = New System.Drawing.Point(764, 390)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSegundoApellido.Size = New System.Drawing.Size(262, 36)
        Me.txtSegundoApellido.TabIndex = 6
        '
        'lblPApeMed
        '
        Me.lblPApeMed.AutoSize = True
        Me.lblPApeMed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPApeMed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblPApeMed.Location = New System.Drawing.Point(741, 123)
        Me.lblPApeMed.Name = "lblPApeMed"
        Me.lblPApeMed.Size = New System.Drawing.Size(141, 25)
        Me.lblPApeMed.TabIndex = 192
        Me.lblPApeMed.Text = "Primer apellido"
        '
        'lblSApeMed
        '
        Me.lblSApeMed.AutoSize = True
        Me.lblSApeMed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSApeMed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSApeMed.Location = New System.Drawing.Point(760, 336)
        Me.lblSApeMed.Name = "lblSApeMed"
        Me.lblSApeMed.Size = New System.Drawing.Size(160, 25)
        Me.lblSApeMed.TabIndex = 193
        Me.lblSApeMed.Text = "Segundo apellido"
        '
        'btnRegistrarMedico
        '
        Me.btnRegistrarMedico.AnimationHoverSpeed = 0.07!
        Me.btnRegistrarMedico.AnimationSpeed = 0.03!
        Me.btnRegistrarMedico.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrarMedico.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnRegistrarMedico.BorderColor = System.Drawing.Color.Black
        Me.btnRegistrarMedico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrarMedico.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistrarMedico.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistrarMedico.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrarMedico.ForeColor = System.Drawing.Color.White
        Me.btnRegistrarMedico.Image = Nothing
        Me.btnRegistrarMedico.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegistrarMedico.Location = New System.Drawing.Point(436, 572)
        Me.btnRegistrarMedico.Name = "btnRegistrarMedico"
        Me.btnRegistrarMedico.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnRegistrarMedico.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistrarMedico.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistrarMedico.OnHoverImage = Nothing
        Me.btnRegistrarMedico.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistrarMedico.Radius = 10
        Me.btnRegistrarMedico.Size = New System.Drawing.Size(199, 42)
        Me.btnRegistrarMedico.TabIndex = 7
        Me.btnRegistrarMedico.Text = "Registrar médico"
        Me.btnRegistrarMedico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnAtras.TabIndex = 195
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblCorreoMed
        '
        Me.lblCorreoMed.AutoSize = True
        Me.lblCorreoMed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreoMed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblCorreoMed.Location = New System.Drawing.Point(35, 351)
        Me.lblCorreoMed.Name = "lblCorreoMed"
        Me.lblCorreoMed.Size = New System.Drawing.Size(169, 25)
        Me.lblCorreoMed.TabIndex = 197
        Me.lblCorreoMed.Text = "Correo electrónico"
        '
        'txtMail
        '
        Me.txtMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMail.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMail.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtMail.LineColor = System.Drawing.Color.Gainsboro
        Me.txtMail.LineSize = 1
        Me.txtMail.Location = New System.Drawing.Point(39, 402)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMail.Size = New System.Drawing.Size(262, 36)
        Me.txtMail.TabIndex = 7
        '
        'lblMiFoto
        '
        Me.lblMiFoto.AutoSize = True
        Me.lblMiFoto.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiFoto.ForeColor = System.Drawing.Color.Silver
        Me.lblMiFoto.Location = New System.Drawing.Point(742, 450)
        Me.lblMiFoto.Name = "lblMiFoto"
        Me.lblMiFoto.Size = New System.Drawing.Size(58, 20)
        Me.lblMiFoto.TabIndex = 203
        Me.lblMiFoto.Text = "Mi foto"
        '
        'btnImg
        '
        Me.btnImg.Animated = True
        Me.btnImg.AnimationHoverSpeed = 0.07!
        Me.btnImg.AnimationSpeed = 0.03!
        Me.btnImg.BackColor = System.Drawing.Color.Transparent
        Me.btnImg.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnImg.BorderColor = System.Drawing.Color.Black
        Me.btnImg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImg.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnImg.FocusedColor = System.Drawing.Color.Empty
        Me.btnImg.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImg.ForeColor = System.Drawing.Color.White
        Me.btnImg.Image = Nothing
        Me.btnImg.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnImg.Location = New System.Drawing.Point(746, 606)
        Me.btnImg.Name = "btnImg"
        Me.btnImg.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnImg.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnImg.OnHoverForeColor = System.Drawing.Color.White
        Me.btnImg.OnHoverImage = Nothing
        Me.btnImg.OnPressedColor = System.Drawing.Color.Black
        Me.btnImg.Radius = 10
        Me.btnImg.Size = New System.Drawing.Size(58, 32)
        Me.btnImg.TabIndex = 202
        Me.btnImg.Text = "+"
        Me.btnImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.GunaPictureBox1.Location = New System.Drawing.Point(714, 480)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Radius = 30
        Me.GunaPictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox1.TabIndex = 201
        Me.GunaPictureBox1.TabStop = False
        '
        'frmRegistrarMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.lblMiFoto)
        Me.Controls.Add(Me.btnImg)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.lblCorreoMed)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.btnRegistrarMedico)
        Me.Controls.Add(Me.lblSApeMed)
        Me.Controls.Add(Me.lblPApeMed)
        Me.Controls.Add(Me.txtSegundoApellido)
        Me.Controls.Add(Me.txtPrimerApellido)
        Me.Controls.Add(Me.lblSNomMed)
        Me.Controls.Add(Me.txtSegundoNombre)
        Me.Controls.Add(Me.lblPNomMed)
        Me.Controls.Add(Me.txtPrimerNombre)
        Me.Controls.Add(Me.lblEspecMed)
        Me.Controls.Add(Me.txtEspec)
        Me.Controls.Add(Me.lblNomPatMed)
        Me.Controls.Add(Me.txtCed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNomPatMed As Label
    Friend WithEvents txtCed As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtEspec As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblEspecMed As Label
    Friend WithEvents txtPrimerNombre As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblPNomMed As Label
    Friend WithEvents txtSegundoNombre As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblSNomMed As Label
    Friend WithEvents txtPrimerApellido As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtSegundoApellido As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblPApeMed As Label
    Friend WithEvents lblSApeMed As Label
    Friend WithEvents btnRegistrarMedico As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents lblCorreoMed As Label
    Friend WithEvents txtMail As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents lblMiFoto As Label
    Friend WithEvents btnImg As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
