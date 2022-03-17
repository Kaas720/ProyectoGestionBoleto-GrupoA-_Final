-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: MYSQL5040.site4now.net    Database: db_a83d0f_a7eb45
-- ------------------------------------------------------
-- Server version	5.6.46-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `administrador`
--

DROP TABLE IF EXISTS `administrador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administrador` (
  `idAdmnistrador` int(11) NOT NULL AUTO_INCREMENT,
  `CodAcceso` varchar(10) NOT NULL,
  `Sueldo` double NOT NULL,
  `Estado` char(1) NOT NULL,
  `idPersona` int(11) NOT NULL,
  `IdCredencial` int(11) DEFAULT NULL,
  PRIMARY KEY (`idAdmnistrador`),
  KEY `Idpersona_idx` (`idPersona`),
  KEY `IdCrendecial_idx` (`IdCredencial`),
  CONSTRAINT `IdCrendecial` FOREIGN KEY (`IdCredencial`) REFERENCES `iniciosesion` (`idInicioSesion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Idpersona` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrador`
--

LOCK TABLES `administrador` WRITE;
/*!40000 ALTER TABLE `administrador` DISABLE KEYS */;
INSERT INTO `administrador` VALUES (1,'0988373733',800.5,'A',2,7),(2,'1244333994',820.5,'A',3,8),(3,'1234578889',800.5,'A',4,9),(4,'0983736363',790.5,'A',6,11),(5,'4267717199',800.5,'A',7,12);
/*!40000 ALTER TABLE `administrador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `asientos_bus`
--

DROP TABLE IF EXISTS `asientos_bus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asientos_bus` (
  `idAsientos_bus` int(11) NOT NULL AUTO_INCREMENT,
  `DescripcionBus` varchar(45) NOT NULL,
  `Estado` varchar(1) NOT NULL,
  `Id_bus` int(11) NOT NULL,
  `IdBoleto_Generado` int(1) DEFAULT NULL,
  PRIMARY KEY (`idAsientos_bus`),
  UNIQUE KEY `idAsientos_bus_UNIQUE` (`idAsientos_bus`),
  KEY `DkBus_idx` (`Id_bus`),
  KEY `FkIg_generardor_boleto_idx` (`IdBoleto_Generado`),
  CONSTRAINT `DkBus` FOREIGN KEY (`Id_bus`) REFERENCES `bus_cooperativa` (`idBus`),
  CONSTRAINT `FkIg_generardor_boleto` FOREIGN KEY (`IdBoleto_Generado`) REFERENCES `generar_boleto` (`idboleto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=211 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asientos_bus`
--

LOCK TABLES `asientos_bus` WRITE;
/*!40000 ALTER TABLE `asientos_bus` DISABLE KEYS */;
INSERT INTO `asientos_bus` VALUES (1,'A1','I',1,1),(2,'A2','I',1,1),(3,'A3','I',1,1),(4,'A4','I',1,1),(5,'A5','I',1,1),(6,'A6','A',1,1),(7,'A7','I',1,1),(8,'A8','I',1,1),(9,'A9','A',1,1),(10,'A10','I',1,1),(11,'A11','A',1,1),(12,'A12','A',1,1),(13,'A13','A',1,1),(14,'A14','A',1,1),(15,'A15','A',1,1),(16,'B1','A',1,1),(17,'B2','A',1,1),(18,'B3','A',1,1),(19,'B4','A',1,1),(20,'B5','A',1,1),(21,'B6','A',1,1),(22,'B7','A',1,1),(23,'B8','A',1,1),(24,'B9','A',1,1),(25,'B10','A',1,1),(26,'B11','A',1,1),(27,'B12','A',1,1),(28,'B13','A',1,1),(29,'B14','A',1,1),(30,'B15','A',1,1),(31,'A1','I',1,2),(32,'A2','I',1,2),(33,'A3','I',1,2),(34,'A4','A',1,2),(35,'A5','I',1,2),(36,'A6','A',1,2),(37,'A7','A',1,2),(38,'A8','A',1,2),(39,'A9','A',1,2),(40,'A10','A',1,2),(41,'A11','A',1,2),(42,'A12','A',1,2),(43,'A13','A',1,2),(44,'A14','A',1,2),(45,'A15','A',1,2),(46,'B1','A',1,2),(47,'B2','A',1,2),(48,'B3','A',1,2),(49,'B4','A',1,2),(50,'B5','A',1,2),(51,'B6','A',1,2),(52,'B7','A',1,2),(53,'B8','A',1,2),(54,'B9','A',1,2),(55,'B10','A',1,2),(56,'B11','A',1,2),(57,'B12','A',1,2),(58,'B13','A',1,2),(59,'B14','A',1,2),(60,'B15','A',1,2),(61,'A1','A',7,12),(62,'A2','A',7,12),(63,'A3','A',7,12),(64,'A4','A',7,12),(65,'A5','I',7,12),(66,'A6','A',7,12),(67,'A7','A',7,12),(68,'A8','A',7,12),(69,'A9','A',7,12),(70,'A10','A',7,12),(71,'A11','A',7,12),(72,'A12','A',7,12),(73,'A13','A',7,12),(74,'A14','A',7,12),(75,'A15','A',7,12),(76,'B1','A',7,12),(77,'B2','A',7,12),(78,'B3','A',7,12),(79,'B4','A',7,12),(80,'B5','A',7,12),(81,'B6','A',7,12),(82,'B7','A',7,12),(83,'B8','A',7,12),(84,'B9','A',7,12),(85,'B10','A',7,12),(86,'B11','A',7,12),(87,'B12','A',7,12),(88,'B13','A',7,12),(89,'B14','A',7,12),(90,'B15','A',7,12),(91,'A1','A',7,13),(92,'A2','A',7,13),(93,'A3','A',7,13),(94,'A4','A',7,13),(95,'A5','I',7,13),(96,'A6','A',7,13),(97,'A7','A',7,13),(98,'A8','A',7,13),(99,'A9','A',7,13),(100,'A10','A',7,13),(101,'A11','A',7,13),(102,'A12','A',7,13),(103,'A13','A',7,13),(104,'A14','A',7,13),(105,'A15','A',7,13),(106,'B1','A',7,13),(107,'B2','A',7,13),(108,'B3','A',7,13),(109,'B4','A',7,13),(110,'B5','A',7,13),(111,'B6','A',7,13),(112,'B7','A',7,13),(113,'B8','A',7,13),(114,'B9','A',7,13),(115,'B10','A',7,13),(116,'B11','A',7,13),(117,'B12','A',7,13),(118,'B13','A',7,13),(119,'B14','A',7,13),(120,'B15','A',7,13),(121,'A1','A',3,14),(122,'A2','A',3,14),(123,'A3','A',3,14),(124,'A4','A',3,14),(125,'A5','I',3,14),(126,'A6','A',3,14),(127,'A7','A',3,14),(128,'A8','A',3,14),(129,'A9','A',3,14),(130,'A10','A',3,14),(131,'A11','A',3,14),(132,'A12','A',3,14),(133,'A13','A',3,14),(134,'A14','A',3,14),(135,'A15','A',3,14),(136,'B1','A',3,14),(137,'B2','A',3,14),(138,'B3','A',3,14),(139,'B4','A',3,14),(140,'B5','A',3,14),(141,'B6','A',3,14),(142,'B7','A',3,14),(143,'B8','A',3,14),(144,'B9','A',3,14),(145,'B10','A',3,14),(146,'B11','A',3,14),(147,'B12','A',3,14),(148,'B13','A',3,14),(149,'B14','A',3,14),(150,'B15','A',3,14),(151,'A1','A',3,15),(152,'A2','A',3,15),(153,'A3','A',3,15),(154,'A4','A',3,15),(155,'A5','I',3,15),(156,'A6','A',3,15),(157,'A7','A',3,15),(158,'A8','A',3,15),(159,'A9','A',3,15),(160,'A10','A',3,15),(161,'A11','A',3,15),(162,'A12','A',3,15),(163,'A13','A',3,15),(164,'A14','A',3,15),(165,'A15','A',3,15),(166,'B1','A',3,15),(167,'B2','A',3,15),(168,'B3','A',3,15),(169,'B4','A',3,15),(170,'B5','A',3,15),(171,'B6','A',3,15),(172,'B7','A',3,15),(173,'B8','A',3,15),(174,'B9','A',3,15),(175,'B10','A',3,15),(176,'B11','A',3,15),(177,'B12','A',3,15),(178,'B13','A',3,15),(179,'B14','A',3,15),(180,'B15','A',3,15),(181,'A1','I',3,16),(182,'A2','I',3,16),(183,'A3','A',3,16),(184,'A4','A',3,16),(185,'A5','I',3,16),(186,'A6','A',3,16),(187,'A7','A',3,16),(188,'A8','A',3,16),(189,'A9','A',3,16),(190,'A10','A',3,16),(191,'A11','A',3,16),(192,'A12','A',3,16),(193,'A13','A',3,16),(194,'A14','A',3,16),(195,'A15','A',3,16),(196,'B1','A',3,16),(197,'B2','A',3,16),(198,'B3','A',3,16),(199,'B4','A',3,16),(200,'B5','A',3,16),(201,'B6','A',3,16),(202,'B7','A',3,16),(203,'B8','A',3,16),(204,'B9','A',3,16),(205,'B10','A',3,16),(206,'B11','A',3,16),(207,'B12','A',3,16),(208,'B13','A',3,16),(209,'B14','A',3,16),(210,'B15','A',3,16);
/*!40000 ALTER TABLE `asientos_bus` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `boleto`
--

DROP TABLE IF EXISTS `boleto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `boleto` (
  `idBoleto` int(11) NOT NULL AUTO_INCREMENT,
  `Cantidad` int(11) NOT NULL,
  `Precio` double NOT NULL,
  PRIMARY KEY (`idBoleto`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `boleto`
--

LOCK TABLES `boleto` WRITE;
/*!40000 ALTER TABLE `boleto` DISABLE KEYS */;
INSERT INTO `boleto` VALUES (1,40,8.5),(2,40,10.25),(3,40,12.5),(4,40,14.5),(5,40,6.25),(6,40,20),(7,40,10),(8,40,20),(9,40,20),(10,40,10),(11,40,345345),(12,40,1),(13,40,10),(14,40,10),(15,40,15),(16,40,20),(17,40,10),(18,40,12);
/*!40000 ALTER TABLE `boleto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bus_cooperativa`
--

DROP TABLE IF EXISTS `bus_cooperativa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bus_cooperativa` (
  `idBus` int(11) NOT NULL AUTO_INCREMENT,
  `Placa` varchar(10) NOT NULL,
  `Disco` varchar(45) NOT NULL,
  `Modelo` varchar(45) NOT NULL,
  `Marca` varchar(45) NOT NULL,
  `CantidadAsiento` int(11) NOT NULL,
  `Ruta_id` int(11) NOT NULL,
  `Cooperativa_id` int(11) NOT NULL,
  PRIMARY KEY (`idBus`),
  KEY `Ruta_idx` (`Ruta_id`),
  CONSTRAINT `Ruta` FOREIGN KEY (`Ruta_id`) REFERENCES `ruta` (`idRuta`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bus_cooperativa`
--

LOCK TABLES `bus_cooperativa` WRITE;
/*!40000 ALTER TABLE `bus_cooperativa` DISABLE KEYS */;
INSERT INTO `bus_cooperativa` VALUES (1,'ABC-1234','001','2','Mercedes Benz',30,1,1),(2,'ABC-7520','005','2','Mercedes Benz',40,1,1),(3,'ABC-1280','004','1','Mercedes Benz',40,5,3),(4,'GTU-1680','007','1','Mercedes Benz',38,4,5),(5,'XSD-1938','002','1','Mercedes Benz',40,5,6),(6,'SDF-4534','003','1','Mercedes Benz',40,6,1),(7,'BBH-3444','004','1','Mercedes Benz',40,2,1);
/*!40000 ALTER TABLE `bus_cooperativa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cabecerafactura`
--

DROP TABLE IF EXISTS `cabecerafactura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cabecerafactura` (
  `idCabeceraFactura` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `nombreCooperativa` varchar(25) NOT NULL,
  `fechaEmision` datetime NOT NULL,
  `idboleto` int(11) NOT NULL,
  `Estado` char(1) NOT NULL,
  PRIMARY KEY (`idCabeceraFactura`),
  KEY `foreingKeycf` (`idboleto`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cabecerafactura`
--

LOCK TABLES `cabecerafactura` WRITE;
/*!40000 ALTER TABLE `cabecerafactura` DISABLE KEYS */;
/*!40000 ALTER TABLE `cabecerafactura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `candidatos`
--

DROP TABLE IF EXISTS `candidatos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `candidatos` (
  `idCandidatos` int(11) NOT NULL AUTO_INCREMENT,
  `Cedula` varchar(11) NOT NULL,
  `Foto` mediumblob,
  `Usuario` varchar(45) NOT NULL,
  `Contrasena` varchar(15) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Correo` varchar(45) NOT NULL,
  `Sexo` varchar(45) NOT NULL,
  `FechaNacimiento` varchar(45) NOT NULL,
  `Estado` varchar(1) NOT NULL,
  `FechaRegistro` date NOT NULL,
  PRIMARY KEY (`idCandidatos`),
  UNIQUE KEY `idCandidatos_UNIQUE` (`idCandidatos`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `candidatos`
--

LOCK TABLES `candidatos` WRITE;
/*!40000 ALTER TABLE `candidatos` DISABLE KEYS */;
INSERT INTO `candidatos` VALUES (1,'0302527742',NULL,'Kaas7520','1234','0991887965','kaas@hotmail.com','Masculino','2000-05-07','A','2020-03-25'),(3,'0943242420',NULL,'Adriangel','1234','099187269','adrian-chavarrea@hotmail.com','Masculino','1999-03-16','A','2020-02-22'),(4,'0917100851',NULL,'bachi99','1234','0990423583','beatriz-99@hotmail.com','Femenino','1975-12-02','A','2020-02-25'),(5,'0934573629',NULL,'ayoranicole','1234','0943782945','dianaayora@gmail.com','Femenino','1998-12-21','A','2020-01-25'),(6,'1123456789',NULL,'andres69','1234','0927490267','yori69@gmail.com','Masculino','1996-01-06','A','2020-03-10');
/*!40000 ALTER TABLE `candidatos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categorias_comisiones`
--

DROP TABLE IF EXISTS `categorias_comisiones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `categorias_comisiones` (
  `idCategorias_Comisiones` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) NOT NULL,
  `Comision` int(11) NOT NULL,
  `FechaRegistro` date NOT NULL,
  `Estado` varchar(1) NOT NULL,
  PRIMARY KEY (`idCategorias_Comisiones`),
  UNIQUE KEY `idCategorias_Comisiones_UNIQUE` (`idCategorias_Comisiones`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categorias_comisiones`
--

LOCK TABLES `categorias_comisiones` WRITE;
/*!40000 ALTER TABLE `categorias_comisiones` DISABLE KEYS */;
INSERT INTO `categorias_comisiones` VALUES (1,' empleos operativos',3,'2020-03-25','A'),(2,' empleos administrativos',5,'2020-03-25','A');
/*!40000 ALTER TABLE `categorias_comisiones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chofer`
--

DROP TABLE IF EXISTS `chofer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chofer` (
  `idChofer` int(11) NOT NULL AUTO_INCREMENT,
  `Licencia` varchar(10) NOT NULL,
  `Sueldo` double NOT NULL,
  `Estado` char(1) NOT NULL,
  `idPersona` int(11) DEFAULT NULL,
  `IdCredencial` int(11) DEFAULT NULL,
  PRIMARY KEY (`idChofer`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chofer`
--

LOCK TABLES `chofer` WRITE;
/*!40000 ALTER TABLE `chofer` DISABLE KEYS */;
INSERT INTO `chofer` VALUES (6,'7733929920',60025,'A',8,14),(7,'1293874455',68050,'A',9,15),(9,'0990026262',60050,'A',17,23),(10,'0098367633',60050,'A',18,24),(11,'9087746643',50050,'A',19,25);
/*!40000 ALTER TABLE `chofer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ciudad`
--

DROP TABLE IF EXISTS `ciudad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ciudad` (
  `idCiudad` int(11) NOT NULL AUTO_INCREMENT,
  `DescripcionCiudad` varchar(45) NOT NULL,
  `Estado` varchar(1) NOT NULL,
  `FechaRegistro` date NOT NULL,
  `Estado/Provincia_idEstado/Provincia` int(11) NOT NULL,
  PRIMARY KEY (`idCiudad`),
  UNIQUE KEY `idCiudad_UNIQUE` (`idCiudad`),
  KEY `fk_Ciudad_Estado/Provincia1_idx` (`Estado/Provincia_idEstado/Provincia`),
  CONSTRAINT `fk_Ciudad_Estado/Provincia1` FOREIGN KEY (`Estado/Provincia_idEstado/Provincia`) REFERENCES `estado/provincia` (`idEstado/Provincia`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciudad`
--

LOCK TABLES `ciudad` WRITE;
/*!40000 ALTER TABLE `ciudad` DISABLE KEYS */;
INSERT INTO `ciudad` VALUES (1,'Guayaquil','A','2019-03-25',1),(2,'Duran','A','2019-03-25',1),(3,'Troncal','A','2019-03-25',4),(4,'Azoguez','A','2019-03-25',4),(5,'Quito','A','2019-03-25',2),(6,'Manta','A','2019-03-25',3);
/*!40000 ALTER TABLE `ciudad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL AUTO_INCREMENT,
  `Estado` varchar(1) NOT NULL,
  `idPersona` int(11) NOT NULL,
  `IdCredencial` int(11) NOT NULL,
  PRIMARY KEY (`idCliente`),
  KEY `IdPersonaFk_idx` (`idPersona`),
  KEY `IdCredencialFk_idx` (`IdCredencial`),
  CONSTRAINT `IdCredencialFk` FOREIGN KEY (`IdCredencial`) REFERENCES `iniciosesion` (`idInicioSesion`),
  CONSTRAINT `IdPersonaFking` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'A',1,6),(2,'A',5,10),(5,'A',22,28),(6,'A',23,29),(7,'A',24,30),(8,'A',25,31),(9,'A',26,32);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `idClientes` int(11) NOT NULL AUTO_INCREMENT,
  `Estado` varchar(1) NOT NULL,
  `FechaRegistro` date NOT NULL,
  `TipoCliente_idTipoCliente` int(11) NOT NULL,
  `DetalleCliente_idDetalleCliente` int(11) NOT NULL,
  `TipoEmpresa_idTipoEmpresa` int(11) NOT NULL,
  PRIMARY KEY (`idClientes`),
  UNIQUE KEY `idClientes_UNIQUE` (`idClientes`),
  KEY `fk_Clientes_TipoCliente1_idx` (`TipoCliente_idTipoCliente`),
  KEY `fk_Clientes_DetalleCliente1_idx` (`DetalleCliente_idDetalleCliente`),
  KEY `fk_Clientes_TipoEmpresa1_idx` (`TipoEmpresa_idTipoEmpresa`),
  CONSTRAINT `fk_Clientes_DetalleCliente1` FOREIGN KEY (`DetalleCliente_idDetalleCliente`) REFERENCES `detallecliente` (`idDetalleCliente`),
  CONSTRAINT `fk_Clientes_TipoCliente1` FOREIGN KEY (`TipoCliente_idTipoCliente`) REFERENCES `tipocliente` (`idTipoCliente`),
  CONSTRAINT `fk_Clientes_TipoEmpresa1` FOREIGN KEY (`TipoEmpresa_idTipoEmpresa`) REFERENCES `tipoempresa` (`idTipoEmpresa`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (8,'A','2020-03-25',1,6,3),(9,'A','2020-03-25',1,2,3),(10,'A','2020-03-25',1,3,3),(11,'A','2020-03-25',1,4,3),(12,'A','2020-03-25',1,5,3),(13,'A','2020-03-25',1,7,3),(14,'A','2020-03-25',1,8,3),(15,'A','2020-03-25',1,9,3),(16,'A','2020-03-25',1,10,3),(17,'A','2020-03-25',1,11,3);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comisiones`
--

DROP TABLE IF EXISTS `comisiones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comisiones` (
  `idComisiones` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) NOT NULL,
  `Estado` varchar(45) NOT NULL,
  `FechaRegistro` date NOT NULL,
  `Categorias_Comisiones_idCategorias_Comisiones` int(11) NOT NULL,
  PRIMARY KEY (`idComisiones`),
  UNIQUE KEY `idComisiones_UNIQUE` (`idComisiones`),
  KEY `fk_Comisiones_Categorias_Comisiones1_idx` (`Categorias_Comisiones_idCategorias_Comisiones`),
  CONSTRAINT `fk_Comisiones_Categorias_Comisiones1` FOREIGN KEY (`Categorias_Comisiones_idCategorias_Comisiones`) REFERENCES `categorias_comisiones` (`idCategorias_Comisiones`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comisiones`
--

LOCK TABLES `comisiones` WRITE;
/*!40000 ALTER TABLE `comisiones` DISABLE KEYS */;
INSERT INTO `comisiones` VALUES (1,'Comicon por trabajo administrativos ','A','2022-01-17',2),(2,'Operador de maquina pesada','A','2022-01-17',1),(3,'Secreteraria de Gerente','A','2022-01-17',2),(4,'Coordinador de Talento Humano','A','2022-01-17',2),(5,'Coordinador de operaciones ','A','2022-01-17',1),(6,'Jefatura','A','2022-01-17',2),(7,'Supervisor','A','2022-01-17',2),(8,'Supervisor de Operaciones','A','2022-01-17',1),(9,'Técnico de desarrollo','A','2022-01-17',1),(10,'Sistemas','A','2022-01-17',1);
/*!40000 ALTER TABLE `comisiones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `competencias`
--

DROP TABLE IF EXISTS `competencias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `competencias` (
  `idCompetencias` int(11) NOT NULL AUTO_INCREMENT,
  `DescripcionCompetencia` varchar(45) NOT NULL,
  `Estado` varchar(1) NOT NULL,
  `FechaRegisto` date NOT NULL,
  PRIMARY KEY (`idCompetencias`),
  UNIQUE KEY `idCompetencias_UNIQUE` (`idCompetencias`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `competencias`
--

LOCK TABLES `competencias` WRITE;
/*!40000 ALTER TABLE `competencias` DISABLE KEYS */;
/*!40000 ALTER TABLE `competencias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cooperativa`
--

DROP TABLE IF EXISTS `cooperativa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cooperativa` (
  `idCooperativa` int(11) NOT NULL AUTO_INCREMENT,
  `Ruc` varchar(10) NOT NULL,
  `Propietario` varchar(45) NOT NULL,
  `NombreCooperativa` varchar(45) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Estado` char(1) NOT NULL,
  `IdCredencial` int(11) NOT NULL,
  PRIMARY KEY (`idCooperativa`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cooperativa`
--

LOCK TABLES `cooperativa` WRITE;
/*!40000 ALTER TABLE `cooperativa` DISABLE KEYS */;
INSERT INTO `cooperativa` VALUES (1,'0938873744','Andres Mendez','Troncaleña','0974783646','A',1),(3,'0923737737','Manuel Reyes','Ecuatoriano Pulman','0938377636','A',2),(4,'0926637737','María Reyes','Loja','0938323636','A',3),(5,'0920037737','Erika Garcia','Playas','0938887636','A',4),(6,'0923123737','Juan Rosado','Rutas Orenses','0938322636','A',5),(7,'0262777288','Hamilton Fara','Yanzaza','0987625355','A',13);
/*!40000 ALTER TABLE `cooperativa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_factura`
--

DROP TABLE IF EXISTS `detalle_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_factura` (
  `idDetalle_Factura` int(11) NOT NULL AUTO_INCREMENT,
  `Estado` varchar(1) NOT NULL,
  `FechaRegistro` date NOT NULL,
  `ID_boleto` int(11) NOT NULL,
  `Numero_Factura` int(11) NOT NULL,
  `ID_cliente` varchar(45) DEFAULT NULL,
  `Cedula_Comprador` varchar(10) DEFAULT NULL,
  `Nombre_comprador` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idDetalle_Factura`),
  UNIQUE KEY `Numero_Factura_UNIQUE` (`Numero_Factura`)
) ENGINE=MyISAM AUTO_INCREMENT=153 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_factura`
--

LOCK TABLES `detalle_factura` WRITE;
/*!40000 ALTER TABLE `detalle_factura` DISABLE KEYS */;
INSERT INTO `detalle_factura` VALUES (152,'A','2022-03-16',2,130,'','1728221929','Maribel ARAUJO'),(151,'A','2022-03-15',1,129,'','5454545487','jejejejejejeje'),(150,'A','2022-03-14',1,128,'','0302527742','Kevin'),(149,'A','2022-03-14',1,127,'','0030230324','Juan'),(148,'A','2022-03-14',1,126,'','0324234324','Marcos'),(142,'A','2022-03-14',16,120,'','4353543453','Juan'),(143,'A','2022-03-14',16,121,'','0302527742','Kaas'),(144,'A','2022-03-14',1,122,'','8979797979','KEVIN arevalo'),(145,'A','2022-03-14',2,123,'','0998237873','Galo Jimenez'),(146,'A','2022-03-14',1,124,'','2093873733','Karis Loyza'),(147,'A','2022-03-14',1,125,'','1199220209','Jairo Sanchez');
/*!40000 ALTER TABLE `detalle_factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detallecliente`
--

DROP TABLE IF EXISTS `detallecliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detallecliente` (
  `idDetalleCliente` int(11) NOT NULL AUTO_INCREMENT,
  `Ruc` varchar(13) NOT NULL,
  `Estado` varchar(1) NOT NULL,
  `FechaRegistro` date NOT NULL,
  `NombreCliente` varchar(45) NOT NULL,
  `RazonSocial` varchar(45) NOT NULL,
  PRIMARY KEY (`idDetalleCliente`),
  UNIQUE KEY `idDetalleCliente_UNIQUE` (`idDetalleCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detallecliente`
--

LOCK TABLES `detallecliente` WRITE;
/*!40000 ALTER TABLE `detallecliente` DISABLE KEYS */;
INSERT INTO `detallecliente` VALUES (2,'176815647001','A','2021-01-18','Meta','Facebook'),(3,'346110643012','A','2021-01-18','Google','Youtube'),(4,'848372029383','A','2021-01-18','Google','Gmail'),(5,'234892382389','A','2021-01-18','Apple','Iphone'),(6,'029281738383','A','2021-01-18','Microsoft','Windows'),(7,'435663534513','A','2021-01-18','Google','Drive'),(8,'676753132113','A','2021-01-18','Microsoft','OneDrive'),(9,'006874653455','A','2021-01-18','SOFT','SistemaContable'),(10,'562234523525','A','2021-01-18','Meta','Instagram'),(11,'656543243256','A','2021-01-18','Meta','WhhatsApp');
/*!40000 ALTER TABLE `detallecliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `generar_boleto`
--

DROP TABLE IF EXISTS `generar_boleto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `generar_boleto` (
  `idboleto` int(11) NOT NULL AUTO_INCREMENT,
  `HoraSalida` time NOT NULL,
  `FechaSalida` date NOT NULL,
  `BusID` int(11) NOT NULL,
  `BoletoId` int(11) NOT NULL,
  PRIMARY KEY (`idboleto`),
  KEY `FK_bus_idx` (`BusID`),
  KEY `FK_boleto_idx` (`BoletoId`),
  CONSTRAINT `FK_boleto` FOREIGN KEY (`BoletoId`) REFERENCES `boleto` (`idBoleto`),
  CONSTRAINT `FK_bus` FOREIGN KEY (`BusID`) REFERENCES `bus_cooperativa` (`idBus`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `generar_boleto`
--

LOCK TABLES `generar_boleto` WRITE;
/*!40000 ALTER TABLE `generar_boleto` DISABLE KEYS */;
INSERT INTO `generar_boleto` VALUES (1,'13:00:00','2022-03-21',1,1),(2,'17:00:00','2022-03-21',1,1),(12,'16:00:00','2022-03-16',7,14),(13,'20:30:00','2022-03-20',7,15),(14,'20:00:00','2022-03-17',3,16),(15,'16:52:41','2022-03-17',3,17),(16,'16:00:00','2022-03-22',3,18);
/*!40000 ALTER TABLE `generar_boleto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `iniciosesion`
--

DROP TABLE IF EXISTS `iniciosesion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `iniciosesion` (
  `idInicioSesion` int(11) NOT NULL AUTO_INCREMENT,
  `Correo` varchar(45) NOT NULL,
  `Contrasena` varchar(45) NOT NULL,
  `Foreking_RolesUsuario` int(11) NOT NULL,
  PRIMARY KEY (`idInicioSesion`),
  KEY `Roles_idx` (`Foreking_RolesUsuario`),
  CONSTRAINT `Roles` FOREIGN KEY (`Foreking_RolesUsuario`) REFERENCES `rol_usuario` (`idRol_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iniciosesion`
--

LOCK TABLES `iniciosesion` WRITE;
/*!40000 ALTER TABLE `iniciosesion` DISABLE KEYS */;
INSERT INTO `iniciosesion` VALUES (1,'troncal@gmail.com','1234',3),(2,'pulman@gmail.com','pulman',3),(3,'loja@gmail.com','loja',3),(4,'Playas@gmail.com','Playita',3),(5,'Orense@gmail.com','123',3),(6,'jose@gmail.com','jose',4),(7,'kevin@gmail.com','kevin',1),(8,'alcivar@gmail.com','alcivar',1),(9,'karla@gmail.com','karla',1),(10,'juanAlvarez@live.com','1234',4),(11,'gerardo@gmail.com','gerardo',1),(12,'sandra@gmail.com','sandra',1),(13,'yanzaz@gmail.com','yanzaza',3),(14,'fernando@gmail.com','fernado',2),(15,'bayron@gmail.com','bayron',2),(16,'nelson@gmal.com','nelson',5),(20,'fausto@gmail.com','fausto',5),(21,'isabel@gmail.com','isabel',5),(22,'patricia@gmail.com','patricia',5),(23,'digna@gmail.com','gigna',2),(24,'stalin@gmail.com','stalin',2),(25,'henry@gmail.com','henry',2),(26,'maritza@gmail.com','maritza',5),(28,'edgar@gmail.com','edgar',4),(29,'mayra@gmail.com','mayra',4),(30,'alex@gmail.com','alex12',4),(31,'kevin@live.com','1234',4),(32,'moises@gmail.com','moises12',4);
/*!40000 ALTER TABLE `iniciosesion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `persona`
--

DROP TABLE IF EXISTS `persona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `persona` (
  `idPersona` int(11) NOT NULL AUTO_INCREMENT,
  `Cedula` varchar(10) NOT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Sexo` varchar(10) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  PRIMARY KEY (`idPersona`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (1,'0987363535','Jose Cantos','Masculino','0987635535'),(2,'1227272828','Kevin Arevalo','Masculino','0988736635'),(3,'3245151616','Alcivar Torres','Masculino','0987652242'),(4,'1402822726','Karla Velez','Femenino','0973363533'),(5,'0302527736','Juan Alvarez','Masculino','0918879652'),(6,'4322828826','Gerardo Marquez','Masculino','0983736363'),(7,'0787262522','Sandra Merchan','Femenino','0965254242'),(8,'0977335535','Fernado Suarez','Masculino','0966737377'),(9,'0973376334','Bayron Tigrero','Masculino','0955226622'),(10,'1163737383','Nelson Toro','Masculino','0976353535'),(14,'0871234567','Fausto Lopez','Masculino','0956627727'),(15,'0912364785','Isabel Valdiviezo','Femenino','0954562626'),(16,'1198009332','Patricia Crespo','Femenino','0912334775'),(17,'1190888777','Digna Leiva','Femenino','0972655354'),(18,'0987746333','Stalin Rivera','Masculino','0912266373'),(19,'0998476464','Henry Ramirez','Masculino','0997366363'),(20,'1102993837','Maritza Crespo','Femenino','0987365355'),(22,'1109837376','Edgar Marino','Masculino','0986544252'),(23,'1120098378','Mayra Santos','Femenino','0987363534'),(24,'1122663399','Alex Baquerizo','Masculino','0987373663'),(25,'9834732723','kevin','Masculino','0991887965'),(26,'0938377764','Moises Campos','Masculino','0987654342');
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporte`
--

DROP TABLE IF EXISTS `reporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reporte` (
  `idReporte` int(11) NOT NULL AUTO_INCREMENT,
  `Descripción` varchar(45) NOT NULL,
  `Tipo_Reporte` varchar(45) NOT NULL,
  `idUsuario` int(11) NOT NULL,
  `Estado` char(1) NOT NULL,
  PRIMARY KEY (`idReporte`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reporte`
--

LOCK TABLES `reporte` WRITE;
/*!40000 ALTER TABLE `reporte` DISABLE KEYS */;
/*!40000 ALTER TABLE `reporte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rol_usuario`
--

DROP TABLE IF EXISTS `rol_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rol_usuario` (
  `idRol_Usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(25) NOT NULL,
  `Estado` char(1) NOT NULL,
  PRIMARY KEY (`idRol_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol_usuario`
--

LOCK TABLES `rol_usuario` WRITE;
/*!40000 ALTER TABLE `rol_usuario` DISABLE KEYS */;
INSERT INTO `rol_usuario` VALUES (1,'Administrador','A'),(2,'Chofer','A'),(3,'Cooperativa','A'),(4,'Cliente','A'),(5,'Vendedor','A');
/*!40000 ALTER TABLE `rol_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ruta`
--

DROP TABLE IF EXISTS `ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ruta` (
  `idRuta` int(11) NOT NULL AUTO_INCREMENT,
  `Destino` int(11) NOT NULL,
  `Salida` int(11) NOT NULL,
  PRIMARY KEY (`idRuta`),
  KEY `CiudadDestino_idx` (`Destino`),
  KEY `CiudadOrigen_idx` (`Salida`),
  CONSTRAINT `CiudadDestino` FOREIGN KEY (`Destino`) REFERENCES `ciudad` (`idCiudad`),
  CONSTRAINT `CiudadOrigen` FOREIGN KEY (`Salida`) REFERENCES `ciudad` (`idCiudad`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
INSERT INTO `ruta` VALUES (1,3,1),(2,4,1),(3,5,1),(4,2,1),(5,6,1),(6,1,4);
/*!40000 ALTER TABLE `ruta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_empresa`
--

DROP TABLE IF EXISTS `tipo_empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipo_empresa` (
  `idTipo_Empresa` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion_tipoEmpresa` varchar(45) NOT NULL,
  `Fecha_Registro` date NOT NULL,
  `Estado` varchar(45) NOT NULL,
  PRIMARY KEY (`idTipo_Empresa`),
  UNIQUE KEY `idTipo_Empresa_UNIQUE` (`idTipo_Empresa`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_empresa`
--

LOCK TABLES `tipo_empresa` WRITE;
/*!40000 ALTER TABLE `tipo_empresa` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipo_empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendedor`
--

DROP TABLE IF EXISTS `vendedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vendedor` (
  `idVendedor` int(11) NOT NULL AUTO_INCREMENT,
  `Sueldo` double NOT NULL,
  `Estado` char(1) NOT NULL,
  `idPersona` int(11) DEFAULT NULL,
  `IdCredencial` int(11) DEFAULT NULL,
  PRIMARY KEY (`idVendedor`),
  KEY `idPersona_idx` (`idPersona`),
  KEY `idPersonavendedor_idx` (`idPersona`),
  KEY `idCredencial_idx` (`IdCredencial`),
  CONSTRAINT `idCredencial` FOREIGN KEY (`IdCredencial`) REFERENCES `iniciosesion` (`idInicioSesion`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `idPersonavendedor` FOREIGN KEY (`idPersona`) REFERENCES `persona` (`idPersona`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendedor`
--

LOCK TABLES `vendedor` WRITE;
/*!40000 ALTER TABLE `vendedor` DISABLE KEYS */;
INSERT INTO `vendedor` VALUES (1,62060,'A',10,16),(3,60080,'A',14,20),(4,60050,'A',15,21),(5,58890,'A',16,22),(6,60050,'A',20,26);
/*!40000 ALTER TABLE `vendedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventaboleto`
--

DROP TABLE IF EXISTS `ventaboleto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventaboleto` (
  `idBoleto` int(11) NOT NULL AUTO_INCREMENT,
  `Cedula` varchar(10) NOT NULL,
  `Nombre` varchar(25) DEFAULT NULL,
  `lugarSalida` varchar(45) NOT NULL,
  `lugarDestino` varchar(45) NOT NULL,
  `FechaSalida` date NOT NULL,
  `horaSalida` time NOT NULL,
  `fechaEmision` date NOT NULL,
  `nombreCoopertiva` varchar(25) NOT NULL,
  `numDisco` int(11) NOT NULL,
  `numAsiento` int(11) NOT NULL,
  `Precio` double NOT NULL,
  `Impuesto12` double NOT NULL,
  `idCooperativa` int(11) NOT NULL,
  `Estado` char(1) NOT NULL,
  PRIMARY KEY (`idBoleto`),
  UNIQUE KEY `Cedula_UNIQUE` (`Cedula`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventaboleto`
--

LOCK TABLES `ventaboleto` WRITE;
/*!40000 ALTER TABLE `ventaboleto` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventaboleto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'db_a83d0f_a7eb45'
--
/*!50003 DROP PROCEDURE IF EXISTS `BuscarAdministrador` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `BuscarAdministrador`(IdPersona int)
Select Cedula,CodAcceso, Nombre, Sexo, Telefono, CodAcceso, Sueldo, Correo, Contrasena  from persona p inner join administrador a on a.idPersona = p.idPersona inner join iniciosesion i on a.IdCredencial = i.idInicioSesion
where p.idPersona = IdPersona ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BuscarAsientos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `BuscarAsientos`(idBus int, BoletoID int)
select DescripcionBus from asientos_bus
where asientos_bus.Id_bus = idBus AND asientos_bus.Estado='A' AND IdBoleto_Generado = BoletoID ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BuscarCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `BuscarCliente`(cedulaCliente varchar(45))
Select *from cliente 
where cliente.Cedula = cedulaCliente ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BuscarCoop` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `BuscarCoop`(Dato varchar(30))
select idCooperativa id,Propietario Nombre,NombreCooperativa cooperativa from cooperativa where NombreCooperativa like (Dato,'%') ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BuscarReporte` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `BuscarReporte`(Dato varchar(1))
SELECT idDetalle_Factura Id_compra, FechaRegistro Fecha_Compra, FechaSalida Fecha_Salida,Cedula_Comprador,Cedula Cedula_cliente, NombreCooperativa cooperativa ,HoraSalida HoraSalida,Placa FROM detalle_factura 
left join cliente c on c.idcliente = ID_cliente
inner join generar_boleto g on g.idboleto = ID_boleto 
inner join bus_cooperativa on BusID = idBus 
inner join boleto b on BoletoId = b.idboleto 
left join persona per on per.idPersona = c.idPersona 
inner join cooperativa coop on coop.idcooperativa = Cooperativa_id ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BuscarReporteCedula` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `BuscarReporteCedula`(Dato varchar(10))
SELECT idDetalle_Factura Id_compra, FechaRegistro Fecha_Compra, FechaSalida Fecha_Salida,Cedula_Comprador,Cedula Cedula_cliente, NombreCooperativa cooperativa ,HoraSalida HoraSalida,Placa FROM detalle_factura 
left join cliente c on c.idcliente = ID_cliente
inner join generar_boleto g on g.idboleto = ID_boleto 
inner join bus_cooperativa on BusID = idBus 
inner join boleto b on BoletoId = b.idboleto 
left join persona per on per.idPersona = c.idPersona 
inner join cooperativa coop on coop.idcooperativa = Cooperativa_id
where Cedula_Comprador like concat(Dato,'%') ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BuscarReporteCooperativa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `BuscarReporteCooperativa`(Dato varchar(100))
SELECT idDetalle_Factura Id_compra, FechaRegistro Fecha_Compra, FechaSalida Fecha_Salida,Cedula_Comprador,Cedula Cedula_cliente, NombreCooperativa cooperativa ,HoraSalida HoraSalida,Placa FROM detalle_factura 
left join cliente c on c.idcliente = ID_cliente
inner join generar_boleto g on g.idboleto = ID_boleto 
inner join bus_cooperativa on BusID = idBus 
inner join boleto b on BoletoId = b.idboleto 
left join persona per on per.idPersona = c.idPersona 
inner join cooperativa coop on coop.idcooperativa = Cooperativa_id
where NombreCooperativa like concat(Dato,'%') ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `BuscarReporteFecha` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `BuscarReporteFecha`(Dato date)
SELECT idDetalle_Factura Id_compra, FechaRegistro Fecha_Compra, FechaSalida Fecha_Salida,Cedula_Comprador,Cedula Cedula_cliente, NombreCooperativa cooperativa ,HoraSalida HoraSalida,Placa FROM detalle_factura 
left join cliente c on c.idcliente = ID_cliente
inner join generar_boleto g on g.idboleto = ID_boleto 
inner join bus_cooperativa on BusID = idBus 
inner join boleto b on BoletoId = b.idboleto 
left join persona per on per.idPersona = c.idPersona 
inner join cooperativa coop on coop.idcooperativa = Cooperativa_id
where Dato<FechaSalida ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ClienteIniciosesion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ClienteIniciosesion`(CorreoFx varchar(50), passwordFx varchar(50))
select Cedula, Nombre, Sexo, Telefono, Correo,Contrasena, Foreking_RolesUsuario from cliente inner join persona on cliente.idPersona = persona.idPersona inner join iniciosesion on iniciosesion.idInicioSesion = cliente.IdCredencial
where iniciosesion.Correo = CorreoFx and iniciosesion.Contrasena = passwordFx ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ConsultarChofer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ConsultarChofer`(DatoFx varchar(45))
Select  * from chofer c inner join persona p on c.idpersona=p.idpersona inner join iniciosesion i on i.idInicioSesion=IdCredencial
Where cedula like Concat(DatoFx,'%') || Nombre like Concat(DatoFx,'%') ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ConsultarCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ConsultarCliente`(DatoFx varchar(45))
Select  * from cliente c inner join persona p on c.idpersona=p.idpersona inner join iniciosesion i on i.idInicioSesion=IdCredencial
Where cedula like Concat(DatoFx,'%') || Nombre like Concat(DatoFx,'%') ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ConsultarVendedor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ConsultarVendedor`(DatoFx varchar(45))
Select  * from vendedor c inner join persona p on c.idpersona=p.idpersona inner join iniciosesion i on i.idInicioSesion=IdCredencial
Where cedula like Concat(DatoFx,'%') || Nombre like Concat(DatoFx,'%') ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `EliminarChofer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `EliminarChofer`(CedulaFx varchar(45))
begin
set @idPerson = (Select  p.idPersona from chofer c inner join persona p on c.idpersona=p.idpersona inner join iniciosesion i on i.idInicioSesion=IdCredencial Where cedula = CedulaFx);
set @idSesion = (Select  idInicioSesion from chofer c inner join persona p on c.idpersona=p.idpersona inner join iniciosesion i on i.idInicioSesion=IdCredencial Where cedula = CedulaFx);
set @idChofer = (Select  idChofer from chofer c inner join persona p on c.idpersona=p.idpersona inner join iniciosesion i on i.idInicioSesion=IdCredencial Where cedula = CedulaFx);
delete from chofer where idChofer=@idChofer;
delete from persona where persona.idPersona = @idPerson;
delete from inicioSesion where idInicioSesion = @idSesion;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `EliminarCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `EliminarCliente`(CedulaFx varchar(45))
begin
set @idPerson = (Select  p.idPersona from cliente c inner join persona p on c.idpersona=p.idpersona inner join iniciosesion i on i.idInicioSesion=IdCredencial Where cedula = CedulaFx);
set @idSesion = (Select  idInicioSesion from cliente c inner join persona p on c.idpersona=p.idpersona inner join iniciosesion i on i.idInicioSesion=IdCredencial Where cedula = CedulaFx);
set @idclient = (Select  idCliente from cliente c inner join persona p on c.idpersona=p.idpersona inner join iniciosesion i on i.idInicioSesion=IdCredencial Where cedula = CedulaFx);
delete from cliente where idCliente=@idclient;
delete from persona where persona.idPersona = @idPerson;
delete from inicioSesion where idInicioSesion = @idSesion;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `EliminarVendedor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `EliminarVendedor`(CedulaFx varchar(45))
begin
set @idPerson = (Select  p.idPersona from vendedor c inner join persona p on c.idpersona=p.idpersona inner join iniciosesion i on i.idInicioSesion=IdCredencial Where cedula = CedulaFx);
set @idSesion = (Select  idInicioSesion from vendedor c inner join persona p on c.idpersona=p.idpersona inner join iniciosesion i on i.idInicioSesion=IdCredencial Where cedula = CedulaFx);
set @idVendedors = (Select  idVendedor from vendedor c inner join persona p on c.idpersona=p.idpersona inner join iniciosesion i on i.idInicioSesion=IdCredencial Where cedula = CedulaFx);
delete from vendedor where idVendedor=@idVendedors;
delete from persona where persona.idPersona = @idPerson;
delete from inicioSesion where idInicioSesion = @idSesion;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ImprimirBoleto` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ImprimirBoleto`(cantboleto int)
SELECT b.Precio,idDetalle_Factura Id_compra, FechaRegistro Fecha_Compra, FechaSalida Fecha_Salida,Cedula_Comprador,Nombre Nombre_cliente, NombreCooperativa cooperativa ,HoraSalida HoraSalida,Placa FROM detalle_factura 
left join cliente c on c.idcliente = ID_cliente
inner join generar_boleto g on g.idboleto = ID_boleto 
inner join bus_cooperativa on BusID = idBus 
inner join boleto b on BoletoId = b.idboleto 
left join persona per on per.idPersona = c.idPersona 
inner join cooperativa coop on coop.idcooperativa = Cooperativa_id
Order by idDetalle_Factura Desc
LIMIT cantboleto ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InactivarAsientos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `InactivarAsientos`(asiento varchar(30), Idboleto int )
UPDATE asientos_bus set Estado = 'I' where  asiento = DescripcionBus AND IdBoleto_Generado = Idboleto ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InactivarAsientoss` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `InactivarAsientoss`(asiento varchar(30), Idboleto int, ultimo bool )
BEGIN 
set session transaction isolation level read uncommitted;
start transaction;
update asientos_bus set estado = 'I' where DescripcionBus = asiento;
UPDATE asientos_bus set Estado = 'I' where asiento = DescripcionBus AND IdBoleto_Generado = Idboleto and Estado = 'A';
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `IngresarAsientos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `IngresarAsientos`(placas varchar(30))
begin
set @iBoleto = LAST_INSERT_ID();
set @idBus = (Select idBus from bus_cooperativa where Placa=placas);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A1', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A2', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A3', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A4', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A5', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A6', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A7', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A8', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A9', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A10', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A11', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A12', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A13', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A14', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('A15', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B1', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B2', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B3', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B4', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B5', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B6', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B7', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B8', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B9', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B10', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B11', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B12', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B13', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B14', 'A', @idBus, @iBoleto);
INSERT INTO `db_a83d0f_a7eb45`.`asientos_bus` (`DescripcionBus`, `Estado`, `Id_bus`, `IdBoleto_Generado`) VALUES ('B15', 'A', @idBus, @iBoleto);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InicioSeccionEjemplo` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `InicioSeccionEjemplo`()
SELECT *FROM iniciosesion ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `InsertarRuta` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `InsertarRuta`(idRuta int,placas varchar(20), fecha date, hora time, Precios double)
begin 
insert into boleto(Cantidad,Precio) values (40,Precios);
set @boleto = LAST_INSERT_ID();
set @bus = (Select idBus from bus_cooperativa where Placa=placas);
insert into generar_boleto(HoraSalida,FechaSalida,BusID,BoletoId) values (hora,fecha,@bus,@boleto);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Insetar` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `Insetar`(usuarioFx varchar(45), contrasenaFx varchar(9), rolUsuario int)
INSERT INTO iniciosesion(Usuario,Contrasena,Foreking_RolesUsuario) VALUE (usuarioFx,contrasenaFx,rolUsuario) ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Insetarb` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `Insetarb`(usuarioFx varchar(45), contrasenaFx varchar(45), rolUsuario int)
INSERT INTO iniciosesion(Usuario,Contrasena,Foreking_RolesUsuario) VALUE (usuarioFx,contrasenaFx,rolUsuario) ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `LlenarVentanaCompra` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `LlenarVentanaCompra`(cooperativaFX varchar(45), horaSalidaFX varchar(45), fechaSalidaFX varchar(45))
Select bus.Idbus, generar.HoraSalida, generar.FechaSalida,b.Precio,c.nombreCooperativa,A1.DescripcionCiudad destino,A2.DescripcionCiudad salida,bus.Disco FROM  generar_boleto generar 
INNER JOIN bus_cooperativa bus ON generar.BusID = bus.idBus
INNER JOIN boleto b  ON generar.BoletoId = b.idBoleto
INNER JOIN  cooperativa c ON  bus.Cooperativa_id = c.idCooperativa
INNER JOIN ruta r ON bus.Ruta_id = r.idRuta
INNER JOIN ciudad A1 ON A1.idCiudad = r.Destino
INNER JOIN ciudad A2 ON A2.idCiudad = r.Salida
Where c.nombreCooperativa= cooperativaFX  AND generar.HoraSalida= horaSalidaFX AND generar.FechaSalida= fechaSalidaFX ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ModificarCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ModificarCliente`(Telefono1 varchar(10), Correo1 varchar(45), Contraseña1 varchar(9), Cedula1 varchar(10))
begin
update cliente set Telefono = Telefono1, 
    Correo = Correo1, 
    Contraseña = Contraseña1 where Cedula = Cedula1 ;
    End ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Procedimiento_insertar_cliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `Procedimiento_insertar_cliente`(Cedula varchar(10), Nombre varchar(25), Sexo varchar(15), 
Telefono varchar (10), Correo varchar(45),Contraseña varchar(9))
begin 
insert into cliente(Cedula,  Nombre, Sexo, Telefono, Correo,Contraseña)values(Cedula, Nombre, Sexo,
Telefono, Correo,Contraseña);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ProcesoBuscarCooperativa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ProcesoBuscarCooperativa`(SalidaFx varchar(45), SestinoFX varchar(45))
SELECT nombreCooperativa FROM bus_cooperativa a 
INNER JOIN cooperativa c ON a.Cooperativa_id = c.idCooperativa 
INNER JOIN ruta b ON a.Ruta_id = b.idRuta
INNER JOIN ciudad A1 ON A1.idCiudad = b.Destino
INNER JOIN ciudad A2 ON A2.idCiudad = b.Salida
Where A2.DescripcionCiudad = SalidaFx  AND A1.DescripcionCiudad= SestinoFX
order by nombreCooperativa Asc ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ProcesoBusquedaCiudad` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ProcesoBusquedaCiudad`()
Select  DescripcionCiudad from ciudad ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ProcesoInicioSeccion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ProcesoInicioSeccion`(CorreoFx varchar(45), contrasenaFx varchar(45))
Select   Foreking_RolesUsuario from iniciosesion
Where Correo=CorreoFx and Contrasena=ContrasenaFX ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ProcesoLlenarDataGrid` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ProcesoLlenarDataGrid`(SalidaFx varchar(45), DestinoFX varchar(45), CooperativaFX varchar(45))
Select generar.HoraSalida, generar.FechaSalida,b.Precio,c.nombreCooperativa,A1.DescripcionCiudad,A2.DescripcionCiudad FROM  generar_boleto generar 
INNER JOIN bus_cooperativa bus ON generar.BusID = bus.idBus
INNER JOIN boleto b  ON generar.BoletoId = b.idBoleto
INNER JOIN  cooperativa c ON  bus.Cooperativa_id = c.idCooperativa
INNER JOIN ruta r ON bus.Ruta_id = r.idRuta
INNER JOIN ciudad A1 ON A1.idCiudad = r.Destino
INNER JOIN ciudad A2 ON A2.idCiudad = r.Salida
Where A2.DescripcionCiudad = SalidaFx  AND A1.DescripcionCiudad= DestinoFX AND c.nombreCooperativa=CooperativaFX ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ProcesoLlenarDataGridB2` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ProcesoLlenarDataGridB2`(SalidaFx varchar(45), DestinoFX varchar(45), CooperativaFX varchar(45))
Select generar.HoraSalida, generar.FechaSalida,b.Precio,c.nombreCooperativa,A1.DescripcionCiudad,A2.DescripcionCiudad FROM  generar_boleto generar 
INNER JOIN bus_cooperativa bus ON generar.BusID = bus.idBus
INNER JOIN boleto b  ON generar.BoletoId = b.idBoleto
INNER JOIN  cooperativa c ON  bus.Cooperativa_id = c.idCooperativa
INNER JOIN ruta r ON bus.Ruta_id = r.idRuta
INNER JOIN ciudad A1 ON A1.idCiudad = r.Destino
INNER JOIN ciudad A2 ON A2.idCiudad = r.Salida
Where c.nombreCooperativa= SalidaFx  AND generar.HoraSalida= DestinoFX AND generar.FechaSalida=CooperativaFX ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistroClienteGeneral` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `RegistroClienteGeneral`(CedulaFx varchar(10), NombreFx varchar(25), SexoFx varchar(15), TelefonoFx varchar (10),CorreoFx varchar (30), ContrasenaFx varchar (10),Foreking_RolesUsuarioFx int)
begin
Call Registrodepersona(CedulaFx,NombreFx,SexoFx,TelefonoFx);
set @persona = LAST_INSERT_ID();
Call Registrocredenciales(CorreoFx,ContrasenaFx,Foreking_RolesUsuarioFx);
set @credencial = LAST_INSERT_ID();
insert into cliente (Estado,idPersona,IdCredencial) values ('A',@persona,@credencial);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Registrocredenciales` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `Registrocredenciales`(CorreoFx varchar (30), ContrasenaFx varchar (10),Foreking_RolesUsuarioFx int)
begin
INSERT INTO iniciosesion (`Correo`, `Contrasena`, `Foreking_RolesUsuario`) VALUES (CorreoFx, ContrasenaFx, Foreking_RolesUsuarioFx);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Registrodepersona` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `Registrodepersona`(CedulaFx varchar(10), NombreFx varchar(25), SexoFx varchar(15), 
TelefonoFx varchar (10))
begin
insert into persona(Cedula,  Nombre, Sexo, Telefono) values (CedulaFx, NombreFx, SexoFx, TelefonoFx);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_Buscarbus` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_Buscarbus`(idCooperativa int,idRuta int)
select Placa,b.idBus from bus_cooperativa b inner join cooperativa c on c.idCooperativa = b.Cooperativa_id where c.idCooperativa= idCooperativa and idRuta = b.Ruta_id ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_BuscarChofer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_BuscarChofer`(Cedula varchar(15))
begin
   Select p.Cedula, p.Nombre, p.Sexo, p.Telefono, i.Correo, i.Contrasena, ch.Licencia, ch.Sueldo from persona p
   inner join chofer ch on ch.idPersona = p.idPersona 
   inner join iniciosesion i on ch.IdCredencial = i.idInicioSesion
   where p.Cedula = Cedula;
   end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_BuscarCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_BuscarCliente`(Cedula varchar(15))
begin
   Select p.Cedula, p.Nombre, p.Sexo, p.Telefono, i.Correo, i.Contrasena  from persona p inner join cliente c on c.idPersona = p.idPersona inner join iniciosesion i on c.IdCredencial = i.idInicioSesion
   where p.Cedula = Cedula;
   end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_BuscarCooperativa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_BuscarCooperativa`(idCooperativa varchar(15))
begin
   Select co.Ruc, co.Propietario, co.NombreCooperativa, co.Telefono, i.Correo, i.Contrasena from cooperativa co
   inner join iniciosesion i on co.IdCredencial = i.idInicioSesion
   where co.idCooperativa = idCooperativa;
   end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_BuscarRutA` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_BuscarRutA`(idCooperativa int)
select idRuta,c1.DescripcionCiudad Destino,c2.DescripcionCiudad Salida from ruta r inner join Ciudad c1 on r.Destino = c1.idciudad inner join Ciudad c2 on r.Salida = c2.idciudad ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_BuscarVendedor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_BuscarVendedor`(Cedula varchar(15))
begin
   Select p.Cedula, p.Nombre, p.Sexo, p.Telefono, i.Correo, i.Contrasena, v.Sueldo from persona p
   inner join vendedor v on v.idPersona = p.idPersona 
   inner join iniciosesion i on v.IdCredencial = i.idInicioSesion
   where p.Cedula = Cedula;
   end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_insertarAdministrador` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_insertarAdministrador`(CedulaFx varchar(10), NombreFx varchar(25), SexoFx varchar(15), TelefonoFx varchar (10), CodAccesoFx varchar(10), SueldoFx double, CorreoFx varchar (30), ContrasenaFx varchar (10),Foreking_RolesUsuarioFx int)
begin
Call Registrodepersona(CedulaFx,NombreFx,SexoFx,TelefonoFx);
set @persona = LAST_INSERT_ID();
Call Registrocredenciales(CorreoFx,ContrasenaFx,Foreking_RolesUsuarioFx);
set @credencial = LAST_INSERT_ID();
insert into administrador (CodAcceso, Sueldo, Estado,idPersona,IdCredencial) values (CodAccesoFx, SueldoFx, 'A',@persona,@credencial);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_insertarChofer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_insertarChofer`(CedulaFx varchar(10), NombreFx varchar(25), SexoFx varchar(15), TelefonoFx varchar (10), Licencia varchar(10), SueldoFx double, CorreoFx varchar (30), ContrasenaFx varchar (10),Foreking_RolesUsuarioFx int)
begin
Call Registrodepersona(CedulaFx,NombreFx,SexoFx,TelefonoFx);
set @persona = LAST_INSERT_ID();
Call Registrocredenciales(CorreoFx,ContrasenaFx,Foreking_RolesUsuarioFx);
set @credencial = LAST_INSERT_ID();
insert into chofer (Licencia, Sueldo, Estado,idPersona,IdCredencial) values (Licencia, SueldoFx, 'A',@persona,@credencial);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_insertarCooperativa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_insertarCooperativa`(Ruc varchar(10), Propietario varchar(45), NombreCooperativa varchar(45), Telefono varchar (10), Correo varchar (30), Contrasena varchar (10),Foreking_RolesUsuario int)
begin
insert into iniciosesion(Correo, Contrasena,Foreking_RolesUsuario)values(Correo, Contrasena, Foreking_RolesUsuario);
set @idcredencial = LAST_INSERT_ID();
insert into Cooperativa (Ruc, Propietario, NombreCooperativa, Telefono, Estado, IdCredencial)values (Ruc, Propietario, NombreCooperativa, Telefono, 'A', @idcredencial);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_insertarVendedor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_insertarVendedor`(CedulaFx varchar(10), NombreFx varchar(25), SexoFx varchar(15), TelefonoFx varchar (10), SueldoFx double, CorreoFx varchar (30), ContrasenaFx varchar (10),Foreking_RolesUsuarioFx int)
begin
Call Registrodepersona(CedulaFx,NombreFx,SexoFx,TelefonoFx);
set @persona = LAST_INSERT_ID();
Call Registrocredenciales(CorreoFx,ContrasenaFx,Foreking_RolesUsuarioFx);
set @credencial = LAST_INSERT_ID();
insert into vendedor (Sueldo, Estado,idPersona,IdCredencial) values (SueldoFx, 'A',@persona,@credencial);
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_insertar_cliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_insertar_cliente`(Cedula varchar(10), Nombre varchar(25), Sexo varchar(15), 
Telefono varchar (10), Correo varchar(45), Ciudad varchar(45), Usuario varchar(20), Contraseña varchar(9))
insert into cliente(Cedula,  Nombre, Sexo, Telefono, Correo, Ciudad, Usuario, Contraseña)values(Cedula, Nombre, Sexo,
Telefono, Correo, Ciudad, Usuario, Contraseña) ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_LlenarVentanaCompra` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_LlenarVentanaCompra`(cooperativaFX varchar(45), horaSalidaFX varchar(45), fechaSalidaFX varchar(45))
Select generar.idboleto Id_generearBoleto,idBus,generar.HoraSalida, generar.FechaSalida,b.Precio,c.nombreCooperativa,A1.DescripcionCiudad destino,A2.DescripcionCiudad salida,bus.Disco, bus.CantidadAsiento FROM  generar_boleto generar 
INNER JOIN bus_cooperativa bus ON generar.BusID = bus.idBus
INNER JOIN boleto b  ON generar.BoletoId = b.idBoleto
INNER JOIN  cooperativa c ON  bus.Cooperativa_id = c.idCooperativa
INNER JOIN ruta r ON bus.Ruta_id = r.idRuta
INNER JOIN ciudad A1 ON A1.idCiudad = r.Destino
INNER JOIN ciudad A2 ON A2.idCiudad = r.Salida
Where c.nombreCooperativa= cooperativaFX  AND generar.HoraSalida= horaSalidaFX AND generar.FechaSalida= fechaSalidaFX ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_ModificarAdministrador` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_ModificarAdministrador`(Telefono1 varchar(10), Correo1 varchar(45), Contraseña1 varchar(9), Cedula1 varchar(10))
begin
  update persona p set p.Telefono = Telefono1 where p.idPersona = idPersona and p.Cedula = Cedula1;
  update administrador a inner join  persona p on a.idPersona = p.idPersona inner join inicioSesion i on a.IdCredencial = i.idInicioSesion
  set i.Correo = Correo1, i.Contrasena = Contraseña1 where i.idInicioSesion = a.IdCredencial and p.idPersona = a.idPersona and p.Cedula = Cedula1;
  End ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_ModificarChofer` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_ModificarChofer`(Telefono1 varchar(10), Correo1 varchar(45), Contraseña1 varchar(9), Cedula1 varchar(10))
begin
  update persona p set p.Telefono = Telefono1 where p.idPersona = idPersona and p.Cedula = Cedula1;
  update chofer ch inner join  persona p on ch.idPersona = p.idPersona inner join inicioSesion i on ch.IdCredencial = i.idInicioSesion
  set i.Correo = Correo1, i.Contrasena = Contraseña1 where i.idInicioSesion = ch.IdCredencial and p.idPersona = ch.idPersona and p.Cedula = Cedula1;
  End ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_ModificarCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_ModificarCliente`(Telefono1 varchar(10), Correo1 varchar(45), Contraseña1 varchar(9), Cedula1 varchar(10))
begin
 update persona p set p.Telefono = Telefono1 where p.idPersona = idPersona and p.Cedula = Cedula1;
  update cliente c inner join  persona p on c.idPersona = p.idPersona inner join inicioSesion i on c.IdCredencial = i.idInicioSesion
  set i.Correo = Correo1, i.Contrasena = Contraseña1 where i.idInicioSesion = c.IdCredencial and p.idPersona = c.idPersona and p.Cedula = Cedula1;
  End ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_ModificarCooperativa` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_ModificarCooperativa`(Telefono varchar(10), Correo varchar(45), Contraseña varchar(9), Ruc varchar(10))
begin
 -- update persona p set p.Telefono = Telefono1 where p.idPersona = idPersona and p.Cedula = Cedula1;
  update cooperativa co inner join inicioSesion i on co.IdCredencial = i.idInicioSesion
  set co.Telefono = Telefono, i.Correo = Correo, i.Contrasena = Contraseña where i.idInicioSesion = co.IdCredencial and co.Ruc = Ruc;
  End ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_ModificarVendedor` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_ModificarVendedor`(Telefono1 varchar(10), Correo1 varchar(45), Contraseña1 varchar(9), Cedula1 varchar(10))
begin
  update persona p set p.Telefono = Telefono1 where p.idPersona = idPersona and p.Cedula = Cedula1;
  update vendedor v inner join  persona p on v.idPersona = p.idPersona inner join inicioSesion i on v.IdCredencial = i.idInicioSesion
  set i.Correo = Correo1, i.Contrasena = Contraseña1 where i.idInicioSesion = v.IdCredencial and p.idPersona = v.idPersona and p.Cedula = Cedula1;
  End ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_pago` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_pago`(id_bus int,cedula_cliente varchar(10),FechaActual date,cedula_Comprador varchar(10),Nombre_comprador varchar(100))
begin 
set @numeroFact =(select Numero_Factura from detalle_factura order by Numero_Factura desc limit 1);
if(cedula_cliente='') THEN 
INSERT INTO detalle_factura(Estado,FechaRegistro,ID_boleto,Numero_Factura,ID_cliente,Cedula_Comprador,Nombre_comprador) VALUES ('A',FechaActual,id_bus,@numeroFact +1,"",cedula_Comprador,Nombre_comprador);
else
set @id_cliente = (Select c.Idcliente from cliente c inner join persona p on c.Idpersona = p.idPersona where p.cedula = cedula_cliente);
INSERT INTO detalle_factura(Estado,FechaRegistro,ID_boleto,Numero_Factura,ID_cliente,Cedula_Comprador,Nombre_comprador) VALUES ('A',FechaActual,id_bus,@numeroFact +1,@id_cliente,cedula_Comprador,Nombre_comprador);
end if;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `spl_VerificarAsiento` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_VerificarAsiento`(asiento varchar(30))
BEGIN 
set session transaction isolation level read uncommitted;
start transaction;
UPDATE asientos_bus set Estado = 'I' where asiento = DescripcionBus;
commit;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `sspl_ProcesoInicioSeccion` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `sspl_ProcesoInicioSeccion`(CorreoFx varchar(45), contrasenaFx varchar(45))
begin
Select   i.Foreking_RolesUsuario, p.Cedula, p.idPersona  from iniciosesion i
inner join administrador a on i.idInicioSesion = a.IdCredencial
inner join persona p on  a.idPersona = p.idPersona
Where Correo=CorreoFx and Contrasena=contrasenaFx 
union 
Select   i.Foreking_RolesUsuario, p.Cedula, p.idPersona  from iniciosesion i
inner join cliente c on i.idInicioSesion = c.IdCredencial
inner join persona p on  c.idPersona = p.idPersona
Where Correo= CorreoFx and Contrasena=contrasenaFx
union 
Select   i.Foreking_RolesUsuario, p.Cedula,p.idPersona  from iniciosesion i
inner join chofer ch on i.idInicioSesion = ch.IdCredencial
inner join persona p on  ch.idPersona = p.idPersona
Where Correo= CorreoFx and Contrasena=contrasenaFx
union
Select   i.Foreking_RolesUsuario, p.Cedula, p.idPersona  from iniciosesion i
inner join vendedor v on i.idInicioSesion = v.IdCredencial
inner join persona p on  v.idPersona = p.idPersona
Where Correo= CorreoFx and Contrasena=contrasenaFx
union 
Select   i.Foreking_RolesUsuario, co.Ruc, co.idCooperativa  from iniciosesion i
inner join cooperativa co on i.idInicioSesion = co.IdCredencial
Where Correo= CorreoFx and Contrasena=contrasenaFx
;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-03-16 23:30:26
