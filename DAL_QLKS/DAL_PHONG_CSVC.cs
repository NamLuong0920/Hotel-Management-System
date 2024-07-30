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
    public class DAL_PHONG_CSVC : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getPHONG_CSVC()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHONG_CSVC", _conn);
            DataTable dtPHONG_CSVC = new DataTable();
            da.Fill(dtPHONG_CSVC);
            return dtPHONG_CSVC;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="p_csvc"></param>
        /// <returns></returns>
        public bool themPHONG_CSVC(DTO_PHONG_CSVC p_csvc)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO NHANVIEN VALUES ('{0}', '{1}', {2})", p_csvc.MAPHONG,p_csvc.MA_CSVC,p_csvc.SOLUONG);

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
        /// <param name="p_csvc"></param>
        /// <returns></returns>
        public bool suaPHONG_CSVC(DTO_PHONG_CSVC p_csvc)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE PHONG_CSVC SET MA_CSVC= '{0}', SOLUONG = {1} WHERE MAPHONG = {2} ", p_csvc.MA_CSVC,p_csvc.SOLUONG);

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
        /// <param name="p_csvc"></param>
        /// <returns></returns>
        public bool xoaPHONG_CSVC(int MAPHONG, int MA_CSVC)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM PHONG_CSVC WHERE MAPHONG = '{0}' AND MA_CSVC='{1}')", MAPHONG, MA_CSVC);

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
