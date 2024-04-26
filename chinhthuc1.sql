create database l3
GO
use l3
go
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NULL default Null,
	[Role] [varchar](20) NULL,
	[Status] [bit] NULL default 0
) 
GO


insert into TaiKhoan(Username, Password, Email, Role, Status) values('admin', 'admin', 'dinhtri42@gmail.com', 'admin', 1)

GO




CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] NOT NULL PRIMARY KEY IDENTITY(1,1),
	[HoTen] [Nvarchar](50) NOT NULL,
	[Phai] [Nvarchar](10) NULL,
	[NgaySinh] [date] NULL,
	[DiaChi] [Nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
	[MaChucVu] int NULL,
	[MaTK] int Default NULL NULL
) 



GO

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
	[MaNV] int NULL,
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

CREATE TABLE [dbo].[ThayThe](
	[MaTT] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[MaPC] int NULL,
	[MaNV] int NULL
) 



go
CREATE TABLE [dbo].[KhachHang](
	[MaKH] int NOT NULL PRIMARY KEY IDENTITY(1,1),
	[HoTen] [nvarchar](255) NULL,
	[SDT] [nvarchar](15) NULL,
	[CCCD] [nvarchar](12) NULL,
	[QuocTich] [nvarchar](50) NULL,
    [HinhAnh] IMAGE NULL
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

CREATE TABLE [dbo].[PhieuThanhToan](
    [MaPTT] int NOT NULL PRIMARY KEY IDENTITY(1,1),
    [MaHoaDon] int NULL,
    [NgayThanhToan] [datetime] NULL,
    [SoTien] [money] NULL
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
	[MaDichVu] int NOT NULL,
	[MaHoaDon] int NOT NULL,
	[SoLuong] [int] NULL,
	[Gia] [money] NULL,
    CONSTRAINT PK_ChiTietHoaDonDichVu PRIMARY KEY (MaDichVu, MaHoaDon)
) 
go
CREATE TABLE [dbo].[Luong](
	[MaNV]  int NOT NULL,
	[Ngay] [date] NOT NULL,
	[TienLuong] [decimal](10, 2) NULL,
    CONSTRAINT PK_Luong PRIMARY KEY (MaNV, Ngay)
) 

GO
---

ALTER TABLE NhanVien ADD CONSTRAINT FK_TaiKhoan_NhanVien FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK) on delete set NULL on update cascade
GO
alter TABLE NhanVien ADD CONSTRAINT FK_ChucVu_NhanVien FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu) on delete CASCADE on update cascade
GO
ALTER TABLE BaoCaoNgay ADD CONSTRAINT FK_NhanVien_BaoCaoNgay FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete cascade on update cascade
GO
ALTER TABLE HoaDon ADD CONSTRAINT FK_PhieuDangKy_HoaDon FOREIGN KEY (MaPhieuDK) REFERENCES PhieuDangKy(MaPhieuDK) on delete cascade on update cascade
GO 
ALTER TABLE PhieuDangKy ADD CONSTRAINT FK_NhanVien_PhieuDangKy FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete cascade on update cascade
GO
ALTER TABLE PhieuDangKy ADD CONSTRAINT FK_KhachHang_PhieuDangKy FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) on delete cascade on update cascade
GO
ALTER TABLE PhieuDangKy ADD CONSTRAINT FK_Phong_PhieuDangKy FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong) on delete cascade on update cascade
GO
ALTer TABLE ThayThe ADD CONSTRAINT FK_PhanCa_ThayThe FOREIGN KEY (MaPC) REFERENCES PhanCa(MaPC) on delete set null on update  NO ACTION
GO
ALTER TABLE ThayThe ADD CONSTRAINT FK_NhanVien_ThayThe FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete cascade on update cascade
GO
ALTER TABLE PhanCa ADD CONSTRAINT FK_Ca_PhanCa FOREIGN KEY (MaCa) REFERENCES Ca(MaCa) on delete cascade on update cascade
GO
ALTER TABLE PhanCa ADD CONSTRAINT FK_NhanVien_PhanCa FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete set null on update cascade
GO
ALTER TABLE DichVu ADD CONSTRAINT FK_LoaiDichVu_DichVu FOREIGN KEY (MaLDV) REFERENCES LoaiDichVu(MaLDV) on delete cascade on update cascade
GO
ALTER TABLE ThuongPhat ADD CONSTRAINT FK_NhanVien_ThuongPhat FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete cascade on update cascade
GO
ALTER TABLE ChiTietHoaDonDichVu ADD CONSTRAINT FK_DichVu_ChiTietHoaDonDichVu FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDV) on delete cascade on update cascade
GO
ALTER TABLE ChiTietHoaDonDichVu ADD CONSTRAINT FK_HoaDon_ChiTietHoaDonDichVu FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon) on delete cascade on update cascade
GO
ALTER TABLE Luong ADD CONSTRAINT FK_NhanVien_Luong FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) on delete cascade on update cascade
GO
ALTER TABLE phong ADD CONSTRAINT FK_LoaiPhong_Phong FOREIGN KEY (MaLoaiPhong) REFERENCES LoaiPhong(MaLoaiPhong) on delete cascade on update cascade
GO

ALTER TABLE HoaDon ADD CONSTRAINT FK_KhachHang_HoaDon FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
GO
ALTER TABLE HoaDon ADD CONSTRAINT FK_Phong_HoaDon FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
GO
ALTER TABLE PhieuThanhToan ADD CONSTRAINT FK_HoaDon_PhieuThanhToan FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon) on delete set NULL on update cascade

go
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

go

-- triger trong nhanvien khi insert nhân viên mới thì cũng sẽ tạo tài khoản cho nhân viên đó
CREATE TRIGGER TRG_NhanVien ON NhanVien
AFTER INSERT
AS
BEGIN
    -- tao ra username chua ton tai trong bang tai khoan
    DECLARE @Username NVARCHAR(50)
    DECLARE @Password NVARCHAR(50)
-- ngẫu nhiên 
    SELECT @Username = 'user' + CAST(ABS(CHECKSUM(NEWID())) % 100000 AS NVARCHAR(5)) FROM inserted
    SELECT @Password = '123'
    -- kiem tra xem username da ton tai chua
    WHILE EXISTS (SELECT * FROM TaiKhoan WHERE Username = @Username)
    BEGIN
        SELECT @Username = 'user' + CAST(ABS(CHECKSUM(NEWID())) % 100000 AS NVARCHAR(5)) FROM inserted
    END
    -- insert tai khoan cho nhan vien
    INSERT INTO TaiKhoan(Username, Password, Role) VALUES(@Username, @Password, 'user')
    -- cap nhat ma tai khoan cho nhan vien
    UPDATE NhanVien
    SET MaTK = (SELECT MaTK FROM TaiKhoan WHERE Username = @Username)
    FROM NhanVien
    JOIN inserted ON NhanVien.MaNV = inserted.MaNV
END


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

go
-- trigger trong phiếu thanh toán để cập nhật trang thái hoá đơn là đã thanh toán đồng thời cập nhật ngày thanh toán hoàn tất khi có tổng tiền hoá đơn = tổng số tiền đã thanh toán
CREATE TRIGGER TRG_PhieuThanhToan ON PhieuThanhToan
AFTER INSERT, UPDATE
AS
BEGIN
    UPDATE HoaDon
    SET TrangThai = N'Đã thanh toán',
        NgayThanhToanHoanTat = GETDATE()
    FROM HoaDon
    JOIN inserted ON HoaDon.MaHoaDon = inserted.MaHoaDon
    WHERE HoaDon.TongTienHoaDon = (SELECT SUM(SoTien) FROM PhieuThanhToan WHERE MaHoaDon = inserted.MaHoaDon)
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
insert into Phong(TenPhong, TinhTrangPhong, MaLoaiPhong) values(N'Phòng 1', 1, 1)
insert into Phong(TenPhong, TinhTrangPhong, MaLoaiPhong) values(N'Phòng 2', 1, 1)






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




-- --thêm thuộc tính mã người quản lí trong nhanvien
-- ALTER TABLE NhanVien ADD MaNQL int NULL default NULL
-- GO
-- -- them khóa ngoại cho mã người quản lí trong nhanvien
-- ALTER TABLE NhanVien ADD CONSTRAINT FK_NhanVien_NhanVien FOREIGN KEY (MaNQL) REFERENCES NhanVien(MaNV) on delete no action on update no action
-- GO
