Public Class ModeloPatologia
    Inherits Conexion

    Public Function Registrar(nombre As String, descripcion As String, recomendacion As String, prioridad As Byte, nomSintomas As ArrayList) As Boolean


        Command.CommandText = "INSERT INTO patologia (nombre, descripcion, recomendacion, prioridad) VALUES ('" & nombre & "','" & descripcion & "','" & recomendacion & "','" & prioridad & "')"
        Command.ExecuteNonQuery()

        For Each nom In nomSintomas
            Command.CommandText = "
                    INSERT INTO patologia_contiene_sintoma (idSintoma, idPatologia)
                    VALUES
                        ((SELECT
                            idSintoma
                        FROM
                            sintoma
                        WHERE
                            nombre = '" & nom & "'),
                        (SELECT
                            idPatologia
                        FROM
                            patologia
                        WHERE
                            nombre = '" & nombre & "'))"

            Command.ExecuteNonQuery()
        Next
        Return True
    End Function

    Public Function listarPatologias() As DataTable

        Command.CommandText = "SELECT nombre AS Nombre, descripcion AS Descripcion, recomendacion AS Recomendacion, prioridad AS Prioridad FROM patologia"
        Dim dt As New DataTable
        dt.Load(Command.ExecuteReader())
        Return dt

    End Function

    Public Sub eliminarPatologias(ali As ArrayList)

        For Each item In ali

            Command.CommandText = "
            DELETE FROM patologia 
            WHERE idPatologia = 

            (SELECT idPatologia WHERE nombre = '" & ali(item) & "' )"
            Command.ExecuteNonQuery()

            Command.CommandText = "
            SELECT idSintoma FROM patologia_contiene_sintoma WHERE idPatologia = '" & ali(item) & "'"
            Reader = Command.ExecuteReader


            Command.CommandText = "DELETE FROM patologia_contiene_sintoma WHERE idPatologia='" & ali(item) & "' && idSintoma = (SELECT idSintoma FROM patologia_contiene_sintoma WHERE idPatologia =  '" & ali(item) & "')"
            Command.ExecuteNonQuery()
        Next




    End Sub
    'Public Function getIdSintomas(nomSintomas As ArrayList)

    '    Dim idSintomas As New ArrayList
    '    For i = 0 To nomSintomas.Count - 1
    '        Command.CommandText = "SELECT idSintoma FROM sintoma WHERE nombre = '" & nomSintomas(i) & "'"
    '        Reader = Command.ExecuteReader
    '        Dim sin = Integer.Parse(Reader.GetValue(0))
    '        MsgBox("ID SINTOMA:" & sin)
    '        'If Reader.HasRows Then
    '        '    idSintomas.Add(Integer.Parse(Reader.GetValue(0)))
    '        '    MsgBox("ID: " & idSintomas(i))
    '        'End If

    '    Next

    '    Return idSintomas
    'End Function

    'Command.CommandText = "Select idPatologia FROM patologia WHERE nombre = '" & nombre & "'"
    'Reader = Command.ExecuteReader()
    'Dim IdPatologia As Integer
    'If Reader.HasRows Then
    '    IdPatologia = Integer.Parse(Reader.GetValue(0))
    'End If

    'Dim idSintomas As New ArrayList
    'idSintomas = getIdSintomas(nomSintomas)
    'For i = 0 To idSintomas.Count() - 1
    '    Command.CommandText = "INSERT INTO patologia_contiene_sintoma (idPatologia, idSintoma) VALUES (" & idSintomas(i) & "," & IdPatologia & ")"
    '    Command.ExecuteNonQuery()
    'Next








End Class
