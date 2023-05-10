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

-- tạo đăng ký --
drop PROCEDURE RegisterAccount
CREATE PROCEDURE RegisterAccount
  @p_Username VARCHAR(255),
  @p_Pass VARCHAR(255),
  @p_ConfirmPass VARCHAR(255)
AS
BEGIN
  DECLARE @v_Count INT;
  
  -- Kiểm tra xem Username đã tồn tại trong bảng Account hay chưa
  SELECT @v_Count = COUNT(*) FROM Account WHERE Username = @p_Username;
  
  -- Nếu Username đã tồn tại, báo lỗi
  IF @v_Count > 0
  BEGIN
    THROW 50001, N'Username đã tồn tại', 1;
    RETURN;
  END;
  
  -- Kiểm tra xem mật khẩu và mật khẩu xác nhận có trùng khớp hay không
  IF @p_Pass <> @p_ConfirmPass
  BEGIN
    THROW 50002, N'Passwords không trùng khớp', 1;
    RETURN;
  END;
  
  -- Thêm tài khoản mới vào bảng Account
  INSERT INTO Account (Username, Pass) VALUES (@p_Username, @p_Pass);
END;
-------------------------------------------
DECLARE @Username VARCHAR(255);
DECLARE @Pass VARCHAR(255);
DECLARE @ConfirmPass VARCHAR(255);

SET @Username = 'NhanDeptrai';
SET @Pass = '1234512';
SET @ConfirmPass = '1234512';

EXEC RegisterAccount @Username, @Pass, @ConfirmPass;

select * from account
----update ID--
drop PROCEDURE UpdateAccountID
CREATE PROCEDURE UpdateAccountID
  @p_Username VARCHAR(50)
AS
BEGIN
  BEGIN TRY
    BEGIN TRANSACTION;

    -- Lấy giá trị ID từ bảng Account dựa trên tên người dùng
    DECLARE @v_AccountID INT;
    SELECT @v_AccountID = ID FROM Account WHERE Username = @p_Username;

    -- Cập nhật trường AccountID trong bảng KhachHang
    UPDATE KhachHang
    SET AccountID = @v_AccountID
    WHERE MaKH = (SELECT TOP 1 MaKH FROM KhachHang WHERE AccountID IS NULL);

    COMMIT;
  END TRY
  BEGIN CATCH
    IF @@TRANCOUNT > 0
      ROLLBACK;

    THROW;
  END CATCH;
END;
EXEC UpdateAccountID @p_Username = 'Nhan1';

---proc đặt phòng ---
drop PROCEDURE DatPhong
CREATE PROCEDURE DatPhong
  @NgayThue DATE,
  @NgayTra DATE,
  @TenPhong NVARCHAR(50),
  @TamGia FLOAT,
  @MaKH INT
AS
BEGIN
  -- Tìm phòng phù hợp với loại phòng và tầm giá tiền thuê
  DECLARE @MaPhong INT;
  SELECT TOP 1 @MaPhong = MaPhong
  FROM Phong
  WHERE TenPhong = @TenPhong AND GiaPhong <= @TamGia AND TrangThai = N'Trống'
  ORDER BY GiaPhong ASC;

  -- Nếu không tìm thấy phòng phù hợp, thông báo không có phòng khả dụng
  IF @MaPhong IS NULL
  BEGIN
    RAISERROR(N'Không có phòng khả dụng cho loại phòng và tầm giá tiền thuê đã chọn.', 16, 1);
    RETURN;
  END;

  -- Thực hiện việc đặt phòng
  BEGIN TRY
    BEGIN TRANSACTION;

    -- Cập nhật trạng thái phòng thành "Đã đặt"
    UPDATE Phong
    SET TrangThai = N'Đã đặt'
    WHERE MaPhong = @MaPhong;

    -- Thêm thông tin đặt phòng vào bảng ChiTietDatPhong
    INSERT INTO ChiTietDatPhong (MaPhong, MaKH, NgayThue, NgayTra, SoNguoi, DaThanhToan)
    VALUES (@MaPhong, @MaKH, @NgayThue, @NgayTra, 1, 0);

    COMMIT;
  END TRY
  BEGIN CATCH
    ROLLBACK;
    THROW;
  END CATCH;
END;

---
EXEC DatPhong @NgayThue = '2023-05-15', @NgayTra = '2023-05-20', @TenPhong = N'Phòng President', @TamGia = 2100000, @MaKH = 1;
select * from Phong
select * from Chitietdatphong
