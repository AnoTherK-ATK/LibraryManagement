using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAL
{
    class DAL_TheLoai
    {
        DataHelper helper = new DataHelper();
        internal List<DTO_TheLoai> LayDanhSachTheLoai()
        {
            DataTable dtTheLoai = helper.ExecuteQuery("SELECT * FROM THELOAI");
            List<DTO_TheLoai> listTheLoai = new List<DTO_TheLoai>();
            foreach (DataRow dr in dtTheLoai.Rows)
            {
                DTO_TheLoai theLoaiTemp = new DTO_TheLoai(dr["MaTheLoai"].ToString(), dr["TenTheLoai"].ToString());
                listTheLoai.Add(theLoaiTemp);
            }
            return listTheLoai;
        }
        internal string LayTenTheLoai(string maTheLoai)
        {
            List<DTO_TheLoai> listTheLoai = LayDanhSachTheLoai();
            foreach (DTO_TheLoai theLoai in listTheLoai)
            {
                if (theLoai.MaTheLoai == maTheLoai)
                {
                    return theLoai.TenTheLoai;
                }
            }
            return null;
        }
    }
}
