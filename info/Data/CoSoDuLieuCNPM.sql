-----------------------------------------------------------------------------
-------------------------------------------------------------- Tạo cơ sở dữ liệu
-----------------------------------------------------------------------------
Create database DoiCTXH
go
use DoiCTXH
-- BẢNG CÁC TÀI KHOẢN CỦA PHẦN MỀM --
CREATE TABLE UserLog(
	Username nvarchar(30) PRIMARY KEY,
	Pass nvarchar(30),
	Administrator bit,
	BanDieuHanh bit
)
GO
-- BẢNG CÁC HÌNH ẢNH LOAD LÊN TRANG CHỦ --
CREATE TABLE Images(
	Url nvarchar(1000),
	Ghichu nvarchar(50)
)
GO
-- BẢNG DANH SÁCH CÁC VẬT DỤNG TRONG KHO --
CREATE TABLE Kho
(Ma_VD nvarchar(15) primary key,
	TenVD nvarchar(50),
	Donvi nvarchar(15),
	Soluong int check (Soluong>=0)
)
go
-- BẢNG DANH SÁCH CÁC KHOA ĐÀO TẠO --
CREATE TABLE Khoa(
	Ma_Khoa nvarchar(15) primary key,
	Ten_Khoa nvarchar(50),
	NgayThanhlap date
)
go
-- BẢNG KHÓA ĐỘI VIÊN --
CREATE TABLE Khoadoivien(
	Ma_Khoa nvarchar(15) primary key,
	Ngayketnap date
)
GO
-- BẢNG DANH SÁCH CÁC NHIỆM KỲ --
CREATE TABLE BanDieuhanh(
	NhiemKy int primary key CHECK (Nhiemky>0),
	Ngaybatdau date
)
go
 -- BẢNG DANH SÁCH CHƯƠNG TRÌNH --
CREATE TABLE Chuongtrinh(
	Ma_CT nvarchar(15) primary key,
	TenCT nvarchar(50),
	Ngaytochuc date,
	Diadiem nvarchar(50),
	Kinhphi int CHECK (Kinhphi>=0 and Kinhphi<=10000000 and Kinhphi%1000=0),
	DiemCTXH int CHECK (DiemCTXH>=0 and DiemCTXH <=40 and DiemCTXH%5=0)
)
go
-- Bảng thành viên --
CREATE TABLE Thanhvien(
	Ma_SV nvarchar(15) primary key,
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
CREATE TABLE Thamgiachuongtrinh(
	Ma_CT nvarchar(15),
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
CREATE TABLE ThamgiaBDH(
	Ma_SV nvarchar(15),
	Nhiemky int,
	Chucvu nvarchar(30),
	primary key (Nhiemky, Ma_SV),
	foreign key (Nhiemky) references Bandieuhanh(Nhiemky),
	foreign key (Ma_SV) references Thanhvien(Ma_SV)
	ON UPDATE CASCADE
)
go
-----------------------------------------------------------------------------
-------------------------------------------------------------- Nhập liệu cơ sở dữ liệu mẫu
-----------------------------------------------------------------------------
 --Nhập Khoa
 INSERT INTO Khoa VALUES
('FIT',N'CÔNG NGHỆ THÔNG TIN',NULL),
('FME',N'CƠ KHÍ CHẾ TẠO MÁY',NULL),
('FAE',N'CƠ KHÍ ĐỘNG LỰC',NULL),
('FGTTD',N'CÔNG NGHỆ MAY THỜI TRANG',NULL),
('FCFT',N'HÓA HỌC THỰC PHẨM',NULL),
('FHQ',N'ĐÀO TẠO CHẤT LƯỢNG CAO',NULL),
('FEEE',N'ĐIỆN - ĐIỆN TỬ',NULL),
('FGAM',N'IN VÀ TRUYỀN THÔNG',NULL),
('FAS',N'KHOA HỌC ỨNG DỤNG',NULL),
('FE',N'KINH TẾ',NULL),
('FCEAM',N'XÂY DỰNG',NULL),
('FFL',N'NGOẠI NGỮ',NULL)
GO
--Nhập kho
insert into Kho Values
('VD1',N'Đường','kg',10),
('VD2',N'Chén','cái',100),
('VD3',N'Bình nước','bình',20),
('VD4',N'Xoong','cái',12),
('VD5',N'Áo mùa hè xanh','cái',51),
('VD6',N'Bạt','tấm',7),
('VD7',N'Tre','Cây',18),
('VD8',N'Loa','Cái',1),
('VD9',N'Lá trà','kg',10),
('VD10',N'Nhang muỗi','hộp',50)
go 	
--Khóa đội viên
INSERT INTO Khoadoivien VALUES
('DV12','2012-1-18'),
('DV13','2013-2-19'),
('DV14','2014-3-20'),
('DV15','2015-4-21'),
('DV16','2016-3-18'),
('DV17','2017-5-10')
GO
--Ban điều hành
INSERT INTO BanDieuhanh VALUES
(13,NULL),
(14,NULL),
(15,NULL),
(16,NULL),
(17,NULL),
(18,NULL)
GO
--Chuong trình
INSERT INTO Chuongtrinh VALUES
('XTN_12017',N'Xuân tình nguyện 2017','2017-1-18',N'Tây Ninh',350000,20),
('MHX_72017',N'Mùa hè xanh 2017','2017-7-15',N'Hồ Chí Minh',350000,30),
('CNTN_92017',N'Chủ nhật tình nguyện 9-2017','2017-9-10',N'Hồ Chí Minh',35000,5),
('HMND_112017',N'Hiến máu nhân đạo 11-2017','2017-11-20',N'Hồ Chí Mình City',10000000,20),
('CDCTXH_32017',N'Chuyến đi CTXH 3-2017','2017-3-11',N'Hồ Chí Mình City',1500000,20),

('XTN_12016',N'Xuân tình nguyện 2016','2016-1-18',N'Tây Ninh',350000,20),
('MHX_72016',N'Mùa hè xanh 2016','2016-7-15',N'Hồ Chí Minh',350000,30),
('CNTN_92016',N'Chủ nhật tình nguyện 9-2016','2016-9-10',N'Hồ Chí Minh',0,5),
('HMND_112016',N'Hiến máu nhân đạo 11-2016','2016-11-20',N'Hồ Chí Mình City',2000000,20),
('CDCTXH_32016',N'Chuyến đi CTXH 3-2016','2016-3-11',N'Hồ Chí Mình City',10000000,20)
GO
--thành viên
INSERT INTO Thanhvien VALUES
('15110276',N'Trần Huỳnh Phiêu','1997-11-9',N'Bến Tre',N'CN Thông tin','FIT','DV16'),
('15110323',N'Nguyễn Minh Thông','1997-1-8',N'Khánh Hòa',N'CN Thông tin','FIT','DV16'),
('15110363',N'Đỗ Quốc Việt','1997-6-18',N'Khánh Hòa',N'CN Thông tin','FIT',NULL),
('15148006',N'Cao Ngọc Dung','1997-12-31',N'Bình Định',N'CN In','FGAM','DV16'),
('14745071',N'Nguyễn Thạch Phát','1996-7-14',N'Đak Lak',N'CNKT Ô tô','FAE','DV16'),
('16141036',N'Phạm Quang Huy','1997-11-18',N'Thái Bình',N'Điện tử truyền thông','FEEE','DV17'),
('16109208',N'Đỗ Thị Thu Thủy','1998-9-13',N'Thái Bình',N'CN May','FGTTD','DV17'),

('14156481',N'Nguyễn Thạch ','1996-7-14',N'Đak Lak',N'CNKT Ô tô','FAE','DV16'),
('16178965',N'Phạm Huy','1997-11-18',N'Thái Bình',N'Điện tử truyền thông','FEEE','DV17'),
('17885421',N'Đỗ Thu Thủy','1998-9-13',N'Thái Bình',N'CN May','FGTTD','DV17'),

('17110341',N'Bùi Minh Nhật','1997-11-18',N'Bình Phước',N'CN Thông tin','FIT',NULL),
('16145327',N'Phạm Tấn Bang','1997-11-18',N'Phú Yên',N'CNKT Ô tô','FAE',NULL),
('15142357',N'Huỳnh Minh Khánh','1989-9-13',N'TPHCM',N'CNKT Ô tô','FAE','DV12')
GO
--Tham gia Chuong trình
INSERT INTO Thamgiachuongtrinh VALUES
('MHX_72017','15110276',30,N'Xuất sắc'),
('MHX_72017','15110323',30,N'Xuất sắc'),
('MHX_72017','15148006',30,N'Xuất sắc'),
('MHX_72017','14745071',30,N'Xuất sắc'),
('MHX_72017','16109208',30,N'Xuất sắc'),
('MHX_72017','16141036',30,N'Xuất sắc'),
('XTN_12017','16141036',20,N'Xuất sắc'),
('XTN_12017','16109208',20,N'Xuất sắc'),
('CNTN_92017','17110341',5,N'Xuất sắc'),
('CNTN_92017','16145327',5,N'Xuất sắc')
GO
--Tham gia Ban điều hành
INSERT INTO ThamgiaBDH VALUES
('15142357',13,N'Ủy viên'),
('15110276',18,N'Đội trưởng'),
('15110323',18,N'Đội phó'),
('15148006',18,N'Ủy viên'),
('14745071',18,N'Ủy viên'),
('16141036',18,N'Ủy viên'),
('14156481',18,N'Ủy viên'),
('16109208',18,N'Ủy viên'),
('16178965',18,N'Ủy viên'),
('17885421',18,N'Ủy viên')
GO
--Danh sách tài khoản sử dụng cho chương trình
INSERT INTO dbo.UserLog(Username, Pass, Administrator, BanDieuHanh)
     VALUES
           ('DoiTruong','DoiTruong','true','false'),
		   ('BanDieuHanh','BanDieuHanh','false','true')
GO
-----------------------------------------------------------------------------
-------------------------------------------------------------- Phân quyền
-----------------------------------------------------------------------------
If not Exists (select loginname from master.dbo.syslogins where name = 'BanDieuHanh')
begin
	create login DoiTruong with password = 'DoiTruong';
	create user urDoiTruong for login DoiTruong;

	ALTER ROLE [db_owner] ADD MEMBER [urDoiTruong]
	ALTER SERVER ROLE [sysadmin] ADD MEMBER [DoiTruong]

	create login BanDieuHanh with password = 'BanDieuHanh';
	create user urBanDieuHanh for login BanDieuHanh;

	ALTER ROLE [db_owner] ADD MEMBER [urBanDieuHanh]
end
go
-----------------------------------------------------------------------------
-------------------------------------------------------------- Các Procedure
-----------------------------------------------------------------------------
--Thêm thành viên
Create procedure sp_ThemThanhVien
@Ma_SV nvarchar (15),
@Hoten nvarchar (50),
@Ngaysinh Date,
@Quequan nvarchar(50),
@Nganh nvarchar(50),
@Khoa nvarchar(15),
@KhoaDV nvarchar(15)
as
begin
insert into dbo.Thanhvien(Ma_SV,Hoten,Ngaysinh,Quequan,Nganh,Khoa,KhoaDV)
values (@Ma_SV,@Hoten,@Ngaysinh,@Quequan,@Nganh,@Khoa,@KhoaDV)
end
go
-- update thành viên
create proc sp_UpdateThanhVien
@MSSV nvarchar(30),
@Hoten nvarchar(50),
@Ngaysinh date,
@Quequan nvarchar(50),
@Nganh nvarchar(50),
@Khoa nvarchar(50),
@KhoaDV nvarchar(50)
as
begin
update Thanhvien
set Hoten=@Hoten,NgaySinh=@Ngaysinh,Quequan=@Quequan,Nganh=@Nganh,Khoa=@Khoa,KhoaDV=@KhoaDV
where dbo.Thanhvien.Ma_SV=@MSSV
end
go
-- Xóa thành viên
CREATE PROC dbo.usp_Xoa_Thanhvien @MSSV nvarchar(30)
AS
BEGIN
DELETE FROM Thanhvien WHERE Thanhvien.Ma_SV=@MSSV
END
go
-- Thêm chương trình
Create procedure sp_ThemChuongTrinh
@Ma_CT nvarchar (15),
@TenCT nvarchar (50),
@NgayToChuc Date,
@DiaDiem nvarchar(50),
@KinhPhi int,
@DiemCTXH int
as
begin
insert into dbo.Chuongtrinh(Ma_CT,TenCT,Ngaytochuc,Diadiem,Kinhphi,DiemCTXH)
values (@Ma_CT,@TenCT,@NgayToChuc,@DiaDiem,@KinhPhi,@DiemCTXH)
end
go
-- update chương trình
create proc sp_UpdateChuongTrinh
@MaCT nvarchar(30),
@TenCT nvarchar(50),
@Ngaytochuc date,
@DiaDiem nvarchar(50),
@Kinhphi int,
@DiemCTXH int
as
begin
update Chuongtrinh
set TenCT=@TenCT,Ngaytochuc=@Ngaytochuc,Diadiem=@DiaDiem,Kinhphi=@Kinhphi,DiemCTXH=@DiemCTXH
where Chuongtrinh.Ma_CT=@MaCT
end
go
--xóa chương trình
create proc sp_XoaChuongTrinh @MaCT nvarchar(30)
as
begin
DELETE FROM Chuongtrinh WHERE Chuongtrinh.Ma_CT = @MaCT
end
go
--Thêm vật dụng
Create procedure sp_ThemVatDung
@MaVD nvarchar (15),
@TenVD nvarchar (50),
@Donvi nvarchar (15),
@Soluong int
as
begin
insert into dbo.Kho(Ma_VD,TenVD,Donvi,Soluong)
values (@MaVD,@TenVD,@Donvi,@Soluong)
end
go
--Update vật dụng
create proc sp_UpdateVatDung
@MaVD nvarchar(15),
@TenVD nvarchar(50),
@DonVi nvarchar(15),
@SoLuong int
as
begin
update Kho
set TenVD = @TenVD, Donvi = @DonVi, Soluong = @SoLuong
where kho.Ma_VD = @MaVD
end
go
--Xóa vật dụng
create proc sp_XoaVatdung @Ma nvarchar(15)
as
delete from Kho where @Ma=Ma_VD or @Ma=TenVD
go
--Thay thế BDH
CREATE PROC dbo.ThaytheBDH 
        @Nhiemky int,
        @Ma_SV_Duongnhiem nvarchar(15),
        @Ma_SV_Thaythe nvarchar(15)
AS
        UPDATE ThamgiaBDH
        SET Ma_SV=@Ma_SV_Thaythe
        WHERE ThamgiaBDH.Nhiemky=@Nhiemky AND ThamgiaBDH.Ma_SV=@Ma_SV_Duongnhiem
go
--Kết nạp thành viên (Khác với thêm thành viên)
CREATE PROC dbo.usp_Ketnap
        @Ma_SV nvarchar(15),
        @Ma_Khoa nvarchar(15)
AS
        UPDATE Thanhvien 
        SET KhoaDV = @Ma_Khoa
        WHERE Thanhvien.Ma_SV =@Ma_SV AND KhoaDV IS NULL
go
--Xóa thông tin thành viên (Xóa mọi thứ về thành viên đó)(Khác với sp xóa thành viên bth)--
CREATE PROC dbo.sp_XoaThongtin_Thanhvien
        @MaSV nvarchar(15)
AS
BEGIN
        DELETE  FROM Thamgiachuongtrinh WHERE Thamgiachuongtrinh.Ma_SV=@MaSV
        DELETE FROM Thanhvien WHERE Thanhvien.Ma_SV=@MaSV
END
go
--Tham gia chuong trình
CREATE PROC dbo.ThamgiaCT
        @MaCT nvarchar(15),
        @MaSV nvarchar(15),
        @DiemCTXH int,
        @Danhgia nvarchar(50)
AS
BEGIN
        INSERT INTO Thamgiachuongtrinh
        VALUES (@MaCT,@MaSV,@DiemCTXH,@Danhgia)
END
go
--Xóa tham gia chuong trình
CREATE PROC dbo.XoaThamgiaCT
        @Ma_SV nvarchar(15),
        @MaCT nvarchar(15)
AS
BEGIN
        DELETE FROM Thamgiachuongtrinh
        WHERE Ma_SV=@Ma_SV AND Ma_CT=@MaCT
END
go
--Tham gia BDH
CREATE PROC dbo.sp_ThamgiaBDH
        @MaSV nvarchar(15),
        @Nhiemky int,
        @Chucvu nvarchar(30)
AS
BEGIN
        INSERT INTO ThamgiaBDH
        VALUES (@MaSV,@Nhiemky,@Chucvu)
END
go
--Xem khóa đội viên 
CREATE PROC dbo.ds_KhoaDV
AS
BEGIN
        SELECT Khoadoivien.Ma_Khoa FROM Khoadoivien
END
go
-- Đếm số lượng đội viên chính thức
CREATE PROC dbo.sp_DemDoivien
        @Ma_KhoaDV nvarchar(15)
AS
BEGIN
        IF(@Ma_KhoaDV='')
                SELECT  COUNT(*)
                FROM Thanhvien
                WHERE Thanhvien.KhoaDV IS NOT NULL
        ELSE
        SELECT COUNT(*)
                FROM Thanhvien
                WHERE Thanhvien.KhoaDV=@Ma_KhoaDV
END
go
-------------------
CREATE PROC [dbo].[sp_DelThamgiaCT]        
        @MaSv nvarchar(15),
        @MaCT nvarchar(15)
AS
        delete from Thamgiachuongtrinh
        where Thamgiachuongtrinh.Ma_CT=@MaCT and Thamgiachuongtrinh.Ma_SV=@MaSv
GO
-------------------
CREATE PROC [dbo].[sp_UpdateThamgiaCT]        
        @MaSv nvarchar(15),
        @MaCT nvarchar(15),
        @DiemCTXH int,
        @Danhgia nvarchar(50)
AS
        UPDATE Thamgiachuongtrinh
        SET DiemCTXH=@DiemCTXH, Danhgia=@Danhgia
        WHERE Ma_CT=@MaCT AND Ma_SV=@MaSv
GO
--Đôi mật khẩu
CREATE proc [dbo].[uspDoiMatKhau]------------------------Đổi mật khẩu
	@forlogin nvarchar(30),
	@newpass nvarchar(30)
as
begin
	declare @sql nvarchar(max)
	set @sql =	 'alter login '+@forlogin+' with password = '''+@newpass+''' UNLOCK;'--phải để 3 '''
				+'alter login '+@forlogin+' with CHECK_POLICY = OFF;'
				+'alter login '+@forlogin+' enable'
	exec (@sql)
end
GO
--Thêm nhiệm kỳ mới
create proc [dbo].[sp_ThemNhiemKy]
AS
	declare @NhiemKyLonNhat int;
	select @NhiemKyLonNhat = Max(NhiemKy)
	from BanDieuhanh
    insert into BanDieuhanh(NhiemKy, Ngaybatdau) values (@NhiemKyLonNhat + 1, null)
GO

-----------------------------------------------------------------------------
-------------------------------------------------------------- Các Function
-----------------------------------------------------------------------------
--Hàm lấy danh sách chương trình
CREATE FUNCTION dbo.fu_Ds_Chuongtrinh ()
RETURNS TABLE
AS
        RETURN (SELECT * FROM Chuongtrinh)
go
-- Hàm trả về một bảng thành viên theo khóa Đội viên
CREATE FUNCTION dbo.fu_DS_DoivienTheoKDV (@KhoaDv nvarchar(10))
RETURNS TABLE
AS
RETURN ( SELECT * FROM DBO.Thanhvien
WHERE Thanhvien.KhoaDV=@KhoaDv)
go
-- Lấy danh sách sinh viên tham gia chương trình
CREATE FUNCTION dbo.fu_DS_SVthamgiaCT (@MaCT nvarchar(10))
RETURNS TABLE
AS
RETURN (SELECT Thanhvien.Hoten, Thanhvien.Ma_SV,Thamgiachuongtrinh.DiemCTXH,Thamgiachuongtrinh.Danhgia
FROM Thanhvien, Thamgiachuongtrinh
WHERE Thanhvien.Ma_SV=Thamgiachuongtrinh.Ma_SV AND Thamgiachuongtrinh.Ma_CT=@MaCT )
go
--Đếm số lượng tham gia chương trình
CREATE FUNCTION dbo.fu_SL_ThamgiaCT (@MaCT nvarchar(15))
RETURNS INT
AS
BEGIN
DECLARE @SL INT
SELECT @SL= COUNT(Thamgiachuongtrinh.Ma_SV)
FROM Thamgiachuongtrinh
WHERE Thamgiachuongtrinh.Ma_CT=@MaCT
RETURN @SL
END
go
--Đếm Đội viên theo khóa kêt nạp
create function fnc_DemDVTheoKhoa (@KhoaDV nvarchar(15))returns int
as
begin
declare @T int
select @T=count(Ma_SV)
from Thanhvien
where KhoaDV=@KhoaDV
return @T
end
go
-- lấy danh sách cộng tác viên
CREATE FUNCTION dbo.fu_ds_CongTacVien()
RETURNS TABLE
AS
RETURN (SELECT Ma_SV,Hoten, Ngaysinh,Quequan,Nganh,Ten_Khoa
FROM Thanhvien, Khoa
WHERE Thanhvien.Khoa = Khoa.Ma_Khoa and KhoaDV is null)
go
--lọc đội viên theo năm sinh
create FUNCTION [dbo].[fu_LocDV_TheoNamsinh] (@namsinh int)
RETURNS TABLE
AS
RETURN (SELECT Ma_SV,Hoten, Ngaysinh,Quequan,Nganh,Ten_Khoa,KhoaDV
FROM Thanhvien, Khoa
WHERE Thanhvien.Khoa = Khoa.Ma_Khoa and Year(Thanhvien.Ngaysinh) = @namsinh and KhoaDV is not null)
go
--lọc đội viên theo khóa học
create FUNCTION [dbo].[fu_LocDV_TheoKhoahoc] (@Ma_Khoa nvarchar(15))
RETURNS TABLE
AS
RETURN (SELECT Ma_SV,Hoten, Ngaysinh,Quequan,Nganh,Ten_Khoa,KhoaDV
FROM Thanhvien, Khoa
WHERE Thanhvien.Khoa = Khoa.Ma_Khoa and Thanhvien.Khoa=@Ma_Khoa and Thanhvien.KhoaDV is not null) 
go
--lọc đội viên theo khóa kết nạp
create FUNCTION [dbo].[fu_LocDV_TheoKhoaDV](@Ma_Khoa nvarchar(15))
RETURNS TABLE
AS
RETURN (SELECT Ma_SV,Hoten, Ngaysinh,Quequan,Nganh,Ten_Khoa,KhoaDV
FROM Thanhvien, Khoa
WHERE Thanhvien.Khoa = Khoa.Ma_Khoa and Thanhvien.KhoaDV=@Ma_Khoa)
go
--Lấy danh sách đội viên
CREATE FUNCTION dbo.fu_ds_Doivien()
RETURNS TABLE
AS
RETURN (SELECT Ma_SV, Hoten,Ngaysinh, Quequan, Ten_Khoa, Nganh, KhoaDV
FROM Thanhvien, Khoa
WHERE Thanhvien.Khoa=Khoa.Ma_Khoa AND KhoaDV IS NOT NULL)
go
--Lấy danh sách vật dụng trong kho
CREATE FUNCTION dbo.fu_Ds_KhoVatDung ()
RETURNS TABLE
AS
RETURN (SELECT * FROM Kho)
go
--Tìm đội viên theo tên nhập vào
create FUNCTION [dbo].[fu_TimKiemDoiVien_TheoTen] (@Ho_ten nvarchar(50)) RETURNS TABLE
AS
RETURN ( SELECT Ma_SV, Hoten,Ngaysinh, Quequan, Ten_Khoa, Nganh, KhoaDV
FROM DBO.Thanhvien, Khoa
WHERE (Thanhvien.Hoten like N'%' +@Ho_ten+ N'%')
AND Thanhvien.Khoa=Khoa.Ma_Khoa AND KhoaDV IS NOT NULL)
go
--Tìm kiếm cộng tác viên theo tên
create FUNCTION [dbo].[fu_TimKiemCTV_TheoTen] (@Ho_ten nvarchar(50)) RETURNS TABLE
AS
RETURN ( SELECT Ma_SV, Hoten,Ngaysinh, Quequan, Ten_Khoa, Nganh
FROM DBO.Thanhvien, Khoa
WHERE (Thanhvien.Hoten like N'%' +@Ho_ten+ N'%')
AND Thanhvien.Khoa=Khoa.Ma_Khoa AND KhoaDV IS NULL)
go
--Tìm ngày kết nạp của một khóa Đội viên
CREATE FUNCTION dbo.fu_ngayKetnap (@KhoaDV nvarchar(15))
RETURNS NVARCHAR(10)
AS
BEGIN
DECLARE @STR NVARCHAR(10)
SELECT @STR = CONVERT(nvarchar(10),Ngayketnap,103)
-- 103 LÀ MÃ KIỂU ĐỊNH DẠNG NGÀY --
FROM Khoadoivien
WHERE Khoadoivien.Ma_Khoa=@KhoaDV
RETURN @STR
END
go
--Lấy khóa đội viên khi truyền nào ngày hiện hành, tức là lấy được khóa của năm đang xét
CREATE FUNCTION dbo.fu_LayKhoaDV(@now date)
RETURNS nvarchar(15)
AS
BEGIN
DECLARE @STR NVARCHAR(15)
DECLARE @NAM INT
SELECT @NAM= YEAR(@now)
SELECT @NAM=@NAM-2000
SET @STR = CAST(@NAM AS nvarchar(15))
SET @STR = 'DV'+@STR
RETURN @STR
END
go
--Lấy danh sách tham gia ban điều hành của một nhiệm kỳ truyền vào
CREATE FUNCTION dbo.fu_ds_BDH_Nhiemky (@Nhiemky int)
RETURNS TABLE
AS
RETURN (SELECT Thanhvien.Ma_SV, Hoten,Ngaysinh,KhoaDV,Chucvu
FROM Thanhvien,ThamgiaBDH
WHERE Thanhvien.Ma_SV=ThamgiaBDH.Ma_SV
AND ThamgiaBDH.Nhiemky=@Nhiemky)
go
--xem thử tài khoản có quyền admin không
create FUNCTION [dbo].[fu_LayVaiTro](@user nvarchar(50))
RETURNS bit
AS
BEGIN
	declare @temp bit
	select @temp = Administrator
	from UserLog
	where Username = @user
RETURN @temp
END
go
--Lọc cộng tác viên theo khoa đào tạo
create FUNCTION [dbo].[fu_LocCTV_TheoKhoaDaoTao](@Ma_Khoa nvarchar(15))
RETURNS TABLE
AS
RETURN (SELECT Ma_SV,Hoten, Ngaysinh,Quequan,Nganh,Ten_Khoa
FROM Thanhvien, Khoa
WHERE Thanhvien.Khoa = Khoa.Ma_Khoa and Khoa.Ma_Khoa = @Ma_Khoa and KhoaDV is null)
go
--Lọc cộng tác viên theo năm sinh
create FUNCTION [dbo].[fu_LocCTV_TheoNamSinh](@namsinh int)
RETURNS TABLE
AS
RETURN (SELECT Ma_SV,Hoten,Ngaysinh,Quequan,Nganh,Ten_Khoa
FROM Thanhvien, Khoa
WHERE Thanhvien.Khoa = Khoa.Ma_Khoa and Year(Thanhvien.Ngaysinh) = @namsinh and KhoaDV is null)
go
--Lọc cộng tác viên theo điều kiện truyền vào
create function [dbo].[fu_Loc_CTV](@Namsinh int, @MaKhoa nvarchar(15))
returns @ketqua table (MaSV varchar(15), Hoten nvarchar(50), Ngaysinh date, Quequan nvarchar(50), Nganh nvarchar(50), TenKhoa nvarchar(50))
as
begin
	declare @theomakhoa table(MaSV varchar(15), Hoten nvarchar(50), Ngaysinh date, Quequan nvarchar(50), Nganh nvarchar(50), TenKhoa nvarchar(50));
	declare @theonamsinh table(MaSV varchar(15), Hoten nvarchar(50), Ngaysinh date, Quequan nvarchar(50), Nganh nvarchar(50), TenKhoa nvarchar(50));
	
	if(@Namsinh is not null or @Namsinh != 0) insert @theonamsinh select * from dbo.fu_LocCTV_TheoNamSinh(@Namsinh)
	if(@MaKhoa is not null or @MaKhoa != '') insert @theomakhoa select * from dbo.fu_LocCTV_TheoKhoaDaoTao(@MaKhoa)
	
	--tất cả cùng null
	if((@Namsinh is null or @Namsinh = 0) and (@MaKhoa is null or @MaKhoa = ''))
	begin
		insert @ketqua	SELECT Ma_SV,Hoten, Ngaysinh,Quequan,Nganh,Ten_Khoa
						FROM Thanhvien, Khoa
						WHERE Thanhvien.Khoa = Khoa.Ma_Khoa and KhoaDV is null
		return
	end
	--chỉ năm sinh null
	else if(@Namsinh is null or @Namsinh = 0)
	begin
		insert @ketqua select * from @theomakhoa
		return
	end
	--chỉ mã khoa null
	else if(@MaKhoa is null or @MaKhoa = '')
	begin
		insert @ketqua select * from @theonamsinh
		return
	end
	else
	begin
		insert @ketqua select * from @theomakhoa INTERSECT select * from @theonamsinh
		return
	end
	return
end
go
--Lọc đội viên theo điều kiện truyền vào
create function [dbo].[fu_Loc_DoiVien] (@Namsinh int, @MaKhoa nvarchar(15), @MaKhoaDV nvarchar(15))
returns @ketqua table (MaSV varchar(15), Hoten nvarchar(50), Ngaysinh date, Quequan nvarchar(50), TenKhoa nvarchar(50), Nganh nvarchar(50), KhoaDV nvarchar(15))
as
begin
	declare @theomakhoa table (MaSV varchar(15), Hoten nvarchar(50), Ngaysinh date, Quequan nvarchar(50), TenKhoa nvarchar(50), Nganh nvarchar(50), KhoaDV nvarchar(15));
	declare @theonamsinh table (MaSV varchar(15), Hoten nvarchar(50), Ngaysinh date, Quequan nvarchar(50), TenKhoa nvarchar(50), Nganh nvarchar(50), KhoaDV nvarchar(15));
	declare @theokhoaDV table (MaSV varchar(15), Hoten nvarchar(50), Ngaysinh date, Quequan nvarchar(50), TenKhoa nvarchar(50), Nganh nvarchar(50), KhoaDV nvarchar(15));
	
	if(@Namsinh is not null or @Namsinh != 0) insert @theonamsinh select * from dbo.fu_LocDV_TheoNamsinh(@Namsinh)
	if(@MaKhoa is not null or @MaKhoa != '') insert @theomakhoa select * from dbo.fu_LocDV_TheoKhoahoc(@MaKhoa)
	if(@MaKhoaDV is not null or @MaKhoaDV != '') insert @theokhoaDV select * from dbo.fu_LocDV_TheoKhoaDV(@MaKhoaDV)

	if((@MaKhoaDV is null or @MaKhoaDV = '') and (@Namsinh is null or @Namsinh = 0) and (@MaKhoa is null or @MaKhoa = ''))
	begin
		insert @ketqua	SELECT Ma_SV, Hoten,Ngaysinh, Quequan, Ten_Khoa, Nganh, KhoaDV
						FROM Thanhvien, Khoa
						WHERE Thanhvien.Khoa=Khoa.Ma_Khoa AND KhoaDV IS NOT NULL
		return
	end

	if((@Namsinh is null or @Namsinh = 0) and (@MaKhoa is null or @MaKhoa = ''))
	begin
		insert @ketqua select * from @theokhoaDV
		return
	end
	if((@MaKhoa is null or @MaKhoa = '') and (@MaKhoaDV is null or @MaKhoaDV = ''))
	begin
		insert @ketqua select * from @theonamsinh
		return
	end
	if((@MaKhoaDV is null or @MaKhoaDV = '') and (@Namsinh is null or @Namsinh = 0))
	begin
		insert @ketqua select * from @theomakhoa
		return
	end 

	if(@Namsinh is null or @Namsinh = 0)
	begin
		insert @ketqua select * from @theomakhoa INTERSECT select * from @theokhoaDV
		return
	end
	if(@MaKhoa is null or @MaKhoa = '')
	begin
		insert @ketqua select * from @theonamsinh INTERSECT select * from @theokhoaDV
		return
	end
	if(@MaKhoaDV is null or @MaKhoaDV = '')
	begin
		insert @ketqua select * from @theomakhoa INTERSECT select * from @theonamsinh
		return
	end 
	return
end
go
--Lấy danh sách tài khoản đăng nhập
create FUNCTION dbo.fu_Ds_TaiKhoan()
RETURNS TABLE
AS
        RETURN (SELECT Username, Administrator, BanDieuHanh
				FROM UserLog)
go
--
CREATE FUNCTION [dbo].[fu_LayTenCT](@MaCT nvarchar(15))
RETURNS nvarchar(50)
AS
BEGIN
        RETURN (SELECT Chuongtrinh.TenCT
                        FROM Chuongtrinh
                        WHERE Chuongtrinh.Ma_CT=@MaCT) 
END
go
--
create FUNCTION [dbo].[fu_ds_BanDieuHanh]()
RETURNS TABLE
AS
RETURN (SELECT Thanhvien.Ma_SV, Hoten,Ngaysinh, Quequan, Nganh, KhoaDV, Nhiemky
FROM Thanhvien, ThamgiaBDH
WHERE Thanhvien.Ma_SV=ThamgiaBDH.Ma_SV AND KhoaDV IS NOT NULL) 
go
-----------------------------------------------------------------------------
-------------------------------------------------------------- Các Trigger
-----------------------------------------------------------------------------
create trigger Tg_VaoBDH
on dbo.ThamgiaBDH
for insert
as
begin
declare @Count int =0
select @Count=COUNT(*) from inserted,Thanhvien
where inserted.Ma_SV=Thanhvien.Ma_SV and Thanhvien.KhoaDV is null

if (@Count>0)
begin
print N'Không thể thêm CTV vào BDH'
rollback tran
end
end
go
-------------------------------------------
create trigger Tg_KTSoLuongBDH
on ThamgiaBDH
for insert,update
as
begin
if exists (select Count(Nhiemky)
from ThamgiaBDH
group by Nhiemky
having Count(*)>9)
begin
print N'Vượt quá giới hạn cho phép'
rollback transaction
end
end
go
--
create function [dbo].[fu_Ds_Nhiemki]()
returns table
as
	return (select NhiemKy from BanDieuhanh)
GO
-------------------------------------------
create trigger Tg_DeleteOver22
on Thanhvien
for delete
as
begin
declare @Count int =0

select @Count = COUNT(*) from deleted
where YEAR(GETDATE()) - YEAR(deleted.Ngaysinh)>22

if (@Count>0)
begin
print N'Không xóa được đội viên đã ra trường!'
rollback tran
end
end
go
-------------------------------------------
CREATE TRIGGER dbo.tg_ChiXem_BDH_NKTruoc
ON ThamgiaBDH
FOR UPDATE
AS
BEGIN
DECLARE @NKHT INT
SELECT @NKHT = MAX(BanDieuhanh.NhiemKy)
FROM BanDieuhanh
if(exists (select * from inserted
where inserted.Nhiemky<>@NKHT))
begin
rollback transaction
end
END
go
-------------------------------------------
CREATE TRIGGER dbo.tg_BlockThamgiaCT
ON Thamgiachuongtrinh
FOR INSERT
AS
BEGIN
DECLARE @NGAYTOCHUC DATE
SELECT @NGAYTOCHUC = Chuongtrinh.Ngaytochuc
FROM Chuongtrinh,inserted
WHERE Chuongtrinh.Ma_CT= inserted.Ma_CT

IF(EXISTS (SELECT *
FROM inserted, Chuongtrinh
WHERE YEAR(GETDATE()) - YEAR(@NGAYTOCHUC)>=1))
BEGIN
PRINT 'tg_BlockThamgiaCT'
ROLLBACK TRANSACTION
END
END
go
-------------------------------------------