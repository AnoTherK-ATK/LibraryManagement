using DoAn.DTO;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn.DAL
{
    class DAL_PhieuThuTienPhat
    {
        DataHelper helper = new DataHelper();
        internal List<DTO_PhieuThuTienPhat> LayDanhSachPhieuThuTienPhat()
        {
            DataTable dtPhieu = helper.ExecuteQuery("SELECT MaPhieuThuTienPhat, SoTienThu, MaDocGia, MaNhanVien FROM PHIEUTHUTIENPHAT");

            List<DTO_PhieuThuTienPhat> listPhieu = new List<DTO_PhieuThuTienPhat>();

            foreach (DataRow dr in dtPhieu.Rows)
            {
                DTO_PhieuThuTienPhat NhanVienTemp = new DTO_PhieuThuTienPhat(
                    dr["MaPhieuThuTienPhat"].ToString(),
                    int.Parse(dr["SoTienThu"].ToString()),
                    dr["MaDocGia"].ToString(),
                    dr["MaNhanVien"].ToString()
                );
                listPhieu.Add(NhanVienTemp);
            }

            return listPhieu;
        }

        public int ThemPhieuThuTienPhat(DTO_PhieuThuTienPhat PhieuThuTienPhat)
        {
            string query = @"
            INSERT INTO PHIEUTHUTIENPHAT (
                MaPhieuThuTienPhat,
                SoTienThu,
                MaNhanVien,
                MaDocGia
            ) VALUES (
                @MaPhieuThuTienPhat,
                @SoTienThu,
                @MaNhanVien,
                @MaDocGia
            )";
            try
            {
                using (var conn = helper.GetConnection())
                {
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieuThuTienPhat", PhieuThuTienPhat.MaPhieuThuTienPhat);
                        cmd.Parameters.AddWithValue("@SoTienThu", PhieuThuTienPhat.SoTienThu);
                        cmd.Parameters.AddWithValue("@MaNhanVien", PhieuThuTienPhat.MaNhanVien);
                        cmd.Parameters.AddWithValue("@MaDocGia", PhieuThuTienPhat.MaDocGia);
                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi thêm thêm phiếu thu tiền phạt mới: " + ex.Message);
            }

        }
    }
}
