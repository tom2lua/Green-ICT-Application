-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2017 at 11:52 PM
-- Server version: 10.1.26-MariaDB
-- PHP Version: 7.1.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `green_ict_application`
--

-- --------------------------------------------------------

--
-- Table structure for table `appointment`
--

CREATE TABLE `appointment` (
  `appointment_id` int(11) NOT NULL,
  `ref_client` int(11) DEFAULT NULL,
  `ref_emp` int(11) NOT NULL,
  `description` longtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `appointment`
--

INSERT INTO `appointment` (`appointment_id`, `ref_client`, `ref_emp`, `description`) VALUES
(4, 7, 4, 'Exchange Information;Fell_320;12/04/2017;10:30:00'),
(5, 8, 5, 'Military Recruitment;Niemi_330;12/26/2017;13:30:00 - 13:45:00 - 14:00:00 - 14:15:00'),
(6, 7, 3, 'BeatBox Class;Niemi_B202;12/12/2017;02:30:00 - 02:45:00'),
(7, 7, 5, 'Military Recruitment;Niemi_330;12/26/2017;17:00:00 - 17:15:00 - 17:30:00 - 17:45:00');

-- --------------------------------------------------------

--
-- Table structure for table `appointment_place`
--

CREATE TABLE `appointment_place` (
  `appointment_place_id` int(11) NOT NULL,
  `ref_user_emp` int(11) DEFAULT NULL,
  `appointment_place` varchar(20) DEFAULT NULL,
  `appointment_room` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `appointment_place`
--

INSERT INTO `appointment_place` (`appointment_place_id`, `ref_user_emp`, `appointment_place`, `appointment_room`) VALUES
(1, 3, 'Fell', '505'),
(2, 3, 'Niemi', 'B202'),
(3, 4, 'Fell', '320'),
(4, NULL, 'Stalh', 'E308'),
(5, NULL, 'Niemi', '101'),
(6, NULL, 'Stalh', 'E205'),
(7, 5, 'Niemi', '330'),
(10, NULL, 'Fell', '506'),
(11, NULL, 'Kive', '51C'),
(12, NULL, 'Niemi ', 'C400');

-- --------------------------------------------------------

--
-- Table structure for table `appointment_product`
--

CREATE TABLE `appointment_product` (
  `appointment_product_id` int(11) NOT NULL,
  `ref_user_emp` int(11) DEFAULT NULL,
  `appointment_product_name` varchar(100) DEFAULT NULL,
  `appoint_duration` time DEFAULT NULL,
  `ref_appointment_place` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `appointment_product`
--

INSERT INTO `appointment_product` (`appointment_product_id`, `ref_user_emp`, `appointment_product_name`, `appoint_duration`, `ref_appointment_place`) VALUES
(1, 3, 'BeatBox Class', '01:00:00', 1),
(2, 3, 'BeatBox Class', '00:30:00', 2),
(3, 3, 'WPF Instruction', '01:30:00', 2),
(4, 4, 'Exchange Information', '01:15:00', 3),
(5, 4, 'Insurance', '00:30:00', 5),
(6, 4, 'Insurance', '01:00:00', 6),
(7, 5, 'Military Recruitment', '00:50:00', 7),
(8, 5, 'Study Counsel', '01:10:00', 5),
(10, 3, 'Say hello to the world', '01:00:00', 5);

-- --------------------------------------------------------

--
-- Table structure for table `user_emp_time`
--

CREATE TABLE `user_emp_time` (
  `time_id` int(11) NOT NULL,
  `ref_user_emp` int(11) DEFAULT NULL,
  `date` date NOT NULL,
  `start_time` time NOT NULL,
  `end_time` time NOT NULL,
  `slot_status` char(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_emp_time`
--

INSERT INTO `user_emp_time` (`time_id`, `ref_user_emp`, `date`, `start_time`, `end_time`, `slot_status`) VALUES
(75, 3, '2017-11-30', '14:45:00', '15:00:00', 'free'),
(76, 3, '2017-11-30', '15:00:00', '15:15:00', 'free'),
(77, 3, '2017-11-30', '15:15:00', '15:30:00', 'taken'),
(78, 3, '2017-11-30', '15:30:00', '15:45:00', 'free'),
(79, 3, '2017-11-30', '15:45:00', '16:00:00', 'free'),
(80, 3, '2017-11-30', '16:00:00', '16:15:00', 'free'),
(81, 3, '2017-11-30', '16:15:00', '16:30:00', 'free'),
(82, 3, '2017-11-30', '16:30:00', '16:45:00', 'free'),
(83, 3, '2017-11-30', '16:45:00', '17:00:00', 'free'),
(84, 3, '2017-12-05', '12:00:00', '12:15:00', 'free'),
(85, 3, '2017-12-05', '12:15:00', '12:30:00', 'free'),
(86, 3, '2017-12-05', '12:30:00', '12:45:00', 'free'),
(87, 3, '2017-12-05', '12:45:00', '13:00:00', 'free'),
(88, 3, '2017-12-05', '13:00:00', '13:15:00', 'free'),
(89, 3, '2017-12-05', '13:15:00', '13:30:00', 'free'),
(90, 3, '2017-12-05', '13:30:00', '13:45:00', 'free'),
(91, 3, '2017-12-05', '13:45:00', '14:00:00', 'free'),
(92, 3, '2017-12-05', '14:00:00', '14:15:00', 'free'),
(93, 3, '2017-12-05', '14:15:00', '14:30:00', 'free'),
(94, 3, '2017-12-05', '14:30:00', '14:45:00', 'free'),
(95, 3, '2017-12-05', '14:45:00', '15:00:00', 'free'),
(96, 3, '2017-12-05', '15:00:00', '15:15:00', 'free'),
(97, 3, '2017-12-05', '15:15:00', '15:30:00', 'taken'),
(98, 3, '2017-12-05', '15:30:00', '15:45:00', 'free'),
(99, 3, '2017-12-05', '15:45:00', '16:00:00', 'free'),
(100, 3, '2017-12-05', '16:00:00', '16:15:00', 'free'),
(101, 3, '2017-12-05', '16:15:00', '16:30:00', 'free'),
(102, 3, '2017-12-05', '16:30:00', '16:45:00', 'free'),
(103, 3, '2017-12-05', '16:45:00', '17:00:00', 'free'),
(104, 4, '2017-12-04', '10:00:00', '10:15:00', 'free'),
(105, 4, '2017-12-04', '10:15:00', '10:30:00', 'free'),
(106, 4, '2017-12-04', '10:30:00', '10:45:00', 'taken'),
(107, 4, '2017-12-04', '10:45:00', '11:00:00', 'free'),
(108, 4, '2017-12-04', '11:00:00', '11:15:00', 'free'),
(109, 4, '2017-12-04', '11:15:00', '11:30:00', 'free'),
(110, 4, '2017-12-04', '11:30:00', '11:45:00', 'free'),
(111, 4, '2017-12-04', '11:45:00', '12:00:00', 'free'),
(112, 4, '2017-12-04', '12:00:00', '12:15:00', 'free'),
(113, 4, '2017-12-04', '12:15:00', '12:30:00', 'free'),
(114, 4, '2017-12-04', '12:30:00', '12:45:00', 'free'),
(115, 4, '2017-12-04', '12:45:00', '13:00:00', 'free'),
(116, 4, '2017-12-04', '13:00:00', '13:15:00', 'free'),
(117, 4, '2017-12-04', '13:15:00', '13:30:00', 'free'),
(118, 4, '2017-12-04', '13:30:00', '13:45:00', 'free'),
(119, 4, '2017-12-04', '13:45:00', '14:00:00', 'free'),
(120, 4, '2017-12-04', '14:00:00', '14:15:00', 'free'),
(121, 4, '2017-12-04', '14:15:00', '14:30:00', 'free'),
(122, 4, '2017-12-04', '14:30:00', '14:45:00', 'free'),
(123, 4, '2017-12-04', '14:45:00', '15:00:00', 'free'),
(124, 4, '2017-12-04', '15:00:00', '15:15:00', 'free'),
(125, 4, '2017-12-04', '15:15:00', '15:30:00', 'free'),
(126, 4, '2017-12-04', '15:30:00', '15:45:00', 'free'),
(127, 4, '2017-12-04', '15:45:00', '16:00:00', 'free'),
(128, 5, '2017-12-26', '13:30:00', '13:45:00', 'taken'),
(129, 5, '2017-12-26', '13:45:00', '14:00:00', 'taken'),
(130, 5, '2017-12-26', '14:00:00', '14:15:00', 'taken'),
(131, 5, '2017-12-26', '14:15:00', '14:30:00', 'taken'),
(132, 5, '2017-12-26', '14:30:00', '14:45:00', 'free'),
(133, 5, '2017-12-26', '14:45:00', '15:00:00', 'free'),
(134, 5, '2017-12-26', '15:00:00', '15:15:00', 'free'),
(135, 5, '2017-12-26', '15:15:00', '15:30:00', 'free'),
(136, 5, '2017-12-26', '15:30:00', '15:45:00', 'free'),
(137, 5, '2017-12-26', '15:45:00', '16:00:00', 'free'),
(138, 5, '2017-12-26', '16:00:00', '16:15:00', 'free'),
(139, 5, '2017-12-26', '16:15:00', '16:30:00', 'free'),
(140, 5, '2017-12-26', '16:30:00', '16:45:00', 'free'),
(141, 5, '2017-12-26', '16:45:00', '17:00:00', 'free'),
(142, 5, '2017-12-26', '17:00:00', '17:15:00', 'taken'),
(143, 5, '2017-12-26', '17:15:00', '17:30:00', 'taken'),
(144, 5, '2017-12-26', '17:30:00', '17:45:00', 'taken'),
(145, 5, '2017-12-26', '17:45:00', '18:00:00', 'taken'),
(146, 3, '2017-12-12', '01:15:00', '01:30:00', 'free'),
(147, 3, '2017-12-12', '01:30:00', '01:45:00', 'free'),
(148, 3, '2017-12-12', '01:45:00', '02:00:00', 'free'),
(149, 3, '2017-12-12', '02:00:00', '02:15:00', 'free'),
(150, 3, '2017-12-12', '02:15:00', '02:30:00', 'free'),
(151, 3, '2017-12-12', '02:30:00', '02:45:00', 'taken'),
(152, 3, '2017-12-12', '02:45:00', '03:00:00', 'taken'),
(153, 3, '2017-12-12', '03:00:00', '03:15:00', 'free'),
(154, 3, '2017-12-12', '03:15:00', '03:30:00', 'free'),
(155, 3, '2017-12-12', '03:30:00', '03:45:00', 'free'),
(156, 3, '2017-12-12', '03:45:00', '04:00:00', 'free'),
(157, 3, '2017-12-12', '04:00:00', '04:15:00', 'free'),
(158, 3, '2017-12-12', '04:15:00', '04:30:00', 'free'),
(159, 3, '2017-12-12', '04:30:00', '04:45:00', 'free'),
(160, 3, '2017-12-12', '04:45:00', '05:00:00', 'free'),
(161, 3, '2017-12-12', '05:00:00', '05:15:00', 'free'),
(162, 3, '2017-12-12', '05:15:00', '05:30:00', 'free'),
(163, 4, '2017-12-05', '02:30:00', '02:45:00', 'free'),
(164, 4, '2017-12-05', '02:45:00', '03:00:00', 'free'),
(165, 4, '2017-12-05', '03:00:00', '03:15:00', 'free'),
(166, 4, '2017-12-05', '03:15:00', '03:30:00', 'free'),
(167, 4, '2017-12-05', '03:30:00', '03:45:00', 'free'),
(168, 4, '2017-12-05', '03:45:00', '04:00:00', 'free'),
(169, 4, '2017-12-05', '04:00:00', '04:15:00', 'free'),
(170, 4, '2017-12-05', '04:15:00', '04:30:00', 'free'),
(171, 4, '2017-12-05', '04:30:00', '04:45:00', 'free'),
(172, 4, '2017-12-05', '04:45:00', '05:00:00', 'free'),
(173, 4, '2017-12-05', '05:00:00', '05:15:00', 'free'),
(174, 4, '2017-12-05', '05:15:00', '05:30:00', 'free'),
(175, 4, '2017-12-05', '05:30:00', '05:45:00', 'free'),
(176, 4, '2017-12-05', '05:45:00', '06:00:00', 'free'),
(177, 4, '2017-12-05', '06:00:00', '06:15:00', 'free'),
(178, 4, '2017-12-05', '06:15:00', '06:30:00', 'free'),
(179, 4, '2017-12-05', '06:30:00', '06:45:00', 'free'),
(180, 4, '2017-12-05', '06:45:00', '07:00:00', 'free'),
(181, 4, '2017-12-05', '07:00:00', '07:15:00', 'free'),
(182, 4, '2017-12-05', '07:15:00', '07:30:00', 'free'),
(183, 4, '2017-12-05', '07:30:00', '07:45:00', 'free'),
(184, 4, '2017-12-05', '07:45:00', '08:00:00', 'free'),
(185, 4, '2017-12-05', '08:00:00', '08:15:00', 'free'),
(186, 4, '2017-12-05', '08:15:00', '08:30:00', 'free'),
(187, 4, '2017-12-05', '08:30:00', '08:45:00', 'free'),
(188, 4, '2017-12-05', '08:45:00', '09:00:00', 'free'),
(189, 4, '2017-12-05', '09:00:00', '09:15:00', 'free'),
(190, 4, '2017-12-05', '09:15:00', '09:30:00', 'free'),
(191, 4, '2017-12-05', '09:30:00', '09:45:00', 'free'),
(192, 4, '2017-12-05', '09:45:00', '10:00:00', 'free'),
(193, 4, '2017-12-05', '10:00:00', '10:15:00', 'free'),
(194, 4, '2017-12-05', '10:15:00', '10:30:00', 'free'),
(195, 4, '2017-12-05', '10:30:00', '10:45:00', 'free'),
(196, 4, '2017-12-05', '10:45:00', '11:00:00', 'free'),
(197, 4, '2017-12-05', '11:00:00', '11:15:00', 'free'),
(198, 4, '2017-12-05', '11:15:00', '11:30:00', 'free'),
(199, 4, '2017-12-05', '11:30:00', '11:45:00', 'free'),
(200, 4, '2017-12-05', '11:45:00', '12:00:00', 'free'),
(201, 4, '2017-12-05', '17:00:00', '17:15:00', 'free'),
(202, 4, '2017-12-05', '17:15:00', '17:30:00', 'free'),
(203, 4, '2017-12-05', '17:30:00', '17:45:00', 'free'),
(204, 4, '2017-12-05', '17:45:00', '18:00:00', 'free'),
(205, 4, '2017-12-05', '18:00:00', '18:15:00', 'free'),
(206, 4, '2017-12-05', '18:15:00', '18:30:00', 'free'),
(207, 4, '2017-12-05', '18:30:00', '18:45:00', 'free'),
(208, 4, '2017-12-05', '18:45:00', '19:00:00', 'free');

-- --------------------------------------------------------

--
-- Table structure for table `user_table`
--

CREATE TABLE `user_table` (
  `user_table_id` int(11) NOT NULL,
  `user_name` varchar(20) DEFAULT NULL,
  `user_password` varchar(20) DEFAULT NULL,
  `real_name` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `role` char(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `user_table`
--

INSERT INTO `user_table` (`user_table_id`, `user_name`, `user_password`, `real_name`, `email`, `role`) VALUES
(1, 'annahaha13998', 'adna123', 'An Pham', 'annahaha139@gmail.com', 'Admin'),
(2, 'tom2lua', 'adna123', 'Nguyen Tran', 'annahaha139@gmail.com', 'Admin'),
(3, 'anhduc1009', 'adna123', 'Duc Pham', 'annahaha139@gmail.com', 'Service Person'),
(4, 'nguyentran11', 'adna123', 'Tran Nguyen', 'annahaha139@gmail.com', 'Service Person'),
(5, 'anhle2008', 'adna123', 'Anh Le', 'annahaha139@gmail.com', 'Service Person'),
(6, 'tunglatui94', 'adna123', 'Tung Phan', 'annahaha139@gmail.com', 'Client'),
(7, 'edward1', 'abc', 'Edward Snowden', 'annahaha139@gmail.com', 'Client'),
(8, 'anthony123', 'adna123', 'Anthony Stone', 'annahaha139@gmail.com', 'Client'),
(10, 'elly123', 'adna123', 'Elizabeth Rose', 'annahaha139@gmail.com', 'Client'),
(12, 'tranNguyen123', 'adna1234', 'Nguyen Tran', 'tom2lua@yahoo.com', 'Client'),
(13, '123456', 'adna123', 'Client', 'a@gmail.com', 'Client');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `appointment`
--
ALTER TABLE `appointment`
  ADD PRIMARY KEY (`appointment_id`),
  ADD KEY `ref_emp` (`ref_emp`),
  ADD KEY `ref_client` (`ref_client`) USING BTREE;

--
-- Indexes for table `appointment_place`
--
ALTER TABLE `appointment_place`
  ADD PRIMARY KEY (`appointment_place_id`),
  ADD KEY `ref_user_emp` (`ref_user_emp`);

--
-- Indexes for table `appointment_product`
--
ALTER TABLE `appointment_product`
  ADD PRIMARY KEY (`appointment_product_id`),
  ADD KEY `ref_user_emp` (`ref_user_emp`),
  ADD KEY `ref_appointment_place` (`ref_appointment_place`);

--
-- Indexes for table `user_emp_time`
--
ALTER TABLE `user_emp_time`
  ADD PRIMARY KEY (`time_id`),
  ADD KEY `ref_user_emp` (`ref_user_emp`);

--
-- Indexes for table `user_table`
--
ALTER TABLE `user_table`
  ADD PRIMARY KEY (`user_table_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `appointment`
--
ALTER TABLE `appointment`
  MODIFY `appointment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `appointment_place`
--
ALTER TABLE `appointment_place`
  MODIFY `appointment_place_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `appointment_product`
--
ALTER TABLE `appointment_product`
  MODIFY `appointment_product_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `user_emp_time`
--
ALTER TABLE `user_emp_time`
  MODIFY `time_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=209;

--
-- AUTO_INCREMENT for table `user_table`
--
ALTER TABLE `user_table`
  MODIFY `user_table_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `appointment`
--
ALTER TABLE `appointment`
  ADD CONSTRAINT `appointment_ibfk_1` FOREIGN KEY (`ref_client`) REFERENCES `user_table` (`user_table_id`),
  ADD CONSTRAINT `appointment_ibfk_2` FOREIGN KEY (`ref_emp`) REFERENCES `user_table` (`user_table_id`);

--
-- Constraints for table `appointment_place`
--
ALTER TABLE `appointment_place`
  ADD CONSTRAINT `appointment_place_ibfk_1` FOREIGN KEY (`ref_user_emp`) REFERENCES `user_table` (`user_table_id`);

--
-- Constraints for table `appointment_product`
--
ALTER TABLE `appointment_product`
  ADD CONSTRAINT `appointment_product_ibfk_1` FOREIGN KEY (`ref_user_emp`) REFERENCES `user_table` (`user_table_id`),
  ADD CONSTRAINT `appointment_product_ibfk_2` FOREIGN KEY (`ref_appointment_place`) REFERENCES `appointment_place` (`appointment_place_id`);

--
-- Constraints for table `user_emp_time`
--
ALTER TABLE `user_emp_time`
  ADD CONSTRAINT `user_emp_time_ibfk_1` FOREIGN KEY (`ref_user_emp`) REFERENCES `user_table` (`user_table_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
