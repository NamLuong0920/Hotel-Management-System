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
    public class DAL_PHIEUDANGKI_DVHT : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getPHIEUDANGKI_DVHT()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHIEUDANGKI_DVHT", _conn);
            DataTable dtPHIEUDANGKI_DVHT = new DataTable();
            da.Fill(dtPHIEUDANGKI_DVHT);
            return dtPHIEUDANGKI_DVHT;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="pdk_dvht"></param>
        /// <returns></returns>
        public bool themPHIEUDANGKI_DVHT(DTO_PHIEUDANGKY_DVHT pdk_dvht)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO PHIEUDANGKI_DVHT(MADP, MADVHT, SONGUOI, THOIGIANKHOIHANH, CACHTHUCDICHUYEN, TINHTRANGDUYET, THOIGIANKETTHUC)" + " VALUES (" + pdk_dvht.MADP + "," + pdk_dvht.MADVHT + "," + pdk_dvht.SONGUOI + ",'" + pdk_dvht.THOIGIANKHOIHANH + "'," + pdk_dvht.DICHUYEN + "," + pdk_dvht.TINHTRANGDUYET + ",'" + pdk_dvht.THOIGIANKETTHUC + "')");

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
        /// <param name="pdk_dvht"></param>
        /// <returns></returns>
        public bool suaPHIEUDANGKI_DVHT(DTO_PHIEUDANGKY_DVHT pdk_dvht)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE PHIEUDANGKI_DVHT SET THOIGIANKHOIHANH = '{0}', THOIGIANKETTHUC = '{1}' WHERE MADVHT = {2} AND MADP = {4}", pdk_dvht.THOIGIANKHOIHANH, pdk_dvht.THOIGIANKETTHUC, pdk_dvht.MADVHT, pdk_dvht.MADP);

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
        /// <param name="pdk_dvht"></param>
        /// <returns></returns>
        public bool xoaPHIEUDANGKI_DVHT(int MADVHT)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM PHIEUDANGKI_DVHT WHERE MADVHT = {0})", MADVHT);

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

        public DataTable getPNP()
        {
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE HienThiPNP", _conn);
            DataTable dtDICHVUHOPTAC = new DataTable();
            da.Fill(dtDICHVUHOPTAC);
            return dtDICHVUHOPTAC;
        }
    }
}
