using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_CHINHSACH : DBConnect
    {
        /// <summary>
        /// Get toàn bộ BẢNG
        /// </summary>
        /// <returns></returns>
        public DataTable getCHINHSACH()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CHINHSACH", _conn);
            DataTable dtCHINHSACH = new DataTable();
            da.Fill(dtCHINHSACH);
            return dtCHINHSACH;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="tv"></param>
        /// <returns></returns>
        public bool themCHINHSACH(DTO_CHINHSACH tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string SQL = string.Format("INSERT INTO CHINHSACH(TENCS,THOIGIANAPDUNG) VALUES ('{0}', '{1}')", tv.TENCS, tv.THOIGIANAPDUNG);

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
        public bool suaCHINHSACH(DTO_CHINHSACH tv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                string SQL = string.Format("UPDATE CHINHSACH SET TENCS = '{0}', THOIGIANAPDUNG = '{1}' WHERE MACS = {2} ", tv.TENCS, tv.THOIGIANAPDUNG, tv.MACS);

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
        public bool xoaCHINHSACH(int MACS)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM CHINHSACH WHERE MACS= {0})", MACS);

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