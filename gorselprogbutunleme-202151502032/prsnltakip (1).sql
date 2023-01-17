-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 17 Oca 2023, 12:58:55
-- Sunucu sürümü: 5.7.36
-- PHP Sürümü: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `prsnltakip`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanici`
--

DROP TABLE IF EXISTS `kullanici`;
CREATE TABLE IF NOT EXISTS `kullanici` (
  `kullanici_id` int(11) NOT NULL AUTO_INCREMENT,
  `tcno` varchar(11) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  `adi` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  `soyadi` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  `kullaniciadi` varchar(20) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  `cinsiyet` char(1) COLLATE utf8mb4_unicode_ci NOT NULL,
  `bolum` varchar(100) COLLATE utf8mb4_unicode_ci NOT NULL,
  `sifre` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  PRIMARY KEY (`kullanici_id`)
) ENGINE=MyISAM AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `kullanici`
--

INSERT INTO `kullanici` (`kullanici_id`, `tcno`, `adi`, `soyadi`, `kullaniciadi`, `cinsiyet`, `bolum`, `sifre`) VALUES
(1, '22222222222', 'Emirhan', 'Yalçın', 'ylcnemirhan', 'E', 'Üretim', '987654'),
(2, '33333333333', 'Serdar', 'Saka', 'sakaserdar', 'E', 'Finans', '987654'),
(3, '44444444444', 'Mehmet', 'Bülbül', 'mehmetbulbul', 'E', 'Finans', '987654'),
(4, '55555555555', 'Zafer', 'Dağ', 'dagzafer10', 'E', 'Halkla ilişkiler', '987654'),
(5, '66666666666', 'Ahmet', 'Seymen', 'seymenahmet', 'E', 'Muhasebe', '987654'),
(6, '77777777777', 'Ömer Faruk', 'Kakıcı', 'kakıcıomer', 'E', 'Pazarlama', '987654'),
(7, '88888888888', 'Akif', 'Döne', 'doneakif', 'E', 'İnsan kaynakları', '987654'),
(8, '99999999999', 'Berkay', 'Mutlu', 'mutluberkay', 'E', 'Temizlik Görevlisi', '987654'),
(9, '12121212121', 'Furkan', 'Atalay', 'atalayfurkan', 'E', 'Araştırma ve geliştirme', '987654'),
(10, '11111111112', 'İbrahim', 'Atalay', 'atalayibrahim', 'E', 'Çırak', '987654'),
(17, '54545454545', 'Hasan ', 'Karakaya', 'karakayahasan', 'E', 'Yönetim', '123456'),
(12, '11111111222', 'Yücel', 'Fil', 'filyucel', 'E', 'Üretim', '987654');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `maas`
--

DROP TABLE IF EXISTS `maas`;
CREATE TABLE IF NOT EXISTS `maas` (
  `kullanici_id` int(11) NOT NULL AUTO_INCREMENT,
  `tcno` varchar(11) COLLATE utf8_unicode_520_ci NOT NULL,
  `adi` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `soyadi` varchar(50) COLLATE utf8_unicode_520_ci NOT NULL,
  `bolum` varchar(100) COLLATE utf8_unicode_520_ci NOT NULL,
  `resim` blob NOT NULL,
  `maas` varchar(100) COLLATE utf8_unicode_520_ci NOT NULL,
  PRIMARY KEY (`kullanici_id`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_520_ci;

--
-- Tablo döküm verisi `maas`
--

INSERT INTO `maas` (`kullanici_id`, `tcno`, `adi`, `soyadi`, `bolum`, `resim`, `maas`) VALUES
(1, '22222222222', 'Emirhan ', 'Yalçın', 'uretim', '', '9000'),
(2, '11111111222', 'Yücel ', 'Fil', 'uretim', '', '9000'),
(3, '99999999999', 'Berkay ', 'Mutlu', 'temizlik görevlisi', '', '6000'),
(4, '77777777777', 'Ömer Faruk  ', 'Kakıcı', 'pazarlama', '', '20000'),
(5, '66666666666', 'Ahmet ', 'Seymen', 'muhasebe', '', '10000'),
(6, '88888888888', 'Akif ', 'Döne', 'insan kaynakları', '', '15000'),
(7, '55555555555', 'Zafer ', 'Dağ', 'halkla ilişkiler', '', '15000'),
(8, '33333333333', 'Serdar ', 'Saka', 'finans', '', '25000'),
(9, '44444444444', 'Mehmet ', 'Bülbül', 'finans', '', '25000'),
(10, '11111111112', 'İbrahim  ', 'atalay', 'çırak', '', '2000'),
(11, '12121212121', 'Furkan ', 'Atalay', 'araştırma ve geliştirme', '', '20000');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `yonetici`
--

DROP TABLE IF EXISTS `yonetici`;
CREATE TABLE IF NOT EXISTS `yonetici` (
  `yonetici_id` int(11) NOT NULL AUTO_INCREMENT,
  `tcno` varchar(11) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  `adi` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  `soyadi` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  `kullaniciadi` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  `sifre` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_520_ci NOT NULL,
  PRIMARY KEY (`yonetici_id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Tablo döküm verisi `yonetici`
--

INSERT INTO `yonetici` (`yonetici_id`, `tcno`, `adi`, `soyadi`, `kullaniciadi`, `sifre`) VALUES
(2, '11111111111', 'Taha', 'Karakaya', 'karakayataha', '123456'),
(6, '78787878788', 'Zehra', 'Karakaya', 'karakayazehra', '0258');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
