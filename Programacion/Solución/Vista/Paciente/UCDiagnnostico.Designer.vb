<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDiagnnostico
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblDescropcionPat = New System.Windows.Forms.Label()
        Me.btnRecomendacionPattt = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtRecomendacion = New System.Windows.Forms.TextBox()
        Me.pnlPatologia = New Guna.UI.WinForms.GunaElipsePanel()
        Me.pnlWrap = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnMasRec = New FontAwesome.Sharp.IconButton()
        Me.btnMasDesc = New FontAwesome.Sharp.IconButton()
        Me.pbAdvertencia = New FontAwesome.Sharp.IconPictureBox()
        Me.btnSintomas = New Guna.UI.WinForms.GunaButton()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.pnlWrap.SuspendLayout()
        CType(Me.pbAdvertencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNom
        '
        Me.lblNom.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblNom.Location = New System.Drawing.Point(20, 46)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(225, 57)
        Me.lblNom.TabIndex = 190
        Me.lblNom.Text = "nom"
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDescropcionPat
        '
        Me.lblDescropcionPat.AutoSize = True
        Me.lblDescropcionPat.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescropcionPat.ForeColor = System.Drawing.Color.White
        Me.lblDescropcionPat.Location = New System.Drawing.Point(21, 108)
        Me.lblDescropcionPat.Name = "lblDescropcionPat"
        Me.lblDescropcionPat.Size = New System.Drawing.Size(89, 20)
        Me.lblDescropcionPat.TabIndex = 194
        Me.lblDescropcionPat.Text = "Descripción"
        '
        'btnRecomendacionPattt
        '
        Me.btnRecomendacionPattt.AutoSize = True
        Me.btnRecomendacionPattt.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecomendacionPattt.ForeColor = System.Drawing.Color.White
        Me.btnRecomendacionPattt.Location = New System.Drawing.Point(21, 251)
        Me.btnRecomendacionPattt.Name = "btnRecomendacionPattt"
        Me.btnRecomendacionPattt.Size = New System.Drawing.Size(118, 20)
        Me.btnRecomendacionPattt.TabIndex = 195
        Me.btnRecomendacionPattt.Text = "Recomendación"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Silver
        Me.txtDescripcion.Location = New System.Drawing.Point(18, 147)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(227, 81)
        Me.txtDescripcion.TabIndex = 196
        '
        'txtRecomendacion
        '
        Me.txtRecomendacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.txtRecomendacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRecomendacion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecomendacion.ForeColor = System.Drawing.Color.Silver
        Me.txtRecomendacion.Location = New System.Drawing.Point(18, 287)
        Me.txtRecomendacion.Margin = New System.Windows.Forms.Padding(0)
        Me.txtRecomendacion.Multiline = True
        Me.txtRecomendacion.Name = "txtRecomendacion"
        Me.txtRecomendacion.ReadOnly = True
        Me.txtRecomendacion.Size = New System.Drawing.Size(227, 137)
        Me.txtRecomendacion.TabIndex = 197
        '
        'pnlPatologia
        '
        Me.pnlPatologia.BackColor = System.Drawing.Color.Transparent
        Me.pnlPatologia.BaseColor = System.Drawing.Color.Lime
        Me.pnlPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlPatologia.Name = "pnlPatologia"
        Me.pnlPatologia.Size = New System.Drawing.Size(582, 486)
        Me.pnlPatologia.TabIndex = 199
        Me.pnlPatologia.Visible = False
        '
        'pnlWrap
        '
        Me.pnlWrap.BackColor = System.Drawing.Color.Transparent
        Me.pnlWrap.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.pnlWrap.Controls.Add(Me.btnMasRec)
        Me.pnlWrap.Controls.Add(Me.btnMasDesc)
        Me.pnlWrap.Controls.Add(Me.pbAdvertencia)
        Me.pnlWrap.Controls.Add(Me.btnSintomas)
        Me.pnlWrap.Controls.Add(Me.txtRecomendacion)
        Me.pnlWrap.Controls.Add(Me.txtDescripcion)
        Me.pnlWrap.Controls.Add(Me.btnRecomendacionPattt)
        Me.pnlWrap.Controls.Add(Me.lblDescropcionPat)
        Me.pnlWrap.Controls.Add(Me.lblNom)
        Me.pnlWrap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlWrap.Location = New System.Drawing.Point(0, 0)
        Me.pnlWrap.Name = "pnlWrap"
        Me.pnlWrap.Size = New System.Drawing.Size(262, 514)
        Me.pnlWrap.TabIndex = 200
        '
        'btnMasRec
        '
        Me.btnMasRec.AutoSize = True
        Me.btnMasRec.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnMasRec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMasRec.FlatAppearance.BorderSize = 0
        Me.btnMasRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasRec.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnMasRec.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasRec.ForeColor = System.Drawing.Color.Silver
        Me.btnMasRec.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnMasRec.IconColor = System.Drawing.Color.Silver
        Me.btnMasRec.IconSize = 15
        Me.btnMasRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMasRec.Location = New System.Drawing.Point(142, 249)
        Me.btnMasRec.Name = "btnMasRec"
        Me.btnMasRec.Rotation = 0R
        Me.btnMasRec.Size = New System.Drawing.Size(103, 27)
        Me.btnMasRec.TabIndex = 205
        Me.btnMasRec.Text = "Mostrar más"
        Me.btnMasRec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMasRec.UseVisualStyleBackColor = False
        '
        'btnMasDesc
        '
        Me.btnMasDesc.AutoSize = True
        Me.btnMasDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnMasDesc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMasDesc.FlatAppearance.BorderSize = 0
        Me.btnMasDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasDesc.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnMasDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMasDesc.ForeColor = System.Drawing.Color.Silver
        Me.btnMasDesc.IconChar = FontAwesome.Sharp.IconChar.Plus
        Me.btnMasDesc.IconColor = System.Drawing.Color.Silver
        Me.btnMasDesc.IconSize = 15
        Me.btnMasDesc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMasDesc.Location = New System.Drawing.Point(142, 106)
        Me.btnMasDesc.Name = "btnMasDesc"
        Me.btnMasDesc.Rotation = 0R
        Me.btnMasDesc.Size = New System.Drawing.Size(103, 27)
        Me.btnMasDesc.TabIndex = 204
        Me.btnMasDesc.Text = "Mostrar más"
        Me.btnMasDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMasDesc.UseVisualStyleBackColor = False
        '
        'pbAdvertencia
        '
        Me.pbAdvertencia.BackColor = System.Drawing.Color.Transparent
        Me.pbAdvertencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbAdvertencia.ForeColor = System.Drawing.Color.IndianRed
        Me.pbAdvertencia.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle
        Me.pbAdvertencia.IconColor = System.Drawing.Color.IndianRed
        Me.pbAdvertencia.Location = New System.Drawing.Point(115, 6)
        Me.pbAdvertencia.Name = "pbAdvertencia"
        Me.pbAdvertencia.Size = New System.Drawing.Size(32, 32)
        Me.pbAdvertencia.TabIndex = 199
        Me.pbAdvertencia.TabStop = False
        '
        'btnSintomas
        '
        Me.btnSintomas.Animated = True
        Me.btnSintomas.AnimationHoverSpeed = 0.07!
        Me.btnSintomas.AnimationSpeed = 0.03!
        Me.btnSintomas.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnSintomas.BorderColor = System.Drawing.Color.Black
        Me.btnSintomas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSintomas.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSintomas.FocusedColor = System.Drawing.Color.Empty
        Me.btnSintomas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSintomas.ForeColor = System.Drawing.Color.White
        Me.btnSintomas.Image = Nothing
        Me.btnSintomas.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSintomas.Location = New System.Drawing.Point(51, 454)
        Me.btnSintomas.Name = "btnSintomas"
        Me.btnSintomas.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSintomas.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSintomas.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSintomas.OnHoverImage = Nothing
        Me.btnSintomas.OnPressedColor = System.Drawing.Color.Black
        Me.btnSintomas.Size = New System.Drawing.Size(160, 42)
        Me.btnSintomas.TabIndex = 198
        Me.btnSintomas.Text = "VER SÍNTOMAS"
        Me.btnSintomas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.AutomaticDelay = 0
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'UCDiagnnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.Controls.Add(Me.pnlWrap)
        Me.Controls.Add(Me.pnlPatologia)
        Me.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Name = "UCDiagnnostico"
        Me.Size = New System.Drawing.Size(262, 514)
        Me.pnlWrap.ResumeLayout(False)
        Me.pnlWrap.PerformLayout()
        CType(Me.pbAdvertencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNom As Label
    Friend WithEvents btnRecomendacionPattt As Label
    Friend WithEvents lblDescropcionPat As Label
    Friend WithEvents txtRecomendacion As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents pnlPatologia As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents pnlWrap As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents btnSintomas As Guna.UI.WinForms.GunaButton
    Friend WithEvents pbAdvertencia As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents btnMasDesc As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMasRec As FontAwesome.Sharp.IconButton
End Class
