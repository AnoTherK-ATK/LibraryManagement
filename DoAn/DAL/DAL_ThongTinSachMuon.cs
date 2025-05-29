using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAL
{
    class DAL_ThongTinSachMuon
    {
        DataHelper helper = new DataHelper();
        internal List<string> LayMaPMDangMuon(List<string> danhSachMaPM)
        {
            if (danhSachMaPM == null || danhSachMaPM.Count == 0)
                return new List<string>(); // Trả về danh sách rỗng nếu input không hợp lệ
            
            // Chuyển danh sách mã PM thành chuỗi cho câu lệnh SQL IN
            string danhSachMaPMText = string.Join("','", danhSachMaPM);
            string query = $"SELECT MaPhieuMuonSach FROM THONGTINSACHMUON WHERE TrangThai = N'Đang mượn' AND MaPhieuMuonSach IN ('{danhSachMaPMText}')";

            DataTable dtMaPM = helper.ExecuteQuery(query);
            List<string> listMaPMDangMuon = new List<string>();
            foreach (DataRow dr in dtMaPM.Rows)
            {
                listMaPMDangMuon.Add(dr["MaPhieuMuonSach"].ToString());
            }
            return listMaPMDangMuon;
        }

    }
}
