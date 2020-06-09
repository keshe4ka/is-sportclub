-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Jun 03, 2020 at 12:50 AM
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
-- Database: `mydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `access`
--

CREATE TABLE `access` (
  `id` int(11) NOT NULL,
  `Role_id` int(11) NOT NULL,
  `Page_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `competition`
--

CREATE TABLE `competition` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `date` date DEFAULT NULL,
  `Referee_id` int(11) NOT NULL,
  `Kind_of_sport_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `competition_results`
--

CREATE TABLE `competition_results` (
  `id` int(11) NOT NULL,
  `Result` varchar(45) DEFAULT NULL,
  `Place` int(11) DEFAULT NULL,
  `Competition_id` int(11) NOT NULL,
  `Sportsman_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `exercise`
--

CREATE TABLE `exercise` (
  `id` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `description` mediumtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `kind_of_sport`
--

CREATE TABLE `kind_of_sport` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `world_record` varchar(45) DEFAULT NULL,
  `date_of_record` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `nutrion`
--

CREATE TABLE `nutrion` (
  `id` int(11) NOT NULL,
  `wish_weight` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `nutrition_program`
--

CREATE TABLE `nutrition_program` (
  `id` int(11) NOT NULL,
  `Trainer_id` int(11) NOT NULL,
  `Nutrion_id` int(11) NOT NULL,
  `Sportsman_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `page`
--

CREATE TABLE `page` (
  `id` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `referee`
--

CREATE TABLE `referee` (
  `id` int(11) NOT NULL,
  `User_id` int(11) NOT NULL,
  `Access_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `id` int(11) NOT NULL,
  `name` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`id`, `name`) VALUES
(1, 'Админ');

-- --------------------------------------------------------

--
-- Table structure for table `sportsman`
--

CREATE TABLE `sportsman` (
  `id` int(11) NOT NULL,
  `birthday` date NOT NULL,
  `sports_category` varchar(45) DEFAULT NULL,
  `User_id` int(11) NOT NULL,
  `Access_id` int(11) NOT NULL,
  `Team_id` int(11) NOT NULL,
  `Trainer_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `team`
--

CREATE TABLE `team` (
  `id` int(11) NOT NULL,
  `name` varchar(45) NOT NULL,
  `Kind_of_sport_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `trainer`
--

CREATE TABLE `trainer` (
  `id` int(11) NOT NULL,
  `User_id` int(11) NOT NULL,
  `Access_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `training`
--

CREATE TABLE `training` (
  `id` int(11) NOT NULL,
  `Trainer_id` int(11) NOT NULL,
  `Sportsman_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `training_programm`
--

CREATE TABLE `training_programm` (
  `id` int(11) NOT NULL,
  `number of times` varchar(45) DEFAULT NULL,
  `lead_time` varchar(45) DEFAULT NULL,
  `Exercise_id` int(11) NOT NULL,
  `Training_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `second_name` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `patronymic` varchar(100) DEFAULT NULL,
  `login` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `Role_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `second_name`, `name`, `patronymic`, `login`, `password`, `Role_id`) VALUES
(1, 'Анащенко', 'Артем', 'Альбертович', 'admin', 'password', 1);

-- --------------------------------------------------------

--
-- Table structure for table `сalorie_intake`
--

CREATE TABLE `сalorie_intake` (
  `id` int(11) NOT NULL,
  `calories_per_day` int(11) NOT NULL,
  `calories_absorbed` varchar(45) DEFAULT NULL,
  `Sportsman_id` int(11) NOT NULL,
  `Nutrion_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `access`
--
ALTER TABLE `access`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Access_Role1_idx` (`Role_id`),
  ADD KEY `fk_Access_Page1_idx` (`Page_id`);

--
-- Indexes for table `competition`
--
ALTER TABLE `competition`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Competition_Referee1_idx` (`Referee_id`),
  ADD KEY `fk_Competition_Kind_of_sport1_idx` (`Kind_of_sport_id`);

--
-- Indexes for table `competition_results`
--
ALTER TABLE `competition_results`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Competition_results_Competition1_idx` (`Competition_id`),
  ADD KEY `fk_Competition_results_Sportsman1_idx` (`Sportsman_id`);

--
-- Indexes for table `exercise`
--
ALTER TABLE `exercise`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`);

--
-- Indexes for table `kind_of_sport`
--
ALTER TABLE `kind_of_sport`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`);

--
-- Indexes for table `nutrion`
--
ALTER TABLE `nutrion`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`);

--
-- Indexes for table `nutrition_program`
--
ALTER TABLE `nutrition_program`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Nutrition_program_Trainer1_idx` (`Trainer_id`),
  ADD KEY `fk_Nutrition_program_Nutrion1_idx` (`Nutrion_id`),
  ADD KEY `fk_Nutrition_program_Sportsman1_idx` (`Sportsman_id`);

--
-- Indexes for table `page`
--
ALTER TABLE `page`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`);

--
-- Indexes for table `referee`
--
ALTER TABLE `referee`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Referee_User1_idx` (`User_id`),
  ADD KEY `fk_Referee_Access1_idx` (`Access_id`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`);

--
-- Indexes for table `sportsman`
--
ALTER TABLE `sportsman`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id sportsman_UNIQUE` (`id`),
  ADD KEY `fk_Sportsman_User1_idx` (`User_id`),
  ADD KEY `fk_Sportsman_Access1_idx` (`Access_id`),
  ADD KEY `fk_Sportsman_Team1_idx` (`Team_id`),
  ADD KEY `fk_Sportsman_Trainer1_idx` (`Trainer_id`);

--
-- Indexes for table `team`
--
ALTER TABLE `team`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Team_Kind_of_sport1_idx` (`Kind_of_sport_id`);

--
-- Indexes for table `trainer`
--
ALTER TABLE `trainer`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `User_id_UNIQUE` (`id`),
  ADD KEY `fk_Trainer_User1_idx` (`User_id`),
  ADD KEY `fk_Trainer_Access1_idx` (`Access_id`);

--
-- Indexes for table `training`
--
ALTER TABLE `training`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Training_Trainer1_idx` (`Trainer_id`),
  ADD KEY `fk_Training_Sportsman1_idx` (`Sportsman_id`);

--
-- Indexes for table `training_programm`
--
ALTER TABLE `training_programm`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Training_programm_Exercise1_idx` (`Exercise_id`),
  ADD KEY `fk_Training_programm_Training1_idx` (`Training_id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_user_UNIQUE` (`id`),
  ADD UNIQUE KEY `login_UNIQUE` (`login`),
  ADD KEY `fk_User_Role1_idx` (`Role_id`);

--
-- Indexes for table `сalorie_intake`
--
ALTER TABLE `сalorie_intake`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_Сalorie_intake_Sportsman1_idx` (`Sportsman_id`),
  ADD KEY `fk_Сalorie_intake_Nutrion1_idx` (`Nutrion_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `access`
--
ALTER TABLE `access`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `competition`
--
ALTER TABLE `competition`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `competition_results`
--
ALTER TABLE `competition_results`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `exercise`
--
ALTER TABLE `exercise`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `kind_of_sport`
--
ALTER TABLE `kind_of_sport`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `nutrion`
--
ALTER TABLE `nutrion`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `nutrition_program`
--
ALTER TABLE `nutrition_program`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `page`
--
ALTER TABLE `page`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `referee`
--
ALTER TABLE `referee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `sportsman`
--
ALTER TABLE `sportsman`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `team`
--
ALTER TABLE `team`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `trainer`
--
ALTER TABLE `trainer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `training`
--
ALTER TABLE `training`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `training_programm`
--
ALTER TABLE `training_programm`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `сalorie_intake`
--
ALTER TABLE `сalorie_intake`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `access`
--
ALTER TABLE `access`
  ADD CONSTRAINT `fk_Access_Page1` FOREIGN KEY (`Page_id`) REFERENCES `page` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Access_Role1` FOREIGN KEY (`Role_id`) REFERENCES `role` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `competition`
--
ALTER TABLE `competition`
  ADD CONSTRAINT `fk_Competition_Kind_of_sport1` FOREIGN KEY (`Kind_of_sport_id`) REFERENCES `kind_of_sport` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Competition_Referee1` FOREIGN KEY (`Referee_id`) REFERENCES `referee` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `competition_results`
--
ALTER TABLE `competition_results`
  ADD CONSTRAINT `fk_Competition_results_Competition1` FOREIGN KEY (`Competition_id`) REFERENCES `competition` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Competition_results_Sportsman1` FOREIGN KEY (`Sportsman_id`) REFERENCES `sportsman` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `nutrition_program`
--
ALTER TABLE `nutrition_program`
  ADD CONSTRAINT `fk_Nutrition_program_Nutrion1` FOREIGN KEY (`Nutrion_id`) REFERENCES `nutrion` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Nutrition_program_Sportsman1` FOREIGN KEY (`Sportsman_id`) REFERENCES `sportsman` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Nutrition_program_Trainer1` FOREIGN KEY (`Trainer_id`) REFERENCES `trainer` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `referee`
--
ALTER TABLE `referee`
  ADD CONSTRAINT `fk_Referee_Access1` FOREIGN KEY (`Access_id`) REFERENCES `access` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Referee_User1` FOREIGN KEY (`User_id`) REFERENCES `user` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `sportsman`
--
ALTER TABLE `sportsman`
  ADD CONSTRAINT `fk_Sportsman_Access1` FOREIGN KEY (`Access_id`) REFERENCES `access` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Sportsman_Team1` FOREIGN KEY (`Team_id`) REFERENCES `team` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Sportsman_Trainer1` FOREIGN KEY (`Trainer_id`) REFERENCES `trainer` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Sportsman_User1` FOREIGN KEY (`User_id`) REFERENCES `user` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `team`
--
ALTER TABLE `team`
  ADD CONSTRAINT `fk_Team_Kind_of_sport1` FOREIGN KEY (`Kind_of_sport_id`) REFERENCES `kind_of_sport` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `trainer`
--
ALTER TABLE `trainer`
  ADD CONSTRAINT `fk_Trainer_Access1` FOREIGN KEY (`Access_id`) REFERENCES `access` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Trainer_User1` FOREIGN KEY (`User_id`) REFERENCES `user` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `training`
--
ALTER TABLE `training`
  ADD CONSTRAINT `fk_Training_Sportsman1` FOREIGN KEY (`Sportsman_id`) REFERENCES `sportsman` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Training_Trainer1` FOREIGN KEY (`Trainer_id`) REFERENCES `trainer` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `training_programm`
--
ALTER TABLE `training_programm`
  ADD CONSTRAINT `fk_Training_programm_Exercise1` FOREIGN KEY (`Exercise_id`) REFERENCES `exercise` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Training_programm_Training1` FOREIGN KEY (`Training_id`) REFERENCES `training` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `fk_User_Role1` FOREIGN KEY (`Role_id`) REFERENCES `role` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `сalorie_intake`
--
ALTER TABLE `сalorie_intake`
  ADD CONSTRAINT `fk_Сalorie_intake_Nutrion1` FOREIGN KEY (`Nutrion_id`) REFERENCES `nutrion` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Сalorie_intake_Sportsman1` FOREIGN KEY (`Sportsman_id`) REFERENCES `sportsman` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
