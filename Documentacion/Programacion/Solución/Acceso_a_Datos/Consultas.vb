'Imports System.Data.Odbc
'Public Class Consultas
'    Dim conn As New OdbcConnection("dsn=driverODBC;uid=root;pwd=;")


'    Overloads Function registrar_Paciente(cedula As Integer, contraseña As String, nombre As String, segundo_nombre As String, apellido As String, segundo_apellido As String, tel As String, email As String, sexo As String, fecNac As String) As Boolean

'        Dim consulta As String = "INSERT INTO usuario (cedula, contrasena, pNom, sNom, pApe, sApe, correo) VALUES ('" & cedula & "','" & contraseña & "','" & nombre & "','" & apellido & "','" & segundo_nombre & "','" & segundo_apellido & "','" & email & "')"

'        Dim consulta2 As String = "INSERT INTO paciente (cedula, verificacion, fecNac, sexo) VALUES ('" & cedula & "','" & 1 & "','" & fecNac & "','" & "M" & "')"

'        Dim consulta3 As String
'        consulta3 = "INSERT INTO usuario_tel (cedula,telefono) VALUES ('" & cedula & "','" & tel & "')"

'        Dim command As New OdbcCommand(consulta, conn)
'        Dim command2 As New OdbcCommand(consulta2, conn)
'        Dim command3 As New OdbcCommand(consulta3, conn)

'        Try
'            conn.Open()

'            command.ExecuteNonQuery()
'            command2.ExecuteNonQuery()
'            command3.ExecuteNonQuery()
'            conn.Close()
'            MsgBox("SUCCESS")
'            Return True

'        Catch ex As Exception
'            MsgBox("ERROR")
'            MsgBox(ex.Message)
'        End Try

'        Return False
'    End Function
'    Overloads Function registrar_Medico(cedula As Integer, contraseña As String, nombre As String, segundo_nombre As String, apellido As String, segundo_apellido As String, tel As String, especializacion As String) As Boolean

'        Dim consulta As String = "INSERT INTO usuario (cedula, contrasena, pNom, sNom, pApe, sApe) VALUES ('" & cedula & "','" & cedula & "','" & nombre & "','" & apellido & "','" & segundo_nombre & "','" & segundo_apellido & "')"

'        Dim consulta2 As String = "INSERT INTO medico (cedula, especializacion) VALUES ('" & cedula & "','" & especializacion & "')"

'        Dim consulta3 As String
'        consulta3 = "INSERT INTO usuario_tel (cedula,telefono) VALUES ('" & cedula & "','" & tel & "')"

'        Dim command As New OdbcCommand(consulta, conn)
'        Dim command2 As New OdbcCommand(consulta2, conn)
'        Dim command3 As New OdbcCommand(consulta3, conn)

'        Try
'            conn.Open()

'            command.ExecuteNonQuery()
'            command2.ExecuteNonQuery()
'            command3.ExecuteNonQuery()
'            conn.Close()
'            MsgBox("SUCCESS")
'            Return True

'        Catch ex As Exception
'            MsgBox("ERROR")
'            MsgBox(ex.Message)
'        End Try

'        Return False
'    End Function
'    Overloads Function registrar_Gestor(cedula As Integer, contraseña As String, nombre As String, segundo_nombre As String, apellido As String, segundo_apellido As String, tel As String, especializacion As String) As Boolean

'        Dim consulta As String = "INSERT INTO usuario (cedula, contrasena, pNom, sNom, pApe, sApe) VALUES ('" & cedula & "','" & cedula & "','" & nombre & "','" & apellido & "','" & segundo_nombre & "','" & segundo_apellido & "')"

'        Dim consulta2 As String = "INSERT INTO gestor (cedula) VALUES ('" & cedula & "')"

'        Dim consulta3 As String


'        Dim command As New OdbcCommand(consulta, conn)
'        Dim command2 As New OdbcCommand(consulta2, conn)


'        Try
'            conn.Open()

'            command.ExecuteNonQuery()
'            command2.ExecuteNonQuery()

'            consulta3 = "INSERT INTO usuario_tel (cedula,telefono) VALUES ('" & cedula & "','" & tel & "')"
'            Dim command3 As New OdbcCommand(consulta3, conn)
'            command3.ExecuteNonQuery()


'            conn.Close()
'            MsgBox("SUCCESS")
'            Return True

'        Catch ex As Exception
'            MsgBox("ERROR")
'            MsgBox(ex.Message)
'        End Try

'        Return False
'    End Function
'    Overloads Function verificarUsuario(cedula As String, contraseña As String) As Integer

'        Dim consulta = "SELECT COUNT(cedula) FROM usuario WHERE cedula = " & cedula & " and contraseña= '" & contraseña & "'"
'        Dim command As New OdbcCommand(consulta, conn)
'        Try
'            conn.Open()
'            Dim num As Integer = command.ExecuteScalar()
'            conn.Close()
'            Return num

'        Catch ex As Exception

'        End Try

'        Return False

'    End Function
'    Public Function agregarSintoma(nombre As String, descripcion As String)



'        Dim consulta As String = "INSERT INTO sintoma (nombre,descripcion) VALUES ("
'        consulta = consulta & "'" & nombre & "','" & descripcion & "')"
'        Dim command As New OdbcCommand(consulta, conn)
'        Try
'            conn.Open()
'            command.ExecuteNonQuery()

'            conn.Close()

'            Return True
'        Catch ex As Exception
'        End Try

'        Return False
'    End Function



'    Public Function traerId(ali As ArrayList)

'        Dim ali2 As New ArrayList

'        Try
'            conn.Open()
'            For i = 0 To ali.Count - 1
'                Dim consulta As String = "SELECT idSintoma FROM sintoma WHERE nombre = '" & ali.Item(i) & "' "
'                Dim reader = New OdbcCommand(consulta, conn).ExecuteReader
'                reader.Read()

'                Dim j As Integer
'                While reader.Read

'                    ali2.Add(reader(j))
'                    j += 1
'                End While
'            Next
'            conn.Close()
'            Return ali2
'            MsgBox("exito")


'        Catch ex As Exception

'        End Try

'    End Function


'    Public Function agregarPatologia(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, nomSintoma As ArrayList, idSintoma As ArrayList)

'        Dim consulta1 As String = "INSERT INTO patologia (nombre,descripcion,recomendacion, prioridad) VALUES ('" & nombre & "','" & descripcion & "','" & recomendacion & "','" & prioridad & "')"

'        Dim command1 As New OdbcCommand(consulta1, conn)

'        Try
'            conn.Open()
'            command1.ExecuteNonQuery()
'            For i As Integer = 0 To idSintoma.Count
'                Dim consulta2 As String = "INSERT INTO patologia_contiene_sintoma (idSintoma) VALUES ('" & idSintoma.Item(i) & "')"
'                Dim command2 As New OdbcCommand(consulta2, conn)
'                command2.ExecuteNonQuery()
'            Next

'            conn.Close()
'            MsgBox("exito")
'            Return True
'        Catch ex As Exception

'            MsgBox("!!!")
'        End Try

'        Return False

'    End Function

'    Private query As New OdbcCommand
'    Private Shared instancia
'    Public Function buscarEnfermedadConSintoma(sintoma As String) As String()
'        Return LeerDatos("SELECT patologia.nombre
'            FROM patologia, patologia_contiene_sintoma, sintoma
'            WHERE patologia_contiene_sintoma.idPatologia = patologia.idPatologia and
'             patologia_contiene_sintoma.idSintoma = sintoma.idSintoma and
'             sintoma.nombre=" & sintoma & "; ")
'    End Function

'    Public Function buscarEnfermedadesConSintomas(sintomas As String()) As String()
'        Dim nroDeSintomasPorPatologia As New Dictionary(Of String, Integer) ' enfermedad y numero de sintomas
'        For Each sintoma In sintomas
'            Dim patologias() As String = buscarEnfermedadConSintoma(sintoma)
'            For Each patologia In patologias
'                If nroDeSintomasPorPatologia.ContainsKey(patologia) Then
'                    nroDeSintomasPorPatologia.Item(patologia) += 1
'                Else
'                    nroDeSintomasPorPatologia.Add(patologia, 1)
'                End If
'            Next
'        Next
'    End Function



'    Public Function LeerDatos(consulta As String)
'        Try
'            ActivarConexion()
'            query.Connection = Consultas.GetSingleton.InstanciarConexion
'            query.CommandText = consulta
'            Return query.ExecuteScalar

'        Catch ex As Exception
'            Return Nothing
'        End Try
'    End Function
'End Class
