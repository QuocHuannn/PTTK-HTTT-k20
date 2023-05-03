USE QLKhachSan
------------ Create Table ------------
CREATE TABLE ThongTinCaNhan (
  IDCaNhan INT PRIMARY KEY,
  HoTen NVARCHAR(50) NOT NULL,
  Sdt int NOT NULL,
  Cmnd VARCHAR(20) UNIQUE NOT NULL,
  DiaChi NVARCHAR(100) NOT NULL
);

CREATE TABLE DichVu (
  MaDV INT PRIMARY KEY,
  TenDV NVARCHAR(50) NOT NULL,
  Gia FLOAT NOT NULL
);

CREATE TABLE Phong (
  MaPhong INT PRIMARY KEY,
  TenPhong NVARCHAR(50) NOT NULL,
  CheckIn Datetime,
  CheckOut Datetime,
  TinhTrang NVARCHAR(50) NOT NULL,
  Gia FLOAT NOT NULL
);

CREATE TABLE ThanhToan (
  IDHoaDon INT PRIMARY KEY,
  MaDV INT NOT NULL,
  MaPhong INT NOT NULL,
  DonGia FLOAT NOT NULL
);

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
  (1, N'Dịch vụ giặt là', 10000),
  (2, N'Dịch vụ hâm nóng', 5000),
  (3, N'Dịch vụ massage', 50000),
  (4, N'Dịch vụ đưa đón sân bay', 25000),
  (5, N'Dịch vụ thuê xe', 300000),
  (6, N'Dịch vụ đặt tour du lịch', 100000),
  (7, N'Dịch vụ đồ ăn', 15000),
  (8, N'Dịch vụ thuê đồ dùng', 20000),
  (9, N'Dịch vụ câu cá', 50000),
  (10, N'Dịch vụ spa', 70000);
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
  (205, N'Phòng President',N'Trống', 1900000);
  select* from Phong
  drop table Phong

------------ Foreign Key ------------
 /*ALTER TABLE ThanhToan
 CONSTRAINT fk_MaDV FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV),
 CONSTRAINT fk_MaPhong FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)

