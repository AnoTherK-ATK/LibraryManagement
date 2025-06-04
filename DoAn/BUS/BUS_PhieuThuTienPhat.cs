using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using DoAn.DTO;

namespace DoAn.BUS
{
    class BUS_PhieuThuTienPhat
    {
        DAL_PhieuThuTienPhat DAL_PhieuThuTienPhat = new DAL_PhieuThuTienPhat();
        internal List<DTO_PhieuThuTienPhat> LayDanhSachPhieuThuTienPhat()
        {
            return DAL_PhieuThuTienPhat.LayDanhSachPhieuThuTienPhat();
        }

        internal List<DTO_PhieuThuTienPhat> LayTatCaPhieuThuTienPhat(string maPM = "", string MaDG = "")
        {
            return DAL_PhieuThuTienPhat.LayTatCaPhieuThu(maPM, MaDG);
        }

        public bool ThemPhieuThuTienPhat(DTO_PhieuThuTienPhat PhieuThuTienPhat)
        {
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(PhieuThuTienPhat.MaPhieuThuTienPhat) ||
                    PhieuThuTienPhat.SoTienThu <= 0 ||
                    string.IsNullOrWhiteSpace(PhieuThuTienPhat.MaDocGia) ||
                    string.IsNullOrWhiteSpace(PhieuThuTienPhat.MaNhanVien))
                {
                    throw new Exception("Các trường không được để trống");
                }
                return DAL_PhieuThuTienPhat.ThemPhieuThuTienPhat(PhieuThuTienPhat) > 0;
            }
        }

        public List<DTO_PhieuThuTienPhat> LayTatCaPhieuThu(string maPT = "", string maDG = "")
        {
            return DAL_PhieuThuTienPhat.LayTatCaPhieuThu(maPT, maDG);   
        }

    }
}
