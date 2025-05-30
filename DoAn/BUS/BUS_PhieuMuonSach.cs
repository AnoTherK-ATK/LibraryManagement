using DoAn.DAL;
using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.BUS
{
    class BUS_PhieuMuonSach
    {
        DAL_PhieuMuonSach DAL_PhieuMuonSach = new DAL_PhieuMuonSach();
        DAL_TheDocGia DAL_TheDocGia = new DAL_TheDocGia();
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
        internal List<DTO_PhieuMuonSach> TimPhieuMuonSach(string maPM, string hoTen, DateTime? ngayMuon)
        {
            string maDocGia = string.Empty;
            if (!string.IsNullOrEmpty(hoTen))
            {
                maDocGia = DAL_TheDocGia.LayMaDocGiaTheoTenDocGia(hoTen);
            }
            return DAL_PhieuMuonSach.TimPhieuMuonSach(maPM, maDocGia, ngayMuon);
        }
        public bool ThemPhieuMuonSach(DTO_PhieuMuonSach PhieuMuonSach)
        {
            {
                if (string.IsNullOrWhiteSpace(PhieuMuonSach.MaPhieuMuonSach) ||
                    string.IsNullOrWhiteSpace(PhieuMuonSach.MaDocGia) ||
                    string.IsNullOrWhiteSpace(PhieuMuonSach.ngayMuon.ToString()) ||
                    string.IsNullOrWhiteSpace(PhieuMuonSach.HanTraSach.ToString()))
                {
                    throw new Exception("Các trường không được để trống");
                }
                return DAL_PhieuMuonSach.ThemPhieuMuonSach(PhieuMuonSach) > 0;
            }
        }
    }
}
