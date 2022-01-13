-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 13 Jan 2022 pada 15.56
-- Versi server: 10.4.21-MariaDB
-- Versi PHP: 8.0.10

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
-- Struktur dari tabel `tbldosen`
--

CREATE TABLE `tbldosen` (
  `nidn` varchar(20) NOT NULL,
  `namaDosen` varchar(255) NOT NULL,
  `idUser` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblmahasiswa`
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

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_formulir`
--

CREATE TABLE `tbl_formulir` (
  `idDaftar` int(10) NOT NULL,
  `tglDaftar` date NOT NULL,
  `namaTempatMagang` varchar(255) NOT NULL,
  `durasiMagang` varchar(20) NOT NULL,
  `alamatTempatMagang` varchar(255) NOT NULL,
  `npm` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `idUser` int(10) NOT NULL,
  `namaUser` varchar(255) NOT NULL,
  `pwUser` varchar(255) NOT NULL,
  `jenisUser` enum('Admin','Mahasiswa','Dosen','') NOT NULL,
  `nama` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`idUser`, `namaUser`, `pwUser`, `jenisUser`, `nama`) VALUES
(1101181112, 'edofr', '123456', 'Admin', 'Edo Fitri Rifai');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbldosen`
--
ALTER TABLE `tbldosen`
  ADD PRIMARY KEY (`nidn`);

--
-- Indeks untuk tabel `tblmahasiswa`
--
ALTER TABLE `tblmahasiswa`
  ADD PRIMARY KEY (`npm`);

--
-- Indeks untuk tabel `tbl_formulir`
--
ALTER TABLE `tbl_formulir`
  ADD PRIMARY KEY (`idDaftar`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
