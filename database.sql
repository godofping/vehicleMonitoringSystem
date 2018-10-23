/*
SQLyog Ultimate v8.53 
MySQL - 5.5.5-10.1.36-MariaDB : Database - new_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`new_db` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `new_db`;

/*Table structure for table `admin_table` */

DROP TABLE IF EXISTS `admin_table`;

CREATE TABLE `admin_table` (
  `adminId` int(6) NOT NULL AUTO_INCREMENT,
  `userName` varchar(60) DEFAULT NULL,
  `passWord` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`adminId`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `admin_table` */

LOCK TABLES `admin_table` WRITE;

insert  into `admin_table`(`adminId`,`userName`,`passWord`) values (1,'admin','admin');

UNLOCK TABLES;

/*Table structure for table `log_table` */

DROP TABLE IF EXISTS `log_table`;

CREATE TABLE `log_table` (
  `logId` int(6) NOT NULL AUTO_INCREMENT,
  `vehicleId` int(6) DEFAULT NULL,
  `dateAndTime` datetime DEFAULT NULL,
  `inOrOut` tinyint(1) DEFAULT NULL,
  `isConfirmed` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`logId`),
  KEY `FK_log_table123` (`vehicleId`),
  CONSTRAINT `FK_log_table123` FOREIGN KEY (`vehicleId`) REFERENCES `vehicle_table` (`vehicleId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `log_table` */

LOCK TABLES `log_table` WRITE;

UNLOCK TABLES;

/*Table structure for table `personel_table` */

DROP TABLE IF EXISTS `personel_table`;

CREATE TABLE `personel_table` (
  `personelId` int(6) NOT NULL AUTO_INCREMENT,
  `personelType` varchar(60) DEFAULT NULL,
  `position` varchar(60) DEFAULT NULL,
  `profileId` int(6) DEFAULT NULL,
  PRIMARY KEY (`personelId`),
  KEY `FK_personel_table` (`profileId`),
  CONSTRAINT `FK_personel_table` FOREIGN KEY (`profileId`) REFERENCES `profile_table` (`profileId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `personel_table` */

LOCK TABLES `personel_table` WRITE;

UNLOCK TABLES;

/*Table structure for table `profile_table` */

DROP TABLE IF EXISTS `profile_table`;

CREATE TABLE `profile_table` (
  `profileId` int(6) NOT NULL AUTO_INCREMENT,
  `firstName` varchar(60) DEFAULT NULL,
  `middleName` varchar(60) DEFAULT NULL,
  `lastName` varchar(60) DEFAULT NULL,
  `gender` varchar(60) DEFAULT NULL,
  `contactNumber` varchar(60) DEFAULT NULL,
  `role` varchar(60) DEFAULT NULL,
  `dateRegistered` date DEFAULT NULL,
  `imageLocation` text,
  `isDeleted` tinyint(1) DEFAULT NULL,
  `birthDay` date DEFAULT NULL,
  PRIMARY KEY (`profileId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `profile_table` */

LOCK TABLES `profile_table` WRITE;

UNLOCK TABLES;

/*Table structure for table `student_table` */

DROP TABLE IF EXISTS `student_table`;

CREATE TABLE `student_table` (
  `studentId` int(6) NOT NULL AUTO_INCREMENT,
  `course` varchar(60) DEFAULT NULL,
  `collegeYearLevel` varchar(60) DEFAULT NULL,
  `strand` varchar(60) DEFAULT NULL,
  `gradeLevel` varchar(60) DEFAULT NULL,
  `profileId` int(6) DEFAULT NULL,
  `department` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`studentId`),
  KEY `FK_student_table` (`profileId`),
  CONSTRAINT `FK_student_table` FOREIGN KEY (`profileId`) REFERENCES `profile_table` (`profileId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `student_table` */

LOCK TABLES `student_table` WRITE;

UNLOCK TABLES;

/*Table structure for table `vehicle_table` */

DROP TABLE IF EXISTS `vehicle_table`;

CREATE TABLE `vehicle_table` (
  `vehicleId` int(6) NOT NULL AUTO_INCREMENT,
  `profileId` int(6) DEFAULT NULL,
  `model` varchar(60) DEFAULT NULL,
  `or` varchar(60) DEFAULT NULL,
  `cr` varchar(60) DEFAULT NULL,
  `plateNumber` varchar(60) DEFAULT NULL,
  `startingValidDate` date DEFAULT NULL,
  `endingValidDate` date DEFAULT NULL,
  `stickerNumber` int(3) DEFAULT NULL,
  `isDeleted` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`vehicleId`),
  KEY `FK_vehicle_table` (`profileId`),
  CONSTRAINT `FK_vehicle_table` FOREIGN KEY (`profileId`) REFERENCES `profile_table` (`profileId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `vehicle_table` */

LOCK TABLES `vehicle_table` WRITE;

UNLOCK TABLES;

/*Table structure for table `visitor_table` */

DROP TABLE IF EXISTS `visitor_table`;

CREATE TABLE `visitor_table` (
  `visitorId` int(6) NOT NULL AUTO_INCREMENT,
  `profileId` int(6) DEFAULT NULL,
  PRIMARY KEY (`visitorId`),
  KEY `FK_visitor_table` (`profileId`),
  CONSTRAINT `FK_visitor_table` FOREIGN KEY (`profileId`) REFERENCES `profile_table` (`profileId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `visitor_table` */

LOCK TABLES `visitor_table` WRITE;

UNLOCK TABLES;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
