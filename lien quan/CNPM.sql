use DoiCTXH
--------------------------------------------------------------------------------
----------------------------------------- Create table
--------------------------------------------------------------------------------
CREATE TABLE Khoa
(Ma_Khoa nvarchar(30) primary key,
 Ten_Khoa nvarchar(50), 
 NgayThanhlap date)
go

Create table Khoadoivien
(Ma_Khoa nvarchar(30) primary key,
Ngayketnap date
)
go

create table Thanhvien
( MSSV nvarchar(30) primary key,
Hoten nvarchar(50),
Ngaysinh date,
Quequan nvarchar(30),
Nganh nvarchar(30),
Khoa nvarchar(30),
KhoaDV nvarchar(30),
FOREIGN KEY (Khoa) references Khoa(Ma_Khoa),
FOREIGN KEY (KhoaDV) references Khoadoivien(Ma_khoa)
)
go

Create table Ban
( Ma_ban nvarchar(30) primary key,
Tenban nvarchar(40)
)
go

create table Chuongtrinh
( MaCT nvarchar(30) primary key,
TenCT nvarchar(30),
Ngaytochuc date,
Diadiem nvarchar(50),
Kinhphi nvarchar(50),
DiemCTXH int
)
go

create table Bandieuhanh
(NhiemKi nvarchar(30) primary key,
Ngaybatdau date)
go

create table Thamgiachuongtrinh
(MaCT nvarchar(30),
MSSV nvarchar(30),
DiemCTXH int,
Danhgia nvarchar(50),
primary key (MSSV, MaCT),
foreign key (MSSV) references Thanhvien(MSSV),
foreign key (MaCT) references Chuongtrinh(MaCT)
)
go

Create table Thamgiaban
(Ma_ban nvarchar(30),
MSSV nvarchar(30),
primary key (MSSV, Ma_ban),
foreign key (MSSV) references Thanhvien(MSSV),
foreign key (Ma_ban) references Ban(Ma_ban)
)
go

create table ThamgiaBDH
(MSSV nvarchar(30),
Nhiemki nvarchar(30),
Chucvu nvarchar(30),
primary key (Nhiemki, MSSV),
foreign key (Nhiemki) references Bandieuhanh(Nhiemki),
foreign key (MSSV) references Thanhvien(MSSV)
)
go

CREATE TABLE Kho
( MaVD nvarchar(20) primary key,
TenVD nvarchar(50),
Donvi nvarchar(20),
Soluong int check (Soluong>=0)
)
go

--------------------------------------------------------------------------------
----------------------------------------- Insert value
--------------------------------------------------------------------------------

insert into Khoadoivien values
('K13','2014-10-19'),
('K14','2015-10-19'),
('K15','2016-10-19'),
('K16','2017-10-19')
go

INSERT INTO Khoa VALUES 
('FIT','Cong nghe thong tin','2000'),
('CKD','Co khi dong luc','1962'),
('FME','Co khi che tao may',''),
('FEEE','Dien - dien tu',''),
('CNM','Cong nghe may va thoi trang',''),
('KTI','In va truyen thong',''),
('FHQ','Dao tao chat luong cao',''),
('FFL','Ngoai ngu',''),
('FE','Kinh te','')

insert into Thanhvien values
('1','Tran Huynh Phieu','1997-2-3','Ben Tre','CNTT','FIT','K16'),
('2','Nguyen Minh Thong','1997-1-8','Nha Trang','CNTT','FIT','K16'),
('3','Ho Thi Dieu Linh','1996-11-20','Binh Dinh','Dien','FEEE','K16'),
('4','Nguyen Thach Phat','1996-2-3','Dak Lak','Oto','CKD','K16'),
('5','Cao Ngoc Dung','1997-12-31','Binh Dinh','In','KTI','K16'),
('6','Cao Thanh Dai','1997-12-31','Khanh Hoa','Co khi','FME','K13'),
('7','Nguyen Luu Phat','1997-12-31','Long An','Co khi','FME','K13'),
('8','Le Tan Thanh','1997-12-31','Tien Giang','Dien','FEEE','K14'),
('9','Tran Thi Hong Gam','1997-12-31','Tien Giang','CNM','CNM','K14'),
('10','Cao Ngoc Dung','1997-12-31','Binh Dinh','In','FHQ','K16')
go

insert into Ban values
('1','Tinh nguyen'),
('2','Hien mau'),
('3','Truyen thong'),
('4','Thuong ki'),
('5','Doi ngoai'),
('6','Tai chinh'),
('7','Nhan su')
go

insert into Chuongtrinh values
('1','Hien mau','2017-10-28','SPKT','15000000',10),
('2','Trai TT','2017-10-28','SPKT','15000000',10),
('3','MHX','2017-10-28','SPKT','15000000',10),
('4','Trung thu','2017-10-28','SPKT','15000000',10),
('5','Chuyen di CTXH','2017-10-28','SPKT','15000000',10),
('6','Sinh hoat','2017-10-28','SPKT','15000000',10),
('7','Ban linh CTXH','2017-10-28','SPKT','15000000',10),
('8','Haloween','2017-10-28','SPKT','15000000',10),
('9','Hien mau','2017-10-28','SPKT','15000000',10),
('10','Hien mau','2017-10-28','SPKT','15000000',10)
go

insert into Bandieuhanh values
('NK13', '2014-10-19'),
('NK14', '2015-10-19'),
('NK15', '2016-10-19'),
('NK18', '2016-10-19'),
('NK16', '2017-10-19')
go

insert into ThamgiaChuongtrinh values
('1','1',10,'Tot'),
('1','2',10,'Tot'),
('1','3',10,'Tot'),
('2','4',10,'Tot'),
('2','5',10,'Tot'),
('3','1',10,'Tot'),
('3','2',10,'Tot'),
('4','3',10,'Tot')
go

insert into Thamgiaban values
('1','1'),
('2','2'),
('3','3'),
('4','4'),
('5','5'),
('6','6'),
('7','7')
go

insert into ThamgiaBDH values
('1','NK18','Doi truong'),
('2','NK18','Uy vien'),
('3','NK18','Doi pho'),
('4','NK18','Uy vien'),
('5','NK18','Uy vien')
go

Insert into dbo.Kho Values
('VD1','Duong','Cay',10),
('VD2','Mi tom','Thung',5),
('VD3','Thung nuoc','Thung',10),
('VD4','Chen','Cai',50),
('VD5','Ao hien mau','Cai',50),
('VD6','Tre','Cay',10),
('VD7','Loa','Cai',1),
('VD8','Xo','Cai',15)
go

--------------------------------------------------------------------------------
----------------------------------------- Store Procedure
--------------------------------------------------------------------------------

create procedure sp_LoadThanhVien
as
select * from Thanhvien
go

Create procedure sp_ThemThanhVien
        @MSSV nvarchar (30),
        @Hoten nvarchar (50),
        @Ngaysinh Date,
        @Quequan nvarchar(30),
        @Nganh nvarchar(30),
        @Khoa nvarchar(30),
        @KhoaDV nvarchar(30)
as
begin
insert into dbo.Thanhvien(MSSV,Hoten,Ngaysinh,Quequan,Nganh,Khoa,KhoaDV)
values (@MSSV,@Hoten,@Ngaysinh,@Quequan,@Nganh,@Khoa,@KhoaDV)
end
go

create proc upt_ThanhVien
@MSSV nvarchar(30),@Hoten nvarchar(50),@Ngaysinh date,@Quequan nvarchar(30),
@Nganh nvarchar(30),@Khoa nvarchar(30),@KhoaDV nvarchar(30)
as
begin
update Thanhvien
set Hoten=@Hoten,NgaySinh=@Ngaysinh,Quequan=@Quequan,Nganh=@Nganh,Khoa=@Khoa,KhoaDV=@KhoaDV
where MSSV=@MSSV
end
go

create proc Sp_TimKiemTV @Ma nvarchar(30)
as
select MSSV,Hoten,Ngaysinh,Quequan,Nganh,Khoa,KhoaDV
from dbo.Thanhvien
where @Ma=MSSV or @Ma=Hoten 
go

create procedure sp_LoadBan
as
select * from Ban
go

CREATE PROC usp_SoDV
        @KhoaDV nvarchar(30),
        @Soluong int output
AS
BEGIN
        SELECT  @Soluong= COUNT(*)
        FROM Thanhvien
        WHERE KhoaDV=@KhoaDV
END
go

-- ham tra ve mot bang thanh vien theo khoa DV
CREATE FUNCTION dbo.fu_DS_DoivienTheoKDV (@KhoaDv nvarchar(10))
RETURNS TABLE
AS
RETURN ( SELECT * FROM DBO.Thanhvien
		WHERE Thanhvien.KhoaDV=@KhoaDv)
go