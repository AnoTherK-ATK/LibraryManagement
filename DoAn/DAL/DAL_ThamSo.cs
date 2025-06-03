
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace DoAn.DAL
{
    internal class DAL_ThamSo
    {
        DataHelper helper = new DataHelper();

        internal int LayTuoiToiThieu()
        {
            DataTable dtLoaiDocGia = helper.ExecuteQuery("SELECT TUOITOITHIEU FROM THAMSO");
            if (dtLoaiDocGia != null && dtLoaiDocGia.Rows.Count > 0)
            {
                return Convert.ToInt32(dtLoaiDocGia.Rows[0]["TUOITOITHIEU"]);
            }
            else
            {
                // Return a default value or throw an exception if no data is found
                throw new InvalidOperationException("No data found for TUOITOITHIEU in THAMSO.");
            }
        }

        internal int LayTuoiToiDa()
        {
            DataTable dtLoaiDocGia = helper.ExecuteQuery("SELECT TUOITOIDA FROM THAMSO");
            if (dtLoaiDocGia != null && dtLoaiDocGia.Rows.Count > 0)
            {
                return Convert.ToInt32(dtLoaiDocGia.Rows[0]["TUOITOIDA"]);
            }
            else
            {
                // Return a default value or throw an exception if no data is found
                throw new InvalidOperationException("No data found for TUOITOIDA in THAMSO.");
            }
        }

        internal int LayTienPhatTraTreMoiNgay()
        {
            DataTable dtTienPhatTraTreMoiNgay = helper.ExecuteQuery("SELECT TienPhatTraTreMoiNgay FROM THAMSO");
            if (dtTienPhatTraTreMoiNgay != null && dtTienPhatTraTreMoiNgay.Rows.Count > 0)
            {
                return Convert.ToInt32(dtTienPhatTraTreMoiNgay.Rows[0]["TienPhatTraTreMoiNgay"]);
            }
            else
            {
                // Return a default value or throw an exception if no data is found
                throw new InvalidOperationException("No data found for TienPhatTraTreMoiNgay in THAMSO.");
            }
        }
        internal int LayGiaTriThe()
        {
            DataTable dtLoaiDocGia = helper.ExecuteQuery("SELECT GIATRITHE FROM THAMSO");
            if (dtLoaiDocGia != null && dtLoaiDocGia.Rows.Count > 0)
            {
                return Convert.ToInt32(dtLoaiDocGia.Rows[0]["GIATRITHE"]);
            }
            else
            {
                // Return a default value or throw an exception if no data is found
                throw new InvalidOperationException("No data found for GIATRITHE in THAMSO.");
            }
        }

        internal int LayThoiGianNhapSachToiDa()
        {
            DataTable dtLoaiDocGia = helper.ExecuteQuery("SELECT THOIGIANNHAPSACHTOIDA FROM THAMSO");
            if (dtLoaiDocGia != null && dtLoaiDocGia.Rows.Count > 0)
            {
                return Convert.ToInt32(dtLoaiDocGia.Rows[0]["THOIGIANNHAPSACHTOIDA"]);
            }
            else
            {
                // Return a default value or throw an exception if no data is found
                throw new InvalidOperationException("No data found for THOIGIANNHAPSACHTOIDA in THAMSO.");
            }
        }

        internal int LayHanMuonSachToiDa()
        {
            DataTable dtHamMuonSachToiDa = helper.ExecuteQuery("SELECT HanMuonSachToiDa FROM THAMSO");
            if (dtHamMuonSachToiDa != null && dtHamMuonSachToiDa.Rows.Count > 0)
            {
                return Convert.ToInt32(dtHamMuonSachToiDa.Rows[0]["HanMuonSachToiDa"]);
            }
            else
            {
                // Return a default value or throw an exception if no data is found
                throw new InvalidOperationException("No data found for HanMuonSachToiDa in THAMSO.");
            }
        }

        internal int LayThoiGianMuonSachTheoQuyDinh()
        {
            DataTable dtThoiGianMuonSachTheoQuyDinh = helper.ExecuteQuery("SELECT ThoiGianMuonSachTheoQuyDinh FROM THAMSO");
            if (dtThoiGianMuonSachTheoQuyDinh != null && dtThoiGianMuonSachTheoQuyDinh.Rows.Count > 0)
            {
                return Convert.ToInt32(dtThoiGianMuonSachTheoQuyDinh.Rows[0]["ThoiGianMuonSachTheoQuyDinh"]);
            }
            else
            {
                // Return a default value or throw an exception if no data is found
                throw new InvalidOperationException("No data found for ThoiGianMuonSachTheoQuyDinh in THAMSO.");
            }
        }

        internal int LaySachMuonToiDaTheoThoiGianQuyDinh()
        {
            DataTable dtSachMuonToiDaTheoThoiGianQuyDinh = helper.ExecuteQuery("SELECT SachMuonToiDaTheoThoiGianQuyDinh FROM THAMSO");
            if (dtSachMuonToiDaTheoThoiGianQuyDinh != null && dtSachMuonToiDaTheoThoiGianQuyDinh.Rows.Count > 0)
            {
                return Convert.ToInt32(dtSachMuonToiDaTheoThoiGianQuyDinh.Rows[0]["SachMuonToiDaTheoThoiGianQuyDinh"]);
            }
            else
            {
                // Return a default value or throw an exception if no data is found
                throw new InvalidOperationException("No data found for SachMuonToiDaTheoThoiGianQuyDinh in THAMSO.");
            }
        }

        internal bool CapNhatThamSo(
            int tuoiToiThieu,
            int tuoiToiDa,
            int giaTriThe,
            int thoiGianNhapSachToiDa,
            int hanMuonSachToiDa,
            int sachMuonToiDaTheoThoiGianQuyDinh,
            int thoiGianMuonSachTheoQuyDinh,
            int tienPhatTraTreMoiNgay
        )
        {
            string query = @"
            UPDATE THAMSO SET 
                TUOITOITHIEU = @TuoiToiThieu, 
                TUOITOIDA = @TuoiToiDa, 
                GIATRITHE = @GiaTriThe, 
                THOIGIANNHAPSACHTOIDA = @ThoiGianNhapSachToiDa, 
                HanMuonSachToiDa = @HanMuonSachToiDa, 
                SachMuonToiDaTheoThoiGianQuyDinh = @SachMuonToiDaTheoThoiGianQuyDinh, 
                ThoiGianMuonSachTheoQuyDinh = @ThoiGianMuonSachTheoQuyDinh, 
                TienPhatTraTreMoiNgay = @TienPhatTraTreMoiNgay";
            using (var conn = helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TuoiToiThieu", tuoiToiThieu);
                    cmd.Parameters.AddWithValue("@TuoiToiDa", tuoiToiDa);
                    cmd.Parameters.AddWithValue("@GiaTriThe", giaTriThe);
                    cmd.Parameters.AddWithValue("@ThoiGianNhapSachToiDa", thoiGianNhapSachToiDa);
                    cmd.Parameters.AddWithValue("@HanMuonSachToiDa", hanMuonSachToiDa);
                    cmd.Parameters.AddWithValue("@SachMuonToiDaTheoThoiGianQuyDinh", sachMuonToiDaTheoThoiGianQuyDinh);
                    cmd.Parameters.AddWithValue("@ThoiGianMuonSachTheoQuyDinh", thoiGianMuonSachTheoQuyDinh);
                    cmd.Parameters.AddWithValue("@TienPhatTraTreMoiNgay", tienPhatTraTreMoiNgay);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    // Handle exception (log it, rethrow it, etc.)
                    throw new Exception("Error updating THAMSO: " + ex.Message);
                }
            }
        }
    }
}
