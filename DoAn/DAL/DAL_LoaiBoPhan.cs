using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DTO;

namespace DoAn.DAL
{
    public class DAL_LoaiBoPhan
    {
        DataHelper helper = new DataHelper();

        internal List<DTO_LoaiBoPhan> LayDanhSachLoaiBoPhan()
        {
            DataTable dtLoaiBoPhan = helper.ExecuteQuery("SELECT * FROM BOPHAN");

            List<DTO_LoaiBoPhan> listLoaiBoPhan = new List<DTO_LoaiBoPhan>();
            foreach (DataRow dr in dtLoaiBoPhan.Rows)
            {
                DTO_LoaiBoPhan BoPhanTemp = new DTO_LoaiBoPhan(
                    dr["MaBoPhan"].ToString(),
                    dr["TenBoPhan"].ToString(),
                    Convert.ToBoolean(dr["QuyenLapThe"])
                );
                listLoaiBoPhan.Add(BoPhanTemp);
            }
            return listLoaiBoPhan;
        }

        internal string LayTenBoPhan(string maBoPhan)
        {
            List<DTO_LoaiBoPhan> listLoaiBoPhan = LayDanhSachLoaiBoPhan();
            foreach (DTO_LoaiBoPhan bangCap in listLoaiBoPhan)
            {
                if (bangCap.MaLoaiBoPhan == maBoPhan)
                {
                    return bangCap.TenLoaiBoPhan;
                }
            }
            return null;
        }

        internal bool LayQuyenLapThe(string maBoPhan)
        {
            List<DTO_LoaiBoPhan> listLoaiBoPhan = LayDanhSachLoaiBoPhan();
            foreach (DTO_LoaiBoPhan boPhan in listLoaiBoPhan)
            {
                if (boPhan.MaLoaiBoPhan == maBoPhan)
                {
                    return boPhan.QuyenLapThe;
                }
            }
            return false;
        }

    }
}
