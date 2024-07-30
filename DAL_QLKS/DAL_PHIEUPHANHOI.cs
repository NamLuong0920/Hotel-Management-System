using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_PHIEUPHANHOI : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getPHIEUPHANHOI()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUPHANHOI", _conn);
            DataTable dtPHIEUPHANHOI = new DataTable();
            da.Fill(dtPHIEUPHANHOI);
            return dtPHIEUPHANHOI;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="ghan"></param>
        /// <returns></returns>
        public bool themPHIEUPHANHOI(DTO_PHIEUPHANHOI phphanhoi)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO PHIEUPHANHOI(MAPH, NOIDUNG, MAPNP, DANHGIA)" + " VALUES ('{0}', '{1}', '{2}','{3}')", phphanhoi.MAPH, phphanhoi.NOIDUNG, phphanhoi.MAPNP, phphanhoi.DANHGIA);

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
        /// <param name="csvc"></param>
        /// <returns></returns>
        public bool suaPHIEUPHANHOI(DTO_PHIEUPHANHOI phphanhoi)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE PHIEUPHANHOI SET NOIDUNG = '{0}' MAPNP = '{1}' DANHGIA = '{2}' WHERE MAPH = {3} ", phphanhoi.NOIDUNG, phphanhoi.MAPNP, phphanhoi.DANHGIA, phphanhoi.MAPH);
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
        /// <param name="phphanhoi"></param>
        /// <returns></returns>
        public bool xoaPHIEUPHANHOI(int MAPH)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM PHIEUPHANHOI WHERE MAPH = {0})", MAPH);

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