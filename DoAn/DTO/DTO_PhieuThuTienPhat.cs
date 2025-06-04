using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    class DTO_PhieuThuTienPhat
    {
        string maPhieuThuTienPhat;
        public string MaPhieuThuTienPhat { get => maPhieuThuTienPhat; set => maPhieuThuTienPhat = value; }

        int soTienThu;
        public int SoTienThu { get => soTienThu; set => soTienThu = value; }

        string maDocGia;
        public string MaDocGia { get => maDocGia; set => maDocGia = value; }

        string maNhanVien;
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }


        public DTO_PhieuThuTienPhat(
            string maPhieuThuTienPhat,
            int soTienThu=0,
            string maDocGia=null,
            string maNhanVien = null
        )
        {
            this.maPhieuThuTienPhat = maPhieuThuTienPhat;
            this.soTienThu = soTienThu;
            this.maDocGia = maDocGia;
            this.maNhanVien = maNhanVien;
        }
    }
}
