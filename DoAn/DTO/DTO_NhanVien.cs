using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    public class DTO_NhanVien
    {
        string maNhanVien;
        public string MaLoaiNhanVien { get => maNhanVien; set => maNhanVien = value; }
        
        string tenNhanVien;
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }

        string diaChiNhanVien;
        public string DiaChiNhanVien { get => diaChiNhanVien; set => diaChiNhanVien = value; }

        string soDienThoaiNhanVien;
        public string SoDienThoaiNhanVien { get => soDienThoaiNhanVien; set => soDienThoaiNhanVien = value; }

        //Foreign keys
        string maBangCapNhanVien;
        public string MaBangCapNhanVien { get => maBangCapNhanVien; set => maBangCapNhanVien = value; }

        string maBoPhanNhanVien;
        public string MaBoPhanNhanVien { get => maBoPhanNhanVien; set => maBoPhanNhanVien = value; }

        string maChucVuNhanVien;
        public string MaChucVuNhanVien { get => maChucVuNhanVien; set => maChucVuNhanVien = value; }

        public DateTime ngaySinhNhanVien { get; set; }
        public string ngaySinhNhanVienStr
        {
            get => ngaySinhNhanVien.ToString("dd/MM/yyyy");
            set
            {
                if(DateTime.TryParseExact(value, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                {
                    ngaySinhNhanVien = parsedDate;
                }
            }
        }

        public DTO_NhanVien(
            string maNhanVien, 
            string tenNhanVien, 
            string diaChiNhanVien, 
            string ngaySinhNhanVienStr,
            string soDienThoaiNhanVien, 
            string maBangCapNhanVien, 
            string maBoPhanNhanVien, 
            string maChucVuNhanVien
        )
        {
            this.maNhanVien = maNhanVien;
            this.tenNhanVien = tenNhanVien;
            this.diaChiNhanVien = diaChiNhanVien;
            this.soDienThoaiNhanVien = soDienThoaiNhanVien;
            this.maBangCapNhanVien = maBangCapNhanVien;
            this.maBoPhanNhanVien = maBoPhanNhanVien;
            this.maChucVuNhanVien = maChucVuNhanVien;
            this.ngaySinhNhanVienStr = ngaySinhNhanVienStr;
        }
    }
}
