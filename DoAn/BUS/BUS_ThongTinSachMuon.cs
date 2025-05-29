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
    }

}
