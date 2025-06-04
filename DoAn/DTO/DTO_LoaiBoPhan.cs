using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DTO
{
    public class DTO_LoaiBoPhan
    {
        string maLoaiBoPhan;
        public string MaLoaiBoPhan { get => maLoaiBoPhan; set => maLoaiBoPhan = value; }
        string tenLoaiBoPhan;
        public string TenLoaiBoPhan { get => tenLoaiBoPhan; set => tenLoaiBoPhan = value; }

        bool quyenLapThe;
        public bool QuyenLapThe { get => quyenLapThe; set => quyenLapThe = value; }

        bool quyenNhanSach;
        public bool QuyenNhanSach { get => quyenNhanSach; set => quyenNhanSach = value; }

        bool quyenThuTienPhat;
        public bool QuyenThuTienPhat { get => quyenThuTienPhat; set => quyenThuTienPhat = value; }

        public DTO_LoaiBoPhan(string maLoaiBoPhan, string tenLoaiBoPhan, bool quyenLapThe, bool quyenNhanSach, bool quyenThuTienPhat = false)
        {
            this.maLoaiBoPhan = maLoaiBoPhan;
            this.tenLoaiBoPhan = tenLoaiBoPhan;
            this.quyenLapThe = quyenLapThe;
            this.quyenNhanSach = quyenNhanSach;
            this.quyenThuTienPhat = quyenThuTienPhat;
        }
    }
}
