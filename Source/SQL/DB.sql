CREATE DATABASE QLKhachSan
--------------------------------------
USE QLKhachSan
------------ Create Table ------------
CREATE TABLE KhachHang (
   MaKH INT IDENTITY(1,1) PRIMARY KEY,
   HoTen NVARCHAR(100),
   DiaChi NVARCHAR(200),
   GioiTinh NVARCHAR(10),
   Sdt NVARCHAR(20) UNIQUE,
   CMND NVARCHAR(20) UNIQUE  
);

CREATE TABLE Phong (
   MaPhong INT PRIMARY KEY,
   TenPhong NVARCHAR(50) NOT NULL ,
   LoaiPhong NVARCHAR(50) NOT NULL,
   GiaPhong FLOAT NOT NULL,
   TrangThai NVARCHAR(20) NOT NULL
);

CREATE TABLE NhanVien (
   MaNV INT IDENTITY(1,1) PRIMARY KEY,
   HoTen NVARCHAR(100) NOT NULL,
   Sdt NVARCHAR(20) NOT NULL
);

CREATE TABLE ChiTietDatPhong (
   MaDatPhong INT IDENTITY(1,1) PRIMARY KEY,
   MaPhong INT NOT NULL,
   MaKH INT NOT NULL,
   NgayThue DATE NOT NULL,
   NgayTra DATE NOT NULL,
   SoNguoi INT NOT NULL,
   DaThanhToan BIT NOT NULL DEFAULT 0,
   MaNV INT NOT NULL,
   CONSTRAINT FK_ChiTietDatPhong_MaPhong FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
   CONSTRAINT FK_ChiTietDatPhong_MaKH FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
   CONSTRAINT FK_ChiTietDatPhong_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

CREATE TABLE DichVu (
   MaDichVu INT IDENTITY(1,1) PRIMARY KEY,
   TenDichVu NVARCHAR(50) NOT NULL,
   GiaDichVu FLOAT NOT NULL,
   ThongTinDV NVARCHAR(255)
);

CREATE TABLE DatPhongDichVu (
   MaDatPhong INT NOT NULL,
   MaDichVu INT NOT NULL,
   SoLuong INT NOT NULL,
   CONSTRAINT PK_DatPhongDichVu PRIMARY KEY (MaDatPhong, MaDichVu),
   CONSTRAINT FK_DatPhongDichVu_MaDatPhong FOREIGN KEY (MaDatPhong) REFERENCES ChiTietDatPhong(MaDatPhong),
   CONSTRAINT FK_DatPhongDichVu_MaDichVu FOREIGN KEY (MaDichVu) REFERENCES DichVu(MaDichVu)
);

CREATE TABLE HoaDon (
   MaHoaDon INT IDENTITY(1,1) PRIMARY KEY,
   MaDatPhong INT NOT NULL,
   TongTien FLOAT NOT NULL,
   NgayIn DATE NOT NULL,
   CONSTRAINT FK_HoaDon_MaDatPhong FOREIGN KEY (MaDatPhong) REFERENCES ChiTietDatPhong(MaDatPhong)
);

CREATE TABLE Account (
   Id INT IDENTITY(1,1) PRIMARY KEY,
   Username VARCHAR(50) UNIQUE NOT NULL,
   Pass VARCHAR(255) NOT NULL,
   MaKH INT,
   CONSTRAINT FK_Account_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);


------------ Inserted ------------
INSERT INTO KhachHang (Hoten,Sdt,Cmnd,DiaChi)
VALUES 
  (N'Nguyễn Văn A', '0987654321', '123456789', N'Hà Nội'),
  (N'Trần Thị B', '0987654322', '234567890', N'Hồ Chí Minh'),
  (N'Lê Văn C', '0987654323', '345678901', N'Đà Nẵng'),
  (N'Phạm Thị D', '0987654324', '456789012', N'Nha Trang'),
  (N'Nguyễn Thị E', '0987654325', '567890123', N'Hà Nội'),
  (N'Trần Văn F', '0987654326', '678901234', N'Hồ Chí Minh'),
  (N'Lê Thị G', '0987654327', '789012345', N'Đà Nẵng'),
  (N'Phạm Văn H', '0987654328', '890123456', N'Nha Trang'),
  (N'Nguyễn Thị K', '0987654329', '901234567', N'Hà Nội'),
  (N'Trần Văn L', '0987654330', '012345678', N'Hồ Chí Minh');
------------ Inserted ------------
INSERT INTO DichVu (TenDichVu, GiaDichVu, ThongTinDV)
VALUES
  (N'Dịch vụ giặt là', 10000, N'Cung cấp dịch vụ giặt là và là ủi cho quần áo của khách hàng, giúp tiết kiệm thời gian và công sức.'),
  (N'Dịch vụ hâm nóng', 5000, N'Cung cấp dịch vụ hâm nóng đồ ăn hoặc thức uống của khách hàng, đảm bảo hương vị và nhiệt độ tốt nhất.'),
  (N'Dịch vụ massage', 50000, N'Cung cấp dịch vụ massage chuyên nghiệp để giúp khách hàng thư giãn, giảm căng thẳng và tái tạo năng lượng.'),
  (N'Dịch vụ đưa đón sân bay', 25000, N'Cung cấp dịch vụ đưa đón khách hàng từ sân bay đến khách sạn và ngược lại, đảm bảo sự thuận tiện và an toàn.'),
  (N'Dịch vụ thuê xe', 300000, N'Cung cấp dịch vụ cho thuê xe (xe hơi, xe máy, xe đạp,...) để khách hàng có thể tự do di chuyển và khám phá vùng đất mới.'),
  (N'Dịch vụ đặt tour du lịch', 100000, N'Cung cấp dịch vụ đặt tour du lịch để khách hàng có thể khám phá các địa điểm du lịch nổi tiếng và trải nghiệm văn hóa địa phương.'),
  (N'Dịch vụ đồ ăn', 15000, N'Cung cấp dịch vụ phục vụ đồ ăn và thức uống trong phòng, đáp ứng nhu cầu ẩm thực của khách hàng.'),
  (N'Dịch vụ thuê đồ dùng', 20000, N'Cung cấp dịch vụ cho thuê các đồ dùng như ghế, bàn, ánh sáng, âm thanh để phục vụ các sự kiện hoặc hội nghị.'),
  (N'Dịch vụ câu cá', 50000, N'Cung cấp dịch vụ câu cá cho khách hàng muốn trải nghiệm hoạt động ngoài trời.'),
  (N'Dịch vụ spa', 70000, N'Cung cấp dịch vụ chăm sóc sức khỏe để khách hàng loại bỏ mọi căng thẳng, áp lực.'),
  (N'Dịch vụ thuê hồ bơi', 10000, N'Cung cấp dịch vụ cho thuê hồ bơi riêng tư hoặc chung, cho phép khách hàng tận hưởng một không gian nghỉ ngơi và tắm nắng thoải mái.'),
  (N'Dịch vụ thuê sân thượng', 50000, N'Cung cấp dịch vụ cho thuê sân thượng để tổ chức tiệc nướng, tiệc rượu,... nhằm tạo điều kiện cho khách hàng tận hưởng không gian ngoài trời cùng người thân, bạn bè.'),
  (N'Dịch vụ thuê sân vườn', 50000, N'Cung cấp dịch vụ cho thuê sân vườn, phục vụ cho các sự kiện ngoài trời, bữa tiệc, hoặc buổi tụ tập gia đình.'),
  (N'Dịch vụ thuê phòng tập gym', 25000, N'Cung cấp dịch vụ cho thuê phòng tập gym, cho phép khách hàng tiếp tục duy trì lối sống lành mạnh và tập luyện khi đi du lịch.'),
  (N'Dịch vụ tham quan du thuyền', 300000, N'Cung cấp dịch vụ đặt tour tham quan trên du thuyền, cho phép khách hàng khám phá vẻ đẹp biển, đảo và cảnh quan từ biển.'),
  (N'Dịch vụ trông trẻ', 100000, N'Cung cấp dịch vụ trông trẻ chuyên nghiệp và an toàn, đảm bảo cha mẹ có thời gian riêng để thư giãn và khám phá.'),
  (N'Dịch vụ xem show ca nhạc', 15000, N'Cung cấp dịch vụ đặt vé xem các buổi biểu diễn ca nhạc, vũ đạo hoặc show trình diễn nghệ thuật.'),
  (N'Dịch vụ xem ảo thuật', 20000, N'cung cấp dịch vụ đặt vé xem các buổi biểu diễn ảo thuật tạo sự giải trí cho khách hàng.'),
  (N'Dịch vụ thuê nôi ngủ cho trẻ em', 50000, N'Cung cấp dịch vụ thuê nôi ngủ chất lượng và an toàn để đảm bảo giấc ngủ thoải mái cho trẻ em.'),
  (N'Dịch vụ tiệc cưới', 500000, N'Cung cấp dịch vụ tổ chức tiệc cưới, bao gồm không gian, thiết kế trang trí, âm thanh, ánh sáng và dịch vụ nhà hàng.'),
  (N'Dịch vụ thuê đồ cưới', 100000, N'Cung cấp dịch vụ cho thuê đồ cưới, bao gồm váy cưới, áo dài, phụ kiện và trang phục cưới khác, để đảm bảo khách hàng có một buổi lễ cưới hoàn hảo và đáng nhớ.'),
  (N'Dịch vụ giữ hành lý', 5000, N'Cung cấp dịch vụ giữ hành lý cho khách hàng khi họ ra khỏi khách sạn trong thời gian chờ hoặc sau khi trả phòng.'),
  (N'Dịch vụ thuê phòng bi-a', 50000, N'Cung cấp dịch vụ cho thuê phòng bi-a, cho phép khách hàng thư giãn và chơi bi-a trong không gian riêng tư.'),
  (N'Dịch vụ thuê sân golf', 250000, N'Cung cấp dịch vụ cho thuê sân golf để khách hàng tham gia hoạt động thể thao và trải nghiệm môn golf.'),
  (N'Dịch vụ thuê phòng bắn cung', 50000, N'Cung cấp dịch vụ cho thuê phòng bắn cung, cho phép khách hàng thử thách kỹ năng bắn cung của mình.'),
  (N'Dịch vụ thuê phòng hội thảo', 150000, N'Cung cấp dịch vụ cho thuê phòng hội thảo, cung cấp không gian và trang thiết bị phục vụ cho các cuộc họp, buổi thuyết trình và sự kiện.'),
  (N'Dịch vụ makeup', 15000, N'Cung cấp dịch vụ trang điểm chuyên nghiệp để khách hàng có diện mạo hoàn hảo, tự tin trong các bữa tiệc, sự kiện.'),
  (N'Dịch vụ làm tóc', 20000, N'Cung cấp dịch vụ làm tóc chuyên nghiệp, bao gồm cắt, nhuộm, uốn và tạo kiểu tóc theo yêu cầu của khách hàng.'),
  (N'Dịch vụ báo thức', 50000, N'cung cấp dịch vụ báo thức, giúp khách hàng được đánh thức và tỉnh táo vào giờ mong muốn. Điều này đảm bảo khách hàng không bỏ lỡ các cuộc họp, chuyến bay hoặc kế hoạch quan trọng.'),
  (N'Dịch vụ chăm sóc thú cưng', 70000, N'Cung cấp dịch vụ chăm sóc thú cưng, bao gồm việc đưa thú cưng đi dạo, cho ăn và chăm sóc hàng ngày.');
------------ Inserted ------------
INSERT INTO Phong (MaPhong, TenPhong, LoaiPhong, TrangThai, GiaPhong)
VALUES
(101, N'Phòng đơn', N'Gần Biển', N'Đã đặt', 500000),
(102, N'Phòng đôi', N'Gần hồ bơi', N'Đã đặt', 700000),
(103, N'Phòng view đẹp', N'View đẹp', N'Đang sử dụng', 100000),
(104, N'Phòng gia đình', N'Gần cửa hàng tiện lợi', N'Đã đặt', 120000),
(105, N'Phòng suit', N'Gần sân golf', N'Trống', 1500000),
(201, N'Phòng đơn', N'Gần Biển', N'Đang sử dụng', 500000),
(202, N'Phòng đôi', N'Gần hồ bơi', N'Trống', 700000),
(203, N'Phòng view đẹp', N'View đẹp', N'Đã đặt', 100000),
(204, N'Phòng gia đình', N'Gần cửa hàng tiện lợi', N'Đang sử dụng', 120000),
(205, N'Phòng President', N'Gần sân golf', N'Trống', 1900000),
(301, N'Phòng đơn', N'Gần Biển', N'Đang sử dụng', 500000),
(302, N'Phòng đôi', N'Gần hồ bơi', N'Trống', 700000),
(303, N'Phòng view đẹp', N'View đẹp', N'Đã đặt', 100000),
(304, N'Phòng gia đình', N'Gần cửa hàng tiện lợi', N'Đang sử dụng', 120000),
(305, N'Phòng President', N'Gần sân golf', N'Trống', 1900000),
(401, N'Phòng đơn', N'Gần Biển', N'Đang sử dụng', 500000),
(402, N'Phòng đôi', N'Gần hồ bơi', N'Trống', 800000),
(403, N'Phòng view đẹp', N'View đẹp', N'Đã đặt', 110000),
(404, N'Phòng gia đình', N'Gần cửa hàng tiện lợi', N'Đang sử dụng', 130000),
(405, N'Phòng President', N'Gần sân golf', N'Trống', 2100000);

  
