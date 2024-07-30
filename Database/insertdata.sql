--insert data
USE QUANLIKHACHSAN
GO
SET DATEFORMAT ymd

insert into NHANVIEN
values(N'Trần Đào Mộng Nhi','0789543700','PhuongTrang8301wh@gmail.com',N'929 Cao Thắng, phường 4, quận 4, thành phố Hồ Chí Minh'),
(N'Bác  Thanh Phương','0321902983','QuocKhonh3956va@gmail.com',N'209 Mạc Đĩnh Chi, phường 2, quận 5, thành phố Hồ Chí Minh'),
(N'Đinh Minh Hải','0327757786','LeNhi7019jy@gmail.com',N'327 Vỗ Văn Tần, phường Bình Khánh, quận 2, thành phố Hồ Chí Minh'),
(N'Hạ Nguyễn Nhã Trang','0456641127','HoangKhang1946fp@gmail.com',N'646 Phạm Ngũ Lão, phường 27, quận Bình Thạnh, thành phố Hồ Chí Minh'),
(N'Lê Lê Hiền Nhi','0456642127','CungHao3971bt@gmail.com', N'146 Trương Định, phường An Lợi Đông, quận 2, thành phố Hồ Chí Minh'),
(N'Tôn  Hoa Tiên','0456642128','HongLinh3191yb@gmail.com', N'167 Phan Văn Đạt, phường 14, quận 8, thành phố Hồ Chí Minh')

insert into KHACHHANG(MADOAN,CCCD_PASSPORT,TENKH,SDT,EMAIL,DIACHI,QUOCTICH)
values(1,'111111111111',N'Lê Đào Thảo Tiên','0123456789','ledaothaotien92@gmail.com',N'343 Nguyễn Đình Chính, phường An Lạc, quận Bình Tân, thành phố Hồ Chí Minh',N'Việt Nam'),
(2,'222222222222',N'Châu Nhật Tuyết','0912345678','tuyet123@gmail.com', N'930 Nguyễn Văn Trỗi, phường Phú Hữu, quận 9, thành phố Hồ Chí Minh',N'Việt Nam'),
(3,'333333333333',N'Ngô Lê Hưng Thịnh','0712345678','thinh123@gmail.com', N'494 Sương Nguyệt Ánh, phường 4, quận 4, thành phố Hồ Chí Minh',N'Việt Nam'),
(4,'444444444444',N'Lương Văn Nam','0512345678','namluong12@gmail.com', N'166 Trần Quý Khoách, phường Nguyễn Thái Bình, quận 1, thành phố Hồ Chí Minh',N'Việt Nam'),
(5,'555555555555',N'Cao Chánh Khải','0312345678','khaica22@gmail.com', N'396 Nguyễn Thái Bình, phường 1, quận 4, thành phố Hồ Chí Minh',N'Việt Nam')

insert into DAILYTRUNGGIAN
values(N'BOOK','19006111','BOOK@gmail.com',N'536 Trần Nhật Duật, phường 15, quận Tân Bình, thành phố Hồ Chí Minh'),
(N'TRAVELOKA','19001544','traveloka@gmail.com',N'166 Trần Quý Khoách, phường Nguyễn Thái Bình, quận 1, thành phố Hồ Chí Minh'),
(N'THINHNGOTOURIST','19001582','TNTourist@gmail.com',N'166 Hoàng Diệu 2, thành phố Thủ Đức, thành phố Hồ Chí Minh');


select * from DAILYTRUNGGIAN
--insert into LOAIPHONG




SELECT * FROM LOAIPHONG

INSERT INTO LOAIPHONG VALUES (N'Single', N'Thuong',700000,N'Phòng 1 giường cho 1-2 người');
INSERT INTO LOAIPHONG VALUES (N'Single', N'VIP',1500000,N'Phòng vip 1 giường cho 1-2 người');
INSERT INTO LOAIPHONG VALUES (N'Twin', N'Thuong',1500000,N'Phòng 2 giường cho 2-4 người');
INSERT INTO LOAIPHONG VALUES (N'Twin', N'VIP',3500000,N'Phòng vip 2 giường cho 2-4 người');
INSERT INTO LOAIPHONG VALUES (N'Double', N'Thuong',1800000,N'Phòng 1 giường đôi cho 1-2 người');
INSERT INTO LOAIPHONG VALUES (N'Double', N'VIP',4500000,N'Phòng 1 giường đôi cho 1-2 người');
select * from LOAIPHONG
--insert into PHONG
INSERT INTO PHONG VALUES(1,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(1,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(1,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(1,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(1,N'ĐÃ CHO THUÊ',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(1,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(1,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(1,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(1,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(1,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(1,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(1,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(1,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(1,N'ĐÃ CHO THUÊ',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(1,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(1,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(1,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(1,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')


INSERT INTO PHONG VALUES(2,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(2,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(2,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(2,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(2,N'ĐÃ CHO THUÊ',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(2,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(2,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(2,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(2,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(2,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(2,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(2,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(2,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(2,N'ĐÃ CHO THUÊ',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(2,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(2,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(2,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(2,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')


INSERT INTO PHONG VALUES(3,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(3,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(3,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(3,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(3,N'ĐÃ CHO THUÊ',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(3,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(3,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(3,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(3,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(3,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(3,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(3,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(3,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(3,N'ĐÃ CHO THUÊ',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(3,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(3,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(3,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(3,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')




INSERT INTO PHONG VALUES(4,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(4,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(4,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(4,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(4,N'ĐÃ CHO THUÊ',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(4,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(4,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(4,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(4,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(4,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(4,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(4,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(4,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(4,N'ĐÃ CHO THUÊ',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(4,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(4,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(4,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(4,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')


INSERT INTO PHONG VALUES(5,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(5,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(5,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(5,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(5,N'ĐÃ CHO THUÊ',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(5,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(5,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(5,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(5,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(5,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(5,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(5,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(5,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(5,N'ĐÃ CHO THUÊ',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(5,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(5,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(5,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(5,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')





INSERT INTO PHONG VALUES(6,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(6,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(6,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(6,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(6,N'ĐÃ CHO THUÊ',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(6,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(6,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(6,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(6,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(6,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(6,N'CÒN TRỐNG',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(6,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(6,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(6,N'ĐÃ CHO THUÊ',N'ĐÃ VỆ SINH')
INSERT INTO PHONG VALUES(6,N'CÒN TRỐNG',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(6,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(6,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')
INSERT INTO PHONG VALUES(6,N'ĐÃ CHO THUÊ',N'CHƯA VỆ SINH')


SELECT * FROM PHONG
--insert into COSOVATCHAT
--insert into PHONG_CSVC
--insert into PHIEUDATPHONG

insert into PHIEUNHANPHONG
values(1,1,'2023-12-19',1,1)

--insert into DV_TAICHO
--insert into DVTC_LP_HOTRO
--insert into PHIEUDANGKI_DVTC
--insert into CHINHSACH
--insert into APDUNGCHINHSACH

insert into DOITACDICHVU
values(N'Vui chơi','0264661231','Vuichoi@gmail.com',N'841 Đào Duy Từ, phường Trung Nhì, quận Phú Nhuận, thành phố Hồ Chí Minh'),
(N'Giải trí','045911664','giaitri@gmail.com', N'535 Hàm Nghi, phường 15, quận 4, thành phố Hồ Chí Minh')
select* from DOITACDICHVU
--insert into DICHVUHOPTAC
--insert into PHIEUDANGKI_DVHT
--insert into HONGHOC
--insert into GIAHAN
--insert into PHIEUPHANHOI
--insert into PHIEUTRAPHONG
--insert into HOADON
--insert into CHITIETHOADON

insert into KS_DOITAC
values(N'ABC',N'5 sao',N'1 Lê Quốc Trinh,  xã Tân Thạnh Đông, huyện Củ Chi, thành phố Hồ Chí Minh','Tan6586@gmail.com','0102656444'),
(N'Bãi biển',N'4 sao',N'1 Hoàng Xuân Nhị,  xã Qui Đức, huyện Bình Chánh, thành phố Hồ Chí Minh','biendep@gmail.com','0546463892')

insert into TAIKHOAN
values(N'fasdfho','faesfe365',1,N'LỄ TÂN'),
(N'njoifreg','akfei45',2,N'LỄ TÂN'),
(N'grevg','fsrfsd15',3,N'BELLMAN'),
(N'htrsb','feds256',4,N'BELLMAN'),
(N'breb','lnoih44',5,N'BUỒNG PHÒNG'),
(N'sgteb','67fewd',6,N'BUỒNG PHÒNG')


INSERT INTO DV_TAICHO
VALUES (N'Karaoke', N'Giờ', 50000);
INSERT INTO DV_TAICHO
VALUES (N'Massage', N'Giờ', 10000);
INSERT INTO DV_TAICHO
VALUES (N'Dưỡng sinh', N'Giờ', 20000);
INSERT INTO DV_TAICHO
VALUES (N'Gym', N'Giờ', 50000);
INSERT INTO DV_TAICHO
VALUES (N'Bi-a', N'Giờ', 50000);
INSERT INTO DV_TAICHO
VALUES (N'Spa', N'Giờ', 100000);




INSERT INTO DVTC_LP_HOTRO VALUES (1, 1);
INSERT INTO DVTC_LP_HOTRO VALUES (1, 2);
INSERT INTO DVTC_LP_HOTRO VALUES (1, 3);
INSERT INTO DVTC_LP_HOTRO VALUES (1, 5);
INSERT INTO DVTC_LP_HOTRO VALUES (2, 1);
INSERT INTO DVTC_LP_HOTRO VALUES (2, 2);
INSERT INTO DVTC_LP_HOTRO VALUES (2, 3);
INSERT INTO DVTC_LP_HOTRO VALUES (2, 5);
INSERT INTO DVTC_LP_HOTRO VALUES (2, 6);
INSERT INTO DVTC_LP_HOTRO VALUES (3, 1);
INSERT INTO DVTC_LP_HOTRO VALUES (3, 2);
INSERT INTO DVTC_LP_HOTRO VALUES (3, 3);
INSERT INTO DVTC_LP_HOTRO VALUES (3, 4);
INSERT INTO DVTC_LP_HOTRO VALUES (3, 6);
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    


INSERT INTO DICHVUHOPTAC
VALUES (1, N'Tham quan khu du lịch sinh thái', 2000000);
INSERT INTO DICHVUHOPTAC
VALUES (2, N'Tham quan sở thú', 1000000);
INSERT INTO DICHVUHOPTAC
VALUES (1, N'Tham quan khu du lịch sinh quyển', 2500000);


INSERT INTO DOITACDICHVU
VALUES(N'Công ty lữ hành', '0973665256', 'ctlh@gmail.com', 'Q5, TP.HCM');
INSERT INTO DOITACDICHVU
VALUES(N'Công ty dịch vụ du lịch', '0979399002', 'ctdvdl@gmail.com', 'Q7, TP.HCM');



INSERT INTO PHIEUDATPHONG 
VALUES (1, N'Lê Đào Thảo Tiên', '2023-07-02', '2023-07-04', N'Có', NULL, N'Trực tiếp', GETDATE(), 200000, 2000000, 1, 1, N'Không');
INSERT INTO PHIEUDATPHONG 
VALUES (2, N'Châu Nhật Tuyết', '2023-07-02', '2023-07-04', N'Có', NULL, N'Trực tiếp', GETDATE(), 200000, 2000000, 1, 2, N'Không');
INSERT INTO PHIEUDATPHONG 
VALUES (3, N'Ngô Lê Hưng Thịnh', '2023-07-02', '2023-07-04', N'Có', NULL, N'Trực tiếp', GETDATE(), 200000, 2000000, 1, 3, N'Không');


INSERT INTO PHIEUNHANPHONG
VALUES(1, 1, GETDATE(), 1, 1);
INSERT INTO PHIEUNHANPHONG
VALUES(2, 2, GETDATE(), 3, 2);
INSERT INTO PHIEUNHANPHONG
VALUES(3, 3, GETDATE(), 2, 1);


INSERT INTO PHIEUDANGKI_DVHT
VALUES(1, 1, 1, GETDATE(), N'Tự túc', N'Chưa duyệt', GETDATE());
INSERT INTO PHIEUDANGKI_DVHT
VALUES(2, 2, 1, GETDATE(), N'Tự túc', N'Chưa duyệt', GETDATE());


INSERT INTO PHIEUDANGKI_DVTC
VALUES (1, 1, GETDATE(), GETDATE(), NULL);
INSERT INTO PHIEUDANGKI_DVTC
VALUES (2, 2, GETDATE(), GETDATE(), NULL);
INSERT INTO PHIEUDANGKI_DVTC
VALUES (3, 3, GETDATE(), GETDATE(), NULL);

INSERT INTO PHIEUTRAPHONG
VALUES(GETDATE(), 1, NULL);
INSERT INTO PHIEUTRAPHONG
VALUES(GETDATE(), 2, NULL);
INSERT INTO PHIEUTRAPHONG
VALUES(GETDATE(), 3, 1);

INSERT INTO HOADON
VALUES(1, NULL, GETDATE(), N'TIỀN MẶT', 5000000, 15000000, NULL);
INSERT INTO HOADON
VALUES(2, NULL, GETDATE(), N'CHUYỂN KHOẢN', 3600000, 12000000, NULL);
INSERT INTO HOADON
VALUES(3, NULL, GETDATE(), N'CHUYỂN KHOẢN', 6200000, 18000000, NULL);

INSERT INTO CHITIETHOADON
VALUES(1, N'Spa', 2, 500000);
INSERT INTO CHITIETHOADON
VALUES(2, N'Ghế', 1, 180000);
INSERT INTO CHITIETHOADON
VALUES(3, N'Bàn', 1, 230000);

--DATA TEST CHECKIN --MỌI NGƯỜI ĐỪNG INSERT GÌ VÔ MÃ PHIẾU ĐẶT PHÒNG NÀY NHA
INSERT INTO KHACHHANG(MADOAN,CCCD_PASSPORT,TENKH,SDT,EMAIL,DIACHI,QUOCTICH)
VALUES(NULL,'048365164749',N'Đoàn Á Châu','0776623895','chaucute92@gmail.com',N'98/20 Trần Quang Cơ,phường Phú Thạnh, quận Tân Phú, thành phố Hồ Chí Minh',N'Việt Nam')

INSERT INTO PHIEUDATPHONG 
VALUES (1,6,'2023-07-07', '2023-07-11',N'VIP', N'TRUNG GIAN', '2023-07-06', 200000, 2000000, 4, 2, NULL);
UPDATE PHIEUDATPHONG SET YEUCAUDACBIET =N'Phòng VIP, có 2 cửa sổ' WHERE NGUOIDAT=6
select*from PHIEUDATPHONG
INSERT INTO PHIEUNHANPHONG
VALUES(6, 2, '2023-07-07 12:00:00', 55, 1);
INSERT INTO PHIEUNHANPHONG
VALUES(10, 4, '2023-07-07 12:00:00', 56, 1);
INSERT INTO PHIEUNHANPHONG
VALUES(11, 4, '2023-07-07 12:00:00', 57, 1);
SELECT *FROM KHACHHANG
select distinct NP.MAPNP, NP.MAPHONG FROM PHIEUNHANPHONG NP,PHIEUDATPHONG DP WHERE NP.MADATPHONG=DP.MADP AND DP.MADP= 4

SELECT TOP(1) KH.MADOAN 
FROM PHIEUDATPHONG DP, KHACHHANG KH
WHERE MADP=1 AND DP.NGUOIDAT=KH.MAKH ORDER BY KH.MAKH DESC
