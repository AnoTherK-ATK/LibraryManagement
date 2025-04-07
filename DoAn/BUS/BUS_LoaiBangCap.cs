using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using DoAn.DTO;

namespace DoAn.BUS
{
    public class BUS_LoaiBangCap
    {
        DAL_LoaiBangCap DAL_LoaiBangCap = new DAL_LoaiBangCap();
        internal List<DTO_LoaiBangCap> LayDanhSachLoaiBangCap()
        {
            return DAL_LoaiBangCap.LayDanhSachLoaiBangCap();
        }

        internal string LayTenBangCap(string maBangCap)
        {
            return DAL_LoaiBangCap.LayTenBangCap(maBangCap);
        }
    }
}
