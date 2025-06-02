using DoAn.DAL;
using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    internal class BUS_TheDocGia
    {
        DAL.DAL_TheDocGia dal_TheDocGia = new DAL.DAL_TheDocGia();
        internal List<DTO.DTO_TheDocGia> LayDanhSachTheDocGia()
        {
            return dal_TheDocGia.LayDanhSachTheDocGia();
        }
        
        internal List<string> LayTatCaMaDocGia()
        {
            return dal_TheDocGia.LayTatCaMaDocGia();
        }

        internal List<string> LayTatCaTenDocGia()
        {
            return dal_TheDocGia.LayTatCaTenDocGia();
        }
        internal string LayMaDocGiaTheoTenDocGia(string TenDocGia)
        {
            return dal_TheDocGia.LayMaDocGiaTheoTenDocGia(TenDocGia);
        }
        internal string LayTenDocGiaTheoMaDocGia(string MaDocGia)
        {
            return dal_TheDocGia.LayTenDocGiaTheoMaDocGia(MaDocGia);
        }

        internal List<string> LayTatCaTenDocGiaTheoMaDocGia(List<string> danhsachMaDocGia)
        {
            List<string> danhSachTenDocGia = new List<string>();
            foreach (var ma in danhsachMaDocGia)
            {
                var ten = LayTenDocGiaTheoMaDocGia(ma);
                if (!string.IsNullOrEmpty(ten))
                {
                    danhSachTenDocGia.Add(ten);
                }
            }
            return danhSachTenDocGia;
        }


        Dictionary<string, string> loaiDocGia = new Dictionary<string, string>
        {

            { "LDG01", "X" },
            { "LDG02", "Y" }
        };
           

        public bool ThemTheDocGia(DTO.DTO_TheDocGia dto_TheDocGia)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(dto_TheDocGia.MaDocGia) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.HoTenDocGia) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.DiaChiDocGia) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.NgaySinhDocGia.ToString()) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.EmailDocGia) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.NgayLapThe.ToString()) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.NgayHetHan.ToString()) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.MaLoaiDocGia) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.MaNhanVien))
            {
                throw new Exception("Các trường không được để trống");
            }
            // Kiểm tra loại độc giả
            if (!loaiDocGia.ContainsKey(dto_TheDocGia.MaLoaiDocGia))
            {
                throw new Exception("Mã loại độc giả không hợp lệ");
            }
            return dal_TheDocGia.ThemTheDocGia(dto_TheDocGia) > 0;
        }


        internal List<DTO.DTO_TheDocGia> TimKiemTheDocGia(
            string maTDG,
            string hoTenTDG,
            string diaChiTDG,
            string ngaySinhTDG,
            string emailTDG,
            string ngayLapTheTDG,
            string ngayHetHanTDG,
            string maLoaiDocGiaTDG,
            string maNhanVienTDG,
            string tenNhanVienTDG
        )
        {
            return dal_TheDocGia.TimKiemTheDocGia(
                maTDG,
                hoTenTDG,
                diaChiTDG,
                ngaySinhTDG,
                emailTDG,
                ngayLapTheTDG,
                ngayHetHanTDG,
                maLoaiDocGiaTDG,
                maNhanVienTDG,
                tenNhanVienTDG
            );
        }

        internal DTO_TheDocGia LayThongTinTheDocGia(string maTDG)
        {
            return dal_TheDocGia.LayThongTinTheDocGia(maTDG);
        }

        //internal DTO_TheDocGia LayNgayHetHan(string tenTDG)
        //{
        //    return dal_TheDocGia.LayNgayHetHan(tenTDG);
        //}


        internal bool CapNhatTheDocGia(DTO.DTO_TheDocGia dto_TheDocGia)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(dto_TheDocGia.MaDocGia) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.HoTenDocGia) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.DiaChiDocGia) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.NgaySinhDocGia.ToString()) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.EmailDocGia) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.NgayLapThe.ToString()) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.NgayHetHan.ToString()) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.MaLoaiDocGia) ||
                string.IsNullOrWhiteSpace(dto_TheDocGia.MaNhanVien))
            {
                throw new Exception("Các trường không được để trống");
            }

       
            return dal_TheDocGia.CapNhatTheDocGia(dto_TheDocGia);
        }




        internal bool XoaTheDocGia(string maTheDocGia)
        {
            if (string.IsNullOrWhiteSpace(maTheDocGia))
            {
                throw new Exception("Mã thẻ độc giả không được để trống");
            }
            return dal_TheDocGia.XoaTheDocGia(maTheDocGia);
        }

        internal bool CapNhatTongNo(string MaDocGia, float TongNo)
        {
            return dal_TheDocGia.CapNhatTongNo(MaDocGia, TongNo);
        }
    }
}
