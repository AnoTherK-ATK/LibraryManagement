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
    TenBoPhan VARCHAR(50) NOT NULL,
    QuyenLapThe BOOLEAN NOT NULL DEFAULT FALSE
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Create the CHUCVU (Positions) table
CREATE TABLE CHUCVU (
    MaChucVu VARCHAR(10) PRIMARY KEY,
    TenChucVu VARCHAR(50) NOT NULL
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Create the NHANVIEN (Employees) table
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

-- Insert sample data into BANGCAP
INSERT INTO BANGCAP (MaBangCap, TenBangCap) VALUES
('BC01', 'Tú Tài'),
('BC02', 'Trung Cấp'),
('BC03', 'Cao Đẳng'),
('BC04', 'Đại Học'),
('BC05', 'Thạc Sĩ'),
('BC06', 'Tiến Sĩ');

-- Insert sample data into BOPHAN
INSERT INTO BOPHAN (MaBoPhan, TenBoPhan, QuyenLapThe) VALUES
('BP01', 'Thủ Thư', TRUE),
('BP02', 'Thủ Kho', FALSE),
('BP03', 'Thủ Quỹ', FALSE),
('BP04', 'Ban Giám Đốc', FALSE);

-- Insert sample data into CHUCVU
INSERT INTO CHUCVU (MaChucVu, TenChucVu) VALUES
('CV01', 'Giám Đốc'),
('CV02', 'Phó Giám Đốc'),
('CV03', 'Trưởng Phòng'),
('CV04', 'Phó Phòng'),
('CV05', 'Nhân Viên');

-- Create the LOAIDOCGIA table
CREATE TABLE LOAIDOCGIA (
    MaLoaiDocGia VARCHAR(10) PRIMARY KEY,
    TenLoaiDocGia VARCHAR(50) NOT NULL
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Create the THEDOCGIA table
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

-- Insert sample data into LOAIDOCGIA
INSERT INTO LOAIDOCGIA (MaLoaiDocGia, TenLoaiDocGia) VALUES
('LDG01', 'X'),
('LDG02', 'Y');

-- Create the THAMSO table
CREATE TABLE THAMSO (
    TuoiToiThieu INT NOT NULL,
    TuoiToiDa INT NOT NULL,
    GiaTriThe INT NOT NULL
) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;

-- Insert sample data into THAMSO
INSERT INTO THAMSO (TuoiToiThieu, TuoiToiDa, GiaTriThe) VALUES
(18, 55, 6);