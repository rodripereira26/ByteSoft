Public Class frmUsuariosRegistrados

    Private Sub ListadoGestor_Load(sender As Object, e As EventArgs) Handles Me.Load

        cbbCriterioBusqueda.SelectedIndex = 0
        dgvEmp.Rows.Add("", "", "")
        dgvEmp.Rows.Add("", "", "")
        dgvEmp.Rows.Add("", "", "")
        dgvEmp.Rows.Add("", "", "")
        dgvEmp.Rows.Add("", "", "")

        dgvEmp.Rows.Add("", "", "")
        dgvEmp.Rows.Add("", "", "")
        dgvEmp.Rows.Add("", "", "")
        dgvEmp.Rows.Add("", "", "")
        'dgvEmp.Rows.Add("5.232.123-5", "JOSE", "LUIS", "BELMONTE", "VILLEGAS", "MÉDICO", "56")

    End Sub

End Class