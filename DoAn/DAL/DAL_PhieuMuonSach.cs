using DoAn.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows.Forms;

namespace DoAn.DAL
{
    class DAL_PhieuMuonSach
    {
        DataHelper helper = new DataHelper();
        internal List<DTO_PhieuMuonSach> LayDanhSachPhieuMuonSach()
        {
            DataTable dtPhieuMuonSach = helper.ExecuteQuery("SELECT MaPhieuMuonSach, DATE_FORMAT(NgayMuon, '%d/%m/%Y') AS NgayMuon, MaDocGia, DATE_FORMAT(HanTraSach, '%d/%m/%Y') HanTraSach FROM PHIEUMUONSACH");

            List<DTO_PhieuMuonSach> listPhieuMuonSach = new List<DTO_PhieuMuonSach>();

            foreach (DataRow dr in dtPhieuMuonSach.Rows)
            {
                //MessageBox.Show(dr["HanTraSach"].ToString());
                DTO_PhieuMuonSach PhieuMuonSachTemp = new DTO_PhieuMuonSach(
                    dr["MaPhieuMuonSach"].ToString(),
                    dr["MaDocGia"].ToString(),
                    dr["NgayMuon"].ToString(),
                    dr["HanTraSach"].ToString()
                );
                //MessageBox.Show(PhieuMuonSachTemp.hanTraSachStr);
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
                        cmd.Parameters.AddWithValue("@HanTraSach", phieuMuonSach.HanTraSach);
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
        internal List<string> LayTatCaSachTheoPhieuMuon(string maPM)
        {
            string query = $"SELECT MaSach FROM THONGTINSACHMUON WHERE MaPhieuMuonSach = '{maPM}'";
            DataTable dtMaSach = helper.ExecuteQuery(query);
            List<string> listMaSach = new List<string>();
            foreach (DataRow dr in dtMaSach.Rows)
            {
                listMaSach.Add(dr["MaSach"].ToString());
            }
            return listMaSach;
        }
        internal string LayTrangThaiPhieuMuon(string maPM)
        {
            string query = $"SELECT TrangThai FROM THONGTINSACHMUON WHERE MaPhieuMuonSach = '{maPM}'";
            DataTable dtTrangThai = helper.ExecuteQuery(query);
            if (dtTrangThai.Rows.Count > 0)
            {
                return dtTrangThai.Rows[0]["TrangThai"].ToString();
            }
            return string.Empty;
        }
    }
}
