-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: MYSQL5045.site4now.net    Database: db_a7eb45_sga
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `asientos_bus`
--

DROP TABLE IF EXISTS `asientos_bus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `asientos_bus` (
  `idAsientos_bus` int NOT NULL AUTO_INCREMENT,
  `DescripcionBus` varchar(45) NOT NULL,
  `Estado` varchar(1) NOT NULL,
  `Id_bus` int NOT NULL,
  PRIMARY KEY (`idAsientos_bus`),
  UNIQUE KEY `idAsientos_bus_UNIQUE` (`idAsientos_bus`),
  KEY `DkBus_idx` (`Id_bus`),
  CONSTRAINT `DkBus` FOREIGN KEY (`Id_bus`) REFERENCES `bus_cooperativa` (`idBus`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `idBoleto` int NOT NULL AUTO_INCREMENT,
  `Cantidad` int NOT NULL,
  `Precio` double NOT NULL,
  PRIMARY KEY (`idBoleto`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `idBus` int NOT NULL AUTO_INCREMENT,
  `Placa` varchar(10) NOT NULL,
  `Disco` varchar(45) NOT NULL,
  `Modelo` varchar(45) NOT NULL,
  `Marca` varchar(45) NOT NULL,
  `CantidadAsiento` int NOT NULL,
  `Ruta_id` int NOT NULL,
  `Cooperativa_id` int NOT NULL,
  PRIMARY KEY (`idBus`),
  KEY `Ruta_idx` (`Ruta_id`),
  KEY `Cooperativa_idx` (`Cooperativa_id`),
  CONSTRAINT `Cooperativa` FOREIGN KEY (`Cooperativa_id`) REFERENCES `cooperativa` (`idCooperativa`),
  CONSTRAINT `Ruta` FOREIGN KEY (`Ruta_id`) REFERENCES `ruta` (`idRuta`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `idCabeceraFactura` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(25) NOT NULL,
  `nombreCooperativa` varchar(25) NOT NULL,
  `fechaEmision` datetime NOT NULL,
  `idboleto` int NOT NULL,
  `Estado` char(1) NOT NULL,
  PRIMARY KEY (`idCabeceraFactura`),
  KEY `foreingKeycf` (`idboleto`),
  CONSTRAINT `foreingKeycf` FOREIGN KEY (`idboleto`) REFERENCES `ventaboleto` (`idBoleto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cabecerafactura`
--

LOCK TABLES `cabecerafactura` WRITE;
/*!40000 ALTER TABLE `cabecerafactura` DISABLE KEYS */;
/*!40000 ALTER TABLE `cabecerafactura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chofer`
--

DROP TABLE IF EXISTS `chofer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chofer` (
  `idChofer` int NOT NULL AUTO_INCREMENT,
  `Cedula` varchar(10) NOT NULL,
  `Nombre` varchar(25) NOT NULL,
  `Licencia` varchar(10) NOT NULL,
  `Sexo` varchar(10) NOT NULL,
  `Teléfono` varchar(10) NOT NULL,
  `Correo` varchar(45) NOT NULL,
  `Ciudad` varchar(45) NOT NULL,
  `Usuario` varchar(20) NOT NULL,
  `Contraseña` varchar(9) NOT NULL,
  `idCooperativa` int NOT NULL,
  `Estado` char(1) NOT NULL,
  PRIMARY KEY (`idChofer`),
  UNIQUE KEY `Licencia_UNIQUE` (`Licencia`),
  UNIQUE KEY `Cedula_UNIQUE` (`Cedula`),
  KEY `foreignKeychofer` (`idCooperativa`),
  CONSTRAINT `foreignKeychofer` FOREIGN KEY (`idCooperativa`) REFERENCES `cooperativa` (`idCooperativa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chofer`
--

LOCK TABLES `chofer` WRITE;
/*!40000 ALTER TABLE `chofer` DISABLE KEYS */;
/*!40000 ALTER TABLE `chofer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ciudad`
--

DROP TABLE IF EXISTS `ciudad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ciudad` (
  `idCiudad` int NOT NULL AUTO_INCREMENT,
  `DescripcionCiudad` varchar(45) NOT NULL,
  `provincia` int NOT NULL,
  PRIMARY KEY (`idCiudad`),
  KEY `ProvinciaFK_idx` (`provincia`),
  CONSTRAINT `ProvinciaFK` FOREIGN KEY (`provincia`) REFERENCES `provincia` (`idprovincia`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ciudad`
--

LOCK TABLES `ciudad` WRITE;
/*!40000 ALTER TABLE `ciudad` DISABLE KEYS */;
INSERT INTO `ciudad` VALUES (1,'Guayaquil',1),(2,'Duran',1),(3,'Troncal',3),(4,'Quito',2),(5,'Manta',4),(6,'Esmeraldas',5),(7,'Cuenca',6);
/*!40000 ALTER TABLE `ciudad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `idCliente` int NOT NULL AUTO_INCREMENT,
  `Cedula` varchar(10) NOT NULL,
  `Nombre` varchar(25) NOT NULL,
  `Sexo` varchar(15) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Correo` varchar(45) NOT NULL,
  `Contraseña` varchar(9) NOT NULL,
  PRIMARY KEY (`idCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'0302527742','Kevin Arevalo','masculino','2309831234','pppp@hotmail.com','23456'),(2,'0991887965','kevin','masculino','02999393','gss@gmail.com','qwwqw'),(3,'0991887965','joel','femenino','02999393','gss@gmail.com','qwwqw'),(4,'1234567890','Jose ALVAREZ','Masculino','12262626','JOSE@GMAIL.com','12345'),(5,'6328925347','Jimi Fernandes','Masculino','0976524312','jimi@gmail.com','12345'),(6,'0921408324','kevin','Masculino','0982307101','kevinsotomayor3@hotmail.com','101791'),(7,'1423567890','Maria Flores','Femenino','0981234567','maria@gmail.com','m12345'),(8,'1327369873','Melania Rodriguez','Femenino','0987624231','melania@gmail.com','123876'),(9,'1234567890','','','','',''),(10,'1237388098','Feliz Jaramillo','Masculino','0987654327','feliz@gmail.com','jarami22'),(11,'1276309876','Fernada Hidalgo','Femenino','0952671286','fernanda@gmail.com','fernan12'),(12,'0301499208','Rosa Saldaña','Femenino','0990067417','lema@hotmail.com','123kevin'),(13,'1234567890','Luis','Masculino','1234567890','Kaas@gmail.com','1234'),(14,'1234567890','Joel','Masculino','1234567890','Kaas@gmail.com','1234'),(15,'1234567890','Kevin','Masculino','1234567890','123','123'),(16,'0302527742','Kevin','Masculino','1234567890','123','123'),(17,'0302527740','Kevin','Masculino','1234567890','kevinArevalo@hotmail.com','123456789'),(18,'0976548863','Dillan Saldaña','Masculino','0997886523','Dillan@live.com','1234poy'),(19,'0976548863','Dillan Saldaña','Masculino','0997886523','Dillan@live.com','1234poy'),(20,'1234908765','Fernando Encada','Masculino','0965212344','fernando@gmail.com','fernan12'),(21,'1234','qwww dsdds','Masculino','212335554','qwqwq','wqwqwq'),(22,'','','','','',''),(23,'1234567890','Fernado','Masculino','0987654321','ferggs@gmail.','fernan12'),(24,'1105086332','dario Gomez','Masculino','0912233333','dario@gmail','dar123'),(25,'1273377373','Miguel Fajardo','Masculino','0965352522','miguel@gmail','migue32'),(26,'1254443333','Verenice','Femenino','0952271771','verenice@gmail','ver2443'),(27,'0925627818','Henrry','Masculino','0928222363','henrry','henr2662'),(28,'1233934044','Maria Paladines','Femenino','0333882233','mary@gmail','mary124'),(29,'0465555555','tgnkmlj','Masculino','8989899899','hyttttttt@hotmail.com','456456fgh');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cooperativa`
--

DROP TABLE IF EXISTS `cooperativa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cooperativa` (
  `idCooperativa` int NOT NULL AUTO_INCREMENT,
  `nombreCooperativa` varchar(25) NOT NULL,
  `NombrePropietario` varchar(45) NOT NULL,
  `RucCooperativa` varchar(15) NOT NULL,
  `TipoCooperativa` varchar(25) NOT NULL,
  `Estado` char(1) NOT NULL,
  PRIMARY KEY (`idCooperativa`),
  UNIQUE KEY `RucCooperativa_UNIQUE` (`RucCooperativa`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cooperativa`
--

LOCK TABLES `cooperativa` WRITE;
/*!40000 ALTER TABLE `cooperativa` DISABLE KEYS */;
INSERT INTO `cooperativa` VALUES (1,'Troncaleña','Kevin Arevalo','1790010937001','1','A'),(2,'Transportes Ecuador','Angel Chavarrea','2040710102301','1','A'),(3,'SuperTaxi','Rosa Saldaña','1370230107463','1','A'),(4,'Manta Express.','Sergio Campoverde','3072930107910','1','A');
/*!40000 ALTER TABLE `cooperativa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_factura`
--

DROP TABLE IF EXISTS `detalle_factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalle_factura` (
  `idDetalle_factura` int NOT NULL AUTO_INCREMENT,
  `Destino` varchar(45) NOT NULL,
  `cant_Boleto` int NOT NULL,
  `Precio_Uni` double NOT NULL,
  `Impuesto` double NOT NULL,
  `PrecioTotal` double NOT NULL,
  `idCabeceraFactura` int NOT NULL,
  `Estado` char(1) NOT NULL,
  PRIMARY KEY (`idDetalle_factura`),
  KEY `foreignKeydf` (`idCabeceraFactura`),
  CONSTRAINT `foreignKeydf` FOREIGN KEY (`idCabeceraFactura`) REFERENCES `cabecerafactura` (`idCabeceraFactura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_factura`
--

LOCK TABLES `detalle_factura` WRITE;
/*!40000 ALTER TABLE `detalle_factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `generar_boleto`
--

DROP TABLE IF EXISTS `generar_boleto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `generar_boleto` (
  `idboleto` int NOT NULL AUTO_INCREMENT,
  `HoraSalida` time NOT NULL,
  `FechaSalida` datetime NOT NULL,
  `BusID` int NOT NULL,
  `BoletoId` int NOT NULL,
  PRIMARY KEY (`idboleto`),
  KEY `FK_bus_idx` (`BusID`),
  KEY `FK_boleto_idx` (`BoletoId`),
  CONSTRAINT `FK_boleto` FOREIGN KEY (`BoletoId`) REFERENCES `boleto` (`idBoleto`),
  CONSTRAINT `FK_bus` FOREIGN KEY (`BusID`) REFERENCES `bus_cooperativa` (`idBus`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `idInicioSesion` int NOT NULL AUTO_INCREMENT,
  `Correo` varchar(45) NOT NULL,
  `Contrasena` varchar(45) NOT NULL,
  `Foreking_RolesUsuario` int NOT NULL,
  PRIMARY KEY (`idInicioSesion`),
  KEY `Roles_idx` (`Foreking_RolesUsuario`),
  CONSTRAINT `Roles` FOREIGN KEY (`Foreking_RolesUsuario`) REFERENCES `rol_usuario` (`idRol_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `iniciosesion`
--

LOCK TABLES `iniciosesion` WRITE;
/*!40000 ALTER TABLE `iniciosesion` DISABLE KEYS */;
INSERT INTO `iniciosesion` VALUES (1,'Kaas7520@hotmail.com','1234',1),(2,'JoelCB12@hotmail.com','7520',1),(3,'David99@hotmail.com','david19',2),(4,'Troncalena19@hotmail.com','Tronc90',3),(5,'ChavareaCSE90@hotmail.com','Emelec90',4),(6,'Dillan@hotmail.com','Kevin',1),(7,'Segio@hotmail.com','malmelec',2);
/*!40000 ALTER TABLE `iniciosesion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `provincia`
--

DROP TABLE IF EXISTS `provincia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `provincia` (
  `idprovincia` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) NOT NULL,
  PRIMARY KEY (`idprovincia`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `provincia`
--

LOCK TABLES `provincia` WRITE;
/*!40000 ALTER TABLE `provincia` DISABLE KEYS */;
INSERT INTO `provincia` VALUES (1,'Guayas'),(2,'Pichincha'),(3,'Cañar'),(4,'Manabi'),(5,'Esmeraldas'),(6,'Azuay');
/*!40000 ALTER TABLE `provincia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pruebac`
--

DROP TABLE IF EXISTS `pruebac`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pruebac` (
  `Id_Chofer` int NOT NULL AUTO_INCREMENT,
  `cedula` varchar(40) NOT NULL,
  `nombre` varchar(40) NOT NULL,
  `licencia` varchar(40) NOT NULL,
  `sexo` varchar(40) NOT NULL,
  `telefono` int NOT NULL,
  `correo` varchar(40) NOT NULL,
  `usuario` varchar(40) NOT NULL,
  `contraseña` varchar(40) NOT NULL,
  PRIMARY KEY (`Id_Chofer`),
  UNIQUE KEY `cedula` (`cedula`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pruebac`
--

LOCK TABLES `pruebac` WRITE;
/*!40000 ALTER TABLE `pruebac` DISABLE KEYS */;
INSERT INTO `pruebac` VALUES (1,'1','1','1','1',1,'1','1','1'),(2,'2','4','4','4',4,'4','4','4');
/*!40000 ALTER TABLE `pruebac` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reporte`
--

DROP TABLE IF EXISTS `reporte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reporte` (
  `idReporte` int NOT NULL AUTO_INCREMENT,
  `Descripción` varchar(45) NOT NULL,
  `Tipo_Reporte` varchar(45) NOT NULL,
  `idUsuario` int NOT NULL,
  `Estado` char(1) NOT NULL,
  PRIMARY KEY (`idReporte`),
  KEY `foreignkeyrol` (`idUsuario`),
  CONSTRAINT `foreignkeyrol` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
  `idRol_Usuario` int NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(25) NOT NULL,
  `Estado` char(1) NOT NULL,
  PRIMARY KEY (`idRol_Usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rol_usuario`
--

LOCK TABLES `rol_usuario` WRITE;
/*!40000 ALTER TABLE `rol_usuario` DISABLE KEYS */;
INSERT INTO `rol_usuario` VALUES (1,'Administrador','A'),(2,'Chofer','A'),(3,'Cooperativa','A'),(4,'Cliente','A');
/*!40000 ALTER TABLE `rol_usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ruta`
--

DROP TABLE IF EXISTS `ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ruta` (
  `idRuta` int NOT NULL AUTO_INCREMENT,
  `Destino` int NOT NULL,
  `Salida` int NOT NULL,
  PRIMARY KEY (`idRuta`),
  KEY `CiudadDestino_idx` (`Destino`),
  KEY `CiudadOrigen_idx` (`Salida`),
  CONSTRAINT `CiudadDestino` FOREIGN KEY (`Destino`) REFERENCES `ciudad` (`idCiudad`),
  CONSTRAINT `CiudadOrigen` FOREIGN KEY (`Salida`) REFERENCES `ciudad` (`idCiudad`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
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
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `idUsuario` int NOT NULL AUTO_INCREMENT,
  `Cedula` varchar(10) NOT NULL,
  `Nombre` varchar(25) NOT NULL,
  `Sexo` varchar(15) NOT NULL,
  `Teléfono` varchar(10) NOT NULL,
  `Correo` varchar(45) NOT NULL,
  `Ciudad` varchar(45) NOT NULL,
  `Usuario` varchar(20) NOT NULL,
  `Contraseña` varchar(9) NOT NULL,
  `idRol_Usuario` int NOT NULL,
  `idCooperativa` int NOT NULL,
  `Estado` char(1) NOT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `Cedula_UNIQUE` (`Cedula`),
  KEY `foreignkeycoperativa` (`idCooperativa`),
  KEY `foreignkey` (`idRol_Usuario`),
  CONSTRAINT `foreignkey` FOREIGN KEY (`idRol_Usuario`) REFERENCES `rol_usuario` (`idRol_Usuario`),
  CONSTRAINT `foreignkeycoperativa` FOREIGN KEY (`idCooperativa`) REFERENCES `cooperativa` (`idCooperativa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventaboleto`
--

DROP TABLE IF EXISTS `ventaboleto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ventaboleto` (
  `idBoleto` int NOT NULL AUTO_INCREMENT,
  `Cedula` varchar(10) NOT NULL,
  `Nombre` varchar(25) DEFAULT NULL,
  `lugarSalida` varchar(45) NOT NULL,
  `lugarDestino` varchar(45) NOT NULL,
  `FechaSalida` date NOT NULL,
  `horaSalida` time NOT NULL,
  `fechaEmision` date NOT NULL,
  `nombreCoopertiva` varchar(25) NOT NULL,
  `numDisco` int NOT NULL,
  `numAsiento` int NOT NULL,
  `Precio` double NOT NULL,
  `Impuesto12` double NOT NULL,
  `idCooperativa` int NOT NULL,
  `Estado` char(1) NOT NULL,
  PRIMARY KEY (`idBoleto`),
  UNIQUE KEY `Cedula_UNIQUE` (`Cedula`),
  KEY `foreignkeyventa` (`idCooperativa`),
  CONSTRAINT `foreignkeyventa` FOREIGN KEY (`idCooperativa`) REFERENCES `cooperativa` (`idCooperativa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventaboleto`
--

LOCK TABLES `ventaboleto` WRITE;
/*!40000 ALTER TABLE `ventaboleto` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventaboleto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'db_a7eb45_sga'
--
/*!50003 DROP PROCEDURE IF EXISTS `BuscarAsientos` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `BuscarAsientos`(idBus int)
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
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `BuscarCliente`(cedulaCliente varchar(45))
Select *from cliente 
where cliente.Cedula = cedulaCliente ;;
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
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `InicioSeccionEjemplo`()
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
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `Insetar`(usuarioFx varchar(45), contrasenaFx varchar(9), rolUsuario int)
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
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `Insetarb`(usuarioFx varchar(45), contrasenaFx varchar(45), rolUsuario int)
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
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `LlenarVentanaCompra`(cooperativaFX varchar(45), horaSalidaFX varchar(45), fechaSalidaFX varchar(45))
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
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `ModificarCliente`(Telefono1 varchar(45), Correo1 varchar(45), Usuario1 varchar(45), Contraseña1 varchar(45), Cedula1 varchar(45))
update cliente set Telefono = Telefono1, 
    Correo = Correo1, 
    Usuario= Usuario1, 
    Contraseña = Contraseña1 where Cedula = Cedula1 ;;
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
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `Procedimiento_insertar_cliente`(Cedula varchar(10), Nombre varchar(25), Sexo varchar(15), 
Telefono varchar (10), Correo varchar(45),Contraseña varchar(9))
insert into cliente(Cedula,  Nombre, Sexo, Telefono, Correo,Contraseña)values(Cedula, Nombre, Sexo,
Telefono, Correo,Contraseña) ;;
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
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `ProcesoBuscarCooperativa`(SalidaFx varchar(45), SestinoFX varchar(45))
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
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `ProcesoBusquedaCiudad`()
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
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `ProcesoInicioSeccion`(CorreoFx varchar(45), contrasenaFx varchar(45), rolUsuario int)
Select  Contrasena, Correo from iniciosesion
Where Correo=CorreoFx and Contrasena=ContrasenaFX and Foreking_RolesUsuario=rolUsuario ;;
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
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `ProcesoLlenarDataGrid`(SalidaFx varchar(45), DestinoFX varchar(45), CooperativaFX varchar(45))
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
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `ProcesoLlenarDataGridB2`(SalidaFx varchar(45), DestinoFX varchar(45), CooperativaFX varchar(45))
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
/*!50003 DROP PROCEDURE IF EXISTS `spl_insertar_cliente` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`a7eb45_sga`@`%` PROCEDURE `spl_insertar_cliente`(Cedula varchar(10), Nombre varchar(25), Sexo varchar(15), 
Telefono varchar (10), Correo varchar(45), Ciudad varchar(45), Usuario varchar(20), Contraseña varchar(9))
insert into cliente(Cedula,  Nombre, Sexo, Telefono, Correo, Ciudad, Usuario, Contraseña)values(Cedula, Nombre, Sexo,
Telefono, Correo, Ciudad, Usuario, Contraseña) ;;
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

-- Dump completed on 2022-01-17 10:03:30
