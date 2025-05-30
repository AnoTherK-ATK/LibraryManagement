using DoAn.DAL;
using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    class BUS_ThongTinSachMuon
    {
        DAL_ThongTinSachMuon DAL_ThongTinSachMuon = new DAL_ThongTinSachMuon();
        internal List<string> LayMaPMDangMuon(List<string> danhSachMaPM)
        {

            return DAL_ThongTinSachMuon.LayMaPMDangMuon(danhSachMaPM);
        }

        public bool ThemPhieuMuonSach(DTO_ThongTinSachMuon ThongTinSachMuon)
        {
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(ThongTinSachMuon.MaPhieuMuonSach) ||
                    string.IsNullOrWhiteSpace(ThongTinSachMuon.MaSach) ||
                    string.IsNullOrWhiteSpace(ThongTinSachMuon.TrangThai))
                {
                    throw new Exception("Các trường không được để trống");
                }
                return DAL_ThongTinSachMuon.ThemPhieuMuonSach(ThongTinSachMuon) > 0;
            }
        }
        internal List<string> LayTatCaSachTheoPhieuMuon(string maPM)
        {
            return DAL_ThongTinSachMuon.LayTatCaSachTheoPhieuMuon(maPM);
        }
        internal string LayTrangThaiPhieuMuon(string maPM)
        {
            return DAL_ThongTinSachMuon.LayTrangThaiPhieuMuon(maPM);
        }
    }

}
