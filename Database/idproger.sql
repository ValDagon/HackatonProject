-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jun 12, 2020 at 01:12 PM
-- Server version: 5.7.24
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `idproger`
--

-- --------------------------------------------------------

--
-- Table structure for table `main_applications`
--

CREATE TABLE `main_applications` (
  `id_applications` int(11) NOT NULL,
  `id_organizations` int(11) NOT NULL,
  `id_client` int(11) NOT NULL,
  `text_applications` varchar(250) NOT NULL,
  `filing_date` date NOT NULL,
  `status_applications` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `main_client`
--

CREATE TABLE `main_client` (
  `id_client` int(11) NOT NULL,
  `name` varchar(25) NOT NULL,
  `surname` varchar(25) NOT NULL,
  `middleName` varchar(25) NOT NULL,
  `apartment` int(11) NOT NULL,
  `home` int(11) NOT NULL,
  `street` varchar(32) NOT NULL,
  `city` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `main_counters`
--

CREATE TABLE `main_counters` (
  `id_counter` int(11) NOT NULL,
  `id_client` int(11) NOT NULL,
  `id_organizations` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `main_finance`
--

CREATE TABLE `main_finance` (
  `id_payment` int(11) NOT NULL,
  `id_client` int(11) NOT NULL,
  `id_organizations` int(11) NOT NULL,
  `id_services` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `main_information`
--

CREATE TABLE `main_information` (
  `id_organizations` int(11) NOT NULL,
  `name` varchar(32) NOT NULL,
  `city` varchar(32) NOT NULL,
  `numHouses` int(11) NOT NULL,
  `address` varchar(50) NOT NULL,
  `telephone` decimal(20,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `main_information`
--

INSERT INTO `main_information` (`id_organizations`, `name`, `city`, `numHouses`, `address`, `telephone`) VALUES
(1, 'УК «УКХ РЭС №2»', 'Новотроицк', 91, 'ул. Советская, д. 66', '83537679356'),
(2, 'sdfsadf', 'sdfsdf', 23, 'dfdsfs', '12323'),
(3, 'sdfasdf', 'sdfsdfas', 32, 'sdfasdf', '435345');

-- --------------------------------------------------------

--
-- Table structure for table `main_services`
--

CREATE TABLE `main_services` (
  `id_services` int(11) NOT NULL,
  `id_property` int(11) NOT NULL,
  `id_organizations` int(11) NOT NULL,
  `id_client` int(11) NOT NULL,
  `com_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `property_counters`
--

CREATE TABLE `property_counters` (
  `id_counter` int(11) NOT NULL,
  `view_counter` varchar(20) NOT NULL,
  `indicator_counter` int(11) NOT NULL,
  `date_counter` date NOT NULL,
  `indicator_counter_past_month` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `property_services`
--

CREATE TABLE `property_services` (
  `id_property` int(11) NOT NULL,
  `title` varchar(25) NOT NULL,
  `price` int(11) NOT NULL,
  `ser_description` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `main_applications`
--
ALTER TABLE `main_applications`
  ADD PRIMARY KEY (`id_applications`),
  ADD KEY `id_client` (`id_client`),
  ADD KEY `main_applications_ibfk_1` (`id_organizations`);

--
-- Indexes for table `main_client`
--
ALTER TABLE `main_client`
  ADD PRIMARY KEY (`id_client`);

--
-- Indexes for table `main_counters`
--
ALTER TABLE `main_counters`
  ADD PRIMARY KEY (`id_counter`),
  ADD KEY `id_client` (`id_client`),
  ADD KEY `id_organizations` (`id_organizations`);

--
-- Indexes for table `main_finance`
--
ALTER TABLE `main_finance`
  ADD PRIMARY KEY (`id_payment`),
  ADD KEY `id_client` (`id_client`),
  ADD KEY `id_organizations` (`id_organizations`),
  ADD KEY `id_services` (`id_services`);

--
-- Indexes for table `main_information`
--
ALTER TABLE `main_information`
  ADD PRIMARY KEY (`id_organizations`);

--
-- Indexes for table `main_services`
--
ALTER TABLE `main_services`
  ADD PRIMARY KEY (`id_services`),
  ADD KEY `id_client` (`id_client`),
  ADD KEY `id_organizations` (`id_organizations`),
  ADD KEY `id_property` (`id_property`);

--
-- Indexes for table `property_counters`
--
ALTER TABLE `property_counters`
  ADD PRIMARY KEY (`id_counter`);

--
-- Indexes for table `property_services`
--
ALTER TABLE `property_services`
  ADD PRIMARY KEY (`id_property`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `main_applications`
--
ALTER TABLE `main_applications`
  ADD CONSTRAINT `main_applications_ibfk_1` FOREIGN KEY (`id_organizations`) REFERENCES `main_information` (`id_organizations`),
  ADD CONSTRAINT `main_applications_ibfk_2` FOREIGN KEY (`id_client`) REFERENCES `main_client` (`id_client`);

--
-- Constraints for table `main_counters`
--
ALTER TABLE `main_counters`
  ADD CONSTRAINT `main_counters_ibfk_1` FOREIGN KEY (`id_client`) REFERENCES `main_client` (`id_client`),
  ADD CONSTRAINT `main_counters_ibfk_2` FOREIGN KEY (`id_organizations`) REFERENCES `main_information` (`id_organizations`),
  ADD CONSTRAINT `main_counters_ibfk_3` FOREIGN KEY (`id_counter`) REFERENCES `property_counters` (`id_counter`);

--
-- Constraints for table `main_finance`
--
ALTER TABLE `main_finance`
  ADD CONSTRAINT `main_finance_ibfk_1` FOREIGN KEY (`id_client`) REFERENCES `main_client` (`id_client`),
  ADD CONSTRAINT `main_finance_ibfk_2` FOREIGN KEY (`id_organizations`) REFERENCES `main_information` (`id_organizations`),
  ADD CONSTRAINT `main_finance_ibfk_3` FOREIGN KEY (`id_services`) REFERENCES `main_services` (`id_services`);

--
-- Constraints for table `main_services`
--
ALTER TABLE `main_services`
  ADD CONSTRAINT `main_services_ibfk_1` FOREIGN KEY (`id_client`) REFERENCES `main_client` (`id_client`),
  ADD CONSTRAINT `main_services_ibfk_2` FOREIGN KEY (`id_organizations`) REFERENCES `main_applications` (`id_applications`),
  ADD CONSTRAINT `main_services_ibfk_3` FOREIGN KEY (`id_property`) REFERENCES `property_services` (`id_property`),
  ADD CONSTRAINT `main_services_ibfk_4` FOREIGN KEY (`id_services`) REFERENCES `property_services` (`id_property`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
