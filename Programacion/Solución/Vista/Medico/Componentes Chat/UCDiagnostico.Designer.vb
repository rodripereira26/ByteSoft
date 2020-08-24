<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCDiagnostico
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroSetTabControl1 = New MetroSet_UI.Controls.MetroSetTabControl()
        Me.fds = New MetroSet_UI.Child.MetroSetTabPage()
        Me.MetroSetTabPage2 = New MetroSet_UI.Child.MetroSetTabPage()
        Me.dgvSintomas = New System.Windows.Forms.DataGridView()
        Me.dgvDiagnosticos = New System.Windows.Forms.DataGridView()
        Me.MetroSetTabControl1.SuspendLayout()
        Me.fds.SuspendLayout()
        Me.MetroSetTabPage2.SuspendLayout()
        CType(Me.dgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroSetTabControl1
        '
        Me.MetroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut
        Me.MetroSetTabControl1.AnimateTime = 200
        Me.MetroSetTabControl1.Controls.Add(Me.fds)
        Me.MetroSetTabControl1.Controls.Add(Me.MetroSetTabPage2)
        Me.MetroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroSetTabControl1.ItemSize = New System.Drawing.Size(100, 38)
        Me.MetroSetTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroSetTabControl1.Name = "MetroSetTabControl1"
        Me.MetroSetTabControl1.SelectedIndex = 0
        Me.MetroSetTabControl1.Size = New System.Drawing.Size(417, 513)
        Me.MetroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MetroSetTabControl1.Speed = 20
        Me.MetroSetTabControl1.Style = MetroSet_UI.Design.Style.Light
        Me.MetroSetTabControl1.StyleManager = Nothing
        Me.MetroSetTabControl1.TabIndex = 1
        Me.MetroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style1
        Me.MetroSetTabControl1.ThemeAuthor = "Narwin"
        Me.MetroSetTabControl1.ThemeName = "MetroLite"
        Me.MetroSetTabControl1.UseAnimation = True
        '
        'fds
        '
        Me.fds.BaseColor = System.Drawing.Color.White
        Me.fds.Controls.Add(Me.dgvSintomas)
        Me.fds.ImageIndex = 0
        Me.fds.ImageKey = Nothing
        Me.fds.Location = New System.Drawing.Point(4, 42)
        Me.fds.Name = "fds"
        Me.fds.Size = New System.Drawing.Size(409, 467)
        Me.fds.Style = MetroSet_UI.Design.Style.Light
        Me.fds.StyleManager = Nothing
        Me.fds.TabIndex = 0
        Me.fds.Text = "SÍNTOMAS"
        Me.fds.ThemeAuthor = "Narwin"
        Me.fds.ThemeName = "MetroLite"
        Me.fds.ToolTipText = Nothing
        '
        'MetroSetTabPage2
        '
        Me.MetroSetTabPage2.BaseColor = System.Drawing.Color.White
        Me.MetroSetTabPage2.Controls.Add(Me.dgvDiagnosticos)
        Me.MetroSetTabPage2.ImageIndex = 0
        Me.MetroSetTabPage2.ImageKey = Nothing
        Me.MetroSetTabPage2.Location = New System.Drawing.Point(4, 42)
        Me.MetroSetTabPage2.Name = "MetroSetTabPage2"
        Me.MetroSetTabPage2.Size = New System.Drawing.Size(409, 467)
        Me.MetroSetTabPage2.Style = MetroSet_UI.Design.Style.Light
        Me.MetroSetTabPage2.StyleManager = Nothing
        Me.MetroSetTabPage2.TabIndex = 1
        Me.MetroSetTabPage2.Text = "DIAGNÓSTICOS TENTATIVOS"
        Me.MetroSetTabPage2.ThemeAuthor = "Narwin"
        Me.MetroSetTabPage2.ThemeName = "MetroLite"
        Me.MetroSetTabPage2.ToolTipText = Nothing
        '
        'dgvSintomas
        '
        Me.dgvSintomas.AllowUserToAddRows = False
        Me.dgvSintomas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvSintomas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSintomas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSintomas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSintomas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSintomas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvSintomas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSintomas.ColumnHeadersVisible = False
        Me.dgvSintomas.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSintomas.EnableHeadersVisualStyles = False
        Me.dgvSintomas.Location = New System.Drawing.Point(0, 0)
        Me.dgvSintomas.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvSintomas.MultiSelect = False
        Me.dgvSintomas.Name = "dgvSintomas"
        Me.dgvSintomas.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSintomas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSintomas.RowHeadersVisible = False
        Me.dgvSintomas.RowHeadersWidth = 51
        Me.dgvSintomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSintomas.Size = New System.Drawing.Size(413, 474)
        Me.dgvSintomas.TabIndex = 150
        '
        'dgvDiagnosticos
        '
        Me.dgvDiagnosticos.AllowUserToAddRows = False
        Me.dgvDiagnosticos.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvDiagnosticos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDiagnosticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDiagnosticos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDiagnosticos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDiagnosticos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDiagnosticos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvDiagnosticos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(4, 30, 4, 20)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDiagnosticos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDiagnosticos.ColumnHeadersVisible = False
        Me.dgvDiagnosticos.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Padding = New System.Windows.Forms.Padding(10)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDiagnosticos.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDiagnosticos.EnableHeadersVisualStyles = False
        Me.dgvDiagnosticos.Location = New System.Drawing.Point(0, 0)
        Me.dgvDiagnosticos.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvDiagnosticos.MultiSelect = False
        Me.dgvDiagnosticos.Name = "dgvDiagnosticos"
        Me.dgvDiagnosticos.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(96, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDiagnosticos.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDiagnosticos.RowHeadersVisible = False
        Me.dgvDiagnosticos.RowHeadersWidth = 51
        Me.dgvDiagnosticos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDiagnosticos.Size = New System.Drawing.Size(413, 474)
        Me.dgvDiagnosticos.TabIndex = 150
        '
        'UCDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroSetTabControl1)
        Me.Name = "UCDiagnostico"
        Me.Size = New System.Drawing.Size(417, 516)
        Me.MetroSetTabControl1.ResumeLayout(False)
        Me.fds.ResumeLayout(False)
        Me.MetroSetTabPage2.ResumeLayout(False)
        CType(Me.dgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroSetTabControl1 As MetroSet_UI.Controls.MetroSetTabControl
    Friend WithEvents fds As MetroSet_UI.Child.MetroSetTabPage
    Friend WithEvents MetroSetTabPage2 As MetroSet_UI.Child.MetroSetTabPage
    Friend WithEvents dgvSintomas As DataGridView
    Friend WithEvents dgvDiagnosticos As DataGridView
End Class
