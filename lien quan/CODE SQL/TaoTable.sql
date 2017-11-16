use DoiCTXH
go
-- BẢNG CÁC TÀI KHOẢN CỦA PHẦN MỀM --
CREATE TABLE UserLog(
Username nvarchar(30) PRIMARY KEY,
Pass nvarchar(30),
Adminitrator bit,
Tinhnguyen bit,
Nhansu bit,
Quankho bit
)
GO
-- BẢNG CÁC HÌNH ẢNH LOAD LÊN TRANG CHỦ --
CREATE TABLE Images(
Url nvarchar(1000),
Ghichu nvarchar(50))
GO
-- BẢNG DANH SÁCH CÁC VẬT DỤNG TRONG KHO --
CREATE TABLE Kho
(Ma_VD nvarchar(15) primary key,
TenVD nvarchar(50),
Donvi nvarchar(15),
Soluong int check (Soluong>=0)
)
go
-- BẢNG DANH SÁCH CÁC KHOA THEO HỌC --
CREATE TABLE Khoa
(Ma_Khoa nvarchar(15) primary key,
 Ten_Khoa nvarchar(50), 
 NgayThanhlap date)
go
-- BẢNG DANH SÁCH CÁC NHIỆM KỲ -- 
CREATE TABLE BanDieuhanh
(NhiemKy int primary key CHECK (Nhiemky>0),
Ngaybatdau date)
go
-- BẢNG DANH SÁCH CHƯƠNG TRÌNH --
CREATE TABLE Chuongtrinh
(Ma_CT nvarchar(15) primary key,
TenCT nvarchar(50),
Ngaytochuc date,
Diadiem nvarchar(50),
Kinhphi int CHECK (Kinhphi>=0 and Kinhphi<=10000000 and Kinhphi%1000=0),
DiemCTXH int CHECK (DiemCTXH>=0 and DiemCTXH <=40 and DiemCTXH%5=0)  
)
go
-- BẢNG KHÓA ĐỘI VIÊN --
CREATE TABLE Khoadoivien
(Ma_Khoa nvarchar(15) primary key,
Ngayketnap date
)
GO
-- Bảng Các ban trực thuộc--
CREATE TABLE Ban
(Ma_ban nvarchar(15) primary key,
Tenban nvarchar(50),
Ngaythanhlap DATE
)
GO
-- Bảng thành viên --
CREATE TABLE Thanhvien
(Ma_SV nvarchar(15) primary key,
Hoten nvarchar(50),
Ngaysinh date,
Quequan nvarchar(50),
Nganh nvarchar(50),
Khoa nvarchar(15),
KhoaDV nvarchar(15),
FOREIGN KEY (Khoa) references Khoa(Ma_Khoa),
FOREIGN KEY (KhoaDV) references Khoadoivien(Ma_khoa)
ON DELETE SET NULL
ON UPDATE CASCADE
)
GO
-- BẢNG THAM GIA CHƯƠNG TRÌNH --
CREATE TABLE Thamgiachuongtrinh
(Ma_CT nvarchar(15),
Ma_SV nvarchar(15),
DiemCTXH int CHECK (DiemCTXH>=0 and DiemCTXH <=40 and DiemCTXH%5=0) ,
Danhgia nvarchar(50),
primary key (Ma_SV, Ma_CT),
foreign key (Ma_SV) references Thanhvien(Ma_SV),
foreign key (Ma_CT) references Chuongtrinh(Ma_CT)
ON UPDATE CASCADE
)
go
-- BẢNG THAM GIA BAN ĐIỀU HÀNH --
CREATE TABLE ThamgiaBDH
(Ma_SV nvarchar(15),
Nhiemky int,
Chucvu nvarchar(30),
primary key (Nhiemky, Ma_SV),
foreign key (Nhiemky) references Bandieuhanh(Nhiemky),
foreign key (Ma_SV) references Thanhvien(Ma_SV)
ON UPDATE CASCADE
)
go
-- THAM GIA BAN --
CREATE TABLE ThamgiaBan
(Ma_ban nvarchar(15),
Ma_SV nvarchar(15),
primary key (Ma_SV, Ma_ban),
foreign key (Ma_SV) references Thanhvien(Ma_SV),
foreign key (Ma_ban) references Ban(Ma_ban)
ON UPDATE CASCADE
)
go