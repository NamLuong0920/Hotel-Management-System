using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_HONGHOC : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getHONGHOC()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HONGHOC", _conn);
            DataTable dtHONGHOC = new DataTable();
            da.Fill(dtHONGHOC);
            return dtHONGHOC;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="hhoc"></param>
        /// <returns></returns>
        public bool themHONGHOC(DTO_HONGHOC hhoc)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO HONGHOC VALUES ('{0}', {1} )", hhoc.MAHONGHOC, hhoc.MAPNP, hhoc.MAVATCHAT, hhoc.SOLUONG);

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
        public bool suaHONGHOC(DTO_HONGHOC hhoc)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE HONGHOC SET MAPNP= '{0}' MAVATCHAT = '{1}' SOLUONG = '{2}' WHERE MAHONGHOC = {3} ", hhoc.MAPNP, hhoc.MAVATCHAT, hhoc.SOLUONG, hhoc.MAHONGHOC);
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
        /// <param name="hhoc"></param>
        /// <returns></returns>
        public bool xoaHONGHOC(int MAHONGHOC)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM HONGHOC WHERE MAHONGHOC = {0})", MAHONGHOC);

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