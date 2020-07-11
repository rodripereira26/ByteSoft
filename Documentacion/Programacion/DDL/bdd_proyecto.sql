-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 11-07-2020 a las 02:26:59
-- Versión del servidor: 5.7.26
-- Versión de PHP: 7.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `bdd_proyecto`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `chat`
--

DROP TABLE IF EXISTS `chat`;
CREATE TABLE IF NOT EXISTS `chat` (
  `idChat` int(11) NOT NULL,
  PRIMARY KEY (`idChat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gestor`
--

DROP TABLE IF EXISTS `gestor`;
CREATE TABLE IF NOT EXISTS `gestor` (
  `cedula` int(9) NOT NULL,
  PRIMARY KEY (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
-- Volcado de datos para la tabla `medico`
--

INSERT INTO `medico` (`cedula`, `especializacion`) VALUES
(5453, 'dsa'),
(534534, 'ggdf');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `mensaje`
--

DROP TABLE IF EXISTS `mensaje`;
CREATE TABLE IF NOT EXISTS `mensaje` (
  `idMensaje` int(11) NOT NULL,
  `fechaEnvio` datetime NOT NULL,
  `cedula` int(9) NOT NULL,
  `idChat` int(11) NOT NULL,
  `mensaje` mediumblob NOT NULL,
  PRIMARY KEY (`idMensaje`,`fechaEnvio`),
  KEY `cedula` (`cedula`),
  KEY `idChat` (`idChat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `observacion`
--

DROP TABLE IF EXISTS `observacion`;
CREATE TABLE IF NOT EXISTS `observacion` (
  `idObservacion` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `cedulaMedico` int(9) NOT NULL,
  `cedulaPaciente` int(9) NOT NULL,
  `recomendacion` varchar(100) NOT NULL,
  `derivacion` varchar(30) NOT NULL,
  PRIMARY KEY (`idObservacion`,`fecha`),
  KEY `cedulaPaciente` (`cedulaPaciente`),
  KEY `cedulaMedico` (`cedulaMedico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente`
--

DROP TABLE IF EXISTS `paciente`;
CREATE TABLE IF NOT EXISTS `paciente` (
  `cedula` int(9) NOT NULL,
  `verificacion` tinyint(1) NOT NULL,
  `fecNac` date NOT NULL,
  `sexo` char(1) NOT NULL,
  PRIMARY KEY (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `paciente`
--

INSERT INTO `paciente` (`cedula`, `verificacion`, `fecNac`, `sexo`) VALUES
(123, 1, '2000-02-01', 'M'),
(1234554, 1, '2000-02-01', 'M');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente_indica_sintoma`
--

DROP TABLE IF EXISTS `paciente_indica_sintoma`;
CREATE TABLE IF NOT EXISTS `paciente_indica_sintoma` (
  `cedula` int(9) NOT NULL,
  `idSintoma` int(11) NOT NULL,
  `fechaIngreso` datetime NOT NULL,
  PRIMARY KEY (`cedula`,`idSintoma`,`fechaIngreso`),
  KEY `paciente_indica_sintoma_ibfk_2_idx` (`idSintoma`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente_obtiene_diagnostico`
--

DROP TABLE IF EXISTS `paciente_obtiene_diagnostico`;
CREATE TABLE IF NOT EXISTS `paciente_obtiene_diagnostico` (
  `cedulaPaciente` int(9) NOT NULL,
  `idPatologia` int(11) NOT NULL,
  `idSintoma` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`idPatologia`,`idSintoma`,`fecha`,`cedulaPaciente`),
  KEY `cedulaPaciente` (`cedulaPaciente`),
  KEY `paciente_obtiene_diagnostico_ibfk_3_idx` (`idSintoma`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `paciente_patologia`
--

DROP TABLE IF EXISTS `paciente_patologia`;
CREATE TABLE IF NOT EXISTS `paciente_patologia` (
  `cedula` int(9) NOT NULL,
  `patologia` varchar(25) NOT NULL,
  PRIMARY KEY (`cedula`,`patologia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `patologia`
--

DROP TABLE IF EXISTS `patologia`;
CREATE TABLE IF NOT EXISTS `patologia` (
  `idPatologia` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  `recomendacion` varchar(100) NOT NULL,
  `prioridad` tinyint(1) NOT NULL,
  PRIMARY KEY (`idPatologia`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `patologia`
--

INSERT INTO `patologia` (`idPatologia`, `nombre`, `descripcion`, `recomendacion`, `prioridad`) VALUES
(1, 'hbfg', 'ghf', 'hgf', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `patologia_contiene_sintoma`
--

DROP TABLE IF EXISTS `patologia_contiene_sintoma`;
CREATE TABLE IF NOT EXISTS `patologia_contiene_sintoma` (
  `idPatologia` int(11) NOT NULL,
  `idSintoma` int(11) NOT NULL,
  PRIMARY KEY (`idPatologia`,`idSintoma`),
  KEY `patologia_contiene_sintoma_ibfk_2_idx` (`idSintoma`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporta`
--

DROP TABLE IF EXISTS `reporta`;
CREATE TABLE IF NOT EXISTS `reporta` (
  `cedulaMedico` int(9) NOT NULL,
  `cedulaPaciente` int(9) NOT NULL,
  `fechaReporte` datetime NOT NULL,
  `motivo` varchar(30) NOT NULL,
  `descripción` varchar(50) NOT NULL,
  PRIMARY KEY (`cedulaMedico`,`cedulaPaciente`,`fechaReporte`),
  KEY `cedulaPaciente` (`cedulaPaciente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sintoma`
--

DROP TABLE IF EXISTS `sintoma`;
CREATE TABLE IF NOT EXISTS `sintoma` (
  `idSintoma` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`idSintoma`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `cedula` int(9) NOT NULL,
  `contrasena` varchar(60) DEFAULT NULL,
  `pNom` varchar(25) NOT NULL,
  `sNom` varchar(25) NOT NULL,
  `pApe` varchar(25) NOT NULL,
  `sApe` varchar(25) NOT NULL,
  `correo` varchar(25) DEFAULT NULL,
  `fotoPerfil` mediumblob,
  PRIMARY KEY (`cedula`),
  UNIQUE KEY `correo` (`correo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`cedula`, `contrasena`, `pNom`, `sNom`, `pApe`, `sApe`, `correo`, `fotoPerfil`) VALUES
(123, 'asd', 'asd', 'asd', 'asd', 'asd', 'asddhfgfghfdsfsd', NULL),
(5453, '5453', 'das', 'dsa', 'dsa', 'dsa', '', NULL),
(534534, '534534', 'gdfg', 'gdfgdf', 'gfd', 'gdfhgf', 'PENDIENTE', NULL),
(1234554, 'asd', 'asd', 'asd', 'asd', 'asd', 'asddhfgfgh', NULL);

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
  KEY `idChat` (`idChat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario_tel`
--

DROP TABLE IF EXISTS `usuario_tel`;
CREATE TABLE IF NOT EXISTS `usuario_tel` (
  `cedula` int(9) NOT NULL,
  `telefono` int(9) NOT NULL,
  PRIMARY KEY (`cedula`,`telefono`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuario_tel`
--

INSERT INTO `usuario_tel` (`cedula`, `telefono`) VALUES
(123, 123),
(534534, 0),
(1234554, 123);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `gestor`
--
ALTER TABLE `gestor`
  ADD CONSTRAINT `gestor_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`);

--
-- Filtros para la tabla `medico`
--
ALTER TABLE `medico`
  ADD CONSTRAINT `medico_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`);

--
-- Filtros para la tabla `mensaje`
--
ALTER TABLE `mensaje`
  ADD CONSTRAINT `mensaje_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`),
  ADD CONSTRAINT `mensaje_ibfk_2` FOREIGN KEY (`idChat`) REFERENCES `chat` (`idChat`);

--
-- Filtros para la tabla `observacion`
--
ALTER TABLE `observacion`
  ADD CONSTRAINT `observacion_ibfk_1` FOREIGN KEY (`cedulaPaciente`) REFERENCES `paciente` (`cedula`),
  ADD CONSTRAINT `observacion_ibfk_2` FOREIGN KEY (`cedulaMedico`) REFERENCES `medico` (`cedula`);

--
-- Filtros para la tabla `paciente`
--
ALTER TABLE `paciente`
  ADD CONSTRAINT `paciente_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`);

--
-- Filtros para la tabla `paciente_indica_sintoma`
--
ALTER TABLE `paciente_indica_sintoma`
  ADD CONSTRAINT `paciente_indica_sintoma_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `paciente` (`cedula`),
  ADD CONSTRAINT `paciente_indica_sintoma_ibfk_2` FOREIGN KEY (`idSintoma`) REFERENCES `sintoma` (`idSintoma`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `paciente_obtiene_diagnostico`
--
ALTER TABLE `paciente_obtiene_diagnostico`
  ADD CONSTRAINT `paciente_obtiene_diagnostico_ibfk_1` FOREIGN KEY (`cedulaPaciente`) REFERENCES `paciente` (`cedula`),
  ADD CONSTRAINT `paciente_obtiene_diagnostico_ibfk_2` FOREIGN KEY (`idPatologia`) REFERENCES `patologia` (`idPatologia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `paciente_obtiene_diagnostico_ibfk_3` FOREIGN KEY (`idSintoma`) REFERENCES `sintoma` (`idSintoma`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `paciente_patologia`
--
ALTER TABLE `paciente_patologia`
  ADD CONSTRAINT `paciente_patologia_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`);

--
-- Filtros para la tabla `patologia_contiene_sintoma`
--
ALTER TABLE `patologia_contiene_sintoma`
  ADD CONSTRAINT `patologia_contiene_sintoma_ibfk_1` FOREIGN KEY (`idPatologia`) REFERENCES `patologia` (`idPatologia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `patologia_contiene_sintoma_ibfk_2` FOREIGN KEY (`idSintoma`) REFERENCES `sintoma` (`idSintoma`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `reporta`
--
ALTER TABLE `reporta`
  ADD CONSTRAINT `reporta_ibfk_1` FOREIGN KEY (`cedulaPaciente`) REFERENCES `paciente` (`cedula`),
  ADD CONSTRAINT `reporta_ibfk_2` FOREIGN KEY (`cedulaMedico`) REFERENCES `medico` (`cedula`);

--
-- Filtros para la tabla `usuario_entra_chat`
--
ALTER TABLE `usuario_entra_chat`
  ADD CONSTRAINT `usuario_entra_chat_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`),
  ADD CONSTRAINT `usuario_entra_chat_ibfk_2` FOREIGN KEY (`idChat`) REFERENCES `chat` (`idChat`);

--
-- Filtros para la tabla `usuario_tel`
--
ALTER TABLE `usuario_tel`
  ADD CONSTRAINT `usuario_tel_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
