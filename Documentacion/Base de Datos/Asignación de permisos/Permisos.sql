/*
ByteSoft - 2020
Asignación de Permisos
*/

USE bytesoft_bdd;

/*
Creación de los roles
*/
CREATE ROLE aux;
CREATE ROLE gestor;
CREATE ROLE medico;
CREATE ROLE paciente;

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
GRANT DELETE ON bytesoft_bdd.patologia_contiene_diagnostico TO gestor;

/*
Creación de los usuarios
*/
CREATE USER 'sysAux'@'%' IDENTIFIED BY '1DWbt9hj8xdk3C72';
CREATE USER 'sysGest'@'%' IDENTIFIED BY 'yX4H84ZpgNp07kDy';
CREATE USER 'sysMed'@'%' IDENTIFIED BY 'hF69t12lQal6hyiD';
CREATE USER 'sysPac'@'%' IDENTIFIED BY 'dV23UTXFZRbinBz3';

/*
Asignación de los usuarios a sus roles
*/
GRANT aux TO 'sysAux'; 
GRANT gestor TO 'sysGest'; 
GRANT medico TO 'sysMed'; 
GRANT paciente TO 'sysPac'; 

SET DEFAULT ROLE aux FOR 'sysAux'@'%';
SET DEFAULT ROLE gestor FOR 'sysGest'@'%';
SET DEFAULT ROLE medico FOR 'sysMed'@'%';
SET DEFAULT ROLE paciente FOR 'sysPac'@'%';

/*
Actualizo los permisos
*/
FLUSH PRIVILEGES;