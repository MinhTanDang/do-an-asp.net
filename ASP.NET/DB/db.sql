CREATE DATABASE WebBanHang;
GO

USE WebBanHang;
GO

--- Create tables ---
CREATE TABLE SanPham
(
	MaSP varchar(10) PRIMARY KEY NOT NULL,
	TenSP nvarchar(100),
	Mau nvarchar(10),
	KichThuoc int,
	AnhMinhHoa nvarchar(MAX),
	MoTa nvarchar(MAX),
	GiaTien int,
	SoLuongTonKho int,
	MaLoaiSP varchar(10),
	TrangThai bit DEFAULT 1 NOT NULL
);

CREATE TABLE LoaiSanPham
(
	MaLoaiSP varchar(10) PRIMARY KEY NOT NULL,
	TenLoaiSP nvarchar(100) NOT NULL,
	TrangThai bit DEFAULT 1 NOT NULL
);

CREATE TABLE TaiKhoan
(
	TenTaiKhoan varchar(30) PRIMARY KEY NOT NULL,
	MatKhau varchar(32) NOT NULL,
	HoTen nvarchar(100),
	Email nvarchar(100),
	SDT varchar(20),
	DiaChi nvarchar(MAX),
	AnhDaiDien nvarchar(MAX),
	LaAdmin bit DEFAULT 0 NOT NULL,
	TrangThai bit DEFAULT 1 NOT NULL
);

CREATE TABLE GioHang
(
	TenTaiKhoan varchar(30) NOT NULL,
	MaSP varchar(10) NOT NULL,
	SoLuong int DEFAULT 1 NOT NULL,
	CONSTRAINT PK_GioHang PRIMARY KEY (TenTaiKhoan, MaSP)
);

CREATE TABLE HoaDon
(
	MaHD varchar(10) PRIMARY KEY NOT NULL,
	TenTaiKhoan varchar(30) NOT NULL,
	NgayMua datetime,
	DiaChiGiaoHang nvarchar(MAX),
	SDTGiaoHang varchar(20),
	TongTien int,
	TrangThai bit DEFAULT 1 NOT NULL
);

CREATE TABLE CTHoaDon
(
	MaHD varchar(10) NOT NULL,
	MaSP varchar(10) NOT NULL,
	SoLuong int,
	DonGia int,
	CONSTRAINT PK_CTHoaDon PRIMARY KEY (MaHD, MaSP)
);

--- Create foreign key constraints
ALTER TABLE SanPham
ADD FOREIGN KEY (MaLoaiSP) REFERENCES LoaiSanPham(MaLoaiSP);

ALTER TABLE GioHang
ADD FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)

ALTER TABLE GioHang
ADD FOREIGN KEY (TenTaiKhoan) REFERENCES TaiKhoan(TenTaiKhoan)

ALTER TABLE HoaDon
ADD FOREIGN KEY (TenTaiKhoan) REFERENCES TaiKhoan(TenTaiKhoan)

ALTER TABLE CTHoaDon
ADD FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD)

ALTER TABLE CTHoaDon
ADD FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)

--- Insert values ---
--- into table LoaiSanPham ---
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP001', N'Converse', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP002', N'Nike', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP003', N'Adidas', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP004', N'Nike Jordan', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP005', N'Vans', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP006', N'Sketch', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP007', N'Yeezy', 1)
--- into SanPham ---
INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES ('SP001', N'Tên giày 1', '??', 35, 'giay-1.jpg', N'?ây là mô t? giày 1', 430000, 43, 'LSP001', 1)
INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES ('SP002', N'Tên giày 2', 'Cam', 36, 'giay-2.jpg', N'?ây là mô t? giày 2', 440000, 44, 'LSP002', 1)
INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES ('SP003', N'Tên giày 3', 'Vàng', 37, 'giay-3.jpg', N'?ây là mô t? giày 3', 450000, 45, 'LSP003', 1)
INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES ('SP004', N'Tên giày 4', 'L?c', 38, 'giay-4.jpg', N'?ây là mô t? giày 4', 460000, 46, 'LSP004', 1)
INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES ('SP005', N'Tên giày 5', 'Lam', 39, 'giay-5.jpg', N'?ây là mô t? giày 5', 470000, 47, 'LSP005', 1)
INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES ('SP006', N'Tên giày 6', 'Chàm', 40, 'giay-6.jpg', N'?ây là mô t? giày 6', 480000, 48, 'LSP006', 1)
INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES ('SP007', N'Tên giày 7', 'Tím', 41, 'giay-7.jpg', N'?ây là mô t? giày 7', 490000, 49, 'LSP007', 1)

--- into table TaiKhoan ---
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, HoTen, Email, SDT, DiaChi, AnhDaiDien, LaAdmin, TrangThai) VALUES ('admin', 'admin', N'Nguy?n Th? Admin', N'admin@webbanhang.com', '01234567890', N'Tp.H? Chí Minh', N'admin.jpg', 1, 1);
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, HoTen, Email, SDT, DiaChi, AnhDaiDien, LaAdmin, TrangThai) VALUES ('user01', 'user01', N'Nguy?n Th? User01', N'user01@webbanhang.com', '08683838970', N'Tp.H? Chí Minh', N'user01.jpg', 0, 1);
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, HoTen, Email, SDT, DiaChi, AnhDaiDien, LaAdmin, TrangThai) VALUES ('user02', 'user02', N'Nguy?n Th? User02', N'user02@webbanhang.com', '01234567890', N'Tp.H? Chí Minh', N'user02.jpg', 0, 0);

--- into table GioHang ---
INSERT INTO GioHang (TenTaiKhoan, MaSP, SoLuong) VALUES ('user01', 'SP001', 3)
INSERT INTO GioHang (TenTaiKhoan, MaSP, SoLuong) VALUES ('user01', 'SP002', 5)
INSERT INTO GioHang (TenTaiKhoan, MaSP, SoLuong) VALUES ('user01', 'SP003', 7)

--- into table HoaDon ---
INSERT INTO HoaDon (MaHD, TenTaiKhoan, NgayMua, DiaChiGiaoHang, SDTGiaoHang, TongTien, TrangThai) VALUES ('HD001', 'user01', '10-15-2019', N'45 Tân V?nh, ph??ng 4, qu?n 4, TP.HCM', '0868383897', 6640000, 1);

--- into table CTHoaDon ---
INSERT INTO CTHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES ('HD001', 'SP001', 3, 430000);
INSERT INTO CTHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES ('HD001', 'SP002', 5, 440000);
INSERT INTO CTHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES ('HD001', 'SP003', 7, 450000);
