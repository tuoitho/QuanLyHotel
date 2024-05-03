create database l7
GO
use l7
go
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Role] [varchar](20) NULL,
	[Status] [bit] NULL default 0
)
GO


insert into TaiKhoan(Username, Password, Role, Status) values('admin', '123' , 'admin', 1)

GO

CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[HoTen] [Nvarchar](50) NOT NULL,
	[Phai] [Nvarchar](10) NULL default null,
	[NgaySinh] [date] NULL default null,
	[DiaChi] [Nvarchar](100) NULL default null,
	[SDT] [varchar](20) NULL default null,
	[MaChucVu] int NULL default null,
    [Email] [varchar](50) NULL default Null,
	[MaTK] int NULL Default NULL,
    MaNQL int NULL default NULL

) 

GO
CREATE TABLE [dbo].[BaoCaoNgay](
	[MaBCN] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Ngay] [date] NULL,
	[MaNV] [int] NULL,
	[SoGio] [decimal](5, 2) NULL
) 

GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[TenHoaDon] [nvarchar](20) DEFAULT N'Hoá Đơn Tổng' NULL,
	[NgayLap] [datetime] DEFAULT NULL NULL,
    [NgayThanhToanHoanTat] [datetime]  DEFAULT NULL NULL,
    [TienDatCoc] [money] default 0 NULL,
    [TienPhong] [money] default 0 NULL,
    [TienDichVu] [money] default 0 NULL,
    [TongTienHoaDon] [money] default 0 NULL,
	[MaPhieuDK] int NULL,
    [MaKH] int NULL,
    [MaPhong] int NULL,
    [TrangThai] [Nvarchar](20) default N'Chưa thanh toán' NULL,
) 
GO
CREATE TABLE [dbo].[PhieuDangKy](
	[MaPhieuDK] int NOT NULL PRIMARY KEY  IDENTITY(1,1),
	[DuKienDen] [datetime] NULL,
	[DuKienDi] [datetime] NULL,
	[TienDatCoc] [money] NULL,
	[MaKH] int NULL,
	[MaPhong] int NULL,
    [TrangThai] [nvarchar](20) Default Null NULL
) 

GO
CREATE TABLE [dbo].[Phong](
	[MaPhong] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[TenPhong] [nvarchar](20) NULL,
	[TinhTrangPhong] [bit] NULL,
	[MaLoaiPhong] int NULL
)

go

CREATE TABLE [dbo].[LoaiPhong](
	[MaLoaiPhong] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[TenLoaiPhong] [nvarchar](20) NULL,
	[TrangThietBi] [nvarchar](100) NULL,
	[GiaLoaiPhong] [money] NULL,
	[MoTa] [nvarchar](100) NULL
) 


GO

-- CREATE TABLE [dbo].[ThayThe](
-- 	[MaTT] int NOT NULL PRIMARY KEY IDENTITY(1,1),
-- 	[MaPC] int NULL,
-- 	[MaNV] int NULL
-- ) 



go
CREATE TABLE [dbo].[KhachHang](
	[MaKH] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[HoTen] [nvarchar](255) NULL,
	[SDT] [nvarchar](15) NULL,
    [NgaySinh] [date] NULL,
	[CCCD] [nvarchar](12) NULL,
    [Email] [varchar](50) NULL default Null,
	[QuocTich] [nvarchar](50) NULL,
    [HinhAnh] IMAGE NULL,
    [MaTK] int NULL Default NULL
) 
go

CREATE TABLE [dbo].[PhanCa](
	[MaPC] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[MaCa] int NULL,
	[MaNV] int NULL,
	[Ngay] [date] NULL,
    [GioDen] [datetime] NULL,
	[GioDi] [datetime] NULL,
)

GO
CREATE TABLE [dbo].[Ca](
	[MaCa] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[TenCa] [nvarchar](50) NOT NULL,
	[BatDau] [datetime] NOT NULL,
	[KetThuc] [datetime] NOT NULL,
	[QL] [int] NULL,
	[TT] [int] NULL,
	[LC] [int] NULL
)
GO

CREATE TABLE [dbo].[LoaiDichVu](
	[MaLDV] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[TenLDV] [nvarchar](20) NULL
) 




GO

CREATE TABLE [dbo].[DichVu](
	[MaDV] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[TenDV] [nvarchar](20) NULL,
	[GiaDV] [money] NULL,
	[MaLDV] int NULL
)


GO

CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[TenChucVu] [nvarchar](50) NOT NULL,
	[LuongGio] [decimal](10, 2) NULL
) 

GO

CREATE TABLE [dbo].[ThuongPhat](
	[MaThuongPhat] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[MaNV] int NULL,
	[Tien] [decimal](10, 2) NULL,
	[Ngay] [date] NULL
) 
go

go
CREATE TABLE [dbo].[ChiTietHoaDonDichVu](
    [MaChiTietHDDV] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[MaDichVu] int NULL,
	[MaHoaDon] int not NULL,
	[SoLuong] [int] NULL,
	[Gia] [money] NULL,
) 
go
CREATE TABLE [dbo].[Luong](
	[MaNV]  int NOT NULL,
	[Ngay] [date] NOT NULL,
	[TienLuong] [decimal](10, 2) NULL,
    CONSTRAINT PK_Luong PRIMARY KEY (MaNV, Ngay)
) 
go
CREATE TABLE [dbo].[ThanhToan](
    [MaHoaDon] int Not NULL PRIMARY KEY,
    [NgayThanhToan] [datetime] NULL,
    [TongTienHoaDon] [money] NULL,
    [GiamGia] [money] NULL,
    [SoTien] [money] NULL
)
GO
create TABLE [dbo].[MaGiamGia](
    [MaGiamGia] int NOT NULL PRIMARY KEY IDENTITY(1,1),
    [MaKH] int NULL,
    [NgayNhan] [date] NULL,
    [SoTien] [money] NULL,
    DaSuDung bit NULL DEFAULT 0
)
---

ALTER TABLE NhanVien ADD CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK) on delete set NULL on update cascade
GO
alter TABLE NhanVien ADD CONSTRAINT FK_ChucVu_NhanVien FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu) on delete set null on update cascade
GO
ALTER TABLE BaoCaoNgay ADD CONSTRAINT FK_NhanVien_BaoCaoNgay FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete cascade on update cascade
GO
ALTER TABLE HoaDon ADD CONSTRAINT FK_PhieuDangKy_HoaDon FOREIGN KEY (MaPhieuDK) REFERENCES PhieuDangKy(MaPhieuDK) on delete cascade on update cascade
GO
ALTER TABLE PhieuDangKy ADD CONSTRAINT FK_KhachHang_PhieuDangKy FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) on delete cascade on update cascade
GO
-- sxoa khoa ngoai
-- ALTER TABLE PhieuDangKy DROP CONSTRAINT FK_KhachHang_PhieuDangKy
go

ALTER TABLE PhieuDangKy ADD CONSTRAINT FK_KhachHang_PhieuDangKy FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) on delete set null on update cascade
go
-------------------chu y
ALTER TABLE PhieuDangKy ADD CONSTRAINT FK_Phong_PhieuDangKy FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) on delete set null on update cascade
GO
-- ALTer TABLE ThayThe ADD CONSTRAINT FK_PhanCa_ThayThe FOREIGN KEY (MaPC) REFERENCES PhanCa(MaPC) on delete set null on update  NO ACTION
-- GO
-- ALTER TABLE ThayThe ADD CONSTRAINT FK_NhanVien_ThayThe FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete cascade on update cascade
-- GO
ALTER TABLE PhanCa ADD CONSTRAINT FK_Ca_PhanCa FOREIGN KEY (MaCa) REFERENCES Ca(MaCa) on delete cascade on update cascade
GO
ALTER TABLE PhanCa ADD CONSTRAINT FK_NhanVien_PhanCa FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete cascade on update cascade
GO
----
ALTER TABLE DichVu ADD CONSTRAINT FK_LoaiDichVu_DichVu FOREIGN KEY (MaLDV) REFERENCES LoaiDichVu(MaLDV) on delete set null on update cascade
GO
ALTER TABLE ThuongPhat ADD CONSTRAINT FK_NhanVien_ThuongPhat FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete cascade on update cascade
GO
-----chu y
ALTER TABLE ChiTietHoaDonDichVu ADD CONSTRAINT FK_DichVu_ChiTietHoaDonDichVu FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDV) on delete set null on update cascade
GO
ALTER TABLE ChiTietHoaDonDichVu ADD CONSTRAINT FK_HoaDon_ChiTietHoaDonDichVu FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon) on delete cascade on update cascade
GO
ALTER TABLE Luong ADD CONSTRAINT FK_NhanVien_Luong FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete cascade on update cascade
GO
ALTER TABLE phong ADD CONSTRAINT FK_LoaiPhong_Phong FOREIGN KEY (MaLoaiPhong) REFERENCES LoaiPhong(MaLoaiPhong) on delete cascade on update cascade
GO
ALTER TABLE MaGiamGia ADD CONSTRAINT FK_KhachHang_MaGiamGia FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) on delete cascade on update cascade
go
-- ALTER TABLE HoaDon ADD CONSTRAINT FK_KhachHang_HoaDon FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) on delete set null on update cascade
-- GO
-- ALTER TABLE HoaDon ADD CONSTRAINT FK_Phong_HoaDon FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) on delete set null on update cascade
GO
ALTER TABLE ThanhToan ADD CONSTRAINT FK_HoaDon_ThanhToan FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon) on delete CASCADE on update cascade
go
-- them khóa ngoại cho mã người quản lí trong nhanvien
ALTER TABLE NhanVien ADD CONSTRAINT FK_NhanVien_NhanVien FOREIGN KEY (MaNQL) REFERENCES NhanVien(MaNV) on delete no action on update no action
GO



--triger tu cap nhat giatien cua chitiethoadondichvu khi insert hoac update
CREATE TRIGGER TRG_ChiTietHoaDonDichVu ON ChiTietHoaDonDichVu
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE ChiTietHoaDonDichVu
    SET Gia = (SELECT GiaDV FROM DichVu WHERE MaDV = inserted.MaDichVu) * inserted.SoLuong
    FROM ChiTietHoaDonDichVu
    JOIN inserted ON ChiTietHoaDonDichVu.MaDichVu = inserted.MaDichVu AND ChiTietHoaDonDichVu.MaHoaDon = inserted.MaHoaDon
    
    UPDATE HoaDon
    SET TienDichVu = (SELECT SUM(Gia)
                    FROM ChiTietHoaDonDichVu
                        JOIN HoaDon ON ChiTietHoaDonDichVu.MaHoaDon = HoaDon.MaHoaDon and HoaDon.MaHoaDon = inserted.MaHoaDon),
    TongTienHoaDon =TienPhong -TienDatCoc + (SELECT SUM(Gia)
                    FROM ChiTietHoaDonDichVu
                        JOIN HoaDon ON ChiTietHoaDonDichVu.MaHoaDon = HoaDon.MaHoaDon and HoaDon.MaHoaDon = inserted.MaHoaDon)
    FROM HoaDon
    JOIN inserted ON HoaDon.MaHoaDon = inserted.MaHoaDon
END
GO
---trigger thay doi gia dich vu thì cập nhật lại giá tiền của chi tiết hoá đơn dịch vụ đòng thời cập nhật lại tổng tiền hoá đơn
CREATE TRIGGER TRG_DichVu ON DichVu
AFTER UPDATE
AS
BEGIN
    UPDATE ChiTietHoaDonDichVu
    SET Gia = (SELECT GiaDV FROM inserted) * SoLuong
    FROM ChiTietHoaDonDichVu
    JOIN inserted ON ChiTietHoaDonDichVu.MaDichVu = inserted.MaDV
    
END
go

-- triger trong nhanvien khi insert nhân viên mới thì cũng sẽ tạo tài khoản cho nhân viên đó
-- CREATE TRIGGER TRG_NhanVien ON NhanVien
-- AFTER INSERT
-- AS
-- BEGIN
--     DECLARE @Username NVARCHAR(50)
--     DECLARE @Password NVARCHAR(50)
--     DECLARE @tenchucvu NVARCHAR(50)
--     SELECT @tenchucvu;
--     if (SELECT MaChucVu FROM inserted) = 1
--         SELECT @tenchucvu = 'ql'
--     ELSE IF (SELECT MaChucVu FROM inserted) = 2
--         SELECT @tenchucvu = 'tt'
--     ELSE
--         SELECT @tenchucvu = 'lc'
--     -- tao ra username mac dinh la nv+ mã nhân viên chuyen sang nvarchar
--     SELECT @Username = @tenchucvu + CAST(inserted.MaNV AS VARCHAR(50)) FROM inserted
--     SELECT @Password = '123'
--     -- insert tai khoan cho nhan vien
--     INSERT INTO TaiKhoan(Username, Password, Role) VALUES(@Username, @Password, 'nhanvien')
--     -- cap nhat ma tai khoan cho nhan vien
--     UPDATE NhanVien
--     SET MaTK = (SELECT MaTK FROM TaiKhoan WHERE Username = @Username)
--     FROM NhanVien
--     JOIN inserted ON NhanVien.MaNV = inserted.MaNV
-- END


GO
--trigger trong pdk để tạo hoá đơn có thông phòng,khách hàng, tổng tiền hoá đơn (là số tiền ban đầu = tiền phòng * số đêm) từ phiếu đăng kí khi xác nhận phiếu đăng ký là hoàn thành
CREATE TRIGGER TRG_PhieuDangKy ON PhieuDangKy
AFTER INSERT,UPDATE
AS
BEGIN
    IF (SELECT TrangThai FROM PhieuDangKy WHERE MaPhieuDK = (SELECT MaPhieuDK FROM inserted)) like N'Hoàn thành'
    BEGIN
        IF (SELECT COUNT(*) FROM HoaDon WHERE MaPhieuDK = (SELECT MaPhieuDK FROM inserted)) = 0
            INSERT INTO HoaDon( TienDatCoc,TienPhong,TongTienHoaDon,MaPhieuDK, MaKH, MaPhong)
            SELECT  
                PhieuDangKy.TienDatCoc,
                LoaiPhong.GiaLoaiPhong * DATEDIFF(DAY, DuKienDen, DuKienDi), 
                LoaiPhong.GiaLoaiPhong * DATEDIFF(DAY, DuKienDen, DuKienDi) - PhieuDangKy.TienDatCoc,
                PhieuDangKy.MaPhieuDK,
                PhieuDangKy.MaKH,
                PhieuDangKy.MaPhong
            FROM PhieuDangKy
                JOIN Phong ON PhieuDangKy.MaPhong = Phong.MaPhong
                JOIN LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong
            WHERE MaPhieuDK = (SELECT MaPhieuDK FROM inserted)
        ELSE
            UPDATE HoaDon
            SET TienPhong = LoaiPhong.GiaLoaiPhong * DATEDIFF(DAY, DuKienDen, DuKienDi),
                TongTienHoaDon = LoaiPhong.GiaLoaiPhong * DATEDIFF(DAY, DuKienDen, DuKienDi) - PhieuDangKy.TienDatCoc,
                MaKH = PhieuDangKy.MaKH,
                MaPhong = PhieuDangKy.MaPhong,
                TienDatCoc = PhieuDangKy.TienDatCoc
            FROM HoaDon
                JOIN PhieuDangKy ON HoaDon.MaPhieuDK = PhieuDangKy.MaPhieuDK
                JOIN Phong ON PhieuDangKy.MaPhong = Phong.MaPhong
                JOIN LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong
            WHERE HoaDon.MaPhieuDK = (SELECT MaPhieuDK FROM inserted)
    END
END


GO
--trigger trong thanh toán để cập nhật trạng thái hoá đơn là đã thanh toán đồng thời cập nhật ngày thanh toán hoàn tất khi insert thanh toán, cập nhật lại trạng thái phòng
CREATE TRIGGER TRG_ThanhToan ON ThanhToan
AFTER INSERT
AS
BEGIN
    UPDATE HoaDon
    SET TrangThai = N'Đã thanh toán',
        NgayThanhToanHoanTat = GETDATE()
    FROM HoaDon
    JOIN inserted ON HoaDon.MaHoaDon = inserted.MaHoaDon

    UPDATE Phong
    SET TinhTrangPhong = 0
    FROM Phong
    JOIN HoaDon ON Phong.MaPhong = HoaDon.MaPhong
    JOIN inserted ON HoaDon.MaHoaDon = inserted.MaHoaDon

END
go


GO
insert into ChucVu(TenChucVu, LuongGio) values(N'QL', Null)
insert into ChucVu(TenChucVu, LuongGio) values(N'TT', 60000)
INSERT INTO ChucVu(TenChucVu, LuongGio) VALUES(N'LC', 40000)

go
INSERT INTO NhanVien(HoTen, Phai, NgaySinh, DiaChi, SDT, MaChucVu, MaTK) VALUES('Nguyen Van A', 'Nam', '2000-10-10', 'Ha Noi', '0123456789', 1, NULL)
INSERT INTO NhanVien(HoTen, Phai, NgaySinh, DiaChi, SDT, MaChucVu, MaTK) VALUES('Nguyen Van B', 'Nam', '2000-10-10', 'Ha Noi', '0123456789', 1, NULL)

INSERT INTO NhanVien(HoTen, Phai, NgaySinh, DiaChi, SDT, MaChucVu, MaTK) VALUES('Nguyen Van C', 'Nam', '2000-10-10', 'Ha Noi', '0123456789', 2, NULL)
INSERT INTO NhanVien(HoTen, Phai, NgaySinh, DiaChi, SDT, MaChucVu, MaTK) VALUES('Nguyen Van D', 'Nam', '2000-10-10', 'Ha Noi', '0123456789', 2, NULL)
INSERT INTO NhanVien(HoTen, Phai, NgaySinh, DiaChi, SDT, MaChucVu, MaTK) VALUES('Nguyen Van E', 'Nam', '2000-10-10', 'Ha Noi', '0123456789', 2, NULL)
INSERT INTO NhanVien(HoTen, Phai, NgaySinh, DiaChi, SDT, MaChucVu, MaTK) VALUES('Nguyen Van F', 'Nam', '2000-10-10', 'Ha Noi', '0123456789', 2, NULL)
INSERT INTO NhanVien(HoTen, Phai, NgaySinh, DiaChi, SDT, MaChucVu, MaTK) VALUES('Nguyen Van G', 'Nam', '2000-10-10', 'Ha Noi', '0123456789', 3, NULL)
INSERT INTO NhanVien(HoTen, Phai, NgaySinh, DiaChi, SDT, MaChucVu, MaTK) VALUES('Nguyen Van H', 'Nam', '2000-10-10', 'Ha Noi', '0123456789', 3, NULL)
INSERT INTO NhanVien(HoTen, Phai, NgaySinh, DiaChi, SDT, MaChucVu, MaTK) VALUES('Nguyen Van I', 'Nam', '2000-10-10', 'Ha Noi', '0123456789', 3, NULL)
INSERT INTO NhanVien(HoTen, Phai, NgaySinh, DiaChi, SDT, MaChucVu, MaTK) VALUES('Nguyen Van J', 'Nam', '2000-10-10', 'Ha Noi', '0123456789', 3, NULL)
INSERT INTO NhanVien(HoTen, Phai, NgaySinh, DiaChi, SDT, MaChucVu, MaTK) VALUES('Nguyen Van K', 'Nam', '2000-10-10', 'Ha Noi', '0123456789', 3, NULL)
INSERT INTO NhanVien(HoTen, Phai, NgaySinh, DiaChi, SDT, MaChucVu, MaTK) VALUES('Nguyen Van L', 'Nam', '2000-10-10', 'Ha Noi', '0123456789', 3, NULL)

go

insert into KhachHang(HoTen, SDT, CCCD, QuocTich) values(N'Nguyễn Văn A', '0123456789', '123456789012', N'Việt Nam')
insert into KhachHang(HoTen, SDT, CCCD, QuocTich) values(N'Nguyễn Văn B', '0123456789', '123456789012', N'Việt Nam')
insert into KhachHang(HoTen, SDT, CCCD, QuocTich) values(N'Nguyễn Văn C', '0123456789', '123456789012', N'Việt Nam')


go
insert into LoaiPhong(TenLoaiPhong, TrangThietBi, GiaLoaiPhong, MoTa) values('Loai Phong 1', 'TV, May Lanh, Tu Lanh', 100000, 'Loai Phong 1')
insert into LoaiPhong(TenLoaiPhong, TrangThietBi, GiaLoaiPhong, MoTa) values('Loai Phong 2', 'TV, May Lanh, Tu Lanh', 100000, 'Loai Phong 2')


go
insert into Phong(TenPhong, TinhTrangPhong, MaLoaiPhong) values(N'Phòng 1', 0, 1)
insert into Phong(TenPhong, TinhTrangPhong, MaLoaiPhong) values(N'Phòng 2', 0, 1)






go
insert into Ca(TenCa, BatDau, KetThuc, QL, TT, LC) values(N'Ca 1', '2021-10-10 07:00:00', '2021-10-10 15:00:00', 1, 1, 1)
insert into Ca(TenCa, BatDau, KetThuc, QL, TT, LC) values(N'Ca 2', '2021-10-10 15:00:00', '2021-10-10 23:00:00', 1, 1, 1)

GO
insert into LoaiDichVu(TenLDV) values(N'Dịch Vụ Thực Phẩm')
insert into LoaiDichVu(TenLDV) values(N'Dịch Vụ Giải Trí')
INSERT INTO LoaiDichVu(TenLDV) VALUES(N'Dịch Vụ Phòng')

GO
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Nước ngọt có gas', 100000, 1)
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Nước ngọt không gas', 100000, 1)
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Nước muối', 100000, 1)
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Nước không muối', 100000, 1)
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Nước lọc', 100000, 1)
INSERT INTO DichVu(TenDV, GiaDV, MaLDV) VALUES(N'Nước không lọc', 100000, 1)

insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Karaoke', 100000, 2)
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Xem phim', 100000, 2)
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Chơi game', 100000, 2)
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Đọc sách', 100000, 2)
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Nghe nhạc', 100000, 2)

insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Dọn dẹp phòng', 100000, 3)
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Giặt ủi', 100000, 3)
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Đổi chăn ga gối', 100000, 3)
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Đổi khăn tắm', 100000, 3)
insert into DichVu(TenDV, GiaDV, MaLDV) values(N'Đổi khăn mặt', 100000, 3)


GO



--
go
-- triger trong khachhang khi insert khach hang mới thì cũng sẽ tạo tài khoản cho khach hang do
-- CREATE TRIGGER TRG_KH ON KhachHang
-- AFTER INSERT
-- AS
-- BEGIN
--     -- tao ra username chua ton tai trong bang tai khoan
--     DECLARE @Username VARCHAR(50)
--     DECLARE @Password VARCHAR(50)
-- -- username mặc định là kh + mã khách hàng chuẩn hóa sang varchar
--     SELECT @Username = 'kh' + CAST(inserted.MaKH AS VARCHAR(50)) FROM inserted
--     SELECT @Password = '123'
--     -- insert tai khoan cho kh
--     INSERT INTO TaiKhoan(Username, Password, Role) VALUES(@Username, @Password, 'khachhang')
-- END



create table KhaiBao
(
    MaKB int not null primary key identity(1,1),
    MaKH int not null,
    MaHD int not null,
    MaDV int not null,
    SoLuong int not null,
    TrangThai nvarchar(20) not null default N'Chưa xử lý'
)

go
--trigger trong khai báo để tạo mã giảm giá khi có 1 khai báo từ khách hàng, chỉ tạo 1 lần
CREATE TRIGGER TRG_KhaiBao ON KhaiBao
AFTER INSERT
AS
BEGIN
    IF (SELECT COUNT(*) FROM MaGiamGia WHERE MaKH = (SELECT MaKH FROM inserted)) = 0
    BEGIN
    -- so tien ngaan nhat la 100000, cao nhat la 999999
        INSERT INTO MaGiamGia(MaKH, NgayNhan, SoTien) VALUES((SELECT MaKH FROM inserted), GETDATE(), FLOOR(RAND()*(999999-100000+1)+100000))
    END
END


go

-- --kiem tra hoá đơn có vấn đề, khi số lượng khách khai báo dịch vụ nhiều hơn số lượng dịch vụ trong phòng được nhân viên xác nhận
SELECT ISNULL(ChiTietHoaDonDichVu.MaDichVu, KhaiBao.MaDV) [Mã DV], ChiTietHoaDonDichVu.SoLuong as [Số lượng nhân viên cập nhật], KhaiBao.SoLuong as [Số lượng khách hàng khai báo]
FROM ChiTietHoaDonDichVu
full JOIN KhaiBao ON ChiTietHoaDonDichVu.MaHoaDon = KhaiBao.MaHD AND ChiTietHoaDonDichVu.MaDichVu = KhaiBao.MaDV
where ChiTietHoaDonDichVu.MaHoaDon = 4 or KhaiBao.MaHD=4
--sua lai so luong dich vu trong hoa don =0 thay vi null và mahoadon trong tat ca dong bang nhau

-- SELECT ISNULL(ChiTietHoaDonDichVu.MaDichVu, 0) as [MaDichVu], 
--        ISNULL(ChiTietHoaDonDichVu.SoLuong, 0) as [Số lượng nhân viên cập nhật], 
--        ISNULL(KhaiBao.SoLuong, 0) as [Số lượng khách hàng khai báo]
-- FROM ChiTietHoaDonDichVu
-- FULL JOIN KhaiBao ON ChiTietHoaDonDichVu.MaHoaDon = KhaiBao.MaHD AND ChiTietHoaDonDichVu.MaDichVu = KhaiBao.MaDV
-- WHERE (ChiTietHoaDonDichVu.MaHoaDon = 4 OR KhaiBao.MaHD = 4)
--   AND ISNULL(ChiTietHoaDonDichVu.MaHoaDon, 0) = ISNULL(KhaiBao.MaHD, 0)