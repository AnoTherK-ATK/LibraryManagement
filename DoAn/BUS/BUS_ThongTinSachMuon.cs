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

        internal List<string> LayTatCaSachTheoListPhieuMuon(List<string> listMaPM)
        {
            HashSet<string> allSach = new HashSet<string>();
            foreach (string maPM in listMaPM)
            {
                List<string> maSach = DAL_ThongTinSachMuon.LayTatCaSachTheoPhieuMuon(maPM);
                allSach.UnionWith(maSach);
            }
            // Nếu cần trả về List<string>:
            return allSach.ToList();
        }
        internal string LayTrangThaiPhieuMuon(string maPM)
        {
            return DAL_ThongTinSachMuon.LayTrangThaiPhieuMuon(maPM);
        }
        internal string LayMaPMTheoMaSach(string MaSach)
        {
            return DAL_ThongTinSachMuon.LayMaPMTheoMaSach(MaSach);
        }

        internal bool CapNhatNgayTraSach(string MaPhieuMuonSach, string MaSach, string TrangThai)
        {
            return DAL_ThongTinSachMuon.CapNhatNgayTraSach(MaPhieuMuonSach, MaSach, TrangThai);
        }

        
    }

}
