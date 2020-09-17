<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BsMsgbox
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
        Me.btnSi = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pb = New FontAwesome.Sharp.IconPictureBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pnlWrap = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlWrap.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSi
        '
        Me.btnSi.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btnSi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSi.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSi.FlatAppearance.BorderSize = 0
        Me.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSi.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSi.Location = New System.Drawing.Point(211, 0)
        Me.btnSi.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(195, 46)
        Me.btnSi.TabIndex = 1
        Me.btnSi.Tag = "1"
        Me.btnSi.Text = "Button2"
        Me.btnSi.UseVisualStyleBackColor = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.LightGray
        Me.btnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNo.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNo.FlatAppearance.BorderSize = 0
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNo.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(0, 0)
        Me.btnNo.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(211, 46)
        Me.btnNo.TabIndex = 2
        Me.btnNo.Tag = "0"
        Me.btnNo.Text = "Button1"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'lblMensaje
        '
        Me.lblMensaje.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.Location = New System.Drawing.Point(108, 20)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(210, 54)
        Me.lblMensaje.TabIndex = 3
        Me.lblMensaje.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pb)
        Me.Panel1.Controls.Add(Me.lblMensaje)
        Me.Panel1.Location = New System.Drawing.Point(31, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(321, 93)
        Me.Panel1.TabIndex = 5
        '
        'pb
        '
        Me.pb.BackColor = System.Drawing.Color.White
        Me.pb.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pb.IconChar = FontAwesome.Sharp.IconChar.CheckCircle
        Me.pb.IconColor = System.Drawing.SystemColors.ControlText
        Me.pb.IconSize = 50
        Me.pb.Location = New System.Drawing.Point(23, 20)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(50, 54)
        Me.pb.TabIndex = 5
        Me.pb.TabStop = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(177, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(53, 19)
        Me.lblTitulo.TabIndex = 5
        Me.lblTitulo.Text = "Label2"
        '
        'pnlWrap
        '
        Me.pnlWrap.Controls.Add(Me.btnSi)
        Me.pnlWrap.Controls.Add(Me.btnNo)
        Me.pnlWrap.Location = New System.Drawing.Point(0, 169)
        Me.pnlWrap.Name = "pnlWrap"
        Me.pnlWrap.Size = New System.Drawing.Size(406, 46)
        Me.pnlWrap.TabIndex = 6
        '
        'BsMsgbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(406, 215)
        Me.Controls.Add(Me.pnlWrap)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BsMsgbox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BsMsgbox"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlWrap.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSi As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents lblMensaje As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlWrap As Panel
    Friend WithEvents pb As FontAwesome.Sharp.IconPictureBox
End Class
