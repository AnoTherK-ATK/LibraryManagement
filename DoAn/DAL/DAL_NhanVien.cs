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
            DataTable dtNhanVien = helper.ExecuteQuery("SELECT * FROM NHANVIEN");

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
                listNhanVien.Add( NhanVienTemp );
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

    }
}
