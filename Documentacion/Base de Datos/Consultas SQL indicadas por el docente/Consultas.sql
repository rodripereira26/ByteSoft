1'' SELECT p.nombre AS Patologia, count(*) AS Cantidad 
FROM patologia p, paciente_obtiene_diagnostico pd 
WHERE p.idPatologia = pd.idPatologia GROUP BY pd.idPatologia ORDER BY count(*) DESC;

2'' SELECT u.sApe AS Nombre, u.pApe AS Apellido, pat.nombre AS Diagnostico, pd.fecha AS Fecha 
FROM paciente p, usuario u, paciente_obtiene_diagnostico pd, patologia pat 
WHERE p.cedula = u.cedula AND pd.cedulaPaciente = p.cedula AND pat.idPatologia = pd.idPatologia ORDER BY pd.fecha DESC;

3'' SELECT count(*) AS Cantidad_de_Pacientes 
FROM paciente_obtiene_diagnostico pd 
WHERE DATE(pd.fecha) = curdate()