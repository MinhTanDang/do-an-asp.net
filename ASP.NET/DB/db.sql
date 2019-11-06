CREATE DATABASE WebBanHangASP;
GO

USE WebBanHangASP;
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
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP004', N'Vans', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP005', N'Fendi', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP006', N'Valentino', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP007', N'SlipOn', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP008', N'Y-3', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP009', N'Lacoste', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP0010', N'Reebok', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP0011', N'Puma', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP0012', N'New Balance', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP0013', N'Alexander', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP0014', N'Asics', 1)
INSERT INTO LoaiSanPham (MaLoaiSP, TenLoaiSP, TrangThai) VALUES ('LSP0015', N'Balenciaga', 1)


--- into SanPham ---
INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES ('SP001', N'Adidas', 'Đen-xám', 40, 'adidas-profier-prophere-đen-xam-40.jpg', N'adidas-profier-prophere-đen-xam-size40', 1200000, 43, 'LSP003', 1)
INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES ('SP002', N'Alexander', 'Đen', 39, 'alexander-mcqueen-đen-39.jpg', N'alexander-mcqueen-đen-39', 699000, 44, 'LSP0013', 1)
INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES ('SP003', N'Asics', 'Trắng-đen', 41, 'asics-court-trang-đen-41.jpg', N'asics-court-trang-đen-41',700000, 45, 'LSP0014', 1)
INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES ('SP004', N'Balenciaga', 'Trắng', 39, 'Balenciaga-triple-replica-trang-39.jpg', N'Balenciaga-triple-replica-trang-39', 6499000, 46, 'LSP0015', 1)
INSERT INTO SanPham (MaSP, TenSP, Mau, KichThuoc, AnhMinhHoa, MoTa, GiaTien, SoLuongTonKho, MaLoaiSP, TrangThai) VALUES ('SP005', N'Fendi', 'Đen-nâu', 42, 'fendi-đen-nau-42.jpg', N'fendi-đen-nau-42', 1470000, 47, 'LSP005', 1)

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
