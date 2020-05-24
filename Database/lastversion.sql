-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema sportclub
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema sportclub
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `sportclub` DEFAULT CHARACTER SET utf8 ;
USE `sportclub` ;

-- -----------------------------------------------------
-- Table `sportclub`.`Role`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Role` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`User`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`User` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `second_name` VARCHAR(100) NOT NULL,
  `name` VARCHAR(100) NOT NULL,
  `patronymic` VARCHAR(100) NULL,
  `login` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `Role_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_user_UNIQUE` (`id` ASC),
  UNIQUE INDEX `login_UNIQUE` (`login` ASC),
  INDEX `fk_User_Role1_idx` (`Role_id` ASC),
  CONSTRAINT `fk_User_Role1`
    FOREIGN KEY (`Role_id`)
    REFERENCES `sportclub`.`Role` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Kind_of_sport`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Kind_of_sport` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  `world_record` VARCHAR(45) NULL,
  `date_of_record` DATE NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Page`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Page` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Access`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Access` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Role_id` INT NOT NULL,
  `Page_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_Access_Role1_idx` (`Role_id` ASC),
  INDEX `fk_Access_Page1_idx` (`Page_id` ASC),
  CONSTRAINT `fk_Access_Role1`
    FOREIGN KEY (`Role_id`)
    REFERENCES `sportclub`.`Role` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Access_Page1`
    FOREIGN KEY (`Page_id`)
    REFERENCES `sportclub`.`Page` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Team`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Team` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  `Kind_of_sport_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_Team_Kind_of_sport1_idx` (`Kind_of_sport_id` ASC),
  CONSTRAINT `fk_Team_Kind_of_sport1`
    FOREIGN KEY (`Kind_of_sport_id`)
    REFERENCES `sportclub`.`Kind_of_sport` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Trainer`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Trainer` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `User_id` INT NOT NULL,
  `Access_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `User_id_UNIQUE` (`id` ASC),
  INDEX `fk_Trainer_User1_idx` (`User_id` ASC),
  INDEX `fk_Trainer_Access1_idx` (`Access_id` ASC),
  CONSTRAINT `fk_Trainer_User1`
    FOREIGN KEY (`User_id`)
    REFERENCES `sportclub`.`User` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Trainer_Access1`
    FOREIGN KEY (`Access_id`)
    REFERENCES `sportclub`.`Access` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Sportsman`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Sportsman` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `birthday` DATE NOT NULL,
  `sports_category` VARCHAR(45) NULL,
  `User_id` INT NOT NULL,
  `Access_id` INT NOT NULL,
  `Team_id` INT NOT NULL,
  `Trainer_id` INT NOT NULL,
  UNIQUE INDEX `id sportsman_UNIQUE` (`id` ASC),
  PRIMARY KEY (`id`),
  INDEX `fk_Sportsman_User1_idx` (`User_id` ASC),
  INDEX `fk_Sportsman_Access1_idx` (`Access_id` ASC),
  INDEX `fk_Sportsman_Team1_idx` (`Team_id` ASC),
  INDEX `fk_Sportsman_Trainer1_idx` (`Trainer_id` ASC),
  CONSTRAINT `fk_Sportsman_User1`
    FOREIGN KEY (`User_id`)
    REFERENCES `sportclub`.`User` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Sportsman_Access1`
    FOREIGN KEY (`Access_id`)
    REFERENCES `sportclub`.`Access` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Sportsman_Team1`
    FOREIGN KEY (`Team_id`)
    REFERENCES `sportclub`.`Team` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Sportsman_Trainer1`
    FOREIGN KEY (`Trainer_id`)
    REFERENCES `sportclub`.`Trainer` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Referee`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Referee` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `User_id` INT NOT NULL,
  `Access_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_Referee_User1_idx` (`User_id` ASC),
  INDEX `fk_Referee_Access1_idx` (`Access_id` ASC),
  CONSTRAINT `fk_Referee_User1`
    FOREIGN KEY (`User_id`)
    REFERENCES `sportclub`.`User` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Referee_Access1`
    FOREIGN KEY (`Access_id`)
    REFERENCES `sportclub`.`Access` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Competition`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Competition` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  `date` DATE NULL,
  `Referee_id` INT NOT NULL,
  `Kind_of_sport_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_Competition_Referee1_idx` (`Referee_id` ASC),
  INDEX `fk_Competition_Kind_of_sport1_idx` (`Kind_of_sport_id` ASC),
  CONSTRAINT `fk_Competition_Referee1`
    FOREIGN KEY (`Referee_id`)
    REFERENCES `sportclub`.`Referee` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Competition_Kind_of_sport1`
    FOREIGN KEY (`Kind_of_sport_id`)
    REFERENCES `sportclub`.`Kind_of_sport` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Competition_results`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Competition_results` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Result` VARCHAR(45) NULL,
  `Place` INT NULL,
  `Competition_id` INT NOT NULL,
  `Sportsman_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_Competition_results_Competition1_idx` (`Competition_id` ASC),
  INDEX `fk_Competition_results_Sportsman1_idx` (`Sportsman_id` ASC),
  CONSTRAINT `fk_Competition_results_Competition1`
    FOREIGN KEY (`Competition_id`)
    REFERENCES `sportclub`.`Competition` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Competition_results_Sportsman1`
    FOREIGN KEY (`Sportsman_id`)
    REFERENCES `sportclub`.`Sportsman` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Exercise`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Exercise` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NULL,
  `description` MEDIUMTEXT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Training`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Training` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Trainer_id` INT NOT NULL,
  `Sportsman_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_Training_Trainer1_idx` (`Trainer_id` ASC),
  INDEX `fk_Training_Sportsman1_idx` (`Sportsman_id` ASC),
  CONSTRAINT `fk_Training_Trainer1`
    FOREIGN KEY (`Trainer_id`)
    REFERENCES `sportclub`.`Trainer` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Training_Sportsman1`
    FOREIGN KEY (`Sportsman_id`)
    REFERENCES `sportclub`.`Sportsman` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Training_programm`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Training_programm` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `number of times` VARCHAR(45) NULL,
  `lead_time` VARCHAR(45) NULL,
  `Exercise_id` INT NOT NULL,
  `Training_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_Training_programm_Exercise1_idx` (`Exercise_id` ASC),
  INDEX `fk_Training_programm_Training1_idx` (`Training_id` ASC),
  CONSTRAINT `fk_Training_programm_Exercise1`
    FOREIGN KEY (`Exercise_id`)
    REFERENCES `sportclub`.`Exercise` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Training_programm_Training1`
    FOREIGN KEY (`Training_id`)
    REFERENCES `sportclub`.`Training` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Nutrion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Nutrion` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `wish_weight` INT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Сalorie_intake`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Сalorie_intake` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `calories_per_day` INT NOT NULL,
  `calories_absorbed` VARCHAR(45) NULL,
  `Sportsman_id` INT NOT NULL,
  `Nutrion_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Сalorie_intake_Sportsman1_idx` (`Sportsman_id` ASC),
  INDEX `fk_Сalorie_intake_Nutrion1_idx` (`Nutrion_id` ASC),
  CONSTRAINT `fk_Сalorie_intake_Sportsman1`
    FOREIGN KEY (`Sportsman_id`)
    REFERENCES `sportclub`.`Sportsman` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Сalorie_intake_Nutrion1`
    FOREIGN KEY (`Nutrion_id`)
    REFERENCES `sportclub`.`Nutrion` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `sportclub`.`Nutrition_program`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `sportclub`.`Nutrition_program` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Trainer_id` INT NOT NULL,
  `Nutrion_id` INT NOT NULL,
  `Sportsman_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_UNIQUE` (`id` ASC),
  INDEX `fk_Nutrition_program_Trainer1_idx` (`Trainer_id` ASC),
  INDEX `fk_Nutrition_program_Nutrion1_idx` (`Nutrion_id` ASC),
  INDEX `fk_Nutrition_program_Sportsman1_idx` (`Sportsman_id` ASC),
  CONSTRAINT `fk_Nutrition_program_Trainer1`
    FOREIGN KEY (`Trainer_id`)
    REFERENCES `sportclub`.`Trainer` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Nutrition_program_Nutrion1`
    FOREIGN KEY (`Nutrion_id`)
    REFERENCES `sportclub`.`Nutrion` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Nutrition_program_Sportsman1`
    FOREIGN KEY (`Sportsman_id`)
    REFERENCES `sportclub`.`Sportsman` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
