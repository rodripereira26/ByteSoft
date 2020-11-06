<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UCChat
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lblCed = New System.Windows.Forms.Label()
        Me.lblidChat = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.GunaCirclePictureBox1 = New Guna.UI.WinForms.GunaCirclePictureBox()
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCed
        '
        Me.lblCed.Enabled = False
        Me.lblCed.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblCed.Location = New System.Drawing.Point(31, 0)
        Me.lblCed.Name = "lblCed"
        Me.lblCed.Size = New System.Drawing.Size(10, 18)
        Me.lblCed.TabIndex = 13
        Me.lblCed.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblCed.Visible = False
        '
        'lblidChat
        '
        Me.lblidChat.Enabled = False
        Me.lblidChat.Font = New System.Drawing.Font("Segoe UI Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblidChat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblidChat.Location = New System.Drawing.Point(9, 0)
        Me.lblidChat.Name = "lblidChat"
        Me.lblidChat.Size = New System.Drawing.Size(12, 18)
        Me.lblidChat.TabIndex = 11
        Me.lblidChat.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblidChat.Visible = False
        '
        'lblFecha
        '
        Me.lblFecha.Enabled = False
        Me.lblFecha.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.lblFecha.Location = New System.Drawing.Point(246, 10)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(46, 18)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(76, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(73, 21)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre"
        '
        'lblMensaje
        '
        Me.lblMensaje.Enabled = False
        Me.lblMensaje.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.lblMensaje.Location = New System.Drawing.Point(77, 44)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(172, 42)
        Me.lblMensaje.TabIndex = 7
        Me.lblMensaje.Text = "sssssssssssssssssssssssssssssssssssssssss"
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaCirclePictureBox1
        '
        Me.GunaCirclePictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCirclePictureBox1.Location = New System.Drawing.Point(12, 19)
        Me.GunaCirclePictureBox1.Name = "GunaCirclePictureBox1"
        Me.GunaCirclePictureBox1.Size = New System.Drawing.Size(52, 52)
        Me.GunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaCirclePictureBox1.TabIndex = 14
        Me.GunaCirclePictureBox1.TabStop = False
        Me.GunaCirclePictureBox1.UseTransfarantBackground = False
        '
        'UCChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.GunaCirclePictureBox1)
        Me.Controls.Add(Me.lblCed)
        Me.Controls.Add(Me.lblMensaje)
        Me.Controls.Add(Me.lblidChat)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblNombre)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "UCChat"
        Me.Size = New System.Drawing.Size(296, 95)
        CType(Me.GunaCirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblCed As Label
    Friend WithEvents lblidChat As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblMensaje As Label
    Friend WithEvents GunaCirclePictureBox1 As Guna.UI.WinForms.GunaCirclePictureBox
End Class
