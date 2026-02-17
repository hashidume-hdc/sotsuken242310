-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- ホスト: 127.0.0.1
-- 生成日時: 2026-02-17 11:24:53
-- サーバのバージョン： 10.4.32-MariaDB
-- PHP のバージョン: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- データベース: `sotuken242310`
--

-- --------------------------------------------------------

--
-- テーブルの構造 `admins`
--

CREATE TABLE `admins` (
  `admin_id` int(10) NOT NULL,
  `admin_name` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- テーブルのデータのダンプ `admins`
--

INSERT INTO `admins` (`admin_id`, `admin_name`, `password`) VALUES
(1, 'admin', 'asdf1234');

-- --------------------------------------------------------

--
-- テーブルの構造 `dm_messages`
--

CREATE TABLE `dm_messages` (
  `message_id` int(10) NOT NULL,
  `room_id` int(10) NOT NULL,
  `sender_id` int(10) NOT NULL,
  `content` varchar(255) NOT NULL,
  `send_time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- テーブルのデータのダンプ `dm_messages`
--

INSERT INTO `dm_messages` (`message_id`, `room_id`, `sender_id`, `content`, `send_time`) VALUES
(1, 1, 1, 'こんにちは。', '2026-01-29 09:47:52'),
(2, 1, 34, 'こんばんはですよ！', '2026-01-29 09:48:59'),
(3, 7, 1, 'こんばんは', '2026-01-29 09:55:14'),
(4, 1, 1, 'そうだった', '2026-02-02 15:21:24'),
(5, 1, 1, 'こんにちは', '2026-02-05 12:21:36'),
(6, 1, 1, 'お久しぶりです！', '2026-02-17 10:21:19');

-- --------------------------------------------------------

--
-- テーブルの構造 `dm_rooms`
--

CREATE TABLE `dm_rooms` (
  `room_id` int(10) NOT NULL,
  `user1_id` int(10) NOT NULL,
  `user2_id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- テーブルのデータのダンプ `dm_rooms`
--

INSERT INTO `dm_rooms` (`room_id`, `user1_id`, `user2_id`) VALUES
(1, 1, 34),
(7, 1, 35),
(8, 1, 36),
(10, 1, 37),
(9, 1, 39),
(11, 1, 40),
(2, 34, 35);

-- --------------------------------------------------------

--
-- テーブルの構造 `follows`
--

CREATE TABLE `follows` (
  `follower_id` int(10) NOT NULL,
  `user_id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- テーブルのデータのダンプ `follows`
--

INSERT INTO `follows` (`follower_id`, `user_id`) VALUES
(34, 1),
(40, 1);

-- --------------------------------------------------------

--
-- テーブルの構造 `hbtks`
--

CREATE TABLE `hbtks` (
  `hbtk_id` int(10) NOT NULL,
  `user_id` int(10) NOT NULL,
  `content` varchar(255) NOT NULL,
  `pare_hbtk_id` int(10) NOT NULL,
  `hbtk_time` timestamp NOT NULL DEFAULT current_timestamp(),
  `delete_frag` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- テーブルのデータのダンプ `hbtks`
--

INSERT INTO `hbtks` (`hbtk_id`, `user_id`, `content`, `pare_hbtk_id`, `hbtk_time`, `delete_frag`) VALUES
(15, 1, 'testtest', 0, '2026-01-22 00:59:38', 0),
(167, 34, '今日も猫がキーボードに乗ってくる', 0, '2026-01-26 03:18:08', 0),
(168, 34, 'VB.NETとMySQL、意外と相性いい', 0, '2026-01-24 03:18:08', 0),
(169, 34, 'エラー直った瞬間が一番楽しい', 0, '2026-01-22 03:18:08', 0),
(170, 35, '404: やる気が見つかりません', 0, '2026-01-25 03:18:08', 0),
(171, 35, 'バグは深夜に増殖する', 0, '2026-01-23 03:18:08', 0),
(172, 35, '今日もWarningと仲良し', 0, '2026-01-21 03:18:08', 0),
(173, 36, '淡々と記録していく', 0, '2026-01-27 02:18:08', 0),
(174, 36, '特に意味はない投稿', 0, '2026-01-25 03:18:08', 0),
(175, 36, '静かなタイムラインが好き', 0, '2026-01-20 03:18:08', 0),
(176, 37, '空がきれいだとコードも捗る', 0, '2026-01-26 03:18:08', 1),
(177, 37, 'ビット演算むずい', 0, '2026-01-24 03:18:08', 0),
(178, 37, 'クラウドじゃなくて空の話', 0, '2026-01-22 03:18:08', 0),
(179, 38, 'ダークテーマしか勝たん', 0, '2026-01-27 02:48:08', 0),
(180, 38, '黒背景は目に優しい（気がする）', 0, '2026-01-25 03:18:08', 0),
(181, 38, '白背景は敵', 0, '2026-01-23 03:18:08', 0),
(182, 39, '実験コードはだいたい爆発する', 0, '2026-01-26 03:18:08', 0),
(183, 39, '今日は成功率20%', 0, '2026-01-24 03:18:08', 0),
(184, 39, 'ログを信じろ', 0, '2026-01-21 03:18:08', 0),
(185, 40, '水分補給大事', 0, '2026-01-27 03:08:08', 0),
(186, 40, '静かな一日', 0, '2026-01-25 03:18:08', 0),
(187, 40, '今日は何も起きてない', 0, '2026-01-22 03:18:08', 1),
(188, 41, 'ドット絵描いてたら夜', 0, '2026-01-26 03:18:08', 0),
(189, 41, 'FPSよりUI調整', 0, '2026-01-24 03:18:08', 0),
(190, 41, 'ピクセルは正義', 0, '2026-01-21 03:18:08', 0),
(191, 42, '匿名でいるのが一番楽', 0, '2026-01-27 01:18:08', 1),
(192, 42, '特定されない程度に喋る', 0, '2026-01-25 03:18:08', 1),
(193, 42, '今日はROM専', 0, '2026-01-22 03:18:08', 1),
(194, 43, '眠いけどpushした', 0, '2026-01-27 03:03:08', 1),
(195, 43, 'レビューは明日やる', 0, '2026-01-25 03:18:08', 1),
(196, 43, 'コーヒーが命綱', 0, '2026-01-23 03:18:08', 1),
(197, 35, 'わかる', 167, '2026-01-27 02:30:54', 0),
(198, 38, '猫は正義', 167, '2026-01-27 02:40:54', 0),
(199, 36, 'VB.NET意外と好き', 168, '2026-01-27 02:20:54', 0),
(200, 39, 'MySQL安定してる', 168, '2026-01-27 02:25:54', 0),
(201, 37, 'その瞬間の快感やばい', 169, '2026-01-27 01:20:54', 0),
(202, 42, '再現できないやつ', 169, '2026-01-27 01:50:54', 1),
(203, 34, '404で草', 170, '2026-01-27 00:20:54', 0),
(204, 41, '今日の俺', 170, '2026-01-27 01:20:54', 0),
(205, 38, '深夜は危険', 171, '2026-01-26 23:20:54', 0),
(206, 43, 'バグは夜行性', 171, '2026-01-27 00:20:54', 1),
(207, 36, '警告100個くらい出てそう', 172, '2026-01-26 22:20:54', 0),
(208, 40, '無視すると痛い', 172, '2026-01-26 23:20:54', 0),
(209, 39, 'ログ職人', 173, '2026-01-27 02:50:54', 0),
(210, 34, 'わかる', 173, '2026-01-27 03:00:54', 0),
(211, 35, '意味がある', 174, '2026-01-27 00:20:54', 0),
(212, 42, '静かなTL良い', 174, '2026-01-27 01:20:54', 1),
(213, 41, '落ち着く', 175, '2026-01-26 21:20:54', 0),
(214, 37, 'わかる', 175, '2026-01-26 22:20:54', 0),
(215, 40, 'それな', 176, '2026-01-27 01:20:54', 0),
(216, 34, '空見るの大事', 176, '2026-01-27 01:50:54', 0),
(217, 36, 'ビット演算は地獄', 177, '2026-01-26 20:20:54', 0),
(218, 43, '頭こんがらがる', 177, '2026-01-26 21:20:54', 1),
(219, 35, 'わかる（違う）', 178, '2026-01-26 19:20:54', 0),
(220, 42, '草', 178, '2026-01-26 20:20:54', 1),
(221, 39, 'ダークテーマ最高', 179, '2026-01-27 02:55:54', 0),
(222, 41, '白は眩しい', 179, '2026-01-27 03:05:54', 0),
(223, 34, '目に優しい（錯覚）', 180, '2026-01-27 00:20:54', 0),
(224, 40, '気持ちは大事', 180, '2026-01-27 01:20:54', 0),
(225, 36, 'わかる', 181, '2026-01-26 22:20:54', 0),
(226, 42, '敵認定', 181, '2026-01-26 23:20:54', 1),
(227, 38, '爆発は様式美', 182, '2026-01-26 21:20:54', 0),
(228, 41, '成功率低め', 182, '2026-01-26 22:20:54', 0),
(229, 35, '20%は希望', 183, '2026-01-26 20:20:54', 0),
(230, 43, '回数で殴る', 183, '2026-01-26 21:20:54', 1),
(231, 34, 'ログは嘘つかない', 184, '2026-01-26 19:20:54', 0),
(232, 40, '信じる者は救われる', 184, '2026-01-26 20:20:54', 0),
(233, 36, '大事', 185, '2026-01-27 03:10:54', 0),
(234, 42, '忘れがち', 185, '2026-01-27 03:15:54', 1),
(235, 39, '平和', 186, '2026-01-27 00:20:54', 0),
(236, 34, '何もないのが一番', 186, '2026-01-27 01:20:54', 0),
(237, 41, 'そういう日もある', 187, '2026-01-26 23:20:54', 0),
(238, 37, '日常', 187, '2026-01-27 00:20:54', 0),
(239, 35, '夜更かし確定', 188, '2026-01-26 22:20:54', 0),
(240, 43, 'わかる', 188, '2026-01-26 23:20:54', 1),
(241, 38, 'UI調整地獄', 189, '2026-01-26 21:20:54', 0),
(242, 34, '沼', 189, '2026-01-26 22:20:54', 0),
(243, 36, '正義', 190, '2026-01-26 20:20:54', 0),
(244, 40, '異論なし', 190, '2026-01-26 21:20:54', 0),
(245, 42, '楽が一番', 191, '2026-01-27 01:20:54', 1),
(246, 35, '匿名最高', 191, '2026-01-27 02:20:54', 0),
(247, 39, 'ほどほどが一番', 192, '2026-01-27 00:20:54', 0),
(248, 34, '距離感大事', 192, '2026-01-27 01:20:54', 0),
(249, 41, 'ROMも楽しい', 193, '2026-01-26 23:20:54', 0),
(250, 36, '見る専の日', 193, '2026-01-27 00:20:54', 0),
(251, 38, 'それはつらい', 194, '2026-01-27 02:50:54', 0),
(252, 40, '休もう', 194, '2026-01-27 03:00:54', 0),
(253, 34, '明日やろう', 195, '2026-01-27 01:20:54', 0),
(254, 42, '未来の自分に任せる', 195, '2026-01-27 02:20:54', 1),
(255, 39, 'コーヒー必須', 196, '2026-01-27 00:20:54', 0),
(256, 35, 'ブラックで', 196, '2026-01-27 01:20:54', 0),
(257, 34, '今日も猫が乗ってくる', 0, '2026-01-29 02:09:38', 0),
(258, 1, 'かわいいね', 257, '2026-02-02 06:20:52', 0),
(259, 1, 'きょうもいいひ', 0, '2026-02-02 06:23:46', 0),
(264, 1, 'それな！', 258, '2026-02-17 01:20:24', 1),
(265, 1, 'ローソンが好きになりました', 0, '2026-02-17 01:23:36', 0);

-- --------------------------------------------------------

--
-- テーブルの構造 `likes`
--

CREATE TABLE `likes` (
  `hbtk_id` int(10) NOT NULL,
  `user_id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- テーブルのデータのダンプ `likes`
--

INSERT INTO `likes` (`hbtk_id`, `user_id`) VALUES
(168, 1),
(185, 1),
(257, 1),
(259, 1),
(260, 1),
(261, 1);

-- --------------------------------------------------------

--
-- テーブルの構造 `post_images`
--

CREATE TABLE `post_images` (
  `hbtk_id` int(10) NOT NULL,
  `sort_order` int(1) NOT NULL,
  `image_url` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- テーブルのデータのダンプ `post_images`
--

INSERT INTO `post_images` (`hbtk_id`, `sort_order`, `image_url`) VALUES
(257, 1, 'C:\\Git\\sotsuken242310\\04_source\\hbtk画像\\neko2.png'),
(259, 1, 'C:\\Git\\sotsuken242310\\04_source\\hbtk画像\\sad.png'),
(260, 1, 'C:\\Git\\sotsuken242310\\04_source\\hbtk画像\\neko2.png'),
(265, 1, 'C:\\Git\\sotsuken242310\\04_source\\hbtk画像\\lawson.png');

-- --------------------------------------------------------

--
-- テーブルの構造 `users`
--

CREATE TABLE `users` (
  `user_id` int(10) NOT NULL,
  `user_name` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `icon_url` varchar(255) NOT NULL DEFAULT 'C:\\Git\\sotsuken242310\\04_source\\Tbatter使用画像\\first_icon.png',
  `bio` varchar(160) NOT NULL,
  `delete_frag` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- テーブルのデータのダンプ `users`
--

INSERT INTO `users` (`user_id`, `user_name`, `password`, `icon_url`, `bio`, `delete_frag`) VALUES
(1, 't', 'asdf', 'C:\\Git\\sotsuken242310\\04_source\\hbtk画像\\lawson.png', 'ローソン大好き', 0),
(34, 'neko_dev', 'pass123', 'C:\\Git\\sotsuken242310\\04_source\\hbtk画像\\neko.png', '猫とコード🐱', 0),
(35, 'yuki_404', 'pass123', 'C:\\Git\\sotsuken242310\\04_source\\Tbatter使用画像\\first_icon.png', 'だいたいエラー', 0),
(36, 'mono_log', 'pass123', 'C:\\Git\\sotsuken242310\\04_source\\Tbatter使用画像\\first_icon.png', '思ったことをつぶやく', 0),
(37, 'sora_bits', 'pass123', 'C:\\Git\\sotsuken242310\\04_source\\Tbatter使用画像\\first_icon.png', '空と技術の話', 0),
(38, 'kuro_note', 'pass123', 'C:\\Git\\sotsuken242310\\04_source\\Tbatter使用画像\\first_icon.png', '黒背景が落ち着く', 0),
(39, 'aki_lab', 'pass123', 'C:\\Git\\sotsuken242310\\04_source\\Tbatter使用画像\\first_icon.png', '実験中', 0),
(40, 'mizu_day', 'pass123', 'C:\\Git\\sotsuken242310\\04_source\\Tbatter使用画像\\first_icon.png', '水と日常', 0),
(41, 'pixel_run', 'pass123', 'C:\\Git\\sotsuken242310\\04_source\\Tbatter使用画像\\first_icon.png', 'ドットと速度', 0),
(42, 'nanashi_x', 'pass123', 'C:\\Git\\sotsuken242310\\04_source\\Tbatter使用画像\\first_icon.png', '匿名気分', 1),
(43, 'sleepy_dev', 'pass123', 'C:\\Git\\sotsuken242310\\04_source\\Tbatter使用画像\\first_icon.png', '眠いけど書く', 1),
(44, 'newmen', 'asdf', 'C:\\Git\\sotsuken242310\\04_source\\Tbatter使用画像\\first_icon.png', '', 1);

--
-- ダンプしたテーブルのインデックス
--

--
-- テーブルのインデックス `admins`
--
ALTER TABLE `admins`
  ADD PRIMARY KEY (`admin_id`),
  ADD UNIQUE KEY `admin_name` (`admin_name`);

--
-- テーブルのインデックス `dm_messages`
--
ALTER TABLE `dm_messages`
  ADD PRIMARY KEY (`message_id`);

--
-- テーブルのインデックス `dm_rooms`
--
ALTER TABLE `dm_rooms`
  ADD PRIMARY KEY (`room_id`),
  ADD UNIQUE KEY `uq_dm_pair` (`user1_id`,`user2_id`);

--
-- テーブルのインデックス `follows`
--
ALTER TABLE `follows`
  ADD PRIMARY KEY (`follower_id`,`user_id`);

--
-- テーブルのインデックス `hbtks`
--
ALTER TABLE `hbtks`
  ADD PRIMARY KEY (`hbtk_id`);

--
-- テーブルのインデックス `likes`
--
ALTER TABLE `likes`
  ADD PRIMARY KEY (`hbtk_id`,`user_id`);

--
-- テーブルのインデックス `post_images`
--
ALTER TABLE `post_images`
  ADD PRIMARY KEY (`hbtk_id`,`sort_order`);

--
-- テーブルのインデックス `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `user_name` (`user_name`);

--
-- ダンプしたテーブルの AUTO_INCREMENT
--

--
-- テーブルの AUTO_INCREMENT `admins`
--
ALTER TABLE `admins`
  MODIFY `admin_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- テーブルの AUTO_INCREMENT `dm_messages`
--
ALTER TABLE `dm_messages`
  MODIFY `message_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- テーブルの AUTO_INCREMENT `dm_rooms`
--
ALTER TABLE `dm_rooms`
  MODIFY `room_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- テーブルの AUTO_INCREMENT `hbtks`
--
ALTER TABLE `hbtks`
  MODIFY `hbtk_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=266;

--
-- テーブルの AUTO_INCREMENT `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=45;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
