-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: kutuphane
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `kitap_turleri`
--

DROP TABLE IF EXISTS `kitap_turleri`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kitap_turleri` (
  `tur_id` tinyint NOT NULL AUTO_INCREMENT,
  `tur_adi` varchar(40) NOT NULL,
  PRIMARY KEY (`tur_id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kitap_turleri`
--

LOCK TABLES `kitap_turleri` WRITE;
/*!40000 ALTER TABLE `kitap_turleri` DISABLE KEYS */;
INSERT INTO `kitap_turleri` VALUES (1,'Roman'),(2,'Hikaye'),(3,'Şiir'),(4,'Gezi'),(5,'Çocuk'),(6,'Kişisel Gelişim'),(7,'Sağlık'),(8,'Bilgisayar'),(9,'Deneme'),(19,'sfdsfs'),(20,'112');
/*!40000 ALTER TABLE `kitap_turleri` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kitaplar`
--

DROP TABLE IF EXISTS `kitaplar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kitaplar` (
  `kitap_id` int NOT NULL AUTO_INCREMENT,
  `tur_id` tinyint NOT NULL,
  `kitap_adi` varchar(40) NOT NULL,
  `yazar` varchar(40) NOT NULL,
  `yayinevi` varchar(40) NOT NULL,
  `sayfa_sayisi` smallint NOT NULL,
  PRIMARY KEY (`kitap_id`,`tur_id`),
  KEY `fk_kitaplar_kitap_turleri_idx` (`tur_id`),
  CONSTRAINT `fk_kitaplar_kitap_turleri` FOREIGN KEY (`tur_id`) REFERENCES `kitap_turleri` (`tur_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kitaplar`
--

LOCK TABLES `kitaplar` WRITE;
/*!40000 ALTER TABLE `kitaplar` DISABLE KEYS */;
INSERT INTO `kitaplar` VALUES (1,1,'Kuyucaklı Yusufa','Sabahattin Ali','Deneme',221),(2,1,'Suç ve Ceza','Dostoyevski','Deneme',687),(3,1,'Beyaz Gemi','Cengiz Aytmatov','Deneme',168),(4,1,'Sinekli Bakkal','Halide Edip Adıvar','Örnek',476),(5,1,'Çalıkuşu','Reşat Nuri Gültekin','Örnek',544),(6,1,'Sefiller','Victor Hugo','Örnek',520),(7,2,'Ömer Seyfettin Hikayelerinden Seçmeler','Ömer Seyfettin','Deneme',176),(8,1,'Küçük Ağa','Tarık Buğra','Deneme',477),(9,1,'Yaban','Yakup Kadri Karaosmanoğlu','Deneme',215),(10,1,'Ölü Canlar','Gogol','Örnek',484),(11,3,'Otuz Beş Yaş','Cahit Sıtkı Tarancı','Örnek',120),(12,3,'Safahat','Mehmet Akif Ersoy','Örnek',560),(13,3,'Çile','Necip Fazıl Kısakürek','Deneme',512),(14,3,'Bütün Şiirleri - Orhan Veli','Orhan Veli Kanık','Örnek',247),(15,4,'Anadolu Notları','Reşat Nuri Güntekin','Örnek',287),(16,4,'Seyahatname','Evliya Çelebi','Deneme',828),(17,1,'aaaa','bbbb','cccc',123);
/*!40000 ALTER TABLE `kitaplar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `odunc_kitaplar`
--

DROP TABLE IF EXISTS `odunc_kitaplar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `odunc_kitaplar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ogr_no` int NOT NULL,
  `kitap_id` int NOT NULL,
  `verilis_tarihi` date NOT NULL,
  `teslim_tarihi` date DEFAULT NULL,
  `aciklama` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id`,`ogr_no`,`kitap_id`),
  KEY `fk_odunc_kitaplar_ogrenciler1_idx` (`ogr_no`),
  KEY `fk_odunc_kitaplar_kitaplar1_idx` (`kitap_id`),
  CONSTRAINT `fk_odunc_kitaplar_kitaplar1` FOREIGN KEY (`kitap_id`) REFERENCES `kitaplar` (`kitap_id`),
  CONSTRAINT `fk_odunc_kitaplar_ogrenciler1` FOREIGN KEY (`ogr_no`) REFERENCES `ogrenciler` (`ogrenci_no`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `odunc_kitaplar`
--

LOCK TABLES `odunc_kitaplar` WRITE;
/*!40000 ALTER TABLE `odunc_kitaplar` DISABLE KEYS */;
INSERT INTO `odunc_kitaplar` VALUES (11,145,3,'2022-02-09',NULL,NULL),(12,222,2,'2022-02-09',NULL,NULL),(13,336,12,'2022-02-09',NULL,NULL),(14,555,11,'2022-02-16',NULL,NULL),(15,985,1,'2022-02-16',NULL,NULL),(16,411,6,'2022-02-16',NULL,NULL),(18,150,10,'2022-02-24',NULL,NULL),(19,344,8,'2022-02-18',NULL,NULL);
/*!40000 ALTER TABLE `odunc_kitaplar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ogrenciler`
--

DROP TABLE IF EXISTS `ogrenciler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ogrenciler` (
  `ogrenci_no` int NOT NULL,
  `ad` varchar(25) NOT NULL,
  `soyad` varchar(25) NOT NULL,
  `sinif` tinyint NOT NULL,
  `cinsiyet` varchar(7) NOT NULL,
  `telefon` varchar(12) NOT NULL,
  PRIMARY KEY (`ogrenci_no`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ogrenciler`
--

LOCK TABLES `ogrenciler` WRITE;
/*!40000 ALTER TABLE `ogrenciler` DISABLE KEYS */;
INSERT INTO `ogrenciler` VALUES (17,'add','add',12,'Erkek','55555'),(145,'Esat','E.',11,'Erkek','65845847'),(150,'Emirhan','Ç.',11,'Erkek','5894120'),(188,'Ali','K.',9,'Erkek','111111555'),(222,'Zeynep','Ö.',10,'Kız','588999666'),(336,'Murat','T.',11,'Erkek','111111741'),(344,'Esra','Ö.',10,'Kız','584269851'),(411,'Samet','K.',10,'Erkek','222222555'),(460,'Yakup','B.',11,'Erkek','85962547'),(461,'Serpil','K.',9,'Kız','999888888'),(555,'Ayşe','C.',11,'Kız','854159874'),(763,'Serhat','E.',12,'Erkek','888555444'),(985,'Mehmet','D.',12,'Erkek','25874125'),(11111,'aaaaaaaaaa','bbbbbbbbbbb',12,'Erkek','5555555555');
/*!40000 ALTER TABLE `ogrenciler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-05  8:24:16
