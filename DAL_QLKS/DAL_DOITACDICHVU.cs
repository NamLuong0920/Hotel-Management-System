using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLKS;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_DOITACDICHVU : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getDOITACDICHVU()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DOITACDICHVU", _conn);
            DataTable dtDOITACDICHVU = new DataTable();
            da.Fill(dtDOITACDICHVU);
            return dtDOITACDICHVU;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="dtdv"></param>
        /// <returns></returns>
        public bool themDOITACDICHVU(DTO_DOITACDICHVU dtdv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO DOITACDICHVU(MADOITACDV, TENDOITAC, SDT,EMAIL,DIACHI)" +
                    " VALUES ('{0}', '{1}', '{2}','{4}','{5}')", dtdv.MADOITACDV, dtdv.TENDOITAC, dtdv.SDT, dtdv.EMAIL, dtdv.DIACHI);

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
        /// <param name="dtdv"></param>
        /// <returns></returns>
        public bool suaDOITACDICHVU(DTO_DOITACDICHVU dtdv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE DOITACDICHVU SET TENDOITAC = '{0}', SDT = '{1}', EMAIL = '{3}', DIACHI = '{4}' WHERE MADOITACDV = {5}", dtdv.TENDOITAC, dtdv.SDT, dtdv.EMAIL, dtdv.DIACHI, dtdv.MADOITACDV);

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
        /// <param name="dtdv"></param>
        /// <returns></returns>
        public bool xoaDOITACDICHVU(int MADOITACDV)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM DOITACDICHVU WHERE MADOITACDV = {0})", MADOITACDV);

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
