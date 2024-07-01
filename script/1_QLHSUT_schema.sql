-- Switch to root container
ALTER SESSION SET CONTAINER = CDB$ROOT;

-- Switch to pluggable database
ALTER SESSION SET CONTAINER = XEPDB1;
ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE;

--------------------------------------------------------------------------------
-- 1. XÓA USER QLTH NẾU USER ĐÃ TỒN TẠI
--------------------------------------------------------------------------------
CREATE OR REPLACE PROCEDURE SYS.DROP_USER
    (OBJ_NAME VARCHAR2)
AS
    COUNT_VAR NUMBER;
    STRSQL VARCHAR2(2000);
BEGIN
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE';
    EXECUTE IMMEDIATE (STRSQL);
    
    STRSQL := 'SELECT COUNT(*) FROM DBA_USERS WHERE DBA_USERS.USERNAME = ' || '''' || OBJ_NAME || '''';
    EXECUTE IMMEDIATE (STRSQL) INTO COUNT_VAR;
    
    IF (COUNT_VAR = 1) THEN
        STRSQL := 'DROP USER ' || ' "' || OBJ_NAME || '" CASCADE';
        EXECUTE IMMEDIATE (STRSQL);
    END IF;
    
    STRSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE';
    EXECUTE IMMEDIATE (STRSQL);
END;
/

BEGIN SYS.DROP_USER('QLHSUT'); END;
/

--------------------------------------------------------------------------------
-- 2. TẠO USER QLTH VÀ CẤP CÁC QUYỀN CẦN THIẾT
--------------------------------------------------------------------------------
ALTER SESSION SET "_ORACLE_SCRIPT" = TRUE;
-- USER SQL
CREATE USER "QLHSUT" IDENTIFIED BY "123456" CONTAINER = CURRENT;
ALTER SESSION SET "_ORACLE_SCRIPT" = FALSE;

-- Grant role
GRANT "DBA" TO "QLHSUT" WITH ADMIN OPTION;
GRANT "CONNECT" TO "QLHSUT" WITH ADMIN OPTION;
GRANT "RESOURCE" TO "QLHSUT" WITH ADMIN OPTION;
GRANT SYSDBA TO QLHSUT;

-- Grant system privileges to the user
GRANT EXECUTE ANY PROCEDURE TO QLHSUT;
GRANT CREATE SESSION TO QLHSUT;
GRANT GRANT ANY ROLE TO QLHSUT;
GRANT CREATE SESSION, CREATE VIEW, ALTER SESSION, CREATE SEQUENCE TO QLHSUT;
GRANT CREATE USER, CREATE ROLE, ALTER USER, ALTER ANY ROLE, DROP USER, DROP ANY ROLE TO QLHSUT;
GRANT CREATE SYNONYM, CREATE DATABASE LINK, RESOURCE, UNLIMITED TABLESPACE TO QLHSUT;
GRANT CREATE TRIGGER TO QLHSUT;
GRANT EXECUTE ON SYS.DBMS_SESSION TO QLHSUT;
GRANT EXECUTE ON DBMS_CRYPTO TO QLHSUT;
GRANT EXEMPT ACCESS POLICY TO QLHSUT;
/
--------------------------------------------------------------------------------
-- 3. TẠO CSDL TRÊN SCHEMA QLHSUV
--------------------------------------------------------------------------------
-- Create tables
CREATE TABLE QLHSUT.QLHSUT_NGUOI_DAI_DIEN (
    MANDD NUMBER PRIMARY KEY,
    HOTEN NVARCHAR2(30),
    NGSINH DATE,
    GIOITINH NVARCHAR2(4) CHECK (GIOITINH IN (N'Nam', N'Nữ', N'Khác')),
    SDT CHAR(10),
    DIACHI NVARCHAR2(100), 
    EMAIL VARCHAR2(100)
);
/

CREATE TABLE QLHSUT.QLHSUT_DOANH_NGHIEP (
    MADN NUMBER PRIMARY KEY,
    TENDN NVARCHAR2(30),
    MASOTHUE CHAR(10),
    NDD NUMBER,
    SDT CHAR(10),
    DIACHI NVARCHAR2(100),
    EMAIL VARCHAR2(100),
    TTTAIKHOAN NUMBER DEFAULT 0 CHECK (TTTAIKHOAN IN (0, 1)) -- 0: CHƯA ĐƯỢC DUYỆT, 1: ĐÃ DUYỆT
);
/

CREATE TABLE QLHSUT.QLHSUT_NHAN_VIEN (
    MANV NUMBER PRIMARY KEY,
    HOTEN NVARCHAR2(30),
    NGSINH DATE,
    GIOITINH NVARCHAR2(4) CHECK (GIOITINH IN (N'Nam', N'Nữ', N'Khác')),
    SDT CHAR(10),
    DIACHI NVARCHAR2(100), 
    EMAIL VARCHAR2(100)
);
/

CREATE TABLE QLHSUT.QLHSUT_UNG_VIEN (
    MAUV NUMBER PRIMARY KEY,
    HOTEN NVARCHAR2(30),
    NGSINH DATE,
    GIOITINH NVARCHAR2(4) CHECK (GIOITINH IN (N'Nam', N'Nữ', N'Khác')),
    SDT CHAR(10),
    DIACHI NVARCHAR2(100), 
    EMAIL VARCHAR2(100),
    TRINHDO NVARCHAR2(100)
);
/

CREATE TABLE QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN (
    MADT NUMBER PRIMARY KEY,
    DN_DANGTUYEN NUMBER,
    VITRI_UNGTUYEN NVARCHAR2(100),
    SOLUONG NUMBER,
    MOTA NVARCHAR2(1000),
    YEUCAU_UNGVIEN NVARCHAR2(1000)
);
/

CREATE TABLE QLHSUT.QLHSUT_THONG_TIN_UU_DAI (
    MAUUDAI NUMBER PRIMARY KEY,
    DK_APDUNG NVARCHAR2(100),
    ND_UUDAI NVARCHAR2(100)
);
/

CREATE TABLE QLHSUT.QLHSUT_HOP_DONG_DANG_TUYEN (
    MAHOPDONG NUMBER PRIMARY KEY,
    MADT NUMBER,
    NGAYKI DATE,
    DIEUKHOAN_HD NVARCHAR2(100),
    NGAYHETHAN DATE,
    TT_UUDAI NUMBER
);
/

CREATE TABLE QLHSUT.QLHSUT_HINH_THUC_DANG_TUYEN (
    MAHT NUMBER PRIMARY KEY,
    TENHINHTHUC NVARCHAR2(30),
    NOIDUNG NVARCHAR2(100),
    CONGTHUC_THANHTIEN NUMBER
);
/

CREATE TABLE QLHSUT.QLHSUT_HINH_THUC_LUA_CHON (
    MAHOPDONG NUMBER,
    MAHT NUMBER,
    CONSTRAINT PK_HTLC PRIMARY KEY (MAHOPDONG, MAHT)
);
/

CREATE TABLE QLHSUT.QLHSUT_PHIEU_QUANG_CAO (
    MAPQC NUMBER PRIMARY KEY,
    MAHOPDONG NUMBER,
    TG_BATDAU DATE,
    TG_KETTHUC DATE,
    TONGTIEN NUMBER,
    TRANGTHAI_THANHTOAN NUMBER CHECK (TRANGTHAI_THANHTOAN IN (-1,0,1))
);
/

CREATE TABLE QLHSUT.QLHSUT_THONG_TIN_THANH_TOAN (
    MATT NUMBER PRIMARY KEY,
    MAPQC NUMBER,
    DOTTHANHTOAN NUMBER,
    TONGTIEN_THANHTOAN NUMBER,
    TRANGTHAI_THANHTOAN NUMBER CHECK (TRANGTHAI_THANHTOAN IN (-1,0,1))
);
/

CREATE TABLE QLHSUT.QLHSUT_HOA_DON (
    MAHOADON NUMBER PRIMARY KEY,
    MATT NUMBER,
    LOAITHANHTOAN NVARCHAR2(30) CHECK (LOAITHANHTOAN IN (N'Thanh toán một lần', N'Thanh toán theo đợt')),
    HINHTHUC_THANHTOAN NVARCHAR2(10) CHECK (HINHTHUC_THANHTOAN IN (N'Thẻ', N'Tiền mặt')),
    THANHTIEN NUMBER,
    NVLAP NUMBER
);
/

CREATE TABLE QLHSUT.QLHSUT_HO_SO_UNG_TUYEN (
    MAHS NUMBER PRIMARY KEY,
    MAUV NUMBER,
    MAPQC NUMBER,
    THONGTIN_HS NVARCHAR2(100),
    TRANGTHAIDUYET NUMBER DEFAULT 0 CHECK (TRANGTHAIDUYET IN (0, 1, 2, 3, 4, 5)),
    NVDUYET NUMBER
);
/

CREATE TABLE QLHSUT.QLHSUT_THONG_TIN_CHUNG_TU (
    MAHS NUMBER,
    MACHUNGTU NUMBER,
    ND_CHUNGTU NVARCHAR2(100),
    CONSTRAINT PK_TTCT PRIMARY KEY (MAHS, MACHUNGTU)
);
/

CREATE TABLE QLHSUT.QLHSUT_THONG_TIN_BANG_CAP (
    MAHS NUMBER,
    MABANGCAP NUMBER,
    TENBANGCAP NVARCHAR2(30),
    NGAYHETHAN DATE,
    ND_BANGCAP NVARCHAR2(100),
    CONSTRAINT PK_TTBC PRIMARY KEY (MAHS, MABANGCAP)
);
/

--------------------------------------------------------------------------------
--INSERT DATA
INSERT INTO "QLHSUT"."QLHSUT_NGUOI_DAI_DIEN" (MANDD, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL) VALUES ('10001', N'Nguyễn Văn An', TO_DATE('2002-02-12', 'YYYY-MM-DD'), N'Nam', '0911222312', N'22 Hoàng Mai', 'NguyenVanAn@gmail.com');
INSERT INTO "QLHSUT"."QLHSUT_NGUOI_DAI_DIEN" (MANDD, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL) VALUES ('10002', N'Nguyễn Thị Bình', TO_DATE('2004-05-28', 'YYYY-MM-DD'), N'Nữ', '0991142241', N'12 Hoàng Diệu', 'NguyenThiBinh@gmail.com');
INSERT INTO "QLHSUT"."QLHSUT_NGUOI_DAI_DIEN" (MANDD, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL) VALUES ('10003', N'Trần Văn Khoa', TO_DATE('2006-01-19', 'YYYY-MM-DD'), N'Khác', '0908221192', N'01 Cao Vân', 'TranVanKhoa@gmail.com');
INSERT INTO "QLHSUT"."QLHSUT_NGUOI_DAI_DIEN" (MANDD, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL) VALUES ('10004', N'Huỳnh Thị Diệu', TO_DATE('2000-11-29', 'YYYY-MM-DD'), N'Nữ', '0865761281', N'05 Bạch Mai', 'HuynhThiDieu@gmail.com');
INSERT INTO "QLHSUT"."QLHSUT_NGUOI_DAI_DIEN" (MANDD, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL) VALUES ('10005', N'Cao Văn Đại', TO_DATE('2001-12-22', 'YYYY-MM-DD'), N'Nam', '0872193022', N'07 Trần Ninh', 'CaoVanDai@gmail.com');

INSERT INTO "QLHSUT"."QLHSUT_DOANH_NGHIEP" (MADN, TENDN, MASOTHUE, NDD, SDT, DIACHI, EMAIL) VALUES ('20001', N'VIN', '1129293122', '10002', '0281933203', N'10 Bạch Vân', 'VIN@gmail.com');
INSERT INTO "QLHSUT"."QLHSUT_DOANH_NGHIEP" (MADN, TENDN, MASOTHUE, NDD, SDT, DIACHI, EMAIL) VALUES ('20002', N'FPT', '2913281044', '10004', '0289173802', N'20 Cao Mỹ', 'FPT@gmail.com');
INSERT INTO "QLHSUT"."QLHSUT_DOANH_NGHIEP" (MADN, TENDN, MASOTHUE, NDD, SDT, DIACHI, EMAIL) VALUES ('20003', N'VNG', '7629102933', '10001', '0287201391', N'18 Văn Hoài', 'VNG@gmail.com');
INSERT INTO "QLHSUT"."QLHSUT_DOANH_NGHIEP" (MADN, TENDN, MASOTHUE, NDD, SDT, DIACHI, EMAIL) VALUES ('20004', N'GEO', '9822108322', '10003', '0288822102', N'05 Hội An', 'GEO@gmail.com');
INSERT INTO "QLHSUT"."QLHSUT_DOANH_NGHIEP" (MADN, TENDN, MASOTHUE, NDD, SDT, DIACHI, EMAIL) VALUES ('20005', N'KMS', '7283290155', '10005', '0281922312', N'09 Hồ Gươm', 'KMS@gmail.com');

INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_DANG_TUYEN" (MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA, YEUCAU_UNGVIEN) VALUES ('30001', '20002', N'Nhân viên', '2', N'Nhân viên làm việc văn phòng', N'Trên 2 năm kinh nghiệm');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_DANG_TUYEN" (MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA, YEUCAU_UNGVIEN) VALUES ('30002', '20004', N'Lao công', '4', N'Lao công quét dọn văn phòng', N'Trên 5 năm kinh nghiệm');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_DANG_TUYEN" (MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA, YEUCAU_UNGVIEN) VALUES ('30003', '20005', N'Trưởng phòng', '1', N'Trường phòng kinh doanh', N'Trên 10 năm kinh nghiệm');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_DANG_TUYEN" (MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA, YEUCAU_UNGVIEN) VALUES ('30004', '20003', N'Thực tập sinh', '10', N'Thực tập sinh phần mềm', N'Tốt nghiệp đại học');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_DANG_TUYEN" (MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA, YEUCAU_UNGVIEN) VALUES ('30005', '20001', N'Thư ký', '1', N'Thư kí riêng cho giám đốc', N'Trên 3 năm kinh nghiệm');

INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_UU_DAI" (MAUUDAI, DK_APDUNG, ND_UUDAI) VALUES ('40001', N'Cho người có khả năng tăng ca', N'Tăng Lương theo thỏa thuận');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_UU_DAI" (MAUUDAI, DK_APDUNG, ND_UUDAI) VALUES ('40002', N'Cho người có khả năng làm việc không phải giờ hành chính', N'Tăng Lương gấp đôi');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_UU_DAI" (MAUUDAI, DK_APDUNG, ND_UUDAI) VALUES ('40003', N'Cho người có trên 5 năm kinh nghiệm', N'Cung cấp chỗ ở');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_UU_DAI" (MAUUDAI, DK_APDUNG, ND_UUDAI) VALUES ('40004', N'Cho người không có làm việc thường xuyên tại công ty', N'Giảm lương');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_UU_DAI" (MAUUDAI, DK_APDUNG, ND_UUDAI) VALUES ('40005', N'Cho người làm việc không lương', N'Nhận trợ cấp của công ty');

INSERT INTO "QLHSUT"."QLHSUT_HOP_DONG_DANG_TUYEN" (MAHOPDONG, MADT, NGAYKI, DIEUKHOAN_HD, NGAYHETHAN, TT_UUDAI) VALUES ('50001', '30003', TO_DATE('2023-06-17', 'YYYY-MM-DD'), N'Có thể gia hạn nếu chưa tìm được người thích hợp', TO_DATE('2023-10-17', 'YYYY-MM-DD'), '40002');
INSERT INTO "QLHSUT"."QLHSUT_HOP_DONG_DANG_TUYEN" (MAHOPDONG, MADT, NGAYKI, DIEUKHOAN_HD, NGAYHETHAN, TT_UUDAI) VALUES ('50002', '30004', TO_DATE('2024-04-02', 'YYYY-MM-DD'), N'Có thể tùy ý hủy hợp đồng', TO_DATE('2024-12-02', 'YYYY-MM-DD'), '40005');
INSERT INTO "QLHSUT"."QLHSUT_HOP_DONG_DANG_TUYEN" (MAHOPDONG, MADT, NGAYKI, DIEUKHOAN_HD, NGAYHETHAN, TT_UUDAI) VALUES ('50003', '30001', TO_DATE('2023-12-22', 'YYYY-MM-DD '), N'Có thể hoãn hợp đồng', TO_DATE('2024-02-22', 'YYYY-MM-DD'), '40004');
INSERT INTO "QLHSUT"."QLHSUT_HOP_DONG_DANG_TUYEN" (MAHOPDONG, MADT, NGAYKI, DIEUKHOAN_HD, NGAYHETHAN, TT_UUDAI) VALUES ('50004', '30005', TO_DATE('2024-02-28', 'YYYY-MM-DD'), N'Hủy hợp đồng nếu công ty không làm theo đúng yêu cầu', TO_DATE('2025-02-28', 'YYYY-MM-DD'), '40001');
INSERT INTO "QLHSUT"."QLHSUT_HOP_DONG_DANG_TUYEN" (MAHOPDONG, MADT, NGAYKI, DIEUKHOAN_HD, NGAYHETHAN, TT_UUDAI) VALUES ('50005', '30002', TO_DATE('2024-01-12', 'YYYY-MM-DD'), N'Hợp đồng có hiệu lực 5 năm', TO_DATE('2029-01-12', 'YYYY-MM-DD'), '40003');

INSERT INTO "QLHSUT"."QLHSUT_HINH_THUC_DANG_TUYEN" (MAHT, TENHINHTHUC, NOIDUNG, CONGTHUC_THANHTIEN) VALUES ('60001', N'Đăng tuyển trên Web', N'Thực hiện đăng tuyển trên các trang web giới thiệu việc làm', '5000000');
INSERT INTO "QLHSUT"."QLHSUT_HINH_THUC_DANG_TUYEN" (MAHT, TENHINHTHUC, NOIDUNG, CONGTHUC_THANHTIEN) VALUES ('60002', N'Đăng tuyển trên tivi', N'Thực hiện đăng tuyển trên các bảng tin quảng cáo giới thiệu việc làm', '6000000');
INSERT INTO "QLHSUT"."QLHSUT_HINH_THUC_DANG_TUYEN" (MAHT, TENHINHTHUC, NOIDUNG, CONGTHUC_THANHTIEN) VALUES ('60003', N'Đăng tuyển trên tường', N'Thực hiện đăng tuyển dán lên các tường khu vực dân phố', '3000000');
INSERT INTO "QLHSUT"."QLHSUT_HINH_THUC_DANG_TUYEN" (MAHT, TENHINHTHUC, NOIDUNG, CONGTHUC_THANHTIEN) VALUES ('60004', N'Đăng tuyển trên băng rôn', N'Thực hiện treo băng rôn tại những nơi gần doanh nghiệp', '2000000');
INSERT INTO "QLHSUT"."QLHSUT_HINH_THUC_DANG_TUYEN" (MAHT, TENHINHTHUC, NOIDUNG, CONGTHUC_THANHTIEN) VALUES ('60005', N'Đăng tuyển tại trường', N'Thực hiện đăng tuyển trực tiếp tại các hội thảo trường đại học', '8000000');

INSERT INTO "QLHSUT"."QLHSUT_HINH_THUC_LUA_CHON" (MAHOPDONG, MAHT) VALUES ('50001', '60002');
INSERT INTO "QLHSUT"."QLHSUT_HINH_THUC_LUA_CHON" (MAHOPDONG, MAHT) VALUES ('50002', '60005');
INSERT INTO "QLHSUT"."QLHSUT_HINH_THUC_LUA_CHON" (MAHOPDONG, MAHT) VALUES ('50003', '60003');
INSERT INTO "QLHSUT"."QLHSUT_HINH_THUC_LUA_CHON" (MAHOPDONG, MAHT) VALUES ('50004', '60001');
INSERT INTO "QLHSUT"."QLHSUT_HINH_THUC_LUA_CHON" (MAHOPDONG, MAHT) VALUES ('50005', '60004');

INSERT INTO "QLHSUT"."QLHSUT_PHIEU_QUANG_CAO" (MAPQC, MAHOPDONG, TG_BATDAU, TG_KETTHUC, TONGTIEN, TRANGTHAI_THANHTOAN) VALUES ('70001', '50001', TO_DATE('2023-06-22', 'YYYY-MM-DD'), TO_DATE('2023-09-17', 'YYYY-MM-DD'), '10000000', '0');
INSERT INTO "QLHSUT"."QLHSUT_PHIEU_QUANG_CAO" (MAPQC, MAHOPDONG, TG_BATDAU, TG_KETTHUC, TONGTIEN, TRANGTHAI_THANHTOAN) VALUES ('70002', '50002', TO_DATE('2024-04-10', 'YYYY-MM-DD'), TO_DATE('2024-11-02', 'YYYY-MM-DD'), '12000000', '1');
INSERT INTO "QLHSUT"."QLHSUT_PHIEU_QUANG_CAO" (MAPQC, MAHOPDONG, TG_BATDAU, TG_KETTHUC, TONGTIEN, TRANGTHAI_THANHTOAN) VALUES ('70003', '50003', TO_DATE('2023-12-29', 'YYYY-MM-DD'), TO_DATE('2024-02-02', 'YYYY-MM-DD'), '15000000', '-1');
INSERT INTO "QLHSUT"."QLHSUT_PHIEU_QUANG_CAO" (MAPQC, MAHOPDONG, TG_BATDAU, TG_KETTHUC, TONGTIEN, TRANGTHAI_THANHTOAN) VALUES ('70004', '50004', TO_DATE('2024-03-03', 'YYYY-MM-DD'), TO_DATE('2025-01-01', 'YYYY-MM-DD'), '9000000', '1');
INSERT INTO "QLHSUT"."QLHSUT_PHIEU_QUANG_CAO" (MAPQC, MAHOPDONG, TG_BATDAU, TG_KETTHUC, TONGTIEN, TRANGTHAI_THANHTOAN) VALUES ('70005', '50005', TO_DATE('2024-01-20', 'YYYY-MM-DD'), TO_DATE('2029-01-01', 'YYYY-MM-DD'), '20000000', '0');

INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_THANH_TOAN" (MATT, MAPQC, DOTTHANHTOAN, TONGTIEN_THANHTOAN, TRANGTHAI_THANHTOAN) VALUES ('80001', '70001', '2', '5000000', '0');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_THANH_TOAN" (MATT, MAPQC, DOTTHANHTOAN, TONGTIEN_THANHTOAN, TRANGTHAI_THANHTOAN) VALUES ('80002', '70002', '1', '12000000', '1');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_THANH_TOAN" (MATT, MAPQC, DOTTHANHTOAN, TONGTIEN_THANHTOAN, TRANGTHAI_THANHTOAN) VALUES ('80003', '70003', '0', '0', '-1');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_THANH_TOAN" (MATT, MAPQC, DOTTHANHTOAN, TONGTIEN_THANHTOAN, TRANGTHAI_THANHTOAN) VALUES ('80004', '70004', '3', '9000000', '1');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_THANH_TOAN" (MATT, MAPQC, DOTTHANHTOAN, TONGTIEN_THANHTOAN, TRANGTHAI_THANHTOAN) VALUES ('80005', '70005', '2', '1000000', '0');

INSERT INTO "QLHSUT"."QLHSUT_NHAN_VIEN" (MANV, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL) VALUES ('90001', N'Huỳnh Thị Mai', TO_DATE('2003-06-12', 'YYYY-MM-DD'), N'Nữ', '0934242644', N'50 Hoàng Băng', 'HuynhThiMai@gmail.com');
INSERT INTO "QLHSUT"."QLHSUT_NHAN_VIEN" (MANV, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL) VALUES ('90002', N'Trần Công Anh', TO_DATE('2004-01-31', 'YYYY-MM-DD'), N'Nam', '0981203112', N'01 Công Lý', 'TranCongAnh@gmail.com');
INSERT INTO "QLHSUT"."QLHSUT_NHAN_VIEN" (MANV, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL) VALUES ('90003', N'Mai Công Hiếu', TO_DATE('2005-04-16', 'YYYY-MM-DD'), N'Khác', '0122381922', N'10 Trần Mỹ', 'MaiCongHieu@gmail.com');
INSERT INTO "QLHSUT"."QLHSUT_NHAN_VIEN" (MANV, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL) VALUES ('90004', N'Nguyễn Văn Toàn', TO_DATE('2002-10-22', 'YYYY-MM-DD'), N'Nam', '0827461823', N'77 Mai Anh', 'NguyenVanToan@gmail.com');
INSERT INTO "QLHSUT"."QLHSUT_NHAN_VIEN" (MANV, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL) VALUES ('90005', N'Lê Thị Như', TO_DATE('2003-09-10', 'YYYY-MM-DD'), N'Nữ', '0988918222', N'90 Diệu Mai', 'LeThiNhu@gmail.com');

INSERT INTO "QLHSUT"."QLHSUT_HOA_DON" (MAHOADON, MATT, LOAITHANHTOAN, HINHTHUC_THANHTOAN, THANHTIEN, NVLAP) VALUES ('100001', '80001', N'Thanh toán theo đợt', N'Thẻ', '5000000', '90002');
INSERT INTO "QLHSUT"."QLHSUT_HOA_DON" (MAHOADON, MATT, LOAITHANHTOAN, HINHTHUC_THANHTOAN, THANHTIEN, NVLAP) VALUES ('100002', '80002', N'Thanh toán một lần', N'Tiền mặt', '5000000', '90001');
INSERT INTO "QLHSUT"."QLHSUT_HOA_DON" (MAHOADON, MATT, LOAITHANHTOAN, HINHTHUC_THANHTOAN, THANHTIEN) VALUES ('100003', '80003', N'Thanh toán một lần', N'Thẻ', '0');
INSERT INTO "QLHSUT"."QLHSUT_HOA_DON" (MAHOADON, MATT, LOAITHANHTOAN, HINHTHUC_THANHTOAN, THANHTIEN, NVLAP) VALUES ('100004', '80004', N'Thanh toán theo đợt', N'Tiền mặt', '300000', '90004');
INSERT INTO "QLHSUT"."QLHSUT_HOA_DON" (MAHOADON, MATT, LOAITHANHTOAN, HINHTHUC_THANHTOAN, THANHTIEN, NVLAP) VALUES ('100005', '80005', N'Thanh toán theo đợt', N'Thẻ', '1000000', '90005');

INSERT INTO "QLHSUT"."QLHSUT_UNG_VIEN" (MAUV, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO) VALUES ('110001', N'Nguyễn Cẩm Đào', TO_DATE('2004-01-17', 'YYYY-MM-DD'), N'Nữ', '0955817332', N'112 Hoa Đào', 'NguyenCamDao@gmail.com', N'Cao đẳng');
INSERT INTO "QLHSUT"."QLHSUT_UNG_VIEN" (MAUV, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO) VALUES ('110002', N'Trần Mai Hạnh', TO_DATE('2005-06-02', 'YYYY-MM-DD'), N'Nữ', '0987211423', N'16 Hoa Cúc', 'TranMaiHanh@gmail.com', N'Đại học');
INSERT INTO "QLHSUT"."QLHSUT_UNG_VIEN" (MAUV, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO) VALUES ('110003', N'Văn Tiến Dũng', TO_DATE('2003-08-16', 'YYYY-MM-DD'), N'Khác', '0871292312', N'30 Hoa Huệ', 'VanTienDung@gmail.com', N'Đại học');
INSERT INTO "QLHSUT"."QLHSUT_UNG_VIEN" (MAUV, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO) VALUES ('110004', N'Trần Công Phúc', TO_DATE('2006-04-30', 'YYYY-MM-DD'), N'Nam', '0991839791', N'40 Hoa Lan', 'TranCongPhuc@gmail.com', N'Đại học');
INSERT INTO "QLHSUT"."QLHSUT_UNG_VIEN" (MAUV, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO) VALUES ('110005', N'Huỳnh Minh Trí', TO_DATE('2003-05-01', 'YYYY-MM-DD'), N'Nam', '0234952022', N'01 Hoa Mai', 'HuynhMinhTri@gmail.com', N'Cao đẳng');

INSERT INTO "QLHSUT"."QLHSUT_HO_SO_UNG_TUYEN" (MAHS, MAUV, MAPQC, THONGTIN_HS, TRANGTHAIDUYET, NVDUYET) VALUES ('120001', '110001', '70003', N'Vừa tốt nghiệp', '0', '90004');
INSERT INTO "QLHSUT"."QLHSUT_HO_SO_UNG_TUYEN" (MAHS, MAUV, MAPQC, THONGTIN_HS, TRANGTHAIDUYET, NVDUYET) VALUES ('120002', '110002', '70005', N'Có 3 năm kinh nghiệm', '1', '90001');
INSERT INTO "QLHSUT"."QLHSUT_HO_SO_UNG_TUYEN" (MAHS, MAUV, MAPQC, THONGTIN_HS, TRANGTHAIDUYET, NVDUYET) VALUES ('120003', '110003', '70001', N'-1', '0', '90003');
INSERT INTO "QLHSUT"."QLHSUT_HO_SO_UNG_TUYEN" (MAHS, MAUV, MAPQC, THONGTIN_HS, TRANGTHAIDUYET, NVDUYET) VALUES ('120004', '110004', '70004', N'Có kinh nghiệm ở lĩnh vực khác', ' 1', '90004');
INSERT INTO "QLHSUT"."QLHSUT_HO_SO_UNG_TUYEN" (MAHS, MAUV, MAPQC, THONGTIN_HS, TRANGTHAIDUYET, NVDUYET) VALUES ('120005', '110005', '70002', N'Có 10 năm kinh nghiệm', '0', '90002');

INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_CHUNG_TU" (MAHS, MACHUNGTU, ND_CHUNGTU) VALUES ('120001', '130001', N'Chứng từ dành cho nội dung thanh toán');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_CHUNG_TU" (MAHS, MACHUNGTU, ND_CHUNGTU) VALUES ('120002', '130002', N'Chứng từ dành cho nội dung xác thực');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_CHUNG_TU" (MAHS, MACHUNGTU, ND_CHUNGTU) VALUES ('120003', '130003', N'Chứng từ dành cho nội dung thông tin');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_CHUNG_TU" (MAHS, MACHUNGTU, ND_CHUNGTU) VALUES ('120004', '130004', N'Chứng từ dành cho nội dung tuyển dụng');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_CHUNG_TU" (MAHS, MACHUNGTU, ND_CHUNGTU) VALUES ('120005', '130005', N'Chứng từ dành cho nội dung thông báo');

INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_BANG_CAP" (MAHS, MABANGCAP, TENBANGCAP, NGAYHETHAN, ND_BANGCAP) VALUES ('120001', '140001', N'IELTS', TO_DATE('2026-01-01', 'YYYY-MM-DD'), N'Bằng chứng chỉ ngoại ngữ IELTS');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_BANG_CAP" (MAHS, MABANGCAP, TENBANGCAP, NGAYHETHAN, ND_BANGCAP) VALUES ('120002', '140002', N'TOEIC', TO_DATE('2027-01-01', 'YYYY-MM-DD'), N'Bằng chứng chỉ ngoại ngữ TOEIC');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_BANG_CAP" (MAHS, MABANGCAP, TENBANGCAP, NGAYHETHAN, ND_BANGCAP) VALUES ('120003', '140003', N'HSK', TO_DATE('2025-01-01', 'YYYY-MM-DD'), N'Bằng chứng chỉ ngoại ngữ HSK');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_BANG_CAP" (MAHS, MABANGCAP, TENBANGCAP, NGAYHETHAN, ND_BANGCAP) VALUES ('120004', '140004', N'VSTEP', TO_DATE('2028-01-01', 'YYYY-MM-DD'), N'Bằng chứng chỉ ngoại ngữ VSTEP');
INSERT INTO "QLHSUT"."QLHSUT_THONG_TIN_BANG_CAP" (MAHS, MABANGCAP, TENBANGCAP, NGAYHETHAN, ND_BANGCAP) VALUES ('120005', '140005', N'TOEFL', TO_DATE('2029-01-01', 'YYYY-MM-DD'), N'Bằng chứng chỉ ngoại ngữ TOEFL');


-- CREATE FOREIGN KEYS
ALTER TABLE QLHSUT.QLHSUT_DOANH_NGHIEP
ADD CONSTRAINT FK_DN_NDD FOREIGN KEY(NDD) REFERENCES QLHSUT.QLHSUT_NGUOI_DAI_DIEN(MANDD);

ALTER TABLE QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN
ADD CONSTRAINT FK_TTTT_DN FOREIGN KEY(DN_DANGTUYEN) REFERENCES QLHSUT.QLHSUT_DOANH_NGHIEP(MADN);

ALTER TABLE QLHSUT.QLHSUT_HOP_DONG_DANG_TUYEN
ADD CONSTRAINT FK_HDDT_TTDN FOREIGN KEY(MADT) REFERENCES QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN(MADT);
ALTER TABLE QLHSUT.QLHSUT_HOP_DONG_DANG_TUYEN
ADD CONSTRAINT FK_HDDT_TTUD FOREIGN KEY(TT_UUDAI) REFERENCES QLHSUT.QLHSUT_THONG_TIN_UU_DAI(MAUUDAI);


ALTER TABLE QLHSUT.QLHSUT_HINH_THUC_LUA_CHON
ADD CONSTRAINT FK_HTLC_HDDT FOREIGN KEY(MAHOPDONG) REFERENCES QLHSUT.QLHSUT_HOP_DONG_DANG_TUYEN(MAHOPDONG);
ALTER TABLE QLHSUT.QLHSUT_HINH_THUC_LUA_CHON
ADD CONSTRAINT FK_HTLC_HTDT FOREIGN KEY(MAHT) REFERENCES QLHSUT.QLHSUT_HINH_THUC_DANG_TUYEN(MAHT);

ALTER TABLE QLHSUT.QLHSUT_PHIEU_QUANG_CAO
ADD CONSTRAINT FK_PQC_HDDT FOREIGN KEY(MAHOPDONG) REFERENCES QLHSUT.QLHSUT_HOP_DONG_DANG_TUYEN(MAHOPDONG);

ALTER TABLE QLHSUT.QLHSUT_THONG_TIN_THANH_TOAN
ADD CONSTRAINT FK_TTTT_PQC FOREIGN KEY(MAPQC) REFERENCES QLHSUT.QLHSUT_PHIEU_QUANG_CAO(MAPQC);

ALTER TABLE QLHSUT.QLHSUT_HOA_DON
ADD CONSTRAINT FK_HD_TTTT FOREIGN KEY(MATT) REFERENCES QLHSUT.QLHSUT_THONG_TIN_THANH_TOAN(MATT);
ALTER TABLE QLHSUT.QLHSUT_HOA_DON
ADD CONSTRAINT FK_HD_NV FOREIGN KEY (NVLAP) REFERENCES QLHSUT.QLHSUT_NHAN_VIEN(MANV);

ALTER TABLE QLHSUT.QLHSUT_HO_SO_UNG_TUYEN
ADD CONSTRAINT FK_HSUT_PQC FOREIGN KEY(MAPQC) REFERENCES QLHSUT.QLHSUT_PHIEU_QUANG_CAO(MAPQC);
ALTER TABLE QLHSUT.QLHSUT_HO_SO_UNG_TUYEN
ADD CONSTRAINT FK_HSUT_UV FOREIGN KEY(MAUV) REFERENCES QLHSUT.QLHSUT_UNG_VIEN(MAUV);
ALTER TABLE QLHSUT.QLHSUT_HO_SO_UNG_TUYEN
ADD CONSTRAINT FK_HSUT_NV FOREIGN KEY(NVDUYET) REFERENCES QLHSUT.QLHSUT_NHAN_VIEN(MANV);

ALTER TABLE QLHSUT.QLHSUT_THONG_TIN_CHUNG_TU
ADD CONSTRAINT FK_TTCT_HSUT FOREIGN KEY(MAHS) REFERENCES QLHSUT.QLHSUT_HO_SO_UNG_TUYEN(MAHS);

ALTER TABLE QLHSUT.QLHSUT_THONG_TIN_BANG_CAP
ADD CONSTRAINT FK_TTBC_HSUT FOREIGN KEY(MAHS) REFERENCES QLHSUT.QLHSUT_HO_SO_UNG_TUYEN(MAHS);


