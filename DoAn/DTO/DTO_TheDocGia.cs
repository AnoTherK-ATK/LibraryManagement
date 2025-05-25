using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    internal class DTO_TheDocGia
    {
        string maDocGia;
        public string MaDocGia
        {
            get { return maDocGia; }
            set { maDocGia = value; }
        }
        string hoTenDocGia;
        public string HoTenDocGia
        {
            get { return hoTenDocGia; }
            set { hoTenDocGia = value; }
        }

        string diaChiDocGia;
        public string DiaChiDocGia
        {
            get { return diaChiDocGia; }
            set { diaChiDocGia = value; }
        }

        string emailDocGia;
        public string EmailDocGia
        {
            get { return emailDocGia; }
            set { emailDocGia = value; }
        }


        DateTime ngaySinhDocGia;
        public DateTime NgaySinhDocGia
        {
            get { return ngaySinhDocGia; }
            set { ngaySinhDocGia = value; }
        }


        public string ngaySinhDocGiaStr
        {
            get => ngaySinhDocGia.ToString("dd/MM/yyyy");
            set
            {
                if (DateTime.TryParseExact(value, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                {
                    ngaySinhDocGia = parsedDate;
                }
            }
        }

        DateTime ngayLapThe;
        public DateTime NgayLapThe
        {
            get { return ngayLapThe; }
            set { ngayLapThe = value; }
        }
        public string ngayLapTheStr
        {
            get => ngayLapThe.ToString("dd/MM/yyyy");
            set
            {
                if (DateTime.TryParseExact(value, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                {
                    ngayLapThe = parsedDate;
                }
            }
        }

        DateTime ngayHetHan;
        public DateTime NgayHetHan
        {
            get { return ngayHetHan; }
            set { ngayHetHan = value; }
        }
        public string ngayHetHanStr
        {
            get => ngayHetHan.ToString("dd/MM/yyyy");
            set
            {
                if (DateTime.TryParseExact(value, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                {
                    ngayHetHan = parsedDate;
                }
            }
        }



        //Foreign keys
        string maLoaiDocGia;
        public string MaLoaiDocGia
        {
            get { return maLoaiDocGia; }
            set { maLoaiDocGia = value; }
        }
        string maNhanVien;
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        public DTO_TheDocGia(
            string maDocGia,
            string hoTenDocGia,
            string diaChiDocGia,
            string ngaySinhDocGiaStr,
            string emailDocGia,
            string ngayLapTheStr,
            string ngayHetHanStr,
            string maLoaiDocGia,
            string maNhanVien
        )
        {
            this.maDocGia = maDocGia;
            this.hoTenDocGia = hoTenDocGia;
            this.diaChiDocGia = diaChiDocGia;
            this.ngaySinhDocGiaStr = ngaySinhDocGiaStr;
            this.emailDocGia = emailDocGia;
            this.ngayLapTheStr = ngayLapTheStr;
            this.ngayHetHanStr = ngayHetHanStr;
            this.maLoaiDocGia = maLoaiDocGia;
            this.maNhanVien = maNhanVien;
        }



    }
}
