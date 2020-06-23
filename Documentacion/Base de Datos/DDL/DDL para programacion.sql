create database if not exists BDD_Proyecto;
use BDD_Proyecto;

create table usuario (
cedula int (9) not null,
contraseña varchar (60) not null,
pNom varchar (25) not null,
sNom varchar (25) not null,
pApe varchar (25) not null,
sApe varchar (25) not null,
correo varchar (25) not null,
edad tinyint not null,
sexo char (1) not null,
fotoPerfil mediumblob,
primary key (cedula),
unique (correo)
) engine = innodb CHARACTER SET=utf8;

create table usuario_Tel (
cedula int (9) not null,
telefono int (9) not null,
primary key (cedula, telefono),
foreign key (cedula) references usuario (cedula)
) engine = innodb CHARACTER SET=utf8;

create table chat (
idChat int not null,
primary key (idChat)
) engine = innodb CHARACTER SET=utf8;

create table mensaje (
idMensaje int not null,
fechaEnvio datetime not null,
cedula int (9) not null,
idChat int not null,
mensaje mediumblob not null,
primary key (idMensaje, fechaEnvio),
foreign key (cedula) references usuario (cedula),
foreign key (idChat) references chat (idChat)
) engine = innodb CHARACTER SET=utf8;

create table gestor (
cedula int (9) not null,
primary key (cedula),
foreign key (cedula) references usuario (cedula)
) engine = innodb CHARACTER SET=utf8;

create table paciente (
cedula int (9) not null,
verificacion boolean not null,
primary key (cedula),
foreign key (cedula) references usuario (cedula)
) engine = innodb CHARACTER SET=utf8;

create table paciente_Patologia (
cedula int (9) not null,
patologia varchar (25) not null,
primary key (cedula, patologia),
foreign key (cedula) references usuario (cedula)
) engine = innodb CHARACTER SET=utf8;

create table sintoma (
idSintoma int not null,
nombre varchar (25) not null,
descripcion varchar (50) not null,
primary key (idSintoma),
unique (nombre)
) engine = innodb CHARACTER SET=utf8;

create table patologia (
idPatologia int not null,
nombre varchar (25) not null,
descripcion varchar (50) not null,
recomendacion varchar (100) not null,
prioridad tinyint(1) not null,
primary key (idPatologia),
unique (nombre)
) engine = innodb CHARACTER SET=utf8;

create table medico (
cedula int (9) not null,
especializacion varchar (25) not null,
primary key (cedula),
foreign key (cedula) references usuario (cedula)
) engine = innodb CHARACTER SET=utf8;

create table observacion (
idObservacion int not null,
fecha datetime not null,
cedulaMedico int (9) not null,
cedulaPaciente int (9) not null,
recomendacion varchar (100) not null,
derivacion varchar (30) not null,
primary key (idObservacion, fecha),
foreign key (cedulaPaciente) references paciente (cedula),
foreign key (cedulaMedico) references medico (cedula)
) engine = innodb CHARACTER SET=utf8;

create table usuario_entra_chat (
cedula int (9) not null,
idChat int not null,
fechaIngreso datetime not null,
primary key (cedula, idChat, fechaIngreso),
foreign key (cedula) references usuario (cedula),
foreign key (idChat) references chat (idChat)
) engine = innodb CHARACTER SET=utf8;

create table paciente_indica_sintoma (
cedula int (9) not null,
idSintoma int not null,
fechaIngreso datetime not null,
primary key (cedula, idSintoma, fechaIngreso),
foreign key (cedula) references paciente (cedula),
foreign key (idSintoma) references sintoma (idSintoma)
) engine = innodb CHARACTER SET=utf8;

create table reporta (
cedulaMedico int (9) not null,
cedulaPaciente int (9) not null,
fechaReporte datetime not null,
motivo varchar (30) not null,
descripción varchar (50) not null,
primary key (cedulaMedico, cedulaPaciente, fechaReporte),
foreign key (cedulaPaciente) references paciente (cedula),
foreign key (cedulaMedico) references medico (cedula)
) engine = innodb CHARACTER SET=utf8;

create table patologia_contiene_sintoma (
idPatologia int not null,
idSintoma int not null,
primary key (idPatologia, idSintoma),
foreign key (idSintoma) references sintoma (idSintoma),
foreign key (idPatologia) references patologia (idPatologia)
) engine = innodb CHARACTER SET=utf8;

create table paciente_obtiene_diagnostico (
cedulaPaciente int (9) not null,
idPatologia int not null,
idSintoma int not null,
fecha datetime not null,
primary key (idPatologia, idSintoma, fecha, cedulaPaciente),
foreign key (cedulaPaciente) references paciente (cedula),
foreign key (idSintoma) references sintoma (idSintoma),
foreign key (idPatologia) references patologia (idPatologia)
) engine = innodb CHARACTER SET=utf8;





