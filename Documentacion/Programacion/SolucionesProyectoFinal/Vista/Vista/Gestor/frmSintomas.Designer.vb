<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSintomas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.MaterialFlatButton2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(100, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(565, 151)
        Me.Panel1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(462, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Ingrese síntomas manualmente o desde un archivo CSV"
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        Me.MaterialFlatButton2.Location = New System.Drawing.Point(85, 265)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(73, 36)
        Me.MaterialFlatButton2.TabIndex = 4
        Me.MaterialFlatButton2.Text = "Entrar"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(569, 14)
        Me.Panel7.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Location = New System.Drawing.Point(100, 267)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(565, 156)
        Me.Panel4.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(26, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(512, 60)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Acceda a todos los síntomas registrados y a opciones de eliminar y modificar"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(564, 12)
        Me.Panel5.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(23, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(314, 40)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Listado de Síntomas"
        '
        'Label4
        '
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(248, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(252, 57)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Menú Síntomas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(767, 77)
        Me.Panel6.TabIndex = 5
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(747, 332)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(8, 8)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(765, 451)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSintomas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
