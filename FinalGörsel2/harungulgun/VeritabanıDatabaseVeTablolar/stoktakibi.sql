-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 04 Oca 2017, 05:30:23
-- Sunucu sürümü: 5.6.26
-- PHP Sürümü: 5.6.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `stoktakibi`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `gelenpara`
--

CREATE TABLE IF NOT EXISTS `gelenpara` (
  `id` int(11) NOT NULL,
  `kimden` varchar(50) NOT NULL,
  `paratipi` varchar(25) NOT NULL,
  `tutar` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB AUTO_INCREMENT=74 DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `gelenpara`
--

INSERT INTO `gelenpara` (`id`, `kimden`, `paratipi`, `tutar`) VALUES
(65, 'harun', 'USD', 18),
(68, 'harun', 'USD', 18),
(69, 'harun', 'USD', 18),
(70, 'harun', 'USD', 18),
(71, 'harun', 'USD', 18),
(72, '100', 'Çek', 500),
(73, '100', 'Çek', 500);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kasa`
--

CREATE TABLE IF NOT EXISTS `kasa` (
  `id` int(11) NOT NULL,
  `kimden` varchar(25) NOT NULL,
  `paratipi` varchar(25) NOT NULL,
  `miktar` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB AUTO_INCREMENT=70 DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `kasa`
--

INSERT INTO `kasa` (`id`, `kimden`, `paratipi`, `miktar`) VALUES
(49, 'harun', 'USD', 18),
(50, 'harun', 'USD', 18),
(51, 'harun', 'USD', 18),
(52, 'harun', 'USD', 18),
(53, 'harun', 'USD', 18),
(54, 'harun', 'USD', 18),
(69, 'asd', 'Çek', 500);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kulgir`
--

CREATE TABLE IF NOT EXISTS `kulgir` (
  `id` int(11) NOT NULL,
  `kulad` varchar(20) NOT NULL,
  `sifre` varchar(20) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `kulgir`
--

INSERT INTO `kulgir` (`id`, `kulad`, `sifre`) VALUES
(1, 'admin', '123'),
(2, 'harun', '123');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `odemeler`
--

CREATE TABLE IF NOT EXISTS `odemeler` (
  `id` int(11) NOT NULL,
  `odemeTuru` varchar(20) NOT NULL,
  `odemeTipi` varchar(20) NOT NULL,
  `aciklama` varchar(300) NOT NULL,
  `tutar` int(11) DEFAULT '0'
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `odemeler`
--

INSERT INTO `odemeler` (`id`, `odemeTuru`, `odemeTipi`, `aciklama`, `tutar`) VALUES
(9, 'Kirtasiye Ödemesi', 'Euro', '', 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personel`
--

CREATE TABLE IF NOT EXISTS `personel` (
  `id` int(11) NOT NULL,
  `personelTc` varchar(11) NOT NULL,
  `personelAd` varchar(25) NOT NULL,
  `personelSoyad` varchar(25) NOT NULL,
  `cinsiyet` varchar(5) NOT NULL,
  `tarih` varchar(25) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `personel`
--

INSERT INTO `personel` (`id`, `personelTc`, `personelAd`, `personelSoyad`, `cinsiyet`, `tarih`) VALUES
(20, 'sad', 'das', 'das', 'Kiz', '29.12.2016'),
(21, 'sad', 'das', 'das', 'Kiz', '29.12.2016');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `urunler`
--

CREATE TABLE IF NOT EXISTS `urunler` (
  `id` int(11) NOT NULL,
  `urunad` varchar(25) NOT NULL,
  `urunadet` int(25) NOT NULL,
  `ureticiFirma` varchar(25) NOT NULL,
  `barkodno` varchar(25) NOT NULL,
  `fiyati` int(11) NOT NULL,
  `giristarihi` varchar(25) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `urunler`
--

INSERT INTO `urunler` (`id`, `urunad`, `urunadet`, `ureticiFirma`, `barkodno`, `fiyati`, `giristarihi`) VALUES
(21, '', 20, '', '', 30, '');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `gelenpara`
--
ALTER TABLE `gelenpara`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `kasa`
--
ALTER TABLE `kasa`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `kulgir`
--
ALTER TABLE `kulgir`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `odemeler`
--
ALTER TABLE `odemeler`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `personel`
--
ALTER TABLE `personel`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `urunler`
--
ALTER TABLE `urunler`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `gelenpara`
--
ALTER TABLE `gelenpara`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=74;
--
-- Tablo için AUTO_INCREMENT değeri `kasa`
--
ALTER TABLE `kasa`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=70;
--
-- Tablo için AUTO_INCREMENT değeri `kulgir`
--
ALTER TABLE `kulgir`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=3;
--
-- Tablo için AUTO_INCREMENT değeri `odemeler`
--
ALTER TABLE `odemeler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
--
-- Tablo için AUTO_INCREMENT değeri `personel`
--
ALTER TABLE `personel`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=22;
--
-- Tablo için AUTO_INCREMENT değeri `urunler`
--
ALTER TABLE `urunler`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=22;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
