using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using DoAn.DTO;

namespace DoAn.BUS
{
    class BUS_TheLoai
    {
        DAL_TheLoai DAL_TheLoai = new DAL_TheLoai();
        internal List<DTO_TheLoai> LayDanhSachTheLoai()
        {
            return DAL_TheLoai.LayDanhSachTheLoai();
        }
        internal string LayTenTheLoai(string maTheLoai)
        {
            return DAL_TheLoai.LayTenTheLoai(maTheLoai);
        }
    }
}
