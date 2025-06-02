using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    class DTO_ThongTinSachMuon
    {
        string maPhieuMuonSach;
        public string MaPhieuMuonSach { get => maPhieuMuonSach; set => maPhieuMuonSach = value; }

        string maSach;
        public string MaSach { get => maSach; set => maSach = value; }

        string trangThai;
        public string TrangThai { get => trangThai; set => trangThai = value; }

        string hanTraSach;

        DateTime ngayTraSach;
        public DateTime NgayTraSach
        {
            get { return ngayTraSach; }
            set { ngayTraSach = value; }
        }
        public string ngayTraSachStr
        {
            get => ngayTraSach.ToString("dd/MM/yyyy");
            set
            {
                if (DateTime.TryParseExact(value, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                {
                    ngayTraSach = parsedDate;
                }
            }
        }



        //public DTO_ThongTinSachMuon()
        //{
        //    this.maPhieuMuonSach = string.Empty;
        //    this.maSach = string.Empty;
        //    this.trangThai = string.Empty;
        //    this.ngayTraSachStr = DateTime.Now.ToString();
        //}

        // Constructor với các tham số tuỳ chọn
        public DTO_ThongTinSachMuon(
            string maPhieuMuonSach,
            string maSach,
            string trangThai,
            string ngayTraSachStr = null
        )
        {
            this.maPhieuMuonSach = maPhieuMuonSach;
            this.maSach = maSach;
            this.trangThai = trangThai;
            this.ngayTraSachStr = ngayTraSachStr;
        }
    }
}
