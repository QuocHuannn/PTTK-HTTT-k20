--- Cập nhật thông tin trong bảng Khách hàng ---
CREATE OR ALTER PROCEDURE UpdateKhachHang 
  @MaKH INT,
  @HoTen NVARCHAR(100),
  @Sdt NVARCHAR(20),
  @CMND NVARCHAR(20),
  @GioiTinh NVARCHAR(10),
  @DiaChi NVARCHAR(200)
AS
BEGIN
  IF EXISTS (SELECT * FROM KhachHang WHERE Sdt = @Sdt AND MaKH != @MaKH)
  BEGIN 
    RAISERROR('Số điện thoại đã tồn tại', 16, 1)
    RETURN;
  END
  
  IF EXISTS (SELECT * FROM KhachHang WHERE CMND = @CMND AND MaKH != @MaKH)
  BEGIN
    RAISERROR('CMND đã tồn tại', 16, 1)
    RETURN;
  END

  UPDATE KhachHang
  SET HoTen = @HoTen,
      Sdt = @Sdt,
      CMND = @CMND,
      GioiTinh = @GioiTinh,
      DiaChi = @DiaChi
  WHERE MaKH = @MaKH
END
----
EXEC UpdateKhachHang 
    @MaKH = 1,
    @HoTen = N'Test đổi tên',
    @Sdt = N'0979787519',
    @CMND = N'123456788',
    @GioiTinh = N'nam',
    @DiaChi = N'227 Nguyễn Văn Cừ'

-- Xem dịch vụ vs TenDichVu
CREATE PROCEDURE ShowDichVuByTen (@TenDichVu NVARCHAR(50))
AS
BEGIN
    SELECT *
    FROM DichVu
    WHERE TenDichVu LIKE '%' + @TenDichVu + '%'
END
----
exec ShowDichVuByTen N'giặt là'
----- thêm dịch vụ
CREATE PROCEDURE ThemDichVuVaoDatPhong
    @MaDatPhong INT,
    @MaDichVu INT,
    @SoLuong INT
AS
BEGIN
    DECLARE @TongTien FLOAT
    SELECT @TongTien = (GiaDichVu * @SoLuong) FROM DichVu WHERE MaDichVu = @MaDichVu
    
    INSERT INTO DatPhongDichVu(MaDatPhong, MaDichVu, SoLuong) VALUES(@MaDatPhong, @MaDichVu, @SoLuong)
    
    UPDATE HoaDon SET TongTien = TongTien + @TongTien WHERE MaDatPhong = @MaDatPhong
END
------- Hóa Đơn
CREATE PROCEDURE TinhHoaDon
    @MaDatPhong INT,
    @MaNV INT
AS
BEGIN
    DECLARE @TongTien FLOAT
    SET @TongTien = (
        SELECT SUM(GiaPhong) + SUM(GiaDichVu * SoLuong)
        FROM ChiTietDatPhong cdp
        LEFT JOIN DatPhongDichVu dpdv ON cdp.MaDatPhong = dpdv.MaDatPhong
        LEFT JOIN DichVu dv ON dpdv.MaDichVu = dv.MaDichVu
        LEFT JOIN Phong p ON cdp.MaPhong = p.MaPhong
        WHERE cdp.MaDatPhong = @MaDatPhong
    )

    DECLARE @MaHoaDon INT
    DECLARE @NgayIn DATE
    SET @NgayIn = GETDATE()

    INSERT INTO HoaDon (MaDatPhong, TongTien, NgayIn)
    VALUES (@MaDatPhong, @TongTien, @NgayIn)

    SET @MaHoaDon = SCOPE_IDENTITY()

    UPDATE ChiTietDatPhong
    SET DaThanhToan = 1
    WHERE MaDatPhong = @MaDatPhong

    SELECT @MaHoaDon AS 'MaHoaDon', @TongTien AS 'TongTien', @NgayIn AS 'NgayIn', @MaNV AS 'MaNV', @MaDatPhong AS 'MaDatPhong'
END

---- check đăng nhập
CREATE PROCEDURE sp_CheckLogin
   @Username VARCHAR(50),
   @Pass VARCHAR(255)
AS
BEGIN
   SET NOCOUNT ON;

   DECLARE @AccountID INT

   SELECT @AccountID = ID FROM Account WHERE Username = @Username AND Pass = @Pass;

   IF @AccountID IS NULL
   BEGIN
      RAISERROR('Tài khoản hoặc mật khẩu không đúng!', 16, 1);
   END
   ELSE
   BEGIN
      SELECT 'Success' AS Message;
   END
END

EXEC sp_CheckLogin @Username = 'DemoPro', @Pass = '123';
EXEC sp_CheckLogin @Username = 'DemoPro', @Pass = '1123';