using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    class DTO_Sach
    {
        string maSach;
        public string MaSach { get => maSach; set => maSach = value; }

        string tenSach;
        public string TenSach { get => tenSach; set => tenSach = value; }

        string tacGia;
        public string TacGia { get => tacGia; set => tacGia = value; }

        string namXuatBan;
        public string NamXuatBan { get => namXuatBan; set => namXuatBan = value; }

        string nhaXuatBan;
        public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }

        public DateTime ngayNhap { get; set; }
        public string ngayNhapStr
        {
            get => ngayNhap.ToString("dd/MM/yyyy");
            set
            {
                if (DateTime.TryParseExact(value, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                {
                    ngayNhap = parsedDate;
                }
            }
        }

        int triGia;
        public int TriGia { get => triGia; set => triGia = value; }

        string tinhTrang;
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        // Foreign keys
        string maTheLoai;
        public string MaTheLoai { get => maTheLoai; set => maTheLoai = value; }

        string maNhanVien;
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }

        public DTO_Sach(
            string maSach, 
            string tenSach, 
            string maTheLoai, 
            string tacGia, 
            string namXuatBan, 
            string nhaXuatBan, 
            string ngayNhapStr, 
            int triGia, 
            string maNhanVien,
            string tinhTrang)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.maTheLoai = maTheLoai;
            this.tacGia = tacGia;
            this.namXuatBan = namXuatBan;
            this.nhaXuatBan = nhaXuatBan;
            this.ngayNhapStr = ngayNhapStr;
            this.triGia = triGia;
            this.maNhanVien = maNhanVien;
            this.tinhTrang = tinhTrang;
        }
    }
}
