using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using DoAn.DTO;

namespace DoAn.BUS
{
    public class BUS_LoaiBoPhan
    {
        DAL_LoaiBoPhan DAL_LoaiBoPhan = new DAL_LoaiBoPhan();
        internal List<DTO_LoaiBoPhan> LayDanhSachLoaiBoPhan()
        {
            return DAL_LoaiBoPhan.LayDanhSachLoaiBoPhan();
        }

        internal string LayTenBoPhan(string maBoPhan)
        {
            return DAL_LoaiBoPhan.LayTenBoPhan(maBoPhan);
        }

        internal bool LayQuyenLapThe(string maBoPhan)
        {
            return DAL_LoaiBoPhan.LayQuyenLapThe(maBoPhan);
        }

        internal bool LayQuyenNhanSach(string maBoPhan)
        {
            return DAL_LoaiBoPhan.LayQuyenNhanSach(maBoPhan);
        }

        internal bool LayQuyenThuTienPhat(string maBoPhan)
        {
            return DAL_LoaiBoPhan.LayQuyenThuTienPhat(maBoPhan);
        }
    }
}
