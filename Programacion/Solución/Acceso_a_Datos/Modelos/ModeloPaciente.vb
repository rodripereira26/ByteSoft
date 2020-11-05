Imports System.Data.Odbc

''' <summary>
''' Clase encargada de realizar las consultas de los adminstradores.
''' </summary>
Public Class ModeloPaciente

    Private Shared instancia As ModeloPaciente

    ''' <summary>
    ''' Función encargada de devolver una instancia singleton de la clase.
    ''' </summary>
    ''' <returns>La instancia creada de la clase.</returns>
    Public Shared Function Singleton() As ModeloPaciente

        If instancia Is Nothing Then
            instancia = New ModeloPaciente
        End If

        Return instancia
    End Function

    ''' <summary>
    ''' Función encargada de verificar si el paciente fue ingresado.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>True si el paciente ya es usuario del sistema.</returns>
    Public Function VerificarEstado(cedula As String) As Boolean

        Dim consulta As String = "SELECT verificacion FROM paciente WHERE cedula = " + cedula

        If ModeloConsultas.Singleton.ConsultaCampo(consulta) = 1 Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de registrar a los pacientes utilizando una conexión auxiliar.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="contraseña"></param>
    ''' <param name="PrimerNombre"></param>
    ''' <param name="SegundoNombre"></param>
    ''' <param name="PrimerApellido"></param>
    ''' <param name="SegundoApellido"></param>
    ''' <param name="Telefonos"></param>
    ''' <param name="Mail"></param>
    ''' <param name="sexo"></param>
    ''' <param name="FechaNacimiento"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function Registrar(cedula As String, contraseña As String, PrimerNombre As String, SegundoNombre As String, PrimerApellido As String, SegundoApellido As String, Telefonos As ArrayList, Mail As String, sexo As String, FechaNacimiento As String) As Boolean

        Conexion.Singleton.SetRolConexion(Conexion.EnumDbLogin.aux)

        Dim consulta As String = "INSERT INTO usuario (cedula, contrasena, pNom, sNom, pApe, sApe, correo) VALUES (?,?,?,?,?,?,?)"
        Dim parametros As New List(Of OdbcParameter)

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("contrasena", contraseña))
        parametros.Add(New OdbcParameter("pNom", PrimerNombre))
        parametros.Add(New OdbcParameter("sNom", SegundoNombre))
        parametros.Add(New OdbcParameter("pApe", PrimerApellido))
        parametros.Add(New OdbcParameter("sApe", cedula))
        parametros.Add(New OdbcParameter("correo", Mail))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            If RegistrarPaciente(cedula, sexo, FechaNacimiento) Then
                If RegistrarTelefono(cedula, Telefonos) Then
                    Return True
                End If
            End If
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de registar a los pacientes en la tabla pacientes.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="sexo"></param>
    ''' <param name="FechaNacimiento"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function RegistrarPaciente(cedula As String, sexo As String, FechaNacimiento As String) As Boolean

        Dim parametros As New List(Of OdbcParameter)
        Dim consulta As String = "INSERT INTO paciente (cedula, verificacion, fecNac, sexo) VALUES (?,?,?,?)"

        parametros.Add(New OdbcParameter("cedula", cedula))
        parametros.Add(New OdbcParameter("verificacion", "false"))
        parametros.Add(New OdbcParameter("fecNac", FechaNacimiento))
        parametros.Add(New OdbcParameter("sexo", sexo))

        If ModeloConsultas.Singleton.InsertParametros(consulta, parametros) Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de registar los telefonos de los administradores.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <param name="Telefonos"></param>
    ''' <returns>True si el insert fue realizado.</returns>
    Public Function RegistrarTelefono(cedula As String, Telefonos As ArrayList)

        Dim consulta = "INSERT INTO usuario_tel (cedula, telefono) VALUES (?,?)"
        Dim parametros As New List(Of OdbcParameter)
        Dim contador As Int16 = 0

        For i As Int16 = 0 To Telefonos.Count - 1
            parametros.Clear()
            parametros.Add(New OdbcParameter("cedula", cedula))
            parametros.Add(New OdbcParameter("telefono", Telefonos.Item(i)))

            ModeloConsultas.Singleton.InsertParametros(consulta, parametros)
            contador = +1
        Next

        If contador = Telefonos.Count Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Función encargada de listar a los pacientes habilitados.
    ''' </summary>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function TraerPacientes() As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT cedula FROM paciente WHERE verificacion = 1 ")
    End Function

    ''' <summary>
    ''' Función encargada de obtener los datos del paciente.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function GetDatosPaciente(cedula As String) As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT pNom,sNom,pApe,sApe,fecNac,sexo,correo from usuario u, paciente p WHERE u.cedula=p.cedula AND u.cedula= " & cedula)
    End Function

    ''' <summary>
    ''' Función encargada de obtener las enfermedades crónicas del paciente.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function GetPatologiasCronicas(cedula As String) As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT patologia FROM pacientePatologia WHERE cedula = " & cedula)
    End Function

    ''' <summary>
    ''' Función encargada de obtener el historial de consultas del paciente.
    ''' </summary>
    ''' <param name="cedula"></param>
    ''' <returns>DataTable cargado con los valores obtenidos.</returns>
    Public Function GetHistorialConsultas(cedula As String) As DataTable
        Return ModeloConsultas.Singleton.ConsultaTabla("SELECT p.nombre,date_format(pod.fecha," & "'%d / %m / %y')" & "FROM paciente_obtiene_diagnostico pod,patologia p WHERE pod.idPatologia=p.idPatologia AND pod.cedulaPaciente =" & cedula)
    End Function

End Class
