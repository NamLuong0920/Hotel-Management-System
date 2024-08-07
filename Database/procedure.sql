use QUANLIKHACHSAN
GO

create proc DICHVUHOTRO @MADP INT
AS
BEGIN
	SELECT DISTINCT NP.MAPHONG,TC.TENDV,TC.GIA
	FROM DV_TAICHO TC, PHIEUDATPHONG DP, PHIEUNHANPHONG NP, DVTC_LP_HOTRO HT, LOAIPHONG LP, PHONG P
	WHERE DP.MADP=@MADP AND NP.MADATPHONG=DP.MADP AND NP.MAPHONG=P.MAPHONG 
		AND P.MALP=HT.MALP AND HT.MADVTC = TC.MADVTC
END
GO
drop proc THEMKHACHNHANPHONG
create proc THEMKHACHNHANPHONG
	@madoan int,
	@CCCD_PASSPORT VARCHAR(12),
   @TENKH NVARCHAR(50),
   @SDT VARCHAR(10),
   @EMAIL VARCHAR(50),
   @DIACHI NVARCHAR(200),
   @QUOCTICH NVARCHAR(50),
   @MAKH int out
AS
BEGIN
	INSERT INTO KHACHHANG(madoan,CCCD_PASSPORT, TENKH, SDT, EMAIL, DIACHI, QUOCTICH) 
	VALUES (@madoan,@CCCD_PASSPORT,@TENKH,@SDT,@EMAIL,@DIACHI,@QUOCTICH)
	set @MAKH=(select top(1) makh 
				from KHACHHANG 
				where CCCD_PASSPORT=@CCCD_PASSPORT order by makh desc)
END
GO