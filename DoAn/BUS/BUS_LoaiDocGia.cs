using DoAn.DAL;
using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.BUS
{
    internal class BUS_LoaiDocGia
    {
        DAL_LoaiDocGia DAL_LoaiDocGia = new DAL_LoaiDocGia();
        internal List<DTO_LoaiDocGia> LayDanhSachLoaiDocGia()
        {
            return DAL_LoaiDocGia.LayDanhSachLoaiDocGia();
        }
    }
}
