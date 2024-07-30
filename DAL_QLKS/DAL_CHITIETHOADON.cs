using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_CHITIETHOADON : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getCHITIETHOADON()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CHITIETHOADON", _conn);
            DataTable dtCHITIETHOADON = new DataTable();
            da.Fill(dtCHITIETHOADON);
            return dtCHITIETHOADON;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="cthdon"></param>
        /// <returns></returns>
        public bool themCHITIETHOADON(DTO_CHITIETHOADON cthdon)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO CHITIETHOADON(MAHOADON, STT, DV_CSVC, SOLUONG, THANHTIEN)" + " VALUES ('{0}', '{1}', '{2}','{3}','{4}')", cthdon.MAHOADON, cthdon.STT, cthdon.DV_CSVC, cthdon.SOLUONG, cthdon.THANHTIEN);

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
        /// <param name="hdon"></param>
        /// <returns></returns>
        public bool suaCHITIETHOADON(DTO_CHITIETHOADON cthdon)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE CHITIETHOADON SET STT = '{0}' DV_CSVC = '{1}' SOLUONG = '{2}' THANHTIEN = '{3}' WHERE MAHOADON = {4} ", cthdon.STT, cthdon.DV_CSVC, cthdon.SOLUONG, cthdon.THANHTIEN, cthdon.MAHOADON);
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
        /// <param name="cthdon"></param>
        /// <returns></returns>
        public bool xoaCHITIETHOADON(int MAHOADON)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM CHITIETHOADON WHERE MAHOADON = {0})", MAHOADON);

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