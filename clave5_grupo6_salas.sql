CREATE DATABASE  IF NOT EXISTS `clave5_grupo6` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `clave5_grupo6`;
-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: clave5_grupo6
-- ------------------------------------------------------
-- Server version	8.0.40

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
-- Table structure for table `salas`
--

DROP TABLE IF EXISTS `salas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `salas` (
  `SalaID` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(100) DEFAULT NULL,
  `Capacidad` int DEFAULT NULL,
  `Ubicacion` varchar(100) DEFAULT NULL,
  `Equipos` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`SalaID`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `salas`
--

LOCK TABLES `salas` WRITE;
/*!40000 ALTER TABLE `salas` DISABLE KEYS */;
INSERT INTO `salas` VALUES (1,'Sala A',10,'Piso 1','Proyector, Oasis, Cafetera'),(2,'Sala B',15,'Piso 2','Oasis, Cafetera'),(3,'Sala C',25,'Piso 3','Proyector, Oasis'),(4,'Sala D',20,'Piso 1','Proyector, Cafetera'),(5,'Sala A',20,'Piso 1, Ala Norte','Proyector, Pantalla, Micrófono'),(6,'Sala B',15,'Piso 1, Ala Sur','Pantalla, Micrófono'),(7,'Sala C',30,'Piso 2, Ala Este','Proyector, Pantalla, Audio, Micrófono'),(8,'Sala D',10,'Piso 3, Ala Oeste','Pantalla, Micrófono'),(9,'Sala E',25,'Piso 2, Ala Norte','Proyector, Pantalla'),(10,'Sala F',12,'Piso 3, Ala Sur','Proyector'),(11,'Sala G',50,'Piso 1, Ala Oeste','Pantalla, Audio, Micrófono, Proyector'),(12,'Sala H',8,'Piso 1, Ala Este','Pantalla'),(13,'Sala I',18,'Piso 2, Ala Sur','Proyector, Pantalla'),(14,'Sala J',22,'Piso 3, Ala Norte','Proyector, Micrófono'),(15,'Sala K',35,'Piso 1, Ala Este','Pantalla, Proyector'),(16,'Sala L',40,'Piso 2, Ala Oeste','Audio, Micrófono'),(17,'Sala M',60,'Piso 3, Ala Este','Proyector, Pantalla, Audio, Micrófono'),(18,'Sala N',55,'Piso 1, Ala Central','Proyector, Pantalla'),(19,'Sala O',10,'Piso 1, Ala Norte','Micrófono');
/*!40000 ALTER TABLE `salas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-20 10:15:12
