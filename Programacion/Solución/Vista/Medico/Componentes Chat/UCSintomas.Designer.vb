<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCSintomas
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
        Me.mpcSintomas = New MetroFramework.Controls.MetroTabControl()
        Me.mtpSintomas = New MetroFramework.Controls.MetroTabPage()
        Me.mtpDiagnosticos = New MetroFramework.Controls.MetroTabPage()
        Me.mpcSintomas.SuspendLayout()
        Me.SuspendLayout()
        '
        'mpcSintomas
        '
        Me.mpcSintomas.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.mpcSintomas.Controls.Add(Me.mtpSintomas)
        Me.mpcSintomas.Controls.Add(Me.mtpDiagnosticos)
        Me.mpcSintomas.HotTrack = True
        Me.mpcSintomas.Location = New System.Drawing.Point(27, 30)
        Me.mpcSintomas.Margin = New System.Windows.Forms.Padding(4)
        Me.mpcSintomas.Name = "mpcSintomas"
        Me.mpcSintomas.SelectedIndex = 0
        Me.mpcSintomas.Size = New System.Drawing.Size(359, 394)
        Me.mpcSintomas.Style = MetroFramework.MetroColorStyle.Black
        Me.mpcSintomas.TabIndex = 4
        Me.mpcSintomas.UseCustomBackColor = True
        Me.mpcSintomas.UseCustomForeColor = True
        Me.mpcSintomas.UseSelectable = True
        Me.mpcSintomas.UseStyleColors = True
        '
        'mtpSintomas
        '
        Me.mtpSintomas.BackColor = System.Drawing.Color.White
        Me.mtpSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtpSintomas.HorizontalScrollbarBarColor = True
        Me.mtpSintomas.HorizontalScrollbarHighlightOnWheel = False
        Me.mtpSintomas.HorizontalScrollbarSize = 12
        Me.mtpSintomas.Location = New System.Drawing.Point(4, 41)
        Me.mtpSintomas.Margin = New System.Windows.Forms.Padding(4)
        Me.mtpSintomas.Name = "mtpSintomas"
        Me.mtpSintomas.Size = New System.Drawing.Size(351, 349)
        Me.mtpSintomas.TabIndex = 0
        Me.mtpSintomas.Text = "SINTOMAS"
        Me.mtpSintomas.VerticalScrollbarBarColor = True
        Me.mtpSintomas.VerticalScrollbarHighlightOnWheel = False
        Me.mtpSintomas.VerticalScrollbarSize = 13
        '
        'mtpDiagnosticos
        '
        Me.mtpDiagnosticos.BackColor = System.Drawing.Color.White
        Me.mtpDiagnosticos.HorizontalScrollbarBarColor = True
        Me.mtpDiagnosticos.HorizontalScrollbarHighlightOnWheel = False
        Me.mtpDiagnosticos.HorizontalScrollbarSize = 12
        Me.mtpDiagnosticos.Location = New System.Drawing.Point(4, 41)
        Me.mtpDiagnosticos.Margin = New System.Windows.Forms.Padding(4)
        Me.mtpDiagnosticos.Name = "mtpDiagnosticos"
        Me.mtpDiagnosticos.Size = New System.Drawing.Size(351, 349)
        Me.mtpDiagnosticos.TabIndex = 1
        Me.mtpDiagnosticos.Text = "DIAGNOSTICOS"
        Me.mtpDiagnosticos.VerticalScrollbarBarColor = True
        Me.mtpDiagnosticos.VerticalScrollbarHighlightOnWheel = False
        Me.mtpDiagnosticos.VerticalScrollbarSize = 13
        '
        'UCSintomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.mpcSintomas)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UCSintomas"
        Me.Size = New System.Drawing.Size(665, 513)
        Me.mpcSintomas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mpcSintomas As MetroFramework.Controls.MetroTabControl
    Friend WithEvents mtpSintomas As MetroFramework.Controls.MetroTabPage
    Friend WithEvents mtpDiagnosticos As MetroFramework.Controls.MetroTabPage
End Class
