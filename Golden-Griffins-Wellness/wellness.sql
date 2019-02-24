-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 24, 2019 at 05:04 AM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 7.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wellness`
--

-- --------------------------------------------------------

--
-- Table structure for table `randomemotion`
--

CREATE TABLE `randomemotion` (
  `question` varchar(1000) NOT NULL,
  `ans1` varchar(100) NOT NULL,
  `ans2` varchar(100) NOT NULL,
  `ans3` varchar(100) NOT NULL,
  `ans4` varchar(100) NOT NULL,
  `lesson` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `randomemotion`
--

INSERT INTO `randomemotion` (`question`, `ans1`, `ans2`, `ans3`, `ans4`, `lesson`) VALUES
('disorders come in different forms and there are variations in the number of symptoms, their severity, and persistence.', 'Anger', 'Anxiety', 'Depression', 'Frustration', 'depressive disorders come in different forms and there are variations in the number of symptoms, their severity, and persistence. Some types of depression run in families and often there appears to be a biological component to depression with changes in brain structures or brain function. Some people have a single episode of depression, but many people have episodes that recur.'),
('It is an emotion that occurs in situations where a person is blocked from reaching a desired outcome.', 'Guilt', 'Lack of Confidence', 'Frustration', 'Anxiety', 'Frustration is an emotion that occurs in situations where a person is blocked from reaching a desired outcome.  In general, whenever we reach one of our goals, we feel pleased and whenever we are prevented from reaching our goals, we may succumb to frustration and feel irritable, annoyed and angry.'),
('It can lead to problems at work, in your personal relationships, and in the overall quality of your life.', 'Self-Esteem', 'Anger', 'Stress', 'Grief', 'Anger is a completely normal, usually healthy, human emotion. But when it gets out of control and turns destructive, it can lead to problems at work, in your personal relationships, and in the overall quality of your life. And it can make you feel as though you\'re at the mercy of an unpredictable and powerful emotion.'),
('It consists of the positive thoughts and feelings you have about yourself.', 'Stress', 'Anger', 'Self-Esteem', 'Depression', 'Positive or high self-esteem consists of the positive thoughts and feelings you have about yourself. It affects how you think, act, and feel about others, as well as how successful you are in life. The acquisition of high self-esteem involves becoming the person you want to be, enjoying others more fully, and offering more of yourself to the world.'),
('Describes an eating disorder characterized by low body weight and body image distortion.', 'Anorexia', 'Anger', 'Self-Esteem', 'Stress', 'Anorexia nervosa describes an eating disorder characterized by low body weight and body image distortion.  Anorexia is a complex condition, involving psychological, neurobiological, and sociological factors.  Anorexia is more than just a problem with food. It\'s a way of using food or starving oneself to feel more in control of life and to ease tension, anger, and anxiety. '),
('It depend excessively on the approval of others in order to feel good about themselves.', 'Anxiety', 'Guilt', 'Lack of Confidence', 'Stress', 'Lack of Confidence - People who are not self-confident depend excessively on the approval of others in order to feel good about themselves. They tend to avoid taking risks because they fear failure. They generally do not expect to be successful. They often put themselves down and tend to discount or ignore compliments paid to them. By contrast, self-confident people are willing to risk the disapproval of others because they generally trust their own abilities. They tend to accept themselves; they don\'t feel they have to conform in order to be accepted.'),
('An abusive relationships without ever realizing what happened.', 'Fears', 'Confused', 'Emotional Abuse', 'Doubt', 'Emotional Abuse many women find themselves in emotionally abusive relationships without ever realizing what happened. Many emotional abusers are masters of manipulation, and are able to present themselves as charming, loyal and attentive partners. Only once the relationship has progressed, generally to a living together situation, does the abuser begin to show his true nature.\r\n\r\nEmotional abuse can be insidious. Many women claim that they did not realize what happened until they were firmly entrenched. No matter how intelligent or capable or independent you are, by virtue of being female you are at some risk of being emotionally abused.');

-- --------------------------------------------------------

--
-- Table structure for table `registration`
--

CREATE TABLE `registration` (
  `name` varchar(50) NOT NULL,
  `age` int(11) NOT NULL,
  `birthday` date NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `status` int(1) NOT NULL,
  `result` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `registration`
--

INSERT INTO `registration` (`name`, `age`, `birthday`, `email`, `password`, `status`, `result`) VALUES
('Elchier', 20, '0000-00-00', 'ElchierLontok@yahoo.com', 'elchier', 1, 5),
('Karl Palma', 20, '0000-00-00', 'Karl@yahoo.com', 'hehehehe', 1, 0),
('mark1', 12, '2012-12-12', 'mark1@gmail.com', 'ASD', 0, 0),
('mark', 20, '2012-12-12', 'mark@gmail.com', 'mark123', 1, 0),
('Dr Nelson Rodelas', 40, '0000-00-00', 'NelsonRodelas@gmail.com', 'hehe', 1, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_joinquestion`
--

CREATE TABLE `tbl_joinquestion` (
  `email` varchar(255) NOT NULL,
  `question` varchar(255) NOT NULL,
  `ans1` varchar(255) NOT NULL,
  `ans2` varchar(255) NOT NULL,
  `ans3` varchar(255) NOT NULL,
  `ans4` varchar(255) NOT NULL,
  `lesson` varchar(255) NOT NULL,
  `timer` time(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_joinquestion`
--

INSERT INTO `tbl_joinquestion` (`email`, `question`, `ans1`, `ans2`, `ans3`, `ans4`, `lesson`, `timer`) VALUES
('ElchierLontok@yahoo.com', 'An abusive relationships without ever realizing what happened.', 'Fears', 'Confused', 'Emotional Abuse', 'Doubt', 'Emotional Abuse many women find themselves in emotionally abusive relationships without ever realizing what happened. Many emotional abusers are masters of manipulation, and are able to present themselves as charming, loyal and attentive partners. Only on', '00:00:00.000000'),
('Karl@yahoo.com', 'It consists of the positive thoughts and feelings you have about yourself.', 'Stress', 'Anger', 'Self-Esteem', 'Depression', 'Positive or high self-esteem consists of the positive thoughts and feelings you have about yourself. It affects how you think, act, and feel about others, as well as how successful you are in life. The acquisition of high self-esteem involves becoming the', '10:55:57.000000'),
('mark@gmail.com', 'An abusive relationships without ever realizing what happened.', 'Fears', 'Confused', 'Emotional Abuse', 'Doubt', 'Emotional Abuse many women find themselves in emotionally abusive relationships without ever realizing what happened. Many emotional abusers are masters of manipulation, and are able to present themselves as charming, loyal and attentive partners. Only on', '00:00:00.000000'),
('NelsonRodelas@gmail.com', 'It consists of the positive thoughts and feelings you have about yourself.', 'Stress', 'Anger', 'Self-Esteem', 'Depression', 'Positive or high self-esteem consists of the positive thoughts and feelings you have about yourself. It affects how you think, act, and feel about others, as well as how successful you are in life. The acquisition of high self-esteem involves becoming the', '00:00:00.000000');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `registration`
--
ALTER TABLE `registration`
  ADD PRIMARY KEY (`email`);

--
-- Indexes for table `tbl_joinquestion`
--
ALTER TABLE `tbl_joinquestion`
  ADD PRIMARY KEY (`email`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
