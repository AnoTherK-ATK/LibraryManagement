using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using DoAn.DTO;

namespace DoAn.BUS
{
    class BUS_Sach
    {
        DAL_Sach DAL_Sach = new DAL.DAL_Sach();
        DAL_ThamSo DAL_ThamSo = new DAL_ThamSo();
        internal List<DTO_Sach> LayDanhSachSach()
        {
            return DAL_Sach.LayDanhSachSach();
        }

        public bool ThemSach(DTO_Sach sach)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(sach.MaSach) ||
                string.IsNullOrWhiteSpace(sach.TenSach) ||
                string.IsNullOrWhiteSpace(sach.MaTheLoai) ||
                string.IsNullOrWhiteSpace(sach.TacGia) ||
                string.IsNullOrWhiteSpace(sach.NamXuatBan) ||
                string.IsNullOrWhiteSpace(sach.NhaXuatBan) ||
                string.IsNullOrWhiteSpace(sach.ngayNhapStr) ||
                sach.TriGia <= 0 ||
                string.IsNullOrWhiteSpace(sach.MaNhanVien))
            {
                throw new Exception("Các trường không được để trống và Tri giá phải lớn hơn 0");
            }

            int ThoiGianNhapSachToiDa = DAL_ThamSo.LayThoiGianNhapSachToiDa();
            if (DateTime.Now.Year - int.Parse(sach.NamXuatBan) > ThoiGianNhapSachToiDa)
            {
                throw new Exception("Chỉ nhận các sách xuất bản trong vòng " + ThoiGianNhapSachToiDa + " năm");
            }

            return DAL_Sach.ThemSach(sach);
        }

        public DTO_Sach LayThongTinSach(string maSach)
        {
            if (string.IsNullOrWhiteSpace(maSach))
            {
                throw new Exception("Mã sách không được để trống");
            }
            return DAL_Sach.LayThongTinSach(maSach);
        }

        public bool CapNhatSach(DTO_Sach sach)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(sach.MaSach) ||
                string.IsNullOrWhiteSpace(sach.TenSach) ||
                string.IsNullOrWhiteSpace(sach.MaTheLoai) ||
                string.IsNullOrWhiteSpace(sach.TacGia) ||
                string.IsNullOrWhiteSpace(sach.NamXuatBan) ||
                string.IsNullOrWhiteSpace(sach.NhaXuatBan) ||
                string.IsNullOrWhiteSpace(sach.ngayNhapStr) ||
                sach.TriGia <= 0 ||
                string.IsNullOrWhiteSpace(sach.MaNhanVien))
            {
                throw new Exception("Các trường không được để trống và Trị giá phải lớn hơn 0");
            }
            int ThoiGianNhapSachToiDa = DAL_ThamSo.LayThoiGianNhapSachToiDa();
            if (DateTime.Now.Year - int.Parse(sach.NamXuatBan) > ThoiGianNhapSachToiDa)
            {
                throw new Exception("Chỉ nhận các sách xuất bản trong vòng " + ThoiGianNhapSachToiDa + " năm");
            }
            return DAL_Sach.CapNhatSach(sach);
        }

        public bool XoaSach(string maSach)
        {
            if (string.IsNullOrWhiteSpace(maSach))
            {
                throw new Exception("Mã sách không được để trống");
            }
            return DAL_Sach.XoaSach(maSach);
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
            return DAL_Sach.TimKiemSach(
                maSach,
                tenSach,
                tacGia,
                namXuatBan,
                nhaXuatBan,
                maNhanVien,
                maTheLoai,
                ngayNhapTu,
                ngayNhapDen,
                triGiaTu,
                triGiaDen
            );
        }
    }
}
