CREATE DATABASE  IF NOT EXISTS `mihailoprodavnica2` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `mihailoprodavnica2`;
-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: mihailoprodavnica2
-- ------------------------------------------------------
-- Server version	8.0.33

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
-- Table structure for table `administrator`
--

DROP TABLE IF EXISTS `administrator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administrator` (
  `ZAPOSLENA_OSOBA_JMB` char(13) NOT NULL,
  PRIMARY KEY (`ZAPOSLENA_OSOBA_JMB`),
  CONSTRAINT `fk_Administrator_ZAPOSLENA_OSOBA1` FOREIGN KEY (`ZAPOSLENA_OSOBA_JMB`) REFERENCES `zaposlena_osoba` (`JMB`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrator`
--

LOCK TABLES `administrator` WRITE;
/*!40000 ALTER TABLE `administrator` DISABLE KEYS */;
INSERT INTO `administrator` VALUES ('0409001200051');
/*!40000 ALTER TABLE `administrator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `artikl`
--

DROP TABLE IF EXISTS `artikl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `artikl` (
  `Barkod` int NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(45) NOT NULL,
  `Cijena` decimal(8,2) NOT NULL,
  `Kolicina` smallint NOT NULL,
  `TIP_ARTIKLA_IdTipArtikla` int NOT NULL,
  PRIMARY KEY (`Barkod`),
  KEY `fk_ARTIKL_TIP_ARTIKLA1_idx` (`TIP_ARTIKLA_IdTipArtikla`),
  CONSTRAINT `fk_ARTIKL_TIP_ARTIKLA1` FOREIGN KEY (`TIP_ARTIKLA_IdTipArtikla`) REFERENCES `tip_artikla` (`IdTipArtikla`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `artikl`
--

LOCK TABLES `artikl` WRITE;
/*!40000 ALTER TABLE `artikl` DISABLE KEYS */;
INSERT INTO `artikl` VALUES (1,'Bijeli hljeb',2.15,61,1),(2,'Crni hljeb',2.50,65,1),(3,'1L Mlijeko',2.20,55,3),(4,'Pavlaka',2.60,71,4),(5,'2L Sok od jabuke',2.50,53,5),(7,'Sprite',2.10,49,6),(8,'Baklava',3.45,23,2),(12,'Francuski hljeb',3.65,2,1);
/*!40000 ALTER TABLE `artikl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dobavljac`
--

DROP TABLE IF EXISTS `dobavljac`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dobavljac` (
  `IdDobavljac` int NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(45) NOT NULL,
  PRIMARY KEY (`IdDobavljac`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dobavljac`
--

LOCK TABLES `dobavljac` WRITE;
/*!40000 ALTER TABLE `dobavljac` DISABLE KEYS */;
INSERT INTO `dobavljac` VALUES (1,'Horvat'),(2,'Jovanovic');
/*!40000 ALTER TABLE `dobavljac` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kasa`
--

DROP TABLE IF EXISTS `kasa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kasa` (
  `IdKasa` int NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`IdKasa`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kasa`
--

LOCK TABLES `kasa` WRITE;
/*!40000 ALTER TABLE `kasa` DISABLE KEYS */;
INSERT INTO `kasa` VALUES (1),(2),(3),(4);
/*!40000 ALTER TABLE `kasa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `narudzba`
--

DROP TABLE IF EXISTS `narudzba`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `narudzba` (
  `IdNarudzba` int NOT NULL AUTO_INCREMENT,
  `Datum` date NOT NULL,
  `DOBAVLJAC_IdDobavljac` int NOT NULL,
  PRIMARY KEY (`IdNarudzba`),
  KEY `fk_NARUDZBA_DOBAVLJAC1_idx` (`DOBAVLJAC_IdDobavljac`),
  CONSTRAINT `fk_NARUDZBA_DOBAVLJAC1` FOREIGN KEY (`DOBAVLJAC_IdDobavljac`) REFERENCES `dobavljac` (`IdDobavljac`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `narudzba`
--

LOCK TABLES `narudzba` WRITE;
/*!40000 ALTER TABLE `narudzba` DISABLE KEYS */;
INSERT INTO `narudzba` VALUES (1,'2023-07-25',1),(3,'2023-07-31',1),(4,'2023-10-14',1),(5,'2022-02-18',2),(6,'2021-06-18',2),(7,'2021-01-24',2),(9,'2022-06-20',2),(10,'2023-11-15',2);
/*!40000 ALTER TABLE `narudzba` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `narudzba_artikl`
--

DROP TABLE IF EXISTS `narudzba_artikl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `narudzba_artikl` (
  `NARUDZBA_IdNarudzba` int NOT NULL,
  `ARTIKL_Barkod` int NOT NULL,
  `Cijena` decimal(8,2) NOT NULL,
  `Kolicina` smallint NOT NULL,
  PRIMARY KEY (`NARUDZBA_IdNarudzba`,`ARTIKL_Barkod`),
  KEY `fk_NARUDZBA_has_ARTIKL_ARTIKL1_idx` (`ARTIKL_Barkod`),
  KEY `fk_NARUDZBA_has_ARTIKL_NARUDZBA1_idx` (`NARUDZBA_IdNarudzba`),
  CONSTRAINT `fk_NARUDZBA_has_ARTIKL_ARTIKL1` FOREIGN KEY (`ARTIKL_Barkod`) REFERENCES `artikl` (`Barkod`),
  CONSTRAINT `fk_NARUDZBA_has_ARTIKL_NARUDZBA1` FOREIGN KEY (`NARUDZBA_IdNarudzba`) REFERENCES `narudzba` (`IdNarudzba`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `narudzba_artikl`
--

LOCK TABLES `narudzba_artikl` WRITE;
/*!40000 ALTER TABLE `narudzba_artikl` DISABLE KEYS */;
INSERT INTO `narudzba_artikl` VALUES (1,1,1.60,10),(1,2,2.10,10),(3,5,2.20,5),(3,7,1.80,5),(3,8,3.45,3),(4,1,2.15,10),(4,2,2.50,10),(4,3,2.20,10),(4,4,2.60,10),(4,5,2.50,10),(4,7,2.15,10),(4,8,3.45,10),(5,1,2.15,8),(5,2,2.50,8),(5,3,2.20,8),(5,4,2.60,8),(5,5,2.50,6),(5,7,2.15,6),(5,8,3.45,2),(6,1,2.15,2),(6,2,2.50,2),(6,3,2.20,2),(6,4,2.60,2),(7,2,2.50,2),(7,4,2.60,3),(7,7,2.10,2),(9,2,2.50,10),(9,4,2.60,10),(9,7,2.10,10),(10,8,3.45,2),(10,12,3.65,2);
/*!40000 ALTER TABLE `narudzba_artikl` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb3 */ ;
/*!50003 SET character_set_results = utf8mb3 */ ;
/*!50003 SET collation_connection  = utf8mb3_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,NO_AUTO_VALUE_ON_ZERO,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `narudzba_artikl_AFTER_INSERT` AFTER INSERT ON `narudzba_artikl` FOR EACH ROW UPDATE artikl
SET Kolicina = Kolicina + new.Kolicina
WHERE Barkod = new.ARTIKL_Barkod */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `racun`
--

DROP TABLE IF EXISTS `racun`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `racun` (
  `IdRacun` int NOT NULL AUTO_INCREMENT,
  `VrijemeIzdavanja` datetime NOT NULL,
  `RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB` char(13) NOT NULL,
  `KASA_IdKasa` int NOT NULL,
  PRIMARY KEY (`IdRacun`),
  KEY `fk_RACUN_RADNIK_NA_KASI1_idx` (`RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB`),
  KEY `fk_RACUN_KASA1_idx` (`KASA_IdKasa`),
  CONSTRAINT `fk_RACUN_KASA1` FOREIGN KEY (`KASA_IdKasa`) REFERENCES `kasa` (`IdKasa`),
  CONSTRAINT `fk_RACUN_RADNIK_NA_KASI1` FOREIGN KEY (`RADNIK_NA_KASI_ZAPOSLENA_OSOBA_JMB`) REFERENCES `radnik_na_kasi` (`ZAPOSLENA_OSOBA_JMB`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `racun`
--

LOCK TABLES `racun` WRITE;
/*!40000 ALTER TABLE `racun` DISABLE KEYS */;
INSERT INTO `racun` VALUES (1,'2023-07-20 14:20:45','1306000100051',1),(2,'2023-07-20 14:30:48','2308003200045',2),(3,'2023-07-25 10:53:10','1306000100051',3),(4,'2023-07-25 11:26:59','2308003200045',2),(5,'2023-07-25 11:41:53','1306000100051',1),(6,'2023-07-25 12:01:14','2308003200045',3),(7,'2023-08-22 13:32:35','1306000100051',1),(8,'2023-08-24 10:18:25','1306000100051',1),(9,'2023-10-31 17:51:18','1306000100051',2),(10,'2023-11-05 18:22:50','1306000100051',1),(11,'2023-11-05 18:39:20','1306000100051',2),(12,'2023-11-05 19:12:37','1306000100051',1),(13,'2023-11-05 19:13:04','1306000100051',1),(14,'2023-11-05 19:27:51','1306000100051',2),(15,'2023-11-06 14:45:42','1306000100051',3),(16,'2023-11-06 17:47:28','1306000100051',3);
/*!40000 ALTER TABLE `racun` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb3 */ ;
/*!50003 SET character_set_results = utf8mb3 */ ;
/*!50003 SET collation_connection  = utf8mb3_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,NO_AUTO_VALUE_ON_ZERO,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `racun_BEFORE_INSERT` BEFORE INSERT ON `racun` FOR EACH ROW BEGIN
	SET new.VrijemeIzdavanja = NOW();
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `racun_artikl`
--

DROP TABLE IF EXISTS `racun_artikl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `racun_artikl` (
  `RACUN_IdRacun` int NOT NULL,
  `ARTIKL_Barkod` int NOT NULL,
  `Cijena` decimal(8,2) NOT NULL,
  `Kolicina` smallint NOT NULL,
  PRIMARY KEY (`RACUN_IdRacun`,`ARTIKL_Barkod`),
  KEY `fk_RACUN_has_ARTIKL_ARTIKL1_idx` (`ARTIKL_Barkod`),
  KEY `fk_RACUN_has_ARTIKL_RACUN1_idx` (`RACUN_IdRacun`),
  CONSTRAINT `fk_RACUN_has_ARTIKL_ARTIKL1` FOREIGN KEY (`ARTIKL_Barkod`) REFERENCES `artikl` (`Barkod`),
  CONSTRAINT `fk_RACUN_has_ARTIKL_RACUN1` FOREIGN KEY (`RACUN_IdRacun`) REFERENCES `racun` (`IdRacun`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `racun_artikl`
--

LOCK TABLES `racun_artikl` WRITE;
/*!40000 ALTER TABLE `racun_artikl` DISABLE KEYS */;
INSERT INTO `racun_artikl` VALUES (1,1,2.10,1),(1,3,2.20,1),(1,7,2.05,2),(2,7,2.05,1),(3,2,2.50,1),(3,3,2.20,2),(3,4,2.60,1),(3,7,2.05,2),(4,2,2.50,2),(4,4,2.60,2),(5,3,2.20,3),(5,4,2.60,1),(6,2,2.50,2),(6,7,2.05,1),(7,2,2.50,2),(7,3,2.20,1),(7,7,2.05,1),(8,1,2.10,2),(8,3,2.20,3),(9,1,2.10,1),(9,3,2.20,1),(9,8,3.45,2),(11,1,2.10,3),(11,2,2.50,2),(11,5,2.50,2),(11,8,3.45,1),(12,3,2.20,2),(13,3,2.20,1),(14,1,2.35,3),(14,3,2.25,2),(15,3,2.20,1);
/*!40000 ALTER TABLE `racun_artikl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `radnik_na_kasi`
--

DROP TABLE IF EXISTS `radnik_na_kasi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `radnik_na_kasi` (
  `ZAPOSLENA_OSOBA_JMB` char(13) NOT NULL,
  PRIMARY KEY (`ZAPOSLENA_OSOBA_JMB`),
  CONSTRAINT `fk_RADNIK_NA_KASI_ZAPOSLENA_OSOBA1` FOREIGN KEY (`ZAPOSLENA_OSOBA_JMB`) REFERENCES `zaposlena_osoba` (`JMB`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `radnik_na_kasi`
--

LOCK TABLES `radnik_na_kasi` WRITE;
/*!40000 ALTER TABLE `radnik_na_kasi` DISABLE KEYS */;
INSERT INTO `radnik_na_kasi` VALUES ('1306000100051'),('2308003200045');
/*!40000 ALTER TABLE `radnik_na_kasi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tip_artikla`
--

DROP TABLE IF EXISTS `tip_artikla`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tip_artikla` (
  `IdTipArtikla` int NOT NULL AUTO_INCREMENT,
  `Naziv` varchar(45) NOT NULL,
  PRIMARY KEY (`IdTipArtikla`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tip_artikla`
--

LOCK TABLES `tip_artikla` WRITE;
/*!40000 ALTER TABLE `tip_artikla` DISABLE KEYS */;
INSERT INTO `tip_artikla` VALUES (1,'Hljeb'),(2,'Kolac'),(3,'Mlijeko'),(4,'Mlijecni proizvod'),(5,'Negazirano pice'),(6,'Gazirano pice'),(9,'xyz');
/*!40000 ALTER TABLE `tip_artikla` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ugovor_o_zaposlenju`
--

DROP TABLE IF EXISTS `ugovor_o_zaposlenju`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ugovor_o_zaposlenju` (
  `IdUgovor` int NOT NULL AUTO_INCREMENT,
  `Od` date NOT NULL,
  `Do` date NOT NULL,
  `Plata` decimal(6,2) NOT NULL,
  `ZAPOSLENA_OSOBA_JMB` char(13) NOT NULL,
  PRIMARY KEY (`IdUgovor`),
  KEY `fk_UGOVOR_O_ZAPOSLENJU_ZAPOSLENA_OSOBA1_idx` (`ZAPOSLENA_OSOBA_JMB`),
  CONSTRAINT `fk_UGOVOR_O_ZAPOSLENJU_ZAPOSLENA_OSOBA1` FOREIGN KEY (`ZAPOSLENA_OSOBA_JMB`) REFERENCES `zaposlena_osoba` (`JMB`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ugovor_o_zaposlenju`
--

LOCK TABLES `ugovor_o_zaposlenju` WRITE;
/*!40000 ALTER TABLE `ugovor_o_zaposlenju` DISABLE KEYS */;
INSERT INTO `ugovor_o_zaposlenju` VALUES (1,'2018-11-05','2020-11-05',2000.00,'1306000100051'),(2,'2021-03-04','2024-03-04',2300.00,'1306000100051'),(5,'2023-11-23','2026-02-12',2700.00,'2308003200045');
/*!40000 ALTER TABLE `ugovor_o_zaposlenju` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zaposlena_osoba`
--

DROP TABLE IF EXISTS `zaposlena_osoba`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `zaposlena_osoba` (
  `JMB` char(13) NOT NULL,
  `Prezime` varchar(20) NOT NULL,
  `Ime` varchar(20) NOT NULL,
  `KorisnickoIme` varchar(45) NOT NULL,
  `Lozinka` varchar(128) NOT NULL,
  PRIMARY KEY (`JMB`),
  UNIQUE KEY `KorisnickoIme_UNIQUE` (`KorisnickoIme`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zaposlena_osoba`
--

LOCK TABLES `zaposlena_osoba` WRITE;
/*!40000 ALTER TABLE `zaposlena_osoba` DISABLE KEYS */;
INSERT INTO `zaposlena_osoba` VALUES ('0409001200051','Nikolic','Nikola','nikola','12345'),('1306000100051','Vasic','Mihailo','mihailo','12345'),('2308003200045','Markovicc','Markoo','markan','haha');
/*!40000 ALTER TABLE `zaposlena_osoba` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'mihailoprodavnica2'
--

--
-- Dumping routines for database 'mihailoprodavnica2'
--
/*!50003 DROP PROCEDURE IF EXISTS `create_racun_artikl` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `create_racun_artikl`(IN racunId INT, IN artiklBarkod INT, IN raCijena DECIMAL(8, 2), IN raKolicina INT, OUT b BOOL)
BEGIN
	DECLARE varKolicina INT DEFAULT 0;
SELECT 
    kolicina
INTO varKolicina FROM
    artikl
WHERE
    Barkod = artiklBarkod;
    
    SET b = true;
    
    IF(raKolicina > varKolicina) THEN
		SET b = FALSE;
	ELSE 
        INSERT INTO racun_artikl VALUES(racunId, artiklBarkod, raCijena, raKolicina);
UPDATE artikl 
SET 
    kolicina = kolicina - raKolicina
WHERE
    barkod = artiklBarkod;
    END IF;
END ;;
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

-- Dump completed on 2023-11-24 16:32:38
