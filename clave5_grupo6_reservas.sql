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
-- Table structure for table `reservas`
--

DROP TABLE IF EXISTS `reservas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservas` (
  `ReservaID` int NOT NULL AUTO_INCREMENT,
  `SalaID` int DEFAULT NULL,
  `Fecha` date DEFAULT NULL,
  `Hora` time DEFAULT NULL,
  `NombrePersona` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ReservaID`),
  KEY `SalaID` (`SalaID`),
  CONSTRAINT `reservas_ibfk_1` FOREIGN KEY (`SalaID`) REFERENCES `salas` (`SalaID`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservas`
--

LOCK TABLES `reservas` WRITE;
/*!40000 ALTER TABLE `reservas` DISABLE KEYS */;
INSERT INTO `reservas` VALUES (1,1,'2024-11-14','10:00:00','Juan Pérez'),(2,2,'2024-11-14','14:00:00','Ana López'),(3,3,'2024-11-15','09:00:00','Carlos Ruiz'),(4,4,'2024-11-15','13:00:00','Juan Pérez'),(5,1,'2024-11-20','09:00:00','Carlos Pérez'),(6,2,'2024-11-21','10:30:00','Ana Gómez'),(7,3,'2024-11-22','14:00:00','Luis Martínez'),(8,4,'2024-11-23','08:00:00','Pedro Sánchez'),(9,5,'2024-11-24','15:00:00','Marta López'),(10,6,'2024-11-25','11:30:00','Javier Fernández'),(11,7,'2024-11-26','16:00:00','Lucía Rodríguez'),(12,8,'2024-11-27','12:00:00','Antonio Gómez'),(13,9,'2024-11-28','09:30:00','Patricia Ruiz'),(14,10,'2024-11-29','13:00:00','Raúl Pérez'),(15,11,'2024-11-30','10:00:00','Isabel Díaz'),(16,12,'2024-12-01','14:30:00','David González'),(17,13,'2024-12-02','08:30:00','Victoria Jiménez'),(18,14,'2024-12-03','16:30:00','José Fernández'),(19,15,'2024-12-04','11:00:00','Manuel López');
/*!40000 ALTER TABLE `reservas` ENABLE KEYS */;
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
