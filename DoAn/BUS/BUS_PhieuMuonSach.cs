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
    }
}
