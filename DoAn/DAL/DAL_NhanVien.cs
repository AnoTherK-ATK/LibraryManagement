using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DTO;
using MySqlConnector;

namespace DoAn.DAL
{
    public class DAL_NhanVien
    {
        DataHelper helper = new DataHelper();

        internal List<DTO_NhanVien> LayDanhSachNhanVien()
        {
            DataTable dtNhanVien = helper.ExecuteQuery("SELECT MaNhanVien, HoTen, DiaChi, DATE_FORMAT(NgaySinh, '%d/%m/%Y') AS NgaySinh, DienThoai, MaBangCap, MaBoPhan, MaChucVu FROM NHANVIEN");

            List<DTO_NhanVien> listNhanVien = new List<DTO_NhanVien>();

            foreach (DataRow dr in dtNhanVien.Rows)
            {
                DTO_NhanVien NhanVienTemp = new DTO_NhanVien(
                    dr["MaNhanVien"].ToString(),
                    dr["HoTen"].ToString(),
                    dr["DiaChi"].ToString(),
                    dr["NgaySinh"].ToString(),
                    dr["DienThoai"].ToString(),
                    dr["MaBangCap"].ToString(),
                    dr["MaBoPhan"].ToString(),
                    dr["MaChucVu"].ToString()
                );
                listNhanVien.Add(NhanVienTemp);
            }

            return listNhanVien;
        }

        internal int ThemNhanVien(DTO_NhanVien dto_NhanVien)
        {
            string query = @"
            INSERT INTO NHANVIEN (
                MaNhanVien, 
                HoTen, 
                DiaChi, 
                NgaySinh, 
                DienThoai, 
                MaBangCap, 
                MaBoPhan, 
                MaChucVu
            ) VALUES (
                @MaNhanVien, 
                @HoTen, 
                @DiaChi, 
                @NgaySinh, 
                @DienThoai, 
                @MaBangCap, 
                @MaBoPhan, 
                @MaChucVu
            )";

            try
            {
                using (var conn = helper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@MaNhanVien", dto_NhanVien.MaNhanVien);
                        cmd.Parameters.AddWithValue("@HoTen", dto_NhanVien.TenNhanVien);
                        cmd.Parameters.AddWithValue("@DiaChi", dto_NhanVien.DiaChiNhanVien);
                        cmd.Parameters.AddWithValue("@NgaySinh", dto_NhanVien.ngaySinhNhanVien);
                        cmd.Parameters.AddWithValue("@DienThoai", dto_NhanVien.SoDienThoaiNhanVien);
                        cmd.Parameters.AddWithValue("@MaBangCap", dto_NhanVien.MaBangCapNhanVien);
                        cmd.Parameters.AddWithValue("@MaBoPhan", dto_NhanVien.MaBoPhanNhanVien);
                        cmd.Parameters.AddWithValue("@MaChucVu", dto_NhanVien.MaChucVuNhanVien);

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle or throw exception as per your needs
                throw new Exception("Error inserting employee: " + ex.Message);
            }
        }

        internal List<DTO_NhanVien> TimKiemNhanVien(
            string maNV,
            string tenNV,
            string sdtNV,
            string bangCapNV,
            string boPhanNV,
            string chucVuNV
        )
        {

            List<DTO_NhanVien> listNhanVien = new List<DTO_NhanVien>();
            List<DTO_NhanVien> listNhanVienTemp = LayDanhSachNhanVien();
            listNhanVien = listNhanVienTemp.Where(nv =>
                (string.IsNullOrEmpty(maNV) || nv.MaNhanVien.Contains(maNV)) &&
                (string.IsNullOrEmpty(tenNV) || nv.TenNhanVien.Contains(tenNV)) &&
                (string.IsNullOrEmpty(sdtNV) || nv.SoDienThoaiNhanVien.Contains(sdtNV)) &&
                (string.IsNullOrEmpty(bangCapNV) || nv.MaBangCapNhanVien.Contains(bangCapNV)) &&
                (string.IsNullOrEmpty(boPhanNV) || nv.MaBoPhanNhanVien.Contains(boPhanNV)) &&
                (string.IsNullOrEmpty(chucVuNV) || nv.MaChucVuNhanVien.Contains(chucVuNV))
            ).ToList();
            return listNhanVien;
        }

        internal List<string> LayTatCaMaNhanVien()
        {
           string query = "SELECT MaNhanVien FROM NHANVIEN";
            DataTable dtMaNhanVien = helper.ExecuteQuery(query);
            List<string> listMaNhanVien = new List<string>();
            foreach (DataRow dr in dtMaNhanVien.Rows)
            {
                listMaNhanVien.Add(dr["MaNhanVien"].ToString());
            }
            return listMaNhanVien;
        }

        internal List<string> LayTatCaTenNhanVien()
        {
            string query = "SELECT HoTen FROM NHANVIEN";
            DataTable dtHoTen = helper.ExecuteQuery(query);
            List<string> listHoTen = new List<string>();
            foreach (DataRow dr in dtHoTen.Rows)
            {
                listHoTen.Add(dr["HoTen"].ToString());
            }
            return listHoTen;
        }

        internal string LayMaBoPhanTheoTenNhanVien(string HoTen)
        {
            string query = $"SELECT MaBoPhan FROM NHANVIEN WHERE HoTen = '{HoTen}'";
            DataTable dtMaBoPhan = helper.ExecuteQuery(query);
            if (dtMaBoPhan.Rows.Count > 0)
            {
                return dtMaBoPhan.Rows[0]["MaBoPhan"].ToString();
            }
            return null;
        }

        internal string LayMaNhanVienTheoTenNhanVien(string HoTen)
        {
            string query = $"SELECT MaNhanVien FROM NHANVIEN WHERE HoTen = '{HoTen}'";
            DataTable dtNV = helper.ExecuteQuery(query);
            if (dtNV.Rows.Count > 0)
            {
                return dtNV.Rows[0]["MaNhanVien"].ToString();
            }
            return null;
        }


        internal DTO_NhanVien LayThongTinNhanVien(string maNV)
        {
            string query = $"SELECT MaNhanVien, HoTen, DiaChi, DATE_FORMAT(NgaySinh, '%d/%m/%Y') AS NgaySinh, DienThoai, MaBangCap, MaBoPhan, MaChucVu FROM NHANVIEN WHERE MaNhanVien = '{maNV}'";
            DataTable dtNhanVien = helper.ExecuteQuery(query);
            if (dtNhanVien.Rows.Count > 0)
            {
                DataRow dr = dtNhanVien.Rows[0];
                return new DTO_NhanVien(
                    dr["MaNhanVien"].ToString(),
                    dr["HoTen"].ToString(),
                    dr["DiaChi"].ToString(),
                    dr["NgaySinh"].ToString(),
                    dr["DienThoai"].ToString(),
                    dr["MaBangCap"].ToString(),
                    dr["MaBoPhan"].ToString(),
                    dr["MaChucVu"].ToString()
                );
            }
            return null;
        }

        internal bool CapNhatNhanVien(DTO_NhanVien dto_NhanVien)
        {
            string query = @"
            UPDATE NHANVIEN SET 
                HoTen = @HoTen, 
                DiaChi = @DiaChi, 
                NgaySinh = @NgaySinh, 
                DienThoai = @DienThoai, 
                MaBangCap = @MaBangCap, 
                MaBoPhan = @MaBoPhan, 
                MaChucVu = @MaChucVu
            WHERE MaNhanVien = @MaNhanVien";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@MaNhanVien", dto_NhanVien.MaNhanVien);
                        cmd.Parameters.AddWithValue("@HoTen", dto_NhanVien.TenNhanVien);
                        cmd.Parameters.AddWithValue("@DiaChi", dto_NhanVien.DiaChiNhanVien);
                        cmd.Parameters.AddWithValue("@NgaySinh", dto_NhanVien.ngaySinhNhanVien);
                        cmd.Parameters.AddWithValue("@DienThoai", dto_NhanVien.SoDienThoaiNhanVien);
                        cmd.Parameters.AddWithValue("@MaBangCap", dto_NhanVien.MaBangCapNhanVien);
                        cmd.Parameters.AddWithValue("@MaBoPhan", dto_NhanVien.MaBoPhanNhanVien);
                        cmd.Parameters.AddWithValue("@MaChucVu", dto_NhanVien.MaChucVuNhanVien);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle or throw exception as per your needs
                throw new Exception("Lỗi khi thêm nhân viên mới: " + ex.Message);
            }
        }

        internal bool XoaNhanVien(string maNV)
        {
            string query = $"DELETE FROM NHANVIEN WHERE MaNhanVien = '{maNV}'";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle or throw exception as per your needs
                throw new Exception("Lỗi khi xóa nhân viên: " + ex.Message);
            }
        }
    }
}
