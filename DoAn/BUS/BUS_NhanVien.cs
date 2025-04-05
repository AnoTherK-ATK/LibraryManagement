using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DAL;
using DoAn.DTO;

namespace DoAn.BUS
{
    public class BUS_NhanVien
    {
        DAL_NhanVien DAL_NhanVien = new DAL_NhanVien();
        internal List<DTO_NhanVien> LayDanhSachNhanVien()
        {
            return DAL_NhanVien.LayDanhSachNhanVien();
        }
    }
}
