Public Class ModeloSintoma
    Inherits Conexion

    Public Function Registrar(nombre As String, descripcion As String)
        Command.CommandText = "
        INSERT INTO 
            sintoma (nombre, descripcion) 
        VALUES ('" & nombre & "','" & descripcion & "')"
        Command.ExecuteNonQuery()
    End Function
End Class
