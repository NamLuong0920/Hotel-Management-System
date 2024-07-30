using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_DV_TAICHO : DBConnect
    {
        /// <summary>
        /// Get toàn bộ phiếu nhận phòng
        /// </summary>
        /// <returns></returns>
        public DataTable getDV_TAICHO()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DV_TAICHO", _conn);
            DataTable dtDV_TAICHO = new DataTable();
            da.Fill(dtDV_TAICHO);
            return dtDV_TAICHO;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool themDV_TAICHO(DTO_DV_TAICHO tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO DV_TAICHO(TENDV, GIA,DONVITINH) VALUES ('{0}', '{1}', '{2}')", tv.TENDV, tv.GIA, tv.DONVITINH);

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
        public bool suaDV_TAICHO(DTO_DV_TAICHO tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE DV_TAICHO SET TENDV = '{0}', GIA = '{1}', DONVITINH = '{2}'WHERE MADVTC = {3}", tv.TENDV, tv.GIA, tv.DONVITINH, tv.MADVTC);

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
        public bool xoaDV_TAICHO(int MADVTC)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM DV_TAICHO WHERE MADVTC = {0})", MADVTC);

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

        public DataTable timKiemDV_TAICHO(string MAPHONG)
        {

            SqlDataAdapter da = new SqlDataAdapter("EXECUTE HienThiDVTC " + MAPHONG, _conn);
            DataTable dtDV_TAICHO = new DataTable();
            da.Fill(dtDV_TAICHO);
            return dtDV_TAICHO;
        }
    }
}