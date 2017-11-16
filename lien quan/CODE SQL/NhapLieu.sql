use DoiCTXH
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
INSERT INTO BanDieuhanh VALUES
(15,NULL),
(16,NULL),
(17,NULL),
(18,NULL)
GO
INSERT INTO Chuongtrinh VALUES
('XTN_12017',N'Xuân tình nguyện 2017','2017-1-18',N'Tây Ninh',350000,20),
('MHX_72017',N'Mùa hè xanh 2017','2017-7-15',N'Hồ Chí Minh',350000,30),
('CNTN_92017',N'Chủ nhật tình nguyện 9-2017','2017-9-10',N'Hồ Chí Minh',0,5)
GO
INSERT INTO Khoadoivien VALUES
('DV16','2016-3-18'),
('DV17','2016-5-10')
GO
INSERT INTO Ban VALUES
('BTK',N'Ban Thường Kỳ',NULL),
('BTC',N'Ban Tài chính',NULL),
('BTT',N'Ban Truyền thông',NULL),
('BTN',N'Ban Tình nguyện',NULL),
('BHM',N'Ban Hiến máu',NULL),
('BDN',N'Ban Đối ngoại',NULL),
('BNS',N'Ban Nhân sự',NULL)
GO
INSERT INTO Thanhvien VALUES
('15110276',N'Trần Huỳnh Phiêu','1997-11-9',N'Bến Tre',N'CN Thông tin','FIT','DV16'),
('15110323',N'Nguyễn Minh Thông','1997-1-8',N'Khánh Hòa',N'CN Thông tin','FIT','DV16'),
('15110363',N'Đỗ Quốc Việt','1997-6-18',N'Khánh Hòa',N'CN Thông tin','FIT',NULL),
('15148006',N'Cao Ngọc Dung','1997-12-31',N'Bình Định',N'CN In','FGAM','DV16'),
('14745071',N'Nguyễn Thạch Phát','1996-7-14',N'Đak Lak',N'CNKT Ô tô','FAE','DV16'),
('16141036',N'Phạm Quang Huy','1996-11-18',N'Thái Bình',N'Điện tử truyền thông','FEEE','DV17'),
('16109208',N'Đỗ Thị Thu Thủy','1996-9-13',N'Thái Bình',N'CN May','FGTTD','DV17'),
('17110341',N'Bùi Minh Nhật',NULL,N'Bình Phước',N'CN Thông tin','FIT',NULL),
('16145327',N'Phạm Tấn Bang',NULL,N'Phú Yên',N'CNKT Ô tô','FAE',NULL)
GO
INSERT INTO Thamgiachuongtrinh VALUES
('MHX_72017','15110276',30,'Xuất sắc'),
('MHX_72017','15110323',30,'Xuất sắc'),
('MHX_72017','15148006',30,'Xuất sắc'),
('MHX_72017','14745071',30,'Xuất sắc'),
('MHX_72017','16109208',30,'Xuất sắc'),
('MHX_72017','16141036',30,'Xuất sắc'),
('XTN_12017','16141036',20,'Xuất sắc'),
('XTN_12017','16109208',20,'Xuất sắc'),
('CNTN_92017','17110341',5,'Xuất sắc'),
('CNTN_92017','16145327',5,'Xuất sắc')
GO
INSERT INTO ThamgiaBDH VALUES
('15110276',18,'Đội trưởng'),
('15110323',18,'Ủy viên'),
('14745071',18,'Ủy viên')
GO
