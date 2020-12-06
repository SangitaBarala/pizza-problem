-- MySQL dump 10.13  Distrib 8.0.21, for Win64 (x86_64)
--
-- Host: localhost    Database: pizzashop
-- ------------------------------------------------------
-- Server version	5.7.31-log

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
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `size` varchar(45) NOT NULL,
  `crust` varchar(45) NOT NULL,
  `topping` varchar(45) NOT NULL,
  `extra` varchar(45) NOT NULL,
  `total` double DEFAULT NULL,
  `tax` double DEFAULT NULL,
  `grandTotal` double DEFAULT NULL,
  `created_at` datetime DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'small','Thick','Olives','Fries',0,NULL,NULL,'2020-12-04 18:02:43','2020-12-04 18:02:43'),(2,'small','Thick','Pineapple','Pasta',0,NULL,NULL,'2020-12-04 18:02:43','2020-12-04 18:02:43'),(3,'Large','Thin','Bacon','Pasta',0,0,0,'2020-12-04 19:56:56','2020-12-04 19:56:56'),(4,'Medium','Thin','Bacon','Garlic Bread',0,0,0,'2020-12-04 20:07:11','2020-12-04 20:07:11'),(5,'Large','Thick','Bacon, Green Pepper, ','Chicken Wings, Garlic bread, ',0,0,0,'2020-12-04 20:15:14','2020-12-04 20:15:14'),(6,'small','Thick','Olives, Green Pepper, Bacon, Sausage, ','Fries, Chicken Wings, ',0,0,0,'2020-12-04 20:33:02','2020-12-04 20:33:02'),(7,'small','Thin','Green Pepper, Sausage, ','can of pop, Fries, ',0,0,0,'2020-12-04 20:38:09','2020-12-04 20:38:09'),(8,'Medium','Thick','Bacon, Sausage, ','Garlic bread, Chicken Wings, ',30,3.9,33.9,'2020-12-04 20:40:57','2020-12-04 20:40:57'),(9,'Medium','Thin','Pineapple, Bacon, ','Chicken Wings, Fries, ',27,3.51,30.51,'2020-12-04 20:52:28','2020-12-04 20:52:28'),(10,'small','Thick','Onion, Olives, ','Pasta, Chicken Wings, pop, ',22,2.86,24.86,'2020-12-04 21:05:14','2020-12-04 21:05:14');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `created_at` datetime DEFAULT CURRENT_TIMESTAMP,
  `updated_at` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'sangita','sangita@gmail.com','sangi1234','2020-11-27 14:27:54','2020-11-27 14:27:54'),(2,'ajay','ajay@gmail.com','ajay1234','2020-11-27 18:09:57','2020-11-27 18:09:57'),(3,'sam','sam@gmail.com','1234','2020-12-03 19:27:12','2020-12-03 19:27:12');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-12-06 17:00:13
