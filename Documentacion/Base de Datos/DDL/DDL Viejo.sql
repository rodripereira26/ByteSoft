-- MySQL dump 10.13  Distrib 5.7.28, for Win64 (x86_64)
--
-- Host: localhost    Database: bdd_proyecto
-- ------------------------------------------------------
-- Server version	5.7.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `chat`
--

DROP TABLE IF EXISTS `chat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `chat` (
  `idChat` int(11) NOT NULL,
  PRIMARY KEY (`idChat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chat`
--

LOCK TABLES `chat` WRITE;
/*!40000 ALTER TABLE `chat` DISABLE KEYS */;
/*!40000 ALTER TABLE `chat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gestor`
--

DROP TABLE IF EXISTS `gestor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `gestor` (
  `cedula` int(9) NOT NULL,
  PRIMARY KEY (`cedula`),
  CONSTRAINT `gestor_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gestor`
--

LOCK TABLES `gestor` WRITE;
/*!40000 ALTER TABLE `gestor` DISABLE KEYS */;
/*!40000 ALTER TABLE `gestor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medico`
--

DROP TABLE IF EXISTS `medico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medico` (
  `cedula` int(9) NOT NULL,
  `especializacion` varchar(25) NOT NULL,
  PRIMARY KEY (`cedula`),
  CONSTRAINT `medico_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medico`
--

LOCK TABLES `medico` WRITE;
/*!40000 ALTER TABLE `medico` DISABLE KEYS */;
/*!40000 ALTER TABLE `medico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mensaje`
--

DROP TABLE IF EXISTS `mensaje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mensaje` (
  `idMensaje` int(11) NOT NULL,
  `fechaEnvio` datetime NOT NULL,
  `cedula` int(9) NOT NULL,
  `idChat` int(11) NOT NULL,
  `mensaje` mediumblob NOT NULL,
  PRIMARY KEY (`idMensaje`,`fechaEnvio`),
  KEY `cedula` (`cedula`),
  KEY `idChat` (`idChat`),
  CONSTRAINT `mensaje_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`),
  CONSTRAINT `mensaje_ibfk_2` FOREIGN KEY (`idChat`) REFERENCES `chat` (`idChat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mensaje`
--

LOCK TABLES `mensaje` WRITE;
/*!40000 ALTER TABLE `mensaje` DISABLE KEYS */;
/*!40000 ALTER TABLE `mensaje` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `observacion`
--

DROP TABLE IF EXISTS `observacion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `observacion` (
  `idObservacion` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  `cedulaMedico` int(9) NOT NULL,
  `cedulaPaciente` int(9) NOT NULL,
  `recomendacion` varchar(100) NOT NULL,
  `derivacion` varchar(30) NOT NULL,
  PRIMARY KEY (`idObservacion`,`fecha`),
  KEY `cedulaPaciente` (`cedulaPaciente`),
  KEY `cedulaMedico` (`cedulaMedico`),
  CONSTRAINT `observacion_ibfk_1` FOREIGN KEY (`cedulaPaciente`) REFERENCES `paciente` (`cedula`),
  CONSTRAINT `observacion_ibfk_2` FOREIGN KEY (`cedulaMedico`) REFERENCES `medico` (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `observacion`
--

LOCK TABLES `observacion` WRITE;
/*!40000 ALTER TABLE `observacion` DISABLE KEYS */;
/*!40000 ALTER TABLE `observacion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paciente` (
  `cedula` int(9) NOT NULL,
  `verificacion` tinyint(1) NOT NULL,
  `fecNac` date NOT NULL,
  `sexo` char(1) NOT NULL,
  PRIMARY KEY (`cedula`),
  CONSTRAINT `paciente_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente_indica_sintoma`
--

DROP TABLE IF EXISTS `paciente_indica_sintoma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paciente_indica_sintoma` (
  `cedula` int(9) NOT NULL,
  `idSintoma` int(11) NOT NULL,
  `fechaIngreso` datetime NOT NULL,
  PRIMARY KEY (`cedula`,`idSintoma`,`fechaIngreso`),
  KEY `paciente_indica_sintoma_ibfk_2_idx` (`idSintoma`),
  CONSTRAINT `paciente_indica_sintoma_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `paciente` (`cedula`),
  CONSTRAINT `paciente_indica_sintoma_ibfk_2` FOREIGN KEY (`idSintoma`) REFERENCES `sintoma` (`idSintoma`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente_indica_sintoma`
--

LOCK TABLES `paciente_indica_sintoma` WRITE;
/*!40000 ALTER TABLE `paciente_indica_sintoma` DISABLE KEYS */;
/*!40000 ALTER TABLE `paciente_indica_sintoma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente_obtiene_diagnostico`
--

DROP TABLE IF EXISTS `paciente_obtiene_diagnostico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paciente_obtiene_diagnostico` (
  `cedulaPaciente` int(9) NOT NULL,
  `idPatologia` int(11) NOT NULL,
  `idSintoma` int(11) NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`idPatologia`,`idSintoma`,`fecha`,`cedulaPaciente`),
  KEY `cedulaPaciente` (`cedulaPaciente`),
  KEY `paciente_obtiene_diagnostico_ibfk_3_idx` (`idSintoma`),
  CONSTRAINT `paciente_obtiene_diagnostico_ibfk_1` FOREIGN KEY (`cedulaPaciente`) REFERENCES `paciente` (`cedula`),
  CONSTRAINT `paciente_obtiene_diagnostico_ibfk_2` FOREIGN KEY (`idPatologia`) REFERENCES `patologia` (`idPatologia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `paciente_obtiene_diagnostico_ibfk_3` FOREIGN KEY (`idSintoma`) REFERENCES `sintoma` (`idSintoma`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente_obtiene_diagnostico`
--

LOCK TABLES `paciente_obtiene_diagnostico` WRITE;
/*!40000 ALTER TABLE `paciente_obtiene_diagnostico` DISABLE KEYS */;
/*!40000 ALTER TABLE `paciente_obtiene_diagnostico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente_patologia`
--

DROP TABLE IF EXISTS `paciente_patologia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paciente_patologia` (
  `cedula` int(9) NOT NULL,
  `patologia` varchar(25) NOT NULL,
  PRIMARY KEY (`cedula`,`patologia`),
  CONSTRAINT `paciente_patologia_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente_patologia`
--

LOCK TABLES `paciente_patologia` WRITE;
/*!40000 ALTER TABLE `paciente_patologia` DISABLE KEYS */;
/*!40000 ALTER TABLE `paciente_patologia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patologia`
--

DROP TABLE IF EXISTS `patologia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patologia` (
  `idPatologia` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  `recomendacion` varchar(100) NOT NULL,
  `prioridad` tinyint(1) NOT NULL,
  PRIMARY KEY (`idPatologia`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patologia`
--

LOCK TABLES `patologia` WRITE;
/*!40000 ALTER TABLE `patologia` DISABLE KEYS */;
/*!40000 ALTER TABLE `patologia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patologia_contiene_sintoma`
--

DROP TABLE IF EXISTS `patologia_contiene_sintoma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patologia_contiene_sintoma` (
  `idPatologia` int(11) NOT NULL,
  `idSintoma` int(11) NOT NULL,
  PRIMARY KEY (`idPatologia`,`idSintoma`),
  KEY `patologia_contiene_sintoma_ibfk_2_idx` (`idSintoma`),
  CONSTRAINT `patologia_contiene_sintoma_ibfk_1` FOREIGN KEY (`idPatologia`) REFERENCES `patologia` (`idPatologia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `patologia_contiene_sintoma_ibfk_2` FOREIGN KEY (`idSintoma`) REFERENCES `sintoma` (`idSintoma`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patologia_contiene_sintoma`
--

LOCK TABLES `patologia_contiene_sintoma` WRITE;
/*!40000 ALTER TABLE `patologia_contiene_sintoma` DISABLE KEYS */;
/*!40000 ALTER TABLE `patologia_contiene_sintoma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporta`
--

DROP TABLE IF EXISTS `reporta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reporta` (
  `cedulaMedico` int(9) NOT NULL,
  `cedulaPaciente` int(9) NOT NULL,
  `fechaReporte` datetime NOT NULL,
  `motivo` varchar(30) NOT NULL,
  `descripción` varchar(50) NOT NULL,
  PRIMARY KEY (`cedulaMedico`,`cedulaPaciente`,`fechaReporte`),
  KEY `cedulaPaciente` (`cedulaPaciente`),
  CONSTRAINT `reporta_ibfk_1` FOREIGN KEY (`cedulaPaciente`) REFERENCES `paciente` (`cedula`),
  CONSTRAINT `reporta_ibfk_2` FOREIGN KEY (`cedulaMedico`) REFERENCES `medico` (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporta`
--

LOCK TABLES `reporta` WRITE;
/*!40000 ALTER TABLE `reporta` DISABLE KEYS */;
/*!40000 ALTER TABLE `reporta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sintoma`
--

DROP TABLE IF EXISTS `sintoma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sintoma` (
  `idSintoma` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`idSintoma`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sintoma`
--

LOCK TABLES `sintoma` WRITE;
/*!40000 ALTER TABLE `sintoma` DISABLE KEYS */;
/*!40000 ALTER TABLE `sintoma` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
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
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_entra_chat`
--

DROP TABLE IF EXISTS `usuario_entra_chat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario_entra_chat` (
  `cedula` int(9) NOT NULL,
  `idChat` int(11) NOT NULL,
  `fechaIngreso` datetime NOT NULL,
  PRIMARY KEY (`cedula`,`idChat`,`fechaIngreso`),
  KEY `idChat` (`idChat`),
  CONSTRAINT `usuario_entra_chat_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`),
  CONSTRAINT `usuario_entra_chat_ibfk_2` FOREIGN KEY (`idChat`) REFERENCES `chat` (`idChat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_entra_chat`
--

LOCK TABLES `usuario_entra_chat` WRITE;
/*!40000 ALTER TABLE `usuario_entra_chat` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario_entra_chat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario_tel`
--

DROP TABLE IF EXISTS `usuario_tel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario_tel` (
  `cedula` int(9) NOT NULL,
  `telefono` int(9) NOT NULL,
  PRIMARY KEY (`cedula`,`telefono`),
  CONSTRAINT `usuario_tel_ibfk_1` FOREIGN KEY (`cedula`) REFERENCES `usuario` (`cedula`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario_tel`
--

LOCK TABLES `usuario_tel` WRITE;
/*!40000 ALTER TABLE `usuario_tel` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario_tel` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-07-17 21:06:47
