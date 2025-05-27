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

        public bool ThemSach(DTO_Sach sach)
        {
            string query = "INSERT INTO SACH (MaSach, TenSach, MaTheLoai, TacGia, NamXuatBan, NhaXuatBan, NgayNhap, TriGia, MaNhanVien) " +
                           "VALUES (@MaSach, @TenSach, @MaTheLoai, @TacGia, @NamXuatBan, @NhaXuatBan, @NgayNhap @TriGia, @MaNhanVien)";
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
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm sách: " + ex.Message);
            }
        }
    }
}
