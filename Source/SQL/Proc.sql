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
--Select * from KhachHang
EXEC UpdateKhachHang 
    @MaKH = 1,
    @HoTen = N'Test đổi tên',
    @Sdt = N'0979787519',
    @CMND = N'123456788',
    @GioiTinh = N'nam',
    @DiaChi = N'227 Nguyễn Văn Cừ'
