using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using DoAn.DTO;

namespace DoAn.BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien DAL_NhanVien = new DAL_NhanVien();
        internal List<DTO_NhanVien> LayDanhSachNhanVien()
        {
            return DAL_NhanVien.LayDanhSachNhanVien();
        }
        Dictionary<string, string> chucVuMap = new Dictionary<string, string>
        {
            { "CV01", "Giám Đốc" },
            { "CV02", "Phó Giám Đốc" },
            { "CV03", "Trưởng Phòng" },
            { "CV04", "Phó Phòng" },
            { "CV05", "Nhân Viên" }
        };

        // Map for BOPHAN (Department ID to Department Name)
        Dictionary<string, string> boPhanMap = new Dictionary<string, string>
        {
            { "BP01", "Thủ Thư" },
            { "BP02", "Thủ Kho" },
            { "BP03", "Thủ Quỹ" },
            { "BP04", "Ban Giám Đốc" }
        };

        public bool ThemNhanVien(DTO_NhanVien dto_NhanVien)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(dto_NhanVien.MaNhanVien) ||
                string.IsNullOrWhiteSpace(dto_NhanVien.TenNhanVien) ||
                string.IsNullOrWhiteSpace(dto_NhanVien.DiaChiNhanVien) ||
                string.IsNullOrWhiteSpace(dto_NhanVien.SoDienThoaiNhanVien) ||
                string.IsNullOrWhiteSpace(dto_NhanVien.MaBangCapNhanVien) ||
                string.IsNullOrWhiteSpace(dto_NhanVien.MaBoPhanNhanVien) ||
                string.IsNullOrWhiteSpace(dto_NhanVien.MaChucVuNhanVien))
            {
                throw new Exception("Các trường không được để trống");
            }

            //Ban giám đốc
            if(dto_NhanVien.MaBoPhanNhanVien == "BP04" && !(dto_NhanVien.MaChucVuNhanVien == "CV01" || dto_NhanVien.MaChucVuNhanVien == "CV02"))
            {
                throw new Exception("Chức vụ " + chucVuMap[dto_NhanVien.MaChucVuNhanVien] + " không phù hợp với Bộ phận Ban giám đốc");
            }

            if (dto_NhanVien.MaBoPhanNhanVien != "BP04" && (dto_NhanVien.MaChucVuNhanVien == "CV01" || dto_NhanVien.MaChucVuNhanVien == "CV02"))
            {
                throw new Exception("Chức vụ " + chucVuMap[dto_NhanVien.MaChucVuNhanVien] + " không phù hợp với Bộ phận " + boPhanMap[dto_NhanVien.MaBoPhanNhanVien]);
            }

            int tmp;
            if (dto_NhanVien.SoDienThoaiNhanVien[0] != '0' || int.TryParse(dto_NhanVien.SoDienThoaiNhanVien.Substring(1), out tmp) == false)
            {
                throw new Exception("Số điện thoại không hợp lệ");
            }
            return DAL_NhanVien.ThemNhanVien(dto_NhanVien) > 0;
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
            return DAL_NhanVien.TimKiemNhanVien(maNV, tenNV, sdtNV, bangCapNV, boPhanNV, chucVuNV);
        }

        internal List<string> LayTatCaMaNhanVien()
        {
            return DAL_NhanVien.LayTatCaMaNhanVien();
        }

        internal List<string> LayTatCaTenNhanVien()
        {
            return DAL_NhanVien.LayTatCaTenNhanVien();
        }

        internal DTO_NhanVien LayThongTinNhanVien(string maNV)
        {
            return DAL_NhanVien.LayThongTinNhanVien(maNV);
        }

        internal bool CapNhatNhanVien(DTO_NhanVien dto_NhanVien)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(dto_NhanVien.MaNhanVien) ||
                string.IsNullOrWhiteSpace(dto_NhanVien.TenNhanVien) ||
                string.IsNullOrWhiteSpace(dto_NhanVien.DiaChiNhanVien) ||
                string.IsNullOrWhiteSpace(dto_NhanVien.SoDienThoaiNhanVien) ||
                string.IsNullOrWhiteSpace(dto_NhanVien.MaBangCapNhanVien) ||
                string.IsNullOrWhiteSpace(dto_NhanVien.MaBoPhanNhanVien) ||
                string.IsNullOrWhiteSpace(dto_NhanVien.MaChucVuNhanVien))
            {
                throw new Exception("Các trường không được để trống");
            }
            int tmp;
            if (dto_NhanVien.SoDienThoaiNhanVien[0] != '0' || int.TryParse(dto_NhanVien.SoDienThoaiNhanVien.Substring(1), out tmp) == false)
            {
                throw new Exception("Số điện thoại không hợp lệ");
            }
            return DAL_NhanVien.CapNhatNhanVien(dto_NhanVien);
        }

        internal bool XoaNhanVien(string maNV)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(maNV))
            {
                throw new Exception("Mã nhân viên không được để trống");
            }
            return DAL_NhanVien.XoaNhanVien(maNV);
        }

        internal string LayTenNhanVien(string maNV)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(maNV))
            {
                throw new Exception("Mã nhân viên không được để trống");
            }
            DTO_NhanVien nhanVien = DAL_NhanVien.LayThongTinNhanVien(maNV);
            if (nhanVien == null)
            {
                throw new Exception("Không tìm thấy thông tin nhân viên với mã: " + maNV);
            }
            return nhanVien.TenNhanVien;
        }

        internal string LayMaBoPhanTheoTenNhanVien(string HoTen)
        {
            return DAL_NhanVien.LayMaBoPhanTheoTenNhanVien(HoTen);
        }
        internal string LayMaNhanVienTheoTenNhanVien(string HoTen)
        {
            return DAL_NhanVien.LayMaNhanVienTheoTenNhanVien(HoTen);
        }
    }

}
