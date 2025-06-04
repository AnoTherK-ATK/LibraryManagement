using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DoAn.DTO;
using MySqlConnector;
namespace DoAn.DAL
{
    internal class DAL_TheDocGia
    {
        DataHelper helper = new DataHelper();
        internal List<DTO_TheDocGia> LayDanhSachTheDocGia()
        {
            string query = "SELECT MaDocGia, HoTen, DATE_FORMAT(NgaySinh, '%d/%m/%Y') AS NgaySinh, DiaChi, Email, DATE_FORMAT(NgayLapThe, '%d/%m/%Y') AS NgayLapThe, DATE_FORMAT(NgayHetHan, '%d/%m/%Y') AS NgayHetHan, MaLoaiDocGia, MaNhanVien FROM THEDOCGIA";

            DataTable dtTheDocGia = helper.ExecuteQuery(query);
            List<DTO_TheDocGia> listTheDocGia = new List<DTO_TheDocGia>();
            foreach (DataRow dr in dtTheDocGia.Rows)
            {
                DTO_TheDocGia theDocGiaTemp = new DTO_TheDocGia(
                    dr["MaDocGia"].ToString(),
                    dr["HoTen"].ToString(),
                    dr["DiaChi"].ToString(),
                    dr["NgaySinh"].ToString(),
                    dr["Email"].ToString(),
                    dr["NgayLapThe"].ToString(),
                    dr["NgayHetHan"].ToString(),
                    dr["MaLoaiDocGia"].ToString(),
                    dr["MaNhanVien"].ToString()

                );

                listTheDocGia.Add(theDocGiaTemp);
            }
            return listTheDocGia;
        }

        internal int ThemTheDocGia(DTO_TheDocGia dto_TheDocGia)
        {
            string query = @"
            INSERT INTO THEDOCGIA (
                MaDocGia, 
                HoTen, 
                DiaChi, 
                NgaySinh, 
                Email, 
                NgayLapThe, 
                NgayHetHan, 
                MaLoaiDocGia, 
                MaNhanVien
            ) VALUES (
                @MaDocGia, 
                @HoTen, 
                @DiaChi, 
                @NgaySinh, 
                @Email, 
                @NgayLapThe, 
                @NgayHetHan, 
                @MaLoaiDocGia, 
                @MaNhanVien
            )";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDocGia", dto_TheDocGia.MaDocGia);
                        cmd.Parameters.AddWithValue("@HoTen", dto_TheDocGia.HoTenDocGia);
                        cmd.Parameters.AddWithValue("@DiaChi", dto_TheDocGia.DiaChiDocGia);
                        cmd.Parameters.AddWithValue("@NgaySinh", dto_TheDocGia.NgaySinhDocGia);
                        cmd.Parameters.AddWithValue("@Email", dto_TheDocGia.EmailDocGia);
                        cmd.Parameters.AddWithValue("@NgayLapThe", dto_TheDocGia.NgayLapThe);
                        cmd.Parameters.AddWithValue("@NgayHetHan", dto_TheDocGia.NgayHetHan);
                        cmd.Parameters.AddWithValue("@MaLoaiDocGia", dto_TheDocGia.MaLoaiDocGia);
                        cmd.Parameters.AddWithValue("@MaNhanVien", dto_TheDocGia.MaNhanVien);
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm thẻ độc giả mới: " + ex.Message);
            }

        }

        internal List<String> LayTatCaMaDocGia()
        {
            string query = "SELECT MaDocGia FROM THEDOCGIA";
            DataTable dtMaDocGia = helper.ExecuteQuery(query);
            List<string> listMaDocGia = new List<string>();
            foreach (DataRow dr in dtMaDocGia.Rows)
            {
                listMaDocGia.Add(dr["MaDocGia"].ToString());
            }
            return listMaDocGia;
        }

        internal List<string> LayTatCaTenDocGia(int TongNo = -1)
        {
            string query = $"SELECT HoTen FROM THEDOCGIA WHERE CURRENT_DATE() < NgayHetHan AND TongNo > {TongNo}";
            DataTable dtTenDocGia = helper.ExecuteQuery(query);
            List<string> listTenDocGia = new List<string>();
            foreach (DataRow dr in dtTenDocGia.Rows)
            {
                listTenDocGia.Add(dr["HoTen"].ToString());
            }
            return listTenDocGia;
        }

        internal string LayMaDocGiaTheoTenDocGia(string TenDocGia)
        {
            string query = @"
                SELECT MaDocGia 
                FROM THEDOCGIA 
                WHERE HoTen = @TenDocGia AND CURRENT_DATE() < NgayHetHan
            ";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "@TenDocGia", TenDocGia }
            };

            object result = helper.ExecuteScalar(query, parameters);

            if (result != null)
                return result.ToString();
            else
                return null; // hoặc trả "" nếu muốn
        }

        internal string LayTenDocGiaTheoMaDocGia(string MaDocGia)
        {
            string query = @"
                SELECT HoTen 
                FROM THEDOCGIA 
                WHERE MaDocGia = @MaDocGia AND CURRENT_DATE() < NgayHetHan
            ";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "@MaDocGia", MaDocGia }
            };

            object result = helper.ExecuteScalar(query, parameters);

            if (result != null)
                return result.ToString();
            else
                return null; // hoặc trả "" nếu muốn
        }



        // Add the missing declaration and initialization for 'listChucVu'.
        // Assuming 'listChucVu' is a list of DTO_ChucVu objects that can be retrieved from a DAL_ChucVu class.

        internal List<DTO_TheDocGia> TimKiemTheDocGia(
            string maDocGiaTDG,
            string hoTenTDG,
            string diaChiTDG,
            string ngaySinhTDG,
            string emailTDG,
            string ngayLapTheTDG,
            string ngayHetHanTDG,
            string maLoaiDocGiaTDG,
            string maNhanVien,
            string tenNhanVien
        )
        {
            List<DTO_TheDocGia> listTheDocGiaTemp = LayDanhSachTheDocGia();
            DAL_NhanVien dAL_NhanVien = new DAL_NhanVien();
            // Lấy danh sách nhân viên theo mã và tên
            List<DTO_NhanVien> listNhanVien = dAL_NhanVien.TimKiemNhanVien(maNhanVien, tenNhanVien, "", "", "", "");
            List<string> dsMaNhanVien = listNhanVien.Select(nv => nv.MaNhanVien).ToList();

            var ketQua = listTheDocGiaTemp.Where(tdg =>
                (listNhanVien.Count == 0 || dsMaNhanVien.Contains(tdg.MaNhanVien)) &&

                (string.IsNullOrEmpty(maDocGiaTDG) || tdg.MaDocGia.Contains(maDocGiaTDG)) &&
                (string.IsNullOrEmpty(hoTenTDG) || tdg.HoTenDocGia.Contains(hoTenTDG)) &&
                (string.IsNullOrEmpty(diaChiTDG) || tdg.DiaChiDocGia.Contains(diaChiTDG)) &&
                (string.IsNullOrEmpty(ngaySinhTDG) || tdg.NgaySinhDocGia.ToString("dd/MM/yyyy").Contains(ngaySinhTDG)) &&
                (string.IsNullOrEmpty(emailTDG) || tdg.EmailDocGia.Contains(emailTDG)) &&
                (string.IsNullOrEmpty(ngayLapTheTDG) || tdg.NgayLapThe.ToString("dd/MM/yyyy").Contains(ngayLapTheTDG)) &&
                (string.IsNullOrEmpty(ngayHetHanTDG) || tdg.NgayHetHan.ToString("dd/MM/yyyy").Contains(ngayHetHanTDG)) &&
                (string.IsNullOrEmpty(maLoaiDocGiaTDG) || tdg.MaLoaiDocGia.Contains(maLoaiDocGiaTDG))
            ).ToList();


            return ketQua;
        }

        internal DTO_TheDocGia LayThongTinTheDocGia(string maDocGia)
        {
            string query = $"SELECT MaDocGia,HoTen, DATE_FORMAT(NgaySinh, '%d/%m/%Y') AS NgaySinh, DiaChi, Email, DATE_FORMAT(NgayLapThe, '%d/%m/%Y') AS NgayLapThe, DATE_FORMAT(NgayHetHan, '%d/%m/%Y') AS NgayHetHan, MaLoaiDocGia, MaNhanVien,TongNo FROM THEDOCGIA WHERE MaDocGia = '{maDocGia}'";
            DataTable dtTheDocGia = helper.ExecuteQuery(query);
            if (dtTheDocGia.Rows.Count > 0)
            {
                DataRow dr = dtTheDocGia.Rows[0];
                return new DTO_TheDocGia(
                    dr["MaDocGia"].ToString(),
                    dr["HoTen"].ToString(),
                    dr["DiaChi"].ToString(),
                    dr["NgaySinh"].ToString(),
                    dr["Email"].ToString(),
                    dr["NgayLapThe"].ToString(),
                    dr["NgayHetHan"].ToString(),
                    dr["MaLoaiDocGia"].ToString(),
                    dr["MaNhanVien"].ToString(),
                    Convert.ToInt32(dr["TongNo"])

                );
            }
            return null;
        }
        


        internal bool CapNhatTheDocGia(DTO_TheDocGia dto_TheDocGia)
        {
            string query = @"
            UPDATE THEDOCGIA SET 
                HoTen = @HoTen, 
                DiaChi = @DiaChi, 
                NgaySinh = @NgaySinh, 
                Email = @Email, 
                NgayLapThe = @NgayLapThe, 
                NgayHetHan = @NgayHetHan, 
                MaLoaiDocGia = @MaLoaiDocGia, 
                MaNhanVien = @MaNhanVien 
            WHERE MaDocGia = @MaDocGia";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDocGia", dto_TheDocGia.MaDocGia);
                        cmd.Parameters.AddWithValue("@HoTen", dto_TheDocGia.HoTenDocGia);
                        cmd.Parameters.AddWithValue("@DiaChi", dto_TheDocGia.DiaChiDocGia);
                        cmd.Parameters.AddWithValue("@NgaySinh", dto_TheDocGia.NgaySinhDocGia);
                        cmd.Parameters.AddWithValue("@Email", dto_TheDocGia.EmailDocGia);
                        cmd.Parameters.AddWithValue("@NgayLapThe", dto_TheDocGia.NgayLapThe);
                        cmd.Parameters.AddWithValue("@NgayHetHan", dto_TheDocGia.NgayHetHan);
                        cmd.Parameters.AddWithValue("@MaLoaiDocGia", dto_TheDocGia.MaLoaiDocGia);
                        cmd.Parameters.AddWithValue("@MaNhanVien", dto_TheDocGia.MaNhanVien);
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thẻ độc giả: " + ex.Message);
            }
        }


        internal bool XoaTheDocGia(string maDocGia)
        {
            string query = "DELETE FROM THEDOCGIA WHERE MaDocGia = @MaDocGia";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaDocGia", maDocGia);
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa thẻ độc giả: " + ex.Message);
            }
        }

        internal bool CapNhatTongNo(string MaDocGia, float TongNo)
        {
            string query = @"
            UPDATE THEDOCGIA SET 
                TongNo = @TongNo
            WHERE MaDocGia = @MaDocGia";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TongNo", TongNo);
                        cmd.Parameters.AddWithValue("@MaDocGia", MaDocGia);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thẻ độc giả: " + ex.Message);
            }
        }
    }
}
