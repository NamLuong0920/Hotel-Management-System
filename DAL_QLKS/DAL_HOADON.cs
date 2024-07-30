using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using DTO_QLKS;

namespace DAL_QLKS
{
    public class DAL_HOADON : DBConnect
    {
        /// <summary>
        /// Get toàn bộ bảng
        /// </summary>
        /// <returns></returns>
        public DataTable getHOADON()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOADON", _conn);
            DataTable dtHOADON = new DataTable();
            da.Fill(dtHOADON);
            return dtHOADON;
        }

        /// <summary>
        /// Thêm 
        /// </summary>
        /// <param name="hdon"></param>
        /// <returns></returns>
        /// 

        public DateTime getCurrentDate()
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("SELECT GETDATE()");

                // Command (mặc định command type = text nên chúng ta khỏi fải làm gì nhiều).
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Query và kiểm tra
                DateTime currentDate = (DateTime)cmd.ExecuteScalar();

                return currentDate;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }
        public decimal tinhTienPhong(int MaNguoiDat)
        {
            decimal tienPhong = 0;

            try
            {
                // Mở kết nối
                _conn.Open();

                // Tạo câu truy vấn
                string SQL = "SELECT PHIEUDATPHONG.CHIPHIUOCTINH FROM PHIEUDATPHONG\r\nJOIN PHIEUNHANPHONG ON PHIEUNHANPHONG.MADATPHONG = PHIEUDATPHONG.MADP\r\nWHERE PHIEUDATPHONG.NGUOIDAT = @MaNguoiDat";

                // Tạo đối tượng Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Thêm tham số cho câu truy vấn
                cmd.Parameters.AddWithValue("@MaNguoiDat", MaNguoiDat);

                // Thực thi câu truy vấn và lấy dữ liệu
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tienPhong = reader.GetDecimal(reader.GetOrdinal("CHIPHIUOCTINH"));
                }

                // Đóng kết nối
                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }

            return tienPhong;
        }

        public decimal tinhTienCSVC(int MaNguoiDat)
        {
            decimal tienCSVC = 0;

            try
            {
                // Mở kết nối
                _conn.Open();

                // Tạo câu truy vấn
                string SQL = "SELECT SUM(HONGHOC.SOLUONG * COSOVATCHAT.GIA) AS TONG_TIEN_HONG_HOC " +
                             "FROM PHONG " +
                             "INNER JOIN PHIEUNHANPHONG ON PHONG.MAPHONG = PHIEUNHANPHONG.MAPHONG " +
                             "INNER JOIN PHIEUDATPHONG ON PHIEUNHANPHONG.MADATPHONG = PHIEUDATPHONG.MADP " +
                             "INNER JOIN HONGHOC ON PHIEUNHANPHONG.MAPNP = HONGHOC.MAPNP " +
                             "INNER JOIN COSOVATCHAT ON HONGHOC.MAVATCHAT = COSOVATCHAT.MAVATCHAT " +
                             "WHERE PHIEUDATPHONG.NGUOIDAT = @MaNguoiDat";
                // Tạo đối tượng Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Thêm tham số cho câu truy vấn
                cmd.Parameters.AddWithValue("@MaNguoiDat", MaNguoiDat);

                // Thực thi câu truy vấn và lấy dữ liệu
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("TONG_TIEN_HONG_HOC")))
                    {
                        tienCSVC = reader.GetDecimal(reader.GetOrdinal("TONG_TIEN_HONG_HOC"));
                    }
                }

                // Đóng kết nối
                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }

            return tienCSVC;
        }

        public decimal tinhTienDV(int MaNguoiDat)
        {
            decimal tienDV = 0;

            try
            {
                // Mở kết nối
                _conn.Open();

                // Tạo câu truy vấn
                string SQL = "SELECT SUM(DV_GIA) AS TONG_TIEN_DICH_VU " +
                             "FROM (" +
                             "    SELECT DICHVUHOPTAC.GIA AS DV_GIA " +
                             "    FROM PHONG " +
                             "    INNER JOIN PHIEUNHANPHONG ON PHONG.MAPHONG = PHIEUNHANPHONG.MAPHONG " +
                             "    INNER JOIN PHIEUDATPHONG ON PHIEUNHANPHONG.MADATPHONG = PHIEUDATPHONG.MADP " +
                             "    INNER JOIN PHIEUDANGKI_DVHT ON PHIEUDATPHONG.MADP = PHIEUDANGKI_DVHT.MADP " +
                             "    INNER JOIN DICHVUHOPTAC ON PHIEUDANGKI_DVHT.MADVHT = DICHVUHOPTAC.MADVHT " +
                             "    WHERE PHIEUDATPHONG.NGUOIDAT = @MaNguoiDat " +
                             "    UNION ALL " +
                             "    SELECT DV_TAICHO.GIA AS DV_GIA " +
                             "    FROM PHIEUNHANPHONG " +
                             "    INNER JOIN PHONG ON PHIEUNHANPHONG.MAPHONG = PHONG.MAPHONG " +
                             "    INNER JOIN PHIEUDATPHONG ON PHIEUNHANPHONG.MADATPHONG = PHIEUDATPHONG.MADP " +
                             "    INNER JOIN PHIEUDANGKI_DVTC ON PHIEUNHANPHONG.MAPNP = PHIEUDANGKI_DVTC.MAPNP " +
                             "    INNER JOIN DV_TAICHO ON PHIEUDANGKI_DVTC.MADVTC = DV_TAICHO.MADVTC " +
                             "    WHERE PHIEUDATPHONG.NGUOIDAT = @MaNguoiDat " +
                             ") AS TONG_TIEN";
                // Tạo đối tượng Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Thêm tham số cho câu truy vấn
                cmd.Parameters.AddWithValue("@MaNguoiDat", MaNguoiDat);

                // Thực thi câu truy vấn và lấy dữ liệu
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("TONG_TIEN_DICH_VU")))
                    {
                        tienDV = reader.GetDecimal(reader.GetOrdinal("TONG_TIEN_DICH_VU"));
                    }
                }

                // Đóng kết nối
                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }

            return tienDV;
        }

        public decimal tinhTienCoc(int MaNguoiDat)
        {
            decimal tienCoc = 0;

            try
            {
                // Mở kết nối
                _conn.Open();

                // Tạo câu truy vấn
                string SQL = "SELECT PHIEUDATPHONG.TIENCOC FROM PHIEUDATPHONG\r\nJOIN PHIEUNHANPHONG ON PHIEUNHANPHONG.MADATPHONG = PHIEUDATPHONG.MADP\r\nWHERE PHIEUDATPHONG.NGUOIDAT = @MaNguoiDat";

                // Tạo đối tượng Command
                SqlCommand cmd = new SqlCommand(SQL, _conn);

                // Thêm tham số cho câu truy vấn
                cmd.Parameters.AddWithValue("@MaNguoiDat", MaNguoiDat);

                // Thực thi câu truy vấn và lấy dữ liệu
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tienCoc = reader.GetDecimal(reader.GetOrdinal("TIENCOC"));
                }

                // Đóng kết nối
                reader.Close();
            }
            catch (Exception e)
            {

            }
            finally
            {
                // Đóng kết nối
                _conn.Close();
            }

            return tienCoc;
        }
        public bool themHOADON(DTO_HOADON hdon)
        {
            try
            {
                // Ket noi
                _conn.Open();

                string SQL = string.Format("INSERT INTO HOADON(MAHOADON, MATP, THOIDIEMTHANHTOAN, HINHTHUCTHANHTOAN, TIENCOC, TONGTIEN, NGUOILAPHOADON)" + " VALUES ('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}')", hdon.MAHOADON, hdon.MATP, hdon.THOIDIEMTHANHTOAN, hdon.HINHTHUCTHANHTOAN, hdon.TIENCOC, hdon.TONGTIEN, hdon.NGUOILAPHOADON);

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
        public bool suaHOADON(DTO_HOADON hdon)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string 
                string SQL = string.Format("UPDATE HOADON SET MATP = '{0}' THOIDIEMTHANHTOAN = '{1}' HINHTHUCTHANHTOAN = '{2}' TIENCOC = '{3}' TONGTIEN = '{4}' NGUOILAPHOADON = '{5}'WHERE MAHOADON = {6} ", hdon.MATP, hdon.THOIDIEMTHANHTOAN, hdon.HINHTHUCTHANHTOAN, hdon.TIENCOC, hdon.TONGTIEN, hdon.NGUOILAPHOADON, hdon.MAHOADON);
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
        /// <param name="hdon"></param>
        /// <returns></returns>
        public bool xoaHOADON(int MAHOADON)
        {
            try
            {
                // Ket noi
                _conn.Open();

                // Query string - vì xóa chỉ cần ID nên chúng ta ko cần 1 DTO, ID là đủ
                string SQL = string.Format("DELETE FROM HOADON WHERE MAHOADON = {0})", MAHOADON);

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