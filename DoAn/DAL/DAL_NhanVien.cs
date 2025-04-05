using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DTO;

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

        internal void ThemNhanVien(DTO_NhanVien)
        {

        }

    }
}
