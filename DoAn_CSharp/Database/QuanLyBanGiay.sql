create database QuanLyBanGiay4
go
use QuanLyBanGiay4
CREATE TABLE chucvu (
    MaCV INT IDENTITY(1,1) PRIMARY KEY,
    TenCV NVARCHAR(255)
);
select * from chucvu
INSERT INTO chucvu ( TenCV) VALUES
( N'admin'),
( N'manager');
CREATE TABLE  danhmuc(
    MaDanhMuc INT IDENTITY(1,1) PRIMARY KEY,
    TenDM NVARCHAR(255),
    TrangThaiDM NVARCHAR(255) NOT NULL DEFAULT N'Mở'
);

INSERT INTO danhmuc (TenDM, TrangThaiDM) VALUES
(N'ADIDAS', N'Mở'),
(N'NIKEs', N'Mở'),
(N'CONVERSE', N'Mở'),
(N'VANS', N'Mở'),
(N'RieVienan', N'Mở'),
(N'PUMA', N'Mở');
-- Tạo bảng khachhang
CREATE TABLE khachhang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    HoTenKH NVARCHAR(255),
    DiaChiKH NVARCHAR(255),
    SDTKH NVARCHAR(15),
    CMNDKH NVARCHAR(20),
    GioiTinhKH NVARCHAR(10),
    TrangThaiKH NVARCHAR(255) NOT NULL DEFAULT N'Mở'
) ;

-- Đang đổ dữ liệu cho bảng `tbl_khachhang`
INSERT INTO khachhang (HoTenKH, DiaChiKH, SDTKH, CMNDKH, GioiTinhKH, TrangThaiKH) VALUES
(N'Trần Thanh Phong', N'Long An', '034342433', '234625345', N'Nam', N'Mở'),
(N'Trần Văn Tiến', N'78 Nguyễn Văn Cừ, P2, Q5, HCMM', '0345838581', '873732723', N'Nam', N'Mở'),
(N'Nguyễn Thanh Toán', N'34 Nguyễn Trãi, P1, Q5, HCM', '0949529592', '347737787', N'Nam', N'Mở'),
(N'Nguyễn Văn Hoàng', N'Hà Nội', '0394939495', '345234567', N'Nam', N'Mở'),
(N'Hùng Lâm', N'Quận 10', '0459345345', '342442123', N'Nam', N'Mở'),
(N'Kiều Oanh', N'Tân Bình', '0453450454', '345765234', N'Nữ', N'Mở'),
(N'Nguyễn Thế Phong', N'HCM', '0453455443', '345123567', N'Nam', N'Mở'),
(N'Tài Smile', N'Đà Lạt', '0342342342', '234343324', N'Khác', N'Mở'),
(N'Trần Thanh Phong', N'84 Nguyễn Trãi, Q5', '0454543353', '234432234', N'Nam', N'Mở');
-- tao bang nhan vien

CREATE TABLE nhanvien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    MaCV INT  NOT NULL ,
    TenTaiKhoanNV NVARCHAR(255) NOT NULL ,
    MatKhauNV NVARCHAR(255) NOT NULL ,
    HoTenNV NVARCHAR(255) NOT NULL ,
    DiaChiNV NVARCHAR(255) NOT NULL ,
    SDTNV NVARCHAR(15) NOT NULL ,
    CMNDNV NVARCHAR(20) NOT NULL ,
    GioiTinhNV NVARCHAR(10) NOT NULL ,
    NgaySinh DATE NOT NULL,
    EmailNV NVARCHAR(255) NOT NULL ,
    AnhNV VARCHAR(50) DEFAULT NULL,
    TrangThaiNV NVARCHAR(255) NOT NULL DEFAULT N'Mở',
    CONSTRAINT FK_ChucVu FOREIGN KEY (MaCV) REFERENCES chucvu (MaCV)
);

-- Insert data into nhanvien table
INSERT INTO nhanvien (MaCV, TenTaiKhoanNV, MatKhauNV, HoTenNV, DiaChiNV, SDTNV, CMNDNV, GioiTinhNV, NgaySinh, EmailNV, AnhNV, TrangThaiNV)
VALUES
(1, N'admin', N'admin', N'Nguyễn Văn Admin', N'Địa chỉ Admin', '0349529529', '349943943', N'Nam', '2001-04-11', N'chauquocalin1@gmail.com', '1663302522811.jpg', N'Mở'),
(2, N'manager', N'thaibao', N'Nguyễn Văn Manager', N'Địa chỉ Manager', '0349529529', '349943943', N'Nam', '2001-04-11', N'chauquocalin1@gmail.com', '1663302522811.jpg', N'Mở');

CREATE TABLE nhacungcap (
    MaNCC INT IDENTITY(1,1) PRIMARY KEY,
    TenNCC NVARCHAR(255),
    DiaChiNCC NVARCHAR(255),
    SDTNCC NVARCHAR(15),
    Email NVARCHAR(255),
    TrangThaiNCC NVARCHAR(255) NOT NULL DEFAULT N'Mở'
);
INSERT INTO nhacungcap (TenNCC, DiaChiNCC, SDTNCC, Email, TrangThaiNCC) VALUES
(N'Nike Crescent Mall', N'Tầng 2, Tòa nhà Crescent Mall, Phú Mỹ Hưng, Q. 7, TP. HCM', '254115559', 'letuananh@gmail.com', N'Mở'),
(N'Nike 93 Nguyễn Trãi', N'93-95 Nguyễn Trãi, P. Bến Thành, Q. 1, TP. HCM', '283620906', 'letuananh@gmail.com', N'Mở'),
(N'Kho giày tân bình', N'45 Út Tịch', '49543234', 'letuananh@gmail.com', N'Mở'),
(N'Adidas Bitexco', N'Tòa nhà Bitexco, số 2 Hải Triều, quận 1, thành phố Hồ Chí Minh', '283916079', 'letuananh@gmail.com', N'Mở'),
(N'Vans house', N'89 Âu Cơ', '945424354', 'letuananh@gmail.com', N'Mở'),
(N'Ananas Store', N'78 Nguyễn Trãi', '413231923', 'letuananh@gmail.com', N'Mở');


-- Tạo bảng phieunhap
CREATE TABLE phieunhap (
    MaPhieuNhap INT IDENTITY(1,1) PRIMARY KEY,
    MaNV INT,
    NgayLapPhieu DATE,
    TrangThaiPN NVARCHAR(255) NOT NULL DEFAULT N'Mở' ,
    FOREIGN KEY (MaNV) REFERENCES nhanvien(MaNV)
);

-- Đang đổ dữ liệu cho bảng `tbl_phieunhap`

INSERT INTO phieunhap (MaNV, NgayLapPhieu , TrangThaiPN) VALUES
(2, '2020-06-19', N'Mở'),
(2, '2020-06-19', N'Mở'),
(2, '2020-06-19', N'Mở'),
(2, '2020-06-19', N'Mở'),
(1, '2022-09-09', N'Mở');

CREATE TABLE  Sizes(
    MaSize INT IDENTITY(1,1) PRIMARY KEY,
    TenSize INT,
    TrangThaiSize NVARCHAR(255) NOT NULL DEFAULT N'Mở'
);

INSERT INTO Sizes ( TenSize) VALUES
( 37),
( 38),
( 39),
( 40),
(41);
-- Tạo bảng sanpham
CREATE TABLE sanpham (
    MaSP INT IDENTITY(1,1) PRIMARY KEY,
    MaNCC INT NOT NULL,
    MaDM INT NOT NULL,
    TenSP NVARCHAR(255) NOT NULL,
    MieuTaSP NVARCHAR(MAX) NOT NULL,
    DonGia DECIMAL(18,2) NOT NULL,
    TrangThaiSP NVARCHAR(255) NOT NULL DEFAULT N'Mở',
    AnhSP NVARCHAR(255) DEFAULT NULL, -- Adjusted column size
    FOREIGN KEY (MaNCC) REFERENCES nhacungcap(MaNCC),
    FOREIGN KEY (MaDM) REFERENCES danhmuc(MaDanhMuc),
    CONSTRAINT CHK_GiaNonNegative CHECK (DonGia >= 0)
);
-- Đang đổ dữ liệu cho bảng `sanpham`
INSERT INTO sanpham (MaNCC, MaDM, TenSP, MieuTaSP, DonGia, TrangThaiSP, AnhSP) VALUES
(4, 1, N'ASICS GEL-RESPECTOR BLACK GOLD', N'Okeyyyy...kk', 2390000, N'Mở', N'1662728173320.jpg'),
(3, 6, N'PUMA RS-100 SOUND MEN SNEAKERS', N'Okeyyy', 1400000, N'Mở', N'1662728239245.jpg'),
(1, 2, N'NIKE AIR FORCE 1 SHADOW AQUA PINK',  N'Good...', 4600000, N'Mở', N'1662728351010.jpg');

CREATE TABLE  SanPhamSize(
    MaSize INT NOT NULL,
	MaSP INT NOT NULL,
	SoLuongSP INT DEFAULT 0 NOT NULL,
	FOREIGN KEY (MaSize) REFERENCES Sizes(MaSize),
    FOREIGN KEY (MaSP) REFERENCES sanpham(MaSP),

);

INSERT INTO SanPhamSize (MaSize, MaSP, SoLuongSP)VALUES
(1, 1, 10),
(1, 2, 10),
(1, 3, 20),
(2, 1, 20),
(2, 2, 20),
(2, 3, 20),
(3, 1, 30),
(3, 2, 30),
(3, 3, 30);


-- Tạo bảng giảm giá
CREATE TABLE giamgia (
    MaGiamGia INT IDENTITY(1,1) PRIMARY KEY,
    TenGiamGia NVARCHAR(255) NOT NULL,
    MaSP INT FOREIGN KEY REFERENCES sanpham(MaSP),
    MaCV INT FOREIGN KEY REFERENCES chucvu(MaCV),
    SoLuongGG INT NOT NULL,
    PhanTramGiam INT NOT NULL CHECK (PhanTramGiam BETWEEN 0 AND 100),
    NgayBatDau DATE NOT NULL,
    NgayKetThuc DATE NOT NULL,
    CONSTRAINT CHK_NgayKetThuc CHECK (NgayKetThuc > NgayBatDau) -- Ràng buộc ngày kết thúc sau ngày bắt đầu
);


-- Thêm dữ liệu vào bảng `giamgia`
INSERT INTO giamgia (TenGiamGia, MaSP, MaCV, SoLuongGG, PhanTramGiam, NgayBatDau, NgayKetThuc) VALUES
(N'Giảm giá mùa hè', 1, 1, 50, 10, '2023-07-01', '2023-08-01'),
(N'Khuyến mãi đặc biệt', 2, 2, 30, 15, '2023-09-01', '2023-09-30'),
(N'Ưu đãi cuối năm', 3, 1, 20, 5, '2023-11-01', '2023-12-31');

-- Tạo bảng hóa đơn
CREATE TABLE hoadon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    MaKH INT,
    MaNV INT,
    NgayLapHD DATE,
    TrangThaiHD NVARCHAR(255) NOT NULL DEFAULT N'Mở',
    FOREIGN KEY (MaKH) REFERENCES khachhang(MaKH),
    FOREIGN KEY (MaNV) REFERENCES nhanvien(MaNV)
);
-- Đang đổ dữ liệu cho bảng `tbl_hoadon`
INSERT INTO hoadon (MaKH, MaNV, NgayLapHD, TrangThaiHD) VALUES
(1, 1, '2023-06-19', N'Mở'),
(2, 1, '2023-06-19', N'Mở'),
(3, 2, '2023-06-19', N'Mở'),
(4, 2, '2023-06-19', N'Mở'),
(5, 2, '2023-09-09', N'Mở');



-- Tạo bảng chitiethd
CREATE TABLE chitiethd (
    MaCTHD INT Identity(1,1) PRIMARY KEY,
    MaHD INT NOT NULL,
    MaSP INT NOT NULL,
    DonGia FLOAT NOT NULL,
	SoLuongSP INT NOT NULL,
    ThanhTien FLOAT NOT NULL,
    FOREIGN KEY (MaHD) REFERENCES hoadon(MaHD),
    FOREIGN KEY (MaSP) REFERENCES sanpham(MaSP),
);

-- Insert data into chitiethd table
INSERT INTO chitiethd (MaHD, MaSP, DonGia, SoLuongSP,ThanhTien) VALUES
(1, 1, 1500000,10 ,1500000), -- Adjust the values accordingly
(2, 2, 1200000, 5,2400000),
(4, 3, 4600000, 5,4600000),
(4, 1, 5500000, 5,11000000),
(5, 2, 5500000, 5,5500000);

-- Tạo bảng chitietphieunhap
CREATE TABLE chitietphieunhap (
    MaCTPN INT Identity(1,1) PRIMARY KEY,
    MaPhieuNhap INT,
    MaSP INT,
    SoLuongNhap INT,
    FOREIGN KEY (MaPhieuNhap) REFERENCES phieunhap(MaPhieuNhap),
    FOREIGN KEY (MaSP) REFERENCES sanpham(MaSP)
);



-- Nhập dữ liệu Chi Tiết phiếu nhập
INSERT INTO chitietphieunhap (MaPhieuNhap, MaSP, SoLuongNhap) VALUES
(1, 1, 100),
(1, 1, 50),
(1, 1, 300),
(2, 2, 90),
(2, 2, 35),
(2, 2, 68),
(2, 2, 234),
(2, 2, 234),
(2, 1, 166),
(3, 3, 345),
(3, 3, 23),
(3, 3, 56),
(3, 3, 67),
(4, 3, 45),
(4, 3, 45),
(5, 3, 10);
