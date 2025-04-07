using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAn.DTO;

namespace DoAn.DAL
{
    public class DAL_LoaiBangCap
    {
        DataHelper helper = new DataHelper();

        internal List<DTO_LoaiBangCap> LayDanhSachLoaiBangCap()
        {
            DataTable dtLoaiBangCap = helper.ExecuteQuery("SELECT * FROM BANGCAP");

            List<DTO_LoaiBangCap> listLoaiBangCap = new List<DTO_LoaiBangCap>();
            foreach (DataRow dr  in dtLoaiBangCap.Rows)
            {
                DTO_LoaiBangCap BangCapTemp = new DTO_LoaiBangCap(dr["MaBangCap"].ToString(), dr["TenBangCap"].ToString());
                listLoaiBangCap.Add(BangCapTemp);
            }
            return listLoaiBangCap;
        }

        internal string LayTenBangCap(string maBangCap)
        {
            List<DTO_LoaiBangCap> listLoaiBangCap = LayDanhSachLoaiBangCap();
            foreach (DTO_LoaiBangCap bangCap in listLoaiBangCap)
            {
                if (bangCap.MaLoaiBangCap == maBangCap)
                {
                    return bangCap.TenLoaiBangCap;
                }
            }
            return null;
        }
    }
}
