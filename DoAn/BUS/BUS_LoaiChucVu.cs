using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using DoAn.DTO;

namespace DoAn.BUS
{
    public class BUS_LoaiChucVu
    {
        DAL_LoaiChucVu DAL_LoaiChucVu = new DAL_LoaiChucVu();
        internal List<DTO_LoaiChucVu> LayDanhSachLoaiChucVu()
        {
            return DAL_LoaiChucVu.LayDanhSachLoaiChucVu();
        }
    }
}
