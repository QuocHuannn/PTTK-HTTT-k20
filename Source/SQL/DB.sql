CREATE DATABASE QLKhachSan
--------------------------------------
USE QLKhachSan
------------ Create Table ------------
CREATE TABLE KhachHang (
   MaKH INT IDENTITY(1,1) PRIMARY KEY,
   HoTen NVARCHAR(100) NOT NULL,
   DiaChi NVARCHAR(200) NOT NULL,
   GioiTinh NVARCHAR(10) NOT NULL,
   Sdt NVARCHAR(20) NOT NULL,
   CMND NVARCHAR(20) UNIQUE NOT NULL 
);

CREATE TABLE Phong (
   MaPhong INT IDENTITY(1,1) PRIMARY KEY,
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
<<<<<<< Updated upstream
   MaDichVu INT IDENTITY(1,1) PRIMARY KEY,
   TenDichVu NVARCHAR(50) NOT NULL,
   GiaDichVu FLOAT NOT NULL
=======
  MaDV INT PRIMARY KEY,
  TenDV NVARCHAR(50) NOT NULL,
  Gia FLOAT NOT NULL,
  ThongTinDV NVARCHAR(255)
>>>>>>> Stashed changes
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
   MaNV INT,
   CONSTRAINT FK_Account_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
   CONSTRAINT FK_Account_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

<<<<<<< Updated upstream
=======
------------ Inserted ------------
INSERT INTO ThongTinCaNhan (IDCaNhan, Hoten, sdt, cmnd, diachi)
VALUES 
  (1, N'Nguyễn Văn A', '0987654321', '123456789', N'Hà Nội'),
  (2, N'Trần Thị B', '0987654322', '234567890', N'Hồ Chí Minh'),
  (3, N'Lê Văn C', '0987654323', '345678901', N'Đà Nẵng'),
  (4, N'Phạm Thị D', '0987654324', '456789012', N'Nha Trang'),
  (5, N'Nguyễn Thị E', '0987654325', '567890123', N'Hà Nội'),
  (6, N'Trần Văn F', '0987654326', '678901234', N'Hồ Chí Minh'),
  (7, N'Lê Thị G', '0987654327', '789012345', N'Đà Nẵng'),
  (8, N'Phạm Văn H', '0987654328', '890123456', N'Nha Trang'),
  (9, N'Nguyễn Thị K', '0987654329', '901234567', N'Hà Nội'),
  (10, N'Trần Văn L', '0987654330', '012345678', N'Hồ Chí Minh');
------------ Inserted ------------
INSERT INTO DichVu (MaDV, TenDv, Gia)
VALUES
  (1, N'Dịch vụ giặt là', 10000, N'Cung cấp dịch vụ giặt là và là ủi cho quần áo của khách hàng, giúp tiết kiệm thời gian và công sức.'),
  (2, N'Dịch vụ hâm nóng', 5000, N'Cung cấp dịch vụ hâm nóng đồ ăn hoặc thức uống của khách hàng, đảm bảo hương vị và nhiệt độ tốt nhất.'),
  (3, N'Dịch vụ massage', 50000, N'Cung cấp dịch vụ massage chuyên nghiệp để giúp khách hàng thư giãn, giảm căng thẳng và tái tạo năng lượng.'),
  (4, N'Dịch vụ đưa đón sân bay', 25000, N'Cung cấp dịch vụ đưa đón khách hàng từ sân bay đến khách sạn và ngược lại, đảm bảo sự thuận tiện và an toàn.'),
  (5, N'Dịch vụ thuê xe', 300000, N'Cung cấp dịch vụ cho thuê xe (xe hơi, xe máy, xe đạp,...) để khách hàng có thể tự do di chuyển và khám phá vùng đất mới.'),
  (6, N'Dịch vụ đặt tour du lịch', 100000, N'Cung cấp dịch vụ đặt tour du lịch để khách hàng có thể khám phá các địa điểm du lịch nổi tiếng và trải nghiệm văn hóa địa phương.'),
  (7, N'Dịch vụ đồ ăn', 15000, N'Cung cấp dịch vụ phục vụ đồ ăn và thức uống trong phòng, đáp ứng nhu cầu ẩm thực của khách hàng.'),
  (8, N'Dịch vụ thuê đồ dùng', 20000, N'Cung cấp dịch vụ cho thuê các đồ dùng như ghế, bàn, ánh sáng, âm thanh để phục vụ các sự kiện hoặc hội nghị.'),
  (9, N'Dịch vụ câu cá', 50000, N'Cung cấp dịch vụ câu cá cho khách hàng muốn trải nghiệm hoạt động ngoài trời.'),
  (10, N'Dịch vụ spa', 70000, N'Cung cấp dịch vụ chăm sóc sức khỏe để khách hàng loại bỏ mọi căng thẳng, áp lực.'),
  (11, N'Dịch vụ thuê hồ bơi', 10000, N'Cung cấp dịch vụ cho thuê hồ bơi riêng tư hoặc chung, cho phép khách hàng tận hưởng một không gian nghỉ ngơi và tắm nắng thoải mái.'),
  (12, N'Dịch vụ thuê sân thượng', 50000, N'Cung cấp dịch vụ cho thuê sân thượng để tổ chức tiệc nướng, tiệc rượu,... nhằm tạo điều kiện cho khách hàng tận hưởng không gian ngoài trời cùng người thân, bạn bè.'),
  (13, N'Dịch vụ thuê sân vườn', 50000, N'Cung cấp dịch vụ cho thuê sân vườn, phục vụ cho các sự kiện ngoài trời, bữa tiệc, hoặc buổi tụ tập gia đình.'),
  (14, N'Dịch vụ thuê phòng tập gym', 25000, N'Cung cấp dịch vụ cho thuê phòng tập gym, cho phép khách hàng tiếp tục duy trì lối sống lành mạnh và tập luyện khi đi du lịch.'),
  (15, N'Dịch vụ tham quan du thuyền', 300000, N'Cung cấp dịch vụ đặt tour tham quan trên du thuyền, cho phép khách hàng khám phá vẻ đẹp biển, đảo và cảnh quan từ biển.'),
  (16, N'Dịch vụ trông trẻ', 100000, N'Cung cấp dịch vụ trông trẻ chuyên nghiệp và an toàn, đảm bảo cha mẹ có thời gian riêng để thư giãn và khám phá.'),
  (17, N'Dịch vụ xem show ca nhạc', 15000, N'Cung cấp dịch vụ đặt vé xem các buổi biểu diễn ca nhạc, vũ đạo hoặc show trình diễn nghệ thuật.'),
  (18, N'Dịch vụ xem ảo thuật', 20000, N'cung cấp dịch vụ đặt vé xem các buổi biểu diễn ảo thuật tạo sự giải trí cho khách hàng.'),
  (19, N'Dịch vụ thuê nôi ngủ cho trẻ em', 50000, N'Cung cấp dịch vụ thuê nôi ngủ chất lượng và an toàn để đảm bảo giấc ngủ thoải mái cho trẻ em.'),
  (20, N'Dịch vụ tiệc cưới', 500000, N'Cung cấp dịch vụ tổ chức tiệc cưới, bao gồm không gian, thiết kế trang trí, âm thanh, ánh sáng và dịch vụ nhà hàng.'),
  (21, N'Dịch vụ thuê đồ cưới', 100000, N'Cung cấp dịch vụ cho thuê đồ cưới, bao gồm váy cưới, áo dài, phụ kiện và trang phục cưới khác, để đảm bảo khách hàng có một buổi lễ cưới hoàn hảo và đáng nhớ.'),
  (22, N'Dịch vụ giữ hành lý', 5000, N'Cung cấp dịch vụ giữ hành lý cho khách hàng khi họ ra khỏi khách sạn trong thời gian chờ hoặc sau khi trả phòng.'),
  (23, N'Dịch vụ thuê phòng bi-a', 50000, N'Cung cấp dịch vụ cho thuê phòng bi-a, cho phép khách hàng thư giãn và chơi bi-a trong không gian riêng tư.'),
  (24, N'Dịch vụ thuê sân golf', 250000, N'Cung cấp dịch vụ cho thuê sân golf để khách hàng tham gia hoạt động thể thao và trải nghiệm môn golf.'),
  (25, N'Dịch vụ thuê phòng bắn cung', 50000, N'Cung cấp dịch vụ cho thuê phòng bắn cung, cho phép khách hàng thử thách kỹ năng bắn cung của mình.'),
  (26, N'Dịch vụ thuê phòng hội thảo', 150000, N'Cung cấp dịch vụ cho thuê phòng hội thảo, cung cấp không gian và trang thiết bị phục vụ cho các cuộc họp, buổi thuyết trình và sự kiện.'),
  (27, N'Dịch vụ makeup', 15000, N'Cung cấp dịch vụ trang điểm chuyên nghiệp để khách hàng có diện mạo hoàn hảo, tự tin trong các bữa tiệc, sự kiện.'),
  (28, N'Dịch vụ làm tóc', 20000, N'Cung cấp dịch vụ làm tóc chuyên nghiệp, bao gồm cắt, nhuộm, uốn và tạo kiểu tóc theo yêu cầu của khách hàng.'),
  (29, N'Dịch vụ báo thức', 50000, N'cung cấp dịch vụ báo thức, giúp khách hàng được đánh thức và tỉnh táo vào giờ mong muốn. Điều này đảm bảo khách hàng không bỏ lỡ các cuộc họp, chuyến bay hoặc kế hoạch quan trọng.'),
  (30, N'Dịch vụ chăm sóc thú cưng', 70000, N'Cung cấp dịch vụ chăm sóc thú cưng, bao gồm việc đưa thú cưng đi dạo, cho ăn và chăm sóc hàng ngày.');
------------ Inserted ------------
INSERT INTO Phong (MaPhong, TenPhong, TinhTrang, Gia)
VALUES
  (101, N'Phòng đơn',N'Đã đặt', 500000),
  (102, N'Phòng đôi',N'Đã đặt', 700000),
  (103, N'Phòng view đẹp',N'Đang sử dụng', 100000),
  (104, N'Phòng gia đình',N'Đã đặt', 120000),
  (105, N'Phòng suit',N'Trống', 1500000),
  (201, N'Phòng đơn',N'Đang sử dụng', 500000),
  (202, N'Phòng đôi',N'Trống', 700000),
  (203, N'Phòng view đẹp',N'Đã đặt', 100000),
  (204, N'Phòng gia đình',N'Đang sử dụng', 120000),
  (205, N'Phòng President',N'Trống', 1900000),
  (301, N'Phòng đơn',N'Đang sử dụng', 500000),
  (302, N'Phòng đôi',N'Trống', 700000),
  (303, N'Phòng view đẹp',N'Đã đặt', 100000),
  (304, N'Phòng gia đình',N'Đang sử dụng', 120000),
  (305, N'Phòng President',N'Trống', 1900000),
  (401, N'Phòng đơn',N'Đang sử dụng', 500000),
  (402, N'Phòng đôi',N'Trống', 800000),
  (403, N'Phòng view đẹp',N'Đã đặt', 110000),
  (404, N'Phòng gia đình',N'Đang sử dụng', 130000),
  (405, N'Phòng President',N'Trống', 2100000),
  (501, N'Phòng đơn',N'Đang sử dụng', 500000),
  (502, N'Phòng đôi',N'Trống', 800000),
  (503, N'Phòng view đẹp',N'Đã đặt', 110000),
  (504, N'Phòng gia đình',N'Đang sử dụng', 130000),
  (505, N'Phòng President',N'Trống', 2100000),
  (601, N'Phòng đơn',N'Đang sử dụng', 500000),
  (602, N'Phòng đôi',N'Trống', 800000),
  (603, N'Phòng view đẹp',N'Đã đặt', 110000),
  (604, N'Phòng gia đình',N'Đang sử dụng', 130000),
  (605, N'Phòng President',N'Trống', 2100000),
  (701, N'Phòng đơn',N'Đang sử dụng', 700000),
  (702, N'Phòng đôi',N'Trống', 900000),
  (703, N'Phòng view đẹp',N'Đã đặt', 130000),
  (704, N'Phòng gia đình',N'Đang sử dụng', 150000),
  (705, N'Phòng President',N'Trống', 2700000),
  (801, N'Phòng đơn',N'Đang sử dụng', 750000),
  (802, N'Phòng đôi',N'Trống', 950000),
  (803, N'Phòng view đẹp',N'Đã đặt', 150000),
  (804, N'Phòng gia đình',N'Đang sử dụng', 200000),
  (805, N'Phòng President',N'Trống', 3000000);

  select* from Phong
  drop table Phong
>>>>>>> Stashed changes

--------Insert-----------

s