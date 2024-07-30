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
    public class DAL_DOAN : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getDOAN()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DOAN", _conn);
            DataTable dtDOAN = new DataTable();
            da.Fill(dtDOAN);
            return dtDOAN;
        }

        public DataTable getMaDoan(string nguoiDat)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MADOAN FROM DOAN where TRUONGDOAN="+ nguoiDat+ " order by MADOAN desc", _conn);
            DataTable dtDOAN = new DataTable();
            da.Fill(dtDOAN);
            return dtDOAN;
        }
        DAL_PHIEUNHANPHONG aca = new DAL_PHIEUNHANPHONG();
        
        public int getMD_MoiNhat()
        {
            int kq = 0;
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = "SELECT MADOAN FROM DOAN  ORDER BY MADOAN DESC  ";


                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                kq = (int)cmd.ExecuteScalar();

                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return kq;

            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return kq;



        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="doan"></param>
        /// <returns></returns>
        public bool themDOAN(DTO_DOAN doan)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO DOAN VALUES ('{0}', '{1}',{2})", doan.TENDOAN, doan.TRUONGDOAN, doan.SONGUOI);

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
        public bool suaDOAN(DTO_DOAN doan)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE DOAN SET TENDOAN= '{0}', TRUONGDOAN = '{1}',SONGUOI= {2}  WHERE MADOAN = {3} ", doan.TENDOAN, doan.TRUONGDOAN, doan.SONGUOI);

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
        public bool xoaDOAN(int MADOAN)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM DOAN WHERE MADOAN = {0})", MADOAN);

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
