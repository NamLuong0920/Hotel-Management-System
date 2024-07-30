using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_PHIEUTRAPHONG : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getPHIEUTRAPHONG()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUTRAPHONG", _conn);
            DataTable dtPHIEUTRAPHONG = new DataTable();
            da.Fill(dtPHIEUTRAPHONG);
            return dtPHIEUTRAPHONG;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="phtraphong"></param>
        /// <returns></returns>
        public bool themPHIEUTRAPHONG(DTO_PHIEUTRAPHONG phtraphong)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO PHIEUTRAPHONG(MATP, NGAYCHECKOUT, MAPH, MADP)" + " VALUES ('{0}', '{1}', '{2}','{3}')", phtraphong.MATP, phtraphong.NGAYCHECKOUT, phtraphong.MAPH, phtraphong.MADP);

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
        public bool suaPHIEUTRAPHONG(DTO_PHIEUTRAPHONG phtraphong)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE PHIEUTRAPHONG SET NGAYCHECKOUT = '{0}' MAPH = '{1}' MADP = '{2}' WHERE MATP = {3} ", phtraphong.NGAYCHECKOUT, phtraphong.MAPH, phtraphong.MADP, phtraphong.MATP);
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
        /// <param name="phtraphong"></param>
        /// <returns></returns>
        public bool xoaPHIEUTRAPHONG(int MATP)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM PHIEUTRAPHONG WHERE MATP = {0})", MATP);

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