-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 16, 2024 at 10:51 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `penjualan`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `ProsesTransaksi` (IN `p_id_barang` INT, IN `p_id_user` INT, IN `p_jumlah_barang` INT, IN `p_tunai` DECIMAL(10,2), OUT `p_id_transaksi` INT, OUT `p_kembalian` DECIMAL(10,2))   BEGIN
    DECLARE v_harga_barang DECIMAL(10,2);
    DECLARE v_subtotal DECIMAL(10,2);
    
    -- Ambil harga barang dari tabel barang
    SELECT harga INTO v_harga_barang FROM barang WHERE id_barang = p_id_barang;
    
    -- Hitung subtotal
    SET v_subtotal = p_jumlah_barang * v_harga_barang;
    
    -- Masukkan transaksi baru
    INSERT INTO transaksi (id_barang, id_user, jumlah_barang, subtotal, tunai)
    VALUES (p_id_barang, p_id_user, p_jumlah_barang, v_subtotal, p_tunai);
    
    -- Ambil ID transaksi yang baru saja dimasukkan
    SET p_id_transaksi = LAST_INSERT_ID();
    
    -- Hitung kembalian
    SET p_kembalian = p_tunai - v_subtotal;
    
    -- Update stok barang
    UPDATE barang SET stok = stok - p_jumlah_barang WHERE id_barang = p_id_barang;
    
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `barang`
--

CREATE TABLE `barang` (
  `id_barang` int(11) NOT NULL,
  `nama_barang` varchar(50) NOT NULL,
  `harga` int(25) NOT NULL,
  `stock` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `barang`
--

INSERT INTO `barang` (`id_barang`, `nama_barang`, `harga`, `stock`) VALUES
(2, 'keyboard', 30000, 50),
(3, 'headset', 90000, 50);

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` int(11) NOT NULL,
  `id_user` int(11) NOT NULL,
  `id_barang` int(11) NOT NULL,
  `jumlah_barang` int(60) NOT NULL,
  `subtotal` int(255) NOT NULL,
  `diskon` int(255) NOT NULL,
  `tunai` int(255) NOT NULL,
  `kembalian` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `id_user`, `id_barang`, `jumlah_barang`, `subtotal`, `diskon`, `tunai`, `kembalian`) VALUES
(6, 6, 3, 123123, 1231231, 12312312, 31231313, 1313131),
(7, 6, 3, 123123, 1232131, 3123123, 1231231, 31231231);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id_user` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(12) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `role` enum('kasir','admin') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id_user`, `username`, `password`, `nama`, `role`) VALUES
(2, 'nadra', 'test', 'ceyo', 'kasir'),
(3, 'ceyo', 'kasir', 'zaki', 'kasir'),
(5, 'test', 'test', 'test', 'kasir'),
(6, 'admin', 'admin', 'ceyo', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`id_barang`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `id_user` (`id_user`),
  ADD KEY `id_barang` (`id_barang`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `id_barang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `id_transaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `fk_table2_table1` FOREIGN KEY (`id_user`) REFERENCES `user` (`id_user`),
  ADD CONSTRAINT `fk_table3_table2` FOREIGN KEY (`id_barang`) REFERENCES `barang` (`id_barang`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
