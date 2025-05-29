using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace DoAn.DAL
{
    class DAL_PhieuMuonSach
    {
        DataHelper helper = new DataHelper();
        internal List<DTO_PhieuMuonSach> LayDanhSachPhieuMuonSach()
        {
            DataTable dtPhieuMuonSach = helper.ExecuteQuery("SELECT MaPhieuMuonSach, DATE_FORMAT(NgayMuon, '%d/%m/%Y') AS NgayMuon, MaDocGia FROM PHIEUMUONSACH");

            List<DTO_PhieuMuonSach> listPhieuMuonSach = new List<DTO_PhieuMuonSach>();

            foreach (DataRow dr in dtPhieuMuonSach.Rows)
            {
                DTO_PhieuMuonSach PhieuMuonSachTemp = new DTO_PhieuMuonSach(
                    dr["MaPhieuMuonSach"].ToString(),
                    dr["NgayMuon"].ToString(),
                    dr["MaDocGia"].ToString()
                );
                listPhieuMuonSach.Add(PhieuMuonSachTemp);
            }

            return listPhieuMuonSach;
        }
    }
}
