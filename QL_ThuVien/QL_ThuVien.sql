create database QL_ThuVien
use QL_ThuVien

create table THUTHU
(
	MaTT char(10) not null primary key,
	TenTT nvarchar(50),
	MatKhau char(10),
	GioiTinh nvarchar(5),
	NgaySinh date,
	SDT char(20),
	DiaChi nvarchar(50),
	HinhAnhTT nvarchar(max),
)
create table DOCGIA
(
	MSSV char(10) not null primary key,
	MatKhau char(10) not null,
	TenDG nvarchar(50),
	GioiTinh nvarchar(5),
	NgaySinh date,
	SDT char(10),
	DiaChi nvarchar(50),
	NgayBD date,
	NgayKT date,
	TienCoc money,
	HinhAnhDG nvarchar(max),
)
create table TACGIA
(
	MaTG char(10) not null primary key,
	TenTG nvarchar(max),
	NgaySinh date,
	QueQuan nvarchar(50),
)
Create table NXB
(
	MaNXB char(10) not null primary key,
	TenNXB nvarchar(50),
)
create table THELOAI
(
	MaLoai char(10) not null primary key,
	TenLoai nvarchar(max),
)
create table SACH
(
	MaSach char(10) not null primary key,
	TenSach nvarchar(max),
	MaLoai char(10),
	SoLuong int,
	MoTa nvarchar(max),
	MaTG char(10) not null,
	TrangThai nvarchar(50),
	MaNXB char(10) not null,
	MaKhuVuc char(10) not null,
	Gia money,
	HinhAnhSach nvarchar(max),
	MaNCC char(10)
)
create table PHONG
(
	MaPhong char(10) not null primary key,
	MaKhuVuc char(10),
	TenPhong nvarchar(50),
	TinhTrang nvarchar(50),
	
)

create table KHUVUC
(
	MaKhuVuc char(10) not null primary key,
	TenKhuVuc nvarchar(50),
)


create table PHIEUMUON
(
	MaPM char(10) not null primary key,
	NgayMuon date,
	TongMuon int,
	MSSV char(10),
	MaTT char(10),
	TongPhiThu money
)


create table CTPHIEUMUON
(
	MaPM char(10) not null,
	MaSach char(10) not null,
	NgayTra date,
	SoLuongMuon int,
	TinhTrang nvarchar(50),
	PhiCoc money,
	primary key(MaPM, MaSach)
)

create table CTPHIEUTRA
(
	MaPT char(10) not null,
	MaPM char(10) not null,
	MaSach char(10) not null,
	TinhTrangSach nvarchar(max) not null,
	SoLuongTra int,
	ChiPhiDenBu money,
	primary key(MaPT,MaSach,MaPM)
)
create table PHIEUTRASACH
(
	MaPT char(10) not null primary key,
	NgayTra date,
	SoLuongTra int,
	TongTienDB money,
)



Create table CTPHIEUGIAHAN
(
	MaPGH char(10) not null,
	NgayGiaHan date,
	SoLuongGH int,
	MaPM char(10) not null,
	MaSach char(10) not null,
	primary key(MaPGH, MaPM, MaSach)
)



create table PHIEUGIAHAN
(
	MaPGH char(10) not null primary key,
	NgayGH date,
	TongSLGH int,
)



create table MUONPHONG
(
	MaPhong char(10) not null,
	MSSV char(10),
	NgayMuon date,
	ThoiGianSD int,
	TrangThai nvarchar(50),
	MaTT char(10),
	primary key(MaPhong, MSSV, NgayMuon, TrangThai, MaTT)
)
create table NHACC
(
	MaNCC char(10) not null primary key,
	TenNCC nvarchar(max),
	DiacChi nvarchar(max),
	SDT char(10)
)


create table NHAPSACH
(
	MaNhap char(10) not null primary key,
	MaNCC char(10),
	MaTT char(10),
	NgayNhap date,
	TongTien money,	
)

create table CTNHAPSACH
(
	MaNhap char(10) not null,
	MaSach char(10) not null,
	SoLuong int,
	DonGia money,
	ThanhTien money,
	primary key(MaNhap,MaSach)
)
----------------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------ KHÓA NGOẠI------------------------------------------

alter table SACH
add CONSTRAINT FK_SACH_LOAISACH FOREIGN KEY (MaLoai) REFERENCES THELOAI(MaLoai),
	CONSTRAINT FK_SACH_TACGIA FOREIGN KEY (MaTG) REFERENCES TACGIA(MaTG),
	CONSTRAINT FK_SACH_NXB FOREIGN KEY (MaNXB) REFERENCES NXB(MaNXB),
	CONSTRAINT FK_SACH_KHUVUC FOREIGN KEY (MaKhuVuc) REFERENCES KHUVUC(MaKhuVuc)
alter table NHAPSACH
add CONSTRAINT FK_NHAPSACH_NCC FOREIGN KEY (MaNCC) REFERENCES NHACC(MaNCC),
	CONSTRAINT FK_NHAPSACH_NCC_THUTHU FOREIGN KEY (MaTT) REFERENCES THUTHU(MaTT)

alter table CTPHIEUMUON
add CONSTRAINT FK_CTPHIEU_PHIEUMUON FOREIGN KEY (MaPM) REFERENCES PHIEUMUON(MaPM),
	CONSTRAINT FK_CTPHIEU_SACH FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)

alter table PHIEUMUON
add CONSTRAINT FK_PHIEUMUON_DOCGIA FOREIGN KEY (MSSV) REFERENCES DOCGIA(MSSV),
	CONSTRAINT FK_PHIEUMUON_THUTHU FOREIGN KEY (MaTT) REFERENCES THUTHU(MaTT)

alter table CTNHAPSACH
add CONSTRAINT FK_NHAPSACH_CTNHAP FOREIGN KEY (MaNhap) REFERENCES NHAPSACH(MaNhap),
	CONSTRAINT FK_NHAPSACH_SACH FOREIGN KEY (MaSach) REFERENCES SACH(MaSach)
alter table CTPHIEUTRA
add CONSTRAINT FK_CTPHIEUTRA_PHIEUTRA FOREIGN KEY (MaPT) REFERENCES PHIEUTRASACH(MaPT),
	CONSTRAINT FK_CTPHIEUTRA_CTPHIEUMUON FOREIGN KEY (MaPM, MaSach) REFERENCES CTPHIEUMUON(MaPM, MaSach)
alter table CTPHIEUGIAHAN
add CONSTRAINT FK_CTPHIEUGIAHAN_PHIEUGH FOREIGN KEY (MaPGH) REFERENCES PHIEUGIAHAN(MaPGH)
alter table CTPHIEUGIAHAN
add CONSTRAINT FK_CTPHIEUGIAHAN_CTPHIEUMUON FOREIGN KEY (MaPM, MaSach) REFERENCES CTPHIEUMUON(MaPM, MaSach)
alter table PHONG
add CONSTRAINT FK_PHONG_KHUVUC FOREIGN KEY (MaKhuVuc) REFERENCES KHUVUC(MaKhuVuc)

alter table MUONPHONG
add CONSTRAINT FK_MUONPHONG_PHONG FOREIGN KEY (MaPhong) REFERENCES PHONG(MaPhong),
CONSTRAINT FK_MUONPHONG_DOCGIA FOREIGN KEY (MSSV) REFERENCES DOCGIA(MSSV),
CONSTRAINT FK_MUONPHONG_TT FOREIGN KEY (MaTT) REFERENCES THUTHU(MaTT)
---------------------------------------------TRIGGER---------------------------------------------
------------------------------------KIỂM TRA NGÀY MƯỢN PHẢI LỚN HƠN NGÀY TRẢ---------------------
--go
--create trigger KTNGAYMUONTRa on CTPHIEUMUON for insert,update
--as
--if(select NgayTra from inserted) >= (select PHIEUMUON.NgayMuon from inserted, PHIEUMUON where inserted.MaPM = PHIEUMUON.MaPM)
--	commit tran
--else 
--	begin 
--	print 'Ngày Trả  > Ngày Mượn ROI!!!!'
--	rollback tran 
--	end
--go
---------------------------------------------PHIẾU MƯỢN - CT PHIẾU MƯỢN ------------------------
--Tổng số lượng mượn sách trong CTPHIEUMUON
Create trigger UpdateTongSLMuon on CTPHIEUMUON for insert,UPDATE
as
update PHIEUMUON
set TongMuon = (select SUM(SoLuongMuon) from CTPHIEUMUON where MaPM = (select MaPM from inserted))
where MaPM=(select MaPM from inserted)
--Tinh lại số sách khi mượn sách 
go
Create trigger UpdateSoLuongMuonSach on CTPHIEUMUON for insert,UPDATE
as
update SACH
set SoLuong = SACH.SoLuong -  (select inserted.SoLuongMuon  from inserted, SACH where inserted.MaSach = SACH.MaSach)
where  MaSach = (select MaSach from inserted) 
update CTPHIEUMUON
set PhiCoc = (select Gia*0.1*SoLuong  from SACH where MaSach = (select MaSach from inserted))
where MaPM=(select MaPM from inserted) and MaSach = (select MaSach from inserted)
update PHIEUMUON
set TongPhiThu = (select sum(PhiCoc) from CTPHIEUMUON where MaPM = (select MaPM from inserted))
where MaPM=(select MaPM from inserted)
go
----------------------------------------------------------------------------------------------------
----------------------------------NHẬP SÁCH && CT NHẬP SÁCH------------------------------
--Cập nhật lại ngày trả sau khi gia hạn
Create trigger UpdateThanhTien_SoLuong on CTNHAPSACH for insert,UPDATE
as
update CTNHAPSACH
set ThanhTien = SoLuong*DonGia
where MaNhap=(select MaNhap from inserted) and MaSach = (select MaSach from inserted)
update SACH
set SoLuong = SACH.SoLuong +  (select inserted.SoLuong  from inserted, SACH where inserted.MaSach = SACH.MaSach)
where  MaSach = (select MaSach from inserted) 
--Cập nhật lại ngày trả sau khi gia hạn
go
Create trigger UpdateTongTienNhapSach on CTNHAPSACH for insert,UPDATE
as
update NHAPSACH
set TongTien += (select ThanhTien from inserted)
where MaNhap=(select MaNhap from inserted)
go
-------------------------------------- MƯỢN PHÒNG --------------------------------------
--Cập nhâp lại phòng nếu có ng đã mượn phòng
CREATE TRIGGER UPDATETTPHONG
ON MUONPHONG
FOR INSERT 
AS
UPDATE PHONG
SET TinhTrang=N'Đã Có Người' where MaPhong=(select MaPhong from inserted)
---------------------------------------------------------------------------------------------------
-------------------------TRẢ SÁCH - CHI TIẾT TRẢ SÁCH ----------------------
--Tổng số lượng mượn sách trong CTPHIEUTRA
go
--Create trigger UpdateTongSLTra on CTPHIEUTRA for insert,UPDATE
--as
--update PHIEUTRASACH
--set SoLuongTra = (select SUM(SoLuongTra) from CTPHIEUTRA)
--where MaPT=(select MaPT from inserted)
go
--Cập nhật lso luong khi tra sách
Create trigger UpdateSoLuongTraSach on CTPHIEUTRA for insert,UPDATE
as
update SACH
set SoLuong = SACH.SoLuong +  (select inserted.SoLuongTra  from inserted, SACH where inserted.MaSach = SACH.MaSach)
where  MaSach = (select MaSach from inserted) 
update CTPHIEUMUON
set SoLuongMuon = CTPHIEUMUON.SoLuongMuon -  (select inserted.SoLuongTra  from inserted)
where MaPM=(select MaPM from inserted) and MaSach = (select MaSach from inserted)
update PHIEUTRASACH
set PHIEUTRASACH.SoLuongTra = (select SUM(CTPHIEUTRA.SoLuongTra) from CTPHIEUTRA, inserted where inserted.MaPT = CTPHIEUTRA.MaPT)
where MaPT=(select MaPT from inserted)

go
------------------------------------------------------------------------------
-------------------------------PHIẾU GIA HẠN - CT PHIẾU GIA HẠN ------------------------
--Tổng số lượng mượn sách trong CTPHIEUGIAHAN
Create trigger UpdateTongSLGIAHAN on CTPHIEUGIAHAN for insert,UPDATE
as
update PHIEUGIAHAN
set TongSLGH = (select SUM(SoLuongGH) from CTPHIEUGIAHAN)
where MaPGH=(select MaPGH from inserted)
--Cập nhật lại ngày trả sau khi gia hạn
go
Create trigger UpdateNgayTraGiaHan on CTPHIEUGIAHAN for insert,UPDATE
as
update CTPHIEUMUON
set NgayTra = (select NgayGiaHan from inserted)
where MaPM=(select MaPM from inserted) and MaSach = (select MaSach from inserted)
----------------------------------Nhập liệu ---------------------------------------------------
set dateformat DMY
insert into THUTHU
values('TT01',N'Đỗ Thanh Tùng','060900',N'Nam','06/11/2000','0832110611',N'80/26 Huỳnh Văn Nghệ, P.15, Q.Tân Bình',N'tung1'),
('TT02',N'Phạm Thị Vi','180800',N'Nữ','04/05/2000','0376437459',N'1 Bùi Xuân Phái, P.12, Q.Tân Phú',N'vi1'),
('TT03',N'Võ Quốc Cường','1234',N'Nam','03/02/2000','0909789987',N'12 Nguyễn Hữu Tiến, P.12, Q.Tân Phú',N'cuong1')

insert into TACGIA
values('TG01',N'Nguyễn Hữu Châu','09/01/1989',N'Bình Định'),
('TG02',N'Nguyễn Minh Thái','19/10/1991',N'Ninh Thuận'),
('TG03',N'Châu Trần Minh Luân','20/10/1981',N'TP.HCM'),
('TG04',N'Phan Mai Ngọc Thảo','13/04/1991',N'Nghệ An'),
('TG05',N'Đỗ Ngọc Phụng','22/10/1988',N'Thái Bình'),
('TG06',N'Lâm An Bình','11/11/1979',N'Tây Ninh'),
('TG07',N'Tô Ngọc Long','05/06/1998',N'An Giang'),
('TG08',N'Nguyễn Trần Nhất Trung','24/09/1992',N'Vũng Tàu'),
('TG09',N'Nguỳnh Huỳnh Quỳnh Châu','15/07/1991',N'Lâm Đồng'),
('TG010',N'Mai Thanh Quân','19/02/1981',N'Huế')

insert into NXB
values('NXB01',N'Kim Đồng'),
('NXB02',N'Tổng hợp thành phố Hồ Chí Minh'),
('NXB03',N'Giáo Dục'),
('NXB04',N'Hội Nhà văn'),
('NXB05',N'Tư pháp'),
('NXB06',N'Thông tin và truyền thông'),
('NXB07',N'Lao động'),
('NXB08',N'Giao thông vận tải'),
('NXB09',N'Đại học Quốc Gia Hà Nội'),
('NXB10',N'Trẻ')

insert into THELOAI
values('TL01',N'Văn học - tài liệu'),
('TL02',N'Sách - ebook'),
('TL03',N'Giáo trình'),
('TL04',N'Bài giảng'),
('TL05',N'Đề thi'),
('TL06',N'Bài thuyết trình'),
('TL07',N'Tiểu luận'),
('TL08',N'Luận văn'),
('TL09',N'Đề tài NCKH'),
('TL010',N'Văn bản - biểu mẫu')

insert into KHUVUC
values('KV01',N'Tầng 1'),
('KV02',N'Tầng 2'),
('KV03',N'Tầng 3'),
('KV04',N'Tầng 4'),
('KV05',N'Tầng 5')

insert into NHACC
values('NCC01',N'Đại Hoàng Gia',N'67 Lê Trọng Tấn, P.Tây Thạnh, Q.Tân Phú, TP.HCM','0289909900'),
('NCC02',N'Kim Hoàng',N'98 Nguyễn Thị Minh Khai, Q.7','0287778787'),
('NCC03',N'Hoàng Đại',N'80 Lý Chính Thắng','0289989989'),
('NCC04',N'Đại Minh Hoàng',N'Phạm Văn Đồng, Q.Gò Vấp','0285656566')


insert into SACH
values('S01',N'Nhà Giả Kim (Tái Bản 2020)','TL01',4,N'Tài liệu giới thiệu về chuẩn mực, mục đích của chuẩn mực trong kiểm soát nội bộ, chuẩn mực thuộc tính, chuẩn mực hoạt động. Mời các bạn cùng tham khảo tài liệu để nắm chi tiết nội dung về tiêu chuẩn Kiểm toán nội bộ quốc tế','TG01',N'Mới','NXB10','KV01',100000,N'sachNhaGiaKim','NCC01'),
	('S02',N'Rừng Nauy (Tái Bản 2018)','TL01',5,N'Quy chuẩn vệ sinh an toàn thực phẩm bếp ăn LG Food trình bày nhận dạng các mối nguy mất an toàn vệ sinh thực phẩm; Các biện pháp kiểm soát mối nguy trong thực phẩm; các quy trình trong bếp ăn.','TG01',N'Mới','NXB10','KV01',120000,N'sachRungNauy','NCC01'),
	('S03',N'Start With Why','TL02',7,N'"A powerful and penetrating exploration of what separates great companies and great leaders from the rest."','TG02',N'Cũ','NXB01','KV01',140000,N'sachStarWithWhy','NCC02'),
	('S04',N'Bí Mật Tư Duy Triệu Phú (Tái Bản 2019)','TL01',3,N'Trong dáng vẻ của một câu chuyện tâm tình giữa một nhà triệu phú kỳ dị, giàu sang đến tột đỉnh với một chàng thanh niên thất bại trong sự nghiệp, đang giãy giụa vượt qua khó khăn. Bài học để trở thành triệu phú sẽ đem lại cho chúng ta một cách nhìn khác về con người mình, về những nỗi đau trần thế của mình, chỉ cho chúng ta cách sống tích...','TG02',N'Mới','NXB01','KV01',90000,N'sachTrieuPhu','NCC02'),
	('S05',N'How Money Works','TL01',2,N'A user-friendly guide to understanding key financial concepts, How Money Works takes a highly visual approach to this topic, using bold infographics with clear, jargon-free text to make finances and economics easy to understand.','TG04',N'Cũ','NXB02','KV01',780000,N'sachMoney','NCC03'),
	('S06',N'Ứng Dụng Công Nghệ Trong Kinh Doanh','TL02',6,N'Tin học ứng dụng trong kinh doanh có nội dung gồm 6 chương, trang bị cho sinh viên những kiến thức về: Một số khái niệm về hệ quản trị cơ sở dữ liệu microsoft access, bảng dữ liệu (table), truy vấn (query), biểu mẫu (form), report (biểu báo), macro (tập lệnh). Mời các bạn cùng tham khảo.','TG04',N'Mới','NXB10','KV02',110000,N'sachCongNgheKD','NCC02'),
	('S07',N'Ứng Dụng Chiến Lược Quân Sự Trong Kinh Doanh','TL02',5,N'Có một câu ngạn ngữ không ai không biết: “Thương trường là chiến trường.” Những vị tướng chỉ huy ngoài mặt trận cũng là những nhà lãnh đạo tài ba. Bởi vậy, những nguyên tắc cốt lõi của việc điều binh khiển tướng cũng có thể áp dụng vào kinh doanh...','TG03',N'Cũ','NXB03','KV02',680000,N'sachChienLuocKD','NCC04'),
	('S08',N'Giáo Trình C++ Và Lập Trình Hướng Đối Tượng','TL03',5,N'Giáo Trình C++ Và Lập Trình Hướng Đối Tượng. Lập trình cấu trúc là phương pháp tổ chức, phân chia chương trình thành các hàm, thủ tục. Chúng được dùng để xử lý dữ liệu nhưng lại tách rời các cấu trúc dữ liệu...','TG06',N'Mới','NXB04','KV02',1550000,N'sachGiaoTrinhC','NCC03'),
	('S09',N'Giáo Trình Điện Tử Thực Hành','TL03',5,N'Điện tử thực hành là môn học cơ bản trong các Khoa Điện – Điện tử của nhiều trường. Cuốn “Giáo trình Điện tử thực hành” được biên soạn dựa trên cơ sở chương trình môn học Điện tử thực hành, dùng trong các trường Cao đẳng, Đại học khối công nghệ...','TG07',N'Mới','NXB06','KV02',200000,N'sachDienTu','NCC04'),
	('S010',N'Inbound Selling - Thay Đổi Phương Thức Bán Hàng Theo Mô Hình Inbound','TL02',5,N'Ngày nay với sự phát triển của ngành digital marketing, lượng khách hàng đến từ môi trường trực tuyến có thể cao hơn rất nhiều lần bộ phận sale trực tiếp hoặc các hoạt động marketing truyền thống..','TG03',N'Cũ','NXB05','KV02',197000,N'sachSelling','NCC03'),
	('S011',N'Danh Nhân Thế Giới','TL02',5,N'Cuốn sách Danh nhân thế giới sẽ giới thiệu đến bạn đọc những nhân vật nổi tiếng thế giới. Họ là những nhà quân sự, chính trị đại tài, nhà văn hóa, những nhà bác học tên tuổi và nổi tiếng. Danh tiếng của họ mãi mãi lưu danh sử sách...','TG07',N'Mới','NXB05','KV03',210000,N'sachDanhNhan','NCC04'),
	('S012',N'Bài giảng Logic học: Bài 1 ','TL04',5,N'Bài giảng Logic học - Bài 1: Nhập môn Logic học" trình bày đại cương về logic học; logic học nhằm xây dựng hứng thú học tập logic học và vận dụng logic học vào việc học tập, rèn luyện và trong ứng xử.','TG08',N'Cũ','NXB07','KV03',99000,N'sachLogic','NCC02'),
	('S013',N'Tư duy mới về Quản trị nhân lực: Bài 1','TL05',5,N'Bài giảng Quản trị nhân lực - Bài 1: Tổng quan về quản trị nhân lực" cung cấp khái niệm, tầm quan trọng của quản trị nhân lực; các hoạt động chủ yếu của quản trị nhân lực; triết lý quản trị nhân lực; sự phân chia trách nhiệm trong quản trị nhân lực; ảnh hưởng của môi trường đến hoạt động quản trị nhân lực.','TG09',N'Cũ','NXB08','KV03',79000,N'sachNhanLuc','NCC01'),
	('S014',N'Thần Tốc Luyện Đề 2021 - Môn Tiếng Anh','TL05',5,N'Không chỉ là 1 trong 3 môn thi bắt buộc mà Tiếng Anh còn là môn thi thuộc những tổ hợp xét tuyển được nhiều thí sinh lựa chọn nhất (A01, D01,..). Do đó, tỉ lệ cạnh tranh trong môn Tiếng Anh thường xuyên rất cao.','TG010',N'Mới','NXB09','KV03',70000,N'sachThiAV','NCC01'),
	('S015',N'Chất Phụ Gia Thực Phẩm - Cẩm Nang Cho Người Tiêu Dùng','TL06',5,N'Bài thuyết trình cung cấp cho người học những nội dung mà người tiêu dùng luôn muốn biết nhưng không có ai để hỏi. Hướng dẫn cho người tiêu dùng cách thức dễ dàng để biết chất phụ gia nào có trên nhãn bao bì thực phẩm, tự tìm ra tên hóa chất từ mã số của chất phụ gia đó và hiểu được vai trò, chức năng của nó.','TG07',N'Cũ','NXB08','KV03',150000,N'sachThucPham','NCC02'),
	('S016',N'Bài giảng Y Học Dinh Dưỡng - Những Điều Bác Sĩ Không Nói Với Bạn','TL04',5,N'Bài giảng Y Học Dinh Dưỡng - Những Điều Bác Sĩ Không Nói Với Bạn kiến thức dinh dưỡng trong phòng và điều trị bệnh.','TG08',N'Mới','NXB09','KV04',178000,N'sachBacSi','NCC02'),
	('S017',N'Tài liệu tập huấn kiến thức về Thực Phẩm Ngừa Ung Thư','TL07',5,N'Ăn uống thế nào để khỏe mạnh? Hiện nay, trước thực trạng thực phẩm bẩn và việc sử dụng tràn lan các phụ gia có nguồn gốc hóa chất, dẫn đến không ít người hoang mang trong việc ăn uống.','TG010',N'Cũ','NXB06','KV04',230000,N'sachNguaUThu','NCC03'),
	('S018',N'Luận văn Môn Ẩm Thực Nhật - Sushi Và Xiên Nướng','TL08',5,N'Cùng với mì Ramen, Sushi được xem là biểu tượng của đất nước mặt trời mọc và chế biến sushi gần như là một môn nghệ thuật tại Nhật Bản.  Cần ít nhất 10 năm để một người có thể trở thành nghệ nhân làm sushi nhưng bạn tin không...','TG09',N'Mới','NXB02','KV04',112000,N'sachSuShi','NCC02'),
	('S019',N'Những Tiểu Luận Triết Học','TL07',5,N'“Bertrand Russell là một nhà triết học viết văn xuôi tiếng Anh hay nhất thế kỷ XX” Anthony Howard, The Times..','TG02',N'Cũ','NXB07','KV04',139000,N'sachTrietHoc','NCC02'),
	('S020',N'Bài Giảng Cuối Cùng','TL04',5,N'Bài Giảng Cuối Cùng “Chúng ta không đổi được những quân bài đã chia, chỉ có thể đổi cách chơi những quân bài đó.” - Randy Paus','TG01',N'Mới','NXB09','KV04',184000,N'sachBaiGiang','NCC01'),
	('S021',N'Bài giảng Kiểm Soát Quản Trị - Corporate Governance','TL010',5,N'Bob Tricker được xem là “cha đẻ” của Corporate Governance / Kiểm soát quản trị. Ông đã cho ra đời cuốn sách – KIỂM SOÁT QUẢN TRỊ - được đánh giá là một trong những tác phẩm kinh điển, toàn diện và quy mô nhất về đề tài này.','TG05',N'Mới','NXB04','KV05',206000,N'sachKiemToan','NCC04'),
	('S022',N'Đề thi lý thuyết May & thiết kế thời trang năm 2011','TL05',5,N'Đề thi lý thuyết May & thiết kế thời trang năm 2011 (Mã đề TH5) sau đây gồm 5 câu hỏi với hình thức thi viết và thời gian làm bài trong vòng 180 phút. Mời các bạn cùng tham khảo và thử sức mình với đề thi nghề này nhé.','TG05',N'Mới','NXB03','KV05',106000,N'sachThoiTrang','NCC02'),
	('S023',N'Bài thuyết trình Tư Bản Thế Kỷ 21 - Le Capital Au XXIe SièCle','TL06',5,N'Bài thuyết trình Phân phối tài sản là một trong những vấn đề gây nhiều tranh cãi và được thảo luận rộng rãi nhất thời nay. Nhưng thật ra, ta biết gì về quá trình tiến hóa của phân phối tài sản trong dài hạn?','TG06',N'Mới','NXB02','KV05',153000,N'sachTuBan','NCC03'),
	('S024',N'Đồ án tốt nghiệp: Nghiên Cứu Văn Học Sử Với Hoa Bằng Qua Tạp Chí Tri Tân','TL07',5,N'Đồ án tốt nghiệp: Nghiên Cứu Văn Học Sử Với Hoa Bằng Qua Tạp Chí Tri Tân..','TG08',N'Mới','NXB03','KV05',130000,N'sachHoaBang','NCC04'),
	('S025',N'Big Data Cho Nhà Quản Lý','TL03',5,N'“Bất kỳ vị CEO nào cũng cần có khả năng đặt ra một câu hỏi liên quan đến việc kết nối dữ liệu xuyên suốt tổ chức, có khả năng điều hành hiệu quả một công ty, và đặc biệt cần có khả năng phản ứng tốt trước những sự kiện bất ngờ. Phần lớn các tổ chức đều thiếu năng lực kết nối toàn bộ dữ liệu với nhau,” theo nhận định của Tim Berners-Lee, người phát minh ra World Wide Web.','TG04',N'Mới','NXB01','KV05',180000,N'sachBigData','NCC01')

insert into PHONG
values('PH01','KV03',N'Phòng số 1',N'Còn trống'),
('PH02','KV03',N'Phòng số 2',N'Còn trống'),
('PH03','KV03',N'Phòng số 3',N'Còn trống'),
('PH04','KV03',N'Phòng số 4',N'Còn trống'),
('PH05','KV04',N'Phòng họp 1',N'Còn trống'),
('PH06','KV04',N'Phòng họp 2',N'Còn trống')

insert into DOCGIA
values('2001180221','1234',N'Thanh Tùng Đỗ',N'Nam','06/11/2000','0832110611',N'174/2 Nguyễn Tư Giãn','10/08/2018','10/08/2022',100000,N'C:\Users\Admin\Documents\Đồ Án năm 3\DoAn_PTTK_QLTV\hinh anh\tung1.jpg'),
('2001181417','040500',N'Phạm Thị Vi',N'Nữ','04/05/2000','0376437459',N'Bùi Xuân Phái','10/08/2018','10/08/2022',100000,N'C:\Users\Admin\Documents\Đồ Án năm 3\DoAn_PTTK_QLTV\hinh anh\Viheo.jpg'),
('2001180000','0001',N'Quốc Cường Võ',N'Nam','01/01/2000','0123456789',N'Tân Phú','10/08/2018','10/08/2022',100000,N'C:\Users\Admin\Documents\Đồ Án năm 3\DoAn_PTTK_QLTV\hinh anh\Viheo.jpg'),
('2001180001','0002',N'Minh Trung',N'Nam','01/02/2001','0987654321',N'Tân Bình','10/08/2019','10/08/2023',100000,N'C:\Users\Admin\Documents\Đồ Án năm 3\DoAn_PTTK_QLTV\hinh anh\tung2.jpg'),
('2001180002','0003',N'Văn Luân',N'Nam','01/03/1999','0987654321',N'Tân Bình','10/08/2017','10/08/2021',100000,N'C:\Users\Admin\Documents\Đồ Án năm 3\DoAn_PTTK_QLTV\hinh anh\tung3.jpg'),
('2001180003','0004',N'Thu Uyên',N'Nữ','01/02/2002','0999887676',N'Bình Thạnh','10/08/2020','10/08/2024',100000,N'C:\Users\Admin\Documents\Đồ Án năm 3\DoAn_PTTK_QLTV\hinh anh\Viheo.jpg')

insert into MUONPHONG
values ('PH02','2001181417','11/04/2021',2)
insert into MUONPHONG
values ('PH04','2001180221','01/04/2021',2)

insert into PHIEUMUON
values('PM01','04/04/2021',null,'2001181417','TT02', 0)

insert into PHIEUMUON
values('PM02','06/04/2021',null,'2001181417','TT02',0),
('PM03','07/04/2021',null,'2001180001','TT01',null),
('PM04','08/04/2021',null,'2001180002','TT03',null),
('PM05','08/04/2021',null,'2001180003','TT03',null),
('PM06','08/04/2021',null,'2001180004','TT01',null)

insert into CTPHIEUMUON
values('PM01','S01','12/04/2021',1,'Tốt',null)
insert into CTPHIEUMUON
values('PM01','S02','12/04/2021',3,'Tốt',null)
insert into CTPHIEUMUON
values ('PM01','S03','12/04/2021',3,'Tốt',20000)
insert into CTPHIEUMUON
values ('PM01','S04','12/04/2021',3,'Tốt',20000)
insert into CTPHIEUMUON
values ('PM02','S02','16/04/2021',3,'Tốt',null)
insert into CTPHIEUMUON
values ('PM02','S01','16/04/2021',3,'Tốt',30000)
insert into CTPHIEUMUON
values ('PM03','S03','16/04/2021',1,'Tốt',40000)
insert into CTPHIEUMUON
values ('PM04'	,'S04','16/04/2021',2,'Tốt',40000)
insert into CTPHIEUMUON
values ('PM05'	,'S01','16/04/2021',2,'Tốt',40000)


insert into PHIEUTRASACH(MaPT,NgayTra,SoLuongTra)
values('PT01','14/04/2021',0)
insert into PHIEUTRASACH(MaPT,NgayTra,SoLuongTra)
values ('PT02','16/04/2021',null)
insert into PHIEUTRASACH(MaPT,NgayTra,SoLuongTra)
values ('PT03','17/04/2021',null)
insert into PHIEUTRASACH(MaPT,NgayTra,SoLuongTra)
values ('PT04','18/04/2021',null)



insert into CTPHIEUTRA(MaPT,MaPM,MaSach,TinhTrangSach,SoLuongTra)
values('PT01','PM01','S01',N'tốt',1)
insert into CTPHIEUTRA(MaPT,MaPM,MaSach,TinhTrangSach,SoLuongTra)
values('PT01','PM2','S012',N'tốt',1)
insert into CTPHIEUTRA(MaPT,MaPM,MaSach,TinhTrangSach,SoLuongTra)
values('PT01','PM01','S03',N'tốt',1)
insert into CTPHIEUTRA(MaPT,MaPM,MaSach,TinhTrangSach,SoLuongTra)
values('PT01','PM01','S04',N'tốt',2)
insert into CTPHIEUTRA(MaPT,MaPM,MaSach,TinhTrangSach,SoLuongTra)
values ('PT02','PM01','S03',N'bị mất 1 trang sách',1)
insert into CTPHIEUTRA(MaPT,MaPM,MaSach,TinhTrangSach,SoLuongTra)
values ('PT03','PM03','S03',N'tốt',1)
insert into CTPHIEUTRA(MaPT,MaPM,MaSach,TinhTrangSach,SoLuongTra)
values ('PT04','PM04','S04',N'tốt',1)

insert into PHIEUGIAHAN
values('PGH01','18/04/2021',null),
('PGH02','20/04/2021',2)

insert into CTPHIEUGIAHAN
values('PGH01','17/04/2021',2,'PM01','S01')
insert into CTPHIEUGIAHAN
values('PGH01','17/04/2021',2,'PM01','S02')
insert into CTPHIEUGIAHAN
values('PGH02','20/04/2021',2,'PM04','S04')
insert into NHAPSACH
values ('MN01', 'NCC01', 'TT02','11/05/2021', 0)
insert into CTNHAPSACH
values ('MN01', 'S01', 3, 30000, 0)
insert into CTNHAPSACH
values ('MN01', 'S03', 3, 20000, 0)
insert into CTNHAPSACH
values ('MN01', 'S02', 3, 20000, 0)
insert into CTNHAPSACH
values ('MN01', 'S04', 3, 20000, 0)
insert into CTNHAPSACH
values ('MN01', 'S05', 3, 60000, 0)

select PHIEUMUON.MaPM, TenSach, NgayMuon, NgayTra, SoLuongMuon
from PHIEUMUON, CTPHIEUMUON, SACH
where MSSV = '2001181417' and PHIEUMUON.MaPM = CTPHIEUMUON.MaPM and CTPHIEUMUON.MaSach = SACH.MaSach and SoLuongMuon > 0
select sum(TongMuon) from PHIEUMUON where MSSV = '2001181417'
select MaSach
from SACH
select KHUVUC.MaKhuVuc, TenKhuVuc
from KHUVUC, PHONG
where KHUVUC.MaKhuVuc = PHONG.MaKhuVuc and MaPhong = 'PH01'
select SACH.* from SACH, TACGIA where SACH.MaTG = TACGIA.MaTG and TenTG like N'M%'

select DISTINCT PHIEUMUON.MaPM,SACH.MaSach,TenSach,CTPHIEUMUON.SoLuongMuon,NgayMuon
from CTPHIEUMUON,SACH,PHIEUMUON
where  PHIEUMUON.MaPM=  CTPHIEUMUON.MaPM and CTPHIEUMUON.MaSach = SACH.MaSach  and MSSV  = '2001181417' 

select DISTINCT PHIEUMUON.MaPM,SACH.MaSach,TenSach,CTPHIEUTRA.SoLuongTra ,CTPHIEUMUON.NgayTra
from CTPHIEUMUON,SACH,PHIEUMUON,CTPHIEUTRA,PHIEUTRASACH
where  PHIEUMUON.MaPM=  CTPHIEUMUON.MaPM and CTPHIEUMUON.MaSach = SACH.MaSach and CTPHIEUTRA.MaPT = PHIEUTRASACH.MaPT and CTPHIEUMUON.MaPM =  CTPHIEUTRA.MaPM and MSSV  = '2001181417' and SoLuongMuon = 0

select DISTINCT PHIEUMUON.MaPM,SACH.MaSach,TenSach,SoLuongMuon,CTPHIEUMUON.NgayTra
from CTPHIEUMUON,SACH,PHIEUMUON,CTPHIEUTRA,PHIEUTRASACH
where  PHIEUMUON.MaPM=  CTPHIEUMUON.MaPM and CTPHIEUMUON.MaSach = SACH.MaSach and CTPHIEUTRA.MaPT = PHIEUTRASACH.MaPT and CTPHIEUMUON.MaPM =  CTPHIEUTRA.MaPM and MSSV  = '2001181417' and SoLuongMuon > 0

