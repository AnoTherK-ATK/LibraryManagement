using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DoAn.DTO;
using MySqlConnector;

namespace DoAn.DAL
{
    class DAL_Sach
    {
        DataHelper helper = new DataHelper();

        internal List<DTO_Sach> LayDanhSachSach()
        {
            DataTable dtSach = helper.ExecuteQuery("SELECT MaSach, TenSach, MaTheLoai, TacGia, NamXuatBan, NhaXuatBan, DATE_FORMAT(NgayNhap, '%d/%m/%Y') as NgayNhap, TriGia, MaNhanVien, TinhTrang FROM SACH");
            List<DTO_Sach> listSach = new List<DTO_Sach>();
            foreach (DataRow dr in dtSach.Rows)
            {
                DTO_Sach SachTemp = new DTO_Sach(
                    dr["MaSach"].ToString(),
                    dr["TenSach"].ToString(),
                    dr["MaTheLoai"].ToString(),
                    dr["TacGia"].ToString(),
                    dr["NamXuatBan"].ToString(),
                    dr["NhaXuatBan"].ToString(),
                    dr["NgayNhap"].ToString(),
                    Convert.ToInt32(dr["TriGia"]),
                    dr["MaNhanVien"].ToString(),
                    dr["TinhTrang"].ToString()
                );
                listSach.Add(SachTemp);
            }
            return listSach;
        }

        internal bool ThemSach(DTO_Sach sach)
        {
            string query = "INSERT INTO SACH (MaSach, TenSach, MaTheLoai, TacGia, NamXuatBan, NhaXuatBan, NgayNhap, TriGia, MaNhanVien, TinhTrang) " +
                           "VALUES (@MaSach, @TenSach, @MaTheLoai, @TacGia, @NamXuatBan, @NhaXuatBan, @NgayNhap, @TriGia, @MaNhanVien, 'Chưa mượn')";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", sach.MaSach);
                        cmd.Parameters.AddWithValue("@TenSach", sach.TenSach);
                        cmd.Parameters.AddWithValue("@MaTheLoai", sach.MaTheLoai);
                        cmd.Parameters.AddWithValue("@TacGia", sach.TacGia);
                        cmd.Parameters.AddWithValue("@NamXuatBan", sach.NamXuatBan);
                        cmd.Parameters.AddWithValue("@NhaXuatBan", sach.NhaXuatBan);
                        cmd.Parameters.AddWithValue("@NgayNhap", sach.ngayNhap);
                        cmd.Parameters.AddWithValue("@TriGia", sach.TriGia);
                        cmd.Parameters.AddWithValue("@MaNhanVien", sach.MaNhanVien);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm sách: " + ex.Message);
            }
        }

        internal DTO_Sach LayThongTinSach(string maSach)
        {
            string query = "SELECT MaSach, TenSach, MaTheLoai, TacGia, NamXuatBan, NhaXuatBan, DATE_FORMAT(NgayNhap, '%d/%m/%Y') as NgayNhap, TriGia, MaNhanVien, TinhTrang FROM SACH WHERE MaSach = @MaSach";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", maSach);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new DTO_Sach(
                                    reader["MaSach"].ToString(),
                                    reader["TenSach"].ToString(),
                                    reader["MaTheLoai"].ToString(),
                                    reader["TacGia"].ToString(),
                                    reader["NamXuatBan"].ToString(),
                                    reader["NhaXuatBan"].ToString(),
                                    reader["NgayNhap"].ToString(),
                                    Convert.ToInt32(reader["TriGia"]),
                                    reader["MaNhanVien"].ToString(),
                                    reader["TinhTrang"].ToString()
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy thông tin sách: " + ex.Message);
            }
            return null;
        }

        internal bool CapNhatTinhTrangSach(string maSach, string tinhTrang = "Đã mượn")
        {
            string query = "UPDATE SACH SET TinhTrang = @TinhTrang WHERE MaSach = @MaSach";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", maSach);
                        cmd.Parameters.AddWithValue("@TinhTrang", tinhTrang);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật tình trạng sách: " + ex.Message);
            }
        }

        internal bool CapNhatSach(DTO_Sach sach)
        {
            string query = @"
            UPDATE SACH SET 
                TenSach = @TenSach, 
                MaTheLoai = @MaTheLoai, 
                TacGia = @TacGia, 
                NamXuatBan = @NamXuatBan, 
                NhaXuatBan = @NhaXuatBan, 
                NgayNhap = @NgayNhap, 
                TriGia = @TriGia, 
                MaNhanVien = @MaNhanVien,
                TinhTrang = @TinhTrang
            WHERE MaSach = @MaSach";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", sach.MaSach);
                        cmd.Parameters.AddWithValue("@TenSach", sach.TenSach);
                        cmd.Parameters.AddWithValue("@MaTheLoai", sach.MaTheLoai);
                        cmd.Parameters.AddWithValue("@TacGia", sach.TacGia);
                        cmd.Parameters.AddWithValue("@NamXuatBan", sach.NamXuatBan);
                        cmd.Parameters.AddWithValue("@NhaXuatBan", sach.NhaXuatBan);
                        cmd.Parameters.AddWithValue("@NgayNhap", sach.ngayNhapStr);
                        cmd.Parameters.AddWithValue("@TriGia", sach.TriGia);
                        cmd.Parameters.AddWithValue("@MaNhanVien", sach.MaNhanVien);
                        cmd.Parameters.AddWithValue("@TinhTrang", sach.TinhTrang);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật sách: " + ex.Message);
            }
        }
        internal bool XoaSach(string maSach)
        {
            string query = "DELETE FROM SACH WHERE MaSach = @MaSach";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSach", maSach);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xóa sách: " + ex.Message);
            }
        }

        private int DateCompare_ddMMyyyy(DateTime a, DateTime b)
        {
            if (a.Year != b.Year)
                return a.Year.CompareTo(b.Year);
            if (a.Month != b.Month)
                return a.Month.CompareTo(b.Month);
            return a.Day.CompareTo(b.Day);
        }

        internal List<DTO_Sach> TimKiemSach(
            string maSach,
            string tenSach,
            string tacGia,
            string namXuatBan,
            string nhaXuatBan,
            string maNhanVien,
            string maTheLoai,
            DateTime? ngayNhapTu,
            DateTime? ngayNhapDen,
            int? triGiaTu,
            int? triGiaDen
        )
        {
            List<DTO_Sach> danhSachSach = LayDanhSachSach();

            var ketQua = danhSachSach.Where(s =>
                (string.IsNullOrEmpty(maSach) || s.MaSach.Contains(maSach)) &&
                (string.IsNullOrEmpty(tenSach) || s.TenSach.Contains(tenSach)) &&
                (string.IsNullOrEmpty(tacGia) || s.TacGia.Contains(tacGia)) &&
                (string.IsNullOrEmpty(namXuatBan) || s.NamXuatBan.Contains(namXuatBan)) &&
                (string.IsNullOrEmpty(nhaXuatBan) || s.NhaXuatBan.Contains(nhaXuatBan)) &&
                (string.IsNullOrEmpty(maNhanVien) || s.MaNhanVien.Contains(maNhanVien)) &&
                (string.IsNullOrEmpty(maTheLoai) || s.MaTheLoai.Contains(maTheLoai)) &&
                (!ngayNhapTu.HasValue || DateCompare_ddMMyyyy(s.ngayNhap, ngayNhapTu.Value) >= 0) &&
                (!ngayNhapDen.HasValue || DateCompare_ddMMyyyy(s.ngayNhap, ngayNhapDen.Value) <= 0) &&
                (!triGiaTu.HasValue || s.TriGia >= triGiaTu.Value) &&
                (!triGiaDen.HasValue || s.TriGia <= triGiaDen.Value)
            ).ToList();

            return ketQua;
        }

        internal List<string> LayTenSachTheoListMaSach(List<string> listMaSach)
        {
            string danhSachMaSachText = string.Join("','", listMaSach);
            string query = $"SELECT TenSach FROM SACH WHERE  MaSach IN ('{danhSachMaSachText}')";

            DataTable dtTenSach = helper.ExecuteQuery(query);
            List<string> listTenSach = new List<string>();
            foreach (DataRow dr in dtTenSach.Rows)
            {
                listTenSach.Add(dr["TenSach"].ToString());
            }
            //List<string> fruits = new List<string> { "Mango", "Pineapple", "Grapes" };
            return listTenSach;
        }

        internal string LayMaSachTheoTenSach(string TenSach)
        {
            string query = @"
                SELECT MaSach 
                FROM SACH 
                WHERE TenSach = @TenSach
            ";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                { "@TenSach", TenSach }
            };

            object result = helper.ExecuteScalar(query, parameters);

            if (result != null)
                return result.ToString();
            else
                return null; // hoặc trả "" nếu muốn
        }
    }
}
