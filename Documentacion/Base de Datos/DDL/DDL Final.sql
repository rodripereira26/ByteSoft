/*
ByteSoft - 2020
DDL - Creación de tablas
*/

/* Inicio */
	DROP DATABASE IF EXISTS bytesoft_bdd;
	CREATE DATABASE IF NOT EXISTS bytesoft_bdd;
    USE bytesoft_bdd;
    
    /* Creación de tablas */
    
    CREATE TABLE usuario (
    cedula INT (9) NOT NULL,
	contrasena VARCHAR (70) NOT NULL,
    pNom VARCHAR (25) NOT NULL,
    pApe VARCHAR (25) NOT NULL,
    sNom VARCHAR (25),
    sApe VARCHAR (25) NOT NULL,
    correo VARCHAR (40) NOT NULL,
    fotoPerfil MEDIUMBLOB,
    bajalogica BOOLEAN NOT NULL DEFAULT FALSE,
    PRIMARY KEY (cedula),
    UNIQUE (correo)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    CREATE TABLE usuarioTel (
    cedula INT (9) NOT NULL,
    telefono INT (9) NOT NULL,
    PRIMARY KEY (cedula, telefono),
    CONSTRAINT fk_telefonos FOREIGN KEY (cedula) REFERENCES usuario (cedula)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    CREATE TABLE chat (
    idChat INT NOT NULL AUTO_INCREMENT,
	finalizado BOOLEAN NOT NULL DEFAULT FALSE,
    PRIMARY KEY (idChat)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    CREATE TABLE mensaje (
    idMensaje INT NOT NULL AUTO_INCREMENT,
    fechaEnvio DATETIME NOT NULL,
    cedula INT (9) NOT NULL,
    idChat INT NOT NULL,
    mensaje MEDIUMBLOB NOT NULL,
    PRIMARY KEY (idMensaje, fechaEnvio),
    CONSTRAINT fk_chat_cedula FOREIGN KEY (cedula) REFERENCES usuario (cedula),
    CONSTRAINT fk_chat_idChat FOREIGN KEY (idChat) REFERENCES chat (idChat)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    CREATE TABLE gestor (
    cedula INT (9) NOT NULL,
    PRIMARY KEY (cedula),
    CONSTRAINT fk_gestor_cedula FOREIGN KEY (cedula) REFERENCES usuario (cedula)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
	CREATE TABLE paciente (
    cedula INT (9) NOT NULL,
    fecNac DATETIME NOT NULL,
    sexo CHAR (1) NOT NULL,
    verificacion BOOLEAN NOT NULL DEFAULT FALSE,
    CHECK (sexo in ("M", "F")),
    PRIMARY KEY (cedula),
    CONSTRAINT fk_paciente_cedula FOREIGN KEY (cedula) REFERENCES usuario (cedula)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    CREATE TABLE pacientePatologia (
    cedula INT (9) NOT NULL,
    patologia VARCHAR (25) NOT NULL,
    PRIMARY KEY (cedula, patologia),
    CONSTRAINT fk_pacientePatologia_cedula FOREIGN KEY (cedula) REFERENCES usuario (cedula)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    CREATE TABLE sintoma (
    idSintoma INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR (25) NOT NULL,
    descripcion VARCHAR (50) NOT NULL,
    bajalogica BOOLEAN NOT NULL DEFAULT FALSE,
    PRIMARY KEY (idSintoma),
    UNIQUE (nombre)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 

	CREATE TABLE patologia (
    idPatologia INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR (25) NOT NULL,
    descripcion VARCHAR (25) NOT NULL,
    recomendacion VARCHAR (60) NOT NULL,
    prioridad TINYINT (1) NOT NULL,
    bajalogica BOOLEAN NOT NULL DEFAULT FALSE,
    PRIMARY KEY (idPatologia),
    UNIQUE (nombre)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    CREATE TABLE medico (
	cedula INT (9) NOT NULL,
    especializacion VARCHAR (25) NOT NULL,
    PRIMARY KEY (cedula),
    CONSTRAINT fk_medico_cedula FOREIGN KEY (cedula) REFERENCES usuario (cedula)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    CREATE TABLE observacion (
    idObservacion INT NOT NULL AUTO_INCREMENT,
    fecha DATETIME NOT NULL,
    cedulaMedico INT (9) NOT NULL,
    cedulaPaciente INT (9) NOT NULL,
    recomendacion VARCHAR (60) NOT NULL,
    derivacion VARCHAR (30),
    PRIMARY KEY (idObservacion, fecha),
	CONSTRAINT fk_observacion_cedulaMedico FOREIGN KEY (cedulaMedico) REFERENCES medico (cedula),
	CONSTRAINT fk_observacion_cedulaPaciente FOREIGN KEY (cedulaPaciente) REFERENCES medico (cedula)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    CREATE TABLE usuario_entra_chat (
    cedula INT (9) NOT NULL,
    idChat INT NOT NULL,
    fechaIngreso DATETIME NOT NULL,
    PRIMARY KEY (cedula, idChat, fechaIngreso),
    CONSTRAINT fk_usuario_entra_chat_cedula FOREIGN KEY (cedula) REFERENCES usuario (cedula),
    CONSTRAINT fk_usuario_entra_chat_chat FOREIGN KEY (idChat) REFERENCES chat (idChat)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    CREATE TABLE paciente_indica_sintoma (
    cedulaPaciente INT (9) NOT NULL,
    idSintoma INT NOT NULL,
    fechaIngreso DATETIME NOT NULL,
    PRIMARY KEY (cedulaPaciente, idSintoma, fechaIngreso),
    CONSTRAINT fk_paciente_indica_sintoma_cedula FOREIGN KEY (cedulaPaciente) REFERENCES paciente (cedula),
    CONSTRAINT fk_paciente_indica_sintoma_sintoma FOREIGN KEY (idSintoma) REFERENCES sintoma (idSintoma)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    CREATE TABLE patologia_contiene_sintoma (
    idPatologia INT NOT NULL,
	idSintoma INT NOT NULL,
    PRIMARY KEY (idPatologia, idSintoma),
    CONSTRAINT fk_patologia_contiene_sintoma_idPatologia FOREIGN KEY (idPatologia) REFERENCES patologia (idPatologia),
    CONSTRAINT fk_patologia_contiene_sintoma_sintoma FOREIGN KEY (idSintoma) REFERENCES sintoma (idSintoma)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    CREATE TABLE paciente_obtiene_diagnostico (
    cedulaPaciente INT (9) NOT NULL,
    idPatologia INT NOT NULL,
    fecha DATETIME NOT NULL,
    PRIMARY KEY (cedulaPaciente, idPatologia, fecha),
    CONSTRAINT fk_paciente_obtiene_diagnostico_cedulaPaciente FOREIGN KEY (cedulaPaciente) REFERENCES paciente (cedula),
    CONSTRAINT fk_paciente_obtiene_diagnostico_idPatolgia FOREIGN KEY (idPatologia) REFERENCES patologia (idPatologia)
    ) ENGINE = InnoDB DEFAULT CHARSET = UTF8; 
    
    /* Fin de tablas */
    
/* Fin */