using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_TAIKHOAN : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getTAIKHOAN()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAIKHOAN", _conn);
            DataTable dtTAIKHOAN = new DataTable();
            da.Fill(dtTAIKHOAN);
            return dtTAIKHOAN;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="tk"></param>
        /// <returns></returns>
        public bool themTAIKHOAN(DTO_TAIKHOAN tk)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO TAIKHOAN(USERNAME, U_PASSWORD, MANV, VAITRO)" + " VALUES ('{0}', '{1}', '{2}','{3}')", tk.USERNAME, tk.U_PASSWORD, tk.MANV, tk.VAITRO);

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
        /// <param name="tk"></param>
        /// <returns></returns>
        public bool suaTAIKHOAN(DTO_TAIKHOAN tk)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE TAIKHOAN SET U_PASSWORD = '{0}' MANV = '{1}' VAITRO = '{2}' WHERE USERNAME = {3} ", tk.U_PASSWORD, tk.MANV, tk.VAITRO, tk.USERNAME);
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
        /// <param name="tk"></param>
        /// <returns></returns>
        public bool xoaTAIKHOAN(string USERNAME)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM TAIKHOAN WHERE USERNAME = {0})", USERNAME);

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
        /// KIỂM TRA
        /// </summary>
        /// <param name="tk"></param>
        /// <returns></returns>
        public bool kiemTraTAIKHOAN(string USERNAME, string PASSWORD)
        {
            _conn.Open();
            string query = "SELECT MANV FROM TAIKHOAN WHERE USERNAME = @taiKhoan AND U_PASSWORD = @matKhau";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@taiKhoan", USERNAME);
            cmd.Parameters.AddWithValue("@matKhau", PASSWORD);
            SqlDataReader reader = cmd.ExecuteReader();
            string MANV = "";
            if (reader.Read())
            {
                int manvInt = reader.GetInt32(0);
                MANV = manvInt.ToString();
            }
            reader.Close();
            _conn.Close();
            if (MANV == "")
                return false;
            else return true;

        }
        /// <summary>
        /// LẤY VAI TRÒ 
        /// </summary>
        /// <param name="tk"></param>
        /// <returns></returns>
        public string getVaiTro(string USERNAME)
        {
            _conn.Open();
            string query = "SELECT VAITRO FROM TAIKHOAN WHERE USERNAME = @USERNAME";
            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@USERNAME", USERNAME);
            SqlDataReader reader = cmd.ExecuteReader();
            string vaitro = "";
            if (reader.Read())
            {
                vaitro = reader.GetString(0);
            }
            reader.Close();
            _conn.Close();
            return vaitro;
        }
    }
}