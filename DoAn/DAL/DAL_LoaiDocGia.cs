using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAL
{
    internal class DAL_LoaiDocGia
    {
        DataHelper helper = new DataHelper();
        internal List<DTO_LoaiDocGia> LayDanhSachLoaiDocGia()
        {
            DataTable dtLoaiDocGia = helper.ExecuteQuery("SELECT * FROM LOAIDOCGIA");
            List<DTO_LoaiDocGia> listLoaiDocGia = new List<DTO_LoaiDocGia>();
            foreach (DataRow dr in dtLoaiDocGia.Rows)
            {
                DTO_LoaiDocGia loaiDocGiaTemp = new DTO_LoaiDocGia(dr["MaLoaiDocGia"].ToString(), dr["TenLoaiDocGia"].ToString());
                listLoaiDocGia.Add(loaiDocGiaTemp);
            }
            return listLoaiDocGia;
        }

        internal string LayTenLoaiDocGia(string maLoaiDocGia)
        {
            List<DTO_LoaiDocGia> listLoaiDocGia = LayDanhSachLoaiDocGia();
            foreach (DTO_LoaiDocGia loaiDocGia in listLoaiDocGia)
            {
                if (loaiDocGia.MaLoaiDocGia == maLoaiDocGia)
                {
                    return loaiDocGia.TenLoaiDocGia;
                }
            }
            return null;
        }
    }
}
