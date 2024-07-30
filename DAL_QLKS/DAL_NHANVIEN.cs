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
    public class DAL_NHANVIEN : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getNHANVIEN()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHANVIEN", _conn);
            DataTable dtNHANVIEN = new DataTable();
            da.Fill(dtNHANVIEN);
            return dtNHANVIEN;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public bool themNHANVIEN(DTO_NHANVIEN nv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO NHANVIEN VALUES ('{0}', '{1}', '{2}','{3}')",nv.TENNV, nv.SDT, nv.EMAIL, nv.DIACHI);

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
        /// <param name="nv"></param>
        /// <returns></returns>
        public bool suaNHANVIEN(DTO_NHANVIEN nv)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE NHANVIEN SET TENNV= '{0}', SDT = '{1}',EMAIL= '{2}',DIACHI = '{3}'  WHERE MANV = {4} ", nv.TENNV, nv.SDT, nv.EMAIL, nv.DIACHI, nv.MANV);

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
        /// <param name="nv"></param>
        /// <returns></returns>
        public bool xoaNHANVIEN(int MANV)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM NHANVIEN WHERE MANV = {0})", MANV);

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
