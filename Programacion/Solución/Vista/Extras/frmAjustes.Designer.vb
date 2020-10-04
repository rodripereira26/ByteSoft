<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAjustes
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
        Me.pnlTitulo = New System.Windows.Forms.Panel()
        Me.lblMinimizar = New System.Windows.Forms.Label()
        Me.lblCerrar = New System.Windows.Forms.Label()
        Me.lblAjustes = New System.Windows.Forms.Label()
        Me.pnlTema = New System.Windows.Forms.Panel()
        Me.mrbtnOscuro = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbtnClaro = New MaterialSkin.Controls.MaterialRadioButton()
        Me.lblTema = New System.Windows.Forms.Label()
        Me.msdDivisor = New MetroSet_UI.Controls.MetroSetDivider()
        Me.lblIdioma = New System.Windows.Forms.Label()
        Me.pnl_Idioma = New System.Windows.Forms.Panel()
        Me.mrbtnIngles = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbtnEspañol = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbtnAplicarCambios = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlTitulo.SuspendLayout()
        Me.pnlTema.SuspendLayout()
        Me.pnl_Idioma.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitulo
        '
        Me.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.pnlTitulo.Controls.Add(Me.lblAjustes)
        Me.pnlTitulo.Controls.Add(Me.lblMinimizar)
        Me.pnlTitulo.Controls.Add(Me.lblCerrar)
        Me.pnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitulo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTitulo.Name = "pnlTitulo"
        Me.pnlTitulo.Size = New System.Drawing.Size(792, 95)
        Me.pnlTitulo.TabIndex = 12
        '
        'lblMinimizar
        '
        Me.lblMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimizar.ForeColor = System.Drawing.Color.White
        Me.lblMinimizar.Location = New System.Drawing.Point(695, -7)
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
        Me.lblCerrar.ForeColor = System.Drawing.Color.White
        Me.lblCerrar.Location = New System.Drawing.Point(735, 0)
        Me.lblCerrar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCerrar.Name = "lblCerrar"
        Me.lblCerrar.Size = New System.Drawing.Size(57, 43)
        Me.lblCerrar.TabIndex = 23
        Me.lblCerrar.Text = "X"
        Me.lblCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAjustes
        '
        Me.lblAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAjustes.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjustes.ForeColor = System.Drawing.Color.White
        Me.lblAjustes.Location = New System.Drawing.Point(201, 11)
        Me.lblAjustes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAjustes.Name = "lblAjustes"
        Me.lblAjustes.Size = New System.Drawing.Size(392, 70)
        Me.lblAjustes.TabIndex = 4
        Me.lblAjustes.Text = "Ajustes"
        Me.lblAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTema
        '
        Me.pnlTema.Controls.Add(Me.mrbtnOscuro)
        Me.pnlTema.Controls.Add(Me.mrbtnClaro)
        Me.pnlTema.Location = New System.Drawing.Point(124, 210)
        Me.pnlTema.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTema.Name = "pnlTema"
        Me.pnlTema.Size = New System.Drawing.Size(155, 123)
        Me.pnlTema.TabIndex = 20
        '
        'mrbtnOscuro
        '
        Me.mrbtnOscuro.AutoSize = True
        Me.mrbtnOscuro.Depth = 0
        Me.mrbtnOscuro.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbtnOscuro.Location = New System.Drawing.Point(27, 76)
        Me.mrbtnOscuro.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbtnOscuro.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbtnOscuro.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnOscuro.Name = "mrbtnOscuro"
        Me.mrbtnOscuro.Ripple = True
        Me.mrbtnOscuro.Size = New System.Drawing.Size(85, 30)
        Me.mrbtnOscuro.TabIndex = 31
        Me.mrbtnOscuro.TabStop = True
        Me.mrbtnOscuro.Text = "Oscuro"
        Me.mrbtnOscuro.UseVisualStyleBackColor = True
        '
        'mrbtnClaro
        '
        Me.mrbtnClaro.AutoSize = True
        Me.mrbtnClaro.Depth = 0
        Me.mrbtnClaro.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbtnClaro.Location = New System.Drawing.Point(27, 27)
        Me.mrbtnClaro.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbtnClaro.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbtnClaro.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnClaro.Name = "mrbtnClaro"
        Me.mrbtnClaro.Ripple = True
        Me.mrbtnClaro.Size = New System.Drawing.Size(71, 30)
        Me.mrbtnClaro.TabIndex = 30
        Me.mrbtnClaro.TabStop = True
        Me.mrbtnClaro.Text = "Claro"
        Me.mrbtnClaro.UseVisualStyleBackColor = True
        '
        'lblTema
        '
        Me.lblTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTema.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTema.ForeColor = System.Drawing.Color.Black
        Me.lblTema.Location = New System.Drawing.Point(153, 144)
        Me.lblTema.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTema.Name = "lblTema"
        Me.lblTema.Size = New System.Drawing.Size(96, 36)
        Me.lblTema.TabIndex = 23
        Me.lblTema.Text = "Tema"
        Me.lblTema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'msdDivisor
        '
        Me.msdDivisor.Location = New System.Drawing.Point(124, 423)
        Me.msdDivisor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.msdDivisor.Name = "msdDivisor"
        Me.msdDivisor.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal
        Me.msdDivisor.Size = New System.Drawing.Size(547, 4)
        Me.msdDivisor.Style = MetroSet_UI.Design.Style.Light
        Me.msdDivisor.StyleManager = Nothing
        Me.msdDivisor.TabIndex = 25
        Me.msdDivisor.Text = "MetroSetDivider1"
        Me.msdDivisor.ThemeAuthor = "Narwin"
        Me.msdDivisor.ThemeName = "MetroLite"
        Me.msdDivisor.Thickness = 1
        '
        'lblIdioma
        '
        Me.lblIdioma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdioma.ForeColor = System.Drawing.Color.Black
        Me.lblIdioma.Location = New System.Drawing.Point(487, 144)
        Me.lblIdioma.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(128, 36)
        Me.lblIdioma.TabIndex = 26
        Me.lblIdioma.Text = "Idioma"
        Me.lblIdioma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_Idioma
        '
        Me.pnl_Idioma.Controls.Add(Me.mrbtnIngles)
        Me.pnl_Idioma.Controls.Add(Me.mrbtnEspañol)
        Me.pnl_Idioma.Location = New System.Drawing.Point(449, 210)
        Me.pnl_Idioma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_Idioma.Name = "pnl_Idioma"
        Me.pnl_Idioma.Size = New System.Drawing.Size(203, 123)
        Me.pnl_Idioma.TabIndex = 22
        '
        'mrbtnIngles
        '
        Me.mrbtnIngles.AutoSize = True
        Me.mrbtnIngles.Depth = 0
        Me.mrbtnIngles.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbtnIngles.Location = New System.Drawing.Point(39, 76)
        Me.mrbtnIngles.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbtnIngles.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbtnIngles.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnIngles.Name = "mrbtnIngles"
        Me.mrbtnIngles.Ripple = True
        Me.mrbtnIngles.Size = New System.Drawing.Size(77, 30)
        Me.mrbtnIngles.TabIndex = 32
        Me.mrbtnIngles.TabStop = True
        Me.mrbtnIngles.Text = "Inglés"
        Me.mrbtnIngles.UseVisualStyleBackColor = True
        '
        'mrbtnEspañol
        '
        Me.mrbtnEspañol.AutoSize = True
        Me.mrbtnEspañol.Depth = 0
        Me.mrbtnEspañol.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.mrbtnEspañol.Location = New System.Drawing.Point(39, 27)
        Me.mrbtnEspañol.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbtnEspañol.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbtnEspañol.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnEspañol.Name = "mrbtnEspañol"
        Me.mrbtnEspañol.Ripple = True
        Me.mrbtnEspañol.Size = New System.Drawing.Size(91, 30)
        Me.mrbtnEspañol.TabIndex = 31
        Me.mrbtnEspañol.TabStop = True
        Me.mrbtnEspañol.Text = "Español"
        Me.mrbtnEspañol.UseVisualStyleBackColor = True
        '
        'mrbtnAplicarCambios
        '
        Me.mrbtnAplicarCambios.AutoSize = True
        Me.mrbtnAplicarCambios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mrbtnAplicarCambios.Depth = 0
        Me.mrbtnAplicarCambios.Icon = Nothing
        Me.mrbtnAplicarCambios.Location = New System.Drawing.Point(301, 491)
        Me.mrbtnAplicarCambios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mrbtnAplicarCambios.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbtnAplicarCambios.Name = "mrbtnAplicarCambios"
        Me.mrbtnAplicarCambios.Primary = True
        Me.mrbtnAplicarCambios.Size = New System.Drawing.Size(172, 36)
        Me.mrbtnAplicarCambios.TabIndex = 126
        Me.mrbtnAplicarCambios.Text = "Aplicar cambios"
        Me.mrbtnAplicarCambios.UseVisualStyleBackColor = True
        '
        'frmAjustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(791, 567)
        Me.Controls.Add(Me.pnlTitulo)
        Me.Controls.Add(Me.lblTema)
        Me.Controls.Add(Me.pnlTema)
        Me.Controls.Add(Me.lblIdioma)
        Me.Controls.Add(Me.pnl_Idioma)
        Me.Controls.Add(Me.msdDivisor)
        Me.Controls.Add(Me.mrbtnAplicarCambios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAjustes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.pnlTitulo.ResumeLayout(False)
        Me.pnlTema.ResumeLayout(False)
        Me.pnlTema.PerformLayout()
        Me.pnl_Idioma.ResumeLayout(False)
        Me.pnl_Idioma.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTitulo As Panel
    Friend WithEvents lblMinimizar As Label
    Friend WithEvents lblCerrar As Label
    Friend WithEvents lblAjustes As Label
    Friend WithEvents pnlTema As Panel
    Friend WithEvents lblTema As Label
    Friend WithEvents msdDivisor As MetroSet_UI.Controls.MetroSetDivider
    Friend WithEvents lblIdioma As Label
    Friend WithEvents pnl_Idioma As Panel
    Friend WithEvents mrbtnClaro As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbtnOscuro As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbtnIngles As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbtnEspañol As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbtnAplicarCambios As MaterialSkin.Controls.MaterialRaisedButton
End Class
