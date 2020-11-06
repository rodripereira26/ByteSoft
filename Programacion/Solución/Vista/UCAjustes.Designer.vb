<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCAjustes
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblTituloAjustes = New System.Windows.Forms.Label()
        Me.cbIdiomas = New Guna.UI.WinForms.GunaComboBox()
        Me.lblIdiomaAjustes = New System.Windows.Forms.Label()
        Me.btnAplicarCambiosAjustes = New Guna.UI.WinForms.GunaButton()
        Me.GunaSeparator3 = New Guna.UI.WinForms.GunaSeparator()
        Me.SuspendLayout()
        '
        'lblTituloAjustes
        '
        Me.lblTituloAjustes.AutoSize = True
        Me.lblTituloAjustes.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloAjustes.ForeColor = System.Drawing.Color.White
        Me.lblTituloAjustes.Location = New System.Drawing.Point(195, 25)
        Me.lblTituloAjustes.Name = "lblTituloAjustes"
        Me.lblTituloAjustes.Size = New System.Drawing.Size(143, 30)
        Me.lblTituloAjustes.TabIndex = 0
        Me.lblTituloAjustes.Text = "Configuración"
        '
        'cbIdiomas
        '
        Me.cbIdiomas.BackColor = System.Drawing.Color.Transparent
        Me.cbIdiomas.BaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbIdiomas.BorderColor = System.Drawing.Color.Silver
        Me.cbIdiomas.BorderSize = 0
        Me.cbIdiomas.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbIdiomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbIdiomas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbIdiomas.FocusedColor = System.Drawing.Color.Empty
        Me.cbIdiomas.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbIdiomas.ForeColor = System.Drawing.Color.White
        Me.cbIdiomas.FormattingEnabled = True
        Me.cbIdiomas.Items.AddRange(New Object() {"Español", "Inglés"})
        Me.cbIdiomas.Location = New System.Drawing.Point(165, 138)
        Me.cbIdiomas.Name = "cbIdiomas"
        Me.cbIdiomas.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbIdiomas.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbIdiomas.Size = New System.Drawing.Size(192, 26)
        Me.cbIdiomas.Sorted = True
        Me.cbIdiomas.TabIndex = 3
        '
        'lblIdiomaAjustes
        '
        Me.lblIdiomaAjustes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdiomaAjustes.ForeColor = System.Drawing.Color.White
        Me.lblIdiomaAjustes.Location = New System.Drawing.Point(165, 98)
        Me.lblIdiomaAjustes.Name = "lblIdiomaAjustes"
        Me.lblIdiomaAjustes.Size = New System.Drawing.Size(192, 21)
        Me.lblIdiomaAjustes.TabIndex = 14
        Me.lblIdiomaAjustes.Text = "Idioma"
        Me.lblIdiomaAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAplicarCambiosAjustes
        '
        Me.btnAplicarCambiosAjustes.AnimationHoverSpeed = 0.07!
        Me.btnAplicarCambiosAjustes.AnimationSpeed = 0.03!
        Me.btnAplicarCambiosAjustes.BackColor = System.Drawing.Color.Transparent
        Me.btnAplicarCambiosAjustes.BaseColor = System.Drawing.Color.DarkSlateBlue
        Me.btnAplicarCambiosAjustes.BorderColor = System.Drawing.Color.Black
        Me.btnAplicarCambiosAjustes.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAplicarCambiosAjustes.FocusedColor = System.Drawing.Color.Empty
        Me.btnAplicarCambiosAjustes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicarCambiosAjustes.ForeColor = System.Drawing.Color.White
        Me.btnAplicarCambiosAjustes.Image = Nothing
        Me.btnAplicarCambiosAjustes.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAplicarCambiosAjustes.Location = New System.Drawing.Point(178, 329)
        Me.btnAplicarCambiosAjustes.Name = "btnAplicarCambiosAjustes"
        Me.btnAplicarCambiosAjustes.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.btnAplicarCambiosAjustes.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAplicarCambiosAjustes.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAplicarCambiosAjustes.OnHoverImage = Nothing
        Me.btnAplicarCambiosAjustes.OnPressedColor = System.Drawing.Color.Black
        Me.btnAplicarCambiosAjustes.Radius = 14
        Me.btnAplicarCambiosAjustes.Size = New System.Drawing.Size(160, 42)
        Me.btnAplicarCambiosAjustes.TabIndex = 17
        Me.btnAplicarCambiosAjustes.Tag = ""
        Me.btnAplicarCambiosAjustes.Text = "Aplicar cambios"
        Me.btnAplicarCambiosAjustes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaSeparator3
        '
        Me.GunaSeparator3.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator3.Location = New System.Drawing.Point(181, 184)
        Me.GunaSeparator3.Name = "GunaSeparator3"
        Me.GunaSeparator3.Size = New System.Drawing.Size(160, 33)
        Me.GunaSeparator3.TabIndex = 18
        '
        'UCAjustes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.Controls.Add(Me.GunaSeparator3)
        Me.Controls.Add(Me.btnAplicarCambiosAjustes)
        Me.Controls.Add(Me.lblIdiomaAjustes)
        Me.Controls.Add(Me.cbIdiomas)
        Me.Controls.Add(Me.lblTituloAjustes)
        Me.Name = "UCAjustes"
        Me.Size = New System.Drawing.Size(522, 441)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTituloAjustes As Label
    Friend WithEvents cbIdiomas As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents lblIdiomaAjustes As Label
    Friend WithEvents btnAplicarCambiosAjustes As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaSeparator3 As Guna.UI.WinForms.GunaSeparator
End Class
