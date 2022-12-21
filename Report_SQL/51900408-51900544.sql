

USE [master];
GO
DECLARE @kill varchar(8000) = '';  
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'  
FROM sys.dm_exec_sessions
WHERE database_id  = db_id('HoaMai')
EXEC(@kill);
drop database HoaMai
CREATE DATABASE HoaMai
USE HoaMai

CREATE TABLE KHOI
( 
	MAKHOI char(4) NOT NULL,
	TENKHOI nvarchar(10),
	GHICHU nvarchar(30),
	PRIMARY KEY(MAKHOI)
)

CREATE TABLE LOP
(
	MALOP char(4) NOT NULL,
	TENLOP nvarchar(10),
	GIAOVIENPHUTRACH nvarchar(30),
	PRIMARY KEY(MALOP)
)

CREATE TABLE MONHOC
(
	MAMON char(4) NOT NULL,
	TENMON nvarchar(30),
	PRIMARY KEY(MAMON)
)

CREATE TABLE BAIHOC
(
	MABAIHOC CHAR(4) NOT NULL,
	TENBAIHOC NVARCHAR(40) ,
	MAKHOI CHAR(4) NOT NULL,
	SOTIET INT ,
	YEUCAUVEDUNGCU NVARCHAR(100) ,
	MAMON CHAR(4) NOT NULL,
	PRIMARY KEY(MABAIHOC)
)

CREATE TABLE THOIKHOABIEU
(
	MABAIHOC CHAR(4) NOT NULL,
	MALOP CHAR(4) NOT NULL,
	THU NVARCHAR(50) ,
	SOTHUTUTIET INT ,
	NGAY DATE ,
	
)
CREATE TABLE HOCSINH
(
	MAHOCSINH CHAR(5) NOT NULL,
	TENHOCSINH nvarchar(30),
	DIEM INT ,
	PRIMARY KEY(MAHOCSINH)
)




alter table THOIKHOABIEU
add constraint FK_THOIKHOABIEU_BAIHOC foreign key(MABAIHOC) references BAIHOC(MABAIHOC)

alter table THOIKHOABIEU
add constraint FK_THOIKHOABIEU_LOP foreign key(MALOP) references LOP(MALOP)

alter table BAIHOC
add constraint FK_BAIHOC_KHOI foreign key(MAKHOI) references KHOI(MAKHOI)

alter table BAIHOC
add constraint FK_BAIHOC_MONHOC foreign key(MAMON) references MONHOC(MAMON)


INSERT INTO KHOI VALUES('K001', N'KHỐI MẦM',N'3 đến 4 tuổi')
INSERT INTO KHOI VALUES('K002', N'KHỐI CHỒI',N'4 đến 5 tuổi') 
INSERT INTO KHOI VALUES('K003', N'KHỐI LÁ',N'5 đến 6 tuổi')  

INSERT INTO LOP VALUES('L001', N'Lớp 1A',N'Trần Thị Thu Lan')  
INSERT INTO LOP VALUES('L002', N'Lớp 2A',N'Lê Thị Minh Hạnh')  
INSERT INTO LOP VALUES('L003', N'Lớp 3A',N'Nguyễn Thụy Huệ Chi')

INSERT INTO MONHOC VALUES('M001', N'Tiếng Việt thực hành')
INSERT INTO MONHOC VALUES('M002', N'Văn học thiếu nhi ')
INSERT INTO MONHOC VALUES('M003', N'Kỹ năng tạo hình')

INSERT INTO HOCSINH VALUES('H001', N'Trần Thu Hương','6')
INSERT INTO HOCSINH VALUES('H002', N'Phan Đế Nhi','7')
INSERT INTO HOCSINH VALUES('H003', N'Cao Nam Vang','4')


INSERT INTO BAIHOC VALUES ('B001',N'Dấu', 'K001', '10', N'Sách vở và bút chì', 'M001')
INSERT INTO BAIHOC VALUES ('B002',N'Nét lợt', 'K002', '10', N'Sách vở và bút chì', 'M001')
INSERT INTO BAIHOC VALUES ('B003',N'Nét đậm', 'K003', '10', N'Sách vở và bút chì', 'M001')
INSERT INTO BAIHOC VALUES ('B004',N'Thơ', 'K002', '15', N'Sách vở và bút chì', 'M002')
INSERT INTO BAIHOC VALUES ('B005',N'Thơ', 'K003', '20', N'Sách vở và bút chì', 'M002')
INSERT INTO BAIHOC VALUES ('B006',N'Kỹ năng cắt, xé dán', 'K001', '10', N'Giấy màu kéo và keo dán', 'M003')
INSERT INTO BAIHOC VALUES ('B007',N'Xếp hình Thỏ', 'K002', '15', N'Giấy màu và kéo', 'M003')
INSERT INTO BAIHOC VALUES ('B008',N'Tô màu', 'K003', '15', N'Tập và chì màu', 'M003')

INSERT INTO THOIKHOABIEU VALUES 
('B001','L001', N'THỨ 2 ĐẾN 5', '1', '2022-09-07') ,
('B002','L001', N'THỨ 2 ĐẾN 5', '2', '2022-09-07') ,
('B003','L003', N'THỨ 2 ĐẾN 5', '3', '2022-09-07')