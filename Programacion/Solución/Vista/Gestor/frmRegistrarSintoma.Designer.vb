<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistrarSintoma
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
        Me.Panel1__ = New System.Windows.Forms.Panel()
        Me.Label1__ = New System.Windows.Forms.Label()
        Me.Panel9__ = New System.Windows.Forms.Panel()
        Me.TextBox1__ = New System.Windows.Forms.TextBox()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.lblCantNom = New System.Windows.Forms.Label()
        Me.btnAtras = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCantText = New System.Windows.Forms.Label()
        Me.btnRegistrar = New Guna.UI.WinForms.GunaButton()
        Me.lblNomPat = New System.Windows.Forms.Label()
        Me.txtNom = New Guna.UI.WinForms.GunaLineTextBox()
        Me.lblDescripcionSintoma = New System.Windows.Forms.Label()
        Me.txtDescripcion = New Guna.UI.WinForms.GunaTextBox()
        Me.sepDesc = New Guna.UI.WinForms.GunaSeparator()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
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
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.lblCantNom)
        Me.pnlContenedor.Controls.Add(Me.btnAtras)
        Me.pnlContenedor.Controls.Add(Me.Label1)
        Me.pnlContenedor.Controls.Add(Me.lblCantText)
        Me.pnlContenedor.Controls.Add(Me.btnRegistrar)
        Me.pnlContenedor.Controls.Add(Me.lblNomPat)
        Me.pnlContenedor.Controls.Add(Me.txtNom)
        Me.pnlContenedor.Controls.Add(Me.lblDescripcionSintoma)
        Me.pnlContenedor.Controls.Add(Me.txtDescripcion)
        Me.pnlContenedor.Controls.Add(Me.sepDesc)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 0)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1070, 650)
        Me.pnlContenedor.TabIndex = 128
        '
        'lblCantNom
        '
        Me.lblCantNom.AutoSize = True
        Me.lblCantNom.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantNom.ForeColor = System.Drawing.Color.Silver
        Me.lblCantNom.Location = New System.Drawing.Point(680, 126)
        Me.lblCantNom.Name = "lblCantNom"
        Me.lblCantNom.Size = New System.Drawing.Size(34, 17)
        Me.lblCantNom.TabIndex = 201
        Me.lblCantNom.Text = "0/25"
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
        Me.btnAtras.TabIndex = 200
        Me.btnAtras.Text = "Atrás"
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-7, 516)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 199
        Me.Label1.Visible = False
        '
        'lblCantText
        '
        Me.lblCantText.AutoSize = True
        Me.lblCantText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantText.ForeColor = System.Drawing.Color.Silver
        Me.lblCantText.Location = New System.Drawing.Point(845, 277)
        Me.lblCantText.Name = "lblCantText"
        Me.lblCantText.Size = New System.Drawing.Size(41, 17)
        Me.lblCantText.TabIndex = 198
        Me.lblCantText.Text = "0/300"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Animated = True
        Me.btnRegistrar.AnimationHoverSpeed = 0.07!
        Me.btnRegistrar.AnimationSpeed = 0.03!
        Me.btnRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrar.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnRegistrar.BorderColor = System.Drawing.Color.Black
        Me.btnRegistrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegistrar.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegistrar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRegistrar.Image = Nothing
        Me.btnRegistrar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegistrar.Location = New System.Drawing.Point(431, 572)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegistrar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegistrar.OnHoverImage = Nothing
        Me.btnRegistrar.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegistrar.Radius = 10
        Me.btnRegistrar.Size = New System.Drawing.Size(199, 42)
        Me.btnRegistrar.TabIndex = 190
        Me.btnRegistrar.Text = "Registrar síntoma"
        Me.btnRegistrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNomPat
        '
        Me.lblNomPat.AutoSize = True
        Me.lblNomPat.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomPat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNomPat.Location = New System.Drawing.Point(303, 118)
        Me.lblNomPat.Name = "lblNomPat"
        Me.lblNomPat.Size = New System.Drawing.Size(184, 25)
        Me.lblNomPat.TabIndex = 187
        Me.lblNomPat.Text = "Nombre del síntoma"
        '
        'txtNom
        '
        Me.txtNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNom.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtNom.LineColor = System.Drawing.Color.Gainsboro
        Me.txtNom.LineSize = 1
        Me.txtNom.Location = New System.Drawing.Point(308, 166)
        Me.txtNom.MaxLength = 25
        Me.txtNom.Name = "txtNom"
        Me.txtNom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNom.Size = New System.Drawing.Size(413, 42)
        Me.txtNom.TabIndex = 185
        '
        'lblDescripcionSintoma
        '
        Me.lblDescripcionSintoma.AutoSize = True
        Me.lblDescripcionSintoma.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionSintoma.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblDescripcionSintoma.Location = New System.Drawing.Point(227, 271)
        Me.lblDescripcionSintoma.Name = "lblDescripcionSintoma"
        Me.lblDescripcionSintoma.Size = New System.Drawing.Size(111, 25)
        Me.lblDescripcionSintoma.TabIndex = 188
        Me.lblDescripcionSintoma.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDescripcion.BorderColor = System.Drawing.Color.Silver
        Me.txtDescripcion.BorderSize = 0
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtDescripcion.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescripcion.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDescripcion.Location = New System.Drawing.Point(232, 307)
        Me.txtDescripcion.MaxLength = 300
        Me.txtDescripcion.MultiLine = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.Size = New System.Drawing.Size(654, 122)
        Me.txtDescripcion.TabIndex = 186
        '
        'sepDesc
        '
        Me.sepDesc.LineColor = System.Drawing.Color.Gainsboro
        Me.sepDesc.Location = New System.Drawing.Point(232, 435)
        Me.sepDesc.Name = "sepDesc"
        Me.sepDesc.Size = New System.Drawing.Size(654, 10)
        Me.sepDesc.TabIndex = 189
        '
        'frmRegistrarSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 650)
        Me.Controls.Add(Me.pnlContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRegistrarSintoma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1__ As Panel
    Friend WithEvents Label1__ As Label
    Friend WithEvents Panel9__ As Panel
    Friend WithEvents TextBox1__ As TextBox
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents lblNomPat As Label
    Friend WithEvents txtNom As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtDescripcion As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents sepDesc As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents lblDescripcionSintoma As Label
    Friend WithEvents btnRegistrar As Guna.UI.WinForms.GunaButton
    Friend WithEvents lblCantText As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAtras As FontAwesome.Sharp.IconButton
    Friend WithEvents lblCantNom As Label
End Class
