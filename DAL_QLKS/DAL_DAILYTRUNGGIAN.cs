using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;
using DAL_QLKS;

namespace DAL_DAILYTRUNGGIAN
{
    public class DAL_DAILYTRUNGGIAN : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getDAILYTRUNGGIAN()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DAILYTRUNGGIAN", _conn);
            DataTable dtDAIYTRUNGGIAN= new DataTable();
            da.Fill(dtDAIYTRUNGGIAN);
            return dtDAIYTRUNGGIAN;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="dltg"></param>
        /// <returns></returns>
        public bool themDAILY_TRUNGGIAN(DTO_DAILYTRUNGGIAN dltg)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO DAIYTRUNGGIAN VALUES ('{0}', '{1}', '{2}','{3}')", dltg.TENDAILY, dltg.SDT, dltg.EMAIL, dltg.DIACHI);

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
        /// <param name="dltg"></param>
        /// <returns></returns>
        public bool suaDAILYTRUNGGIAN(DTO_DAILYTRUNGGIAN dltg)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE DAILYTRUNGGIAN SET TENDAILY= '{0}', SDT = '{1}',EMAIL= '{2}',DIACHI = '{3}'  WHERE MADAILY = {4} ", dltg.TENDAILY, dltg.SDT, dltg.EMAIL, dltg.DIACHI, dltg.MADAILY);

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
        /// <param name="dltg"></param>
        /// <returns></returns>
        public bool xoaDAILYTRUNGGIAN(int MADAILY)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM NHANVIEN WHERE MADAILY = {0})", MADAILY);

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
