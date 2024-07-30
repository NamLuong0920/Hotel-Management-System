using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL_QLKS;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_PHIEUDATPHONG : DBConnect
    {
        public DataTable getDSPhong(string MADP)
        {
            SqlDataAdapter da = new SqlDataAdapter("select distinct NP.MAPNP, NP.MAPHONG FROM PHIEUNHANPHONG NP,PHIEUDATPHONG DP WHERE NP.MADATPHONG=DP.MADP AND DP.MADP= " + MADP, _conn);
            DataTable dtPhieuDatPhong = new DataTable();
            da.Fill(dtPhieuDatPhong);
            return dtPhieuDatPhong;
        }
        public DataTable getDVHoTro(string MADP)
        {
            SqlDataAdapter da = new SqlDataAdapter("EXEC DICHVUHOTRO "+ MADP, _conn);
            DataTable dtPhieuDatPhong = new DataTable();
            da.Fill(dtPhieuDatPhong);
            return dtPhieuDatPhong;
        }
        public DataTable getPHIEUDATPHONG_MADP(string MADP)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT  TOP(1) * FROM PHIEUDATPHONG WHERE MADP='" + MADP + "'", _conn);
            DataTable dtPhieuDatPhong = new DataTable();
            da.Fill(dtPhieuDatPhong);
            return dtPhieuDatPhong;
        }
        public DataTable getMaDoan_MADP(string MADP)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(1) KH.MADOAN " +
                " FROM PHIEUDATPHONG DP, KHACHHANG KH " +
                "WHERE MADP='" + MADP + "'AND DP.NGUOIDAT=KH.MAKH ORDER BY KH.MAKH DESC", _conn);
            DataTable dtPhieuDatPhong = new DataTable();
            da.Fill(dtPhieuDatPhong);
            return dtPhieuDatPhong;
        }
        public DataTable getPHIEUDATPHONG1(string MAKH)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(1)  * FROM PHIEUDATPHONG WHERE NGUOIDAT='" + MAKH +"' ORDER BY MADP DESC", _conn);
            DataTable dtPhieuDatPhong = new DataTable();
            da.Fill(dtPhieuDatPhong);
            return dtPhieuDatPhong;
        }
        public DataTable getPHIEUDATPHONG()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUDATPHONG", _conn);
            DataTable dtPhieuDatPhong = new DataTable();
            da.Fill(dtPhieuDatPhong);
            return dtPhieuDatPhong;
        }
        public int getMaPDP_MoiNhat()
        {
            int kq = 0;
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = "SELECT MADP FROM PHIEUDATPHONG ORDER BY MADP DESC  ";


                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                kq = (int)cmd.ExecuteScalar();

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return kq;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return kq;




        }
        public bool themPHIEUDATPHONG(DTO_PHIEUDATPHONG pdp)
        {
            try
            {
                // Ket noi
                _conn.Open();

                //identity (giá trị tự tăng dần) nên ko cần fải insert ID

                string query_themTV = " INSERT INTO PHIEUDATPHONG(" + pdp.MADAILY + "," + pdp.NGUOIDAT + "," + pdp.NGAYDEN + "," + pdp.NGAYDI + "," + pdp.YEUCAUDACBIET + "," + pdp.HINHTHUCDATPHONG + "," + pdp.NGAYDAT + "," + pdp.TIENCOC + "," + pdp.CHIPHIUOCTINH + "," + pdp.SONGUOI + "," + pdp.SOPHONG + "," + pdp.GIAHAN +")";

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).


                string SQL = string.Format("INSERT INTO PHIEUDATPHONG VALUES ({0}, {1}, '{2}','{3}',N'{4}',N'{5}','{6}',{7},{8},{9},{10},N'KHÔNG')", pdp.MADAILY, pdp.NGUOIDAT, pdp.NGAYDEN, pdp.NGAYDI, pdp.YEUCAUDACBIET, pdp.HINHTHUCDATPHONG, pdp.NGAYDAT,0 , 0, 1, pdp.SOPHONG);
                
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        public bool suaPHIEUDATPHONG_YCDB(string MADP,string YCDB)

        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE PHIEUDATPHONG SET YEUCAUDACBIET = N'{0}' WHERE MADP = {1}", YCDB, MADP);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        public bool suaPHIEUDATPHONG(DTO_PHIEUDATPHONG PDP)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE PHIEUDATPHONG SET  MADAILY = '{0}', NGUOIDAT = '{1}', NGAYDEN = '{2}' NGAYDI = '{3}', YEUCAUDACBIET = '{4}', HINHTHUCDATPHONG = '{5}', NGAYDAT = '{6}', TIENCOC = '{7}' CHIPHIUOCTINH = '{8}', SONGUOI = '{9}', SOPHONG = '{10}', GIAHAN = '{11}' WHERE MADP = {12}", PDP.MADAILY, PDP.NGUOIDAT, PDP.NGAYDEN, PDP.NGAYDI, PDP.YEUCAUDACBIET, PDP.HINHTHUCDATPHONG, PDP.NGAYDAT, PDP.TIENCOC,
                PDP.CHIPHIUOCTINH, PDP.SONGUOI, PDP.SOPHONG, PDP.GIAHAN, PDP.MADP);

                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }


      /*  public bool xoaPHONG(int MAPHONG)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM PHIEUDATPHONG WHERE MADP = {0})", MADP);

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

           return false;
        }*/
        public DataTable getPHIEUDATPHONG_HienTai()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUDATPHONG WHERE NGAYDEN <= GETDATE() AND NGAYDI >= GETDATE()", _conn);
            DataTable dtPhieuDatPhong = new DataTable();
            da.Fill(dtPhieuDatPhong);
            return dtPhieuDatPhong;
        }
        public DataTable getPHIEUDATPHONG_canGiaHan(string maDP)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUDATPHONG WHERE MADP = "+maDP, _conn);
            DataTable dtPhieuDatPhong = new DataTable();
            da.Fill(dtPhieuDatPhong);
            return dtPhieuDatPhong;
        }
        public int layNGUOIDAT(int mp)
        {
            int nguoiDat = 0;

            try
            {
                // Mở kết nối
                _conn.Open();

                // Tạo câu truy vấn
                string SQL = "SELECT PD.NGUOIDAT FROM PHIEUNHANPHONG PN JOIN PHIEUDATPHONG PD ON PN.MADATPHONG = PD.MADP WHERE PN.MAPHONG = @MaPhong";

                // Tạo đối tượng Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Thêm tham số cho câu truy vấn
                cmd.Parameters.AddWithValue("@MaPhong", mp);

                // Thực thi câu truy vấn và lấy dữ liệu
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    nguoiDat = reader.GetInt32(0);
                }

                // Đóng kết nối
                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }

            return nguoiDat;
        }
        public bool CapNhatPDP_GiaHan(string madp, string songaygiahan)
    {
        try
        {
            // Ket noi
            _conn.Open();

            // Query string
            string SQL = string.Format("UPDATE PHIEUDATPHONG SET NGAYDI = DATEADD(day, "+songaygiahan+ ", NGAYDI),GIAHAN = N'CÓ' WHERE MADP = " + madp);


            SqlCommand cmd = new SqlCommand(SQL, _conn);

            // Query và kiểm tra
            if (cmd.ExecuteNonQuery() > 0)
                return true;

        }
        catch (Exception e)
        {

        }
        finally
        {
            // Dong ket noi
            _conn.Close();
        }

        return false;
    }
}
}


