-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 13, 2022 at 05:01 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 8.1.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbappmagang3`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbldosen`
--

CREATE TABLE `tbldosen` (
  `nidn` varchar(20) NOT NULL,
  `namaDosen` varchar(255) NOT NULL,
  `idUser` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `tblmahasiswa`
--

CREATE TABLE `tblmahasiswa` (
  `npm` int(10) NOT NULL,
  `namaMahasiswa` varchar(255) NOT NULL,
  `tempatLahir` varchar(100) NOT NULL,
  `tanggalLahir` date NOT NULL,
  `fakultas` varchar(100) NOT NULL,
  `jurusan` varchar(100) NOT NULL,
  `tahunMasuk` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblmahasiswa`
--

INSERT INTO `tblmahasiswa` (`npm`, `namaMahasiswa`, `tempatLahir`, `tanggalLahir`, `fakultas`, `jurusan`, `tahunMasuk`) VALUES
(1101181109, 'Aska Erlangga', 'Serang', '2000-01-01', 'Ilmu Komputer', 'Teknik Informatika', '2018-01-01');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_formulir`
--

CREATE TABLE `tbl_formulir` (
  `idDaftar` int(10) NOT NULL,
  `tglDaftar` date NOT NULL,
  `namaTempatMagang` varchar(255) NOT NULL,
  `durasiMagang` varchar(20) NOT NULL,
  `alamatTempatMagang` varchar(255) NOT NULL,
  `npm` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_formulir`
--

INSERT INTO `tbl_formulir` (`idDaftar`, `tglDaftar`, `namaTempatMagang`, `durasiMagang`, `alamatTempatMagang`, `npm`) VALUES
(1, '2022-01-13', 'Bappeda', '30', 'Serang', 1101181109),
(2, '2022-01-13', 'Diskominfo', '30', 'Serang', 1101181112);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `idUser` int(10) NOT NULL,
  `namaUser` varchar(255) NOT NULL,
  `pwUser` varchar(255) NOT NULL,
  `jenisUser` enum('Admin','Mahasiswa','Dosen','') NOT NULL,
  `nama` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`idUser`, `namaUser`, `pwUser`, `jenisUser`, `nama`) VALUES
(1101181112, 'edofr', '123456', 'Admin', 'Edo Fitri Rifai'),
(1, 'askaerlangga', '12345678', 'Mahasiswa', 'Aska Erlangga'),
(2, 'admin', 'admin', 'Admin', 'Admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbldosen`
--
ALTER TABLE `tbldosen`
  ADD PRIMARY KEY (`nidn`);

--
-- Indexes for table `tblmahasiswa`
--
ALTER TABLE `tblmahasiswa`
  ADD PRIMARY KEY (`npm`);

--
-- Indexes for table `tbl_formulir`
--
ALTER TABLE `tbl_formulir`
  ADD PRIMARY KEY (`idDaftar`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_formulir`
--
ALTER TABLE `tbl_formulir`
  MODIFY `idDaftar` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
