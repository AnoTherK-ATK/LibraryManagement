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



        public DTO_ThongTinSachMuon(
            string maPhieuMuonSach,
            string maSach,
            string trangThai
        )
        {
            this.maPhieuMuonSach = maPhieuMuonSach;
            this.maSach = maSach;
            this.trangThai = trangThai;
        }
    }
}
