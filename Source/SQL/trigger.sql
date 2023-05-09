
-- trigger set trangthai dat phong------------------------
CREATE TRIGGER trg_UpdateTrangThaiPhong
ON ChiTietDatPhong
AFTER INSERT
AS
BEGIN
   UPDATE Phong
   SET TrangThai = 'Đã đặt'
   WHERE MaPhong IN (SELECT MaPhong FROM inserted) AND TrangThai = 'Trống'
END


--trigger cap nhat thanh toan--------
CREATE TRIGGER trg_UpdateTongTien
ON DatPhongDichVu
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
   DECLARE @MaDatPhong INT
   
   SELECT @MaDatPhong = MaDatPhong
   FROM inserted
   
   UPDATE ChiTietDatPhong
   SET DaThanhToan = 1,
       TongTien = (SELECT SUM(SoLuong * GiaDichVu) FROM DatPhongDichVu JOIN DichVu ON DatPhongDichVu.MaDichVu = DichVu.MaDichVu WHERE MaDatPhong = @MaDatPhong)
   WHERE MaDatPhong = @MaDatPhong
END

--trigger kiem tra SL khach so voi SL da dat
CREATE TRIGGER trg_CheckSoNguoi
ON ChiTietDatPhong
AFTER INSERT
AS
BEGIN
   DECLARE @SoNguoi INT, @MaPhong INT
   
   SELECT @SoNguoi = SoNguoi, @MaPhong = MaPhong
   FROM inserted
   
   IF (@SoNguoi > (SELECT COUNT(*) FROM ChiTietDatPhong WHERE MaPhong = @MaPhong))
   BEGIN
      RAISERROR ('Số người không được vượt quá số lượng khách hàng đã đặt phòng!', 16, 1)
      ROLLBACK TRANSACTION
   END
END

--trigger check ngay dat
CREATE TRIGGER trg_CheckNgayDatHopLe
ON ChiTietDatPhong
FOR INSERT, UPDATE
AS
BEGIN
   IF EXISTS (
      SELECT 1
      FROM inserted
      WHERE NgayThue > NgayTra)
   BEGIN
      RAISERROR ('Ngày đặt phòng không hợp lệ!', 16, 1)
      ROLLBACK TRANSACTION
   END
END
