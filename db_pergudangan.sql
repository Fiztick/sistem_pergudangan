-- --------------------------------------------------------
-- Host:                         localhost
-- Server version:               10.4.17-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for pergudangan
DROP DATABASE IF EXISTS `pergudangan`;
CREATE DATABASE IF NOT EXISTS `pergudangan` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `pergudangan`;

-- Dumping structure for table pergudangan.barang
DROP TABLE IF EXISTS `barang`;
CREATE TABLE IF NOT EXISTS `barang` (
  `id_barang` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_jenis_barang` int(10) unsigned NOT NULL,
  `barang` varchar(255) NOT NULL,
  `stock` int(10) DEFAULT NULL,
  PRIMARY KEY (`id_barang`),
  KEY `FK_id_jenis_barang` (`id_jenis_barang`),
  CONSTRAINT `FK_id_jenis_barang` FOREIGN KEY (`id_jenis_barang`) REFERENCES `jenis_barang` (`id_jenis_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table pergudangan.barang: ~4 rows (approximately)
/*!40000 ALTER TABLE `barang` DISABLE KEYS */;
INSERT INTO `barang` (`id_barang`, `id_jenis_barang`, `barang`, `stock`) VALUES
	(1, 1, 'Milo', 10),
	(3, 3, 'Sari Gandum', 100),
	(6, 5, 'Gayung', 70),
	(7, 6, 'Sendok', 1010);
/*!40000 ALTER TABLE `barang` ENABLE KEYS */;

-- Dumping structure for table pergudangan.barang_masuk
DROP TABLE IF EXISTS `barang_masuk`;
CREATE TABLE IF NOT EXISTS `barang_masuk` (
  `id_barang_masuk` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `id_order` int(10) unsigned NOT NULL,
  `jumlah_masuk` int(10) NOT NULL,
  PRIMARY KEY (`id_barang_masuk`),
  KEY `FK_id_order` (`id_order`),
  CONSTRAINT `FK_id_order` FOREIGN KEY (`id_order`) REFERENCES `order_barang` (`id_order`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table pergudangan.barang_masuk: ~2 rows (approximately)
/*!40000 ALTER TABLE `barang_masuk` DISABLE KEYS */;
INSERT INTO `barang_masuk` (`id_barang_masuk`, `id_order`, `jumlah_masuk`) VALUES
	(1, 2, 10),
	(2, 3, 25),
	(4, 2, 20);
/*!40000 ALTER TABLE `barang_masuk` ENABLE KEYS */;

-- Dumping structure for table pergudangan.jenis_barang
DROP TABLE IF EXISTS `jenis_barang`;
CREATE TABLE IF NOT EXISTS `jenis_barang` (
  `id_jenis_barang` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `jenis_barang` varchar(50) NOT NULL,
  `satuan` varchar(50) NOT NULL,
  PRIMARY KEY (`id_jenis_barang`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table pergudangan.jenis_barang: ~6 rows (approximately)
/*!40000 ALTER TABLE `jenis_barang` DISABLE KEYS */;
INSERT INTO `jenis_barang` (`id_jenis_barang`, `jenis_barang`, `satuan`) VALUES
	(1, 'Susu', 'Liter'),
	(2, 'Pakaian', 'Pcs'),
	(3, 'Beras', 'Liter'),
	(4, 'ATK', 'Unit'),
	(5, 'Alat Mandi', 'Box'),
	(6, 'Alat Makan', 'Box');
/*!40000 ALTER TABLE `jenis_barang` ENABLE KEYS */;

-- Dumping structure for table pergudangan.order_barang
DROP TABLE IF EXISTS `order_barang`;
CREATE TABLE IF NOT EXISTS `order_barang` (
  `id_order` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `id_barang` int(10) unsigned NOT NULL,
  `tanggal_order` date NOT NULL,
  `jumlah_order` int(10) NOT NULL,
  `status_order` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_order`),
  KEY `FK_id_barang` (`id_barang`),
  CONSTRAINT `FK_id_barang` FOREIGN KEY (`id_barang`) REFERENCES `barang` (`id_barang`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table pergudangan.order_barang: ~4 rows (approximately)
/*!40000 ALTER TABLE `order_barang` DISABLE KEYS */;
INSERT INTO `order_barang` (`id_order`, `id_barang`, `tanggal_order`, `jumlah_order`, `status_order`) VALUES
	(1, 1, '2022-01-13', 30, 1),
	(2, 3, '2022-01-13', 30, 1),
	(3, 6, '2022-01-13', 10, 1),
	(4, 7, '2022-01-13', 25, 1);
/*!40000 ALTER TABLE `order_barang` ENABLE KEYS */;

-- Dumping structure for table pergudangan.users
DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `id_user` int(3) unsigned NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `registered_at` date NOT NULL,
  PRIMARY KEY (`id_user`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

-- Dumping data for table pergudangan.users: ~2 rows (approximately)
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`id_user`, `username`, `password`, `registered_at`) VALUES
	(1, '1', 'c4ca4238a0b923820dcc509a6f75849b', '2021-12-22'),
	(2, '2', 'c81e728d9d4c2f636f067f89cc14862c', '2021-12-22'),
	(3, '3', 'eccbc87e4b5ce2fe28308fd9f2a7baf3', '2021-12-29');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
