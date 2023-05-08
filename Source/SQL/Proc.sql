CREATE PROCEDURE CreateNewUser 
    @Username nvarchar(50), 
    @Password nvarchar(50)
AS
BEGIN
    DECLARE @SQL nvarchar(MAX)

    -- Kiểm tra xem username đã tồn tại chưa
    IF EXISTS (SELECT * FROM sys.server_principals WHERE name = @Username)
    BEGIN
        RAISERROR(N'Đã tồn tại tài', 16, 1)
        RETURN
    END

    -- Tạo login
    SET @SQL = 'CREATE LOGIN ' + QUOTENAME(@Username) + ' WITH PASSWORD = ' + QUOTENAME(@Password, '''')
    EXEC sp_executesql @SQL

    --- Thêm MaKH
    DECLARE @MaKH INT
    SELECT @MaKH = COALESCE(MAX(MaKH), 0) + 1 FROM KhachHang

    -- Thêm tài khoản vào bảng Account
    INSERT INTO account (username, pass) VALUES (@username, @password)

    -- Thêm KhachHang mới
    INSERT INTO KhachHang (MaKH) VALUES (@MaKH)

    -- Tạo user và phân quyền
    SET @SQL = 'USE [QLKhachSan] 
                CREATE USER ' + QUOTENAME(@Username) + ' FOR LOGIN ' + QUOTENAME(@Username) + '
                EXEC sp_addrolemember ''db_datareader'', ' + QUOTENAME(@Username) + '
                EXEC sp_addrolemember ''db_datawriter'', ' + QUOTENAME(@Username)
    EXEC sp_executesql @SQL
END

EXEC CreateNewUser 'Creatine', '123123' 
