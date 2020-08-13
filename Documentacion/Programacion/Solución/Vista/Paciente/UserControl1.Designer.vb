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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MetroSetDivider1 = New MetroSet_UI.Controls.MetroSetDivider()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.pnlTituloPatologia = New System.Windows.Forms.Panel()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblRec = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlTituloPatologia.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descripción: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(208, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Recomendaciones:"
        '
        'MetroSetDivider1
        '
        Me.MetroSetDivider1.Location = New System.Drawing.Point(153, 118)
        Me.MetroSetDivider1.Name = "MetroSetDivider1"
        Me.MetroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal
        Me.MetroSetDivider1.Size = New System.Drawing.Size(301, 4)
        Me.MetroSetDivider1.Style = MetroSet_UI.Design.Style.Light
        Me.MetroSetDivider1.StyleManager = Nothing
        Me.MetroSetDivider1.TabIndex = 2
        Me.MetroSetDivider1.Text = "MetroSetDivider1"
        Me.MetroSetDivider1.ThemeAuthor = "Narwin"
        Me.MetroSetDivider1.ThemeName = "MetroLite"
        Me.MetroSetDivider1.Thickness = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(236, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ver síntomas"
        '
        'lblNom
        '
        Me.lblNom.Font = New System.Drawing.Font("Roboto", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(153, 58)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(301, 38)
        Me.lblNom.TabIndex = 4
        Me.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlTituloPatologia
        '
        Me.pnlTituloPatologia.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTituloPatologia.Controls.Add(Me.Button1)
        Me.pnlTituloPatologia.Location = New System.Drawing.Point(0, 0)
        Me.pnlTituloPatologia.Name = "pnlTituloPatologia"
        Me.pnlTituloPatologia.Size = New System.Drawing.Size(607, 36)
        Me.pnlTituloPatologia.TabIndex = 148
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(150, 190)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(306, 59)
        Me.lblDesc.TabIndex = 149
        '
        'lblRec
        '
        Me.lblRec.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRec.Location = New System.Drawing.Point(150, 307)
        Me.lblRec.Name = "lblRec"
        Me.lblRec.Size = New System.Drawing.Size(306, 47)
        Me.lblRec.TabIndex = 151
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Vista.My.Resources.Resources.icons8_left_32px
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(3)
        Me.Button1.Size = New System.Drawing.Size(49, 32)
        Me.Button1.TabIndex = 152
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.lblRec)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.pnlTituloPatologia)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MetroSetDivider1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(605, 539)
        Me.pnlTituloPatologia.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MetroSetDivider1 As MetroSet_UI.Controls.MetroSetDivider
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents pnlTituloPatologia As Panel
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblRec As Label
    Friend WithEvents Button1 As Button
End Class
