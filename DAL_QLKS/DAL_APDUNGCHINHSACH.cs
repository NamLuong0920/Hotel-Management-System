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
    public class DAL_APDUNGCHINHSACH : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getAPDUNGCHINHSACH()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM APDUNGCHINHSACH", _conn);
            DataTable dtAPDUNGCHINHSACH = new DataTable();
            da.Fill(dtAPDUNGCHINHSACH);
            return dtAPDUNGCHINHSACH;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="adcs"></param>
        /// <returns></returns>
        public bool themAPDUNGCHINHSACH(DTO_APDUNGCHINHSACH adcs)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO APDUNGCHINHSACH(MACS, MAPDP, THOIGIANBATDAU,THOIGIANKETTHUC) VALUES ('{0}', '{1}', '{2}','{4}')", adcs.MACS, adcs.MAPDP, adcs.THOIGIANBATDAU,adcs.THOIGIANKETTHUC);

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
        /// <param name="adcs"></param>
        /// <returns></returns>
        public bool suaAPDUNGCHINHSACH(DTO_APDUNGCHINHSACH adcs)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE APDUNGCHINHSACH SET THOIGIANBATDAU = '{0}', THOIGIANKETTHUC = '{1}' WHERE MACS = {2} AND MAPDP = {4}", adcs.THOIGIANBATDAU, adcs.THOIGIANKETTHUC, adcs.MACS, adcs.MAPDP);

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
        /// <param name="adcs"></param>
        /// <returns></returns>
        public bool xoaAPDUNGCHINHSACH(int MACS)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM APDUNGCHINHSACH WHERE MACS = {0})", MACS);

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
