using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DAL_QLKS;
using DTO_QLKS;
using System.Net.NetworkInformation;

namespace DAL_QLKS
{
    public class DAL_PHONG : DBConnect
    {
        public DataTable getPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHONG", _conn);
            DataTable dtPhong = new DataTable();
            da.Fill(dtPhong);
            return dtPhong;
        }
        public DataTable checkPhong(string tinhtrangthue, string tinhtrangvesinh, int lp)
        {
            string SQL = "select * from PHONG WHERE TINHTRANGTHUE=N'" + tinhtrangthue + "' AND TINHTRANGVESINH=N'" + tinhtrangvesinh + "'AND MALP=" + lp;
            SqlDataAdapter da = new SqlDataAdapter(SQL, _conn);
            DataTable dtPhong = new DataTable();
            da.Fill(dtPhong);
            return dtPhong;
        }


        public bool themPHONG(DTO_PHONG phong)
        {
            try
            {
                // Ket noi
                _conn.Open();

                //identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string query_themTV = " INSERT INTO PHONG(" + phong.MALP + "," + phong.TINHTRANGTHUE + "," + phong.TINHTRANGVESINH + ")";
                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(query_themTV, _conn);

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

        public bool suaPHONG(DTO_PHONG phong)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string
                /*string SQL = string.Format("UPDATE PHONG SET  MALP = '{0}', TINHTRANGTHUE = '{1}', TINHTRANGVESINH = '{2}' " +
                    "WHERE MAPHONG = {3}", phong.MALP, phong.TINHTRANGTHUE, phong.TINHTRANGVESINH, phong.MAPHONG);*/
                string SQL = string.Format("UPDATE PHONG SET  MALP = "+phong.MALP+ ", TINHTRANGTHUE = N'"+phong.TINHTRANGTHUE+"', TINHTRANGVESINH = N'"+phong.TINHTRANGVESINH+"' " +
                    "WHERE MAPHONG = "+ phong.MAPHONG);

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
    

        public bool xoaPHONG(int MAPHONG)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM THANHVIEN WHERE MAPHONG = {0})", MAPHONG);

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
        public DataTable getPhong_BuongPhong()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAPHONG,TINHTRANGVESINH FROM PHONG", _conn);
            DataTable dtPhong = new DataTable();
            da.Fill(dtPhong);
            return dtPhong;
        }
        public DataTable getPhong_BuongPhongTimKiem(string maphong)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MAPHONG,TINHTRANGVESINH FROM PHONG WHERE MAPHONG = '"+maphong+"'", _conn);
            DataTable dtPhong = new DataTable();
            da.Fill(dtPhong);
            return dtPhong;
        }
        public DataTable getPhong(string maphong)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PHONG WHERE MAPHONG = '"+maphong+"'", _conn);
            DataTable dtPhong = new DataTable();
            da.Fill(dtPhong);
            return dtPhong;
        }

        public DataTable getDSPhong_MaNguoiDat(int MaNguoiDat)
        {
            DataTable dtPhong = new DataTable();
            string query = @"SELECT p.MAPHONG, p.MALP
                            FROM PHIEUNHANPHONG pn
                            INNER JOIN PHONG p ON pn.MAPHONG = p.MAPHONG
                            INNER JOIN PHIEUDATPHONG pd ON pn.MADATPHONG = pd.MADP
                            WHERE pd.NGUOIDAT = @MaNguoiDat";
            SqlCommand command = new SqlCommand(query,_conn);
            command.Parameters.AddWithValue("@MaNguoiDat", MaNguoiDat);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dtPhong);
            return dtPhong;
        }

        public DataTable getHongHoc_DSPhong_MaNguoiDat(int MaNguoiDat)
        {
            DataTable dtPhong = new DataTable();
            string query = @"SELECT p.MAPHONG, mv.TENVATCHAT, h.SOLUONG
                            FROM PHIEUNHANPHONG pn
                            INNER JOIN PHONG p ON pn.MAPHONG = p.MAPHONG
                            INNER JOIN PHIEUDATPHONG pd ON pn.MADATPHONG = pd.MADP
                            LEFT JOIN HONGHOC h ON pn.MAPNP = h.MAPNP
                            LEFT JOIN COSOVATCHAT mv ON h.MAVATCHAT = mv.MAVATCHAT
                            WHERE pd.NGUOIDAT = @MaNguoiDat";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@MaNguoiDat", MaNguoiDat);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dtPhong);
            return dtPhong;
        }
        public DataTable getDichVu_DSPhong_MaNguoiDat(int MaNguoiDat)
        {
            DataTable dtPhong = new DataTable();
            string query = @"
SELECT DISTINCT DVH.TENDV, DVH.GIA, DVTC.TENDV, DVTC.DONVITINH, DVTC.GIA
FROM PHIEUNHANPHONG PNP
INNER JOIN PHIEUDATPHONG PDP ON PNP.MADATPHONG = PDP.MADP
INNER JOIN PHONG P ON PNP.MAPHONG = P.MAPHONG
INNER JOIN PHIEUDANGKI_DVHT PDV ON PDP.MADP = PDV.MADP
INNER JOIN DICHVUHOPTAC DVH ON PDV.MADVHT = DVH.MADVHT
INNER JOIN PHIEUDANGKI_DVTC PDT ON PNP.MAPNP = PDT.MAPNP
INNER JOIN DV_TAICHO DVTC ON PDT.MADVTC = DVTC.MADVTC
WHERE PDP.NGUOIDAT = @MaNguoiDat";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@MaNguoiDat", MaNguoiDat);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dtPhong);
            return dtPhong;
        }

    }
}

    

