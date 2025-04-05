using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DTO;

namespace DoAn.DAL
{
    public class DAL_LoaiChucVu
    {
        DataHelper helper = new DataHelper();

        internal List<DTO_LoaiChucVu> LayDanhSachLoaiChucVu()
        {
            DataTable dtLoaiChucVu = helper.ExecuteQuery("SELECT * FROM CHUCVU");

            List<DTO_LoaiChucVu> listLoaiChucVu = new List<DTO_LoaiChucVu>();
            foreach (DataRow dr in dtLoaiChucVu.Rows)
            {
                DTO_LoaiChucVu ChucVuTemp = new DTO_LoaiChucVu(dr["MaChucVu"].ToString(), dr["TenChucVu"].ToString());
                listLoaiChucVu.Add(ChucVuTemp);
            }
            return listLoaiChucVu;
        }
    }
}
