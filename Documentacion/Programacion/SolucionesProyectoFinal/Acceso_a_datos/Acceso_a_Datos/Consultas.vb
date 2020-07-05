Imports System.Data.Odbc
Public Class Consultas
    Dim conn As New OdbcConnection("dsn=driverODBC;uid=root;pwd=;")


    Overloads Function agregar_registro(cedula As Integer, contraseña As String, nombre As String, segundo_nombre As String, apellido As String, segundo_apellido As String, tel As String, email As String, sexo As String) As Boolean

        Dim consulta As String = "INSERT INTO usuario (cedula,pNom,pApe,sNom,sApe,correo,contrasena) VALUES ("
        consulta = consulta & " '" & cedula & "','" & nombre & "','" & apellido & "','" & segundo_nombre & "',"
        consulta = consulta & "'" & segundo_apellido & "','" & email & "','" & contraseña & "')"

        Dim consulta2 As String
        consulta2 = "INSERT INTO paciente (cedula, sexo, verificacion) VALUES (" & cedula & ",'" & sexo & "'," & "true" & ")"

        Dim consulta3 As String
        consulta3 = "INSERT INTO usuario_tel (cedula,telefono) VALUES (" & cedula & "," & tel & ")"

        Dim command As New OdbcCommand(consulta, conn)
        Dim command2 As New OdbcCommand(consulta2, conn)
        Dim command3 As New OdbcCommand(consulta3, conn)

        Try
            conn.Open()
            command.ExecuteNonQuery()
            command2.ExecuteNonQuery()
            command3.ExecuteNonQuery()
            conn.Close()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return False
    End Function

    Overloads Function verificarUsuario(cedula As String, contraseña As String) As Integer

        Dim consulta = "SELECT COUNT(cedula) FROM usuario WHERE cedula = " & cedula & " and contraseña= '" & contraseña & "'"
        Dim command As New OdbcCommand(consulta, conn)

        Try
            conn.Open()
            Dim num As Integer = command.ExecuteScalar()
            conn.Close()
            Return num

        Catch ex As Exception

        End Try

        Return False

    End Function
    Public Function agregarSintoma(nombre As String, descripcion As String)

        Dim consulta As String = "INSERT INTO sintoma (nombre,descripcion) VALUES ("
        consulta = consulta & "'" & nombre & "','" & descripcion & "')"
        Dim command As New OdbcCommand(consulta, conn)
        Try
            conn.Open()
            command.ExecuteNonQuery()

            conn.Close()

            Return True
        Catch ex As Exception
        End Try

        Return False
    End Function

    Public Sub imp()

        MsgBox("holaa")
    End Sub


    Public Function traerId(ali As ArrayList)

        For i = 0 To ali.Count - 1

            Dim ali2 As New ArrayList
            Dim consulta As String = "SELECT idSintoma FROM sintoma WHERE nombre = '" & ali.Item(i) & "' "



            Try
                conn.Open()
                Dim reader = New OdbcCommand(consulta, conn).ExecuteReader

                conn.Close()
                MsgBox("exito")
                MsgBox(ali2.Item(i))

            Catch ex As Exception

            End Try

        Next

    End Function


    Public Function agregarPatologia(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, ali As ArrayList)

        Dim idSintoma As String
        Dim ali2 As ArrayList = traerId(ali)

        Dim consulta1 As String = "INSERT INTO patologia (nombre,descripcion,recomendacion, prioridad) VALUES ("
        consulta1 = consulta1 & "'" & nombre & "','" & descripcion & "','" & recomendacion & "','" & prioridad & "')"

        Dim consulta3 As String = "INSERT INTO patologia_contiene_sintoma (idSintoma) VALUES ('" & idSintoma & "')"

        Dim command1 As New OdbcCommand(consulta1, conn)
        Dim command2 As New OdbcCommand(consulta3, conn)

        Try
            conn.Open()
            command1.ExecuteNonQuery()

            For i = 0 To ali.Count - 1
                idSintoma = ali2.Item(i)
                command2.ExecuteNonQuery()
            Next


            conn.Close()
            MsgBox("exito")
            Return True
        Catch ex As Exception

            MsgBox("!!!")
        End Try

        Return False

    End Function
    'Private query As New OdbcCommand
    'Private Shared instancia
    'Public Function buscarEnfermedadConSintoma(sintoma As String) As String()
    '    Return LeerDatos("SELECT patologia.nombre
    '        FROM patologia, patologia_contiene_sintoma, sintoma
    '        WHERE patologia_contiene_sintoma.idPatologia = patologia.idPatologia and
    '         patologia_contiene_sintoma.idSintoma = sintoma.idSintoma and
    '         sintoma.nombre=" & sintoma & "; ")
    'End Function

    'Public Function buscarEnfermedadesConSintomas(sintomas As String()) As String()
    '    Dim nroDeSintomasPorPatologia As New Dictionary(Of String, Integer) ' enfermedad y numero de sintomas
    '    For Each sintoma In sintomas
    '        Dim patologias() As String = buscarEnfermedadConSintoma(sintoma)
    '        For Each patologia In patologias
    '            If nroDeSintomasPorPatologia.ContainsKey(patologia) Then
    '                nroDeSintomasPorPatologia.Item(patologia) += 1
    '            Else
    '                nroDeSintomasPorPatologia.Add(patologia, 1)
    '            End If
    '        Next
    '    Next
    'End Function



    'Public Function LeerDatos(consulta As String)
    '    Try
    '        ActivarConexion()
    '        query.Connection = Consultas.GetSingleton.InstanciarConexion
    '        query.CommandText = consulta
    '        Return query.ExecuteScalar

    '    Catch ex As Exception
    '        Return Nothing
    '    End Try
    'End Function
End Class
