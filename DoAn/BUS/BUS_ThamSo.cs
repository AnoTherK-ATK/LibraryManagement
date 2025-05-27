using DoAn.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    internal class BUS_ThamSo
    {

        DAL_ThamSo DAL_ThamSo = new DAL_ThamSo();
        internal int LayTuoiToiThieu()
        {
            return DAL_ThamSo.LayTuoiToiThieu();
        }
        internal int LayTuoiToiDa()
        {
            return DAL_ThamSo.LayTuoiToiDa();
        }

        internal int LayGiaTriThe()
        {
            return DAL_ThamSo.LayGiaTriThe();
        }

        internal int LayThoiGianNhapSachToiDa()
        {
            return DAL_ThamSo.LayThoiGianNhapSachToiDa();
        }

    }
}
