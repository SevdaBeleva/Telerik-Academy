CREATE DATABASE  IF NOT EXISTS `university_db` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `university_db`;
-- MySQL dump 10.13  Distrib 5.5.16, for Win32 (x86)
--
-- Host: localhost    Database: university_db
-- ------------------------------------------------------
-- Server version	5.5.32

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
-- Table structure for table `courses`
--

DROP TABLE IF EXISTS `courses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `courses` (
  `course_id` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `Departments_department_id` int(11) NOT NULL,
  `Professors_professor_id` int(11) NOT NULL,
  PRIMARY KEY (`course_id`),
  KEY `fk_Courses_Departments1_idx` (`Departments_department_id`),
  KEY `fk_Courses_Professors1_idx` (`Professors_professor_id`),
  CONSTRAINT `fk_Courses_Departments1` FOREIGN KEY (`Departments_department_id`) REFERENCES `departments` (`department_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Courses_Professors1` FOREIGN KEY (`Professors_professor_id`) REFERENCES `professors` (`professor_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses`
--

LOCK TABLES `courses` WRITE;
/*!40000 ALTER TABLE `courses` DISABLE KEYS */;
INSERT INTO `courses` VALUES (1,'Chemistry',3,1),(2,'C#',4,3),(3,'History of traditional and modern societies',1,2);
/*!40000 ALTER TABLE `courses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `courses_has_students`
--

DROP TABLE IF EXISTS `courses_has_students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `courses_has_students` (
  `Courses_course_id` int(11) NOT NULL,
  `Students_student_id` varchar(10) NOT NULL,
  PRIMARY KEY (`Courses_course_id`,`Students_student_id`),
  KEY `fk_Courses_has_Students_Students1_idx` (`Students_student_id`),
  KEY `fk_Courses_has_Students_Courses1_idx` (`Courses_course_id`),
  CONSTRAINT `fk_Courses_has_Students_Courses1` FOREIGN KEY (`Courses_course_id`) REFERENCES `courses` (`course_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Courses_has_Students_Students1` FOREIGN KEY (`Students_student_id`) REFERENCES `students` (`student_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `courses_has_students`
--

LOCK TABLES `courses_has_students` WRITE;
/*!40000 ALTER TABLE `courses_has_students` DISABLE KEYS */;
INSERT INTO `courses_has_students` VALUES (1,'10122345'),(1,'1234656676'),(1,'12SDR1243');
/*!40000 ALTER TABLE `courses_has_students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departments`
--

DROP TABLE IF EXISTS `departments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departments` (
  `department_id` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `Faculties_faculty_id` int(11) NOT NULL,
  PRIMARY KEY (`department_id`),
  KEY `fk_Departments_Faculties1_idx` (`Faculties_faculty_id`),
  CONSTRAINT `fk_Departments_Faculties1` FOREIGN KEY (`Faculties_faculty_id`) REFERENCES `faculties` (`faculty_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departments`
--

LOCK TABLES `departments` WRITE;
/*!40000 ALTER TABLE `departments` DISABLE KEYS */;
INSERT INTO `departments` VALUES (1,'History',1),(2,'Philosophy',1),(3,'Chemistry',2),(4,'Programming languages',3);
/*!40000 ALTER TABLE `departments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faculties`
--

DROP TABLE IF EXISTS `faculties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `faculties` (
  `faculty_id` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`faculty_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faculties`
--

LOCK TABLES `faculties` WRITE;
/*!40000 ALTER TABLE `faculties` DISABLE KEYS */;
INSERT INTO `faculties` VALUES (1,'History and Philosophy'),(2,'Science'),(3,'Mahtematics and Informatics');
/*!40000 ALTER TABLE `faculties` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `professors`
--

DROP TABLE IF EXISTS `professors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `professors` (
  `professor_id` int(11) NOT NULL,
  `title_id` varchar(45) DEFAULT NULL,
  `first_name` varchar(45) DEFAULT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`professor_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `professors`
--

LOCK TABLES `professors` WRITE;
/*!40000 ALTER TABLE `professors` DISABLE KEYS */;
INSERT INTO `professors` VALUES (1,'1','Georgi','Vladkov'),(2,'2','Stoyan','Smitkov'),(3,'3','Simeon','Aleksiev');
/*!40000 ALTER TABLE `professors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `students` (
  `student_id` varchar(10) NOT NULL,
  `first_name` varchar(45) DEFAULT NULL,
  `last_name` varchar(45) DEFAULT NULL,
  `Faculties_faculty_id` int(11) NOT NULL,
  PRIMARY KEY (`student_id`),
  KEY `fk_Students_Faculties_idx` (`Faculties_faculty_id`),
  CONSTRAINT `fk_Students_Faculties` FOREIGN KEY (`Faculties_faculty_id`) REFERENCES `faculties` (`faculty_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES ('10122345','Ivan','Todorov',1),('1234656676','Panaiotka','Veselova',2),('12SDR1243','Stoyan','Pancherev',1),('4567891234','Georgi','Radev',3);
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students_has_courses`
--

DROP TABLE IF EXISTS `students_has_courses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `students_has_courses` (
  `Students_student_id` varchar(10) NOT NULL,
  `Courses_course_id` int(11) NOT NULL,
  PRIMARY KEY (`Students_student_id`,`Courses_course_id`),
  KEY `fk_Students_has_Courses_Courses1_idx` (`Courses_course_id`),
  KEY `fk_Students_has_Courses_Students1_idx` (`Students_student_id`),
  CONSTRAINT `fk_Students_has_Courses_Students1` FOREIGN KEY (`Students_student_id`) REFERENCES `students` (`student_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Students_has_Courses_Courses1` FOREIGN KEY (`Courses_course_id`) REFERENCES `courses` (`course_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students_has_courses`
--

LOCK TABLES `students_has_courses` WRITE;
/*!40000 ALTER TABLE `students_has_courses` DISABLE KEYS */;
INSERT INTO `students_has_courses` VALUES ('12SDR1243',1),('12SDR1243',2);
/*!40000 ALTER TABLE `students_has_courses` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `titles`
--

DROP TABLE IF EXISTS `titles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `titles` (
  `title_id` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `Professors_professor_id` int(11) NOT NULL,
  PRIMARY KEY (`title_id`),
  KEY `fk_Titles_Professors1_idx` (`Professors_professor_id`),
  CONSTRAINT `fk_Titles_Professors1` FOREIGN KEY (`Professors_professor_id`) REFERENCES `professors` (`professor_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `titles`
--

LOCK TABLES `titles` WRITE;
/*!40000 ALTER TABLE `titles` DISABLE KEYS */;
INSERT INTO `titles` VALUES (1,'Phd',1),(2,'Junior Assistant',2),(3,'Senior Assistant',3);
/*!40000 ALTER TABLE `titles` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2013-07-13 20:23:33
