<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
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
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblRecomendaciones = New System.Windows.Forms.Label()
        Me.msdDec = New MetroSet_UI.Controls.MetroSetDivider()
        Me.lblVerSintomas = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.pnlTituloPatologia = New System.Windows.Forms.Panel()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblRec = New System.Windows.Forms.Label()
        Me.pnlTituloPatologia.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(316, 188)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(188, 36)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripción: "
        '
        'lblRecomendaciones
        '
        Me.lblRecomendaciones.AutoSize = True
        Me.lblRecomendaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecomendaciones.Location = New System.Drawing.Point(277, 334)
        Me.lblRecomendaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecomendaciones.Name = "lblRecomendaciones"
        Me.lblRecomendaciones.Size = New System.Drawing.Size(269, 36)
        Me.lblRecomendaciones.TabIndex = 1
        Me.lblRecomendaciones.Text = "Recomendaciones:"
        '
        'msdDec
        '
        Me.msdDec.Location = New System.Drawing.Point(204, 145)
        Me.msdDec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.msdDec.Name = "msdDec"
        Me.msdDec.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal
        Me.msdDec.Size = New System.Drawing.Size(401, 4)
        Me.msdDec.Style = MetroSet_UI.Design.Style.Light
        Me.msdDec.StyleManager = Nothing
        Me.msdDec.TabIndex = 2
        Me.msdDec.Text = "MetroSetDivider1"
        Me.msdDec.ThemeAuthor = "Narwin"
        Me.msdDec.ThemeName = "MetroLite"
        Me.msdDec.Thickness = 1
        '
        'lblVerSintomas
        '
        Me.lblVerSintomas.AutoSize = True
        Me.lblVerSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerSintomas.Location = New System.Drawing.Point(315, 463)
        Me.lblVerSintomas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVerSintomas.Name = "lblVerSintomas"
        Me.lblVerSintomas.Size = New System.Drawing.Size(188, 36)
        Me.lblVerSintomas.TabIndex = 3
        Me.lblVerSintomas.Text = "Ver síntomas"
        '
        'lblNom
        '
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(204, 71)
        Me.lblNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(401, 47)
        Me.lblNom.TabIndex = 4
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTituloPatologia
        '
        Me.pnlTituloPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTituloPatologia.Controls.Add(Me.btnAtras)
        Me.pnlTituloPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituloPatologia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTituloPatologia.Name = "pnlTituloPatologia"
        Me.pnlTituloPatologia.Size = New System.Drawing.Size(809, 44)
        Me.pnlTituloPatologia.TabIndex = 148
        '
        'btnAtras
        '
        Me.btnAtras.BackgroundImage = Global.Vista.My.Resources.Resources.icons8_left_32px
        Me.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Location = New System.Drawing.Point(0, 0)
        Me.btnAtras.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAtras.Size = New System.Drawing.Size(65, 39)
        Me.btnAtras.TabIndex = 152
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(200, 234)
        Me.lblDesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(408, 73)
        Me.lblDesc.TabIndex = 149
        '
        'lblRec
        '
        Me.lblRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRec.Location = New System.Drawing.Point(200, 378)
        Me.lblRec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRec.Name = "lblRec"
        Me.lblRec.Size = New System.Drawing.Size(408, 58)
        Me.lblRec.TabIndex = 151
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.pnlTituloPatologia)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.msdDec)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblRecomendaciones)
        Me.Controls.Add(Me.lblRec)
        Me.Controls.Add(Me.lblVerSintomas)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(807, 663)
        Me.pnlTituloPatologia.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblRecomendaciones As Label
    Friend WithEvents msdDec As MetroSet_UI.Controls.MetroSetDivider
    Friend WithEvents lblVerSintomas As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents pnlTituloPatologia As Panel
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblRec As Label
    Friend WithEvents btnAtras As Button
End Class
