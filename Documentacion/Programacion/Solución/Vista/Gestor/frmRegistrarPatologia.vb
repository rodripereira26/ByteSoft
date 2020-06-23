Public Class frmRegistrarPatologia
    Private Sub RegistrarPatologias_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        DataGridView1.Rows.Add("Fiebre")

        DataGridView1.Rows.Add("Escalofrios")
        DataGridView1.Rows.Add("Dolor de pecho")
        DataGridView1.Rows.Add("Mareos")
    End Sub
End Class