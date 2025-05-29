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

        public bool ThemPhieuMuonSach(DTO_PhieuMuonSach PhieuMuonSach)
        {
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(PhieuMuonSach.MaPhieuMuonSach) ||
                    string.IsNullOrWhiteSpace(PhieuMuonSach.MaDocGia) ||
                    string.IsNullOrWhiteSpace(PhieuMuonSach.ngayMuon.ToString()) ||
                    string.IsNullOrWhiteSpace(PhieuMuonSach.hanTraSach.ToString()))
                {
                    throw new Exception("Các trường không được để trống");
                }
                return DAL_PhieuMuonSach.ThemPhieuMuonSach(PhieuMuonSach) > 0;
            }
        }
    }
}
