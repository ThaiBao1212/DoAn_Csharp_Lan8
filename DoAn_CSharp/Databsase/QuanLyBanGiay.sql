create Database QuanLyBanGiay
use QuanLyBanGiay
-- Tạo bảng chucvu
CREATE TABLE chucvu (
    MaCV INT PRIMARY KEY,
    TenCV NVARCHAR(255)
);

-- Tạo bảng nhanvien


-- Tạo bảng khachhang
CREATE TABLE khachhang (
    MaKH INT PRIMARY KEY,
    HoTenKH NVARCHAR(255),
    DiaChiKH NVARCHAR(255),
    SDTKH NVARCHAR(15),
    CMNDKH NVARCHAR(20),
    GioiTinhKH NVARCHAR(10),
    TrangThaiKH NVARCHAR(255)
);
CREATE TABLE nhanvien (
    MaNV INT PRIMARY KEY,
    MaCV INT,
    TenTaiKhoanNV NVARCHAR(255),
    MatKhauNV NVARCHAR(255),
    HoTenNV NVARCHAR(255),
    GioiTinhNV NVARCHAR(10),
    NgaySinh DATE,
    DiaChiNV NVARCHAR(255),
    EmailNV NVARCHAR(255),
    SDTNV NVARCHAR(15),
    TrangThaiNV NVARCHAR(255),
    FOREIGN KEY (MaCV) REFERENCES chucvu(MaCV)
);

-- Tạo bảng nhacungcap
CREATE TABLE nhacungcap (
    MaNCC INT PRIMARY KEY,
    TenNCC NVARCHAR(255),
    DiaChiNCC NVARCHAR(255),
    SDTNCC NVARCHAR(15),
    Email NVARCHAR(255),
    TrangThaiNCC NVARCHAR(255)
);

-- Tạo bảng danhmuc
CREATE TABLE danhmuc (
    MaDanhMuc INT PRIMARY KEY,
    TenDM NVARCHAR(255),
    TrangThaiDM NVARCHAR(255)
);

-- Tạo bảng hoadon
CREATE TABLE hoadon (
    MaHD INT PRIMARY KEY,
    MaKH INT,
    MaNV INT,
    NgayLapHD DATE,
    TongTien FLOAT,
    FOREIGN KEY (MaKH) REFERENCES khachhang(MaKH),
    FOREIGN KEY (MaNV) REFERENCES nhanvien(MaNV)
);

-- Tạo bảng phieunhap
CREATE TABLE phieunhap (
    MaPhieuNhap INT PRIMARY KEY,
    MaNV INT,
    NgayLapPhieu DATE,
    TrangThaiPN NVARCHAR(255),
    FOREIGN KEY (MaNV) REFERENCES nhanvien(MaNV)
);

-- Tạo bảng sanpham
CREATE TABLE sanpham (
    MaSP INT PRIMARY KEY,
    MaNCC INT,
    MaDM INT,
    TenSP NVARCHAR(255),
    SizeSP NVARCHAR(50),
    SoLuongSP INT,
    MieuTaSP NVARCHAR(MAX),
    DonGia FLOAT,
    TrangThaiSP NVARCHAR(255),
    AnhSP NVARCHAR(255),
    FOREIGN KEY (MaNCC) REFERENCES nhacungcap(MaNCC),
    FOREIGN KEY (MaDM) REFERENCES danhmuc(MaDanhMuc)
);

-- Tạo bảng chitiethd
CREATE TABLE chitiethd (
    MaCTHD INT PRIMARY KEY,
    MaHD INT,
    MaSP INT,
    DonGia FLOAT,
    SizeSP NVARCHAR(50),
    ThanhTien FLOAT,
    FOREIGN KEY (MaHD) REFERENCES hoadon(MaHD),
    FOREIGN KEY (MaSP) REFERENCES sanpham(MaSP)
);

-- Tạo bảng chitietphieunhajp
CREATE TABLE chitietphieunhajp (
    MaCTPN INT PRIMARY KEY,
    MaPhieuNhap INT,
    MaSP INT,
    SoLuongNhap INT,
    FOREIGN KEY (MaPhieuNhap) REFERENCES phieunhap(MaPhieuNhap),
    FOREIGN KEY (MaSP) REFERENCES sanpham(MaSP)
);
-- Insert data into chucvu Table
INSERT INTO chucvu (MaCV, TenCV) VALUES
    (1, N'Quản lý'),
    (2, N'Nhân viên bán hàng')


-- Insert data into khachhang Table
INSERT INTO khachhang (MaKH, HoTenKH, DiaChiKH, SDTKH, CMNDKH, GioiTinhKH, TrangThaiKH) VALUES
    (1, N'Nguyễn Văn A', N'123 Đường ABC, Quận 1, TP.HCM', N'0123456789', N'123456789', N'Nam', N'Active'),
    (2, N'Trần Thị B', N'456 Đường XYZ, Quận 2, TP.HCM', N'0987654321', N'987654321', N'Nữ', N'Active');

-- Insert data into nhanvien Table
INSERT INTO nhanvien (MaNV, MaCV, TenTaiKhoanNV, MatKhauNV, HoTenNV, GioiTinhNV, NgaySinh, DiaChiNV, EmailNV, SDTNV, TrangThaiNV) VALUES
    (1, 1, N'Admin', N'123', N'Admin', N'Nam', '1990-01-01', N'789 Đường XYZ, Quận 3, TP.HCM', N'quanly1@email.com', N'0123456789', N'Active'),
    (2, 2, N'ThaiBao', N'123', N'Thái Bảo', N'Nam', '1995-05-15', N'456 Đường ABC, Quận 4, TP.HCM', N'nhanvienbh1@email.com', N'0987654321', N'Active'),
    (3, 2, N'Alin', N'123', N'Châu Quốc ALin', N'Nam', '1995-05-15', N'456 Đường ABC, Quận 4, TP.HCM', N'nhanvienbh1@email.com', N'0987654321', N'Active');

-- Insert data into nhacungcap Table
INSERT INTO nhacungcap (MaNCC, TenNCC, DiaChiNCC, SDTNCC, Email, TrangThaiNCC) VALUES
    (1, N'Nhà cung cấp 1', N'789 Đường ABC, Quận 5, TP.HCM', N'0123456789', N'ncc1@email.com', N'Active'),
    (2, N'Nhà cung cấp 2', N'456 Đường XYZ, Quận 6, TP.HCM', N'0987654321', N'ncc2@email.com', N'Active');

-- Insert data into danhmuc Table
INSERT INTO danhmuc (MaDanhMuc, TenDM, TrangThaiDM) VALUES
    (1, N'Danh mục 1', N'Active'),
    (2, N'Danh mục 2', N'Active');

-- Insert data into hoadon Table
INSERT INTO hoadon (MaHD, MaKH, MaNV, NgayLapHD, TongTien) VALUES
    (1, 1, 2, '2023-01-15', 500000),
    (2, 2, 1, '2023-01-20', 700000);

-- Insert data into phieunhap Table
INSERT INTO phieunhap (MaPhieuNhap, MaNV, NgayLapPhieu, TrangThaiPN) VALUES
    (1, 2, '2023-01-10', N'Đã nhập'),
    (2, 1, '2023-01-25', N'Chưa nhập');

-- Insert data into sanpham Table
INSERT INTO sanpham (MaSP, MaNCC, MaDM, TenSP, SizeSP, SoLuongSP, MieuTaSP, DonGia, TrangThaiSP, AnhSP) VALUES
    (1, 1, 1, N'Sản phẩm 1', N'39', 50, N'Mô tả sản phẩm 1', 200000, N'Active', N'anh1.jpg'),
    (2, 2, 2, N'Sản phẩm 2', N'40', 30, N'Mô tả sản phẩm 2', 250000, N'Active', N'anh2.jpg');

-- Insert data into chitiethd Table
INSERT INTO chitiethd (MaCTHD, MaHD, MaSP, DonGia, SizeSP, ThanhTien) VALUES
    (1, 1, 1, 200000, N'39', 200000),
    (2, 2, 2, 250000, N'40', 500000);

-- Insert data into chitietphieunhajp Table
INSERT INTO chitietphieunhajp (MaCTPN, MaPhieuNhap, MaSP, SoLuongNhap) VALUES
    (1, 1, 1, 20),
    (2, 2, 2, 15);
