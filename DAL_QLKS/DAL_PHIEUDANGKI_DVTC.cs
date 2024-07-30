using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_PHIEUDANGKY_DVTC : DBConnect
    {
        /// <summary>
        /// Get toàn bộ BẢNG
        /// </summary>
        /// <returns></returns>
        public DataTable getPHIEUDANGKY_DVTC()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUDANGKY_DVTC", _conn);
            DataTable dtPHIEUDANGKY_DVTC = new DataTable();
            da.Fill(dtPHIEUDANGKY_DVTC);
            return dtPHIEUDANGKY_DVTC;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool themPHIEUDANGKY_DVTC(DTO_PHIEUDANGKY_DVTC tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO PHIEUDANGKI_DVTC(MADVTC,MAPNP, THOIDIEMSUDUNG,THOIDIEMDANGKY)" + "VALUES (" + tv.MADVTC + ", " + tv.MAPNP + ",'" + tv.THOIDIEMSUDUNG + "','" + tv.THOIDIEMDANGKY + "')");

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
        public bool suaPHIEUDANGKY_DVTC(DTO_PHIEUDANGKY_DVTC tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE PHIEUDANGKY_DVTC SET THOIDIEMSUDUNG = '{0}', THOIDIEMDANGKY = '{1}' WHERE MADVTC = {2} AND MAPNP = {3}", tv.THOIDIEMSUDUNG, tv.THOIDIEMDANGKY, tv.MADVTC, tv.MAPNP);

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
        public bool xoaDV_LP_HOTRO( int MADVTC, int MALP)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM PHIEUDANGKY_DVTC WHERE MADVTC= {0} and MALP = {1})", MADVTC, MALP);

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