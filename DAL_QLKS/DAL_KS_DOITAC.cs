using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_KS_DOITAC : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getKS_DOITAC()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KS_DOITAC", _conn);
            DataTable dtKS_DOITAC = new DataTable();
            da.Fill(dtKS_DOITAC);
            return dtKS_DOITAC;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="ks_doitac"></param>
        /// <returns></returns>
        public bool themKS_DOITAC(DTO_KS_DOITAC ks_doitac)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO KS_DOITAC(MAKSDT, TENKS, MOTA, DIACHI, EMAIL, SDT)" + " VALUES ('{0}', '{1}', '{2}','{3}','{4}','{5}')", ks_doitac.MAKSDT, ks_doitac.TENKS, ks_doitac.MOTA, ks_doitac.DIACHI, ks_doitac.EMAIL, ks_doitac.SDT);

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
        /// <param name="ks_doitac"></param>
        /// <returns></returns>
        public bool suaKS_DOITAC(DTO_KS_DOITAC ks_doitac)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE KS_DOITAC SET TENKS = '{0}' MOTA = '{1}' DIACHI = '{2}' EMAIL = '{3}' SDT = '{4}' WHERE MAKSDT = {5} ", ks_doitac.TENKS, ks_doitac.MOTA, ks_doitac.DIACHI, ks_doitac.EMAIL, ks_doitac.SDT, ks_doitac.MAKSDT);
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
        /// <param name="ks_doitac"></param>
        /// <returns></returns>
        public bool xoaKS_DOITAC(int MAKSDT)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM KS_DOITAC WHERE MAKSDT = {0})", MAKSDT);

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