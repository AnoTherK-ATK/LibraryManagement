using DoAn.DAL;
using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    class BUS_PhieuMuonSach
    {
        DAL_PhieuMuonSach DAL_PhieuMuonSach = new DAL_PhieuMuonSach();
        internal List<DTO_PhieuMuonSach> LayDanhSachPhieuMuonSach()
        {
            return DAL_PhieuMuonSach.LayDanhSachPhieuMuonSach();
        }

        internal List<string> LayTatCaMaPMTheoDocGia(string maDocGia)
        {
            return DAL_PhieuMuonSach.LayTatCaMaPMTheoDocGia(maDocGia);
        }

        internal List<string> LayTatCaMaPMTheoThoiGianMuonSach(string maDocGia, int ThoiGianMuonSachQuyDinh)
        {
            return DAL_PhieuMuonSach.LayTatCaMaPMTheoThoiGianMuonSach(maDocGia, ThoiGianMuonSachQuyDinh);
        }
    }
}
