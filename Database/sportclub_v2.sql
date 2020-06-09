-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Июн 09 2020 г., 14:02
-- Версия сервера: 5.7.24
-- Версия PHP: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `sportclub_v2`
--

-- --------------------------------------------------------

--
-- Структура таблицы `competition`
--

CREATE TABLE `competition` (
  `id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Kind_of_sport_id` int(11) NOT NULL,
  `Result` varchar(45) DEFAULT NULL,
  `Place` int(11) DEFAULT NULL,
  `Sportsman_id` int(11) NOT NULL,
  `Date` date DEFAULT NULL,
  `Referee_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `competition`
--

INSERT INTO `competition` (`id`, `Name`, `Kind_of_sport_id`, `Result`, `Place`, `Sportsman_id`, `Date`, `Referee_id`) VALUES
(1, 'Турнир', 1, '100 очков', 1, 1, '2020-06-09', 1),
(3, 'Между народами', 2, '46 очков', 2, 1, '2020-06-09', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `exercise`
--

CREATE TABLE `exercise` (
  `id` int(11) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `description` mediumtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `exercise`
--

INSERT INTO `exercise` (`id`, `name`, `description`) VALUES
(1, 'Отжимания', NULL),
(3, 'Подтягивания', 'На тунике надо сделать сальто');

-- --------------------------------------------------------

--
-- Структура таблицы `kind_of_sport`
--

CREATE TABLE `kind_of_sport` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `world_record` varchar(45) DEFAULT NULL,
  `date_of_record` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `kind_of_sport`
--

INSERT INTO `kind_of_sport` (`id`, `name`, `world_record`, `date_of_record`) VALUES
(1, 'Теннис', '300 очков', '2018-01-08'),
(2, 'Шашки', '10 побед подряд', '2020-06-09');

-- --------------------------------------------------------

--
-- Структура таблицы `nutrition_program`
--

CREATE TABLE `nutrition_program` (
  `id` int(11) NOT NULL,
  `wish_weight` varchar(45) DEFAULT NULL,
  `Trainer_id` int(11) NOT NULL,
  `Sportsman_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `nutrition_program`
--

INSERT INTO `nutrition_program` (`id`, `wish_weight`, `Trainer_id`, `Sportsman_id`) VALUES
(1, '100', 1, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `referee`
--

CREATE TABLE `referee` (
  `id` int(11) NOT NULL,
  `User_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `referee`
--

INSERT INTO `referee` (`id`, `User_id`) VALUES
(1, 3);

-- --------------------------------------------------------

--
-- Структура таблицы `sportsman`
--

CREATE TABLE `sportsman` (
  `id` int(11) NOT NULL,
  `birthday` date NOT NULL,
  `sports_category` varchar(45) DEFAULT NULL,
  `User_id` int(11) NOT NULL,
  `Trainer_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `sportsman`
--

INSERT INTO `sportsman` (`id`, `birthday`, `sports_category`, `User_id`, `Trainer_id`) VALUES
(1, '2020-06-03', NULL, 4, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `trainer`
--

CREATE TABLE `trainer` (
  `id` int(11) NOT NULL,
  `User_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `trainer`
--

INSERT INTO `trainer` (`id`, `User_id`) VALUES
(1, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `training`
--

CREATE TABLE `training` (
  `id` int(11) NOT NULL,
  `Trainer_id` int(11) NOT NULL,
  `Sportsman_id` int(11) NOT NULL,
  `Training_programm_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `training_programm`
--

CREATE TABLE `training_programm` (
  `id` int(11) NOT NULL,
  `number_of_times` varchar(45) DEFAULT NULL,
  `lead_time` varchar(45) DEFAULT NULL,
  `Exercise_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `training_programm`
--

INSERT INTO `training_programm` (`id`, `number_of_times`, `lead_time`, `Exercise_id`) VALUES
(1, '5', '10', 1);

-- --------------------------------------------------------

--
-- Структура таблицы `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `second_name` varchar(100) NOT NULL,
  `name` varchar(100) NOT NULL,
  `patronymic` varchar(100) DEFAULT NULL,
  `login` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `Role` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `user`
--

INSERT INTO `user` (`id`, `second_name`, `name`, `patronymic`, `login`, `password`, `Role`) VALUES
(1, 'admin', 'admin', 'admin', 'admin', 'password', 'Admin'),
(2, 'trainer', 'trainer', 'trainer', 'trainer', 'password', 'Trainer'),
(3, 'referee', 'referee', 'referee', 'referee', 'password', 'Referee'),
(4, 'sportsman', 'sportsman', 'sportsman', 'sportsman', 'password', 'Sportsman'),
(5, 'Анащенко', 'Артем', 'Альбертович', 'user', 'password', 'Sportsman');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `competition`
--
ALTER TABLE `competition`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Competition_results_Sportsman1_idx` (`Sportsman_id`),
  ADD KEY `fk_Competition_Kind_of_sport1_idx` (`Kind_of_sport_id`),
  ADD KEY `fk_Competition_Referee1_idx` (`Referee_id`);

--
-- Индексы таблицы `exercise`
--
ALTER TABLE `exercise`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`);

--
-- Индексы таблицы `kind_of_sport`
--
ALTER TABLE `kind_of_sport`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`);

--
-- Индексы таблицы `nutrition_program`
--
ALTER TABLE `nutrition_program`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Nutrition_program_Trainer1_idx` (`Trainer_id`),
  ADD KEY `fk_Nutrition_program_Sportsman1_idx` (`Sportsman_id`);

--
-- Индексы таблицы `referee`
--
ALTER TABLE `referee`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Referee_User1_idx` (`User_id`);

--
-- Индексы таблицы `sportsman`
--
ALTER TABLE `sportsman`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id sportsman_UNIQUE` (`id`),
  ADD KEY `fk_Sportsman_User1_idx` (`User_id`),
  ADD KEY `fk_Sportsman_Trainer1_idx` (`Trainer_id`);

--
-- Индексы таблицы `trainer`
--
ALTER TABLE `trainer`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `User_id_UNIQUE` (`id`),
  ADD KEY `fk_Trainer_User1_idx` (`User_id`);

--
-- Индексы таблицы `training`
--
ALTER TABLE `training`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Training_Trainer1_idx` (`Trainer_id`),
  ADD KEY `fk_Training_Sportsman1_idx` (`Sportsman_id`),
  ADD KEY `fk_Training_Training_programm1_idx` (`Training_programm_id`);

--
-- Индексы таблицы `training_programm`
--
ALTER TABLE `training_programm`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Training_programm_Exercise1_idx` (`Exercise_id`);

--
-- Индексы таблицы `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_user_UNIQUE` (`id`),
  ADD UNIQUE KEY `login_UNIQUE` (`login`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `competition`
--
ALTER TABLE `competition`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `exercise`
--
ALTER TABLE `exercise`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `kind_of_sport`
--
ALTER TABLE `kind_of_sport`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `nutrition_program`
--
ALTER TABLE `nutrition_program`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `referee`
--
ALTER TABLE `referee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `sportsman`
--
ALTER TABLE `sportsman`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `trainer`
--
ALTER TABLE `trainer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `training`
--
ALTER TABLE `training`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `training_programm`
--
ALTER TABLE `training_programm`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `competition`
--
ALTER TABLE `competition`
  ADD CONSTRAINT `fk_Competition_Kind_of_sport1` FOREIGN KEY (`Kind_of_sport_id`) REFERENCES `kind_of_sport` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Competition_Referee1` FOREIGN KEY (`Referee_id`) REFERENCES `referee` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Competition_results_Sportsman1` FOREIGN KEY (`Sportsman_id`) REFERENCES `sportsman` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ограничения внешнего ключа таблицы `nutrition_program`
--
ALTER TABLE `nutrition_program`
  ADD CONSTRAINT `fk_Nutrition_program_Sportsman1` FOREIGN KEY (`Sportsman_id`) REFERENCES `sportsman` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Nutrition_program_Trainer1` FOREIGN KEY (`Trainer_id`) REFERENCES `trainer` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ограничения внешнего ключа таблицы `referee`
--
ALTER TABLE `referee`
  ADD CONSTRAINT `fk_Referee_User1` FOREIGN KEY (`User_id`) REFERENCES `user` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ограничения внешнего ключа таблицы `sportsman`
--
ALTER TABLE `sportsman`
  ADD CONSTRAINT `fk_Sportsman_Trainer1` FOREIGN KEY (`Trainer_id`) REFERENCES `trainer` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Sportsman_User1` FOREIGN KEY (`User_id`) REFERENCES `user` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ограничения внешнего ключа таблицы `trainer`
--
ALTER TABLE `trainer`
  ADD CONSTRAINT `fk_Trainer_User1` FOREIGN KEY (`User_id`) REFERENCES `user` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ограничения внешнего ключа таблицы `training`
--
ALTER TABLE `training`
  ADD CONSTRAINT `fk_Training_Sportsman1` FOREIGN KEY (`Sportsman_id`) REFERENCES `sportsman` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Training_Trainer1` FOREIGN KEY (`Trainer_id`) REFERENCES `trainer` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Training_Training_programm1` FOREIGN KEY (`Training_programm_id`) REFERENCES `training_programm` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Ограничения внешнего ключа таблицы `training_programm`
--
ALTER TABLE `training_programm`
  ADD CONSTRAINT `fk_Training_programm_Exercise1` FOREIGN KEY (`Exercise_id`) REFERENCES `exercise` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
