using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLKS;
using DAL_QLKS;

namespace DAL_LOAIPHONG
{
    public class DAL_LOAIPHONG : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getLOAIPHONG()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOAIPHONG", _conn);
            DataTable dtLOAIPHONG = new DataTable();
            da.Fill(dtLOAIPHONG);
            return dtLOAIPHONG;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="lp"></param>
        /// <returns></returns>
        public bool themLOAIPHONG(DTO_LOAIPHONG   lp)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO LOAIPHONG VALUES ('{0}', '{1}', '{2}','{3}')", lp.TENLP, lp.HANGPHONG, lp.DONGIA, lp.MOTA);

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
        /// <param name="lp"></param>
        /// <returns></returns>
        public bool suaLOAIPHONG(DTO_LOAIPHONG lp)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE LOAIPHONG SET TENLP= '{0}', HANGPHONG = '{1}',DONGIA= '{2}',MOTA = '{3}'  WHERE MALP = {4} ", lp.TENLP , lp.HANGPHONG, lp.DONGIA, lp.MOTA);

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
        /// <param name="lp"></param>
        /// <returns></returns>
        public bool xoaPHIEUDANGKI_DVHT(int MALP)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM LOAIPHONG WHERE MALP = {0})", MALP);

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
