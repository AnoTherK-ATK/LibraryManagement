using DoAn.DTO;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DoAn.DAL
{
    class DAL_ThongTinSachMuon
    {
        DataHelper helper = new DataHelper();
        internal List<string> LayMaPMDangMuon(List<string> danhSachMaPM)
        {
            //return danhSachMaPM;
            if (danhSachMaPM == null || danhSachMaPM.Count == 0)
                return new List<string>() ;// Trả về danh sách rỗng nếu input không hợp lệ
            
            // Chuyển danh sách mã PM thành chuỗi cho câu lệnh SQL IN
            string danhSachMaPMText = string.Join("','", danhSachMaPM);
            string query = $"SELECT MaPhieuMuonSach FROM THONGTINSACHMUON WHERE TrangThai = N'Đang mượn' AND MaPhieuMuonSach IN ('{danhSachMaPMText}')";

            DataTable dtMaPM = helper.ExecuteQuery(query);
            List<string> listMaPMDangMuon = new List<string>();
            foreach (DataRow dr in dtMaPM.Rows)
            {
                listMaPMDangMuon.Add(dr["MaPhieuMuonSach"].ToString());
            }
            //List<string> fruits = new List<string> { "Mango", "Pineapple", "Grapes" };
            return listMaPMDangMuon;
        }

        public int ThemPhieuMuonSach(DTO_ThongTinSachMuon ThongTinSachMuon)
        {
            string query = @"
            INSERT INTO THONGTINSACHMUON (
                MaPhieuMuonSach,
                MaSach,
                TrangThai
            ) VALUES (
                @MaPhieuMuonSach,
                @MaSach,
                @TrangThai
            )";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieuMuonSach", ThongTinSachMuon.MaPhieuMuonSach);
                        cmd.Parameters.AddWithValue("@MaSach", ThongTinSachMuon.MaSach);
                        cmd.Parameters.AddWithValue("@TrangThai", ThongTinSachMuon.TrangThai);
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm thông tin cho phiếu mượn sách mới: " + ex.Message);
            }

        }
        internal List<string> LayTatCaSachTheoPhieuMuon(string maPM)
        {
            string query = $"SELECT MaSach FROM THONGTINSACHMUON WHERE MaPhieuMuonSach = '{maPM}' AND TrangThai = 'Đang Mượn'";
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

        internal string LayTrangThaiPhieuMuonTheoMS_MPM(string maPM, string maSach)
        {
            string query = $"SELECT TrangThai FROM THONGTINSACHMUON WHERE MaPhieuMuonSach = '{maPM}' AND MaSach = '{maSach}'";
            DataTable dtTrangThai = helper.ExecuteQuery(query);
            if (dtTrangThai.Rows.Count > 0)
            {
                return dtTrangThai.Rows[0]["TrangThai"].ToString();
            }
            return string.Empty;
        }

        internal string LayMaPMTheoMaSach(string MaSach)
        {
            string query = $"SELECT MaPhieuMuonSach FROM THONGTINSACHMUON WHERE MaSach = '{MaSach}' AND TrangThai = 'Đang mượn'";
            DataTable dtMaPM = helper.ExecuteQuery(query);
            if (dtMaPM.Rows.Count > 0)
            {
                return dtMaPM.Rows[0]["MaPhieuMuonSach"].ToString();
            }
            return string.Empty;
        }

        internal bool CapNhatNgayTraSach(string MaPhieuMuonSach, string MaSach, string TrangThai)
        {
            string query = @"
            UPDATE THONGTINSACHMUON SET 
                NgayTraSach = @NgayTraSach, 
                TrangThai = @TrangThai
            WHERE MaPhieuMuonSach = @MaPhieuMuonSach AND MaSach = @MaSach";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NgayTraSach", DateTime.Now);
                        cmd.Parameters.AddWithValue("@MaPhieuMuonSach", MaPhieuMuonSach);
                        cmd.Parameters.AddWithValue("@MaSach", MaSach);
                        cmd.Parameters.AddWithValue("@TrangThai", TrangThai);

                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi cập nhật thẻ độc giả: " + ex.Message);
            }
        }
    }
}
