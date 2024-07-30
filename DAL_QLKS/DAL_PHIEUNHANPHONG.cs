using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_PHIEUNHANPHONG : DBConnect
    {
        /// <summary>
        /// Get toàn bộ phiếu nhận phòng
        /// </summary>
        /// <returns></returns>
        public DataTable getPhieuNhanPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUNHANPHONG", _conn);
            DataTable dtPhieuNhanPhong = new DataTable();
            da.Fill(dtPhieuNhanPhong);
            return dtPhieuNhanPhong;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool themPHIEUNHANPHONG(DTO_PHIEUNHANPHONG tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO PHIEUNHANPHONG(KHACHNHANPHONG, MADATPHONG,THOIDIEMNHAN,MAPHONG,NGUOILAP) VALUES ({0}, {1}, '{2}', {3}, {4})", tv.KHACHNHANPHONG, tv.MADATPHONG, tv.THOIDIEMNHAN, tv.MAPHONG, tv.NGUOILAP);

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
        /// Sửa 
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool suaPHIEUNHANPHONG(DTO_PHIEUNHANPHONG tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE PhieuNhanPhong SET KHACHNHANPHONG = '{0}', MADATPHONG = '{1}', THOIDIEMNHAN = '{2}', MAPHONG = '{3}', NGUOILAP = '{4}' WHERE MAPNP = {5}", tv.KHACHNHANPHONG, tv.MADATPHONG, tv.THOIDIEMNHAN, tv.MAPHONG, tv.NGUOILAP, tv.MAPNP);

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
        public bool sua_PNP_nguoiDat(string mapnp, string makh)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE PhieuNhanPhong SET KHACHNHANPHONG = '{0}' WHERE MAPNP = {1}", makh, mapnp);

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
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool xoaPHIEUNHANPHONG(int MAPNP)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM PHIEUNHANPHONG WHERE MAPNP = {0})", MAPNP);

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
        public DataTable kiemTraTinhTrangPhong(string sophong,string tuNgay, string denNgay)
        {
            string sql = "SELECT PDP.* FROM PHIEUNHANPHONG PNP,PHIEUDATPHONG PDP WHERE PNP.MADATPHONG = PDP.MADP " +
                "AND PNP.MAPHONG = " + sophong + 
                " AND ('" + tuNgay + "' BETWEEN PDP.NGAYDEN AND PDP.NGAYDI " +
                "OR '" + tuNgay + "' < PDP.NGAYDEN and '" + denNgay + "' > PDP.NGAYDI " +
                "OR '" + denNgay + "' BETWEEN PDP.NGAYDEN AND PDP.NGAYDI)";
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dtPhieuNhanPhong = new DataTable();
            da.Fill(dtPhieuNhanPhong);
            return dtPhieuNhanPhong;
        }
    }
}