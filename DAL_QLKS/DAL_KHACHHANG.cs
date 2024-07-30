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
    public class DAL_KHACHHANG : DBConnect
    {
        public static string makh;
        public static string madoan;
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getKHACHHANG()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHACHHANG", _conn);
            DataTable dtKHACHHANG= new DataTable();
            da.Fill(dtKHACHHANG);
            return dtKHACHHANG;
        }
        public DataTable dsKhachNhanPhong(string madp)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT kh.* " +
                "FROM KHACHHANG kh, PHIEUDATPHONG DP, PHIEUNHANPHONG PNP" +
                "where PNP.KHACHNHANPHONG=KH.MAKH AND PNP.MADATPHONG=DP.MADP" +
                "AND DP.MADP= "+ madp, _conn);
            DataTable dtKHACHHANG = new DataTable();
            da.Fill(dtKHACHHANG);
            return dtKHACHHANG;
        }
        public DataTable getKHACHHANG1()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT *TOP(1) FROM KHACHHANG ORDER BY MAKH DESC", _conn);
            DataTable dtKHACHHANG = new DataTable();
            da.Fill(dtKHACHHANG);
            return dtKHACHHANG;
        }
        public DataTable getKH_theoMAKH(string MAKH)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(1) * FROM KHACHHANG WHERE MAKH ='" + MAKH + "'", _conn);
            DataTable dtKHACHHANG = new DataTable();

            da.Fill(dtKHACHHANG);
            return dtKHACHHANG;
        }
        public DataTable docThongTin(string CCCD)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(1) * FROM KHACHHANG WHERE CCCD_PASSPORT ='"+ CCCD+"'", _conn);
            DataTable dtKHACHHANG = new DataTable();
           
            da.Fill(dtKHACHHANG);
            return dtKHACHHANG;
        }
        // public DataTable getMAKH(string CCCD)
        public DataTable getMAKH(string CCCD)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT  TOP(1)  MAKH FROM KHACHHANG WHERE CCCD_PASSPORT ='" + CCCD + "'ORDER BY MAKH DESC ", _conn);
            DataTable dtKHACHHANG = new DataTable();
            da.Fill(dtKHACHHANG);
            return dtKHACHHANG;
        }
        public string layHoTenKH(int MaNguoiDat)
        {
            string hotenKH = "";

            try
            {
                // Mở kết nối
                _conn.Open();

                // Tạo câu truy vấn
                string SQL = "SELECT KHACHHANG.TENKH FROM KHACHHANG\r\nJOIN PHIEUDATPHONG ON PHIEUDATPHONG.NGUOIDAT = KHACHHANG.MAKH\r\nJOIN PHIEUNHANPHONG ON PHIEUNHANPHONG.MADATPHONG = PHIEUDATPHONG.MADP\r\nJOIN PHONG ON PHONG.MAPHONG = PHIEUNHANPHONG.MAPHONG\r\nWHERE PHIEUDATPHONG.NGUOIDAT = @MaNguoiDat";

                // Tạo đối tượng Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Thêm tham số cho câu truy vấn
                cmd.Parameters.AddWithValue("@MaNguoiDat", MaNguoiDat);

                // Thực thi câu truy vấn và lấy dữ liệu
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    hotenKH = reader.GetString(reader.GetOrdinal("TENKH")) ;
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

            return hotenKH;
        }
        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="kh"></param>
        /// <returns></returns>
        public bool themKhachNhanPhong_checkin(string madp,string mapnp, string CCCD_PASSPORT, string TENKH, string SDT, string EMAIL, string DIACHI, string QUOCTICH)
        {
          try
        {
               // Ket noi
               _conn.Open();

               DAL_PHIEUDATPHONG mad = new DAL_PHIEUDATPHONG();
              string madoan=mad.getMaDoan_MADP(madp).Rows[0]["MADOAN"].ToString(); 
            string SQL = string.Format("exec THEMKHACHNHANPHONG {0}, '{1}', '{2}','{3}','{4}','{5}','{6}'", madoan, CCCD_PASSPORT, TENKH, SDT, EMAIL, DIACHI, QUOCTICH);

              // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
             SqlCommand cmd = new SqlCommand(SQL, _conn);

               int returnValue = Convert.ToInt32(cmd.Parameters["@MAKH"].Value);
             makh = returnValue.ToString();
            DAL_PHIEUNHANPHONG aca = new DAL_PHIEUNHANPHONG();
           aca.sua_PNP_nguoiDat(mapnp, makh);

        //        // Query và kiểm tra
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
        public DataTable getkhachNhanPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TOP(1) * FROM KHACHHANG WHERE MAKH ='" + makh + "'", _conn);
            DataTable dtKHACHHANG = new DataTable();
            da.Fill(dtKHACHHANG);
            return dtKHACHHANG;
        }
        public bool themKHACHHANG(DTO_KHACHHANG kh)
        {
            try
            {
                // Ket noi
                _conn.Open();
                string SQL = "";
                if (kh.MADOAN == 0)
                {
                    SQL = string.Format("INSERT INTO KHACHHANG VALUES ({0}, '{1}', N'{2}','{3}','{4}',N'{5}',N'{6}')", "null", kh.CCCD_PASSPORT, kh.TENKH, kh.SDT, kh.EMAIL, kh.DIACHI,kh.QUOCTICH);

                }
                else
                {
                     SQL = string.Format("INSERT INTO KHACHHANG VALUES ({0}, '{1}', N'{2}','{3}','{4}',N'{5}',N'{6}')", kh.MADOAN, kh.CCCD_PASSPORT, kh.TENKH, kh.SDT, kh.EMAIL, kh.DIACHI,kh.QUOCTICH);
                }
                    // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                    SqlCommand cmd = new SqlCommand(SQL, _conn);

                    // Query và kiểm tra
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        /// <summary>
        /// Sửa 
        /// </summary>
        /// <param name="kh"></param>
        /// <returns></returns>
        public bool suaKHACHHANG(DTO_KHACHHANG kh)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE KHACHHANG SET MADOAN= '{0}', CCCC_PASSPORT = '{1}',TENKH= '{2}',SDT = '{3}', EMAIL='{4}',DIACHI = '{5}, QUOCTICH = '{6}'  WHERE MAKH = {7} ", kh.MADOAN, kh.CCCD_PASSPORT, kh.TENKH, kh.SDT, kh.EMAIL, kh.DIACHI, kh.QUOCTICH, kh.MAKH);

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
        }

        /// <summary>
        /// Xóa 
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        /// 
        
        public int getMaKH_MoiNhat()
        {
            int kq = 0;
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = "SELECT MAKH FROM KHACHHANG  ORDER BY MAKH DESC  ";


                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                kq=(int)cmd.ExecuteScalar();

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
        public bool xoaKHACHHANG(int MAKH)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM KHACHHANG WHERE MANV = {0})", MAKH);

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
        }
        public bool suaKH_Madoan(int md, int makh)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE KHACHHANG SET MADOAN = {0} WHERE MAKH = {1} ", md,makh);

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
        }
        public bool suaKH_MadoanNULL(int md, int makh)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE KHACHHANG SET MADOAN =  WHERE MAKH = {2} ", md, makh);

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
        }
    }
}
