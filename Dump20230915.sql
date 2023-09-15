CREATE DATABASE  IF NOT EXISTS `quiz` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `quiz`;
-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: localhost    Database: quiz
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
-- Table structure for table `__efmigrationshistory`
--

DROP TABLE IF EXISTS `__efmigrationshistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__efmigrationshistory`
--

LOCK TABLES `__efmigrationshistory` WRITE;
/*!40000 ALTER TABLE `__efmigrationshistory` DISABLE KEYS */;
INSERT INTO `__efmigrationshistory` VALUES ('20230911190342_Initial-Migrate','7.0.5'),('20230911191410_Create-Quiz-Tables','7.0.5'),('20230912064454_KeyRemoval-InitialSeeding','7.0.5'),('20230912064840_EditSeeding','7.0.5'),('20230912185202_EditDBStructure','7.0.5'),('20230912185738_EditDBTestResult','7.0.5'),('20230912191030_EditDBTestResult-RemovePercentage-AddedIntsAnswers','7.0.5');
/*!40000 ALTER TABLE `__efmigrationshistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `answers`
--

DROP TABLE IF EXISTS `answers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `answers` (
  `AnswerId` int NOT NULL AUTO_INCREMENT,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `IsRightAnswer` tinyint(1) NOT NULL,
  `QuestionId` int NOT NULL,
  PRIMARY KEY (`AnswerId`),
  KEY `IX_Answers_QuestionId` (`QuestionId`),
  CONSTRAINT `FK_Answers_Questions_QuestionId` FOREIGN KEY (`QuestionId`) REFERENCES `questions` (`QuestionId`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `answers`
--

LOCK TABLES `answers` WRITE;
/*!40000 ALTER TABLE `answers` DISABLE KEYS */;
INSERT INTO `answers` VALUES (1,'17',0,3),(2,'21',0,3),(3,'25',1,3),(5,'Best of 3',0,4),(6,'Best of 5',1,4),(7,'Best of 7',0,4),(8,'8x8',0,1),(9,'9x9',1,1),(10,'7x7',0,1),(11,'Yes',1,2),(12,'No',0,2),(13,'Monte Carlo',1,5),(14,'Rome',0,5),(15,'Budapest',0,5),(16,'Red Bull Racing',1,6),(17,'Aston Martin',0,6),(18,'Sauber',0,6),(19,'Valtteri Bottas',0,8),(20,'Kimi Räikkönen',1,8),(21,'Halo',1,7),(22,'Fuel sensor',0,7),(23,'10080',1,9),(24,'10820',0,9),(25,'11800',0,9),(26,'118',1,10),(27,'120',0,10),(28,'3',1,11),(29,'4',0,11),(30,'5',0,11),(31,'16',0,12),(32,'20',0,12),(33,'12',1,12);
/*!40000 ALTER TABLE `answers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `questions`
--

DROP TABLE IF EXISTS `questions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `questions` (
  `QuestionId` int NOT NULL AUTO_INCREMENT,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `TestId` int NOT NULL,
  PRIMARY KEY (`QuestionId`),
  KEY `IX_Questions_TestId` (`TestId`),
  CONSTRAINT `FK_Questions_Tests_TestId` FOREIGN KEY (`TestId`) REFERENCES `tests` (`TestId`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `questions`
--

LOCK TABLES `questions` WRITE;
/*!40000 ALTER TABLE `questions` DISABLE KEYS */;
INSERT INTO `questions` VALUES (1,'How large is a volleyball court?',1),(2,'Can you touch the ball with your feet?',1),(3,'How many points does a set have?',1),(4,'What is the winning formula in a standard match??',1),(5,'Which city hosts the Monaco Grand Prix?',2),(6,'Which F1 constructor is based in Milton Keynes, England?',2),(7,'What is the name of the F1 car\'s protective structure that is designed to protect the driver\'s head in the event of an accident?',2),(8,'“The Iceman” is the nickname given to which Finnish Formula 1 World Champion??',2),(9,'How many minutes are in a full week?',3),(10,'How many elements are in the periodic table?',3),(11,'How many bones do we have in an ear?',3),(12,'How many faces does a Dodecahedron have?',3);
/*!40000 ALTER TABLE `questions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `testresults`
--

DROP TABLE IF EXISTS `testresults`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `testresults` (
  `TestResultId` int NOT NULL AUTO_INCREMENT,
  `UserId` int NOT NULL,
  `TestId` int NOT NULL,
  `TestDate` datetime(6) DEFAULT NULL,
  `RightAnswers` int NOT NULL DEFAULT '0',
  `TotalAnswers` int NOT NULL DEFAULT '0',
  PRIMARY KEY (`TestResultId`),
  KEY `IX_TestResults_TestId` (`TestId`),
  KEY `IX_TestResults_UserId` (`UserId`),
  CONSTRAINT `FK_TestResults_Tests_TestId` FOREIGN KEY (`TestId`) REFERENCES `tests` (`TestId`) ON DELETE RESTRICT,
  CONSTRAINT `FK_TestResults_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`UserId`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `testresults`
--

LOCK TABLES `testresults` WRITE;
/*!40000 ALTER TABLE `testresults` DISABLE KEYS */;
INSERT INTO `testresults` VALUES (1,1,1,'2023-09-12 21:12:21.000000',2,4);
/*!40000 ALTER TABLE `testresults` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tests`
--

DROP TABLE IF EXISTS `tests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tests` (
  `TestId` int NOT NULL AUTO_INCREMENT,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`TestId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tests`
--

LOCK TABLES `tests` WRITE;
/*!40000 ALTER TABLE `tests` DISABLE KEYS */;
INSERT INTO `tests` VALUES (1,'Volleyball'),(2,'Formula 1'),(3,'Numbers');
/*!40000 ALTER TABLE `tests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `UserId` int NOT NULL AUTO_INCREMENT,
  `UserName` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`UserId`),
  UNIQUE KEY `IX_Users_UserName` (`UserName`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Alessia'),(2,'Luigi');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usertestquestionanswers`
--

DROP TABLE IF EXISTS `usertestquestionanswers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usertestquestionanswers` (
  `UserTestQuestionAnswerId` int NOT NULL AUTO_INCREMENT,
  `TestResultId` int NOT NULL,
  `QuestionId` int NOT NULL,
  `AnswerId` int NOT NULL,
  `AnswerDate` datetime(6) NOT NULL DEFAULT '0001-01-01 00:00:00.000000',
  PRIMARY KEY (`UserTestQuestionAnswerId`),
  KEY `IX_UserTestQuestionAnswers_AnswerId` (`AnswerId`),
  KEY `IX_UserTestQuestionAnswers_QuestionId` (`QuestionId`),
  KEY `IX_UserTestQuestionAnswers_TestResultId` (`TestResultId`),
  CONSTRAINT `FK_UserTestQuestionAnswers_Answers_AnswerId` FOREIGN KEY (`AnswerId`) REFERENCES `answers` (`AnswerId`) ON DELETE RESTRICT,
  CONSTRAINT `FK_UserTestQuestionAnswers_Questions_QuestionId` FOREIGN KEY (`QuestionId`) REFERENCES `questions` (`QuestionId`) ON DELETE RESTRICT,
  CONSTRAINT `FK_UserTestQuestionAnswers_TestResults_TestResultId` FOREIGN KEY (`TestResultId`) REFERENCES `testresults` (`TestResultId`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usertestquestionanswers`
--

LOCK TABLES `usertestquestionanswers` WRITE;
/*!40000 ALTER TABLE `usertestquestionanswers` DISABLE KEYS */;
INSERT INTO `usertestquestionanswers` VALUES (1,1,1,8,'2023-09-12 19:01:04.274563'),(2,1,2,11,'2023-09-12 19:01:21.297615'),(3,1,3,3,'2023-09-12 19:01:38.170009'),(4,1,4,7,'2023-09-12 19:01:50.571850');
/*!40000 ALTER TABLE `usertestquestionanswers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-09-15 11:11:05
