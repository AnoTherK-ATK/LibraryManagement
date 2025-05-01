-- Create the database with UTF-8 support
DROP DATABASE IF EXISTS ThuVienDB;
CREATE DATABASE ThuVienDB
CHARACTER SET utf8mb4
COLLATE utf8mb4_unicode_ci;

-- Use the database
USE ThuVienDB;

-- Create the BANGCAP (Degrees) table
CREATE TABLE BANGCAP (
    MaBangCap VARCHAR(10) PRIMARY KEY,
    TenBangCap VARCHAR(50) NOT NULL
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Create the BOPHAN (Departments) table
CREATE TABLE BOPHAN (
    MaBoPhan VARCHAR(10) PRIMARY KEY,
    TenBoPhan VARCHAR(50) NOT NULL
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Create the CHUCVU (Positions) table
CREATE TABLE CHUCVU (
    MaChucVu VARCHAR(10) PRIMARY KEY,
    TenChucVu VARCHAR(50) NOT NULL
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Create the NHANVIEN (Employees) table with foreign keys
CREATE TABLE NHANVIEN (
    MaNhanVien VARCHAR(10) PRIMARY KEY,
    HoTen VARCHAR(50) NOT NULL,
    DiaChi VARCHAR(200),
    NgaySinh DATE,
    DienThoai VARCHAR(15),
    MaBangCap VARCHAR(10) NOT NULL,
    MaBoPhan VARCHAR(10) NOT NULL,
    MaChucVu VARCHAR(10) NOT NULL,
    FOREIGN KEY (MaBangCap) REFERENCES BANGCAP(MaBangCap),
    FOREIGN KEY (MaBoPhan) REFERENCES BOPHAN(MaBoPhan),
    FOREIGN KEY (MaChucVu) REFERENCES CHUCVU(MaChucVu)
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Insert sample data into BANGCAP (5 types of degrees)
INSERT INTO BANGCAP (MaBangCap, TenBangCap) VALUES
('BC01', 'Tú Tài'),
('BC02', 'Trung Cấp'),
('BC03', 'Cao Đẳng'),
('BC04', 'Đại Học'),
('BC05', 'Thạc Sĩ'),
('BC06', 'Tiến Sĩ');

-- Insert sample data into BOPHAN (4 departments)
INSERT INTO BOPHAN (MaBoPhan, TenBoPhan) VALUES
('BP01', 'Thủ Thư'),
('BP02', 'Thủ Kho'),
('BP03', 'Thủ Quỹ'),
('BP04', 'Ban Giám Đốc');

-- Insert sample data into CHUCVU (5 positions)
INSERT INTO CHUCVU (MaChucVu, TenChucVu) VALUES
('CV01', 'Giám Đốc'),
('CV02', 'Phó Giám Đốc'),
('CV03', 'Trưởng Phòng'),
('CV04', 'Phó Phòng'),
('CV05', 'Nhân Viên');

-- Create the LOAIDOCGIA (Reader Types) table
CREATE TABLE LOAIDOCGIA (
    MaLoaiDocGia VARCHAR(10) PRIMARY KEY,
    TenLoaiDocGia VARCHAR(50) NOT NULL
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Create the THEDOCGIA (Reader Cards) table with foreign keys
CREATE TABLE THEDOCGIA (
    MaDocGia VARCHAR(10) PRIMARY KEY,
    HoTen VARCHAR(50) NOT NULL,
    NgaySinh DATE,
    DiaChi VARCHAR(200),
    Email VARCHAR(100),
    NgayLapThe DATE NOT NULL,
    NgayHetHan DATE NOT NULL,
    MaLoaiDocGia VARCHAR(10) NOT NULL,
    MaNhanVien VARCHAR(10) NOT NULL,
    FOREIGN KEY (MaLoaiDocGia) REFERENCES LOAIDOCGIA(MaLoaiDocGia),
    FOREIGN KEY (MaNhanVien) REFERENCES NHANVIEN(MaNhanVien)
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Create the THAMSO (Parameters) table
CREATE TABLE THAMSO (
    TuoiToiThieu INT NOT NULL,
    TuoiToiDa INT NOT NULL,
    GiaTriThe INT NOT NULL
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Insert sample data into THAMSO (Parameters)
INSERT INTO THAMSO (TuoiToiThieu, TuoiToiDa, GiaTriThe) VALUES
(18, 55, 6);