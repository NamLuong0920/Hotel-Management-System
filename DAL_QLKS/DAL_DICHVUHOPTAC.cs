using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_DICHVUHOPTAC : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getDICHVUHOPTAC()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DICHVUHOPTAC", _conn);
            DataTable dtDICHVUHOPTAC = new DataTable();
            da.Fill(dtDICHVUHOPTAC);
            return dtDICHVUHOPTAC;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="dvht"></param>
        /// <returns></returns>
        public bool themDICHVUHOPTAC(DTO_DICHVUHOPTAC dvht)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO DICHVUHOPTAC(MADVHT, MADOITACDV, TENDV,GIA) " +
                    "VALUES ('{0}', '{1}', '{2}','{4}')", dvht.MADVHT, dvht.MADOITACDV, dvht.TENDV, dvht.GIA);

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
        /// <param name="dvht"></param>
        /// <returns></returns>
        public bool suaDICHVUHOPTAC(DTO_DICHVUHOPTAC dvht)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE DICHVUHOPTAC SET MADOITACDV = '{0}', TENDV = '{1}' , GIA = '{2}' WHERE MADVHT = {3} ", 
                    dvht.MADOITACDV, dvht.TENDV, dvht.GIA, dvht.MADVHT);

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
        /// <param name="dvht"></param>
        /// <returns></returns>
        public bool xoaDICHVUHOPTAC(int MADVHT)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM DICHVUHOPTAC WHERE MADVHT = {0})", MADVHT);

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

        public DataTable getPNP()
        {
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE HienThiPNP", _conn);
            DataTable dtDICHVUHOPTAC = new DataTable();
            da.Fill(dtDICHVUHOPTAC);
            return dtDICHVUHOPTAC;
        }
    }
}
