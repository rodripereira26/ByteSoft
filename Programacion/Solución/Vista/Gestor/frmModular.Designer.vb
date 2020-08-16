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
        Me.lblSubtituloIngresar = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblIngresar = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlOpcion2 = New System.Windows.Forms.Panel()
        Me.lblSubtituloListadoDe = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblListadoDe = New System.Windows.Forms.Label()
        Me.pnlOpcion1.SuspendLayout()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlOpcion2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlOpcion1
        '
        Me.pnlOpcion1.BackColor = System.Drawing.Color.White
        Me.pnlOpcion1.Controls.Add(Me.lblSubtituloIngresar)
        Me.pnlOpcion1.Controls.Add(Me.Panel7)
        Me.pnlOpcion1.Controls.Add(Me.lblIngresar)
        Me.pnlOpcion1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlOpcion1.Location = New System.Drawing.Point(100, 100)
        Me.pnlOpcion1.Name = "pnlOpcion1"
        Me.pnlOpcion1.Size = New System.Drawing.Size(565, 151)
        Me.pnlOpcion1.TabIndex = 7
        '
        'lblSubtituloIngresar
        '
        Me.lblSubtituloIngresar.AutoSize = True
        Me.lblSubtituloIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubtituloIngresar.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtituloIngresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblSubtituloIngresar.Location = New System.Drawing.Point(25, 80)
        Me.lblSubtituloIngresar.Name = "lblSubtituloIngresar"
        Me.lblSubtituloIngresar.Size = New System.Drawing.Size(0, 24)
        Me.lblSubtituloIngresar.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(564, 14)
        Me.Panel7.TabIndex = 2
        '
        'lblIngresar
        '
        Me.lblIngresar.AutoSize = True
        Me.lblIngresar.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblIngresar.Location = New System.Drawing.Point(22, 28)
        Me.lblIngresar.Name = "lblIngresar"
        Me.lblIngresar.Size = New System.Drawing.Size(146, 39)
        Me.lblIngresar.TabIndex = 0
        Me.lblIngresar.Text = "Registrar"
        '
        'Label12
        '
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(692, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 35)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "_"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(722, 6)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 35)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "X"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.lblTitulo)
        Me.pnlTopBar.Controls.Add(Me.Label12)
        Me.pnlTopBar.Controls.Add(Me.Label13)
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
        Me.pnlOpcion2.Controls.Add(Me.lblSubtituloListadoDe)
        Me.pnlOpcion2.Controls.Add(Me.Panel5)
        Me.pnlOpcion2.Controls.Add(Me.lblListadoDe)
        Me.pnlOpcion2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlOpcion2.Location = New System.Drawing.Point(100, 270)
        Me.pnlOpcion2.Name = "pnlOpcion2"
        Me.pnlOpcion2.Size = New System.Drawing.Size(565, 156)
        Me.pnlOpcion2.TabIndex = 11
        '
        'lblSubtituloListadoDe
        '
        Me.lblSubtituloListadoDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSubtituloListadoDe.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtituloListadoDe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblSubtituloListadoDe.Location = New System.Drawing.Point(26, 75)
        Me.lblSubtituloListadoDe.Name = "lblSubtituloListadoDe"
        Me.lblSubtituloListadoDe.Size = New System.Drawing.Size(512, 60)
        Me.lblSubtituloListadoDe.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(564, 12)
        Me.Panel5.TabIndex = 2
        '
        'lblListadoDe
        '
        Me.lblListadoDe.AutoSize = True
        Me.lblListadoDe.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListadoDe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.lblListadoDe.Location = New System.Drawing.Point(23, 25)
        Me.lblListadoDe.Name = "lblListadoDe"
        Me.lblListadoDe.Size = New System.Drawing.Size(0, 39)
        Me.lblListadoDe.TabIndex = 0
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
    Friend WithEvents lblSubtituloIngresar As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblIngresar As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents pnlTopBar As Panel
    Friend WithEvents pnlOpcion2 As Panel
    Friend WithEvents lblSubtituloListadoDe As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblListadoDe As Label
    Friend WithEvents lblTitulo As Label
End Class
