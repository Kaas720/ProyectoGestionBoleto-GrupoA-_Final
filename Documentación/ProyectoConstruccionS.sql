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
  `idPersona` int(11) DEFAULT NULL,
  `IdCredencial` int(11) DEFAULT NULL,
  PRIMARY KEY (`idAdmnistrador`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrador`
--

LOCK TABLES `administrador` WRITE;
/*!40000 ALTER TABLE `administrador` DISABLE KEYS */;
INSERT INTO `administrador` VALUES (1,'3722698765',780.5,'A',1,1),(2,'9383875676',689.98,'A',2,2);
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
  PRIMARY KEY (`idAsientos_bus`),
  UNIQUE KEY `idAsientos_bus_UNIQUE` (`idAsientos_bus`),
  KEY `DkBus_idx` (`Id_bus`),
  CONSTRAINT `DkBus` FOREIGN KEY (`Id_bus`) REFERENCES `bus_cooperativa` (`idBus`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `asientos_bus`
--

LOCK TABLES `asientos_bus` WRITE;
/*!40000 ALTER TABLE `asientos_bus` DISABLE KEYS */;
INSERT INTO `asientos_bus` VALUES (1,'A1','A',1),(2,'A2','A',1),(3,'A3','A',1),(4,'A4','A',1),(5,'A5','A',1),(6,'A6','A',1),(7,'A7','A',1),(8,'A8','A',1),(9,'A9','A',1),(10,'A10','A',1),(11,'A11','A',1),(12,'A12','A',1),(13,'A13','A',1),(14,'A14','A',1),(15,'A15','A',1),(16,'B1','A',1),(17,'B2','A',1),(18,'B3','A',1),(19,'B4','A',1),(20,'B5','A',1),(21,'B6','A',1),(22,'B7','A',1),(23,'B8','A',1),(24,'B9','A',1),(25,'B10','A',1),(26,'B11','A',1),(27,'B12','A',1),(28,'B13','A',1),(29,'B14','A',1),(30,'B15','A',1);
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
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `boleto`
--

LOCK TABLES `boleto` WRITE;
/*!40000 ALTER TABLE `boleto` DISABLE KEYS */;
INSERT INTO `boleto` VALUES (1,40,1);
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bus_cooperativa`
--

LOCK TABLES `bus_cooperativa` WRITE;
/*!40000 ALTER TABLE `bus_cooperativa` DISABLE KEYS */;
INSERT INTO `bus_cooperativa` VALUES (1,'ABC-1234','001','2','Mercedes Benz',30,1,1),(2,'ABC-7520','005','2','Mercedes Benz',40,2,2),(3,'ABC-1280','004','1','Mercedes Benz',40,3,3),(4,'GTU-1680','007','1','Mercedes Benz',38,4,4);
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
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chofer`
--

LOCK TABLES `chofer` WRITE;
/*!40000 ALTER TABLE `chofer` DISABLE KEYS */;
INSERT INTO `chofer` VALUES (1,'1525662373',56080,'A',66,43);
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
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (14,'A',3,5),(16,'A',8,8),(18,'A',10,11),(19,'A',2,3),(20,'A',2,3),(21,'A',2,3),(22,'A',41,17),(23,'A',42,18),(24,'A',43,19),(25,'A',44,20),(26,'A',45,21),(27,'A',46,22),(28,'A',47,23),(29,'A',48,24),(30,'A',49,25),(31,'A',50,26),(32,'A',54,30),(33,'A',55,31),(34,'A',56,32),(35,'A',57,33),(36,'A',58,34),(37,'A',59,35),(38,'A',60,36),(39,'A',61,37),(40,'A',62,38),(41,'A',63,39),(42,'A',67,44),(43,'A',68,45),(44,'A',69,46),(45,'A',70,47),(46,'A',71,48);
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
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cooperativa`
--

LOCK TABLES `cooperativa` WRITE;
/*!40000 ALTER TABLE `cooperativa` DISABLE KEYS */;
INSERT INTO `cooperativa` VALUES (0,'','','','','',0),(2,'0938873744','Andres Mendez','Loja','0974783646','A',41);
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
  `NumeroFactura` int(11) NOT NULL,
  PRIMARY KEY (`idDetalle_Factura`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_factura`
--

LOCK TABLES `detalle_factura` WRITE;
/*!40000 ALTER TABLE `detalle_factura` DISABLE KEYS */;
INSERT INTO `detalle_factura` VALUES (1,'A','2022-01-17',1),(2,'A','2022-01-17',2),(3,'A','2022-01-17',3),(4,'A','2022-01-17',4),(5,'A','2022-01-17',5),(6,'A','2022-01-17',6),(7,'A','2022-01-17',7),(8,'A','2022-01-17',8),(9,'A','2022-01-17',9),(10,'A','2022-01-17',10);
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
  `FechaSalida` datetime NOT NULL,
  `BusID` int(11) NOT NULL,
  `BoletoId` int(11) NOT NULL,
  PRIMARY KEY (`idboleto`),
  KEY `FK_bus_idx` (`BusID`),
  KEY `FK_boleto_idx` (`BoletoId`),
  CONSTRAINT `FK_boleto` FOREIGN KEY (`BoletoId`) REFERENCES `boleto` (`idBoleto`),
  CONSTRAINT `FK_bus` FOREIGN KEY (`BusID`) REFERENCES `bus_cooperativa` (`idBus`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `generar_boleto`
--

LOCK TABLES `generar_boleto` WRITE;
/*!40000 ALTER TABLE `generar_boleto` DISABLE KEYS */;
INSERT INTO `generar_boleto` VALUES (1,'13:00:00','2022-01-20 00:00:00',1,1),(2,'17:00:00','2022-01-20 00:00:00',1,1);
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
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iniciosesion`
--

LOCK TABLES `iniciosesion` WRITE;
/*!40000 ALTER TABLE `iniciosesion` DISABLE KEYS */;
INSERT INTO `iniciosesion` VALUES (1,'kevin@gmail.com','kevin12',1),(2,'rosal@gmail.com','rosa12',1),(3,'angela@gmail.com','angela1',2),(4,'angela@gmail.com','angela1',3),(5,'ChavareaCSE90@hotmail.com','Emelec90',4),(7,'Segio@hotmail.com','malmelec',2),(8,'angela@gmail.com','angela1',3),(9,'angel@gmail.com','angel',2),(11,'angela@gmail.com','angela1',2),(12,'angela@gmail.com','angela1',1),(13,'angela@gmail.com','angela1',4),(14,'angela@gmail.com','angela1',4),(15,'angela@gmail.com','angela1',4),(16,'angela@gmail.com','angela1',4),(17,'angela@gmail.com','angela1',4),(18,'angela@gmail.com','angela1',4),(19,'angela@gmail.com','angela1',4),(20,'angela@gmail.com','angela1',4),(21,'angela@gmail.com','angela1',4),(22,'angela@gmail.com','angela1',4),(23,'angela@gmail.com','angela1',4),(24,'angela@gmail.com','angela1',4),(25,'angela@gmail.com','angela1',4),(26,'angela@gmail.com','angela1',4),(27,'angela@gmail.com','angela1',3),(28,'angela@gmail.com','angela1',3),(29,'angela@gmail.com','angela1',3),(30,'angela@gmail.com','angela1',4),(31,'angela@gmail.com','angela1',4),(32,'angela@gmail.com','angela1',4),(33,'angela@gmail.com','angela1',4),(34,'angela@gmail.com','angela1',4),(35,'joseal@gmail.com','joseal',4),(36,'vero@gmail.com','veronica1',4),(37,'carlosc@gmail.com','carlosc',4),(38,'jorge@gmail.com','jorge12',4),(39,'jorgel@gmail.com','lorgel',4),(40,'klever@gmail.com','klever',2),(41,'loja@gmail.com','loja1',3),(42,'hectorc@gmail.com','hector1',5),(43,'marlom@gmail.com','marlon',2),(44,'brayan@gmail.com','brayan',4),(45,'luis@live.com','12341234',4),(46,'pae@live.com','1234',4),(47,'4444@jole.com','12312',4),(48,'lop@live.com','123111111',4);
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
) ENGINE=InnoDB AUTO_INCREMENT=72 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persona`
--

LOCK TABLES `persona` WRITE;
/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` VALUES (1,'0302527742','Kevin Arévalo S','Masculino','0987655598'),(2,'0301420998','Rosa Saldaña L','Femenino','0987655999'),(3,'0398675543','David Arevalo s','Masculino','0987655598'),(4,'0948475776','Mirella Armijos','Femenino','0987655598'),(8,'','','','0987655598'),(9,'','','','0987655598'),(10,'213','cddc','masculino','0987655598'),(11,'1234567890','Jorge Velez','Masculino','0987655598'),(12,'0302526654','Mijo','Masculino','0987655598'),(13,'1111111111','qqq','Femenino','0987655598'),(14,'2222222222','wwwwwwwwwwwwwww','Masculino','0987655598'),(15,'3121631313','onijknij','Masculino','0987655598'),(16,'2133333333','weqqqq','Masculino','0987655598'),(17,'5444444444','uijuijuijuijo','Masculino','0987655598'),(18,'3222222222','reeeeee','Masculino','0987655598'),(19,'3222222222','rtttttttttt','Masculino','0987655598'),(20,'3454535555','rteeeeeeeeeeeeee','Femenino','0987655598'),(21,'l','k','m','0987655598'),(22,'l','k','m','0987655598'),(23,'9898989898','hjjnhnjnjnjkjkkkm','Masculino','0987655598'),(24,'1233333333','qweeeeeeeeeee','Masculino','0987655598'),(25,'3342342342','rterrrttr','Femenino','0987655598'),(26,'9800000000','uuuuuyyyyyy','Masculino','0987655598'),(27,'d','d','d','0987655598'),(28,'d','d','d','0987655598'),(29,'3343434343','rrtertrte','Masculino','0987655598'),(30,'3434234234','rrerrrrrrrrr','Masculino','0987655598'),(31,'8888888888','ujyyyyy','Masculino','0987655598'),(32,'6544444444','ytrrrrr','Femenino','0987655598'),(33,'5555555555','tttttttttttttttttttttt','Masculino','0987655598'),(34,'4343443434','rr','Masculino','0987655598'),(35,'4444444444','rrrrrrrrrrrrrrr','Femenino','0987655598'),(36,'0000000000','ooooooooooooo','Masculino','0987655598'),(37,'6666666666','yyyyyyyy','Masculino','0987655598'),(38,'6555577453','yuttttt','Masculino','0987655598'),(39,'3232323232','pppppppppppppppppp','Masculino','0987655598'),(40,'0000000000','oooooooooooooooooooooo','Masculino','0987655598'),(41,'7777777777','yyyyyyyyyyyy','Masculino','0987655598'),(42,'1209373455','gsh kdks','Masculino','0987655598'),(43,'p','p','p','0987655598'),(44,'p','p','p','0987655598'),(45,'4444444444','eeeeeeeeeeeeeeeeeeeeee','Masculino','0987655598'),(46,'1829298378','Hector Ortiz','Masculino','0987655598'),(47,'1727289233','Juan H','Masculino','0987655598'),(48,'1289393988','Karla Vazquez','Femenino','0987655598'),(49,'0129293933','Joel Hidalgo','Masculino','0987655598'),(50,'0302527742','kAss','Masculino','0987655598'),(51,'1029293934','Dora Reyes','Femenino','0987655598'),(52,'1298282444','Emely Vaskez','Femenino','0987655598'),(53,'1822992833','Karen hh','Femenino','0987655598'),(54,'1263722998','Jose David Mendez Flores','Masculino','0987655598'),(55,'1263722998','Jose Mendez','Masculino','0987655598'),(56,'0302524420','csdcsdcsdcsd','Masculino','0987655598'),(57,'1293938844','Katerin Cedeño','Femenino','0987655598'),(58,'0956267272','Agela Ortiz','Femenino','0987655598'),(59,'1263637272','Jose Alvarez','Masculino','0938737373'),(60,'0373273883','Veronica Fernadez','Femenino','0977464664'),(61,'0937376636','Carlos Contreras','Masculino','0958578755'),(62,'0498888888','Jorge Ayala','Masculino','0934847766'),(63,'0938376366','Jorge Campos','Masculino','0948487474'),(64,'0383736356','Klever Fernandez','Masculino','0994874646'),(65,'0939387374','Hector Calderon','Masculino','0985757564'),(66,'0393847476','Marlon santi','Masculino','0968678666'),(67,'0984747644','Brayan Hidalgo','Masculino','0983783764'),(68,'0302633214','Kaas','Masculino','1234777878'),(69,'0000000000','Perax','Masculino','1233333333'),(70,'4444444444','lopez','Masculino','0998887373'),(71,'4555555555','Kavs','Masculino','3444444444');
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
INSERT INTO `ruta` VALUES (1,3,1),(2,4,1),(3,7,6),(4,1,5);
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
  PRIMARY KEY (`idVendedor`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendedor`
--

LOCK TABLES `vendedor` WRITE;
/*!40000 ALTER TABLE `vendedor` DISABLE KEYS */;
INSERT INTO `vendedor` VALUES (1,84035,'A',51,27),(2,123456,'A',52,28),(3,589.95,'A',53,29),(4,65089,'A',65,42);
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
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `BuscarAdministrador`(IdPersona int)
Select Cedula,CodAcceso, Nombre, Sexo, Telefono, Correo, Contrasena  from persona p inner join administrador a on a.idPersona = p.idPersona inner join iniciosesion i on a.IdCredencial = i.idInicioSesion
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
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `BuscarAsientos`(idBus int)
select DescripcionBus from asientos_bus
where asientos_bus.Id_bus = idBus AND asientos_bus.Estado='A' ;;
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
/*!50003 DROP PROCEDURE IF EXISTS `ConsultarCliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ConsultarCliente`(CedulaFx varchar(45))
Select  Cedula,Nombre,Correo from cliente
Where cedula= CedulaFx ;;
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
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ProcesoBuscarCooperativa`(SalidaFx varchar(45), SestinoFX varchar(45))
SELECT nombreCooperativa,Placa, A1.DescripcionCiudad,A2.DescripcionCiudad FROM bus_cooperativa a 
INNER JOIN cooperativa c ON a.Cooperativa_id = c.idCooperativa 
INNER JOIN ruta b ON a.Ruta_id = b.idRuta
INNER JOIN ciudad A1 ON A1.idCiudad = b.Destino
INNER JOIN ciudad A2 ON A2.idCiudad = b.Salida
Where A2.DescripcionCiudad = SalidaFx  AND A1.DescripcionCiudad= SestinoFX ;;
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
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `ProcesoBusquedaCiudad`()
Select  *from ciudad ;;
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
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'NO_AUTO_VALUE_ON_ZERO' */ ;
DELIMITER ;;
CREATE DEFINER=`a83d0f_a7eb45`@`%` PROCEDURE `spl_insertarAdministrador`(CedulaFx varchar(10), NombreFx varchar(25), SexoFx varchar(15), TelefonoFx varchar (10), CodAcceso varchar(10), SueldoFx double, CorreoFx varchar (30), ContrasenaFx varchar (10),Foreking_RolesUsuarioFx int)
begin
Call Registrodepersona(CedulaFx,NombreFx,SexoFx,TelefonoFx);
set @persona = LAST_INSERT_ID();
Call Registrocredenciales(CorreoFx,ContrasenaFx,Foreking_RolesUsuarioFx);
set @credencial = LAST_INSERT_ID();
insert into vendedor (CodAcceso, Sueldo, Estado,idPersona,IdCredencial) values (CodAccesoFx, SueldoFx, 'A',@persona,@credencial);
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

-- Dump completed on 2022-03-06 14:46:45
