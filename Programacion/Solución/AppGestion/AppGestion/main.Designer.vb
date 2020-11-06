<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.ventana = New System.Windows.Forms.Panel()
        Me.pnlCerrar = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New FontAwesome.Sharp.IconButton()
        Me.btnSalir = New FontAwesome.Sharp.IconButton()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.pnlCerrar.SuspendLayout()
        Me.SuspendLayout()
        '
        'ventana
        '
        Me.ventana.AutoSize = True
        Me.ventana.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ventana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ventana.Location = New System.Drawing.Point(0, 40)
        Me.ventana.Name = "ventana"
        Me.ventana.Size = New System.Drawing.Size(871, 494)
        Me.ventana.TabIndex = 0
        '
        'pnlCerrar
        '
        Me.pnlCerrar.AutoSize = True
        Me.pnlCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlCerrar.Controls.Add(Me.btnMinimizar)
        Me.pnlCerrar.Controls.Add(Me.btnSalir)
        Me.pnlCerrar.Controls.Add(Me.lblApp)
        Me.pnlCerrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCerrar.Location = New System.Drawing.Point(0, 0)
        Me.pnlCerrar.Name = "pnlCerrar"
        Me.pnlCerrar.Size = New System.Drawing.Size(871, 40)
        Me.pnlCerrar.TabIndex = 10
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimizar.IconColor = System.Drawing.Color.White
        Me.btnMinimizar.IconSize = 19
        Me.btnMinimizar.Location = New System.Drawing.Point(791, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Padding = New System.Windows.Forms.Padding(0, 2, 4, 10)
        Me.btnMinimizar.Rotation = 0R
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 37)
        Me.btnMinimizar.TabIndex = 4
        Me.btnMinimizar.Text = " "
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnSalir.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnSalir.IconColor = System.Drawing.Color.White
        Me.btnSalir.IconSize = 20
        Me.btnSalir.Location = New System.Drawing.Point(831, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(0, 4, 5, 0)
        Me.btnSalir.Rotation = 0R
        Me.btnSalir.Size = New System.Drawing.Size(40, 37)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = " "
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblApp
        '
        Me.lblApp.AutoSize = True
        Me.lblApp.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApp.ForeColor = System.Drawing.Color.White
        Me.lblApp.Location = New System.Drawing.Point(12, 11)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(94, 18)
        Me.lblApp.TabIndex = 2
        Me.lblApp.Text = "Administración"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(871, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.ventana)
        Me.Controls.Add(Me.pnlCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlCerrar.ResumeLayout(False)
        Me.pnlCerrar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents ventana As Panel
    Public WithEvents pnlCerrar As Panel
    Friend WithEvents lblApp As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimizar As FontAwesome.Sharp.IconButton
End Class
