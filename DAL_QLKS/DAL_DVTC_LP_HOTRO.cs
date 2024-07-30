using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_DV_LP_HOTRO : DBConnect
    {
        /// <summary>
        /// Get toàn bộ BẢNG
        /// </summary>
        /// <returns></returns>
        public DataTable getDV_LP_HOTRO()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DV_LP_HOTRO", _conn);
            DataTable dtDV_LP_HOTRO = new DataTable();
            da.Fill(dtDV_LP_HOTRO);
            return dtDV_LP_HOTRO;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool themDV_LP_HOTRO(DTO_DV_LP_HOTRO tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO DV_LP_HOTRO(MALP, MADVTC) VALUES ('{0}', '{1}')", tv.MALP, tv.MADVTC);

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
        public bool suaDV_LP_HOTRO(DTO_DV_LP_HOTRO tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE DV_LP_HOTRO SET MADVTC = '{0}'WHERE MALP = {1}", tv.MADVTC, tv.MALP);

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
        public bool xoaDV_LP_HOTRO(int MALP, int MADVTC)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM DV_LP_HOTRO WHERE MALP = {0}) AND MADVTC ={1}", MALP, MADVTC);

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