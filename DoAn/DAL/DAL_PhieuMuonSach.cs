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
            DataTable dtPhieuMuonSach = helper.ExecuteQuery("SELECT MaPhieuMuonSach, DATE_FORMAT(NgayMuon, '%d/%m/%Y') AS NgayMuon, MaDocGia, HanTraSach FROM PHIEUMUONSACH");

            List<DTO_PhieuMuonSach> listPhieuMuonSach = new List<DTO_PhieuMuonSach>();

            foreach (DataRow dr in dtPhieuMuonSach.Rows)
            {
                DTO_PhieuMuonSach PhieuMuonSachTemp = new DTO_PhieuMuonSach(
                    dr["MaPhieuMuonSach"].ToString(),
                    dr["NgayMuon"].ToString(),
                    dr["MaDocGia"].ToString(),
                    dr["HanTraSach"].ToString()
                );
                listPhieuMuonSach.Add(PhieuMuonSachTemp);
            }

            return listPhieuMuonSach;
        }
        internal List<string> LayTatCaMaPMTheoDocGia(string maDocGia)
        {
            string query = $"SELECT MaPhieuMuonSach FROM PHIEUMUONSACH WHERE MaDocGia = '{maDocGia}' AND HanTraSach < CURDATE() ";
            DataTable dtMaPM = helper.ExecuteQuery(query);
            List<string> listmaPM = new List<string>();
            foreach (DataRow dr in dtMaPM.Rows)
            {
                listmaPM.Add(dr["MaPhieuMuonSach"].ToString());
            }
            return listmaPM;
        }

        internal List<string> LayTatCaMaPMTheoThoiGianMuonSach(string maDocGia, int ThoiGianMuonSachQuyDinh)
        {
            string query = $@"
                SELECT MaPhieuMuonSach 
                FROM PHIEUMUONSACH 
                WHERE MaDocGia = '{maDocGia}' 
                  AND DATE_ADD(NgayMuon, INTERVAL {ThoiGianMuonSachQuyDinh} DAY) >= CURDATE()";

            DataTable dtMaPM = helper.ExecuteQuery(query);
            List<string> listMaPM = new List<string>();
            foreach (DataRow dr in dtMaPM.Rows)
            {
                listMaPM.Add(dr["MaPhieuMuonSach"].ToString());
            }
            return listMaPM;
        }

        public int ThemPhieuMuonSach(DTO_PhieuMuonSach phieuMuonSach)
        {
            string query = @"
            INSERT INTO PHIEUMUONSACH (
                MaPhieuMuonSach,
                NgayMuon,
                MaDocGia,
                HanTraSach
            ) VALUES (
                @MaPhieuMuonSach,
                @NgayMuon,
                @MaDocGia,
                @HanTraSach
            )";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieuMuonSach", phieuMuonSach.MaPhieuMuonSach);
                        cmd.Parameters.AddWithValue("@NgayMuon", phieuMuonSach.ngayMuon);
                        cmd.Parameters.AddWithValue("@MaDocGia", phieuMuonSach.MaDocGia);
                        cmd.Parameters.AddWithValue("@HanTraSach", phieuMuonSach.hanTraSach);
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm phiếu mượn sách mới: " + ex.Message);
            }

        }

        internal List<DTO_PhieuMuonSach> TimPhieuMuonSach(string maPM, string maDocGia, DateTime? ngayMuon)
        {
            List<DTO_PhieuMuonSach> dTO_PhieuMuonSaches = LayDanhSachPhieuMuonSach();
            List<DTO_PhieuMuonSach> clone = new List<DTO_PhieuMuonSach>(dTO_PhieuMuonSaches);
            if (!string.IsNullOrEmpty(maPM))
            {
                foreach (var phieuMuon in clone)
                {
                    if (!phieuMuon.MaPhieuMuonSach.Equals(maPM, StringComparison.OrdinalIgnoreCase))
                    {
                        dTO_PhieuMuonSaches.Remove(phieuMuon);
                    }
                }                
            }
            clone = new List<DTO_PhieuMuonSach>(dTO_PhieuMuonSaches);
            if (!string.IsNullOrEmpty(maDocGia))
            {
                foreach (var phieuMuon in clone)
                {
                    if (!phieuMuon.MaDocGia.Equals(maDocGia, StringComparison.OrdinalIgnoreCase))
                    {
                        dTO_PhieuMuonSaches.Remove(phieuMuon);
                    }
                }
            }
            clone = new List<DTO_PhieuMuonSach>(dTO_PhieuMuonSaches);
            if (ngayMuon.HasValue)
            {
                string ngayMuonStr = ngayMuon.Value.ToString("dd/MM/yyyy");
                foreach (var phieuMuon in clone)
                {
                    if (!phieuMuon.ngayMuonStr.Equals(ngayMuonStr, StringComparison.OrdinalIgnoreCase))
                    {
                        dTO_PhieuMuonSaches.Remove(phieuMuon);
                    }
                }
            }
            return dTO_PhieuMuonSaches;
        }
    }
}
