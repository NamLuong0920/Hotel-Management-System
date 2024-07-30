using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_GIAHAN : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getGIAHAN()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GIAHAN", _conn);
            DataTable dtGIAHAN = new DataTable();
            da.Fill(dtGIAHAN);
            return dtGIAHAN;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="ghan"></param>
        /// <returns></returns>
        public bool themGIAHAN(DTO_GIAHAN ghan)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO GIAHAN( MADP, THOIGIANGIAHAN, TINHTRANGDUYET)" + 
                    " VALUES ("+ ghan.MADP+", "+ ghan.THOIGIANGIAHAN+", "+ ghan.TINHTRANGDUYET + ")");

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
        public bool suaGIAHAN(DTO_GIAHAN ghan)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE GIAHAN SET MADP = '{0}' THOIGIANGIAHAN = '{1}' TINHTRANGDUYET = '{2}' WHERE STT = {3} ", ghan.MADP, ghan.THOIGIANGIAHAN, ghan.TINHTRANGDUYET, ghan.STT);
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
        /// <param name="ghan"></param>
        /// <returns></returns>
        public bool xoaGIAHAN(int STT)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM GIAHAN WHERE STT = {0})", STT);

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
        public DataTable getGIAHAN(string MADP)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GIAHAN WHERE MADP = "+MADP, _conn);
            DataTable dtGIAHAN = new DataTable();
            da.Fill(dtGIAHAN);
            return dtGIAHAN;
        }
        public DataTable getGIAHAN_STT(string MAGH)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM GIAHAN WHERE STT = " + MAGH, _conn);
            DataTable dtGIAHAN = new DataTable();
            da.Fill(dtGIAHAN);
            return dtGIAHAN;
        }
        public bool capNhatTinhTrangDuyet(DTO_GIAHAN ghan)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE GIAHAN SET TINHTRANGDUYET = N'"+ghan.TINHTRANGDUYET+"' WHERE STT =" + ghan.STT);
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