using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;
using DAL_QLKS;

namespace DAL_QLKS
{
    public class DAL_COSOVATCHAT: DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getCOSOVATCHAT()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM COSOVATCHAT", _conn);
            DataTable dtCOSOVATCHAT = new DataTable();
            da.Fill(dtCOSOVATCHAT);
            return dtCOSOVATCHAT;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="csvc"></param>
        /// <returns></returns>
        public bool themCOSOVATCHAT(DTO_COSOVATCHAT csvc)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO COSOVATCHART VALUES ('{0}', {1} )", csvc.TENVATCHAT, csvc.GIA);

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
        public bool suaCOSOVATCHAT(DTO_COSOVATCHAT csvc)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE COSOVATCHAT SET TENVATCHAT= '{0}' GIA = {1}  WHERE MAVATCHAT = {2} ", csvc.TENVATCHAT, csvc.GIA, csvc.MAVATCHAT);
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
        /// <param name="csvc"></param>
        /// <returns></returns>
        public bool xoaCOSOVATCHAT(int MAVATCHAT)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM COSOVATCHAT WHERE MAVATCHAT = {0})", MAVATCHAT);

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
