/*
ByteSoft - 2020
Asignación de Permisos
*/

USE bytesoft_bdd;

/*
Creación de los roles
*/
CREATE ROLE IF NOT EXISTS aux;
CREATE ROLE IF NOT EXISTS gestor;
CREATE ROLE IF NOT EXISTS medico;
CREATE ROLE IF NOT EXISTS paciente;

/*
Permisos de Insert
*/
GRANT INSERT ON bytesoft_bdd.usuario TO gestor, aux;
GRANT INSERT ON bytesoft_bdd.usuarioTel TO gestor, medico, paciente, aux;
GRANT INSERT ON bytesoft_bdd.chat TO paciente;
GRANT INSERT ON bytesoft_bdd.mensaje TO medico, paciente;
GRANT INSERT ON bytesoft_bdd.gestor TO gestor;
GRANT INSERT ON bytesoft_bdd.paciente TO gestor, aux;
GRANT INSERT ON bytesoft_bdd.pacientePatologia TO paciente;
GRANT INSERT ON bytesoft_bdd.sintoma TO gestor;
GRANT INSERT ON bytesoft_bdd.patologia TO gestor;
GRANT INSERT ON bytesoft_bdd.medico TO gestor, medico;
GRANT INSERT ON bytesoft_bdd.observacion TO medico;
GRANT INSERT ON bytesoft_bdd.usuario_entra_chat TO medico, paciente;
GRANT INSERT ON bytesoft_bdd.paciente_indica_sintoma TO paciente;
GRANT INSERT ON bytesoft_bdd.patologia_contiene_sintoma TO gestor;
GRANT INSERT ON bytesoft_bdd.paciente_obtiene_diagnostico TO paciente;

/*
Permisos de Select
*/
GRANT SELECT ON bytesoft_bdd.usuario TO gestor, aux;
GRANT SELECT ON bytesoft_bdd.usuarioTel TO gestor, medico, paciente;
GRANT SELECT ON bytesoft_bdd.chat TO medico, paciente;
GRANT SELECT ON bytesoft_bdd.mensaje TO medico, paciente;
GRANT SELECT ON bytesoft_bdd.gestor TO gestor, aux;
GRANT SELECT ON bytesoft_bdd.paciente TO gestor, medico, paciente, aux;
GRANT SELECT ON bytesoft_bdd.pacientePatologia TO medico, paciente;
GRANT SELECT ON bytesoft_bdd.sintoma TO gestor, medico, paciente;
GRANT SELECT ON bytesoft_bdd.patologia TO gestor, medico, paciente;
GRANT SELECT ON bytesoft_bdd.medico TO gestor, medico, paciente, aux;
GRANT SELECT ON bytesoft_bdd.observacion TO medico, paciente;
GRANT SELECT ON bytesoft_bdd.usuario_entra_chat TO gestor, medico, paciente;
GRANT SELECT ON bytesoft_bdd.paciente_indica_sintoma TO gestor, medico, paciente;
GRANT SELECT ON bytesoft_bdd.patologia_contiene_sintoma TO gestor, medico, paciente;
GRANT SELECT ON bytesoft_bdd.paciente_obtiene_diagnostico TO medico, paciente;
/*
Permiso para que el médico pueda ver el nombre del paciente
*/
GRANT SELECT (cedula,pNom,pApe,correo) ON bytesoft_bdd.usuario TO medico;

/*
Permisos de Update
*/
GRANT UPDATE ON bytesoft_bdd.usuario TO gestor, medico, paciente;
GRANT UPDATE ON bytesoft_bdd.usuarioTel TO gestor, medico, paciente;
GRANT UPDATE ON bytesoft_bdd.chat TO medico, paciente;
GRANT UPDATE ON bytesoft_bdd.mensaje TO medico, paciente;
GRANT UPDATE ON bytesoft_bdd.gestor to gestor;
GRANT UPDATE ON bytesoft_bdd.paciente TO gestor, paciente;
GRANT UPDATE ON bytesoft_bdd.pacientePatologia TO paciente;
GRANT UPDATE ON bytesoft_bdd.sintoma TO gestor;
GRANT UPDATE ON bytesoft_bdd.patologia TO gestor;
GRANT UPDATE ON bytesoft_bdd.medico to gestor, medico;
GRANT UPDATE ON bytesoft_bdd.observacion TO medico;
GRANT UPDATE ON bytesoft_bdd.paciente_indica_sintoma TO paciente;
GRANT UPDATE ON bytesoft_bdd.patologia_contiene_sintoma TO gestor;

/*
Permiso de Delete
*/
GRANT DELETE ON bytesoft_bdd.usuarioTel TO gestor, medico, paciente;
GRANT DELETE ON bytesoft_bdd.patologia_contiene_sintoma TO gestor;

/*
Creación de los usuarios
*/
CREATE USER IF NOT EXISTS 'sysAux'@'%' IDENTIFIED BY 'sysAuxPass2';
CREATE USER IF NOT EXISTS 'sysGest'@'%' IDENTIFIED BY 'sysGestPass2';
CREATE USER IF NOT EXISTS 'sysMed'@'%' IDENTIFIED BY 'sysMedPass2';
CREATE USER IF NOT EXISTS 'sysPac'@'%' IDENTIFIED BY 'sysPacPass2';

/*
Asignación de los usuarios a sus roles
*/
GRANT aux TO 'sysAux'; 
GRANT gestor TO 'sysGest'; 
GRANT medico TO 'sysMed'; 
GRANT paciente TO 'sysPac'; 

SET DEFAULT ROLE aux TO 'sysAux'@'%';
SET DEFAULT ROLE gestor TO 'sysGest'@'%';
SET DEFAULT ROLE medico TO 'sysMed'@'%';
SET DEFAULT ROLE paciente TO 'sysPac'@'%';

/*
Usuario para backups
*/
CREATE USER IF NOT EXISTS 'sysBack'@'%' IDENTIFIED BY 'Rvu5i70pDVQqmkdh';
GRANT SELECT, SHOW VIEW, RELOAD, REPLICATION CLIENT, EVENT, TRIGGER ON *.* TO 'sysBack'@'%';
GRANT LOCK TABLES ON *.* TO 'sysBack'@'%';

/*
Actualizo los permisos
*/
FLUSH PRIVILEGES;