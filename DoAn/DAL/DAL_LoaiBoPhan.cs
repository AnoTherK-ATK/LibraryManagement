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
                DTO_LoaiBoPhan BoPhanTemp = new DTO_LoaiBoPhan(dr["MaBoPhan"].ToString(), dr["TenBoPhan"].ToString());
                listLoaiBoPhan.Add(BoPhanTemp);
            }
            return listLoaiBoPhan;
        }
    }
}
