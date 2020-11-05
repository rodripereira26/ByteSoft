-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-08-2020 a las 08:15:44
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bytesoft_bdd`
--
CREATE DATABASE IF NOT EXISTS `bytesoft_bdd` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `bytesoft_bdd`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `chat`
--

DROP TABLE IF EXISTS `chat`;
CREATE TABLE IF NOT EXISTS `chat` (
  `idChat` int(11) NOT NULL AUTO_INCREMENT,
  `finalizado` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`idChat`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `chat`:
--

--
-- Volcado de datos para la tabla `chat`
--

INSERT INTO `chat` (`idChat`, `finalizado`) VALUES(1, 0);
INSERT INTO `chat` (`idChat`, `finalizado`) VALUES(2, 0);
INSERT INTO `chat` (`idChat`, `finalizado`) VALUES(3, 0);
INSERT INTO `chat` (`idChat`, `finalizado`) VALUES(4, 0);
INSERT INTO `chat` (`idChat`, `finalizado`) VALUES(5, 0);
INSERT INTO `chat` (`idChat`, `finalizado`) VALUES(6, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gestor`
--

DROP TABLE IF EXISTS `gestor`;
CREATE TABLE IF NOT EXISTS `gestor` (
  `cedula` int(9) NOT NULL,
  PRIMARY KEY (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `gestor`:
--   `cedula`
--       `usuario` -> `cedula`
--

--
-- Volcado de datos para la tabla `gestor`
--

INSERT INTO `gestor` (`cedula`) VALUES(5264558);
INSERT INTO `gestor` (`cedula`) VALUES(6975124);
INSERT INTO `gestor` (`cedula`) VALUES(22222222);
INSERT INTO `gestor` (`cedula`) VALUES(24357009);
INSERT INTO `gestor` (`cedula`) VALUES(39389695);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `medico`
--

DROP TABLE IF EXISTS `medico`;
CREATE TABLE IF NOT EXISTS `medico` (
  `cedula` int(9) NOT NULL,
  `especializacion` varchar(25) NOT NULL,
  PRIMARY KEY (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `medico`:
--   `cedula`
--       `usuario` -> `cedula`
--

--
-- Volcado de datos para la tabla `medico`
--

INSERT INTO `medico` (`cedula`, `especializacion`) VALUES(9679359, 'Pediatra');
INSERT INTO `medico` (`cedula`, `especializacion`) VALUES(18360276, 'General');
INSERT INTO `medico` (`cedula`, `especializacion`) VALUES(31264984, 'Oncólogo');
INSERT INTO `medico` (`cedula`, `especializacion`) VALUES(33333333, 'Pediatra');
INSERT INTO `medico` (`cedula`, `especializacion`) VALUES(53642362, 'Cardiólogo');
INSERT INTO `medico` (`cedula`, `especializacion`) VALUES(76700056, 'Cirujano');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mensaje`
--

DROP TABLE IF EXISTS `mensaje`;
CREATE TABLE IF NOT EXISTS `mensaje` (
  `idMensaje` int(11) NOT NULL AUTO_INCREMENT,
  `fechaEnvio` datetime NOT NULL,
  `cedula` int(9) NOT NULL,
  `idChat` int(11) NOT NULL,
  `mensaje` mediumblob NOT NULL,
  PRIMARY KEY (`idMensaje`,`fechaEnvio`),
  KEY `fk_chat_cedula` (`cedula`),
  KEY `fk_chat_idChat` (`idChat`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `mensaje`:
--   `cedula`
--       `usuario` -> `cedula`
--   `idChat`
--       `chat` -> `idChat`
--

--
-- Volcado de datos para la tabla `mensaje`
--

INSERT INTO `mensaje` (`idMensaje`, `fechaEnvio`, `cedula`, `idChat`, `mensaje`) VALUES(1, '2020-08-08 00:00:00', 9679359, 1, 0xc2bf43c3b36d6f2074652073656e74c3ad733f);
INSERT INTO `mensaje` (`idMensaje`, `fechaEnvio`, `cedula`, `idChat`, `mensaje`) VALUES(2, '2020-08-08 00:00:00', 34569836, 1, 0x4269656e2c206772616369617320706f722070726567756e746172);
INSERT INTO `mensaje` (`idMensaje`, `fechaEnvio`, `cedula`, `idChat`, `mensaje`) VALUES(3, '2020-08-10 00:00:00', 31264984, 2, 0x4275656e617320746172646573);
INSERT INTO `mensaje` (`idMensaje`, `fechaEnvio`, `cedula`, `idChat`, `mensaje`) VALUES(4, '2020-08-12 00:00:00', 76700056, 4, 0xc2bf43c3b36d6f2074652073656e74c3ad733f);
INSERT INTO `mensaje` (`idMensaje`, `fechaEnvio`, `cedula`, `idChat`, `mensaje`) VALUES(5, '2020-08-15 00:00:00', 15654523, 6, 0x486f6c61616161);
INSERT INTO `mensaje` (`idMensaje`, `fechaEnvio`, `cedula`, `idChat`, `mensaje`) VALUES(6, '2020-08-15 00:00:00', 15654523, 6, 0x43c3b36d6f20657374c3a1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `observacion`
--

DROP TABLE IF EXISTS `observacion`;
CREATE TABLE IF NOT EXISTS `observacion` (
  `idObservacion` int(11) NOT NULL AUTO_INCREMENT,
  `fecha` datetime NOT NULL,
  `cedulaMedico` int(9) NOT NULL,
  `cedulaPaciente` int(9) NOT NULL,
  `recomendacion` varchar(60) NOT NULL,
  `derivacion` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idObservacion`,`fecha`),
  KEY `fk_observacion_cedulaMedico` (`cedulaMedico`),
  KEY `fk_observacion_cedulaPaciente` (`cedulaPaciente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `observacion`:
--   `cedulaMedico`
--       `medico` -> `cedula`
--   `cedulaPaciente`
--       `medico` -> `cedula`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente`
--

DROP TABLE IF EXISTS `paciente`;
CREATE TABLE IF NOT EXISTS `paciente` (
  `cedula` int(9) NOT NULL,
  `fecNac` datetime NOT NULL,
  `sexo` char(1) NOT NULL,
  `verificacion` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`cedula`)
) ;

--
-- RELACIONES PARA LA TABLA `paciente`:
--   `cedula`
--       `usuario` -> `cedula`
--

--
-- Volcado de datos para la tabla `paciente`
--

INSERT INTO `paciente` (`cedula`, `fecNac`, `sexo`, `verificacion`) VALUES(9679359, '1998-10-27 00:00:00', 'M', 0);
INSERT INTO `paciente` (`cedula`, `fecNac`, `sexo`, `verificacion`) VALUES(11111111, '2001-05-26 00:00:00', 'M', 0);
INSERT INTO `paciente` (`cedula`, `fecNac`, `sexo`, `verificacion`) VALUES(15654523, '1976-09-12 00:00:00', 'M', 0);
INSERT INTO `paciente` (`cedula`, `fecNac`, `sexo`, `verificacion`) VALUES(34569836, '2002-04-16 00:00:00', 'M', 0);
INSERT INTO `paciente` (`cedula`, `fecNac`, `sexo`, `verificacion`) VALUES(49841235, '1999-07-30 00:00:00', 'M', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pacientepatologia`
--

DROP TABLE IF EXISTS `pacientepatologia`;
CREATE TABLE IF NOT EXISTS `pacientepatologia` (
  `cedula` int(9) NOT NULL,
  `patologia` varchar(25) NOT NULL,
  PRIMARY KEY (`cedula`,`patologia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `pacientepatologia`:
--   `cedula`
--       `usuario` -> `cedula`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente_indica_sintoma`
--

DROP TABLE IF EXISTS `paciente_indica_sintoma`;
CREATE TABLE IF NOT EXISTS `paciente_indica_sintoma` (
  `cedulaPaciente` int(9) NOT NULL,
  `idSintoma` int(11) NOT NULL,
  `fechaIngreso` datetime NOT NULL,
  PRIMARY KEY (`cedulaPaciente`,`idSintoma`,`fechaIngreso`),
  KEY `fk_paciente_indica_sintoma_sintoma` (`idSintoma`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `paciente_indica_sintoma`:
--   `cedulaPaciente`
--       `paciente` -> `cedula`
--   `idSintoma`
--       `sintoma` -> `idSintoma`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente_obtiene_diagnostico`
--

DROP TABLE IF EXISTS `paciente_obtiene_diagnostico`;
CREATE TABLE IF NOT EXISTS `paciente_obtiene_diagnostico` (
  `cedulaPaciente` int(9) NOT NULL,
  `idPatologia` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`cedulaPaciente`,`idPatologia`,`fecha`),
  KEY `fk_paciente_obtiene_diagnostico_idPatolgia` (`idPatologia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `paciente_obtiene_diagnostico`:
--   `cedulaPaciente`
--       `paciente` -> `cedula`
--   `idPatologia`
--       `patologia` -> `idPatologia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `patologia`
--

DROP TABLE IF EXISTS `patologia`;
CREATE TABLE IF NOT EXISTS `patologia` (
  `idPatologia` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `descripcion` varchar(25) NOT NULL,
  `recomendacion` varchar(60) NOT NULL,
  `prioridad` tinyint(1) NOT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`idPatologia`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `patologia`:
--

--
-- Volcado de datos para la tabla `patologia`
--

INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(1, 'COVID-19', '', '', 1, 0);
INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(2, 'Gripe', 'Es una enfermedad infecci', 'Mantener una buena higiene personal y beber mucho líquido, a', 3, 0);
INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(3, 'Diabetes', 'La diabetes es una enferm', 'El tratamiento de la diabetes se basa en tres pilares: dieta', 1, 0);
INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(4, 'Cáncer de pulmon', 'El cáncer de pulmón se pr', 'La elección de tratamiento dependerá de la etapa y de la ext', 1, 0);
INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(5, 'Depresión', 'La depresión se presenta ', 'El ambiente que rodea a una persona que sufre depresión es f', 2, 0);
INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(6, 'Ébola', 'El virus del Ebola se emp', 'No hay ningún tratamiento específico, aunque se están evalua', 2, 0);
INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(7, 'Gonorrea', 'La gonorrea es una infecc', 'Los antibióticos son el mejor tratamiento para tratar la gon', 2, 0);
INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(8, 'Gastroenteritis', 'La gastroenteritis es una', 'La gastroenteritis requiere un reposo alimenticio y reposici', 3, 0);
INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(9, 'Hepatitis A', 'La hepatitis A es una enf', 'No existe un tratamiento específico para la hepatitis A más ', 2, 0);
INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(10, 'Hepatitis B', 'La hepatitis B es una inf', 'La hepatitis B no necesita un tratamiento específico en la f', 1, 0);
INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(11, 'Meningitis', 'La meningitis es una enfe', 'La mayor parte de las personas que sufre una meningitis vira', 3, 0);
INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(12, 'Malaria', 'El paludismo o malaria es', 'La malaria requiere hospitalización por lo que una persona s', 2, 0);
INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`, `bajalogica`) VALUES(13, 'Neumonía', 'La neumonía es una infecc', '“Una vez que diagnosticamos la neumonía se indica inmediatam', 1, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `patologia_contiene_sintoma`
--

DROP TABLE IF EXISTS `patologia_contiene_sintoma`;
CREATE TABLE IF NOT EXISTS `patologia_contiene_sintoma` (
  `idPatologia` int(11) NOT NULL,
  `idSintoma` int(11) NOT NULL,
  PRIMARY KEY (`idPatologia`,`idSintoma`),
  KEY `fk_patologia_contiene_sintoma_sintoma` (`idSintoma`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `patologia_contiene_sintoma`:
--   `idPatologia`
--       `patologia` -> `idPatologia`
--   `idSintoma`
--       `sintoma` -> `idSintoma`
--

--
-- Volcado de datos para la tabla `patologia_contiene_sintoma`
--

INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(1, 1);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(1, 3);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(1, 9);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(1, 11);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(1, 12);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(1, 14);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(1, 26);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(2, 1);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(2, 2);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(2, 9);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(2, 11);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(2, 23);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(2, 24);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(3, 4);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(3, 12);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(3, 26);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(3, 28);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(3, 29);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(4, 3);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(4, 12);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(4, 25);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(5, 12);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(5, 16);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(5, 20);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(5, 30);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(5, 31);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(6, 1);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(6, 2);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(6, 8);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(6, 9);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(6, 10);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(6, 11);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(6, 22);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(7, 1);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(7, 10);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(7, 11);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(7, 22);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(8, 1);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(8, 7);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(8, 8);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(8, 10);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(8, 11);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(8, 22);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(9, 1);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(9, 7);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(9, 8);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(9, 12);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(9, 21);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(10, 7);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(10, 8);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(10, 10);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(10, 12);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(10, 22);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(11, 1);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(11, 11);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(11, 22);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(12, 1);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(12, 10);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(12, 11);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(12, 22);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(12, 23);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(13, 1);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(13, 3);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(13, 9);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(13, 10);
INSERT INTO `patologia_contiene_sintoma` (`idPatologia`, `idSintoma`) VALUES(13, 12);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sintoma`
--

DROP TABLE IF EXISTS `sintoma`;
CREATE TABLE IF NOT EXISTS `sintoma` (
  `idSintoma` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`idSintoma`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `sintoma`:
--

--
-- Volcado de datos para la tabla `sintoma`
--

INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(1, 'Fiebre', 'La fiebre es el aumento temporal en la temperatura', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(2, 'Comezón', 'Sensación molesta que se siente en una parte del c', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(3, 'Tos', 'Las vías respiratorias se hinchan dificultando el ', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(4, 'Deshidratación', 'La deshidratación es la alteración o falta de agua', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(5, 'Desmayo', 'Pérdida momentánea del sentido o del conocimiento ', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(6, 'Mareos', 'El mareo es un término que a menudo se utiliza par', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(7, 'Náuseas', 'La náusea es la sensación de tener ganas de vomita', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(8, 'Diarrea', 'Se le llama diarrea a las heces acuosas y blandas.', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(9, 'Dolor de garganta', 'El dolor de garganta es dolor, carraspera o irrita', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(10, 'Dolor abdominal', 'Es el dolor que se siente en el área entre el pech', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(11, 'Dolor de cabeza', 'Es un dolor o molestia en la cabeza, el cuero cabe', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(12, 'Fatiga', 'La fatiga puede ser una respuesta normal e importa', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(13, 'Asma', 'Es una enfermedad crónica que provoca que las vías', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(14, 'Problemas respiratorios', 'Los problemas respiratorios se producen cuando el ', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(15, 'Taquicardia', 'La taquicardia es un tipo frecuente de trastornos ', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(16, 'Autolesión', 'Es el acto de dañarse deliberadamente el propio cu', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(17, 'Cansancio', 'El cansancio es la falta de fuerzas después de rea', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(18, 'Conjuntivitis', 'La conjuntivitis es una de las afecciones del ojo ', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(19, 'Urticaria', 'La urticaria es una enfermedad de la piel caracter', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(20, 'Tristeza', 'Sentimiento de dolor anímico producido por un suce', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(21, 'Cólicos estomacales', 'Un cólico es un tipo de dolor abdominal que va var', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(22, 'Vómitos', 'Vomitar es cuando devuelve el contenido del estóma', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(23, 'Escalofrios', 'Se refieren a una sensación de frío después de est', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(24, 'Congestión nasal', 'Una nariz congestionada o tapada se produce cuando', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(25, 'Pérdida del olfato', 'El deterioro del olfato es la pérdida total o parc', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(26, 'Disnea', 'La disnea es una sensación de falta de aire. Mucha', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(27, 'Hormigeo', 'Son sensaciones anormales que pueden ocurrir en cu', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(28, 'Sensación de hambre', 'El hambre es una sensación que se presenta como un', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(29, 'Visión borrosa', 'La vision borrosa es la pérdida de la agudeza visu', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(30, 'Imsomnio', 'El insomnio es un trastorno del sueño que puede ma', 0);
INSERT INTO `sintoma` (`idSintoma`, `nombre`, `descripcion`, `bajalogica`) VALUES(31, 'Ansiedad', 'Sentir ansiedad de modo ocasional es una parte nor', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `cedula` int(9) NOT NULL,
  `contrasena` varchar(70) NOT NULL,
  `pNom` varchar(25) NOT NULL,
  `pApe` varchar(25) NOT NULL,
  `sNom` varchar(25) DEFAULT NULL,
  `sApe` varchar(25) NOT NULL,
  `correo` varchar(40) NOT NULL,
  `fotoPerfil` mediumblob DEFAULT NULL,
  `bajalogica` tinyint(1) NOT NULL DEFAULT 0,
  PRIMARY KEY (`cedula`),
  UNIQUE KEY `correo` (`correo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `usuario`:
--

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(5264558, 'AF851605D713D13E19FE0A718409A8F5306C3F148A631239AB24851D6C9B6029', 'Nicolás', 'Rodriguez', NULL, 'Jurado', 'nicorodriguez97@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(5456234, '4C8B422307AC7BDF38C2C17BAB533EAD4FC28D6DAEC176B195EF8A25A20A53E2', 'Gonzalo', 'Martinez', NULL, 'Jara', 'martiGon@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(6975124, 'F24ABC34B13FADE76E805799F71187DA6CD90B9CAC373AE65ED57F143BD664E5', 'Pedro', 'Pereira', NULL, 'Machado', 'machadopedro7@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(9679359, '50AD41624C25E493AA1DC7F4AB32BDC5A3B0B78ECC35B539936E3FEA7C565AF7', 'Mariano', 'Ferreira', NULL, 'Olivera', 'marianoolivera63@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(11111111, 'pruebapaciente', 'xd', 'xd', NULL, 'xd', 'xd', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(15654523, '8697e8189037e76ce6e1be276be33265def98696e240637666299b38e70ccc1e', 'Javier', 'Da Silva', NULL, 'Pérez', 'javiGonzales@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(18360276, '2F34B801CB2F8EE28525437FE45DD6E41329578F81E11904B8B35CE95DCC58AD', 'Paula', 'Falco', NULL, 'Peralta', 'paulaperelta2001@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(22222222, 'pruebagestor', 'xd', 'xd', NULL, 'xd', 'xdd', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(24357009, '3DBE378C509A4B1900E24173EF07AAD8C466FE8BEFAE256A85B5B7DBDCDCFB46', 'Pablo', 'Flores', NULL, 'Ramírez', 'pablitoramirez@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(31264984, 'A95BEE4EFB70453E61F91D2D59B727BA8F62D3CB39700FD62590D38B9344072A', 'Rodrigo', 'Oseira', NULL, 'Ochoa', 'roseira990@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(33333333, 'pruebamedico', 'xd', 'xd', NULL, 'xd', 'xddd', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(34569836, 'B6FECD38E1AF90E1D117BFE6694E0AB54D4C9447DB0C8412FE66DE3BD9E43B9F', 'Valentín', 'García', NULL, 'Maldonado', 'valegarcia@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(39012888, 'FD906B13C62DC06F7A42789988ADBEBDDCB171BE2D6B4CAF1E5991A84634BCF1', 'Ariana', 'Acosta', NULL, 'Ramos', 'ariramos@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(39389695, 'F7CDD5E13AC6DA7EF654764199CDA1BA433C93E8440876B89CC704D1AA6DAE0F', 'Fernanda', 'Acuña', NULL, 'Pérez', 'ferperez4@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(43462946, 'F369958093324770D9CE761DE406E5BD90154523C002D20FD681CF101661D9C2', 'Juan', 'Gutierrez', NULL, 'Lopez', 'juanlopez21@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(49841235, '95B99B07F44831711AA88715F8E8DE493B9AD51546018580F3140EE49D2EF573', 'Alexis', 'Rivera', NULL, 'Navarro', 'alexisnavaro666@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(53642362, 'E4508DA5D861CB30C0A622A8FB677C436C870F446103DD920B69DFBB5D638750', 'Matías', 'Padrón', NULL, 'Macedo', 'matipadron777@gmail.com', NULL, 0);
INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `pApe`, `sNom`, `sApe`, `correo`, `fotoPerfil`, `bajalogica`) VALUES(76700056, '7E5DA17A86414D890D579669A82D6226490983468D17387358EE2B63E28B7487', 'Lucía', 'Pérez', NULL, 'Olmo', 'luperez29@gmail.com', NULL, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuariotel`
--

DROP TABLE IF EXISTS `usuariotel`;
CREATE TABLE IF NOT EXISTS `usuariotel` (
  `cedula` int(9) NOT NULL,
  `telefono` int(9) NOT NULL,
  PRIMARY KEY (`cedula`,`telefono`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `usuariotel`:
--   `cedula`
--       `usuario` -> `cedula`
--

--
-- Volcado de datos para la tabla `usuariotel`
--

INSERT INTO `usuariotel` (`cedula`, `telefono`) VALUES(5264558, 9865312);
INSERT INTO `usuariotel` (`cedula`, `telefono`) VALUES(5264558, 26280256);
INSERT INTO `usuariotel` (`cedula`, `telefono`) VALUES(24357009, 24781256);
INSERT INTO `usuariotel` (`cedula`, `telefono`) VALUES(31264984, 26479612);
INSERT INTO `usuariotel` (`cedula`, `telefono`) VALUES(39389695, 97421252);
INSERT INTO `usuariotel` (`cedula`, `telefono`) VALUES(49841235, 26280259);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_entra_chat`
--

DROP TABLE IF EXISTS `usuario_entra_chat`;
CREATE TABLE IF NOT EXISTS `usuario_entra_chat` (
  `cedula` int(9) NOT NULL,
  `idChat` int(11) NOT NULL,
  `fechaIngreso` datetime NOT NULL,
  PRIMARY KEY (`cedula`,`idChat`,`fechaIngreso`),
  KEY `fk_usuario_entra_chat_chat` (`idChat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- RELACIONES PARA LA TABLA `usuario_entra_chat`:
--   `cedula`
--       `usuario` -> `cedula`
--   `idChat`
--       `chat` -> `idChat`
--

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `gestor`
--
ALTER TABLE `gestor`
  ADD CONSTRAINT `fk_gestor_cedula` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`);

--
-- Filtros para la tabla `medico`
--
ALTER TABLE `medico`
  ADD CONSTRAINT `fk_medico_cedula` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`);

--
-- Filtros para la tabla `mensaje`
--
ALTER TABLE `mensaje`
  ADD CONSTRAINT `fk_chat_cedula` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`),
  ADD CONSTRAINT `fk_chat_idChat` FOREIGN KEY (`idChat`) REFERENCES `chat` (`idChat`);

--
-- Filtros para la tabla `observacion`
--
ALTER TABLE `observacion`
  ADD CONSTRAINT `fk_observacion_cedulaMedico` FOREIGN KEY (`cedulaMedico`) REFERENCES `medico` (`cedula`),
  ADD CONSTRAINT `fk_observacion_cedulaPaciente` FOREIGN KEY (`cedulaPaciente`) REFERENCES `medico` (`cedula`);

--
-- Filtros para la tabla `paciente`
--
ALTER TABLE `paciente`
  ADD CONSTRAINT `fk_paciente_cedula` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`);

--
-- Filtros para la tabla `pacientepatologia`
--
ALTER TABLE `pacientepatologia`
  ADD CONSTRAINT `fk_pacientePatologia_cedula` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`);

--
-- Filtros para la tabla `paciente_indica_sintoma`
--
ALTER TABLE `paciente_indica_sintoma`
  ADD CONSTRAINT `fk_paciente_indica_sintoma_cedula` FOREIGN KEY (`cedulaPaciente`) REFERENCES `paciente` (`cedula`),
  ADD CONSTRAINT `fk_paciente_indica_sintoma_sintoma` FOREIGN KEY (`idSintoma`) REFERENCES `sintoma` (`idSintoma`);

--
-- Filtros para la tabla `paciente_obtiene_diagnostico`
--
ALTER TABLE `paciente_obtiene_diagnostico`
  ADD CONSTRAINT `fk_paciente_obtiene_diagnostico_cedulaPaciente` FOREIGN KEY (`cedulaPaciente`) REFERENCES `paciente` (`cedula`),
  ADD CONSTRAINT `fk_paciente_obtiene_diagnostico_idPatolgia` FOREIGN KEY (`idPatologia`) REFERENCES `patologia` (`idPatologia`);

--
-- Filtros para la tabla `patologia_contiene_sintoma`
--
ALTER TABLE `patologia_contiene_sintoma`
  ADD CONSTRAINT `fk_patologia_contiene_sintoma_idPatologia` FOREIGN KEY (`idPatologia`) REFERENCES `patologia` (`idPatologia`),
  ADD CONSTRAINT `fk_patologia_contiene_sintoma_sintoma` FOREIGN KEY (`idSintoma`) REFERENCES `sintoma` (`idSintoma`);

--
-- Filtros para la tabla `usuariotel`
--
ALTER TABLE `usuariotel`
  ADD CONSTRAINT `fk_telefonos` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`);

--
-- Filtros para la tabla `usuario_entra_chat`
--
ALTER TABLE `usuario_entra_chat`
  ADD CONSTRAINT `fk_usuario_entra_chat_cedula` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`),
  ADD CONSTRAINT `fk_usuario_entra_chat_chat` FOREIGN KEY (`idChat`) REFERENCES `chat` (`idChat`);


--
-- Metadatos
--
USE `phpmyadmin`;

--
-- Metadatos para la tabla chat
--

--
-- Metadatos para la tabla gestor
--

--
-- Metadatos para la tabla medico
--

--
-- Metadatos para la tabla mensaje
--

--
-- Metadatos para la tabla observacion
--

--
-- Metadatos para la tabla paciente
--

--
-- Metadatos para la tabla pacientepatologia
--

--
-- Metadatos para la tabla paciente_indica_sintoma
--

--
-- Metadatos para la tabla paciente_obtiene_diagnostico
--

--
-- Metadatos para la tabla patologia
--

--
-- Metadatos para la tabla patologia_contiene_sintoma
--

--
-- Metadatos para la tabla sintoma
--

--
-- Metadatos para la tabla usuario
--

--
-- Metadatos para la tabla usuariotel
--

--
-- Metadatos para la tabla usuario_entra_chat
--

--
-- Metadatos para la base de datos bytesoft_bdd
--
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
