CREATE DATABASE  IF NOT EXISTS `thuviendb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `thuviendb`;
-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: thuviendb
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bangcap`
--

DROP TABLE IF EXISTS `bangcap`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bangcap` (
  `MaBangCap` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `TenBangCap` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`MaBangCap`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bangcap`
--

LOCK TABLES `bangcap` WRITE;
/*!40000 ALTER TABLE `bangcap` DISABLE KEYS */;
INSERT INTO `bangcap` VALUES ('BC01','Tú Tài'),('BC02','Trung Cấp'),('BC03','Cao Đẳng'),('BC04','Đại Học'),('BC05','Thạc Sĩ'),('BC06','Tiến Sĩ');
/*!40000 ALTER TABLE `bangcap` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bophan`
--

DROP TABLE IF EXISTS `bophan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bophan` (
  `MaBoPhan` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `TenBoPhan` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `QuyenLapThe` tinyint(1) NOT NULL DEFAULT '0',
  `QuyenNhanSach` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`MaBoPhan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bophan`
--

LOCK TABLES `bophan` WRITE;
/*!40000 ALTER TABLE `bophan` DISABLE KEYS */;
INSERT INTO `bophan` VALUES ('BP01','Thủ Thư',1,0),('BP02','Thủ Kho',0,1),('BP03','Thủ Quỹ',0,0),('BP04','Ban Giám Đốc',0,0);
/*!40000 ALTER TABLE `bophan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chucvu`
--

DROP TABLE IF EXISTS `chucvu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `chucvu` (
  `MaChucVu` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `TenChucVu` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`MaChucVu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chucvu`
--

LOCK TABLES `chucvu` WRITE;
/*!40000 ALTER TABLE `chucvu` DISABLE KEYS */;
INSERT INTO `chucvu` VALUES ('CV01','Giám Đốc'),('CV02','Phó Giám Đốc'),('CV03','Trưởng Phòng'),('CV04','Phó Phòng'),('CV05','Nhân Viên');
/*!40000 ALTER TABLE `chucvu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `loaidocgia`
--

DROP TABLE IF EXISTS `loaidocgia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `loaidocgia` (
  `MaLoaiDocGia` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `TenLoaiDocGia` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`MaLoaiDocGia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loaidocgia`
--

LOCK TABLES `loaidocgia` WRITE;
/*!40000 ALTER TABLE `loaidocgia` DISABLE KEYS */;
INSERT INTO `loaidocgia` VALUES ('LDG01','X'),('LDG02','Y');
/*!40000 ALTER TABLE `loaidocgia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nhanvien`
--

DROP TABLE IF EXISTS `nhanvien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nhanvien` (
  `MaNhanVien` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `HoTen` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `DiaChi` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `NgaySinh` date DEFAULT NULL,
  `DienThoai` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `MaBangCap` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `MaBoPhan` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `MaChucVu` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`MaNhanVien`),
  KEY `MaBangCap` (`MaBangCap`),
  KEY `MaBoPhan` (`MaBoPhan`),
  KEY `MaChucVu` (`MaChucVu`),
  CONSTRAINT `NHANVIEN_ibfk_1` FOREIGN KEY (`MaBangCap`) REFERENCES `bangcap` (`MaBangCap`),
  CONSTRAINT `NHANVIEN_ibfk_2` FOREIGN KEY (`MaBoPhan`) REFERENCES `bophan` (`MaBoPhan`),
  CONSTRAINT `NHANVIEN_ibfk_3` FOREIGN KEY (`MaChucVu`) REFERENCES `chucvu` (`MaChucVu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nhanvien`
--

LOCK TABLES `nhanvien` WRITE;
/*!40000 ALTER TABLE `nhanvien` DISABLE KEYS */;
INSERT INTO `nhanvien` VALUES ('NV0001','3432432432','234324324','1980-01-01','0912345678','BC03','BP03','CV04'),('NV0002','asdsada','asfasfas','1973-01-01','0912345678','BC04','BP02','CV03'),('NV0003','12323123','123','1980-01-01','012312312','BC03','BP01','CV03'),('NV0004','Messi','HCM','1980-05-01','0101000034','BC04','BP03','CV05');
/*!40000 ALTER TABLE `nhanvien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `phieumuonsach`
--

DROP TABLE IF EXISTS `phieumuonsach`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `phieumuonsach` (
  `MaPhieuMuonSach` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `NgayMuon` date NOT NULL,
  `MaDocGia` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `HanTraSach` date DEFAULT NULL,
  PRIMARY KEY (`MaPhieuMuonSach`),
  KEY `MaDocGia` (`MaDocGia`),
  CONSTRAINT `PHIEUMUONSACH_ibfk_1` FOREIGN KEY (`MaDocGia`) REFERENCES `thedocgia` (`MaDocGia`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phieumuonsach`
--

LOCK TABLES `phieumuonsach` WRITE;
/*!40000 ALTER TABLE `phieumuonsach` DISABLE KEYS */;
INSERT INTO `phieumuonsach` VALUES ('PM0001','2025-05-25','TDG0001','2025-05-27'),('PM0002','2025-05-26','TDG0002','2025-05-28');
/*!40000 ALTER TABLE `phieumuonsach` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sach`
--

DROP TABLE IF EXISTS `sach`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sach` (
  `MaSach` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `TenSach` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `MaTheLoai` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `TacGia` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `NamXuatBan` year DEFAULT NULL,
  `NhaXuatBan` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `NgayNhap` date NOT NULL,
  `TriGia` int NOT NULL,
  `MaNhanVien` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `TinhTrang` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'Chưa mượn',
  PRIMARY KEY (`MaSach`),
  KEY `MaTheLoai` (`MaTheLoai`),
  KEY `MaNhanVien` (`MaNhanVien`),
  CONSTRAINT `SACH_ibfk_1` FOREIGN KEY (`MaTheLoai`) REFERENCES `theloai` (`MaTheLoai`),
  CONSTRAINT `SACH_ibfk_2` FOREIGN KEY (`MaNhanVien`) REFERENCES `nhanvien` (`MaNhanVien`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sach`
--

LOCK TABLES `sach` WRITE;
/*!40000 ALTER TABLE `sach` DISABLE KEYS */;
INSERT INTO `sach` VALUES ('S0001','Ai đã đặt tên cho dòng sông','TL02','Hoàng Phủ Ngọc Tường',2018,'NXB Giáo dục','2020-01-28',129000,'NV0002','Chưa mượn'),('S0002','12r','TL02','qwfqwf',2020,'wqrqwr3','2025-05-07',24125,'NV0002','Chưa mượn');
/*!40000 ALTER TABLE `sach` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thamso`
--

DROP TABLE IF EXISTS `thamso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `thamso` (
  `TuoiToiThieu` int NOT NULL,
  `TuoiToiDa` int NOT NULL,
  `GiaTriThe` int NOT NULL,
  `ThoiGianNhapSachToiDa` int NOT NULL,
  `HanMuonSachToiDa` int DEFAULT NULL,
  `SachMuonToiDaTheoThoiGianQuyDinh` int DEFAULT NULL,
  `ThoiGianMuonSachTheoQuyDinh` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thamso`
--

LOCK TABLES `thamso` WRITE;
/*!40000 ALTER TABLE `thamso` DISABLE KEYS */;
INSERT INTO `thamso` VALUES (18,55,6,8,10,3,4);
/*!40000 ALTER TABLE `thamso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thedocgia`
--

DROP TABLE IF EXISTS `thedocgia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `thedocgia` (
  `MaDocGia` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `HoTen` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `NgaySinh` date DEFAULT NULL,
  `DiaChi` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `Email` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `NgayLapThe` date NOT NULL,
  `NgayHetHan` date NOT NULL,
  `MaLoaiDocGia` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `MaNhanVien` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`MaDocGia`),
  KEY `MaLoaiDocGia` (`MaLoaiDocGia`),
  KEY `MaNhanVien` (`MaNhanVien`),
  CONSTRAINT `THEDOCGIA_ibfk_1` FOREIGN KEY (`MaLoaiDocGia`) REFERENCES `loaidocgia` (`MaLoaiDocGia`),
  CONSTRAINT `THEDOCGIA_ibfk_2` FOREIGN KEY (`MaNhanVien`) REFERENCES `nhanvien` (`MaNhanVien`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thedocgia`
--

LOCK TABLES `thedocgia` WRITE;
/*!40000 ALTER TABLE `thedocgia` DISABLE KEYS */;
INSERT INTO `thedocgia` VALUES ('TDG0001','rqwrqwr','1995-05-28','qwfqwfwqf','gdsgw','2025-05-28','2025-11-28','LDG01','NV0003'),('TDG0002','Tống Trần Tiến Dũng','2003-12-20','KTX Khu B','anhmmessi@gmail.com','2025-05-28','2025-11-28','LDG01','NV0003'),('TDG0003','Nguyễn Văn A','2000-05-15','123 Đường ABC, Hà Nội','vana@example.com','2024-06-01','2025-05-28','LDG01','NV0001'),('TDG0004','Nguyễn Văn B','2000-05-15',' Hà Nội','vana@example.com','2024-06-01','2025-06-01','LDG01','NV0001');
/*!40000 ALTER TABLE `thedocgia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `theloai`
--

DROP TABLE IF EXISTS `theloai`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `theloai` (
  `MaTheLoai` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `TenTheLoai` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`MaTheLoai`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `theloai`
--

LOCK TABLES `theloai` WRITE;
/*!40000 ALTER TABLE `theloai` DISABLE KEYS */;
INSERT INTO `theloai` VALUES ('TL01','A'),('TL02','B'),('TL03','C');
/*!40000 ALTER TABLE `theloai` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thongtinsachmuon`
--

DROP TABLE IF EXISTS `thongtinsachmuon`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `thongtinsachmuon` (
  `MaPhieuMuonSach` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `MaSach` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `TrangThai` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`MaPhieuMuonSach`,`MaSach`),
  KEY `MaSach` (`MaSach`),
  CONSTRAINT `THONGTINSACHMUON_ibfk_1` FOREIGN KEY (`MaPhieuMuonSach`) REFERENCES `phieumuonsach` (`MaPhieuMuonSach`),
  CONSTRAINT `THONGTINSACHMUON_ibfk_2` FOREIGN KEY (`MaSach`) REFERENCES `sach` (`MaSach`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thongtinsachmuon`
--

LOCK TABLES `thongtinsachmuon` WRITE;
/*!40000 ALTER TABLE `thongtinsachmuon` DISABLE KEYS */;
INSERT INTO `thongtinsachmuon` VALUES ('PM0001','S0001','Đã trả'),('PM0001','S0002','Đã trả'),('PM0002','S0001','Đang mượn'),('PM0002','S0002','Đang mượn');
/*!40000 ALTER TABLE `thongtinsachmuon` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-29 14:43:50